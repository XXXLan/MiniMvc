using MiniMVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniMvcUse.Controller
{
    public class UserController:ControllerBase
    {
        public RawContentResult Login(MiniMvcUse.Model.SimpleModel model)
        {
            string content = string.Format("UserName:{0}</br>PWD:{1}", model.UserName, model.PassWord);
            return new RawContentResult(content);
        }
    }
}