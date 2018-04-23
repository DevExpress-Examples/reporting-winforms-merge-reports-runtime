Imports Microsoft.VisualBasic
Imports System
Namespace reportMerging
	Partial Public Class XtraReport2
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New reportMerging.nwindDataSet()
			Me.customersTableAdapter = New reportMerging.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.Detail.HeightF = 62.58336F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 102F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' PageFooter
			' 
			Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageInfo1})
			Me.PageFooter.HeightF = 56.33329F
			Me.PageFooter.Name = "PageFooter"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.BackColor = System.Drawing.Color.AntiqueWhite
			Me.xrPageInfo1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(640.2957F, 0F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(328.7043F, 56.33329F)
			Me.xrPageInfo1.StylePriority.UseBackColor = False
			Me.xrPageInfo1.StylePriority.UseBorders = False
			Me.xrPageInfo1.StylePriority.UseFont = False
			Me.xrPageInfo1.StylePriority.UseTextAlignment = False
			Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrTable1
			' 
			Me.xrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
			Me.xrTable1.BackColor = System.Drawing.Color.AntiqueWhite
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.KeepTogether = True
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(54.16667F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(914.8333F, 62.58336F)
			Me.xrTable1.StylePriority.UseBackColor = False
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UseForeColor = False
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.CanGrow = False
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.City")})
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.StylePriority.UseTextAlignment = False
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell1.Weight = 1R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.CanGrow = False
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CompanyName")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.StylePriority.UseTextAlignment = False
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell2.Weight = 1R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.CanGrow = False
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.ContactName")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.StylePriority.UseTextAlignment = False
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell3.Weight = 1.1216107382550336R
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Country", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			Me.GroupHeader1.HeightF = 40.70834F
			Me.GroupHeader1.KeepTogether = True
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Country")})
			Me.xrLabel1.Font = New System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xrLabel1.ForeColor = System.Drawing.Color.DarkRed
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(969F, 40.70834F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.StylePriority.UseForeColor = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' XtraReport2
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.GroupHeader1})
			Me.DataAdapter = Me.customersTableAdapter
			Me.DataMember = "Customers"
			Me.DataSource = Me.nwindDataSet1
			Me.Landscape = True
			Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 102)
			Me.PageHeight = 827
			Me.PageWidth = 1169
			Me.PaperKind = System.Drawing.Printing.PaperKind.A4
			Me.Version = "12.1"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private customersTableAdapter As nwindDataSetTableAdapters.CustomersTableAdapter
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
