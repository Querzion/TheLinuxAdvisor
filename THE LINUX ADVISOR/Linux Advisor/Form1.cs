using Linux_Advisor.Classes;
using Linux_Advisor.Classes.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Linux_Advisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            
            //*/    Looped Window Manager List
            string[] enumWM = Enum.GetNames(typeof(Interface_WindowManagers));

            foreach (var item in enumWM)
            {
                comboBox1.Items.Add(item.Replace("_", " "));
            }

            comboBox1.SelectedIndex = (int)Interface_WindowManagers.CHOOSE;
            //*/

            //*/    Looped Desktop Environment List
            string[] enumDE = Enum.GetNames(typeof(Interface_DesktopEnvironments));

            foreach (var item in enumDE)
            {
                comboBox2.Items.Add(item.Replace("_", " "));
            }

            comboBox2.SelectedIndex = (int)Interface_DesktopEnvironments.CHOOSE;
            //*/
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
            gbx_Purpose.Visible = true;
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
            gbx_Purpose.Visible = true;
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
            gbx_Purpose.Visible = true;
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
            gbx_Purpose.Visible = true;
        }

        private void btn_DailyDriver_Click(object sender, EventArgs e)
        {
            gbx_Release.Visible = true;
        }

        private void btn_Work_Click(object sender, EventArgs e)
        {
            gbx_Release.Visible = true;
        }

        private void btn_Gaming_Click(object sender, EventArgs e)
        {
            gbx_Release.Visible = true;
        }

        private void btn_HomeServer_Click(object sender, EventArgs e)
        {
            gbx_Release.Visible = true;
        }

        private void btn_Server_Click(object sender, EventArgs e)
        {
            gbx_Release.Visible = true;
        }

        private void btn_SeasonalRelease_Click(object sender, EventArgs e)
        {
            gbx_Stability.Visible = true;
        }

        private void btn_RollingRelease_Click(object sender, EventArgs e)
        {
            gbx_Stability.Visible = true;
        }

        private void btn_Extremely_Click(object sender, EventArgs e)
        {
            gbx_Interface.Visible = true;
        }

        private void btn_Very_Click(object sender, EventArgs e)
        {
            gbx_Interface.Visible = true;
        }

        private void btn_Usable_Click(object sender, EventArgs e)
        {
            gbx_Interface.Visible = true;
        }

        private void btn_NotAtAll_Click(object sender, EventArgs e)
        {
            gbx_Interface.Visible = true;
        }

        private void btn_DE_Click(object sender, EventArgs e)
        {

            gbx_DE_Drop.Visible = true;
            gbx_WM_Drop.Visible = false;
        }

        private void btn_WM_Click(object sender, EventArgs e)
        {

            gbx_DE_Drop.Visible = false;
            gbx_WM_Drop.Visible = true;
            
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
            //*/    Looped Desktop Environment List
            string[] enumDE = Enum.GetNames(typeof(Interface_DesktopEnvironments));

            foreach (var item in enumDE)
            {
                comboBox2.Items.Add(item.Replace("_", " "));
            }

            comboBox2.SelectedIndex = (int)Interface_DesktopEnvironments.CHOOSE;
            //*/
        }

        private void gbx_Distros_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ventoy_Click(object sender, EventArgs e)
        {
            Process.Start("https://ventoy.net/en/download.html");   // Opens the webpage in the default browser upon press.

            wb_Youtube.Visible = true;  // Make the browser visable.
            playTheVideo("https://www.youtube.com/watch?v=2SXscyVArMI"); // Video link to Ventoy Guide.
            
        }

        private void wb_Youtube_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void txtVideoLink_TextChanged(object sender, EventArgs e)
        {

        }

        // Youtube video player. It plays the urls that is added with a click.
        private void playTheVideo(string Url)
        {
            txtVideoLink.Text = Url;

            string html = "<html> <head>";
            html += " <meta content='IE=Edge' http-equiv='X-UA-Compatible'/> ";
            html += " <iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='580' height='380' frameborder='0' allowfullscreen></iframe> ";
            html += " </body> </html> ";
            this.wb_Youtube.DocumentText = string.Format(html, txtVideoLink.Text.Split('=')[1]);
        }

        private void btn_DE_Check_Click(object sender, EventArgs e)
        {
            if ()
        }

        private void btn_WM_Check_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Window Manager List
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // Desktop Environment List
        {

        }

        private void gbx_DE_Drop_Enter(object sender, EventArgs e)
        {

        }

        private void gbx_WM_Drop_Enter(object sender, EventArgs e)
        {

        }
    }
}
