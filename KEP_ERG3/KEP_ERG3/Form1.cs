using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace KEP_ERG3
{
    public partial class Form1 : Form
    {
        string name;
        string email;
        long phonenum;
        string birth_date;
        string aitima;
        string postal;
        DateTime date;
        string textbox;
        string[] strarray;
        string[] strarray2;
        public static HashSet<Userinfo> USERS= new HashSet<Userinfo>();
     


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.form1 = this;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            email = textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Length > 10) { MessageBox.Show("ΒΑΛΕ ΣΩΣΤΟ ΑΡΙΘΜΟ ΤΗΛΕΦΩΝΟΥ"); textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1); return; }   
                    phonenum = long.Parse(textBox3.Text);
                
            }
            catch (Exception) 
            {
                if (textBox3.Text == "") { return; }
               
                    MessageBox.Show("ERROR");
            
            }
            
        }
        List<int> nums = new List<int>{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
               

            if (textBox4.Text.ToArray().Length <= 0) return;
            if (textBox4.Text.ToArray()[0] == ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 1) return;
            if (textBox4.Text.ToArray()[1] == ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 2) return;
            if (textBox4.Text.ToArray()[2] != ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 3) return;
            if (textBox4.Text.ToArray()[3] == ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 4) return;
            if (textBox4.Text.ToArray()[4] == ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 5) return;
            if (textBox4.Text.ToArray()[5] != ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 6) return;
            if (textBox4.Text.ToArray()[6] == ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 7) return;
            if (textBox4.Text.ToArray()[7] == ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 8) return;
            if (textBox4.Text.ToArray()[8] == ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length <= 9) return;
            if (textBox4.Text.ToArray()[9] == ' ') { MessageBox.Show("ΛΑΘΟΣ ΗΜΕΡΟΜΗΝΙΑ ΠΧ 24 02 2003"); textBox4.Text = ""; return; }
            if (textBox4.Text.ToArray().Length > 10) { textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);  return; }





        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            aitima = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            postal = textBox6.Text;
        }


        string errormessage = "";

        private void button1_Click(object sender, EventArgs e)
        {


            // EDW PREPEI NA GINEI ELEGXOS AN TO INPUT STHN HMEROMHNIA EINAI VALID OI ARITHMOI ALLIWS RETURN KAI MHDENISE PALI TA PANTA
            if (textBox4.Text.Length == 10)
            {
                strarray2 = textBox4.Text.Split(' ');
                int day2 = int.Parse(strarray2[0]);
                int month2 = int.Parse(strarray2[1]);
                int year2 = int.Parse(strarray2[2]);
                if (day2 > 31 || month2 > 12 || year2 > 2023 || day2==0 || month2 ==0 || year2==00) { textBox4.Text = ""; }
            }
            else if(textBox4.Text.Length > 0) { textBox4.Text = ""; }
            // HMEROMHNIA GENNHSHS
            if (textBox4.Text.Length == 10) // EDW EXOUME TO ERROR PWS MPORW NA BALW NA ARXIKOPOIEI SWSTA THN HMEROMHNIA
            {
                strarray = textBox4.Text.Split(' ');// EAN HMEROMHNIA GENNHSHS KENO TOTE ERROR
               
                int year = int.Parse(strarray[2]);
                int day = int.Parse(strarray[0]);
                int month = int.Parse(strarray[1]);

                
                birth_date = strarray[0] + " " + strarray[1] + " " + strarray[2]; // AN BALEIS APAGOREUMENI HMEROMHNIA TOTE BGALE ERROR
            }
            else if(textBox4.Text.Length >0 ) { textBox4.Text = ""; }// DEN ARXIKOPOIHTE SWSTA H HMEROMHNIA GENNHSHS
            //
            //THLEFWNO
           
            if(textBox1.Text == "") { errormessage += " " + "ΒΑΛΕ ΟΝΟΜΑ " + "\n"; }
            if (textBox2.Text == "" || !textBox2.Text.Contains("@")) { errormessage += " " + "ΒΑΛΕ EMAIL " + "\n"; }
            if (textBox3.Text.Length != 10) { errormessage += " " + "ΒΑΛΕ ΤΗΛΕΦΩΝΟ ΕΠΙΚΟΙΝΩΝΙΑΣ " + "\n"; }
            if (textBox4.Text == "") { errormessage += " " + "ΒΑΛΕ ΗΜΕΡΟΜΗΝΙΑ ΓΕΝΝΗΣΗΣ " + "\n";  }
            if (textBox5.Text == "") { errormessage += " " + "ΒΑΛΕ ΕΙΔΟΣ ΑΙΤΗΜΑΤΟΣ " + "\n";  }
            if (textBox6.Text == "") { errormessage += " " + "ΒΑΛΕ ΔΙΕΥΘΥΝΣΗ ΚΑΤΟΙΚΙΑΣ " + "\n";  }
            if (errormessage != "")
            {
                MessageBox.Show(errormessage);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                errormessage = "";
                return;
            }


            Userinfo user = new Userinfo(Program.generateId(),name, email, phonenum, birth_date, aitima, postal, DateTime.Now);
            USERS.Add(user);
            Program.getFileManager().saveuser(user);


            this.Hide();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            new Form2().Show();

        }

        //ONLY DIGITS 
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }
       
        //ONLY DIGITS AND SPACE
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Space) { e.Handled = true; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox1.Focus();
            errormessage = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space)  { e.Handled = true; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {




            new DataShow().Show();
           




        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
