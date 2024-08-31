using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
   public interface IDisease
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool RecoveryStatus { get; set; }
        public  DateTime DateOnsetIllness { get; set; }
        public  DateTime DateRecovery { get; set; }

    }
}
