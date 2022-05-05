using System.Diagnostics;

namespace TenkUpgraderv2
{
	public partial class Form1 : Form
	{
		public static string TenkPath = string.Empty;
		public static List<TenkManager> managers = new List<TenkManager>();
		public static Form1? Instance;
		private Thread _managementThread;
		private string realPath = string.Empty;
		public Form1()
		{
			Instance = this;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (!File.Exists(tenkPathTxtBox.Text))
			{
				MessageBox.Show("Impossible de trouver Tenk !");
				return;
			}
			TenkPath = tenkPathTxtBox.Text;
			textBox1.Enabled = false;
			managers.Clear();
			tenkPathTxtBox.Enabled = false;
			button1.Enabled = false;
			progressBar.Value = 0;
			_managementThread = new Thread(ManagementThread);
			if (Directory.Exists(textBox1.Text))
			{
				realPath = textBox1.Text.Replace("/", "\\");
				realPath = textBox1.Text[textBox1.TextLength - 1] != '/' ? realPath + "/" : realPath;
				progressBar.Maximum = Directory.GetFiles(realPath).Length * 100;
				foreach (string file in Directory.GetFiles(realPath))
				{
					if(new FileInfo(file).Extension == ".d2p")
						managers.Add(new TenkManager(file));
				}
				_managementThread.Start();
			}
			else
				MessageBox.Show("Le repertoire indiqué n'existe pas !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			textBox1.Clear();
		}

		private void ManagementThread() {
			while (threadAlive())
				Thread.Sleep(1);
			Management(new FileInfo(TenkPath).Directory.FullName + @"\Extracted Content\", new FileInfo(TenkPath).Directory.FullName + @"\data");
			button1.Invoke(delegate { button1.Enabled = true; });
			tenkPathTxtBox.Invoke(delegate { tenkPathTxtBox.Enabled = true; });
			textBox1.Invoke(delegate { textBox1.Enabled = true; });
			progressBar.Invoke(delegate { progressBar.Value = 0; });
			Invoke(delegate { MessageBox.Show("L'extraction des fichiers est terminée", "Fin de l'extraction", MessageBoxButtons.OK, MessageBoxIcon.Information); });
			
		}
		private bool threadAlive()
		{
			foreach(TenkManager Manager in managers)
			{
				if(Manager.GetThread != null && Manager.GetThread.IsAlive)
					return true;
			}
			return false;
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (TenkManager TM in managers)
				TM.KillThreads();
			if (_managementThread != null && _managementThread.IsAlive)
				_managementThread.Interrupt();
		}

		private void Management(string unpacked, string dataPath)
		{
			if (Directory.Exists(dataPath))
			{
				if (Directory.Exists(unpacked + @"\" + new FileInfo(realPath).Directory.Name + @"\data\"))
					Directory.Delete(unpacked + @"\" + new FileInfo(realPath).Directory.Name + @"\data\", true);
				Directory.CreateDirectory(unpacked + @"\" + new FileInfo(realPath).Directory.Name);
				Directory.Move(dataPath, unpacked + @"\" + new FileInfo(realPath).Directory.Name + @"\data\");
			}
		}
	}
}