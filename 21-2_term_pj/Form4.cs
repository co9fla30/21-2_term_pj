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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Text = "예약 확인/취소";
            //dataGridView1.DataSource = DataManager.Reservations;


            System.Collections.Generic.List<Reservation> reservationsList = new List<Reservation>();
            dataGridView1.DataSource = null;
            try
            {
                for(int i = 0; i<DataManager.Reservations.Count;i++)
                    if (DataManager.Reservations[i].UId.Contains(Form2.username))
                    {
                        reservationsList.Add(DataManager.Reservations[i]);
                    }
                dataGridView1.DataSource = reservationsList;
            }catch(Exception e) {
                MessageBox.Show(" 오류");  
            }




            //try
            //{

            //    DataTable table = new DataTable();

            //    //행 추가
            //    table.Columns.Add("아이디", typeof(string));
            //    table.Columns.Add("뮤지컬", typeof(string));
            //    table.Columns.Add("결제가격", typeof(string));
            //    table.Columns.Add("좌석", typeof(string));




            //    int i = 1;
            //    while (i <10 /*DataManager.Reservations.Count*/)
            //    {
            //        Reservation reservation = DataManager.Reservations.Single((x) => x.RNo == i);
            //        if (reservation.UId == Form2.username)
            //        {
            //            if (reservation.RA1)
            //                table.Rows.Add(reservation.UId, reservation.MName, reservation.RPrice, "A-1");
            //            else if (reservation.RA2)
            //                table.Rows.Add(reservation.UId, reservation.MName, reservation.RPrice, "A-2");
            //            else if (reservation.RA3)
            //                table.Rows.Add(reservation.UId, reservation.MName, reservation.RPrice, "A-3");
            //            else if (reservation.RB1)
            //                table.Rows.Add(reservation.UId, reservation.MName, reservation.RPrice, "B-1");
            //            else if (reservation.RB2)
            //                table.Rows.Add(reservation.UId, reservation.MName, reservation.RPrice, "B-2");
            //            else if (reservation.RB3)
            //                table.Rows.Add(reservation.UId, reservation.MName, reservation.RPrice, "B-3");
            //        }
            //        i++;
            //    }



            //    dataGridView2.DataSource = table;
            //}
            //catch(Exception e)
            //{
            //    MessageBox.Show("오류");
            //}






        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Reservation reservation = DataManager.Reservations.Single(x => x.RNo.ToString() == label13.Text);
                if (reservation.UId == Form2.username)
                {
                    DataManager.Reservations.Remove(reservation);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Reservations;
                    DataManager.Save();
                }
                else
                {
                    MessageBox.Show("본인만 취소 가능합니다.");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("예매취소오류");
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Reservation reservation = dataGridView1.CurrentRow.DataBoundItem as Reservation;
                label14.Text = reservation.MName;
                label13.Text = reservation.RNo.ToString();
                label14.Text = reservation.MName;
                label8.Text = reservation.UId;
                if (reservation.RA1)
                {
                    label9.Text = "A-1";
                }
                else if (reservation.RA2)
                    label9.Text = "A-2";
                else if (reservation.RA3)
                    label9.Text = "A-3";
                else if (reservation.RB1)
                    label9.Text = "B-1";
                else if (reservation.RB2)
                    label9.Text = "B-2";
                else if (reservation.RB3)
                    label9.Text = "B-3";
            }
            catch (Exception ex) { }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = null;
           // dataGridView1.DataSource = DataManager.Reservations;
        }
    }
}
