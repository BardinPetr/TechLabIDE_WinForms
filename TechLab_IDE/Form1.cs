using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechLab_IDE
{
    public partial class Form1 : Form
    {
        string curDir = Directory.GetCurrentDirectory();
        public Form1()
        {
            InitializeComponent();

            scan();
            load_playground();
        }

        //Utils
        private void scan()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    port_box.Items.Add(port);
                }
                if (port_box.Items.Count > 0)
                    port_box.SelectedIndex = 0;
                board_box.SelectedItem = "arduino:avr:nano:cpu=atmega328";
            } catch(Exception e)
            {

            }
        }

        private void load_playground()
        {
            try
            {
                this.webBrowser1.Url = new Uri(
                    String.Format("file:///{0}/html/index.html", curDir)); //Load playground
            } catch(Exception e)
            {
                log("Playground error: " + e.ToString());
            }
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
            return (str);
        }
        private string get_xml()
        {
            HtmlDocument doc = webBrowser1.Document;
            String str;
            try
            {
                str = doc.InvokeScript("get_xml").ToString();
            }
            catch (Exception ex)
            {
                str = ex.Message.ToString();
                log(ex.Message.ToString());
            }
            return (str);
        }

        private void savetofile(string code, string dir, string name = "/sketch/sketch.ino")
        {
            try
            {
                using (StreamWriter sw = File.CreateText(dir + name))
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
            File.Delete(curDir + "/sketch/sketch.ino");
        }

        private string getArduino()
        {
            return Properties.Settings.Default.arduino_path;
        }

        private void log(object s)
        {
            Debug.WriteLine(s);
        }

        private string make_str(bool type)
        {
            string str = "";
            try
            {
                str = ""; 
                str += " --port " + port_box.SelectedItem.ToString();
                str += " --board " + board_box.SelectedItem.ToString();
                str += (!type ? " --verify " : " --upload ") + " \\sketch\\sketch.ino";
            }
            catch (Exception e)
            {
                log(e.ToString());
            }
            return str;
        }


        private void run_arduino(bool type)
        {
            log("Arduino started");

            webBrowser1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;

            label2.Text = "Arduino started\nCompilation started\n";

            string ostr = "";
            try {
                Process process = new Process();

                process.StartInfo.FileName = getArduino();
                process.StartInfo.Arguments = make_str(type);// + " --pref build.path=" + curDir + "\\sketch";
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.OutputDataReceived += new DataReceivedEventHandler(
                    (s, ex) =>
                    {
                        string str = ex.Data;
                        if (str != null) {
                            if (!str.StartsWith("Invalid") && !str.StartsWith("Invalid") && !str.StartsWith("Неверная") && !str.StartsWith("Игнорировать") && !str.StartsWith("Имена") && !str.StartsWith("("))
                            {
                                log(str);
                                setLabel(str + '\n');
                            }
                        }
                    }
                );
                process.ErrorDataReceived += new DataReceivedEventHandler((s, ex) => { Debug.WriteLine(ex.Data); return; });

                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();
            } catch (Exception e)
            {
                log("Error while arduino:   " + e.ToString());
                label2.Text += "Error while arduino\n";

                button2.Visible = true;

                return;
            }

            log("Arduino was finished sucessfully\n");
            label2.Text += "Arduino was finished sucessfully\n";

            button2.Visible = true;
        }

        private void setLabel(string txt)
        {
            this.label2.BeginInvoke((MethodInvoker)(() => this.label2.Text += txt));
        }
        

        // Onclick handlers
        private void compile_btn_Click(object sender, EventArgs e)
        {
            savetofile(get_code(), curDir);

            run_arduino(false);

            deltempfile();
        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            savetofile(get_code(), curDir);

            run_arduino(true);

            deltempfile();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            load_playground();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TechLAB files|*.tlab";
            ofd.Title = "Open an TechLAB files File";

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = ofd.FileName;
            string fileText = System.IO.File.ReadAllText(filename);

            HtmlDocument doc = webBrowser1.Document;
            object[] o = new object[1];
            o[0] = fileText;
            doc.InvokeScript("set_xml", o);
        }
        private void openexItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TechLAB files|*.tlab";
            ofd.Title = "Open an TechLAB files File";
            ofd.InitialDirectory = "C:\\Program Files (x86)\\TechLAB\\Examples";

            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = ofd.FileName;
            string fileText = System.IO.File.ReadAllText(filename);

            HtmlDocument doc = webBrowser1.Document;
            object[] o = new object[1];
            o[0] = fileText;
            doc.InvokeScript("set_xml", o);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TechLAB files|*.tlab";
            sfd.Title = "Save an TechLAB files File";
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = sfd.FileName;
            File.WriteAllText(filename, get_xml());
        }
        private void save_codeItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arduino|*.ino";
            sfd.Title = "Save an sketch File";
            sfd.ShowDialog();

            string filename = sfd.FileName;
            File.WriteAllText(filename, get_code());
        }

        private void set_btn_Click(object sender, EventArgs e)
        {
            SetForm form = new SetForm();
            form.ShowDialog();
        }

        private void term_btn_Click(object sender, EventArgs e)
        {
            Terminal form = new Terminal();
            form.setport(port_box.SelectedItem.ToString());
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siteItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.robonel.com");
        }

        private void infoItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
        }
    }
}
