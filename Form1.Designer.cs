namespace SimmEndNoSimm_2
{
    partial class UIForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultBtn = new System.Windows.Forms.Button();
            this.ChoiceLoad = new System.Windows.Forms.CheckBox();
            this.ResultLable = new System.Windows.Forms.Label();
            this.TBL1 = new System.Windows.Forms.TextBox();
            this.TBL2 = new System.Windows.Forms.TextBox();
            this.TBL3 = new System.Windows.Forms.TextBox();
            this.TBU1 = new System.Windows.Forms.TextBox();
            this.TBU2 = new System.Windows.Forms.TextBox();
            this.TBU3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultBtn
            // 
            this.ResultBtn.Location = new System.Drawing.Point(52, 313);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(216, 38);
            this.ResultBtn.TabIndex = 0;
            this.ResultBtn.Text = "Расчёт";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // ChoiceLoad
            // 
            this.ChoiceLoad.AutoSize = true;
            this.ChoiceLoad.Location = new System.Drawing.Point(13, 13);
            this.ChoiceLoad.Name = "ChoiceLoad";
            this.ChoiceLoad.Size = new System.Drawing.Size(145, 17);
            this.ChoiceLoad.TabIndex = 1;
            this.ChoiceLoad.Text = "Выбор режима расчёта";
            this.ChoiceLoad.UseVisualStyleBackColor = true;
            this.ChoiceLoad.CheckedChanged += new System.EventHandler(this.ChoiceLoad_CheckedChanged);
            // 
            // ResultLable
            // 
            this.ResultLable.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLable.Location = new System.Drawing.Point(22, 217);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(276, 75);
            this.ResultLable.TabIndex = 2;
            this.ResultLable.Text = "Результат";
            this.ResultLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBL1
            // 
            this.TBL1.Location = new System.Drawing.Point(22, 99);
            this.TBL1.Name = "TBL1";
            this.TBL1.Size = new System.Drawing.Size(91, 20);
            this.TBL1.TabIndex = 3;
            // 
            // TBL2
            // 
            this.TBL2.Location = new System.Drawing.Point(22, 135);
            this.TBL2.Name = "TBL2";
            this.TBL2.Size = new System.Drawing.Size(91, 20);
            this.TBL2.TabIndex = 4;
            // 
            // TBL3
            // 
            this.TBL3.Location = new System.Drawing.Point(22, 170);
            this.TBL3.Name = "TBL3";
            this.TBL3.Size = new System.Drawing.Size(91, 20);
            this.TBL3.TabIndex = 5;
            // 
            // TBU1
            // 
            this.TBU1.Location = new System.Drawing.Point(207, 99);
            this.TBU1.Name = "TBU1";
            this.TBU1.Size = new System.Drawing.Size(91, 20);
            this.TBU1.TabIndex = 6;
            // 
            // TBU2
            // 
            this.TBU2.Location = new System.Drawing.Point(207, 135);
            this.TBU2.Name = "TBU2";
            this.TBU2.Size = new System.Drawing.Size(91, 20);
            this.TBU2.TabIndex = 7;
            // 
            // TBU3
            // 
            this.TBU3.Location = new System.Drawing.Point(207, 170);
            this.TBU3.Name = "TBU3";
            this.TBU3.Size = new System.Drawing.Size(91, 20);
            this.TBU3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "I (A)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "U (v)";
            // 
            // UIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBU3);
            this.Controls.Add(this.TBU2);
            this.Controls.Add(this.TBU1);
            this.Controls.Add(this.TBL3);
            this.Controls.Add(this.TBL2);
            this.Controls.Add(this.TBL1);
            this.Controls.Add(this.ResultLable);
            this.Controls.Add(this.ChoiceLoad);
            this.Controls.Add(this.ResultBtn);
            this.MaximizeBox = false;
            this.Name = "UIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simm&NoSimm";
            this.Load += new System.EventHandler(this.UIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.CheckBox ChoiceLoad;
        private System.Windows.Forms.Label ResultLable;
        private System.Windows.Forms.TextBox TBL1;
        private System.Windows.Forms.TextBox TBL2;
        private System.Windows.Forms.TextBox TBL3;
        private System.Windows.Forms.TextBox TBU1;
        private System.Windows.Forms.TextBox TBU2;
        private System.Windows.Forms.TextBox TBU3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

