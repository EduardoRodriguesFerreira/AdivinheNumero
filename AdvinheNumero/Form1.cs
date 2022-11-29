namespace AdvinheNumero
{
    public partial class Form1 : Form
    {
        int num;
        int aleatorio;
        int cont = 0;

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random random = new Random();

            aleatorio = random.Next(0, 1000);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(txtnum.Text);
            cont++;

            lblten.Text = "Número de tentativas: " + cont.ToString();

            lblP.Text = null;
            if (cont >= 25)
            {
                Close();
            }
            if (aleatorio == num)
            {
             
                this.txtnum.BackColor=Color.Violet;
                lblTela.Text = "Acertou";
                
            }
            else if (aleatorio >num )
            {
                this.txtnum.BackColor = Color.Blue;   
                lblTela.Text = "Mais alto";
            }else if(aleatorio < num)
            {
                this.txtnum.BackColor = Color.Red;
                lblTela.Text = "Mais baixo";
            }
            if (num>aleatorio-50 && num<aleatorio+50)
            {
                lblP.Text = "Está Perto";
            }

            lblTela.Visible = true;
            lblP.Visible = true;   
            lblten.Visible = true;
        }
    }
}