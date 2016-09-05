<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInbox
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInbox))
        Me.DataSetMessage = New ScoresAttendanceSMSGateway.DataSetMessage()
        Me.OzekimessageinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OzekimessageinTableAdapter = New ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.ozekimessageinTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.TableAdapterManager()
        Me.OzekimessageinBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OzekimessageinBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OzekimessageinGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colreceiver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmsg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsenttime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colreceivedtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coloperator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmsgtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colreference = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzekimessageinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzekimessageinBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OzekimessageinBindingNavigator.SuspendLayout()
        CType(Me.OzekimessageinGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetMessage
        '
        Me.DataSetMessage.DataSetName = "DataSetMessage"
        Me.DataSetMessage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OzekimessageinBindingSource
        '
        Me.OzekimessageinBindingSource.DataMember = "ozekimessagein"
        Me.OzekimessageinBindingSource.DataSource = Me.DataSetMessage
        '
        'OzekimessageinTableAdapter
        '
        Me.OzekimessageinTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ozekimessageoutFailedTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OzekimessageinBindingNavigator
        '
        Me.OzekimessageinBindingNavigator.AddNewItem = Nothing
        Me.OzekimessageinBindingNavigator.BindingSource = Me.OzekimessageinBindingSource
        Me.OzekimessageinBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OzekimessageinBindingNavigator.DeleteItem = Nothing
        Me.OzekimessageinBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.OzekimessageinBindingNavigatorSaveItem})
        Me.OzekimessageinBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OzekimessageinBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OzekimessageinBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OzekimessageinBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OzekimessageinBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OzekimessageinBindingNavigator.Name = "OzekimessageinBindingNavigator"
        Me.OzekimessageinBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OzekimessageinBindingNavigator.Size = New System.Drawing.Size(773, 25)
        Me.OzekimessageinBindingNavigator.TabIndex = 0
        Me.OzekimessageinBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'OzekimessageinBindingNavigatorSaveItem
        '
        Me.OzekimessageinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OzekimessageinBindingNavigatorSaveItem.Enabled = False
        Me.OzekimessageinBindingNavigatorSaveItem.Image = CType(resources.GetObject("OzekimessageinBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OzekimessageinBindingNavigatorSaveItem.Name = "OzekimessageinBindingNavigatorSaveItem"
        Me.OzekimessageinBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OzekimessageinBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OzekimessageinGridControl
        '
        Me.OzekimessageinGridControl.DataSource = Me.OzekimessageinBindingSource
        Me.OzekimessageinGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OzekimessageinGridControl.Location = New System.Drawing.Point(0, 25)
        Me.OzekimessageinGridControl.MainView = Me.GridView1
        Me.OzekimessageinGridControl.Name = "OzekimessageinGridControl"
        Me.OzekimessageinGridControl.Size = New System.Drawing.Size(773, 489)
        Me.OzekimessageinGridControl.TabIndex = 1
        Me.OzekimessageinGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colsender, Me.colreceiver, Me.colmsg, Me.colsenttime, Me.colreceivedtime, Me.coloperator, Me.colmsgtype, Me.colreference})
        Me.GridView1.GridControl = Me.OzekimessageinGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colsender
        '
        Me.colsender.FieldName = "sender"
        Me.colsender.Name = "colsender"
        Me.colsender.Visible = True
        Me.colsender.VisibleIndex = 0
        '
        'colreceiver
        '
        Me.colreceiver.FieldName = "receiver"
        Me.colreceiver.Name = "colreceiver"
        Me.colreceiver.Visible = True
        Me.colreceiver.VisibleIndex = 1
        '
        'colmsg
        '
        Me.colmsg.FieldName = "msg"
        Me.colmsg.Name = "colmsg"
        Me.colmsg.Visible = True
        Me.colmsg.VisibleIndex = 2
        '
        'colsenttime
        '
        Me.colsenttime.FieldName = "senttime"
        Me.colsenttime.Name = "colsenttime"
        Me.colsenttime.Visible = True
        Me.colsenttime.VisibleIndex = 3
        '
        'colreceivedtime
        '
        Me.colreceivedtime.FieldName = "receivedtime"
        Me.colreceivedtime.Name = "colreceivedtime"
        Me.colreceivedtime.Visible = True
        Me.colreceivedtime.VisibleIndex = 4
        '
        'coloperator
        '
        Me.coloperator.FieldName = "operator"
        Me.coloperator.Name = "coloperator"
        '
        'colmsgtype
        '
        Me.colmsgtype.FieldName = "msgtype"
        Me.colmsgtype.Name = "colmsgtype"
        '
        'colreference
        '
        Me.colreference.FieldName = "reference"
        Me.colreference.Name = "colreference"
        '
        'FormInbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 514)
        Me.Controls.Add(Me.OzekimessageinGridControl)
        Me.Controls.Add(Me.OzekimessageinBindingNavigator)
        Me.Name = "FormInbox"
        Me.Text = "FormInbox"
        CType(Me.DataSetMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzekimessageinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzekimessageinBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OzekimessageinBindingNavigator.ResumeLayout(False)
        Me.OzekimessageinBindingNavigator.PerformLayout()
        CType(Me.OzekimessageinGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetMessage As DataSetMessage
    Friend WithEvents OzekimessageinBindingSource As BindingSource
    Friend WithEvents OzekimessageinTableAdapter As DataSetMessageTableAdapters.ozekimessageinTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMessageTableAdapters.TableAdapterManager
    Friend WithEvents OzekimessageinBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OzekimessageinBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OzekimessageinGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As XtraGrid.Columns.GridColumn
    Friend WithEvents colsender As XtraGrid.Columns.GridColumn
    Friend WithEvents colreceiver As XtraGrid.Columns.GridColumn
    Friend WithEvents colmsg As XtraGrid.Columns.GridColumn
    Friend WithEvents colsenttime As XtraGrid.Columns.GridColumn
    Friend WithEvents colreceivedtime As XtraGrid.Columns.GridColumn
    Friend WithEvents coloperator As XtraGrid.Columns.GridColumn
    Friend WithEvents colmsgtype As XtraGrid.Columns.GridColumn
    Friend WithEvents colreference As XtraGrid.Columns.GridColumn
End Class
