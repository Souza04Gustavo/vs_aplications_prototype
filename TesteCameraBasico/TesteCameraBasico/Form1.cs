using AForge.Video;
using AForge.Video.DirectShow;

namespace TesteCameraBasico
{
    public partial class Form1 : Form
    {
        FilterInfoCollection _filterInfoCollection;
        VideoCaptureDevice _videoCaptureDevice;

        public Form1()
        {
            InitializeComponent();

            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in _filterInfoCollection)
                cmbCameras.Items.Add(filterInfo.Name);

            cmbCameras.SelectedIndex = 0;
            _videoCaptureDevice = new VideoCaptureDevice();

            this.FormClosing += Form1_FormClosing; // Garante que a câmera será fechada ao sair

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoCaptureDevice != null && _videoCaptureDevice.IsRunning)
            {
                _videoCaptureDevice.SignalToStop();
                _videoCaptureDevice.WaitForStop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[cmbCameras.SelectedIndex].MonikerString);

            _videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();
        }


        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            pictCamImagem.Image = (Bitmap)e.Frame.Clone();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_videoCaptureDevice != null && _videoCaptureDevice.IsRunning)
            {
                _videoCaptureDevice.SignalToStop();
                _videoCaptureDevice.WaitForStop();
                _videoCaptureDevice = null; // Libera o objeto da câmera
            }

            if (pictCamImagem.Image != null)
            {
                pictCamImagem.Image.Dispose();
                pictCamImagem.Image = null; // Remove a última imagem exibida
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarImagem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetImage(pictCamImagem.Image);
            pictImagemRecortada.Image = Clipboard.GetImage();
            Clipboard.Clear();

            pictImagemRecortada.Image.Save(@"C:\Users\lostv\OneDrive\Área de Trabalho\estagio\imagem.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void pictImagemRecortada_Click(object sender, EventArgs e)
        {

        }

        private void pictCamImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
