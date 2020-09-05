using Calculations;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPF
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel(RealFileProvider realFileProvider)
        {
            History = new ObservableCollection<Calculator>();
            fileProvider = realFileProvider;

            Calculator = new Calculator();
            Calculator.distance = 60;
            Calculator.speed = 60;
            Calculator.minutes = 60;
            Calculator.distanceType = "Miles";
            Calculator.speedType = "MPH";


            CalculateCommand = new DelegateCommand(
                () =>
                {
                    Calculator.CalculateAll();
                    History.Add(Calculator);

                    Calculator = Calculator.Clone() as Calculator;
                    RaisePropertyChanged(nameof(Calculator));
                },
                () =>
                {
                    return (Calculator.distance > 0 && Calculator.speed > 0 && Calculator.minutes > 0);
                });

            ConvertCommand = new DelegateCommand(
                () =>
                {
                    if (Calculator.distanceType == "Miles")
                    {
                        Calculator.convertedDistance = Calculator.MilesToKilometers(Calculator.distance);
                    }
                    else if (Calculator.distanceType == "Kilometers")
                    {
                        Calculator.convertedDistance = Calculator.KilometersToMiles(Calculator.distance);
                    }
                    RaisePropertyChanged(nameof(Calculator));
                },
                () =>
                {
                    return (Calculator.distance > 0);
                });
        }

        public ObservableCollection<Calculator> History { get; set; }
        public Calculator Calculator { get; private set; }
        public DelegateCommand CalculateCommand { get; private set; }
        public DelegateCommand ConvertCommand { get; private set; }
        private readonly IFileProvider fileProvider;

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetProperty(ref isBusy, value);
                ImportFromExcel.RaiseCanExecuteChanged();
            }
        }

        private string importFilePath;
        public string ImportFilePath
        {
            get => importFilePath;
            set
            {
                importFilePath = value;
                RaisePropertyChanged(nameof(ImportFilePath));
                ImportFromExcel.RaiseCanExecuteChanged();
            }
        }

        private DelegateCommand importFromExcel;
        public DelegateCommand ImportFromExcel => importFromExcel ??= new DelegateCommand(
            async () =>
            {
                IsBusy = true;
                var rows = await fileProvider.ReadFromExcelAsync(ImportFilePath);
                await Task.Run(() =>
                {
                    Parallel.ForEach(rows, r => r.CalculateAll());
                });
                History.AddRange(rows);
                Calculator = rows.Last().Clone() as Calculator;
                RaisePropertyChanged(nameof(Calculator));
                IsBusy = false;
            },
            () =>
            {
                return fileProvider.FileExists(ImportFilePath) && !IsBusy;
            }
        );

        private DelegateCommand exportToExcel;
        public DelegateCommand ExportToExcel => exportToExcel ??= new DelegateCommand(
            () =>
            {
                fileProvider.ExportToExcel(History);
            });
            //},
            //() =>
            //{
            //    return History.Any();
            //});
    }
}
