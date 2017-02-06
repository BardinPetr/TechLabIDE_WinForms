using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechLab_IDE
{
    public partial class Form1 : Form
    {
        string curDir = System.IO.Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();

            load_playground();
        }

        private void load_playground()
        {
            this.webBrowser1.Url = new Uri(
                String.Format("file:///{0}/html/index.html", curDir)); //Load playground
        }

        // Onclick handlers
        private void compile_btn_Click(object sender, EventArgs e)
        {

        }

        private void load_btn_Click(object sender, EventArgs e)
        {

        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            load_playground();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            SetForm form = new SetForm();
            form.ShowDialog();
        }

        private void term_btn_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openexItem_Click(object sender, EventArgs e)
        {

        }

        private void save_codeItem_Click(object sender, EventArgs e)
        {

        }

        private void siteItem_Click(object sender, EventArgs e)
        {

        }

        private void infoItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        //

        private void log_s(string s)
        {
            log.Text = s;
        }
    }
}
