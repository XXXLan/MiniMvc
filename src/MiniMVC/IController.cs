using System;

namespace MiniMVC
{
	public interface IController
	{
		void Execute(RequestContext requestContext);
	}
}

