namespace Homework_9
{
    partial class CrawlerForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.funcFlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.startUrlTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.funcFlowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // funcFlowLayoutPanel2
            // 
            this.funcFlowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.funcFlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.funcFlowLayoutPanel2.Controls.Add(this.startUrlTextBox);
            this.funcFlowLayoutPanel2.Controls.Add(this.startButton);
            this.funcFlowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.funcFlowLayoutPanel2.Name = "funcFlowLayoutPanel2";
            this.funcFlowLayoutPanel2.Size = new System.Drawing.Size(776, 53);
            this.funcFlowLayoutPanel2.TabIndex = 2;
            // 
            // startUrlTextBox
            // 
            this.startUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startUrlTextBox.Location = new System.Drawing.Point(3, 10);
            this.startUrlTextBox.Name = "startUrlTextBox";
            this.startUrlTextBox.Size = new System.Drawing.Size(372, 25);
            this.startUrlTextBox.TabIndex = 5;
            this.startUrlTextBox.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("宋体", 19F);
            this.startButton.Location = new System.Drawing.Point(381, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(68, 40);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "爬";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(12, 71);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(776, 367);
            this.resultsTextBox.TabIndex = 3;
            // 
            // CrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.funcFlowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CrawlerForm";
            this.Text = "CrawlerForm";
            this.funcFlowLayoutPanel2.ResumeLayout(false);
            this.funcFlowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel funcFlowLayoutPanel2;
        private System.Windows.Forms.TextBox startUrlTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox resultsTextBox;
    }
}

