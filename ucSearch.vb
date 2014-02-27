Public Class ucSearch
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAndOr As System.Windows.Forms.ComboBox
    Friend WithEvents txtKriter As System.Windows.Forms.TextBox
    Friend WithEvents cmbTableFields As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbTableFields = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.txtKriter = New System.Windows.Forms.TextBox
        Me.cmbAndOr = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'cmbTableFields
        '
        Me.cmbTableFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTableFields.Location = New System.Drawing.Point(0, 0)
        Me.cmbTableFields.Name = "cmbTableFields"
        Me.cmbTableFields.Size = New System.Drawing.Size(121, 21)
        Me.cmbTableFields.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(120, 0)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'txtKriter
        '
        Me.txtKriter.Location = New System.Drawing.Point(240, 0)
        Me.txtKriter.Name = "txtKriter"
        Me.txtKriter.TabIndex = 2
        Me.txtKriter.Text = ""
        '
        'cmbAndOr
        '
        Me.cmbAndOr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAndOr.Items.AddRange(New Object() {"And", "Or"})
        Me.cmbAndOr.Location = New System.Drawing.Point(344, 0)
        Me.cmbAndOr.Name = "cmbAndOr"
        Me.cmbAndOr.Size = New System.Drawing.Size(72, 21)
        Me.cmbAndOr.TabIndex = 3
        '
        'ucSearch
        '
        Me.Controls.Add(Me.cmbAndOr)
        Me.Controls.Add(Me.txtKriter)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.cmbTableFields)
        Me.Name = "ucSearch"
        Me.Size = New System.Drawing.Size(424, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Event AndOr_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
    
    Private Sub cmbAndOr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAndOr.SelectedIndexChanged
        If cmbAndOr.SelectedIndex <> -1 Then
            RaiseEvent AndOr_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Public Sub AddColumns(ByVal clm As ArrayList)
        For Each str As String In clm
            cmbTableFields.Items.Add(str)
        Next
    End Sub
End Class
