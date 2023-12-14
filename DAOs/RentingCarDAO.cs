using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOs
{
    public class RentingCarDAO
    {
        private static RentingCarDAO instance = null;
        public RentingCarDAO()
        {

        }
        public static RentingCarDAO getInstance()
        {

            if (instance == null)
            {
                instance = new RentingCarDAO();
            }
            return instance;
        }
        public List<RentingTransaction> GetAll()
        {
            var dbContent = new FUCarRentingManagementContext();
            return dbContent.RentingTransactions.ToList();
        }
    }
}
