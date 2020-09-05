using Calculations;
using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace CalculatorWPF
{
    public interface IFileProvider
    {
        public bool FileExists(string path);
        public IEnumerable<Calculator> ReadFromExcel(string path);
        public Task<IEnumerable<Calculator>> ReadFromExcelAsync(string path);
        public void ExportToExcel(IEnumerable<Calculator> history);
    }

    public class RealFileProvider : IFileProvider
    {
        public bool FileExists(string path) => File.Exists(path);
        public void ExportToExcel(IEnumerable<Calculator> history)
        {
            var fileName = getFileName();
            if (fileName == null)
                return;

            if (File.Exists(fileName))
            {
                var result = MessageBox.Show("File exists, would you like to overwrite it?", "Overwrite Existing?", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                    File.Delete(fileName);
                else
                    return;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(fileName)))
            {
                var sheet = package.Workbook.Worksheets.Add("Export");
                sheet.Cells[1, 1].Value = "Distance";
                sheet.Cells[1, 2].Value = "Speed";
                sheet.Cells[1, 3].Value = "Minutes";
                sheet.Cells[1, 4].Value = "DistanceType";
                sheet.Cells[1, 5].Value = "Converted Distance";
                sheet.Cells[1, 6].Value = "Speed Type";
                sheet.Cells[1, 7].Value = "Travel Time";
                sheet.Cells[1, 8].Value = "Travel Time String";
                sheet.Cells[1, 9].Value = "Distance Traveled";
                sheet.Cells[1, 10].Value = "Travel Rate";

                var row = 1;
                foreach(var calc in history)
                {
                    row++;
                    sheet.Cells[row, 1].Value = calc.distance;
                    sheet.Cells[row, 2].Value = calc.speed;
                    sheet.Cells[row, 3].Value = calc.minutes;
                    sheet.Cells[row, 4].Value = calc.distanceType;
                    sheet.Cells[row, 5].Value = calc.convertedDistance;
                    sheet.Cells[row, 6].Value = calc.speedType;
                    sheet.Cells[row, 7].Value = calc.travelTime;
                    sheet.Cells[row, 8].Value = calc.travelTimeString;
                    sheet.Cells[row, 9].Value = calc.distanceTraveled;
                    sheet.Cells[row, 10].Value = calc.travelRate;
                }

                sheet.Tables.Add(sheet.Cells[1, 1, row, 10], "ExportTable");
                package.Save();
            }

            new Process
            {
                StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                }
            }.Start();
        }

        public IEnumerable<Calculator> ReadFromExcel(string path)
        {
            var rows = new List<Calculator>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage Package = new ExcelPackage(new FileInfo(path)))
            {
                var sheet = Package.Workbook.Worksheets.First();
                for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                {
                    rows.Add(new Calculator
                    {
                        distance = (double)sheet.Cells[row, 1].Value,
                        speed = (int)sheet.Cells[row, 2].Value,
                        minutes = (double)sheet.Cells[row, 3].Value,
                        distanceType = (string)sheet.Cells[row, 4].Value,
                        convertedDistance = (double)sheet.Cells[row, 5].Value,
                        speedType = (string)sheet.Cells[row, 6].Value,
                        travelTime = (int)sheet.Cells[row, 7].Value,
                        travelTimeString = (string)sheet.Cells[row, 8].Value,
                        distanceTraveled = (double)sheet.Cells[row, 9].Value,
                        travelRate = (double)sheet.Cells[row, 10].Value,
                    });
                }
            }
            return rows;
        }

        public async Task<IEnumerable<Calculator>> ReadFromExcelAsync(string path)
        {
            return await Task.Run(() =>
            {
                var rows = new List<Calculator>();
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
                {
                    var sheet = package.Workbook.Worksheets.First();
                    for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                    {
                        rows.Add(new Calculator
                        {
                            distance = (double)sheet.Cells[row, 1].Value,
                            speed = (int)(double)sheet.Cells[row, 2].Value,
                            minutes = (double)sheet.Cells[row, 3].Value,
                            distanceType = (string)sheet.Cells[row, 4].Value,
                            convertedDistance = (double)sheet.Cells[row, 5].Value,
                            speedType = (string)sheet.Cells[row, 6].Value,
                            travelTime = (int)(double)sheet.Cells[row, 7].Value,
                            travelTimeString = (string)sheet.Cells[row, 8].Value,
                            distanceTraveled = (double)sheet.Cells[row, 9].Value,
                            travelRate = (double)sheet.Cells[row, 10].Value,
                        });
                    }
                }
                return rows;
            });
        }

        private string getFileName()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlxs)|*.xlsx";
            openFileDialog.Title = "Select your Excel Output File";
            openFileDialog.CheckFileExists = false;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() ?? false)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
    }
}
