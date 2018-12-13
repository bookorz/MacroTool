namespace MacroTool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Load_file = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Copy1_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Copy2_btn = new System.Windows.Forms.Button();
            this.Copy3_btn = new System.Windows.Forms.Button();
            this.fileName_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(701, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // Load_file
            // 
            this.Load_file.Location = new System.Drawing.Point(627, 374);
            this.Load_file.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Load_file.Name = "Load_file";
            this.Load_file.Size = new System.Drawing.Size(83, 50);
            this.Load_file.TabIndex = 1;
            this.Load_file.Text = "Load file";
            this.Load_file.UseVisualStyleBackColor = true;
            this.Load_file.Click += new System.EventHandler(this.Load_file_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(68, 374);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 27);
            this.textBox1.TabIndex = 2;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(627, 428);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(83, 33);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 461);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Macro tool ver 1.0";
            // 
            // Copy1_btn
            // 
            this.Copy1_btn.Location = new System.Drawing.Point(9, 374);
            this.Copy1_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Copy1_btn.Name = "Copy1_btn";
            this.Copy1_btn.Size = new System.Drawing.Size(55, 27);
            this.Copy1_btn.TabIndex = 5;
            this.Copy1_btn.Text = "Copy";
            this.Copy1_btn.UseVisualStyleBackColor = true;
            this.Copy1_btn.Click += new System.EventHandler(this.Copy1_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(68, 404);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(555, 27);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(68, 434);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(555, 27);
            this.textBox3.TabIndex = 7;
            // 
            // Copy2_btn
            // 
            this.Copy2_btn.Location = new System.Drawing.Point(9, 404);
            this.Copy2_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Copy2_btn.Name = "Copy2_btn";
            this.Copy2_btn.Size = new System.Drawing.Size(55, 27);
            this.Copy2_btn.TabIndex = 8;
            this.Copy2_btn.Text = "Copy";
            this.Copy2_btn.UseVisualStyleBackColor = true;
            this.Copy2_btn.Click += new System.EventHandler(this.Copy2_btn_Click);
            // 
            // Copy3_btn
            // 
            this.Copy3_btn.Location = new System.Drawing.Point(9, 434);
            this.Copy3_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Copy3_btn.Name = "Copy3_btn";
            this.Copy3_btn.Size = new System.Drawing.Size(55, 27);
            this.Copy3_btn.TabIndex = 9;
            this.Copy3_btn.Text = "Copy";
            this.Copy3_btn.UseVisualStyleBackColor = true;
            this.Copy3_btn.Click += new System.EventHandler(this.Copy3_btn_Click);
            // 
            // fileName_lb
            // 
            this.fileName_lb.AutoSize = true;
            this.fileName_lb.ForeColor = System.Drawing.SystemColors.Control;
            this.fileName_lb.Location = new System.Drawing.Point(9, 7);
            this.fileName_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileName_lb.Name = "fileName_lb";
            this.fileName_lb.Size = new System.Drawing.Size(0, 12);
            this.fileName_lb.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(719, 477);
            this.Controls.Add(this.fileName_lb);
            this.Controls.Add(this.Copy3_btn);
            this.Controls.Add(this.Copy2_btn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Copy1_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Load_file);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Load_file;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Copy1_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Copy2_btn;
        private System.Windows.Forms.Button Copy3_btn;
        private System.Windows.Forms.Label fileName_lb;
    }
}

