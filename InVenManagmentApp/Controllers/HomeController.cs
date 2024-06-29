using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InVenManagmentApp.Models;


namespace InVenManagmentApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Dashboard() 
        {
            List<MemberList>lstMemberlist= new List<MemberList>();

            MemberList MemberList = new MemberList();
            MemberList.Name = "Sushanto Kumar Halder";
            MemberList.DesigNation = "Officer";
            MemberList.Mobile = "01929997356";
            MemberList.Department = "IT";
            MemberList.Remarks = "Test";
            MemberList.Assigned = "Chair";
            lstMemberlist.Add(MemberList);

            MemberList = new MemberList();
            MemberList.Name = "Md. Zakir Hossain";
            MemberList.DesigNation = "Sr.Officer";
            MemberList.Mobile = "01929997350";
            MemberList.Department = "Hardware";
            MemberList.Remarks = "Test";
            MemberList.Assigned = "Computer Table";
            lstMemberlist.Add(MemberList);

            MemberList = new MemberList();
            MemberList.Name = "Md. Hafizul Islam Hafiz";
            MemberList.DesigNation = "Jr.Officer";
            MemberList.Mobile = "01929997353";
            MemberList.Department = "IT";
            MemberList.Remarks = "Test";
            MemberList.Assigned = "Computer Table";
            lstMemberlist.Add(MemberList);

            ViewBag.MemberList = lstMemberlist;

            List<EquipmentList> lstEquipmentList = new List<EquipmentList>();

            EquipmentList EquipmentList = new EquipmentList();
            EquipmentList.Id = 1;
            EquipmentList.Name = "Chair";
            EquipmentList.NumberofEquipment = "10";
            lstEquipmentList.Add(EquipmentList);

            EquipmentList = new EquipmentList();
            EquipmentList.Id = 2;
            EquipmentList.Name = "Table";
            EquipmentList.NumberofEquipment = "50";
            lstEquipmentList.Add(EquipmentList);

            EquipmentList = new EquipmentList();
            EquipmentList.Id = 3;
            EquipmentList.Name = "Computer Chair";
            EquipmentList.NumberofEquipment = "20";
            lstEquipmentList.Add(EquipmentList);

            ViewBag.EquipmentList = lstEquipmentList;

            return View();
        }
    }
}