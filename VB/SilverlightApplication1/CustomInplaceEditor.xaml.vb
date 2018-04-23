Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Scheduler
Imports DevExpress.Xpf.Scheduler.UI
Imports DevExpress.XtraScheduler

#Region "#AppointmentInplaceEditorBase"
Partial Public Class CustomInplaceEditor
    Inherits AppointmentInplaceEditorBase
    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
        MyBase.New(control, apt)
        InitializeComponent()
    End Sub

    Private Sub OK_button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        OnCommitChanges()
    End Sub

    Private Sub Cancel_button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        OnRollbackChanges()
    End Sub

End Class
#End Region
