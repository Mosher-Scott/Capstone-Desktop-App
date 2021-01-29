
namespace Exercise_Tracker.Forms
{
    partial class EditClient
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
            this.dataGridViewClientData = new System.Windows.Forms.DataGridView();
            this.buttonSaveEdits = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientData
            // 
            this.dataGridViewClientData.AllowUserToAddRows = false;
            this.dataGridViewClientData.AllowUserToDeleteRows = false;
            this.dataGridViewClientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientData.Location = new System.Drawing.Point(141, 69);
            this.dataGridViewClientData.Name = "dataGridViewClientData";
            this.dataGridViewClientData.RowHeadersWidth = 102;
            this.dataGridViewClientData.RowTemplate.Height = 40;
            this.dataGridViewClientData.Size = new System.Drawing.Size(1695, 255);
            this.dataGridViewClientData.TabIndex = 0;
            // 
            // buttonSaveEdits
            // 
            this.buttonSaveEdits.Location = new System.Drawing.Point(141, 364);
            this.buttonSaveEdits.Name = "buttonSaveEdits";
            this.buttonSaveEdits.Size = new System.Drawing.Size(134, 73);
            this.buttonSaveEdits.TabIndex = 1;
            this.buttonSaveEdits.Text = "Save";
            this.buttonSaveEdits.UseVisualStyleBackColor = true;
            this.buttonSaveEdits.Click += new System.EventHandler(this.buttonSaveEdits_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2029, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSaveEdits);
            this.Controls.Add(this.dataGridViewClientData);
            this.Name = "EditClient";
            this.Text = "Edit Client";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientData;
        private System.Windows.Forms.Button buttonSaveEdits;
        private System.Windows.Forms.Button button1;
    }
}