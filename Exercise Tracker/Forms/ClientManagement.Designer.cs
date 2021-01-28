
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).BeginInit();
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
            this.buttonGetClientInfo.Location = new System.Drawing.Point(418, 118);
            this.buttonGetClientInfo.Name = "buttonGetClientInfo";
            this.buttonGetClientInfo.Size = new System.Drawing.Size(164, 76);
            this.buttonGetClientInfo.TabIndex = 9;
            this.buttonGetClientInfo.Text = "Get Info";
            this.buttonGetClientInfo.UseVisualStyleBackColor = false;
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
            this.dataGridViewClientDetails.Size = new System.Drawing.Size(2368, 162);
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
            this.labelClientTrainingSessions.Location = new System.Drawing.Point(37, 436);
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
            this.dataGridViewTrainingSessions.Location = new System.Drawing.Point(37, 507);
            this.dataGridViewTrainingSessions.Name = "dataGridViewTrainingSessions";
            this.dataGridViewTrainingSessions.ReadOnly = true;
            this.dataGridViewTrainingSessions.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessions.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessions.Size = new System.Drawing.Size(2484, 469);
            this.dataGridViewTrainingSessions.TabIndex = 11;
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2548, 1747);
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
    }
}