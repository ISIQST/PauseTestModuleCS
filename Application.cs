using System;

namespace PauseTestModule
{
	public class Application : IDisposable
	{
		public Application()
		{
			ModuleID = assyName;
            ModuleDescr = "pause test module";
        }
		
		private string assyName = "PauseTestModule";
		public string ModuleDescr { get; set; }
		public string ModuleID {get; set;}
		public string Manufacturer = "Integral Solutions Int\'l";
		public string AppDataPath = "";
		
		private void GetAppDataPath()
		{
			string strAppData = "";
			strAppData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData); //GetSpecialFolderA(mceIDLPaths.CSIDL_COMMON_APPDATA)
			strAppData = strAppData + "\\" + Manufacturer;
			AppDataPath = strAppData + "\\Quasi97";
		}
		
		public void Initialize2(object q)
		{
			modMain.QST = (Quasi97.Application) q;
			GetAppDataPath();
			//add tables needed for pause test module
			modMain.QST.QuasiParameters.RegisterTestClassNET(clsTest.SharedTestID, assyName, assyName + ".clsTest", global::My.Resources.Resources.Hourglass, "Quasi97.ucGenericNoGraph");
			
		}
		
public bool CustomStressSupport
		{
			get
			{
				return false;
			}
		}
		
		public void Dispose()
		{
			if (!(modMain.QST == null))
			{
				modMain.QST.QuasiParameters.UnregisterTestClass(ref clsTest.SharedTestID);
			}
			
			modMain.QST = null;
		}
		
public bool QuasiAddIn
		{
			get
			{
				return true;
			}
		}
		
		
	}
	
}
