using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class Diagnosis: ICloneable // Диагноз пациента, класс пациент (Patient) содержит класс Диагноз (Diagnosis)
    {
        internal Dictionary<Doctor, Disease> diagnosisData { get; set; }

        public Diagnosis(Disease disease, Doctor doctor)
        {
            diagnosisData = new Dictionary<Doctor, Disease>();
            diagnosisData.Add(doctor, disease);
        }

        public Diagnosis MuCloneClass()
        {

            Diagnosis _diagnosis = new Diagnosis( diagnosisData.GetEnumerator().Current.Value, diagnosisData.GetEnumerator().Current.Key);
            foreach (var data in diagnosisData)
            {
                _diagnosis.AddDiagnosis(data.Key, data.Value);
            }
            return _diagnosis;
        }

        internal void AddDiagnosis(Doctor doctor, Disease disease)
        {
            if (diagnosisData.Count == 0 || diagnosisData == null)
            {
                diagnosisData = new Dictionary<Doctor, Disease>();
                diagnosisData.Add(doctor, disease);
            }
            diagnosisData.TryAdd(doctor, disease);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
