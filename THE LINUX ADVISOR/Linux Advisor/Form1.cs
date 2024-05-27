using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linux_Advisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)  // btn_Education
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)    // gbx_Release
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)    // gbx_Interface
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)    // gbx_Purpose
        {

        }

        private void gbx_Experience_Enter(object sender, EventArgs e)
        {

        }

        private void gbx_DE_Enter(object sender, EventArgs e)
        {

        }

        private void gbx_WM_Enter(object sender, EventArgs e)
        {

        }

        private void pbx_GUI_Click(object sender, EventArgs e)
        {

        }

        private void gbx_DisplayServer_Enter(object sender, EventArgs e)
        {

        }

        private void gbx_Stability_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // btn_New
        {
            btn_NotAtAll.Visible = false;
            btn_Usable.Visible = false;
            btn_Server.Visible = false;
            btn_HomeServer.Visible = false;
            btn_WM.Visible = false;
            btn_Work.Visible = false;
            btn_RollingRelease.Visible = false;
            gbx_DisplayServer.Visible = false;
        }

        private void btn_Accustomed_Click(object sender, EventArgs e)
        {
            btn_Work.Visible = true;
            btn_NotAtAll.Visible = false;
            btn_Usable.Visible = false;
            btn_Server.Visible = false;
            btn_HomeServer.Visible = false;
            btn_WM.Visible = false;
            btn_RollingRelease.Visible = true;
            gbx_DisplayServer.Visible = false;
        }

        private void btn_Advanced_Click(object sender, EventArgs e)
        {
            btn_Usable.Visible = true;
            btn_HomeServer.Visible = true;
            btn_WM.Visible = true;
            btn_Server.Visible = false;
            btn_NotAtAll.Visible = false;
            btn_RollingRelease.Visible = true;
            gbx_DisplayServer.Visible = true;
            btn_Work.Visible = true;
        }

        private void btn_Expert_Click(object sender, EventArgs e)
        {
            btn_NotAtAll.Visible = true;
            btn_Usable.Visible = true;
            btn_Server.Visible = true;
            btn_HomeServer.Visible = true;
            btn_WM.Visible = true;
            btn_RollingRelease.Visible = true;
            gbx_DisplayServer.Visible = true;
            btn_Work.Visible = true;
        }

        private void btn_DailyDriver_Click(object sender, EventArgs e)
        {

        }

        private void btn_Work_Click(object sender, EventArgs e)
        {

        }

        private void btn_Gaming_Click(object sender, EventArgs e)
        {

        }

        private void btn_HomeServer_Click(object sender, EventArgs e)
        {

        }

        private void btn_Server_Click(object sender, EventArgs e)
        {

        }

        private void btn_SeasonalRelease_Click(object sender, EventArgs e)
        {

        }

        private void btn_RollingRelease_Click(object sender, EventArgs e)
        {

        }

        private void btn_Extremely_Click(object sender, EventArgs e)
        {

        }

        private void btn_Very_Click(object sender, EventArgs e)
        {

        }

        private void btn_Usable_Click(object sender, EventArgs e)
        {

        }

        private void btn_NotAtAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DE_Click(object sender, EventArgs e)
        {
            gbx_DE.Visible = true;
            gbx_WM.Visible = false;
        }

        private void btn_WM_Click(object sender, EventArgs e)
        {
            gbx_DE.Visible = false;
            gbx_WM.Visible = true;
        }

        private void btn_Gnome_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xfce_Click(object sender, EventArgs e)
        {

        }

        private void btn_Mate_Click(object sender, EventArgs e)
        {

        }

        private void btn_KDEPlasma_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cinnamon_Click(object sender, EventArgs e)
        {

        }

        private void btn_Lxqt_Click(object sender, EventArgs e)
        {

        }

        private void btn_Deepin_Click(object sender, EventArgs e)
        {

        }

        private void btn_Enlightenment_Click(object sender, EventArgs e)
        {

        }

        private void btn_Lxde_Click(object sender, EventArgs e)
        {

        }

        private void btn_i3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Hyprland_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bspwm_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sway_Click(object sender, EventArgs e)
        {

        }

        private void btn_Wayfire_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xmonad_Click(object sender, EventArgs e)
        {

        }

        private void btn_Herbstluftwm_Click(object sender, EventArgs e)
        {

        }

        private void btn_Qtile_Click(object sender, EventArgs e)
        {

        }

        private void btn_Awesome_Click(object sender, EventArgs e)
        {

        }

        private void btn_X11_Click(object sender, EventArgs e)
        {

        }

        private void btn_Wayland_Click(object sender, EventArgs e)
        {

        }

        private void btn_VisitDistro_Click(object sender, EventArgs e)
        {

        }

        private void lbx_RecommendedDistributions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbx_Distros_Enter(object sender, EventArgs e)
        {

        }
    }
}
