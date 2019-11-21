using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using ProjectMVVM_FlowerOnline.Interface;
using ProjectMVVM_FlowerOnline.Model;
using ProjectMVVM_FlowerOnline.Helper;

namespace ProjectMVVM_FlowerOnline.Repository
{
    class HoaRepository : IHoaRepository
    {
        Database db;
        public HoaRepository()
        {
            db = new Database();
        }

        public int Delete(Hoa temp)
        {
            db.DeleteHoa(temp);
            return 0;
        }

        public Task<List<Hoa>> GetHoa()
        {
            return db.GetHoa();
        }

        public Task<List<Hoa>> GetHoa(int maLoai)
        {
            return db.GetHoa(maLoai);
        }

        public Task<List<Hoa>> GetHoaByID(int maLoai, int maHoa)
        {
            return db.GetHoa(maLoai, maHoa);
        }

        public int Modify(Hoa temp)
        {
            db.SaveHoa(temp);
            return 0;
        }
    }
}
