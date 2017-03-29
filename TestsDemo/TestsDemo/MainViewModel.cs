using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using TestsDemo.TestsView;
using TestsDemo.UIL;
using TestsDemo.UIL.HomeView;
using TestsDemo.UIL.QuestionsView;

namespace TestsDemo
{
    class MainViewModel: ViewModelBase
    {

        public MainViewModel()
        {
            QuestionView = new DelegateCommand(() => NavigationService.Navigate(typeof(QuestionView).FullName, null, this));
            TestView = new DelegateCommand(() => NavigationService.Navigate(typeof(TestView).FullName, null, this));
            HomeView = new DelegateCommand(() => NavigationService.Navigate(typeof(HomeView).FullName, null, this));
            ResultsView = new DelegateCommand(() => NavigationService.Navigate(typeof(ResultsView).FullName, null, this));

        }

        public DelegateCommand QuestionView { get; }
        public DelegateCommand TestView { get; }
        public DelegateCommand HomeView { get; }
        public DelegateCommand ResultsView { get; }
        private INavigationService NavigationService => GetService<INavigationService>();
    }
}
