using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Solo_project
{
    public partial class Form3_result : Form
    {
       
       public Form3_result()
        {
            InitializeComponent();
        }
        public string sharedString;
        public int total;
        public string pack;

        private void Form3_result_Load(object sender, EventArgs e)
        {
            sharedString = Form1.sharedString;
            total = Form1.total_price;
            if (total == 0) { richTextBox_result.Text = "주문을 담고 결제해주세요"; }
            else
            richTextBox_result.Text=sharedString+String.Format("\n 합계 : {0:0,0}원",total);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pack = Form2_title.package;
            if (pack == "pack")
            {
                if (radioButton1.Checked == true) { MessageBox.Show(sharedString + String.Format("\n 합계 : {0:0,0}원이 현금으로 결제 후 포장주문이 완료되었습니다.", total)); }
                if (radioButton2.Checked == true) { MessageBox.Show(sharedString + String.Format("\n 합계 : {0:0,0}원이 카드로 결제 후 포장주문이 완료되었습니다.", total)); }
                if (radioButton3.Checked == true) { MessageBox.Show(sharedString + String.Format("\n 합계 : {0:0,0}원이 상품권으로 결제 후 포장주문이 완료되었습니다.", total)); }
            }
            else {
                if (radioButton1.Checked == true) { MessageBox.Show(sharedString + String.Format("\n 합계 : {0:0,0}원이 현금으로 결제 후 매장식사가 주문 완료되었습니다.", total)); }
                if (radioButton2.Checked == true) { MessageBox.Show(sharedString + String.Format("\n 합계 : {0:0,0}원이 카드로 결제 후 매장식사가 주문 완료되었습니다.", total)); }
                if (radioButton3.Checked == true) { MessageBox.Show(sharedString + String.Format("\n 합계 : {0:0,0}원이 상품권으로 결제 후 매장식사가 주문 완료되었습니다.", total)); }
            }
            Form1.gold_aa = 0;
            Form1.dbull_aa = 0;
            Form1.bulbul_aa = 0;
            Form1.psy_aa = 0;
            Form1.un_aa = 0;
            Form1.in_aa = 0;
            Form1.mami_aa =0;
            Form1.tex_aa = 0;
            Form1.white_aa =0;

            Form1.gmr_aa = 0;
            Form1.gmpsy_aa =0;
            Form1.gmc_aa = 0;
            Form1.mompsy_aa = 0;
            Form1.hotcpsy_aa = 0;
            Form1.chipa_aa = 0;
            Form1.fpsy_aa = 0;
            Form1.fc_aa = 0;
            Form1.half_aa = 0;

            Form1.lemon_aa = 0;
            Form1.md_aa = 0;
            Form1.mira_aa = 0;
            Form1.soda_aa = 0;
            Form1.americah_aa =0;
            Form1.americai_aa = 0;
            Form1.orange_aa = 0;
            Form1.grape_aa = 0;
            Form1.coke_aa = 0;
            Form1.sharedString="";
            Form1.total_price = 0;
            this.Close();   
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
