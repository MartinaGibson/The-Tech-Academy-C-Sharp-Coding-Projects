using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QCarInsurance.Models;

namespace QCarInsurance.Controllers
{
    public class CustomerController : Controller
    {
        private string _connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Insurance; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        // GET: Customer
        public ActionResult Index()
        {
            string queryString = "SELECT * FROM CustomerQuotes";
            List<Customer> customers = new List<Customer>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                    customer.EmailAddress = reader["EmailAddress"].ToString();
                    customer.DOB = Convert.ToDateTime(reader["DOB"]);
                    customer.CarYear = Convert.ToInt32(reader["CarYear"]);
                    customer.CarMake = reader["CarMake"].ToString();
                    customer.CarModel = reader["CarModel"].ToString();
                    customer.DUI = reader["DUI"].ToString();
                    customer.NumberOfSpeedTix = Convert.ToInt32(reader["NumberOfSpeedTix"]);
                    customer.Coverage = reader["Coverage"].ToString();
                }
                connection.Close();
            }
            return View(customers);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            string queryString = @"INSERT INTO CustomerQuotes (FirstName, LastName,
                                    EmailAddress, DOB, CarYear, CarMake, CarModel, DUI,
                                    NumberOfSpeedTix, Coverage) VALUES (@FirstName, @LastName,
                                    @EmailAddress, @DOB, @CarYear, @CarMake, @CarModel,
                                    @DUI, @NumberOfSpeedTix, @Coverage)";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);
                command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                command.Parameters.Add("@DOB", SqlDbType.DateTime);
                command.Parameters.Add("@CarYear", SqlDbType.Int);
                command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                command.Parameters.Add("@DUI", SqlDbType.VarChar);
                command.Parameters.Add("@NumberOfSpeedTix", SqlDbType.Int);
                command.Parameters.Add("@Coverage", SqlDbType.VarChar);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();

            }
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            string queryString = "SELECT * FROM CustomerQuotes WHERE id = @Id";
            Customer customer = new Customer();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Id", SqlDbType.Int);

                command.Parameters["@Id"].Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                }
                connection.Close();
            }
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            string queryString = "SELECT * FROM CustomerQuotes WHERE id = @Id";
            Customer customer = new Customer();

            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Id", SqlDbType.Int);

                command.Parameters["@id"].Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    customer.Id = Convert.ToInt32(reader["Id"]);
                    customer.FirstName = reader["FirstName"].ToString();
                    customer.LastName = reader["LastName"].ToString();
                }
                connection.Close();
            }
            return View(customer);
        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            string queryString = @"UPDATE CustomerQuotes SET FirstName = @FirstName,
                                LastName = @LastName, EmailAddress = @EmailAddress,
                                DOB = @DOB, CarYear = @CarYear, CarMake = @CarMake,
                                CarModel = @CarModel, DUI = @DUI, NumberOfSpeedTix = @NumberOfSpeedTix,
                                Coverage = @Coverage WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Id", SqlDbType.Int);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);
                command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                command.Parameters.Add("@DOB", SqlDbType.DateTime);
                command.Parameters.Add("@CarYear", SqlDbType.Int);
                command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                command.Parameters.Add("@DUI", SqlDbType.VarChar);
                command.Parameters.Add("@NumberOfSpeedTix", SqlDbType.Int);
                command.Parameters.Add("@Coverage", SqlDbType.VarChar);

                command.Parameters["@Id"].Value = customer.Id;
                command.Parameters["@FirstName"].Value = customer.FirstName;
                command.Parameters["@LastName"].Value = customer.LastName;
                command.Parameters["@EmailAddress"].Value = customer.EmailAddress;
                command.Parameters["@DOB"].Value = customer.DOB;
                command.Parameters["@CarYear"].Value = customer.CarYear;
                command.Parameters["@CarMake"].Value = customer.CarMake;
                command.Parameters["@CarModel"].Value = customer.CarModel;
                command.Parameters["@DUI"].Value = customer.DUI;
                command.Parameters["@NumberOfSpeedTix"].Value = customer.NumberOfSpeedTix;
                command.Parameters["@Coverage"].Value = customer.Coverage;

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
            return RedirectToAction("Index");
        }




    }
}