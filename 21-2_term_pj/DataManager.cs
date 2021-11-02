using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _21_2_term_pj
{
    class DataManager
    {
        public static List<Musical> Musicals = new List<Musical>();
        public static List<User> Users = new List<User>();
        public static List<Reservation> Reservations = new List<Reservation>();

        static DataManager() 
        {
            Load();
        }
        public static void Load() //파일에서 가져오는 메소드
        {
            try
            {

                string musicalsOutput = File.ReadAllText(@"./Musicals.xml"); //File.치고 임포트 해야함(using system IO) 파일에 모든 텍스트를 불러와라... 스트링으로 현재 파일경로 지정
                XElement musicalsXElement = XElement.Parse(musicalsOutput); //Xml 임포트, 파싱 작업을 하겠다

                Musicals = (from item in musicalsXElement.Descendants("musical") //파싱작업 북스의 디펜던트는 북, 북의 디펜던트는 하나하나의 요소들
                         select new Musical() //북 객체를 만들거야...
                         {
                             MId = int.Parse(item.Element("mId").Value),
                             MName = item.Element("mName").Value, //스트링, book.cs의 객체
                             MLocation = item.Element("mLocation").Value,
                             MPeriod = DateTime.Parse(item.Element("mPeriod").Value),
                             MCasting = item.Element("mCasting").Value,
                             MAge = item.Element("mAge").Value,
                             MPrice = int.Parse(item.Element("mPrice").Value)

                         }).ToList<Musical>();

                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);

                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             UId = item.Element("uId").Value,
                             UPwd = item.Element("uPwd").Value,
                             UName = item.Element("uName").Value
                         }
                         ).ToList<User>();

                string reservationsOutput = File.ReadAllText(@"./Reservations.xml");
                XElement reservationsXElement = XElement.Parse(reservationsOutput);

                Reservations = (from item in reservationsXElement.Descendants("reservation")
                         select new Reservation()
                         { 
                             RNo = int.Parse(item.Element("rNo").Value),
                             MName = item.Element("mName").Value,
                             RPrice = int.Parse(item.Element("rPrice").Value),
                             RA1 = item.Element("rA1").Value != "0" ? true : false,
                             RA2 = item.Element("rA2").Value != "0" ? true : false,
                             RA3 = item.Element("rA3").Value != "0" ? true : false,
                             RB1 = item.Element("rB1").Value != "0" ? true : false,
                             RB2 = item.Element("rB2").Value != "0" ? true : false,
                             RB3 = item.Element("rB3").Value != "0" ? true : false,
                             UId = item.Element("uId").Value
                            
                         }
                         ).ToList<Reservation>();

            }
            catch (FileNotFoundException e) // 파일 없을 때 ... 자동으로 세이브에 넘김
            {
                Save();
            }
        }

        public static void Save() //파일에 저장하는 메소드
        {
            string musicalsOutput = "";
            musicalsOutput += "<musicals>\n";
            foreach (var item in Musicals)
            {
                musicalsOutput += "<musical>\n";

                musicalsOutput += "<mId>" + item.MId + "</mId>\n";
                musicalsOutput += "<mName>" + item.MName + "</mName>\n";
                musicalsOutput += "<mLocation>" + item.MId + "</mLocation>\n";
                musicalsOutput += "<mPeriod>" + item.MPeriod.ToLongDateString() + "</mPeriod>\n";
                musicalsOutput += "<mCasting>" + item.MCasting + "</mCasting>\n";
                musicalsOutput += "<mAge>" + item.MAge + "</mAge>\n";
                musicalsOutput += "<mPrice>" + item.MPrice + "</mPrice>\n";
                
                musicalsOutput += "</musical>\n";
            }

            musicalsOutput += "</musicals>\n";


            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in Users)
            {
                usersOutput += "<user>\n";

                usersOutput += "<uId>" + item.UId + "</uId>\n";
                usersOutput += "<uPwd>" + item.UPwd + "</uPwd>\n";
                usersOutput += "<uName>" + item.UName + "</uName>\n";
                
                usersOutput += "</user>\n";
            }
            usersOutput += "</users>";

            string reservationsOutput = "";
            reservationsOutput += "<resrvations>\n";
            foreach (var item in Reservations)
            {
                reservationsOutput += "<resrvation>\n";

                reservationsOutput += "<rNo>" + item.RNo + "</rNo>\n";
                reservationsOutput += "<mName>" + item.MName + "</mName>\n";
                reservationsOutput += "<rPrice>" + item.RPrice + "</rPrice>\n";
                reservationsOutput += "<rA1>" + (item.RA1 ? 1 : 0) + "</rA1>\n";
                reservationsOutput += "<rA2>" + (item.RA2 ? 1 : 0) + "</rA2>\n";
                reservationsOutput += "<rA3>" + (item.RA3 ? 1 : 0) + "</rA3>\n";
                reservationsOutput += "<rB1>" + (item.RB1 ? 1 : 0) + "</rB1>\n";
                reservationsOutput += "<rB2>" + (item.RB2 ? 1 : 0) + "</rB2>\n";
                reservationsOutput += "<rB3>" + (item.RB3 ? 1 : 0) + "</rB3>\n";
                reservationsOutput += "<uId>" + item.UId + "</uId>\n";

                reservationsOutput += "</resrvation>\n";
            }
            reservationsOutput += "</resrvations>";

            File.WriteAllText(@"./Musicals.xml", musicalsOutput);
            File.WriteAllText(@"./Users.xml", usersOutput);
            File.WriteAllText(@"./Reservations.xml", reservationsOutput);


        }
    }
}
