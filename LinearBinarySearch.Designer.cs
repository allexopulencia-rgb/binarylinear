namespace OpulenciaLinearBinary
{
    partial class LinearBinarySearch
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
            this.components = new System.ComponentModel.Container();
            this.grpBinary = new System.Windows.Forms.GroupBox();
            this.lblBinaryStatus = new System.Windows.Forms.Label();
            this.btnBinaryStart = new System.Windows.Forms.Button();
            this.panelBinary = new System.Windows.Forms.FlowLayoutPanel();
            this.grpLinear = new System.Windows.Forms.GroupBox();
            this.lblLinearStatus = new System.Windows.Forms.Label();
            this.panelLinear = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLinearStart = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.timerLinear = new System.Windows.Forms.Timer(this.components);
            this.timerBinary = new System.Windows.Forms.Timer(this.components);
            this.grpBinary.SuspendLayout();
            this.grpLinear.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBinary
            // 
            this.grpBinary.Controls.Add(this.lblBinaryStatus);
            this.grpBinary.Controls.Add(this.btnBinaryStart);
            this.grpBinary.Controls.Add(this.panelBinary);
            this.grpBinary.Location = new System.Drawing.Point(58, 434);
            this.grpBinary.Name = "grpBinary";
            this.grpBinary.Size = new System.Drawing.Size(676, 244);
            this.grpBinary.TabIndex = 17;
            this.grpBinary.TabStop = false;
            this.grpBinary.Text = "Binary Search";
            // 
            // lblBinaryStatus
            // 
            this.lblBinaryStatus.AutoSize = true;
            this.lblBinaryStatus.Location = new System.Drawing.Point(15, 192);
            this.lblBinaryStatus.Name = "lblBinaryStatus";
            this.lblBinaryStatus.Size = new System.Drawing.Size(115, 16);
            this.lblBinaryStatus.TabIndex = 7;
            this.lblBinaryStatus.Text = "BINARY STATUS";
            // 
            // btnBinaryStart
            // 
            this.btnBinaryStart.Location = new System.Drawing.Point(542, 34);
            this.btnBinaryStart.Name = "btnBinaryStart";
            this.btnBinaryStart.Size = new System.Drawing.Size(98, 32);
            this.btnBinaryStart.TabIndex = 5;
            this.btnBinaryStart.Text = "SEARCH";
            this.btnBinaryStart.UseVisualStyleBackColor = true;
            this.btnBinaryStart.Click += new System.EventHandler(this.btnBinaryStart_Click);
            // 
            // panelBinary
            // 
            this.panelBinary.Location = new System.Drawing.Point(17, 84);
            this.panelBinary.Name = "panelBinary";
            this.panelBinary.Size = new System.Drawing.Size(632, 50);
            this.panelBinary.TabIndex = 6;
            this.panelBinary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBinary_Paint);
            // 
            // grpLinear
            // 
            this.grpLinear.Controls.Add(this.lblLinearStatus);
            this.grpLinear.Controls.Add(this.panelLinear);
            this.grpLinear.Controls.Add(this.btnLinearStart);
            this.grpLinear.Location = new System.Drawing.Point(58, 179);
            this.grpLinear.Name = "grpLinear";
            this.grpLinear.Size = new System.Drawing.Size(676, 227);
            this.grpLinear.TabIndex = 16;
            this.grpLinear.TabStop = false;
            this.grpLinear.Text = "Linear Search";
            // 
            // lblLinearStatus
            // 
            this.lblLinearStatus.AutoSize = true;
            this.lblLinearStatus.Location = new System.Drawing.Point(17, 178);
            this.lblLinearStatus.Name = "lblLinearStatus";
            this.lblLinearStatus.Size = new System.Drawing.Size(113, 16);
            this.lblLinearStatus.TabIndex = 10;
            this.lblLinearStatus.Text = "LINEAR STATUS";
            // 
            // panelLinear
            // 
            this.panelLinear.Location = new System.Drawing.Point(18, 85);
            this.panelLinear.Name = "panelLinear";
            this.panelLinear.Size = new System.Drawing.Size(631, 48);
            this.panelLinear.TabIndex = 1;
            this.panelLinear.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLinear_Paint);
            // 
            // btnLinearStart
            // 
            this.btnLinearStart.Location = new System.Drawing.Point(546, 39);
            this.btnLinearStart.Name = "btnLinearStart";
            this.btnLinearStart.Size = new System.Drawing.Size(94, 29);
            this.btnLinearStart.TabIndex = 0;
            this.btnLinearStart.Text = "SEARCH";
            this.btnLinearStart.UseVisualStyleBackColor = true;
            this.btnLinearStart.Click += new System.EventHandler(this.btnLinearStart_Click_1);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(164, 122);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(201, 22);
            this.txtTarget.TabIndex = 15;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(51, 128);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(107, 16);
            this.lblTarget.TabIndex = 14;
            this.lblTarget.Text = "TARGET INPUT";
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(105, 62);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(201, 22);
            this.txtArray.TabIndex = 13;
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(51, 65);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(48, 16);
            this.lblArray.TabIndex = 12;
            this.lblArray.Text = "INPUT";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(950, 611);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 47);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // timerLinear
            // 
            this.timerLinear.Interval = 1000;
            this.timerLinear.Tick += new System.EventHandler(this.timerLinear_Tick);
            // 
            // timerBinary
            // 
            this.timerBinary.Interval = 1000;
            this.timerBinary.Tick += new System.EventHandler(this.timerBinary_Tick);
            // 
            // LinearBinarySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 740);
            this.Controls.Add(this.grpBinary);
            this.Controls.Add(this.grpLinear);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.btnBack);
            this.Name = "LinearBinarySearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LinearBinarySearch_Load);
            this.grpBinary.ResumeLayout(false);
            this.grpBinary.PerformLayout();
            this.grpLinear.ResumeLayout(false);
            this.grpLinear.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBinary;
        private System.Windows.Forms.Label lblBinaryStatus;
        private System.Windows.Forms.Button btnBinaryStart;
        private System.Windows.Forms.FlowLayoutPanel panelBinary;
        private System.Windows.Forms.GroupBox grpLinear;
        private System.Windows.Forms.Label lblLinearStatus;
        private System.Windows.Forms.FlowLayoutPanel panelLinear;
        private System.Windows.Forms.Button btnLinearStart;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timerLinear;
        private System.Windows.Forms.Timer timerBinary;
    }
}

