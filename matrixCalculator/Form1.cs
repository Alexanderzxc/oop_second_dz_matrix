using System.Windows.Forms;

namespace matrixCalculator
{
    public partial class MatrixCalculator : Form
    {
        Matrix matrixVisual;
        Matrix matrixVisual2;
        Matrix matrixResult;

        public MatrixCalculator()
        {
            InitializeComponent();
            textBoxSize.Text = "3";
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
                matrixVisual.Random();
                matrixVisual2.Random();
                matrixVisual.Visualize(dataGridViewMatrix);
                matrixVisual2.Visualize(dataGridViewMatrix2);
        }


        private void textBoxSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                matrixVisual = new Matrix(Convert.ToInt32(textBoxSize.Text));
                matrixVisual2 = new Matrix(Convert.ToInt32(textBoxSize.Text));
            }
            catch
            {
                MessageBox.Show("Неправильный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSize.Text = "";
            }
        }


        private void buttonSum_Click(object sender, EventArgs e)
        {
            matrixResult = matrixVisual + matrixVisual2;
            matrixResult.Visualize(dataGridViewMatrixResult);
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            matrixVisual.FillMatrixGrid(dataGridViewMatrix);
            matrixVisual2.FillMatrixGrid(dataGridViewMatrix2);
        }

        private void buttonUmn_Click(object sender, EventArgs e)
        {
            matrixResult = matrixVisual * matrixVisual2;
            matrixResult.Visualize(dataGridViewMatrixResult);
        }

        private void buttonTranspo_Click(object sender, EventArgs e)
        {
            matrixResult = !matrixVisual;
            matrixResult.Visualize(dataGridViewMatrixResult);
        }

        private void buttonClearResult_Click(object sender, EventArgs e)
        {
            dataGridViewMatrixResult.Rows.Clear();

        }

        private void buttonClearMatrix_Click(object sender, EventArgs e)
        {
            dataGridViewMatrix.Rows.Clear();
            dataGridViewMatrix2.Rows.Clear();
        }
    }
}