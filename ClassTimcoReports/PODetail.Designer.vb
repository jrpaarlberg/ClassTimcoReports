Partial Class PODetail
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PODetail))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.po_idGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.po_idGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'po_idGroupFooterSection
        '
        Me.po_idGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.299999862909317R)
        Me.po_idGroupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox7, Me.TextBox8, Me.TextBox9})
        Me.po_idGroupFooterSection.Name = "po_idGroupFooterSection"
        '
        'TextBox7
        '
        Me.TextBox7.Format = "{0:N2}"
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.6999607086181641R), Telerik.Reporting.Drawing.Unit.Inch(0.0091479616239666939R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7999998927116394R), Telerik.Reporting.Drawing.Unit.Inch(0.19089126586914063R))
        Me.TextBox7.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox7.Value = "=Sum(Fields.ExtCost)"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89996069669723511R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "=sum(Fields.ordered_qty)"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.0091479616239666939R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox9.Value = "Total"
        '
        'po_idGroupHeaderSection
        '
        Me.po_idGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R)
        Me.po_idGroupHeaderSection.KeepTogether = True
        Me.po_idGroupHeaderSection.Name = "po_idGroupHeaderSection"
        Me.po_idGroupHeaderSection.Style.Visible = False
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(2.0R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.Visible = False
        '
        'detail
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("RowNumber() % 2", Telerik.Reporting.FilterOperator.Equal, "1"))
        FormattingRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.detail.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox3})
        Me.detail.Name = "detail"
        '
        'TextBox1
        '
        Me.TextBox1.Format = "{0:N1}"
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757813R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89996069669723511R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "=Fields.ordered_qty"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2001184225082397R), Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2998818159103394R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox2.Value = "=Fields.item_id"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000002861022949R), Telerik.Reporting.Drawing.Unit.Inch(0.000039736431062920019R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.300079345703125R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "=Fields.item_desc"
        '
        'TextBox5
        '
        Me.TextBox5.Format = "{0:N4}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.0R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.Value = "=Fields.item_cost"
        '
        'TextBox6
        '
        Me.TextBox6.Format = "{0:N2}"
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4542346000671387R), Telerik.Reporting.Drawing.Unit.Inch(0.0091482801362872124R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0457261800765991R), Telerik.Reporting.Drawing.Unit.Inch(0.19996070861816406R))
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "=Fields.ExtCost"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox3.Value = "=Fields.item_tx"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.6000003814697266R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.Visible = False
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.CalculatedFields.AddRange(New Telerik.Reporting.CalculatedField() {New Telerik.Reporting.CalculatedField("ExtCost", GetType(Double), "= Fields.ordered_qty* Fields.item_cost")})
        Me.SqlDataSource2.ConnectionString = "ClassTimcoReports.My.MySettings.ConvergeProd"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.SelectCommand = resources.GetString("SqlDataSource2.SelectCommand")
        '
        'PODetail
        '
        Me.DataSource = Me.SqlDataSource2
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.po_id", Telerik.Reporting.FilterOperator.Equal, "=Parameters.dPONumber.Value"))
        Me.Filters.Add(New Telerik.Reporting.Filter("=Fields.status_cd", Telerik.Reporting.FilterOperator.[In], "= IIf(Parameters.dFlagOpen.Value = TRUE,""=POStatus()"" ,Fields.Status_cd)"))
        Group1.GroupFooter = Me.po_idGroupFooterSection
        Group1.GroupHeader = Me.po_idGroupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.po_id"))
        Group1.Name = "po_idGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.po_idGroupHeaderSection, Me.po_idGroupFooterSection, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "PODetail"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "dPONumber"
        ReportParameter2.Name = "dFlagOpen"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Boolean]
        ReportParameter2.Value = "FALSE"
        ReportParameter3.Name = "dDrop_ship_fl"
        ReportParameter3.Value = "N"
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.6000003814697266R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents po_idGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents po_idGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
End Class