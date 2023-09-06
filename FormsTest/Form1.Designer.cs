namespace FormsTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            centerButton = new Button();
            SuspendLayout();
            // 
            // centerButton
            // 
            centerButton.BackColor = Color.OrangeRed;
            centerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            centerButton.Location = new Point(484, 256);
            centerButton.Name = "centerButton";
            centerButton.Size = new Size(214, 122);
            centerButton.TabIndex = 0;
            centerButton.Text = "Złap mnie!";
            centerButton.UseVisualStyleBackColor = false;
            centerButton.Click += ButtonClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 681);
            Controls.Add(centerButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button centerButton;
    }
}