using BusinessObject.Models;
using Reposioties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RentingCarService : IRentingCarService
    {
        private IRentingCarRepository rentingCarRepository;

        public RentingCarService()
        {
            rentingCarRepository = new RentingCarRepository();
        }

        public List<RentingTransaction> GetAll()
        {
           return rentingCarRepository.GetAll();
        }
    }
}
