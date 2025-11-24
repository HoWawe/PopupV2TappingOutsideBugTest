using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;
using PopupV2CanBeDismissedByTappingOutsideOfPopupBug.Popup;

namespace PopupV2CanBeDismissedByTappingOutsideOfPopupBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void OpenPopupFirstButton_Clicked(object sender, EventArgs e)
        {
            var popupFirst = new FirstPopup();
            var first = await this.ShowPopupAsync<string>(popupFirst, new PopupOptions { CanBeDismissedByTappingOutsideOfPopup = true });

        }
    }
}
