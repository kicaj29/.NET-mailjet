namespace MailJetSample
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
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnSendMailTemplate = new System.Windows.Forms.Button();
            this.btnTemplateWithVariable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(25, 36);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(180, 23);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "SendMail - simple";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnSendMailTemplate
            // 
            this.btnSendMailTemplate.Location = new System.Drawing.Point(25, 94);
            this.btnSendMailTemplate.Name = "btnSendMailTemplate";
            this.btnSendMailTemplate.Size = new System.Drawing.Size(180, 23);
            this.btnSendMailTemplate.TabIndex = 1;
            this.btnSendMailTemplate.Text = "SendMailTemplate";
            this.btnSendMailTemplate.UseVisualStyleBackColor = true;
            this.btnSendMailTemplate.Click += new System.EventHandler(this.btnSendMailTemplate_Click);
            // 
            // btnTemplateWithVariable
            // 
            this.btnTemplateWithVariable.Location = new System.Drawing.Point(25, 155);
            this.btnTemplateWithVariable.Name = "btnTemplateWithVariable";
            this.btnTemplateWithVariable.Size = new System.Drawing.Size(180, 23);
            this.btnTemplateWithVariable.TabIndex = 2;
            this.btnTemplateWithVariable.Text = "SendMailTemplateWithVariable";
            this.btnTemplateWithVariable.UseVisualStyleBackColor = true;
            this.btnTemplateWithVariable.Click += new System.EventHandler(this.btnTemplateWithVariable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 262);
            this.Controls.Add(this.btnTemplateWithVariable);
            this.Controls.Add(this.btnSendMailTemplate);
            this.Controls.Add(this.btnSendMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnSendMailTemplate;
        private System.Windows.Forms.Button btnTemplateWithVariable;
    }
}

