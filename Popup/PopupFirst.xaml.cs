using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Maui.Views;

namespace PopupV2CanBeDismissedByTappingOutsideOfPopupBug.Popup;

public partial class FirstPopup : Popup<string>
{
    public FirstPopup()
    {
        InitializeComponent();
    }

    private async void OpenSecondPopupButton_Clicked(object sender, EventArgs e)
    {
        var secondaryPopup = new SecondaryPopup();
        await Shell.Current.ShowPopupAsync<string>(secondaryPopup, new PopupOptions { CanBeDismissedByTappingOutsideOfPopup = true });
    }

    private async void CloseFirstPopupButton_Clicked(object sender, EventArgs e)
    {
        await this.CloseAsync("First Popup Closed");
    }


}