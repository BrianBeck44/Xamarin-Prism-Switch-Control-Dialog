using Prism.Commands;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchControlToggleDialog.ViewModels
{
    

    public class SwitchToggleDialogViewModel : ViewModelBase, IDialogAware
    {
        private IDialogService _dialogService;

        private string _message;

        public event Action<IDialogParameters> RequestClose;

        protected IDialogService DialogService { get; private set; }

        public SwitchToggleDialogViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService)
        {
            Title = "Testing... Dialog works with button";
            _dialogService = dialogService;
            CloseCommand = new DelegateCommand(()=>RequestClose(null));
        }

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public DelegateCommand CloseCommand { get; }

        private void ExecuteCancel()
        {

        }

        public bool CanCloseDialog() => true;
        
        public void OnDialogClosed()
        {
            throw new NotImplementedException();
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
    }
}
