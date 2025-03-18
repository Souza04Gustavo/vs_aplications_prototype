using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientePCFixo
{
    public partial class Form1 : Form
    {
        private readonly string serverUrl = "http://127.0.0.1:5000"; // URL do servidor Flask
        private readonly HttpClient client = new HttpClient();
        private string lastImage = "";
        private string lastGcode = "";
        private readonly string downloadsFolder;

        public Form1()
        {
            InitializeComponent();

            // Define o diretório de downloads na pasta Documentos
            downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MeuAppDownloads");

            // Garante que o diretório de downloads existe
            if (!Directory.Exists(downloadsFolder))
            {
                Directory.CreateDirectory(downloadsFolder);
            }
        }

        // Esse método será chamado quando o botão for clicado
        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            await AtualizarDadosServidor();
        }

        private async Task AtualizarDadosServidor()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{serverUrl}/");
                if (!response.IsSuccessStatusCode) return;

                string htmlContent = await response.Content.ReadAsStringAsync();

                // Usa o primeiro <p> para a imagem e o segundo para o G-Code
                string newImage = ExtrairValor(htmlContent, "<p>", "</p>", 1);
                string newGcode = ExtrairValor(htmlContent, "<p>", "</p>", 2);
                string ledStatus = ExtrairValor(htmlContent, "<span id=\"led-status\">", "</span>");

                lblLedStatus.Text = $"LED: {ledStatus}";
                lblLedStatus.ForeColor = ledStatus.Contains("Ligado") ? System.Drawing.Color.Green : System.Drawing.Color.Red;

                // Baixa a imagem se for nova e se o valor não for uma mensagem padrão
                if (!string.IsNullOrEmpty(newImage) && newImage != "Nenhuma imagem recebida" && newImage != lastImage)
                {
                    string imagePath = Path.Combine(downloadsFolder, newImage);
                    await BaixarArquivo($"/uploads/{newImage}", imagePath);
                    pictureBox1.ImageLocation = imagePath;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    lastImage = newImage;
                }

                // Baixa o G-Code se for novo e se o valor não for uma mensagem padrão
                if (!string.IsNullOrEmpty(newGcode) && newGcode != "Nenhum G-Code recebido" && newGcode != lastGcode)
                {
                    string gcodePath = Path.Combine(downloadsFolder, newGcode);
                    await BaixarArquivo($"/uploads/{newGcode}", gcodePath);
                    lblGcodeStatus.Text = $"Último G-Code: {newGcode}";
                    lastGcode = newGcode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar com o servidor: {ex.Message}");
            }
        }

        private async Task BaixarArquivo(string fileUrl, string savePath)
        {
            try
            {
                string encodedUrl = $"{serverUrl}{Uri.EscapeUriString(fileUrl)}";
                HttpResponseMessage response = await client.GetAsync(encodedUrl);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Erro ao baixar arquivo: {response.StatusCode}");
                    return;
                }

                byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                // Use a versão síncrona se WriteAllBytesAsync não estiver disponível
                File.WriteAllBytes(savePath, fileBytes);
                MessageBox.Show($"Arquivo salvo em: {savePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao baixar arquivo: {ex.Message}");
            }
        }

        private string ExtrairValor(string html, string inicio, string fim, int ocorrencia = 1)
        {
            int start = 0;
            for (int i = 0; i < ocorrencia; i++)
            {
                start = html.IndexOf(inicio, start) + inicio.Length;
                if (start < inicio.Length) return "";
            }
            int end = html.IndexOf(fim, start);
            return html.Substring(start, end - start);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
