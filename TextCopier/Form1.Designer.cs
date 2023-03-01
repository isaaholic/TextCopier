namespace TextCopier
{
    partial class Form1
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
            this.CopyBtn = new System.Windows.Forms.Button();
            this.SuspendBtn = new System.Windows.Forms.Button();
            this.AbortBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.ToBtn = new System.Windows.Forms.Button();
            this.FileBtn = new System.Windows.Forms.Button();
            this.prBar = new System.Windows.Forms.ProgressBar();
            this.Totxtbox = new System.Windows.Forms.TextBox();
            this.Fromtxtbox = new System.Windows.Forms.TextBox();
            this.Fromlbl = new System.Windows.Forms.Label();
            this.Tolbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(507, 168);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(75, 23);
            this.CopyBtn.TabIndex = 20;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // SuspendBtn
            // 
            this.SuspendBtn.Location = new System.Drawing.Point(319, 168);
            this.SuspendBtn.Name = "SuspendBtn";
            this.SuspendBtn.Size = new System.Drawing.Size(75, 23);
            this.SuspendBtn.TabIndex = 19;
            this.SuspendBtn.Text = "Suspend";
            this.SuspendBtn.UseVisualStyleBackColor = true;
            this.SuspendBtn.Click += new System.EventHandler(this.SuspendBtn_Click);
            // 
            // AbortBtn
            // 
            this.AbortBtn.Location = new System.Drawing.Point(400, 168);
            this.AbortBtn.Name = "AbortBtn";
            this.AbortBtn.Size = new System.Drawing.Size(75, 23);
            this.AbortBtn.TabIndex = 18;
            this.AbortBtn.Text = "Abort";
            this.AbortBtn.UseVisualStyleBackColor = true;
            this.AbortBtn.Click += new System.EventHandler(this.AbortBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Location = new System.Drawing.Point(238, 168);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(75, 23);
            this.ResumeBtn.TabIndex = 17;
            this.ResumeBtn.Text = "Resume";
            this.ResumeBtn.UseVisualStyleBackColor = true;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // ToBtn
            // 
            this.ToBtn.Location = new System.Drawing.Point(507, 122);
            this.ToBtn.Name = "ToBtn";
            this.ToBtn.Size = new System.Drawing.Size(75, 23);
            this.ToBtn.TabIndex = 16;
            this.ToBtn.Text = "File";
            this.ToBtn.UseVisualStyleBackColor = true;
            this.ToBtn.Click += new System.EventHandler(this.ToFilebtn_Click);
            // 
            // FileBtn
            // 
            this.FileBtn.Location = new System.Drawing.Point(507, 63);
            this.FileBtn.Name = "FileBtn";
            this.FileBtn.Size = new System.Drawing.Size(75, 23);
            this.FileBtn.TabIndex = 15;
            this.FileBtn.Text = "File";
            this.FileBtn.UseVisualStyleBackColor = true;
            this.FileBtn.Click += new System.EventHandler(this.FromFilebtn_Click);
            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(93, 168);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(130, 23);
            this.prBar.TabIndex = 14;
            // 
            // Totxtbox
            // 
            this.Totxtbox.Location = new System.Drawing.Point(133, 127);
            this.Totxtbox.Name = "Totxtbox";
            this.Totxtbox.Size = new System.Drawing.Size(342, 20);
            this.Totxtbox.TabIndex = 13;
            // 
            // Fromtxtbox
            // 
            this.Fromtxtbox.Location = new System.Drawing.Point(133, 65);
            this.Fromtxtbox.Name = "Fromtxtbox";
            this.Fromtxtbox.Size = new System.Drawing.Size(342, 20);
            this.Fromtxtbox.TabIndex = 12;
            // 
            // Fromlbl
            // 
            this.Fromlbl.AutoSize = true;
            this.Fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fromlbl.Location = new System.Drawing.Point(89, 64);
            this.Fromlbl.Name = "Fromlbl";
            this.Fromlbl.Size = new System.Drawing.Size(47, 21);
            this.Fromlbl.TabIndex = 10;
            this.Fromlbl.Text = "From";
            // 
            // Tolbl
            // 
            this.Tolbl.AutoSize = true;
            this.Tolbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tolbl.Location = new System.Drawing.Point(89, 124);
            this.Tolbl.Name = "Tolbl";
            this.Tolbl.Size = new System.Drawing.Size(25, 21);
            this.Tolbl.TabIndex = 11;
            this.Tolbl.Text = "To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 252);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.SuspendBtn);
            this.Controls.Add(this.AbortBtn);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.ToBtn);
            this.Controls.Add(this.FileBtn);
            this.Controls.Add(this.prBar);
            this.Controls.Add(this.Totxtbox);
            this.Controls.Add(this.Fromtxtbox);
            this.Controls.Add(this.Fromlbl);
            this.Controls.Add(this.Tolbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button SuspendBtn;
        private System.Windows.Forms.Button AbortBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.Button ToBtn;
        private System.Windows.Forms.Button FileBtn;
        private System.Windows.Forms.ProgressBar prBar;
        private System.Windows.Forms.TextBox Totxtbox;
        private System.Windows.Forms.TextBox Fromtxtbox;
        private System.Windows.Forms.Label Fromlbl;
        private System.Windows.Forms.Label Tolbl;
    }
}