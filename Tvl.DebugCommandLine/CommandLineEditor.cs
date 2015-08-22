using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tvl.DebugCommandLine
{
    public partial class CommandLineEditor : Form
    {
        public CommandLineEditor(ReadOnlyCollection<string> RecentCommandLines)
        {
            InitializeComponent();

            lstLines.Columns[0].Width = lstLines.Width-4;
            if (RecentCommandLines.Count > 0)
            {
                foreach (string commandline in RecentCommandLines)
                {
                    ListViewItem lvi = new ListViewItem(commandline);
                    lstLines.Items.Add(lvi);
                }
            }
            updateCounterLabel();
        }

        public ReadOnlyCollection<string> getCommandLines()
        {
            List<string> items = new List<string>();
            foreach (ListViewItem lvi in lstLines.Items)
            {
                items.Add(lvi.Text);
            }

            return new ReadOnlyCollection<string>(items);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Ignore any changes
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Store changes
            Close();
        }

        private void lstLines_ItemActivate(object sender, EventArgs e)
        {
            lstLines.SelectedItems[0].BeginEdit();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstLines.Items.Count < DebugCommandLinePackage.maxRecentCommandLineCount)
            {
                ListViewItem lvi = lstLines.Items.Add(new ListViewItem("<New Command Line>"));
                updateCounterLabel();
                lvi.BeginEdit();
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstLines.SelectedItems.Count > 0)
            {
                lstLines.Items.Remove(lstLines.SelectedItems[0]);
                updateCounterLabel();
            }
        }

        private void CommandLineEditor_ResizeEnd(object sender, EventArgs e)
        {
            lstLines.Columns[0].Width = lstLines.Width - 4;
        }

        private void updateCounterLabel()
        {
            lblCounter.Text = "" + lstLines.Items.Count + " / " + DebugCommandLinePackage.maxRecentCommandLineCount;
            if (lstLines.Items.Count >= DebugCommandLinePackage.maxRecentCommandLineCount)
            {
                lblCounter.ForeColor = Color.Red;
            }
            else
            {
                lblCounter.ForeColor = Color.Black;
            }
        }
    }
}
