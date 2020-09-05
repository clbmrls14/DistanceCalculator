using CalculatorWPF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DistanceCalculator.WPF.Tests
{
    [Binding]
    public sealed class Steps
    {
        private readonly ScenarioContext _scenarioContext;

        public Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a MainWindowViewModel")]
        public void GivenAMainWindowViewModel()
        {
            if (!_scenarioContext.TryGetValue(out Mock<IFileProvider> fileProviderMock))
                fileProviderMock = new Mock<IFileProvider>();
            var viewModel = new MainWindowViewModel(fileProviderMock.Object);
            _scenarioContext.Set(viewModel);
        }

        [When(@"I do nothing")]
        public void WhenIDoNothing() { }

        [Then(@"The Import button is (.*)")]
        public void ThenTheImportButtonIs___(string enabledOrDisabled)
        {
            var isEnabled = enabledOrDisabled.Contains("nabled");
            var viewModel = _scenarioContext.Get<MainWindowViewModel>();
            viewModel.ImportFromExcel.CanExecute().Should().Be(isEnabled);
        }

        [Then(@"The Export button is (.*)")]
        public void ThenTheExportButtonIs___(string enabledOrDisabled)
        {
            var isEnabled = enabledOrDisabled.Contains("isabled");
            var viewModel = _scenarioContext.Get<MainWindowViewModel>();
            viewModel.ImportFromExcel.CanExecute().Should().Be(isEnabled);
        }
    }
}
