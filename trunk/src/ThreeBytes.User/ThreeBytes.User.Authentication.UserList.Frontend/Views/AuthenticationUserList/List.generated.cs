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

namespace ThreeBytes.User.Authentication.UserList.Frontend.Views.AuthenticationUserList
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
    using ThreeBytes.User.Authentication.UserList.Frontend.Models;
    using ThreeBytes.User.Authentication.UserList.Resources;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AuthenticationUserList/List.cshtml")]
    public class List : System.Web.Mvc.WebViewPage<PagedUserListUserViewModel>
    {
        public List()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n");


            
            #line 3 "..\..\Views\AuthenticationUserList\List.cshtml"
  
    ViewBag.Title = Resources.BrowserTitle;


            
            #line default
            #line hidden
WriteLiteral(@"
<div id=""latest-users-container"">
    <div data-bind=""latestItems: latestViewModel""></div>
</div>
<div id=""paged-users-container"">
    <div data-bind=""pagedGrid: pagedViewModel, pagedGridTemplate: 'paged-users-table-tmpl'""></div>
</div>

<script type=""text/x-jquery-tmpl"" id=""paged-users-table-tmpl"">
    <div class=""widget widget-table"">
    <div class=""widget-header"">
        <i class=""icon-user""></i>
        <h3>System Users</h3>
        <div class=""pull-right-menu"">
            <em>");


            
            #line 20 "..\..\Views\AuthenticationUserList\List.cshtml"
           Write(Resources.There);

            
            #line default
            #line hidden
WriteLiteral(@"&nbsp;<span data-bind=""text: is_are""></span>&nbsp;<span data-bind=""text: totalItemCount""></span>&nbsp;<span data-bind=""text: plural""></span></em>
        </div>
    </div>
    <div class=""widget-content"">
        <table id=""paged-users-table"" class=""table table-striped table-bordered table-condensed"">
            <thead>
                <tr>
                    <th class=""header yellow"" data-bind=""click: setOrderBy.bind($data, 'Username'), css: { headerSortDown: orderBy() == 'Username' && isAsc(), headerSortUp: orderBy() == 'Username' && !isAsc() }"">
                        ");


            
            #line 28 "..\..\Views\AuthenticationUserList\List.cshtml"
                   Write(Resources.Username);

            
            #line default
            #line hidden
WriteLiteral(@"
                    </th>
                    <th class=""header green"" data-bind=""click: setOrderBy.bind($data, 'Email'), css: { headerSortDown: orderBy() == 'Email' && isAsc(), headerSortUp: orderBy() == 'Email' && !isAsc() }"">
                        ");


            
            #line 31 "..\..\Views\AuthenticationUserList\List.cshtml"
                   Write(Resources.Email);

            
            #line default
            #line hidden
WriteLiteral(@"
                    </th>
                    <th class=""header red"" data-bind=""click: setOrderBy.bind($data, 'IsVerified'), css: { headerSortDown: orderBy() == 'IsVerified' && isAsc(), headerSortUp: orderBy() == 'IsVerified' && !isAsc() }"">
                        ");


            
            #line 34 "..\..\Views\AuthenticationUserList\List.cshtml"
                   Write(Resources.IsVerified);

            
            #line default
            #line hidden
WriteLiteral(@"
                    </th>
                    <th class=""header orange"" data-bind=""click: setOrderBy.bind($data, 'IsLockedOut'), css: { headerSortDown: orderBy() == 'IsLockedOut' && isAsc(), headerSortUp: orderBy() == 'IsLockedOut' && !isAsc() }"">
                        ");


            
            #line 37 "..\..\Views\AuthenticationUserList\List.cshtml"
                   Write(Resources.IsLockedOut);

            
            #line default
            #line hidden
WriteLiteral(@"
                    </th>
                    <th class=""header purple"" data-bind=""click: setOrderBy.bind($data, 'CreationDateTime'), css: { headerSortDown: orderBy() == 'CreationDateTime' && isAsc(), headerSortUp: orderBy() == 'CreationDateTime' && !isAsc() }"">
                        ");


            
            #line 40 "..\..\Views\AuthenticationUserList\List.cshtml"
                   Write(Resources.Creation);

            
            #line default
            #line hidden
WriteLiteral(@"
                    </th>
                    <th class=""header light-blue"" data-bind=""click: setOrderBy.bind($data, 'LastModifiedDateTime'), css: { headerSortDown: orderBy() == 'LastModifiedDateTime' && isAsc(), headerSortUp: orderBy() == 'LastModifiedDateTime' && !isAsc() }"">
                        ");


            
            #line 43 "..\..\Views\AuthenticationUserList\List.cshtml"
                   Write(Resources.LastModified);

            
            #line default
            #line hidden
WriteLiteral(@"
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody id=""paged-users-tbody"" data-bind=""foreach: items"">
                <tr>        
                    <td data-bind=""text: Username""></td>
                    <td data-bind=""text: Email""></td>
                    <td data-bind=""text: IsVerified""></td>
                    <td data-bind=""text: IsLockedOut""></td>
                    <td data-bind=""text: CreationDateTime""></td>
                    <td data-bind=""text: LastModifiedDateTime""></td>
                    <td>
                        <div class=""btn-group open"">
                            <button class=""btn btn-primary dropdown-toggle"" data-toggle=""dropdown"">Select <span class=""caret""></span></button>
                            <ul class=""dropdown-menu"">
                                <li><a href=""#"" data-bind=""click: function(event) { $parent.additionalFunctions.raiseDetails($data); }"">");


            
            #line 60 "..\..\Views\AuthenticationUserList\List.cshtml"
                                                                                                                                   Write(Resources.Details);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                                <li><a href=\"#\" data-bind=\"click: func" +
"tion(event) { $parent.additionalFunctions.raiseManage($data); }\">");


            
            #line 61 "..\..\Views\AuthenticationUserList\List.cshtml"
                                                                                                                                  Write(Resources.Manage);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                            </ul>\r\n                        </div>\r\n   " +
"                 </td>\r\n                </tr>\r\n            </tbody>\r\n        </t" +
"able>\r\n    </div>\r\n</div>\r\n</script>\r\n\r\n");


            
            #line 72 "..\..\Views\AuthenticationUserList\List.cshtml"
   
  using (Html.BeginScriptContext())
  {
    Html.AddScriptBlock(@"
        var user_latest_list  = {};
    
        (function (index) {

            var itemMapping = {
			    'CreationDateTime': ko.utils.getDateFromJson('dd/MMM HH:mm'),
                'LastModifiedDateTime': ko.utils.getDateFromJson('dd/MMM HH:mm')
		    };

            var itemViewModel = function(data) {
			    ko.mapping.fromJS(data, itemMapping, this);
		    };

            var mapping = {	
			    'Items': {
				    create: function(options) {
					    return new itemViewModel(options.data);
				    }
			    }
		    };
        
            user_latest_list = index = ko.mapping.fromJS(" + @Html.Raw(new JavaScriptSerializer().Serialize(Model.MostRecentResult)) + @", mapping);

            index.latestViewModel = new ko.latestItems.viewModel({
                controller: 'Users/List',
                action: 'GetNewerThan',
                data: index,
                singular: 'User',
                plural: 'Users',
                loadPageCallback: function(data) {
                    ko.mapping.fromJS(data, index);
                },
                divIdentifier: 'latest-users-container',
                pagingComponentIdentifier: 'paged-users',
                columns: [
                    { headerText: 'Username', rowText: 'Username' },
                    { headerText: 'Email', rowText: 'Email' },
                    { headerText: 'Creation', rowText: 'CreationDateTime' }
                ]
            });

            jQuery(function() {
                ko.applyBindings(index, jQuery('#latest-users-container')[0]);
            });     

        } (user_latest_list));
    
        var users_paged_list  = {};

        (function (index) {

            var itemMapping = {
			    'CreationDateTime': ko.utils.getDateFromJson('dd/MMM HH:mm'),
                'LastModifiedDateTime': ko.utils.getDateFromJson('dd/MMM HH:mm')
		    };

            var itemViewModel = function(data) {
			    ko.mapping.fromJS(data, itemMapping, this);
		    };

            var mapping = {	
			    'Items': {
				    create: function(options) {
					    return new itemViewModel(options.data);
				    }
			    }
		    };
        
            users_paged_list = index = ko.mapping.fromJS(" + @Html.Raw(new JavaScriptSerializer().Serialize(Model.PagedResult)) + @", mapping);

            index.pagedViewModel = new ko.pagedGrid.viewModel({
                controller: 'Users',
                action: 'GetPage',
                data: index,
                singular: 'User',
                plural: 'Users',
                pagingComponentIdentifier: 'paged-users',
                loadPageCallback: function(data) {
                    ko.mapping.fromJS(data, index);
                },
                columns: [
                    { headerText: 'Name', rowText: 'Name' },
                    { headerText: 'Application Name', rowText: 'ApplicationName' },
                    { headerText: 'Creation Date Time', rowText: 'CreationDateTime' },
                    { headerText: 'Last Modified Date Time', rowText: 'LastModifiedDateTime' }
                ],
                additionalFunctions: {
                    raiseManage: function (obj) {
                        jQuery(document).trigger('userManage', [obj.Id()]);
                    },
                    raiseDetails: function (obj) {
                        jQuery(document).trigger('userDetails', [obj]);
                    },
                    raiseDelete: function (obj) {
                        jQuery(document).trigger('userDelete', [obj.Id()]);
                    }
                }
            });

            jQuery(function() {
                ko.applyBindings(index, jQuery('#paged-users-container')[0]);
            });
        } (users_paged_list));");
  }


            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
