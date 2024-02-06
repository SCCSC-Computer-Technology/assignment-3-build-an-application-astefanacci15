namespace States_AnnaStefanacci_CPT206
{
    partial class FormStates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStates));
            this.statesGridView = new System.Windows.Forms.DataGridView();
            this.stateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationinMillionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateFlagDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateFlowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateBirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threeLargestCitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCapitolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medianIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentageOfComputerRelatedJobsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesDBDataSet = new States_AnnaStefanacci_CPT206.StatesDBDataSet();
            this.statesTableAdapter = new States_AnnaStefanacci_CPT206.StatesDBDataSetTableAdapters.StatesTableAdapter();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPopAsc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMedIncomeAsc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonJobsAsc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBirdsAlpha = new System.Windows.Forms.Button();
            this.buttonFlowersAlpha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStatesAlpha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStateSort = new System.Windows.Forms.Button();
            this.listBoxStates = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.statesbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFlagDesShow = new System.Windows.Forms.Button();
            this.listBoxStatesTwo = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonColorsAsc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonStateCaptiolAsc = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesbindingNavigator)).BeginInit();
            this.statesbindingNavigator.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statesGridView
            // 
            this.statesGridView.AutoGenerateColumns = false;
            this.statesGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Complex_IV25", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.statesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateNameDataGridViewTextBoxColumn,
            this.populationinMillionsDataGridViewTextBoxColumn,
            this.stateFlagDescriptionDataGridViewTextBoxColumn,
            this.stateFlowerDataGridViewTextBoxColumn,
            this.stateBirdDataGridViewTextBoxColumn,
            this.stateColorsDataGridViewTextBoxColumn,
            this.threeLargestCitiesDataGridViewTextBoxColumn,
            this.stateCapitolDataGridViewTextBoxColumn,
            this.medianIncomeDataGridViewTextBoxColumn,
            this.percentageOfComputerRelatedJobsDataGridViewTextBoxColumn});
            this.statesGridView.DataSource = this.statesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Complex_IV25", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statesGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.statesGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statesGridView.Location = new System.Drawing.Point(12, 40);
            this.statesGridView.Margin = new System.Windows.Forms.Padding(4);
            this.statesGridView.Name = "statesGridView";
            this.statesGridView.Size = new System.Drawing.Size(1097, 256);
            this.statesGridView.TabIndex = 0;
            // 
            // stateNameDataGridViewTextBoxColumn
            // 
            this.stateNameDataGridViewTextBoxColumn.DataPropertyName = "State Name";
            this.stateNameDataGridViewTextBoxColumn.HeaderText = "State Name";
            this.stateNameDataGridViewTextBoxColumn.Name = "stateNameDataGridViewTextBoxColumn";
            // 
            // populationinMillionsDataGridViewTextBoxColumn
            // 
            this.populationinMillionsDataGridViewTextBoxColumn.DataPropertyName = "Population (in millions)";
            this.populationinMillionsDataGridViewTextBoxColumn.HeaderText = "Population (in millions)";
            this.populationinMillionsDataGridViewTextBoxColumn.Name = "populationinMillionsDataGridViewTextBoxColumn";
            // 
            // stateFlagDescriptionDataGridViewTextBoxColumn
            // 
            this.stateFlagDescriptionDataGridViewTextBoxColumn.DataPropertyName = "State Flag Description";
            this.stateFlagDescriptionDataGridViewTextBoxColumn.HeaderText = "State Flag Description";
            this.stateFlagDescriptionDataGridViewTextBoxColumn.Name = "stateFlagDescriptionDataGridViewTextBoxColumn";
            // 
            // stateFlowerDataGridViewTextBoxColumn
            // 
            this.stateFlowerDataGridViewTextBoxColumn.DataPropertyName = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.HeaderText = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.Name = "stateFlowerDataGridViewTextBoxColumn";
            // 
            // stateBirdDataGridViewTextBoxColumn
            // 
            this.stateBirdDataGridViewTextBoxColumn.DataPropertyName = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.HeaderText = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.Name = "stateBirdDataGridViewTextBoxColumn";
            // 
            // stateColorsDataGridViewTextBoxColumn
            // 
            this.stateColorsDataGridViewTextBoxColumn.DataPropertyName = "State Colors";
            this.stateColorsDataGridViewTextBoxColumn.HeaderText = "State Colors";
            this.stateColorsDataGridViewTextBoxColumn.Name = "stateColorsDataGridViewTextBoxColumn";
            // 
            // threeLargestCitiesDataGridViewTextBoxColumn
            // 
            this.threeLargestCitiesDataGridViewTextBoxColumn.DataPropertyName = "Three Largest Cities";
            this.threeLargestCitiesDataGridViewTextBoxColumn.HeaderText = "Three Largest Cities";
            this.threeLargestCitiesDataGridViewTextBoxColumn.Name = "threeLargestCitiesDataGridViewTextBoxColumn";
            // 
            // stateCapitolDataGridViewTextBoxColumn
            // 
            this.stateCapitolDataGridViewTextBoxColumn.DataPropertyName = "State Capitol";
            this.stateCapitolDataGridViewTextBoxColumn.HeaderText = "State Capitol";
            this.stateCapitolDataGridViewTextBoxColumn.Name = "stateCapitolDataGridViewTextBoxColumn";
            // 
            // medianIncomeDataGridViewTextBoxColumn
            // 
            this.medianIncomeDataGridViewTextBoxColumn.DataPropertyName = "Median Income";
            this.medianIncomeDataGridViewTextBoxColumn.HeaderText = "Median Income";
            this.medianIncomeDataGridViewTextBoxColumn.Name = "medianIncomeDataGridViewTextBoxColumn";
            // 
            // percentageOfComputerRelatedJobsDataGridViewTextBoxColumn
            // 
            this.percentageOfComputerRelatedJobsDataGridViewTextBoxColumn.DataPropertyName = "Percentage of Computer-Related Jobs";
            this.percentageOfComputerRelatedJobsDataGridViewTextBoxColumn.HeaderText = "Percentage of Computer-Related Jobs";
            this.percentageOfComputerRelatedJobsDataGridViewTextBoxColumn.Name = "percentageOfComputerRelatedJobsDataGridViewTextBoxColumn";
            this.percentageOfComputerRelatedJobsDataGridViewTextBoxColumn.Width = 150;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.statesDBDataSetBindingSource;
            // 
            // statesDBDataSetBindingSource
            // 
            this.statesDBDataSetBindingSource.DataSource = this.statesDBDataSet;
            this.statesDBDataSetBindingSource.Position = 0;
            // 
            // statesDBDataSet
            // 
            this.statesDBDataSet.DataSetName = "StatesDBDataSet";
            this.statesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(622, 515);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(108, 39);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.buttonPopAsc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonMedIncomeAsc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonJobsAsc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonBirdsAlpha);
            this.groupBox1.Controls.Add(this.buttonFlowersAlpha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonStatesAlpha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // buttonPopAsc
            // 
            this.buttonPopAsc.BackColor = System.Drawing.Color.Red;
            this.buttonPopAsc.Location = new System.Drawing.Point(237, 178);
            this.buttonPopAsc.Name = "buttonPopAsc";
            this.buttonPopAsc.Size = new System.Drawing.Size(90, 27);
            this.buttonPopAsc.TabIndex = 6;
            this.buttonPopAsc.Text = "Sort";
            this.buttonPopAsc.UseVisualStyleBackColor = false;
            this.buttonPopAsc.Click += new System.EventHandler(this.buttonPopAsc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Population Acending:";
            // 
            // buttonMedIncomeAsc
            // 
            this.buttonMedIncomeAsc.BackColor = System.Drawing.Color.Red;
            this.buttonMedIncomeAsc.Location = new System.Drawing.Point(237, 148);
            this.buttonMedIncomeAsc.Name = "buttonMedIncomeAsc";
            this.buttonMedIncomeAsc.Size = new System.Drawing.Size(90, 27);
            this.buttonMedIncomeAsc.TabIndex = 5;
            this.buttonMedIncomeAsc.Text = "Sort";
            this.buttonMedIncomeAsc.UseVisualStyleBackColor = false;
            this.buttonMedIncomeAsc.Click += new System.EventHandler(this.buttonMedIncomeAsc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Median Income Acending:";
            // 
            // buttonJobsAsc
            // 
            this.buttonJobsAsc.BackColor = System.Drawing.Color.Red;
            this.buttonJobsAsc.Location = new System.Drawing.Point(237, 118);
            this.buttonJobsAsc.Name = "buttonJobsAsc";
            this.buttonJobsAsc.Size = new System.Drawing.Size(90, 27);
            this.buttonJobsAsc.TabIndex = 4;
            this.buttonJobsAsc.Text = "Sort";
            this.buttonJobsAsc.UseVisualStyleBackColor = false;
            this.buttonJobsAsc.Click += new System.EventHandler(this.buttonJobsAsc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jobs Acending:";
            // 
            // buttonBirdsAlpha
            // 
            this.buttonBirdsAlpha.BackColor = System.Drawing.Color.Red;
            this.buttonBirdsAlpha.Location = new System.Drawing.Point(237, 88);
            this.buttonBirdsAlpha.Name = "buttonBirdsAlpha";
            this.buttonBirdsAlpha.Size = new System.Drawing.Size(90, 27);
            this.buttonBirdsAlpha.TabIndex = 3;
            this.buttonBirdsAlpha.Text = "Sort";
            this.buttonBirdsAlpha.UseVisualStyleBackColor = false;
            this.buttonBirdsAlpha.Click += new System.EventHandler(this.buttonBirdsAlpha_Click);
            // 
            // buttonFlowersAlpha
            // 
            this.buttonFlowersAlpha.BackColor = System.Drawing.Color.Red;
            this.buttonFlowersAlpha.Location = new System.Drawing.Point(237, 57);
            this.buttonFlowersAlpha.Name = "buttonFlowersAlpha";
            this.buttonFlowersAlpha.Size = new System.Drawing.Size(90, 27);
            this.buttonFlowersAlpha.TabIndex = 2;
            this.buttonFlowersAlpha.Text = "Sort";
            this.buttonFlowersAlpha.UseVisualStyleBackColor = false;
            this.buttonFlowersAlpha.Click += new System.EventHandler(this.buttonFlowersAlpha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birds Alphabetically:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Flowers Alphabetically:";
            // 
            // buttonStatesAlpha
            // 
            this.buttonStatesAlpha.BackColor = System.Drawing.Color.Red;
            this.buttonStatesAlpha.Location = new System.Drawing.Point(237, 27);
            this.buttonStatesAlpha.Name = "buttonStatesAlpha";
            this.buttonStatesAlpha.Size = new System.Drawing.Size(90, 27);
            this.buttonStatesAlpha.TabIndex = 1;
            this.buttonStatesAlpha.Text = "Sort";
            this.buttonStatesAlpha.UseVisualStyleBackColor = false;
            this.buttonStatesAlpha.Click += new System.EventHandler(this.buttonStatesAlpha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "States Alphabetically:";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Red;
            this.buttonReset.Location = new System.Drawing.Point(383, 514);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(108, 39);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.buttonStateSort);
            this.groupBox2.Controls.Add(this.listBoxStates);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(383, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 114);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            // 
            // buttonStateSort
            // 
            this.buttonStateSort.BackColor = System.Drawing.Color.Red;
            this.buttonStateSort.Location = new System.Drawing.Point(238, 60);
            this.buttonStateSort.Name = "buttonStateSort";
            this.buttonStateSort.Size = new System.Drawing.Size(90, 27);
            this.buttonStateSort.TabIndex = 8;
            this.buttonStateSort.Text = "Sort";
            this.buttonStateSort.UseVisualStyleBackColor = false;
            this.buttonStateSort.Click += new System.EventHandler(this.buttonStateSort_Click);
            // 
            // listBoxStates
            // 
            this.listBoxStates.DataSource = this.statesBindingSource;
            this.listBoxStates.DisplayMember = "State Name";
            this.listBoxStates.FormattingEnabled = true;
            this.listBoxStates.ItemHeight = 19;
            this.listBoxStates.Location = new System.Drawing.Point(177, 30);
            this.listBoxStates.Name = "listBoxStates";
            this.listBoxStates.Size = new System.Drawing.Size(151, 23);
            this.listBoxStates.TabIndex = 7;
            this.listBoxStates.ValueMember = "State Name";
            this.listBoxStates.SelectedIndexChanged += new System.EventHandler(this.listBoxStates_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Search by State:";
            // 
            // statesbindingNavigator
            // 
            this.statesbindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.statesbindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesbindingNavigator.Name = "statesbindingNavigator";
            this.statesbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesbindingNavigator.Size = new System.Drawing.Size(1122, 25);
            this.statesbindingNavigator.TabIndex = 14;
            this.statesbindingNavigator.Text = "bindingNavigator1";
            this.statesbindingNavigator.RefreshItems += new System.EventHandler(this.statesbindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.buttonFlagDesShow);
            this.groupBox3.Controls.Add(this.listBoxStatesTwo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.buttonColorsAsc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.buttonStateCaptiolAsc);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(762, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 235);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort";
            // 
            // buttonFlagDesShow
            // 
            this.buttonFlagDesShow.BackColor = System.Drawing.Color.Red;
            this.buttonFlagDesShow.Location = new System.Drawing.Point(136, 153);
            this.buttonFlagDesShow.Name = "buttonFlagDesShow";
            this.buttonFlagDesShow.Size = new System.Drawing.Size(90, 27);
            this.buttonFlagDesShow.TabIndex = 12;
            this.buttonFlagDesShow.Text = "Show";
            this.buttonFlagDesShow.UseVisualStyleBackColor = false;
            this.buttonFlagDesShow.Click += new System.EventHandler(this.buttonFlagDesShow_Click);
            // 
            // listBoxStatesTwo
            // 
            this.listBoxStatesTwo.DataSource = this.statesBindingSource;
            this.listBoxStatesTwo.DisplayMember = "State Name";
            this.listBoxStatesTwo.FormattingEnabled = true;
            this.listBoxStatesTwo.ItemHeight = 19;
            this.listBoxStatesTwo.Location = new System.Drawing.Point(103, 123);
            this.listBoxStatesTwo.Name = "listBoxStatesTwo";
            this.listBoxStatesTwo.Size = new System.Drawing.Size(151, 23);
            this.listBoxStatesTwo.TabIndex = 11;
            this.listBoxStatesTwo.ValueMember = "State Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "To read full text of flag description:";
            // 
            // buttonColorsAsc
            // 
            this.buttonColorsAsc.BackColor = System.Drawing.Color.Red;
            this.buttonColorsAsc.Location = new System.Drawing.Point(216, 61);
            this.buttonColorsAsc.Name = "buttonColorsAsc";
            this.buttonColorsAsc.Size = new System.Drawing.Size(90, 27);
            this.buttonColorsAsc.TabIndex = 10;
            this.buttonColorsAsc.Text = "Sort";
            this.buttonColorsAsc.UseVisualStyleBackColor = false;
            this.buttonColorsAsc.Click += new System.EventHandler(this.buttonColorsAsc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Colors Alphabetically:";
            // 
            // buttonStateCaptiolAsc
            // 
            this.buttonStateCaptiolAsc.BackColor = System.Drawing.Color.Red;
            this.buttonStateCaptiolAsc.Location = new System.Drawing.Point(216, 28);
            this.buttonStateCaptiolAsc.Name = "buttonStateCaptiolAsc";
            this.buttonStateCaptiolAsc.Size = new System.Drawing.Size(90, 27);
            this.buttonStateCaptiolAsc.TabIndex = 9;
            this.buttonStateCaptiolAsc.Text = "Sort";
            this.buttonStateCaptiolAsc.UseVisualStyleBackColor = false;
            this.buttonStateCaptiolAsc.Click += new System.EventHandler(this.buttonStateCaptiolAsc_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "State Capitols Alpha.:";
            // 
            // FormStates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1122, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statesbindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.statesGridView);
            this.Font = new System.Drawing.Font("Complex_IV25", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "States";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesbindingNavigator)).EndInit();
            this.statesbindingNavigator.ResumeLayout(false);
            this.statesbindingNavigator.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statesGridView;
        private System.Windows.Forms.BindingSource statesDBDataSetBindingSource;
        private StatesDBDataSet statesDBDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StatesDBDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationinMillionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateFlagDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateFlowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateBirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn threeLargestCitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCapitolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medianIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentageOfComputerRelatedJobsDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBirdsAlpha;
        private System.Windows.Forms.Button buttonFlowersAlpha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStatesAlpha;
        private System.Windows.Forms.Button buttonPopAsc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonMedIncomeAsc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonJobsAsc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxStates;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.BindingNavigator statesbindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button buttonStateSort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonColorsAsc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonStateCaptiolAsc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxStatesTwo;
        private System.Windows.Forms.Button buttonFlagDesShow;
    }
}

