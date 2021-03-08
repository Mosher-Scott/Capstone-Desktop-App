
namespace Exercise_Tracker.Forms
{
    partial class ModifyTrainingSession
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
            this.dataGridViewAssignedExercises = new System.Windows.Forms.DataGridView();
            this.buttonAddExercise = new System.Windows.Forms.Button();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAssignedExercises = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comboBoxExercises = new System.Windows.Forms.ComboBox();
            this.dataGridViewExerciseList = new System.Windows.Forms.DataGridView();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.textBoxTrainingSessionSets = new System.Windows.Forms.TextBox();
            this.labelTrainingSessionSets = new System.Windows.Forms.Label();
            this.textBoxTrainingSessionReps = new System.Windows.Forms.TextBox();
            this.labelTrainingSessionReps = new System.Windows.Forms.Label();
            this.labelExercises = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSessionName = new System.Windows.Forms.Label();
            this.labelSessionId = new System.Windows.Forms.Label();
            this.textBoxSessionId = new System.Windows.Forms.TextBox();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedExercises)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExerciseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssignedExercises
            // 
            this.dataGridViewAssignedExercises.AllowUserToAddRows = false;
            this.dataGridViewAssignedExercises.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAssignedExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedExercises.Location = new System.Drawing.Point(1216, 156);
            this.dataGridViewAssignedExercises.Name = "dataGridViewAssignedExercises";
            this.dataGridViewAssignedExercises.ReadOnly = true;
            this.dataGridViewAssignedExercises.RowHeadersWidth = 102;
            this.dataGridViewAssignedExercises.RowTemplate.Height = 40;
            this.dataGridViewAssignedExercises.Size = new System.Drawing.Size(1845, 593);
            this.dataGridViewAssignedExercises.TabIndex = 47;
            // 
            // buttonAddExercise
            // 
            this.buttonAddExercise.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddExercise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddExercise.Location = new System.Drawing.Point(773, 773);
            this.buttonAddExercise.Name = "buttonAddExercise";
            this.buttonAddExercise.Size = new System.Drawing.Size(231, 90);
            this.buttonAddExercise.TabIndex = 7;
            this.buttonAddExercise.Text = "Add Exercise";
            this.buttonAddExercise.UseVisualStyleBackColor = false;
            this.buttonAddExercise.Click += new System.EventHandler(this.buttonAddExercise_Click);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(192, 45);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // labelAssignedExercises
            // 
            this.labelAssignedExercises.AutoSize = true;
            this.labelAssignedExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignedExercises.Location = new System.Drawing.Point(1210, 107);
            this.labelAssignedExercises.Name = "labelAssignedExercises";
            this.labelAssignedExercises.Size = new System.Drawing.Size(281, 32);
            this.labelAssignedExercises.TabIndex = 46;
            this.labelAssignedExercises.Text = "Assigned Exercises";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(3291, 49);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comboBoxExercises
            // 
            this.comboBoxExercises.FormattingEnabled = true;
            this.comboBoxExercises.Location = new System.Drawing.Point(182, 787);
            this.comboBoxExercises.Name = "comboBoxExercises";
            this.comboBoxExercises.Size = new System.Drawing.Size(566, 39);
            this.comboBoxExercises.TabIndex = 6;
            this.comboBoxExercises.SelectedIndexChanged += new System.EventHandler(this.ExerciseDropdown_Changed);
            // 
            // dataGridViewExerciseList
            // 
            this.dataGridViewExerciseList.AllowUserToAddRows = false;
            this.dataGridViewExerciseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExerciseList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExerciseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExerciseList.Location = new System.Drawing.Point(15, 889);
            this.dataGridViewExerciseList.Name = "dataGridViewExerciseList";
            this.dataGridViewExerciseList.ReadOnly = true;
            this.dataGridViewExerciseList.RowHeadersWidth = 102;
            this.dataGridViewExerciseList.RowTemplate.Height = 40;
            this.dataGridViewExerciseList.Size = new System.Drawing.Size(3046, 218);
            this.dataGridViewExerciseList.TabIndex = 42;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActive.Checked = true;
            this.checkBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(94, 324);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(137, 36);
            this.checkBoxActive.TabIndex = 4;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // textBoxTrainingSessionSets
            // 
            this.textBoxTrainingSessionSets.Location = new System.Drawing.Point(202, 206);
            this.textBoxTrainingSessionSets.Name = "textBoxTrainingSessionSets";
            this.textBoxTrainingSessionSets.Size = new System.Drawing.Size(106, 38);
            this.textBoxTrainingSessionSets.TabIndex = 2;
            // 
            // labelTrainingSessionSets
            // 
            this.labelTrainingSessionSets.AutoSize = true;
            this.labelTrainingSessionSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainingSessionSets.Location = new System.Drawing.Point(107, 212);
            this.labelTrainingSessionSets.Name = "labelTrainingSessionSets";
            this.labelTrainingSessionSets.Size = new System.Drawing.Size(76, 32);
            this.labelTrainingSessionSets.TabIndex = 39;
            this.labelTrainingSessionSets.Text = "Sets";
            // 
            // textBoxTrainingSessionReps
            // 
            this.textBoxTrainingSessionReps.Location = new System.Drawing.Point(202, 268);
            this.textBoxTrainingSessionReps.Name = "textBoxTrainingSessionReps";
            this.textBoxTrainingSessionReps.Size = new System.Drawing.Size(106, 38);
            this.textBoxTrainingSessionReps.TabIndex = 3;
            // 
            // labelTrainingSessionReps
            // 
            this.labelTrainingSessionReps.AutoSize = true;
            this.labelTrainingSessionReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainingSessionReps.Location = new System.Drawing.Point(97, 271);
            this.labelTrainingSessionReps.Name = "labelTrainingSessionReps";
            this.labelTrainingSessionReps.Size = new System.Drawing.Size(85, 32);
            this.labelTrainingSessionReps.TabIndex = 37;
            this.labelTrainingSessionReps.Text = "Reps";
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExercises.Location = new System.Drawing.Point(10, 794);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(147, 32);
            this.labelExercises.TabIndex = 36;
            this.labelExercises.Text = "Exercises";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(239, 1143);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(374, 101);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel Without Saving";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(16, 1143);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(194, 101);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(192, 384);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(976, 365);
            this.textBoxDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(9, 384);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(169, 32);
            this.labelDescription.TabIndex = 32;
            this.labelDescription.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(202, 147);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(567, 38);
            this.textBoxName.TabIndex = 1;
            // 
            // labelSessionName
            // 
            this.labelSessionName.AutoSize = true;
            this.labelSessionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionName.Location = new System.Drawing.Point(88, 150);
            this.labelSessionName.Name = "labelSessionName";
            this.labelSessionName.Size = new System.Drawing.Size(94, 32);
            this.labelSessionName.TabIndex = 30;
            this.labelSessionName.Text = "Name";
            // 
            // labelSessionId
            // 
            this.labelSessionId.AutoSize = true;
            this.labelSessionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionId.Location = new System.Drawing.Point(134, 94);
            this.labelSessionId.Name = "labelSessionId";
            this.labelSessionId.Size = new System.Drawing.Size(44, 32);
            this.labelSessionId.TabIndex = 48;
            this.labelSessionId.Text = "ID";
            // 
            // textBoxSessionId
            // 
            this.textBoxSessionId.Enabled = false;
            this.textBoxSessionId.Location = new System.Drawing.Point(202, 90);
            this.textBoxSessionId.Name = "textBoxSessionId";
            this.textBoxSessionId.Size = new System.Drawing.Size(55, 38);
            this.textBoxSessionId.TabIndex = 0;
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteRow.Location = new System.Drawing.Point(1216, 777);
            this.buttonDeleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(373, 86);
            this.buttonDeleteRow.TabIndex = 8;
            this.buttonDeleteRow.Text = "Remove Selected Exercise";
            this.buttonDeleteRow.UseVisualStyleBackColor = false;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // ModifyTrainingSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(3291, 1553);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.textBoxSessionId);
            this.Controls.Add(this.labelSessionId);
            this.Controls.Add(this.dataGridViewAssignedExercises);
            this.Controls.Add(this.buttonAddExercise);
            this.Controls.Add(this.labelAssignedExercises);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxExercises);
            this.Controls.Add(this.dataGridViewExerciseList);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.textBoxTrainingSessionSets);
            this.Controls.Add(this.labelTrainingSessionSets);
            this.Controls.Add(this.textBoxTrainingSessionReps);
            this.Controls.Add(this.labelTrainingSessionReps);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSessionName);
            this.Name = "ModifyTrainingSession";
            this.Text = "Modify Training Session";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedExercises)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExerciseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAssignedExercises;
        private System.Windows.Forms.Button buttonAddExercise;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label labelAssignedExercises;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboBoxExercises;
        private System.Windows.Forms.DataGridView dataGridViewExerciseList;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.TextBox textBoxTrainingSessionSets;
        private System.Windows.Forms.Label labelTrainingSessionSets;
        private System.Windows.Forms.TextBox textBoxTrainingSessionReps;
        private System.Windows.Forms.Label labelTrainingSessionReps;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSessionName;
        private System.Windows.Forms.Label labelSessionId;
        private System.Windows.Forms.TextBox textBoxSessionId;
        private System.Windows.Forms.Button buttonDeleteRow;
    }
}