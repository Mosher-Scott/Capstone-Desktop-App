
namespace Exercise_Tracker.Forms
{
    partial class ViewClientWorkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewClientWorkout));
            this.dataGridViewExercises = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelWorkoutId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelExercises = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxWorkoutDetails = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxWorkoutDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewExercises
            // 
            this.dataGridViewExercises.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercises.Location = new System.Drawing.Point(27, 473);
            this.dataGridViewExercises.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewExercises.Name = "dataGridViewExercises";
            this.dataGridViewExercises.RowHeadersWidth = 102;
            this.dataGridViewExercises.RowTemplate.Height = 40;
            this.dataGridViewExercises.Size = new System.Drawing.Size(1558, 578);
            this.dataGridViewExercises.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(27, 1089);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(152, 77);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelWorkoutId
            // 
            this.labelWorkoutId.AutoSize = true;
            this.labelWorkoutId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkoutId.Location = new System.Drawing.Point(149, 50);
            this.labelWorkoutId.Name = "labelWorkoutId";
            this.labelWorkoutId.Size = new System.Drawing.Size(53, 32);
            this.labelWorkoutId.TabIndex = 2;
            this.labelWorkoutId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(214, 48);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(39, 39);
            this.textBoxId.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(21, 203);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(178, 32);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(211, 200);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(621, 66);
            this.textBoxDescription.TabIndex = 7;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Location = new System.Drawing.Point(211, 150);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(258, 39);
            this.textBoxDate.TabIndex = 9;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(111, 153);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(88, 32);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date:";
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Location = new System.Drawing.Point(32, 422);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(296, 32);
            this.labelExercises.TabIndex = 10;
            this.labelExercises.Text = "Exercises Performed";
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1651, 49);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
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
            // groupBoxWorkoutDetails
            // 
            this.groupBoxWorkoutDetails.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxWorkoutDetails.Controls.Add(this.labelName);
            this.groupBoxWorkoutDetails.Controls.Add(this.labelDate);
            this.groupBoxWorkoutDetails.Controls.Add(this.textBoxName);
            this.groupBoxWorkoutDetails.Controls.Add(this.textBoxDate);
            this.groupBoxWorkoutDetails.Controls.Add(this.textBoxDescription);
            this.groupBoxWorkoutDetails.Controls.Add(this.labelWorkoutId);
            this.groupBoxWorkoutDetails.Controls.Add(this.labelDescription);
            this.groupBoxWorkoutDetails.Controls.Add(this.textBoxId);
            this.groupBoxWorkoutDetails.Location = new System.Drawing.Point(633, 99);
            this.groupBoxWorkoutDetails.Name = "groupBoxWorkoutDetails";
            this.groupBoxWorkoutDetails.Size = new System.Drawing.Size(894, 304);
            this.groupBoxWorkoutDetails.TabIndex = 12;
            this.groupBoxWorkoutDetails.TabStop = false;
            this.groupBoxWorkoutDetails.Text = "Workout Information";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(103, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(103, 32);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(215, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(258, 39);
            this.textBoxName.TabIndex = 14;
            // 
            // ViewClientWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1651, 1413);
            this.Controls.Add(this.groupBoxWorkoutDetails);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridViewExercises);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ViewClientWorkout";
            this.Text = "View Client Workout";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxWorkoutDetails.ResumeLayout(false);
            this.groupBoxWorkoutDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExercises;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelWorkoutId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxWorkoutDetails;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}