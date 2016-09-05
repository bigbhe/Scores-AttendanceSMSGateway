<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMessageSending
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMessageSending))
        Me.DataSetMessage = New ScoresAttendanceSMSGateway.DataSetMessage()
        Me.OzekimessageoutSendingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OzekimessageoutSendingTableAdapter = New ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.ozekimessageoutSendingTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.TableAdapterManager()
        Me.OzekimessageoutSendingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OzekimessageoutSendingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OzekimessageoutSendingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colreceiver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmsg = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzekimessageoutSendingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzekimessageoutSendingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OzekimessageoutSendingBindingNavigator.SuspendLayout()
        CType(Me.OzekimessageoutSendingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetMessage
        '
        Me.DataSetMessage.DataSetName = "DataSetMessage"
        Me.DataSetMessage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OzekimessageoutSendingBindingSource
        '
        Me.OzekimessageoutSendingBindingSource.DataMember = "ozekimessageoutSending"
        Me.OzekimessageoutSendingBindingSource.DataSource = Me.DataSetMessage
        '
        'OzekimessageoutSendingTableAdapter
        '
        Me.OzekimessageoutSendingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ozekimessageoutFailedTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OzekimessageoutSendingBindingNavigator
        '
        Me.OzekimessageoutSendingBindingNavigator.AddNewItem = Nothing
        Me.OzekimessageoutSendingBindingNavigator.BindingSource = Me.OzekimessageoutSendingBindingSource
        Me.OzekimessageoutSendingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OzekimessageoutSendingBindingNavigator.DeleteItem = Nothing
        Me.OzekimessageoutSendingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.OzekimessageoutSendingBindingNavigatorSaveItem})
        Me.OzekimessageoutSendingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OzekimessageoutSendingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OzekimessageoutSendingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OzekimessageoutSendingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OzekimessageoutSendingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OzekimessageoutSendingBindingNavigator.Name = "OzekimessageoutSendingBindingNavigator"
        Me.OzekimessageoutSendingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OzekimessageoutSendingBindingNavigator.Size = New System.Drawing.Size(586, 25)
        Me.OzekimessageoutSendingBindingNavigator.TabIndex = 0
        Me.OzekimessageoutSendingBindingNavigator.Text = "BindingNavigator1"
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
        'OzekimessageoutSendingBindingNavigatorSaveItem
        '
        Me.OzekimessageoutSendingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OzekimessageoutSendingBindingNavigatorSaveItem.Enabled = False
        Me.OzekimessageoutSendingBindingNavigatorSaveItem.Image = CType(resources.GetObject("OzekimessageoutSendingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OzekimessageoutSendingBindingNavigatorSaveItem.Name = "OzekimessageoutSendingBindingNavigatorSaveItem"
        Me.OzekimessageoutSendingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OzekimessageoutSendingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OzekimessageoutSendingGridControl
        '
        Me.OzekimessageoutSendingGridControl.DataSource = Me.OzekimessageoutSendingBindingSource
        Me.OzekimessageoutSendingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OzekimessageoutSendingGridControl.Location = New System.Drawing.Point(0, 25)
        Me.OzekimessageoutSendingGridControl.MainView = Me.GridView1
        Me.OzekimessageoutSendingGridControl.Name = "OzekimessageoutSendingGridControl"
        Me.OzekimessageoutSendingGridControl.Size = New System.Drawing.Size(586, 500)
        Me.OzekimessageoutSendingGridControl.TabIndex = 1
        Me.OzekimessageoutSendingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsender, Me.colreceiver, Me.colmsg})
        Me.GridView1.GridControl = Me.OzekimessageoutSendingGridControl
        Me.GridView1.Name = "GridView1"
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
        'FormMessageSending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 525)
        Me.Controls.Add(Me.OzekimessageoutSendingGridControl)
        Me.Controls.Add(Me.OzekimessageoutSendingBindingNavigator)
        Me.Name = "FormMessageSending"
        Me.Text = "FormMessageSending"
        CType(Me.DataSetMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzekimessageoutSendingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzekimessageoutSendingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OzekimessageoutSendingBindingNavigator.ResumeLayout(False)
        Me.OzekimessageoutSendingBindingNavigator.PerformLayout()
        CType(Me.OzekimessageoutSendingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetMessage As DataSetMessage
    Friend WithEvents OzekimessageoutSendingBindingSource As BindingSource
    Friend WithEvents OzekimessageoutSendingTableAdapter As DataSetMessageTableAdapters.ozekimessageoutSendingTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMessageTableAdapters.TableAdapterManager
    Friend WithEvents OzekimessageoutSendingBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OzekimessageoutSendingBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OzekimessageoutSendingGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colsender As XtraGrid.Columns.GridColumn
    Friend WithEvents colreceiver As XtraGrid.Columns.GridColumn
    Friend WithEvents colmsg As XtraGrid.Columns.GridColumn
End Class
