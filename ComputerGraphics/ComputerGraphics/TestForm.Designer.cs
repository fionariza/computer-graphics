namespace ComputerGraphics
{
    partial class TestForm
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
            this.openGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.transX_Plus = new System.Windows.Forms.Button();
            this.transY_Plus = new System.Windows.Forms.Button();
            this.transZ_Plus = new System.Windows.Forms.Button();
            this.transX_Minus = new System.Windows.Forms.Button();
            this.transY_Minus = new System.Windows.Forms.Button();
            this.transZ_Minus = new System.Windows.Forms.Button();
            this.transX_label = new System.Windows.Forms.Label();
            this.transY_label = new System.Windows.Forms.Label();
            this.transZ_label = new System.Windows.Forms.Label();
            this.persFovY_lbl = new System.Windows.Forms.Label();
            this.persAspectRatio_lbl = new System.Windows.Forms.Label();
            this.persZNear_lbl = new System.Windows.Forms.Label();
            this.persZFar_lbl = new System.Windows.Forms.Label();
            this.rotatedAngle_lbl = new System.Windows.Forms.Label();
            this.rotatedX_lbl = new System.Windows.Forms.Label();
            this.rotatedY_lbl = new System.Windows.Forms.Label();
            this.rotatedZ_lbl = new System.Windows.Forms.Label();
            this.persFovY_Plus = new System.Windows.Forms.Button();
            this.persFovY_Minus = new System.Windows.Forms.Button();
            this.persAspectRatio_Plus = new System.Windows.Forms.Button();
            this.persAspectRatio_Minus = new System.Windows.Forms.Button();
            this.persZNear_Plus = new System.Windows.Forms.Button();
            this.persZNear_Minus = new System.Windows.Forms.Button();
            this.persZFar_Plus = new System.Windows.Forms.Button();
            this.persZFar_minus = new System.Windows.Forms.Button();
            this.rotatedAngle_Plus = new System.Windows.Forms.Button();
            this.rotatedAngle_minus = new System.Windows.Forms.Button();
            this.rotatedX_Plus = new System.Windows.Forms.Button();
            this.rotatedX_Minus = new System.Windows.Forms.Button();
            this.rotatedY_Plus = new System.Windows.Forms.Button();
            this.rotatedY_minus = new System.Windows.Forms.Button();
            this.rotatedZ_Plus = new System.Windows.Forms.Button();
            this.rotatedZ_Minus = new System.Windows.Forms.Button();
            this.radius_lbl = new System.Windows.Forms.Label();
            this.height_lbl = new System.Windows.Forms.Label();
            this.slices_lbl = new System.Windows.Forms.Label();
            this.stacks_lbl = new System.Windows.Forms.Label();
            this.radius_Plus = new System.Windows.Forms.Button();
            this.height_Plus = new System.Windows.Forms.Button();
            this.slices_Plus = new System.Windows.Forms.Button();
            this.stacks_Plus = new System.Windows.Forms.Button();
            this.radius_Minus = new System.Windows.Forms.Button();
            this.height_minus = new System.Windows.Forms.Button();
            this.slices_Minus = new System.Windows.Forms.Button();
            this.stacks_Minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openGlControl
            // 
            this.openGlControl.AccumBits = ((byte)(0));
            this.openGlControl.AutoCheckErrors = false;
            this.openGlControl.AutoFinish = false;
            this.openGlControl.AutoMakeCurrent = true;
            this.openGlControl.AutoSwapBuffers = true;
            this.openGlControl.BackColor = System.Drawing.Color.Transparent;
            this.openGlControl.ColorBits = ((byte)(32));
            this.openGlControl.DepthBits = ((byte)(16));
            this.openGlControl.Location = new System.Drawing.Point(9, 9);
            this.openGlControl.Margin = new System.Windows.Forms.Padding(0);
            this.openGlControl.Name = "openGlControl";
            this.openGlControl.Size = new System.Drawing.Size(982, 613);
            this.openGlControl.StencilBits = ((byte)(0));
            this.openGlControl.TabIndex = 0;
            // 
            // transX_Plus
            // 
            this.transX_Plus.Location = new System.Drawing.Point(1194, 8);
            this.transX_Plus.Name = "transX_Plus";
            this.transX_Plus.Size = new System.Drawing.Size(96, 21);
            this.transX_Plus.TabIndex = 1;
            this.transX_Plus.Text = "+";
            this.transX_Plus.UseVisualStyleBackColor = true;
            this.transX_Plus.Click += new System.EventHandler(this.translatedX_Plus_Click);
            // 
            // transY_Plus
            // 
            this.transY_Plus.Location = new System.Drawing.Point(1194, 39);
            this.transY_Plus.Name = "transY_Plus";
            this.transY_Plus.Size = new System.Drawing.Size(96, 21);
            this.transY_Plus.TabIndex = 2;
            this.transY_Plus.Text = "+";
            this.transY_Plus.UseVisualStyleBackColor = true;
            this.transY_Plus.Click += new System.EventHandler(this.translatedY_Plus_Click);
            // 
            // transZ_Plus
            // 
            this.transZ_Plus.Location = new System.Drawing.Point(1194, 66);
            this.transZ_Plus.Name = "transZ_Plus";
            this.transZ_Plus.Size = new System.Drawing.Size(96, 21);
            this.transZ_Plus.TabIndex = 3;
            this.transZ_Plus.Text = "+";
            this.transZ_Plus.UseVisualStyleBackColor = true;
            this.transZ_Plus.Click += new System.EventHandler(this.translatedZ_Plus_Click);
            // 
            // transX_Minus
            // 
            this.transX_Minus.Location = new System.Drawing.Point(1296, 9);
            this.transX_Minus.Name = "transX_Minus";
            this.transX_Minus.Size = new System.Drawing.Size(102, 20);
            this.transX_Minus.TabIndex = 4;
            this.transX_Minus.Text = "-";
            this.transX_Minus.UseVisualStyleBackColor = true;
            this.transX_Minus.Click += new System.EventHandler(this.transX_Minus_Click);
            // 
            // transY_Minus
            // 
            this.transY_Minus.Location = new System.Drawing.Point(1296, 36);
            this.transY_Minus.Name = "transY_Minus";
            this.transY_Minus.Size = new System.Drawing.Size(102, 21);
            this.transY_Minus.TabIndex = 5;
            this.transY_Minus.Text = "-";
            this.transY_Minus.UseVisualStyleBackColor = true;
            this.transY_Minus.Click += new System.EventHandler(this.transY_Minus_Click);
            // 
            // transZ_Minus
            // 
            this.transZ_Minus.Location = new System.Drawing.Point(1296, 66);
            this.transZ_Minus.Name = "transZ_Minus";
            this.transZ_Minus.Size = new System.Drawing.Size(102, 21);
            this.transZ_Minus.TabIndex = 6;
            this.transZ_Minus.Text = "-";
            this.transZ_Minus.UseVisualStyleBackColor = true;
            this.transZ_Minus.Click += new System.EventHandler(this.transZ_Minus_Click);
            // 
            // transX_label
            // 
            this.transX_label.AutoSize = true;
            this.transX_label.Location = new System.Drawing.Point(1017, 17);
            this.transX_label.Name = "transX_label";
            this.transX_label.Size = new System.Drawing.Size(67, 13);
            this.transX_label.TabIndex = 7;
            this.transX_label.Text = "Translated X";
            // 
            // transY_label
            // 
            this.transY_label.AutoSize = true;
            this.transY_label.Location = new System.Drawing.Point(1017, 40);
            this.transY_label.Name = "transY_label";
            this.transY_label.Size = new System.Drawing.Size(67, 13);
            this.transY_label.TabIndex = 8;
            this.transY_label.Text = "Translated Y";
            // 
            // transZ_label
            // 
            this.transZ_label.AutoSize = true;
            this.transZ_label.Location = new System.Drawing.Point(1017, 70);
            this.transZ_label.Name = "transZ_label";
            this.transZ_label.Size = new System.Drawing.Size(67, 13);
            this.transZ_label.TabIndex = 9;
            this.transZ_label.Text = "Translated Z";
            // 
            // persFovY_lbl
            // 
            this.persFovY_lbl.AutoSize = true;
            this.persFovY_lbl.Location = new System.Drawing.Point(1017, 111);
            this.persFovY_lbl.Name = "persFovY_lbl";
            this.persFovY_lbl.Size = new System.Drawing.Size(94, 13);
            this.persFovY_lbl.TabIndex = 10;
            this.persFovY_lbl.Text = "Perspective Fov Y";
            // 
            // persAspectRatio_lbl
            // 
            this.persAspectRatio_lbl.AutoSize = true;
            this.persAspectRatio_lbl.Location = new System.Drawing.Point(1017, 135);
            this.persAspectRatio_lbl.Name = "persAspectRatio_lbl";
            this.persAspectRatio_lbl.Size = new System.Drawing.Size(127, 13);
            this.persAspectRatio_lbl.TabIndex = 11;
            this.persAspectRatio_lbl.Text = "Perspective Aspect Ratio";
            // 
            // persZNear_lbl
            // 
            this.persZNear_lbl.AutoSize = true;
            this.persZNear_lbl.Location = new System.Drawing.Point(1017, 161);
            this.persZNear_lbl.Name = "persZNear_lbl";
            this.persZNear_lbl.Size = new System.Drawing.Size(94, 13);
            this.persZNear_lbl.TabIndex = 12;
            this.persZNear_lbl.Text = "Perspective zNear";
            // 
            // persZFar_lbl
            // 
            this.persZFar_lbl.AutoSize = true;
            this.persZFar_lbl.Location = new System.Drawing.Point(1017, 188);
            this.persZFar_lbl.Name = "persZFar_lbl";
            this.persZFar_lbl.Size = new System.Drawing.Size(86, 13);
            this.persZFar_lbl.TabIndex = 13;
            this.persZFar_lbl.Text = "Perspective zFar";
            // 
            // rotatedAngle_lbl
            // 
            this.rotatedAngle_lbl.AutoSize = true;
            this.rotatedAngle_lbl.Location = new System.Drawing.Point(1017, 235);
            this.rotatedAngle_lbl.Name = "rotatedAngle_lbl";
            this.rotatedAngle_lbl.Size = new System.Drawing.Size(75, 13);
            this.rotatedAngle_lbl.TabIndex = 14;
            this.rotatedAngle_lbl.Text = "Rotated Angle";
            // 
            // rotatedX_lbl
            // 
            this.rotatedX_lbl.AutoSize = true;
            this.rotatedX_lbl.Location = new System.Drawing.Point(1017, 259);
            this.rotatedX_lbl.Name = "rotatedX_lbl";
            this.rotatedX_lbl.Size = new System.Drawing.Size(55, 13);
            this.rotatedX_lbl.TabIndex = 15;
            this.rotatedX_lbl.Text = "Rotated X";
            // 
            // rotatedY_lbl
            // 
            this.rotatedY_lbl.AutoSize = true;
            this.rotatedY_lbl.Location = new System.Drawing.Point(1017, 285);
            this.rotatedY_lbl.Name = "rotatedY_lbl";
            this.rotatedY_lbl.Size = new System.Drawing.Size(55, 13);
            this.rotatedY_lbl.TabIndex = 16;
            this.rotatedY_lbl.Text = "Rotated Y";
            // 
            // rotatedZ_lbl
            // 
            this.rotatedZ_lbl.AutoSize = true;
            this.rotatedZ_lbl.Location = new System.Drawing.Point(1017, 312);
            this.rotatedZ_lbl.Name = "rotatedZ_lbl";
            this.rotatedZ_lbl.Size = new System.Drawing.Size(55, 13);
            this.rotatedZ_lbl.TabIndex = 17;
            this.rotatedZ_lbl.Text = "Rotated Z";
            // 
            // persFovY_Plus
            // 
            this.persFovY_Plus.Location = new System.Drawing.Point(1194, 100);
            this.persFovY_Plus.Name = "persFovY_Plus";
            this.persFovY_Plus.Size = new System.Drawing.Size(96, 23);
            this.persFovY_Plus.TabIndex = 18;
            this.persFovY_Plus.Text = "+";
            this.persFovY_Plus.UseVisualStyleBackColor = true;
            this.persFovY_Plus.Click += new System.EventHandler(this.persFovY_Plus_Click);
            // 
            // persFovY_Minus
            // 
            this.persFovY_Minus.Location = new System.Drawing.Point(1296, 100);
            this.persFovY_Minus.Name = "persFovY_Minus";
            this.persFovY_Minus.Size = new System.Drawing.Size(102, 24);
            this.persFovY_Minus.TabIndex = 19;
            this.persFovY_Minus.Text = "-";
            this.persFovY_Minus.UseVisualStyleBackColor = true;
            this.persFovY_Minus.Click += new System.EventHandler(this.persFovY_Minus_Click);
            // 
            // persAspectRatio_Plus
            // 
            this.persAspectRatio_Plus.Location = new System.Drawing.Point(1194, 129);
            this.persAspectRatio_Plus.Name = "persAspectRatio_Plus";
            this.persAspectRatio_Plus.Size = new System.Drawing.Size(96, 19);
            this.persAspectRatio_Plus.TabIndex = 20;
            this.persAspectRatio_Plus.Text = "+";
            this.persAspectRatio_Plus.UseVisualStyleBackColor = true;
            this.persAspectRatio_Plus.Click += new System.EventHandler(this.persAspectRatio_Plus_Click);
            // 
            // persAspectRatio_Minus
            // 
            this.persAspectRatio_Minus.Location = new System.Drawing.Point(1297, 129);
            this.persAspectRatio_Minus.Name = "persAspectRatio_Minus";
            this.persAspectRatio_Minus.Size = new System.Drawing.Size(101, 19);
            this.persAspectRatio_Minus.TabIndex = 21;
            this.persAspectRatio_Minus.Text = "-";
            this.persAspectRatio_Minus.UseVisualStyleBackColor = true;
            this.persAspectRatio_Minus.Click += new System.EventHandler(this.persAspectRatio_Minus_Click);
            // 
            // persZNear_Plus
            // 
            this.persZNear_Plus.Location = new System.Drawing.Point(1194, 155);
            this.persZNear_Plus.Name = "persZNear_Plus";
            this.persZNear_Plus.Size = new System.Drawing.Size(96, 19);
            this.persZNear_Plus.TabIndex = 22;
            this.persZNear_Plus.Text = "+";
            this.persZNear_Plus.UseVisualStyleBackColor = true;
            this.persZNear_Plus.Click += new System.EventHandler(this.persZNear_Plus_Click);
            // 
            // persZNear_Minus
            // 
            this.persZNear_Minus.Location = new System.Drawing.Point(1297, 155);
            this.persZNear_Minus.Name = "persZNear_Minus";
            this.persZNear_Minus.Size = new System.Drawing.Size(101, 19);
            this.persZNear_Minus.TabIndex = 23;
            this.persZNear_Minus.Text = "-";
            this.persZNear_Minus.UseVisualStyleBackColor = true;
            this.persZNear_Minus.Click += new System.EventHandler(this.persZNear_Minus_Click);
            // 
            // persZFar_Plus
            // 
            this.persZFar_Plus.Location = new System.Drawing.Point(1194, 181);
            this.persZFar_Plus.Name = "persZFar_Plus";
            this.persZFar_Plus.Size = new System.Drawing.Size(96, 20);
            this.persZFar_Plus.TabIndex = 24;
            this.persZFar_Plus.Text = "+";
            this.persZFar_Plus.UseVisualStyleBackColor = true;
            this.persZFar_Plus.Click += new System.EventHandler(this.persZFar_Plus_Click);
            // 
            // persZFar_minus
            // 
            this.persZFar_minus.Location = new System.Drawing.Point(1296, 181);
            this.persZFar_minus.Name = "persZFar_minus";
            this.persZFar_minus.Size = new System.Drawing.Size(102, 20);
            this.persZFar_minus.TabIndex = 25;
            this.persZFar_minus.Text = "-";
            this.persZFar_minus.UseVisualStyleBackColor = true;
            this.persZFar_minus.Click += new System.EventHandler(this.persZFar_minus_Click);
            // 
            // rotatedAngle_Plus
            // 
            this.rotatedAngle_Plus.Location = new System.Drawing.Point(1194, 224);
            this.rotatedAngle_Plus.Name = "rotatedAngle_Plus";
            this.rotatedAngle_Plus.Size = new System.Drawing.Size(96, 19);
            this.rotatedAngle_Plus.TabIndex = 26;
            this.rotatedAngle_Plus.Text = "+";
            this.rotatedAngle_Plus.UseVisualStyleBackColor = true;
            this.rotatedAngle_Plus.Click += new System.EventHandler(this.rotatedAngle_Plus_Click);
            // 
            // rotatedAngle_minus
            // 
            this.rotatedAngle_minus.Location = new System.Drawing.Point(1297, 224);
            this.rotatedAngle_minus.Name = "rotatedAngle_minus";
            this.rotatedAngle_minus.Size = new System.Drawing.Size(95, 19);
            this.rotatedAngle_minus.TabIndex = 27;
            this.rotatedAngle_minus.Text = "-";
            this.rotatedAngle_minus.UseVisualStyleBackColor = true;
            this.rotatedAngle_minus.Click += new System.EventHandler(this.rotatedAngle_minus_Click);
            // 
            // rotatedX_Plus
            // 
            this.rotatedX_Plus.Location = new System.Drawing.Point(1194, 249);
            this.rotatedX_Plus.Name = "rotatedX_Plus";
            this.rotatedX_Plus.Size = new System.Drawing.Size(96, 23);
            this.rotatedX_Plus.TabIndex = 28;
            this.rotatedX_Plus.Text = "+";
            this.rotatedX_Plus.UseVisualStyleBackColor = true;
            this.rotatedX_Plus.Click += new System.EventHandler(this.rotatedX_Plus_Click);
            // 
            // rotatedX_Minus
            // 
            this.rotatedX_Minus.Location = new System.Drawing.Point(1296, 249);
            this.rotatedX_Minus.Name = "rotatedX_Minus";
            this.rotatedX_Minus.Size = new System.Drawing.Size(96, 23);
            this.rotatedX_Minus.TabIndex = 29;
            this.rotatedX_Minus.Text = "-";
            this.rotatedX_Minus.UseVisualStyleBackColor = true;
            this.rotatedX_Minus.Click += new System.EventHandler(this.rotatedX_Minus_Click);
            // 
            // rotatedY_Plus
            // 
            this.rotatedY_Plus.Location = new System.Drawing.Point(1194, 275);
            this.rotatedY_Plus.Name = "rotatedY_Plus";
            this.rotatedY_Plus.Size = new System.Drawing.Size(96, 23);
            this.rotatedY_Plus.TabIndex = 30;
            this.rotatedY_Plus.Text = "+";
            this.rotatedY_Plus.UseVisualStyleBackColor = true;
            this.rotatedY_Plus.Click += new System.EventHandler(this.rotatedY_Plus_Click);
            // 
            // rotatedY_minus
            // 
            this.rotatedY_minus.Location = new System.Drawing.Point(1296, 275);
            this.rotatedY_minus.Name = "rotatedY_minus";
            this.rotatedY_minus.Size = new System.Drawing.Size(96, 23);
            this.rotatedY_minus.TabIndex = 31;
            this.rotatedY_minus.Text = "-";
            this.rotatedY_minus.UseVisualStyleBackColor = true;
            this.rotatedY_minus.Click += new System.EventHandler(this.rotatedY_minus_Click);
            // 
            // rotatedZ_Plus
            // 
            this.rotatedZ_Plus.Location = new System.Drawing.Point(1194, 302);
            this.rotatedZ_Plus.Name = "rotatedZ_Plus";
            this.rotatedZ_Plus.Size = new System.Drawing.Size(96, 23);
            this.rotatedZ_Plus.TabIndex = 32;
            this.rotatedZ_Plus.Text = "+";
            this.rotatedZ_Plus.UseVisualStyleBackColor = true;
            this.rotatedZ_Plus.Click += new System.EventHandler(this.rotatedZ_Plus_Click);
            // 
            // rotatedZ_Minus
            // 
            this.rotatedZ_Minus.Location = new System.Drawing.Point(1296, 302);
            this.rotatedZ_Minus.Name = "rotatedZ_Minus";
            this.rotatedZ_Minus.Size = new System.Drawing.Size(96, 23);
            this.rotatedZ_Minus.TabIndex = 33;
            this.rotatedZ_Minus.Text = "-";
            this.rotatedZ_Minus.UseVisualStyleBackColor = true;
            this.rotatedZ_Minus.Click += new System.EventHandler(this.rotatedZ_Minus_Click);
            // 
            // radius_lbl
            // 
            this.radius_lbl.AutoSize = true;
            this.radius_lbl.Location = new System.Drawing.Point(1020, 355);
            this.radius_lbl.Name = "radius_lbl";
            this.radius_lbl.Size = new System.Drawing.Size(40, 13);
            this.radius_lbl.TabIndex = 34;
            this.radius_lbl.Text = "Radius";
            // 
            // height_lbl
            // 
            this.height_lbl.AutoSize = true;
            this.height_lbl.Location = new System.Drawing.Point(1020, 382);
            this.height_lbl.Name = "height_lbl";
            this.height_lbl.Size = new System.Drawing.Size(38, 13);
            this.height_lbl.TabIndex = 35;
            this.height_lbl.Text = "Height";
            // 
            // slices_lbl
            // 
            this.slices_lbl.AutoSize = true;
            this.slices_lbl.Location = new System.Drawing.Point(1020, 410);
            this.slices_lbl.Name = "slices_lbl";
            this.slices_lbl.Size = new System.Drawing.Size(35, 13);
            this.slices_lbl.TabIndex = 36;
            this.slices_lbl.Text = "Slices";
            // 
            // stacks_lbl
            // 
            this.stacks_lbl.AutoSize = true;
            this.stacks_lbl.Location = new System.Drawing.Point(1020, 432);
            this.stacks_lbl.Name = "stacks_lbl";
            this.stacks_lbl.Size = new System.Drawing.Size(40, 13);
            this.stacks_lbl.TabIndex = 37;
            this.stacks_lbl.Text = "Stacks";
            // 
            // radius_Plus
            // 
            this.radius_Plus.Location = new System.Drawing.Point(1194, 345);
            this.radius_Plus.Name = "radius_Plus";
            this.radius_Plus.Size = new System.Drawing.Size(75, 23);
            this.radius_Plus.TabIndex = 38;
            this.radius_Plus.Text = "+";
            this.radius_Plus.UseVisualStyleBackColor = true;
            this.radius_Plus.Click += new System.EventHandler(this.radius_Plus_Click);
            // 
            // height_Plus
            // 
            this.height_Plus.Location = new System.Drawing.Point(1194, 372);
            this.height_Plus.Name = "height_Plus";
            this.height_Plus.Size = new System.Drawing.Size(75, 23);
            this.height_Plus.TabIndex = 39;
            this.height_Plus.Text = "+";
            this.height_Plus.UseVisualStyleBackColor = true;
            this.height_Plus.Click += new System.EventHandler(this.height_Plus_Click);
            // 
            // slices_Plus
            // 
            this.slices_Plus.Location = new System.Drawing.Point(1194, 401);
            this.slices_Plus.Name = "slices_Plus";
            this.slices_Plus.Size = new System.Drawing.Size(75, 23);
            this.slices_Plus.TabIndex = 40;
            this.slices_Plus.Text = "+";
            this.slices_Plus.UseVisualStyleBackColor = true;
            this.slices_Plus.Click += new System.EventHandler(this.slices_Plus_Click);
            // 
            // stacks_Plus
            // 
            this.stacks_Plus.Location = new System.Drawing.Point(1194, 427);
            this.stacks_Plus.Name = "stacks_Plus";
            this.stacks_Plus.Size = new System.Drawing.Size(75, 23);
            this.stacks_Plus.TabIndex = 41;
            this.stacks_Plus.Text = "+";
            this.stacks_Plus.UseVisualStyleBackColor = true;
            this.stacks_Plus.Click += new System.EventHandler(this.stacks_Plus_Click);
            // 
            // radius_Minus
            // 
            this.radius_Minus.Location = new System.Drawing.Point(1296, 345);
            this.radius_Minus.Name = "radius_Minus";
            this.radius_Minus.Size = new System.Drawing.Size(75, 23);
            this.radius_Minus.TabIndex = 42;
            this.radius_Minus.Text = "-";
            this.radius_Minus.UseVisualStyleBackColor = true;
            this.radius_Minus.Click += new System.EventHandler(this.radius_Minus_Click);
            // 
            // height_minus
            // 
            this.height_minus.Location = new System.Drawing.Point(1297, 374);
            this.height_minus.Name = "height_minus";
            this.height_minus.Size = new System.Drawing.Size(75, 23);
            this.height_minus.TabIndex = 43;
            this.height_minus.Text = "-";
            this.height_minus.UseVisualStyleBackColor = true;
            this.height_minus.Click += new System.EventHandler(this.height_minus_Click);
            // 
            // slices_Minus
            // 
            this.slices_Minus.Location = new System.Drawing.Point(1297, 400);
            this.slices_Minus.Name = "slices_Minus";
            this.slices_Minus.Size = new System.Drawing.Size(75, 23);
            this.slices_Minus.TabIndex = 44;
            this.slices_Minus.Text = "-";
            this.slices_Minus.UseVisualStyleBackColor = true;
            this.slices_Minus.Click += new System.EventHandler(this.slices_Minus_Click);
            // 
            // stacks_Minus
            // 
            this.stacks_Minus.Location = new System.Drawing.Point(1296, 429);
            this.stacks_Minus.Name = "stacks_Minus";
            this.stacks_Minus.Size = new System.Drawing.Size(75, 23);
            this.stacks_Minus.TabIndex = 45;
            this.stacks_Minus.Text = "-";
            this.stacks_Minus.UseVisualStyleBackColor = true;
            this.stacks_Minus.Click += new System.EventHandler(this.stacks_Minus_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 631);
            this.Controls.Add(this.stacks_Minus);
            this.Controls.Add(this.slices_Minus);
            this.Controls.Add(this.height_minus);
            this.Controls.Add(this.radius_Minus);
            this.Controls.Add(this.stacks_Plus);
            this.Controls.Add(this.slices_Plus);
            this.Controls.Add(this.height_Plus);
            this.Controls.Add(this.radius_Plus);
            this.Controls.Add(this.stacks_lbl);
            this.Controls.Add(this.slices_lbl);
            this.Controls.Add(this.height_lbl);
            this.Controls.Add(this.radius_lbl);
            this.Controls.Add(this.rotatedZ_Minus);
            this.Controls.Add(this.rotatedZ_Plus);
            this.Controls.Add(this.rotatedY_minus);
            this.Controls.Add(this.rotatedY_Plus);
            this.Controls.Add(this.rotatedX_Minus);
            this.Controls.Add(this.rotatedX_Plus);
            this.Controls.Add(this.rotatedAngle_minus);
            this.Controls.Add(this.rotatedAngle_Plus);
            this.Controls.Add(this.persZFar_minus);
            this.Controls.Add(this.persZFar_Plus);
            this.Controls.Add(this.persZNear_Minus);
            this.Controls.Add(this.persZNear_Plus);
            this.Controls.Add(this.persAspectRatio_Minus);
            this.Controls.Add(this.persAspectRatio_Plus);
            this.Controls.Add(this.persFovY_Minus);
            this.Controls.Add(this.persFovY_Plus);
            this.Controls.Add(this.rotatedZ_lbl);
            this.Controls.Add(this.rotatedY_lbl);
            this.Controls.Add(this.rotatedX_lbl);
            this.Controls.Add(this.rotatedAngle_lbl);
            this.Controls.Add(this.persZFar_lbl);
            this.Controls.Add(this.persZNear_lbl);
            this.Controls.Add(this.persAspectRatio_lbl);
            this.Controls.Add(this.persFovY_lbl);
            this.Controls.Add(this.transZ_label);
            this.Controls.Add(this.transY_label);
            this.Controls.Add(this.transX_label);
            this.Controls.Add(this.transZ_Minus);
            this.Controls.Add(this.transY_Minus);
            this.Controls.Add(this.transX_Minus);
            this.Controls.Add(this.transZ_Plus);
            this.Controls.Add(this.transY_Plus);
            this.Controls.Add(this.transX_Plus);
            this.Controls.Add(this.openGlControl);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl openGlControl;
        private System.Windows.Forms.Button transX_Plus;
        private System.Windows.Forms.Button transY_Plus;
        private System.Windows.Forms.Button transZ_Plus;
        private System.Windows.Forms.Button transX_Minus;
        private System.Windows.Forms.Button transY_Minus;
        private System.Windows.Forms.Button transZ_Minus;
        private System.Windows.Forms.Label transX_label;
        private System.Windows.Forms.Label transY_label;
        private System.Windows.Forms.Label transZ_label;
        private System.Windows.Forms.Label persFovY_lbl;
        private System.Windows.Forms.Label persAspectRatio_lbl;
        private System.Windows.Forms.Label persZNear_lbl;
        private System.Windows.Forms.Label persZFar_lbl;
        private System.Windows.Forms.Label rotatedAngle_lbl;
        private System.Windows.Forms.Label rotatedX_lbl;
        private System.Windows.Forms.Label rotatedY_lbl;
        private System.Windows.Forms.Label rotatedZ_lbl;
        private System.Windows.Forms.Button persFovY_Plus;
        private System.Windows.Forms.Button persFovY_Minus;
        private System.Windows.Forms.Button persAspectRatio_Plus;
        private System.Windows.Forms.Button persAspectRatio_Minus;
        private System.Windows.Forms.Button persZNear_Plus;
        private System.Windows.Forms.Button persZNear_Minus;
        private System.Windows.Forms.Button persZFar_Plus;
        private System.Windows.Forms.Button persZFar_minus;
        private System.Windows.Forms.Button rotatedAngle_Plus;
        private System.Windows.Forms.Button rotatedAngle_minus;
        private System.Windows.Forms.Button rotatedX_Plus;
        private System.Windows.Forms.Button rotatedX_Minus;
        private System.Windows.Forms.Button rotatedY_Plus;
        private System.Windows.Forms.Button rotatedY_minus;
        private System.Windows.Forms.Button rotatedZ_Plus;
        private System.Windows.Forms.Button rotatedZ_Minus;
        private System.Windows.Forms.Label radius_lbl;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.Label slices_lbl;
        private System.Windows.Forms.Label stacks_lbl;
        private System.Windows.Forms.Button radius_Plus;
        private System.Windows.Forms.Button height_Plus;
        private System.Windows.Forms.Button slices_Plus;
        private System.Windows.Forms.Button stacks_Plus;
        private System.Windows.Forms.Button radius_Minus;
        private System.Windows.Forms.Button height_minus;
        private System.Windows.Forms.Button slices_Minus;
        private System.Windows.Forms.Button stacks_Minus;
    }
}

