
namespace Exercise_Tracker.Forms
{
    partial class CreateNewExercise
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInstructionInput = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxMuscleGroups = new System.Windows.Forms.ComboBox();
            this.labelCategories = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMuscleGroup = new System.Windows.Forms.Label();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(52, 95);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(534, 38);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxInstructionInput
            // 
            this.textBoxInstructionInput.Location = new System.Drawing.Point(52, 386);
            this.textBoxInstructionInput.Multiline = true;
            this.textBoxInstructionInput.Name = "textBoxInstructionInput";
            this.textBoxInstructionInput.Size = new System.Drawing.Size(1124, 365);
            this.textBoxInstructionInput.TabIndex = 3;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(46, 351);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(172, 32);
            this.labelInstructions.TabIndex = 2;
            this.labelInstructions.Text = "Instructions";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(52, 783);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(183, 101);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(273, 783);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(183, 101);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxMuscleGroups
            // 
            this.comboBoxMuscleGroups.FormattingEnabled = true;
            this.comboBoxMuscleGroups.Location = new System.Drawing.Point(52, 210);
            this.comboBoxMuscleGroups.Name = "comboBoxMuscleGroups";
            this.comboBoxMuscleGroups.Size = new System.Drawing.Size(381, 39);
            this.comboBoxMuscleGroups.TabIndex = 6;
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(525, 163);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(0, 32);
            this.labelCategories.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(46, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 32);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelMuscleGroup
            // 
            this.labelMuscleGroup.AutoSize = true;
            this.labelMuscleGroup.Location = new System.Drawing.Point(46, 163);
            this.labelMuscleGroup.Name = "labelMuscleGroup";
            this.labelMuscleGroup.Size = new System.Drawing.Size(191, 32);
            this.labelMuscleGroup.TabIndex = 9;
            this.labelMuscleGroup.Text = "Muscle Group";
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActive.Checked = true;
            this.checkBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActive.Location = new System.Drawing.Point(52, 280);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(131, 36);
            this.checkBoxActive.TabIndex = 10;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // CreateNewExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 931);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.labelMuscleGroup);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCategories);
            this.Controls.Add(this.comboBoxMuscleGroups);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxInstructionInput);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.textBoxName);
            this.Name = "CreateNewExercise";
            this.Text = "Add New Workout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInstructionInput;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxMuscleGroups;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMuscleGroup;
        private System.Windows.Forms.CheckBox checkBoxActive;
    }
}