using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App12
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public MainPage()
        {
            InitializeComponent();
            MyListView.ItemsSource = employees;
            MessagingCenter.Subscribe<Object, Employee>(this, "add_click", (sender, arg) => {
                employees.Add(arg);
            });
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new page1());
        }
    }
}
