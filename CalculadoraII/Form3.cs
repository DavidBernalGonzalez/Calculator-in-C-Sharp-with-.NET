using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraII
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            try{
                String rutaInicial = Directory.GetCurrentDirectory().ToString();
                //C:\Users\David\Desktop\MegaCursos\C# y .NET\Ejercicios\mios\CalculadoraII\CalculadoraII\bin\Debug
                System.Console.WriteLine(">>>" + rutaInicial);
                //C:\Users\David\Desktop\MegaCursos\C# y .NET\Ejercicios\mios\CalculadoraII\CalculadoraII\bin
                string parentIntermedio = System.IO.Directory.GetParent(rutaInicial).FullName;
                System.Console.WriteLine(">>>" + parentIntermedio);
                //C:\Users\David\Desktop\MegaCursos\C# y .NET\Ejercicios\mios\CalculadoraII\CalculadoraII
                string parentIntermedioII = System.IO.Directory.GetParent(parentIntermedio).FullName;
                System.Console.WriteLine(">>>" + parentIntermedioII);
                ////C:\Users\David\Desktop\MegaCursos\C# y .NET\Ejercicios\mios\CalculadoraII\CalculadoraII\img\yo.jpg
                string rutaFinal = Path.Combine(parentIntermedioII, "img", "yo2.jpg");
                System.Console.WriteLine(">>>" + rutaFinal);
                System.Console.WriteLine(rutaFinal);
                pictureBox1.Image = Image.FromFile(rutaFinal);
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
            catch(Exception e)
            {
                MessageBox.Show("No se encuentra la imagen en la ruta esperada.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String url = "https://www.linkedin.com/in/david-bernal-gonzalez-912020143/";
            System.Diagnostics.Process.Start(url);
        }
    }
}
