using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin_1.PortfolioPage;

namespace Xamarin_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectDetails : ContentPage
    {
        public ProjectDetails(Project project)
        {
            InitializeComponent();
            Title = project.Title;
            listView.ItemsSource = new List<Project> { project };
        }
    }
}