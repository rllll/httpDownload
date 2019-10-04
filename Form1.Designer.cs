namespace httpDownload
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recevMsg = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.filecombine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startDownload = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.recvThreadnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.recevMsg);
            this.groupBox1.Location = new System.Drawing.Point(29, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收信息";
            // 
            // recevMsg
            // 
            this.recevMsg.FormattingEnabled = true;
            this.recevMsg.ItemHeight = 12;
            this.recevMsg.Location = new System.Drawing.Point(16, 31);
            this.recevMsg.Name = "recevMsg";
            this.recevMsg.Size = new System.Drawing.Size(432, 412);
            this.recevMsg.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DateEnd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.filecombine);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.startDownload);
            this.groupBox2.Controls.Add(this.Date);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.recvThreadnum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.path);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SourceUrl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(522, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 468);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "开始区";
            // 
            // DateEnd
            // 
            this.DateEnd.Enabled = false;
            this.DateEnd.Location = new System.Drawing.Point(125, 266);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(199, 21);
            this.DateEnd.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "接收结束时间";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filecombine
            // 
            this.filecombine.Location = new System.Drawing.Point(238, 371);
            this.filecombine.Name = "filecombine";
            this.filecombine.Size = new System.Drawing.Size(86, 23);
            this.filecombine.TabIndex = 11;
            this.filecombine.Text = "合并文件";
            this.filecombine.UseVisualStyleBackColor = true;
            this.filecombine.Click += new System.EventHandler(this.Filecombine_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "清空接收消息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 21);
            this.button2.TabIndex = 9;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // startDownload
            // 
            this.startDownload.Location = new System.Drawing.Point(238, 318);
            this.startDownload.Name = "startDownload";
            this.startDownload.Size = new System.Drawing.Size(86, 23);
            this.startDownload.TabIndex = 8;
            this.startDownload.Text = "下载";
            this.startDownload.UseVisualStyleBackColor = true;
            this.startDownload.Click += new System.EventHandler(this.StartDownload_Click);
            // 
            // Date
            // 
            this.Date.Enabled = false;
            this.Date.Location = new System.Drawing.Point(125, 219);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(199, 21);
            this.Date.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "接收开始时间";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recvThreadnum
            // 
            this.recvThreadnum.Location = new System.Drawing.Point(125, 168);
            this.recvThreadnum.Name = "recvThreadnum";
            this.recvThreadnum.Size = new System.Drawing.Size(199, 21);
            this.recvThreadnum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(24, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "接收线程数";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(125, 110);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(162, 21);
            this.path.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "存储位置";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SourceUrl
            // 
            this.SourceUrl.Location = new System.Drawing.Point(125, 55);
            this.SourceUrl.Name = "SourceUrl";
            this.SourceUrl.Size = new System.Drawing.Size(199, 21);
            this.SourceUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "下载网址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 547);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "多线程下载";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SourceUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recvThreadnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startDownload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox recevMsg;
        private System.Windows.Forms.Button filecombine;
        private System.Windows.Forms.TextBox DateEnd;
        private System.Windows.Forms.Label label5;
    }
}

