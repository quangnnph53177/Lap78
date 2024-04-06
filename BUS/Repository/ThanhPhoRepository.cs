using DAL.Context;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repository
{
    internal class ThanhPhoRepository
    {
        MyContext context;
        public ThanhPhoRepository()
        {
            context = new MyContext();
        }
        public List<Thanhpho>GetAll()
        {
            return context.Thanhphos.ToList();
        }
        public  IQueryable<TPWithQuan> GetData()
        {
            var result = context.Thanhphos.Join(context.Quans,
                                                    tp => tp.Maquan,
                                                    q => q.Maquan,
                                                    (tp, q) => new TPWithQuan()
                                                    {
                                                        Stt = tp.Stt,
                                                        Guidid = tp.Guidid,
                                                        Matp = tp.Matp,
                                                        Tentp = tp.Tentp,
                                                        Tenquan = q.Tenquan,
                                                    }); 
            return result;
        }
        public bool Add_TP(Thanhpho thanhpho)
        {
            if (thanhpho == null)
            {
                return false;
            }
            context.Add(thanhpho);
            context.SaveChanges();
            return true;
        }
        public bool Remove_TP(Thanhpho thanhpho) 
        { 
            if (thanhpho == null)
            {
                return false;
            }
            context.Remove(thanhpho);
            context.SaveChanges();
            return true;
        }
        
    }
}
