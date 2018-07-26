using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
using System.Reflection;

namespace WebApplication1.Controllers
{
    public class MemberSearchController : Controller
    {
        // GET: MemberSearch
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MemberSearch(string strName, string strContactID,string strMobile,string strPhone, string strEMail)
        {
            try
            {
                logger.Info("進入首頁，接到參數strName={0}, strContactID = {1},  strMobile = {2}, strPhone = {3}, strEMail  = {4}",
                    strName, strContactID, strMobile, strPhone, strEMail);
            }
            catch(Exception e)
            {
                logger.Error("{0 {1}", MethodInfo.GetCurrentMethod().Name, e.Message);
                throw e;
            }
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }
            return View();
        }
    }
}