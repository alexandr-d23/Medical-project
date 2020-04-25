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
        Patient patient;
        public ProfileInfo(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void ProfileInfo_Load(object sender, EventArgs e)
        {
            Information info = patient.getInformation();
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
    }
}
