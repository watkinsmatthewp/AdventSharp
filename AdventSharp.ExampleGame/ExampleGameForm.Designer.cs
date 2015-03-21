namespace AdventSharp.ExampleGame
{
    partial class ExampleGameForm
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtCurrentLocationDescription = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtCommandResult = new System.Windows.Forms.TextBox();
            this.lbl_CurrentLocation = new System.Windows.Forms.Label();
            this.lblCommandResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.Location = new System.Drawing.Point(13, 13);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(366, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyUp);
            // 
            // txtCurrentLocationDescription
            // 
            this.txtCurrentLocationDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentLocationDescription.BackColor = System.Drawing.Color.White;
            this.txtCurrentLocationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentLocationDescription.Location = new System.Drawing.Point(13, 147);
            this.txtCurrentLocationDescription.Multiline = true;
            this.txtCurrentLocationDescription.Name = "txtCurrentLocationDescription";
            this.txtCurrentLocationDescription.ReadOnly = true;
            this.txtCurrentLocationDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrentLocationDescription.Size = new System.Drawing.Size(447, 145);
            this.txtCurrentLocationDescription.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(385, 11);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // txtCommandResult
            // 
            this.txtCommandResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandResult.BackColor = System.Drawing.Color.White;
            this.txtCommandResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandResult.Location = new System.Drawing.Point(12, 56);
            this.txtCommandResult.Multiline = true;
            this.txtCommandResult.Name = "txtCommandResult";
            this.txtCommandResult.ReadOnly = true;
            this.txtCommandResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommandResult.Size = new System.Drawing.Size(447, 63);
            this.txtCommandResult.TabIndex = 3;
            // 
            // lbl_CurrentLocation
            // 
            this.lbl_CurrentLocation.AutoSize = true;
            this.lbl_CurrentLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentLocation.Location = new System.Drawing.Point(12, 131);
            this.lbl_CurrentLocation.Name = "lbl_CurrentLocation";
            this.lbl_CurrentLocation.Size = new System.Drawing.Size(101, 13);
            this.lbl_CurrentLocation.TabIndex = 4;
            this.lbl_CurrentLocation.Text = "Current Location";
            // 
            // lblCommandResult
            // 
            this.lblCommandResult.AutoSize = true;
            this.lblCommandResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommandResult.Location = new System.Drawing.Point(9, 40);
            this.lblCommandResult.Name = "lblCommandResult";
            this.lblCommandResult.Size = new System.Drawing.Size(101, 13);
            this.lblCommandResult.TabIndex = 5;
            this.lblCommandResult.Text = "Command Result";
            // 
            // ExampleGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 304);
            this.Controls.Add(this.lblCommandResult);
            this.Controls.Add(this.lbl_CurrentLocation);
            this.Controls.Add(this.txtCommandResult);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtCurrentLocationDescription);
            this.Controls.Add(this.txtCommand);
            this.Name = "ExampleGameForm";
            this.Text = "ExampleGameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtCurrentLocationDescription;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtCommandResult;
        private System.Windows.Forms.Label lbl_CurrentLocation;
        private System.Windows.Forms.Label lblCommandResult;
    }
}