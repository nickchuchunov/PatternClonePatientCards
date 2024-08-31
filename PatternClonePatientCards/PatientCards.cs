using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class PatientCards : Patient,  ICloneable // У карточки пациента есть Инфорация о пациенте (Patient) а пациент в свою очередь содержит диагноз (Diagnosis)
    {
        
        public PatientCards() : base(string.Empty, string.Empty, DateTime.Now, new Disease() , new Doctor() )
        {
        }

        public new object Clone()
        {
            return MemberwiseClone();
        }
    }
}
