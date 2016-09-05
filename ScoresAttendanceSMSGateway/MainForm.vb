Imports System.ComponentModel
Imports System.Text


Partial Public Class MainForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = My.Settings.Skins
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FormLogin.ShowDialog()

    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        labelDateTime.Caption = Format(Now, "HH:mm:ss") + vbCrLf + Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub menuUser_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuUser.ItemClick
        Dim newForm As New FormUser
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If
    End Sub

    Private Sub menuChangePassword_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuChangePassword.ItemClick
        FormChangePassword.ShowDialog()

    End Sub

    Private Sub menuStudent_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuStudent.ItemClick
        Dim newForm As New FormStudents
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If

    End Sub

    Private Sub menuRelation_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuRelation.ItemClick
        FormRelation.ShowDialog()
    End Sub

    Private Sub menuClass_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuClass.ItemClick
        FormClass.ShowDialog()

    End Sub

    Private Sub menuSubject_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuSubject.ItemClick
        FormSubject.ShowDialog()

    End Sub

    Private Sub menuHoliday_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuHoliday.ItemClick
        Dim newForm As New FormHoliday
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If
    End Sub

    Private Sub menuExam_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuExam.ItemClick
        Dim newForm As New FormExam
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If
    End Sub

    Private Sub menuTeacher_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuTeacher.ItemClick
        Dim newForm As New FormTeacher
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If
    End Sub

    Private Sub menuMapStudentClass_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMapStudentClass.ItemClick
        FormMappingStudentClass.ShowDialog()

    End Sub

    Private Sub menuMapTeacherClassSubject_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMapTeacherClassSubject.ItemClick

        Dim newForm As New FormMappingTeacherClassSubject
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If
    End Sub

    Private Sub menuExamHeader_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuExamHeader.ItemClick
        Dim newForm As New FormExamHeader
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If
    End Sub

    Private Sub menuAttendance_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuAttendance.ItemClick
        Dim newForm As New FormAttendanceList
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If
    End Sub

    Private Sub menuAttendanceState_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuAttendanceState.ItemClick

        Dim newForm As New FormAttendanceState
        If Me.MdiChildren.Contains(newForm) Then
            newForm.Focus()
        Else
            newForm.MdiParent = Me
            newForm.Show()
        End If
    End Sub
End Class
