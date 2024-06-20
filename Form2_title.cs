using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solo_project
{
    public partial class Form2_title : Form
    {
        public Form2_title()
        {
            InitializeComponent();
        }
        public static string package;
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            //form1.StartPosition= FormStartPosition.Manual;
            //form1.Location=new Point(0,0);
            form1.Show();
            package = "inside";
        }

        private void pack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            //form1.StartPosition= FormStartPosition.Manual;
            //form1.Location=new Point(0, 0);
            form1.Show();
            package = "pack";
        }

        private void Form2_title_Load(object sender, EventArgs e)
        {

        }
    }
}
