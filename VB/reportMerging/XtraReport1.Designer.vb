Namespace reportMerging

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim selectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim columnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reportMerging.XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1})
            Me.Detail.HeightF = 32.79168F
            Me.Detail.KeepTogether = True
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.BackColor = System.Drawing.Color.Gainsboro
            Me.xrLabel2.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Country]")})
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
            Me.xrLabel1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[City]")})
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
            ' PageFooter
            ' 
            Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageInfo1})
            Me.PageFooter.HeightF = 37.58334F
            Me.PageFooter.Name = "PageFooter"
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.BackColor = System.Drawing.Color.Gainsboro
            Me.xrPageInfo1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
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
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel4})
            Me.PageHeader.HeightF = 34.45834F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.BackColor = System.Drawing.Color.MintCream
            Me.xrLabel3.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.25F)
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
            Me.xrLabel4.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Times New Roman", 14.25F)
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
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            columnExpression1.ColumnName = "CustomerID"
            table1.Name = "Customers"
            columnExpression1.Table = table1
            column1.Expression = columnExpression1
            columnExpression2.ColumnName = "CompanyName"
            columnExpression2.Table = table1
            column2.Expression = columnExpression2
            columnExpression3.ColumnName = "ContactName"
            columnExpression3.Table = table1
            column3.Expression = columnExpression3
            columnExpression4.ColumnName = "ContactTitle"
            columnExpression4.Table = table1
            column4.Expression = columnExpression4
            columnExpression5.ColumnName = "Address"
            columnExpression5.Table = table1
            column5.Expression = columnExpression5
            columnExpression6.ColumnName = "City"
            columnExpression6.Table = table1
            column6.Expression = columnExpression6
            columnExpression7.ColumnName = "Region"
            columnExpression7.Table = table1
            column7.Expression = columnExpression7
            columnExpression8.ColumnName = "PostalCode"
            columnExpression8.Table = table1
            column8.Expression = columnExpression8
            columnExpression9.ColumnName = "Country"
            columnExpression9.Table = table1
            column9.Expression = columnExpression9
            columnExpression10.ColumnName = "Phone"
            columnExpression10.Table = table1
            column10.Expression = columnExpression10
            columnExpression11.ColumnName = "Fax"
            columnExpression11.Table = table1
            column11.Expression = columnExpression11
            selectQuery1.Columns.Add(column1)
            selectQuery1.Columns.Add(column2)
            selectQuery1.Columns.Add(column3)
            selectQuery1.Columns.Add(column4)
            selectQuery1.Columns.Add(column5)
            selectQuery1.Columns.Add(column6)
            selectQuery1.Columns.Add(column7)
            selectQuery1.Columns.Add(column8)
            selectQuery1.Columns.Add(column9)
            selectQuery1.Columns.Add(column10)
            selectQuery1.Columns.Add(column11)
            selectQuery1.Name = "Customers"
            selectQuery1.Tables.Add(table1)
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {selectQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooter, Me.PageHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.sqlDataSource1})
            Me.DataMember = "Customers"
            Me.DataSource = Me.sqlDataSource1
            Me.Landscape = True
            Me.Margins = New DevExpress.Drawing.DXMargins(100F, 100F, 100F, 102F)
            Me.PageHeight = 827
            Me.PageWidth = 1169
            Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
            Me.Version = "22.2"
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand

        Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel

        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
