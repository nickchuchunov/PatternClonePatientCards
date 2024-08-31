using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class ClonePatientCards: IMyCloneable<PatientCards>
    {

        public PatientCards MuCloneClass(PatientCards _patientCards)
        {

            PatientCards patientCards = new PatientCards();

            patientCards.PatientName = _patientCards.PatientName;
            patientCards.PatientSurname = _patientCards.PatientSurname;
            patientCards.PatientDateBirth = _patientCards.PatientDateBirth;
            foreach (var p in _patientCards.Diagnosis.diagnosisData)
            {
                patientCards.Diagnosis.AddDiagnosis(p.Key, p.Value);
            }

            foreach (History p in _patientCards.ListHistoryPatient )
            {

                patientCards.AddListHistoryPatient(p);


            }

            return patientCards;
        }
    }
}
