
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyAssignedTrainingSessions));
            this.labelClientId = new System.Windows.Forms.Label();
            this.dataGridViewTrainingSessions = new System.Windows.Forms.DataGridView();
            this.comboBoxAllTrainingSessions = new System.Windows.Forms.ComboBox();
            this.labelAssignedSessions = new System.Windows.Forms.Label();
            this.labelAddNewSession = new System.Windows.Forms.Label();
            this.groupBoxSessionInfo = new System.Windows.Forms.GroupBox();
            this.textBoxReps = new System.Windows.Forms.TextBox();
            this.textBoxSets = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSessionName = new System.Windows.Forms.TextBox();
            this.labelSets = new System.Windows.Forms.Label();
            this.labelReps = new System.Windows.Forms.Label();
            this.labelSessionDescription = new System.Windows.Forms.Label();
            this.labelSessionname = new System.Windows.Forms.Label();
            this.buttonAddSession = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonDeleteRow = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).BeginInit();
            this.groupBoxSessionInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(29, 43);
            this.labelClientId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(50, 13);
            this.labelClientId.TabIndex = 0;
            this.labelClientId.Text = "Client ID:";
            // 
            // dataGridViewTrainingSessions
            // 
            this.dataGridViewTrainingSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainingSessions.Location = new System.Drawing.Point(31, 87);
            this.dataGridViewTrainingSessions.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewTrainingSessions.Name = "dataGridViewTrainingSessions";
            this.dataGridViewTrainingSessions.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessions.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTrainingSessions.Size = new System.Drawing.Size(606, 220);
            this.dataGridViewTrainingSessions.TabIndex = 1;
            // 
            // comboBoxAllTrainingSessions
            // 
            this.comboBoxAllTrainingSessions.FormattingEnabled = true;
            this.comboBoxAllTrainingSessions.Location = new System.Drawing.Point(31, 341);
            this.comboBoxAllTrainingSessions.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxAllTrainingSessions.Name = "comboBoxAllTrainingSessions";
            this.comboBoxAllTrainingSessions.Size = new System.Drawing.Size(197, 21);
            this.comboBoxAllTrainingSessions.TabIndex = 2;
            this.comboBoxAllTrainingSessions.SelectedIndexChanged += new System.EventHandler(this.ViewTrainingSessionDetails);
            // 
            // labelAssignedSessions
            // 
            this.labelAssignedSessions.AutoSize = true;
            this.labelAssignedSessions.Location = new System.Drawing.Point(29, 65);
            this.labelAssignedSessions.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAssignedSessions.Name = "labelAssignedSessions";
            this.labelAssignedSessions.Size = new System.Drawing.Size(136, 13);
            this.labelAssignedSessions.TabIndex = 3;
            this.labelAssignedSessions.Text = "Assigned Training Sessions";
            // 
            // labelAddNewSession
            // 
            this.labelAddNewSession.AutoSize = true;
            this.labelAddNewSession.Location = new System.Drawing.Point(31, 322);
            this.labelAddNewSession.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAddNewSession.Name = "labelAddNewSession";
            this.labelAddNewSession.Size = new System.Drawing.Size(91, 13);
            this.labelAddNewSession.TabIndex = 4;
            this.labelAddNewSession.Text = "Add New Session";
            // 
            // groupBoxSessionInfo
            // 
            this.groupBoxSessionInfo.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxSessionInfo.Controls.Add(this.textBoxReps);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxSets);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxDescription);
            this.groupBoxSessionInfo.Controls.Add(this.textBoxSessionName);
            this.groupBoxSessionInfo.Controls.Add(this.labelSets);
            this.groupBoxSessionInfo.Controls.Add(this.labelReps);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionDescription);
            this.groupBoxSessionInfo.Controls.Add(this.labelSessionname);
            this.groupBoxSessionInfo.Location = new System.Drawing.Point(31, 376);
            this.groupBoxSessionInfo.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxSessionInfo.Name = "groupBoxSessionInfo";
            this.groupBoxSessionInfo.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxSessionInfo.Size = new System.Drawing.Size(537, 252);
            this.groupBoxSessionInfo.TabIndex = 5;
            this.groupBoxSessionInfo.TabStop = false;
            this.groupBoxSessionInfo.Text = "Training Session Info";
            // 
            // textBoxReps
            // 
            this.textBoxReps.Enabled = false;
            this.textBoxReps.Location = new System.Drawing.Point(50, 221);
            this.textBoxReps.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxReps.Name = "textBoxReps";
            this.textBoxReps.Size = new System.Drawing.Size(30, 20);
            this.textBoxReps.TabIndex = 7;
            // 
            // textBoxSets
            // 
            this.textBoxSets.Enabled = false;
            this.textBoxSets.Location = new System.Drawing.Point(50, 197);
            this.textBoxSets.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxSets.Name = "textBoxSets";
            this.textBoxSets.Size = new System.Drawing.Size(30, 20);
            this.textBoxSets.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(11, 96);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(414, 97);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxSessionName
            // 
            this.textBoxSessionName.Enabled = false;
            this.textBoxSessionName.Location = new System.Drawing.Point(11, 43);
            this.textBoxSessionName.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxSessionName.Name = "textBoxSessionName";
            this.textBoxSessionName.Size = new System.Drawing.Size(220, 20);
            this.textBoxSessionName.TabIndex = 4;
            // 
            // labelSets
            // 
            this.labelSets.AutoSize = true;
            this.labelSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSets.Location = new System.Drawing.Point(11, 198);
            this.labelSets.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSets.Name = "labelSets";
            this.labelSets.Size = new System.Drawing.Size(36, 13);
            this.labelSets.TabIndex = 3;
            this.labelSets.Text = "Sets:";
            // 
            // labelReps
            // 
            this.labelReps.AutoSize = true;
            this.labelReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReps.Location = new System.Drawing.Point(11, 221);
            this.labelReps.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelReps.Name = "labelReps";
            this.labelReps.Size = new System.Drawing.Size(40, 13);
            this.labelReps.TabIndex = 2;
            this.labelReps.Text = "Reps:";
            // 
            // labelSessionDescription
            // 
            this.labelSessionDescription.AutoSize = true;
            this.labelSessionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionDescription.Location = new System.Drawing.Point(11, 74);
            this.labelSessionDescription.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSessionDescription.Name = "labelSessionDescription";
            this.labelSessionDescription.Size = new System.Drawing.Size(75, 13);
            this.labelSessionDescription.TabIndex = 1;
            this.labelSessionDescription.Text = "Description:";
            // 
            // labelSessionname
            // 
            this.labelSessionname.AutoSize = true;
            this.labelSessionname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionname.Location = new System.Drawing.Point(11, 26);
            this.labelSessionname.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSessionname.Name = "labelSessionname";
            this.labelSessionname.Size = new System.Drawing.Size(91, 13);
            this.labelSessionname.TabIndex = 0;
            this.labelSessionname.Text = "Session Name:";
            // 
            // buttonAddSession
            // 
            this.buttonAddSession.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddSession.Location = new System.Drawing.Point(239, 327);
            this.buttonAddSession.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAddSession.Name = "buttonAddSession";
            this.buttonAddSession.Size = new System.Drawing.Size(53, 36);
            this.buttonAddSession.TabIndex = 8;
            this.buttonAddSession.Text = "Add Session";
            this.buttonAddSession.UseVisualStyleBackColor = false;
            this.buttonAddSession.Click += new System.EventHandler(this.buttonAddSession_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveChanges.Location = new System.Drawing.Point(304, 327);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(53, 36);
            this.buttonSaveChanges.TabIndex = 9;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonDeleteRow
            // 
            this.buttonDeleteRow.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteRow.Location = new System.Drawing.Point(367, 327);
            this.buttonDeleteRow.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDeleteRow.Name = "buttonDeleteRow";
            this.buttonDeleteRow.Size = new System.Drawing.Size(62, 36);
            this.buttonDeleteRow.TabIndex = 10;
            this.buttonDeleteRow.Text = "Delete Selected Row";
            this.buttonDeleteRow.UseVisualStyleBackColor = false;
            this.buttonDeleteRow.Click += new System.EventHandler(this.buttonDeleteRow_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCloseForm.Location = new System.Drawing.Point(442, 326);
            this.buttonCloseForm.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(65, 37);
            this.buttonCloseForm.TabIndex = 11;
            this.buttonCloseForm.Text = "Finished";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // ModifyAssignedTrainingSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(694, 644);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonDeleteRow);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonAddSession);
            this.Controls.Add(this.groupBoxSessionInfo);
            this.Controls.Add(this.labelAddNewSession);
            this.Controls.Add(this.labelAssignedSessions);
            this.Controls.Add(this.comboBoxAllTrainingSessions);
            this.Controls.Add(this.dataGridViewTrainingSessions);
            this.Controls.Add(this.labelClientId);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ModifyAssignedTrainingSessions";
            this.Text = "Modify Assigned Training Sessions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).EndInit();
            this.groupBoxSessionInfo.ResumeLayout(false);
            this.groupBoxSessionInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonDeleteRow;
        private System.Windows.Forms.Button buttonCloseForm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
    }
}