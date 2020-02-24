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

namespace ShoppingLists
{
    /// <summary>
    /// Interaction logic for AddToShoppingListControl.xaml
    /// </summary>
    public partial class AddToShoppingListControl : UserControl
    {
        public AddToShoppingListControl()
        {
            InitializeComponent();
            AddButton.Click += OnAddButtonClicked;
        }
        public void OnAddButtonClicked(object sender, RoutedEventArgs e)
        {
            //var data = (ShoppingListData)DataContext; //will throw error if not possible
            //var data = DataContext as ShoppingListData; //will just set variable to null instead of throwing error
            if (DataContext is ShoppingListData data) //Combines all with error checking
            {
                data.Add(ItemsToAdd.Text);
                ItemsToAdd.Text = "";
            }
        }
    }
}
