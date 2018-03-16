using ExamTotalTech.Helpers;
using ExamTotalTech.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace ExamTotalTech.Views
{
    public partial class DoctorDetailPage : ContentPage
    {
        DoctorDetailPageViewModel viewModel;

        public DoctorDetailPage()
        {
            InitializeComponent();
            viewModel = (DoctorDetailPageViewModel)BindingContext;
        }

        protected override void OnAppearing()
        {
            MoveMap();
        }

        private void MoveMap()
        {
            var location = Utils.StringToPosition(viewModel.CurrentUser.Location.UserPosition);
            UserPositionMap.MoveToRegion(MapSpan.FromCenterAndRadius(location, Distance.FromKilometers(1)));
        }
    }
}
