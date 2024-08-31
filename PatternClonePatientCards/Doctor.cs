using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class Doctor : IDoctor, ICloneable  // Доктор пишет диагноз по каждой болезни больного 
    {
        public string DoctorSurname { get; set; }
        public string DoctorName { get; set; }
        public DateTime DoctorDateBirth { get; set; }
        public string DoctorProfession { get; set; }
        public string DoctorSpecialization { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
