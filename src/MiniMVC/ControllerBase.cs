using System;

namespace MiniMVC
{
	public abstract class ControllerBase:IController
	{
		protected IActionInvoker AcitonInvoker{ get; set;}

		public ControllerBase ()
		{
			this.AcitonInvoker = new ControllerActionInvoker();
		}

		public void Execute(RequestContext requestContext)
		{
			ControllerContext context = new ControllerContext ()
			{
				ReuqestContext=requestContext,
				Controller=this
			};
			string actionName = requestContext.RouteData.ActionName;
			this.AcitonInvoker.InvokeAction (context, actionName);
		}
	}
}

