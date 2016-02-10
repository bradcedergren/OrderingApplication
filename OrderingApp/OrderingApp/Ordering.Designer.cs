namespace OrderingApp
{
    partial class Ordering
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
            this.pnlStart = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.pnlOrderType = new System.Windows.Forms.Panel();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.pnlPrevNext = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pnlStart.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.pnlOrderType.SuspendLayout();
            this.pnlPrevNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.BackColor = System.Drawing.Color.White;
            this.pnlStart.Controls.Add(this.lblStart);
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Location = new System.Drawing.Point(306, 12);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(918, 764);
            this.pnlStart.TabIndex = 0;
            this.pnlStart.VisibleChanged += new System.EventHandler(this.pnlStart_VisibleChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(242, 128);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(435, 73);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Touch to Start";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(321, 311);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(277, 131);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlLocation
            // 
            this.pnlLocation.BackColor = System.Drawing.Color.White;
            this.pnlLocation.Controls.Add(this.lblLocation);
            this.pnlLocation.Controls.Add(this.btnOut);
            this.pnlLocation.Controls.Add(this.btnIn);
            this.pnlLocation.Location = new System.Drawing.Point(306, 12);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(915, 764);
            this.pnlLocation.TabIndex = 1;
            this.pnlLocation.VisibleChanged += new System.EventHandler(this.pnlLocation_VisibleChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(219, 128);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(476, 73);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Eating Location";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(608, 311);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 65);
            this.btnOut.TabIndex = 1;
            this.btnOut.Text = "Out";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(236, 311);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 65);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // pnlOrderType
            // 
            this.pnlOrderType.BackColor = System.Drawing.Color.White;
            this.pnlOrderType.Controls.Add(this.lblOrderType);
            this.pnlOrderType.Location = new System.Drawing.Point(306, 12);
            this.pnlOrderType.Name = "pnlOrderType";
            this.pnlOrderType.Size = new System.Drawing.Size(918, 566);
            this.pnlOrderType.TabIndex = 2;
            this.pnlOrderType.Visible = false;
            this.pnlOrderType.VisibleChanged += new System.EventHandler(this.pnlOrderType_VisibleChanged);
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(187, 128);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(550, 73);
            this.lblOrderType.TabIndex = 0;
            this.lblOrderType.Text = "Choose an Option";
            // 
            // pnlPrevNext
            // 
            this.pnlPrevNext.Controls.Add(this.btnNext);
            this.pnlPrevNext.Controls.Add(this.btnPrev);
            this.pnlPrevNext.Location = new System.Drawing.Point(306, 584);
            this.pnlPrevNext.Name = "pnlPrevNext";
            this.pnlPrevNext.Size = new System.Drawing.Size(918, 192);
            this.pnlPrevNext.TabIndex = 3;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(779, 49);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 82);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(49, 49);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 82);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "< Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 788);
            this.Controls.Add(this.pnlStart);
            this.Controls.Add(this.pnlLocation);
            this.Controls.Add(this.pnlOrderType);
            this.Controls.Add(this.pnlPrevNext);
            this.Name = "Ordering";
            this.Text = "Ordering";
            this.Load += new System.EventHandler(this.Ordering_Load);
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.pnlOrderType.ResumeLayout(false);
            this.pnlOrderType.PerformLayout();
            this.pnlPrevNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Panel pnlOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Panel pnlPrevNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;

    }
}

