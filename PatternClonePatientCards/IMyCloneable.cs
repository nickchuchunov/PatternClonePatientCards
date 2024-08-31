using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal interface IMyCloneable <T>
    {
        public T MuCloneClass(T t);
    }
}
