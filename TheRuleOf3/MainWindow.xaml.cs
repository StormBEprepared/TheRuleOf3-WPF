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

namespace TheRuleOf3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); PreviewKeyDown += (s, e) =>
            {
                if (e.Key == Key.Escape) Close();
                else if (Abox.Text.Length > 0 && Bbox.Text.Length > 0 && Cbox.Text.Length > 0 && e.Key == Key.Enter)
                {
                    Calculate();
                }
                else if (Abox.Text.Length == 0 || Bbox.Text.Length == 0 || Cbox.Text.Length == 0)
                {
                    if (e.Key == Key.Enter)
                    {
                        MessageBox.Show("Enter values!");

                    }
                } 
            };
            
        }
        private void Grid_DragMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
        }
        private void Calculate()
        {
            double res = (Convert.ToDouble(Cbox.Text.Trim()) * Convert.ToDouble(Bbox.Text.Trim()))/Convert.ToDouble(Abox.Text.Trim());
            string result =Convert.ToString(res);
            Resbox.Text = result.Substring(0,result.IndexOf(".")+2);
           
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
