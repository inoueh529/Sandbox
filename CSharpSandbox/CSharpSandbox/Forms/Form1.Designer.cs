namespace CSharpSandbox
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.calcSum = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcSum
            // 
            this.calcSum.Location = new System.Drawing.Point(109, 119);
            this.calcSum.Name = "calcSum";
            this.calcSum.Size = new System.Drawing.Size(75, 23);
            this.calcSum.TabIndex = 0;
            this.calcSum.Text = "計算";
            this.calcSum.UseVisualStyleBackColor = true;
            this.calcSum.Click += new System.EventHandler(this.calcSum_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(97, 22);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 19);
            this.num1.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(97, 67);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 19);
            this.num2.TabIndex = 2;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(97, 196);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 24);
            this.sum.TabIndex = 3;
            this.sum.Text = "合計";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.calcSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcSum;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label sum;
    }
}

