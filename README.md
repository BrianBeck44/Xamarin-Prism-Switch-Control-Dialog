# Xamarin-Prism-Switch-Control-Dialog  Error
Project demonstrates error when attempting to display a Prism Dialog from a Switch Control toggled event.

MainPage.xaml has a button and a switch control.  They both call the same AllowUseToggled command in MainPageViewModel.  
AllowUseToggled uses dialogservice to attempt to open a dialog.

When the button is clicked it opens a Dialog, but when the switch is toggled it throws an object is null exception.

I am wanting to display a Confirmation dialog when the user clicks on the switch control.  


