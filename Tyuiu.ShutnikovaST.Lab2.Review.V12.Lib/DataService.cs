namespace Tyuiu.ShutnikovaST.Lab2.Review.V12.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int start, int end)
        {
            if (start > end)
                return new double[0];
            double[] results = new double[end - start + 1];
            int index = 0;
            for (int x = start; x <= end; x++)
            {
                double znamenatel = Math.PI - 2 * Math.Pow(x, 3);
                if (Math.Abs(znamenatel) < 0.000001) 
                {
                    results[index] = double.NaN; 
                }
                else
                {
                    results[index] = Math.Cos(x) / znamenatel + 16 * x * Math.Cos(x) - 2; 
                    results[index] = Math.Round(results[index], 2); 
                }
                index++; 
            }
            return results;
        }
    }
}