Partial Public Class MainForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.labelDateTime = New DevExpress.XtraBars.BarStaticItem()
        Me.BarDockingMenuItem1 = New DevExpress.XtraBars.BarDockingMenuItem()
        Me.labelFullName = New DevExpress.XtraBars.BarStaticItem()
        Me.menuUser = New DevExpress.XtraBars.BarButtonItem()
        Me.menuChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.menuStudent = New DevExpress.XtraBars.BarButtonItem()
        Me.menuRelation = New DevExpress.XtraBars.BarButtonItem()
        Me.menuSubject = New DevExpress.XtraBars.BarButtonItem()
        Me.menuClass = New DevExpress.XtraBars.BarButtonItem()
        Me.menuTeacher = New DevExpress.XtraBars.BarButtonItem()
        Me.menuExam = New DevExpress.XtraBars.BarButtonItem()
        Me.menuHoliday = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMapStudentClass = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMapTeacherClassSubject = New DevExpress.XtraBars.BarButtonItem()
        Me.menuExamHeader = New DevExpress.XtraBars.BarButtonItem()
        Me.menuAttendance = New DevExpress.XtraBars.BarButtonItem()
        Me.menuAttendanceState = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpSettings = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.mdiManager = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.nbItemInxox = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbItemSent = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbOutBox = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbNotSend = New DevExpress.XtraNavBar.NavBarItem()
        Me.nbOutGoingMessage = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.Controller = Me.BarAndDockingController1
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.labelDateTime, Me.BarDockingMenuItem1, Me.labelFullName, Me.menuUser, Me.menuChangePassword, Me.menuStudent, Me.menuRelation, Me.menuSubject, Me.menuClass, Me.menuTeacher, Me.menuExam, Me.menuHoliday, Me.menuMapStudentClass, Me.menuMapTeacherClassSubject, Me.menuExamHeader, Me.menuAttendance, Me.menuAttendanceState})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 18
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2, Me.ribbonPage1, Me.rpSettings})
        Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.Size = New System.Drawing.Size(874, 146)
        Me.ribbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 1
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'labelDateTime
        '
        Me.labelDateTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.labelDateTime.Caption = "lblDate"
        Me.labelDateTime.Id = 1
        Me.labelDateTime.Name = "labelDateTime"
        Me.labelDateTime.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarDockingMenuItem1
        '
        Me.BarDockingMenuItem1.Caption = "BarDockingMenuItem1"
        Me.BarDockingMenuItem1.Id = 2
        Me.BarDockingMenuItem1.Name = "BarDockingMenuItem1"
        '
        'labelFullName
        '
        Me.labelFullName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.labelFullName.Caption = "BarStaticItem2"
        Me.labelFullName.Id = 3
        Me.labelFullName.Name = "labelFullName"
        Me.labelFullName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'menuUser
        '
        Me.menuUser.Caption = "User"
        Me.menuUser.Glyph = CType(resources.GetObject("menuUser.Glyph"), System.Drawing.Image)
        Me.menuUser.Id = 4
        Me.menuUser.LargeGlyph = CType(resources.GetObject("menuUser.LargeGlyph"), System.Drawing.Image)
        Me.menuUser.Name = "menuUser"
        '
        'menuChangePassword
        '
        Me.menuChangePassword.Caption = "Change Password"
        Me.menuChangePassword.Glyph = CType(resources.GetObject("menuChangePassword.Glyph"), System.Drawing.Image)
        Me.menuChangePassword.Id = 5
        Me.menuChangePassword.LargeGlyph = CType(resources.GetObject("menuChangePassword.LargeGlyph"), System.Drawing.Image)
        Me.menuChangePassword.Name = "menuChangePassword"
        '
        'menuStudent
        '
        Me.menuStudent.Caption = "Student "
        Me.menuStudent.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.student
        Me.menuStudent.Id = 6
        Me.menuStudent.LargeGlyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.student__1_
        Me.menuStudent.Name = "menuStudent"
        Me.menuStudent.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuRelation
        '
        Me.menuRelation.Caption = "Relation"
        Me.menuRelation.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.users_relation
        Me.menuRelation.Id = 7
        Me.menuRelation.LargeGlyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.Relationship_icon
        Me.menuRelation.Name = "menuRelation"
        '
        'menuSubject
        '
        Me.menuSubject.Caption = "Subject"
        Me.menuSubject.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.iprocrastinate_icon
        Me.menuSubject.Id = 8
        Me.menuSubject.Name = "menuSubject"
        Me.menuSubject.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuClass
        '
        Me.menuClass.Caption = "Class"
        Me.menuClass.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources._128165808084466705classroom_svg_hi
        Me.menuClass.Id = 9
        Me.menuClass.Name = "menuClass"
        Me.menuClass.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuTeacher
        '
        Me.menuTeacher.Caption = "Teacher"
        Me.menuTeacher.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.Teacher_icon
        Me.menuTeacher.Id = 10
        Me.menuTeacher.Name = "menuTeacher"
        Me.menuTeacher.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuExam
        '
        Me.menuExam.Caption = "Exam"
        Me.menuExam.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.exam
        Me.menuExam.Id = 11
        Me.menuExam.Name = "menuExam"
        Me.menuExam.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuHoliday
        '
        Me.menuHoliday.Caption = "Off Day"
        Me.menuHoliday.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.holiday_travel_icon_png_22
        Me.menuHoliday.Id = 12
        Me.menuHoliday.Name = "menuHoliday"
        Me.menuHoliday.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuMapStudentClass
        '
        Me.menuMapStudentClass.Caption = "Map Student - Class"
        Me.menuMapStudentClass.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.links_icon_7
        Me.menuMapStudentClass.Id = 13
        Me.menuMapStudentClass.Name = "menuMapStudentClass"
        Me.menuMapStudentClass.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuMapTeacherClassSubject
        '
        Me.menuMapTeacherClassSubject.Caption = "Map Teacher Class Subject"
        Me.menuMapTeacherClassSubject.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.links_icon_71
        Me.menuMapTeacherClassSubject.Id = 14
        Me.menuMapTeacherClassSubject.Name = "menuMapTeacherClassSubject"
        Me.menuMapTeacherClassSubject.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuExamHeader
        '
        Me.menuExamHeader.Caption = "Exam Header"
        Me.menuExamHeader.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.exam__1_
        Me.menuExamHeader.Id = 15
        Me.menuExamHeader.Name = "menuExamHeader"
        Me.menuExamHeader.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuAttendance
        '
        Me.menuAttendance.Caption = "Attendance List"
        Me.menuAttendance.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.unnamed
        Me.menuAttendance.Id = 16
        Me.menuAttendance.Name = "menuAttendance"
        Me.menuAttendance.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'menuAttendanceState
        '
        Me.menuAttendanceState.Caption = "Attendance State"
        Me.menuAttendanceState.Glyph = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.setting
        Me.menuAttendanceState.Id = 17
        Me.menuAttendanceState.Name = "menuAttendanceState"
        Me.menuAttendanceState.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Data"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuStudent)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.menuRelation)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Student Properties"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuSubject)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuClass)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuTeacher)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuExam)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuAttendanceState)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.menuHoliday)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "School Properties"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.menuMapStudentClass)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.menuMapTeacherClassSubject)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Mapping"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup6})
        Me.ribbonPage1.KeyTip = "R"
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Activity"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.menuExamHeader)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Exam"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.menuAttendance)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Attendance"
        '
        'rpSettings
        '
        Me.rpSettings.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.rpSettings.Image = CType(resources.GetObject("rpSettings.Image"), System.Drawing.Image)
        Me.rpSettings.KeyTip = "S"
        Me.rpSettings.Name = "rpSettings"
        Me.rpSettings.Text = "Settings"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.labelFullName)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.labelDateTime)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 585)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.ribbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(874, 31)
        '
        'mdiManager
        '
        Me.mdiManager.Controller = Me.BarAndDockingController1
        Me.mdiManager.MdiParent = Me
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.nbItemInxox, Me.nbItemSent, Me.nbOutBox, Me.nbNotSend, Me.nbOutGoingMessage})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 146)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 140
        Me.NavBarControl1.Size = New System.Drawing.Size(140, 439)
        Me.NavBarControl1.TabIndex = 3
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Message"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.nbItemInxox), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbItemSent), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbOutBox), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbNotSend), New DevExpress.XtraNavBar.NavBarItemLink(Me.nbOutGoingMessage)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'nbItemInxox
        '
        Me.nbItemInxox.Caption = "Inbox"
        Me.nbItemInxox.Name = "nbItemInxox"
        Me.nbItemInxox.SmallImage = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.download__1_
        Me.nbItemInxox.SmallImageSize = New System.Drawing.Size(20, 20)
        '
        'nbItemSent
        '
        Me.nbItemSent.Caption = "Sent"
        Me.nbItemSent.Name = "nbItemSent"
        Me.nbItemSent.SmallImage = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_12_Mail_message_send
        Me.nbItemSent.SmallImageSize = New System.Drawing.Size(20, 20)
        '
        'nbOutBox
        '
        Me.nbOutBox.Caption = "Out Box"
        Me.nbOutBox.Name = "nbOutBox"
        Me.nbOutBox.SmallImage = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.outbox
        Me.nbOutBox.SmallImageSize = New System.Drawing.Size(20, 20)
        '
        'nbNotSend
        '
        Me.nbNotSend.Caption = "Failed"
        Me.nbNotSend.LargeImageSize = New System.Drawing.Size(16, 16)
        Me.nbNotSend.Name = "nbNotSend"
        Me.nbNotSend.SmallImage = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.asdasda
        Me.nbNotSend.SmallImageSize = New System.Drawing.Size(20, 16)
        '
        'nbOutGoingMessage
        '
        Me.nbOutGoingMessage.Caption = "Outgoing"
        Me.nbOutGoingMessage.Name = "nbOutGoingMessage"
        Me.nbOutGoingMessage.SmallImage = Global.ScoresAttendanceSMSGateway.My.Resources.Resources.outbox1
        Me.nbOutGoingMessage.SmallImageSize = New System.Drawing.Size(20, 20)
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Caption = "List"
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'MainForm
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 616)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Ribbon = Me.ribbonControl1
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mdiManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents rpSettings As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents labelDateTime As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemTextEdit1 As Repository.RepositoryItemTextEdit
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents mdiManager As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents tmrMain As Timer
    Friend WithEvents BarDockingMenuItem1 As DevExpress.XtraBars.BarDockingMenuItem
    Public WithEvents labelFullName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents menuUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuChangePassword As XtraBars.BarButtonItem
    Friend WithEvents menuStudent As XtraBars.BarButtonItem
    Friend WithEvents menuRelation As XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuSubject As XtraBars.BarButtonItem
    Friend WithEvents menuClass As XtraBars.BarButtonItem
    Friend WithEvents menuTeacher As XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuExam As XtraBars.BarButtonItem
    Friend WithEvents menuHoliday As XtraBars.BarButtonItem
    Friend WithEvents menuMapStudentClass As XtraBars.BarButtonItem
    Friend WithEvents menuMapTeacherClassSubject As XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuExamHeader As XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuAttendance As XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menuAttendanceState As XtraBars.BarButtonItem
    Friend WithEvents NavBarControl1 As XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As XtraNavBar.NavBarGroup
    Friend WithEvents nbItemInxox As XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup2 As XtraNavBar.NavBarGroup
    Friend WithEvents nbItemSent As XtraNavBar.NavBarItem
    Friend WithEvents nbOutBox As XtraNavBar.NavBarItem
    Friend WithEvents nbNotSend As XtraNavBar.NavBarItem
    Friend WithEvents nbOutGoingMessage As XtraNavBar.NavBarItem
End Class
