using WaterShop;

namespace Coffee_Machine
{
    public partial class Form1 : Form
    {

        private CoffeeMachine coffeeMachine;

        public Form1()
        {
            InitializeComponent();
            coffeeMachine = new CoffeeMachine();
            UpdateStock();
        }

        private void UpdateStock()
        {
            CFStock.Text = coffeeMachine.Ingredients["Coffee"].Quantity.ToString();
            ChocStock.Text = coffeeMachine.Ingredients["Chocolate"].Quantity.ToString();
            MilkStock.Text = coffeeMachine.Ingredients["Hot_Milk"].Quantity.ToString();
            WaterStock.Text = coffeeMachine.Ingredients["Water"].Quantity.ToString();
        }
        private void MakeCoffee(string type)
        {
            if (coffeeMachine.MakeCoffee(type))
            {
                UpdateStock();
            }
            else
            {
                MessageBox.Show(" Ë«πº ¡‰¡ËæÕ!", "·®Èß‡µ◊Õπ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var ingredient in coffeeMachine.Ingredients.Values)
            {
                ingredient.Refill(1000);
            }
            UpdateStock();
        }

        private void BlackCF_B_Click(object sender, EventArgs e)
        {
            MakeCoffee("Black");
        }

        private void HotChoc_B_Click(object sender, EventArgs e)
        {
            MakeCoffee("HotChocolate");
        }

        private void Mocca_B_Click(object sender, EventArgs e)
        {
            MakeCoffee("Mocca");
        }

        private void Latte_B_Click(object sender, EventArgs e)
        {
            MakeCoffee("Late");
        }
    }
}
