using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer {
    class DifferentialEvolution {
        private const float ShrinkFactor = 0.6F;
        private const int PopulationSize = 40, Iterations = 200, Runs = 3;

        struct Creature {
            public Vector4 p;
            public float F;

            public Creature(Vector4 p, float F) {
                this.p = p;
                this.F = F;
            }
        }

        private Creature[] population;

        private float[] desiredFrequencies;
        private float suppressVariance;

        private Vector4 min, max;

        public DifferentialEvolution(float[] desiredFrequencies, float suppressVariance, Vector4 min, Vector4 max) {
            this.desiredFrequencies = desiredFrequencies;
            this.suppressVariance = suppressVariance;
            this.min = min;
            this.max = max;
        }

        private float Mod(float a, float b) {
            return a - b * (float)Math.Floor(a / b);
        }

        private float Fract(float x, float min, float max) {
            return min + Mod(x - min, max - min);
        }

        private Vector4 KeepWithinBounds(Vector4 p) {
            Vector4 r = new Vector4();
            r.X = Fract(p.X, min.X, max.X);
            r.Y = Fract(p.Y, Math.Max(r.X, min.Y), max.Y);
            r.Z = Fract(p.Z, min.Z, max.Z);
            r.W = Fract(p.W, min.W, max.W);
            return r;
        }

        private float EvaluateFitness(Vector4 p) {
            (float f, float a)[] data = Maa.Compute(p);

            bool optimizeAll = desiredFrequencies.Length == Maa.Frequencies.Length;

            var desired = data.Where(t => desiredFrequencies.Contains(t.f));
            var others = data.Except(desired);

            float avgDesired = desired.Average(t => t.a);
            float avgOthers = optimizeAll ? 0.0F : others.Average(t => t.a);
            float varDesired = desired.Average(t => (t.a - avgDesired) * (t.a - avgDesired));
            float varOthers = optimizeAll ? 0.0F : others.Average(t => (t.a - avgOthers) * (t.a - avgOthers));

            return avgDesired - suppressVariance * (varDesired + varOthers);
        }

        private void GeneratePopulation() {
            population = new Creature[PopulationSize];
            for (int i = 0; i < population.Length; i++) {
                float holeDiameter = MathUtils.RandomFloat(min.X, max.X);
                Vector4 p = new Vector4(
                    holeDiameter,
                    MathUtils.RandomFloat(Math.Max(holeDiameter, min.Y), max.Y),
                    MathUtils.RandomFloat(min.Z, max.Z),
                    MathUtils.RandomFloat(min.W, max.W)
                );
                population[i] = new Creature(p, EvaluateFitness(p));
            }
        }

        private void Step() {
            for (int i = 0; i < population.Length; i++) {
                // Pick random indices u, v, w.
                List<int> ind = new List<int>() { i };
                while (ind.Count < 4) {
                    int k;
                    do {
                        k = MathUtils.RandomInt(population.Length);
                    } while (ind.Contains(k));
                    ind.Add(k);
                }

                Vector4 p = population[i].p;

                // Generate a new candidate
                Vector4 q = population[ind[1]].p + ShrinkFactor * (population[ind[2]].p - population[ind[3]].p);
                q = KeepWithinBounds(new Vector4(
                    MathUtils.RandomBool() ? p.X : q.X,
                    MathUtils.RandomBool() ? p.Y : q.Y,
                    MathUtils.RandomBool() ? p.Z : q.Z,
                    MathUtils.RandomBool() ? p.W : q.W
                ));

                // Pick the better one of both
                float Fq = EvaluateFitness(q);
                if (Fq > population[i].F) {
                    population[i] = new Creature(q, Fq);
                }
            }
        }

        private Creature GetBest() {
            return population.OrderByDescending(c => c.F).First();
        }

        public async Task<Vector4> Compute(IProgress<float> progress) {
            Creature[] bests = new Creature[Runs];
            await Task.Run(() => {
                for (int i = 0; i < Runs; i++) {
                    GeneratePopulation();
                    for (int j = 0; j < Iterations; j++) {
                        Step();
                        progress.Report((i * Iterations + j + 1) / (float)(Runs * Iterations));
                    }
                    bests[i] = GetBest();
                }
            });
            return bests.OrderByDescending(c => c.F).First().p;
        }
    }
}
