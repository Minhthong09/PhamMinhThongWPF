using BusinessObject.Models;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposioties
{
    public class RentingCarRepository : IRentingCarRepository

    {
        public List<RentingTransaction> GetAll() => RentingCarDAO.getInstance().GetAll();

    }
}

