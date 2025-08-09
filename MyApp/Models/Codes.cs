using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    class Codes
    {
        public int id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string ActivationCode { get; set; }
        
        public Codes(int _id, string _code, string _description, string activationCode)
        {
            id = _id;
            code = _code;
            description = _description;
            ActivationCode = activationCode;
        }

        public Codes() { }
    }
}
