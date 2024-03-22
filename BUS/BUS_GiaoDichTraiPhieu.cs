using Aspose.Cells;
using DAL;
using DTO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;

namespace BUS
{
    public class BUS_GiaoDichTraiPhieu
    {
        private static BUS_GiaoDichTraiPhieu instance;

        public static BUS_GiaoDichTraiPhieu Instance
        {
            get { if (instance == null) instance = new BUS_GiaoDichTraiPhieu(); return BUS_GiaoDichTraiPhieu.instance; }

            private set { BUS_GiaoDichTraiPhieu.instance = value; }
        }

        public DataTable loadData()
        {
            return DAL_GiaoDichTraiPhieu.Instance.loadData();
        }

        public bool editData(int ID, int STT, DateTime Ngay_GD, string Ma_CK, float Gia_DC, float TKL_GDKL_LoChan, float TGT_GDKL_LoChan, float TKL_GDKL_LoLe,
            float TGT_GDKL_LoLe, float Tong_KLGD_TT_LoChan, float Tong_GTGD_TT_LoChan, float Tong_KLGD_TT_LoLe, float Tong_GTGD_TT_LoLe)
        {
            return DAL_GiaoDichTraiPhieu.Instance.editData(ID, STT, Ngay_GD, Ma_CK, Gia_DC, TKL_GDKL_LoChan, TGT_GDKL_LoChan,
            TKL_GDKL_LoLe, TGT_GDKL_LoLe, Tong_KLGD_TT_LoChan, Tong_GTGD_TT_LoChan, Tong_KLGD_TT_LoLe, Tong_GTGD_TT_LoLe);
        }

        public bool deleteData(int ID)
        {
            return DAL.DAL_GiaoDichTraiPhieu.Instance.deleteData(ID);
        }

        public bool addData(int STT, DateTime Ngay_GD, string Ma_CK, float Gia_DC, float TKL_GDKL_LoChan, float TGT_GDKL_LoChan, float TKL_GDKL_LoLe,
            float TGT_GDKL_LoLe, float Tong_KLGD_TT_LoChan, float Tong_GTGD_TT_LoChan, float Tong_KLGD_TT_LoLe, float Tong_GTGD_TT_LoLe)
        {
            return DAL_GiaoDichTraiPhieu.Instance.addData(STT, Ngay_GD, Ma_CK, Gia_DC, TKL_GDKL_LoChan, TGT_GDKL_LoChan,
            TKL_GDKL_LoLe, TGT_GDKL_LoLe, Tong_KLGD_TT_LoChan, Tong_GTGD_TT_LoChan, Tong_KLGD_TT_LoLe, Tong_GTGD_TT_LoLe);
        }

        public DataTable findData(string MACK, DateTime from, DateTime to)
        {
            return DAL_GiaoDichTraiPhieu.Instance.findData(MACK, from, to);
        }

        public DataTable cb_DATA()
        {
            return DAL_GiaoDichTraiPhieu.Instance.Data_CB();
        }

        public DataTable DataChart(string MaCK)
        {
            DataTable date = new DataTable();
            date = DAL_GiaoDichTraiPhieu.Instance.DataChart_DATE(MaCK);
            DataTable mack = new DataTable();
            mack = DAL_GiaoDichTraiPhieu.Instance.DataChart_MACK();
            DataTable data = new DataTable();
            data = DAL_GiaoDichTraiPhieu.Instance.DataChart(MaCK);
            DataTable finish = new DataTable();
            if (MaCK != "")
            {
                finish.Columns.Add("MACK");

                for (int i = 0; i < date.Rows.Count; i++)
                {
                    finish.Columns.Add($"{date.Rows[i][0]}");
                }

                //finish.Rows[i][j] = value;

                for (int i = 0; i < mack.Rows.Count; i++)
                {
                    DataRow _mack = finish.NewRow();
                    _mack["MACK"] = mack.Rows[i][0];
                    finish.Rows.Add(_mack);
                }
                int c = 0;
                int cMax = data.Columns.Count;
                int r = 0;
                int rMax = data.Rows.Count;
                for (int i = 0; i < finish.Rows.Count; i++)
                {
                    for (int j = 1; j < finish.Columns.Count; j++)
                    {
                        finish.Rows[i][j] = data.Rows[r][c];
                        r++;
                         
                    }
                    r = 0;
                    c++;
                }
            }

            return finish;
        }

