﻿namespace Spawn_Animated_Fireworks_WFApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            animationTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // animationTimer
            // 
            animationTimer.Enabled = true;
            animationTimer.Interval = 20;
            animationTimer.Tick += AnimationTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Fireworks";
            Paint += FormPaintEvent;
            KeyUp += KeyIsUp;
            MouseDown += FormMouseDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
    }
}