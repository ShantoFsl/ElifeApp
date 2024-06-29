using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InVenManagmentApp.Models
{
    public class MemberList
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string DesigNation { get; set; }
            public string Mobile { get; set; }
            public string Department { get; set; }
            public string Remarks { get; set; }
            public string Assigned { get; set; }

    }

    public class DepartmentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EnableYN { get; set; }
        public string Remarks { get; set; }
    }

    
}