Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace dxSample_ColoredFormHeaders
    Partial Public Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
            InitColorefulForms()
        End Sub
        Private Shared Sub InitColorefulForms()
            CType(New ColoredHeaderForm(Color.Magenta), ColoredHeaderForm).Show()
            CType(New ColoredHeaderForm(Color.Yellow), ColoredHeaderForm).Show()
            CType(New ColoredHeaderForm(Color.DarkOrchid), ColoredHeaderForm).Show()
        End Sub
    End Class
End Namespace
