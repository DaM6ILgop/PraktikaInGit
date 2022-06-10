using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Pract
{
    class Student
    {
        internal string LastName = "";
        internal string Name= "";
        internal string FatherName="";
        internal string Birthday  ="";
        internal string Sex = "";
        internal string Math = "";
        internal string English = "";
        internal string Physics = "";
        internal string Disckretka="";
        internal string MathLogic="";

        internal Student(string serialized = "") {

            if (serialized.Length > 0) {
                string[] fields = serialized.Split(';');
                LastName = fields[0];
                Name = fields[1];
                FatherName = fields[2];
                Birthday = fields[3];
                Sex = fields[4];

                string[] grants = fields[5].Split(',');
                Math = grants[0];
                English = grants[1];
                Physics = grants[2];
                Disckretka = grants[3];
                MathLogic = grants[4];

            }
        }
        internal ListViewItem ToListItem() {

            return new ListViewItem(new string[] { LastName, Name, FatherName, Birthday, Sex, Math, English, Physics, Disckretka, MathLogic });
        }

        internal bool HasGrants() {

            bool math = CheckSubject(Math);
            bool english = CheckSubject(English);
            bool physics = CheckSubject(Physics);
            bool diskretka = CheckSubject(Disckretka);
            bool mathLogic = CheckSubject(MathLogic);

            return math && english && physics && diskretka && mathLogic;
        }

        private bool CheckSubject(string sub) {
            return int.Parse(sub)>3;
        }

        internal string Serialize() {
            string grants = Math + ',' + English + ',' + Physics + ',' + Disckretka + ',' + MathLogic;
            return LastName + ";" + Name + ";" + FatherName + ";" + Birthday + ";" + Sex + ";"+ grants;
        } 


    }
}
