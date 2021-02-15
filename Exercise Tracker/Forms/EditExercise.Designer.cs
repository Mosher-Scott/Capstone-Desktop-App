
namespace Exercise_Tracker.Forms
{
    partial class EditExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditExercise));
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.labelMuscleGroup = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.comboBoxMuscleGroups = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxInstructionInput = new System.Windows.Forms.TextBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActive.Checked = true;
            this.checkBoxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(18, 324);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(137, 36);
            this.checkBoxActive.TabIndex = 21;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // labelMuscleGroup
            // 
            this.labelMuscleGroup.AutoSize = true;
            this.labelMuscleGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuscleGroup.Location = new System.Drawing.Point(12, 207);
            this.labelMuscleGroup.Name = "labelMuscleGroup";
            this.labelMuscleGroup.Size = new System.Drawing.Size(203, 32);
            this.labelMuscleGroup.TabIndex = 20;
            this.labelMuscleGroup.Text = "Muscle Group";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 32);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Name";
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategories.Location = new System.Drawing.Point(491, 207);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(0, 32);
            this.labelCategories.TabIndex = 18;
            // 
            // comboBoxMuscleGroups
            // 
            this.comboBoxMuscleGroups.FormattingEnabled = true;
            this.comboBoxMuscleGroups.Location = new System.Drawing.Point(18, 254);
            this.comboBoxMuscleGroups.Name = "comboBoxMuscleGroups";
            this.comboBoxMuscleGroups.Size = new System.Drawing.Size(381, 39);
            this.comboBoxMuscleGroups.TabIndex = 17;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(239, 827);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(183, 101);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 827);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(183, 101);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxInstructionInput
            // 
            this.textBoxInstructionInput.Location = new System.Drawing.Point(18, 430);
            this.textBoxInstructionInput.Multiline = true;
            this.textBoxInstructionInput.Name = "textBoxInstructionInput";
            this.textBoxInstructionInput.Size = new System.Drawing.Size(1124, 365);
            this.textBoxInstructionInput.TabIndex = 14;
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(12, 395);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(172, 32);
            this.labelInstructions.TabIndex = 13;
            this.labelInstructions.Text = "Instructions";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(18, 139);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(534, 38);
            this.textBoxName.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1531, 49);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(192, 45);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            // 
            // Edit_Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1531, 1062);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Exercise";
            this.Text = "Edit Exercise";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label labelMuscleGroup;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.ComboBox comboBoxMuscleGroups;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxInstructionInput;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
    }
}