Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class PODetail
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Function POStatus() As String()
        Dim PurchaseOrderStatus() As String = New String() {"CA", "CP", "CL", "RC", "PL"}
        Return PurchaseOrderStatus
    End Function
End Class