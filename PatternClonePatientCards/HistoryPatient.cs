using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PatternClonePatientCards
{
    internal class HistoryPatient
    {
        internal List<History> ListHistoryPatient { get; set; }


    internal   HistoryPatient() 
        {
            ListHistoryPatient = new List<History>();


        }


        internal void AddListHistoryPatient(Diagnosis diagnosis)
        {
            foreach (var history in diagnosis.diagnosisData)
            {
                if (history.Value.RecoveryStatus == true)
                {
                    History history1 = new History();
                    history1.DoctorSurname = history.Key.DoctorSurname;
                    history1.DoctorName = history.Key.DoctorName;
                    history1.DoctorDateBirth = history.Key.DoctorDateBirth;
                    history1.DoctorProfession = history.Key.DoctorProfession;
                    history1.DoctorSpecialization = history.Key.DoctorSpecialization;

                    history1.Name = history.Value.Name;
                    history1.Description = history.Value.Description;
                    history1.RecoveryStatus = history.Value.RecoveryStatus;
                    history1.DateOnsetIllness = history.Value.DateOnsetIllness;
                    history1.DateRecovery = history.Value.DateRecovery;
                    ListHistoryPatient .Add(history1);
                }
             }
        }


        internal void AddListHistoryPatient(History history) 
        {
           
            ListHistoryPatient.Add(history);

        }



    }
}
