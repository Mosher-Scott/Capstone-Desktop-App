
namespace Exercise_Tracker.Forms
{
    partial class TrainingSessionManagement
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
            this.dataGridViewTrainingSessionData = new System.Windows.Forms.DataGridView();
            this.labelTrainingSessionExercises = new System.Windows.Forms.Label();
            this.comboBoxTrainingSessions = new System.Windows.Forms.ComboBox();
            this.labelTrainingSessionBox = new System.Windows.Forms.Label();
            this.buttonAddNewSession = new System.Windows.Forms.Button();
            this.buttonEditSession = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSessionId = new System.Windows.Forms.Label();
            this.textBoxSessionId = new System.Windows.Forms.TextBox();
            this.textBoxSessionName = new System.Windows.Forms.TextBox();
            this.labelSessionName = new System.Windows.Forms.Label();
            this.textBoxSessionDescription = new System.Windows.Forms.TextBox();
            this.labelSessionDescription = new System.Windows.Forms.Label();
            this.textBoxSets = new System.Windows.Forms.TextBox();
            this.labelSessionSets = new System.Windows.Forms.Label();
            this.textBoxReps = new System.Windows.Forms.TextBox();
            this.labelSessionReps = new System.Windows.Forms.Label();
            this.checkBoxSessionActive = new System.Windows.Forms.CheckBox();
            this.groupBoxSessionInfo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessionData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSessionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTrainingSessionData
            // 
            this.dataGridViewTrainingSessionData.AllowUserToAddRows = false;
            this.dataGridViewTrainingSessionData.AllowUserToDeleteRows = false;
            this.dataGridViewTrainingSessionData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTrainingSessionData.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTrainingSessionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainingSessionData.Location = new System.Drawing.Point(20, 838);
            this.dataGridViewTrainingSessionData.Name = "dataGridViewTrainingSessionData";
            this.dataGridViewTrainingSessionData.ReadOnly = true;
            this.dataGridViewTrainingSessionData.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessionData.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessionData.Size = new System.Drawing.Size(3382, 732);
            this.dataGridViewTrainingSessionData.TabIndex = 0;
            // 
            // labelTrainingSessionExercises
            // 
            this.labelTrainingSessionExercises.AutoSize = true;
            this.labelTrainingSessionExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainingSessionExercises.Location = new System.Drawing.Point(20, 783);
            this.labelTrainingSessionExercises.Name = "labelTrainingSessionExercises";
            this.labelTrainingSessionExercises.Size = new System.Drawing.Size(147, 32);
            this.labelTrainingSessionExercises.TabIndex = 1;
            this.labelTrainingSessionExercises.Text = "Exercises";
            // 
            // comboBoxTrainingSessions
            // 
            this.comboBoxTrainingSessions.FormattingEnabled = true;
            this.comboBoxTrainingSessions.Location = new System.Drawing.Point(26, 127);
            this.comboBoxTrainingSessions.Name = "comboBoxTrainingSessions";
            this.comboBoxTrainingSessions.Size = new System.Drawing.Size(411, 39);
            this.comboBoxTrainingSessions.TabIndex = 2;
            this.comboBoxTrainingSessions.SelectedIndexChanged += new System.EventHandler(this.SessionSelected_changed);
            // 
            // labelTrainingSessionBox
            // 
            this.labelTrainingSessionBox.AutoSize = true;
            this.labelTrainingSessionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrainingSessionBox.Location = new System.Drawing.Point(26, 89);
            this.labelTrainingSessionBox.Name = "labelTrainingSessionBox";
            this.labelTrainingSessionBox.Size = new System.Drawing.Size(259, 32);
            this.labelTrainingSessionBox.TabIndex = 3;
            this.labelTrainingSessionBox.Text = "Training Sessions";
            // 
            // buttonAddNewSession
            // 
            this.buttonAddNewSession.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddNewSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddNewSession.Location = new System.Drawing.Point(682, 127);
            this.buttonAddNewSession.Name = "buttonAddNewSession";
            this.buttonAddNewSession.Size = new System.Drawing.Size(165, 81);
            this.buttonAddNewSession.TabIndex = 10;
            this.buttonAddNewSession.Text = "Add New";
            this.buttonAddNewSession.UseVisualStyleBackColor = false;
            this.buttonAddNewSession.Click += new System.EventHandler(this.buttonAddNewSession_Click);
            // 
            // buttonEditSession
            // 
            this.buttonEditSession.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditSession.Location = new System.Drawing.Point(477, 127);
            this.buttonEditSession.Name = "buttonEditSession";
            this.buttonEditSession.Size = new System.Drawing.Size(165, 81);
            this.buttonEditSession.TabIndex = 11;
            this.buttonEditSession.Text = "Edit";
            this.buttonEditSession.UseVisualStyleBackColor = false;
            this.buttonEditSession.Click += new System.EventHandler(this.buttonEditSession_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(3402, 49);
            this.menuStrip1.TabIndex = 25;
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
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(192, 45);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // labelSessionId
            // 
            this.labelSessionId.AutoSize = true;
            this.labelSessionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionId.Location = new System.Drawing.Point(141, 59);
            this.labelSessionId.Name = "labelSessionId";
            this.labelSessionId.Size = new System.Drawing.Size(53, 32);
            this.labelSessionId.TabIndex = 26;
            this.labelSessionId.Text = "ID:";
            // 
            // textBoxSessionId
            // 
            this.textBoxSessionId.Enabled = false;
            this.textBoxSessionId.Location = new System.Drawing.Point(208, 56);
            this.textBoxSessionId.Name = "textBoxSessionId";
            this.textBoxSessionId.Size = new System.Drawing.Size(61, 38);
            this.textBoxSessionId.TabIndex = 27;
            // 
            // textBoxSessionName
            // 
            this.textBoxSessionName.Enabled = false;
            this.textBoxSessionName.Location = new System.Drawing.Point(208, 110);
            this.textBoxSessionName.Name = "textBoxSessionName";
            this.textBoxSessionName.Size = new System.Drawing.Size(468, 38);
            this.textBoxSessionName.TabIndex = 29;
            // 
            // labelSessionName
            // 
            this.labelSessionName.AutoSize = true;
            this.labelSessionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionName.Location = new System.Drawing.Point(100, 113);
            this.labelSessionName.Name = "labelSessionName";
            this.labelSessionName.Size = new System.Drawing.Size(103, 32);
            this.labelSessionName.TabIndex = 28;
            this.labelSessionName.Text = "Name:";
            // 
            // textBoxSessionDescription
            // 
            this.textBoxSessionDescription.Enabled = false;
            this.textBoxSessionDescription.Location = new System.Drawing.Point(208, 163);
            this.textBoxSessionDescription.Multiline = true;
            this.textBoxSessionDescription.Name = "textBoxSessionDescription";
            this.textBoxSessionDescription.Size = new System.Drawing.Size(1277, 106);
            this.textBoxSessionDescription.TabIndex = 31;
            // 
            // labelSessionDescription
            // 
            this.labelSessionDescription.AutoSize = true;
            this.labelSessionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionDescription.Location = new System.Drawing.Point(25, 170);
            this.labelSessionDescription.Name = "labelSessionDescription";
            this.labelSessionDescription.Size = new System.Drawing.Size(178, 32);
            this.labelSessionDescription.TabIndex = 30;
            this.labelSessionDescription.Text = "Description:";
            // 
            // textBoxSets
            // 
            this.textBoxSets.Enabled = false;
            this.textBoxSets.Location = new System.Drawing.Point(206, 286);
            this.textBoxSets.Name = "textBoxSets";
            this.textBoxSets.Size = new System.Drawing.Size(61, 38);
            this.textBoxSets.TabIndex = 33;
            // 
            // labelSessionSets
            // 
            this.labelSessionSets.AutoSize = true;
            this.labelSessionSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionSets.Location = new System.Drawing.Point(107, 286);
            this.labelSessionSets.Name = "labelSessionSets";
            this.labelSessionSets.Size = new System.Drawing.Size(85, 32);
            this.labelSessionSets.TabIndex = 32;
            this.labelSessionSets.Text = "Sets:";
            // 
            // textBoxReps
            // 
            this.textBoxReps.Enabled = false;
            this.textBoxReps.Location = new System.Drawing.Point(206, 342);
            this.textBoxReps.Name = "textBoxReps";
            this.textBoxReps.Size = new System.Drawing.Size(61, 38);
            this.textBoxReps.TabIndex = 35;
            // 
            // labelSessionReps
            // 
            this.labelSessionReps.AutoSize = true;
            this.labelSessionReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionReps.Location = new System.Drawing.Point(100, 342);
            this.labelSessionReps.Name = "labelSessionReps";
            this.labelSessionReps.Size = new System.Drawing.Size(94, 32);
            this.labelSessionReps.TabIndex = 34;
            this.labelSessionReps.Text = "Reps:";
            // 
            // checkBoxSessionActive
            // 
            this.checkBoxSessionActive.AutoSize = true;
            this.checkBoxSessionActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSessionActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSessionActive.Location = new System.Drawing.Point(99, 408);
            this.checkBoxSessionActive.Name = "checkBoxSessionActive";
            this.checkBoxSessionActive.Size = new System.Drawing.Size(137, 36);
            this.checkBoxSessionActive.TabIndex = 36;
            this.checkBoxSessionActive.Text = "Active";
            this.checkBoxSessionActive.UseVisualStyleBackColor = true;
            // 
            // groupBoxSessionInfo
            // 
            this.groupBoxSessionInfo.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxSessionInfo.Controls.Add(this.textBoxSessionDescription);
            this.groupBoxSessionInfo.Controls.Add(this.checkBoxSessionActive);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionId);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxReps);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxSessionId);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionReps);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionName);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxSets);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxSessionName);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionSets);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionDescription);
            this.groupBoxSessionInfo.Location = new System.Drawing.Point(26, 258);
            this.groupBoxSessionInfo.Name = "groupBoxSessionInfo";
            this.groupBoxSessionInfo.Size = new System.Drawing.Size(1688, 495);
            this.groupBoxSessionInfo.TabIndex = 37;
            this.groupBoxSessionInfo.TabStop = false;
            this.groupBoxSessionInfo.Text = "Session Information";
            // 
            // TrainingSessionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(2953, 1746);
            this.Controls.Add(this.groupBoxSessionInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonEditSession);
            this.Controls.Add(this.buttonAddNewSession);
            this.Controls.Add(this.labelTrainingSessionBox);
            this.Controls.Add(this.comboBoxTrainingSessions);
            this.Controls.Add(this.labelTrainingSessionExercises);
            this.Controls.Add(this.dataGridViewTrainingSessionData);
            this.Name = "TrainingSessionManagement";
            this.Text = "Training Session Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessionData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSessionInfo.ResumeLayout(false);
            this.groupBoxSessionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrainingSessionData;
        private System.Windows.Forms.Label labelTrainingSessionExercises;
        private System.Windows.Forms.ComboBox comboBoxTrainingSessions;
        private System.Windows.Forms.Label labelTrainingSessionBox;
        private System.Windows.Forms.Button buttonAddNewSession;
        private System.Windows.Forms.Button buttonEditSession;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.Label labelSessionId;
        private System.Windows.Forms.TextBox textBoxSessionId;
        private System.Windows.Forms.TextBox textBoxSessionName;
        private System.Windows.Forms.Label labelSessionName;
        private System.Windows.Forms.TextBox textBoxSessionDescription;
        private System.Windows.Forms.Label labelSessionDescription;
        private System.Windows.Forms.TextBox textBoxSets;
        private System.Windows.Forms.Label labelSessionSets;
        private System.Windows.Forms.TextBox textBoxReps;
        private System.Windows.Forms.Label labelSessionReps;
        private System.Windows.Forms.CheckBox checkBoxSessionActive;
        private System.Windows.Forms.GroupBox groupBoxSessionInfo;
    }
}