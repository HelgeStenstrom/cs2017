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
            // throw new NotImplementedException();
        }

        private void OnFileCLick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
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
            Priority prio;
            prio = (Priority) 1;
            var sv = cbxPrio.SelectedItem;
            prio = (Priority)cbxPrio.SelectedIndex;
            _taskManager.Add(new Task(txtDescription.Text, 
                                      prio,
                                      dateTimePicker1.Value, 
                                      false));
            UpdateTable();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            NotImplementedMessage();
            if (lstvTasks.SelectedIndices.Count == 1)
            {
                int index = lstvTasks.SelectedIndices[0];
                Task task = new Task(txtDescription.Text,
                                      (Priority)cbxPrio.SelectedIndex,
                                      dateTimePicker1.Value,
                                      false);
                _taskManager[index] = task;
                UpdateTable();
            }
        }

        private static void NotImplementedMessage()
        {
            MessageBoxButtons okButton = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show("Not implemented",
                "Alert!",
                okButton);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _taskManager.RemoveAt(lstvTasks.SelectedIndices[0]);
            UpdateTable();
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
                    $"{t.Date.Hour.ToString()}:{t.Date.Minute.ToString()}",
                    t.PrioString,
                    t.IsDone.ToString(),
                    t.Description
                };
                // Create a row of the data
                ListViewItem row = new ListViewItem(rowStrings);
                // and add it to the ListView
                lstvTasks.Items.Add(row);
            }
            ActivateButtons();
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
            bool activateButtons = ActivateButtons();
            if (activateButtons)
            {
                int index = lstvTasks.SelectedIndices[0];
                Task task = _taskManager[index];
                UpdateFormFromTask(task);
            }
        }

        private bool ActivateButtons()
        {
            bool activateButtons = (lstvTasks.SelectedIndices.Count == 1);
            btnChange.Enabled = activateButtons;
            btnDelete.Enabled = activateButtons;
            return activateButtons;
        }

        private void UpdateFormFromTask(Task task)
        {
            txtDescription.Text = task.Description;
            dateTimePicker1.Value = task.Date;
            cbxPrio.SelectedIndex = (int) task.Priority;
        }
    }
}
