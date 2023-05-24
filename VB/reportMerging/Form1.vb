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
Imports DevExpress.Drawing.Printing

Namespace reportMerging

    Public Partial Class Form1
        Inherits System.Windows.Forms.Form

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim p As reportMerging.PrintHelper = New reportMerging.PrintHelper(New System.Collections.Generic.List(Of DevExpress.XtraReports.UI.XtraReport) From {New reportMerging.XtraReport1(), New reportMerging.XtraReport2()})
            p.CreateDocument()
            p.ShowPreview()
        End Sub
    End Class

    Public Class PrintHelper

        Private reports As System.Collections.Generic.List(Of DevExpress.XtraReports.UI.XtraReport)

        Private link As DevExpress.XtraPrinting.Link

        Public Sub New(ByVal reports As System.Collections.Generic.List(Of DevExpress.XtraReports.UI.XtraReport))
            Me.reports = reports
            Me.link = New DevExpress.XtraPrinting.Link(New DevExpress.XtraPrinting.PrintingSystem())
            Dim height As Integer = 0, width As Integer = 0
            For Each x As DevExpress.XtraReports.UI.XtraReport In reports
                height += x.PageHeight
                width = System.Math.Max(width, x.PageWidth)
            Next

            Me.link.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
            Me.link.CustomPaperSize = New System.Drawing.Size(width, height)
            Me.link.Margins = New DevExpress.Drawing.DXMargins(System.Linq.Enumerable.First(Of DevExpress.XtraReports.UI.XtraReport)(reports).Margins.Left, System.Linq.Enumerable.First(Of DevExpress.XtraReports.UI.XtraReport)(reports).Margins.Right, System.Linq.Enumerable.First(Of DevExpress.XtraReports.UI.XtraReport)(reports).Margins.Top, System.Linq.Enumerable.Last(Of DevExpress.XtraReports.UI.XtraReport)(reports).Margins.Bottom)
            AddHandler Me.link.CreateDetailArea, AddressOf Me.link_CreateDetailArea
        End Sub

        Public Sub CreateDocument()
            Me.link.CreateDocument()
        End Sub

        Public Sub ShowPreview()
            Me.link.ShowPreview()
        End Sub

        Private Sub link_CreateDetailArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)
            Dim maxPages As Integer = 0
            For Each x As DevExpress.XtraReports.UI.XtraReport In Me.reports
                x.CreateDocument()
                maxPages = System.Math.Max(maxPages, x.Pages.Count)
            Next

            Dim pageSize As System.Drawing.SizeF = e.Graph.ClientPageSize
            Dim sectionHeight As Single = If(Me.reports IsNot Nothing AndAlso Me.reports.Count() > 1, pageSize.Height / Me.reports.Count(), 0)
            Dim section As DevExpress.XtraPrinting.PanelBrick
            For pageIndex As Integer = 0 To maxPages - 1
                For sectionIndex As Integer = 0 To Me.reports.Count - 1
                    section = New DevExpress.XtraPrinting.PanelBrick With {.Size = New System.Drawing.SizeF(e.Graph.ClientPageSize.Width, sectionHeight), .BorderWidth = 0}
                    If Me.reports(CInt((sectionIndex))).Pages.Count < pageIndex + 1 Then
                        section.Bricks.Add(New DevExpress.XtraPrinting.LineBrick() With {.Rect = section.Rect, .LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant, .ForeColor = System.Drawing.Color.Red, .LineStyle = DevExpress.Drawing.DXDashStyle.Dash, .BorderWidth = 0})
                        section.Bricks.Add(New DevExpress.XtraPrinting.LineBrick() With {.Rect = section.Rect, .LineDirection = DevExpress.XtraReports.UI.LineDirection.BackSlant, .ForeColor = System.Drawing.Color.Red, .BackColor = System.Drawing.Color.Transparent, .LineStyle = DevExpress.Drawing.DXDashStyle.Dash, .BorderWidth = 1, .BorderColor = System.Drawing.Color.Red, .BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash, .BorderStyle = DevExpress.XtraPrinting.BrickBorderStyle.Inset})
                    Else
                        For Each brick As DevExpress.XtraPrinting.Brick In CType(Me.reports(CInt((sectionIndex))).Pages(CInt((pageIndex))), DevExpress.XtraPrinting.Native.PSPage).Bricks
                            section.Bricks.Add(brick)
                        Next
                    End If

                    e.Graph.Modifier = DevExpress.XtraPrinting.BrickModifier.None
                    e.Graph.Modifier = DevExpress.XtraPrinting.BrickModifier.Detail
                    e.Graph.DrawBrick(section)
                Next
            Next
        End Sub
    End Class
End Namespace
