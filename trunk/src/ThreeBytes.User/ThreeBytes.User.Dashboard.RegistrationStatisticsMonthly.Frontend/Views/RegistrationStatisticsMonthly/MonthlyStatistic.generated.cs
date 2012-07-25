﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThreeBytes.User.Dashboard.RegistrationStatisticsMonthly.Frontend.Views.RegistrationStatisticsMonthly
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
    using System.Web.Script.Serialization;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using ThreeBytes.Core.Extensions.Mvc;
    using ThreeBytes.User.Dashboard.RegistrationStatisticsMonthly.Frontend.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/RegistrationStatisticsMonthly/MonthlyStatistic.cshtml")]
    public class MonthlyStatistic : System.Web.Mvc.WebViewPage<RegistrationStatisticViewModel>
    {
        public MonthlyStatistic()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n<div id=\"monthly-registration-statistic-container\" class=\"stat\">\t\t\t\t\t\t\t\t\r\n    <" +
"h4>Unique <span data-bind=\"text: plural\"></span> This Month</h4>\r\n    <span clas" +
"s=\"value\">");


            
            #line 5 "..\..\Views\RegistrationStatisticsMonthly\MonthlyStatistic.cshtml"
                   Write(Model.CurrentStatistic);

            
            #line default
            #line hidden
WriteLiteral("</span>\t\t\t\t\t\t\t\t\r\n</div>\r\n\r\n");


            
            #line 8 "..\..\Views\RegistrationStatisticsMonthly\MonthlyStatistic.cshtml"
   
  using (Html.BeginScriptContext())
  {
    Html.AddScriptBlock(@"
        var monthly_registration_statistic  = {};
    
        (function (index) {
        
            monthly_registration_statistic = index = ko.mapping.fromJS(" + @Html.Raw(new JavaScriptSerializer().Serialize(Model)) + @");

            index.plural = ko.dependentObservable(function () {
                return index.CurrentStatistic() == 1 ? 'Registration' : 'Registrations';
            }, index);

            jQuery(function() {
                ko.applyBindings(index, jQuery('#monthly-registration-statistic-container')[0]);
            });     

        } (monthly_registration_statistic));");
  }

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591