using Phase2.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase2
{
    public partial class TruongPhong : Form
    {
        bool sidebarExpand;
        bool taskCollapsed;
        bool profileCollapsed;
        public TruongPhong()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            ProfileTimer.Start();
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TruongPhong truongphong = new TruongPhong();
            truongphong.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            TaskTimer.Start();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            QLTrucTiep_DSPhongBan ql = new QLTrucTiep_DSPhongBan();
            addUserControl(ql);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            QLTrucTiep_DSDeAn ql = new QLTrucTiep_DSDeAn();
            addUserControl(ql);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            QLTrucTiep_ThongTinNV ql = new QLTrucTiep_ThongTinNV();
            addUserControl(ql);
        }

        private void button15_Click_2(object sender, EventArgs e)
        {
            QLTrucTiep_Task ql = new QLTrucTiep_Task();
            addUserControl(ql);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TruongPhong_DSNV_HieuChinh ql = new TruongPhong_DSNV_HieuChinh();
            addUserControl(ql);
        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void TaskTimer_Tick_1(object sender, EventArgs e)
        {
            if (taskCollapsed)
            {
                TaskContainer.Height += 10;
                if (TaskContainer.Height == TaskContainer.MaximumSize.Height)
                {
                    taskCollapsed = false;
                    TaskTimer.Stop();
                }
            }
            else
            {
                TaskContainer.Height -= 10;
                if (TaskContainer.Height == TaskContainer.MinimumSize.Height)
                {
                    taskCollapsed = true;
                    TaskTimer.Stop();
                }
            }
        }

        private void ProfileTimer_Tick(object sender, EventArgs e)
        {
            if (profileCollapsed)
            {
                panelThongTin.Height += 10;
                if (panelThongTin.Height == panelThongTin.MaximumSize.Height)
                {
                    profileCollapsed = false;
                    ProfileTimer.Stop();
                }
            }
            else
            {
                panelThongTin.Height -= 10;
                if (panelThongTin.Height == panelThongTin.MinimumSize.Height)
                {
                    profileCollapsed = true;
                    ProfileTimer.Stop();
                }
            }
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            XemProfile ql = new XemProfile();
            addUserControl(ql);
        }
    }
}
