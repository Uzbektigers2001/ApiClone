using ApiClone.Core.Interfaces;
using ApiClone.Data;
using ApiClone.Domain;
using ApiClone.Domain.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        private IMapper _mapper;

        public HomeService( ApiCloneDBContext dbcontext, IMapper mapper)
        {
            _mapper = mapper;
            _dbcontext = dbcontext;
        }

        public string GetOvirPassports(string PinFL)
        {
            List<OvirPassports> res = _dbcontext.OvirPassports.Where(p => p.PinFL == PinFL).ToList();

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

        public string GetInn(string PinFL)
        {
            var result = _dbcontext.TaxCommiteeInns.FromSqlRaw($"EXEC GetINNByPinFL {PinFL}").ToList();

            try
            {
                ResponseInn res = new ResponseInn();
                if (result is null)
                {
                    res.success = false;
                    res.code = "2";
                    res.description = "Bu PinFL buyicha hech qanday ma'lumot topilmadi";
                    res.data = null;
                    res.ToString();

                    return JsonConvert.SerializeObject(res);
                }

                res.success = true;
                res.code = "1";
                res.description = "Response Done";
                res.data = result[0];
                res.ToString();

                return JsonConvert.SerializeObject(res);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GetAlimony(object json)
        {
            Request jsonReq =  new Request();
            jsonReq = JsonConvert.DeserializeObject<Request>(json.ToString());

            try
            {
                var result = _dbcontext.CreditorInfo.FromSqlRaw($"GetDataOfPersonByPinFL {jsonReq.pinfl}").ToList();

                Request request = new Request();
                request.pinfl = jsonReq.pinfl;
                request.start_date = jsonReq.start_date;
                request.end_date = jsonReq.end_date;

                creditor_info creditorInfo = new creditor_info();
                creditorInfo.pinfl = result[0].PinFL;
                creditorInfo.fio = $"{result[0].Surname} {result[0].FirstName} {result[0].Patronymic}";

                Response response = new Response();

                response.exec_works = null;
                response.creditor_info = creditorInfo;
                
                PersonAlimonies personAlimonies = new PersonAlimonies();
                personAlimonies.request = request;
                personAlimonies.response = response;
                personAlimonies.result_code = 0;
                personAlimonies.result_message = "Данные успешно обработаны";

                personAlimonies.ToString();

                return JsonConvert.SerializeObject(personAlimonies);

            }
                
            catch
            {
                DataIsNull data = new DataIsNull();
                data.ToString();
                return JsonConvert.SerializeObject(data);
            }


        }

        public string GetCapitalMarket(string Inn)
        {
            var result = _dbcontext.PersonCapitalMarkets.FromSqlRaw($"EXEC GetPersonCapitalMarketsForApiClone {Inn}");
            if(result is not null){
                return JsonConvert.SerializeObject(result);
            }
            return JsonConvert.SerializeObject(new BadRequestCapitalMarkets());
        }

        public string GetGaiAutos(string PinFl)
        {
            throw new NotImplementedException();
        }

        public string GetHigerEducation(string PinFL)
        {
           IEnumerable<GetPersonIdWithPinFLForApiClone> res = _dbcontext.getPersonIdWithPinFL.FromSqlRaw($"GetPersonIdWithPinFLForApiClone '{PinFL}'").AsEnumerable();

            PersonHigherEducation result = _dbcontext.PersonHigherEducationData.FirstOrDefault(p => p.PersonID == res.ToList()[0].PersonID);

            HigherEducation higherEducation = _mapper.Map<HigherEducation>(result);

            return JsonConvert.SerializeObject(higherEducation);
        }

        
    }
}
