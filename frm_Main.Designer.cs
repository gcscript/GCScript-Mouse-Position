namespace GCScript_Mouse_Position
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_Move = new System.Windows.Forms.Button();
            this.nud_X = new System.Windows.Forms.NumericUpDown();
            this.nud_Y = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Speed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Move
            // 
            this.btn_Move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Move.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Move.Location = new System.Drawing.Point(12, 65);
            this.btn_Move.Name = "btn_Move";
            this.btn_Move.Size = new System.Drawing.Size(313, 46);
            this.btn_Move.TabIndex = 0;
            this.btn_Move.Text = "Move";
            this.btn_Move.UseVisualStyleBackColor = true;
            this.btn_Move.Click += new System.EventHandler(this.btn_Move_Click);
            // 
            // nud_X
            // 
            this.nud_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_X.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_X.Location = new System.Drawing.Point(12, 33);
            this.nud_X.Maximum = new decimal(new int[] {
            7680,
            0,
            0,
            0});
            this.nud_X.Name = "nud_X";
            this.nud_X.Size = new System.Drawing.Size(100, 26);
            this.nud_X.TabIndex = 1;
            this.nud_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nud_Y
            // 
            this.nud_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_Y.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_Y.Location = new System.Drawing.Point(118, 33);
            this.nud_Y.Maximum = new decimal(new int[] {
            4320,
            0,
            0,
            0});
            this.nud_Y.Name = "nud_Y";
            this.nud_Y.Size = new System.Drawing.Size(100, 26);
            this.nud_Y.TabIndex = 2;
            this.nud_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(225, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Speed";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nud_Speed
            // 
            this.nud_Speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_Speed.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_Speed.Location = new System.Drawing.Point(225, 33);
            this.nud_Speed.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nud_Speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nud_Speed.Name = "nud_Speed";
            this.nud_Speed.Size = new System.Drawing.Size(100, 26);
            this.nud_Speed.TabIndex = 5;
            this.nud_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Developed by GCScript";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 140);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_Speed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_Y);
            this.Controls.Add(this.nud_X);
            this.Controls.Add(this.btn_Move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GCScript";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nud_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Speed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Move;
        private NumericUpDown nud_X;
        private NumericUpDown nud_Y;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown nud_Speed;
        private Label label4;
    }
}