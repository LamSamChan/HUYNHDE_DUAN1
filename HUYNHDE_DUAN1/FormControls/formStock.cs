using BUS;
using HUYNHDE_DUAN1.formShowClickGrid;
using HUYNHDE_DUAN1.FormUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1
{
    public partial class formStock : Form
    {
        public formStock()
        {
            InitializeComponent();
        }
        //Methods
        public void LoadGrid()
        {

            GridViewHoSo.DataSource = BUS_HoSoCuPhieu.Instance.LoadGriHoSo();
        }

        public DataTable export()
        {
            DataTable _datatable = GridViewHoSo.DataSource as DataTable;

            return _datatable;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            formChildStock ct = new formChildStock(this);
            ct.ShowDialog();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }




        private void formStock_Load(object sender, EventArgs e)
        {
            LoadGrid();
            // textBox1.DataBindings.Add(new Binding("Text", GridViewHoSo.DataSource, "MaCK"));
            GridViewHoSo.ForeColor = Color.Black;
            string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(formLoginGrogram.Email);

            if (Convert.ToBoolean(Vaitro) == false)
            {
                btnAdd.Visible= false;
                btnUpGrade.Visible= false;
            }



        }

        private void GridViewHoSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formShowStock show = new formShowStock(this);
            try
            {
                string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(formLoginGrogram.Email);

                if (Convert.ToBoolean(Vaitro) == true)
                {
                    try
                    {
                        if (GridViewHoSo.Rows[e.RowIndex].Cells[9].Selected == true)
                        {
                            show.Close();
                            System.Diagnostics.Process.Start(GridViewHoSo.Rows[e.RowIndex].Cells[16].Value.ToString());
                        }
                        else
                        {
                            List<string> binding = new List<string>();
                            for (int i = 0; i < GridViewHoSo.Columns.Count; i++)
                            {
                                binding.Add(GridViewHoSo.CurrentRow.Cells[i].Value.ToString());
                            }

                            show.bindindDataGrid(binding);
                            show.ShowDialog();
                        }
                    }
                    catch { }

                }
            }
            catch { }
        }

        private void btnUpGrade_Click(object sender, EventArgs e)
        {
            BUS_HoSoCuPhieu.Instance.upGradeHoSo();
            LoadGrid();
        }

        private void btnExports_Click(object sender, EventArgs e)
        {
            formExFileStock show = new formExFileStock(this);
            show.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            GridViewHoSo.DataSource = BUS_HoSoCuPhieu.Instance.FindListHoSo(txtFind.Text, txtFind.Text);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadGrid();
            txtFind.Text = "";
        }
    }
}
