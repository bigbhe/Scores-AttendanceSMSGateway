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
        'Dim newForm As New FormUser
        If Me.MdiChildren.Contains(FormUser) Then
            FormUser.Focus()
        Else
            FormUser.MdiParent = Me
            FormUser.Show()
        End If
    End Sub

    Private Sub menuChangePassword_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuChangePassword.ItemClick
        FormChangePassword.ShowDialog()

    End Sub

    Private Sub menuStudent_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuStudent.ItemClick
        'Dim newForm As New FormStudents
        If Me.MdiChildren.Contains(FormStudents) Then
            FormStudents.Focus()
        Else
            FormStudents.MdiParent = Me
            FormStudents.Show()
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
        'Dim newForm As New FormHoliday
        If Me.MdiChildren.Contains(FormHoliday) Then
            FormHoliday.Focus()
        Else
            FormHoliday.MdiParent = Me
            FormHoliday.Show()
        End If
    End Sub

    Private Sub menuExam_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuExam.ItemClick
        'Dim newForm As New FormExam
        If Me.MdiChildren.Contains(FormExam) Then
            FormExam.Focus()
        Else
            FormExam.MdiParent = Me
            FormExam.Show()
        End If
    End Sub

    Private Sub menuTeacher_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuTeacher.ItemClick
        'Dim newForm As New FormTeacher
        If Me.MdiChildren.Contains(FormTeacher) Then
            FormTeacher.Focus()
        Else
            FormTeacher.MdiParent = Me
            FormTeacher.Show()
        End If
    End Sub

    Private Sub menuMapStudentClass_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMapStudentClass.ItemClick
        FormMappingStudentClass.ShowDialog()

    End Sub

    Private Sub menuMapTeacherClassSubject_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuMapTeacherClassSubject.ItemClick

        'Dim newForm As New FormMappingTeacherClassSubject
        If Me.MdiChildren.Contains(FormMappingTeacherClassSubject) Then
            FormMappingTeacherClassSubject.Focus()
        Else
            FormMappingTeacherClassSubject.MdiParent = Me
            FormMappingTeacherClassSubject.Show()
        End If
    End Sub

    Private Sub menuExamHeader_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuExamHeader.ItemClick
        'Dim newForm As New FormExamHeader
        If Me.MdiChildren.Contains(FormExamHeader) Then
            FormExamHeader.Focus()
        Else
            FormExamHeader.MdiParent = Me
            FormExamHeader.Show()
        End If
    End Sub

    Private Sub menuAttendance_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuAttendance.ItemClick
        'Dim newForm As New FormAttendanceList
        If Me.MdiChildren.Contains(FormAttendanceList) Then
            FormAttendanceList.Focus()
        Else
            FormAttendanceList.MdiParent = Me
            FormAttendanceList.Show()
        End If
    End Sub

    Private Sub menuAttendanceState_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles menuAttendanceState.ItemClick

        'Dim newForm As New FormAttendanceState
        If Me.MdiChildren.Contains(FormAttendanceState) Then
            FormAttendanceState.Focus()
        Else
            FormAttendanceState.MdiParent = Me
            FormAttendanceState.Show()
        End If
    End Sub

    Private Sub nbItemInxox_LinkClicked(sender As Object, e As XtraNavBar.NavBarLinkEventArgs) Handles nbItemInxox.LinkClicked
        'Dim newForm As New FormInbox
        If Me.MdiChildren.Contains(FormInbox) Then
            FormInbox.Focus()
        Else
            FormInbox.MdiParent = Me
            FormInbox.Show()
        End If
    End Sub

    Private Sub nbOutBox_LinkClicked(sender As Object, e As XtraNavBar.NavBarLinkEventArgs) Handles nbOutBox.LinkClicked
        'Dim newForm As New FormSendMessage
        If Me.MdiChildren.Contains(FormSendMessage) Then
            FormSendMessage.Focus()
        Else
            FormSendMessage.MdiParent = Me
            FormSendMessage.Show()
        End If
    End Sub

    Private Sub nbNotSend_LinkClicked(sender As Object, e As XtraNavBar.NavBarLinkEventArgs) Handles nbNotSend.LinkClicked
        If Me.MdiChildren.Contains(FormFailedToSend) Then
            FormFailedToSend.Focus()
        Else
            FormFailedToSend.MdiParent = Me
            FormFailedToSend.Show()
        End If
    End Sub

    Private Sub nbItemSent_LinkClicked(sender As Object, e As XtraNavBar.NavBarLinkEventArgs) Handles nbItemSent.LinkClicked
        'Dim newForm As New FormSentMessage
        If Me.MdiChildren.Contains(FormSentMessage) Then
            FormSentMessage.Focus()
        Else
            FormSentMessage.MdiParent = Me
            FormSentMessage.Show()
        End If
    End Sub

    Private Sub nbOutGoingMessage_LinkClicked(sender As Object, e As XtraNavBar.NavBarLinkEventArgs) Handles nbOutGoingMessage.LinkClicked
        If Me.MdiChildren.Contains(FormMessageSending) Then
            FormMessageSending.Focus()
        Else
            FormMessageSending.MdiParent = Me
            FormMessageSending.Show()
        End If
    End Sub
End Class
