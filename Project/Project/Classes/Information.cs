using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Classes
{
    public class Information
    {
        private string fName { get; set; }
        private string lName { get; set; }
        private string patronymic { get; set; }
        private Boolean gender { get; set; }
        private DateTime birthday { get; set; }
        private string sitizenShip { get; set; }
        private string passportData { get; set; }
        private string attachment { get; set; }
        private DateTime lastSurvey { get; set; }

        private Information()
        {

        }

        public Information(string fName, string lName, string patronymic, DateTime birthday, string sitizenShip, string passportData, string attachment, DateTime lastSurvey)
        {
            this.fName = fName;
            this.lName = lName;
            this.patronymic = patronymic;
            this.birthday = birthday;
            this.sitizenShip = sitizenShip;
            this.passportData = passportData;
            this.attachment = attachment;
            this.lastSurvey = lastSurvey;
        }

    }
}
