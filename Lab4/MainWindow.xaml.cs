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

namespace Lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rovn rovn;
        private Pramoug pramoug;
        private RovnStor rovnStor;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rovn = new Rovn(double.Parse(Dve.Text),
                                      double.Parse(UgleRovn.Text));
            RES1.Text = rovn.Print();
            
           
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            pramoug = new Pramoug(double.Parse(PramougPer.Text),
                                     double.Parse(PramougVtor.Text));
            RES2.Text = pramoug.Print();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            rovnStor = new RovnStor(double.Parse(VsStoron.Text));
            RES3.Text = rovnStor.Print();
        }
    }
}
