using ApiClone.Data;
using ApiClone.Domain.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Core.NewService.Concrete
{
    public class Service : IService
    {
        private readonly ApiCloneDBContext _dbcontext;

        public Service(ApiCloneDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }


        public string GetMofScholarship(string PINFL, string StartDate, string EndDate)
        {
            try
            {
                var result = _dbcontext.InComes.FromSqlRaw($"GetMofScholarship {PINFL} ").ToList();

                MofScholarship mof = new MofScholarship();

                var nameWithPinFL = (PinFLWithName)_dbcontext.pinFLWithNames.FromSqlRaw($"GetMofScholarshipName {PINFL} ").ToList()[0];
                mof.PinFL = nameWithPinFL.PinFL;
                mof.Name = nameWithPinFL.Name;

                if (result.Count != 0)
                {
                    mof.InComes = result;
                    return JsonConvert.SerializeObject(mof);
                }
                mof.InComes = null;
                return JsonConvert.SerializeObject(mof);

            }
            catch
            {
                ErrorMofScholarship error = new ErrorMofScholarship();
                return JsonConvert.SerializeObject(error.ToString());
            }
        }

        public string GetMolDisability(string json)
        {
            throw new NotImplementedException();
        }

        public string GetPersonInfoByPinFL(string PinFL)
        {
            throw new NotImplementedException();
        }
    }
}
