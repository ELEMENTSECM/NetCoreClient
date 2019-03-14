namespace NCoreClientCore.WinForms.Framework
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFetchFunctions = new System.Windows.Forms.Button();
            this.btnFetchCases = new System.Windows.Forms.Button();
            this.btnFetchDocumentSize = new System.Windows.Forms.Button();
            this.txtRegistryEntryId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(800, 404);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 46);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnFetchFunctions
            // 
            this.btnFetchFunctions.Location = new System.Drawing.Point(12, 12);
            this.btnFetchFunctions.Name = "btnFetchFunctions";
            this.btnFetchFunctions.Size = new System.Drawing.Size(107, 23);
            this.btnFetchFunctions.TabIndex = 5;
            this.btnFetchFunctions.Text = "Fetch Functions";
            this.btnFetchFunctions.UseVisualStyleBackColor = true;
            this.btnFetchFunctions.Click += new System.EventHandler(this.BtnFetchFunctions_Click);
            // 
            // btnFetchCases
            // 
            this.btnFetchCases.Location = new System.Drawing.Point(141, 12);
            this.btnFetchCases.Name = "btnFetchCases";
            this.btnFetchCases.Size = new System.Drawing.Size(107, 23);
            this.btnFetchCases.TabIndex = 6;
            this.btnFetchCases.Text = "Fetch Cases";
            this.btnFetchCases.UseVisualStyleBackColor = true;
            this.btnFetchCases.Click += new System.EventHandler(this.BtnFetchCases_Click);
            // 
            // btnFetchDocumentSize
            // 
            this.btnFetchDocumentSize.Location = new System.Drawing.Point(507, 13);
            this.btnFetchDocumentSize.Name = "btnFetchDocumentSize";
            this.btnFetchDocumentSize.Size = new System.Drawing.Size(140, 23);
            this.btnFetchDocumentSize.TabIndex = 6;
            this.btnFetchDocumentSize.Text = "Fetch Document (size)";
            this.btnFetchDocumentSize.UseVisualStyleBackColor = true;
            this.btnFetchDocumentSize.Click += new System.EventHandler(this.BtnFetchDocumentSize_Click);
            // 
            // txtRegistryEntryId
            // 
            this.txtRegistryEntryId.Location = new System.Drawing.Point(392, 13);
            this.txtRegistryEntryId.Name = "txtRegistryEntryId";
            this.txtRegistryEntryId.Size = new System.Drawing.Size(100, 20);
            this.txtRegistryEntryId.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRegistryEntryId);
            this.Controls.Add(this.btnFetchDocumentSize);
            this.Controls.Add(this.btnFetchCases);
            this.Controls.Add(this.btnFetchFunctions);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFetchFunctions;
        private System.Windows.Forms.Button btnFetchCases;
        private System.Windows.Forms.Button btnFetchDocumentSize;
        private System.Windows.Forms.TextBox txtRegistryEntryId;
    }
}

