Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Scheduler

Partial Public Class MainPage
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub

#Region "#InplaceEditorShowing"
    Private Sub schedulerControl1_InplaceEditorShowing(ByVal sender As Object, ByVal e As InplaceEditorEventArgs)
        Dim editor As New CustomInplaceEditor(Me.schedulerControl1, e.Appointment)
        e.InplaceEditor = editor
        editor.DataContext = editor
        Dim location As New Point(e.Bounds.Right, e.Bounds.Top)
        e.Bounds = New Rect(location, New Size(editor.Width, editor.Height))
    End Sub
#End Region
End Class
