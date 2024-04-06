using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class QuanService
    {
        private QuanRepository repos;
        public QuanService()
        {
            repos = new QuanRepository();
        }
        public List<Quan> GetQuans() 
        {
            return repos.GetAll();
        }
    }
}
