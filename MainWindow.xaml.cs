using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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

namespace tugas
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
      

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            if (textnama.Text=="" || textumur.Text=="" || textalamat.Text=="" || textkontak.Text == "")
            {
                MessageBox.Show("Isi Semua kotak yang ada!!!");

                
            } else
            {
                data.Items.Add(new { kolom_nama = textnama.Text, kolom_umur = Convert.ToInt32(textumur.Text), kolom_alamat = textalamat.Text, kolom_kontak = Convert.ToInt32(textkontak.Text) });
                textnama.Clear();
                textumur.Clear();
                textkontak.Clear();
                textalamat.Clear();
            }
          
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            int row = data.SelectedIndex;
            data.Items.RemoveAt(row);
        }
        private void selectbtn_Click(object sender, RoutedEventArgs e)
        {
            
              int row = data.SelectedIndex;
           

        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            textnama.Clear();
            textumur.Clear();
            textkontak.Clear();
            textalamat.Clear();
        }
    }
    


}
