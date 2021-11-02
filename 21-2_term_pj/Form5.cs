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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent(); Text = "뮤지컬 관리";
            dataGridView1.DataSource = DataManager.Musicals;
            
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;

            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;

            button1.Click += (sender, e) =>         //추가
            {
                try
                {
                    if (DataManager.Musicals.Exists(x => x.MName.ToString() == textBox1.Text))
                    {
                        MessageBox.Show("이미 존재하는 뮤지컬입니다.");
                    }
                    else
                    {
                        Musical musical = new Musical()
                        {
                            MId = DataManager.Musicals.Max(x=>x.MId)+1,
                           // MId = int.Parse(textBox7.Text),
                            MName = textBox1.Text,
                            MLocation = textBox2.Text,
                            MPeriod = dateTimePicker1.Value,
                            MCasting = textBox4.Text,
                            MAge = textBox5.Text,
                            MPrice = int.Parse(textBox6.Text)

                        };
                        DataManager.Musicals.Add(musical);
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Musicals;
                    DataManager.Save();
                }
                catch (Exception ex) { }
            };

            button2.Click += (sender, e) =>
            {
                try
                {
                    Musical musical = DataManager.Musicals.Single(x => x.MId.ToString() == label9.Text);
                    musical.MId = int.Parse(label9.Text);
                    musical.MName = textBox1.Text;
                    musical.MLocation = textBox2.Text;
                    musical.MPeriod = dateTimePicker1.Value;
                    musical.MCasting = textBox4.Text;
                    musical.MAge = textBox5.Text;
                    musical.MPrice = int.Parse(textBox6.Text);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Musicals;
                    DataManager.Save();
                }
                catch (Exception ex) { }
            };
            button3.Click += (sender, e) =>
            {
                try
                {
                    Musical musical = DataManager.Musicals.Single(x => x.MId.ToString() == label9.Text);
                    DataManager.Musicals.Remove(musical);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Musicals;
                    DataManager.Save();
                }
                catch (Exception ex) { }

            };

        
    }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Musical musical = dataGridView1.CurrentRow.DataBoundItem as Musical;
                label9.Text = musical.MId.ToString();
                textBox1.Text = musical.MName;
                textBox2.Text = musical.MLocation;
                //dateTimePicker1.Value = musical.MPeriod;
                textBox4.Text = musical.MCasting;
                textBox5.Text = musical.MAge;
                textBox6.Text = musical.MPrice.ToString();
            }
            catch (Exception ex) { }

        }

        private void label7_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.Trim() == "")
            {
                MessageBox.Show("검색할 뮤지컬의 이름을 입력해주세요.");
                dataGridView1.DataSource = DataManager.Musicals;
                return;
            }
            System.Collections.Generic.List<Musical> musicalsList = new List<Musical>();
            dataGridView1.DataSource = null;
            try
            {
                for (int i = 0; i < DataManager.Musicals.Count; i++)
                    if (DataManager.Musicals[i].MName.Contains(textBox3.Text))
                    {
                        musicalsList.Add(DataManager.Musicals[i]);
                    }
                dataGridView1.DataSource = musicalsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" 오류");
            }
        }
    }
}
