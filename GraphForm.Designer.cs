
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
            this.graphBox = new System.Windows.Forms.PictureBox();
            this.DrawGraphButton = new System.Windows.Forms.Button();
            this.waveLengthText = new System.Windows.Forms.TextBox();
            this.lengthToScreen = new System.Windows.Forms.TextBox();
            this.slitWidth = new System.Windows.Forms.TextBox();
            this.slitPeriod = new System.Windows.Forms.TextBox();
            this.numOfSlits = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // graphBox
            // 
            this.graphBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphBox.Location = new System.Drawing.Point(39, 22);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(721, 287);
            this.graphBox.TabIndex = 3;
            this.graphBox.TabStop = false;
            // 
            // DrawGraphButton
            // 
            this.DrawGraphButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DrawGraphButton.Location = new System.Drawing.Point(351, 323);
            this.DrawGraphButton.Name = "DrawGraphButton";
            this.DrawGraphButton.Size = new System.Drawing.Size(75, 23);
            this.DrawGraphButton.TabIndex = 4;
            this.DrawGraphButton.Text = "Start";
            this.DrawGraphButton.UseVisualStyleBackColor = true;
            this.DrawGraphButton.Click += new System.EventHandler(this.DrawGraphButton_Click);
            // 
            // waveLengthText
            // 
            this.waveLengthText.Location = new System.Drawing.Point(571, 22);
            this.waveLengthText.Name = "waveLengthText";
            this.waveLengthText.Size = new System.Drawing.Size(189, 22);
            this.waveLengthText.TabIndex = 5;
            // 
            // lengthToScreen
            // 
            this.lengthToScreen.Location = new System.Drawing.Point(571, 50);
            this.lengthToScreen.Name = "lengthToScreen";
            this.lengthToScreen.Size = new System.Drawing.Size(189, 22);
            this.lengthToScreen.TabIndex = 6;
            // 
            // slitWidth
            // 
            this.slitWidth.Location = new System.Drawing.Point(571, 78);
            this.slitWidth.Name = "slitWidth";
            this.slitWidth.Size = new System.Drawing.Size(189, 22);
            this.slitWidth.TabIndex = 7;
            // 
            // slitPeriod
            // 
            this.slitPeriod.Location = new System.Drawing.Point(571, 106);
            this.slitPeriod.Name = "slitPeriod";
            this.slitPeriod.Size = new System.Drawing.Size(189, 22);
            this.slitPeriod.TabIndex = 8;
            // 
            // numOfSlits
            // 
            this.numOfSlits.Location = new System.Drawing.Point(571, 134);
            this.numOfSlits.Name = "numOfSlits";
            this.numOfSlits.Size = new System.Drawing.Size(189, 22);
            this.numOfSlits.TabIndex = 9;
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 358);
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

        private System.Windows.Forms.PictureBox graphBox;
        private System.Windows.Forms.Button DrawGraphButton;
        private System.Windows.Forms.TextBox waveLengthText;
        private System.Windows.Forms.TextBox lengthToScreen;
        private System.Windows.Forms.TextBox slitWidth;
        private System.Windows.Forms.TextBox slitPeriod;
        private System.Windows.Forms.TextBox numOfSlits;
    }
}

