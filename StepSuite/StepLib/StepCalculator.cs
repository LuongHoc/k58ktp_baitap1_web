using System;
using System.Globalization;

namespace StepLib
{
    public class StepCalculator
    {
        public double DistanceKm { get; set; }
        public double WeightKg { get; set; }
        public double StepLengthM { get; set; }

        public string Signature { get; set; }
        public double HocFactor { get; set; }

        public StepCalculator()
        {
            StepLengthM = 0.0;
            Signature = "by Học";
            HocFactor = 1.0;
        }

        private static double Clamp(double v, double min, double max)
        {
            if (v < min) return min; if (v > max) return max; return v;
        }

        private void Validate()
        {
            if (DistanceKm < 0) throw new ArgumentOutOfRangeException("DistanceKm");
            if (WeightKg < 0) throw new ArgumentOutOfRangeException("WeightKg");
            HocFactor = Clamp(HocFactor, 0.9, 1.1);
        }

        private double ResolveStepLengthM() { return (StepLengthM > 0) ? StepLengthM : 0.75; }

        public long ComputeSteps()
        {
            Validate();
            double steps = (DistanceKm * 1000.0 / ResolveStepLengthM()) * HocFactor;
            if (steps < 0) steps = 0;
            return (long)Math.Round(steps, MidpointRounding.AwayFromZero);
        }

        public double ComputeCalories()
        {
            Validate();
            double kcal = DistanceKm * WeightKg * 0.9 * HocFactor;
            if (kcal < 0) kcal = 0;
            return Math.Round(kcal, 2);
        }

        public string FormatResult()
        {
            long steps = ComputeSteps(); double kcal = ComputeCalories();
            return string.Format(CultureInfo.InvariantCulture,
                "Steps={0}, Calories={1} ({2})", steps, kcal, Signature);
        }
    }

    public static class SafeParse
    {
        public static double PositiveDouble(string s)
        {
            if (s == null) return 0;
            double v;
            if (!double.TryParse(s.Trim().Replace(',', '.'),
                NumberStyles.Float, CultureInfo.InvariantCulture, out v)) v = 0;
            if (v < 0) v = 0;
            return v;
        }
    }
}
