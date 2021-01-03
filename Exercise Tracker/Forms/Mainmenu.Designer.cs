
namespace Exercise_Tracker
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessionExercises)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClientNames
            // 
            this.comboBoxClientNames.FormattingEnabled = true;
            this.comboBoxClientNames.Location = new System.Drawing.Point(38, 143);
            this.comboBoxClientNames.Name = "comboBoxClientNames";
            this.comboBoxClientNames.Size = new System.Drawing.Size(345, 39);
            this.comboBoxClientNames.TabIndex = 0;
            // 
            // labelClientNames
            // 
            this.labelClientNames.AutoSize = true;
            this.labelClientNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNames.Location = new System.Drawing.Point(32, 105);
            this.labelClientNames.Name = "labelClientNames";
            this.labelClientNames.Size = new System.Drawing.Size(207, 32);
            this.labelClientNames.TabIndex = 1;
            this.labelClientNames.Text = "Choose Client";
            // 
            // dataGridViewClientDetails
            // 
            this.dataGridViewClientDetails.AllowUserToAddRows = false;
            this.dataGridViewClientDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClientDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientDetails.Location = new System.Drawing.Point(38, 254);
            this.dataGridViewClientDetails.Name = "dataGridViewClientDetails";
            this.dataGridViewClientDetails.ReadOnly = true;
            this.dataGridViewClientDetails.RowHeadersWidth = 102;
            this.dataGridViewClientDetails.RowTemplate.Height = 40;
            this.dataGridViewClientDetails.Size = new System.Drawing.Size(2368, 162);
            this.dataGridViewClientDetails.TabIndex = 2;
            // 
            // buttonGetClientInfo
            // 
            this.buttonGetClientInfo.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonGetClientInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGetClientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGetClientInfo.Location = new System.Drawing.Point(425, 143);
            this.buttonGetClientInfo.Name = "buttonGetClientInfo";
            this.buttonGetClientInfo.Size = new System.Drawing.Size(164, 76);
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
            this.dataGridViewTrainingSessions.Location = new System.Drawing.Point(38, 554);
            this.dataGridViewTrainingSessions.Name = "dataGridViewTrainingSessions";
            this.dataGridViewTrainingSessions.ReadOnly = true;
            this.dataGridViewTrainingSessions.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessions.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessions.Size = new System.Drawing.Size(2632, 469);
            this.dataGridViewTrainingSessions.TabIndex = 4;
            // 
            // labelClientInfo
            // 
            this.labelClientInfo.AutoSize = true;
            this.labelClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientInfo.Location = new System.Drawing.Point(38, 216);
            this.labelClientInfo.Name = "labelClientInfo";
            this.labelClientInfo.Size = new System.Drawing.Size(154, 32);
            this.labelClientInfo.TabIndex = 5;
            this.labelClientInfo.Text = "Client Info";
            // 
            // labelClientTrainingSessions
            // 
            this.labelClientTrainingSessions.AutoSize = true;
            this.labelClientTrainingSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientTrainingSessions.Location = new System.Drawing.Point(38, 516);
            this.labelClientTrainingSessions.Name = "labelClientTrainingSessions";
            this.labelClientTrainingSessions.Size = new System.Drawing.Size(259, 32);
            this.labelClientTrainingSessions.TabIndex = 6;
            this.labelClientTrainingSessions.Text = "Training Sessions";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2694, 60);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 56);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(230, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboBoxAssignedTrainingSessions
            // 
            this.comboBoxAssignedTrainingSessions.FormattingEnabled = true;
            this.comboBoxAssignedTrainingSessions.Location = new System.Drawing.Point(38, 1129);
            this.comboBoxAssignedTrainingSessions.Name = "comboBoxAssignedTrainingSessions";
            this.comboBoxAssignedTrainingSessions.Size = new System.Drawing.Size(379, 39);
            this.comboBoxAssignedTrainingSessions.TabIndex = 8;
            this.comboBoxAssignedTrainingSessions.SelectedIndexChanged += new System.EventHandler(this.DisplaySessionExercieses);
            // 
            // labelPickSession
            // 
            this.labelPickSession.AutoSize = true;
            this.labelPickSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickSession.Location = new System.Drawing.Point(38, 1091);
            this.labelPickSession.Name = "labelPickSession";
            this.labelPickSession.Size = new System.Drawing.Size(303, 32);
            this.labelPickSession.TabIndex = 9;
            this.labelPickSession.Text = "Training Session Info";
            // 
            // dataGridViewSessionExercises
            // 
            this.dataGridViewSessionExercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSessionExercises.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSessionExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessionExercises.Location = new System.Drawing.Point(38, 1195);
            this.dataGridViewSessionExercises.Name = "dataGridViewSessionExercises";
            this.dataGridViewSessionExercises.RowHeadersWidth = 102;
            this.dataGridViewSessionExercises.RowTemplate.Height = 40;
            this.dataGridViewSessionExercises.Size = new System.Drawing.Size(2632, 541);
            this.dataGridViewSessionExercises.TabIndex = 10;
            // 
            // buttonDoWorkout
            // 
            this.buttonDoWorkout.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDoWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDoWorkout.Location = new System.Drawing.Point(460, 1109);
            this.buttonDoWorkout.Name = "buttonDoWorkout";
            this.buttonDoWorkout.Size = new System.Drawing.Size(240, 59);
            this.buttonDoWorkout.TabIndex = 11;
            this.buttonDoWorkout.Text = "Do Workout";
            this.buttonDoWorkout.UseVisualStyleBackColor = false;
            this.buttonDoWorkout.Click += new System.EventHandler(this.buttonDoWorkout_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2694, 1747);
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
            this.Name = "FormMainMenu";
            this.Text = "Exercise Tracker";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
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
    }
}

