using BUS.Repository;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ThanhphoService
    {
        private ThanhPhoRepository repos;
        public ThanhphoService()
        {
            repos = new ThanhPhoRepository();
        }
        public List<Thanhpho>GetThanhphos()
        {
            return repos.GetAll();
        }
        public IQueryable<TPWithQuan> GetTPWithQuans()
        {
            return repos.GetData();
        }
        public string Them_TP(Thanhpho thanhpho)
        {
            if(repos.Add_TP(thanhpho))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string Xoa_TP(string ma)
        {
            var thanhpho = repos.GetAll().Find( x => x.Matp == ma);
            if (repos.Remove_TP(thanhpho))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string? Xoa_TP(Thanhpho? tp)
        {
            throw new NotImplementedException();
        }
    }
    
}
