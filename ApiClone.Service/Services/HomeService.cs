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
            List<OvirPassports> res = _dbcontext.ovirPassports.Where(p => p.PinFL == PinFL).ToList();

            Root root = new Root();
            root.PinFL = PinFL;

            List<Passport> passports = new List<Passport>();

            foreach (var item in res)
            {
                Passport passport = new Passport();
                passport.PasspSer = item.PasspSer;
                passport.PasspNum = int.Parse(item.PasspNum);
                passports.Add(passport);
            }
            root.Passports = passports;

            return JsonConvert.SerializeObject(root);
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
