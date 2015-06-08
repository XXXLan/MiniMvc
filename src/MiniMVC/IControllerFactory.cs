using System;

namespace MiniMVC
{
	public interface IControllerFactory
	{
		IController CreateController(RequestContext requestContext,string controllerName);
	}
}

