using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Optimizer {
    public partial class FrmMain : Form {
        private LiveCharts.WinForms.CartesianChart chart;
        private DifferentialEvolution optimizer;

        private Vector4 best;

        public FrmMain() {
            InitializeComponent();

            chart = new LiveCharts.WinForms.CartesianChart() {
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                DisableAnimations = true
            };

            chart.AxisX.Add(new Axis() {
                Labels = Maa.Frequencies.Select(f => f.ToString()).ToList(),
                Title = "Frequency (Hz)",
                Separator = new LiveCharts.Wpf.Separator() {
                    Step = 2
                }
            });

            chart.AxisY.Add(new Axis() {
                MinValue = 0,
                MaxValue = 1,
                Title = "Predicted absorption (α)"
            });

            chart.Font = Font;

            chart.Series.Add(new LineSeries() {
                Title = "Predicted absorption",
                Values = new ChartValues<double>(new double[Maa.Frequencies.Length]),
                LabelPoint = p => p.Y.ToString("0.000")
            });

            pnlPlot.Controls.Add(chart);

            rngHoleDiameter.ValueChanged += Rng_ValueChanged;
            rngHoleRepeatDistance.ValueChanged += Rng_ValueChanged;
        }

        private void Plot(Vector4 p) {
            var data = Maa.Compute(p);
            chart.Series[0].Values = new ChartValues<float>(data.Select(t => t.a));
            lblBest.Text = $"d = {best.X:0.000} mm, b = {best.Y:0.000} mm, t = {best.Z:0.000} mm, D = {best.W:0.000} mm";
        }

        private void Rng_ValueChanged(object sender, EventArgs e) {
            if (rngHoleRepeatDistance.Min < rngHoleDiameter.Min) {
                rngHoleRepeatDistance.Min = rngHoleDiameter.Min;
            }
            if (rngHoleRepeatDistance.Max < rngHoleDiameter.Max) {
                rngHoleRepeatDistance.Max = rngHoleDiameter.Max;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            clbFrequencies.Items.AddRange(Maa.Frequencies.Select(f => (object)f).ToArray());
        }

        private async void btnOptimize_Click(object sender, EventArgs e) {
            btnOptimize.Enabled = false;
            btnSavePlot.Enabled = false;

            List<float> frequencies = new List<float>();
            foreach(object f in clbFrequencies.CheckedItems) {
                frequencies.Add((float)f);
            }

            optimizer = new DifferentialEvolution(
                // If we picked no frequencies, we chose all frequencies
                frequencies.Count == 0 ? Maa.Frequencies : frequencies.ToArray(),
                (float)nudReduceVariance.Value,
                new Vector4((float)rngHoleDiameter.Min, (float)rngHoleRepeatDistance.Min, (float)rngThickness.Min, (float)rngCavityDepth.Min),
                new Vector4((float)rngHoleDiameter.Max, (float)rngHoleRepeatDistance.Max, (float)rngThickness.Max, (float)rngCavityDepth.Max));

            best = await optimizer.Compute(new Progress<float>(p => pbProgress.Value = (int)(p * 100)));
            Plot(best);
            
            pbProgress.Value = 0;

            btnOptimize.Enabled = true;
            btnSavePlot.Enabled = true;
        }

        private void pnlPlot_Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawString("Test", Font, Brushes.Black, PointF.Empty);
        }

        private void btnSavePlot_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog() {
                Filter = "*.png|*.png"
            };
            if (sfd.ShowDialog() == DialogResult.OK) {
                try {
                    using (Bitmap bmp = new Bitmap(pnlPlot.Width, pnlPlot.Height)) {
                        pnlPlot.DrawToBitmap(bmp, new Rectangle(0, 0, pnlPlot.Width, pnlPlot.Height));
                        using (Graphics g = Graphics.FromImage(bmp)) {
                            g.DrawString(lblBest.Text, Font, Brushes.Black, new Point(45, 15));
                        }
                        bmp.Save(sfd.FileName);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error while saving plot: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
