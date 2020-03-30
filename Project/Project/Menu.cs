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
            
            dataGridView1.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addAnalysisButton_Click(object sender, EventArgs e)
        {
            Information info=null;
            Analysis form = new Analysis(info);
            form.Show();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            Profile form1 = new Profile();
            form1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PatientListButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
