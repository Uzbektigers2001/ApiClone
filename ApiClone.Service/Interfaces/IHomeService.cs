using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Core.Interfaces
{
    public interface IHomeService
    {
        string OvirPassports(string PinFL);
        string GetInn(string PinFL);
        string Alimony(string PinFL);
    }
}
