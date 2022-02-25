using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Threading.Tasks;

using System.IO;



namespace TEST2
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection
                con = new SqlConnection("data source=.; database=Gow; integrated security=SSPI");
                // writing sql query
                SqlCommand cm = new SqlCommand("create table studentss(StudId int primary key,Name varchar(20),Course varchar(20))", con);

                // Opening Connection
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine();
                Console.WriteLine("Table created succesfully");

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e.Message);
            }
            // Closing the connection
            finally
            {

                con.Close();
            }



       
        }


        public void SelectTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection
                con = new SqlConnection("data source=.; database=Gow; integrated security=SSPI");
                // writing sql query
                SqlCommand cm = new SqlCommand("select * from student1", con);

                // Opening Connection
                con.Open();

                // Executing the SQL query to retrive the values fromt he table
                SqlDataReader dr = cm.ExecuteReader();
                Console.WriteLine("StudId \tName \tCourse");
                

               
                
               
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + "\t" + dr[1] + " " + dr[2]);
                   
                    
                       


                    }
               
                Console.ReadLine();


            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e.Message);
            }
            // Closing the connection
            finally
            {

                con.Close();
            }
           


            Console.WriteLine("data written to file");
        }

        public void InsertTable()
        {
            SqlConnection con = null;
            try
            {
               
                con = new SqlConnection("data source=.; database=Gow; integrated security=SSPI");
                
                SqlCommand cm = new SqlCommand("insert into student1(studid,name,course)values(10,'arun','C'),(20,'ajith','c++'),(30,'vijay','java'),(40,'dilip','c#'),(50,'kumar','javascript'),(60,'yadav','selenium'),(70,'vignesh','python')", con);
                
                con.Open();
            
                cm.ExecuteNonQuery();
                
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e.Message);
            }
       
            finally
            {
                con.Close();
            }
        }
        
        
        static void Main(string[] args)
        {
            int ch;
            string Continue;


            do
            { 
                Console.WriteLine("ENETER YOU CHOICE");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1.CREATE");
                Console.WriteLine("2.INSERT");
                Console.WriteLine("3.SELECT");
                
                Console.WriteLine("y.CONTINUE AGAIN RUN");
                Console.WriteLine("N.END");
                Console.Write("Enter Choice(1-3):");
                ch = Convert.ToInt32(Console.ReadLine());
                Continue = Console.ReadLine();


                switch (ch)
                {
                    case 1:
                        Program p = new Program();
                        p.CreateTable();
                        break;
                    case 2:
                        Program q = new Program();
                        q.InsertTable();
                        break;
                    case 3:
                        Program r = new Program();
                        r.SelectTable();
                        break;
                    
                    
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                Console.Write("Do You Want To Continue? (Y/N) : ");
                Continue = Console.ReadLine();

            } while (Continue != "N" && Continue != "n");
        }
                 

               
        
    }
}