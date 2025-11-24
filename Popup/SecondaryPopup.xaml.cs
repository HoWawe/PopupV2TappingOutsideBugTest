using CommunityToolkit.Maui.Views;

namespace PopupV2CanBeDismissedByTappingOutsideOfPopupBug.Popup;

public partial class SecondaryPopup : Popup<string>
{
	public SecondaryPopup()
	{
		InitializeComponent();
	}


    private async void ClosePopupSecondButton_Clicked(object sender, EventArgs e)
    {
        await this.CloseAsync("Second Popup Closed");
    }
}