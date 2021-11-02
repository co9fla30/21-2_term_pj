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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Text = "뮤지컬 예매";
            isChecked(checkBox1.Checked);
            dataGridView1.DataSource = DataManager.Musicals;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;

        }

        public void isChecked(bool Checked) 
        { 
            if (Checked)
            {
                button1.Enabled = true;
                label14.Text = "";
                if (checkBox1.Checked)
                    label14.Text = "a-1"; 
                else if(checkBox2.Checked)
                    label14.Text = "a-2";
                else if (checkBox3.Checked)
                    label14.Text = "a-3";
                else if (checkBox8.Checked)
                    label14.Text = "B-1";
                else if (checkBox7.Checked)
                    label14.Text = "B-2";
                else if (checkBox6.Checked)
                    label14.Text = "b-3";
                else
                    label14.Text = "좌석을 선택해주세요";
            }
            else 
            { 
                button1.Enabled = false;
                label14.Text = "좌석을 선택해주세요"; 
            }
        }

        
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Musical musical = dataGridView1.CurrentRow.DataBoundItem as Musical;
                
                label6.Text = musical.MName;
                label9.Text = musical.MLocation;
                //dateTimePicker1.Value = musical.MPeriod;
                label10.Text = musical.MPeriod.ToString("d");
                label11.Text = musical.MCasting;
                label7.Text = musical.MAge;
                label12.Text = musical.MPrice.ToString();
            }
            catch (Exception ex) { }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked(checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isChecked(checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            isChecked(checkBox3.Checked);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            isChecked(checkBox8.Checked);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            isChecked(checkBox7.Checked);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            isChecked(checkBox6.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("예약정보 \n <뮤지컬> " + label6.Text + "\n 좌석 " + label14.Text + "\n 가격 " + label12.Text);

            //int RNoCount = DataManager.Reservations.Where((x) => x.RNo).Count();
            //if (DataManager.Reservations.Exists(x => x.RA1 == true))
            //    MessageBox.Show("A-1, 이미 선택된 좌석입니다.");
            //else if (DataManager.Reservations.Exists(x => x.RA2 == true))
            //    MessageBox.Show("A-2, 이미 선택된 좌석입니다.");
            //else if (DataManager.Reservations.Exists(x => x.RA3 == true))
            //    MessageBox.Show("A-3, 이미 선택된 좌석입니다.");
            //else if (DataManager.Reservations.Exists(x => x.RB1 == true))
            //    MessageBox.Show("B-1, 이미 선택된 좌석입니다.");
            //else if (DataManager.Reservations.Exists(x => x.RB2 == true))
            //    MessageBox.Show("B-2, 이미 선택된 좌석입니다.");
            //else if (DataManager.Reservations.Exists(x => x.RB3 == true))
            //    MessageBox.Show("B-3, 이미 선택된 좌석입니다.");
            //else
            //{
            var reservation1 = DataManager.Reservations.FindAll((x) => x.MName == label6.Text);
            if (checkBox1.Checked && reservation1.Exists(x => x.RA1 == true))
            {
                MessageBox.Show("A-1, 이미 선택된 좌석입니다.");
            }
            else if (checkBox2.Checked && reservation1.Exists(x => x.RA2 == true))
                MessageBox.Show("A-2, 이미 선택된 좌석입니다.");
            else if (checkBox3.Checked && reservation1.Exists(x => x.RA3 == true))
                MessageBox.Show("A-3, 이미 선택된 좌석입니다.");
            else if (checkBox8.Checked && reservation1.Exists(x => x.RB1 == true))
                MessageBox.Show("B-1, 이미 선택된 좌석입니다.");
            else if (checkBox7.Checked && reservation1.Exists(x => x.RB2 == true))
                MessageBox.Show("B-2, 이미 선택된 좌석입니다.");
            else if (checkBox6.Checked && reservation1.Exists(x => x.RB3 == true))
                MessageBox.Show("B-3, 이미 선택된 좌석입니다.");
            else
            {
                try
                {


                    //Reservation reservation1 = DataManager.Reservations.Single((x) => x.MName == label6.Text);
                    //if (reservation1.RA1)
                    //{
                    //    MessageBox.Show("A-1, 이미 선택된 좌석입니다.");
                    //}
                    //else if (reservation1.RA2)
                    //    MessageBox.Show("A-2, 이미 선택된 좌석입니다.");
                    //else if (reservation1.RA3)
                    //    MessageBox.Show("A-3, 이미 선택된 좌석입니다.");
                    //else if (reservation1.RB1)
                    //    MessageBox.Show("B-1, 이미 선택된 좌석입니다.");
                    //else if (reservation1.RB2)
                    //    MessageBox.Show("B-2, 이미 선택된 좌석입니다.");
                    //else if (reservation1.RB3)
                    //    MessageBox.Show("B-3, 이미 선택된 좌석입니다.");
                    //else
                    //{
                    Reservation reservation = new Reservation()
                    {
                        //RNo = DataManager.Reservations.Where(x => x.RNo).Count() + 1,
                        RNo = DataManager.Reservations.Count + 1,
                        UId = Form2.username,
                        MName = label6.Text,
                        RPrice = int.Parse(label12.Text)
                    };
                    DataManager.Reservations.Add(reservation);

                    DataManager.Save();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("예매 오류");
                }

                try
                {
                    Reservation reservation = DataManager.Reservations.Single((x) => x.RNo == DataManager.Reservations.Count);

                    if (checkBox1.Checked)
                        reservation.RA1 = true;
                    else if (checkBox2.Checked)
                        reservation.RA2 = true;
                    else if (checkBox3.Checked)
                        reservation.RA3 = true;
                    else if (checkBox8.Checked)
                        reservation.RB1 = true;
                    else if (checkBox7.Checked)
                        reservation.RB2 = true;
                    else if (checkBox6.Checked)
                        reservation.RB3 = true;

                    DataManager.Save();
                    MessageBox.Show("예매 완료");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("예매(좌석추가) 오류");
                }
            }
        }
    }
}

