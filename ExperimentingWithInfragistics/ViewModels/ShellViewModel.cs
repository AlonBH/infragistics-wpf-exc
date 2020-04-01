using Caliburn.Micro;
using ExperimentingWithInfragistics.Models;

namespace ExperimentingWithInfragistics.ViewModels
{
    public class ShellViewModel : Screen
    {
        public IObservableCollection<TeamMember> TeamMembers { get; set; }

        public ShellViewModel()
        {
            TeamMembers = new BindableCollection<TeamMember>();
            TeamMembers.Add(new TeamMember
            {
                FirstName = "Noga",
                LastName = "Lavan",
                Age = 19
            });
            TeamMembers.Add(new TeamMember
            {
                FirstName = "Aviad",
                LastName = "Rozenkof",
                Age = 24
            });
            TeamMembers.Add(new TeamMember
            {
                FirstName = "Shir",
                LastName = "Magen",
                Age = 22
            });
        }
    }
}
