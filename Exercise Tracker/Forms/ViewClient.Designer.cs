
namespace Exercise_Tracker
{
    partial class FormViewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewClient));
            this.comboBoxClientNames = new System.Windows.Forms.ComboBox();
            this.labelClientNames = new System.Windows.Forms.Label();
            this.dataGridViewClientDetails = new System.Windows.Forms.DataGridView();
            this.buttonGetClientInfo = new System.Windows.Forms.Button();
            this.dataGridViewTrainingSessions = new System.Windows.Forms.DataGridView();
            this.labelClientInfo = new System.Windows.Forms.Label();
            this.labelClientTrainingSessions = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxAssignedTrainingSessions = new System.Windows.Forms.ComboBox();
            this.labelPickSession = new System.Windows.Forms.Label();
            this.dataGridViewSessionExercises = new System.Windows.Forms.DataGridView();
            this.buttonDoWorkout = new System.Windows.Forms.Button();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionExercises)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClientNames
            // 
            this.comboBoxClientNames.FormattingEnabled = true;
            this.comboBoxClientNames.Location = new System.Drawing.Point(14, 60);
            this.comboBoxClientNames.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBoxClientNames.Name = "comboBoxClientNames";
            this.comboBoxClientNames.Size = new System.Drawing.Size(132, 21);
            this.comboBoxClientNames.TabIndex = 0;
            // 
            // labelClientNames
            // 
            this.labelClientNames.AutoSize = true;
            this.labelClientNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNames.Location = new System.Drawing.Point(12, 44);
            this.labelClientNames.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientNames.Name = "labelClientNames";
            this.labelClientNames.Size = new System.Drawing.Size(85, 13);
            this.labelClientNames.TabIndex = 1;
            this.labelClientNames.Text = "Choose Client";
            // 
            // dataGridViewClientDetails
            // 
            this.dataGridViewClientDetails.AllowUserToAddRows = false;
            this.dataGridViewClientDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClientDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientDetails.Location = new System.Drawing.Point(14, 107);
            this.dataGridViewClientDetails.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewClientDetails.Name = "dataGridViewClientDetails";
            this.dataGridViewClientDetails.ReadOnly = true;
            this.dataGridViewClientDetails.RowHeadersWidth = 102;
            this.dataGridViewClientDetails.RowTemplate.Height = 40;
            this.dataGridViewClientDetails.Size = new System.Drawing.Size(888, 68);
            this.dataGridViewClientDetails.TabIndex = 2;
            // 
            // buttonGetClientInfo
            // 
            this.buttonGetClientInfo.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonGetClientInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGetClientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetClientInfo.Location = new System.Drawing.Point(159, 60);
            this.buttonGetClientInfo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonGetClientInfo.Name = "buttonGetClientInfo";
            this.buttonGetClientInfo.Size = new System.Drawing.Size(62, 32);
            this.buttonGetClientInfo.TabIndex = 3;
            this.buttonGetClientInfo.Text = "Get Info";
            this.buttonGetClientInfo.UseVisualStyleBackColor = false;
            this.buttonGetClientInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTrainingSessions
            // 
            this.dataGridViewTrainingSessions.AllowUserToAddRows = false;
            this.dataGridViewTrainingSessions.AllowUserToDeleteRows = false;
            this.dataGridViewTrainingSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTrainingSessions.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTrainingSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainingSessions.Location = new System.Drawing.Point(14, 232);
            this.dataGridViewTrainingSessions.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewTrainingSessions.Name = "dataGridViewTrainingSessions";
            this.dataGridViewTrainingSessions.ReadOnly = true;
            this.dataGridViewTrainingSessions.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessions.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessions.Size = new System.Drawing.Size(932, 197);
            this.dataGridViewTrainingSessions.TabIndex = 4;
            this.dataGridViewTrainingSessions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplaySessionExercieses);
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInfo.Location = new System.Drawing.Point(14, 91);
            this.labelClientInfo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(65, 13);
            this.labelClientInfo.TabIndex = 5;
            this.labelClientInfo.Text = "Client Info";
            // 
            // labelClientTrainingSessions
            // 
            this.labelClientTrainingSessions.AutoSize = true;
            this.labelClientTrainingSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientTrainingSessions.Location = new System.Drawing.Point(14, 216);
            this.labelClientTrainingSessions.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientTrainingSessions.Name = "labelClientTrainingSessions";
            this.labelClientTrainingSessions.Size = new System.Drawing.Size(107, 13);
            this.labelClientTrainingSessions.TabIndex = 6;
            this.labelClientTrainingSessions.Text = "Training Sessions";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboBoxAssignedTrainingSessions
            // 
            this.comboBoxAssignedTrainingSessions.FormattingEnabled = true;
            this.comboBoxAssignedTrainingSessions.Location = new System.Drawing.Point(285, 478);
            this.comboBoxAssignedTrainingSessions.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comboBoxAssignedTrainingSessions.Name = "comboBoxAssignedTrainingSessions";
            this.comboBoxAssignedTrainingSessions.Size = new System.Drawing.Size(145, 21);
            this.comboBoxAssignedTrainingSessions.TabIndex = 8;
            this.comboBoxAssignedTrainingSessions.Visible = false;
            this.comboBoxAssignedTrainingSessions.SelectedIndexChanged += new System.EventHandler(this.DisplaySessionExercieses);
            // 
            // labelPickSession
            // 
            this.labelPickSession.AutoSize = true;
            this.labelPickSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickSession.Location = new System.Drawing.Point(18, 476);
            this.labelPickSession.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPickSession.Name = "labelPickSession";
            this.labelPickSession.Size = new System.Drawing.Size(127, 13);
            this.labelPickSession.TabIndex = 9;
            this.labelPickSession.Text = "Training Session Info";
            // 
            // dataGridViewSessionExercises
            // 
            this.dataGridViewSessionExercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSessionExercises.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSessionExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessionExercises.Location = new System.Drawing.Point(14, 501);
            this.dataGridViewSessionExercises.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewSessionExercises.Name = "dataGridViewSessionExercises";
            this.dataGridViewSessionExercises.RowHeadersWidth = 102;
            this.dataGridViewSessionExercises.RowTemplate.Height = 40;
            this.dataGridViewSessionExercises.Size = new System.Drawing.Size(987, 227);
            this.dataGridViewSessionExercises.TabIndex = 10;
            // 
            // buttonDoWorkout
            // 
            this.buttonDoWorkout.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDoWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDoWorkout.Location = new System.Drawing.Point(153, 465);
            this.buttonDoWorkout.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonDoWorkout.Name = "buttonDoWorkout";
            this.buttonDoWorkout.Size = new System.Drawing.Size(90, 25);
            this.buttonDoWorkout.TabIndex = 11;
            this.buttonDoWorkout.Text = "Start Workout";
            this.buttonDoWorkout.UseVisualStyleBackColor = false;
            this.buttonDoWorkout.Click += new System.EventHandler(this.buttonDoWorkout_Click);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.closeFormToolStripMenuItem.Text = "Close Form";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // FormViewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 445);
            this.Controls.Add(this.buttonDoWorkout);
            this.Controls.Add(this.dataGridViewSessionExercises);
            this.Controls.Add(this.labelPickSession);
            this.Controls.Add(this.comboBoxAssignedTrainingSessions);
            this.Controls.Add(this.labelClientTrainingSessions);
            this.Controls.Add(this.labelClientInfo);
            this.Controls.Add(this.dataGridViewTrainingSessions);
            this.Controls.Add(this.buttonGetClientInfo);
            this.Controls.Add(this.dataGridViewClientDetails);
            this.Controls.Add(this.labelClientNames);
            this.Controls.Add(this.comboBoxClientNames);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormViewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercise Tracker";
            this.Load += new System.EventHandler(this.FormViewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionExercises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClientNames;
        private System.Windows.Forms.Label labelClientNames;
        private System.Windows.Forms.DataGridView dataGridViewClientDetails;
        private System.Windows.Forms.Button buttonGetClientInfo;
        private System.Windows.Forms.DataGridView dataGridViewTrainingSessions;
        private System.Windows.Forms.Label labelClientInfo;
        private System.Windows.Forms.Label labelClientTrainingSessions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxAssignedTrainingSessions;
        private System.Windows.Forms.Label labelPickSession;
        private System.Windows.Forms.DataGridView dataGridViewSessionExercises;
        private System.Windows.Forms.Button buttonDoWorkout;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
    }
}

