using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FullResponderInfo : Responder
    {
        private int availability;
        private int experienceYears;
        private List<string> certifications;

        public int Availability { get => availability; set => availability = value;}
        public int ExperienceYears {  get => experienceYears; set => experienceYears = value;}

        public List<string> Certifications { get => certifications; set => certifications = value;}
    }
}
