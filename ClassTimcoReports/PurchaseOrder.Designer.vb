Partial Class PurchaseOrder
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseOrder))
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule3 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule4 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim FormattingRule5 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim InstanceReportSource2 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim FormattingRule6 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule7 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.PoDetail1 = New ClassTimcoReports.PODetail()
        Me.PoDetailDropShip1 = New ClassTimcoReports.PODetailDropShip()
        Me.po_idGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.po_idGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.Shape1 = New Telerik.Reporting.Shape()
        Me.Shape2 = New Telerik.Reporting.Shape()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.SubReport1 = New Telerik.Reporting.SubReport()
        Me.SubReport2 = New Telerik.Reporting.SubReport()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.Shape3 = New Telerik.Reporting.Shape()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.Panel4 = New Telerik.Reporting.Panel()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        CType(Me.PoDetail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoDetailDropShip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PoDetail1
        '
        Me.PoDetail1.Name = "PODetail"
        '
        'PoDetailDropShip1
        '
        Me.PoDetailDropShip1.Name = "PODetailDropShip"
        '
        'po_idGroupFooterSection
        '
        Me.po_idGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.19999951124191284R)
        Me.po_idGroupFooterSection.Name = "po_idGroupFooterSection"
        '
        'po_idGroupHeaderSection
        '
        Me.po_idGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R)
        Me.po_idGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox47, Me.TextBox49})
        Me.po_idGroupHeaderSection.Name = "po_idGroupHeaderSection"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.20003907382488251R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.PictureBox1.MimeType = "image/png"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999608039855957R), Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Normal
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.50000005960464478R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "Purchase Order"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(1.0999999046325684R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582R))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "Supplier "
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(0.50000005960464478R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999998092651367R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "=Fields.po_id"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5999999046325684R), Telerik.Reporting.Drawing.Unit.Inch(1.0999999046325684R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3000001907348633R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "=Fields.supplier_nbr"
        '
        'TextBox47
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("=Fields.drop_ship_fl", Telerik.Reporting.FilterOperator.Equal, "Y"))
        FormattingRule1.Style.Visible = False
        Me.TextBox47.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox47.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox47.Value = "Revision"
        '
        'TextBox49
        '
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("=Fields.drop_ship_fl", Telerik.Reporting.FilterOperator.Equal, "Y"))
        FormattingRule2.Style.Visible = False
        Me.TextBox49.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6000008583068848R), Telerik.Reporting.Drawing.Unit.Inch(0.800000011920929R))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.19992096722126007R))
        Me.TextBox49.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox49.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox49.Value = "=Fields.revision_nbr"
        '
        'TextBox26
        '
        FormattingRule3.Filters.Add(New Telerik.Reporting.Filter("=Fields.drop_ship_fl", Telerik.Reporting.FilterOperator.Equal, "N"))
        FormattingRule3.Style.Visible = False
        Me.TextBox26.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule3})
        Me.TextBox26.Format = "{0}"
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595R), Telerik.Reporting.Drawing.Unit.Inch(0.80047434568405151R))
        Me.TextBox26.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Dashed
        Me.TextBox26.Style.Color = System.Drawing.Color.Red
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox26.Value = "Please use Timco Packing Slips, Bill of Ladings and Labels on shipments. Referenc" & _
    "e Customer Purchase Order Number on all shipments."
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R)
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.Visible = False
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(4.7999997138977051R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox14, Me.TextBox18, Me.TextBox19, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox20, Me.TextBox21, Me.TextBox23, Me.TextBox30, Me.TextBox34, Me.TextBox41, Me.TextBox35, Me.TextBox37, Me.TextBox13, Me.TextBox42, Me.TextBox43, Me.Shape1, Me.Shape2, Me.TextBox40, Me.TextBox36, Me.SubReport1, Me.SubReport2, Me.Panel1, Me.Panel2, Me.TextBox26})
        Me.detail.Name = "detail"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099921226501464844R), Telerik.Reporting.Drawing.Unit.Inch(1.5999999046325684R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8000787496566772R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox5.Value = "Timco Rubber Products Inc."
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9000787734985352R), Telerik.Reporting.Drawing.Unit.Inch(1.600157618522644R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999209880828857R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox6.Value = "P.O. Box 35135"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0000789165496826R), Telerik.Reporting.Drawing.Unit.Inch(1.5999999046325684R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4999215602874756R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox7.Value = "Cleveland, Ohio 44135"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.300079345703125R), Telerik.Reporting.Drawing.Unit.Inch(1.600157618522644R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3998416662216187R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox8.Value = "Fax: (216) 267-6245"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.50007963180542R), Telerik.Reporting.Drawing.Unit.Inch(1.5999999046325684R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999213933944702R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox9.Value = "Telephone: (216) 267-6242"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197R), Telerik.Reporting.Drawing.Unit.Inch(0.10031620413064957R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox10.Value = "To:"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.10000022500753403R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox11.Value = "Ship To:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.40000009536743164R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox12.Value = "=Fields.Shipnm"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.60007905960083008R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox14.Value = "=Fields.ShipStreet"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(1.0000786781311035R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999999284744263R), Telerik.Reporting.Drawing.Unit.Inch(0.19992129504680634R))
        Me.TextBox18.Value = "=Fields.ShipCountry"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.80015802383422852R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(0.19984245300292969R))
        Me.TextBox19.Value = "=Fields.ShipCity+ "", ""+ Fields.ShipState+ "" ""+ Fields.ShipZip"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.60007905960083008R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5999221801757812R), Telerik.Reporting.Drawing.Unit.Inch(0.20031578838825226R))
        Me.TextBox15.Value = "=Fields.BillStreet"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099921226501464844R), Telerik.Reporting.Drawing.Unit.Inch(1.8000788688659668R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4000000953674316R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox16.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "P.O. Date"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(1.8000794649124146R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5999212265014648R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox17.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "Ship Via"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(1.8000788688659668R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4999210834503174R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox20.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "F.O.B."
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10003948211669922R), Telerik.Reporting.Drawing.Unit.Inch(2.2094271183013916R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5999605655670166R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox21.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "Terms"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.6000008583068848R), Telerik.Reporting.Drawing.Unit.Inch(1.8000788688659668R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.099998950958252R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox23.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "Freight"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000789642333984R), Telerik.Reporting.Drawing.Unit.Inch(2.2094264030456543R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9999208450317383R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox30.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox30.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox30.Value = "Customer PO"
        '
        'TextBox34
        '
        Me.TextBox34.Format = "{0:d}"
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.19992129504680634R), Telerik.Reporting.Drawing.Unit.Inch(2.0000002384185791R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1999999284744263R), Telerik.Reporting.Drawing.Unit.Inch(0.20934772491455078R))
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox34.Value = "=Fields.entered_dt"
        '
        'TextBox41
        '
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7000789642333984R), Telerik.Reporting.Drawing.Unit.Inch(2.4093470573425293R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.9998416900634766R), Telerik.Reporting.Drawing.Unit.Inch(0.20934772491455078R))
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox41.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox41.Value = "=Fields.cust_po_nbr"
        '
        'TextBox35
        '
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(2.0001585483551025R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.4999210834503174R), Telerik.Reporting.Drawing.Unit.Inch(0.19999916851520538R))
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox35.Value = "=Fields.carrier_nm"
        '
        'TextBox37
        '
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10003948211669922R), Telerik.Reporting.Drawing.Unit.Inch(2.4002373218536377R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5999605655670166R), Telerik.Reporting.Drawing.Unit.Inch(0.209188774228096R))
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox37.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox37.Value = "=Fields.PayTermsDesc"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.40000009536743164R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5999221801757812R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox13.Value = "=Fields.supplier_nbr"
        '
        'TextBox42
        '
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.50000065565109253R), Telerik.Reporting.Drawing.Unit.Inch(0.80047398805618286R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5999214649200439R), Telerik.Reporting.Drawing.Unit.Inch(0.20000045001506805R))
        Me.TextBox42.Value = "= Fields.BillCity + "", "" + Fields.BillState + "" "" + Fields.BillZip"
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.50000065565109253R), Telerik.Reporting.Drawing.Unit.Inch(1.0003947019577026R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054R), Telerik.Reporting.Drawing.Unit.Inch(0.19992096722126007R))
        Me.TextBox43.Value = "=Fields.BillCountry"
        '
        'Shape1
        '
        Me.Shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.4000391960144043R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5999605655670166R), Telerik.Reporting.Drawing.Unit.Inch(0.19992129504680634R))
        '
        'Shape2
        '
        Me.Shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.7000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.Shape2.Name = "Shape2"
        Me.Shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0000004768371582R), Telerik.Reporting.Drawing.Unit.Inch(0.19992129504680634R))
        '
        'TextBox40
        '
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.599921703338623R), Telerik.Reporting.Drawing.Unit.Inch(1.9999995231628418R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.099998950958252R), Telerik.Reporting.Drawing.Unit.Inch(0.20007960498332977R))
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox40.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox40.Value = "=Fields.FrtTermsDesc"
        '
        'TextBox36
        '
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1000003814697266R), Telerik.Reporting.Drawing.Unit.Inch(1.9999995231628418R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4998422861099243R), Telerik.Reporting.Drawing.Unit.Inch(0.20934772491455078R))
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox36.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox36.Value = "=Fields.FrtFOBDesc"
        '
        'SubReport1
        '
        FormattingRule4.Filters.Add(New Telerik.Reporting.Filter("=Fields.drop_ship_fl", Telerik.Reporting.FilterOperator.Equal, "Y"))
        FormattingRule4.Style.Visible = False
        Me.SubReport1.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule4})
        Me.SubReport1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10007890313863754R), Telerik.Reporting.Drawing.Unit.Inch(3.2189319133758545R))
        Me.SubReport1.Name = "SubReport1"
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dPONumber", "=Fields.po_id"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dFlagOpen", "=Parameters.FlagOpen.Value"))
        InstanceReportSource1.Parameters.Add(New Telerik.Reporting.Parameter("dDrop_ship_fl", "=Fields.drop_ship_fl"))
        InstanceReportSource1.ReportDocument = Me.PoDetail1
        Me.SubReport1.ReportSource = InstanceReportSource1
        Me.SubReport1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.4479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606R))
        '
        'SubReport2
        '
        FormattingRule5.Filters.Add(New Telerik.Reporting.Filter("=Fields.drop_ship_fl", Telerik.Reporting.FilterOperator.Equal, "N"))
        FormattingRule5.Style.Visible = False
        Me.SubReport2.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule5})
        Me.SubReport2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099921226501464844R), Telerik.Reporting.Drawing.Unit.Inch(3.9190108776092529R))
        Me.SubReport2.Name = "SubReport2"
        InstanceReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("dPONumber", "=Fields.po_id"))
        InstanceReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("dFlagOpen", "=Parameters.FlagOpen.Value"))
        InstanceReportSource2.Parameters.Add(New Telerik.Reporting.Parameter("dDrop_ship_fl", "=Fields.drop_ship_fl"))
        InstanceReportSource2.ReportDocument = Me.PoDetailDropShip1
        Me.SubReport2.ReportSource = InstanceReportSource2
        Me.SubReport2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.4479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.7999998927116394R))
        '
        'Panel1
        '
        FormattingRule6.Filters.Add(New Telerik.Reporting.Filter("=Fields.drop_ship_fl", Telerik.Reporting.FilterOperator.Equal, "Y"))
        FormattingRule6.Style.Visible = False
        Me.Panel1.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule6})
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox46, Me.TextBox50, Me.TextBox51, Me.TextBox52, Me.TextBox53})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10007890313863754R), Telerik.Reporting.Drawing.Unit.Inch(2.9188525676727295R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.5999603271484375R), Telerik.Reporting.Drawing.Unit.Inch(0.30000019073486328R))
        '
        'TextBox46
        '
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1518464088439941R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox46.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox46.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox46.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox46.Value = "Extended Cost"
        '
        'TextBox50
        '
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992102384567261R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox50.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox50.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox50.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox50.Value = "Unit Cost"
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.20015811920166R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2539293766021729R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox51.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox51.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox51.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox51.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox51.Value = "Description"
        '
        'TextBox52
        '
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.80003947019577026R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4000399112701416R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox52.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox52.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox52.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox52.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox52.Value = "Item Number"
        '
        'TextBox53
        '
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.7999606728553772R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox53.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox53.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox53.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox53.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox53.Value = "Qty. Req."
        '
        'Panel2
        '
        FormattingRule7.Filters.Add(New Telerik.Reporting.Filter("=Fields.drop_ship_fl", Telerik.Reporting.FilterOperator.Equal, "N"))
        FormattingRule7.Style.Visible = False
        Me.Panel2.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule7})
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox22, Me.TextBox24, Me.TextBox25, Me.TextBox32, Me.TextBox38, Me.TextBox39})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099921226501464844R), Telerik.Reporting.Drawing.Unit.Inch(2.6187736988067627R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.5999603271484375R), Telerik.Reporting.Drawing.Unit.Inch(0.30000019073486328R))
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.9001187086105347R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4454387426376343R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox22.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "Cust Part Number"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1520041227340698R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox24.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox24.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "Extended Cost"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4479165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992102384567261R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox25.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox25.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "Unit Cost"
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.3541667461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0999207496643066R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox32.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox32.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "Description"
        '
        'TextBox38
        '
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.80003958940505981R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.100000262260437R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox38.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox38.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox38.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox38.Value = "Item Number"
        '
        'TextBox39
        '
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039418537198798731R), Telerik.Reporting.Drawing.Unit.Inch(0.0416666679084301R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79992121458053589R), Telerik.Reporting.Drawing.Unit.Inch(0.19999980926513672R))
        Me.TextBox39.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.TextBox39.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox39.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox39.Value = "Qty. Req."
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(2.8000004291534424R)
        Me.pageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox, Me.TextBox45, Me.Shape3, Me.TextBox48, Me.Panel3, Me.Panel4})
        Me.pageFooterSection1.Name = "pageFooterSection1"
        Me.pageFooterSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Format = "{0:D}"
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6018481254577637R), Telerik.Reporting.Drawing.Unit.Inch(2.5000007152557373R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.19999860227108002R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099921226501464844R), Telerik.Reporting.Drawing.Unit.Inch(2.5000007152557373R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.19999860227108002R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=""Page Number:""+PageNumber"
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6018471717834473R), Telerik.Reporting.Drawing.Unit.Inch(2.0520446300506592R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.29999923706054688R))
        Me.TextBox45.Value = "Authorized Signature"
        '
        'Shape3
        '
        Me.Shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6018481254577637R), Telerik.Reporting.Drawing.Unit.Inch(1.8520437479019165R))
        Me.Shape3.Name = "Shape3"
        Me.Shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.Shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.8999996185302734R), Telerik.Reporting.Drawing.Unit.Inch(0.29999923706054688R))
        '
        'TextBox48
        '
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.6018481254577637R), Telerik.Reporting.Drawing.Unit.Inch(1.7520440816879272R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7999992370605469R), Telerik.Reporting.Drawing.Unit.Inch(0.20000074803829193R))
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox48.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox48.Value = "=Fields.nm"
        '
        'Panel3
        '
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox28})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.10000038146972656R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.299959659576416R), Telerik.Reporting.Drawing.Unit.Inch(1.5000005960464478R))
        Me.Panel3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'TextBox28
        '
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.09992130845785141R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.0000786781311035R), Telerik.Reporting.Drawing.Unit.Inch(1.3479169607162476R))
        Me.TextBox28.Value = "=Fields.order_tx"
        '
        'Panel4
        '
        Me.Panel4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.4000382423400879R), Telerik.Reporting.Drawing.Unit.Inch(0.10000038146972656R))
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1479568481445313R), Telerik.Reporting.Drawing.Unit.Inch(1.5000005960464478R))
        Me.Panel4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "ClassTimcoReports.My.MySettings.ConvergeProd"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@PONumber", System.Data.DbType.[String], "=Parameters.PONumber.Value")})
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'PurchaseOrder
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.po_idGroupFooterSection
        Group1.GroupHeader = Me.po_idGroupHeaderSection
        Group1.Groupings.Add(New Telerik.Reporting.Grouping("=Fields.po_id"))
        Group1.Name = "po_idGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.po_idGroupHeaderSection, Me.po_idGroupFooterSection, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "PurchaseOrder"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ReportParameter1.Name = "PONumber"
        ReportParameter1.Text = "Purchase Order Number"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = "38836"
        ReportParameter1.Visible = True
        ReportParameter2.Name = "FlagOpen"
        ReportParameter2.Text = "Open Items Only?"
        ReportParameter2.Type = Telerik.Reporting.ReportParameterType.[Boolean]
        ReportParameter2.Value = "FALSE"
        ReportParameter2.Visible = True
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.9000000953674316R)
        CType(Me.PoDetail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoDetailDropShip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents po_idGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents po_idGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox43 As Telerik.Reporting.TextBox
    Friend WithEvents Shape1 As Telerik.Reporting.Shape
    Friend WithEvents Shape2 As Telerik.Reporting.Shape
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents TextBox45 As Telerik.Reporting.TextBox
    Friend WithEvents Shape3 As Telerik.Reporting.Shape
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents SubReport1 As Telerik.Reporting.SubReport
    Friend WithEvents SubReport2 As Telerik.Reporting.SubReport
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox51 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox52 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox53 As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents PoDetail1 As ClassTimcoReports.PODetail
    Friend WithEvents PoDetailDropShip1 As ClassTimcoReports.PODetailDropShip
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents Panel4 As Telerik.Reporting.Panel
End Class