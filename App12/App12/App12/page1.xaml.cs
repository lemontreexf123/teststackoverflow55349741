using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class page1 : ContentPage
	{
		public page1 ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Name = NameEntry.Text;
            employee.Count = CountEntry.Text;
            MessagingCenter.Send<Object, Employee>(this, "add_click", employee);
            await Navigation.PopAsync();
        }
    }
}