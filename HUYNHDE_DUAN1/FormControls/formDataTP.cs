using BUS;
using HUYNHDE_DUAN1.formShowClickGrid;
using HUYNHDE_DUAN1.FormUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HUYNHDE_DUAN1
{
    public partial class formDataTP : Form
    {
        private formMessage f = new formMessage();

        public formDataTP()
        {
            InitializeComponent();
            fromdate.Value = DateTime.Today;
            todate.Value = DateTime.Today;
            getdataCB();
            dataGridGDTP.ForeColor = System.Drawing.Color.Black;
        }

        public DataTable export()
        {
            DataTable _datatable = dataGridGDTP.DataSource as DataTable;

            return _datatable;
        }

        private void panel1_Click(object sender, System.EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formChildDataTP tp = new formChildDataTP(this);
            tp.ShowDialog();
        }

        private void btnUpGrade_Click_1(object sender, EventArgs e)
        {
            Thread mess = new Thread(new ThreadStart(() =>
            {
                f.showMessage("Thông báo", "Đang cập nhật dữ liệu...", "icon_info.png", "Đóng");
            }));
            try
            {
                mess.Start();
                if (BUS_GiaoDichTraiPhieu.Instance.Update(fromdate.Text, todate.Text))
                {
                    mess.Abort();
                    f.showMessage("Thông báo", "Cập nhật dữ liệu thành công.", "icon_success.png", "Đóng");
                }
                else
                {
                    mess.Abort();
                    f.showMessage("Thông báo", "Đã lỗi trong quá trình cập nhật,\nvui lòng kiểm tra và thử lại!", "icon_error.png", "Đóng");
                }
            }
            catch (Exception ex)
            {
                mess.Abort();
                f.showMessage("Thông báo", "Đã lỗi trong quá trình cập nhật,\nvui lòng kiểm tra và thử lại!", "icon_error.png", "Đóng");
            }
            finally
            {
                loadform();
            }
        }

        private void formDataTP_Load(object sender, EventArgs e)
        {
            dataGridGDTP.DataSource = BUS_GiaoDichTraiPhieu.Instance.loadData();
            string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(formLoginGrogram.Email);

            if (Convert.ToBoolean(Vaitro) == false)
            {
                btnUpGrade.Visible = false;
                btnAdd.Visible = false;
            }
        }

        public void loadform()
        {
            formShowGDTP fr = new formShowGDTP(this);
            dataGridGDTP.DataSource = null;
            dataGridGDTP.DataSource = BUS_GiaoDichTraiPhieu.Instance.loadData();
        }

        private void dataGridGDTP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(formLoginGrogram.Email);

                if (Convert.ToBoolean(Vaitro) == true)
                {
                    List<string> binding = new List<string>();
                    for (int i = 0; i < dataGridGDTP.Columns.Count; i++)
                    {
                        if (i == 2)
                        {
                            string[] date = dataGridGDTP.CurrentRow.Cells[i].Value.ToString().Split('-');
                            string new_format = date[2] + "/" + date[1] + "/" + date[0];
                            binding.Add(new_format);
                            continue;
                        }
                        binding.Add(dataGridGDTP.CurrentRow.Cells[i].Value.ToString());
                    }
                    formShowGDTP show = new formShowGDTP(this);
                    show.showData(binding);
                }
            }
            catch { }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DateTime temp;
            if (fromdate.Value > todate.Value)
            {
                temp = fromdate.Value;
                fromdate.Value = todate.Value;
                todate.Value = temp;
            }
            dataGridGDTP.DataSource = BUS_GiaoDichTraiPhieu.Instance.findData(ma_CK.Text, fromdate.Value, todate.Value);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            fromdate.Value = DateTime.Today;
            todate.Value = DateTime.Today;
            loadform();
        }

        private void btnExports_Click(object sender, EventArgs e)
        {
            formExTP showFormMessageEx = new formExTP(this);
            showFormMessageEx.ShowDialog();
        }

        private void getdataCB()
        {
            cb_MACK.DataSource = BUS_GiaoDichTraiPhieu.Instance.cb_DATA();
            cb_MACK.DisplayMember = "Ma_CK";
            cb_MACK.ValueMember = "Ma_CK";
        }

        private void loadChart(string MCK)
        {
            DataTable dt = new DataTable();
            dt = BUS_GiaoDichTraiPhieu.Instance.DataChart(MCK);
            Chart_GDTP.DataSource = dt;

            string datemin = dt.Columns[1].ColumnName.ToString();

            string datemax = dt.Columns[dt.Columns.Count - 1].ColumnName.ToString();

            Chart_GDTP.Titles.Clear();
            Chart_GDTP.Titles.Add($"Biểu đồ dữ liệu so sánh dữ liệu của {MCK} từ ngày {datemin} đến ngày {datemax}");

            var objChart = Chart_GDTP.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            objChart.AxisX.Minimum = 0;
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            //clear
            Chart_GDTP.Series.Clear();
            //random color
            //loop rows to draw multi line chart c#
            for (int i = 1; i < dt.Rows.Count; i++)
            {
                Chart_GDTP.Series.Add(dt.Rows[i][0].ToString());
                if (i == 1)
                {
                    Chart_GDTP.Series[dt.Rows[i][0].ToString()].Color = Color.FromArgb(34, 185, 170);
                }
                else
                {
                    Chart_GDTP.Series[dt.Rows[i][0].ToString()].Color = Color.FromArgb(112, 59, 151);
                }
                Chart_GDTP.Series[dt.Rows[i][0].ToString()].Legend = "Legend1";
                Chart_GDTP.Series[dt.Rows[i][0].ToString()].ChartArea = "ChartArea1";
                Chart_GDTP.Series[dt.Rows[i][0].ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                //adding data
                for (int j = 1; j < dt.Columns.Count; j++)
                {
                    Chart_GDTP.Series[dt.Rows[i][0].ToString()].Points.AddXY(j, Convert.ToInt32(dt.Rows[i][j]));
                }
            }

            Chart_GDTP.Series.Add(dt.Rows[0][0].ToString());
            Chart_GDTP.Series[dt.Rows[0][0].ToString()].Color = Color.FromArgb(240, 98, 34);
            Chart_GDTP.Series[dt.Rows[0][0].ToString()].Legend = "Legend1";
            Chart_GDTP.Series[dt.Rows[0][0].ToString()].ChartArea = "ChartArea1";
            Chart_GDTP.Series[dt.Rows[0][0].ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            Chart_GDTP.Series[dt.Rows[0][0].ToString()].MarkerStyle = MarkerStyle.Circle;
            //adding data
            for (int j = 1; j < dt.Columns.Count; j++)
            {
                Chart_GDTP.Series[dt.Rows[0][0].ToString()].Points.AddXY(j, Convert.ToInt32(dt.Rows[0][j]));
            }
        }

        private void cb_MACK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string mack = cb_MACK.GetItemText(cb_MACK.SelectedItem);
            loadChart(mack);
        }

        private void saveChart_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            sfd.FileName = "Chart_GDTP.jpeg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Chart_GDTP.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
            }
        }
    }
}