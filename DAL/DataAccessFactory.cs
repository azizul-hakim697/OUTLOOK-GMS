using DAL.EF.Models;
using DAL.iNTERFACES;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        
        
            public static IRepo<RawMaterial, int, bool> RawMaterialData()
            {
            return new RawMaterialRepo();
            }

            public static IRepo<Product, int, bool> ProductData()
            {
            return new ProductRepo();
            }

        public static IRepo<Salary, int, bool> SalaryData()
        {
            return new SalaryRepos();
        }
    }
}
