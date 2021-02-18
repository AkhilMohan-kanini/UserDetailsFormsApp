
namespace UserDetailsFormsApp
{
    partial class Form1
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
            this.UserDetailsGridView = new System.Windows.Forms.DataGridView();
            this.DbConnCheck = new System.Windows.Forms.Label();
            this.countButton = new System.Windows.Forms.Button();
            this.countResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDetailsGridView
            // 
            this.UserDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDetailsGridView.Location = new System.Drawing.Point(328, 12);
            this.UserDetailsGridView.Name = "UserDetailsGridView";
            this.UserDetailsGridView.Size = new System.Drawing.Size(460, 350);
            this.UserDetailsGridView.TabIndex = 0;
            // 
            // DbConnCheck
            // 
            this.DbConnCheck.AutoSize = true;
            this.DbConnCheck.Location = new System.Drawing.Point(122, 34);
            this.DbConnCheck.Name = "DbConnCheck";
            this.DbConnCheck.Size = new System.Drawing.Size(35, 13);
            this.DbConnCheck.TabIndex = 1;
            this.DbConnCheck.Text = "label1";
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(134, 98);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 2;
            this.countButton.Text = "Count Users";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // countResultLabel
            // 
            this.countResultLabel.AutoSize = true;
            this.countResultLabel.Location = new System.Drawing.Point(97, 187);
            this.countResultLabel.Name = "countResultLabel";
            this.countResultLabel.Size = new System.Drawing.Size(188, 13);
            this.countResultLabel.TabIndex = 3;
            this.countResultLabel.Text = "Click Count Users to know User Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countResultLabel);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.DbConnCheck);
            this.Controls.Add(this.UserDetailsGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDetailsGridView;
        private System.Windows.Forms.Label DbConnCheck;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label countResultLabel;
    }
}

