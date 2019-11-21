using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text;
using ProjectMVVM_FlowerOnline.Interface;
using ProjectMVVM_FlowerOnline.Model;
using ProjectMVVM_FlowerOnline.Helper;

namespace ProjectMVVM_FlowerOnline.Interface
{
    interface ILoaiHoaRepository
    {
        Task<List<LoaiHoa>> GetLoaiHoa();
        Task<List<LoaiHoa>> GetLoaiHoaByID(int maLoai);
        int Modify(LoaiHoa temp);//Insert or Update
        int Delete(LoaiHoa temp);
    }
}
