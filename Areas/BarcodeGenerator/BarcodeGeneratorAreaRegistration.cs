using System.Web.Mvc;

namespace barcode_generator.Areas.BarcodeGenerator
{
    public class BarcodeGeneratorAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BarcodeGenerator";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BarcodeGenerator_default",
                "BarcodeGenerator/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}