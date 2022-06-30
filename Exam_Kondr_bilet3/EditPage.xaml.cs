using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exam_Kondr_bilet3
{
    public partial class EditPage : ContentPage
    {
        public EditPage()
        {
            InitializeComponent();
        }

        private async void SaveF(object sender, EventArgs e)
        {
            var friend = (Stud)BindingContext;
            if (!String.IsNullOrEmpty(friend.Name))
            {
                await App.Database.SaveItemAsync(friend);
            }
            await this.Navigation.PopAsync();
        }
        private async void DeleteF(object sender, EventArgs e)
        {
            var friend = (Stud)BindingContext;
            await App.Database.DeleteItemAsync(friend);
            await this.Navigation.PopAsync();
        }
        private async void Cancel(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}