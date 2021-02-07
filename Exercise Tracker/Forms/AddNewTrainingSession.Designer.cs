
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
            this.labelExercises = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxInstructionInput = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSessionName = new System.Windows.Forms.Label();
            this.textBoxTrainingSessionSets = new System.Windows.Forms.TextBox();
            this.labelTrainingSessionSets = new System.Windows.Forms.Label();
            this.textBoxTrainingSessionReps = new System.Windows.Forms.TextBox();
            this.labelTrainingSessionReps = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridViewExerciseList = new System.Windows.Forms.DataGridView();
            this.comboBoxExercises = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExerciseList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExercises.Location = new System.Drawing.Point(1224, 87);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(147, 32);
            this.labelExercises.TabIndex = 15;
            this.labelExercises.Text = "Exercises";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(355, 915);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(227, 126);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel Without Saving";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(133, 928);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(183, 101);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxInstructionInput
            // 
            this.textBoxInstructionInput.Location = new System.Drawing.Point(207, 366);
            this.textBoxInstructionInput.Multiline = true;
            this.textBoxInstructionInput.Name = "textBoxInstructionInput";
            this.textBoxInstructionInput.Size = new System.Drawing.Size(919, 365);
            this.textBoxInstructionInput.TabIndex = 11;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(15, 366);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(169, 32);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(216, 115);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(534, 38);
            this.textBoxName.TabIndex = 9;
            // 
            // labelSessionName
            // 
            this.labelSessionName.AutoSize = true;
            this.labelSessionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionName.Location = new System.Drawing.Point(105, 118);
            this.labelSessionName.Name = "labelSessionName";
            this.labelSessionName.Size = new System.Drawing.Size(94, 32);
            this.labelSessionName.TabIndex = 8;
            this.labelSessionName.Text = "Name";
            // 
            // textBoxTrainingSessionSets
            // 
            this.textBoxTrainingSessionSets.Location = new System.Drawing.Point(216, 188);
            this.textBoxTrainingSessionSets.Name = "textBoxTrainingSessionSets";
            this.textBoxTrainingSessionSets.Size = new System.Drawing.Size(100, 38);
            this.textBoxTrainingSessionSets.TabIndex = 19;
            // 
            // labelTrainingSessionSets
            // 
            this.labelTrainingSessionSets.AutoSize = true;
            this.labelTrainingSessionSets.Location = new System.Drawing.Point(127, 194);
            this.labelTrainingSessionSets.Name = "labelTrainingSessionSets";
            this.labelTrainingSessionSets.Size = new System.Drawing.Size(72, 32);
            this.labelTrainingSessionSets.TabIndex = 18;
            this.labelTrainingSessionSets.Text = "Sets";
            // 
            // textBoxTrainingSessionReps
            // 
            this.textBoxTrainingSessionReps.Location = new System.Drawing.Point(216, 250);
            this.textBoxTrainingSessionReps.Name = "textBoxTrainingSessionReps";
            this.textBoxTrainingSessionReps.Size = new System.Drawing.Size(100, 38);
            this.textBoxTrainingSessionReps.TabIndex = 17;
            // 
            // labelTrainingSessionReps
            // 
            this.labelTrainingSessionReps.AutoSize = true;
            this.labelTrainingSessionReps.Location = new System.Drawing.Point(118, 253);
            this.labelTrainingSessionReps.Name = "labelTrainingSessionReps";
            this.labelTrainingSessionReps.Size = new System.Drawing.Size(81, 32);
            this.labelTrainingSessionReps.TabIndex = 16;
            this.labelTrainingSessionReps.Text = "Reps";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(115, 306);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 36);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExerciseList
            // 
            this.dataGridViewExerciseList.AllowUserToAddRows = false;
            this.dataGridViewExerciseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExerciseList.Location = new System.Drawing.Point(1239, 194);
            this.dataGridViewExerciseList.Name = "dataGridViewExerciseList";
            this.dataGridViewExerciseList.ReadOnly = true;
            this.dataGridViewExerciseList.RowHeadersWidth = 102;
            this.dataGridViewExerciseList.RowTemplate.Height = 40;
            this.dataGridViewExerciseList.Size = new System.Drawing.Size(1153, 496);
            this.dataGridViewExerciseList.TabIndex = 23;
            // 
            // comboBoxExercises
            // 
            this.comboBoxExercises.FormattingEnabled = true;
            this.comboBoxExercises.Location = new System.Drawing.Point(1386, 80);
            this.comboBoxExercises.Name = "comboBoxExercises";
            this.comboBoxExercises.Size = new System.Drawing.Size(533, 39);
            this.comboBoxExercises.TabIndex = 24;
            // 
            // AddNewTrainingSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2447, 1065);
            this.Controls.Add(this.comboBoxExercises);
            this.Controls.Add(this.dataGridViewExerciseList);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxTrainingSessionSets);
            this.Controls.Add(this.labelTrainingSessionSets);
            this.Controls.Add(this.textBoxTrainingSessionReps);
            this.Controls.Add(this.labelTrainingSessionReps);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxInstructionInput);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSessionName);
            this.Name = "AddNewTrainingSession";
            this.Text = "AddNewTrainingSession";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExerciseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxInstructionInput;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSessionName;
        private System.Windows.Forms.TextBox textBoxTrainingSessionSets;
        private System.Windows.Forms.Label labelTrainingSessionSets;
        private System.Windows.Forms.TextBox textBoxTrainingSessionReps;
        private System.Windows.Forms.Label labelTrainingSessionReps;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridViewExerciseList;
        private System.Windows.Forms.ComboBox comboBoxExercises;
    }
}