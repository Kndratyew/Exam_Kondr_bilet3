using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exam_Kondr_bilet3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            // создание таблицы, если ее нет
            await App.Database.CreateTable();
            // привязка данных
            friendsList.ItemsSource = await App.Database.GetItemsAsync();

            base.OnAppearing();
        }

        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Stud selectedFriend = (Stud)e.SelectedItem;
            EditPage friendPage = new EditPage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }

        // обработка нажатия кнопки добавления
        private async void CreateF(object sender, EventArgs e)
        {
            Stud friend = new Stud();
            EditPage friendPage = new EditPage();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }
    }
}
