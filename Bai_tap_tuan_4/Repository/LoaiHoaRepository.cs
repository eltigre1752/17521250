using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using ProjectMVVM_FlowerOnline.Interface;
using ProjectMVVM_FlowerOnline.Model;
using ProjectMVVM_FlowerOnline.Helper;

namespace ProjectMVVM_FlowerOnline.Repository
{
    class LoaiHoaRepository : ILoaiHoaRepository
    {
        public Database db;
        public LoaiHoaRepository()
        {
            db = new Database();
        }

        public int Delete(LoaiHoa temp)
        {
            db.DeleteLoaiHoa(temp);
            return 0;
        }

        public Task<List<LoaiHoa>> GetLoaiHoa()
        {
            return db.GetLoaiHoa();
        }

        public Task<List<LoaiHoa>> GetLoaiHoaByID(int maLoai)
        {
            return db.GetLoaiHoa(maLoai);
        }

        public int Modify(LoaiHoa temp)
        {
            db.SaveLoaiHoa(temp);
            return 0;
        }
    }
}