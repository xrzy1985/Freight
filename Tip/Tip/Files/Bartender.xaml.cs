using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tip.Files
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bartender : ContentPage
    {
        public Bartender()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string total_bar_sales = bar_sales.Text;
            
            bool isNum2 = Double.TryParse(total_bar_sales, out double num2);

            if (isNum2)
            {
                double total_bar_sales_double = Convert.ToDouble(total_bar_sales);

                double perc = 0.05;

                double bar_tip_out = Math.Round((total_bar_sales_double * perc), MidpointRounding.AwayFromZero);

                DisplayAlert("Tip Out Calculation", "You will owe $" + bar_tip_out + " to your bartender.", "Close");
                
            }
            else
            {
                DisplayAlert("Tip Out Calculation", "You need to enter proper values.", "Try Again");
            }


        }        
    }
}