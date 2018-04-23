Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq

Namespace dxSample_ColoredFormHeaders
    Partial Public Class ColoredHeaderForm
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal formBorderColor As Color)
            Me.FormBorderColor = formBorderColor
            InitializeComponent()
        End Sub
        Private _FormBorderColor As Color = Color.Yellow
        Public Property FormBorderColor() As Color
            Get
                Return _FormBorderColor
            End Get
            Set(ByVal value As Color)
                _FormBorderColor = value
            End Set
        End Property
        Protected Overrides Function CreateFormBorderPainter() As DevExpress.Skins.XtraForm.FormPainter
            Return New CustomFormPainter(Me, LookAndFeel)
        End Function
    End Class
End Namespace
