
namespace AmIPositve
{
    partial class ifStaments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputIntLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputIntLabel
            // 
            this.inputIntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIntLabel.Location = new System.Drawing.Point(51, 44);
            this.inputIntLabel.Name = "inputIntLabel";
            this.inputIntLabel.Size = new System.Drawing.Size(143, 29);
            this.inputIntLabel.TabIndex = 0;
            this.inputIntLabel.Text = "Input an Integer";
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(200, 44);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 29);
            this.inputBox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.Location = new System.Drawing.Point(200, 79);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 46);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(51, 170);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(249, 193);
            this.outputLabel.TabIndex = 3;
            // 
            // ifStaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 408);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.inputIntLabel);
            this.Name = "ifStaments";
            this.Text = "If Statements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputIntLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

