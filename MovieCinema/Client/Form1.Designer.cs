namespace Client
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
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_TicketNumber = new System.Windows.Forms.TextBox();
            this.txt_Response = new System.Windows.Forms.TextBox();
            this.lbl_TicketNumber = new System.Windows.Forms.Label();
            this.lbl_Response = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(168, 229);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(108, 23);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_TicketNumber
            // 
            this.txt_TicketNumber.Location = new System.Drawing.Point(23, 28);
            this.txt_TicketNumber.Name = "txt_TicketNumber";
            this.txt_TicketNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_TicketNumber.TabIndex = 1;
            // 
            // txt_Response
            // 
            this.txt_Response.Location = new System.Drawing.Point(23, 85);
            this.txt_Response.Name = "txt_Response";
            this.txt_Response.Size = new System.Drawing.Size(172, 20);
            this.txt_Response.TabIndex = 2;
            // 
            // lbl_TicketNumber
            // 
            this.lbl_TicketNumber.AutoSize = true;
            this.lbl_TicketNumber.Location = new System.Drawing.Point(23, 13);
            this.lbl_TicketNumber.Name = "lbl_TicketNumber";
            this.lbl_TicketNumber.Size = new System.Drawing.Size(77, 13);
            this.lbl_TicketNumber.TabIndex = 3;
            this.lbl_TicketNumber.Text = "Ticket Number";
            // 
            // lbl_Response
            // 
            this.lbl_Response.AutoSize = true;
            this.lbl_Response.Location = new System.Drawing.Point(23, 66);
            this.lbl_Response.Name = "lbl_Response";
            this.lbl_Response.Size = new System.Drawing.Size(55, 13);
            this.lbl_Response.TabIndex = 4;
            this.lbl_Response.Text = "Response";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 264);
            this.Controls.Add(this.lbl_Response);
            this.Controls.Add(this.lbl_TicketNumber);
            this.Controls.Add(this.txt_Response);
            this.Controls.Add(this.txt_TicketNumber);
            this.Controls.Add(this.btn_Send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_TicketNumber;
        private System.Windows.Forms.TextBox txt_Response;
        private System.Windows.Forms.Label lbl_TicketNumber;
        private System.Windows.Forms.Label lbl_Response;
    }
}

