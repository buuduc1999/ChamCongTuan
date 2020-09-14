﻿using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChamCongTuan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static List<Person> ListPerson = new List<Person>();
        private void NhapHoSoBtn(object sender, RoutedEventArgs e)
        {

            List<Person> PersonList = new List<Person>();
            try
            {
                // mở file excel
                var package = new ExcelPackage(new FileInfo(@"E:\OneDrive - poxz\User\ADMIN\Desktop\ChamCongTuan\ChamCongTuan\HoSoNhanSu.xlsx"));

                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                List<Person> ListPerson = new List<Person>();
                // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
                for (int i = workSheet.Dimension.Start.Row + 2; i <= workSheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        // biến j biểu thị cho một column trong file
                        int j = 1;

                        // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh

                        // lấy ra cột ngày sinh tương ứng giá trị tại vị trí [i, 2]. i lần đầu là 2
                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        // lấy ra giá trị ngày tháng và ép kiểu thành DateTime  
                        Person person = new Person();
                        person.MaNhanVien = workSheet.Cells[i, j++].Value.ToString();
                        person.HoTen = workSheet.Cells[i, j++].Value.ToString();
                        person.PhongBan = workSheet.Cells[i, j++].Value.ToString();
                        person.ViTri = workSheet.Cells[i, j++].Value.ToString();
                        person.NgaySinh = workSheet.Cells[i, j++].Value.ToString();
                        person.SDT= workSheet.Cells[i, j++].Value.ToString();
                        ListPerson.Add(person);
                    }
                    catch (Exception exe)
                    {

                    }
                }
                Datagrid.ItemsSource = ListPerson;
                this.ListPerson = ListPerson;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(),"Error!");
            }
        }

        private void NhapDuLieuBtn(object sender, RoutedEventArgs e)
        {
            List<Person> PersonList = new List<Person>();
            try
            {
                // mở file excel
                var package = new ExcelPackage(new FileInfo(@"E:\OneDrive - poxz\User\ADMIN\Desktop\ChamCongTuan\ChamCongTuan\Bang-cham-cong-[8-2020].xlsx"));

                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                List<Person> ListPerson = new List<Person>();
                // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
                for (int i = workSheet.Dimension.Start.Row + 2; i <= workSheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        // biến j biểu thị cho một column trong file
                        int j = 1;

                        // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh

                        // lấy ra cột ngày sinh tương ứng giá trị tại vị trí [i, 2]. i lần đầu là 2
                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        // lấy ra giá trị ngày tháng và ép kiểu thành DateTime  
                        Person person = new Person();
                        person.MaNhanVien = workSheet.Cells[i, j++].Value.ToString();
                        person.HoTen = workSheet.Cells[i, j++].Value.ToString();
                        person.PhongBan = workSheet.Cells[i, j++].Value.ToString();
                        person.ViTri = workSheet.Cells[i, j++].Value.ToString();
                        person.NgaySinh = workSheet.Cells[i, j++].Value.ToString();
                        person.SDT = workSheet.Cells[i, j++].Value.ToString();
                        ListPerson.Add(person);
                    }
                    catch (Exception exe)
                    {

                    }
                }
                Datagrid.ItemsSource = ListPerson;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString(), "Error!");
            }

        }

        private void ExportDataBtn(object sender, RoutedEventArgs e)
        {

        }   
    }
}
