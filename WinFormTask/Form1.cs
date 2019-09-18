using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            double x, y, z, r;

            if (double.TryParse(textBoxX.Text, out x)) ;
            else
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (double.TryParse(textBoxY.Text, out y)) ;
            else
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (double.TryParse(textBoxZ.Text, out z)) ;
            else
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            r = (2.0 * Math.Cos(x * x) - 0.5) / (0.5 + Math.Sin(Math.Pow(y, (2 - z)))) + (z * z) / (7 - z / 3.0);
            textBoxR.Text = r.ToString("F2");
        }
    }
}
