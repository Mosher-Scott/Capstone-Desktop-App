
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
            this.buttonViewClients = new System.Windows.Forms.Button();
            this.buttonExerciseManagement = new System.Windows.Forms.Button();
            this.buttonSessionManagement = new System.Windows.Forms.Button();
            this.buttonClientManagement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewClients
            // 
            this.buttonViewClients.Location = new System.Drawing.Point(915, 492);
            this.buttonViewClients.Name = "buttonViewClients";
            this.buttonViewClients.Size = new System.Drawing.Size(145, 71);
            this.buttonViewClients.TabIndex = 0;
            this.buttonViewClients.Text = "View Client Workouts";
            this.buttonViewClients.UseVisualStyleBackColor = true;
            this.buttonViewClients.Visible = false;
            this.buttonViewClients.Click += new System.EventHandler(this.buttonViewClients_Click);
            // 
            // buttonExerciseManagement
            // 
            this.buttonExerciseManagement.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonExerciseManagement.Enabled = false;
            this.buttonExerciseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExerciseManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExerciseManagement.Location = new System.Drawing.Point(71, 217);
            this.buttonExerciseManagement.Name = "buttonExerciseManagement";
            this.buttonExerciseManagement.Size = new System.Drawing.Size(212, 133);
            this.buttonExerciseManagement.TabIndex = 2;
            this.buttonExerciseManagement.Text = "Exercise Management";
            this.buttonExerciseManagement.UseVisualStyleBackColor = false;
            this.buttonExerciseManagement.Click += new System.EventHandler(this.buttonExerciseManagement_Click);
            // 
            // buttonSessionManagement
            // 
            this.buttonSessionManagement.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonSessionManagement.Enabled = false;
            this.buttonSessionManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSessionManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSessionManagement.Location = new System.Drawing.Point(71, 379);
            this.buttonSessionManagement.Name = "buttonSessionManagement";
            this.buttonSessionManagement.Size = new System.Drawing.Size(212, 133);
            this.buttonSessionManagement.TabIndex = 3;
            this.buttonSessionManagement.Text = "Training Session Management";
            this.buttonSessionManagement.UseVisualStyleBackColor = false;
            this.buttonSessionManagement.Click += new System.EventHandler(this.buttonSessionManagement_Click);
            // 
            // buttonClientManagement
            // 
            this.buttonClientManagement.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonClientManagement.Enabled = false;
            this.buttonClientManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClientManagement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClientManagement.Location = new System.Drawing.Point(71, 56);
            this.buttonClientManagement.Name = "buttonClientManagement";
            this.buttonClientManagement.Size = new System.Drawing.Size(212, 133);
            this.buttonClientManagement.TabIndex = 4;
            this.buttonClientManagement.Text = "Client Management";
            this.buttonClientManagement.UseVisualStyleBackColor = false;
            this.buttonClientManagement.Click += new System.EventHandler(this.buttonClientManagement_Click);
            // 
            // FormStartingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1260, 694);
            this.Controls.Add(this.buttonClientManagement);
            this.Controls.Add(this.buttonSessionManagement);
            this.Controls.Add(this.buttonExerciseManagement);
            this.Controls.Add(this.buttonViewClients);
            this.Name = "FormStartingMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonViewClients;
        private System.Windows.Forms.Button buttonExerciseManagement;
        private System.Windows.Forms.Button buttonSessionManagement;
        private System.Windows.Forms.Button buttonClientManagement;
    }
}