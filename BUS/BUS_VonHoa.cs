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
    public class BUS_VonHoa
    {
        private static BUS_VonHoa instance;

        public static BUS_VonHoa Instance
        {
            get { if (instance == null) instance = new BUS_VonHoa(); return BUS_VonHoa.instance; }

            private set { BUS_VonHoa.instance = value; }
        }

        public bool DongBoVonHoa()
        {
            try
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                var options = new ChromeOptions();
                options.AddArgument("window-position=-32000,-32000");
                IWebDriver driver = new ChromeDriver(service, options);

                driver.Navigate().GoToUrl("https://www.hnx.vn/cophieu-etfs/chi-tiet-chung-khoan-ny-AAV.html?_des_tab=2");

                DataTable dt = new DataTable("VonHoa");

                dt.Columns.Add("NgayGiaoDich");
                dt.Columns.Add("MaCk");
                dt.Columns.Add("GiaDong");
                dt.Columns.Add("GiaTriVonHoa");
                dt.Columns.Add("PhanTramThiTruong");

                Thread.Sleep(1000);

                IList<IWebElement> links = driver.FindElements(By.XPath("//*[@id=\"divSearchContentArticle\"]/ul/li[2]/div/div/div[2]/ul/li/label/input"));
                string query = "exec dbo.VonHoaProc_getByMaCk @mack , @ngayGiaoDich";
                try
                {
                    for (int i = 0; i < links.Count; i++)
                    {
                        string MaCk = links[i].GetAttribute("value");
                        var url = "https://www.hnx.vn/cophieu-etfs/chi-tiet-chung-khoan-ny-" + links[i].GetAttribute("value").ToLower() + ".html?_ces_tab=4";
                        driver.Navigate().GoToUrl(url);
                        Thread.Sleep(1000);

                        Console.WriteLine(MaCk);
                        int x = 2;

                        while (true)
                        {
                            try
                            {
                                driver.FindElement(By.XPath("//*[@id=\"VonHoadivNumberRecordOnPage\"]/option[5]")).Click();
                                Thread.Sleep(500);

                                IList<IWebElement> listtr = driver.FindElements(By.XPath("//*[@id=\"VonHoa_tableDatas\"]/tbody/tr"));
                                Thread.Sleep(500);

                                for (int j = 1; j <= listtr.Count; j++)
                                {
                                    IList<IWebElement> listCol = driver.FindElements(By.XPath($"//*[@id=\"VonHoa_tableDatas\"]/tbody/tr[{j}]/td"));
                                    DateTime NgayGiaoDich = DateTime.ParseExact(listCol[0].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                                    if (CountGD(query, MaCk, NgayGiaoDich.ToString()) == false)
                                    {
                                        double.TryParse(listCol[1].Text.Replace(",", "."), out double GiaDong);
                                        double.TryParse(listCol[2].Text.Replace(",", "."), out double GiaTriVonHoa);
                                        double.TryParse(listCol[3].Text.Replace(",", "."), out double PhanTramThiTruong);

                                        dt.Rows.Add(NgayGiaoDich, MaCk, GiaDong, Convert.ToDouble(listCol[2].Text.Replace(".", "")), PhanTramThiTruong);
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

        public void loadCVonHoa(DataGridView data)
        {
            data.DataSource = DAL_VonHoa.Instance.getListVonHoa();
        }

        public bool UpdateVH(DateTime ngayGiaoDich, string maCK, double GiaDong, double VonHoa, double ThiTruong)
        {
            DTO_VonHoa VH = new DTO_VonHoa(ngayGiaoDich, maCK, GiaDong, VonHoa, ThiTruong);

            return DAL_VonHoa.Instance.update(VH);
        }

        public bool deleteVH(int id)
        {
            return DAL_VonHoa.Instance.deleteData(id);
        }

        public bool AddVH(DateTime ngayGiaoDich, string maCK, double GiaDong, double VonHoa, double ThiTruong)
        {
            DTO_VonHoa VH = new DTO_VonHoa(ngayGiaoDich, maCK, GiaDong, VonHoa, ThiTruong);

            return DAL_VonHoa.Instance.adddata(VH);
        }

        public DataTable findDataVH(string MACK, DateTime from, DateTime to)
        {
            return DAL_VonHoa.Instance.findData(MACK, from, to);
        }
    }
}