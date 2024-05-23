using System;
using System.Collections.Generic;
using System.Data;
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
using Laba_1_4_DataSet.Laba5DataSetTableAdapters;

namespace Laba_1_4_DataSet
{

    public partial class MainWindow : Window
    {
        BrandsTableAdapter brands = new BrandsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            DataTable brandsTable = brands.GetData();
            DataView brandsView = new DataView(brandsTable);
            BrandsComboBox.ItemsSource = brandsView;
            BrandsComboBox.DisplayMemberPath = "BrandsName";
        }

        private void BrandsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BrandsComboBox.SelectedItem != null)
            {
                object Brand_ID = (BrandsComboBox.SelectedItem as DataRowView).Row[0];
                object BrandsName = (BrandsComboBox.SelectedItem as DataRowView).Row[1];

                MessageBox.Show($"ID: {Brand_ID}, BrandsName: {BrandsName}");
            }
        }

    }
}