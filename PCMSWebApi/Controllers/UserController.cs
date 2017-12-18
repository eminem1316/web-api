using PCMSWebApi.BAL;
using PCMSWebApi.Filters;
using PCMSWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace PCMSWebApi.Controllers
{
   // [ValidateHttpAntiForgeryToken]
    public class UserController : ApiController
    {
        // GET: api/User
         [Route("api/User/Get/{userID}/{userActivity}")]
        public HttpResponseMessage Get(int userID, string userActivity)
        {
            string _userID = "0";
            string json = null;
            pcms_BAL objBAL = new pcms_BAL();
            _userID = objBAL.InsertUserActivity(userID, userActivity);
            var response2 = this.Request.CreateResponse(HttpStatusCode.OK);
            if (_userID.Contains("Inserted"))
                json = "[{'UserID':'" + _userID + "','Status':'','Success':''}]";
            else
            {
                json = "[{'UserID':'','Status':'','Failure':''}]";
            }
            response2.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return response2;
        }

        // GET: api/User/5
         [Route("api/User/PostRule")]
         [HttpPost]
         public IHttpActionResult PostRule([FromBody] pcms_Rule _rule)
         {
             // string MS = "";
             pcms_KeyRule objKeyRule = new pcms_KeyRule();
             if (_rule != null)
             {
                 pcms_BAL objBAL = new pcms_BAL();
                 objKeyRule = objBAL.RuleInformarion(_rule);
                 //var response = this.Request.CreateResponse(HttpStatusCode.OK);
                 //DataTableToJson json = new DataTableToJson();
                 //if (yourJson.Rows.Count > 0)
                 //{
                 //    response.Content = new StringContent(json.DataTableToJsonObj(yourJson), Encoding.UTF8, "application/json");
                 //    return response;
                 //}
                 //else
                 //{
                 //    var response1 = this.Request.CreateResponse(HttpStatusCode.OK);
                 //    string jsonData = "[{'RULE_ID':null,'RULE_APPLIED_URL':null,'CONTENT_HTML':null,'DESIGN_HTML':null,'POPUP_HTML':null}]";
                 //    response1.Content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                 //    return response1;
                 //}
             }
             else
             {
                 //var response2 = this.Request.CreateResponse(HttpStatusCode.OK);
                 //string json = "[{'RULE_ID':'','RULE_APPLIED_URL':'','CONTENT_HTML':'','DESIGN_HTML':'','POPUP_HTML':''}]";
                 //response2.Content = new StringContent(json, Encoding.UTF8, "application/json");
                 //return response2;
             }
             return Ok(objKeyRule);

         }

        // POST: api/User
        //public void Post([FromBody]string value)
        //{

        //}

        // POST: api/User
        [HttpPost]
        public IHttpActionResult PostUserDetail([FromBody] pcms_User _user)
        {
            // int _userId = 0;
            pcms_User objUser = new pcms_User();
            try
            {
                pcms_BAL objBAL = new pcms_BAL();
                objUser = objBAL.InsertUserDetail(_user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Ok(objUser);
        }


        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
