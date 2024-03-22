using DAL;
using DTO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_CungCau
    {
        private static BUS_CungCau instance;

        public static BUS_CungCau Instance
        {
            get { if (instance == null) instance = new BUS_CungCau(); return BUS_CungCau.instance; }

            private set { BUS_CungCau.instance = value; }
        }

        public bool DongBoCungCau()
        {
            try
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                var options = new ChromeOptions();
                options.AddArgument("window-position=-32000,-32000");

                IWebDriver driver = new ChromeDriver(service, options);
                driver.Navigate().GoToUrl("https://www.hnx.vn/cophieu-etfs/chi-tiet-chung-khoan-ny-AAV.html?_des_tab=2");

                DataTable dt = new DataTable("ThongKeCungCau");

                dt.Columns.Add("NgayGiaoDich");
                dt.Columns.Add("MaCk");
                dt.Columns.Add("GiaDong");
                dt.Columns.Add("SoLenhMua");
                dt.Columns.Add("KhoiLuongMua");
                dt.Columns.Add("SoLenhBan");
                dt.Columns.Add("KhoiLuongban");
                dt.Columns.Add("DuMua");
                dt.Columns.Add("DuBan");
                dt.Columns.Add("KhoiLuongGD");
                dt.Columns.Add("GiaTriGD");

                Thread.Sleep(1000);

                IList<IWebElement> links = driver.FindElements(By.XPath("//*[@id=\"divSearchContentArticle\"]/ul/li[2]/div/div/div[2]/ul/li/label/input"));
                string query = "exec dbo.CungCauProc_getByMaCk @mack , @ngayGiaoDich";
                try
                {
                    for (int i = 0; i < links.Count; i++)
                    {
                        string MaCk = links[i].GetAttribute("value");
                        var url = "https://www.hnx.vn/cophieu-etfs/chi-tiet-chung-khoan-ny-" + links[i].GetAttribute("value").ToLower() + ".html?_ces_tab=3";
                        driver.Navigate().GoToUrl(url);
                        Thread.Sleep(1000);
                        int x = 2;

                        while (true)
                        {
                            try
                            {
                                driver.FindElement(By.XPath("//*[@id=\"TK_CungCaudivNumberRecordOnPage\"]/option[5]")).Click();
                                Thread.Sleep(500);

                                IList<IWebElement> listtr = driver.FindElements(By.XPath("//*[@id=\"TK_CungCau_tableDatas\"]/tbody/tr"));
                                Thread.Sleep(500);
                                for (int j = 1; j <= listtr.Count; j++)
                                {
                                    IList<IWebElement> listCol = driver.FindElements(By.XPath($"//*[@id=\"TK_CungCau_tableDatas\"]/tbody/tr[{j}]/td"));
                                    Console.WriteLine(listCol[0].Text);
                                    Console.WriteLine(listCol[9].Text);
                                    DateTime NgayGiaoDich = DateTime.ParseExact(listCol[0].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                                    if (CountGD(query, MaCk, NgayGiaoDich.ToString()) == false)
                                    {
                                        double.TryParse(listCol[1].Text.Replace(",", "."), out double GiaDong);
                                        double.TryParse(listCol[2].Text.Replace(",", "."), out double SoLenhMua);
                                        double.TryParse(listCol[3].Text.Replace(",", "."), out double KhoiLuongMua);
                                        double.TryParse(listCol[4].Text.Replace(",", "."), out double SoLenhBan);
                                        double.TryParse(listCol[5].Text.Replace(",", "."), out double KhoiLuongBan);
                                        double.TryParse(listCol[6].Text.Replace(",", "."), out double DuMu);
                                        double.TryParse(listCol[7].Text.Replace(",", "."), out double DuBan);
                                        double.TryParse(listCol[8].Text.Replace(",", "."), out double KhoiLuongGD);

                                        dt.Rows.Add(NgayGiaoDich, MaCk, GiaDong, SoLenhMua, KhoiLuongMua, SoLenhBan, KhoiLuongBan, DuMu, DuBan, KhoiLuongGD, Convert.ToDouble(listCol[9].Text.Replace(".", "")));
                                    }
                                }
                                Thread.Sleep(500);

                                driver.FindElement(By.XPath($"//*[@id=\"{x}\"]")).Click();
                                x++;
                            }
                            catch (Exception ex)
                            {
                                break;
                            }
                        }

                        driver.Navigate().Back();
                    }
                }
                catch (NoSuchWindowException ex)
                {
                    return true;
                }
                DataProvider.Instance.insertDB(dt);
                driver.Quit();
            }
            catch (WebDriverException ex)
            {
                return true;
            }
            return false;
        }

        public bool CountGD(string query, string mack, string ngayGd)
        {
            var i = DataProvider.Instance.Executequery(query, new object[] { mack, ngayGd });
            if (i.Rows.Count > 0) { return true; }
            return false;
        }

        public void loadCungCau(DataGridView data)
        {
            data.DataSource = DAL_CungCau.Instance.getListCungCau();
        }

        public bool UpdateCC(DateTime ngayGiaoDich, string maCK, double GiaDong, double LenhMua, double LuongMua, double LenhBan, double LuongBan, double DuMua, double DuBan, double KhoiLuongGD, double GiaTriGD)
        {
            DTO_CungCau CC = new DTO_CungCau(ngayGiaoDich, maCK, GiaDong, LenhMua, LuongMua, LenhBan, LuongBan, DuMua, DuBan, KhoiLuongGD, GiaTriGD);

            return DAL_CungCau.Instance.update(CC);
        }

        public bool deleteCC(int id)
        {
            return DAL_CungCau.Instance.deleteData(id);
        }

        public bool AddCC(DateTime ngayGiaoDich, string maCK, double GiaDong, double LenhMua, double LuongMua, double LenhBan, double LuongBan, double DuMua, double DuBan, double KhoiLuongGD, double GiaTriGD)
        {
            DTO_CungCau CC = new DTO_CungCau(ngayGiaoDich, maCK, GiaDong, LenhMua, LuongMua, LenhBan, LuongBan, DuMua, DuBan, KhoiLuongGD, GiaTriGD);

            return DAL_CungCau.Instance.adddata(CC);
        }

        public DataTable findDataCC(string MACK, DateTime from, DateTime to)
        {
            return DAL_CungCau.Instance.findData(MACK, from, to);
        }
    }
}