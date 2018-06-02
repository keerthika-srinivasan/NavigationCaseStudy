using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DisanceCalculator
{
    public class Navigator
    {
        private string _destination;
        private string _CurrentLocation;
        

        public void CurrentLocation(string CurrentLocation)
        {
            _CurrentLocation = CurrentLocation;            
        }
        public void SetDestination(string EndPoint)
        {
            _destination = EndPoint;           
        }

        public List<RouteDetails> GetRoute()
        {
            if(_destination!=null && _CurrentLocation!=null)
            {
                List<RouteDetails> routedetails = new List<RouteDetails>
                {
                         new    RouteDetails{SerialDetails="1",RouteAddress="chennai"},
                         new    RouteDetails{SerialDetails="2",RouteAddress="vellore"}
                };
                return routedetails;
            }
            return null;

        }

        public void ModifyRouteAvoid()
        {
                       
        }

        public void ModifyRouteToInclude()
        {

        }

        public int TotalDistance()
        {
            return 0;
        }






    }

    public class RouteDetails
    {
        public string SerialDetails { get; set; }
        public string RouteAddress { get; set; }
    }
}