using Project.Classes;
using System;
using System.Collections;
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
    public partial class Menu : Form
    {
        private List<Patient> list;

        public Menu()
        {
            InitializeComponent();
            list = new List<Patient>();
        }

        public void addPatient(Patient p)
        {
            list.Add(p);
            Information inf = (Information)p.getInformation();
            String lastS = inf.lastSurvey.ToShortDateString().Equals("01.01.0001") ? "-" : inf.lastSurvey.ToShortDateString();
            dataGridView1.Rows.Add(inf.fName,inf.lName,inf.patronymic,inf.sitizenShip,inf.attachment,lastS);
            if(dataGridView1.Rows.Count==1)dataGridView1.ClearSelection();
            /*
            var l= from inf in list select inf.getInformation();
            dataGridView1.DataSource = from inf in list select (Information)inf.getInformation();
            */
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            Profile form1 = new Profile(this);
            form1.Show();
        }
        /* Profile form1 = new Profile(this);
            form1.Show();
            */

        private void PatientListButton_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   if (e.RowIndex<0) return;
            ProfileInfo form = new ProfileInfo(list[dataGridView1.CurrentRow.Index]);
            form.Show();
        }

        private void addAnalysButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пациента");
                return;
            }
            Analysis form = new Analysis(list[dataGridView1.CurrentRow.Index]);
            form.Show();
        }

        public void reload()
        {
            dataGridView1.Rows.Clear();
            foreach(Patient p in list){
                Information inf = (Information)p.getInformation();
                String lastS = inf.lastSurvey.ToShortDateString().Equals("01.01.0001") ? "-" : inf.lastSurvey.ToShortDateString();
                dataGridView1.Rows.Add(inf.fName, inf.lName, inf.patronymic, inf.sitizenShip, inf.attachment, lastS);
                if (dataGridView1.Rows.Count == 1) dataGridView1.ClearSelection();
            }

        }

        private void PatientListButton_Click_1(object sender, EventArgs e)
        {
            reload();
        }
    }
    
}
