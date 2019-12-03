namespace Undirected_graph__lab6_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GraphBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.VertexOperations = new System.Windows.Forms.Label();
            this.EdgeOperations = new System.Windows.Forms.Label();
            this.TBAdd1 = new System.Windows.Forms.TextBox();
            this.TBAdd2 = new System.Windows.Forms.TextBox();
            this.TBDel1 = new System.Windows.Forms.TextBox();
            this.TBDel2 = new System.Windows.Forms.TextBox();
            this.TBVertexDel = new System.Windows.Forms.TextBox();
            this.AddVertex = new System.Windows.Forms.Button();
            this.DeleteVertex = new System.Windows.Forms.Button();
            this.AddEdge = new System.Windows.Forms.Button();
            this.DeleteEdge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphBox
            // 
            this.GraphBox.Location = new System.Drawing.Point(34, 52);
            this.GraphBox.Name = "GraphBox";
            this.GraphBox.Size = new System.Drawing.Size(520, 520);
            this.GraphBox.TabIndex = 0;
            this.GraphBox.TabStop = false;
            this.GraphBox.Click += new System.EventHandler(this.GraphBox_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuTool});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(934, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // FileMenuTool
            // 
            this.FileMenuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileTool,
            this.SaveFileTool,
            this.NewFileTool});
            this.FileMenuTool.Name = "FileMenuTool";
            this.FileMenuTool.Size = new System.Drawing.Size(48, 20);
            this.FileMenuTool.Text = "Файл";
            // 
            // OpenFileTool
            // 
            this.OpenFileTool.Name = "OpenFileTool";
            this.OpenFileTool.Size = new System.Drawing.Size(133, 22);
            this.OpenFileTool.Text = "Открыть";
            this.OpenFileTool.Click += new System.EventHandler(this.OpenFileTool_Click);
            // 
            // SaveFileTool
            // 
            this.SaveFileTool.Name = "SaveFileTool";
            this.SaveFileTool.Size = new System.Drawing.Size(133, 22);
            this.SaveFileTool.Text = "Сохранить";
            this.SaveFileTool.Click += new System.EventHandler(this.SaveFileTool_Click);
            // 
            // NewFileTool
            // 
            this.NewFileTool.Name = "NewFileTool";
            this.NewFileTool.Size = new System.Drawing.Size(133, 22);
            this.NewFileTool.Text = "Новый";
            this.NewFileTool.Click += new System.EventHandler(this.NewFileTool_Click);
            // 
            // VertexOperations
            // 
            this.VertexOperations.AutoSize = true;
            this.VertexOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VertexOperations.Location = new System.Drawing.Point(560, 108);
            this.VertexOperations.Name = "VertexOperations";
            this.VertexOperations.Size = new System.Drawing.Size(93, 24);
            this.VertexOperations.TabIndex = 2;
            this.VertexOperations.Text = "VERTEX:";
            // 
            // EdgeOperations
            // 
            this.EdgeOperations.AutoSize = true;
            this.EdgeOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EdgeOperations.Location = new System.Drawing.Point(560, 330);
            this.EdgeOperations.Name = "EdgeOperations";
            this.EdgeOperations.Size = new System.Drawing.Size(68, 24);
            this.EdgeOperations.TabIndex = 5;
            this.EdgeOperations.Text = "EDGE:";
            this.EdgeOperations.Click += new System.EventHandler(this.EdgeOperations_Click);
            // 
            // TBAdd1
            // 
            this.TBAdd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAdd1.Location = new System.Drawing.Point(804, 306);
            this.TBAdd1.Name = "TBAdd1";
            this.TBAdd1.Size = new System.Drawing.Size(29, 22);
            this.TBAdd1.TabIndex = 8;
            this.TBAdd1.TextChanged += new System.EventHandler(this.TBAdd1_TextChanged);
            // 
            // TBAdd2
            // 
            this.TBAdd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAdd2.Location = new System.Drawing.Point(859, 306);
            this.TBAdd2.Name = "TBAdd2";
            this.TBAdd2.Size = new System.Drawing.Size(29, 22);
            this.TBAdd2.TabIndex = 9;
            this.TBAdd2.TextChanged += new System.EventHandler(this.TBAdd2_TextChanged);
            // 
            // TBDel1
            // 
            this.TBDel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDel1.Location = new System.Drawing.Point(804, 350);
            this.TBDel1.Name = "TBDel1";
            this.TBDel1.Size = new System.Drawing.Size(29, 22);
            this.TBDel1.TabIndex = 10;
            this.TBDel1.TextChanged += new System.EventHandler(this.TBDel1_TextChanged);
            // 
            // TBDel2
            // 
            this.TBDel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDel2.Location = new System.Drawing.Point(859, 350);
            this.TBDel2.Name = "TBDel2";
            this.TBDel2.Size = new System.Drawing.Size(29, 22);
            this.TBDel2.TabIndex = 11;
            this.TBDel2.TextChanged += new System.EventHandler(this.TBDel2_TextChanged);
            // 
            // TBVertexDel
            // 
            this.TBVertexDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBVertexDel.Location = new System.Drawing.Point(804, 110);
            this.TBVertexDel.Name = "TBVertexDel";
            this.TBVertexDel.Size = new System.Drawing.Size(29, 22);
            this.TBVertexDel.TabIndex = 12;
            this.TBVertexDel.TextChanged += new System.EventHandler(this.TBVertexDel_TextChanged);
            // 
            // AddVertex
            // 
            this.AddVertex.Location = new System.Drawing.Point(669, 92);
            this.AddVertex.Name = "AddVertex";
            this.AddVertex.Size = new System.Drawing.Size(110, 22);
            this.AddVertex.TabIndex = 13;
            this.AddVertex.Text = "ADD VERTEX";
            this.AddVertex.UseVisualStyleBackColor = true;
            this.AddVertex.Click += new System.EventHandler(this.AddVertex_Click);
            // 
            // DeleteVertex
            // 
            this.DeleteVertex.Location = new System.Drawing.Point(669, 134);
            this.DeleteVertex.Name = "DeleteVertex";
            this.DeleteVertex.Size = new System.Drawing.Size(110, 22);
            this.DeleteVertex.TabIndex = 14;
            this.DeleteVertex.Text = "DELETE VERTEX";
            this.DeleteVertex.UseVisualStyleBackColor = true;
            this.DeleteVertex.Click += new System.EventHandler(this.DeleteVertex_Click);
            // 
            // AddEdge
            // 
            this.AddEdge.Location = new System.Drawing.Point(669, 306);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(110, 22);
            this.AddEdge.TabIndex = 15;
            this.AddEdge.Text = "ADD EDGE";
            this.AddEdge.UseVisualStyleBackColor = true;
            this.AddEdge.Click += new System.EventHandler(this.AddEdge_Click);
            // 
            // DeleteEdge
            // 
            this.DeleteEdge.Location = new System.Drawing.Point(669, 350);
            this.DeleteEdge.Name = "DeleteEdge";
            this.DeleteEdge.Size = new System.Drawing.Size(110, 22);
            this.DeleteEdge.TabIndex = 16;
            this.DeleteEdge.Text = "DELETE EDGE";
            this.DeleteEdge.UseVisualStyleBackColor = true;
            this.DeleteEdge.Click += new System.EventHandler(this.DeleteEdge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 641);
            this.Controls.Add(this.DeleteEdge);
            this.Controls.Add(this.AddEdge);
            this.Controls.Add(this.DeleteVertex);
            this.Controls.Add(this.AddVertex);
            this.Controls.Add(this.TBVertexDel);
            this.Controls.Add(this.TBDel2);
            this.Controls.Add(this.TBDel1);
            this.Controls.Add(this.TBAdd2);
            this.Controls.Add(this.TBAdd1);
            this.Controls.Add(this.EdgeOperations);
            this.Controls.Add(this.VertexOperations);
            this.Controls.Add(this.GraphBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GraphBox)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GraphBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuTool;
        private System.Windows.Forms.ToolStripMenuItem OpenFileTool;
        private System.Windows.Forms.ToolStripMenuItem SaveFileTool;
        private System.Windows.Forms.Label VertexOperations;
        private System.Windows.Forms.Label EdgeOperations;
        private System.Windows.Forms.TextBox TBAdd1;
        private System.Windows.Forms.TextBox TBAdd2;
        private System.Windows.Forms.TextBox TBDel1;
        private System.Windows.Forms.TextBox TBDel2;
        private System.Windows.Forms.TextBox TBVertexDel;
        private System.Windows.Forms.Button AddVertex;
        private System.Windows.Forms.Button DeleteVertex;
        private System.Windows.Forms.Button AddEdge;
        private System.Windows.Forms.Button DeleteEdge;
        private System.Windows.Forms.ToolStripMenuItem NewFileTool;
    }
}

