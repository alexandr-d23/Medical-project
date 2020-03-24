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
    public partial class Analysis : Form
    {
        private Classes.Information info;
        public Analysis(Classes.Information info)
        {
            this.info = info;
            InitializeComponent();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {

        }

    }
}
