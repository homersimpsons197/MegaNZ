using CG.Web.MegaApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meganz.Controller
{    
    public class MeganzApi
    {
        Form1 f;

        MegaApiClient client;

        public MeganzApi(Form1 f)
        {
            this.f = f;
        }
        
        public void Connection()
        {
            client = new MegaApiClient();
            client.Login("meganz13@proton.me", "M@rino13");
            if (client.IsLoggedIn)
            {
                f.lblStatus.Text = "CONNECTED";
                f.lblStatus.ForeColor = Color.Green;
                f.btnConnect.Enabled = false;
                f.btnDisconnect.Enabled = true;
                f.gboxDloadPath.Enabled = true;
                f.lblFolderName.Text = GetFolderName();
            }            
        }

        public void Disconnect()
        {
            client.Logout();
            f.lblStatus.Text = "DISCONNECTED";
            f.lblStatus.ForeColor = Color.Red;
            f.btnDisconnect.Enabled = false;
            f.btnConnect.Enabled = false;
            f.gboxDloadPath.Enabled= false;
            f.gboxDloadProgress.Enabled= false;
        }

        public string GetFolderName()
        {
            Uri folderLink = new Uri("https://mega.nz/folder/FfQ2RJrY#MdKcTTZ5NOdZxiil3URmIw");
            IEnumerable<INode> nodes = client.GetNodesFromLink(folderLink);
            List<INode> parent = nodes.Where(n => n.Type == NodeType.Root).ToList();
            string folderName = parent[0].Name;
            return folderName;
        }

        public string DownloadPath()
        {
            string path = f.txtPath.Text + "\\" + GetFolderName();
            return path;
        }

        public async void DownloadFiles()
        {
            Directory.CreateDirectory(DownloadPath());
            Uri folderLink = new Uri("https://mega.nz/folder/FfQ2RJrY#MdKcTTZ5NOdZxiil3URmIw");
            IEnumerable<INode> nodes = client.GetNodesFromLink(folderLink);
            int totalNodes = (nodes.Count()-1);
            foreach (INode node in nodes.Where(x => x.Type == NodeType.File))
            {
                IProgress<double> progressHandler = new Progress<double>(x => f.progressBar.Value = (int)x);                       
                f.lblFilename.Text = node.Name;               
                await client.DownloadFileAsync(node, DownloadPath() + "\\" + node.Name, progressHandler);
                totalNodes--;
            }
            if (totalNodes == 0)
            {
                f.lblFilename.Text = "Download finished!";
                f.lblFilename.ForeColor = Color.Green;
                f.progressBar.Value = 0;
            }
            else if(totalNodes != 0)
            {
                f.lblFilename.Text = "Download failed!";
                f.lblFilename.ForeColor = Color.Red;
                f.progressBar.Value = 0;
            }
        }
    }
}
