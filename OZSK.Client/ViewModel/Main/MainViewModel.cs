using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OfficeOpenXml;
using OZSK.Client.Annotations;
using OZSK.Client.Model;
using OZSK.Client.Model.Abstr;
using OZSK.Client.ViewModel;
using OZSK.Client.ViewModel.Auto.Command;
using OZSK.Client.ViewModel.Main.Command;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace OZSK.Client.ViewModel.Main
{
    public class MainViewModel : BaseViewModel, IHasCarrierList
    {
        private readonly LoadCipherListCommand _loadCipherListCommand;
        private readonly LoadShippingNameCommand _loadShippingNameCommand;
        private readonly LoadCarriersCommand _loadCarriersCommand;

        public MainViewModel()
        {
            _loadCipherListCommand = new LoadCipherListCommand();
            _loadShippingNameCommand = new LoadShippingNameCommand();
            _loadCarriersCommand = new LoadCarriersCommand();
           
        }

        private void GetNumbers()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var path = @$"{basePath}number.txt";
            if (File.Exists(path))
            {
                var str = File.ReadAllText(path);
                var number = JsonConvert.DeserializeObject<SaveNumber>(str);
                Ov = number.OvNumber;
                Tn = number.TnNumber;
                return;
            }

            Ov = 13000;
            Tn = 5000;
        }
        public void SaveNumbers()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var path = @$"{basePath}number.txt";
            var str = JsonConvert.SerializeObject(new SaveNumber
            {
                TnNumber = Tn+1,
                OvNumber = Ov+1
            });
            using var fstream = new FileStream($"{path}", FileMode.OpenOrCreate);
            var array = Encoding.Default.GetBytes(str);
            fstream.Write(array, 0, array.Length);
        }
        public override void Initialize()
        {
            GetNumbers();
            Task.Run(async () =>
            {
                await _loadCipherListCommand.Execute(this, null);
                await _loadShippingNameCommand.Execute(this, null);
                await _loadCarriersCommand.Execute(this, null);
            });
        }

        #region Consignee

        private string _consigneeName;

        public string ConsigneeName
        {
            get => _consigneeName;
            set => SetProperty(ref _consigneeName, value);
        }

        private Consignee _consignee;

        public Consignee Consignee
        {
            get => _consignee;
            set
            {
                SetProperty(ref _consignee, value);
                ConsigneeName = value?.Name;
            }
        }

        #endregion

        #region Cipher

        private Cipherlist _cipher;

        public Cipherlist Cipher
        {
            get => _cipher;
            set => SetProperty(ref _cipher, value);
        }

        private ObservableCollection<Cipherlist> _cipherlists;

        public ObservableCollection<Cipherlist> Cipherlists
        {
            get => _cipherlists;
            set => SetProperty(ref _cipherlists, value);
        }

        #endregion

        #region ShippingName

        private ObservableCollection<ShippingName> _shippingNames;

        public ObservableCollection<ShippingName> ShippingNames
        {
            get => _shippingNames;
            set => SetProperty(ref _shippingNames, value);
        }

        private ShippingName _shippingName;

        public ShippingName ShippingName
        {
            get => _shippingName;
            set => SetProperty(ref _shippingName, value);
        }

        #endregion

        #region Carrier

        private Model.Carrier _carrier;

        public Model.Carrier Carrier
        {
            get => _carrier;
            set => SetProperty(ref _carrier, value);
        }

        private ObservableCollection<Model.Carrier> _carriers;

        public ObservableCollection<Model.Carrier> CarrierList
        {
            get => _carriers;
            set => SetProperty(ref _carriers, value);
        }

        #endregion

        #region Auto

        private ObservableCollection<Model.Auto> _autos;

        public ObservableCollection<Model.Auto> Autos
        {
            get => _autos;
            set => SetProperty(ref _autos, value);
        }

        private Model.Auto _auto;

        public Model.Auto Auto
        {
            get => _auto;
            set => SetProperty(ref _auto, value);
        }

        #endregion

        #region Driver

        private ObservableCollection<Model.Driver> _drivers;

        public ObservableCollection<Model.Driver> Drivers
        {
            get => _drivers;
            set => SetProperty(ref _drivers, value);
        }

        private Model.Driver _driver;

        public Model.Driver Driver
        {
            get => _driver;
            set => SetProperty(ref _driver, value);
        }

        #endregion

        #region Params

        private int _tn, _ov, _count;

        public int Ov
        {
            get => _ov;
            set => SetProperty(ref _ov, value);
        }

        public int Tn
        {
            get => _tn;
            set => SetProperty(ref _tn, value);
        }

        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }

        private double _massa;

        public double Massa
        {
            get => _massa;
            set => SetProperty(ref _massa, value);
        }

        private DateTime _date;

        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        #endregion

        public void LoadAuto()
        {
            if (Carrier != null)
            {
                Autos = new ObservableCollection<Model.Auto>
                (CarrierList?.FirstOrDefault(q => q.Id == Carrier.Id)
                    ?.Autos?
                    .ToList()!);
                if (!Autos.Any())
                {
                    Drivers = new ObservableCollection<Model.Driver>();
                }
            }
        }

        public void LoadDriver()
        {
            if (Auto != null)
            {
                Drivers = new ObservableCollection<Model.Driver>
                (Autos?.FirstOrDefault(q => q.Id == Auto.Id)
                    ?.Drivers?
                    .ToList()!);
            }
        }
        public string DriverName { get; set; }

        private void SetDriverName()
        {
            var split = Driver.Name.Split(' ');
            DriverName = split.First() + " " +
                   string.Join(" ",
                       split.Skip(1)
                           .Select(s => string.Format("{0}.", s.First())));
        }
        public bool LoadInTN()
        {
            try
            {
                SetDriverName();
                Directory.CreateDirectory(@"C:\Создать ТН");
                Directory.CreateDirectory(@$"C:\Создать ТН\{Cipher.Name}");

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var currentPath = AppDomain.CurrentDomain.BaseDirectory;
                var existingFile = new FileInfo(@$"{currentPath}Template\Tn.xlsx");
                var fNewFile = new FileInfo(@$"C:\Создать ТН\{Cipher.Name}\{Ov}.xlsx");
                using var excelPackage = new ExcelPackage(existingFile);


                var worksheet = excelPackage.Workbook.Worksheets.First();
                worksheet.Cells["B19"].Value = ShippingName.Name;
                worksheet.Cells["I9"].Value = Tn;
                worksheet.Cells["BB9"].Value = Ov;
                worksheet.Cells["AJ9"].Value = Date.Date.ToString("yyyy-MM-dd");
                worksheet.Cells["AH14"].Value = $"{Consignee.Name} {Consignee.Address} {Consignee.Contact}";
                worksheet.Cells["AH43"].Value = $"{Consignee.Name} {Consignee.Address} {Consignee.Contact}";

                worksheet.Cells["B18"].Value = Consignee.Name;
                worksheet.Cells["B19"].Value = $"{ShippingName.Name} {Massa} кг";
                worksheet.Cells["B20"].Value = $"{ShippingName.Name} {Massa} кг";
                worksheet.Cells["B28"].Value = Ov;
                worksheet.Cells["B45"].Value = Date.Date.ToString("yyyy-MM-dd");
                ;
                worksheet.Cells["B47"].Value = Date.Date.ToString("yyyy-MM-dd");
                ;
                worksheet.Cells["R47"].Value = Date.Date.ToString("yyyy-MM-dd");
                ;
                worksheet.Cells["R55"].Value = DriverName;
                worksheet.Cells["AH49"].Value = ShippingName.Name;
                worksheet.Cells["B51"].Value = Massa;
                worksheet.Cells["R51"].Value = Count;
                worksheet.Cells["AH51"].Value = Massa;
                worksheet.Cells["AX51"].Value = Count;
                worksheet.Cells["AX55"].Value = DriverName;
                worksheet.Cells["B75"].Value = Date.Date.ToString("yyyy-MM-dd");
                ;
                worksheet.Cells["Q75"].Value = $"{Carrier.Name} {Carrier.SEO}";
                worksheet.Cells["B82"].Value =
                    $"{Carrier.Name} {Carrier.Address} {Carrier.INN} {Carrier.Contact} {Carrier.SEO}";
                worksheet.Cells["B82"].Value =
                    $"{Carrier.Name} {Carrier.Address} {Carrier.INN} {Carrier.Contact} {Carrier.SEO}";
                worksheet.Cells["J84"].Value = DriverName;
                worksheet.Cells["B87"].Value = Auto.Brand;
                worksheet.Cells["AM87"].Value = Auto.Number;
                worksheet.Cells["S121"].Value = Date.Date.ToString("yyyy-MM-dd");
                ;
                worksheet.Cells["AY121"].Value = Date.Date.ToString("yyyy-MM-dd");
                ;
                worksheet.Cells["AH121"].Value = $"{Carrier.Name} {Carrier.SEO}";


                excelPackage.SaveAs(fNewFile);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool LoadInOV()
        {
            try
            {
                SetDriverName();
                Directory.CreateDirectory(@"C:\Создать ОВ");
                Directory.CreateDirectory(@$"C:\Создать ОВ\{Cipher.Name}");

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var currentPath = AppDomain.CurrentDomain.BaseDirectory;
                var existingFile = new FileInfo(@$"{currentPath}Template\Ov.xlsx");
                var fNewFile = new FileInfo(@$"C:\Создать ОВ\{Cipher.Name}\{Tn}.xlsx");
                using var excelPackage = new ExcelPackage(existingFile);


                var worksheet = excelPackage.Workbook.Worksheets.First();
                worksheet.Cells["E2"].Value = Ov;
                worksheet.Cells["L2"].Value = Cipher.Name;
                worksheet.Cells["C4"].Value = Carrier.Name;
                worksheet.Cells["E4"].Value = Consignee.Name;
                worksheet.Cells["A10"].Value = ShippingName.Name;
                worksheet.Cells["E10"].Value = Count;
                worksheet.Cells["G10"].Value = $"{Auto.Brand} {Auto.Number}";
                worksheet.Cells["J10"].Value = Tn;
                worksheet.Cells["K10"].Value = Massa;
                worksheet.Cells["L10"].Value = Massa;
                worksheet.Cells["H15"].Value = Date.Date.ToString("yyyy-MM-dd");


                excelPackage.SaveAs(fNewFile);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        
    }
}