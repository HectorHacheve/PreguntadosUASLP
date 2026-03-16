namespace PreguntadosUASLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cultura_pop_Paint(object sender, PaintEventArgs e)
        {
            PictureBox botonActual = (PictureBox)sender;


            string textoBoton = "";
            if (botonActual.Tag != null)
            {
                textoBoton = botonActual.Tag.ToString();
            }


            Font miFuente = new Font("Arial", 14, FontStyle.Bold);
            StringFormat formatoCentrado = new StringFormat();
            formatoCentrado.Alignment = StringAlignment.Center;
            formatoCentrado.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(textoBoton, miFuente, Brushes.White, botonActual.ClientRectangle, formatoCentrado);
        }

        private void Futbol_Click(object sender, EventArgs e)
        {
            FormFutbol ventanaJuego = new FormFutbol();
            ventanaJuego.ShowDialog();

        }
    }
}
