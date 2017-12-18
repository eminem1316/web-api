using PCMSWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PCMSWebApi.DAL
{
    public class pcms_DAL
    {
        public string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PCMS_DbConnection"].ConnectionString;
        public pcms_User InsertUserDetail(pcms_User _user)
        {
            // var _userId = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    cmd = new SqlCommand(null, con);
                    cmd.CommandText = "select count(*) as count from pcms_user where USER_ID=@USER_ID";
                    SqlParameter USER_ID = new SqlParameter("@USER_ID", SqlDbType.Int, 1024);
                    USER_ID.Value = _user.USER_ID;
                    cmd.Parameters.Add(USER_ID);
                    cmd.Prepare();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (Convert.ToInt16(dr[0]) > 0)
                            {
                                cmd = new SqlCommand(null, con);
                                cmd.CommandText = @"UPDATE pcms_user
                                   SET USER_IP = @USER_IP
                                      ,USER_GENDER = @USER_GENDER
                                      ,USER_CITY = @USER_CITY
                                      ,USER_URL = @USER_URL
                                      ,USER_BROWSER = @USER_BROWSER
                                      ,USER_COUNTRY_NAME = @USER_COUNTRY_NAME
                                      ,USER_REGION = @USER_REGION
                                      ,USER_TIMEZONE = @USER_TIMEZONE
                                      ,USER_ZIP = @USER_ZIP
                                      ,USER_TYPE = @USER_TYPE
                                      ,COOKIE_CREATION_DATE = @COOKIE_CREATION_DATE
                                      ,INSERTED_BY = @INSERTED_BY
                                      ,INSERTED_DATE = @INSERTED_DATE
                                      ,UPDATED_BY = @UPDATED_BY
                                      ,UPDATED_DATE = @UPDATED_DATE
                                      ,TS_CNT = @TS_CNT
                                 WHERE USER_ID=@USER_ID";

                                SqlParameter USER_IP = new SqlParameter("@USER_IP", SqlDbType.VarChar, 50);
                                SqlParameter USER_GENDER = new SqlParameter("@USER_GENDER", SqlDbType.NVarChar, 50);
                                SqlParameter USER_CITY = new SqlParameter("@USER_CITY", SqlDbType.NVarChar, 100);
                                SqlParameter USER_URL = new SqlParameter("@USER_URL", SqlDbType.VarChar);
                                SqlParameter USER_BROWSER = new SqlParameter("@USER_BROWSER", SqlDbType.VarChar, 50);
                                SqlParameter USER_COUNTRY_NAME = new SqlParameter("@USER_COUNTRY_NAME", SqlDbType.NVarChar, 100);
                                SqlParameter USER_REGION = new SqlParameter("@USER_REGION", SqlDbType.NVarChar, 50);
                                SqlParameter USER_TIMEZONE = new SqlParameter("@USER_TIMEZONE", SqlDbType.NVarChar, 100);
                                SqlParameter USER_ZIP = new SqlParameter("@USER_ZIP", SqlDbType.NVarChar, 10);
                                SqlParameter USER_TYPE = new SqlParameter("@USER_TYPE", SqlDbType.NVarChar, 16);
                                SqlParameter COOKIE_CREATION_DATE = new SqlParameter("@COOKIE_CREATION_DATE", SqlDbType.DateTime, 16);
                                SqlParameter INSERTED_BY = new SqlParameter("@INSERTED_BY", SqlDbType.NVarChar, 50);
                                SqlParameter INSERTED_DATE = new SqlParameter("@INSERTED_DATE", SqlDbType.DateTime, 16);
                                SqlParameter UPDATED_BY = new SqlParameter("@UPDATED_BY", SqlDbType.NVarChar, 50);
                                SqlParameter UPDATED_DATE = new SqlParameter("@UPDATED_DATE", SqlDbType.DateTime, -1);
                                SqlParameter TS_CNT = new SqlParameter("@TS_CNT", SqlDbType.Int, 16);
                                USER_IP.Value = _user.USER_IP;
                                USER_GENDER.Value = _user.USER_GENDER;
                                USER_CITY.Value = _user.USER_CITY;
                                USER_URL.Value = _user.USER_URL;
                                USER_BROWSER.Value = _user.USER_BROWSER;
                                USER_COUNTRY_NAME.Value = _user.USER_COUNTRY_NAME;
                                USER_REGION.Value = _user.USER_REGION;
                                USER_TIMEZONE.Value = _user.USER_TIMEZONE;
                                USER_ZIP.Value = _user.USER_ZIP;
                                USER_TYPE.Value = _user.USER_TYPE;
                                COOKIE_CREATION_DATE.Value = _user.COOKIE_CREATION_DATE;
                                INSERTED_BY.Value = _user.INSERTED_BY;
                                INSERTED_DATE.Value = _user.INSERTED_DATE;
                                UPDATED_BY.Value = _user.UPDATED_BY;
                                UPDATED_DATE.Value = _user.UPDATED_DATE;
                                TS_CNT.Value = _user.TS_CNT;
                                cmd.Parameters.Add(USER_IP);
                                cmd.Parameters.Add(USER_GENDER);
                                cmd.Parameters.Add(USER_CITY);
                                cmd.Parameters.Add(USER_URL);
                                cmd.Parameters.Add(USER_BROWSER);
                                cmd.Parameters.Add(USER_COUNTRY_NAME);
                                cmd.Parameters.Add(USER_REGION);
                                cmd.Parameters.Add(USER_TIMEZONE);
                                cmd.Parameters.Add(USER_ZIP);
                                cmd.Parameters.Add(USER_TYPE);
                                cmd.Parameters.Add(COOKIE_CREATION_DATE);
                                cmd.Parameters.Add(INSERTED_BY);
                                cmd.Parameters.Add(INSERTED_DATE);
                                cmd.Parameters.Add(UPDATED_BY);
                                cmd.Parameters.Add(UPDATED_DATE);
                                cmd.Parameters.Add(TS_CNT);
                                cmd.Prepare();
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                cmd = new SqlCommand(null, con);
                                cmd.CommandText = @"insert into pcms_user(USER_IP,USER_GENDER,USER_CITY
                                                    ,USER_URL,USER_BROWSER,USER_COUNTRY_NAME,USER_REGION
                                                    ,USER_TIMEZONE,USER_ZIP,USER_TYPE,COOKIE_CREATION_DATE
                                                    ,INSERTED_BY,INSERTED_DATE,UPDATED_BY,UPDATED_DATE
                                                    ,TS_CNT) 
                                                values(@USER_IP,@USER_GENDER,@USER_CITY
                                                    ,@USER_URL,@USER_BROWSER,@USER_COUNTRY_NAME,@USER_REGION
                                                    ,@USER_TIMEZONE,@USER_ZIP,@USER_TYPE,@COOKIE_CREATION_DATE
                                                    ,@INSERTED_BY,@INSERTED_DATE,@UPDATED_BY,@UPDATED_DATE
                                                    ,@TS_CNT);SELECT SCOPE_IDENTITY();";
                                SqlParameter USER_IP = new SqlParameter("@USER_IP", SqlDbType.VarChar, 50);
                                SqlParameter USER_GENDER = new SqlParameter("@USER_GENDER", SqlDbType.NVarChar, 50);
                                SqlParameter USER_CITY = new SqlParameter("@USER_CITY", SqlDbType.NVarChar, 100);
                                SqlParameter USER_URL = new SqlParameter("@USER_URL", SqlDbType.VarChar, 1024);
                                SqlParameter USER_BROWSER = new SqlParameter("@USER_BROWSER", SqlDbType.VarChar, 50);
                                SqlParameter USER_COUNTRY_NAME = new SqlParameter("@USER_COUNTRY_NAME", SqlDbType.NVarChar, 100);
                                SqlParameter USER_REGION = new SqlParameter("@USER_REGION", SqlDbType.NVarChar, 50);
                                SqlParameter USER_TIMEZONE = new SqlParameter("@USER_TIMEZONE", SqlDbType.NVarChar, 100);
                                SqlParameter USER_ZIP = new SqlParameter("@USER_ZIP", SqlDbType.NVarChar, 10);
                                SqlParameter USER_TYPE = new SqlParameter("@USER_TYPE", SqlDbType.NVarChar, 16);
                                SqlParameter COOKIE_CREATION_DATE = new SqlParameter("@COOKIE_CREATION_DATE", SqlDbType.DateTime, -1);
                                SqlParameter INSERTED_BY = new SqlParameter("@INSERTED_BY", SqlDbType.NVarChar, 50);
                                SqlParameter INSERTED_DATE = new SqlParameter("@INSERTED_DATE", SqlDbType.DateTime, -1);
                                SqlParameter UPDATED_BY = new SqlParameter("@UPDATED_BY", SqlDbType.NVarChar, 50);
                                SqlParameter UPDATED_DATE = new SqlParameter("@UPDATED_DATE", SqlDbType.DateTime, -1);
                                SqlParameter TS_CNT = new SqlParameter("@TS_CNT", SqlDbType.Int, 16);
                                USER_IP.Value = _user.USER_IP;
                                USER_GENDER.Value = _user.USER_GENDER;
                                USER_CITY.Value = _user.USER_CITY;
                                USER_URL.Value = _user.USER_URL;
                                USER_BROWSER.Value = _user.USER_BROWSER;
                                USER_COUNTRY_NAME.Value = _user.USER_COUNTRY_NAME;
                                USER_REGION.Value = _user.USER_REGION;
                                USER_TIMEZONE.Value = _user.USER_TIMEZONE;
                                USER_ZIP.Value = _user.USER_ZIP;
                                USER_TYPE.Value = _user.USER_TYPE;
                                COOKIE_CREATION_DATE.Value = _user.COOKIE_CREATION_DATE;
                                INSERTED_BY.Value = _user.INSERTED_BY;
                                INSERTED_DATE.Value = _user.INSERTED_DATE;
                                UPDATED_BY.Value = _user.UPDATED_BY;
                                UPDATED_DATE.Value = _user.UPDATED_DATE;
                                //if (_user.UPDATED_DATE == null)
                                //    UPDATED_DATE.Value = DBNull.Value;
                                //else
                                //    UPDATED_DATE.Value = _user.UPDATED_DATE;
                                TS_CNT.Value = _user.TS_CNT;
                                cmd.Parameters.Add(USER_IP);
                                cmd.Parameters.Add(USER_GENDER);
                                cmd.Parameters.Add(USER_CITY);
                                cmd.Parameters.Add(USER_URL);
                                cmd.Parameters.Add(USER_BROWSER);
                                cmd.Parameters.Add(USER_COUNTRY_NAME);
                                cmd.Parameters.Add(USER_REGION);
                                cmd.Parameters.Add(USER_TIMEZONE);
                                cmd.Parameters.Add(USER_ZIP);
                                cmd.Parameters.Add(USER_TYPE);
                                cmd.Parameters.Add(COOKIE_CREATION_DATE);
                                cmd.Parameters.Add(INSERTED_BY);
                                cmd.Parameters.Add(INSERTED_DATE);
                                cmd.Parameters.Add(UPDATED_BY);
                                cmd.Parameters.Add(UPDATED_DATE);
                                cmd.Parameters.Add(TS_CNT);
                                cmd.Prepare();
                                //  cmd.ExecuteNonQuery();
                                //_userId = command.ExecuteNonQuery();
                                _user.USER_ID = Convert.ToInt32(cmd.ExecuteScalar());
                                // return modified;
                            }
                        }
                    }
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                    return _user;
                }
            }
            catch (Exception)
            {

                return _user;
            }
        }

        public pcms_KeyRule RuleInformarion(pcms_Rule _rule)
        {
            SqlCommand cmd = null;
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                pcms_KeyRule objDAL = new pcms_KeyRule();
                cmd = new SqlCommand(null, con);
                cmd.CommandText = @"select RULE_ID,RULE_APPLIED_URL,CONTENT_HTML,DESIGN_HTML,
                POPUP_HTML,RULE_PARAMETER_KEY_VALUE,CAMPAIGN_REDIRECT_URL,
                CAMPAIGN_CONTAINER_ID FROM pcms_rules inner join pcms_campaign 
                on CAMPAIGN_RULE_ID=RULE_ID 
                left join pcms_popup on CAMPAIGN_POPUP_ID=POPUP_ID 
                left join pcms_design on CAMPAIGN_DESIGN_ID=  DESIGN_ID 
                left join pcms_content on CAMPAIGN_CONTENT_ID=CONTENT_ID 
                where CAMPAIGN_STATUS='Active' AND RULE_APPLIED_URL=@RULE_APPLIED_URL 
                AND RULE_LOCATION=@RULE_LOCATION
                AND RULE_USER_TYPE =@RULE_USER_TYPE 
                AND (CAMPAIGN_START_DATE <='" + DateTime.Now + "' AND CAMPAIGN_END_DATE >='" + DateTime.Now + "')";
                SqlParameter RULE_APPLIED_URL = new SqlParameter("@RULE_APPLIED_URL", SqlDbType.NVarChar, -1);
                SqlParameter RULE_LOCATION = new SqlParameter("@RULE_LOCATION", SqlDbType.NVarChar, -1);
                SqlParameter RULE_USER_TYPE = new SqlParameter("@RULE_USER_TYPE", SqlDbType.NVarChar, -1);
                RULE_APPLIED_URL.Value = Cryptographys.Encrypt(_rule.URL);
                cmd.Parameters.Add(RULE_APPLIED_URL);
                RULE_LOCATION.Value = _rule.COUNTRY;
                cmd.Parameters.Add(RULE_LOCATION);
                RULE_USER_TYPE.Value = _rule.USERTYPE;
                cmd.Parameters.Add(RULE_USER_TYPE);
                cmd.Prepare();
                SqlDataReader dr = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Columns.Add("CONTENT_HTML", typeof(string));
                //dt.Columns.Add("DESIGN_HTML", typeof(string));
                //dt.Columns.Add("POPUP_HTML", typeof(string));
                //dt.Columns.Add("RULE_PARAMETER_KEY_VALUE", typeof(string));
                //dt.Columns.Add("CAMPAIGN_REDIRECT_URL", typeof(string));
                //dt.Columns.Add("CAMPAIGN_CONTAINER_ID", typeof(string));
               // DataRow row;
                while (dr.Read())
                {
                    objDAL = new pcms_KeyRule();
                    // row["RULE_ID"] = dr["RULE_ID"].ToString();
                    objDAL.CAMPAIGN_CONTAINER_ID = dr["CAMPAIGN_CONTAINER_ID"].ToString();
                    objDAL.RULE_PARAMETER_KEY_VALUE = dr["RULE_PARAMETER_KEY_VALUE"].ToString();
                    // row["RULE_APPLIED_URL"] = Cryptographys.Decrypt(dr["RULE_APPLIED_URL"].ToString());
                    objDAL.CONTENT_HTML = Cryptographys.Decrypt(dr["CONTENT_HTML"].ToString());
                    objDAL.DESIGN_HTML = Cryptographys.Decrypt(dr["DESIGN_HTML"].ToString());
                    objDAL.POPUP_HTML = Cryptographys.Decrypt(dr["POPUP_HTML"].ToString());
                    objDAL.CAMPAIGN_REDIRECT_URL = Cryptographys.Decrypt(dr["CAMPAIGN_REDIRECT_URL"].ToString());
                   // dt.Rows.Add(row);
                }
                con.Close();
                return objDAL;
            }
        }

