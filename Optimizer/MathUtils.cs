using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimizer {
    static class MathUtils {
        private static Random rnd = new Random();

        public static float Clamp(float value, float min, float max) {
            return Math.Max(Math.Min(value, max), min);
        }

        public static float RandomFloat(float min, float max) {
            return (float)(rnd.NextDouble() * (max - min) + min);
        }

        public static bool RandomBool() {
            return rnd.NextDouble() >= 0.5;
        }

        public static int RandomInt(int max) {
            return rnd.Next(max);
        }
    }
}
