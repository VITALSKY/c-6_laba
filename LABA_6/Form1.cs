using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Undirected_graph__lab6_
{
    public partial class Form1 : Form
    {
        Graph Grafic = new Graph();
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileTool_Click(object sender, EventArgs e)
        {
            GraphBox.Image = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader SR = new StreamReader(openFileDialog.FileName);
                string KolvoVer = SR.ReadLine();
                int MaxVert = Int32.Parse(KolvoVer);
                if (MaxVert == 0)
                {
                    MessageBox.Show("ERROR. КОЛИЧЕСТВО ВЕРШИН = 0. ERROR");
                    return;
                }

                int[,] Matrix = new int[MaxVert, MaxVert];

                for (int i = 0; i < MaxVert; i++)
                {
                    string Currentstr = SR.ReadLine();

                    string[] Splitstr = Currentstr.Split(' ');
                    for (int j = 0; j < MaxVert; j++)
                    {
                        int k = Int32.Parse(Splitstr[j]);
                        Matrix[i, j] = k;
                    }
                }

                Grafic.Quant = MaxVert;
                Grafic.Matr = Matrix;
                Bitmap bmp = new Bitmap(GraphBox.Width, GraphBox.Height);
                bmp = Grafic.Painting(GraphBox);
                GraphBox.Image = bmp;
            }
        }

        private void SaveFileTool_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter StWr = new StreamWriter(saveFileDialog.FileName);
                int MaxVert = Grafic.Quant;
                int[,] Matrix = new int[MaxVert, MaxVert];
                Matrix = Grafic.Matr;
                
                StWr.WriteLine(MaxVert.ToString());
                for (int i = 0; i < MaxVert; i++)
                    for (int j = 0; j < MaxVert; j++)
                    {
                        StWr.Write(Matrix[i, j].ToString(), " ");
                        if (j == MaxVert - 1)
                            StWr.Write("\n");
                    }
                StWr.Close();
            }
        }

        private void AddVertex_Click(object sender, EventArgs e)
        {
            Grafic.AddVertex();
            Bitmap bmp = new Bitmap(GraphBox.Width, GraphBox.Height);
            bmp = Grafic.Painting(GraphBox);
            GraphBox.Image = bmp;
        }

        private void DeleteVertex_Click(object sender, EventArgs e)
        {
            if (TBVertexDel.TextLength == 0)
            {
                MessageBox.Show("ERROR. Введите номер вершины. ERROR");
                TBVertexDel.Clear();
                return;
            }
            int Vertex = Int32.Parse(TBVertexDel.Text);
            if (Vertex == 0 || Vertex > Grafic.Quant)
            {
                MessageBox.Show("ERROR. Удостоверьтесь в правильности ввода. ERROR");
                TBVertexDel.Clear();
                return;
            }
            Grafic.DeleteVertex(Vertex);
            Bitmap bmp = new Bitmap(GraphBox.Width, GraphBox.Height);
            bmp = Grafic.Painting(GraphBox);
            GraphBox.Image = bmp;
            TBVertexDel.Clear();
        }

        private void AddEdge_Click(object sender, EventArgs e)
        {
            if (TBAdd1.TextLength == 0 || TBAdd2.TextLength == 0)
            {
                MessageBox.Show("ERROR. Введите обе величины. ERROR");
                TBAdd1.Clear();
                TBAdd2.Clear();
                return;
            }
            int Vertex1 = Int32.Parse(TBAdd1.Text);
            int Vertex2 = Int32.Parse(TBAdd2.Text);
            if (Vertex1 == 0 || Vertex1 > Grafic.Quant || Vertex2 == 0 || Vertex2 > Grafic.Quant)
            {
                MessageBox.Show("ERROR. Удостоверьтесь в правильности ввода. ERROR");
                TBAdd1.Clear();
                TBAdd2.Clear();
                return;
            }
            Grafic.AddEdge(Vertex1, Vertex2);
            Bitmap bmp = new Bitmap(GraphBox.Width, GraphBox.Height);
            bmp = Grafic.Painting(GraphBox);
            GraphBox.Image = bmp;
            TBAdd1.Clear();
            TBAdd2.Clear();
        }

        private void DeleteEdge_Click(object sender, EventArgs e)
        {
            if (TBDel1.TextLength == 0 || TBDel2.TextLength == 0)
            {
                MessageBox.Show("ERROR. Введите обе величины. ERROR");
                TBDel1.Clear();
                TBDel2.Clear();
                return;
            }
            int Vertex1 = Int32.Parse(TBDel1.Text);
            int Vertex2 = Int32.Parse(TBDel2.Text);
            if (Vertex1 == 0 || Vertex1 > Grafic.Quant || Vertex2 == 0 || Vertex2 > Grafic.Quant)
            {
                MessageBox.Show("ERROR. Удостоверьтесь в правильности ввода. ERROR");
                TBDel1.Clear();
                TBDel2.Clear();
                return;
            }
            Grafic.DeleteEdge(Vertex1, Vertex2);
            Bitmap bmp = new Bitmap(GraphBox.Width, GraphBox.Height);
            bmp = Grafic.Painting(GraphBox);
            GraphBox.Image = bmp;
            TBDel1.Clear();
            TBDel2.Clear();
        }

        private void NewFileTool_Click(object sender, EventArgs e)
        {
            Grafic.ClearGraph(Grafic);
            Bitmap bmp = new Bitmap(GraphBox.Width, GraphBox.Height);
            bmp = Grafic.Painting(GraphBox);
            GraphBox.Image = bmp;
        }

        private void GraphBox_Click(object sender, EventArgs e)
        {

        }

        private void EdgeOperations_Click(object sender, EventArgs e)
        {

        }

        private void TBAdd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBAdd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBDel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBVertexDel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
