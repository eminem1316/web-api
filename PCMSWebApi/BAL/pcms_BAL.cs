using PCMSWebApi.DAL;
using PCMSWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PCMSWebApi.BAL
{
    public class pcms_BAL
    {
        pcms_DAL objDAL = new pcms_DAL();
        public pcms_User InsertUserDetail(pcms_User _user)
        {
            pcms_DAL objDAL = new pcms_DAL();
            return objDAL.InsertUserDetail(_user);
        }
        public pcms_KeyRule RuleInformarion(pcms_Rule _rule)
        {

            return objDAL.RuleInformarion(_rule);
        }
        public string InsertUserActivity(int userID, string activitLog)
        {
            return objDAL.InsertUserActivity(userID, activitLog);
        }

    }
}