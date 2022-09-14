namespace DZ_14092022_wf {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.bBIO = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.tbCaption = new System.Windows.Forms.TextBox();
            this.tbNewCaption = new System.Windows.Forms.TextBox();
            this.lCaption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbChange = new System.Windows.Forms.RadioButton();
            this.rbClose = new System.Windows.Forms.RadioButton();
            this.gbEx2 = new System.Windows.Forms.GroupBox();
            this.rbMaximize = new System.Windows.Forms.RadioButton();
            this.bBeeps = new System.Windows.Forms.Button();
            this.gbEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bBIO
            // 
            this.bBIO.Location = new System.Drawing.Point(145, 12);
            this.bBIO.Name = "bBIO";
            this.bBIO.Size = new System.Drawing.Size(75, 23);
            this.bBIO.TabIndex = 0;
            this.bBIO.Text = "BIO";
            this.bBIO.UseVisualStyleBackColor = true;
            this.bBIO.Click += new System.EventHandler(this.bBIO_Click);
            // 
            // bSubmit
            // 
            this.bSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSubmit.Location = new System.Drawing.Point(257, 94);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(95, 23);
            this.bSubmit.TabIndex = 1;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // tbCaption
            // 
            this.tbCaption.Location = new System.Drawing.Point(223, 19);
            this.tbCaption.Name = "tbCaption";
            this.tbCaption.Size = new System.Drawing.Size(129, 20);
            this.tbCaption.TabIndex = 2;
            // 
            // tbNewCaption
            // 
            this.tbNewCaption.Location = new System.Drawing.Point(223, 42);
            this.tbNewCaption.Name = "tbNewCaption";
            this.tbNewCaption.Size = new System.Drawing.Size(129, 20);
            this.tbNewCaption.TabIndex = 3;
            // 
            // lCaption
            // 
            this.lCaption.AutoSize = true;
            this.lCaption.Location = new System.Drawing.Point(130, 22);
            this.lCaption.Name = "lCaption";
            this.lCaption.Size = new System.Drawing.Size(87, 13);
            this.lCaption.TabIndex = 4;
            this.lCaption.Text = "Window caption:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "New caption:";
            // 
            // rbChange
            // 
            this.rbChange.AutoSize = true;
            this.rbChange.Checked = true;
            this.rbChange.Location = new System.Drawing.Point(15, 20);
            this.rbChange.Name = "rbChange";
            this.rbChange.Size = new System.Drawing.Size(100, 17);
            this.rbChange.TabIndex = 7;
            this.rbChange.TabStop = true;
            this.rbChange.Text = "Change caption";
            this.rbChange.UseVisualStyleBackColor = true;
            this.rbChange.CheckedChanged += new System.EventHandler(this.CC);
            // 
            // rbClose
            // 
            this.rbClose.AutoSize = true;
            this.rbClose.Location = new System.Drawing.Point(15, 43);
            this.rbClose.Name = "rbClose";
            this.rbClose.Size = new System.Drawing.Size(103, 17);
            this.rbClose.TabIndex = 8;
            this.rbClose.Text = "Close by caption";
            this.rbClose.UseVisualStyleBackColor = true;
            // 
            // gbEx2
            // 
            this.gbEx2.Controls.Add(this.rbMaximize);
            this.gbEx2.Controls.Add(this.tbCaption);
            this.gbEx2.Controls.Add(this.rbClose);
            this.gbEx2.Controls.Add(this.bSubmit);
            this.gbEx2.Controls.Add(this.rbChange);
            this.gbEx2.Controls.Add(this.tbNewCaption);
            this.gbEx2.Controls.Add(this.label1);
            this.gbEx2.Controls.Add(this.lCaption);
            this.gbEx2.Location = new System.Drawing.Point(12, 41);
            this.gbEx2.Name = "gbEx2";
            this.gbEx2.Size = new System.Drawing.Size(358, 123);
            this.gbEx2.TabIndex = 9;
            this.gbEx2.TabStop = false;
            this.gbEx2.Text = "Exercise 2";
            // 
            // rbMaximize
            // 
            this.rbMaximize.AutoSize = true;
            this.rbMaximize.Location = new System.Drawing.Point(15, 66);
            this.rbMaximize.Name = "rbMaximize";
            this.rbMaximize.Size = new System.Drawing.Size(68, 17);
            this.rbMaximize.TabIndex = 9;
            this.rbMaximize.Text = "Maximize";
            this.rbMaximize.UseVisualStyleBackColor = true;
            // 
            // bBeeps
            // 
            this.bBeeps.Location = new System.Drawing.Point(145, 170);
            this.bBeeps.Name = "bBeeps";
            this.bBeeps.Size = new System.Drawing.Size(75, 23);
            this.bBeeps.TabIndex = 10;
            this.bBeeps.Text = "Beeps";
            this.bBeeps.UseVisualStyleBackColor = true;
            this.bBeeps.Click += new System.EventHandler(this.bBeeps_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 269);
            this.Controls.Add(this.bBeeps);
            this.Controls.Add(this.gbEx2);
            this.Controls.Add(this.bBIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Main menu";
            this.gbEx2.ResumeLayout(false);
            this.gbEx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBIO;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.TextBox tbCaption;
        private System.Windows.Forms.TextBox tbNewCaption;
        private System.Windows.Forms.Label lCaption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbChange;
        private System.Windows.Forms.RadioButton rbClose;
        private System.Windows.Forms.GroupBox gbEx2;
        private System.Windows.Forms.RadioButton rbMaximize;
        private System.Windows.Forms.Button bBeeps;
    }
}

