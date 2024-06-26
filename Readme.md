<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604711/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20058)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/reportMerging/Form1.cs) (VB: [Form1.vb](./VB/reportMerging/Form1.vb))
* [Program.cs](./CS/reportMerging/Program.cs) (VB: [Program.vb](./VB/reportMerging/Program.vb))
* [XtraReport1.cs](./CS/reportMerging/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/reportMerging/XtraReport1.vb))
* [XtraReport2.cs](./CS/reportMerging/XtraReport2.cs) (VB: [XtraReport2.vb](./VB/reportMerging/XtraReport2.vb))
<!-- default file list end -->
# Runtime report merging


<p>Given a collection of XtraReports the goal is to merge each page of every report into a single report document. A custom PrintHelper class encapsulates the Link associated with the resulting document.  PrintHelper handles <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingLinkBase_CreateDetailAreatopic">Link.CreateDetailArea</a>, calling <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingLinkBase_CreateDetailAreatopic">e.Graph.DrawBrick</a> for each brick of the constituent reports. If the constituent reports are of unequal page length, a red crossbox is drawn as a placeholder in the empty page areas corresponding to the shorter reports.</p>


<h3>Description</h3>

<p>A PrintHelper class accepts List&lt;XtraReport&gt; and merges each page from each report document when PrintHelper.CreateDocument and PrintHelper.ShowPreview are called.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-merge-reports-runtime&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-merge-reports-runtime&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
