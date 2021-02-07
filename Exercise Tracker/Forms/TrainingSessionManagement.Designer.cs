
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
            this.dataGridViewTrainingSessionDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrainingSessionData
            // 
            this.dataGridViewTrainingSessionData.AllowUserToAddRows = false;
            this.dataGridViewTrainingSessionData.AllowUserToDeleteRows = false;
            this.dataGridViewTrainingSessionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainingSessionData.Location = new System.Drawing.Point(95, 526);
            this.dataGridViewTrainingSessionData.Name = "dataGridViewTrainingSessionData";
            this.dataGridViewTrainingSessionData.ReadOnly = true;
            this.dataGridViewTrainingSessionData.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessionData.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessionData.Size = new System.Drawing.Size(2014, 442);
            this.dataGridViewTrainingSessionData.TabIndex = 0;
            // 
            // labelTrainingSessionExercises
            // 
            this.labelTrainingSessionExercises.AutoSize = true;
            this.labelTrainingSessionExercises.Location = new System.Drawing.Point(95, 471);
            this.labelTrainingSessionExercises.Name = "labelTrainingSessionExercises";
            this.labelTrainingSessionExercises.Size = new System.Drawing.Size(138, 32);
            this.labelTrainingSessionExercises.TabIndex = 1;
            this.labelTrainingSessionExercises.Text = "Exercises";
            // 
            // comboBoxTrainingSessions
            // 
            this.comboBoxTrainingSessions.FormattingEnabled = true;
            this.comboBoxTrainingSessions.Location = new System.Drawing.Point(95, 112);
            this.comboBoxTrainingSessions.Name = "comboBoxTrainingSessions";
            this.comboBoxTrainingSessions.Size = new System.Drawing.Size(411, 39);
            this.comboBoxTrainingSessions.TabIndex = 2;
            // 
            // labelTrainingSessionBox
            // 
            this.labelTrainingSessionBox.AutoSize = true;
            this.labelTrainingSessionBox.Location = new System.Drawing.Point(95, 54);
            this.labelTrainingSessionBox.Name = "labelTrainingSessionBox";
            this.labelTrainingSessionBox.Size = new System.Drawing.Size(242, 32);
            this.labelTrainingSessionBox.TabIndex = 3;
            this.labelTrainingSessionBox.Text = "Training Sessions";
            // 
            // buttonAddNewSession
            // 
            this.buttonAddNewSession.Location = new System.Drawing.Point(751, 112);
            this.buttonAddNewSession.Name = "buttonAddNewSession";
            this.buttonAddNewSession.Size = new System.Drawing.Size(165, 81);
            this.buttonAddNewSession.TabIndex = 10;
            this.buttonAddNewSession.Text = "Add New";
            this.buttonAddNewSession.UseVisualStyleBackColor = true;
            // 
            // buttonEditSession
            // 
            this.buttonEditSession.Location = new System.Drawing.Point(546, 112);
            this.buttonEditSession.Name = "buttonEditSession";
            this.buttonEditSession.Size = new System.Drawing.Size(165, 81);
            this.buttonEditSession.TabIndex = 11;
            this.buttonEditSession.Text = "Edit";
            this.buttonEditSession.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTrainingSessionDetails
            // 
            this.dataGridViewTrainingSessionDetails.AllowUserToAddRows = false;
            this.dataGridViewTrainingSessionDetails.AllowUserToDeleteRows = false;
            this.dataGridViewTrainingSessionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainingSessionDetails.Location = new System.Drawing.Point(114, 266);
            this.dataGridViewTrainingSessionDetails.Name = "dataGridViewTrainingSessionDetails";
            this.dataGridViewTrainingSessionDetails.ReadOnly = true;
            this.dataGridViewTrainingSessionDetails.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessionDetails.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessionDetails.Size = new System.Drawing.Size(1995, 150);
            this.dataGridViewTrainingSessionDetails.TabIndex = 12;
            // 
            // TrainingSessionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2179, 1189);
            this.Controls.Add(this.dataGridViewTrainingSessionDetails);
            this.Controls.Add(this.buttonEditSession);
            this.Controls.Add(this.buttonAddNewSession);
            this.Controls.Add(this.labelTrainingSessionBox);
            this.Controls.Add(this.comboBoxTrainingSessions);
            this.Controls.Add(this.labelTrainingSessionExercises);
            this.Controls.Add(this.dataGridViewTrainingSessionData);
            this.Name = "TrainingSessionManagement";
            this.Text = "Training Session Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessionDetails)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewTrainingSessionDetails;
    }
}