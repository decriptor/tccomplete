using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Windows.Forms;
using tccomplete.Interfaces;

namespace TestCaseComplete
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_login loginBox = new Form_login();
            if (loginBox.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(loginBox.loggedInUser));
            }
        }
    }
}