
namespace Exercise_Tracker.Forms
{
    partial class AddNewTrainingSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTrainingSession));
            this.labelExercises = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSessionName = new System.Windows.Forms.Label();
            this.textBoxTrainingSessionSets = new System.Windows.Forms.TextBox();
            this.labelTrainingSessionSets = new System.Windows.Forms.Label();
            this.textBoxTrainingSessionReps = new System.Windows.Forms.TextBox();
            this.labelTrainingSessionReps = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.dataGridViewExerciseList = new System.Windows.Forms.DataGridView();
            this.comboBoxExercises = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddExercise = new System.Windows.Forms.Button();
            this.labelAssignedExercises = new System.Windows.Forms.Label();
            this.dataGridViewAssignedExercises = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExerciseList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedExercises)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExercises.Location = new System.Drawing.Point(38, 776);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(147, 32);
            this.labelExercises.TabIndex = 15;
            this.labelExercises.Text = "Exercises";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(434, 1124);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(374, 101);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel Without Saving";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(211, 1124);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(194, 101);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(220, 366);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(976, 365);
            this.textBoxDescription.TabIndex = 11;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(37, 366);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(169, 32);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(230, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(567, 38);
            this.textBoxName.TabIndex = 9;
            // 
            // labelSessionName
            // 
            this.labelSessionName.AutoSize = true;
            this.labelSessionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionName.Location = new System.Drawing.Point(112, 118);
            this.labelSessionName.Name = "labelSessionName";
            this.labelSessionName.Size = new System.Drawing.Size(94, 32);
            this.labelSessionName.TabIndex = 8;
            this.labelSessionName.Text = "Name";
            // 
            // textBoxTrainingSessionSets
            // 
            this.textBoxTrainingSessionSets.Location = new System.Drawing.Point(230, 188);
            this.textBoxTrainingSessionSets.Name = "textBoxTrainingSessionSets";
            this.textBoxTrainingSessionSets.Size = new System.Drawing.Size(106, 38);
            this.textBoxTrainingSessionSets.TabIndex = 19;
            // 
            // labelTrainingSessionSets
            // 
            this.labelTrainingSessionSets.AutoSize = true;
            this.labelTrainingSessionSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainingSessionSets.Location = new System.Drawing.Point(135, 194);
            this.labelTrainingSessionSets.Name = "labelTrainingSessionSets";
            this.labelTrainingSessionSets.Size = new System.Drawing.Size(76, 32);
            this.labelTrainingSessionSets.TabIndex = 18;
            this.labelTrainingSessionSets.Text = "Sets";
            // 
            // textBoxTrainingSessionReps
            // 
            this.textBoxTrainingSessionReps.Location = new System.Drawing.Point(230, 250);
            this.textBoxTrainingSessionReps.Name = "textBoxTrainingSessionReps";
            this.textBoxTrainingSessionReps.Size = new System.Drawing.Size(106, 38);
            this.textBoxTrainingSessionReps.TabIndex = 17;
            // 
            // labelTrainingSessionReps
            // 
            this.labelTrainingSessionReps.AutoSize = true;
            this.labelTrainingSessionReps.Location = new System.Drawing.Point(125, 253);
            this.labelTrainingSessionReps.Name = "labelTrainingSessionReps";
            this.labelTrainingSessionReps.Size = new System.Drawing.Size(85, 32);
            this.labelTrainingSessionReps.TabIndex = 16;
            this.labelTrainingSessionReps.Text = "Reps";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActive.Checked = true;
            this.checkBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(122, 306);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(137, 36);
            this.checkBoxActive.TabIndex = 22;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExerciseList
            // 
            this.dataGridViewExerciseList.AllowUserToAddRows = false;
            this.dataGridViewExerciseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExerciseList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExerciseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExerciseList.Location = new System.Drawing.Point(210, 878);
            this.dataGridViewExerciseList.Name = "dataGridViewExerciseList";
            this.dataGridViewExerciseList.ReadOnly = true;
            this.dataGridViewExerciseList.RowHeadersWidth = 102;
            this.dataGridViewExerciseList.RowTemplate.Height = 40;
            this.dataGridViewExerciseList.Size = new System.Drawing.Size(3306, 218);
            this.dataGridViewExerciseList.TabIndex = 23;
            // 
            // comboBoxExercises
            // 
            this.comboBoxExercises.FormattingEnabled = true;
            this.comboBoxExercises.Location = new System.Drawing.Point(210, 769);
            this.comboBoxExercises.Name = "comboBoxExercises";
            this.comboBoxExercises.Size = new System.Drawing.Size(566, 39);
            this.comboBoxExercises.TabIndex = 24;
            this.comboBoxExercises.SelectedIndexChanged += new System.EventHandler(this.ExerciseDropdown_Changed);
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
            this.menuStrip1.Size = new System.Drawing.Size(3594, 60);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 56);
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
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(192, 56);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // buttonAddExercise
            // 
            this.buttonAddExercise.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddExercise.Location = new System.Drawing.Point(801, 755);
            this.buttonAddExercise.Name = "buttonAddExercise";
            this.buttonAddExercise.Size = new System.Drawing.Size(231, 90);
            this.buttonAddExercise.TabIndex = 27;
            this.buttonAddExercise.Text = "Add Exercise";
            this.buttonAddExercise.UseVisualStyleBackColor = false;
            this.buttonAddExercise.Click += new System.EventHandler(this.buttonAddExercise_Click);
            // 
            // labelAssignedExercises
            // 
            this.labelAssignedExercises.AutoSize = true;
            this.labelAssignedExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignedExercises.Location = new System.Drawing.Point(1322, 99);
            this.labelAssignedExercises.Name = "labelAssignedExercises";
            this.labelAssignedExercises.Size = new System.Drawing.Size(281, 32);
            this.labelAssignedExercises.TabIndex = 28;
            this.labelAssignedExercises.Text = "Assigned Exercises";
            // 
            // dataGridViewAssignedExercises
            // 
            this.dataGridViewAssignedExercises.AllowUserToAddRows = false;
            this.dataGridViewAssignedExercises.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAssignedExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedExercises.Location = new System.Drawing.Point(1328, 148);
            this.dataGridViewAssignedExercises.Name = "dataGridViewAssignedExercises";
            this.dataGridViewAssignedExercises.ReadOnly = true;
            this.dataGridViewAssignedExercises.RowHeadersWidth = 102;
            this.dataGridViewAssignedExercises.RowTemplate.Height = 40;
            this.dataGridViewAssignedExercises.Size = new System.Drawing.Size(999, 593);
            this.dataGridViewAssignedExercises.TabIndex = 29;
            // 
            // AddNewTrainingSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(3594, 1524);
            this.Controls.Add(this.dataGridViewAssignedExercises);
            this.Controls.Add(this.labelAssignedExercises);
            this.Controls.Add(this.buttonAddExercise);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(3626, 1612);
            this.Name = "AddNewTrainingSession";
            this.Text = "New Training Session";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExerciseList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedExercises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSessionName;
        private System.Windows.Forms.TextBox textBoxTrainingSessionSets;
        private System.Windows.Forms.Label labelTrainingSessionSets;
        private System.Windows.Forms.TextBox textBoxTrainingSessionReps;
        private System.Windows.Forms.Label labelTrainingSessionReps;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.DataGridView dataGridViewExerciseList;
        private System.Windows.Forms.ComboBox comboBoxExercises;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddExercise;
        private System.Windows.Forms.Label labelAssignedExercises;
        private System.Windows.Forms.DataGridView dataGridViewAssignedExercises;
    }
}