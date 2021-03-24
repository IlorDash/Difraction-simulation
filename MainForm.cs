using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difraction_simulation {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
        struct lineCoord {
            public float x1;
            public float x2;
            public float y1;
            public float y2;
        }


        private void startButton_Click(object sender, EventArgs e) {

            double wavelength = 660 / Math.Pow(10, 9); //in metres
            double lengthToScreen = 1; //in metres
            double slitWidth = 60 / Math.Pow(10, 6); //in metres


            lineCoord myLine;
            Graphics g = plotBox.CreateGraphics();
            Pen myPen = new Pen(Color.Blue);
            int nmbInterv = 1000000;
            double xMin = 0;
            double xMax = 1000;
            double yMin = 0;
            double yMax = 4;
            int xOffset = (int)(xMax / 2);
            double xStep = (xMax - xMin) / nmbInterv;
            float kx = (float)(plotBox.Width / xMax);
            float ky = (float)(plotBox.Height / yMax);
            double xPrev = xMin;
            double intensityPrev = yMax;
            double x;
            double intensity;
            for (int i = 0; i < nmbInterv; i++) {
                x = xPrev + xStep;
                intensity = yMax * Math.Pow((Math.Sin((Math.PI * slitWidth * x) / (wavelength * lengthToScreen)) / ((Math.PI * slitWidth * x) / (wavelength * lengthToScreen))), 2);
                myLine.x1 = ((float)xPrev + xOffset) * kx;
                myLine.x2 = ((float)x + xOffset) * kx;
                myLine.y1 = plotBox.Height - ((float)intensityPrev) * ky;
                myLine.y2 = plotBox.Height - ((float)intensity) * ky;

                g.DrawLine(myPen, myLine.x1, myLine.y1, myLine.x2, myLine.y2);
                xPrev = x;
                intensityPrev = intensity;
            }
        }
    }
}
