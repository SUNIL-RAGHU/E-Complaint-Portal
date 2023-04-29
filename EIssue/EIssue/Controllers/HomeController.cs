using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EIssue.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace EIssue.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IConfiguration _iconfiguration;

        public HomeController(ILogger<HomeController> logger, IConfiguration iconfiguration)
        {
            _logger = logger;
            _iconfiguration = iconfiguration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SaveForm(string Email, string Password)
        {

            var email = Email;
            var password = Password;
            String connectionString = _iconfiguration.GetConnectionString("DefaultConnectionString");

            SqlConnection connection = new SqlConnection(connectionString);

            var query = String.Format("Select count(*) from CitizenInfo where email='{0}' and Password='{1}'", email, password);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            var count = (int)cmd.ExecuteScalar();
            connection.Close();

            if(count == 1)
            {
                HttpContext.Session.SetString("Email", Email);
                var query1 = String.Format("Select * from[dbo].[Grievances] where Email = '{0}'", Email);

                SqlCommand cmd2 = new SqlCommand(query1, connection);
                connection.Open();
                List<EIssue.ViewModel.Details> issuedetails = new List<ViewModel.Details>();
                using (System.Data.IDataReader reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewModel.Details Details = new ViewModel.Details();
                        Details.location = reader[0].ToString(); 
                        Details.Description = reader[1].ToString();
                        Details.category = reader[2].ToString();
                        Details.status = reader[3].ToString();
                        Details.Email = reader[4].ToString();
                        Details.Municipility = reader[6].ToString();

                        issuedetails.Add(Details);
                    }
                }

                    //var count = (int)cmd.ExecuteScalar();
                    connection.Close();
                ViewData["IssueDetails"] = issuedetails;

                return View("SaveForm");
            }
            else
            {
                ViewData["fail"] = 1;
                return View("Index");
            }

        }

        [HttpPost]
        public IActionResult CreateAccount(string Email,string Password,string inputAddress, string Gender,string inputMunicipility,string inputZip)
        {
            var email = Email;
            var password = Password;
            var address = inputAddress;
            var gender = Gender;
            var Municipility = inputMunicipility;
            var pincode = int.Parse(inputZip);

            


            String connectionString = _iconfiguration.GetConnectionString("DefaultConnectionString");

            SqlConnection connection = new SqlConnection(connectionString);

            var query = String.Format("INSERT INTO [dbo].[CitizenInfo]  VALUES ('zzz', '{0}', '{1}', 1234567890, '{2}', '{3}' , {4}, '{5}')",email,password,gender,Municipility,inputZip, address);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            return View("Index");



        }
        [HttpPost]
        public IActionResult CreateRequest(string Email,string inputCategory,string inputMunicipility,string inputAddress,string Description)
        {

            String connectionString = _iconfiguration.GetConnectionString("DefaultConnectionString");

            SqlConnection connection = new SqlConnection(connectionString);

            var query = String.Format("INSERT INTO [dbo].[Grievances] VALUES ('{0}' ,'{1}','{2}','Open','{3}','{4}')", inputAddress, Description, inputCategory, Email, inputMunicipility);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            ViewData["Success2"] = 2;

                
                var query1 = String.Format("Select * from[dbo].[Grievances] where Email = '{0}'", Email);

                SqlCommand cmd2 = new SqlCommand(query1, connection);
                connection.Open();
                List<EIssue.ViewModel.Details> issuedetails = new List<ViewModel.Details>();
                using (System.Data.IDataReader reader = cmd2.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ViewModel.Details Details = new ViewModel.Details();
                        Details.location = reader[0].ToString();
                        Details.Description = reader[1].ToString();
                        Details.category = reader[2].ToString();
                        Details.status = reader[3].ToString();
                        Details.Email = reader[4].ToString();
                        Details.Municipility = reader[6].ToString();

                        issuedetails.Add(Details);
                    }
                

                //var count = (int)cmd.ExecuteScalar();
                connection.Close();
                ViewData["IssueDetails"] = issuedetails;

                return View("SaveForm");
        }


        }
    }
}
