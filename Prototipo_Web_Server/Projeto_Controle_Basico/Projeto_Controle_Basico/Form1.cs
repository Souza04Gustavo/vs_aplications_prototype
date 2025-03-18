using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;

namespace Projeto_Controle_Basico
{
    public partial class Form1 : Form
    {
        private string imagemPath = "";
        private string gcodePath = "";
        private string serverUrl = "http://127.0.0.1:5000"; // URL do servidor Flask
        private readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void BtnGcode_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "G-Code|*.gcode;*.nc";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gcodePath = openFileDialog.FileName;
                    lblGcode.Text = Path.GetFileName(gcodePath);
                }
            }
        }

        private void BtnImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagemPath = openFileDialog.FileName;
                    lblImagem.Text = Path.GetFileName(imagemPath);
                    ExibirImagem(imagemPath);
                }
            }
        }

        private void ExibirImagem(string caminho)
        {
            if (File.Exists(caminho))
            {
                using (Image img = Image.FromFile(caminho))
                {
                    pictureBoxImagem.Image = new Bitmap(img);
                    pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }

        private async void BtnLed_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.PostAsync(serverUrl + "/toggle-led", null);
            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                lblStatusLed.Text = result.Contains("Ligado") ? "Ligado" : "Desligado";
            }
        }

        private async void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (File.Exists(imagemPath))
            {
                await EnviarArquivo(imagemPath, "/upload-image");
            }
            if (File.Exists(gcodePath))
            {
                await EnviarArquivo(gcodePath, "/upload-gcode");
            }
            MessageBox.Show("Arquivos enviados com sucesso!");
        }

        private async Task EnviarArquivo(string filePath, string endpoint)
        {
            using (var form = new MultipartFormDataContent())
            {
                var fileContent = new ByteArrayContent(File.ReadAllBytes(filePath));
                form.Add(fileContent, "file", Path.GetFileName(filePath));
                await client.PostAsync(serverUrl + endpoint, form);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
