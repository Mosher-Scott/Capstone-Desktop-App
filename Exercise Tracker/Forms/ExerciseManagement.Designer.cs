
namespace Exercise_Tracker.Forms
{
    partial class ExerciseManagement
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
            this.buttonAddNewExercise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddNewExercise
            // 
            this.buttonAddNewExercise.Location = new System.Drawing.Point(46, 54);
            this.buttonAddNewExercise.Name = "buttonAddNewExercise";
            this.buttonAddNewExercise.Size = new System.Drawing.Size(212, 133);
            this.buttonAddNewExercise.TabIndex = 2;
            this.buttonAddNewExercise.Text = "Add New Exercise";
            this.buttonAddNewExercise.UseVisualStyleBackColor = true;
            this.buttonAddNewExercise.Click += new System.EventHandler(this.buttonAddNewExercise_Click);
            // 
            // ExerciseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddNewExercise);
            this.Name = "ExerciseManagement";
            this.Text = "ExerciseManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewExercise;
    }
}