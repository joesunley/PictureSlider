
namespace PictureSlider
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBottomRight = new System.Windows.Forms.PictureBox();
            this.pbBottomCentre = new System.Windows.Forms.PictureBox();
            this.pbBottomLeft = new System.Windows.Forms.PictureBox();
            this.pbCentreRight = new System.Windows.Forms.PictureBox();
            this.pbCentreCentre = new System.Windows.Forms.PictureBox();
            this.pbCentreLeft = new System.Windows.Forms.PictureBox();
            this.pbTopRight = new System.Windows.Forms.PictureBox();
            this.pbTopCentre = new System.Windows.Forms.PictureBox();
            this.pbTopLeft = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomCentre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentreRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentreCentre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentreLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopCentre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbBottomRight);
            this.panel1.Controls.Add(this.pbBottomCentre);
            this.panel1.Controls.Add(this.pbBottomLeft);
            this.panel1.Controls.Add(this.pbCentreRight);
            this.panel1.Controls.Add(this.pbCentreCentre);
            this.panel1.Controls.Add(this.pbCentreLeft);
            this.panel1.Controls.Add(this.pbTopRight);
            this.panel1.Controls.Add(this.pbTopCentre);
            this.panel1.Controls.Add(this.pbTopLeft);
            this.panel1.Location = new System.Drawing.Point(63, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 0;
            // 
            // pbBottomRight
            // 
            this.pbBottomRight.Location = new System.Drawing.Point(200, 200);
            this.pbBottomRight.Margin = new System.Windows.Forms.Padding(0);
            this.pbBottomRight.Name = "pbBottomRight";
            this.pbBottomRight.Size = new System.Drawing.Size(100, 100);
            this.pbBottomRight.TabIndex = 8;
            this.pbBottomRight.TabStop = false;
            this.pbBottomRight.Tag = "8";
            this.pbBottomRight.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // pbBottomCentre
            // 
            this.pbBottomCentre.Location = new System.Drawing.Point(100, 200);
            this.pbBottomCentre.Margin = new System.Windows.Forms.Padding(0);
            this.pbBottomCentre.Name = "pbBottomCentre";
            this.pbBottomCentre.Size = new System.Drawing.Size(100, 100);
            this.pbBottomCentre.TabIndex = 7;
            this.pbBottomCentre.TabStop = false;
            this.pbBottomCentre.Tag = "7";
            this.pbBottomCentre.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // pbBottomLeft
            // 
            this.pbBottomLeft.Location = new System.Drawing.Point(0, 200);
            this.pbBottomLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pbBottomLeft.Name = "pbBottomLeft";
            this.pbBottomLeft.Size = new System.Drawing.Size(100, 100);
            this.pbBottomLeft.TabIndex = 6;
            this.pbBottomLeft.TabStop = false;
            this.pbBottomLeft.Tag = "6";
            this.pbBottomLeft.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // pbCentreRight
            // 
            this.pbCentreRight.Location = new System.Drawing.Point(200, 100);
            this.pbCentreRight.Margin = new System.Windows.Forms.Padding(0);
            this.pbCentreRight.Name = "pbCentreRight";
            this.pbCentreRight.Size = new System.Drawing.Size(100, 100);
            this.pbCentreRight.TabIndex = 5;
            this.pbCentreRight.TabStop = false;
            this.pbCentreRight.Tag = "5";
            this.pbCentreRight.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // pbCentreCentre
            // 
            this.pbCentreCentre.Location = new System.Drawing.Point(100, 100);
            this.pbCentreCentre.Margin = new System.Windows.Forms.Padding(0);
            this.pbCentreCentre.Name = "pbCentreCentre";
            this.pbCentreCentre.Size = new System.Drawing.Size(100, 100);
            this.pbCentreCentre.TabIndex = 4;
            this.pbCentreCentre.TabStop = false;
            this.pbCentreCentre.Tag = "4";
            this.pbCentreCentre.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // pbCentreLeft
            // 
            this.pbCentreLeft.Location = new System.Drawing.Point(0, 100);
            this.pbCentreLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pbCentreLeft.Name = "pbCentreLeft";
            this.pbCentreLeft.Size = new System.Drawing.Size(100, 100);
            this.pbCentreLeft.TabIndex = 3;
            this.pbCentreLeft.TabStop = false;
            this.pbCentreLeft.Tag = "3";
            this.pbCentreLeft.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // pbTopRight
            // 
            this.pbTopRight.Location = new System.Drawing.Point(200, 0);
            this.pbTopRight.Margin = new System.Windows.Forms.Padding(0);
            this.pbTopRight.Name = "pbTopRight";
            this.pbTopRight.Size = new System.Drawing.Size(100, 100);
            this.pbTopRight.TabIndex = 2;
            this.pbTopRight.TabStop = false;
            this.pbTopRight.Tag = "2";
            this.pbTopRight.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // pbTopCentre
            // 
            this.pbTopCentre.Location = new System.Drawing.Point(100, 0);
            this.pbTopCentre.Margin = new System.Windows.Forms.Padding(0);
            this.pbTopCentre.Name = "pbTopCentre";
            this.pbTopCentre.Size = new System.Drawing.Size(100, 100);
            this.pbTopCentre.TabIndex = 1;
            this.pbTopCentre.TabStop = false;
            this.pbTopCentre.Tag = "1";
            this.pbTopCentre.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // pbTopLeft
            // 
            this.pbTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pbTopLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pbTopLeft.Name = "pbTopLeft";
            this.pbTopLeft.Size = new System.Drawing.Size(100, 100);
            this.pbTopLeft.TabIndex = 0;
            this.pbTopLeft.TabStop = false;
            this.pbTopLeft.Tag = "0";
            this.pbTopLeft.Click += new System.EventHandler(this.Tile_Clicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose New Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Open_Clicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomCentre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentreRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentreCentre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentreLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopCentre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBottomRight;
        private System.Windows.Forms.PictureBox pbBottomCentre;
        private System.Windows.Forms.PictureBox pbBottomLeft;
        private System.Windows.Forms.PictureBox pbCentreRight;
        private System.Windows.Forms.PictureBox pbCentreCentre;
        private System.Windows.Forms.PictureBox pbCentreLeft;
        private System.Windows.Forms.PictureBox pbTopRight;
        private System.Windows.Forms.PictureBox pbTopCentre;
        private System.Windows.Forms.PictureBox pbTopLeft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

