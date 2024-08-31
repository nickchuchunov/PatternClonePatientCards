using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    public interface IDoctor
    {
        public string DoctorSurname { get; set; }
        public string DoctorName { get; set; }
        public DateTime DoctorDateBirth { get; set; }
        public string DoctorProfession { get; set; }
        public string DoctorSpecialization { get; set; }
    }
}
