using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestCaseComplete
{
	public partial class Form_UpdateResultDialog : Form
	{
		#region Variables
		int _resultID = -1;
		int _status = 0;
		string _updateNotes = string.Empty;
		#endregion

		public Form_UpdateResultDialog(ResultListViewItem result)
		{
			_resultID = result.ID;
			_status = result.iStatus;
			_updateNotes = result.UpdatedNotes;
			InitializeComponent();
			FillFields();
		}

		private void FillFields()
		{
			SetupComboBox();
			rtb_UpdateNotes.Text = _updateNotes;
		}

		private void SetupComboBox()
		{
			cb_Status.Items.Add("Not Run");
			cb_Status.Items.Add("Passed");
			cb_Status.Items.Add("Failed");
			if (_status == -1)
			{
				cb_Status.SelectedIndex = 2;
			}
			else if (_status == 1)
			{
				cb_Status.SelectedIndex = 1;
			}
			else
			{
				cb_Status.SelectedIndex = 0;
			}
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			if ((rtb_UpdateNotes.Text != ""))
			{
				if(cb_Status.Text == "Passed")
				{
					_status = 1;
				}
				else if(cb_Status.Text == "Failed")
				{
					_status = -1;
				}
				Client.dataAccess.ResultsCheckIn(_resultID, _status, MFController._loggedInUser.UserName, rtb_UpdateNotes.Text.Trim());
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("All Fields Must be filled");
			}

		}
	}
}