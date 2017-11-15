namespace ResourcesMonitor
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
            this.lb_processRapidChange = new System.Windows.Forms.ListBox();
            this.bt_getProcessRapidChange = new System.Windows.Forms.Button();
            this.lbl_state = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_ramSurge = new System.Windows.Forms.ListBox();
            this.lb_cpuSurge = new System.Windows.Forms.ListBox();
            this.tb_period = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_processRapidChange
            // 
            this.lb_processRapidChange.FormattingEnabled = true;
            this.lb_processRapidChange.Location = new System.Drawing.Point(231, 368);
            this.lb_processRapidChange.Name = "lb_processRapidChange";
            this.lb_processRapidChange.Size = new System.Drawing.Size(141, 290);
            this.lb_processRapidChange.TabIndex = 0;
            // 
            // bt_getProcessRapidChange
            // 
            this.bt_getProcessRapidChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_getProcessRapidChange.Location = new System.Drawing.Point(256, 223);
            this.bt_getProcessRapidChange.Name = "bt_getProcessRapidChange";
            this.bt_getProcessRapidChange.Size = new System.Drawing.Size(96, 36);
            this.bt_getProcessRapidChange.TabIndex = 1;
            this.bt_getProcessRapidChange.Text = "Start";
            this.bt_getProcessRapidChange.UseVisualStyleBackColor = true;
            this.bt_getProcessRapidChange.Click += new System.EventHandler(this.bt_getProcessRapidChange_Click);
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.Location = new System.Drawing.Point(225, 285);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(156, 33);
            this.lbl_state.TabIndex = 2;
            this.lbl_state.Text = "Terminate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Process ID\r\n    (Both)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(560, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "This is a GUI application can detect the proccesses\r\n which having the rapid surg" +
    "e of cpu and ram usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "  Process ID \r\n( CPU Surge )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "   Process ID \r\n( RAM Surge )";
            // 
            // lb_ramSurge
            // 
            this.lb_ramSurge.FormattingEnabled = true;
            this.lb_ramSurge.Location = new System.Drawing.Point(457, 368);
            this.lb_ramSurge.Name = "lb_ramSurge";
            this.lb_ramSurge.Size = new System.Drawing.Size(141, 290);
            this.lb_ramSurge.TabIndex = 7;
            // 
            // lb_cpuSurge
            // 
            this.lb_cpuSurge.FormattingEnabled = true;
            this.lb_cpuSurge.Location = new System.Drawing.Point(15, 368);
            this.lb_cpuSurge.Name = "lb_cpuSurge";
            this.lb_cpuSurge.Size = new System.Drawing.Size(141, 290);
            this.lb_cpuSurge.TabIndex = 8;
            // 
            // tb_period
            // 
            this.tb_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_period.Location = new System.Drawing.Point(107, 132);
            this.tb_period.Name = "tb_period";
            this.tb_period.Size = new System.Drawing.Size(49, 29);
            this.tb_period.TabIndex = 9;
            this.tb_period.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Period :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "( Detect the surge within this ms)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 670);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_period);
            this.Controls.Add(this.lb_cpuSurge);
            this.Controls.Add(this.lb_ramSurge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.bt_getProcessRapidChange);
            this.Controls.Add(this.lb_processRapidChange);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_processRapidChange;
        private System.Windows.Forms.Button bt_getProcessRapidChange;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_ramSurge;
        private System.Windows.Forms.ListBox lb_cpuSurge;
        private System.Windows.Forms.TextBox tb_period;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

