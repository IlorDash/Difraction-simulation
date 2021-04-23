using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difraction_simulation {
    public partial class GraphForm : Form {
        public GraphForm() {
            InitializeComponent();
        }

        struct lineCoord {
            public int x1;
            public int x2;
            public int y1;
            public int y2;
        }

        public struct experimentData {
            public double waveLength; //in metres
            public float lengthToScreen; //in metres
            public double slitWidth; //in metres
            public double slitPeriod; //in metres
            public int slitNum; //in pcs
        }

        public static experimentData myExperiment;
        private float xMinReal = (float)-0.15; //in metres
        private float xMaxReal = (float)0.15; //in metres
        private float xStepReal = (float)0.001;

        private float intensityByCoord(float x) => (float)Math.Pow((Math.Sin((Math.PI * myExperiment.slitWidth * x) / (myExperiment.waveLength * myExperiment.lengthToScreen)) / ((Math.PI * myExperiment.slitWidth * x) / (myExperiment.waveLength * myExperiment.lengthToScreen))), 2);

        private float Map(float value, float from1, float to1, float from2, float to2) => (value - from1) / (to1 - from1) * (to2 - from2) + from2;

        private void drawCoordSystem(Graphics myGraph) {
            Pen blackPen = new Pen(Color.Black);
            blackPen.EndCap = LineCap.ArrowAnchor;
            blackPen.Width = 2;
            myGraph.DrawLine(blackPen, 0, graphBox.Height, graphBox.Width, graphBox.Height);
            myGraph.DrawLine(blackPen, graphBox.Width / 2, graphBox.Height, graphBox.Width / 2, 0);
            float xCellSize = Map((float)0.02, 0, (float)0.3, 0, graphBox.Width);
            float yCellSize = Map((float)0.1, 0, 1, 0, graphBox.Height);
            blackPen.Width = 1;
            blackPen.EndCap = LineCap.NoAnchor;
            for (float i = (graphBox.Width / 2 + xCellSize); i <= graphBox.Width; i += xCellSize) {
                myGraph.DrawLine(blackPen, i, 0, i, graphBox.Height);
            }
            for (float i = (graphBox.Width / 2 - xCellSize); i >= 0; i -= xCellSize) {
                myGraph.DrawLine(blackPen, i, 0, i, graphBox.Height);
            }
            for (float i = (graphBox.Height + yCellSize); i >= 0; i -= yCellSize) {
                myGraph.DrawLine(blackPen, 0, i, graphBox.Width, i);
            }
        }

        private void DrawGraphButton_Click(object sender, EventArgs e) {
            graphBox.Width = (int)(this.Size.Width - 70);
            graphBox.Height = (int)(this.Size.Height - 100);
            lineCoord myLine;
            Graphics myGraph = graphBox.CreateGraphics();
            myGraph.Clear(Color.White);
            drawCoordSystem(myGraph);

            Pen bluePen = new Pen(Color.Blue);
            bluePen.Width = 3;

            int nmbInterv = (int)(xMaxReal / xStepReal + 1) * 2;
            float xPixInRealStep = xStepReal * graphBox.Width / xMaxReal;

            int yMinReal = 0;
            int yMaxReal = 1; //in I(x)/I(0)
            double yStepReal = intensityByCoord(xMinReal);
            double yPixInRealStep = yStepReal * graphBox.Height / yMaxReal;

            float xPrevReal = xMinReal;
            float intensityPrev = intensityByCoord(xPrevReal);
            for (int i = 0; i < nmbInterv; i++) {
                float xReal = xPrevReal + xStepReal;
                float intensityReal = intensityByCoord(xReal);
                myLine.x1 = (int)(Map(xPrevReal, xMinReal, xMaxReal, 0, graphBox.Width));
                myLine.x2 = (int)(Map(xReal, xMinReal, xMaxReal, 0, graphBox.Width));
                myLine.y1 = graphBox.Height - (int)(Map(intensityPrev, yMinReal, yMaxReal, 0, graphBox.Height));
                myLine.y2 = graphBox.Height - (int)(Map(intensityReal, yMinReal, yMaxReal, 0, graphBox.Height));

                myGraph.DrawLine(bluePen, myLine.x1, myLine.y1, myLine.x2, myLine.y2);
                xPrevReal = xReal;
                intensityPrev = intensityReal;
            }
        }

        private void GraphForm_Shown(object sender, EventArgs e) {
            waveLengthText.Text = String.Concat("Wave lentgh λ [nm] = ", (myExperiment.waveLength * Math.Pow(10, 9)).ToString());
            lengthToScreen.Text = String.Concat("Length to screen L [m] = ", myExperiment.lengthToScreen.ToString());
            slitPeriod.Text = String.Concat("Slit period d [μm] = ", (myExperiment.slitPeriod * Math.Pow(10, 6)).ToString());
            slitWidth.Text = String.Concat("Slit width b [μm] = ", (myExperiment.slitWidth * Math.Pow(10, 6)).ToString());
            numOfSlits.Text = String.Concat("Num of slits N [pcs] = ", myExperiment.slitNum.ToString());
        }
    }
}
