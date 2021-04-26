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
    public partial class DataForm : Form {
        public DataForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            GraphForm.myExperiment.lengthToScreen = float.Parse(lengthToScreen.Text);
            GraphForm.myExperiment.waveLength = float.Parse(waveLength.Text) / Math.Pow(10, 9);
            GraphForm.myExperiment.slitWidth = float.Parse(slitWidth.Text) / Math.Pow(10, 6);
            GraphForm.myExperiment.slitPeriod = float.Parse(slitPeriod.Text) / Math.Pow(10, 6);
            GraphForm.myExperiment.slitNum = int.Parse(numOfSlits.Text);

            var graphForm = new GraphForm();
            graphForm.ShowDialog();
        }
    }
}
