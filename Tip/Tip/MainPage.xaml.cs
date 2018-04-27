using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tip.Files;
using Xamarin.Forms;

namespace Tip
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            // Here we are telling the function to send us to a new Page object 
            // everytime the button is clicked on, or triggered
            Navigation.PushAsync(new About());
        }

    }
}
