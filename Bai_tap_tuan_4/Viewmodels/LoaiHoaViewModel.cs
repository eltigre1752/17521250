using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using ProjectMVVM_FlowerOnline.Interface;
using ProjectMVVM_FlowerOnline.Model;
using ProjectMVVM_FlowerOnline.Helper;
using ProjectMVVM_FlowerOnline.Repository;
using Xamarin.Forms;

namespace ProjectMVVM_FlowerOnline.Viewmodels
{
    class LoaiHoaViewModel : INotifyPropertyChanged
    {
        private LoaiHoa loaiHoa;
        public ILoaiHoaRepository LoaiHoaRepository;

        //PROPERTIES
        public ICommand DeleteLoaiHoa { get; set; }
        public ICommand ModifyLoaiHoa { get; set; }
        public LoaiHoa LoaiHoa
        {
            get
            {
                return loaiHoa;
            }
            set
            {
                loaiHoa = value;
                RaisePropertyChanged("LoaiHoa");
            }
        }

        public List<LoaiHoa> ListLoaiHoa
        {
            get { return ListLoaiHoa; }
            set
            {
                ListLoaiHoa = value;
                RaisePropertyChanged("ListLoaiHoa");
            }
        }

        public int MaLoai
        {
            get
            {
                return loaiHoa.MaLoai;
            }
            set
            {
                loaiHoa.MaLoai = value;
                RaisePropertyChanged("MaLoai");
            }
        }

        public string TenLoai 
        {
            get 
            { 
                return loaiHoa.TenLoai; 
            }
            set
            {
                loaiHoa.TenLoai = value;
                RaisePropertyChanged("TenLoai");
            }
        }

        //METHODS
        public LoaiHoaViewModel()
        {
            LoaiHoaRepository = new LoaiHoaRepository();
            LoadLoaiHoa();
            ModifyLoaiHoa = new Command(Modify, IsValid);
            DeleteLoaiHoa = new Command(Delete, IsValid);
            loaiHoa = new LoaiHoa();
        }
        async void LoadLoaiHoa()
        {
            ListLoaiHoa = await LoaiHoaRepository.GetLoaiHoa();
        }
        private void Modify()
        {
            LoaiHoaRepository.Modify(LoaiHoa);
            LoadLoaiHoa();
        }
        private void Delete()
        {
            LoaiHoaRepository.Delete(LoaiHoa);
            LoadLoaiHoa();
        }
        private bool IsValid()
        {
            if (LoaiHoa == null || LoaiHoa.MaLoai == 0)
                return false;
            else
                return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
