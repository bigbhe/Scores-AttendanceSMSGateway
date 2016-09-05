<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSentMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSentMessage))
        Me.DataSetMessage = New ScoresAttendanceSMSGateway.DataSetMessage()
        Me.OzekimessageoutSentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OzekimessageoutSentTableAdapter = New ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.ozekimessageoutSentTableAdapter()
        Me.TableAdapterManager = New ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.TableAdapterManager()
        Me.OzekimessageoutSentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OzekimessageoutSentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.OzekimessageoutSentGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colreceiver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colmsg = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.DataSetMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzekimessageoutSentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OzekimessageoutSentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OzekimessageoutSentBindingNavigator.SuspendLayout()
        CType(Me.OzekimessageoutSentGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetMessage
        '
        Me.DataSetMessage.DataSetName = "DataSetMessage"
        Me.DataSetMessage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OzekimessageoutSentBindingSource
        '
        Me.OzekimessageoutSentBindingSource.DataMember = "ozekimessageoutSent"
        Me.OzekimessageoutSentBindingSource.DataSource = Me.DataSetMessage
        '
        'OzekimessageoutSentTableAdapter
        '
        Me.OzekimessageoutSentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ozekimessageoutFailedTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScoresAttendanceSMSGateway.DataSetMessageTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OzekimessageoutSentBindingNavigator
        '
        Me.OzekimessageoutSentBindingNavigator.AddNewItem = Nothing
        Me.OzekimessageoutSentBindingNavigator.BindingSource = Me.OzekimessageoutSentBindingSource
        Me.OzekimessageoutSentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OzekimessageoutSentBindingNavigator.DeleteItem = Nothing
        Me.OzekimessageoutSentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.OzekimessageoutSentBindingNavigatorSaveItem})
        Me.OzekimessageoutSentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OzekimessageoutSentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OzekimessageoutSentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OzekimessageoutSentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OzekimessageoutSentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OzekimessageoutSentBindingNavigator.Name = "OzekimessageoutSentBindingNavigator"
        Me.OzekimessageoutSentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OzekimessageoutSentBindingNavigator.Size = New System.Drawing.Size(774, 25)
        Me.OzekimessageoutSentBindingNavigator.TabIndex = 0
        Me.OzekimessageoutSentBindingNavigator.Text = "BindingNavigator1"
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
        'OzekimessageoutSentBindingNavigatorSaveItem
        '
        Me.OzekimessageoutSentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OzekimessageoutSentBindingNavigatorSaveItem.Enabled = False
        Me.OzekimessageoutSentBindingNavigatorSaveItem.Image = CType(resources.GetObject("OzekimessageoutSentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OzekimessageoutSentBindingNavigatorSaveItem.Name = "OzekimessageoutSentBindingNavigatorSaveItem"
        Me.OzekimessageoutSentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OzekimessageoutSentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'OzekimessageoutSentGridControl
        '
        Me.OzekimessageoutSentGridControl.DataSource = Me.OzekimessageoutSentBindingSource
        Me.OzekimessageoutSentGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OzekimessageoutSentGridControl.Location = New System.Drawing.Point(0, 25)
        Me.OzekimessageoutSentGridControl.MainView = Me.GridView1
        Me.OzekimessageoutSentGridControl.Name = "OzekimessageoutSentGridControl"
        Me.OzekimessageoutSentGridControl.Size = New System.Drawing.Size(774, 486)
        Me.OzekimessageoutSentGridControl.TabIndex = 1
        Me.OzekimessageoutSentGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsender, Me.colreceiver, Me.colmsg})
        Me.GridView1.GridControl = Me.OzekimessageoutSentGridControl
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
        'FormSentMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 511)
        Me.Controls.Add(Me.OzekimessageoutSentGridControl)
        Me.Controls.Add(Me.OzekimessageoutSentBindingNavigator)
        Me.Name = "FormSentMessage"
        Me.Text = "FormSentMessage"
        CType(Me.DataSetMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzekimessageoutSentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OzekimessageoutSentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OzekimessageoutSentBindingNavigator.ResumeLayout(False)
        Me.OzekimessageoutSentBindingNavigator.PerformLayout()
        CType(Me.OzekimessageoutSentGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetMessage As DataSetMessage
    Friend WithEvents OzekimessageoutSentBindingSource As BindingSource
    Friend WithEvents OzekimessageoutSentTableAdapter As DataSetMessageTableAdapters.ozekimessageoutSentTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMessageTableAdapters.TableAdapterManager
    Friend WithEvents OzekimessageoutSentBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OzekimessageoutSentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents OzekimessageoutSentGridControl As XtraGrid.GridControl
    Friend WithEvents GridView1 As XtraGrid.Views.Grid.GridView
    Friend WithEvents colsender As XtraGrid.Columns.GridColumn
    Friend WithEvents colreceiver As XtraGrid.Columns.GridColumn
    Friend WithEvents colmsg As XtraGrid.Columns.GridColumn
End Class
