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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "로그인";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("아이디를 입력하시오.");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("비밀번호를 입력하시오.");
            }
            else
            {
                try
                {
                    User user = DataManager.Users.Single(x => x.UId == textBox1.Text);
                    if (user.UId == textBox1.Text && user.UPwd == textBox2.Text)
                    {
                        
                        Form2.username = user.UId;
                        
                        new Form2().ShowDialog();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("존재하지 않는 아이디 혹은 비밀번호입니다.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("존재하지 않는 아이디 혹은 비밀번호입니다.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form6().ShowDialog(); 
            this.Close();
        }
    }
}
