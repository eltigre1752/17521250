using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProjectMVVM_FlowerOnline.Model
{
    public class Hoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaLoai { get; set; }
        public int MaHoa { get; set; }
        public string TenHoa { get; set; }
        public string Hinh { get; set; }
        public string MoTa { get; set; }
        public string DonGia { get; set; }
    }
    
}
