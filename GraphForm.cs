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
        private float xMinReal = (float)-0.05; //in metres
        private static float xMaxReal = (float)0.05; //in metres
        private float xStepReal;
        int xCenterCoord;
        float xCellSize;

        private int yOffset = 12;
        int yMinReal = 0;
        int yMaxReal = 1; //in I(x)/I(0)

        const int numOfMax = 5;

        private float intensityByCoord(float x) {
            if (myExperiment.slitNum == 1) {
                return (float)Math.Pow((Math.Sin((Math.PI * myExperiment.slitWidth * x) / (myExperiment.waveLength * myExperiment.lengthToScreen)) / ((Math.PI * myExperiment.slitWidth * x) / (myExperiment.waveLength * myExperiment.lengthToScreen))), 2);
            } else if (myExperiment.slitNum == 2) {
                return (float)(Math.Pow((Math.Sin((Math.PI * myExperiment.slitWidth * x) / (myExperiment.waveLength * myExperiment.lengthToScreen)) / ((Math.PI * myExperiment.slitWidth * x) / (myExperiment.waveLength * myExperiment.lengthToScreen))), 2) * (1 + Math.Cos((2 * Math.PI * myExperiment.slitPeriod * x) / (myExperiment.waveLength * myExperiment.lengthToScreen))) / 2);
            } else {
                return (float)(Math.Pow((Math.Sin((Math.PI * myExperiment.slitWidth * x) / (myExperiment.waveLength * myExperiment.lengthToScreen)) / ((Math.PI * myExperiment.slitWidth * x) / (myExperiment.waveLength * myExperiment.lengthToScreen))), 2) * Math.Pow((Math.Sin((myExperiment.slitNum * Math.PI * myExperiment.slitPeriod * x) / (myExperiment.waveLength * myExperiment.lengthToScreen)) / (Math.Sin((Math.PI * myExperiment.slitPeriod * x) / (myExperiment.waveLength * myExperiment.lengthToScreen)) * myExperiment.slitNum)), 2));
            }
        }

        private float Map(float value, float from1, float to1, float from2, float to2) => (value - from1) / (to1 - from1) * (to2 - from2) + from2;

        private void drawCoordSystem(Graphics myGraph) {
            Pen blackPen = new Pen(Color.FromArgb(100, Color.Black));
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            blackPen.CustomEndCap = bigArrow;
            blackPen.Width = 2;
            myGraph.DrawLine(blackPen, 0, graphBox.Height - yOffset, graphBox.Width, graphBox.Height - yOffset);

            if (xMinReal < 0) {
                myGraph.DrawLine(blackPen, xCenterCoord, graphBox.Height - yOffset, xCenterCoord, 0);
            }

            float yCellSize = Map((float)0.1, 0, 1, 0, graphBox.Height - yOffset);
            blackPen.Width = 1;
            blackPen.EndCap = LineCap.NoAnchor;
            Font axisFont = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font coordFont = new Font("Arial", 8);
            int xCoordIter = 10;
            for (float i = (xCenterCoord + xCellSize); i <= graphBox.Width; i += xCellSize) {
                myGraph.DrawLine(blackPen, i, 0, i, graphBox.Height - yOffset);
                myGraph.DrawString(xCoordIter.ToString(), coordFont, drawBrush, i - 10, graphBox.Height - 12);
                xCoordIter += 10;
            }
            xCoordIter = -10;
            for (float i = (xCenterCoord - xCellSize); i >= 0; i -= xCellSize) {
                myGraph.DrawLine(blackPen, i, 0, i, graphBox.Height - yOffset);
                myGraph.DrawString(xCoordIter.ToString(), coordFont, drawBrush, i - 15, graphBox.Height - 12);
                xCoordIter -= 10;
            }
            myGraph.DrawString("0", coordFont, drawBrush, xCenterCoord - 5, graphBox.Height - 12);
            int coord = 10;
            for (float i = (graphBox.Height - yCellSize - yOffset); i >= 0; i -= yCellSize) {
                myGraph.DrawLine(blackPen, 0, i, graphBox.Width, i);
                myGraph.DrawString(coord.ToString(), coordFont, drawBrush, xCenterCoord + xCellSize / 10, i - 12);
                coord += 10;
            }
            myGraph.DrawString("I(x) / I(0) [%]", axisFont, drawBrush, xCenterCoord - 75, 5);
            myGraph.DrawString("X [mm]", axisFont, drawBrush, graphBox.Width - 50, graphBox.Height - 20 - yOffset);
        }

        private void drawGraph(Graphics myGraph) {
            lineCoord myLine;

            Pen bluePen = new Pen(Color.Blue);
            bluePen.Width = 1;

            if (xMinReal < 0) {
                xCenterCoord = (int)Map(Math.Abs(xMinReal), 0, xMaxReal + Math.Abs(xMinReal), 0, graphBox.Width);
                xCellSize = Map((float)0.01, 0, xMaxReal + Math.Abs(xMinReal), 0, graphBox.Width);
            } else {
                xCenterCoord = -(int)Map(2 * xMinReal, 0, xMaxReal, 0, graphBox.Width);
                xCellSize = Map((float)0.01, 0, xMaxReal, 0, graphBox.Width + Math.Abs(xCenterCoord));
            }

            int nmbInterv = (int)((xMaxReal + Math.Abs(xMinReal)) / xStepReal + 1);

            double yStepReal = intensityByCoord(xMinReal);

            float xPrevReal = xMinReal;
            float intensityPrev = intensityByCoord(xPrevReal);

            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Font maxCoordFont = new Font("Arial", 10);

            for (int i = 0; i < nmbInterv; i++) {
                float xReal = xPrevReal + xStepReal;
                float intensityReal = intensityByCoord(xReal);
                myLine.x1 = (int)(Map(xPrevReal, xMinReal, xMaxReal, 0, graphBox.Width));
                myLine.x2 = (int)(Map(xReal, xMinReal, xMaxReal, 0, graphBox.Width));
                myLine.y1 = graphBox.Height - (int)(Map(intensityPrev, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));
                myLine.y2 = graphBox.Height - (int)(Map(intensityReal, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));

                myGraph.DrawLine(bluePen, myLine.x1, myLine.y1 - yOffset, myLine.x2, myLine.y2 - yOffset);
                xPrevReal = xReal;
                intensityPrev = intensityReal;
            }
        }

        float getCoordOfMax(int m) {
            if (myExperiment.slitNum == 1) {
                return (float)((2 * m + 1) * myExperiment.waveLength * myExperiment.lengthToScreen / (2 * myExperiment.slitWidth));
            } else {
                return (float)(m * myExperiment.waveLength * myExperiment.lengthToScreen / myExperiment.slitPeriod);
            }
        }

        void drawGraphSign(Graphics myGraph) {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Font maxCoordFont = new Font("Arial", 10);
            float intensityReal = 1;

            for (int i = 1; i <= numOfMax; i++) {
                float xReal = getCoordOfMax(i);
                int x = (int)(Map(xReal, xMinReal, xMaxReal, 0, graphBox.Width));
                intensityReal = intensityByCoord(xReal);
                int y = graphBox.Height - (int)(Map(intensityReal, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));
                var coordText = Math.Round(xReal * 1000).ToString();
                myGraph.DrawString(coordText, maxCoordFont, redBrush, x - coordText.Length * 9, y - yOffset - 35);
                myGraph.DrawString(i.ToString(), maxCoordFont, greenBrush, x, y - yOffset - 35);
                //myGraph.FillEllipse(redBrush, new Rectangle(x - 5, y - yOffset - 5, 10, 10)); //disabled marks on peeks because of inaccuracy of geyCoordMax formulas

                myGraph.DrawString(coordText, maxCoordFont, redBrush, 2 * xCenterCoord - x - coordText.Length * 9, y - yOffset - 35);
                myGraph.DrawString(i.ToString(), maxCoordFont, greenBrush, 2 * xCenterCoord - x + 5, y - yOffset - 35);
                //myGraph.FillEllipse(redBrush, new Rectangle(2 * xCenterCoord - x - 5, y - yOffset - 5, 10, 10));
            }
        }


        private void DrawGraphButton_Click(object sender, EventArgs e) {
            xMinReal = float.Parse(xMinText.Text) / 1000;   //in metres
            xMaxReal = float.Parse(xMaxText.Text) / 1000;
            xStepReal = Map(1, 0, graphBox.Width, 0, Math.Abs(xMinReal) + Math.Abs(xMaxReal));
            Graphics myGraph = graphBox.CreateGraphics();
            myGraph.Clear(Color.White);
            drawGraph(myGraph);
            drawGraphSign(myGraph);
            if (gridCheckBox.Checked) {
                drawCoordSystem(myGraph);
            }
        }

        private void GraphForm_Shown(object sender, EventArgs e) {
            //myExperiment.lengthToScreen = 1;
            //myExperiment.slitNum = 10;
            //myExperiment.slitWidth = 5 / Math.Pow(10, 6);
            //myExperiment.waveLength = 532 / Math.Pow(10, 9);
            //myExperiment.slitPeriod = 10 / Math.Pow(10, 6);

            waveLengthText.Text = String.Concat("Wave lentgh λ [nm] = ", (myExperiment.waveLength * Math.Pow(10, 9)).ToString());
            lengthToScreen.Text = String.Concat("Length to screen L [m] = ", myExperiment.lengthToScreen.ToString());
            slitPeriod.Text = String.Concat("Slit period d [μm] = ", (myExperiment.slitPeriod * Math.Pow(10, 6)).ToString());
            slitWidth.Text = String.Concat("Slit width b [μm] = ", (myExperiment.slitWidth * Math.Pow(10, 6)).ToString());
            numOfSlits.Text = String.Concat("Num of slits N [pcs] = ", myExperiment.slitNum.ToString());
        }
    }
}
