using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        //Utils
        private void load_playground()
        {
            this.webBrowser1.Url = new Uri(
                String.Format("file:///{0}/html/index.html", curDir)); //Load playground
        }

        private string get_code()
        {
            HtmlDocument doc = webBrowser1.Document;
            String str;
            try
            {
                str = doc.InvokeScript("get_code").ToString();
            }
            catch (Exception ex)
            {
                str = ex.Message.ToString();
                log(ex.Message.ToString());
            }
            return(str);
        }

        private void savetofile(string code)
        {
            try {
                using (StreamWriter sw = File.CreateText(curDir + "/sketch.inot"))
                {
                    sw.Write(code);
                }
            }
            catch (Exception e)
            {
                log(e.ToString());
            }
        }

        private void deltempfile()
        {
            File.Delete(curDir + "/sketch.inot");
        }

        private string getArduino()
        {
            return Properties.Settings.Default.arduino_path;
        }

        private void log(object s)
        {
            Debug.WriteLine(s);
        }


        // Onclick handlers
        private void compile_btn_Click(object sender, EventArgs e)
        {
            savetofile(get_code());
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
            this.Close();
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
    }
}
