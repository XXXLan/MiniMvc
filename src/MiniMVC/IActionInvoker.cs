using System;

namespace MiniMVC
{
	public interface IActionInvoker
	{
		void InvokeAction(ControllerContext controllerContext,string actionName);
	}
}

