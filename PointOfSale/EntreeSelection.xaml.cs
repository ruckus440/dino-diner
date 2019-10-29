using DinoDiner.Menu;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        public Entree Entree { get; set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public void EntreeSelect(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
            }
            NavigationService.Navigate(new Selection());
        }

        public void AddBrontowurst(object sender, RoutedEventArgs args)
        {
            EntreeSelect(new Brontowurst());
        }

        public void AddDinoNuggets(object sender, RoutedEventArgs args)
        {
            EntreeSelect(new DinoNuggets());
        }

        public void AddPrehistoricPBJ(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new PrehistoricPBJCustomization(pbj));
            }
        }

        public void AddPterodactylWings(object sender, RoutedEventArgs args)
        {
            EntreeSelect(new PterodactylWings());
        }

        public void AddSteakosaurusBurger(object sender, RoutedEventArgs args)
        {
            EntreeSelect(new SteakosaurusBurger());
        }

        public void AddTRexKingBurger(object sender, RoutedEventArgs args)
        {
            EntreeSelect(new TRexKingBurger());
        }

        public void AddVelociWrap(object sender, RoutedEventArgs args)
        {
            EntreeSelect(new VelociWrap());
        }
    }
}
