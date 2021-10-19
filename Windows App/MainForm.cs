using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fraktaler_X
{
    public partial class FraktalerX : Form
    {

        private string selectedfractal;
        private string text;
        private string ausgabetext;

        public FraktalerX()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void fraktalAuswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fraktal_Auswählen fa = new Fraktal_Auswählen();
            fa.Show();
        }

        private void beendenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Application.Exit();
        }

        /*private void view_aktualisieren_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Jonas\source\repos\Fraktaler X\Fraktaler X\values\selected\saved_selected_fractal.fractal");
            selectedfractal = sr.ReadToEnd();
            sr.Close();
            //MessageBox.Show(selectedfractal);
            text = "Mandelbrot";
            ausgabetext = "Rendering started...";
            if (selectedfractal == text)
            {
                MessageBox.Show(ausgabetext);
            }
        }*/
    }
}
