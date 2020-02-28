namespace Homework2
{
    partial class CaculatorForm
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
            this.sign = new System.Windows.Forms.ListBox();
            this.temp1 = new System.Windows.Forms.TextBox();
            this.temp2 = new System.Windows.Forms.TextBox();
            this.Exception = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sign.FormattingEnabled = true;
            this.sign.ItemHeight = 33;
            this.sign.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.sign.Location = new System.Drawing.Point(211, 89);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(46, 37);
            this.sign.TabIndex = 1;
            this.sign.SelectedIndexChanged += new System.EventHandler(this.sign_SelectedIndexChanged);
            // 
            // temp1
            // 
            this.temp1.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp1.Location = new System.Drawing.Point(80, 92);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(100, 34);
            this.temp1.TabIndex = 2;
            // 
            // temp2
            // 
            this.temp2.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.temp2.Location = new System.Drawing.Point(284, 92);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(100, 34);
            this.temp2.TabIndex = 3;
            // 
            // Exception
            // 
            this.Exception.AutoSize = true;
            this.Exception.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exception.Location = new System.Drawing.Point(174, 150);
            this.Exception.Name = "Exception";
            this.Exception.Size = new System.Drawing.Size(0, 27);
            this.Exception.TabIndex = 6;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result.Location = new System.Drawing.Point(462, 95);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 27);
            this.result.TabIndex = 7;
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.equal.Location = new System.Drawing.Point(400, 89);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(43, 40);
            this.equal.TabIndex = 8;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // CaculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 222);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Exception);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.sign);
            this.Name = "CaculatorForm";
            this.Text = "Caculator";
            this.Load += new System.EventHandler(this.CaculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox sign;
        private System.Windows.Forms.TextBox temp1;
        private System.Windows.Forms.TextBox temp2;
        private System.Windows.Forms.Label Exception;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button equal;
    }
}

