using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Patient
    {
        AbstractInformation information;

        private Patient()
        {

        }

        public Patient(AbstractInformation information)
        {
            this.information = information;   
        }

        public AbstractInformation getInformation()
        {
            return information;
        }
    }
}
