using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchControlToggleDialog.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
		private readonly IDialogService _dialogService;

		protected IDialogService DialogService { get; private set; }

		public MainPageViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService)
        {
            Title = "Main Page";
			_dialogService = dialogService;

			this.AllowUseToggledCommand = new DelegateCommand(this.AllowUseToggled);
		}

		public DelegateCommand AllowUseToggledCommand { get; set; }

		private void AllowUseToggled()
		{
			var message = "This is a test message for the test dialog";
			DialogParameters dialogParameters = new DialogParameters
			{
				{ "Title", "Switch toggled Dialog" },
				{ "Message", message },
			};

			//await this._dialogService.ShowDialogAsync("SwitchToggleDialog", dialogParameters);
			this._dialogService.ShowDialog("SwitchToggleDialog", dialogParameters);
			//this.ProcessDialogNavigationRequest(dialogResult);
		}
	}
}
