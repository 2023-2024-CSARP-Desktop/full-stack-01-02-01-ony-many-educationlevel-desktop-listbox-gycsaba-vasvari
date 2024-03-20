using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;

namespace Kreta.Desktop.ViewModels.Administration
{
    public partial class EducationLevelViewModel : BaseViewModel
    {
        private readonly IEducationLevelService? _educationLevelService;

        public EducationLevelViewModel(IEducationLevelService? educationLevelService)
        {
            _educationLevelService = educationLevelService;
        }

        public string Title { get; set; } = "Tanulmányi szint kezelése";
    }
}
