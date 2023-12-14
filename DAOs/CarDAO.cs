using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DAOs
{

    public class CarDAO
    {
        private static CarDAO instance = null;
        public CarDAO()
        {

        }
        public static CarDAO getInstance()
        {

            if (instance == null)
            {
                instance = new CarDAO();
            }
            return instance;
        }
        public List<CarInformation> GetAll()
        {
            var dbContent = new FUCarRentingManagementContext();
            return dbContent.CarInformations.ToList();
        }
    }
}
