﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeBytes.Email.Dashboard.DispatchMonthly.Frontend.Views.DispatchMonthly
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    
    #line 1 "..\..\Views\DispatchMonthly\MonthlyStatistics.cshtml"
    using System.Web.Script.Serialization;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using ThreeBytes.Core.Extensions.Mvc;
    
    #line 2 "..\..\Views\DispatchMonthly\MonthlyStatistics.cshtml"
    using ThreeBytes.Email.Dashboard.DispatchMonthly.Frontend.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DispatchMonthly/MonthlyStatistics.cshtml")]
    public class MonthlyStatistics : System.Web.Mvc.WebViewPage<DispatchStatisticsViewModel>
    {
        public MonthlyStatistics()
        {
        }
        public override void Execute()
        {



WriteLiteral("\r\n<div id=\"monthly-email-dispatch-statistics-container\">\r\n    <div><span class=\"i" +
"nline-sparkline\"></span><span>");


            
            #line 6 "..\..\Views\DispatchMonthly\MonthlyStatistics.cshtml"
                                                Write(Model.CurrentStatistic);

            
            #line default
            #line hidden
WriteLiteral(" Dispatched Emails This Month</span></div>\r\n</div>\r\n\r\n");


            
            #line 9 "..\..\Views\DispatchMonthly\MonthlyStatistics.cshtml"
   
  using (Html.BeginScriptContext())
  {
    Html.AddScriptBlock(@"
        var monthly_email_dispatch_statistics  = {};
    
        (function (index) {
        
            monthly_email_dispatch_statistics = index = ko.mapping.fromJS(" + @Html.Raw(new JavaScriptSerializer().Serialize(Model)) + @");

            jQuery(function() {
                ko.applyBindings(index, jQuery('#monthly-email-dispatch-statistics-container')[0]);
                jQuery('#monthly-email-dispatch-statistics-container .inline-sparkline').sparkline(index.HistoricStatistics(), {type:'line', lineColor:'blue', height:'30px', width:'80px'});
            });     

        } (monthly_email_dispatch_statistics));");
  }

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591