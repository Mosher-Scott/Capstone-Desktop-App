
namespace Exercise_Tracker.Forms
{
    partial class EditClientDetails
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
            this.buttonSaveEdits = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelClientFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.labelExerciseId = new System.Windows.Forms.Label();
            this.labelClientIdText = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveEdits
            // 
            this.buttonSaveEdits.Location = new System.Drawing.Point(20, 306);
            this.buttonSaveEdits.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSaveEdits.Name = "buttonSaveEdits";
            this.buttonSaveEdits.Size = new System.Drawing.Size(50, 31);
            this.buttonSaveEdits.TabIndex = 1;
            this.buttonSaveEdits.Text = "Save";
            this.buttonSaveEdits.UseVisualStyleBackColor = true;
            this.buttonSaveEdits.Click += new System.EventHandler(this.buttonSaveEdits_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(33, 237);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(47, 13);
            this.labelPhone.TabIndex = 27;
            this.labelPhone.Text = "Phone:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(39, 159);
            this.labelState.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(41, 13);
            this.labelState.TabIndex = 26;
            this.labelState.Text = "State:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(37, 211);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 13);
            this.labelEmail.TabIndex = 24;
            this.labelEmail.Text = "Email:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCode.Location = new System.Drawing.Point(25, 185);
            this.labelZipCode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(57, 13);
            this.labelZipCode.TabIndex = 23;
            this.labelZipCode.Text = "Zipcode:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(46, 133);
            this.labelCity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(32, 13);
            this.labelCity.TabIndex = 22;
            this.labelCity.Text = "City:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(24, 107);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 13);
            this.labelAddress.TabIndex = 21;
            this.labelAddress.Text = "Address:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(11, 81);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(71, 13);
            this.labelLastName.TabIndex = 20;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelClientFirstName
            // 
            this.labelClientFirstName.AutoSize = true;
            this.labelClientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientFirstName.Location = new System.Drawing.Point(10, 55);
            this.labelClientFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientFirstName.Name = "labelClientFirstName";
            this.labelClientFirstName.Size = new System.Drawing.Size(71, 13);
            this.labelClientFirstName.TabIndex = 19;
            this.labelClientFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(83, 55);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(180, 20);
            this.textBoxFirstName.TabIndex = 28;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(83, 81);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(180, 20);
            this.textBoxLastName.TabIndex = 29;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(83, 107);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(180, 20);
            this.textBoxAddress.TabIndex = 30;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(83, 133);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(180, 20);
            this.textBoxCity.TabIndex = 31;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(83, 159);
            this.textBoxState.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(180, 20);
            this.textBoxState.TabIndex = 32;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(83, 185);
            this.textBoxZipCode.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(180, 20);
            this.textBoxZipCode.TabIndex = 33;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(83, 211);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(180, 20);
            this.textBoxEmail.TabIndex = 34;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(83, 237);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(180, 20);
            this.textBoxPhone.TabIndex = 35;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxActive.Location = new System.Drawing.Point(35, 265);
            this.checkBoxActive.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(62, 17);
            this.checkBoxActive.TabIndex = 36;
            this.checkBoxActive.Text = "Active";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // labelExerciseId
            // 
            this.labelExerciseId.AutoSize = true;
            this.labelExerciseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExerciseId.Location = new System.Drawing.Point(22, 33);
            this.labelExerciseId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelExerciseId.Name = "labelExerciseId";
            this.labelExerciseId.Size = new System.Drawing.Size(76, 13);
            this.labelExerciseId.TabIndex = 37;
            this.labelExerciseId.Text = "Exercise ID:";
            // 
            // labelClientIdText
            // 
            this.labelClientIdText.AutoSize = true;
            this.labelClientIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientIdText.Location = new System.Drawing.Point(84, 33);
            this.labelClientIdText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientIdText.Name = "labelClientIdText";
            this.labelClientIdText.Size = new System.Drawing.Size(39, 13);
            this.labelClientIdText.TabIndex = 38;
            this.labelClientIdText.Text = "        ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(445, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // EditClientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(445, 398);
            this.Controls.Add(this.labelClientIdText);
            this.Controls.Add(this.labelExerciseId);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelClientFirstName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSaveEdits);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "EditClientDetails";
            this.Text = "Edit Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveEdits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelClientFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Label labelExerciseId;
        private System.Windows.Forms.Label labelClientIdText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
    }
}