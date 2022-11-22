namespace NoteTaker2
{
    partial class EditNote
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editNoteBox = new System.Windows.Forms.TextBox();
            this.editSubjectListBox = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editDateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Note";
            // 
            // editNoteBox
            // 
            this.editNoteBox.Location = new System.Drawing.Point(220, 29);
            this.editNoteBox.Multiline = true;
            this.editNoteBox.Name = "editNoteBox";
            this.editNoteBox.Size = new System.Drawing.Size(629, 456);
            this.editNoteBox.TabIndex = 5;
            // 
            // editSubjectListBox
            // 
            this.editSubjectListBox.FormattingEnabled = true;
            this.editSubjectListBox.ItemHeight = 20;
            this.editSubjectListBox.Location = new System.Drawing.Point(19, 29);
            this.editSubjectListBox.Name = "editSubjectListBox";
            this.editSubjectListBox.Size = new System.Drawing.Size(168, 404);
            this.editSubjectListBox.TabIndex = 4;
            this.editSubjectListBox.SelectedIndexChanged += new System.EventHandler(this.editSubjectListBox_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(56, 439);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(94, 29);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editDateBox
            // 
            this.editDateBox.Location = new System.Drawing.Point(617, 491);
            this.editDateBox.Name = "editDateBox";
            this.editDateBox.Size = new System.Drawing.Size(232, 27);
            this.editDateBox.TabIndex = 9;
            this.editDateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.editDateBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editNoteBox);
            this.Controls.Add(this.editSubjectListBox);
            this.Name = "EditNote";
            this.Text = "EditNote";
            this.Load += new System.EventHandler(this.EditNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox editNoteBox;
        private ListBox editSubjectListBox;
        private Button deleteBtn;
        private TextBox editDateBox;
    }
}