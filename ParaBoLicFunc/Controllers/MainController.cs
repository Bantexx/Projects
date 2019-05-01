using ParaBoLicFunc.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Mvc;

namespace ParaBoLicFunc.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Check(UserData ud)
        {
            CheckParabola(ud);
            return View("Index");
        }
        private void CheckParabola(UserData ud)
        {
            if (CheckData(ud))
            {
                int _chartid;
                using (MdaBdContext db = new MdaBdContext())
                {
                    db.UserDatas.Add(ud);
                    db.SaveChanges();
                    var userdata = db.UserDatas.Max(x => x.Id_UD);
                    _chartid = userdata;
                }

                List<Point> ds = new List<Point>();
                Point pt = new Point();
                for (float i = ud.RangeFrom; i <= ud.RangeTo; i += ud.Step)
                {
                    pt = new Point
                    {
                        x = i,
                        y = (ud.A * (i * i) + ud.B * i + ud.C),
                        ChartId= _chartid
                    };

                    ds.Add(pt);
                }
                AddToDb(ds, ud);
                pt.Serializer(ds);
            }
        }
        private bool CheckData(UserData ud)
        {
            if (ud.Step > 0)
            {
                return true;
            }
            return false;
        }
        private void AddToDb(List<Point> listofPoints,UserData userData)
        {
            using(MdaBdContext db = new MdaBdContext())
            {
                foreach(Point point in listofPoints)
                {
                    db.Points.Add(point);
                }
                db.SaveChanges();
            }
        }
    }
}