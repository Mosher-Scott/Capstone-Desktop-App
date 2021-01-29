
namespace Exercise_Tracker.Forms
{
    partial class ClientManagement
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
            this.labelClientInfo = new System.Windows.Forms.Label();
            this.buttonGetClientInfo = new System.Windows.Forms.Button();
            this.dataGridViewClientDetails = new System.Windows.Forms.DataGridView();
            this.labelClientNames = new System.Windows.Forms.Label();
            this.comboBoxClientNames = new System.Windows.Forms.ComboBox();
            this.labelClientTrainingSessions = new System.Windows.Forms.Label();
            this.dataGridViewTrainingSessions = new System.Windows.Forms.DataGridView();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.dataGridViewWorkoutHistory = new System.Windows.Forms.DataGridView();
            this.labelWorkoutHistory = new System.Windows.Forms.Label();
            this.buttonDeleteSession = new System.Windows.Forms.Button();
            this.buttonAddSession = new System.Windows.Forms.Button();
            this.buttonDeleteWorkout = new System.Windows.Forms.Button();
            this.buttonEditWorkout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInfo.Location = new System.Drawing.Point(31, 191);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(154, 32);
            this.labelClientInfo.TabIndex = 10;
            this.labelClientInfo.Text = "Client Info";
            // 
            // buttonGetClientInfo
            // 
            this.buttonGetClientInfo.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonGetClientInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGetClientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetClientInfo.Location = new System.Drawing.Point(966, 71);
            this.buttonGetClientInfo.Name = "buttonGetClientInfo";
            this.buttonGetClientInfo.Size = new System.Drawing.Size(164, 76);
            this.buttonGetClientInfo.TabIndex = 9;
            this.buttonGetClientInfo.Text = "Get Info";
            this.buttonGetClientInfo.UseVisualStyleBackColor = false;
            this.buttonGetClientInfo.Visible = false;
            this.buttonGetClientInfo.Click += new System.EventHandler(this.buttonGetClientInfo_Click);
            // 
            // dataGridViewClientDetails
            // 
            this.dataGridViewClientDetails.AllowUserToAddRows = false;
            this.dataGridViewClientDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClientDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientDetails.Location = new System.Drawing.Point(31, 229);
            this.dataGridViewClientDetails.Name = "dataGridViewClientDetails";
            this.dataGridViewClientDetails.ReadOnly = true;
            this.dataGridViewClientDetails.RowHeadersWidth = 102;
            this.dataGridViewClientDetails.RowTemplate.Height = 40;
            this.dataGridViewClientDetails.Size = new System.Drawing.Size(2076, 177);
            this.dataGridViewClientDetails.TabIndex = 8;
            // 
            // labelClientNames
            // 
            this.labelClientNames.AutoSize = true;
            this.labelClientNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNames.Location = new System.Drawing.Point(25, 80);
            this.labelClientNames.Name = "labelClientNames";
            this.labelClientNames.Size = new System.Drawing.Size(207, 32);
            this.labelClientNames.TabIndex = 7;
            this.labelClientNames.Text = "Choose Client";
            // 
            // comboBoxClientNames
            // 
            this.comboBoxClientNames.FormattingEnabled = true;
            this.comboBoxClientNames.Location = new System.Drawing.Point(31, 118);
            this.comboBoxClientNames.Name = "comboBoxClientNames";
            this.comboBoxClientNames.Size = new System.Drawing.Size(345, 39);
            this.comboBoxClientNames.TabIndex = 6;
            this.comboBoxClientNames.SelectedIndexChanged += new System.EventHandler(this.buttonGetClientInfo_Click);
            // 
            // labelClientTrainingSessions
            // 
            this.labelClientTrainingSessions.AutoSize = true;
            this.labelClientTrainingSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientTrainingSessions.Location = new System.Drawing.Point(45, 558);
            this.labelClientTrainingSessions.Name = "labelClientTrainingSessions";
            this.labelClientTrainingSessions.Size = new System.Drawing.Size(393, 32);
            this.labelClientTrainingSessions.TabIndex = 12;
            this.labelClientTrainingSessions.Text = "Assigned Training Sessions";
            // 
            // dataGridViewTrainingSessions
            // 
            this.dataGridViewTrainingSessions.AllowUserToAddRows = false;
            this.dataGridViewTrainingSessions.AllowUserToDeleteRows = false;
            this.dataGridViewTrainingSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTrainingSessions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTrainingSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainingSessions.Location = new System.Drawing.Point(31, 641);
            this.dataGridViewTrainingSessions.Name = "dataGridViewTrainingSessions";
            this.dataGridViewTrainingSessions.ReadOnly = true;
            this.dataGridViewTrainingSessions.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessions.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessions.Size = new System.Drawing.Size(2354, 469);
            this.dataGridViewTrainingSessions.TabIndex = 11;
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditClient.Location = new System.Drawing.Point(37, 412);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(164, 76);
            this.buttonEditClient.TabIndex = 13;
            this.buttonEditClient.Text = "Edit Client";
            this.buttonEditClient.UseVisualStyleBackColor = false;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteClient.Location = new System.Drawing.Point(228, 412);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(210, 76);
            this.buttonDeleteClient.TabIndex = 14;
            this.buttonDeleteClient.Text = "Delete Client";
            this.buttonDeleteClient.UseVisualStyleBackColor = false;
            // 
            // dataGridViewWorkoutHistory
            // 
            this.dataGridViewWorkoutHistory.AllowUserToAddRows = false;
            this.dataGridViewWorkoutHistory.AllowUserToDeleteRows = false;
            this.dataGridViewWorkoutHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewWorkoutHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkoutHistory.Location = new System.Drawing.Point(45, 1286);
            this.dataGridViewWorkoutHistory.Name = "dataGridViewWorkoutHistory";
            this.dataGridViewWorkoutHistory.ReadOnly = true;
            this.dataGridViewWorkoutHistory.RowHeadersWidth = 102;
            this.dataGridViewWorkoutHistory.RowTemplate.Height = 40;
            this.dataGridViewWorkoutHistory.Size = new System.Drawing.Size(2340, 440);
            this.dataGridViewWorkoutHistory.TabIndex = 15;
            // 
            // labelWorkoutHistory
            // 
            this.labelWorkoutHistory.AutoSize = true;
            this.labelWorkoutHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkoutHistory.Location = new System.Drawing.Point(45, 1237);
            this.labelWorkoutHistory.Name = "labelWorkoutHistory";
            this.labelWorkoutHistory.Size = new System.Drawing.Size(230, 32);
            this.labelWorkoutHistory.TabIndex = 16;
            this.labelWorkoutHistory.Text = "Workout History";
            // 
            // buttonDeleteSession
            // 
            this.buttonDeleteSession.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDeleteSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteSession.Location = new System.Drawing.Point(236, 1116);
            this.buttonDeleteSession.Name = "buttonDeleteSession";
            this.buttonDeleteSession.Size = new System.Drawing.Size(210, 76);
            this.buttonDeleteSession.TabIndex = 18;
            this.buttonDeleteSession.Text = "Delete Client";
            this.buttonDeleteSession.UseVisualStyleBackColor = false;
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddSession.Location = new System.Drawing.Point(45, 1116);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(164, 76);
            this.buttonAddSession.TabIndex = 17;
            this.buttonAddSession.Text = "Edit Client";
            this.buttonAddSession.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteWorkout
            // 
            this.buttonDeleteWorkout.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDeleteWorkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteWorkout.Location = new System.Drawing.Point(263, 1785);
            this.buttonDeleteWorkout.Name = "buttonDeleteWorkout";
            this.buttonDeleteWorkout.Size = new System.Drawing.Size(230, 76);
            this.buttonDeleteWorkout.TabIndex = 20;
            this.buttonDeleteWorkout.Text = "Delete Workout";
            this.buttonDeleteWorkout.UseVisualStyleBackColor = false;
            // 
            // buttonEditWorkout
            // 
            this.buttonEditWorkout.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditWorkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditWorkout.Location = new System.Drawing.Point(45, 1785);
            this.buttonEditWorkout.Name = "buttonEditWorkout";
            this.buttonEditWorkout.Size = new System.Drawing.Size(187, 76);
            this.buttonEditWorkout.TabIndex = 19;
            this.buttonEditWorkout.Text = "Edit Workout";
            this.buttonEditWorkout.UseVisualStyleBackColor = false;
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2425, 2113);
            this.Controls.Add(this.buttonDeleteWorkout);
            this.Controls.Add(this.buttonEditWorkout);
            this.Controls.Add(this.buttonDeleteSession);
            this.Controls.Add(this.buttonAddSession);
            this.Controls.Add(this.labelWorkoutHistory);
            this.Controls.Add(this.dataGridViewWorkoutHistory);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.labelClientTrainingSessions);
            this.Controls.Add(this.dataGridViewTrainingSessions);
            this.Controls.Add(this.labelClientInfo);
            this.Controls.Add(this.buttonGetClientInfo);
            this.Controls.Add(this.dataGridViewClientDetails);
            this.Controls.Add(this.labelClientNames);
            this.Controls.Add(this.comboBoxClientNames);
            this.Name = "ClientManagement";
            this.Text = "ClientManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientInfo;
        private System.Windows.Forms.Button buttonGetClientInfo;
        private System.Windows.Forms.DataGridView dataGridViewClientDetails;
        private System.Windows.Forms.Label labelClientNames;
        private System.Windows.Forms.ComboBox comboBoxClientNames;
        private System.Windows.Forms.Label labelClientTrainingSessions;
        private System.Windows.Forms.DataGridView dataGridViewTrainingSessions;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.DataGridView dataGridViewWorkoutHistory;
        private System.Windows.Forms.Label labelWorkoutHistory;
        private System.Windows.Forms.Button buttonDeleteSession;
        private System.Windows.Forms.Button buttonAddSession;
        private System.Windows.Forms.Button buttonDeleteWorkout;
        private System.Windows.Forms.Button buttonEditWorkout;
    }
}