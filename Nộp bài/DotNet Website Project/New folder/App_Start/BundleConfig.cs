using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace DotNet_Website_Project
{
    public class BundleConfig
    {
        // For more information on Bundling, visit https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
      

            bundles.Add(new ScriptBundle("~/bundles/FrontendJS").Include(
                              "~/Scripts/Frontend/waypoints.min.js",
                               "~/Scripts/Frontend/chosen.jquery.min.js",
                                   "~/Scripts/Frontend/custom.js",
                                    "~/Scripts/Frontend/stacktable.js")); 

              
            //  bundles.Add(new ScriptBundle("~/bundles/scripts").IncludeDirectory("~/Scripts/", "*.js", true));
            bundles.Add(new ScriptBundle("~/bundles/JQuery").Include(
                          "~/Scripts/JQuery/jquery-2.1.3.min.js",
                          "~/Scripts/JQuery/jquery.superfish.js",
                          "~/Scripts/JQuery/jquery.themepunch.tools.min.js",
                          "~/Scripts/JQuery/jquery.themepunch.revolution.min.js",
                          "~/Scripts/JQuery/jquery.themepunch.showbizpro.min.js",
                          "~/Scripts/JQuery/jquery.flexslider-min.js",
                            "~/Scripts/JQuery/jquery.magnific-popup.min.js",
                          "~/Scripts/JQuery/jquery.counterup.min.js",
                          "~/Scripts/JQuery/jquery.jpanelmenu.js"));
                         
   

            bundles.Add(new ScriptBundle("~/bundles/WebFormsJs").Include(
                            "~/Scripts/WebForms/WebForms.js",
                            "~/Scripts/WebForms/WebUIValidation.js",
                            "~/Scripts/WebForms/MenuStandards.js",
                            "~/Scripts/WebForms/Focus.js",
                            "~/Scripts/WebForms/GridView.js",
                            "~/Scripts/WebForms/DetailsView.js",
                            "~/Scripts/WebForms/TreeView.js",
                            "~/Scripts/WebForms/WebParts.js"));

            // Order is very important for these files to work, they have explicit dependencies
            bundles.Add(new ScriptBundle("~/bundles/MsAjaxJs").Include(
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                    "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

            // Use the Development version of Modernizr to develop with and learn from. Then, when you’re
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                            "~/Scripts/modernizr-*"));
        }
    }
}