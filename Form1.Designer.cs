namespace MultiProgressBar
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
            this.components = new System.ComponentModel.Container();
            this.btn_Start_Stop = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.multiProgressBar6 = new MultiProgressBar.Controls.MultiProgressBar();
            this.multiProgressBar5 = new MultiProgressBar.Controls.MultiProgressBar();
            this.multiProgressBar4 = new MultiProgressBar.Controls.MultiProgressBar();
            this.multiProgressBar3 = new MultiProgressBar.Controls.MultiProgressBar();
            this.multiProgressBar2 = new MultiProgressBar.Controls.MultiProgressBar();
            this.multiProgressBar1 = new MultiProgressBar.Controls.MultiProgressBar();
            this.SuspendLayout();
            // 
            // btn_Start_Stop
            // 
            this.btn_Start_Stop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Start_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start_Stop.Location = new System.Drawing.Point(12, 364);
            this.btn_Start_Stop.Name = "btn_Start_Stop";
            this.btn_Start_Stop.Size = new System.Drawing.Size(700, 43);
            this.btn_Start_Stop.TabIndex = 6;
            this.btn_Start_Stop.Text = "Start";
            this.btn_Start_Stop.UseVisualStyleBackColor = false;
            this.btn_Start_Stop.Click += new System.EventHandler(this.btn_Start_Stop_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // multiProgressBar6
            // 
            this.multiProgressBar6.Bar_Direction = MultiProgressBar.Controls.MultiProgressBar.Direction.Forward;
            this.multiProgressBar6.Bar_Type = MultiProgressBar.Controls.MultiProgressBar.BarType.Horizontal;
            this.multiProgressBar6.BarShapeEnd = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.multiProgressBar6.BarShapeStart = System.Drawing.Drawing2D.LineCap.Flat;
            this.multiProgressBar6.BorderWidth = 5;
            this.multiProgressBar6.ColorBarBackground = System.Drawing.Color.SkyBlue;
            this.multiProgressBar6.ColorBarBorder = System.Drawing.Color.Yellow;
            this.multiProgressBar6.ColorBarGradient1 = System.Drawing.Color.Black;
            this.multiProgressBar6.ColorBarGradient2 = System.Drawing.Color.Red;
            this.multiProgressBar6.ColorBMPBackground = System.Drawing.Color.Transparent;
            this.multiProgressBar6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.multiProgressBar6.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.multiProgressBar6.LineWidth = 20;
            this.multiProgressBar6.Location = new System.Drawing.Point(372, 318);
            this.multiProgressBar6.Max_Val = 100;
            this.multiProgressBar6.Min_Val = 0;
            this.multiProgressBar6.MinimumSize = new System.Drawing.Size(50, 20);
            this.multiProgressBar6.Name = "multiProgressBar6";
            this.multiProgressBar6.Size = new System.Drawing.Size(340, 40);
            this.multiProgressBar6.TabIndex = 5;
            this.multiProgressBar6.TextType = MultiProgressBar.Controls.MultiProgressBar.TextMode.None;
            this.multiProgressBar6.Value = 25;
            // 
            // multiProgressBar5
            // 
            this.multiProgressBar5.Bar_Direction = MultiProgressBar.Controls.MultiProgressBar.Direction.Backward;
            this.multiProgressBar5.Bar_Type = MultiProgressBar.Controls.MultiProgressBar.BarType.Horizontal;
            this.multiProgressBar5.BarShapeEnd = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.multiProgressBar5.BarShapeStart = System.Drawing.Drawing2D.LineCap.Flat;
            this.multiProgressBar5.BorderWidth = 5;
            this.multiProgressBar5.ColorBarBackground = System.Drawing.Color.SkyBlue;
            this.multiProgressBar5.ColorBarBorder = System.Drawing.Color.Green;
            this.multiProgressBar5.ColorBarGradient1 = System.Drawing.Color.Red;
            this.multiProgressBar5.ColorBarGradient2 = System.Drawing.Color.Black;
            this.multiProgressBar5.ColorBMPBackground = System.Drawing.Color.Transparent;
            this.multiProgressBar5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.multiProgressBar5.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.multiProgressBar5.LineWidth = 20;
            this.multiProgressBar5.Location = new System.Drawing.Point(12, 318);
            this.multiProgressBar5.Max_Val = 100;
            this.multiProgressBar5.Min_Val = 0;
            this.multiProgressBar5.MinimumSize = new System.Drawing.Size(50, 20);
            this.multiProgressBar5.Name = "multiProgressBar5";
            this.multiProgressBar5.Size = new System.Drawing.Size(340, 40);
            this.multiProgressBar5.TabIndex = 4;
            this.multiProgressBar5.TextType = MultiProgressBar.Controls.MultiProgressBar.TextMode.Value;
            this.multiProgressBar5.Value = 25;
            // 
            // multiProgressBar4
            // 
            this.multiProgressBar4.Bar_Direction = MultiProgressBar.Controls.MultiProgressBar.Direction.Forward;
            this.multiProgressBar4.Bar_Type = MultiProgressBar.Controls.MultiProgressBar.BarType.Vertical;
            this.multiProgressBar4.BarShapeEnd = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.multiProgressBar4.BarShapeStart = System.Drawing.Drawing2D.LineCap.Flat;
            this.multiProgressBar4.BorderWidth = 5;
            this.multiProgressBar4.ColorBarBackground = System.Drawing.Color.Blue;
            this.multiProgressBar4.ColorBarBorder = System.Drawing.Color.HotPink;
            this.multiProgressBar4.ColorBarGradient1 = System.Drawing.Color.Red;
            this.multiProgressBar4.ColorBarGradient2 = System.Drawing.Color.Orange;
            this.multiProgressBar4.ColorBMPBackground = System.Drawing.Color.Transparent;
            this.multiProgressBar4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.multiProgressBar4.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.multiProgressBar4.LineWidth = 20;
            this.multiProgressBar4.Location = new System.Drawing.Point(672, 12);
            this.multiProgressBar4.Max_Val = 100;
            this.multiProgressBar4.Min_Val = 0;
            this.multiProgressBar4.MinimumSize = new System.Drawing.Size(20, 50);
            this.multiProgressBar4.Name = "multiProgressBar4";
            this.multiProgressBar4.Size = new System.Drawing.Size(40, 300);
            this.multiProgressBar4.TabIndex = 3;
            this.multiProgressBar4.TextType = MultiProgressBar.Controls.MultiProgressBar.TextMode.Value;
            this.multiProgressBar4.Value = 25;
            // 
            // multiProgressBar3
            // 
            this.multiProgressBar3.Bar_Direction = MultiProgressBar.Controls.MultiProgressBar.Direction.Backward;
            this.multiProgressBar3.Bar_Type = MultiProgressBar.Controls.MultiProgressBar.BarType.Vertical;
            this.multiProgressBar3.BarShapeEnd = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.multiProgressBar3.BarShapeStart = System.Drawing.Drawing2D.LineCap.Flat;
            this.multiProgressBar3.BorderWidth = 5;
            this.multiProgressBar3.ColorBarBackground = System.Drawing.Color.Fuchsia;
            this.multiProgressBar3.ColorBarBorder = System.Drawing.Color.DarkGreen;
            this.multiProgressBar3.ColorBarGradient1 = System.Drawing.Color.Black;
            this.multiProgressBar3.ColorBarGradient2 = System.Drawing.Color.LightGray;
            this.multiProgressBar3.ColorBMPBackground = System.Drawing.Color.Transparent;
            this.multiProgressBar3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.multiProgressBar3.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.multiProgressBar3.LineWidth = 20;
            this.multiProgressBar3.Location = new System.Drawing.Point(624, 12);
            this.multiProgressBar3.Max_Val = 100;
            this.multiProgressBar3.Min_Val = 0;
            this.multiProgressBar3.MinimumSize = new System.Drawing.Size(20, 50);
            this.multiProgressBar3.Name = "multiProgressBar3";
            this.multiProgressBar3.Size = new System.Drawing.Size(40, 300);
            this.multiProgressBar3.TabIndex = 2;
            this.multiProgressBar3.TextType = MultiProgressBar.Controls.MultiProgressBar.TextMode.None;
            this.multiProgressBar3.Value = 25;
            // 
            // multiProgressBar2
            // 
            this.multiProgressBar2.Bar_Direction = MultiProgressBar.Controls.MultiProgressBar.Direction.Backward;
            this.multiProgressBar2.Bar_Type = MultiProgressBar.Controls.MultiProgressBar.BarType.Circle;
            this.multiProgressBar2.BarShapeEnd = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.multiProgressBar2.BarShapeStart = System.Drawing.Drawing2D.LineCap.Flat;
            this.multiProgressBar2.BorderWidth = 5;
            this.multiProgressBar2.ColorBarBackground = System.Drawing.Color.Yellow;
            this.multiProgressBar2.ColorBarBorder = System.Drawing.Color.SaddleBrown;
            this.multiProgressBar2.ColorBarGradient1 = System.Drawing.Color.Red;
            this.multiProgressBar2.ColorBarGradient2 = System.Drawing.Color.Green;
            this.multiProgressBar2.ColorBMPBackground = System.Drawing.Color.Transparent;
            this.multiProgressBar2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.multiProgressBar2.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.multiProgressBar2.LineWidth = 20;
            this.multiProgressBar2.Location = new System.Drawing.Point(318, 12);
            this.multiProgressBar2.Max_Val = 100;
            this.multiProgressBar2.Min_Val = 0;
            this.multiProgressBar2.MinimumSize = new System.Drawing.Size(60, 60);
            this.multiProgressBar2.Name = "multiProgressBar2";
            this.multiProgressBar2.Size = new System.Drawing.Size(300, 300);
            this.multiProgressBar2.TabIndex = 1;
            this.multiProgressBar2.TextType = MultiProgressBar.Controls.MultiProgressBar.TextMode.Percentage;
            this.multiProgressBar2.Value = 25;
            // 
            // multiProgressBar1
            // 
            this.multiProgressBar1.Bar_Direction = MultiProgressBar.Controls.MultiProgressBar.Direction.Forward;
            this.multiProgressBar1.Bar_Type = MultiProgressBar.Controls.MultiProgressBar.BarType.Circle;
            this.multiProgressBar1.BarShapeEnd = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.multiProgressBar1.BarShapeStart = System.Drawing.Drawing2D.LineCap.Flat;
            this.multiProgressBar1.BorderWidth = 5;
            this.multiProgressBar1.ColorBarBackground = System.Drawing.Color.Transparent;
            this.multiProgressBar1.ColorBarBorder = System.Drawing.Color.Chartreuse;
            this.multiProgressBar1.ColorBarGradient1 = System.Drawing.Color.Red;
            this.multiProgressBar1.ColorBarGradient2 = System.Drawing.Color.Red;
            this.multiProgressBar1.ColorBMPBackground = System.Drawing.Color.MediumPurple;
            this.multiProgressBar1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.multiProgressBar1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.multiProgressBar1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.multiProgressBar1.LineWidth = 20;
            this.multiProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.multiProgressBar1.Max_Val = 100;
            this.multiProgressBar1.Min_Val = 0;
            this.multiProgressBar1.MinimumSize = new System.Drawing.Size(60, 60);
            this.multiProgressBar1.Name = "multiProgressBar1";
            this.multiProgressBar1.Size = new System.Drawing.Size(300, 300);
            this.multiProgressBar1.TabIndex = 0;
            this.multiProgressBar1.TextType = MultiProgressBar.Controls.MultiProgressBar.TextMode.Value;
            this.multiProgressBar1.Value = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(728, 423);
            this.Controls.Add(this.btn_Start_Stop);
            this.Controls.Add(this.multiProgressBar6);
            this.Controls.Add(this.multiProgressBar5);
            this.Controls.Add(this.multiProgressBar4);
            this.Controls.Add(this.multiProgressBar3);
            this.Controls.Add(this.multiProgressBar2);
            this.Controls.Add(this.multiProgressBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Multiple Progress Bar Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MultiProgressBar multiProgressBar1;
        private Controls.MultiProgressBar multiProgressBar2;
        private Controls.MultiProgressBar multiProgressBar3;
        private Controls.MultiProgressBar multiProgressBar4;
        private Controls.MultiProgressBar multiProgressBar5;
        private Controls.MultiProgressBar multiProgressBar6;
        private System.Windows.Forms.Button btn_Start_Stop;
        private System.Windows.Forms.Timer MainTimer;
    }
}

