using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCMSWebApi.Models
{
    public class pcms_KeyRule
    {
        public string CAMPAIGN_CONTAINER_ID { get; set; }
        public string RULE_PARAMETER_KEY_VALUE { get; set; }
        public string CONTENT_HTML { get; set; }
        public string DESIGN_HTML { get; set; }
        public string POPUP_HTML { get; set; }
        public string CAMPAIGN_REDIRECT_URL { get; set; }
    }
}