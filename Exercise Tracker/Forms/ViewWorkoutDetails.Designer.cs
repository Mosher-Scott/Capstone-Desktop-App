
namespace Exercise_Tracker.Forms
{
    partial class ViewWorkoutDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewWorkoutDetails));
            this.groupBoxWorkoutDetails = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelWorkoutId = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelExercises = new System.Windows.Forms.Label();
            this.dataGridViewExercises = new System.Windows.Forms.DataGridView();
            this.groupBoxWorkoutDetails.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).BeginInit();
            this.SuspendLayout();
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
            this.groupBoxWorkoutDetails.Location = new System.Drawing.Point(23, 117);
            this.groupBoxWorkoutDetails.Name = "groupBoxWorkoutDetails";
            this.groupBoxWorkoutDetails.Size = new System.Drawing.Size(1000, 408);
            this.groupBoxWorkoutDetails.TabIndex = 13;
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
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(215, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(416, 38);
            this.textBoxName.TabIndex = 14;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Location = new System.Drawing.Point(211, 150);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(420, 38);
            this.textBoxDate.TabIndex = 9;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(211, 200);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(711, 154);
            this.textBoxDescription.TabIndex = 7;
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
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(214, 48);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(39, 38);
            this.textBoxId.TabIndex = 4;
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1794, 49);
            this.menuStrip2.TabIndex = 14;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 45);
            this.toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(448, 54);
            this.toolStripMenuItem2.Text = "Exit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(192, 45);
            this.toolStripMenuItem3.Text = "Close Form";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExercises.Location = new System.Drawing.Point(26, 603);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(296, 32);
            this.labelExercises.TabIndex = 16;
            this.labelExercises.Text = "Exercises Performed";
            // 
            // dataGridViewExercises
            // 
            this.dataGridViewExercises.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercises.Location = new System.Drawing.Point(23, 655);
            this.dataGridViewExercises.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewExercises.Name = "dataGridViewExercises";
            this.dataGridViewExercises.RowHeadersWidth = 102;
            this.dataGridViewExercises.RowTemplate.Height = 40;
            this.dataGridViewExercises.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewExercises.Size = new System.Drawing.Size(1747, 776);
            this.dataGridViewExercises.TabIndex = 15;
            // 
            // ViewWorkoutDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1794, 1441);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.dataGridViewExercises);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBoxWorkoutDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewWorkoutDetails";
            this.Text = "Workout Details";
            this.groupBoxWorkoutDetails.ResumeLayout(false);
            this.groupBoxWorkoutDetails.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWorkoutDetails;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelWorkoutId;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.DataGridView dataGridViewExercises;
    }
}