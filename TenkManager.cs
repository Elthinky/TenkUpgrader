using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenkUpgraderv2
{
	public class TenkManager
	{
		private string _path;
		private Thread _thread;
		private Process _tenkProcess;
		public TenkManager(string Path)
		{
			_thread = new Thread(GlobalThread);
			_thread.Start();
			_path = Path;
		}
		private void GlobalThread()
		{
			_tenkProcess = new Process();
			ProcessStartInfo tenkInfo = new ProcessStartInfo();
			tenkInfo.FileName = Form1.TenkPath;
			_tenkProcess.StartInfo = tenkInfo;
			_tenkProcess.Start();
			while (_tenkProcess.MainWindowHandle == IntPtr.Zero)
				Thread.Sleep(1);

			WinAPI.ShowWindow(_tenkProcess.MainWindowHandle, WinAPI.ShowWindowMode.SW_MINIMIZE);
			List<IntPtr> Composants = WinAPI.GetAllComponnents(WinAPI.GetWindow(_tenkProcess.MainWindowHandle, WinAPI.GetWindowType.GW_CHILD));

			IntPtr Label = Composants[0];
			IntPtr TextBox = Composants[4];
			IntPtr SubmitButton = Composants[5];

			WinAPI.SendMessage(TextBox, WinAPI.WM_SETTEXT, 0, _path);
			WinAPI.SendKey(SubmitButton, Keys.Enter);

			while(!isDone(Label))
				Thread.Sleep(10);
			_tenkProcess.Kill();
			Form1.Instance.progressBar.Invoke(delegate { Form1.Instance.progressBar.Value += 100; });
		}
		public string Path => _path;
		public Thread GetThread => _thread;
		public void KillThreads()
		{
			if(_thread != null && _thread.IsAlive)
				_thread.Interrupt();
			if (_tenkProcess != null && _tenkProcess.Responding)
				_tenkProcess.Kill();
		}

		private bool isDone(IntPtr LabelHandle)
		{
			Int32 titleSize = WinAPI.SendMessage(LabelHandle, WinAPI.WM_GETTEXTLENGTH, 0, 0).ToInt32();
			if (titleSize == 0)
				return false;
			StringBuilder title = new StringBuilder(titleSize + 1);
			WinAPI.SendMessage(LabelHandle, WinAPI.WM_GETTEXT, title.Capacity, title);
			return title.ToString().ToLower().Contains("terminé") ? true : false;
		}
	}
}
