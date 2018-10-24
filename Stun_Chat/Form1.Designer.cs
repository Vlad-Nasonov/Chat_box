namespace Stun_Chat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Stun_serv_adr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Net_Type = new System.Windows.Forms.TextBox();
            this.new_Local_output = new System.Windows.Forms.TextBox();
            this.new_local_input = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chat_box = new System.Windows.Forms.TextBox();
            this.local_port_log = new System.Windows.Forms.TextBox();
            this.srv_port_log = new System.Windows.Forms.TextBox();
            this.srv_ip_log = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stun_serv_adr
            // 
            this.Stun_serv_adr.Location = new System.Drawing.Point(12, 12);
            this.Stun_serv_adr.Name = "Stun_serv_adr";
            this.Stun_serv_adr.Size = new System.Drawing.Size(169, 20);
            this.Stun_serv_adr.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Net_Type
            // 
            this.Net_Type.Location = new System.Drawing.Point(12, 38);
            this.Net_Type.Name = "Net_Type";
            this.Net_Type.Size = new System.Drawing.Size(169, 20);
            this.Net_Type.TabIndex = 2;
            // 
            // new_Local_output
            // 
            this.new_Local_output.Location = new System.Drawing.Point(13, 65);
            this.new_Local_output.Name = "new_Local_output";
            this.new_Local_output.Size = new System.Drawing.Size(168, 20);
            this.new_Local_output.TabIndex = 3;
            // 
            // new_local_input
            // 
            this.new_local_input.Location = new System.Drawing.Point(13, 92);
            this.new_local_input.Name = "new_local_input";
            this.new_local_input.Size = new System.Drawing.Size(168, 20);
            this.new_local_input.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 20);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chat_box
            // 
            this.chat_box.Location = new System.Drawing.Point(187, 12);
            this.chat_box.Multiline = true;
            this.chat_box.Name = "chat_box";
            this.chat_box.Size = new System.Drawing.Size(592, 340);
            this.chat_box.TabIndex = 6;
            // 
            // local_port_log
            // 
            this.local_port_log.Location = new System.Drawing.Point(13, 145);
            this.local_port_log.Name = "local_port_log";
            this.local_port_log.Size = new System.Drawing.Size(168, 20);
            this.local_port_log.TabIndex = 7;
            // 
            // srv_port_log
            // 
            this.srv_port_log.Location = new System.Drawing.Point(12, 172);
            this.srv_port_log.Name = "srv_port_log";
            this.srv_port_log.Size = new System.Drawing.Size(169, 20);
            this.srv_port_log.TabIndex = 8;
            // 
            // srv_ip_log
            // 
            this.srv_ip_log.Location = new System.Drawing.Point(12, 198);
            this.srv_ip_log.Name = "srv_ip_log";
            this.srv_ip_log.Size = new System.Drawing.Size(168, 20);
            this.srv_ip_log.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 358);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 146);
            this.textBox1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 145);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 516);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.srv_ip_log);
            this.Controls.Add(this.srv_port_log);
            this.Controls.Add(this.local_port_log);
            this.Controls.Add(this.chat_box);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.new_local_input);
            this.Controls.Add(this.new_Local_output);
            this.Controls.Add(this.Net_Type);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Stun_serv_adr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Stun_serv_adr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Net_Type;
        private System.Windows.Forms.TextBox new_Local_output;
        private System.Windows.Forms.TextBox new_local_input;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox chat_box;
        private System.Windows.Forms.TextBox local_port_log;
        private System.Windows.Forms.TextBox srv_port_log;
        private System.Windows.Forms.TextBox srv_ip_log;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}

