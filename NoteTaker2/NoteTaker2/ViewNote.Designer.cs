namespace NoteTaker2
{
    partial class ViewNote
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
            this.viewSubjectListBox = new System.Windows.Forms.ListBox();
            this.viewNoteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewDateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // viewSubjectListBox
            // 
            this.viewSubjectListBox.FormattingEnabled = true;
            this.viewSubjectListBox.ItemHeight = 20;
            this.viewSubjectListBox.Location = new System.Drawing.Point(12, 47);
            this.viewSubjectListBox.Name = "viewSubjectListBox";
            this.viewSubjectListBox.Size = new System.Drawing.Size(168, 424);
            this.viewSubjectListBox.TabIndex = 0;
            this.viewSubjectListBox.SelectedIndexChanged += new System.EventHandler(this.viewSubjectListBox_SelectedIndexChanged);
            // 
            // viewNoteBox
            // 
            this.viewNoteBox.Location = new System.Drawing.Point(213, 47);
            this.viewNoteBox.Multiline = true;
            this.viewNoteBox.Name = "viewNoteBox";
            this.viewNoteBox.Size = new System.Drawing.Size(596, 422);
            this.viewNoteBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            // 
            // viewDateBox
            // 
            this.viewDateBox.Location = new System.Drawing.Point(577, 475);
            this.viewDateBox.Name = "viewDateBox";
            this.viewDateBox.Size = new System.Drawing.Size(232, 27);
            this.viewDateBox.TabIndex = 4;
            this.viewDateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ViewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.viewDateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewNoteBox);
            this.Controls.Add(this.viewSubjectListBox);
            this.Name = "ViewNote";
            this.Text = "ViewNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox viewSubjectListBox;
        private TextBox viewNoteBox;
        private Label label1;
        private Label label2;
        private TextBox viewDateBox;
    }
}