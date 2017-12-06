// Helge Stenström 2017
// ah7875

using System;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// The main form has a task manager
        /// </summary>
        private readonly TaskManager _taskManager = new TaskManager();
        private bool _closeForm = true;

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


        private void Form1_Load(object sender, EventArgs e)
        {
            _taskManager.Clear();
            InitializeGui();
            UpdateTable();
           
        }

        private void InitializeGui()
        {
            cbxPrio.DataSource = Task.GetAllPrioStrings();
            txtDescription.Clear();
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
            //NotImplementedMessage();
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
            foreach (var task in _taskManager.TasksAsStrings)
            {
                // Create a row of the data
                ListViewItem row = new ListViewItem(task);
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

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new AboutBox().ShowDialog();
            MessageBox.Show("This is a solution to Assignment 6 i MAH's C# course 2017. \n (c) 2017 Helge Stenström");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons okButton = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Sure to exit the program?",
                "Think twice!",
                okButton);

            if (result == DialogResult.OK)
            {
                _closeForm = true;
                Application.Exit();
            }
            else _closeForm = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_closeForm)
                e.Cancel = false; // Close this form
            else
                e.Cancel = true; // Do not close (user has chosen Cancel)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            // TODO: Skriv värdena med inledande nolla, när det behövs
            lblNow.Text = $"{now.Hour,2}:{now.Minute,2}:{now.Second,2}";
        }

        private void openDatefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotImplementedMessage();
        }

        private void saveDatefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotImplementedMessage();
        }
    }
}
