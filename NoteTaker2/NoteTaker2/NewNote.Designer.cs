namespace NoteTaker2
{
    partial class NewNote
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
            this.subjectInputBox = new System.Windows.Forms.TextBox();
            this.noteBodyInputBox = new System.Windows.Forms.TextBox();
            this.noteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.discardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectInputBox
            // 
            this.subjectInputBox.Location = new System.Drawing.Point(167, 57);
            this.subjectInputBox.Name = "subjectInputBox";
            this.subjectInputBox.Size = new System.Drawing.Size(655, 27);
            this.subjectInputBox.TabIndex = 0;
            this.subjectInputBox.TextChanged += new System.EventHandler(this.subjectInputBox_TextChanged);
            // 
            // noteBodyInputBox
            // 
            this.noteBodyInputBox.Location = new System.Drawing.Point(167, 90);
            this.noteBodyInputBox.Multiline = true;
            this.noteBodyInputBox.Name = "noteBodyInputBox";
            this.noteBodyInputBox.Size = new System.Drawing.Size(655, 324);
            this.noteBodyInputBox.TabIndex = 1;
            // 
            // noteDateTimePicker
            // 
            this.noteDateTimePicker.Location = new System.Drawing.Point(167, 420);
            this.noteDateTimePicker.Name = "noteDateTimePicker";
            this.noteDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.noteDateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(323, 483);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 29);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // discardBtn
            // 
            this.discardBtn.Location = new System.Drawing.Point(509, 483);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(94, 29);
            this.discardBtn.TabIndex = 7;
            this.discardBtn.Text = "Discard";
            this.discardBtn.UseVisualStyleBackColor = true;
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.discardBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteDateTimePicker);
            this.Controls.Add(this.noteBodyInputBox);
            this.Controls.Add(this.subjectInputBox);
            this.Name = "NewNote";
            this.Text = "NewNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox subjectInputBox;
        private TextBox noteBodyInputBox;
        private DateTimePicker noteDateTimePicker;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveBtn;
        private Button discardBtn;
    }
}