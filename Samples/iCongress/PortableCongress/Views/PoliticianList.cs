#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace PortableCongress
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class PoliticianList : PortableRazor.ViewBase
{

#line hidden

#line 2 "PoliticianList.cshtml"
public List<Politician> Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<html>\n<head>\n\t<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"jquery.mobile-1.4.0.min.css\"");

WriteLiteral(" />\n\t<script");

WriteLiteral(" src=\"jquery-1.10.2.min.js\"");

WriteLiteral("></script>\n\t<script");

WriteLiteral(" src=\"jquery.mobile-1.4.0.min.js\"");

WriteLiteral("></script>\n</head>\n<body>\n\t<div");

WriteLiteral(" data-role=\"header\"");

WriteLiteral(" style=\"overflow:hidden;\"");

WriteLiteral(" data-position=\"fixed\"");

WriteLiteral(">\n    \t<h1>iCongress</h1>\n    </div>\n\n\t<ul");

WriteLiteral(" data-role=\"listview\"");

WriteLiteral(" data-inset=\"true\"");

WriteLiteral(" data-filter-placeholder=\"Search Congress...\"");

WriteLiteral(" data-filter=\"true\"");

WriteLiteral(">\n");


#line 16 "PoliticianList.cshtml"
		

#line default
#line hidden

#line 16 "PoliticianList.cshtml"
   foreach(var p in Model) {


#line default
#line hidden
WriteLiteral("\t\t\t<li>\n");

WriteLiteral("\t\t\t\t");


#line 18 "PoliticianList.cshtml"
Write(Html.ActionLink(String.Format("{0} {1}", p.FirstName, p.LastName), "ShowPoliticianView", new {id = p.Id }));


#line default
#line hidden
WriteLiteral("\n\t\t\t</li>\n");


#line 20 "PoliticianList.cshtml"
		}


#line default
#line hidden
WriteLiteral("\t</ul>\n</body>\n</html>");

}
}
}
#pragma warning restore 1591
