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
    class HoaViewModel
    {
        //PRIVATE FIELD
        private Hoa hoa;

        //PUBLIC FIELD
        public IHoaRepository HoaRepository;
        public ICommand ModifyHoa { get; set; }
        public ICommand DeleteHoa { get; set; }
        public List<Hoa> ListHoa { get; set; }
        public Hoa Hoa
        {
            get { return hoa; }
            set
            {
                hoa = value;
                RaisePropertyChanged("Hoa");
            }
        }
        public int MaLoai
        {
            get { return hoa.MaLoai; }
            set
            {
                hoa.MaLoai = value;
                RaisePropertyChanged("MaLoai");       
            }
        }
        public int MaHoa
        {
            get { return hoa.MaHoa; }
            set
            {
                hoa.MaHoa = value;
                RaisePropertyChanged("MaHoa");
            }
        }
        public string TenHoa
        {
            get { return hoa.TenHoa; }
            set
            {
                hoa.TenHoa = value;
                RaisePropertyChanged("TenHoa");
            }
        }
        public string Hinh
        {
            get { return hoa.Hinh; }
            set
            {
                hoa.Hinh = value;
                RaisePropertyChanged("Hinh");
            }
        }
        public string MoTa
        {
            get { return hoa.MoTa; }
            set
            {
                hoa.MoTa = value;
                RaisePropertyChanged("MoTa");
            }
        }
        public string DonGia
        {
            get { return hoa.DonGia; }
            set
            {
                hoa.DonGia = value;
                RaisePropertyChanged("DonGia");
            }
        }

        //METHODS
        public HoaViewModel()
        {
            hoa = new Hoa();
            HoaRepository = new HoaRepository();
            LoadHoa();
            ModifyHoa = new Command(Modify, IsValid);
            DeleteHoa = new Command(Delete, IsValid);
        }
        async void LoadHoa()
        {
            ListHoa = await HoaRepository.GetHoa();
        }
        private void Modify()
        {
            HoaRepository.Modify(Hoa);
            LoadHoa();
        }
        private void Delete()
        {
            HoaRepository.Delete(Hoa);
            LoadHoa();
        }
        private bool IsValid()
        {
            if (Hoa == null || Hoa.MaHoa == 0 || Hoa.MaLoai == 0)
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
