namespace Parallels
{
    partial class Monitor
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
            this.label1 = new System.Windows.Forms.Label();
            this.thread_quantity = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip_host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connecting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error_displaying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.thrqnt = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threads:";
            // 
            // thread_quantity
            // 
            this.thread_quantity.Location = new System.Drawing.Point(535, 276);
            this.thread_quantity.Name = "thread_quantity";
            this.thread_quantity.Size = new System.Drawing.Size(175, 19);
            this.thread_quantity.TabIndex = 5;
            this.thread_quantity.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numbers,
            this.ip_host,
            this.connecting,
            this.error_displaying});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // numbers
            // 
            this.numbers.HeaderText = "№";
            this.numbers.Name = "numbers";
            // 
            // ip_host
            // 
            this.ip_host.HeaderText = "Host";
            this.ip_host.Name = "ip_host";
            // 
            // connecting
            // 
            this.connecting.HeaderText = "Connecting";
            this.connecting.Name = "connecting";
            // 
            // error_displaying
            // 
            this.error_displaying.HeaderText = "Errors...";
            this.error_displaying.Name = "error_displaying";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(783, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start/Pause";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thrqnt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(953, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // thrqnt
            // 
            this.thrqnt.Name = "thrqnt";
            this.thrqnt.Size = new System.Drawing.Size(118, 17);
            this.thrqnt.Text = "toolStripStatusLabel1";
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 383);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.thread_quantity);
            this.Controls.Add(this.label1);
            this.Name = "Monitor";
            this.Text = "Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox thread_quantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip_host;
        private System.Windows.Forms.DataGridViewTextBoxColumn connecting;
        private System.Windows.Forms.DataGridViewTextBoxColumn error_displaying;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel thrqnt;
    }
}