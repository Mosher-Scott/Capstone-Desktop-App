
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
            this.buttonSaveWorkout = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelWeightAndTimeDefault = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSessionName
            // 
            this.labelSessionName.AutoSize = true;
            this.labelSessionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionName.Location = new System.Drawing.Point(24, 96);
            this.labelSessionName.Name = "labelSessionName";
            this.labelSessionName.Size = new System.Drawing.Size(359, 58);
            this.labelSessionName.TabIndex = 1;
            this.labelSessionName.Text = "Workout Name";
            // 
            // dataGridViewExercises
            // 
            this.dataGridViewExercises.AllowUserToAddRows = false;
            this.dataGridViewExercises.AllowUserToDeleteRows = false;
            this.dataGridViewExercises.AllowUserToOrderColumns = true;
            this.dataGridViewExercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewExercises.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExercises.ColumnHeadersHeight = 58;
            this.dataGridViewExercises.Location = new System.Drawing.Point(236, 163);
            this.dataGridViewExercises.MinimumSize = new System.Drawing.Size(800, 1023);
            this.dataGridViewExercises.Name = "dataGridViewExercises";
            this.dataGridViewExercises.RowHeadersWidth = 102;
            this.dataGridViewExercises.RowTemplate.Height = 40;
            this.dataGridViewExercises.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewExercises.Size = new System.Drawing.Size(1514, 1023);
            this.dataGridViewExercises.TabIndex = 2;
            // 
            // buttonSaveWorkout
            // 
            this.buttonSaveWorkout.Location = new System.Drawing.Point(34, 162);
            this.buttonSaveWorkout.Name = "buttonSaveWorkout";
            this.buttonSaveWorkout.Size = new System.Drawing.Size(196, 88);
            this.buttonSaveWorkout.TabIndex = 4;
            this.buttonSaveWorkout.Text = "Save Workout";
            this.buttonSaveWorkout.UseVisualStyleBackColor = true;
            this.buttonSaveWorkout.Click += new System.EventHandler(this.buttonSaveWorkout_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(34, 275);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(196, 88);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelWeightAndTimeDefault
            // 
            this.labelWeightAndTimeDefault.AutoSize = true;
            this.labelWeightAndTimeDefault.Location = new System.Drawing.Point(1049, 119);
            this.labelWeightAndTimeDefault.Name = "labelWeightAndTimeDefault";
            this.labelWeightAndTimeDefault.Size = new System.Drawing.Size(443, 32);
            this.labelWeightAndTimeDefault.TabIndex = 6;
            this.labelWeightAndTimeDefault.Text = "Weight and Time use 0 if not used";
            // 
            // RecordWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(2590, 1440);
            this.Controls.Add(this.labelWeightAndTimeDefault);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveWorkout);
            this.Controls.Add(this.dataGridViewExercises);
            this.Controls.Add(this.labelSessionName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecordWorkout";
            this.Text = "Record Workout";
            this.Load += new System.EventHandler(this.RecordWorkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSessionName;
        private System.Windows.Forms.DataGridView dataGridViewExercises;
        private System.Windows.Forms.Button buttonSaveWorkout;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelWeightAndTimeDefault;
    }
}