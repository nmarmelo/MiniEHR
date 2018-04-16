using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEHR
{
    public class Patient
    {
        public String first, last, phone;
        DateTime dob;

        public Patient()
        {
            first = "";
            last = "";
            phone = "";
            dob = DateTime.Now;
        }

        public Patient(String first, String last, String phone, DateTime dob)
        {
            this.first = first;
            this.last = last;
            this.phone = phone;
            this.dob = dob;
        }

        override
        public String ToString()
        {
            String date = dob.ToShortDateString();
            String info =
                first + "\n" +
                last + "\n" +
                phone + "\n" +
                date + "\n";
            return info;
        }

        public String calculateDetailedAge()
        {
            String detailedAge = "";

            Age age = new Age(dob);

            detailedAge = age.Years + " years, " + 
                age.Months + " months, and " +
                age.Days + " days";

            return detailedAge;
        }

        public String getDate()
        {
            return dob.ToString("yyyy-MM-dd");
        }
    }

}
