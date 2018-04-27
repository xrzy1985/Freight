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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{

            DisplayedInformation i = new DisplayedInformation();

            i.displayed_information = "Tip Amount Calculator";

            i.break_line = " ";

            BindingContext = i;

            InitializeComponent ();
		}
	}
}