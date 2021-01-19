namespace WindowsFormsApp1
{
    using WindowsFormsControlLibrary1;

    partial class FormRGB
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
            this.rgbControl1 = new WindowsFormsControlLibrary1.RGBControl();
            this.SuspendLayout();
            // 
            // rgbControl1
            // 
            this.rgbControl1.AutoSize = true;
            this.rgbControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rgbControl1.CurColor = System.Drawing.Color.Black;
            this.rgbControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgbControl1.Location = new System.Drawing.Point(0, 0);
            this.rgbControl1.Margin = new System.Windows.Forms.Padding(2);
            this.rgbControl1.Name = "rgbControl1";
            this.rgbControl1.Size = new System.Drawing.Size(359, 242);
            this.rgbControl1.TabIndex = 0;
            // 
            // FormRGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(359, 242);
            this.Controls.Add(this.rgbControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormRGB";
            this.Text = "RGB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RGBControl rgbControl1;
    }
}

