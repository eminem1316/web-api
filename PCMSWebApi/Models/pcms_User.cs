using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCMSWebApi.Models
{
    public class pcms_User
    {
        public int USER_PK { get; set; }
        public int USER_ID { get; set; }
        public string USER_IP { get; set; }
        public string USER_GENDER { get; set; }
        public string USER_CITY { get; set; }
        public string USER_URL { get; set; }
        public string USER_BROWSER { get; set; }
        public string USER_COUNTRY_NAME { get; set; }
        public string USER_REGION { get; set; }
        public string USER_TIMEZONE { get; set; }
        public string USER_ZIP { get; set; }
        public string USER_TYPE { get; set; }
        public DateTime? COOKIE_CREATION_DATE { get; set; }
        public string INSERTED_BY { get; set; }
        public DateTime INSERTED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public int TS_CNT { get; set; }
    }
}