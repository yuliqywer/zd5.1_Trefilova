using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorCredit
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RatesPage : ContentPage
    {
        public RatesPage()
        {
            InitializeComponent();
            CurrencyDatePicker.Date = new DateTime(2026, 6, 11);
        }
    }
}