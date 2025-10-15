using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public  interface IGrading
    {

        double CalculateAverage();
        double  CalculateGPA();
        double  CalculateRScore(double Zscore, double IRG);



    }
}
