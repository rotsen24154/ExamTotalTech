using ExamTotalTech.Services.User;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace ExamTotalTech.ViewModels
{
    /// <summary>
    /// All viewmodels has to inherit from the BaseViewModel
    /// </summary>
    public class BaseViewModel : BindableBase, INavigationAware, IDestructible
    {
        #region Properties

        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        public bool IsNotBusy
        {
            get { return !IsBusy; }
        }
        #endregion

        #region Services
        protected INavigationService NavigationService { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for ViewModelBase
        /// </summary>
        /// <param name="navigationService">Interface navigationService</param>
        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        #endregion

        #region Methods
        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
        #endregion
    }
}
