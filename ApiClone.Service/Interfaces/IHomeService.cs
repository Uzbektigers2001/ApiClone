using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Core.Interfaces
{
    public interface IHomeService
    {
        string GetOvirPassports(string PinFL);

        string GetInn(string PinFL);

        string GetAlimony(object json);

        string GetCapitalMarket(string Inn);

        string GetGaiAutos(string PinFl);
    }
}
