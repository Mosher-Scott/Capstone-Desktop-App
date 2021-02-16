
namespace Exercise_Tracker.Forms
{
    partial class FormStartingMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartingMenu));
            this.buttonViewClients = new System.Windows.Forms.Button();
            this.buttonExerciseManagement = new System.Windows.Forms.Button();
            this.buttonSessionManagement = new System.Windows.Forms.Button();
            this.buttonClientManagement = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonViewClients
            // 
            this.buttonViewClients.Location = new System.Drawing.Point(915, 491);
            this.buttonViewClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewClients.Name = "buttonViewClients";
            this.buttonViewClients.Size = new System.Drawing.Size(144, 72);
            this.buttonViewClients.TabIndex = 0;
            this.buttonViewClients.Text = "View Client Workouts";
            this.buttonViewClients.UseVisualStyleBackColor = true;
            this.buttonViewClients.Visible = false;
            this.buttonViewClients.Click += new System.EventHandler(this.buttonViewClients_Click);
            // 
            // buttonExerciseManagement
            // 
            this.buttonExerciseManagement.BackColor = System.Drawing.Color.LightGreen;
            this.buttonExerciseManagement.Enabled = false;
            this.buttonExerciseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExerciseManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExerciseManagement.Location = new System.Drawing.Point(56, 253);
            this.buttonExerciseManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExerciseManagement.Name = "buttonExerciseManagement";
            this.buttonExerciseManagement.Size = new System.Drawing.Size(213, 134);
            this.buttonExerciseManagement.TabIndex = 2;
            this.buttonExerciseManagement.Text = "Exercise Management";
            this.buttonExerciseManagement.UseVisualStyleBackColor = false;
            this.buttonExerciseManagement.Click += new System.EventHandler(this.buttonExerciseManagement_Click);
            // 
            // buttonSessionManagement
            // 
            this.buttonSessionManagement.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSessionManagement.Enabled = false;
            this.buttonSessionManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSessionManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSessionManagement.Location = new System.Drawing.Point(56, 415);
            this.buttonSessionManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSessionManagement.Name = "buttonSessionManagement";
            this.buttonSessionManagement.Size = new System.Drawing.Size(213, 134);
            this.buttonSessionManagement.TabIndex = 3;
            this.buttonSessionManagement.Text = "Training Session Management";
            this.buttonSessionManagement.UseVisualStyleBackColor = false;
            this.buttonSessionManagement.Click += new System.EventHandler(this.buttonSessionManagement_Click);
            // 
            // buttonClientManagement
            // 
            this.buttonClientManagement.BackColor = System.Drawing.Color.LightGreen;
            this.buttonClientManagement.Enabled = false;
            this.buttonClientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClientManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClientManagement.Location = new System.Drawing.Point(56, 91);
            this.buttonClientManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClientManagement.Name = "buttonClientManagement";
            this.buttonClientManagement.Size = new System.Drawing.Size(213, 134);
            this.buttonClientManagement.TabIndex = 4;
            this.buttonClientManagement.Text = "Client Management";
            this.buttonClientManagement.UseVisualStyleBackColor = false;
            this.buttonClientManagement.Click += new System.EventHandler(this.buttonClientManagement_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1259, 55);
            this.menuStrip1.TabIndex = 5;
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
            // FormStartingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1259, 694);
            this.Controls.Add(this.buttonClientManagement);
            this.Controls.Add(this.buttonSessionManagement);
            this.Controls.Add(this.buttonExerciseManagement);
            this.Controls.Add(this.buttonViewClients);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStartingMenu";
            this.Text = "Exercise Tracker Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewClients;
        private System.Windows.Forms.Button buttonExerciseManagement;
        private System.Windows.Forms.Button buttonSessionManagement;
        private System.Windows.Forms.Button buttonClientManagement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}