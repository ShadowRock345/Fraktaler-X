using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Fraktaler_X
{
    public partial class Fraktal_Auswählen : Form
    {
        public Fraktal_Auswählen()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Auswählen_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string selectedfractal = listBox1.SelectedItem.ToString();
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Ein Fraktal wurde ausgewählt und wird nun gerendert!" + "(" + selectedfractal + ")";
                notifyIcon1.ShowBalloonTip(100);
                MessageBox.Show(selectedfractal);
                this.ShowInTaskbar = false;
                Save(@"C:\Users\Jonas\source\repos\Fraktaler X\Fraktaler X\values\selected\saved_selected_fractal.fractal", selectedfractal);
                //notifyIcon1.Visible = true;
                ComplexNumber.frmMain fm = new ComplexNumber.frmMain();
                fm.Show();
                this.Close();

            } else
            {
                MessageBox.Show("Du musst ein Fraktal auswählen!");
            }
        }

        public void Save(string path, string fractal_selected)
        {
            StreamWriter sw = new StreamWriter(@path, false);

            sw.WriteLine(fractal_selected);
            sw.Close();
        }

    }
}