        public bool Update(string fromd, string tod)
        {
            DTO_GiaoDichTraiPhieu GDTP = new DTO_GiaoDichTraiPhieu();
            char[] charsToTrim = { '1', '.', ' ' };

            string folderName = "DATA_TPDN";

            var chromeOptions = new ChromeOptions();
            var CurrentDirectory = Directory.GetCurrentDirectory();
            var downloadDirectory = $"{CurrentDirectory}" + @"\DATA_TPDN";
            string pathfile = $"{downloadDirectory}" + @"\remember_file.txt";

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }

            if (!System.IO.File.Exists(pathfile))
            {
                System.IO.File.Create(pathfile).Close();
            }
            chromeOptions.AddUserProfilePreference("download.default_directory", downloadDirectory);
            chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            chromeOptions.AddArgument("window-position=-32000,-32000");
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            //read file .txt
            var logFile = System.IO.File.ReadAllLines(pathfile);
            var xlsFileExist = new List<string>(logFile);

            IWebDriver chromeDriver = new ChromeDriver(service, chromeOptions);
            try
            {
                
                chromeDriver.Url = "https://www.hnx.vn/vi-vn/thong-tin-cong-bo-ny-hnx.html";
                chromeDriver.Navigate();
                chromeDriver.Manage().Window.Maximize();
                

                Thread.Sleep(2000);
                
                var from = chromeDriver.FindElement(By.XPath("//*[@id=\"txtTuNgay\"]"));
                //from.SendKeys(Convert.ToDateTime(fromd).ToString("dd/MM/yyyy"));
                from.SendKeys(fromd.ToString());

                var to = chromeDriver.FindElement(By.XPath("//*[@id=\"txtDenNgay\"]"));
                //to.SendKeys(Convert.ToDateTime(tod).ToString("dd/MM/yyyy"));
                to.SendKeys(tod.ToString());

                var title = chromeDriver.FindElement(By.XPath("//*[@id=\"txtTieuDeTin\"]"));
                title.SendKeys("Kết quả giao dịch Trái phiếu doanh nghiệp ngày");

                Thread.Sleep(1000);
                var button_find = chromeDriver.FindElement(By.XPath("//*[@id=\"btn_searchL\"]"));
                button_find.Click();

                //Thread.Sleep(1000);
                //var select_show_more = chromeDriver.FindElement(By.XPath("//*[@id=\"divNumberRecordOnPage\"]"));
                //select_show_more.Click();

                Thread.Sleep(1000);
                
            }
            catch (Exception)
            {
                return false;
            }

