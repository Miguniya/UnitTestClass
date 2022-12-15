using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit1
{
    public class Sedlo
    {
        int[,] matrix;
        public List<Point> sedloPoints = new List<Point>();

        public Sedlo(int[,] matrix)
        {
            this.matrix = matrix;

            var maxPoints = Max('r');
            var minPoints = Min('c');

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxPoints[i] && matrix[i, j] == minPoints[j])
                        SedloPoints.Add(new Point(i, j, matrix[i, j]));
                }
            }

            maxPoints = Max('c');
            minPoints = Min('r');
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxPoints[j] && matrix[i, j] == minPoints[i])
                        SedloPoints.Add(new Point(i, j, matrix[i, j]));
                }
            }

            //SedloPoints.Add(new Point(0,0,0)); 
        }
        public int[] Max(char type)//r - по строкам c- по столбцам
        {
            int maxValue = 0;
            int[] matrixMax = (type == 'r' ? new int[matrix.GetLength(0)] : new int[matrix.GetLength(1)]);

            switch (type)
            {
                case 'r':
                    {
                        //по столбцу
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            maxValue = matrix[i, 0];
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (maxValue < matrix[i, j])
                                    maxValue = matrix[i, j];
                            }
                            matrixMax[i] = maxValue;
                        }
                        break;
                    }
                case 'c':
                    {
                        //по строке
                        for (int i = 0; i < matrix.GetLength(1); i++)
                        {
                            maxValue = matrix[0, i];
                            for (int j = 0; j < matrix.GetLength(0); j++)
                            {
                                if (maxValue < matrix[j, i])
                                    maxValue = matrix[j, i];
                            }
                            matrixMax[i] = maxValue;
                        }
                        break;
                    }

            }
            return matrixMax;
        }
        public int[] Min(char type)//r - по строкам c- по столбцам
        {
            int maxValue = 0;
            int[] matrixMax = (type == 'r' ? new int[matrix.GetLength(0)] : new int[matrix.GetLength(1)]);

            switch (type)
            {
                case 'r':
                    {
                        //по столбцу
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            maxValue = matrix[i, 0];
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (maxValue > matrix[i, j])
                                    maxValue = matrix[i, j];
                            }
                            matrixMax[i] = maxValue;
                        }
                        break;
                    }
                case 'c':
                    {
                        //по строке
                        for (int i = 0; i < matrix.GetLength(1); i++)
                        {
                            maxValue = matrix[0, i];
                            for (int j = 0; j < matrix.GetLength(0); j++)
                            {
                                if (maxValue > matrix[i, j])
                                    maxValue = matrix[i, j];
                                matrixMax[i] = maxValue;
                            }
                        }
                        break;
                    }

            }
            return matrixMax;
        }

        public List<Point> SedloPoints
        {
            get { return sedloPoints; }
            private set { sedloPoints = value; }
        }
    }
}