//        public DataTable RuleInformarion(pcms_Rule _rule)
//        {
//            SqlCommand cmd = null;
//            using (SqlConnection con = new SqlConnection(_connectionString))
//            {
//                con.Open();
//                cmd = new SqlCommand(null, con);
//                cmd.CommandText = @"select RULE_ID,RULE_APPLIED_URL,CONTENT_HTML,DESIGN_HTML,
//                POPUP_HTML,RULE_PARAMETER_KEY_VALUE,CAMPAIGN_REDIRECT_URL,
//                CAMPAIGN_CONTAINER_ID FROM pcms_rules inner join pcms_campaign 
//                on CAMPAIGN_RULE_ID=RULE_ID 
//                left join pcms_popup on CAMPAIGN_POPUP_ID=POPUP_ID 
//                left join pcms_design on CAMPAIGN_DESIGN_ID=  DESIGN_ID 
//                left join pcms_content on CAMPAIGN_CONTENT_ID=CONTENT_ID 
//                where CAMPAIGN_STATUS='Active' AND RULE_APPLIED_URL=@RULE_APPLIED_URL 
//                AND RULE_LOCATION=@RULE_LOCATION
//                AND RULE_USER_TYPE =@RULE_USER_TYPE 
//                AND (CAMPAIGN_START_DATE <='" + DateTime.Now + "' AND CAMPAIGN_END_DATE >='" + DateTime.Now + "')";
//                SqlParameter RULE_APPLIED_URL = new SqlParameter("@RULE_APPLIED_URL", SqlDbType.NVarChar, -1);
//                SqlParameter RULE_LOCATION = new SqlParameter("@RULE_LOCATION", SqlDbType.NVarChar, -1);
//                SqlParameter RULE_USER_TYPE = new SqlParameter("@RULE_USER_TYPE", SqlDbType.NVarChar, -1);
//                RULE_APPLIED_URL.Value = Cryptographys.Encrypt(_rule.URL);
//                cmd.Parameters.Add(RULE_APPLIED_URL);
//                RULE_LOCATION.Value = _rule.COUNTRY;
//                cmd.Parameters.Add(RULE_LOCATION);
//                RULE_USER_TYPE.Value = _rule.USERTYPE;
//                cmd.Parameters.Add(RULE_USER_TYPE);
//                cmd.Prepare();
//                SqlDataReader dr = cmd.ExecuteReader();
//                DataTable dt = new DataTable();                               
//                dt.Columns.Add("CONTENT_HTML", typeof(string));
//                dt.Columns.Add("DESIGN_HTML", typeof(string));
//                dt.Columns.Add("POPUP_HTML", typeof(string));
//                dt.Columns.Add("RULE_PARAMETER_KEY_VALUE", typeof(string));
//                dt.Columns.Add("CAMPAIGN_REDIRECT_URL", typeof(string));
//                dt.Columns.Add("CAMPAIGN_CONTAINER_ID", typeof(string));               
//                DataRow row;
//                while (dr.Read())
//                {
//                    row = dt.NewRow();
//                   // row["RULE_ID"] = dr["RULE_ID"].ToString();
//                    row["CAMPAIGN_CONTAINER_ID"] = dr["CAMPAIGN_CONTAINER_ID"].ToString();
//                    row["RULE_PARAMETER_KEY_VALUE"] = dr["RULE_PARAMETER_KEY_VALUE"].ToString();
//                   // row["RULE_APPLIED_URL"] = Cryptographys.Decrypt(dr["RULE_APPLIED_URL"].ToString());
//                    row["CONTENT_HTML"] = Cryptographys.Decrypt(dr["CONTENT_HTML"].ToString());
//                    row["DESIGN_HTML"] = Cryptographys.Decrypt(dr["DESIGN_HTML"].ToString());
//                    row["POPUP_HTML"] = Cryptographys.Decrypt(dr["POPUP_HTML"].ToString());
//                    row["CAMPAIGN_REDIRECT_URL"] = Cryptographys.Decrypt(dr["CAMPAIGN_REDIRECT_URL"].ToString());
//                    dt.Rows.Add(row);
//                }
//                con.Close();
//                return dt;
//            }
//        }

        public string InsertUserActivity(int userkey, string activityLog)
        {
            //var _userId = 0;
            SqlCommand cmd = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    cmd = new SqlCommand(null, con);
                    cmd.CommandText = @"insert into pcms_analytics (USER_ID,USER_ACTIVITY_LOG,TS_CNT) values(@USER_ID,@USER_ACTIVITY_LOG,@TS_CNT)";
                    SqlParameter USER_ID = new SqlParameter("@USER_ID", SqlDbType.Int, 16);
                    SqlParameter USER_ACTIVITY_LOG = new SqlParameter("@USER_ACTIVITY_LOG", SqlDbType.NVarChar, -1);
                    SqlParameter TS_CNT = new SqlParameter("@TS_CNT", SqlDbType.Int, 16);
                    USER_ID.Value = Convert.ToInt16(userkey);
                    USER_ACTIVITY_LOG.Value = activityLog;
                    TS_CNT.Value = 1;
                    cmd.Parameters.Add(USER_ID);
                    cmd.Parameters.Add(USER_ACTIVITY_LOG);
                    cmd.Parameters.Add(TS_CNT);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return "Inserted";
                }
            }
            catch (Exception ex)
            {
                return "Failure";
            }
        }
    }
}