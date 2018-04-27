using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tip.Files;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tip.Files
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calculator : ContentPage
	{
		public Calculator ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            string total_sales_string = sales.Text;

            string number_of_essays = essays.Text;

            bool isNum = Double.TryParse(total_sales_string, out double num);

            bool isNum2 = Double.TryParse(number_of_essays, out double num2);

            if (isNum && isNum2)
            {
                double total_sales_double = Convert.ToDouble(total_sales_string);                

                // if there was only 1 essay
                if (essays.Text == null)
                {
                    double tip_out = Math.Round(total_sales_double * 0.01, MidpointRounding.AwayFromZero);

                    DisplayAlert("Tip Out Calculation", "You will owe $" + tip_out + " to your essay.", "Close");
                }
                else
                {
                    double total_essays = Convert.ToDouble(number_of_essays);

                    double perc = total_essays * 0.01;

                    double tip_out = total_sales_double * perc;

                    double tip_out_divided = tip_out / total_essays;

                    double tip_out_rounded = Math.Round(tip_out_divided, MidpointRounding.AwayFromZero);

                    DisplayAlert("Tip Out Calculation", "You will owe $" + tip_out_rounded + " to each essay.", "Close");

                }
            }
            else
            {
                DisplayAlert("Tip Out Calculation", "You need to enter proper values.", "Try Again");
            }

            

        }
    
    }
}