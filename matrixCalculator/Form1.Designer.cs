namespace matrixCalculator
{
    partial class MatrixCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewMatrix = new DataGridView();
            labelSize = new Label();
            textBoxSize = new TextBox();
            buttonGenerate = new Button();
            dataGridViewMatrix2 = new DataGridView();
            dataGridViewMatrixResult = new DataGridView();
            buttonSum = new Button();
            buttonUmn = new Button();
            buttonTranspo = new Button();
            buttonWrite = new Button();
            labelResult = new Label();
            buttonClearResult = new Button();
            buttonClearMatrix = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewMatrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(186, 11);
            dataGridViewMatrix.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.RowTemplate.Height = 29;
            dataGridViewMatrix.Size = new Size(329, 212);
            dataGridViewMatrix.TabIndex = 0;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(10, 11);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(149, 15);
            labelSize.TabIndex = 1;
            labelSize.Text = "Задайте размер матрицы:";
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(10, 37);
            textBoxSize.Margin = new Padding(3, 2, 3, 2);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(149, 23);
            textBoxSize.TabIndex = 3;
            textBoxSize.TextChanged += textBoxSize_TextChanged;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerate.Location = new Point(12, 73);
            buttonGenerate.Margin = new Padding(3, 2, 3, 2);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(149, 32);
            buttonGenerate.TabIndex = 6;
            buttonGenerate.Text = "Заполнить случайно ";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // dataGridViewMatrix2
            // 
            dataGridViewMatrix2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix2.Location = new Point(545, 11);
            dataGridViewMatrix2.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMatrix2.Name = "dataGridViewMatrix2";
            dataGridViewMatrix2.RowHeadersWidth = 51;
            dataGridViewMatrix2.RowTemplate.Height = 29;
            dataGridViewMatrix2.Size = new Size(330, 212);
            dataGridViewMatrix2.TabIndex = 8;
            // 
            // dataGridViewMatrixResult
            // 
            dataGridViewMatrixResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixResult.Location = new Point(382, 248);
            dataGridViewMatrixResult.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMatrixResult.Name = "dataGridViewMatrixResult";
            dataGridViewMatrixResult.RowHeadersWidth = 51;
            dataGridViewMatrixResult.RowTemplate.Height = 29;
            dataGridViewMatrixResult.Size = new Size(330, 212);
            dataGridViewMatrixResult.TabIndex = 9;
            // 
            // buttonSum
            // 
            buttonSum.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSum.Location = new Point(12, 150);
            buttonSum.Margin = new Padding(3, 2, 3, 2);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(149, 32);
            buttonSum.TabIndex = 11;
            buttonSum.Text = "Выполнить сложение";
            buttonSum.UseVisualStyleBackColor = true;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonUmn
            // 
            buttonUmn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUmn.Location = new Point(12, 186);
            buttonUmn.Margin = new Padding(3, 2, 3, 2);
            buttonUmn.Name = "buttonUmn";
            buttonUmn.Size = new Size(149, 32);
            buttonUmn.TabIndex = 12;
            buttonUmn.Text = "Выполнить умножение";
            buttonUmn.UseVisualStyleBackColor = true;
            buttonUmn.Click += buttonUmn_Click;
            // 
            // buttonTranspo
            // 
            buttonTranspo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTranspo.Location = new Point(12, 222);
            buttonTranspo.Margin = new Padding(3, 2, 3, 2);
            buttonTranspo.Name = "buttonTranspo";
            buttonTranspo.Size = new Size(149, 40);
            buttonTranspo.TabIndex = 13;
            buttonTranspo.Text = "Выполнить транспонирование";
            buttonTranspo.UseVisualStyleBackColor = true;
            buttonTranspo.Click += buttonTranspo_Click;
            // 
            // buttonWrite
            // 
            buttonWrite.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWrite.Location = new Point(12, 109);
            buttonWrite.Margin = new Padding(3, 2, 3, 2);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(149, 37);
            buttonWrite.TabIndex = 14;
            buttonWrite.Text = "Ввести данные из таблицы";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(161, 352);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(201, 52);
            labelResult.TabIndex = 15;
            labelResult.Text = "Результат:";
            // 
            // buttonClearResult
            // 
            buttonClearResult.Location = new Point(12, 302);
            buttonClearResult.Margin = new Padding(3, 2, 3, 2);
            buttonClearResult.Name = "buttonClearResult";
            buttonClearResult.Size = new Size(149, 32);
            buttonClearResult.TabIndex = 16;
            buttonClearResult.Text = "Очистить результат";
            buttonClearResult.UseVisualStyleBackColor = true;
            buttonClearResult.Click += buttonClearResult_Click;
            // 
            // buttonClearMatrix
            // 
            buttonClearMatrix.Location = new Point(12, 266);
            buttonClearMatrix.Margin = new Padding(3, 2, 3, 2);
            buttonClearMatrix.Name = "buttonClearMatrix";
            buttonClearMatrix.Size = new Size(149, 32);
            buttonClearMatrix.TabIndex = 17;
            buttonClearMatrix.Text = "Очистить матрицы";
            buttonClearMatrix.UseVisualStyleBackColor = true;
            buttonClearMatrix.Click += buttonClearMatrix_Click;
            // 
            // MatrixCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 611);
            Controls.Add(buttonClearMatrix);
            Controls.Add(buttonClearResult);
            Controls.Add(labelResult);
            Controls.Add(buttonWrite);
            Controls.Add(buttonTranspo);
            Controls.Add(buttonUmn);
            Controls.Add(buttonSum);
            Controls.Add(dataGridViewMatrixResult);
            Controls.Add(dataGridViewMatrix2);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxSize);
            Controls.Add(labelSize);
            Controls.Add(dataGridViewMatrix);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MatrixCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькултор матриц";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMatrix;
        private Label labelSize;
        private TextBox textBoxSize;
        private Button buttonGenerate;
        private DataGridView dataGridViewMatrix2;
        private DataGridView dataGridViewMatrixResult;
        private Button buttonSum;
        private Button buttonUmn;
        private Button buttonTranspo;
        private Button buttonWrite;
        private Label labelResult;
        private Button buttonClearResult;
        private Button buttonClearMatrix;
    }
}