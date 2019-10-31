using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using SQLite;


namespace baitap3.Data
{
    public class DBLoaiHoa
    {
        readonly SQLiteAsyncConnection _database;

        public DBLoaiHoa(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<LoaiHoa>().Wait();
            _database.CreateTableAsync<Hoa>().Wait();
        }

        public Task<List<LoaiHoa>> LietKeLoaiHoa()
        {
            return _database.Table<LoaiHoa>().ToListAsync();
        }

        public Task<int> LuuLoaiHoa(LoaiHoa temp)
        {
            if (temp.MaLoai != 0)
                return _database.UpdateAsync(temp);
            else
                return _database.InsertAsync(temp);
        }

        public Task<List<Hoa>> LietKeHoa()
        {
            return _database.Table<Hoa>().ToListAsync();
        }

        public Task<List<Hoa>> LietKeHoa(int MaLoai)
        {
            return _database.Table<Hoa>().Where(i => i.MaLoai == MaLoai).ToListAsync();
        }

        public Task<int> LuuHoa(Hoa temp)
        {
            if (temp.MaHoa != 0)
                return _database.UpdateAsync(temp);
            else
                return _database.InsertAsync(temp);
        }

        public Task<int> XoaHoa(Hoa Hoa)
        {
           return _database.Table<Hoa>().DeleteAsync(i => i.TenHoa == Hoa.TenHoa);
        }
    }
}
