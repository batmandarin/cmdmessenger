namespace FocusApp
{
    partial class FocusForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlnput = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "학번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "체중";
            // 
            // btnlnput
            // 
            this.btnlnput.Location = new System.Drawing.Point(12, 126);
            this.btnlnput.Name = "btnlnput";
            this.btnlnput.Size = new System.Drawing.Size(75, 23);
            this.btnlnput.TabIndex = 2;
            this.btnlnput.Text = "입력";
            this.btnlnput.UseVisualStyleBackColor = true;
            this.btnlnput.Click += new System.EventHandler(this.btnlnput_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(140, 25);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 21);
            this.txtNum.TabIndex = 0;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(140, 71);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 21);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(123, 126);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(160, 23);
            this.lblResult.TabIndex = 5;
            // 
            // FocusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnlnput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FocusForm";
            this.Text = "포커스활용(입력)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlnput;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblResult;
    }
}

