using CG.Web.MegaApiClient;
using meganz.Controller;

namespace meganz
{
    public partial class Form1 : Form
    {
        MeganzApi api;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            api = new MeganzApi(this);
            btnDisconnect.Enabled = false;
            gboxDloadPath.Enabled = false;
            gboxDloadProgress.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            api.Connection();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            api.Disconnect();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;

            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
                Environment.SpecialFolder root = fbd.RootFolder;
                gboxDloadProgress.Enabled = true;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            api.DownloadFiles();
        }
    }
}