using Microsoft.Extensions.DependencyInjection;

namespace PopupV2CanBeDismissedByTappingOutsideOfPopupBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}