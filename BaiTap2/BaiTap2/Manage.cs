using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaiTap2
{
    public class Manager : Employee, IManageable
    {
        private List<IWorkable> teamMembers;
        public Manager(string name) : base(name)
        {
            teamMembers = new List<IWorkable>();
        }
        public override void PerformDuties()
        {
            Manage();
        }
        public void Manage()
        {
            Console.WriteLine($"{Name} is managing the team.");
            foreach (var member in teamMembers)
            {
                member.PerformDuties();
            }
        }
        public void AddTeamMember(IWorkable member)
        {
            teamMembers.Add(member);
        }
    }
}
