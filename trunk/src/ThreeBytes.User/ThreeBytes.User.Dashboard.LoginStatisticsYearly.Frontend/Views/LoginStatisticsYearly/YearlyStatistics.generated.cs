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

namespace ThreeBytes.User.Dashboard.LoginStatisticsYearly.Frontend.Views.LoginStatisticsYearly
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
    using ThreeBytes.User.Dashboard.LoginStatisticsYearly.Frontend.Models;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/LoginStatisticsYearly/YearlyStatistics.cshtml")]
    public class YearlyStatistics : System.Web.Mvc.WebViewPage<LoginStatisticsViewModel>
    {
        public YearlyStatistics()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n<div id=\"yearly-login-statistics-container\">\r\n    <div><span class=\"inline-spar" +
"kline\"></span><span>");


            
            #line 4 "..\..\Views\LoginStatisticsYearly\YearlyStatistics.cshtml"
                                                Write(Model.CurrentStatistic);

            
            #line default
            #line hidden
WriteLiteral(" Unique <span data-bind=\"text: plural\"></span> This Year</span></div>\r\n</div>\r\n\r\n" +
"");


            
            #line 7 "..\..\Views\LoginStatisticsYearly\YearlyStatistics.cshtml"
   
  using (Html.BeginScriptContext())
  {
    Html.AddScriptBlock(@"
        var yearly_login_statistics  = {};
    
        (function (index) {
        
            yearly_login_statistics = index = ko.mapping.fromJS(" + @Html.Raw(new JavaScriptSerializer().Serialize(Model)) + @");

            index.plural = ko.dependentObservable(function () {
                return index.CurrentStatistic() == 1 ? 'Login' : 'Logins';
            }, index);

            jQuery(function() {
                ko.applyBindings(index, jQuery('#yearly-login-statistics-container')[0]);
                jQuery('#yearly-login-statistics-container .inline-sparkline').sparkline(index.HistoricStatistics(), {type:'line', lineColor:'black', fillColor:'orange', height:'30px', width:'80px'});
            });     

        } (yearly_login_statistics));");
  }

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
