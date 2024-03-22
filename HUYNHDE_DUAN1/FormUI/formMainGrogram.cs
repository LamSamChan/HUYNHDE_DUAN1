using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static HUYNHDE_DUAN1.formMessage;

namespace HUYNHDE_DUAN1
{
    public partial class FormMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form ChildFormCurrent;

        public FormMain()
        {
            InitializeComponent();
           
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //opacity
            panelOpacity.BackColor = Color.FromArgb(100, Color.FromArgb(51, 51, 51));
            // Display left button
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 100);
            pnControlButtons.Controls.Add(leftBorderBtn);


            ///


        }

        private void formMainGrogram_Load(object sender, EventArgs e)
        {
            logoDisplay.Image = Image.FromFile("../../img/LogoTeamDisplay.png");
            pcLogoHome.Image = Image.FromFile("../../img/LogoTeamHome.jpg");
            TimerLoad.Start();
        }
        #region MoveDownForm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelLinearGradient2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

                if (this.WindowState == FormWindowState.Normal)
                {
                    btnMaximized.Text = "☐";
                }
            }
        }

        #endregion


        private struct RGBColors
        {
            public static Color color1 = Color.White;

            //public static Color color2 = Color.FromArgb(39, 80, 104);
            //public static Color color3 = Color.FromArgb(39, 80, 104);
            //public static Color color4 = Color.FromArgb(39, 80, 104);
        }

        private void ActionButton(object btnsender, Color color)
        {

            DisableBtn();
            if (btnsender != null)
            {
                DisableBtn();
                #region
                currentBtn = (IconButton)btnsender;
                currentBtn.BackColor = Color.FromArgb(47, 167, 204);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // left border btn
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon HomeForm
                fillIconButton.IconChar = currentBtn.IconChar;
                fillIconButton.IconColor = Color.FromArgb(106, 130, 251);
                #endregion



            }
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(36, 198, 220);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void OppenChildForm(Form childForm)
        {
            if (ChildFormCurrent != null)
            {
                // chỉ mở form con khi  icon home có hiện icon form con
                ChildFormCurrent.Close();
            }
            ChildFormCurrent = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnFillChildForms.Controls.Add(childForm);
            pnFillChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }

        private void ResetForm()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            fillIconButton.IconChar = IconChar.HomeUser;
            fillIconButton.IconColor = Color.FromArgb(106, 130, 251);
            label1.Text = "Home";
        }



        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour <= 12)
            {
                lbTime.Text = DateTime.Now.ToString("hh:mm:ss") + ("_AM");
                lbCongra.Text = "Mỗi buổi sáng mang lại niềm hi vọng và những giấc mơ mới.\n" +
                                         "Chúc em ngày mới thành công! Chào buổi sáng";
            }
            else if (DateTime.Now.Hour >= 13 && DateTime.Now.Hour <= 18)
            {
                lbTime.Text = DateTime.Now.ToString("hh:mm:ss") + ("_PM");
                lbCongra.Text = "Ở đâu đó ngoài kia ước mơ thành hiện thực,\n" +
                                         "Chỉ cần cố gắng hết sức là được.\n" +
                                         "Một ngày làm việc cũng sắp kết thúc.\n" +
                                         "Thư giãn vào buổi chiều!";
            }
            else if (DateTime.Now.Hour >= 19 && DateTime.Now.Hour <= 23)
            {
                lbTime.Text = DateTime.Now.ToString("hh:mm:ss") + ("_PM");
                lbCongra.Text = "Nằm xuống giường, nhắm mắt vào, đi ngủ đi \n" +
                                          "Và mơ những giấc mơ ngọt ngào nhất bạn nhé.\n" +
                                          "Have a good night!";
            }
        }
       



        private void btnFormStock_Click_1(object sender, EventArgs e)
        {
            ActionButton(sender, RGBColors.color1);
            OppenChildForm(new formStock());
        }

        private void btnFormGDBDG_Click(object sender, EventArgs e)
        {
            ActionButton(sender, RGBColors.color1);
            OppenChildForm(new formGDBDG());
        }

        private void btnFormDataTP_Click(object sender, EventArgs e)
        {
            ActionButton(sender, RGBColors.color1);
            OppenChildForm(new formDataTP());
        }
        private void btnFormManagerEmplyee_Click_1(object sender, EventArgs e)
        {
            ActionButton(sender, RGBColors.color1);
            OppenChildForm(new FormManagerEmployee());
        }

        private void btnFormPersonalCurrent_Click_1(object sender, EventArgs e)
        {
            ActionButton(sender, RGBColors.color1);
            OppenChildForm(new formPersonnalCurrent());
        }



        private void pcLogoHome_Click(object sender, EventArgs e)
        {
            ChildFormCurrent.Close();
            label1.Text = "Home";
            ResetForm();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (btnMaximized.Text.ToString() == "❐")
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
                btnMaximized.Text = "☐";
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                btnMaximized.Text = "❐";
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            formMessage form = new formMessage();
            form.showMessage("Thông báo", "Bạn có thực sự muốn thoát chương trình?", "icon_info.png", "Thoát");
        }

       
    }
}
