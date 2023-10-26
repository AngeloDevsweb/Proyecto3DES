using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.mp3;|Todos los archivos|*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = openFileDialog1.FileName;
                // Aquí puedes utilizar 'archivoSeleccionado' como el archivo seleccionado por el usuario.
                textBox1.Text = archivoSeleccionado;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TripleDES tDES = new TripleDES(textBox2.Text);
                tDES.EncryptFile(textBox1.Text);
                GC.Collect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TripleDES tDES = new TripleDES(textBox2.Text);
                tDES.DecryptFile(textBox1.Text);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
