using System.Web.Mvc;

namespace MyMvc.Areas.area
{
    public class areaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "area";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "area_default",
                "area/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}