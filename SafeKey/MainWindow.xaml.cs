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

namespace SafeKey
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

        private void SafeKeyMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            int testListItemCount = 10;

            for (int i = 0; i < testListItemCount; i++)
            {
                ListBoxItem lbi = new ListBoxItem();
                DataTemplate dt = GetContentTemplate("CredentialListItemContentTemplate");
                lbi.Style = GetResourceStyle("CredentialListItem");
                lbi.ContentTemplate = dt;

                CredentialsList.Items.Add(lbi);
            }
        }

        Style GetResourceStyle(string XKey)
        {
            return (Style)Application.Current.Resources[XKey];
        }

        DataTemplate GetContentTemplate(string XKey)
        {
            return (DataTemplate)Application.Current.Resources[XKey];
        }
    }

    
}
