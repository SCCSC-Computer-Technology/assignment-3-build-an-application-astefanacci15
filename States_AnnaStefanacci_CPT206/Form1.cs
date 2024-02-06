using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // import this to connect db

namespace States_AnnaStefanacci_CPT206
{
    /*  Anna Stefanacci
     *  CPT 206 - States Form
     */
    public partial class FormStates : Form
    {

        private OleDbConnection connection; // database connection object
        private OleDbDataAdapter dataAdapter;
        private DataSet dataSet; // to hold retrieved data

        public FormStates()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this line of code loads data into the 'statesDBDataSet.States' table. 
            this.statesTableAdapter.Fill(this.statesDBDataSet.States);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // exit button
            this.Close();
            // tool tip 'C' close
            this.toolTip1.SetToolTip(this.buttonClose, "Exit States Form");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.RowFilter = ""; // clear the RowFilter to show all rows
            statesGridView.DataSource = dv;
            // tool tip 'R' reset
            this.toolTip2.SetToolTip(this.buttonReset, "Reset States Form");
        }

        // states alphabetically
        private void buttonStatesAlpha_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "State Name ASC"; // acsending order
            statesGridView.DataSource = dv;
        }

        private void statesbindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            // binding nav
            this.Validate();
            this.statesBindingSource.EndEdit();
            this.statesTableAdapter.Update(this.statesDBDataSet);
        }

        // flowers alphabetically
        private void buttonFlowersAlpha_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "State Flower ASC"; // acsending order
            statesGridView.DataSource = dv;
        }

        // birds alphabetically
        private void buttonBirdsAlpha_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "State Bird ASC"; // acsending order
            statesGridView.DataSource = dv;
        }

        // jobs percentage ranked
        private void buttonJobsAsc_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "Percentage of Computer-Related Jobs ASC"; // acsending order
            statesGridView.DataSource = dv;
        }

        // median income ranked
        private void buttonMedIncomeAsc_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "Median Income DESC"; // desending order
            statesGridView.DataSource = dv;
        }

        // population ranked
        // note to self: fix population in access, not ranking properly
        private void buttonPopAsc_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "Population (in millions) DESC"; // desending order
            statesGridView.DataSource = dv;
        }

        // variable for state
        string selectedState;

        // the selection
        private void listBoxStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = listBoxStates.SelectedItem.ToString();
        }

        // button for choosing a specific state
        private void buttonStateSort_Click(object sender, EventArgs e)
        {
             string selectedState = listBoxStates.SelectedValue.ToString();
            // pass relevant data
            StateInfoForm stateInfoForm = new StateInfoForm(selectedState, statesDBDataSet.States.DefaultView);
            stateInfoForm.Show();
        }

        // capitols alphabetically
        private void buttonStateCaptiolAsc_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "State Capitol ASC"; // acsending order
            statesGridView.DataSource = dv;
        }
        
        // colors alphabetically
        private void buttonColorsAsc_Click(object sender, EventArgs e)
        {
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "State Colors ASC"; // acsending order
            statesGridView.DataSource = dv;
        }

        // state flag description
        private void buttonFlagDesShow_Click(object sender, EventArgs e)
        {
            string selectedStateFlag = listBoxStatesTwo.SelectedValue.ToString();
            DataView dv = statesDBDataSet.States.DefaultView;
            dv.Sort = "State Name";
            int rowIndex = dv.Find(selectedStateFlag);
            string stateFlagDescription = (string)(dv.Table.Rows[rowIndex])["State Flag Description"];

            MessageBox.Show($"State: {selectedState}\nState Flag Description: {stateFlagDescription}");
        }

    }
}

