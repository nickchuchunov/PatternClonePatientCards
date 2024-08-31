using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class Patient : HistoryPatient,  ICloneable // У пациента есть диагноз 
    {
        internal string PatientSurname { get; set; }
        internal string PatientName { get; set; }
        internal DateTime PatientDateBirth { get; set; }
        internal Diagnosis Diagnosis; // У пациента есть диагноз 
        internal Patient(string surname, string name, DateTime dateBirth, Disease disease, Doctor doctor) 
        {
            PatientSurname = surname;
            PatientName = name;
            PatientDateBirth = dateBirth;
            Diagnosis = new Diagnosis(disease, doctor);
        }

        public new object Clone()
        {
            return MemberwiseClone();
        }
    }
}


