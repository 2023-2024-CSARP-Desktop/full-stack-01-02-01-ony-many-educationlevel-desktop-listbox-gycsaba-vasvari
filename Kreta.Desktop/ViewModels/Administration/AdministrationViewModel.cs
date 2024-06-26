﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;

namespace Kreta.Desktop.ViewModels.Administration
{
    public partial class AdministrationViewModel : BaseViewModel
    {
        private EducationLevelViewModel _educationLevelViewModel;

        [ObservableProperty]
        private BaseViewModel _currentAdministrationChildView;

        public AdministrationViewModel()
        {
            _currentAdministrationChildView = _educationLevelViewModel;
        }

        public AdministrationViewModel(EducationLevelViewModel educationLevelViewModel)
        {
            _educationLevelViewModel= educationLevelViewModel;
            CurrentAdministrationChildView= _educationLevelViewModel;            
            CurrentAdministrationChildView.InitializeAsync();
        }

        [RelayCommand]
        private void ShowEducationLevel()
        {
            CurrentAdministrationChildView = _educationLevelViewModel;
            _educationLevelViewModel.InitializeAsync();
        }
    }
}
