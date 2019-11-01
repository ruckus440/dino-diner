﻿using DinoDiner.Menu;
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
    /// Interaction logic for BrontowurstCustomization.xaml
    /// </summary>
    public partial class BrontowurstCustomization : Page
    {
        private Brontowurst brontowurst;
        public BrontowurstCustomization(Brontowurst brontowurst)
        {
            InitializeComponent();
            this.brontowurst = brontowurst;
        }

        private void OnHoldBun()
        {
            brontowurst.HoldBun();
        }

        private void OnHoldBrautwurst()
        {
            brontowurst.HoldBrautwurst();
        }

        private void OnHoldPeppers()
        {
            brontowurst.HoldPeppers();
        }

        private void OnHoldOnions()
        {
            brontowurst.HoldOnion();
        }
    }
}