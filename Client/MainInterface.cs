using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
    public partial class MainInterface : UserControl
    {
        public MainInterface()
        {
            InitializeComponent();
            BuildStatusListView();
        }

        private void BuildStatusListView()
        {
            ListViewGroup StatusGroup = new ListViewGroup("Status", HorizontalAlignment.Center);
            lsv_Status.Groups.Add(StatusGroup);
            foreach( string statusName in _statuses)
            {
                ListViewItem LVI = new ListViewItem(statusName, StatusGroup);
                lsv_Status.Items.Add(LVI);
            }
        }

        #region Variables
        string[] _statuses = new string[] { "Passed", "Failed", "NR" };

        #endregion
    }
}
