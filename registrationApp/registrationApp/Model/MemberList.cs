using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registrationApp
{
    class MemberList
    {
        public List<Member> Members { get; }

        public MemberList()
        {
            Members = new List<Member>();
        }

        public void addMember(string firstName, string lastName)
        {
            Member newMember = new Member(firstName, lastName);
            Members.Add(newMember);
        }

        public void removeMemberAt(int position)
        {
            if(position > 0 && position < Members.Count)
                Members.RemoveAt(position);
        }
    }
}
