using System;
using System.Collections.Generic;
using System.Text;

namespace PrePocessing
{
    public class ObservationVector
    {
        public double[][] OrientationField;
        double getAlphaX(int u, int v)
        {
            return this.OrientationField[u + 1][v] - this.OrientationField[u - 1][v];
        }
        double getAlphaY(int u, int v)
        {
            return this.OrientationField[u][v + 1] - this.OrientationField[u][v - 1];
        }
        double getVX()
        {
            int u, v;
            double sum = 0;
            int uMax = OrientationField.Length-2;
            int vMax = OrientationField[0].Length-2;
            for (u = 1; u <= uMax; u++)
            {
                for (v = 1; v <= vMax; v++)
                {
                    sum += 2 * getAlphaX(u, v) * getAlphaY(u, v);
                }
            }
            return sum;
        }
        double getVY()
        {
            int u, v;
            double sum = 0;
            int uMax = OrientationField.Length - 2;
            int vMax = OrientationField[0].Length - 2;
            for (u = 1; u <= uMax; u++)
            {
                for (v = 1; v <= vMax; v++)
                {
                    sum += getAlphaX(u, v) * getAlphaX(u, v) - getAlphaY(u, v) * getAlphaY(u, v);
                }
            }
            return sum;
        }
        public double GetTheta()
        {
            return 0.5*Math.Atan2(getVX(),getVY());
        }
    }
}
