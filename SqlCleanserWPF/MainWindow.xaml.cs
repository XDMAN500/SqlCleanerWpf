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

namespace SqlCleanserWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextData textData;
        private bool loaded;


        public MainWindow()
        {
            textData = new TextData();
            InitializeComponent();
            cleanTab.DataContext = textData;
            rawTab.DataContext = textData;
            loaded = true;
 

        }

        private void cleanTab_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
           
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

          
        }

  

        private void cleanTab_MouseDown(object sender, MouseButtonEventArgs e)
        {
        
        }

        private void tabControl_Selected_1(object sender, RoutedEventArgs e)
        {
     
        }

        private void tabControl_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
      
         
        }

        private void tabControl_Selected(object sender, RoutedEventArgs e)
        {
       
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        
          

        }

        private void tabControl_LostFocus(object sender, RoutedEventArgs e)
        {
            textData.RunClean();
        }
    }
}
