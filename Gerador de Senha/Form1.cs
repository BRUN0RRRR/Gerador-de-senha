namespace Gerador_de_Senha
{
    public partial class Form1 : Form
    {
        private string GerarSenha(int comprimento, bool incluirMaiusculas, bool incluirMinusculas, bool incluirNumeros, bool incluirEspeciais)
        {
            string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            string numeros = "0123456789";
            string caracteresEspeciais = "!@#$%^&*()";

            string caracteresDisponiveis = "";

            if (incluirMaiusculas)
                caracteresDisponiveis += letrasMaiusculas;
            if (incluirMinusculas)
                caracteresDisponiveis += letrasMinusculas;
            if (incluirNumeros)
                caracteresDisponiveis += numeros;
            if (incluirEspeciais)
                caracteresDisponiveis += caracteresEspeciais;

            if (string.IsNullOrEmpty(caracteresDisponiveis))
                return "Selecione ao menos um tipo de caractere";

            Random rand = new Random();
            char[] senha = new char[comprimento];
            for (int i = 0; i < comprimento; i++)
            {
                senha[i] = caracteresDisponiveis[rand.Next(caracteresDisponiveis.Length)];
            }

            return new string(senha);
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            int comprimento;
            if (int.TryParse(txtsenha.Text, out comprimento) && comprimento > 0)
            {
                string senhaGerada = GerarSenha(comprimento, chkMaiusculas.Checked, chkMinusculas.Checked, chkNumeros.Checked, chkEspeciais.Checked);
                txtsenha.Text = senhaGerada;
            }
            else
            {
                MessageBox.Show("Por favor, insira um comprimento válido.");
            }
        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsenha.Text))
            {
                Clipboard.SetText(txtsenha.Text);
                MessageBox.Show("Senha copiada para a área de transferência!");
            }
        }
    }
}
