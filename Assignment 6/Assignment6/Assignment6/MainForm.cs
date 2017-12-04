using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// The main form has a task manager
        /// </summary>
        private readonly TaskManager _taskManager = new TaskManager();

        public frmMain()
        {
            InitializeComponent();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnFileCLick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New command executed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGui();
        }

        private void InitializeGui()
        {
            cbxPrio.DataSource = Task.GetAllPrioStrings();
            // _closeForm = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Priority p;
            p = (Priority) 1;
            var sv = cbxPrio.SelectedItem;
            p = (Priority)cbxPrio.SelectedIndex;
            _taskManager.Add(new Task(txtDescription.Text, 
                                      p,
                                       dateTimePicker1.Value, 
                                       false));
            UpdateTable();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            MessageBoxButtons okButton = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("Not implemented",
                "Alert!",
                okButton);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons okButton = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("Not implemented",
                "Alert!",
                okButton);
        }

        /// <summary>
        /// Fill the ListVIEW for customers, with data from the customer manager
        /// </summary>
        private void UpdateTable()
        {
            lstvTasks.Items.Clear();
            foreach (Task t in _taskManager)
            {
                // A list of strings, each for its own column in the view.
                string[] rowStrings = new string[]
                {
                    t.Date.ToShortDateString(),
                    t.Date.Hour.ToString(),
                };
                // Create a row of the data
                ListViewItem row = new ListViewItem(rowStrings);
                // and add it to the ListView
                lstvTasks.Items.Add(row);
            }
        }

        /// <summary>
        /// There must be some text in the description before we can add a task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !(string.IsNullOrEmpty(txtDescription.Text));
        }

        private void lstvTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool activateButtons = (lstvTasks.SelectedIndices.Count == 1);
            btnChange.Enabled = activateButtons;
            btnDelete.Enabled = activateButtons;
        }
    }
}
