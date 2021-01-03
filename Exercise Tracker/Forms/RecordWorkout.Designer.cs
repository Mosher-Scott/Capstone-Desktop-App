
namespace Exercise_Tracker.Forms
{
    public partial class RecordWorkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordWorkout));
            this.labelSessionName = new System.Windows.Forms.Label();
            this.dataGridViewExercises = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveWorkout = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExerciseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSessionName
            // 
            this.labelSessionName.AutoSize = true;
            this.labelSessionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionName.Location = new System.Drawing.Point(25, 65);
            this.labelSessionName.Name = "labelSessionName";
            this.labelSessionName.Size = new System.Drawing.Size(359, 58);
            this.labelSessionName.TabIndex = 1;
            this.labelSessionName.Text = "Workout Name";
            // 
            // dataGridViewExercises
            // 
            this.dataGridViewExercises.AllowUserToAddRows = false;
            this.dataGridViewExercises.AllowUserToDeleteRows = false;
            this.dataGridViewExercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExercises.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercises.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ExerciseName});
            this.dataGridViewExercises.Location = new System.Drawing.Point(1074, 126);
            this.dataGridViewExercises.Name = "dataGridViewExercises";
            this.dataGridViewExercises.ReadOnly = true;
            this.dataGridViewExercises.RowHeadersWidth = 102;
            this.dataGridViewExercises.RowTemplate.Height = 40;
            this.dataGridViewExercises.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewExercises.Size = new System.Drawing.Size(1424, 815);
            this.dataGridViewExercises.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1707, 49);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.closeWindowToolStripMenuItem.Text = "Close Window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // buttonSaveWorkout
            // 
            this.buttonSaveWorkout.Location = new System.Drawing.Point(35, 126);
            this.buttonSaveWorkout.Name = "buttonSaveWorkout";
            this.buttonSaveWorkout.Size = new System.Drawing.Size(196, 88);
            this.buttonSaveWorkout.TabIndex = 4;
            this.buttonSaveWorkout.Text = "Save Workout";
            this.buttonSaveWorkout.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(35, 239);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(196, 88);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 12;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 96;
            // 
            // ExerciseName
            // 
            this.ExerciseName.HeaderText = "Name";
            this.ExerciseName.MinimumWidth = 12;
            this.ExerciseName.Name = "ExerciseName";
            this.ExerciseName.ReadOnly = true;
            this.ExerciseName.Width = 144;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // RecordWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1707, 1252);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveWorkout);
            this.Controls.Add(this.dataGridViewExercises);
            this.Controls.Add(this.labelSessionName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RecordWorkout";
            this.Text = "Record Workout";
            this.Load += new System.EventHandler(this.RecordWorkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSessionName;
        private System.Windows.Forms.DataGridView dataGridViewExercises;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveWorkout;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExerciseName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}