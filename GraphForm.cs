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
        float xCenterCoordReal;
        float xCellSize;

        float yMaxReal = 1; //in I(x)/I(0)
        private int yOffset = 15;
        int yMinReal = 0;

        const int numOfMax = 5;

        private float intensityByCoord(experimentData experiment, float x) {
            if (x == 0) {
                return 1;
            } else if (experiment.slitNum == 1) {
                return (float)Math.Pow((Math.Sin((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen)) / ((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen))), 2);
            } else if (experiment.slitNum == 2) {
                return (float)(Math.Pow((Math.Sin((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen)) / ((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen))), 2) * (1 + Math.Cos((2 * Math.PI * experiment.slitPeriod * x) / (experiment.waveLength * experiment.lengthToScreen))) / 2);
            } else {
                return (float)(Math.Pow((Math.Sin((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen)) / ((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen))), 2) * Math.Pow((Math.Sin((experiment.slitNum * Math.PI * experiment.slitPeriod * x) / (experiment.waveLength * experiment.lengthToScreen)) / (Math.Sin((Math.PI * experiment.slitPeriod * x) / (experiment.waveLength * experiment.lengthToScreen)) * experiment.slitNum)), 2));
            }
        }

        double intensityByCoord(experimentData experiment, double x) {
            if (x == 0) {
                return 1;
            } else if (experiment.slitNum == 1) {
                return (double)Math.Pow((Math.Sin((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen)) / ((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen))), 2);
            } else if (experiment.slitNum == 2) {
                return (double)(Math.Pow((Math.Sin((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen)) / ((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen))), 2) * (1 + Math.Cos((2 * Math.PI * experiment.slitPeriod * x) / (experiment.waveLength * experiment.lengthToScreen))) / 2);
            } else {
                return (double)(Math.Pow((Math.Sin((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen)) / ((Math.PI * experiment.slitWidth * x) / (experiment.waveLength * experiment.lengthToScreen))), 2) * Math.Pow((Math.Sin((experiment.slitNum * Math.PI * experiment.slitPeriod * x) / (experiment.waveLength * experiment.lengthToScreen)) / (Math.Sin((Math.PI * experiment.slitPeriod * x) / (experiment.waveLength * experiment.lengthToScreen)) * experiment.slitNum)), 2));
            }
        }

        float Map(float value, float from1, float to1, float from2, float to2) => (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        double Map(double value, double from1, double to1, double from2, double to2) => (value - from1) / (to1 - from1) * (to2 - from2) + from2;

        void printExperimentData(Graphics myGraph) {
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Font myFont = new Font("Arial", 10);
            var waveLengthStr = String.Concat("Wave lentgh λ [nm] = ", (myExperiment.waveLength * Math.Pow(10, 9)).ToString());
            myGraph.DrawString(waveLengthStr, myFont, blackBrush, graphBox.Width - 200, 15);

            var lengthToScreenStr = String.Concat("Length to screen L [m] = ", myExperiment.lengthToScreen.ToString());
            myGraph.DrawString(lengthToScreenStr, myFont, blackBrush, graphBox.Width - 200, 30);

            var slitPeriodStr = String.Concat("Slit period d [μm] = ", (myExperiment.slitPeriod * Math.Pow(10, 6)).ToString());
            myGraph.DrawString(slitPeriodStr, myFont, blackBrush, graphBox.Width - 200, 45);

            var slitWidthStr = String.Concat("Slit width b [μm] = ", (myExperiment.slitWidth * Math.Pow(10, 6)).ToString());
            myGraph.DrawString(slitWidthStr, myFont, blackBrush, graphBox.Width - 200, 60);

            var numOfSlitsStr = String.Concat("Num of slits N [pcs] = ", myExperiment.slitNum.ToString());
            myGraph.DrawString(numOfSlitsStr, myFont, blackBrush, graphBox.Width - 200, 75);
        }

        private void drawGraph(Graphics myGraph) {
            lineCoord myLine;

            Pen bluePen = new Pen(Color.Blue);
            bluePen.Width = 1;

            if (xMinReal < 0) {
                xCenterCoord = (int)Map(Math.Abs(xMinReal), 0, xMaxReal + Math.Abs(xMinReal), 0, graphBox.Width);
                xCellSize = Map((float)0.01, 0, xMaxReal + Math.Abs(xMinReal), 0, graphBox.Width);
                xCenterCoordReal = 0;
            } else {
                xCenterCoord = -(int)Map(2 * xMinReal, 0, xMaxReal, 0, graphBox.Width);
                xCellSize = Map((float)0.01, 0, xMaxReal, 0, graphBox.Width + Math.Abs(xCenterCoord));
                xCenterCoordReal = xMinReal;
            }

            int nmbInterv = (int)((xMaxReal + Math.Abs(xMinReal)) / xStepReal + 1);

            double yStepReal = intensityByCoord(myExperiment, xMinReal);

            float xPrevReal = xMinReal;
            float intensityPrev = intensityByCoord(myExperiment, xPrevReal);

            for (int i = 0; i < nmbInterv; i++) {
                float xReal = xPrevReal + xStepReal;
                float intensityReal = intensityByCoord(myExperiment, xReal);
                myLine.x1 = (int)(Map(xPrevReal, xMinReal, xMaxReal, 0, graphBox.Width));
                myLine.x2 = (int)(Map(xReal, xMinReal, xMaxReal, 0, graphBox.Width));
                myLine.y1 = graphBox.Height - (int)(Map(intensityPrev, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));
                myLine.y2 = graphBox.Height - (int)(Map(intensityReal, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));

                myGraph.DrawLine(bluePen, myLine.x1, myLine.y1 - yOffset, myLine.x2, myLine.y2 - yOffset);
                xPrevReal = xReal;
                intensityPrev = intensityReal;
            }
        }

        void drawEnvelope(Graphics myGraph) {
            lineCoord myLine;
            int nmbInterv = (int)((xMaxReal + Math.Abs(xMinReal)) / xStepReal + 1);
            float xPrevReal = xMinReal;
            experimentData experiment_t = myExperiment;
            experiment_t.slitNum = 1;
            float intensityPrev = intensityByCoord(experiment_t, xPrevReal);

            Pen greenPen = new Pen(Color.Green);
            greenPen.Width = 1;

            for (int i = 0; i < nmbInterv; i++) {
                float xReal = xPrevReal + xStepReal;
                float intensityReal = intensityByCoord(experiment_t, xReal);
                myLine.x1 = (int)(Map(xPrevReal, xMinReal, xMaxReal, 0, graphBox.Width));
                myLine.x2 = (int)(Map(xReal, xMinReal, xMaxReal, 0, graphBox.Width));
                myLine.y1 = graphBox.Height - (int)(Map(intensityPrev, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));
                myLine.y2 = graphBox.Height - (int)(Map(intensityReal, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));

                myGraph.DrawLine(greenPen, myLine.x1, myLine.y1 - yOffset, myLine.x2, myLine.y2 - yOffset);
                xPrevReal = xReal;
                intensityPrev = intensityReal;
            }
        }


        private void drawCoordSystem(Graphics myGraph) {
            Pen blackPen = new Pen(Color.FromArgb(100, Color.Black));
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            blackPen.CustomEndCap = bigArrow;
            blackPen.Width = 2;
            myGraph.DrawLine(blackPen, 0, graphBox.Height - yOffset, graphBox.Width, graphBox.Height - yOffset);

            if (xMinReal < 0) {
                myGraph.DrawLine(blackPen, xCenterCoord, graphBox.Height - yOffset, xCenterCoord, 0);
            }

            Font axisFont = new Font("Arial", 10, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            myGraph.DrawString("I(x) / I(0) [%]", axisFont, drawBrush, xCenterCoord - 80, 5);
            myGraph.DrawString("X [mm]", axisFont, drawBrush, graphBox.Width - 50, graphBox.Height - 20 - yOffset);
        }

        double getCoordOfMax(int m) {
            if (myExperiment.slitNum == 1) {
                return (double)((2 * m + 1) * myExperiment.waveLength * myExperiment.lengthToScreen / (2 * myExperiment.slitWidth));
            } else {
                return (double)(m * myExperiment.waveLength * myExperiment.lengthToScreen / myExperiment.slitPeriod);
            }
        }

        int getMaxCoord_y(int maxNum) {
            int iter = 0;
            float xPrevReal = xCenterCoordReal;
            float intensityPrev = intensityByCoord(myExperiment, xPrevReal);
            int y = graphBox.Height - (int)(Map(intensityPrev, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));
            bool isRise = false;
            float xReal = xPrevReal + xStepReal;
            while (iter != maxNum) {
                float intensityReal = intensityByCoord(myExperiment, xReal);
                if (intensityPrev < intensityReal) {
                    isRise = true;
                } else if ((intensityPrev > intensityReal) && isRise) {
                    isRise = false;
                    y = graphBox.Height - (int)(Map(intensityPrev, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));
                    iter++;
                }
                xPrevReal = xReal;
                xReal = xPrevReal + xStepReal;
                intensityPrev = intensityReal;
            }
            return y;
        }



        void drawGraphSign(Graphics myGraph) {
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            Font maxCoordFont = new Font("Arial", 10);
            double intensityReal = 1;
            myGraph.DrawString("0", maxCoordFont, redBrush, graphBox.Width / 2 - 2, graphBox.Height - yOffset);
            for (int i = 1; i <= numOfMax; i++) {
                double xReal = getCoordOfMax(i);
                int x = (int)(Map(xReal, xMinReal, xMaxReal, 0, graphBox.Width));
                intensityReal = intensityByCoord(myExperiment, xReal);
                //int y = getMaxCoord_y(i);
                int y = graphBox.Height - (int)(Map(intensityReal, yMinReal, yMaxReal, 0, graphBox.Height - yOffset));
                var coordText = Math.Round(xReal * 1000, 2).ToString();
                var intensText = String.Format("{0,7:0.#####}", intensityReal);
                myGraph.DrawString(coordText, maxCoordFont, redBrush, x - coordText.Length * 4, graphBox.Height - yOffset);
                myGraph.DrawString(intensText, maxCoordFont, greenBrush, x - intensText.Length * 4, y - 15 - yOffset);

                myGraph.DrawString(String.Concat("-", coordText), maxCoordFont, redBrush, 2 * xCenterCoord - x - coordText.Length * 4, graphBox.Height - yOffset);
                myGraph.DrawString(intensText, maxCoordFont, greenBrush, 2 * xCenterCoord - x - intensText.Length * 4, y - 15 - yOffset);
            }
        }

        void drawImg() {
            Bitmap sourceBitmap = new Bitmap(graphBox.Width, graphBox.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics myGraph = Graphics.FromImage(sourceBitmap);
            xMinReal = float.Parse(xMinText.Text) / 1000;   //in metres
            xMaxReal = float.Parse(xMaxText.Text) / 1000;
            xStepReal = Map(1, 0, graphBox.Width, 0, Math.Abs(xMinReal) + Math.Abs(xMaxReal));
            yMaxReal = float.Parse(iMaxText.Text);
            myGraph.Clear(Color.White);
            drawGraph(myGraph);
            drawGraphSign(myGraph);
            printExperimentData(myGraph);
            if (myExperiment.slitNum > 1) {
                drawEnvelope(myGraph);
            }
            drawCoordSystem(myGraph);
            graphBox.Image = sourceBitmap;
        }

        private void DrawGraphButton_Click(object sender, EventArgs e) {
            drawImg();
        }

        private void GraphForm_ResizeEnd(object sender, EventArgs e) {
            drawImg();
        }

        private void saveGraphButton_Click(object sender, EventArgs e) {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                try {
                    string path = folderBrowserDialog.SelectedPath + "\\graph.jpeg";
                    graphBox.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                } catch (Exception) {
                    return;
                }
            }
        }
    }
}
