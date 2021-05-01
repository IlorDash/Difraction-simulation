
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
            this.waveLength = new System.Windows.Forms.TextBox();
            this.WaterMark = new System.Windows.Forms.TextBox();
            this.lengthToScreen = new System.Windows.Forms.TextBox();
            this.numOfSlits = new System.Windows.Forms.TextBox();
            this.slitWidth = new System.Windows.Forms.TextBox();
            this.slitPeriod = new System.Windows.Forms.TextBox();
            this.dataName1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataName2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
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
            this.dataName1.Text = "Wave lentgh λ [nm]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataName2
            // 
            this.dataName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataName2.Location = new System.Drawing.Point(30, 104);
            this.dataName2.Name = "dataName2";
            this.dataName2.ReadOnly = true;
            this.dataName2.Size = new System.Drawing.Size(153, 15);
            this.dataName2.TabIndex = 8;
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
            this.textBox.Text = "Enter experiment conditions";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 315);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataName2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataName1);
            this.Controls.Add(this.slitPeriod);
            this.Controls.Add(this.slitWidth);
            this.Controls.Add(this.numOfSlits);
            this.Controls.Add(this.lengthToScreen);
            this.Controls.Add(this.WaterMark);
            this.Controls.Add(this.waveLength);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dataName2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox;
    }
}