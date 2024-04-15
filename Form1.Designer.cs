namespace graphics_lab_4
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
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBarStacks = new System.Windows.Forms.TrackBar();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.trackBarSlices = new System.Windows.Forms.TrackBar();
            this.trackBarHeight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarAngle = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxZ = new System.Windows.Forms.CheckBox();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxScalingZ = new System.Windows.Forms.CheckBox();
            this.checkBoxScalingY = new System.Windows.Forms.CheckBox();
            this.checkBoxScalingX = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStacks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSlices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(333, 12);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(455, 426);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Визуализировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Куб",
            "Сфера",
            "Цилиндр",
            "Конус"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // trackBarStacks
            // 
            this.trackBarStacks.LargeChange = 2;
            this.trackBarStacks.Location = new System.Drawing.Point(221, 100);
            this.trackBarStacks.Maximum = 20;
            this.trackBarStacks.Minimum = 2;
            this.trackBarStacks.Name = "trackBarStacks";
            this.trackBarStacks.Size = new System.Drawing.Size(106, 45);
            this.trackBarStacks.TabIndex = 5;
            this.trackBarStacks.TickFrequency = 2;
            this.trackBarStacks.Value = 16;
            this.trackBarStacks.Scroll += new System.EventHandler(this.trackBarStacks_Scroll);
            // 
            // trackBarSize
            // 
            this.trackBarSize.LargeChange = 200;
            this.trackBarSize.Location = new System.Drawing.Point(221, 49);
            this.trackBarSize.Maximum = 2000;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(106, 45);
            this.trackBarSize.TabIndex = 4;
            this.trackBarSize.TickFrequency = 200;
            this.trackBarSize.Value = 1000;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // trackBarSlices
            // 
            this.trackBarSlices.LargeChange = 2;
            this.trackBarSlices.Location = new System.Drawing.Point(221, 151);
            this.trackBarSlices.Maximum = 20;
            this.trackBarSlices.Minimum = 2;
            this.trackBarSlices.Name = "trackBarSlices";
            this.trackBarSlices.Size = new System.Drawing.Size(106, 45);
            this.trackBarSlices.TabIndex = 6;
            this.trackBarSlices.TickFrequency = 2;
            this.trackBarSlices.Value = 16;
            this.trackBarSlices.Scroll += new System.EventHandler(this.trackBarSlices_Scroll);
            // 
            // trackBarHeight
            // 
            this.trackBarHeight.Location = new System.Drawing.Point(221, 202);
            this.trackBarHeight.Maximum = 20;
            this.trackBarHeight.Minimum = 2;
            this.trackBarHeight.Name = "trackBarHeight";
            this.trackBarHeight.Size = new System.Drawing.Size(106, 45);
            this.trackBarHeight.TabIndex = 7;
            this.trackBarHeight.TickFrequency = 2;
            this.trackBarHeight.Value = 3;
            this.trackBarHeight.Scroll += new System.EventHandler(this.trackBarHeight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // trackBarAngle
            // 
            this.trackBarAngle.LargeChange = 15;
            this.trackBarAngle.Location = new System.Drawing.Point(221, 253);
            this.trackBarAngle.Maximum = 359;
            this.trackBarAngle.Name = "trackBarAngle";
            this.trackBarAngle.Size = new System.Drawing.Size(106, 45);
            this.trackBarAngle.TabIndex = 12;
            this.trackBarAngle.TickFrequency = 45;
            this.trackBarAngle.Value = 45;
            this.trackBarAngle.Scroll += new System.EventHandler(this.trackBarAngle_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 253);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Checked = true;
            this.checkBoxX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX.Location = new System.Drawing.Point(216, 304);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(33, 17);
            this.checkBoxX.TabIndex = 14;
            this.checkBoxX.Text = "X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Checked = true;
            this.checkBoxY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxY.Location = new System.Drawing.Point(255, 304);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(33, 17);
            this.checkBoxY.TabIndex = 15;
            this.checkBoxY.Text = "Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // checkBoxZ
            // 
            this.checkBoxZ.AutoSize = true;
            this.checkBoxZ.Location = new System.Drawing.Point(294, 304);
            this.checkBoxZ.Name = "checkBoxZ";
            this.checkBoxZ.Size = new System.Drawing.Size(33, 17);
            this.checkBoxZ.TabIndex = 16;
            this.checkBoxZ.Text = "Z";
            this.checkBoxZ.UseVisualStyleBackColor = true;
            // 
            // trackBarScale
            // 
            this.trackBarScale.LargeChange = 100;
            this.trackBarScale.Location = new System.Drawing.Point(221, 332);
            this.trackBarScale.Maximum = 5000;
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(106, 45);
            this.trackBarScale.TabIndex = 17;
            this.trackBarScale.TickFrequency = 1000;
            this.trackBarScale.Value = 1000;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 332);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // checkBoxScalingZ
            // 
            this.checkBoxScalingZ.AutoSize = true;
            this.checkBoxScalingZ.Checked = true;
            this.checkBoxScalingZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScalingZ.Location = new System.Drawing.Point(294, 383);
            this.checkBoxScalingZ.Name = "checkBoxScalingZ";
            this.checkBoxScalingZ.Size = new System.Drawing.Size(33, 17);
            this.checkBoxScalingZ.TabIndex = 21;
            this.checkBoxScalingZ.Text = "Z";
            this.checkBoxScalingZ.UseVisualStyleBackColor = true;
            // 
            // checkBoxScalingY
            // 
            this.checkBoxScalingY.AutoSize = true;
            this.checkBoxScalingY.Checked = true;
            this.checkBoxScalingY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScalingY.Location = new System.Drawing.Point(255, 383);
            this.checkBoxScalingY.Name = "checkBoxScalingY";
            this.checkBoxScalingY.Size = new System.Drawing.Size(33, 17);
            this.checkBoxScalingY.TabIndex = 20;
            this.checkBoxScalingY.Text = "Y";
            this.checkBoxScalingY.UseVisualStyleBackColor = true;
            // 
            // checkBoxScalingX
            // 
            this.checkBoxScalingX.AutoSize = true;
            this.checkBoxScalingX.Checked = true;
            this.checkBoxScalingX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScalingX.Location = new System.Drawing.Point(216, 383);
            this.checkBoxScalingX.Name = "checkBoxScalingX";
            this.checkBoxScalingX.Size = new System.Drawing.Size(33, 17);
            this.checkBoxScalingX.TabIndex = 19;
            this.checkBoxScalingX.Text = "X";
            this.checkBoxScalingX.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxScalingZ);
            this.Controls.Add(this.checkBoxScalingY);
            this.Controls.Add(this.checkBoxScalingX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarScale);
            this.Controls.Add(this.checkBoxZ);
            this.Controls.Add(this.checkBoxY);
            this.Controls.Add(this.checkBoxX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarAngle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarHeight);
            this.Controls.Add(this.trackBarSlices);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.trackBarStacks);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStacks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSlices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar trackBarStacks;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.TrackBar trackBarSlices;
        private System.Windows.Forms.TrackBar trackBarHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarAngle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxZ;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxScalingZ;
        private System.Windows.Forms.CheckBox checkBoxScalingY;
        private System.Windows.Forms.CheckBox checkBoxScalingX;
    }
}

