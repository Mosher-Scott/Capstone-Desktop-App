
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManagement));
            this.labelClientNames = new System.Windows.Forms.Label();
            this.comboBoxClientNames = new System.Windows.Forms.ComboBox();
            this.labelClientTrainingSessions = new System.Windows.Forms.Label();
            this.dataGridViewTrainingSessions = new System.Windows.Forms.DataGridView();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.dataGridViewWorkoutHistory = new System.Windows.Forms.DataGridView();
            this.labelWorkoutHistory = new System.Windows.Forms.Label();
            this.buttonDeleteWorkout = new System.Windows.Forms.Button();
            this.buttonEditWorkout = new System.Windows.Forms.Button();
            this.groupBoxClientDetails = new System.Windows.Forms.GroupBox();
            this.labelPhoneText = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelStateText = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelActiveText = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            this.labelRegistrationDateText = new System.Windows.Forms.Label();
            this.labelRegistrationDate = new System.Windows.Forms.Label();
            this.labelEmailText = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelZipCodeText = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.labelCityText = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddressText = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastNameText = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstNameText = new System.Windows.Forms.Label();
            this.labelClientFirstName = new System.Windows.Forms.Label();
            this.buttonRefreshClient = new System.Windows.Forms.Button();
            this.buttonModifyAssignedSessions = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutHistory)).BeginInit();
            this.groupBoxClientDetails.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClientNames
            // 
            this.labelClientNames.AutoSize = true;
            this.labelClientNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientNames.Location = new System.Drawing.Point(7, 35);
            this.labelClientNames.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientNames.Name = "labelClientNames";
            this.labelClientNames.Size = new System.Drawing.Size(85, 13);
            this.labelClientNames.TabIndex = 7;
            this.labelClientNames.Text = "Choose Client";
            // 
            // comboBoxClientNames
            // 
            this.comboBoxClientNames.FormattingEnabled = true;
            this.comboBoxClientNames.Location = new System.Drawing.Point(10, 50);
            this.comboBoxClientNames.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxClientNames.Name = "comboBoxClientNames";
            this.comboBoxClientNames.Size = new System.Drawing.Size(140, 21);
            this.comboBoxClientNames.TabIndex = 6;
            this.comboBoxClientNames.SelectedIndexChanged += new System.EventHandler(this.buttonGetClientInfo_Click);
            // 
            // labelClientTrainingSessions
            // 
            this.labelClientTrainingSessions.AutoSize = true;
            this.labelClientTrainingSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientTrainingSessions.Location = new System.Drawing.Point(7, 350);
            this.labelClientTrainingSessions.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientTrainingSessions.Name = "labelClientTrainingSessions";
            this.labelClientTrainingSessions.Size = new System.Drawing.Size(162, 13);
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
            this.dataGridViewTrainingSessions.Location = new System.Drawing.Point(10, 369);
            this.dataGridViewTrainingSessions.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewTrainingSessions.Name = "dataGridViewTrainingSessions";
            this.dataGridViewTrainingSessions.ReadOnly = true;
            this.dataGridViewTrainingSessions.RowHeadersWidth = 102;
            this.dataGridViewTrainingSessions.RowTemplate.Height = 40;
            this.dataGridViewTrainingSessions.Size = new System.Drawing.Size(942, 153);
            this.dataGridViewTrainingSessions.TabIndex = 11;
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditClient.Location = new System.Drawing.Point(10, 305);
            this.buttonEditClient.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(66, 30);
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
            this.buttonDeleteClient.Location = new System.Drawing.Point(86, 305);
            this.buttonDeleteClient.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(84, 30);
            this.buttonDeleteClient.TabIndex = 14;
            this.buttonDeleteClient.Text = "Make Inactive";
            this.buttonDeleteClient.UseVisualStyleBackColor = false;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // dataGridViewWorkoutHistory
            // 
            this.dataGridViewWorkoutHistory.AllowUserToAddRows = false;
            this.dataGridViewWorkoutHistory.AllowUserToDeleteRows = false;
            this.dataGridViewWorkoutHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWorkoutHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewWorkoutHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkoutHistory.Location = new System.Drawing.Point(6, 594);
            this.dataGridViewWorkoutHistory.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewWorkoutHistory.Name = "dataGridViewWorkoutHistory";
            this.dataGridViewWorkoutHistory.ReadOnly = true;
            this.dataGridViewWorkoutHistory.RowHeadersWidth = 102;
            this.dataGridViewWorkoutHistory.RowTemplate.Height = 40;
            this.dataGridViewWorkoutHistory.Size = new System.Drawing.Size(936, 176);
            this.dataGridViewWorkoutHistory.TabIndex = 15;
            // 
            // labelWorkoutHistory
            // 
            this.labelWorkoutHistory.AutoSize = true;
            this.labelWorkoutHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkoutHistory.Location = new System.Drawing.Point(6, 574);
            this.labelWorkoutHistory.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelWorkoutHistory.Name = "labelWorkoutHistory";
            this.labelWorkoutHistory.Size = new System.Drawing.Size(98, 13);
            this.labelWorkoutHistory.TabIndex = 16;
            this.labelWorkoutHistory.Text = "Workout History";
            // 
            // buttonDeleteWorkout
            // 
            this.buttonDeleteWorkout.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDeleteWorkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDeleteWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteWorkout.Location = new System.Drawing.Point(92, 779);
            this.buttonDeleteWorkout.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDeleteWorkout.Name = "buttonDeleteWorkout";
            this.buttonDeleteWorkout.Size = new System.Drawing.Size(92, 30);
            this.buttonDeleteWorkout.TabIndex = 20;
            this.buttonDeleteWorkout.Text = "Delete Workout";
            this.buttonDeleteWorkout.UseVisualStyleBackColor = false;
            // 
            // buttonEditWorkout
            // 
            this.buttonEditWorkout.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditWorkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEditWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditWorkout.Location = new System.Drawing.Point(5, 779);
            this.buttonEditWorkout.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEditWorkout.Name = "buttonEditWorkout";
            this.buttonEditWorkout.Size = new System.Drawing.Size(75, 30);
            this.buttonEditWorkout.TabIndex = 19;
            this.buttonEditWorkout.Text = "View Workout";
            this.buttonEditWorkout.UseVisualStyleBackColor = false;
            this.buttonEditWorkout.Click += new System.EventHandler(this.buttonEditWorkout_Click);
            // 
            // groupBoxClientDetails
            // 
            this.groupBoxClientDetails.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxClientDetails.Controls.Add(this.labelPhoneText);
            this.groupBoxClientDetails.Controls.Add(this.labelPhone);
            this.groupBoxClientDetails.Controls.Add(this.labelStateText);
            this.groupBoxClientDetails.Controls.Add(this.labelState);
            this.groupBoxClientDetails.Controls.Add(this.labelActiveText);
            this.groupBoxClientDetails.Controls.Add(this.labelActive);
            this.groupBoxClientDetails.Controls.Add(this.labelRegistrationDateText);
            this.groupBoxClientDetails.Controls.Add(this.labelRegistrationDate);
            this.groupBoxClientDetails.Controls.Add(this.labelEmailText);
            this.groupBoxClientDetails.Controls.Add(this.labelEmail);
            this.groupBoxClientDetails.Controls.Add(this.labelZipCodeText);
            this.groupBoxClientDetails.Controls.Add(this.labelZipCode);
            this.groupBoxClientDetails.Controls.Add(this.labelCityText);
            this.groupBoxClientDetails.Controls.Add(this.labelCity);
            this.groupBoxClientDetails.Controls.Add(this.labelAddressText);
            this.groupBoxClientDetails.Controls.Add(this.labelAddress);
            this.groupBoxClientDetails.Controls.Add(this.labelLastNameText);
            this.groupBoxClientDetails.Controls.Add(this.labelLastName);
            this.groupBoxClientDetails.Controls.Add(this.labelFirstNameText);
            this.groupBoxClientDetails.Controls.Add(this.labelClientFirstName);
            this.groupBoxClientDetails.Location = new System.Drawing.Point(10, 78);
            this.groupBoxClientDetails.Margin = new System.Windows.Forms.Padding(1);
            this.groupBoxClientDetails.Name = "groupBoxClientDetails";
            this.groupBoxClientDetails.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxClientDetails.Size = new System.Drawing.Size(376, 219);
            this.groupBoxClientDetails.TabIndex = 21;
            this.groupBoxClientDetails.TabStop = false;
            this.groupBoxClientDetails.Text = "Client Info";
            // 
            // labelPhoneText
            // 
            this.labelPhoneText.AutoSize = true;
            this.labelPhoneText.Location = new System.Drawing.Point(72, 156);
            this.labelPhoneText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPhoneText.Name = "labelPhoneText";
            this.labelPhoneText.Size = new System.Drawing.Size(37, 13);
            this.labelPhoneText.TabIndex = 19;
            this.labelPhoneText.Text = "          ";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(26, 156);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(47, 13);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Phone:";
            // 
            // labelStateText
            // 
            this.labelStateText.AutoSize = true;
            this.labelStateText.Location = new System.Drawing.Point(74, 95);
            this.labelStateText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStateText.Name = "labelStateText";
            this.labelStateText.Size = new System.Drawing.Size(40, 13);
            this.labelStateText.TabIndex = 17;
            this.labelStateText.Text = "           ";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(33, 95);
            this.labelState.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(41, 13);
            this.labelState.TabIndex = 16;
            this.labelState.Text = "State:";
            // 
            // labelActiveText
            // 
            this.labelActiveText.AutoSize = true;
            this.labelActiveText.Location = new System.Drawing.Point(74, 196);
            this.labelActiveText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelActiveText.Name = "labelActiveText";
            this.labelActiveText.Size = new System.Drawing.Size(46, 13);
            this.labelActiveText.TabIndex = 15;
            this.labelActiveText.Text = "             ";
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActive.Location = new System.Drawing.Point(28, 196);
            this.labelActive.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(47, 13);
            this.labelActive.TabIndex = 14;
            this.labelActive.Text = "Active:";
            // 
            // labelRegistrationDateText
            // 
            this.labelRegistrationDateText.AutoSize = true;
            this.labelRegistrationDateText.Location = new System.Drawing.Point(74, 177);
            this.labelRegistrationDateText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRegistrationDateText.Name = "labelRegistrationDateText";
            this.labelRegistrationDateText.Size = new System.Drawing.Size(34, 13);
            this.labelRegistrationDateText.TabIndex = 13;
            this.labelRegistrationDateText.Text = "         ";
            // 
            // labelRegistrationDate
            // 
            this.labelRegistrationDate.AutoSize = true;
            this.labelRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationDate.Location = new System.Drawing.Point(11, 177);
            this.labelRegistrationDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRegistrationDate.Name = "labelRegistrationDate";
            this.labelRegistrationDate.Size = new System.Drawing.Size(65, 13);
            this.labelRegistrationDate.TabIndex = 12;
            this.labelRegistrationDate.Text = "Reg Date:";
            // 
            // labelEmailText
            // 
            this.labelEmailText.AutoSize = true;
            this.labelEmailText.Location = new System.Drawing.Point(74, 134);
            this.labelEmailText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmailText.Name = "labelEmailText";
            this.labelEmailText.Size = new System.Drawing.Size(37, 13);
            this.labelEmailText.TabIndex = 11;
            this.labelEmailText.Text = "          ";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(31, 134);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 13);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email:";
            // 
            // labelZipCodeText
            // 
            this.labelZipCodeText.AutoSize = true;
            this.labelZipCodeText.Location = new System.Drawing.Point(74, 114);
            this.labelZipCodeText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelZipCodeText.Name = "labelZipCodeText";
            this.labelZipCodeText.Size = new System.Drawing.Size(43, 13);
            this.labelZipCodeText.TabIndex = 9;
            this.labelZipCodeText.Text = "            ";
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCode.Location = new System.Drawing.Point(18, 114);
            this.labelZipCode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(57, 13);
            this.labelZipCode.TabIndex = 8;
            this.labelZipCode.Text = "Zipcode:";
            // 
            // labelCityText
            // 
            this.labelCityText.AutoSize = true;
            this.labelCityText.Location = new System.Drawing.Point(74, 76);
            this.labelCityText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCityText.Name = "labelCityText";
            this.labelCityText.Size = new System.Drawing.Size(46, 13);
            this.labelCityText.TabIndex = 7;
            this.labelCityText.Text = "             ";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(40, 76);
            this.labelCity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(32, 13);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "City:";
            // 
            // labelAddressText
            // 
            this.labelAddressText.AutoSize = true;
            this.labelAddressText.Location = new System.Drawing.Point(74, 57);
            this.labelAddressText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAddressText.Name = "labelAddressText";
            this.labelAddressText.Size = new System.Drawing.Size(43, 13);
            this.labelAddressText.TabIndex = 5;
            this.labelAddressText.Text = "            ";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(17, 57);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(56, 13);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address:";
            // 
            // labelLastNameText
            // 
            this.labelLastNameText.AutoSize = true;
            this.labelLastNameText.Location = new System.Drawing.Point(74, 38);
            this.labelLastNameText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLastNameText.Name = "labelLastNameText";
            this.labelLastNameText.Size = new System.Drawing.Size(52, 13);
            this.labelLastNameText.TabIndex = 3;
            this.labelLastNameText.Text = "               ";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(4, 38);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(71, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstNameText
            // 
            this.labelFirstNameText.AutoSize = true;
            this.labelFirstNameText.Location = new System.Drawing.Point(74, 18);
            this.labelFirstNameText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelFirstNameText.Name = "labelFirstNameText";
            this.labelFirstNameText.Size = new System.Drawing.Size(16, 13);
            this.labelFirstNameText.TabIndex = 1;
            this.labelFirstNameText.Text = "   ";
            // 
            // labelClientFirstName
            // 
            this.labelClientFirstName.AutoSize = true;
            this.labelClientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientFirstName.Location = new System.Drawing.Point(3, 18);
            this.labelClientFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelClientFirstName.Name = "labelClientFirstName";
            this.labelClientFirstName.Size = new System.Drawing.Size(71, 13);
            this.labelClientFirstName.TabIndex = 0;
            this.labelClientFirstName.Text = "First Name:";
            // 
            // buttonRefreshClient
            // 
            this.buttonRefreshClient.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonRefreshClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefreshClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefreshClient.Location = new System.Drawing.Point(170, 44);
            this.buttonRefreshClient.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRefreshClient.Name = "buttonRefreshClient";
            this.buttonRefreshClient.Size = new System.Drawing.Size(66, 30);
            this.buttonRefreshClient.TabIndex = 22;
            this.buttonRefreshClient.Text = "Refresh";
            this.buttonRefreshClient.UseVisualStyleBackColor = false;
            this.buttonRefreshClient.Click += new System.EventHandler(this.buttonRefreshClient_Click);
            // 
            // buttonModifyAssignedSessions
            // 
            this.buttonModifyAssignedSessions.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonModifyAssignedSessions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonModifyAssignedSessions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifyAssignedSessions.Location = new System.Drawing.Point(10, 529);
            this.buttonModifyAssignedSessions.Margin = new System.Windows.Forms.Padding(1);
            this.buttonModifyAssignedSessions.Name = "buttonModifyAssignedSessions";
            this.buttonModifyAssignedSessions.Size = new System.Drawing.Size(148, 30);
            this.buttonModifyAssignedSessions.TabIndex = 23;
            this.buttonModifyAssignedSessions.Text = "Modify Assigned Sessions";
            this.buttonModifyAssignedSessions.UseVisualStyleBackColor = false;
            this.buttonModifyAssignedSessions.Click += new System.EventHandler(this.buttonModifyAssignedSessions_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip1.TabIndex = 24;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddClient.Location = new System.Drawing.Point(182, 305);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(66, 30);
            this.buttonAddClient.TabIndex = 25;
            this.buttonAddClient.Text = "Add Client";
            this.buttonAddClient.UseVisualStyleBackColor = false;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1132, 625);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.buttonModifyAssignedSessions);
            this.Controls.Add(this.buttonRefreshClient);
            this.Controls.Add(this.groupBoxClientDetails);
            this.Controls.Add(this.buttonDeleteWorkout);
            this.Controls.Add(this.buttonEditWorkout);
            this.Controls.Add(this.labelWorkoutHistory);
            this.Controls.Add(this.dataGridViewWorkoutHistory);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.labelClientTrainingSessions);
            this.Controls.Add(this.dataGridViewTrainingSessions);
            this.Controls.Add(this.labelClientNames);
            this.Controls.Add(this.comboBoxClientNames);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ClientManagement";
            this.Text = "Client Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainingSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkoutHistory)).EndInit();
            this.groupBoxClientDetails.ResumeLayout(false);
            this.groupBoxClientDetails.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClientNames;
        private System.Windows.Forms.ComboBox comboBoxClientNames;
        private System.Windows.Forms.Label labelClientTrainingSessions;
        private System.Windows.Forms.DataGridView dataGridViewTrainingSessions;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.DataGridView dataGridViewWorkoutHistory;
        private System.Windows.Forms.Label labelWorkoutHistory;
        private System.Windows.Forms.Button buttonDeleteWorkout;
        private System.Windows.Forms.Button buttonEditWorkout;
        private System.Windows.Forms.GroupBox groupBoxClientDetails;
        private System.Windows.Forms.Label labelLastNameText;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstNameText;
        private System.Windows.Forms.Label labelClientFirstName;
        private System.Windows.Forms.Label labelAddressText;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelZipCodeText;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Label labelCityText;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelEmailText;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelActiveText;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.Label labelRegistrationDateText;
        private System.Windows.Forms.Label labelRegistrationDate;
        private System.Windows.Forms.Label labelStateText;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelPhoneText;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button buttonRefreshClient;
        private System.Windows.Forms.Button buttonModifyAssignedSessions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddClient;
    }
}