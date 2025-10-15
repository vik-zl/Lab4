using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public partial class ChamplainStudent : Person, IGrading
    {
      public double CalculateAverage()
        {
            if (Score.Count == 0) return 0;
            return Score.Average();

        }


        public double  CalculateGPA()
        {
            double average = CalculateGPA();
            if (average >= 90) return 4.0;
            else if (average >= 80) return 3.0;
            else if (average >= 70) return 2.0;
            else if (average >= 60) return 1.0;
            else return 0.0;
        }


        public double  CalculateRScore(double Zscore, double IRG)
        {
            return ((Zscore * 5) + (IRG + 35) / 60 * 20);
        }
    }
}
