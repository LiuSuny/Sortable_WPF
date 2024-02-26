using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Sortable_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GridViewColumnHeader listViewSortCol = null;
        private Sortable listViewSortable = null;
        public MainWindow()
        {
            InitializeComponent();
            //
            ObservableCollection<User> items = new ObservableCollection<User>();
            items.Add(new User() { Name = "John Doe", Age = 42, Sex = SexType.Male, PlaceOfBirth = "Moscow", Mail = "johndoe@mail.ru"});
            items.Add(new User() { Name = "Jane Doe", Age = 39, Sex = SexType.Female, PlaceOfBirth = "Rostov", Mail = "janedoe@gmail.com"});
            items.Add(new User() { Name = "Sammy Doe", Age = 13, Sex = SexType.Male, PlaceOfBirth = "Paris", Mail = "sammydoe@gmail.com" });
            items.Add(new User() { Name = "Donna Doe", Age = 15, Sex = SexType.Female, PlaceOfBirth = "Casablanca", Mail ="donnadoe@hotmail.com"});
            items.Add(new User() { Name = "Rowland Kelly", Age = 25, Sex = SexType.Female, PlaceOfBirth = "Rome", Mail = "rowlandkelly@hotmail.com" });
            items.Add(new User() { Name = "Patrick Joe", Age = 20, Sex = SexType.Male, PlaceOfBirth = "Lagos", Mail = "patrickjoe@hotmail.com" });
            items.Add(new User() { Name = "Justice Vlad", Age = 59, Sex = SexType.Male, PlaceOfBirth = "London", Mail = "justicevlad@hotmail.com" });
            items.Add(new User() { Name = "Lilian Vivian", Age = 27, Sex = SexType.Female, PlaceOfBirth = "New York", Mail = "lilianVi@hotmail.com" });           
            sortableUserData.ItemsSource = items;
        }

        /// <summary>
        /// Click sorted event whenever our item is click  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">routed event</param>
        private void UserSortable_Table_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortable);
                sortableUserData.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortable.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortable = new Sortable(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortable);
            sortableUserData.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }
    }

    

    

    
}
