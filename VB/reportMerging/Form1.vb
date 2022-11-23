Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native

Namespace reportMerging
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim p As New PrintHelper(New List(Of XtraReport) From {New XtraReport1(), New XtraReport2()})
			p.CreateDocument()
			p.ShowPreview()
		End Sub
	End Class
	Public Class PrintHelper
		Private reports As List(Of XtraReport)
		Private link As Link
		Public Sub New(ByVal reports As List(Of XtraReport))
			Me.reports = reports
			link = New Link(New PrintingSystem())
			Dim height As Integer = 0, width As Integer = 0
			For Each x As XtraReport In reports
				height += x.PageHeight
				width = Math.Max(width, x.PageWidth)
			Next x
			link.PaperKind = PaperKind.Custom
			link.CustomPaperSize = New Size(width, height)
            link.Margins = New DXMargins(reports.First().Margins.Left, reports.First().Margins.Right, reports.First().Margins.Top, reports.Last().Margins.Bottom)
			AddHandler link.CreateDetailArea, AddressOf link_CreateDetailArea
		End Sub
		Public Sub CreateDocument()
			link.CreateDocument()
		End Sub
		Public Sub ShowPreview()
			link.ShowPreview()
		End Sub
		Private Sub link_CreateDetailArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			Dim maxPages As Integer = 0
			For Each x As XtraReport In reports
				x.CreateDocument()
				maxPages = Math.Max(maxPages, x.Pages.Count)
			Next x
			Dim pageSize As SizeF = e.Graph.ClientPageSize
			Dim sectionHeight As Single = If(reports IsNot Nothing AndAlso reports.Count() > 1, pageSize.Height / reports.Count(), 0)
			Dim section As PanelBrick
			For pageIndex As Integer = 0 To maxPages - 1
				For sectionIndex As Integer = 0 To reports.Count - 1
					section = New PanelBrick With {.Size = New SizeF(e.Graph.ClientPageSize.Width, sectionHeight), .BorderWidth=0}
					If reports(sectionIndex).Pages.Count < pageIndex + 1 Then
						section.Bricks.Add(New LineBrick() With {.Rect = section.Rect, .LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant, .ForeColor = Color.Red, .LineStyle = System.Drawing.Drawing2D.DashStyle.Dash, .BorderWidth = 0})
						section.Bricks.Add(New LineBrick() With {.Rect = section.Rect, .LineDirection = DevExpress.XtraReports.UI.LineDirection.BackSlant, .ForeColor = Color.Red, .BackColor = Color.Transparent, .LineStyle = System.Drawing.Drawing2D.DashStyle.Dash, .BorderWidth = 1, .BorderColor = Color.Red, .BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash, .BorderStyle = BrickBorderStyle.Inset})
					Else
						For Each brick As Brick In (CType(reports(sectionIndex).Pages(pageIndex), PSPage)).Bricks
							section.Bricks.Add(brick)
						Next brick
					End If
					e.Graph.Modifier = BrickModifier.None
					e.Graph.Modifier = BrickModifier.Detail
					e.Graph.DrawBrick(section)
				Next sectionIndex
			Next pageIndex
		End Sub
	End Class
End Namespace
