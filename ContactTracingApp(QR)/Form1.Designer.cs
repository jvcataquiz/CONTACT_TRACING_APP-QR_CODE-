
namespace ContactTracingApp_QR_
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelcamera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMERA";
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCamera.Location = new System.Drawing.Point(55, 49);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(427, 363);
            this.pictureBoxCamera.TabIndex = 1;
            this.pictureBoxCamera.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(391, 429);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(91, 33);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.TabStop = false;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelcamera
            // 
            this.labelcamera.AutoSize = true;
            this.labelcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcamera.Location = new System.Drawing.Point(116, 21);
            this.labelcamera.Name = "labelcamera";
            this.labelcamera.Size = new System.Drawing.Size(76, 24);
            this.labelcamera.TabIndex = 3;
            this.labelcamera.Text = "Camera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 483);
            this.Controls.Add(this.labelcamera);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxCamera);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Contact Traing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelcamera;
    }
}

