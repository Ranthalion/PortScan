namespace Assessment
{
    partial class Assessment
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SelectAll = new System.Windows.Forms.CheckBox();
            this.SelectNone = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PortScan = new System.Windows.Forms.Button();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btnObjects = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.00314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.99686F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.SelectAll, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.SelectNone, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtConsole, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.PortScan, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.progBar, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnObjects, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.07457F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.78203F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.211635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02018F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 579);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.checkedListBox1, 2);
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(31, 74);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(147, 87);
            this.checkedListBox1.TabIndex = 3;
            // 
            // SelectAll
            // 
            this.SelectAll.AutoSize = true;
            this.SelectAll.Location = new System.Drawing.Point(31, 167);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(37, 16);
            this.SelectAll.TabIndex = 5;
            this.SelectAll.Text = "All";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.CheckedChanged += new System.EventHandler(this.SelectAll_CheckedChanged);
            // 
            // SelectNone
            // 
            this.SelectNone.AutoSize = true;
            this.SelectNone.Location = new System.Drawing.Point(93, 167);
            this.SelectNone.Name = "SelectNone";
            this.SelectNone.Size = new System.Drawing.Size(52, 16);
            this.SelectNone.TabIndex = 4;
            this.SelectNone.Text = "None";
            this.SelectNone.UseVisualStyleBackColor = true;
            this.SelectNone.CheckedChanged += new System.EventHandler(this.SelectNone_CheckedChanged);
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(31, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get IP Addresses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Location = new System.Drawing.Point(184, 74);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.tableLayoutPanel1.SetRowSpan(this.txtConsole, 2);
            this.txtConsole.Size = new System.Drawing.Size(336, 109);
            this.txtConsole.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PortScan
            // 
            this.PortScan.Dock = System.Windows.Forms.DockStyle.Top;
            this.PortScan.Location = new System.Drawing.Point(93, 189);
            this.PortScan.Name = "PortScan";
            this.PortScan.Size = new System.Drawing.Size(85, 23);
            this.PortScan.TabIndex = 7;
            this.PortScan.Text = "PortScan";
            this.PortScan.UseVisualStyleBackColor = true;
            this.PortScan.Click += new System.EventHandler(this.PortScan_Click);
            // 
            // progBar
            // 
            this.progBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progBar.Location = new System.Drawing.Point(184, 508);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(336, 23);
            this.progBar.TabIndex = 8;
            // 
            // btnObjects
            // 
            this.btnObjects.Location = new System.Drawing.Point(31, 189);
            this.btnObjects.Name = "btnObjects";
            this.btnObjects.Size = new System.Drawing.Size(56, 22);
            this.btnObjects.TabIndex = 9;
            this.btnObjects.Text = "Show";
            this.btnObjects.UseVisualStyleBackColor = true;
            this.btnObjects.Click += new System.EventHandler(this.btnObjects_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(184, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 313);
            this.dataGridView1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(31, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 12;
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(640, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Assessment";
            this.Text = "Assessment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox SelectAll;
        private System.Windows.Forms.CheckBox SelectNone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PortScan;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btnObjects;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

