using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    internal class QuanRepository
    {
        MyContext _context;
        public QuanRepository()
        {
            _context = new MyContext();
        }
        public List<Quan> GetAll()
        {
            return _context.Quans.ToList();
        }
    }
}
