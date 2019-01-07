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
            string queryString = "SELECT * FROM cqTable";
            List<Customer> customers = new List<Customer>();


            //===============================================
            //Not Sure how to make the final runningTotal to post to customer.Quote
            foreach (var customer in customers)
            {
                int qbase = 50;
                DateTime todayDate = DateTime.Now;
                var custAge = todayDate.Year - customer.DOB.Year;
                int runningTotal = 0;

                if (custAge < 25 || custAge > 100)
                {
                    int riskyDriver = 25;
                    runningTotal = qbase + riskyDriver;

                }
                else if (Convert.ToInt32(custAge) < 18)
                {
                    int youngDriver = 100;
                    runningTotal = qbase + youngDriver;
                }


                if (customer.CarYear < 2000 || customer.CarYear > 2015)
                {
                    int carAge = 25;
                    runningTotal = qbase + carAge;
                }
                if (customer.CarMake == "Porsche")
                {
                    int makePorsche = 25;
                    runningTotal = qbase + makePorsche;

                    if (customer.CarModel == "911 Carrera")
                    {
                        int porscheCarrera = makePorsche + 25;
                        runningTotal = porscheCarrera + qbase;
                    }
                }
                if (customer.NumberOfSpeedTix > 0)
                {
                    int speedyDriver = (10 * customer.NumberOfSpeedTix);
                    runningTotal = speedyDriver + qbase;
                }
                else
                {
                    runningTotal = qbase;
                }
                runningTotal = customer.Quote;


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
                        customer.Quote = Convert.ToInt32(reader["Quote"]);
                        customers.Add(customer);

                    };
                    connection.Close();
                }
                return View(customers);
            }
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            
            string queryString = @"INSERT INTO cqTable (FirstName, LastName,
                                    EmailAddress, DOB, CarYear, CarMake, CarModel, DUI,
                                    NumberOfSpeedTix, Coverage, Quote) VALUES (@FirstName, @LastName,
                                    @EmailAddress, @DOB, @CarYear, @CarMake, @CarModel,
                                    @DUI, @NumberOfSpeedTix, @Coverage,@Quote)";
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
                command.Parameters.Add("@Quote", SqlDbType.Int);

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
                command.Parameters["@Quote"].Value = customer.Quote;

                connection.Open();
                command.ExecuteNonQuery();
                

                connection.Close();
                
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            string queryString = "SELECT * FROM cqTable WHERE Id = @Id";
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
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            string queryString = "SELECT * FROM cqTable WHERE id = @Id";
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
            return View(customer);
        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            string queryString = @"UPDATE cqTable SET FirstName = @FirstName,
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

        public ActionResult Quote(DateTime DOB, int CarYear, string CarMake, string CarModel, string DUI, int NumberofSpeedTix, string Coverage)
        {
            string queryString = "SELECT * FROM cqTable";
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
                    customer.Quote = Convert.ToInt32(reader["Quote"]);
                    customers.Add(customer);
                }
                foreach (var customer in customers)
                {
                    int runningTotal = 50;

                    var custAge = DateTime.Now - customer.DOB;

                    if (Convert.ToInt32(custAge) < 25 || Convert.ToInt32(custAge) > 100)
                    {
                        int riskyDriver = 25;
                        runningTotal = runningTotal + riskyDriver; 
                        

                    }
                    else if (Convert.ToInt32(custAge) < 18)
                    {
                        int youngDriver = 100;
                        runningTotal = runningTotal + youngDriver;                        
                    };
                    

                    if (customer.CarYear < 2000 || customer.CarYear > 2015)
                    {
                        int carAge = 25;
                        runningTotal = runningTotal + carAge;
                        
                    };
                    if (customer.CarMake == "Porsche")
                    {
                        int makePorsche = 25;
                        runningTotal = runningTotal + makePorsche;

                        if (customer.CarModel == "911 Carrera")
                        {
                            int porscheCarrera = makePorsche + 25;
                            runningTotal = runningTotal + porscheCarrera;
                            
                        }
                    };
                    if (customer.NumberOfSpeedTix > 0)
                    {
                        int speedyDriver = (10 * customer.NumberOfSpeedTix);
                        runningTotal = runningTotal + speedyDriver;

                    };
                    if (customer.DUI == "Yes" || customer.DUI == "Yeah" || customer.DUI == "yes" || customer.DUI == "y" || customer.DUI == "Y")
                    {
                        int duiClub = (runningTotal / 4) + runningTotal;
                        runningTotal = duiClub + runningTotal;
                    };
                    if (customer.Coverage == "Full Coverage" || customer.Coverage == "full coverage")
                    {
                        int fc = (runningTotal / 2) + runningTotal;
                        runningTotal = fc + runningTotal;
                    };
                    customer.Quote = runningTotal;
                    
                }
                connection.Close();
            }
            return View(customers);
        }










    }




    }

