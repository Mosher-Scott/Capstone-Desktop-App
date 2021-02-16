
namespace Exercise_Tracker.Forms
{
    partial class ExerciseManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseManagement));
            this.comboBoxExercises = new System.Windows.Forms.ComboBox();
            this.labelExercises = new System.Windows.Forms.Label();
            this.dataGridViewExercises = new System.Windows.Forms.DataGridView();
            this.buttonDeleteExercise = new System.Windows.Forms.Button();
            this.buttonEditExercise = new System.Windows.Forms.Button();
            this.labelCategories = new System.Windows.Forms.Label();
            this.textBoxInstructionInput = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelExerciseName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonSaveEdits = new System.Windows.Forms.Button();
            this.comboBoxMuscleGroups = new System.Windows.Forms.ComboBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxExercises
            // 
            this.comboBoxExercises.FormattingEnabled = true;
            this.comboBoxExercises.Location = new System.Drawing.Point(8, 44);
            this.comboBoxExercises.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxExercises.Name = "comboBoxExercises";
            this.comboBoxExercises.Size = new System.Drawing.Size(218, 21);
            this.comboBoxExercises.TabIndex = 3;
            this.comboBoxExercises.SelectedIndexChanged += new System.EventHandler(this.ExerciseDropdown_Changed);
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Location = new System.Drawing.Point(8, 29);
            this.labelExercises.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(52, 13);
            this.labelExercises.TabIndex = 4;
            this.labelExercises.Text = "Exercises";
            // 
            // dataGridViewExercises
            // 
            this.dataGridViewExercises.AllowUserToAddRows = false;
            this.dataGridViewExercises.AllowUserToDeleteRows = false;
            this.dataGridViewExercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExercises.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercises.Location = new System.Drawing.Point(8, 72);
            this.dataGridViewExercises.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewExercises.Name = "dataGridViewExercises";
            this.dataGridViewExercises.ReadOnly = true;
            this.dataGridViewExercises.RowHeadersWidth = 102;
            this.dataGridViewExercises.RowTemplate.Height = 40;
            this.dataGridViewExercises.Size = new System.Drawing.Size(1140, 234);
            this.dataGridViewExercises.TabIndex = 5;
            // 
            // buttonDeleteExercise
            // 
            this.buttonDeleteExercise.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDeleteExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteExercise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteExercise.Location = new System.Drawing.Point(104, 316);
            this.buttonDeleteExercise.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDeleteExercise.Name = "buttonDeleteExercise";
            this.buttonDeleteExercise.Size = new System.Drawing.Size(96, 32);
            this.buttonDeleteExercise.TabIndex = 16;
            this.buttonDeleteExercise.Text = "Delete Exercise";
            this.buttonDeleteExercise.UseVisualStyleBackColor = false;
            // 
            // buttonEditExercise
            // 
            this.buttonEditExercise.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditExercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditExercise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditExercise.Location = new System.Drawing.Point(8, 316);
            this.buttonEditExercise.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEditExercise.Name = "buttonEditExercise";
            this.buttonEditExercise.Size = new System.Drawing.Size(83, 32);
            this.buttonEditExercise.TabIndex = 15;
            this.buttonEditExercise.Text = "Edit Exercise";
            this.buttonEditExercise.UseVisualStyleBackColor = false;
            this.buttonEditExercise.Click += new System.EventHandler(this.buttonEditExercise_Click);
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(15, 391);
            this.labelCategories.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(85, 13);
            this.labelCategories.TabIndex = 22;
            this.labelCategories.Text = "Muscle Group";
            // 
            // textBoxInstructionInput
            // 
            this.textBoxInstructionInput.Location = new System.Drawing.Point(104, 451);
            this.textBoxInstructionInput.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxInstructionInput.Multiline = true;
            this.textBoxInstructionInput.Name = "textBoxInstructionInput";
            this.textBoxInstructionInput.Size = new System.Drawing.Size(424, 155);
            this.textBoxInstructionInput.TabIndex = 20;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(27, 451);
            this.labelInstructions.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(73, 13);
            this.labelInstructions.TabIndex = 19;
            this.labelInstructions.Text = "Instructions";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(104, 356);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(203, 20);
            this.textBoxName.TabIndex = 18;
            // 
            // labelExerciseName
            // 
            this.labelExerciseName.AutoSize = true;
            this.labelExerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExerciseName.Location = new System.Drawing.Point(59, 359);
            this.labelExerciseName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelExerciseName.Name = "labelExerciseName";
            this.labelExerciseName.Size = new System.Drawing.Size(39, 13);
            this.labelExerciseName.TabIndex = 17;
            this.labelExerciseName.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1247, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNew.Location = new System.Drawing.Point(241, 33);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(62, 32);
            this.buttonAddNew.TabIndex = 25;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonSaveEdits
            // 
            this.buttonSaveEdits.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSaveEdits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSaveEdits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveEdits.Location = new System.Drawing.Point(104, 617);
            this.buttonSaveEdits.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSaveEdits.Name = "buttonSaveEdits";
            this.buttonSaveEdits.Size = new System.Drawing.Size(87, 32);
            this.buttonSaveEdits.TabIndex = 26;
            this.buttonSaveEdits.Text = "Save Changes";
            this.buttonSaveEdits.UseVisualStyleBackColor = false;
            this.buttonSaveEdits.Click += new System.EventHandler(this.buttonSaveEdits_Click);
            // 
            // comboBoxMuscleGroups
            // 
            this.comboBoxMuscleGroups.FormattingEnabled = true;
            this.comboBoxMuscleGroups.Location = new System.Drawing.Point(104, 388);
            this.comboBoxMuscleGroups.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxMuscleGroups.Name = "comboBoxMuscleGroups";
            this.comboBoxMuscleGroups.Size = new System.Drawing.Size(203, 21);
            this.comboBoxMuscleGroups.TabIndex = 27;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(56, 423);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(62, 17);
            this.checkBoxActive.TabIndex = 28;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // ExerciseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1247, 649);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.comboBoxMuscleGroups);
            this.Controls.Add(this.buttonSaveEdits);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.textBoxInstructionInput);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelExerciseName);
            this.Controls.Add(this.buttonDeleteExercise);
            this.Controls.Add(this.buttonEditExercise);
            this.Controls.Add(this.dataGridViewExercises);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.comboBoxExercises);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ExerciseManagement";
            this.Text = "Exercise Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxExercises;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.DataGridView dataGridViewExercises;
        private System.Windows.Forms.Button buttonDeleteExercise;
        private System.Windows.Forms.Button buttonEditExercise;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.TextBox textBoxInstructionInput;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelExerciseName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSaveEdits;
        private System.Windows.Forms.ComboBox comboBoxMuscleGroups;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxActive;
    }
}