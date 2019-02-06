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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            try
            {
                String rutaInicial = Directory.GetCurrentDirectory().ToString();
                //C:\Users\David\Desktop\MegaCursos\C# y .NET\Ejercicios\mios\CalculadoraII\CalculadoraII\bin\Debug
                System.Console.WriteLine(">>>" + rutaInicial);
                //C:\Users\David\Desktop\MegaCursos\C# y .NET\Ejercicios\mios\CalculadoraII\CalculadoraII\bin
                string parentIntermedio = System.IO.Directory.GetParent(rutaInicial).FullName;
                System.Console.WriteLine(">>>" + parentIntermedio);
                //C:\Users\David\Desktop\MegaCursos\C# y .NET\Ejercicios\mios\CalculadoraII\CalculadoraII
                string parentIntermedioII = System.IO.Directory.GetParent(parentIntermedio).FullName;
                System.Console.WriteLine(">>>" + parentIntermedioII);
                ////C:\Users\David\Desktop\MegaCursos\C# y .NET\Ejercicios\mios\CalculadoraII\CalculadoraII\img\manual.jpg
                string rutaFinal = Path.Combine(parentIntermedioII, "img", "manual.jpg");
                System.Console.WriteLine(">>>" + rutaFinal);
                System.Console.WriteLine(rutaFinal);
                pictureBox1.Image = Image.FromFile(rutaFinal);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se encuentra la imagen en la ruta esperada.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*  
                S --> Cambiar símbolo
                C --> Limpiar pantalla
                Retroceso (Backspace) --> Eliminar un digito
                0,1,2,3,4,5,6,7,8,9 --> Introduce los digitos en la pantalla
                + --> Realiza una suma
                - --> Realiza una resta
                * --> Realiza una multiplicación"
                / --> Realiza una división
            */
        }
    }
}
