namespace Sumalinog_Regression
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brnPerceptron_Click(object sender, EventArgs e)
        {
            //get inputs from user
            int input1 = Convert.ToInt32(txtInput1.Text);
            int input2 = Convert.ToInt32(txtInput2.Text);
            int numOfEpochs = Convert.ToInt32(txtEpoch.Text);

            //application of perceptron codes
            perceptron = new Perceptron(numInputs: 2);
            double[][] inputs = new double[][]
            {
                new double[] { 0, 0 },
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 1, 1 }
            };
            //set target
            int[] targets = new int[] { 1, 1, 1, 0};

            //train perceptron
            perceptron.Train(inputs, targets, numOfEpochs);

            //get output
            string output = perceptron.Predict(new double[] { input1, input2 }).ToString();

            //show output
            lblOutput.Text = output;
        }
    }
}