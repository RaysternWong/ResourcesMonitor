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
            this.SuspendLayout();
            // 
            // lb_processRapidChange
            // 
            this.lb_processRapidChange.FormattingEnabled = true;
            this.lb_processRapidChange.Location = new System.Drawing.Point(25, 253);
            this.lb_processRapidChange.Name = "lb_processRapidChange";
            this.lb_processRapidChange.Size = new System.Drawing.Size(273, 277);
            this.lb_processRapidChange.TabIndex = 0;
            // 
            // bt_getProcessRapidChange
            // 
            this.bt_getProcessRapidChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_getProcessRapidChange.Location = new System.Drawing.Point(64, 12);
            this.bt_getProcessRapidChange.Name = "bt_getProcessRapidChange";
            this.bt_getProcessRapidChange.Size = new System.Drawing.Size(199, 108);
            this.bt_getProcessRapidChange.TabIndex = 1;
            this.bt_getProcessRapidChange.Text = "Get list of processes that rapid change of Usage";
            this.bt_getProcessRapidChange.UseVisualStyleBackColor = true;
            this.bt_getProcessRapidChange.Click += new System.EventHandler(this.bt_getProcessRapidChange_Click);
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.Location = new System.Drawing.Point(80, 141);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(156, 33);
            this.lbl_state.TabIndex = 2;
            this.lbl_state.Text = "Terminate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Process ID List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 559);
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
    }
}

