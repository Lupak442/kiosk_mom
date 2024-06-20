using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solo_project
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            gold_nud.Value = gold_aa;                                               ///폼1 초기화 값
            nud_dbull.Value= dbull_aa;
            nud_bulbul.Value= bulbul_aa;
            nud_psy.Value= psy_aa;
            nud_un.Value= un_aa;
            nud_in.Value= in_aa;
            nud_mami.Value= mami_aa;
            nud_tex.Value= tex_aa;
            nud_white.Value= white_aa;

            nud_gmr.Value= gmr_aa;
            nud_gmpsy.Value= gmpsy_aa;
            nud_gmc.Value= gmc_aa;
            nud_mompsy.Value= mompsy_aa;
            nud_hotcpsy.Value= hotcpsy_aa;
            nud_chipa.Value= chipa_aa;
            nud_fpsy.Value= fpsy_aa;
            nud_fc.Value= fc_aa;
            nud_half.Value= half_aa;

            nud_lemon.Value= lemon_aa;
            nud_md.Value= md_aa;
            nud_mira.Value= mira_aa;
            nud_soda.Value= soda_aa;
            nud_americah.Value= americah_aa;
            nud_americai.Value= americai_aa;
            nud_orange.Value= orange_aa;
            nud_grape.Value= grape_aa;
            nud_coke.Value= coke_aa;

            //richTextBox1.Text=;

        }
        public static int total_price = 0;                                        //총합계
        public static string sharedString = "";
        public static int count_check = 0;

        private void gold_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(gold_aa));
        }

        private void dbull_Click(object sender, EventArgs e)
        {
            //total_price = 0;
            // change(lb_dbull.Text, (int)nud_dbull.Value);
            //change(gold_price.Text, (int)gold_nud.Value); 
            MessageBox.Show(Convert.ToString(change(lb_dbull.Text, (int)nud_dbull.Value)));
        }
        public int change(string lb_text, int nud_val)
        {
            int remove1 = lb_text.IndexOf(",");             //햄버거 가격에서 ,와 원 삭제
            string re1 = lb_text.Remove(remove1, 1);
            int remove2 = re1.IndexOf("원");
            string re2 = re1.Remove(remove2, 1);
            int final = int.Parse(re2);
            int i = nud_val;
            int total = final * i;
            return total;
        }
        private void gold_nud_ValueChanged(object sender, EventArgs e)
        {
            /*
            int remove1 = gold_price.Text.IndexOf(",");             //햄버거 가격에서 ,와 원 삭제
            string re1 = gold_price.Text.Remove(remove1, 1);
            int remove2 = re1.IndexOf("원");
            string re2 = re1.Remove(remove2, 1);
            int final = int.Parse(re2);
            int i = (int)gold_nud.Value;*/
            //total_price+=final*i;
            //MessageBox.Show(Convert.ToString(total_price));
        }

        private void nud_dbull_ValueChanged(object sender, EventArgs e)
        {
            /* richTextBox1.Text = "";
             StringBuilder gold = new StringBuilder();

             if (gold_nud.Value != 0)
             {
                 gold.AppendLine(string.Format("{0} {1}개", label1.Text, gold_nud.Value));
             }
             if (nud_dbull.Value != 0)
             {
                 gold.AppendLine(string.Format("{0} {1}개", name_dbull.Text, nud_dbull.Value));
             }
             richTextBox1.Text=gold.ToString();*/
            // StringBuilder dbull = new StringBuilder();
            // dbull.AppendLine(string.Format("{0} {1}개", label3.Text, nud_dbull.Value));
            // richTextBox1.Text+=dbull.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        ///////////////////버거//////////////
        public static int gold_aa;
        public static int dbull_aa;
        public static int bulbul_aa;
        public static int psy_aa;
        public static int un_aa;
        public static int in_aa;
        public static int mami_aa;
        public static int tex_aa;
        public static int white_aa;
        //////////////////치킨/////////////////////
        public static int gmr_aa;
        public static int gmpsy_aa;
        public static int gmc_aa;
        public static int mompsy_aa;
        public static int hotcpsy_aa;
        public static int chipa_aa;
        public static int fpsy_aa;
        public static int fc_aa;
        public static int half_aa;
        //////////////////주스/////////////////////
        public static int lemon_aa;
        public static int md_aa;
        public static int mira_aa;
        public static int soda_aa;
        public static int americah_aa;
        public static int americai_aa;
        public static int orange_aa;
        public static int grape_aa;
        public static int coke_aa;


        private void button1_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            StringBuilder gold = new StringBuilder();
            if (gold_nud.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", label1.Text, gold_nud.Value, change(gold_price.Text, (int)gold_nud.Value))); }
            if (nud_dbull.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_dbull.Text, nud_dbull.Value, change(lb_dbull.Text, (int)nud_dbull.Value))); }
            if (nud_bulbul.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_bulbul.Text, nud_bulbul.Value, change(lb_bulbul.Text, (int)nud_bulbul.Value))); }
            if (nud_psy.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_psy.Text, nud_psy.Value, change(lb_psy.Text, (int)nud_psy.Value))); }
            if (nud_un.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_un.Text, nud_un.Value, change(lb_un.Text, (int)nud_un.Value))); }
            if (nud_in.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_in.Text, nud_in.Value, change(lb_in.Text, (int)nud_in.Value))); }
            if (nud_mami.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_mami.Text, nud_mami.Value, change(lb_mami.Text, (int)nud_mami.Value))); }
            if (nud_tex.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_tex.Text, nud_tex.Value, change(lb_tex.Text, (int)nud_tex.Value))); }
            if (nud_white.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_white.Text, nud_white.Value, change(lb_white.Text, (int)nud_white.Value))); }
            ////////////////////치킨//////////
            if (nud_gmr.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_gmr.Text, nud_gmr.Value, change(lb_gmr.Text, (int)nud_gmr.Value))); }
            if (nud_gmpsy.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_gmpsy.Text, nud_gmpsy.Value, change(lb_gmpsy.Text, (int)nud_gmpsy.Value))); }
            if (nud_gmc.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_gmc.Text, nud_gmc.Value, change(lb_gmc.Text, (int)nud_gmc.Value))); }
            if (nud_mompsy.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_mompsy.Text, nud_mompsy.Value, change(lb_mompsy.Text, (int)nud_mompsy.Value))); }
            if (nud_hotcpsy.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_hotcpsy.Text, nud_hotcpsy.Value, change(lb_hotcpsy.Text, (int)nud_hotcpsy.Value))); }
            if (nud_chipa.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_chipa.Text, nud_chipa.Value, change(lb_chipa.Text, (int)nud_chipa.Value))); }
            if (nud_fpsy.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_fpsy.Text, nud_fpsy.Value, change(lb_fpsy.Text, (int)nud_fpsy.Value))); }
            if (nud_fc.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_fc.Text, nud_fc.Value, change(lb_fc.Text, (int)nud_fc.Value))); }
            if (nud_half.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_half.Text, nud_half.Value, change(lb_half.Text, (int)nud_half.Value))); }
            //////////////음료수///////
            if (nud_lemon.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_lemon.Text, nud_lemon.Value, change(lb_lemon.Text, (int)nud_lemon.Value))); }
            if (nud_md.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_md.Text, nud_md.Value, change(lb_md.Text, (int)nud_md.Value))); }
            if (nud_mira.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_mira.Text, nud_mira.Value, change(lb_mira.Text, (int)nud_mira.Value))); }
            if (nud_soda.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_soda.Text, nud_soda.Value, change(lb_soda.Text, (int)nud_soda.Value))); }
            if (nud_americah.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_americah.Text, nud_americah.Value, change(lb_americah.Text, (int)nud_americah.Value))); }
            if (nud_americai.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_americai.Text, nud_americai.Value, change(lb_americai.Text, (int)nud_americai.Value))); }
            if (nud_orange.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_orange.Text, nud_orange.Value, change(lb_orange.Text, (int)nud_orange.Value))); }
            if (nud_grape.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_grape.Text, nud_grape.Value, change(lb_grape.Text, (int)nud_grape.Value))); }
            if (nud_coke.Value != 0) { gold.AppendLine(string.Format("{0} {1}개 {2:0,0}원", name_coke.Text, nud_coke.Value, change(lb_coke.Text, (int)nud_coke.Value))); }

            richTextBox1.Text = gold.ToString();
            sharedString = richTextBox1.Text;
            total_price=change(gold_price.Text, (int)gold_nud.Value)+ change(lb_dbull.Text, (int)nud_dbull.Value) + change(lb_bulbul.Text, (int)nud_bulbul.Value)
                + change(lb_psy.Text, (int)nud_psy.Value) + change(lb_un.Text, (int)nud_un.Value)+ change(lb_in.Text, (int)nud_in.Value)
                + change(lb_mami.Text, (int)nud_mami.Value)+ change(lb_tex.Text, (int)nud_tex.Value) + change(lb_white.Text, (int)nud_white.Value)
                + change(lb_gmr.Text, (int)nud_gmr.Value)+ change(lb_gmpsy.Text, (int)nud_gmpsy.Value)+ change(lb_gmc.Text, (int)nud_gmc.Value)+ change(lb_mompsy.Text, (int)nud_mompsy.Value)
                + change(lb_hotcpsy.Text, (int)nud_hotcpsy.Value)+ change(lb_chipa.Text, (int)nud_chipa.Value)+ change(lb_fpsy.Text, (int)nud_fpsy.Value)+ change(lb_fc.Text, (int)nud_fc.Value)
                + change(lb_half.Text, (int)nud_half.Value)
                + change(lb_lemon.Text, (int)nud_lemon.Value)+ change(lb_md.Text, (int)nud_md.Value)+ change(lb_mira.Text, (int)nud_mira.Value)+ change(lb_soda.Text, (int)nud_soda.Value)
                + change(lb_americah.Text, (int)nud_americah.Value) + change(lb_americai.Text, (int)nud_americai.Value)+ change(lb_orange.Text, (int)nud_orange.Value)+ change(lb_grape.Text, (int)nud_grape.Value)
                + change(lb_coke.Text, (int)nud_coke.Value);

            gold_aa= (int)gold_nud.Value;               // 담기 버튼을 눌렀을 때 값들을 전역변수로 옮겨주는 작업
            dbull_aa=(int)nud_dbull.Value;
            bulbul_aa= (int)nud_bulbul.Value;
            psy_aa= (int)nud_psy.Value;
            un_aa= (int)nud_un.Value;
            in_aa= (int)nud_in.Value;
            mami_aa= (int)nud_mami.Value;
            tex_aa= (int)nud_tex.Value;
            white_aa = (int)nud_white.Value;

            gmr_aa= (int)nud_gmr.Value;
            gmpsy_aa= (int)nud_gmpsy.Value;
            gmc_aa= (int)nud_gmc.Value;
            mompsy_aa= (int)nud_mompsy.Value;
            hotcpsy_aa= (int)nud_hotcpsy.Value;
            chipa_aa= (int)nud_chipa.Value;
            fpsy_aa= (int)nud_fpsy.Value;
            fc_aa= (int)nud_fc.Value;
            half_aa= (int)nud_half.Value;

            lemon_aa= (int)nud_lemon.Value;
            md_aa= (int)nud_md.Value;
            mira_aa= (int)nud_mira.Value;
            soda_aa=(int)nud_soda.Value;
            americah_aa= (int)nud_americah.Value;
            americai_aa= (int)nud_americai.Value;
            orange_aa= (int)nud_orange.Value;
            grape_aa= (int)nud_grape.Value;
            coke_aa= (int)nud_coke.Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3_result form3 = new Form3_result();
            form3.Show();
            this.Close();
        }


        private void cancel_Click(object sender, EventArgs e)       //초기화 이벤트
        {
            richTextBox1.Text = null;
            gold_nud.Value = 0; nud_dbull.Value = 0; nud_bulbul.Value=0; nud_psy.Value=0; nud_un.Value=0;
            nud_in.Value=0; nud_mami.Value=0; nud_tex.Value = 0; nud_white.Value = 0;
            nud_gmr.Value=0; nud_gmpsy.Value = 0; nud_gmc.Value = 0; nud_mompsy.Value = 0; nud_hotcpsy.Value = 0;
            nud_chipa.Value = 0; nud_fpsy.Value = 0; nud_fc.Value = 0; nud_half.Value = 0;
            nud_lemon.Value = 0; nud_md.Value = 0; nud_mira.Value = 0; nud_soda.Value = 0; nud_americah.Value = 0;
            nud_americai.Value = 0; nud_orange.Value = 0; nud_grape.Value = 0; nud_coke.Value = 0;

            total_price=change(gold_price.Text, (int)gold_nud.Value)+ change(lb_dbull.Text, (int)nud_dbull.Value) + change(lb_bulbul.Text, (int)nud_bulbul.Value)
               + change(lb_psy.Text, (int)nud_psy.Value) + change(lb_un.Text, (int)nud_un.Value)+ change(lb_in.Text, (int)nud_in.Value)
               + change(lb_mami.Text, (int)nud_mami.Value)+ change(lb_tex.Text, (int)nud_tex.Value) + change(lb_white.Text, (int)nud_white.Value)
               + change(lb_gmr.Text, (int)nud_gmr.Value)+ change(lb_gmpsy.Text, (int)nud_gmpsy.Value)+ change(lb_gmc.Text, (int)nud_gmc.Value)+ change(lb_mompsy.Text, (int)nud_mompsy.Value)
               + change(lb_hotcpsy.Text, (int)nud_hotcpsy.Value)+ change(lb_chipa.Text, (int)nud_chipa.Value)+ change(lb_fpsy.Text, (int)nud_fpsy.Value)+ change(lb_fc.Text, (int)nud_fc.Value)
               + change(lb_half.Text, (int)nud_half.Value)
               + change(lb_lemon.Text, (int)nud_lemon.Value)+ change(lb_md.Text, (int)nud_md.Value)+ change(lb_mira.Text, (int)nud_mira.Value)+ change(lb_soda.Text, (int)nud_soda.Value)
               + change(lb_americah.Text, (int)nud_americah.Value) + change(lb_americai.Text, (int)nud_americai.Value)+ change(lb_orange.Text, (int)nud_orange.Value)+ change(lb_grape.Text, (int)nud_grape.Value)
               + change(lb_coke.Text, (int)nud_coke.Value);

            gold_aa= (int)gold_nud.Value;
            dbull_aa=(int)nud_dbull.Value;
            bulbul_aa= (int)nud_bulbul.Value;
            psy_aa= (int)nud_psy.Value;
            un_aa= (int)nud_un.Value;
            in_aa= (int)nud_in.Value;
            mami_aa= (int)nud_mami.Value;
            tex_aa= (int)nud_tex.Value;
            white_aa = (int)nud_white.Value;

            gmr_aa= (int)nud_gmr.Value;
            gmpsy_aa= (int)nud_gmpsy.Value;
            gmc_aa= (int)nud_gmc.Value;
            mompsy_aa= (int)nud_mompsy.Value;
            hotcpsy_aa= (int)nud_hotcpsy.Value;
            chipa_aa= (int)nud_chipa.Value;
            fpsy_aa= (int)nud_fpsy.Value;
            fc_aa= (int)nud_fc.Value;
            half_aa= (int)nud_half.Value;

            lemon_aa= (int)nud_lemon.Value;
            md_aa= (int)nud_md.Value;
            mira_aa= (int)nud_mira.Value;
            soda_aa=(int)nud_soda.Value;
            americah_aa= (int)nud_americah.Value;
            americai_aa= (int)nud_americai.Value;
            orange_aa= (int)nud_orange.Value;
            grape_aa= (int)nud_grape.Value;
            coke_aa= (int)nud_coke.Value;


        }

        private void gmr_Click(object sender, EventArgs e)
        {

        }

        private void nud_fpsy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_fc_Click(object sender, EventArgs e)
        {

        }

        private void nud_fc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_half_Click(object sender, EventArgs e)
        {

        }

        private void nud_half_ValueChanged(object sender, EventArgs e)
        {

        }

        private void name_half_Click(object sender, EventArgs e)
        {

        }

        private void name_fc_Click(object sender, EventArgs e)
        {

        }

        private void name_fpsy_Click(object sender, EventArgs e)
        {

        }

        private void name_mompsy_Click(object sender, EventArgs e)
        {

        }

        private void name_hotcpsy_Click(object sender, EventArgs e)
        {

        }

        private void name_chipa_Click(object sender, EventArgs e)
        {

        }

        private void lb_fpsy_Click(object sender, EventArgs e)
        {

        }

        private void nud_chipa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lb_chipa_Click(object sender, EventArgs e)
        {

        }

        private void lb_hotcpsy_Click(object sender, EventArgs e)
        {

        }

        private void nud_hotcpsy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nud_mompsy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Lb_mompsy_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.gold_aa = 0;          //////초기화 하기(초기화 버튼눌렀을 때)
            Form1.dbull_aa = 0;
            Form1.bulbul_aa = 0;
            Form1.psy_aa = 0;
            Form1.un_aa = 0;
            Form1.in_aa = 0;
            Form1.mami_aa = 0;
            Form1.tex_aa = 0;
            Form1.white_aa = 0;

            Form1.gmr_aa = 0;
            Form1.gmpsy_aa = 0;
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
            Form1.americah_aa = 0;
            Form1.americai_aa = 0;
            Form1.orange_aa = 0;
            Form1.grape_aa = 0;
            Form1.coke_aa = 0;
            Form1.sharedString="";
            //richTextBox1.Text="";
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=0;
        }
    }
}