            while (true)
            {
                try
                {
                    var select = chromeDriver.FindElement(By.XPath("//*[@id=\"divNumberRecordOnPage\"]/option[5]"));
                    select.Click();
                    Thread.Sleep(500);
                    WebClient download = new WebClient();
                    IList<IWebElement> stt = chromeDriver.FindElements(By.XPath("//*[@id=\"_tableDatas\"]/tbody/tr"));
                    Thread.Sleep(500);
                    for (int i = 1; i <= stt.Count; i++)
                    {
                        bool check_filename = false;

                        Thread.Sleep(500);
                        var link_text = chromeDriver.FindElement(By.CssSelector($"#_tableDatas > tbody > tr:nth-child({i}) > td.tdLeftAlign > a")).Text.Trim();
                        Thread.Sleep(100);
                        if (link_text.Contains("Kết quả giao dịch Trái phiếu doanh nghiệp ngày"))
                        {
                            chromeDriver.ExecuteJavaScript($"var content = document.querySelector(\"#_tableDatas > tbody > tr:nth-child({i}) > td.tdLeftAlign > a\").click()");
                        }
                        else
                        {
                            break;
                        }


                            Thread.Sleep(3000);
                            var file_text = chromeDriver.FindElement(By.XPath("//*[@id=\"divViewDetailArticles\"]/div[2]/div[3]/p/a")).Text.ToUpper().Trim(charsToTrim);
                            var file_link = chromeDriver.FindElement(By.XPath("//*[@id=\"divViewDetailArticles\"]/div[2]/div[3]/p/a")).GetAttribute("href");

                            //check filename
                            for (int j = 0; j < xlsFileExist.Count; j++)
                            {
                                if (xlsFileExist[j].CompareTo(file_text) == 0)
                                {
                                    check_filename = true;
                                    break;
                                }
                            }

                            if (check_filename == false)
                            {
                                //save filename
                                System.IO.File.AppendAllText(pathfile, file_text + Environment.NewLine);
                                chromeDriver.ExecuteJavaScript("var content = document.querySelector(\"#divViewDetailArticles > div.divContentArticlesDetail > div.divLstFileAttach > p > a\").click()");
                                download.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                                download.DownloadFile(file_link, file_text);
                                Thread.Sleep(1000);

                                FileInfo newestFile = GetNewestFile(new DirectoryInfo(downloadDirectory));
                                DeleteRows(newestFile.ToString().Trim(), 6);
                                EditCells(newestFile.ToString().Trim());
                                DAL_GiaoDichTraiPhieu.Instance.ImportExcelInDB(newestFile.ToString().Trim());
                                System.IO.File.Delete($"{downloadDirectory}" + @"\" + $"{file_text}");
                            }
                            var esc = chromeDriver.FindElement(By.XPath("//*[@id=\"divViewDetailArticles\"]/div[5]/input"));
                            esc.Click();
                        }

                        chromeDriver.FindElement(By.XPath($"//*[@id=\"next\"]")).Click();
                     
                }
                catch (Exception)
                {
                    chromeDriver.Quit();
                    return true;
                }
            }
        }

        public static FileInfo GetNewestFile(DirectoryInfo directory)
        {
            return directory.GetFiles()
                .Union(directory.GetDirectories().Select(d => GetNewestFile(d)))
                .OrderByDescending(f => (f == null ? DateTime.MinValue : f.LastWriteTime))
                .FirstOrDefault();
        }

        private void DeleteRows(string filename, int rows)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            var path = $"{CurrentDirectory}" + @"\DATA_TPDN\" + $"{filename}";
            //Apose.Cell

            Workbook workbook = new Workbook(path);
            Worksheet worksheet = workbook.Worksheets[0];
            //delete rows
            worksheet.Cells.DeleteRows(0, rows);
            workbook.Save(path);
        }

        private void EditCells(string filename)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            var path = $"{CurrentDirectory}" + @"\DATA_TPDN\" + $"{filename}";
            //Apose.Cell

            Workbook workbook = new Workbook(path);
            Worksheet worksheet = workbook.Worksheets[0];

            worksheet.Cells["B1"].PutValue("Ngay_GD");
            worksheet.Cells["C1"].PutValue("Ma_CK");
            worksheet.Cells["D1"].PutValue("Gia_DC");
            worksheet.Cells["E1"].PutValue("TKL_GDKL_LoChan");
            worksheet.Cells["F1"].PutValue("TGT_GDKL_LoChan");
            worksheet.Cells["G1"].PutValue("TKL_GDKL_LoLe");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
            worksheet.Cells["H1"].PutValue("TGT_GDKL_LoLe");
            worksheet.Cells["I1"].PutValue("Tong_KLGD_TT_LoChan");
            worksheet.Cells["J1"].PutValue("Tong_GTGD_TT_LoChan");
            worksheet.Cells["K1"].PutValue("Tong_KLGD_TT_LoLe");
            worksheet.Cells["L1"].PutValue("Tong_GTGD_TT_LoLe");

            string[] date = worksheet.Cells[1, 1].Value.ToString().Split('/');
            string new_format = date[2] + "/" + date[1] + "/" + date[0];

            for (int r = 1; r <= worksheet.Cells.Rows.Count - 2; r++)
            {
                worksheet.Cells[r, 1].PutValue(Convert.ToDateTime(new_format).ToShortDateString());
            }

            workbook.Save(path);
        }
    }
}