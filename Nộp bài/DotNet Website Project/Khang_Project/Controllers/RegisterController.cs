using PHocKi.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PHocKi.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult DangKi()
        {
            return View();
        }
        public ActionResult DangKiVao()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];

            bool checkUser = check(username);

            if (!checkUser)
            {
                ViewBag.notify = "Tên đăng nhập đã có người sử dụng";

                return View("DangKi");
            }

            string value = Request.Form["chucvu"];

            int realValue = value.Equals("Người tìm việc") ? 1 : 2;

            String insertQuery = "insert into USERS(USERNAME,PASSWORD,USER_STATUS,ROLE_ID,JOINED_DATE) values (@uName,@uPass,@uStatus,@uRole,@date)";

            SqlConnection connection = DBConnect.getConnection();

            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@uName",username);
            cmd.Parameters.AddWithValue("@uPass", password);
            cmd.Parameters.AddWithValue("@uStatus",1);
            cmd.Parameters.AddWithValue("@uRole", realValue);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);

            cmd.ExecuteNonQuery();

            return View("ThanhCong");
        }

        private bool  check(string username)
        {

           DbCommand cm = new SqlCommand("SELECT  * FROM USERS where userName ='" +username +"'", DBConnect.getConnection());
            DbDataReader dr = cm.ExecuteReader();

            if (dr.Read())
            {
                return false;
            }
            else return true;

        }


    }
}