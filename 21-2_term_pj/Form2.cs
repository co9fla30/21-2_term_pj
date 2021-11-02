using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_2_term_pj
{

    public partial class Form2 : Form
    {
        public static String username; 
        
        public Form2()
        {
            InitializeComponent();
            Text = "메인화면";
            label7.Text = username + " 회원님 반갑습니다.";


        }

        private void 뮤지컬예매ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void 예매관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            username = "";
            this.Close();
            new Form1().ShowDialog();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void 회원가입ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form6().ShowDialog();
        }
    }
}
