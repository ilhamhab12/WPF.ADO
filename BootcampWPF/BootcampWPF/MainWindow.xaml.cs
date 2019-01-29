using BootcampWPF.Model;
using System;
using System.Collections.Generic;
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

namespace BootcampWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyContext _context = new MyContext();
        Suppliers supplier = new Suppliers();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Please Insert Name Supplier", "Warning", MessageBoxButton.OK);
            }
            else
            {
                //var name = NameTextBox.Text;
                supplier.Name = NameTextBox.Text;
                supplier.JoinDate = DateTimeOffset.Now.LocalDateTime;
                supplier.CreateDate = DateTimeOffset.Now.LocalDateTime;
                _context.Suppliers.Add(supplier);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Insert Succesfully", "Sukses", MessageBoxButton.OK);
                    NameTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Insert Failed", "Failed", MessageBoxButton.OK);
                }
            }
        }

        private void NameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("^[a-zA-Z .]*$"); //Agar TextBox hanya bisa di isi dengan huruf alfabet tidak bisa angka
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            LenghtTextBox.Text = NameTextBox.Text.Length.ToString();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SupplierDataGrid.ItemsSource = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
            SupplierComboBox.ItemsSource = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
        }

        private void SupplierDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            //Untuk memilih saat click di data supplier di tampilin di TextBox 
            // NamaBox.Text = (SupplierGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            object item = SupplierDataGrid.SelectedItem;
            NameTextBox.Text = (SupplierDataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;

            //Untuk memilih saat click di data supplier tp tidak usah
            //SupplierComboBox.Text = (SupplierDataGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var category = SearchComboBox.Text;
            if (SearchComboBox.Text == "" && SearchTextBox.Text == "")
            {
                MessageBox.Show("Please Chose and Insert Data Search Supplier", "Warning", MessageBoxButton.OK);
            }
            else
            {
                if(category == "Id")
                {
                    MessageBox.Show("Id Not ready yet", "Failed", MessageBoxButton.OK);
                    SupplierDataGrid.ItemsSource = _context.Suppliers.Where(Id => Id.IsDelete == false).ToList();

                }
                else if (category == "Name")
                {
                    MessageBox.Show("Name Not ready yet", "Failed", MessageBoxButton.OK);
                }
                else if (category == "Join Date")
                {
                    MessageBox.Show("Join Date Not ready yet", "Failed", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show("Not ready yet", "Failed", MessageBoxButton.OK);
                }
                // MessageBox.Show("Successfully", "Sucess", MessageBoxButton.OK);
            }

            //if (SearchComboBox.ToString() == "Id")
            //{
            //    if(SearchTextBox == null)
            //    {
            //        MessageBox.Show("Please Insert Data Search Supplier", "Warning", MessageBoxButton.OK);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Berhasil", "Sucess", MessageBoxButton.OK);
            //    }
            //}
            //else if (SearchComboBox.ToString() == "Name")
            //{

            //}
            //else if (SearchComboBox.ToString() == "Join Date")
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Please Chose Category Search");
            //    Console.Read();
            //}
        }
    }
}