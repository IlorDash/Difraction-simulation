
namespace Difraction_simulation {
    partial class DataForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.waveLength = new System.Windows.Forms.TextBox();
            this.WaterMark = new System.Windows.Forms.TextBox();
            this.lengthToScreen = new System.Windows.Forms.TextBox();
            this.numOfSlits = new System.Windows.Forms.TextBox();
            this.slitWidth = new System.Windows.Forms.TextBox();
            this.slitPeriod = new System.Windows.Forms.TextBox();
            this.dataName1 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.dataName2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // waveLength
            // 
            this.waveLength.Location = new System.Drawing.Point(217, 77);
            this.waveLength.Name = "waveLength";
            this.waveLength.Size = new System.Drawing.Size(100, 22);
            this.waveLength.TabIndex = 0;
            // 
            // WaterMark
            // 
            this.WaterMark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WaterMark.Location = new System.Drawing.Point(128, 288);
            this.WaterMark.Name = "WaterMark";
            this.WaterMark.ReadOnly = true;
            this.WaterMark.Size = new System.Drawing.Size(199, 15);
            this.WaterMark.TabIndex = 30;
            this.WaterMark.TabStop = false;
            this.WaterMark.Text = "Orazov Ilya IVT-12 MIET 2021";
            // 
            // lengthToScreen
            // 
            this.lengthToScreen.Location = new System.Drawing.Point(217, 105);
            this.lengthToScreen.Name = "lengthToScreen";
            this.lengthToScreen.Size = new System.Drawing.Size(100, 22);
            this.lengthToScreen.TabIndex = 1;
            // 
            // numOfSlits
            // 
            this.numOfSlits.Location = new System.Drawing.Point(217, 133);
            this.numOfSlits.Name = "numOfSlits";
            this.numOfSlits.Size = new System.Drawing.Size(100, 22);
            this.numOfSlits.TabIndex = 2;
            // 
            // slitWidth
            // 
            this.slitWidth.Location = new System.Drawing.Point(217, 161);
            this.slitWidth.Name = "slitWidth";
            this.slitWidth.Size = new System.Drawing.Size(100, 22);
            this.slitWidth.TabIndex = 3;
            // 
            // slitPeriod
            // 
            this.slitPeriod.Location = new System.Drawing.Point(217, 189);
            this.slitPeriod.Name = "slitPeriod";
            this.slitPeriod.Size = new System.Drawing.Size(100, 22);
            this.slitPeriod.TabIndex = 4;
            // 
            // dataName1
            // 
            this.dataName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataName1.Location = new System.Drawing.Point(30, 76);
            this.dataName1.Name = "dataName1";
            this.dataName1.ReadOnly = true;
            this.dataName1.Size = new System.Drawing.Size(123, 15);
            this.dataName1.TabIndex = 7;
            this.dataName1.TabStop = false;
            this.dataName1.Text = "Wave lentgh λ [nm]";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(128, 231);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dataName2
            // 
            this.dataName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataName2.Location = new System.Drawing.Point(30, 104);
            this.dataName2.Name = "dataName2";
            this.dataName2.ReadOnly = true;
            this.dataName2.Size = new System.Drawing.Size(153, 15);
            this.dataName2.TabIndex = 8;
            this.dataName2.TabStop = false;
            this.dataName2.Text = "Length to screen L [m]";
            this.dataName2.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(30, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(133, 15);
            this.textBox2.TabIndex = 9;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Num of slits N [pcs]";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(30, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 15);
            this.textBox3.TabIndex = 10;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Slit width b [μm]";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(30, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(123, 15);
            this.textBox4.TabIndex = 11;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Slit period d [μm]";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(88, 31);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(165, 15);
            this.textBox.TabIndex = 6;
            this.textBox.TabStop = false;
            this.textBox.Text = "Enter experiment conditions";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(128, 260);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(94, 23);
            this.aboutButton.TabIndex = 31;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 315);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataName2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.dataName1);
            this.Controls.Add(this.slitPeriod);
            this.Controls.Add(this.slitWidth);
            this.Controls.Add(this.numOfSlits);
            this.Controls.Add(this.lengthToScreen);
            this.Controls.Add(this.WaterMark);
            this.Controls.Add(this.waveLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 362);
            this.Name = "DataForm";
            this.Text = "Difraction simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox waveLength;
        private System.Windows.Forms.TextBox WaterMark;
        private System.Windows.Forms.TextBox lengthToScreen;
        private System.Windows.Forms.TextBox numOfSlits;
        private System.Windows.Forms.TextBox slitWidth;
        private System.Windows.Forms.TextBox slitPeriod;
        private System.Windows.Forms.TextBox dataName1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox dataName2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button aboutButton;
    }
}