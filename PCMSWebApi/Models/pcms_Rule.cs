using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCMSWebApi.Models
{
    public class pcms_Rule
    {
        public int BROWSER { get; set; }
        public int DEVICE { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
        public string IP { get; set; }
        public string REGION { get; set; }
        public string TIMEZONE { get; set; }
        public string USERID { get; set; }
        public string USERTYPE { get; set; }
        public string ZIP { get; set; }
        public string URL { get; set; }

      
       
    }
}