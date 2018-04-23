# Runtime report merging


<p>Given a collection of XtraReports the goal is to merge each page of every report into a single report document. A custom PrintHelper class encapsulates the Link associated with the resulting document.  PrintHelper handles <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingLinkBase_CreateDetailAreatopic">Link.CreateDetailArea</a>, calling <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPrintingLinkBase_CreateDetailAreatopic">e.Graph.DrawBrick</a> for each brick of the constituent reports. If the constituent reports are of unequal page length, a red crossbox is drawn as a placeholder in the empty page areas corresponding to the shorter reports.</p>


<h3>Description</h3>

<p>A PrintHelper class accepts List&lt;XtraReport&gt; and merges each page from each report document when PrintHelper.CreateDocument and PrintHelper.ShowPreview are called.</p>

<br/>


