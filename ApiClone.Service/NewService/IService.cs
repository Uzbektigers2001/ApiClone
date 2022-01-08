using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Core.NewService
{
    public interface IService
    {
        string GetMofScholarship(string PINFL, string StartDate, string EndDate);
        
        string GetMolDisability(string json);

        string GetPersonInfoByPinFL(string PinFL);
    }
}
