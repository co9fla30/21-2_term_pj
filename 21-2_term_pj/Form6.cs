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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Text = "회원가입";


            button1.Click += (sender, e) =>        
            {
                try
                {
                    if (DataManager.Users.Exists(x => x.UId.ToString() == textBox1.Text))
                    {
                        MessageBox.Show("이미 존재하는 아이디입니다.");
                    }
                    else
                    {
                        User user = new User()
                        {
                            UId = textBox1.Text,
                            UPwd = textBox2.Text,
                            UName = textBox3.Text
                            
                        };
                        DataManager.Users.Add(user);
                        DataManager.Save();
                        MessageBox.Show("회원가입이 완료되었습니다. \n로그인 하십시오.");
                        new Form1().ShowDialog();
                    }

                    
                }
                catch (Exception ex) { }
            };

        }
    }
}
