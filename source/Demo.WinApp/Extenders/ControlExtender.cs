using System;
using System.Windows.Forms;

namespace Demo.WinApp.Extenders
{
    public static class ControlExtender
    {
		public static void MyInvoke(this Control control, Action action) 
		{
			if (!control.InvokeRequired)
			{
				action();
			}
			else
			{
				control.Invoke(action);
			}
		}
	}
}