using System;
namespace Operatii_cu_matrici

{
    internal class Matrix
    {
        public int rows;
        public int columns;
        public float[,] elements;

        public Matrix (int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            elements = new float [rows,columns];
            Init();
        }
        public void Init()
        {
            Random rnd = new Random();
            for(int i=0; i<rows; i++)
            {
                for(int j=0; j<columns; j++)
                {
                    elements[i, j] = rnd.Next(10);
                }
            }            
        }

        internal Matrix Multiply(Matrix m2)
        {            
            if (this.columns != m2.rows)
            {
                throw new Exception("arguments do not match");
            }

            Matrix c = new Matrix (this.rows, m2.columns);

            for (int i = 0; i < c.rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    float suma = 0;
                    for (int k = 0; k < this.rows; k++)
                    {
                        suma += GetElement(i, k) * m2.GetElement(k, j);
                    }
                    c.SetElement(i,j,suma);
                }
            }

            return c;
        }
               
        public Matrix Inversa()
        {
            float determinant = CalculateDeterminant(this.elements, rows);
            Console.WriteLine("determinant = " + determinant);
            
            Matrix transpusa = GetTransposedMatrix();

            Matrix adjuncta = transpusa.GetAdjugateMatrix();
           
            Matrix result = new Matrix(rows, rows);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    result.elements[i, j] = adjuncta.elements[i, j] / determinant;
                }
            }
            return result;
            
        }
        public bool IsInverse(float determinant)
        {
            if (determinant == 0)
            {
                Console.WriteLine("Matricea nu este inversabila");
                return false;
            }

            return true;           
        }

        public Matrix Reduce(float[,] old, int lin, int col)
        {
            int n = old.GetLength(0);
            Matrix result = new Matrix(n - 1, n - 1);

            for (int i = 0; i < lin; i++)
                for (int j = 0; j < col; j++)
                    result.elements[i, j] = old[i, j];
            for (int i = lin + 1; i < n; i++)
                for (int j = 0; j < col; j++)
                    result.elements[i - 1, j] = old[i, j];
            for (int i = 0; i < lin; i++)
                for (int j = col + 1; j < n; j++)
                    result.elements[i, j - 1] = old[i, j];
            for (int i = lin + 1; i < n; i++)
                for (int j = col + 1; j < n; j++)
                    result.elements[i - 1, j - 1] = old[i, j];

            return result;
        }
   
        private float CalculateDeterminant(float [,] m, int n)
        {
            if (rows != columns)
            {
                throw new ImpossibleMatrixOperationException();
            }

            if (n==2)
            {
                return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
            }
            if(n==3)
            {
                return (m[0, 0] * m[1, 1] * m[2, 2] + m[1, 0] * m[2, 1] * m[0, 2] + m[0, 1] * m[1, 2] * m[2, 0]) -
                    (m[0, 2] * m[1, 1] * m[2, 0] + m[0, 1] * m[1, 0] * m[2, 2] + m[1, 2] * m[2, 1] * m[0, 0]);
            }

            float sum = 0;
            for(int i=0; i<n; i++)
            {
                float [,] aux = new float[n-1,n-1];
                int p = 0;
                int q = 0;
                for(int k=1; k<n; k++)
                {
                    for(int j=0; j<n; j++)
                    {
                        if(j != i)
                        {
                            aux[p, q] = m[k, j];
                            q++;
                        }
                    }
                    q = 0;
                    p++;
                }
                if((i+2)%2==0)
                {
                    sum += m[0, 1] * CalculateDeterminant(aux, n - 1);
                }
                else
                {
                    sum -= m[0, 1] * CalculateDeterminant(aux, n - 1);
                }
            }


            return sum;           
        }

        private Matrix GetAdjugateMatrix()
        {
            Matrix result = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Matrix b = Reduce(this.elements, i, j);
                    float bdet = CalculateDeterminant(b.elements, b.rows);                               
                    
                    result.elements[i, j] = (float)Math.Pow(-1, (i+1 + j+1)) * bdet;
                }
            }


            return result;
        }
        private Matrix GetTransposedMatrix()
        {
            Matrix a = new Matrix(rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    a.elements[i, j] = elements[j, i];
                }
            }
            return a;
        }
        internal Matrix Power(int k)
        {
            if(k==1)
            {
                return this;
            }
           
            Matrix result = this;
            for(int i=1; i<k; i++)
            {
               result = result.Multiply(this);                
            }
            return result;
        }

        internal Matrix Add(Matrix m2)
        {
            
            Matrix result = new Matrix(rows, columns);
            for (int i = 0; i < m2.rows; i++)
            {
                for (int j = 0; j < m2.columns; j++)
                {
                    float suma = elements[i, j] + m2.GetElement(i, j);
                    result.SetElement(i, j, suma);
                }
            }
            return result;            
        }
        internal Matrix Subtract(Matrix m2)
        {

            Matrix result = new Matrix(rows, columns);
            for (int i = 0; i < m2.rows; i++)
            {
                for (int j = 0; j < m2.columns; j++)
                {
                    float diferenta = elements[i, j] - m2.GetElement(i, j);
                    result.SetElement(i, j, diferenta);
                }
            }
            return result;
        }
        public float GetElement(int row, int column)
        {
            return elements[row, column];
        }
        public void SetElement(int row, int column, float value)
        {
            elements[row, column] = value;
        }
        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                   Console.Write( elements[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}