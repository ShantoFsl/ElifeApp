using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InVenManagmentApp.Models
{
    public class InventoryModel
    {
    }

       public class EquipmentList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NumberofEquipment { get; set; }
        public string EnableYN {  get; set; }
        public string Remarks { get; set; }
    }
   
    }