Imports System.Data.SqlClient

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmbDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents NicePanel1 As PureComponents.NicePanel.NicePanel
    Friend WithEvents NicePanel2 As PureComponents.NicePanel.NicePanel
    Friend WithEvents NicePanel3 As PureComponents.NicePanel.NicePanel
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents NicePanel4 As PureComponents.NicePanel.NicePanel
    Friend WithEvents rbWindows As System.Windows.Forms.RadioButton
    Friend WithEvents rbSQL As System.Windows.Forms.RadioButton
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents NicePanel5 As PureComponents.NicePanel.NicePanel
    Friend WithEvents lstTables As System.Windows.Forms.ListBox
    Friend WithEvents NicePanel6 As PureComponents.NicePanel.NicePanel
    Friend WithEvents btnOneRight As System.Windows.Forms.Button
    Friend WithEvents btnAllRight As System.Windows.Forms.Button
    Friend WithEvents btnOneLeft As System.Windows.Forms.Button
    Friend WithEvents btnAllLeft As System.Windows.Forms.Button
    Friend WithEvents lstTableFields As System.Windows.Forms.ListBox
    Friend WithEvents lstSelectFields As System.Windows.Forms.ListBox
    Friend WithEvents btnAsagi As System.Windows.Forms.Button
    Friend WithEvents btnYukari As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dgwQueryResult As System.Windows.Forms.DataGridView
    Friend WithEvents btnQueryExecute As System.Windows.Forms.Button
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents btnCopySelectField As System.Windows.Forms.Button
    Friend WithEvents btnCopyTableField As System.Windows.Forms.Button
    Friend WithEvents btnCopyTableName As System.Windows.Forms.Button
    Friend WithEvents lblStatusQuery As System.Windows.Forms.Label
    Friend WithEvents picStatusQuery As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateXMLFromTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateTableFromXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StoredProcedureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateLoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterLoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DropLoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DropUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateRoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterRoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DropRoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddRoleMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRoleMemberToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddServerRoleMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DropRoleMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DropServerRoleMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrantUserToRoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevokeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DenyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DropTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DropDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultLanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditColumnDataTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddingAColumnWithAConstraintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddingCheckConstraintAoAnExistingColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddingADefaultConstraintToAnExistingColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddingForeignKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConstraintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteForeignKeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddOrModifyFilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddingAFileToADatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovingAFileFromADatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyingAFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogFileBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullBackupToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifferentialBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoRecoveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithRecoveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RestoreLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoRecoveryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WithRecoveryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertUpdateDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OneRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nplWhere As PureComponents.NicePanel.NicePanel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ContainerImage1 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage13 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage14 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle7 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle7 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle13 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle14 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage2 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage1 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage2 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle1 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle1 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle1 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle2 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage3 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage3 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage4 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle2 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle2 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle3 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle4 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ContainerImage4 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage5 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage6 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle3 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle3 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle5 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle6 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage5 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage7 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage8 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle4 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle4 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle7 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle8 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage6 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage9 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage10 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle5 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle5 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle9 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle10 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim ContainerImage7 As PureComponents.NicePanel.ContainerImage = New PureComponents.NicePanel.ContainerImage
        Dim HeaderImage11 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim HeaderImage12 As PureComponents.NicePanel.HeaderImage = New PureComponents.NicePanel.HeaderImage
        Dim PanelStyle6 As PureComponents.NicePanel.PanelStyle = New PureComponents.NicePanel.PanelStyle
        Dim ContainerStyle6 As PureComponents.NicePanel.ContainerStyle = New PureComponents.NicePanel.ContainerStyle
        Dim PanelHeaderStyle11 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Dim PanelHeaderStyle12 As PureComponents.NicePanel.PanelHeaderStyle = New PureComponents.NicePanel.PanelHeaderStyle
        Me.cmbDatabases = New System.Windows.Forms.ComboBox
        Me.NicePanel1 = New PureComponents.NicePanel.NicePanel
        Me.nplWhere = New PureComponents.NicePanel.NicePanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateXMLFromTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateTableFromXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StoredProcedureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DefaultDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DefaultLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.DropLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.DropUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateRoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterRoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.DropRoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.AddRoleMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddRoleMemberToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AddServerRoleMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.DropRoleMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DropServerRoleMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrantUserToRoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GrantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RevokeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DenyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.TableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditColumnDataTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.AddingAColumnWithAConstraintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddingCheckConstraintAoAnExistingColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddingADefaultConstraintToAnExistingColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConstraintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.AddingForeignKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteForeignKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.DropTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlterDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator
        Me.AddOrModifyFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddingAFileToADatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemovingAFileFromADatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyingAFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.DropDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FullBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DiffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogFileBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FullBackupToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DifferentialBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator
        Me.RestoreDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoRecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WithRecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestoreLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoRecoveryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.WithRecoveryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InsertUpdateDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InsertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OneRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblStatusQuery = New System.Windows.Forms.Label
        Me.picStatusQuery = New System.Windows.Forms.PictureBox
        Me.dgwQueryResult = New System.Windows.Forms.DataGridView
        Me.btnCopyTableField = New System.Windows.Forms.Button
        Me.btnCopyTableName = New System.Windows.Forms.Button
        Me.btnCopySelectField = New System.Windows.Forms.Button
        Me.btnQueryExecute = New System.Windows.Forms.Button
        Me.txtQuery = New System.Windows.Forms.TextBox
        Me.NicePanel6 = New PureComponents.NicePanel.NicePanel
        Me.btnOneRight = New System.Windows.Forms.Button
        Me.lstTableFields = New System.Windows.Forms.ListBox
        Me.btnAllRight = New System.Windows.Forms.Button
        Me.btnOneLeft = New System.Windows.Forms.Button
        Me.btnAllLeft = New System.Windows.Forms.Button
        Me.lstSelectFields = New System.Windows.Forms.ListBox
        Me.btnAsagi = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnYukari = New System.Windows.Forms.Button
        Me.NicePanel5 = New PureComponents.NicePanel.NicePanel
        Me.lstTables = New System.Windows.Forms.ListBox
        Me.NicePanel4 = New PureComponents.NicePanel.NicePanel
        Me.rbSQL = New System.Windows.Forms.RadioButton
        Me.rbWindows = New System.Windows.Forms.RadioButton
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.lblUserID = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.NicePanel2 = New PureComponents.NicePanel.NicePanel
        Me.NicePanel3 = New PureComponents.NicePanel.NicePanel
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NicePanel1.SuspendLayout()
        Me.nplWhere.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picStatusQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NicePanel6.SuspendLayout()
        Me.NicePanel5.SuspendLayout()
        Me.NicePanel4.SuspendLayout()
        Me.NicePanel2.SuspendLayout()
        Me.NicePanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbDatabases
        '
        Me.cmbDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDatabases.Location = New System.Drawing.Point(8, 32)
        Me.cmbDatabases.Name = "cmbDatabases"
        Me.cmbDatabases.Size = New System.Drawing.Size(168, 22)
        Me.cmbDatabases.TabIndex = 0
        '
        'NicePanel1
        '
        Me.NicePanel1.BackColor = System.Drawing.Color.Transparent
        Me.NicePanel1.CloseButton = True
        Me.NicePanel1.CollapseButton = False
        ContainerImage1.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage1.Image = Nothing
        ContainerImage1.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage1.Transparency = 50
        Me.NicePanel1.ContainerImage = ContainerImage1
        Me.NicePanel1.ContextMenuButton = False
        Me.NicePanel1.Controls.Add(Me.nplWhere)
        Me.NicePanel1.Controls.Add(Me.NicePanel6)
        Me.NicePanel1.Controls.Add(Me.NicePanel5)
        Me.NicePanel1.Controls.Add(Me.NicePanel4)
        Me.NicePanel1.Controls.Add(Me.NicePanel2)
        Me.NicePanel1.Controls.Add(Me.NicePanel3)
        Me.NicePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        HeaderImage13.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage13.Image = Nothing
        Me.NicePanel1.FooterImage = HeaderImage13
        Me.NicePanel1.FooterText = ""
        Me.NicePanel1.FooterVisible = False
        Me.NicePanel1.ForeColor = System.Drawing.Color.Black
        HeaderImage14.ClipArt = PureComponents.NicePanel.ImageClipArt.Block
        HeaderImage14.Image = Nothing
        Me.NicePanel1.HeaderImage = HeaderImage14
        Me.NicePanel1.HeaderText = "SQL Server 2005 Report Builder & SQL Assistant"
        Me.NicePanel1.IsExpanded = True
        Me.NicePanel1.Location = New System.Drawing.Point(0, 0)
        Me.NicePanel1.MaximizeButton = True
        Me.NicePanel1.MinimizeButton = True
        Me.NicePanel1.MouseMoveTarget = PureComponents.NicePanel.MouseMoveTarget.Form
        Me.NicePanel1.Name = "NicePanel1"
        Me.NicePanel1.OriginalFooterVisible = False
        Me.NicePanel1.OriginalHeight = 0
        Me.NicePanel1.ShowChildFocus = False
        Me.NicePanel1.Size = New System.Drawing.Size(728, 639)
        ContainerStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle7.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle7.BorderStyle = PureComponents.NicePanel.BorderStyle.[Double]
        ContainerStyle7.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Top
        ContainerStyle7.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle7.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalBackward
        ContainerStyle7.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle7.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle7.ForeColor = System.Drawing.Color.Black
        ContainerStyle7.Shape = PureComponents.NicePanel.Shape.Squared
        PanelStyle7.ContainerStyle = ContainerStyle7
        PanelHeaderStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle13.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle13.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle13.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle13.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle13.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle13.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle13.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle7.FooterStyle = PanelHeaderStyle13
        PanelHeaderStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle14.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle14.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle14.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalBackward
        PanelHeaderStyle14.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle14.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle14.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        PanelHeaderStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle14.Size = PureComponents.NicePanel.PanelHeaderSize.Large
        PanelStyle7.HeaderStyle = PanelHeaderStyle14
        Me.NicePanel1.Style = PanelStyle7
        Me.NicePanel1.TabIndex = 1
        '
        'nplWhere
        '
        Me.nplWhere.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nplWhere.BackColor = System.Drawing.Color.Transparent
        ContainerImage2.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage2.Image = Nothing
        ContainerImage2.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage2.Transparency = 50
        Me.nplWhere.ContainerImage = ContainerImage2
        Me.nplWhere.Controls.Add(Me.Panel1)
        Me.nplWhere.Controls.Add(Me.lblStatusQuery)
        Me.nplWhere.Controls.Add(Me.picStatusQuery)
        Me.nplWhere.Controls.Add(Me.dgwQueryResult)
        Me.nplWhere.Controls.Add(Me.btnCopyTableField)
        Me.nplWhere.Controls.Add(Me.btnCopyTableName)
        Me.nplWhere.Controls.Add(Me.btnCopySelectField)
        Me.nplWhere.Controls.Add(Me.btnQueryExecute)
        Me.nplWhere.Controls.Add(Me.txtQuery)
        HeaderImage1.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage1.Image = Nothing
        Me.nplWhere.FooterImage = HeaderImage1
        Me.nplWhere.FooterText = "PureComponents NicePanel for .NET WinForms V1.0."
        Me.nplWhere.FooterVisible = False
        Me.nplWhere.ForeColor = System.Drawing.Color.Black
        HeaderImage2.ClipArt = PureComponents.NicePanel.ImageClipArt.Pencil
        HeaderImage2.Image = Nothing
        Me.nplWhere.HeaderImage = HeaderImage2
        Me.nplWhere.HeaderText = "Query Writing & Execute"
        Me.nplWhere.IsExpanded = True
        Me.nplWhere.Location = New System.Drawing.Point(200, 216)
        Me.nplWhere.Name = "nplWhere"
        Me.nplWhere.OriginalFooterVisible = False
        Me.nplWhere.OriginalHeight = 0
        Me.nplWhere.Size = New System.Drawing.Size(520, 415)
        ContainerStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle1.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle1.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle1.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle1.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle1.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle1.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle1.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle1.ForeColor = System.Drawing.Color.Black
        ContainerStyle1.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle1.ContainerStyle = ContainerStyle1
        PanelHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle1.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle1.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle1.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle1.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle1.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle1.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle1.FooterStyle = PanelHeaderStyle1
        PanelHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle2.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle2.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle2.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle2.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle2.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle2.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        PanelHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle2.Size = PureComponents.NicePanel.PanelHeaderSize.Medium
        PanelStyle1.HeaderStyle = PanelHeaderStyle2
        Me.nplWhere.Style = PanelStyle1
        Me.nplWhere.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(16, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 26)
        Me.Panel1.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StoredProcedureToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(494, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateXMLFromTableToolStripMenuItem, Me.CreateTableFromXMLToolStripMenuItem, Me.ToolStripMenuItem13, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CreateXMLFromTableToolStripMenuItem
        '
        Me.CreateXMLFromTableToolStripMenuItem.Name = "CreateXMLFromTableToolStripMenuItem"
        Me.CreateXMLFromTableToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CreateXMLFromTableToolStripMenuItem.Text = "Create XML From Table"
        '
        'CreateTableFromXMLToolStripMenuItem
        '
        Me.CreateTableFromXMLToolStripMenuItem.Name = "CreateTableFromXMLToolStripMenuItem"
        Me.CreateTableFromXMLToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CreateTableFromXMLToolStripMenuItem.Text = "Create Table From XML"
        '
        'StoredProcedureToolStripMenuItem
        '
        Me.StoredProcedureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.UserToolStripMenuItem, Me.RoleToolStripMenuItem, Me.ToolStripMenuItem7, Me.TableToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.BackupToolStripMenuItem, Me.InsertUpdateDeleteToolStripMenuItem})
        Me.StoredProcedureToolStripMenuItem.Name = "StoredProcedureToolStripMenuItem"
        Me.StoredProcedureToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.StoredProcedureToolStripMenuItem.Text = "Stored Procedures"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateLoginToolStripMenuItem, Me.AlterLoginToolStripMenuItem, Me.ToolStripMenuItem1, Me.DropLoginToolStripMenuItem})
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'CreateLoginToolStripMenuItem
        '
        Me.CreateLoginToolStripMenuItem.Name = "CreateLoginToolStripMenuItem"
        Me.CreateLoginToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.CreateLoginToolStripMenuItem.Text = "Create Login"
        '
        'AlterLoginToolStripMenuItem
        '
        Me.AlterLoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem, Me.PasswordToolStripMenuItem, Me.DefaultDatabaseToolStripMenuItem, Me.DefaultLanguageToolStripMenuItem})
        Me.AlterLoginToolStripMenuItem.Name = "AlterLoginToolStripMenuItem"
        Me.AlterLoginToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AlterLoginToolStripMenuItem.Text = "Alter Login"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NameToolStripMenuItem.Text = "Name"
        '
        'PasswordToolStripMenuItem
        '
        Me.PasswordToolStripMenuItem.Name = "PasswordToolStripMenuItem"
        Me.PasswordToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PasswordToolStripMenuItem.Text = "Password"
        '
        'DefaultDatabaseToolStripMenuItem
        '
        Me.DefaultDatabaseToolStripMenuItem.Name = "DefaultDatabaseToolStripMenuItem"
        Me.DefaultDatabaseToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DefaultDatabaseToolStripMenuItem.Text = "Default Database"
        '
        'DefaultLanguageToolStripMenuItem
        '
        Me.DefaultLanguageToolStripMenuItem.Name = "DefaultLanguageToolStripMenuItem"
        Me.DefaultLanguageToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.DefaultLanguageToolStripMenuItem.Text = "Default Language"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 6)
        '
        'DropLoginToolStripMenuItem
        '
        Me.DropLoginToolStripMenuItem.Name = "DropLoginToolStripMenuItem"
        Me.DropLoginToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.DropLoginToolStripMenuItem.Text = "Drop Login"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateUserToolStripMenuItem, Me.AlterUserToolStripMenuItem, Me.ToolStripMenuItem3, Me.DropUserToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'CreateUserToolStripMenuItem
        '
        Me.CreateUserToolStripMenuItem.Name = "CreateUserToolStripMenuItem"
        Me.CreateUserToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CreateUserToolStripMenuItem.Text = "Create User"
        '
        'AlterUserToolStripMenuItem
        '
        Me.AlterUserToolStripMenuItem.Name = "AlterUserToolStripMenuItem"
        Me.AlterUserToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AlterUserToolStripMenuItem.Text = "Alter User"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(140, 6)
        '
        'DropUserToolStripMenuItem
        '
        Me.DropUserToolStripMenuItem.Name = "DropUserToolStripMenuItem"
        Me.DropUserToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.DropUserToolStripMenuItem.Text = "Drop User"
        '
        'RoleToolStripMenuItem
        '
        Me.RoleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateRoleToolStripMenuItem, Me.AlterRoleToolStripMenuItem, Me.ToolStripMenuItem4, Me.DropRoleToolStripMenuItem, Me.ToolStripMenuItem5, Me.AddRoleMemberToolStripMenuItem, Me.GrantUserToRoleToolStripMenuItem})
        Me.RoleToolStripMenuItem.Name = "RoleToolStripMenuItem"
        Me.RoleToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.RoleToolStripMenuItem.Text = "Role"
        '
        'CreateRoleToolStripMenuItem
        '
        Me.CreateRoleToolStripMenuItem.Name = "CreateRoleToolStripMenuItem"
        Me.CreateRoleToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CreateRoleToolStripMenuItem.Text = "Create Role"
        '
        'AlterRoleToolStripMenuItem
        '
        Me.AlterRoleToolStripMenuItem.Name = "AlterRoleToolStripMenuItem"
        Me.AlterRoleToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AlterRoleToolStripMenuItem.Text = "Alter Role"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(173, 6)
        '
        'DropRoleToolStripMenuItem
        '
        Me.DropRoleToolStripMenuItem.Name = "DropRoleToolStripMenuItem"
        Me.DropRoleToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.DropRoleToolStripMenuItem.Text = "Drop Role"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(173, 6)
        '
        'AddRoleMemberToolStripMenuItem
        '
        Me.AddRoleMemberToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRoleMemberToolStripMenuItem1, Me.AddServerRoleMemberToolStripMenuItem, Me.ToolStripMenuItem6, Me.DropRoleMemberToolStripMenuItem, Me.DropServerRoleMemberToolStripMenuItem})
        Me.AddRoleMemberToolStripMenuItem.Name = "AddRoleMemberToolStripMenuItem"
        Me.AddRoleMemberToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.AddRoleMemberToolStripMenuItem.Text = "Role Member"
        '
        'AddRoleMemberToolStripMenuItem1
        '
        Me.AddRoleMemberToolStripMenuItem1.Name = "AddRoleMemberToolStripMenuItem1"
        Me.AddRoleMemberToolStripMenuItem1.Size = New System.Drawing.Size(208, 22)
        Me.AddRoleMemberToolStripMenuItem1.Text = "Add Role Member"
        '
        'AddServerRoleMemberToolStripMenuItem
        '
        Me.AddServerRoleMemberToolStripMenuItem.Name = "AddServerRoleMemberToolStripMenuItem"
        Me.AddServerRoleMemberToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AddServerRoleMemberToolStripMenuItem.Text = "Add Server Role Member"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(205, 6)
        '
        'DropRoleMemberToolStripMenuItem
        '
        Me.DropRoleMemberToolStripMenuItem.Name = "DropRoleMemberToolStripMenuItem"
        Me.DropRoleMemberToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.DropRoleMemberToolStripMenuItem.Text = "Drop Role Member"
        '
        'DropServerRoleMemberToolStripMenuItem
        '
        Me.DropServerRoleMemberToolStripMenuItem.Name = "DropServerRoleMemberToolStripMenuItem"
        Me.DropServerRoleMemberToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.DropServerRoleMemberToolStripMenuItem.Text = "Drop Server Role Member"
        '
        'GrantUserToRoleToolStripMenuItem
        '
        Me.GrantUserToRoleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrantToolStripMenuItem, Me.RevokeToolStripMenuItem, Me.DenyToolStripMenuItem})
        Me.GrantUserToRoleToolStripMenuItem.Name = "GrantUserToRoleToolStripMenuItem"
        Me.GrantUserToRoleToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GrantUserToRoleToolStripMenuItem.Text = "Grant User To Role"
        '
        'GrantToolStripMenuItem
        '
        Me.GrantToolStripMenuItem.Name = "GrantToolStripMenuItem"
        Me.GrantToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.GrantToolStripMenuItem.Text = "Grant"
        '
        'RevokeToolStripMenuItem
        '
        Me.RevokeToolStripMenuItem.Name = "RevokeToolStripMenuItem"
        Me.RevokeToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RevokeToolStripMenuItem.Text = "Revoke"
        '
        'DenyToolStripMenuItem
        '
        Me.DenyToolStripMenuItem.Name = "DenyToolStripMenuItem"
        Me.DenyToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.DenyToolStripMenuItem.Text = "Deny"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(185, 6)
        '
        'TableToolStripMenuItem
        '
        Me.TableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateTableToolStripMenuItem, Me.AlterTableToolStripMenuItem, Me.ToolStripMenuItem2, Me.DropTableToolStripMenuItem})
        Me.TableToolStripMenuItem.Name = "TableToolStripMenuItem"
        Me.TableToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TableToolStripMenuItem.Text = "Table"
        '
        'CreateTableToolStripMenuItem
        '
        Me.CreateTableToolStripMenuItem.Name = "CreateTableToolStripMenuItem"
        Me.CreateTableToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CreateTableToolStripMenuItem.Text = "Create Table"
        '
        'AlterTableToolStripMenuItem
        '
        Me.AlterTableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddColumnToolStripMenuItem, Me.EditColumnDataTypeToolStripMenuItem, Me.DeleteColumnToolStripMenuItem, Me.ToolStripMenuItem10, Me.AddingAColumnWithAConstraintToolStripMenuItem, Me.AddingCheckConstraintAoAnExistingColumnToolStripMenuItem, Me.AddingADefaultConstraintToAnExistingColumnToolStripMenuItem, Me.ConstraintToolStripMenuItem, Me.ToolStripMenuItem9, Me.AddingForeignKeyToolStripMenuItem, Me.DeleteForeignKeyToolStripMenuItem})
        Me.AlterTableToolStripMenuItem.Name = "AlterTableToolStripMenuItem"
        Me.AlterTableToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AlterTableToolStripMenuItem.Text = "Alter Table"
        '
        'AddColumnToolStripMenuItem
        '
        Me.AddColumnToolStripMenuItem.Name = "AddColumnToolStripMenuItem"
        Me.AddColumnToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.AddColumnToolStripMenuItem.Text = "Add Column"
        '
        'EditColumnDataTypeToolStripMenuItem
        '
        Me.EditColumnDataTypeToolStripMenuItem.Name = "EditColumnDataTypeToolStripMenuItem"
        Me.EditColumnDataTypeToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.EditColumnDataTypeToolStripMenuItem.Text = "Changing The Data Type Of A Column"
        '
        'DeleteColumnToolStripMenuItem
        '
        Me.DeleteColumnToolStripMenuItem.Name = "DeleteColumnToolStripMenuItem"
        Me.DeleteColumnToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.DeleteColumnToolStripMenuItem.Text = "Delete Column"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(377, 6)
        '
        'AddingAColumnWithAConstraintToolStripMenuItem
        '
        Me.AddingAColumnWithAConstraintToolStripMenuItem.Name = "AddingAColumnWithAConstraintToolStripMenuItem"
        Me.AddingAColumnWithAConstraintToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.AddingAColumnWithAConstraintToolStripMenuItem.Text = "Adding A Column With A Constraint"
        '
        'AddingCheckConstraintAoAnExistingColumnToolStripMenuItem
        '
        Me.AddingCheckConstraintAoAnExistingColumnToolStripMenuItem.Name = "AddingCheckConstraintAoAnExistingColumnToolStripMenuItem"
        Me.AddingCheckConstraintAoAnExistingColumnToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.AddingCheckConstraintAoAnExistingColumnToolStripMenuItem.Text = "Adding An Unverified Check Constraint To An Existing Column"
        '
        'AddingADefaultConstraintToAnExistingColumnToolStripMenuItem
        '
        Me.AddingADefaultConstraintToAnExistingColumnToolStripMenuItem.Name = "AddingADefaultConstraintToAnExistingColumnToolStripMenuItem"
        Me.AddingADefaultConstraintToAnExistingColumnToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.AddingADefaultConstraintToAnExistingColumnToolStripMenuItem.Text = "Adding A Default Constraint To An Existing Column"
        '
        'ConstraintToolStripMenuItem
        '
        Me.ConstraintToolStripMenuItem.Name = "ConstraintToolStripMenuItem"
        Me.ConstraintToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.ConstraintToolStripMenuItem.Text = "Delete Constraint"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(377, 6)
        '
        'AddingForeignKeyToolStripMenuItem
        '
        Me.AddingForeignKeyToolStripMenuItem.Name = "AddingForeignKeyToolStripMenuItem"
        Me.AddingForeignKeyToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.AddingForeignKeyToolStripMenuItem.Text = "Adding Foreign Key"
        '
        'DeleteForeignKeyToolStripMenuItem
        '
        Me.DeleteForeignKeyToolStripMenuItem.Name = "DeleteForeignKeyToolStripMenuItem"
        Me.DeleteForeignKeyToolStripMenuItem.Size = New System.Drawing.Size(380, 22)
        Me.DeleteForeignKeyToolStripMenuItem.Text = "Delete Foreign Key"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(144, 6)
        '
        'DropTableToolStripMenuItem
        '
        Me.DropTableToolStripMenuItem.Name = "DropTableToolStripMenuItem"
        Me.DropTableToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DropTableToolStripMenuItem.Text = "Drop Table"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateDatabaseToolStripMenuItem, Me.AlterDatabaseToolStripMenuItem, Me.ToolStripMenuItem8, Me.DropDatabaseToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'CreateDatabaseToolStripMenuItem
        '
        Me.CreateDatabaseToolStripMenuItem.Name = "CreateDatabaseToolStripMenuItem"
        Me.CreateDatabaseToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CreateDatabaseToolStripMenuItem.Text = "Create Database"
        '
        'AlterDatabaseToolStripMenuItem
        '
        Me.AlterDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifyDatabaseToolStripMenuItem, Me.ToolStripMenuItem11, Me.AddOrModifyFilesToolStripMenuItem})
        Me.AlterDatabaseToolStripMenuItem.Name = "AlterDatabaseToolStripMenuItem"
        Me.AlterDatabaseToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AlterDatabaseToolStripMenuItem.Text = "Alter Database"
        '
        'ModifyDatabaseToolStripMenuItem
        '
        Me.ModifyDatabaseToolStripMenuItem.Name = "ModifyDatabaseToolStripMenuItem"
        Me.ModifyDatabaseToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ModifyDatabaseToolStripMenuItem.Text = "Changing Database Name"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(206, 6)
        '
        'AddOrModifyFilesToolStripMenuItem
        '
        Me.AddOrModifyFilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddingAFileToADatabaseToolStripMenuItem, Me.RemovingAFileFromADatabaseToolStripMenuItem, Me.ModifyingAFileToolStripMenuItem})
        Me.AddOrModifyFilesToolStripMenuItem.Name = "AddOrModifyFilesToolStripMenuItem"
        Me.AddOrModifyFilesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AddOrModifyFilesToolStripMenuItem.Text = "Add or Modify Files"
        '
        'AddingAFileToADatabaseToolStripMenuItem
        '
        Me.AddingAFileToADatabaseToolStripMenuItem.Name = "AddingAFileToADatabaseToolStripMenuItem"
        Me.AddingAFileToADatabaseToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.AddingAFileToADatabaseToolStripMenuItem.Text = "Adding A File To A Database"
        '
        'RemovingAFileFromADatabaseToolStripMenuItem
        '
        Me.RemovingAFileFromADatabaseToolStripMenuItem.Name = "RemovingAFileFromADatabaseToolStripMenuItem"
        Me.RemovingAFileFromADatabaseToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.RemovingAFileFromADatabaseToolStripMenuItem.Text = "Removing A File From A Database"
        '
        'ModifyingAFileToolStripMenuItem
        '
        Me.ModifyingAFileToolStripMenuItem.Name = "ModifyingAFileToolStripMenuItem"
        Me.ModifyingAFileToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ModifyingAFileToolStripMenuItem.Text = "Modifying A File"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(164, 6)
        '
        'DropDatabaseToolStripMenuItem
        '
        Me.DropDatabaseToolStripMenuItem.Name = "DropDatabaseToolStripMenuItem"
        Me.DropDatabaseToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DropDatabaseToolStripMenuItem.Text = "Drop Database"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupDatabaseToolStripMenuItem, Me.LogFileBackupToolStripMenuItem, Me.ToolStripMenuItem12, Me.RestoreDatabaseToolStripMenuItem, Me.RestoreLogToolStripMenuItem})
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.BackupToolStripMenuItem.Text = "Backup / Restore"
        '
        'BackupDatabaseToolStripMenuItem
        '
        Me.BackupDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullBackupToolStripMenuItem, Me.DiffToolStripMenuItem})
        Me.BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        Me.BackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.BackupDatabaseToolStripMenuItem.Text = "Backup Database"
        '
        'FullBackupToolStripMenuItem
        '
        Me.FullBackupToolStripMenuItem.Name = "FullBackupToolStripMenuItem"
        Me.FullBackupToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FullBackupToolStripMenuItem.Text = "Full Backup"
        '
        'DiffToolStripMenuItem
        '
        Me.DiffToolStripMenuItem.Name = "DiffToolStripMenuItem"
        Me.DiffToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DiffToolStripMenuItem.Text = "Differential Backup"
        '
        'LogFileBackupToolStripMenuItem
        '
        Me.LogFileBackupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullBackupToolStripMenuItem1, Me.DifferentialBackupToolStripMenuItem})
        Me.LogFileBackupToolStripMenuItem.Name = "LogFileBackupToolStripMenuItem"
        Me.LogFileBackupToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.LogFileBackupToolStripMenuItem.Text = "Backup Log"
        '
        'FullBackupToolStripMenuItem1
        '
        Me.FullBackupToolStripMenuItem1.Name = "FullBackupToolStripMenuItem1"
        Me.FullBackupToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.FullBackupToolStripMenuItem1.Text = "Full Backup"
        '
        'DifferentialBackupToolStripMenuItem
        '
        Me.DifferentialBackupToolStripMenuItem.Name = "DifferentialBackupToolStripMenuItem"
        Me.DifferentialBackupToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DifferentialBackupToolStripMenuItem.Text = "Differential Backup"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(169, 6)
        '
        'RestoreDatabaseToolStripMenuItem
        '
        Me.RestoreDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoRecoveryToolStripMenuItem, Me.WithRecoveryToolStripMenuItem})
        Me.RestoreDatabaseToolStripMenuItem.Name = "RestoreDatabaseToolStripMenuItem"
        Me.RestoreDatabaseToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RestoreDatabaseToolStripMenuItem.Text = "Restore Database"
        '
        'NoRecoveryToolStripMenuItem
        '
        Me.NoRecoveryToolStripMenuItem.Name = "NoRecoveryToolStripMenuItem"
        Me.NoRecoveryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NoRecoveryToolStripMenuItem.Text = "No Recovery"
        '
        'WithRecoveryToolStripMenuItem
        '
        Me.WithRecoveryToolStripMenuItem.Name = "WithRecoveryToolStripMenuItem"
        Me.WithRecoveryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.WithRecoveryToolStripMenuItem.Text = "With Recovery"
        '
        'RestoreLogToolStripMenuItem
        '
        Me.RestoreLogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoRecoveryToolStripMenuItem1, Me.WithRecoveryToolStripMenuItem1})
        Me.RestoreLogToolStripMenuItem.Name = "RestoreLogToolStripMenuItem"
        Me.RestoreLogToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.RestoreLogToolStripMenuItem.Text = "Restore Log"
        '
        'NoRecoveryToolStripMenuItem1
        '
        Me.NoRecoveryToolStripMenuItem1.Name = "NoRecoveryToolStripMenuItem1"
        Me.NoRecoveryToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.NoRecoveryToolStripMenuItem1.Text = "No Recovery"
        '
        'WithRecoveryToolStripMenuItem1
        '
        Me.WithRecoveryToolStripMenuItem1.Name = "WithRecoveryToolStripMenuItem1"
        Me.WithRecoveryToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.WithRecoveryToolStripMenuItem1.Text = "With Recovery"
        '
        'InsertUpdateDeleteToolStripMenuItem
        '
        Me.InsertUpdateDeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.InsertUpdateDeleteToolStripMenuItem.Name = "InsertUpdateDeleteToolStripMenuItem"
        Me.InsertUpdateDeleteToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.InsertUpdateDeleteToolStripMenuItem.Text = "Insert,Update,Delete"
        '
        'InsertToolStripMenuItem
        '
        Me.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem"
        Me.InsertToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InsertToolStripMenuItem.Text = "Insert"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripMenuItem, Me.OneRowsToolStripMenuItem})
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'AllRowsToolStripMenuItem
        '
        Me.AllRowsToolStripMenuItem.Name = "AllRowsToolStripMenuItem"
        Me.AllRowsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AllRowsToolStripMenuItem.Text = "All Rows"
        '
        'OneRowsToolStripMenuItem
        '
        Me.OneRowsToolStripMenuItem.Name = "OneRowsToolStripMenuItem"
        Me.OneRowsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OneRowsToolStripMenuItem.Text = "One Rows"
        '
        'lblStatusQuery
        '
        Me.lblStatusQuery.AutoSize = True
        Me.lblStatusQuery.Location = New System.Drawing.Point(39, 198)
        Me.lblStatusQuery.Name = "lblStatusQuery"
        Me.lblStatusQuery.Size = New System.Drawing.Size(0, 14)
        Me.lblStatusQuery.TabIndex = 4
        '
        'picStatusQuery
        '
        Me.picStatusQuery.Location = New System.Drawing.Point(16, 196)
        Me.picStatusQuery.Name = "picStatusQuery"
        Me.picStatusQuery.Size = New System.Drawing.Size(16, 16)
        Me.picStatusQuery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStatusQuery.TabIndex = 3
        Me.picStatusQuery.TabStop = False
        '
        'dgwQueryResult
        '
        Me.dgwQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwQueryResult.Location = New System.Drawing.Point(16, 218)
        Me.dgwQueryResult.Name = "dgwQueryResult"
        Me.dgwQueryResult.Size = New System.Drawing.Size(496, 184)
        Me.dgwQueryResult.TabIndex = 2
        '
        'btnCopyTableField
        '
        Me.btnCopyTableField.Location = New System.Drawing.Point(16, 161)
        Me.btnCopyTableField.Name = "btnCopyTableField"
        Me.btnCopyTableField.Size = New System.Drawing.Size(122, 23)
        Me.btnCopyTableField.TabIndex = 1
        Me.btnCopyTableField.Text = "Copy Table Field"
        Me.btnCopyTableField.UseVisualStyleBackColor = True
        '
        'btnCopyTableName
        '
        Me.btnCopyTableName.Location = New System.Drawing.Point(272, 161)
        Me.btnCopyTableName.Name = "btnCopyTableName"
        Me.btnCopyTableName.Size = New System.Drawing.Size(125, 23)
        Me.btnCopyTableName.TabIndex = 1
        Me.btnCopyTableName.Text = "Copy Table Name"
        Me.btnCopyTableName.UseVisualStyleBackColor = True
        '
        'btnCopySelectField
        '
        Me.btnCopySelectField.Location = New System.Drawing.Point(144, 161)
        Me.btnCopySelectField.Name = "btnCopySelectField"
        Me.btnCopySelectField.Size = New System.Drawing.Size(122, 23)
        Me.btnCopySelectField.TabIndex = 1
        Me.btnCopySelectField.Text = "Copy Select Field"
        Me.btnCopySelectField.UseVisualStyleBackColor = True
        '
        'btnQueryExecute
        '
        Me.btnQueryExecute.Location = New System.Drawing.Point(437, 161)
        Me.btnQueryExecute.Name = "btnQueryExecute"
        Me.btnQueryExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnQueryExecute.TabIndex = 1
        Me.btnQueryExecute.Text = "Execute"
        Me.btnQueryExecute.UseVisualStyleBackColor = True
        '
        'txtQuery
        '
        Me.txtQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuery.Location = New System.Drawing.Point(16, 66)
        Me.txtQuery.Multiline = True
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtQuery.Size = New System.Drawing.Size(496, 87)
        Me.txtQuery.TabIndex = 0
        '
        'NicePanel6
        '
        Me.NicePanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NicePanel6.BackColor = System.Drawing.Color.Transparent
        ContainerImage3.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage3.Image = Nothing
        ContainerImage3.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage3.Transparency = 50
        Me.NicePanel6.ContainerImage = ContainerImage3
        Me.NicePanel6.Controls.Add(Me.btnOneRight)
        Me.NicePanel6.Controls.Add(Me.lstTableFields)
        Me.NicePanel6.Controls.Add(Me.btnAllRight)
        Me.NicePanel6.Controls.Add(Me.btnOneLeft)
        Me.NicePanel6.Controls.Add(Me.btnAllLeft)
        Me.NicePanel6.Controls.Add(Me.lstSelectFields)
        Me.NicePanel6.Controls.Add(Me.btnAsagi)
        Me.NicePanel6.Controls.Add(Me.btnYukari)
        HeaderImage3.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage3.Image = Nothing
        Me.NicePanel6.FooterImage = HeaderImage3
        Me.NicePanel6.FooterText = "PureComponents NicePanel for .NET WinForms V1.0."
        Me.NicePanel6.FooterVisible = False
        Me.NicePanel6.ForeColor = System.Drawing.Color.Black
        HeaderImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.Calendar
        HeaderImage4.Image = Nothing
        Me.NicePanel6.HeaderImage = HeaderImage4
        Me.NicePanel6.HeaderText = "Selection Fields"
        Me.NicePanel6.IsExpanded = True
        Me.NicePanel6.Location = New System.Drawing.Point(200, 48)
        Me.NicePanel6.Name = "NicePanel6"
        Me.NicePanel6.OriginalFooterVisible = False
        Me.NicePanel6.OriginalHeight = 0
        Me.NicePanel6.Size = New System.Drawing.Size(520, 160)
        ContainerStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle2.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle2.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle2.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle2.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle2.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle2.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle2.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle2.ForeColor = System.Drawing.Color.Black
        ContainerStyle2.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle2.ContainerStyle = ContainerStyle2
        PanelHeaderStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle3.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle3.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle3.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle3.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle3.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle3.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle3.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle2.FooterStyle = PanelHeaderStyle3
        PanelHeaderStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle4.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle4.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle4.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle4.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle4.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle4.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        PanelHeaderStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle4.Size = PureComponents.NicePanel.PanelHeaderSize.Medium
        PanelStyle2.HeaderStyle = PanelHeaderStyle4
        Me.NicePanel6.Style = PanelStyle2
        Me.NicePanel6.TabIndex = 4
        '
        'btnOneRight
        '
        Me.btnOneRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOneRight.Location = New System.Drawing.Point(224, 40)
        Me.btnOneRight.Name = "btnOneRight"
        Me.btnOneRight.Size = New System.Drawing.Size(40, 23)
        Me.btnOneRight.TabIndex = 1
        Me.btnOneRight.Tag = ""
        Me.btnOneRight.Text = ">"
        '
        'lstTableFields
        '
        Me.lstTableFields.ItemHeight = 14
        Me.lstTableFields.Location = New System.Drawing.Point(16, 32)
        Me.lstTableFields.Name = "lstTableFields"
        Me.lstTableFields.Size = New System.Drawing.Size(200, 116)
        Me.lstTableFields.TabIndex = 0
        '
        'btnAllRight
        '
        Me.btnAllRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAllRight.Location = New System.Drawing.Point(224, 64)
        Me.btnAllRight.Name = "btnAllRight"
        Me.btnAllRight.Size = New System.Drawing.Size(40, 23)
        Me.btnAllRight.TabIndex = 1
        Me.btnAllRight.Tag = ""
        Me.btnAllRight.Text = ">>"
        '
        'btnOneLeft
        '
        Me.btnOneLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOneLeft.Location = New System.Drawing.Point(224, 112)
        Me.btnOneLeft.Name = "btnOneLeft"
        Me.btnOneLeft.Size = New System.Drawing.Size(40, 23)
        Me.btnOneLeft.TabIndex = 1
        Me.btnOneLeft.Tag = ""
        Me.btnOneLeft.Text = "<"
        '
        'btnAllLeft
        '
        Me.btnAllLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAllLeft.Location = New System.Drawing.Point(224, 88)
        Me.btnAllLeft.Name = "btnAllLeft"
        Me.btnAllLeft.Size = New System.Drawing.Size(40, 23)
        Me.btnAllLeft.TabIndex = 1
        Me.btnAllLeft.Tag = ""
        Me.btnAllLeft.Text = "<<"
        '
        'lstSelectFields
        '
        Me.lstSelectFields.ItemHeight = 14
        Me.lstSelectFields.Location = New System.Drawing.Point(272, 32)
        Me.lstSelectFields.Name = "lstSelectFields"
        Me.lstSelectFields.Size = New System.Drawing.Size(200, 116)
        Me.lstSelectFields.TabIndex = 0
        '
        'btnAsagi
        '
        Me.btnAsagi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAsagi.ImageIndex = 1
        Me.btnAsagi.ImageList = Me.ImageList1
        Me.btnAsagi.Location = New System.Drawing.Point(480, 80)
        Me.btnAsagi.Name = "btnAsagi"
        Me.btnAsagi.Size = New System.Drawing.Size(32, 23)
        Me.btnAsagi.TabIndex = 1
        Me.btnAsagi.Tag = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "button_ok.ico")
        Me.ImageList1.Images.SetKeyName(3, "button_cancel.ico")
        '
        'btnYukari
        '
        Me.btnYukari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnYukari.ImageIndex = 0
        Me.btnYukari.ImageList = Me.ImageList1
        Me.btnYukari.Location = New System.Drawing.Point(480, 56)
        Me.btnYukari.Name = "btnYukari"
        Me.btnYukari.Size = New System.Drawing.Size(32, 23)
        Me.btnYukari.TabIndex = 1
        Me.btnYukari.Tag = ""
        '
        'NicePanel5
        '
        Me.NicePanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NicePanel5.BackColor = System.Drawing.Color.Transparent
        ContainerImage4.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage4.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage4.Image = Nothing
        ContainerImage4.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage4.Transparency = 50
        Me.NicePanel5.ContainerImage = ContainerImage4
        Me.NicePanel5.Controls.Add(Me.lstTables)
        HeaderImage5.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage5.Image = Nothing
        Me.NicePanel5.FooterImage = HeaderImage5
        Me.NicePanel5.FooterText = ""
        Me.NicePanel5.FooterVisible = False
        Me.NicePanel5.ForeColor = System.Drawing.Color.Black
        HeaderImage6.ClipArt = PureComponents.NicePanel.ImageClipArt.Task
        HeaderImage6.Image = Nothing
        Me.NicePanel5.HeaderImage = HeaderImage6
        Me.NicePanel5.HeaderText = "Tables"
        Me.NicePanel5.IsExpanded = True
        Me.NicePanel5.Location = New System.Drawing.Point(8, 344)
        Me.NicePanel5.Name = "NicePanel5"
        Me.NicePanel5.OriginalFooterVisible = False
        Me.NicePanel5.OriginalHeight = 0
        Me.NicePanel5.Size = New System.Drawing.Size(184, 287)
        ContainerStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle3.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle3.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle3.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle3.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle3.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle3.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle3.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle3.ForeColor = System.Drawing.Color.Black
        ContainerStyle3.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle3.ContainerStyle = ContainerStyle3
        PanelHeaderStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle5.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle5.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle5.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle5.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle5.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle5.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle5.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle3.FooterStyle = PanelHeaderStyle5
        PanelHeaderStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle6.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle6.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle6.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle6.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle6.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle6.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        PanelHeaderStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle6.Size = PureComponents.NicePanel.PanelHeaderSize.Medium
        PanelStyle3.HeaderStyle = PanelHeaderStyle6
        Me.NicePanel5.Style = PanelStyle3
        Me.NicePanel5.TabIndex = 3
        '
        'lstTables
        '
        Me.lstTables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTables.ItemHeight = 14
        Me.lstTables.Location = New System.Drawing.Point(8, 32)
        Me.lstTables.Name = "lstTables"
        Me.lstTables.Size = New System.Drawing.Size(168, 242)
        Me.lstTables.TabIndex = 0
        '
        'NicePanel4
        '
        Me.NicePanel4.BackColor = System.Drawing.Color.Transparent
        ContainerImage5.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage5.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage5.Image = Nothing
        ContainerImage5.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage5.Transparency = 50
        Me.NicePanel4.ContainerImage = ContainerImage5
        Me.NicePanel4.Controls.Add(Me.rbSQL)
        Me.NicePanel4.Controls.Add(Me.rbWindows)
        Me.NicePanel4.Controls.Add(Me.txtUserID)
        Me.NicePanel4.Controls.Add(Me.lblUserID)
        Me.NicePanel4.Controls.Add(Me.txtPassword)
        Me.NicePanel4.Controls.Add(Me.lblPassword)
        HeaderImage7.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage7.Image = Nothing
        Me.NicePanel4.FooterImage = HeaderImage7
        Me.NicePanel4.FooterText = "PureComponents NicePanel for .NET WinForms V1.0."
        Me.NicePanel4.FooterVisible = False
        Me.NicePanel4.ForeColor = System.Drawing.Color.Black
        HeaderImage8.ClipArt = PureComponents.NicePanel.ImageClipArt.Login
        HeaderImage8.Image = Nothing
        Me.NicePanel4.HeaderImage = HeaderImage8
        Me.NicePanel4.HeaderText = "Authentication"
        Me.NicePanel4.IsExpanded = True
        Me.NicePanel4.Location = New System.Drawing.Point(8, 120)
        Me.NicePanel4.Name = "NicePanel4"
        Me.NicePanel4.OriginalFooterVisible = False
        Me.NicePanel4.OriginalHeight = 0
        Me.NicePanel4.Size = New System.Drawing.Size(184, 144)
        ContainerStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle4.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle4.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle4.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle4.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle4.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle4.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle4.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle4.ForeColor = System.Drawing.Color.Black
        ContainerStyle4.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle4.ContainerStyle = ContainerStyle4
        PanelHeaderStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle7.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle7.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle7.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle7.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle7.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle7.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle7.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle4.FooterStyle = PanelHeaderStyle7
        PanelHeaderStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle8.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle8.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle8.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle8.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle8.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle8.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        PanelHeaderStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle8.Size = PureComponents.NicePanel.PanelHeaderSize.Medium
        PanelStyle4.HeaderStyle = PanelHeaderStyle8
        Me.NicePanel4.Style = PanelStyle4
        Me.NicePanel4.TabIndex = 2
        '
        'rbSQL
        '
        Me.rbSQL.Location = New System.Drawing.Point(8, 56)
        Me.rbSQL.Name = "rbSQL"
        Me.rbSQL.Size = New System.Drawing.Size(168, 24)
        Me.rbSQL.TabIndex = 2
        Me.rbSQL.Text = "SQL Authentication"
        '
        'rbWindows
        '
        Me.rbWindows.Checked = True
        Me.rbWindows.Location = New System.Drawing.Point(8, 32)
        Me.rbWindows.Name = "rbWindows"
        Me.rbWindows.Size = New System.Drawing.Size(176, 24)
        Me.rbWindows.TabIndex = 1
        Me.rbWindows.TabStop = True
        Me.rbWindows.Text = "Windows Authentication"
        '
        'txtUserID
        '
        Me.txtUserID.Enabled = False
        Me.txtUserID.Location = New System.Drawing.Point(80, 88)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(96, 22)
        Me.txtUserID.TabIndex = 0
        '
        'lblUserID
        '
        Me.lblUserID.Enabled = False
        Me.lblUserID.Location = New System.Drawing.Point(8, 88)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(64, 23)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "User ID"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(80, 112)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(96, 22)
        Me.txtPassword.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.Enabled = False
        Me.lblPassword.Location = New System.Drawing.Point(8, 112)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(64, 23)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'NicePanel2
        '
        Me.NicePanel2.BackColor = System.Drawing.Color.Transparent
        ContainerImage6.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage6.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage6.Image = Nothing
        ContainerImage6.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage6.Transparency = 50
        Me.NicePanel2.ContainerImage = ContainerImage6
        Me.NicePanel2.Controls.Add(Me.cmbDatabases)
        HeaderImage9.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage9.Image = Nothing
        Me.NicePanel2.FooterImage = HeaderImage9
        Me.NicePanel2.FooterText = ""
        Me.NicePanel2.FooterVisible = False
        Me.NicePanel2.ForeColor = System.Drawing.Color.Black
        HeaderImage10.ClipArt = PureComponents.NicePanel.ImageClipArt.Trash
        HeaderImage10.Image = Nothing
        Me.NicePanel2.HeaderImage = HeaderImage10
        Me.NicePanel2.HeaderText = "Databases"
        Me.NicePanel2.IsExpanded = True
        Me.NicePanel2.Location = New System.Drawing.Point(8, 272)
        Me.NicePanel2.Name = "NicePanel2"
        Me.NicePanel2.OriginalFooterVisible = False
        Me.NicePanel2.OriginalHeight = 0
        Me.NicePanel2.Size = New System.Drawing.Size(184, 64)
        ContainerStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle5.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle5.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle5.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle5.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle5.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle5.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle5.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle5.ForeColor = System.Drawing.Color.Black
        ContainerStyle5.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle5.ContainerStyle = ContainerStyle5
        PanelHeaderStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle9.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle9.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle9.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle9.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle9.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle9.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle9.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle5.FooterStyle = PanelHeaderStyle9
        PanelHeaderStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle10.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle10.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle10.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle10.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle10.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle10.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        PanelHeaderStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle10.Size = PureComponents.NicePanel.PanelHeaderSize.Medium
        PanelStyle5.HeaderStyle = PanelHeaderStyle10
        Me.NicePanel2.Style = PanelStyle5
        Me.NicePanel2.TabIndex = 1
        '
        'NicePanel3
        '
        Me.NicePanel3.BackColor = System.Drawing.Color.Transparent
        ContainerImage7.Alignment = System.Drawing.ContentAlignment.BottomRight
        ContainerImage7.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        ContainerImage7.Image = Nothing
        ContainerImage7.Size = PureComponents.NicePanel.ContainerImageSize.Small
        ContainerImage7.Transparency = 50
        Me.NicePanel3.ContainerImage = ContainerImage7
        Me.NicePanel3.Controls.Add(Me.txtServer)
        HeaderImage11.ClipArt = PureComponents.NicePanel.ImageClipArt.None
        HeaderImage11.Image = Nothing
        Me.NicePanel3.FooterImage = HeaderImage11
        Me.NicePanel3.FooterText = "PureComponents NicePanel for .NET WinForms V1.0."
        Me.NicePanel3.FooterVisible = False
        Me.NicePanel3.ForeColor = System.Drawing.Color.Black
        HeaderImage12.ClipArt = PureComponents.NicePanel.ImageClipArt.Applications
        HeaderImage12.Image = Nothing
        Me.NicePanel3.HeaderImage = HeaderImage12
        Me.NicePanel3.HeaderText = "SQL Server"
        Me.NicePanel3.IsExpanded = True
        Me.NicePanel3.Location = New System.Drawing.Point(8, 48)
        Me.NicePanel3.Name = "NicePanel3"
        Me.NicePanel3.OriginalFooterVisible = False
        Me.NicePanel3.OriginalHeight = 0
        Me.NicePanel3.Size = New System.Drawing.Size(184, 64)
        ContainerStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        ContainerStyle6.BaseColor = System.Drawing.Color.Transparent
        ContainerStyle6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(150, Byte), Integer))
        ContainerStyle6.BorderStyle = PureComponents.NicePanel.BorderStyle.Solid
        ContainerStyle6.CaptionAlign = PureComponents.NicePanel.CaptionAlign.Left
        ContainerStyle6.FadeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(252, Byte), Integer))
        ContainerStyle6.FillStyle = PureComponents.NicePanel.FillStyle.DiagonalForward
        ContainerStyle6.FlashItemBackColor = System.Drawing.Color.Red
        ContainerStyle6.FocusItemBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ContainerStyle6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        ContainerStyle6.ForeColor = System.Drawing.Color.Black
        ContainerStyle6.Shape = PureComponents.NicePanel.Shape.Rounded
        PanelStyle6.ContainerStyle = ContainerStyle6
        PanelHeaderStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle11.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle11.FadeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle11.FillStyle = PureComponents.NicePanel.FillStyle.HorizontalFading
        PanelHeaderStyle11.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle11.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle11.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        PanelHeaderStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(237, Byte), Integer))
        PanelHeaderStyle11.Size = PureComponents.NicePanel.PanelHeaderSize.Small
        PanelStyle6.FooterStyle = PanelHeaderStyle11
        PanelHeaderStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(215, Byte), Integer))
        PanelHeaderStyle12.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(227, Byte), Integer))
        PanelHeaderStyle12.FadeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(127, Byte), Integer))
        PanelHeaderStyle12.FillStyle = PureComponents.NicePanel.FillStyle.VerticalFading
        PanelHeaderStyle12.FlashBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(1, Byte), Integer))
        PanelHeaderStyle12.FlashFadeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(159, Byte), Integer))
        PanelHeaderStyle12.FlashForeColor = System.Drawing.Color.White
        PanelHeaderStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        PanelHeaderStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(251, Byte), Integer))
        PanelHeaderStyle12.Size = PureComponents.NicePanel.PanelHeaderSize.Medium
        PanelStyle6.HeaderStyle = PanelHeaderStyle12
        Me.NicePanel3.Style = PanelStyle6
        Me.NicePanel3.TabIndex = 0
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(8, 32)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(168, 22)
        Me.txtServer.TabIndex = 0
        Me.txtServer.Text = "(local)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(193, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(728, 639)
        Me.Controls.Add(Me.NicePanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.NicePanel1.ResumeLayout(False)
        Me.nplWhere.ResumeLayout(False)
        Me.nplWhere.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picStatusQuery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NicePanel6.ResumeLayout(False)
        Me.NicePanel5.ResumeLayout(False)
        Me.NicePanel4.ResumeLayout(False)
        Me.NicePanel4.PerformLayout()
        Me.NicePanel2.ResumeLayout(False)
        Me.NicePanel3.ResumeLayout(False)
        Me.NicePanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "LocalVariables"
    Dim Columns As ArrayList
    Dim ust As Integer = 30

    'Sql server'a baðlanmak için sqlconnection nesnesi kullanýlabilir. SQl Sonnection kullanýcýdan en az server ve authentication bilgileri ister. Server=., localserver'a baðlanmak istediðimiz anlamýna gelir. Integrated security=sspi, windows authentication kullanýlacaðý anlamýna gelir. Bunun yerine ( user id = xx , password=xxx ) de kullanýlabilir
    'Dim conn As SqlConnection = New SqlConnection("Server=.;Integrated Security=sspi")
    Dim conn As SqlConnection = New SqlConnection
#End Region

#Region "Events"
    Private Sub rb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWindows.CheckedChanged, rbSQL.CheckedChanged
        If rbWindows.Checked Then
            lblUserID.Enabled = False
            lblPassword.Enabled = False
            txtUserID.Enabled = False
            txtPassword.Enabled = False
        Else
            lblUserID.Enabled = True
            lblPassword.Enabled = True
            txtUserID.Enabled = True
            txtPassword.Enabled = True
        End If
    End Sub

    Private Sub cmbDatabases_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDatabases.MouseEnter

        If rbWindows.Checked Then
            conn.ConnectionString = "Server=" & txtServer.Text & ";Integrated Security=sspi"
        Else
            conn.ConnectionString = "Server=" & txtServer.Text & ";User ID=" & txtUserID.Text & "; Password=" & txtPassword.Text
        End If
        cmbDatabases.Items.Clear()
        Dim cmd As SqlCommand = New SqlCommand("Select name from sysdatabases where dbid>4 order by name", conn)
        conn.Open()
        'SQl server'a baðlandýktan sonra herhangi bir database'e baðlanmak için 
        conn.ChangeDatabase("master")
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            cmbDatabases.Items.Add(dr.Item(0))
        End While
        conn.Close()
    End Sub

    Private Sub cmbDatabases_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDatabases.SelectedIndexChanged
        lstTables.Items.Clear()
        Dim cmd As SqlCommand = New SqlCommand("select name from sysobjects where xtype='U' and name <> 'dtproperties' order by name", conn)
        conn.Open()
        'Change Database'in çalýþabilmesi için baðlantýnýn açýk olmasý gerekir
        conn.ChangeDatabase(cmbDatabases.SelectedItem.ToString)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            lstTables.Items.Add(dr.Item(0))
        End While
        conn.Close()
    End Sub

    Private Sub lstTables_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTables.SelectedIndexChanged
        lstTableFields.Items.Clear()
        lstSelectFields.Items.Clear()
        Me.txtQuery.Text = ""
        Me.dgwQueryResult.DataSource = Nothing
        'Columns = New ArrayList

        Dim cmd As SqlCommand = New SqlCommand("select name from syscolumns where id = object_id('" & lstTables.SelectedItem.ToString & "') order by colorder", conn)
        conn.Open()
        'Change Database'in çalýþabilmesi için baðlantýnýn açýk olmasý gerekir
        conn.ChangeDatabase(cmbDatabases.SelectedItem.ToString)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        While dr.Read
            lstTableFields.Items.Add(dr.Item(0))
            'Columns.Add(dr.Item(0))
        End While
        conn.Close()

        '================================
        'Arama user Control ekler..
        '================================
        'nplWhere.Controls.Clear()
        'Dim uc As ucSearch = New ucSearch
        'uc.Location = New Point(10, ust)
        'uc.cmbAndOr.Tag = ust
        'uc.AddColumns(Columns)
        'nplWhere.Controls.Add(uc)
    End Sub

    Private Sub lstTableFields_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTableFields.SelectedIndexChanged
        If Not lstTableFields.SelectedItem Is Nothing Then
            lstSelectFields.Items.Add(lstTableFields.SelectedItem.ToString)
            lstTableFields.Items.Remove(lstTableFields.SelectedItem)
        End If
    End Sub

    Private Sub btnYukari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYukari.Click
        If Not lstSelectFields.SelectedItem Is Nothing AndAlso lstSelectFields.SelectedIndex <> 0 Then
            Dim itm As String = lstSelectFields.SelectedItem.ToString
            lstSelectFields.Items.Insert(lstSelectFields.SelectedIndex - 1, itm)
            Dim index As Integer = lstSelectFields.SelectedIndex - 2
            lstSelectFields.Items.RemoveAt(lstSelectFields.SelectedIndex)
            lstSelectFields.SelectedIndex = index
        End If
    End Sub

    Private Sub btnAsagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsagi.Click
        If Not lstSelectFields.SelectedItem Is Nothing AndAlso lstSelectFields.SelectedIndex <> lstSelectFields.Items.Count - 1 Then
            Dim itm As String = lstSelectFields.SelectedItem.ToString
            lstSelectFields.Items.Insert(lstSelectFields.SelectedIndex + 2, itm)
            Dim index As Integer = lstSelectFields.SelectedIndex + 1
            lstSelectFields.Items.RemoveAt(lstSelectFields.SelectedIndex)
            lstSelectFields.SelectedIndex = index
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtServer.Text = My.Computer.Name.ToString
    End Sub

    Private Sub btnAllLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllLeft.Click
        If Not lstSelectFields.Items.Count = 0 Then
            For i As Integer = 0 To lstSelectFields.Items.Count - 1
                lstTableFields.Items.Add(lstSelectFields.Items(0).ToString)
                lstSelectFields.Items.RemoveAt(0)
            Next
        End If
    End Sub

    Private Sub btnAllRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllRight.Click
        If Not lstTableFields.Items.Count = 0 Then
            For i As Integer = 0 To lstTableFields.Items.Count - 1
                lstSelectFields.Items.Add(lstTableFields.Items(0).ToString)
                lstTableFields.Items.RemoveAt(0)
            Next
        End If
    End Sub

    Private Sub btnOneLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneLeft.Click
        If Not lstSelectFields.SelectedIndex = -1 Then
            Dim Index As Integer = lstSelectFields.SelectedIndex
            lstTableFields.Items.Add(lstSelectFields.SelectedItem.ToString)
            lstSelectFields.Items.RemoveAt(lstSelectFields.SelectedIndex)
            If Not lstSelectFields.Items.Count = 0 Then
                If lstSelectFields.Items.Count = Index AndAlso (lstSelectFields.Items.Count <> 1 OrElse lstSelectFields.Items.Count = 1) Then
                    lstSelectFields.SelectedIndex = Index - 1
                Else
                    lstSelectFields.SelectedIndex = Index
                End If
            End If
        End If
    End Sub

    Private Sub btnOneRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOneRight.Click
        If Not lstTableFields.SelectedIndex = -1 Then
            Dim Index As Integer = lstTableFields.SelectedIndex
            lstSelectFields.Items.Add(lstTableFields.SelectedItem.ToString)
            lstTableFields.Items.RemoveAt(lstTableFields.SelectedIndex)
            If Not lstTableFields.Items.Count = 0 Then
                If lstTableFields.Items.Count = Index AndAlso (lstTableFields.Items.Count <> 1 OrElse lstTableFields.Items.Count = 1) Then
                    lstTableFields.SelectedIndex = Index - 1
                Else
                    lstTableFields.SelectedIndex = Index
                End If
            End If
        End If
    End Sub

    Private Sub btnCopyTableField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyTableField.Click
        If Not Me.lstTableFields.Items.Count = 0 Then
            For i As Integer = 0 To Me.lstTableFields.Items.Count - 1
                Me.txtQuery.Text &= Me.lstTableFields.Items(i).ToString & ", "
            Next

            Me.txtQuery.Text = Me.txtQuery.Text.Remove(Me.txtQuery.Text.Length - 2, 1)
        End If
    End Sub

    Private Sub btnCopySelectField_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopySelectField.Click
        If Not Me.lstSelectFields.Items.Count = 0 Then
            For i As Integer = 0 To Me.lstSelectFields.Items.Count - 1
                Me.txtQuery.Text &= Me.lstSelectFields.Items(i).ToString & ", "
            Next

            Me.txtQuery.Text = Me.txtQuery.Text.Remove(Me.txtQuery.Text.Length - 2, 1)
        End If
    End Sub

    Private Sub btnCopyTableName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyTableName.Click
        Me.txtQuery.Text &= " " & Me.lstTables.SelectedItem.ToString & " "
    End Sub

    Private Sub btnQueryExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryExecute.Click
        Try
            Me.picStatusQuery.Image = Me.ImageList1.Images(3)
            Me.dgwQueryResult.DataSource = Nothing

            If rbWindows.Checked Then
                conn.ConnectionString = "Server=" & txtServer.Text & ";Database=" & Me.cmbDatabases.SelectedItem.ToString & ";Integrated Security=sspi"
            Else
                conn.ConnectionString = "Server=" & txtServer.Text & ";Database=" & Me.cmbDatabases.SelectedItem.ToString & ";User ID=" & txtUserID.Text & "; Password=" & txtPassword.Text
            End If

            Dim DT As DataTable = New DataTable
            Dim DA As SqlDataAdapter = New SqlDataAdapter(Me.txtQuery.Text, conn)
            DA.Fill(DT)
            Me.dgwQueryResult.DataSource = DT

            Me.picStatusQuery.Image = Me.ImageList1.Images(2)
            Me.lblStatusQuery.Text = "Query Executed Successfully."
            Me.lblStatusQuery.ForeColor = Color.Green

        Catch exSQL As SqlException
            MessageBox.Show(exSQL.Message.ToString, "SQL Exception !", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.lblStatusQuery.Text = "Query Executed Unsuccessfully."
            Me.lblStatusQuery.ForeColor = Color.Red
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "General Exception !", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Me.lblStatusQuery.Text = "Query Executed Unsuccessfully."
            Me.lblStatusQuery.ForeColor = Color.Red
        End Try
    End Sub
#End Region

#Region "Stored Procedures"

#Region "Login"
    Private Sub CreateLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateLoginToolStripMenuItem.Click
        Me.txtQuery.Text &= vbCrLf & "EXEC sp_addlogin <@LoginName> ," & vbCrLf & _
            "'<@Password>' ," & vbCrLf & _
            "'<@DefaultDatabase>' ," & vbCrLf & _
            "'<@DefaultLanguage>' "
    End Sub

    Private Sub NameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameToolStripMenuItem.Click
        Me.txtQuery.Text &= vbCrLf & "Alter Login <@LoginName> WITH NAME = <@NewLoginName>" & vbCrLf
    End Sub
    Private Sub PasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordToolStripMenuItem.Click
        Me.txtQuery.Text &= vbCrLf & "Alter Login <@LoginName> WITH PASSWORD = '<@NewPassword>'" & vbCrLf
    End Sub
    Private Sub DefaultDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultDatabaseToolStripMenuItem.Click
        Me.txtQuery.Text &= vbCrLf & "Alter Login <@LoginName> WITH DEFAULT_DATABASE = '<@NewDefaultDatabase>'" & vbCrLf
    End Sub
    Private Sub DefaultLanguageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultLanguageToolStripMenuItem.Click
        Me.txtQuery.Text &= vbCrLf & "Alter Login <@LoginName> WITH DEFAULT_LANGUAGE = '<@NewDefaultLanguage>'" & vbCrLf
    End Sub

    Private Sub DropLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropLoginToolStripMenuItem.Click
        Me.txtQuery.Text &= vbCrLf & "EXEC sp_droplogin <@LoginName>" & vbCrLf
    End Sub
#End Region

#Region "User"
    Private Sub CreateUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateUserToolStripMenuItem.Click
        Me.txtQuery.Text &= "EXEC sp_adduser '<@UserName>' ," & vbCrLf & _
            "'<@NameInDatabase>' ," & vbCrLf & _
            "'<@RoleName'>" & vbCrLf
    End Sub

    Private Sub AlterUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterUserToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER USER UserName WITH Name = <@NewUserName> " & vbCrLf
    End Sub

    Private Sub DropUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropUserToolStripMenuItem.Click

        Me.txtQuery.Text &= "--If <@UserName> has a Schema in Database" & vbCrLf & "DROP SCHEMA <@UserName> " & vbCrLf & vbCrLf & "DROP USER <@UserName> " & vbCrLf
    End Sub
#End Region

#Region "Role"
    Private Sub CreateRoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateRoleToolStripMenuItem.Click
        Me.txtQuery.Text &= "CREATE ROLE <@RoleName> AUTHORIZATION <Sample:db_securityadmin>" & vbCrLf
    End Sub
    Private Sub AlterRoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterRoleToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER ROLE <@RoleName> WITH NAME = <@NewName>" & vbCrLf
    End Sub
    Private Sub DropRoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropRoleToolStripMenuItem.Click
        Me.txtQuery.Text &= "DROP ROLE <@RoleName>" & vbCrLf
    End Sub

    Private Sub AddRoleMemberToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRoleMemberToolStripMenuItem1.Click
        Me.txtQuery.Text &= "EXEC sp_addrolemember '<@RoleName>' ," & vbCrLf & _
            "'<@UserNameInDatabase>'" & vbCrLf
    End Sub
    Private Sub AddServerRoleMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddServerRoleMemberToolStripMenuItem.Click
        Me.txtQuery.Text &= "EXEC sp_addsrvrolemember '<@LoginName>' ," & vbCrLf & _
            "'<@RoleName>'" & vbCrLf
    End Sub

    Private Sub DropRoleMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropRoleMemberToolStripMenuItem.Click
        Me.txtQuery.Text &= "EXEC sp_droprolemember '<@RoleName>' ," & vbCrLf & _
                    "'<@UserNameInDatabase>'" & vbCrLf
    End Sub
    Private Sub DropServerRoleMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropServerRoleMemberToolStripMenuItem.Click
        Me.txtQuery.Text &= "EXEC sp_dropsrvrolemember '<@LoginName>' ," & vbCrLf & _
                    "'<@RoleName>'" & vbCrLf
    End Sub

    Private Sub GrantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrantToolStripMenuItem.Click
        Me.txtQuery.Text &= "GRANT ALTER,CONTROL,SELECT,EXECUTE,UPDATE,INSERT,DELETE,RECEIVE,REFERENCES,[TAKE OWNERSHIP],[VIEW DEFINITION] ON <@TableName> TO <@UserName>" & vbCrLf
    End Sub
    Private Sub RevokeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevokeToolStripMenuItem.Click
        Me.txtQuery.Text &= "REVOKE ALTER,CONTROL,SELECT,EXECUTE,UPDATE,INSERT,DELETE,RECEIVE,REFERENCES,[TAKE OWNERSHIP],[VIEW DEFINITION] ON <@TableName> TO <@UserName>" & vbCrLf
    End Sub
    Private Sub DenyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DenyToolStripMenuItem.Click
        Me.txtQuery.Text &= "DENY ALTER,CONTROL,SELECT,EXECUTE,UPDATE,INSERT,DELETE,RECEIVE,REFERENCES,[TAKE OWNERSHIP],[VIEW DEFINITION] ON <@TableName> TO <@UserName>" & vbCrLf
    End Sub
#End Region

#Region "Table"
    Private Sub CreateTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateTableToolStripMenuItem.Click
        Me.txtQuery.Text &= "CREATE TABLE <@TableName>" & vbCrLf & _
            "(<PrimaryKeyColumnName0> int Primary Key Clustered identity(1,1)," & vbCrLf & _
            "<@ColumnName1> nvarchar(30) not null," & vbCrLf & _
            "<@ColumnName2> Datetime not null," & vbCrLf & _
            "<@ColumnName3> SmallDatetime not null," & vbCrLf & _
            "<@ColumnName4> Int null," & vbCrLf & _
            "<@ColumnName5> Bit null)" & vbCrLf
    End Sub

    Private Sub AddColumnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddColumnToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER TABLE <@TableName> ADD <@ColumnName> <@DataType> <@Nullable> " & vbCrLf
    End Sub

    Private Sub EditColumnDataTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditColumnDataTypeToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER TABLE <@TableName> ALTER COLUMN <@ColumnName> <@DataType> " & vbCrLf
    End Sub

    Private Sub DeleteColumnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteColumnToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER TABLE <@TableName> DROP COLUMN <@ColumnName>" & vbCrLf
    End Sub

    Private Sub DropTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropTableToolStripMenuItem.Click
        Me.txtQuery.Text &= "DROP TABLE <@DatabaseName>.<@TableName> " & vbCrLf
    End Sub


    Private Sub AddingAColumnWithAConstraintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddingAColumnWithAConstraintToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER TABLE <@TableName> ADD <@ColumnName> <@DataType> <@Nullable> CONSTRAINT <@ConstraintName> UNIQUE" & vbCrLf
    End Sub

    Private Sub AddingCheckConstraintAoAnExistingColumnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddingCheckConstraintAoAnExistingColumnToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER TABLE <@TableName> WITH NOCHECK ADD CONSTRAINT <@ConstraintName> CHECK (<@ColumnName> <@Operator(=,>,<)> '<@CheckValue>')" & vbCrLf
    End Sub

    Private Sub AddingADefaultConstraintToAnExistingColumnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddingADefaultConstraintToAnExistingColumnToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER TABLE <@TableName> ADD CONSTRAINT <@ConstraintName> DEFAULT <@Value> FOR <@ColumnName>" & vbCrLf
    End Sub

    Private Sub ConstraintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConstraintToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER TABLE <@TableName> DROP CONSTRAINT <@ConstraintName>" & vbCrLf
    End Sub

    Private Sub AddingForeignKeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddingForeignKeyToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER TABLE <@TableName> ADD CONSTRAINT <@ConstraintName> FOREIGN KEY (<@ForeignKeyColumnName>) REFERENCES(<@ReferenceDatabase>.<@ReferenceTableName>(<@ReferenceColumn>))" & vbCrLf
    End Sub

    Private Sub DeleteForeignKeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteForeignKeyToolStripMenuItem.Click
        Me.txtQuery.Text = "ALTER TABLE <@TableName> DROP CONSTRAINT <@ConstraintName>" & vbCrLf
    End Sub
#End Region

#Region "Database"
    Private Sub CreateDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateDatabaseToolStripMenuItem.Click
        Me.txtQuery.Text &= "CREATE DATABASE <@DatabaseName> (" & vbCrLf & _
            "NAME = <@DatabaseName> ," & vbCrLf & _
            "FILENAME = '<@PathName>' ," & vbCrLf & _
            "SIZE = <@Size(MB)> ," & vbCrLf & _
            "MAXSIZE = <@MaxSize(MB)> ," & vbCrLf & _
            "FILEGROWTH = <@Growth(%10)> )" & vbCrLf
    End Sub

    Private Sub ModifyDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyDatabaseToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER DATABASE <@DatabaseName> MODIFY NAME = <@NewDatabaseName>" & vbCrLf
    End Sub

    Private Sub AddingAFileToADatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddingAFileToADatabaseToolStripMenuItem.Click
        Me.txtQuery.Text &= "'ALTER DATABASE <@DatabaseName> " & vbCrLf & _
        "ADD(FILE)" & vbCrLf & _
        "(" & vbCrLf & _
            "   NAME = <@AddingFileName>," & vbCrLf & _
            "   FILENAME = '''+ <@AddingFileNamePath> + '<@FileName>.<@FileType(ndf=DataFile,ldf=LogFile)'' ," & vbCrLf & _
            "   SIZE = <@Size>," & vbCrLf & _
            "   MAXSIZE = <@MaxSize> ," & vbCrLf & _
            "   FILEGROWTH = <@Growth(5MB/%15)>" & vbCrLf & _
        ")" & vbCrLf
    End Sub

    Private Sub RemovingAFileFromADatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovingAFileFromADatabaseToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER DATABASE <@DatabaseName> REMOVE FILE <@RemoveFileNameInDatabase>" & vbCrLf
    End Sub

    Private Sub ModifyingAFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyingAFileToolStripMenuItem.Click
        Me.txtQuery.Text &= "ALTER DATABASE <@DatabaseName> " & vbCrLf & _
            "MODIFY(FILE)" & vbCrLf & _
            "   (NAME = <@ModifyFileName> ," & vbCrLf & _
            "   SIZE = <@NewSize> ," & vbCrLf & _
            "   FILENAME = N'<@NewLocation><@FileName.ndf>')" & vbCrLf
    End Sub

    Private Sub DropDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DropDatabaseToolStripMenuItem.Click
        Me.txtQuery.Text &= "USE Master " & vbCrLf & "DROP DATABASE <@DatabaseName>" & vbCrLf
    End Sub
#End Region

#Region "Backup"
    Private Sub FullBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullBackupToolStripMenuItem.Click
        Me.txtQuery.Text &= "USE Master " & vbCrLf & "BACKUP DATABASE <@DatabaseName> TO DISK = '<@BackUpLocation>.bac' WITH INIT" & vbCrLf
    End Sub

    Private Sub DiffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiffToolStripMenuItem.Click
        Me.txtQuery.Text &= "USE Master " & vbCrLf & "BACKUP DATABASE <@DatabaseName> TO DISK = '<@BackUpLocation>.bac' WITH DIFFERENTIAL,INIT" & vbCrLf
    End Sub

    Private Sub FullBackupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullBackupToolStripMenuItem1.Click
        Me.txtQuery.Text &= "USE Master " & vbCrLf & "BACKUP LOG <@DatabaseName> TO DISK = '<@BackUpLocation>.bac' WITH INIT" & vbCrLf
    End Sub

    Private Sub DifferentialBackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DifferentialBackupToolStripMenuItem.Click
        Me.txtQuery.Text &= "USE Master " & vbCrLf & "BACKUP LOG <@DatabaseName> TO DISK = '<@BackUpLocation>.bac' WITH DIFFERENTIAL,INIT" & vbCrLf
    End Sub

    Private Sub NoRecoveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoRecoveryToolStripMenuItem.Click
        Me.txtQuery.Text &= "RESTORE DATABASE <@DatabaseName> FROM DISK = '<@RestoreLocation>.bac' WITH NORECOVERY" & vbCrLf
    End Sub

    Private Sub WithRecoveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithRecoveryToolStripMenuItem.Click
        Me.txtQuery.Text &= "RESTORE DATABASE <@DatabaseName> FROM DISK = '<@RestoreLocation>.bac' WITH RECOVERY" & vbCrLf
    End Sub

    Private Sub NoRecoveryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoRecoveryToolStripMenuItem1.Click
        Me.txtQuery.Text &= "RESTORE LOG <@LogName> FROM DISK = '<@RestoreLocation>.bac' WITH NORECOVERY" & vbCrLf
    End Sub

    Private Sub WithRecoveryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithRecoveryToolStripMenuItem1.Click
        Me.txtQuery.Text &= "RESTORE LOG <@LogName> FROM DISK = '<@RestoreLocation>.bac' WITH RECOVERY" & vbCrLf
    End Sub
#End Region

#Region "Insert,Update,Delete"
    Private Sub InsertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem.Click
        Me.txtQuery.Text &= "INSERT INTO <@TableName>(<@ColumnName1>,<@ColumnName2>,..) " & vbCrLf & _
                "VALUES(<@Column1Value>,<@Column2Value>,..)" & vbCrLf
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Me.txtQuery.Text &= "UPDATE <@TableName> SET (<@ColumnName>='<@Value>',<@ColumnName='<@Value>',..) WHERE <@UpdateColumnName> = '<@UpdateColumnValue>'" & vbCrLf
    End Sub

    Private Sub AllRowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllRowsToolStripMenuItem.Click
        Me.txtQuery.Text &= "DELETE FROM <@TableName>" & vbCrLf
    End Sub

    Private Sub OneRowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OneRowsToolStripMenuItem.Click
        Me.txtQuery.Text &= "DELETE FROM <@TableName> WHERE <@DeleteColumnName> = '<@DeleteColumnValue>'" & vbCrLf
    End Sub
#End Region

#End Region

#Region "XML"
    Private Sub CreateXMLFromTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateXMLFromTableToolStripMenuItem.Click
        Me.SaveFileDialog1.Filter = "XML File(*.xml)|*.xml"

        If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim XML_Writer As WinCreatingXMLFileFromDataTable.XMLFileCreating = New WinCreatingXMLFileFromDataTable.XMLFileCreating
            Dim DT As DataTable = New DataTable

            DT = Me.dgwQueryResult.DataSource
            XML_Writer.CreateXMLFile(DT, Me.SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub CreateTableFromXMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateTableFromXMLToolStripMenuItem.Click
        Me.OpenFileDialog1.Filter = "XML File(*.xml)|*.xml"

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim XML_Reader As WinCreatingXMLFileFromDataTable.XMLFileCreating = New WinCreatingXMLFileFromDataTable.XMLFileCreating
            Dim DT As DataTable = New DataTable

            DT = XML_Reader.ReadXMLFile(Me.OpenFileDialog1.FileName)
            Me.dgwQueryResult.DataSource = DT
        End If
    End Sub
#End Region

#Region "print"
    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If Not Me.dgwQueryResult.DataSource Is Nothing Then
            Dim XML_Writer As WinCreatingXMLFileFromDataTable.XMLFileCreating = New WinCreatingXMLFileFromDataTable.XMLFileCreating
            Dim DT As DataTable = New DataTable

            DT = Me.dgwQueryResult.DataSource
            If System.IO.Directory.Exists(Application.StartupPath & "\SourceData") = False Then
                MkDir(Application.StartupPath & "\SourceData")
            End If
            XML_Writer.CreateXMLFile(DT, Application.StartupPath & "\SourceData\Tablonuz.xml")
            Shell(Application.StartupPath & "\WinHtmlTableOptionsForm.exe", AppWinStyle.NormalFocus)
        End If
    End Sub
#End Region

End Class
