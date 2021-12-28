using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClone.Domain.Models
{
    public class PersonAlimonies
    {
        public Request request { get; set; }
        public Response response { get; set; }
        public int result_code { get; set; }
        public string result_message { get; set; }
    }

    public class Request
    {
        public string pinfl { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }

    public class creditor_info
    {
        public string pinfl;
        public string fio { get; set; }
        public string birth_date { get; set; }
    }


    [Table("GetDataOfPersonByPinFL")]
    public class CreditorInfo
    {
        [Key]
        [Column("PersonID")]
        public long Id { get; set; }
        public string PinFL { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public class ExecWork
    {
        public string work_number { get; set; }
        public List<object> payments { get; set; }
    }

    public class Response
    {
        public creditor_info creditor_info { get; set; }
        public List<ExecWork> exec_works { get; set; }
    }

    public class DataIsNull
    {
        public string status { get; set; } = "NOT_FOUND";

        public string timestamp { get; set; } = DateTime.Now.ToString();

        public int result_code { get; set; } = 50;

        public string result_message { get; set; } = "Данные не найдены";
    }

 
}
