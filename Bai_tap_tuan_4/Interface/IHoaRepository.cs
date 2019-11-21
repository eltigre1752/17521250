using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using ProjectMVVM_FlowerOnline.Model;

namespace ProjectMVVM_FlowerOnline.Interface
{
    interface IHoaRepository
    {
        Task<List<Hoa>> GetHoa();
        Task<List<Hoa>> GetHoa(int maLoai);
        Task<List<Hoa>> GetHoaByID(int maLoai, int maHoa);
        int Modify(Hoa temp);//Insert or Update
        int Delete(Hoa temp);
    }
}
