Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.Skins.XtraForm
Imports DevExpress.Utils.Drawing

Namespace dxSample_ColoredFormHeaders
    Public Class CustomFormPainter
        Inherits FormPainter

        Public Sub New(ByVal owner As System.Windows.Forms.Control, ByVal provider As DevExpress.Skins.ISkinProvider)
            MyBase.New(owner, provider)
        End Sub
        Private Function GetFormBorderColor() As Color
            Dim formBorderColor = (TryCast(Owner, ColoredHeaderForm)).FormBorderColor
            Return formBorderColor
        End Function
        Protected Overrides Sub DrawBackground(ByVal cache As GraphicsCache)
            Dim info = GetCaptionInfo()
            Dim ee = TryCast(info, ObjectInfoArgs)
            Dim formBorderColor = GetFormBorderColor()
            cache.FillRectangle(New SolidBrush(formBorderColor), ee.Bounds)
        End Sub
        Protected Overrides Sub DrawFrameCore(ByVal cache As GraphicsCache, ByVal info As SkinElementInfo, ByVal kind As FrameKind)
            Dim formBorderColor = GetFormBorderColor()
            cache.FillRectangle(formBorderColor, info.Bounds)
        End Sub
    End Class
End Namespace
