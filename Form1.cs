using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            this.pictureBoxmostrar.Visible = true;
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            this.pictureBoxmostrar.Visible = false;
        }

        private void btn_mostrar2_Click(object sender, EventArgs e)
        {
            this.pictureBoxmostrar2.Visible = true;
        }

        private void btn_apagar2_Click(object sender, EventArgs e)
        {
            this.pictureBoxmostrar2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBoxmostrar2.Visible = false;
            this.pictureBoxmostrar.Visible = false;

        }
    }
}
