using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class Disease : IDisease,  ICloneable // Болезнь является частью диагноза не наследуется создается через New
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool RecoveryStatus { get; set; }
        public DateTime DateOnsetIllness { get; set; }
        public DateTime DateRecovery { get; set; }

        internal Disease()
        { }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
