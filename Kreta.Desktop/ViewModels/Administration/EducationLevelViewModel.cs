﻿using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.Administration
{
    public partial class EducationLevelViewModel : BaseViewModel
    {
        private readonly IEducationLevelService? _educationLevelService;

        [ObservableProperty]
        private ObservableCollection<EducationLevel> _educationLevels = new();

        [ObservableProperty]
        private EducationLevel _selectedEducationLevel = new();

        public EducationLevelViewModel()
        {            
        }
        public EducationLevelViewModel(IEducationLevelService? educationLevelService)
        {
            _educationLevelService = educationLevelService;
        }

        public string Title { get; set; } = "Tanulmányi szint kezelése";

        public override async Task InitializeAsync()
        {
            await UpdateView();
            await base.InitializeAsync();
        }


    }
}
