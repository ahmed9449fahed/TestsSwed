using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Utils.About;
using TestsDemo.Annotations;
using TestsDemo.DataManager;
using System.Xml;
using DevExpress.XtraPrinting.Native;

namespace TestsDemo.UIL.QuestionsView
{
    /// <summary>
    /// Interaction logic for QuestionView.xaml
    /// </summary>
    public partial class QuestionView : UserControl,INotifyPropertyChanged
    {
        public QuestionView()
        {
            InitializeComponent();
      
        }

        

        public ObservableCollection<Questions> QuestionsCollection=new ObservableCollection<Questions>();
   
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Questions q=new Questions();
            List<Answers> A=new List<Answers>();
            q.Question = TxtQuestion.Text;
            if (!TxtAnswer1.Text.IsEmpty())
            {
                Answers an=new Answers();
                an._answer = TxtAnswer1.Text;
                an.TrueAnswer = check1.IsChecked.Value;     
               A.Add(an);
            }
            if (!TxtAnswer2.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer2.Text;
                an.TrueAnswer = check2.IsChecked.Value;
                A.Add(an);
            }
            if (!TxtAnswer3.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer3.Text;
                an.TrueAnswer = check3.IsChecked.Value;
                A.Add(an);
            }
            if (!TxtAnswer4.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer4.Text;
                an.TrueAnswer = check4.IsChecked.Value;
                A.Add(an);
            }
            if (!TxtAnswer5.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer5.Text;
                an.TrueAnswer = check5.IsChecked.Value;
                A.Add(an);
            }
            if (!TxtAnswer6.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer6.Text;
                an.TrueAnswer = check6.IsChecked.Value;
                A.Add(an);
            }
            if (!TxtAnswer7.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer7.Text;
                an.TrueAnswer = check7.IsChecked.Value;
                A.Add(an);
            }
            if (!TxtAnswer8.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer8.Text;
                an.TrueAnswer = check8.IsChecked.Value;
                A.Add(an);
            }
            if (!TxtAnswer9.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer9.Text;
                an.TrueAnswer = check9.IsChecked.Value;
                A.Add(an);
            }
            if (!TxtAnswer10.Text.IsEmpty())
            {
                Answers an = new Answers();
                an._answer = TxtAnswer10.Text;
                an.TrueAnswer = check10.IsChecked.Value;
                A.Add(an);
            }
            q.AnswersList = A;
            QuestionsCollection.Add(q);
            GridControlQuestions.ItemsSource = QuestionsCollection.Select(x => x.Question);
            List<Answers> list=new List<Answers>();
            foreach (Answers answers in q.AnswersList)
            {
                list.Add(answers);
            }
            GridControlAnswers.ItemsSource = list;

        }
    }
}
