using ApiClone.Core.Interfaces;
using ApiClone.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Core.Services
{
    internal class HomeService : IHomeService
    {
        private readonly ApiCloneDBContext _dbcontext;

        public HomeService( ApiCloneDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public string Alimony(string PinFL)
        {
            return PinFL;
        }

        public string GetInn(string PinFL)
        {
            throw new NotImplementedException();
        }

        public string OvirPassports(string PinFL)
        {
            throw new NotImplementedException();
        }
    }
}
