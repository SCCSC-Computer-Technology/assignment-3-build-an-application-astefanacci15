using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace States_AnnaStefanacci_CPT206
{
    public partial class StateInfoForm : Form
    {

        DataView statesGridView;

        public StateInfoForm(string selectedState)
        {
            InitializeComponent();
        }

        public StateInfoForm(string selectedState, DataView dv)
        {
            SelectedState = selectedState;
            statesGridView = dv;
            InitializeComponent();
            LoadData();
        }

        public string SelectedState { get; set; }
        public object DataList { get; set;  }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void LoadData()
        {
            statesGridView.Sort = "State Name";
            int rowIndex = statesGridView.Find(SelectedState);
            StringBuilder stateInfo = new StringBuilder();
            for (int i = 0; i < statesGridView.Table.Columns.Count; i++)
            {
                stateInfo.AppendLine(statesGridView.Table.Rows[rowIndex][i].ToString());
            }

            textBoxStateInfo.Text = stateInfo.ToString();
        }

        
    }
}
