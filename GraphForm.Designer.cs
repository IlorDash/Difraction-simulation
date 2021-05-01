
namespace Difraction_simulation {
    partial class GraphForm {
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
            this.DrawGraphButton = new System.Windows.Forms.Button();
            this.waveLengthText = new System.Windows.Forms.TextBox();
            this.lengthToScreen = new System.Windows.Forms.TextBox();
            this.slitWidth = new System.Windows.Forms.TextBox();
            this.slitPeriod = new System.Windows.Forms.TextBox();
            this.numOfSlits = new System.Windows.Forms.TextBox();
            this.WaterMark = new System.Windows.Forms.TextBox();
            this.gridCheckBox = new System.Windows.Forms.CheckBox();
            this.xMinText = new System.Windows.Forms.TextBox();
            this.xMaxText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.graphBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawGraphButton
            // 
            this.DrawGraphButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DrawGraphButton.Location = new System.Drawing.Point(355, 315);
            this.DrawGraphButton.Name = "DrawGraphButton";
            this.DrawGraphButton.Size = new System.Drawing.Size(75, 23);
            this.DrawGraphButton.TabIndex = 4;
            this.DrawGraphButton.Text = "Draw";
            this.DrawGraphButton.UseVisualStyleBackColor = true;
            this.DrawGraphButton.Click += new System.EventHandler(this.DrawGraphButton_Click);
            // 
            // waveLengthText
            // 
            this.waveLengthText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.waveLengthText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.waveLengthText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waveLengthText.Location = new System.Drawing.Point(594, 31);
            this.waveLengthText.Name = "waveLengthText";
            this.waveLengthText.ReadOnly = true;
            this.waveLengthText.Size = new System.Drawing.Size(189, 22);
            this.waveLengthText.TabIndex = 5;
            // 
            // lengthToScreen
            // 
            this.lengthToScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthToScreen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lengthToScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lengthToScreen.Location = new System.Drawing.Point(594, 59);
            this.lengthToScreen.Name = "lengthToScreen";
            this.lengthToScreen.ReadOnly = true;
            this.lengthToScreen.Size = new System.Drawing.Size(189, 22);
            this.lengthToScreen.TabIndex = 6;
            // 
            // slitWidth
            // 
            this.slitWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slitWidth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.slitWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slitWidth.Location = new System.Drawing.Point(594, 87);
            this.slitWidth.Name = "slitWidth";
            this.slitWidth.ReadOnly = true;
            this.slitWidth.Size = new System.Drawing.Size(189, 22);
            this.slitWidth.TabIndex = 7;
            // 
            // slitPeriod
            // 
            this.slitPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slitPeriod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.slitPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slitPeriod.Location = new System.Drawing.Point(594, 115);
            this.slitPeriod.Name = "slitPeriod";
            this.slitPeriod.ReadOnly = true;
            this.slitPeriod.Size = new System.Drawing.Size(189, 22);
            this.slitPeriod.TabIndex = 8;
            // 
            // numOfSlits
            // 
            this.numOfSlits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numOfSlits.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.numOfSlits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numOfSlits.Location = new System.Drawing.Point(594, 143);
            this.numOfSlits.Name = "numOfSlits";
            this.numOfSlits.ReadOnly = true;
            this.numOfSlits.Size = new System.Drawing.Size(189, 22);
            this.numOfSlits.TabIndex = 9;
            // 
            // WaterMark
            // 
            this.WaterMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WaterMark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WaterMark.Location = new System.Drawing.Point(599, 318);
            this.WaterMark.Name = "WaterMark";
            this.WaterMark.ReadOnly = true;
            this.WaterMark.Size = new System.Drawing.Size(189, 15);
            this.WaterMark.TabIndex = 10;
            this.WaterMark.Text = "Orazov Ilya IVT-12 MIET 2021";
            // 
            // gridCheckBox
            // 
            this.gridCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gridCheckBox.AutoSize = true;
            this.gridCheckBox.Location = new System.Drawing.Point(464, 315);
            this.gridCheckBox.Name = "gridCheckBox";
            this.gridCheckBox.Size = new System.Drawing.Size(57, 21);
            this.gridCheckBox.TabIndex = 11;
            this.gridCheckBox.Text = "Grid";
            this.gridCheckBox.UseVisualStyleBackColor = true;
            // 
            // xMinText
            // 
            this.xMinText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xMinText.Location = new System.Drawing.Point(117, 315);
            this.xMinText.Name = "xMinText";
            this.xMinText.Size = new System.Drawing.Size(55, 22);
            this.xMinText.TabIndex = 12;
            this.xMinText.Text = "-150";
            // 
            // xMaxText
            // 
            this.xMaxText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.xMaxText.Location = new System.Drawing.Point(273, 315);
            this.xMaxText.Name = "xMaxText";
            this.xMaxText.Size = new System.Drawing.Size(55, 22);
            this.xMaxText.TabIndex = 13;
            this.xMaxText.Text = "150";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(41, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(70, 15);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "x min [mm]";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(197, 318);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(70, 15);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "x max [mm]";
            // 
            // graphBox
            // 
            this.graphBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphBox.Location = new System.Drawing.Point(39, 22);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(754, 287);
            this.graphBox.TabIndex = 3;
            this.graphBox.TabStop = false;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 345);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.xMaxText);
            this.Controls.Add(this.xMinText);
            this.Controls.Add(this.gridCheckBox);
            this.Controls.Add(this.WaterMark);
            this.Controls.Add(this.numOfSlits);
            this.Controls.Add(this.slitPeriod);
            this.Controls.Add(this.slitWidth);
            this.Controls.Add(this.lengthToScreen);
            this.Controls.Add(this.waveLengthText);
            this.Controls.Add(this.DrawGraphButton);
            this.Controls.Add(this.graphBox);
            this.Name = "GraphForm";
            this.Text = "Difraction simulation";
            this.Shown += new System.EventHandler(this.GraphForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DrawGraphButton;
        private System.Windows.Forms.TextBox waveLengthText;
        private System.Windows.Forms.TextBox lengthToScreen;
        private System.Windows.Forms.TextBox slitWidth;
        private System.Windows.Forms.TextBox slitPeriod;
        private System.Windows.Forms.TextBox numOfSlits;
        private System.Windows.Forms.TextBox WaterMark;
        private System.Windows.Forms.CheckBox gridCheckBox;
        private System.Windows.Forms.TextBox xMinText;
        private System.Windows.Forms.TextBox xMaxText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox graphBox;
    }
}

