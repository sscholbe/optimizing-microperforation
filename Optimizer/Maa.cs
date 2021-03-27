using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer {
    class Maa {
        // 1/3 octaves
        public static float[] Frequencies = new float[] {
            1, 50, 63, 80, 100, 125, 160, 200, 250, 315, 400, 500, 630, 800, 1000, 1250, 1600, 2000, 2500, 3150, 4000, 5000, 6300, 8000, 10000
        };

        private static Complex Bessel(int order, Complex z) {
            if (order == 0 && z.Real == 0 && z.Imaginary == 0) {
                return new Complex();
            }

            double t0 = 1;
            for (int i = 2; i <= order; i++) {
                t0 /= i;
            }

            Complex t = t0, sum = t0, z2 = z * z / 4;
            for (int i = 0; i < 200; i++) {
                t = t / (i + 1) * z2 / (order + i + 1);
                if (i % 2 == 1) {
                    sum += t;
                } else {
                    sum -= t;
                }
                if (Complex.Abs(t / t0) < 1E-6) {
                    break;
                }
            }
            return sum * Complex.Pow(z / 2, order);
        }

        // X: Hole diameter, Y: Hole repeat distance, Z: Thickness, W: Cavity depth
        public static (float f, float a)[] Compute(Vector4 p) {
            return Frequencies.Select(f => (f, (float)Compute(p / 1000, f))).ToArray();
        }

        private static double Compute(Vector4 p, double f) {
            // Note: p in meters!

            const double airViscosity = 1.85E-5, gasConstant = 287.05,
                airDensityNtp = 1.293, gamma = 1.402, oneAtm = 101325;
            const double airTemp = 20.0, airPressureBar = 1.000;

            double airDensity = airPressureBar * oneAtm / (gasConstant * (273.15 + airTemp)),
                soundVelocity = Math.Sqrt(gamma * oneAtm / airDensityNtp * (1 + airTemp / 273.15)),
                airImpedance = soundVelocity * airDensity;

            double angularFrequency = 2 * Math.PI * f,
                waveNumber = 2 * Math.PI / soundVelocity * f;
            double holeRadius = p.Z / 2;

            Complex jwpt = Complex.ImaginaryOne * angularFrequency * airDensity * p.X;
            Complex k1p = holeRadius * Math.Sqrt(airDensity / airViscosity * angularFrequency) * Complex.Sqrt(-Complex.ImaginaryOne);
            Complex z1 = jwpt / (1 - (2 * Bessel(1, k1p)) / (k1p * Bessel(0, k1p)));

            double kd = waveNumber * p.W;
            Complex za = -Complex.ImaginaryOne * airImpedance * Math.Cos(kd) / Math.Sin(kd);

            double microPorosity = Math.PI * (holeRadius * holeRadius) / (p.Y * p.Y);
            double twoSq = Math.Sqrt(2 * angularFrequency * airDensity * airViscosity) / (2 * microPorosity);
            Complex jpwa = Complex.ImaginaryOne * (1.7 * angularFrequency * airDensity * holeRadius / microPorosity);
            Complex zh = ((z1 / microPorosity) + za + twoSq + jpwa);
            Complex reflection = (zh - airImpedance) / (zh + airImpedance);

            return 1 - Math.Pow(Complex.Abs(reflection), 2);
        }
    }
}
