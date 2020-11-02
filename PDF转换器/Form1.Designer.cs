namespace PDF转换器
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelFileBox = new System.Windows.Forms.Panel();
            this.labTips = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnPdfToWord = new System.Windows.Forms.Button();
            this.tipMsg = new System.Windows.Forms.ToolTip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labPro = new System.Windows.Forms.Label();
            this.panelFileBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFileBox
            // 
            this.panelFileBox.AllowDrop = true;
            this.panelFileBox.Controls.Add(this.labTips);
            this.panelFileBox.Controls.Add(this.listView1);
            this.panelFileBox.Location = new System.Drawing.Point(12, 12);
            this.panelFileBox.Name = "panelFileBox";
            this.panelFileBox.Size = new System.Drawing.Size(480, 200);
            this.panelFileBox.TabIndex = 0;
            this.panelFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFileBox_DragDrop);
            this.panelFileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFileBox_DragEnter);
            // 
            // labTips
            // 
            this.labTips.AutoSize = true;
            this.labTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.labTips.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labTips.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTips.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labTips.Location = new System.Drawing.Point(136, 92);
            this.labTips.Name = "labTips";
            this.labTips.Size = new System.Drawing.Size(208, 16);
            this.labTips.TabIndex = 3;
            this.labTips.Text = "拖拽要转换的PDF文件到这里";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 200);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnPdfToWord
            // 
            this.btnPdfToWord.BackColor = System.Drawing.Color.Green;
            this.btnPdfToWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfToWord.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPdfToWord.ForeColor = System.Drawing.Color.White;
            this.btnPdfToWord.Location = new System.Drawing.Point(164, 256);
            this.btnPdfToWord.Name = "btnPdfToWord";
            this.btnPdfToWord.Size = new System.Drawing.Size(176, 48);
            this.btnPdfToWord.TabIndex = 1;
            this.btnPdfToWord.Text = "转换成Word";
            this.btnPdfToWord.UseVisualStyleBackColor = false;
            this.btnPdfToWord.Click += new System.EventHandler(this.btnPdfToWord_Click);
            // 
            // tipMsg
            // 
            this.tipMsg.ForeColor = System.Drawing.Color.Black;
            this.tipMsg.IsBalloon = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 212);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(480, 5);
            this.progressBar1.TabIndex = 2;
            // 
            // labPro
            // 
            this.labPro.AutoSize = true;
            this.labPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labPro.Location = new System.Drawing.Point(182, 225);
            this.labPro.Name = "labPro";
            this.labPro.Size = new System.Drawing.Size(137, 12);
            this.labPro.TabIndex = 3;
            this.labPro.Text = "正在转换，当前进度：0%";
            this.labPro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 334);
            this.Controls.Add(this.labPro);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnPdfToWord);
            this.Controls.Add(this.panelFileBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF转换器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelFileBox.ResumeLayout(false);
            this.panelFileBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFileBox;
        private System.Windows.Forms.Label labTips;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnPdfToWord;
        private System.Windows.Forms.ToolTip tipMsg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labPro;
    }
}

