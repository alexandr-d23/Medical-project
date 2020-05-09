using Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ProfileInfo : Form
    {
        Information info;
        Patient patient;
        bool edited;
        public ProfileInfo(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void ProfileInfo_Load(object sender, EventArgs e)
        {
            info = patient.getInformation();
            textBox1.Text = info.fName;
            textBox2.Text = info.lName;
            textBox3.Text = info.patronymic;
            comboBox1.Text = info.gender ? "Мужской" : "Женский";
            maskedTextBox1.Text = info.birthday.ToShortDateString();
            textBox4.Text = info.sitizenShip;
            maskedTextBox2.Text = info.passportData;
            maskedTextBox3.Text = info.insurancePolicy;
            textBox5.Text = info.attachment;
            maskedTextBox4.Text = info.lastSurvey.ToShortDateString().Equals("01.01.0001") ? "-" : info.lastSurvey.ToShortDateString();
        }

        private void addAnalysButton_Click(object sender, EventArgs e)
        {
            Analysis form = new Analysis(patient);
            form.owner = this;
            form.Show();
        }

        public void changeLastSurvey()
        {
            if (maskedTextBox4.Text != patient.getInformation().lastSurvey.ToShortDateString()) maskedTextBox4.Text = patient.getInformation().lastSurvey.ToShortDateString();
        }

        private void show_Click(object sender, EventArgs e)
        {   if (show.Text == "показать")
            {
                show.Text = "скрыть";
                Form1 form = new Form1(this);
                form.Show();
            }
            else
            {
                show.Text = "показать";
                richTextBox1.Visible = true;
                maskedTextBox2.Visible = false;
            }
        }

        public void passportDataShow()
        {
            richTextBox1.Visible = false;
            maskedTextBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Information info = patient.getInformation();
            if (Check_Correct())
            {
                try
                {
                    string fName = textBox1.Text;
                    string lName = textBox2.Text;
                    string patronymic = textBox3.Text;                                      
                    Boolean gender = comboBox1.Text == "Мужской" ? true : false;
                    String[] b = maskedTextBox1.Text.Split('.');
                    DateTime birthday = new DateTime(Convert.ToInt32(b[2]), Convert.ToInt32(b[1]), Convert.ToInt32(b[0]));
                    string sitizenShip = textBox4.Text;
                    string passportData = maskedTextBox2.Text;
                    string insurancePolicy = maskedTextBox3.Text;
                    string attachment = textBox5.Text;
                    
                }
                catch
                {
                    MessageBox.Show("Поле \"Дата рождения\" заполнено некорректно");
                }
            }
        }

        private bool Check_Correct()
        {
            bool b = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && string.IsNullOrWhiteSpace(c.Text) || c is MaskedTextBox && !(c as MaskedTextBox).MaskCompleted)
                {
                    b = false;
                    MessageBox.Show("Заполните все поля");
                    break;
                }
                string[] s = maskedTextBox1.Text.Split('.');

                if (Convert.ToInt32(s[2]) < 1900 || 1 > Convert.ToInt32(s[1]) || Convert.ToInt32(s[1]) > 12 || 1 > Convert.ToInt32(s[0]) || Convert.ToInt32(s[0]) > 31)
                {
                    b = false;
                    MessageBox.Show("Поле \"Дата рождения\" заполнено некорректно");
                    break;
                }

            }
            return b;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != info.fName) {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != info.lName)
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != info.patronymic)
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string s;
            if (info.gender == true)
            {
                s = "мужской";
            }
            else s = "женский";
            if (comboBox1.Text != s)
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            String[] b = maskedTextBox1.Text.Split('.');
            DateTime birthday = new DateTime(Convert.ToInt32(b[2]), Convert.ToInt32(b[1]), Convert.ToInt32(b[0]));
            if (birthday.Equals(info.birthday))
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != info.sitizenShip)
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {

            if(maskedTextBox2.Text != info.passportData)
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {

            if (maskedTextBox3.Text != info.insurancePolicy)
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != info.attachment)
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            String[] b = maskedTextBox1.Text.Split('.');
            DateTime last = new DateTime(Convert.ToInt32(b[2]), Convert.ToInt32(b[1]), Convert.ToInt32(b[0]));
            if (last.Equals(info.lastSurvey))
            {
                edited = true;
                save.Enabled = true;
            }
            else
            {
                edited = false;
                save.Enabled = false;
            }
        }
    }
}
