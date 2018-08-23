using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstProjectGit.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace FirstProjectGit.Controllers
{
    public class SampleController : Controller
    {
        private SqlConnection con;
        //To Handle connection related activities
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ToString();
            con = new SqlConnection(constr);

        }
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = "INSERT INTO Employee(name,city,address) VALUES(@name,@city,@address)";
                query += " SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", employee.name);
                    cmd.Parameters.AddWithValue("@city", employee.city);
                    cmd.Parameters.AddWithValue("@address", employee.address);
                    employee.id = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                }
            }
            return View(employee);
        }
        public ActionResult Emplist()
        {


            string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            var model = new List<Employee>();
            string query = "select * from Employee";


            using (SqlConnection con = new SqlConnection(constr))
            {

                //query += " SELECT SCOPE_IDENTITY()";

                con.Open();
                //using (SqlCommand cmd = new SqlCommand(query))
                //{
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var employee = new Employee();
                    employee.name = rdr["name"].ToString();
                    employee.city = rdr["city"].ToString();
                    employee.address = rdr["address"].ToString();
                    model.Add(employee);
                }

                //}
                con.Close();
            }

            return View(model);
        }
    }
}