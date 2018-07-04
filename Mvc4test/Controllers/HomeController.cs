using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4test.Controllers
{
    public class HomeController : Controller//每个控制器必须继承的基类，命名以Controller结尾
    {
        //
        // GET: /Home/
        //控制器的动作方法，用于响应客户端请求，并调用响应的视图向浏览器输出信息
        public ActionResult Index()
        {
            //【1】获取数据：接收请求数据
            //【2】业务处理：和Models交互
            //【3】返回视图或跳转到其他控制器
            return View();//该方法默认调用Index视图（与Index()方法同名的视图）
        }

    }
}
