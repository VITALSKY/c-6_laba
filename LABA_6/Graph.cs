using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Undirected_graph__lab6_
{
    class Graph
    {
        int Quantity;
        int[,] M;

        public Graph(int Quantity, int[,] Matrix)
        {
            this.Quantity = Quantity;
            int[,] M = new int[Quantity, Quantity];
            for (int i = 0; i < Quantity; i++)
                for(int j = 0; j < Quantity; j++)
                    M[i, j] = Matrix[i, j];      
        }
        public Graph()
        {

        }

        public int Quant
        {
            get { return this.Quantity; }
            set { this.Quantity = value; }
        }

        public int[,] Matr
        {
            get { return this.M; }
            set { this.M = value; }
        }
        public void AddVertex()
        {
            this.Quantity += 1;
            int[,] newM = new int[Quantity, Quantity];
            for (int i = 0; i < Quantity - 1; i++)
                for (int j = 0; j < Quantity - 1; j++)
                    newM[i, j] = M[i, j];
            M = newM;
        }

        public void DeleteVertex(int NumberVertex)
        {
            this.Quantity -= 1;
            int[,] newM = new int[Quantity, Quantity];
            for (int i = 0; i < Quantity + 1; i++)
            {
                if (i == NumberVertex - 1)
                    continue;
                for (int j = 0; j < Quantity + 1; j++)
                {
                    if (j == NumberVertex - 1)
                        continue;
                    if (i > NumberVertex - 1 && j > NumberVertex - 1)
                        newM[i - 1, j - 1] = M[i, j];
                    else if (i > NumberVertex - 1)
                        newM[i - 1, j] = M[i, j];
                    else if (j > NumberVertex - 1)
                        newM[i, j - 1] = M[i, j];
                    else newM[i, j] = M[i, j];
                }
            }
            M = newM;
        }

        public void AddEdge(int First, int Second)
        {
            M[First - 1, Second - 1] = 1;
            M[Second - 1, First - 1] = 1;
        }

        public void DeleteEdge(int First, int Second)
        {
            M[First - 1, Second - 1] = 0;
            M[Second - 1, First - 1] = 0;
        }

        public Bitmap Painting(System.Windows.Forms.PictureBox PB)
        {
            Bitmap bmp = new Bitmap(PB.Width, PB.Height);
            Graphics gr = Graphics.FromImage(bmp);
            Pen p1 = new Pen(Color.Red);
            int x0 = PB.Height / 2;
            int y0 = PB.Width / 2;
            int R = PB.Height / 4;

            for(int i = 0; i < Quantity; i++)
            {
                gr.FillEllipse(Brushes.Blue, x0 + (int)((R * Math.Cos(2 * Math.PI * i / Quantity))) - 3, y0 + (int)((R * Math.Sin(2 * Math.PI * i / Quantity))) - 3, 5, 5);
                gr.DrawString((i+1).ToString(), new Font("Arial", 14), Brushes.Black, x0 + (int)((R * Math.Cos(2 * Math.PI * i / Quantity))) - 3, y0 + (int)((R * Math.Sin(2 * Math.PI * i / Quantity))) - 3);
            }

            for(int i = 0; i < Quantity; i++)
            {
                for (int j = i + 1; j < Quantity; j++)
                    if (M[i, j] == 1)
                        gr.DrawLine(p1, x0 + (int)((R * Math.Cos(2 * Math.PI * i / Quantity))), y0 + (int)((R * Math.Sin(2 * Math.PI * i / Quantity))), x0 + (int)((R * Math.Cos(2 * Math.PI * j / Quantity))), y0 + (int)((R * Math.Sin(2 * Math.PI * j / Quantity))));
                    else continue;
            }
            return bmp;
        }

        public Graph ClearGraph(Graph gr)
        {
            int Q = gr.Quantity;
            for (int i = Q; i > 0; i--)
            {
                gr.DeleteVertex(i);
            }
            return gr;
        }
    }
}
