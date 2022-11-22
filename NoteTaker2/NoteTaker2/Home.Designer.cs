namespace NoteTaker2
{
    partial class Home
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
            this.newNoteBtn = new System.Windows.Forms.Button();
            this.viewNotesBtn = new System.Windows.Forms.Button();
            this.editNotesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.Location = new System.Drawing.Point(110, 355);
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(166, 77);
            this.newNoteBtn.TabIndex = 0;
            this.newNoteBtn.Text = "New Note";
            this.newNoteBtn.UseVisualStyleBackColor = true;
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // viewNotesBtn
            // 
            this.viewNotesBtn.Location = new System.Drawing.Point(342, 355);
            this.viewNotesBtn.Name = "viewNotesBtn";
            this.viewNotesBtn.Size = new System.Drawing.Size(166, 77);
            this.viewNotesBtn.TabIndex = 1;
            this.viewNotesBtn.Text = "View Notes";
            this.viewNotesBtn.UseVisualStyleBackColor = true;
            this.viewNotesBtn.Click += new System.EventHandler(this.viewNotesBtn_Click);
            // 
            // editNotesBtn
            // 
            this.editNotesBtn.Location = new System.Drawing.Point(572, 355);
            this.editNotesBtn.Name = "editNotesBtn";
            this.editNotesBtn.Size = new System.Drawing.Size(166, 77);
            this.editNotesBtn.TabIndex = 2;
            this.editNotesBtn.Text = "Edit Notes";
            this.editNotesBtn.UseVisualStyleBackColor = true;
            this.editNotesBtn.Click += new System.EventHandler(this.editNotesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(261, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "NoteBuddy";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editNotesBtn);
            this.Controls.Add(this.viewNotesBtn);
            this.Controls.Add(this.newNoteBtn);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button newNoteBtn;
        private Button viewNotesBtn;
        private Button editNotesBtn;
        private Label label1;
    }
}