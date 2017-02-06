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
    public partial class SetForm : Form
    {
        public SetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.arduino_path = textBox1.Text;
            Properties.Settings.Default.theme = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
