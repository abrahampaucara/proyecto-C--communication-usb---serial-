using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PicWinUSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Class1.Conectar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1.Conectar();
        }
    }
}
