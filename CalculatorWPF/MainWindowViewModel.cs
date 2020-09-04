using Calculations;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CalculatorWPF
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            History = new ObservableCollection<Calculator>();

            Calculator = new Calculator();
            Calculator.distance = 60;
            Calculator.speed = 60;
            Calculator.minutes = 60;
            Calculator.distanceType = "MPH";
            Calculator.speedType = "KPH";


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
    }
}
