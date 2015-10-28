using Microsoft.VisualBasic;

namespace PauseTestModule
{
	public class clsTest : Quasi97.clsSimpleTest 
	{
		
		public static string SharedTestID = "Pause";
		private string _Message = "Click OK when ready to continue";
public string Message
		{
			get
			{
				return _Message;
			}
			set
			{
				_Message = value;
			}
		}
		private string myTableName = "PauseTestModule_Settings";
			
		public override void RunTest()
		{
			if (modMain.QST.QSTHardware.DualChanMode)
			{
				return ;
			}
			if (Interaction.MsgBox(Message, Constants.vbOKCancel, SharedTestID) == MsgBoxResult.Cancel)
			{
				modMain.QST.QuasiParameters.AbortTest = true;
			}
		}
		
        public override string TestID
		{
			get
			{
				return SharedTestID;
			}
		}

        public override string MyTable
        {
            get
            {
                return myTableName;
            }
        }

        public clsTest()
		{
			colParameters.Add(new Quasi97.clsTestParam(this,"Message", "Message", Message.GetType(), false, null));
		}
	}
	
}
