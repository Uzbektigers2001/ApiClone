using ApiClone.Core.Interfaces;
using ApiClone.Data;
using ApiClone.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Core.Services
{
    public class HomeService : IHomeService
    {
        private readonly ApiCloneDBContext _dbcontext;

        public HomeService( ApiCloneDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public string OvirPassports(string PinFL)
        {
            OvirPassports res = _dbcontext.ovirPassports.FirstOrDefault(p => p.PinFL == PinFL);
            return JsonConvert.SerializeObject(res);
        }


        public string Alimony(string PinFL)
        {
            return PinFL;
        }

        public string GetInn(string PinFL)
        {
            throw new NotImplementedException();
        }

       
    }
}
