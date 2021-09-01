using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registrationApp
{
    public partial class View : Form
    {
        Controller controller;
        MemberList medlemList = new MemberList();
        public View()
        {
            InitializeComponent();
            controller = new Controller(this);
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            controller.addMemberClicked();
           // medlemList.addMember("Nour", "Ibrahim");
           // updateList();
        }

        public void UppdateList(List<string> result)
        {
            memberListBox.Items.Clear();
            memberListBox.Items.AddRange(result.ToArray());
        }

        public int getSelectedMemberIndex()
        {
            return memberListBox.SelectedIndex;
        }

        private void RemoveMemberButton_Click(object sender, EventArgs e)
        {
            controller.RemoveMemberClicked();
            // medlemList.removeMemberAt(memberListBox.SelectedIndex);
            // updateList();
        }
        /*
               private void updateList()
               {

                   memberListBox.Items.Clear();
                   foreach (var member in medlemList.Members)
                   {
                       memberListBox.Items.Add($"{member.FirstName} { member.LastName}");
                   } 


               }
        */
    }
}
