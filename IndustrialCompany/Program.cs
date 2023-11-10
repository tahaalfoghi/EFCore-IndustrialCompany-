using IndustrialCompany.Data;
using IndustrialCompany.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace IndustrialCompany
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (var context = new AppDbContext())
            {
               
            }

                Console.ReadKey();
        }
    }
}