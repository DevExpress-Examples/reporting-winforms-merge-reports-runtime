Imports Microsoft.VisualBasic
Imports System
Namespace reportMerging
	Partial Public Class XtraReport1
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
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.nwindDataSet1 = New reportMerging.nwindDataSet()
			Me.customersTableAdapter = New reportMerging.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.HeightF = 32.79168F
			Me.Detail.KeepTogether = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BackColor = System.Drawing.Color.Gainsboro
			Me.xrLabel2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.Country")})
			Me.xrLabel2.KeepTogether = True
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(248.9583F, 32.79168F)
			Me.xrLabel2.StylePriority.UseBackColor = False
			Me.xrLabel2.StylePriority.UseBorders = False
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.MintCream
			Me.xrLabel1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.City")})
			Me.xrLabel1.KeepTogether = True
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(248.9584F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(720.0416F, 32.79168F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.StylePriority.UseBorders = False
			Me.xrLabel1.Text = "xrLabel1"
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
			Me.PageFooter.HeightF = 37.58334F
			Me.PageFooter.Name = "PageFooter"
			' 
			' xrPageInfo1
			' 
			Me.xrPageInfo1.BackColor = System.Drawing.Color.Gainsboro
			Me.xrPageInfo1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPageInfo1.ForeColor = System.Drawing.Color.Red
			Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPageInfo1.Name = "xrPageInfo1"
			Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(248.9583F, 37.58334F)
			Me.xrPageInfo1.StylePriority.UseBackColor = False
			Me.xrPageInfo1.StylePriority.UseBorders = False
			Me.xrPageInfo1.StylePriority.UseFont = False
			Me.xrPageInfo1.StylePriority.UseForeColor = False
			Me.xrPageInfo1.StylePriority.UseTextAlignment = False
			Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel4})
			Me.PageHeader.HeightF = 34.45834F
			Me.PageHeader.Name = "PageHeader"
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.MintCream
			Me.xrLabel3.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(248.9584F, 0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(720.0415F, 34.45833F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.StylePriority.UseBorders = False
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			Me.xrLabel3.Text = "City"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.BackColor = System.Drawing.Color.Gainsboro
			Me.xrLabel4.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(6.357829E-05F, 0F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(248.9583F, 34.45834F)
			Me.xrLabel4.StylePriority.UseBackColor = False
			Me.xrLabel4.StylePriority.UseBorders = False
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.StylePriority.UseTextAlignment = False
			Me.xrLabel4.Text = "Country"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.PageHeader})
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
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private nwindDataSet1 As nwindDataSet
		Private customersTableAdapter As nwindDataSetTableAdapters.CustomersTableAdapter
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
