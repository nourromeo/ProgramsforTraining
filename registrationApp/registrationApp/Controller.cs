using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registrationApp
{
    class Controller
    {
        MemberList memberlist;
        View view;

        public Controller(View view)
        {
            memberlist = new MemberList();
            this.view = view;
        }

        internal void addMemberClicked()
        {
            memberlist.addMember("Nour", "Ibrahim");
            uppdateList();

        }

        internal void RemoveMemberClicked()
        {
            if (view.getSelectedMemberIndex() > 0 && view.getSelectedMemberIndex() < memberlist.Members.Count)
            {
                memberlist.removeMemberAt(view.getSelectedMemberIndex());
            }
            uppdateList();
        }

        private void uppdateList()
        {
            List<string> result = new List<string>();
            foreach (var member in memberlist.Members)
            {
                result.Add($"{member.FirstName} { member.LastName}");
            }
            view.UppdateList(result);
        }
    }
}
