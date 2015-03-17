namespace Republic.Employee.Forms
{
  partial class EmployeeManagerForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagerForm));
      this.ttForm = new System.Windows.Forms.ToolTip(this.components);
      this.tsForm = new System.Windows.Forms.ToolStrip();
      this.tsbFilter = new System.Windows.Forms.ToolStripButton();
      this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbAdd = new System.Windows.Forms.ToolStripButton();
      this.tsbEdit = new System.Windows.Forms.ToolStripButton();
      this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsbDelete = new System.Windows.Forms.ToolStripButton();
      this.gbFilter = new System.Windows.Forms.GroupBox();
      this.rbFilterAll = new System.Windows.Forms.RadioButton();
      this.rbFilterUserName = new System.Windows.Forms.RadioButton();
      this.rbFilterFullName = new System.Windows.Forms.RadioButton();
      this.rbFilterLastName = new System.Windows.Forms.RadioButton();
      this.rbFilterFirstName = new System.Windows.Forms.RadioButton();
      this.gbContent = new System.Windows.Forms.GroupBox();
      this.dgvEmployees = new System.Windows.Forms.DataGridView();
      this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.isActiveIndicatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.bsEmployeesInfo = new System.Windows.Forms.BindingSource(this.components);
      this.lbFilterBy = new System.Windows.Forms.Label();
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.tsbAdsiUpdate = new System.Windows.Forms.ToolStripButton();
      this.tsForm.SuspendLayout();
      this.gbFilter.SuspendLayout();
      this.gbContent.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsEmployeesInfo)).BeginInit();
      this.SuspendLayout();
      // 
      // tsForm
      // 
      this.tsForm.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.tsForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFilter,
            this.tsSeparator1,
            this.tsbAdd,
            this.tsbEdit,
            this.tsSeparator2,
            this.tsbDelete,
            this.tsbAdsiUpdate});
      this.tsForm.Location = new System.Drawing.Point(0, 0);
      this.tsForm.Name = "tsForm";
      this.tsForm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.tsForm.Size = new System.Drawing.Size(678, 25);
      this.tsForm.TabIndex = 46;
      this.tsForm.Text = "toolStrip1";
      // 
      // tsbFilter
      // 
      this.tsbFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbFilter.Image = global::Republic.Employee.Properties.Resources.search_16;
      this.tsbFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbFilter.Name = "tsbFilter";
      this.tsbFilter.Size = new System.Drawing.Size(23, 22);
      this.tsbFilter.Text = "toolStripButton1";
      this.tsbFilter.ToolTipText = "Filter";
      this.tsbFilter.Click += new System.EventHandler(this.tsbFilter_Click);
      // 
      // tsSeparator1
      // 
      this.tsSeparator1.Name = "tsSeparator1";
      this.tsSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // tsbAdd
      // 
      this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbAdd.Image = global::Republic.Employee.Properties.Resources.new_16;
      this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbAdd.Name = "tsbAdd";
      this.tsbAdd.Size = new System.Drawing.Size(23, 22);
      this.tsbAdd.Text = "toolStripButton2";
      this.tsbAdd.ToolTipText = "Add";
      this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
      // 
      // tsbEdit
      // 
      this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbEdit.Image = global::Republic.Employee.Properties.Resources.edit_16;
      this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbEdit.Name = "tsbEdit";
      this.tsbEdit.Size = new System.Drawing.Size(23, 22);
      this.tsbEdit.Text = "toolStripButton3";
      this.tsbEdit.ToolTipText = "Edit";
      this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
      // 
      // tsSeparator2
      // 
      this.tsSeparator2.Name = "tsSeparator2";
      this.tsSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // tsbDelete
      // 
      this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsbDelete.Image = global::Republic.Employee.Properties.Resources.delete_16;
      this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbDelete.Name = "tsbDelete";
      this.tsbDelete.Size = new System.Drawing.Size(23, 22);
      this.tsbDelete.Text = "toolStripButton5";
      this.tsbDelete.ToolTipText = "Delete";
      this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
      // 
      // gbFilter
      // 
      this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.gbFilter.Controls.Add(this.rbFilterAll);
      this.gbFilter.Controls.Add(this.rbFilterUserName);
      this.gbFilter.Controls.Add(this.rbFilterFullName);
      this.gbFilter.Controls.Add(this.rbFilterLastName);
      this.gbFilter.Controls.Add(this.rbFilterFirstName);
      this.gbFilter.Location = new System.Drawing.Point(197, 34);
      this.gbFilter.Name = "gbFilter";
      this.gbFilter.Size = new System.Drawing.Size(284, 33);
      this.gbFilter.TabIndex = 45;
      this.gbFilter.TabStop = false;
      // 
      // rbFilterAll
      // 
      this.rbFilterAll.AutoSize = true;
      this.rbFilterAll.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.rbFilterAll.Location = new System.Drawing.Point(4, 11);
      this.rbFilterAll.Name = "rbFilterAll";
      this.rbFilterAll.Size = new System.Drawing.Size(36, 17);
      this.rbFilterAll.TabIndex = 27;
      this.rbFilterAll.Text = "All";
      this.rbFilterAll.UseVisualStyleBackColor = true;
      this.rbFilterAll.CheckedChanged += new System.EventHandler(this.rb_CheckChanged);
      // 
      // rbFilterUserName
      // 
      this.rbFilterUserName.AutoSize = true;
      this.rbFilterUserName.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.rbFilterUserName.Location = new System.Drawing.Point(197, 11);
      this.rbFilterUserName.Name = "rbFilterUserName";
      this.rbFilterUserName.Size = new System.Drawing.Size(74, 17);
      this.rbFilterUserName.TabIndex = 26;
      this.rbFilterUserName.Text = "UserName";
      this.rbFilterUserName.UseVisualStyleBackColor = true;
      this.rbFilterUserName.CheckedChanged += new System.EventHandler(this.rb_CheckChanged);
      // 
      // rbFilterFullName
      // 
      this.rbFilterFullName.AutoSize = true;
      this.rbFilterFullName.Checked = true;
      this.rbFilterFullName.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.rbFilterFullName.Location = new System.Drawing.Point(99, 11);
      this.rbFilterFullName.Name = "rbFilterFullName";
      this.rbFilterFullName.Size = new System.Drawing.Size(41, 17);
      this.rbFilterFullName.TabIndex = 25;
      this.rbFilterFullName.TabStop = true;
      this.rbFilterFullName.Text = "Full";
      this.rbFilterFullName.UseVisualStyleBackColor = true;
      this.rbFilterFullName.CheckedChanged += new System.EventHandler(this.rb_CheckChanged);
      // 
      // rbFilterLastName
      // 
      this.rbFilterLastName.AutoSize = true;
      this.rbFilterLastName.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.rbFilterLastName.Location = new System.Drawing.Point(146, 11);
      this.rbFilterLastName.Name = "rbFilterLastName";
      this.rbFilterLastName.Size = new System.Drawing.Size(45, 17);
      this.rbFilterLastName.TabIndex = 24;
      this.rbFilterLastName.Text = "Last";
      this.rbFilterLastName.UseVisualStyleBackColor = true;
      this.rbFilterLastName.CheckedChanged += new System.EventHandler(this.rb_CheckChanged);
      // 
      // rbFilterFirstName
      // 
      this.rbFilterFirstName.AutoSize = true;
      this.rbFilterFirstName.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.rbFilterFirstName.Location = new System.Drawing.Point(47, 11);
      this.rbFilterFirstName.Name = "rbFilterFirstName";
      this.rbFilterFirstName.Size = new System.Drawing.Size(46, 17);
      this.rbFilterFirstName.TabIndex = 23;
      this.rbFilterFirstName.Text = "First";
      this.rbFilterFirstName.UseVisualStyleBackColor = true;
      this.rbFilterFirstName.CheckedChanged += new System.EventHandler(this.rb_CheckChanged);
      // 
      // gbContent
      // 
      this.gbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.gbContent.Controls.Add(this.dgvEmployees);
      this.gbContent.Location = new System.Drawing.Point(12, 68);
      this.gbContent.Name = "gbContent";
      this.gbContent.Size = new System.Drawing.Size(654, 229);
      this.gbContent.TabIndex = 42;
      this.gbContent.TabStop = false;
      this.gbContent.Text = "   Employees ...   ";
      // 
      // dgvEmployees
      // 
      this.dgvEmployees.AllowUserToAddRows = false;
      this.dgvEmployees.AllowUserToDeleteRows = false;
      this.dgvEmployees.AllowUserToOrderColumns = true;
      this.dgvEmployees.AllowUserToResizeRows = false;
      this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvEmployees.AutoGenerateColumns = false;
      this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgvEmployees.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.UserName,
            this.isActiveIndicatorDataGridViewTextBoxColumn});
      this.dgvEmployees.DataSource = this.bsEmployeesInfo;
      this.dgvEmployees.Location = new System.Drawing.Point(9, 19);
      this.dgvEmployees.MultiSelect = false;
      this.dgvEmployees.Name = "dgvEmployees";
      this.dgvEmployees.ReadOnly = true;
      this.dgvEmployees.RowHeadersVisible = false;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dgvEmployees.RowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvEmployees.RowTemplate.Height = 18;
      this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvEmployees.Size = new System.Drawing.Size(636, 201);
      this.dgvEmployees.TabIndex = 3;
      this.dgvEmployees.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvEmployees_MouseDoubleClick);
      // 
      // employeeIdDataGridViewTextBoxColumn
      // 
      this.employeeIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
      this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
      this.employeeIdDataGridViewTextBoxColumn.MinimumWidth = 2;
      this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
      this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
      this.employeeIdDataGridViewTextBoxColumn.Width = 2;
      // 
      // firstNameDataGridViewTextBoxColumn
      // 
      this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
      this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.firstNameDataGridViewTextBoxColumn.Width = 79;
      // 
      // lastNameDataGridViewTextBoxColumn
      // 
      this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
      this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
      this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.lastNameDataGridViewTextBoxColumn.Width = 80;
      // 
      // fullNameDataGridViewTextBoxColumn
      // 
      this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
      this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
      this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
      this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // UserName
      // 
      this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.UserName.DataPropertyName = "UserName";
      this.UserName.HeaderText = "UserName";
      this.UserName.MinimumWidth = 100;
      this.UserName.Name = "UserName";
      this.UserName.ReadOnly = true;
      // 
      // isActiveIndicatorDataGridViewTextBoxColumn
      // 
      this.isActiveIndicatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.isActiveIndicatorDataGridViewTextBoxColumn.DataPropertyName = "IsActiveIndicator";
      this.isActiveIndicatorDataGridViewTextBoxColumn.HeaderText = "Active";
      this.isActiveIndicatorDataGridViewTextBoxColumn.Name = "isActiveIndicatorDataGridViewTextBoxColumn";
      this.isActiveIndicatorDataGridViewTextBoxColumn.ReadOnly = true;
      this.isActiveIndicatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.isActiveIndicatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.isActiveIndicatorDataGridViewTextBoxColumn.Width = 62;
      // 
      // bsEmployeesInfo
      // 
      this.bsEmployeesInfo.DataMember = "Collection";
      this.bsEmployeesInfo.DataSource = typeof(Republic.Employee.Business.EmployeesInfo);
      // 
      // lbFilterBy
      // 
      this.lbFilterBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lbFilterBy.AutoSize = true;
      this.lbFilterBy.Location = new System.Drawing.Point(144, 47);
      this.lbFilterBy.Name = "lbFilterBy";
      this.lbFilterBy.Size = new System.Drawing.Size(47, 13);
      this.lbFilterBy.TabIndex = 44;
      this.lbFilterBy.Text = "Filter By:";
      // 
      // tbFilter
      // 
      this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.tbFilter.BackColor = System.Drawing.Color.White;
      this.tbFilter.Font = new System.Drawing.Font("Tahoma", 8.25F);
      this.tbFilter.Location = new System.Drawing.Point(487, 43);
      this.tbFilter.Name = "tbFilter";
      this.tbFilter.Size = new System.Drawing.Size(170, 21);
      this.tbFilter.TabIndex = 43;
      this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
      // 
      // tsbAdsiUpdate
      // 
      this.tsbAdsiUpdate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.tsbAdsiUpdate.Image = global::Republic.Employee.Properties.Resources.Execute_16;
      this.tsbAdsiUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsbAdsiUpdate.Name = "tsbAdsiUpdate";
      this.tsbAdsiUpdate.Size = new System.Drawing.Size(106, 22);
      this.tsbAdsiUpdate.Text = "Adsi Update ... ";
      this.tsbAdsiUpdate.Click += new System.EventHandler(this.tsbAdsiUpdate_Click);
      // 
      // EmployeeManagerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(678, 309);
      this.Controls.Add(this.tsForm);
      this.Controls.Add(this.gbFilter);
      this.Controls.Add(this.gbContent);
      this.Controls.Add(this.lbFilterBy);
      this.Controls.Add(this.tbFilter);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EmployeeManagerForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "   Employee Manager ...";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingProcess);
      this.tsForm.ResumeLayout(false);
      this.tsForm.PerformLayout();
      this.gbFilter.ResumeLayout(false);
      this.gbFilter.PerformLayout();
      this.gbContent.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsEmployeesInfo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolTip ttForm;
    private System.Windows.Forms.ToolStrip tsForm;
    private System.Windows.Forms.ToolStripButton tsbFilter;
    private System.Windows.Forms.ToolStripSeparator tsSeparator1;
    private System.Windows.Forms.ToolStripButton tsbAdd;
    private System.Windows.Forms.ToolStripButton tsbEdit;
    private System.Windows.Forms.ToolStripSeparator tsSeparator2;
    private System.Windows.Forms.ToolStripButton tsbDelete;
    private System.Windows.Forms.GroupBox gbFilter;
    private System.Windows.Forms.RadioButton rbFilterFirstName;
    private System.Windows.Forms.GroupBox gbContent;
    private System.Windows.Forms.DataGridView dgvEmployees;
    private System.Windows.Forms.Label lbFilterBy;
    private System.Windows.Forms.TextBox tbFilter;
    private System.Windows.Forms.RadioButton rbFilterUserName;
    private System.Windows.Forms.RadioButton rbFilterFullName;
    private System.Windows.Forms.RadioButton rbFilterLastName;
    private System.Windows.Forms.BindingSource bsEmployeesInfo;
    private System.Windows.Forms.RadioButton rbFilterAll;
    private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveIndicatorDataGridViewTextBoxColumn;
    private System.Windows.Forms.ToolStripButton tsbAdsiUpdate;


  }
}