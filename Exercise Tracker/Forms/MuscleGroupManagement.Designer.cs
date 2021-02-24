
namespace Exercise_Tracker.Forms
{
    partial class MuscleGroupManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuscleGroupManagement));
            this.dataGridViewMuscleGroups = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelNewName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxAddNew = new System.Windows.Forms.GroupBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditName = new System.Windows.Forms.TextBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuscleGroups)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxAddNew.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMuscleGroups
            // 
            this.dataGridViewMuscleGroups.AllowUserToAddRows = false;
            this.dataGridViewMuscleGroups.AllowUserToDeleteRows = false;
            this.dataGridViewMuscleGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMuscleGroups.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMuscleGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMuscleGroups.Location = new System.Drawing.Point(43, 147);
            this.dataGridViewMuscleGroups.Name = "dataGridViewMuscleGroups";
            this.dataGridViewMuscleGroups.ReadOnly = true;
            this.dataGridViewMuscleGroups.RowHeadersWidth = 102;
            this.dataGridViewMuscleGroups.RowTemplate.Height = 40;
            this.dataGridViewMuscleGroups.Size = new System.Drawing.Size(1069, 483);
            this.dataGridViewMuscleGroups.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(2153, 55);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(192, 45);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupName.Location = new System.Drawing.Point(37, 99);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(218, 32);
            this.labelGroupName.TabIndex = 41;
            this.labelGroupName.Text = "Muscle Groups";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNew.Location = new System.Drawing.Point(15, 156);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(231, 90);
            this.buttonAddNew.TabIndex = 46;
            this.buttonAddNew.Text = "Add";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(43, 656);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(231, 90);
            this.buttonEdit.TabIndex = 47;
            this.buttonEdit.Text = "Edit Selected";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewName.Location = new System.Drawing.Point(9, 59);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(103, 32);
            this.labelNewName.TabIndex = 49;
            this.labelNewName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(531, 38);
            this.textBoxName.TabIndex = 50;
            // 
            // groupBoxAddNew
            // 
            this.groupBoxAddNew.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxAddNew.Controls.Add(this.labelNewName);
            this.groupBoxAddNew.Controls.Add(this.textBoxName);
            this.groupBoxAddNew.Controls.Add(this.buttonAddNew);
            this.groupBoxAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddNew.Location = new System.Drawing.Point(43, 781);
            this.groupBoxAddNew.Name = "groupBoxAddNew";
            this.groupBoxAddNew.Size = new System.Drawing.Size(700, 286);
            this.groupBoxAddNew.TabIndex = 51;
            this.groupBoxAddNew.TabStop = false;
            this.groupBoxAddNew.Text = "New Muscle Group";
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxEdit.Controls.Add(this.labelId);
            this.groupBoxEdit.Controls.Add(this.textBoxId);
            this.groupBoxEdit.Controls.Add(this.label1);
            this.groupBoxEdit.Controls.Add(this.textBoxEditName);
            this.groupBoxEdit.Controls.Add(this.buttonSaveChanges);
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEdit.Location = new System.Drawing.Point(790, 781);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(700, 341);
            this.groupBoxEdit.TabIndex = 52;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit Muscle Group";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(9, 58);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 32);
            this.labelId.TabIndex = 51;
            this.labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(15, 96);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(72, 38);
            this.textBoxId.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "Name:";
            // 
            // textBoxEditName
            // 
            this.textBoxEditName.Location = new System.Drawing.Point(15, 180);
            this.textBoxEditName.Name = "textBoxEditName";
            this.textBoxEditName.Size = new System.Drawing.Size(531, 38);
            this.textBoxEditName.TabIndex = 50;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(15, 236);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(231, 90);
            this.buttonSaveChanges.TabIndex = 46;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // MuscleGroupManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(2153, 1255);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxAddNew);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewMuscleGroups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MuscleGroupManagement";
            this.Text = "Muscle Group Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMuscleGroups)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxAddNew.ResumeLayout(false);
            this.groupBoxAddNew.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMuscleGroups;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxAddNew;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEditName;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
    }
}