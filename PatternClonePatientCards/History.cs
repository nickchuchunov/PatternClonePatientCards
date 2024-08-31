using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    public class History : IDoctor, IDisease 
    {
        public string DoctorSurname { get; set; }
        public string DoctorName { get; set; }
        public DateTime DoctorDateBirth { get; set; }
        public string DoctorProfession { get; set; }
        public string DoctorSpecialization { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool RecoveryStatus { get; set; }
        public DateTime DateOnsetIllness { get; set; }
        public DateTime DateRecovery { get; set; }
    }
}
