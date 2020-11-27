namespace duPiesanieJuandreDecisionInc
{
    partial class FrmBoatSimulation
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
            this.RtbPerimeter = new System.Windows.Forms.RichTextBox();
            this.LblQueue = new System.Windows.Forms.Label();
            this.BtnEndSimulation = new System.Windows.Forms.Button();
            this.BtnStartSimulation = new System.Windows.Forms.Button();
            this.TxtNextInLine = new System.Windows.Forms.TextBox();
            this.LblWindSpeed = new System.Windows.Forms.Label();
            this.LblCurrWindSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RtbPerimeter
            // 
            this.RtbPerimeter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbPerimeter.Location = new System.Drawing.Point(3, 9);
            this.RtbPerimeter.Name = "RtbPerimeter";
            this.RtbPerimeter.Size = new System.Drawing.Size(596, 281);
            this.RtbPerimeter.TabIndex = 0;
            this.RtbPerimeter.Text = "";
            // 
            // LblQueue
            // 
            this.LblQueue.AutoSize = true;
            this.LblQueue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQueue.Location = new System.Drawing.Point(615, 12);
            this.LblQueue.Name = "LblQueue";
            this.LblQueue.Size = new System.Drawing.Size(88, 18);
            this.LblQueue.TabIndex = 4;
            this.LblQueue.Text = "Next In Line";
            // 
            // BtnEndSimulation
            // 
            this.BtnEndSimulation.Location = new System.Drawing.Point(672, 139);
            this.BtnEndSimulation.Name = "BtnEndSimulation";
            this.BtnEndSimulation.Size = new System.Drawing.Size(135, 29);
            this.BtnEndSimulation.TabIndex = 5;
            this.BtnEndSimulation.Text = "End Simulation";
            this.BtnEndSimulation.UseVisualStyleBackColor = true;
            this.BtnEndSimulation.Click += new System.EventHandler(this.BtnEndSimulation_Click);
            // 
            // BtnStartSimulation
            // 
            this.BtnStartSimulation.Location = new System.Drawing.Point(672, 91);
            this.BtnStartSimulation.Name = "BtnStartSimulation";
            this.BtnStartSimulation.Size = new System.Drawing.Size(135, 29);
            this.BtnStartSimulation.TabIndex = 6;
            this.BtnStartSimulation.Text = "Start Simulation";
            this.BtnStartSimulation.UseVisualStyleBackColor = true;
            this.BtnStartSimulation.Click += new System.EventHandler(this.BtnStartSimulation_Click);
            // 
            // TxtNextInLine
            // 
            this.TxtNextInLine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNextInLine.Location = new System.Drawing.Point(618, 39);
            this.TxtNextInLine.Name = "TxtNextInLine";
            this.TxtNextInLine.Size = new System.Drawing.Size(189, 26);
            this.TxtNextInLine.TabIndex = 7;
            // 
            // LblWindSpeed
            // 
            this.LblWindSpeed.AutoSize = true;
            this.LblWindSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWindSpeed.Location = new System.Drawing.Point(615, 182);
            this.LblWindSpeed.Name = "LblWindSpeed";
            this.LblWindSpeed.Size = new System.Drawing.Size(146, 18);
            this.LblWindSpeed.TabIndex = 8;
            this.LblWindSpeed.Text = "Current WindSpeed";
            // 
            // LblCurrWindSpeed
            // 
            this.LblCurrWindSpeed.AutoSize = true;
            this.LblCurrWindSpeed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrWindSpeed.Location = new System.Drawing.Point(615, 211);
            this.LblCurrWindSpeed.Name = "LblCurrWindSpeed";
            this.LblCurrWindSpeed.Size = new System.Drawing.Size(20, 16);
            this.LblCurrWindSpeed.TabIndex = 9;
            this.LblCurrWindSpeed.Text = "...";
            // 
            // FrmBoatSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 311);
            this.Controls.Add(this.LblCurrWindSpeed);
            this.Controls.Add(this.LblWindSpeed);
            this.Controls.Add(this.TxtNextInLine);
            this.Controls.Add(this.BtnStartSimulation);
            this.Controls.Add(this.BtnEndSimulation);
            this.Controls.Add(this.LblQueue);
            this.Controls.Add(this.RtbPerimeter);
            this.Name = "FrmBoatSimulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boat Simulation";
            this.Load += new System.EventHandler(this.FrmBoatSimulation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtbPerimeter;
        private System.Windows.Forms.Label LblQueue;
        private System.Windows.Forms.Button BtnEndSimulation;
        private System.Windows.Forms.Button BtnStartSimulation;
        private System.Windows.Forms.TextBox TxtNextInLine;
        private System.Windows.Forms.Label LblWindSpeed;
        private System.Windows.Forms.Label LblCurrWindSpeed;
    }
}

