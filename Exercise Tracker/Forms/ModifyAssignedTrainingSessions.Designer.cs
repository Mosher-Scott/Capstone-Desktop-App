
namespace Exercise_Tracker.Forms
{
    partial class ModifyAssignedTrainingSessions
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
            this.labelClientId = new System.Windows.Forms.Label();
            this.dataGridViewTrainingSessions = new System.Windows.Forms.DataGridView();
            this.comboBoxAllTrainingSessions = new System.Windows.Forms.ComboBox();
            this.labelAssignedSessions = new System.Windows.Forms.Label();
            this.labelAddNewSession = new System.Windows.Forms.Label();
            this.groupBoxSessionInfo = new System.Windows.Forms.GroupBox();
            this.labelSessionname = new System.Windows.Forms.Label();
            this.labelSessionDescription = new System.Windows.Forms.Label();
            this.labelReps = new System.Windows.Forms.Label();
            this.labelSets = new System.Windows.Forms.Label();
            this.textBoxSessionName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSets = new System.Windows.Forms.TextBox();
            this.textBoxReps = new System.Windows.Forms.TextBox();
            this.buttonAddSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).BeginInit();
            this.groupBoxSessionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(77, 103);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(131, 32);
            this.labelClientId.TabIndex = 0;
            this.labelClientId.Text = "Client ID:";
            // 
            // dataGridViewTrainingSessions
            // 
            this.dataGridViewTrainingSessions.AllowUserToAddRows = false;
            this.dataGridViewTrainingSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainingSessions.Location = new System.Drawing.Point(83, 208);
            this.dataGridViewTrainingSessions.Name = "dataGridViewTrainingSessions";
            this.dataGridViewTrainingSessions.ReadOnly = true;
            this.dataGridViewTrainingSessions.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessions.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessions.Size = new System.Drawing.Size(1617, 524);
            this.dataGridViewTrainingSessions.TabIndex = 1;
            // 
            // comboBoxAllTrainingSessions
            // 
            this.comboBoxAllTrainingSessions.FormattingEnabled = true;
            this.comboBoxAllTrainingSessions.Location = new System.Drawing.Point(83, 814);
            this.comboBoxAllTrainingSessions.Name = "comboBoxAllTrainingSessions";
            this.comboBoxAllTrainingSessions.Size = new System.Drawing.Size(519, 39);
            this.comboBoxAllTrainingSessions.TabIndex = 2;
            this.comboBoxAllTrainingSessions.SelectedIndexChanged += new System.EventHandler(this.ViewTrainingSessionDetails);
            // 
            // labelAssignedSessions
            // 
            this.labelAssignedSessions.AutoSize = true;
            this.labelAssignedSessions.Location = new System.Drawing.Point(77, 154);
            this.labelAssignedSessions.Name = "labelAssignedSessions";
            this.labelAssignedSessions.Size = new System.Drawing.Size(367, 32);
            this.labelAssignedSessions.TabIndex = 3;
            this.labelAssignedSessions.Text = "Assigned Training Sessions";
            // 
            // labelAddNewSession
            // 
            this.labelAddNewSession.AutoSize = true;
            this.labelAddNewSession.Location = new System.Drawing.Point(83, 769);
            this.labelAddNewSession.Name = "labelAddNewSession";
            this.labelAddNewSession.Size = new System.Drawing.Size(238, 32);
            this.labelAddNewSession.TabIndex = 4;
            this.labelAddNewSession.Text = "Add New Session";
            // 
            // groupBoxSessionInfo
            // 
            this.groupBoxSessionInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxSessionInfo.Controls.Add(this.buttonAddSession);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxReps);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxSets);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxDescription);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxSessionName);
            this.groupBoxSessionInfo.Controls.Add(this.labelSets);
            this.groupBoxSessionInfo.Controls.Add(this.labelReps);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionDescription);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionname);
            this.groupBoxSessionInfo.Location = new System.Drawing.Point(89, 872);
            this.groupBoxSessionInfo.Name = "groupBoxSessionInfo";
            this.groupBoxSessionInfo.Size = new System.Drawing.Size(1431, 600);
            this.groupBoxSessionInfo.TabIndex = 5;
            this.groupBoxSessionInfo.TabStop = false;
            this.groupBoxSessionInfo.Text = "Training Session Info";
            // 
            // labelSessionname
            // 
            this.labelSessionname.AutoSize = true;
            this.labelSessionname.Location = new System.Drawing.Point(29, 62);
            this.labelSessionname.Name = "labelSessionname";
            this.labelSessionname.Size = new System.Drawing.Size(207, 32);
            this.labelSessionname.TabIndex = 0;
            this.labelSessionname.Text = "Session Name:";
            // 
            // labelSessionDescription
            // 
            this.labelSessionDescription.AutoSize = true;
            this.labelSessionDescription.Location = new System.Drawing.Point(51, 119);
            this.labelSessionDescription.Name = "labelSessionDescription";
            this.labelSessionDescription.Size = new System.Drawing.Size(166, 32);
            this.labelSessionDescription.TabIndex = 1;
            this.labelSessionDescription.Text = "Description:";
            // 
            // labelReps
            // 
            this.labelReps.AutoSize = true;
            this.labelReps.Location = new System.Drawing.Point(128, 418);
            this.labelReps.Name = "labelReps";
            this.labelReps.Size = new System.Drawing.Size(89, 32);
            this.labelReps.TabIndex = 2;
            this.labelReps.Text = "Reps:";
            // 
            // labelSets
            // 
            this.labelSets.AutoSize = true;
            this.labelSets.Location = new System.Drawing.Point(128, 362);
            this.labelSets.Name = "labelSets";
            this.labelSets.Size = new System.Drawing.Size(80, 32);
            this.labelSets.TabIndex = 3;
            this.labelSets.Text = "Sets:";
            // 
            // textBoxSessionName
            // 
            this.textBoxSessionName.Enabled = false;
            this.textBoxSessionName.Location = new System.Drawing.Point(243, 55);
            this.textBoxSessionName.Name = "textBoxSessionName";
            this.textBoxSessionName.Size = new System.Drawing.Size(580, 38);
            this.textBoxSessionName.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(243, 116);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(1098, 225);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxSets
            // 
            this.textBoxSets.Enabled = false;
            this.textBoxSets.Location = new System.Drawing.Point(234, 359);
            this.textBoxSets.Name = "textBoxSets";
            this.textBoxSets.Size = new System.Drawing.Size(72, 38);
            this.textBoxSets.TabIndex = 6;
            // 
            // textBoxReps
            // 
            this.textBoxReps.Enabled = false;
            this.textBoxReps.Location = new System.Drawing.Point(234, 418);
            this.textBoxReps.Name = "textBoxReps";
            this.textBoxReps.Size = new System.Drawing.Size(72, 38);
            this.textBoxReps.TabIndex = 7;
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.Location = new System.Drawing.Point(66, 483);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(142, 87);
            this.buttonAddSession.TabIndex = 8;
            this.buttonAddSession.Text = "Add Session";
            this.buttonAddSession.UseVisualStyleBackColor = true;
            // 
            // ModifyAssignedTrainingSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1852, 1541);
            this.Controls.Add(this.groupBoxSessionInfo);
            this.Controls.Add(this.labelAddNewSession);
            this.Controls.Add(this.labelAssignedSessions);
            this.Controls.Add(this.comboBoxAllTrainingSessions);
            this.Controls.Add(this.dataGridViewTrainingSessions);
            this.Controls.Add(this.labelClientId);
            this.Name = "ModifyAssignedTrainingSessions";
            this.Text = "ModifyAssignedTrainingSessions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).EndInit();
            this.groupBoxSessionInfo.ResumeLayout(false);
            this.groupBoxSessionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.DataGridView dataGridViewTrainingSessions;
        private System.Windows.Forms.ComboBox comboBoxAllTrainingSessions;
        private System.Windows.Forms.Label labelAssignedSessions;
        private System.Windows.Forms.Label labelAddNewSession;
        private System.Windows.Forms.GroupBox groupBoxSessionInfo;
        private System.Windows.Forms.Label labelSessionname;
        private System.Windows.Forms.TextBox textBoxSessionName;
        private System.Windows.Forms.Label labelSets;
        private System.Windows.Forms.Label labelReps;
        private System.Windows.Forms.Label labelSessionDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxReps;
        private System.Windows.Forms.TextBox textBoxSets;
        private System.Windows.Forms.Button buttonAddSession;
    }
}