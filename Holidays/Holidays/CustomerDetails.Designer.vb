<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.dtpDateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(12, 217)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(134, 52)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Save details"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(172, 217)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(134, 52)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'dtpDateOfBirth
        '
        Me.dtpDateOfBirth.Location = New System.Drawing.Point(67, 162)
        Me.dtpDateOfBirth.MaxDate = New Date(2200, 1, 1, 0, 0, 0, 0)
        Me.dtpDateOfBirth.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpDateOfBirth.Name = "dtpDateOfBirth"
        Me.dtpDateOfBirth.Size = New System.Drawing.Size(196, 29)
        Me.dtpDateOfBirth.TabIndex = 10
        Me.dtpDateOfBirth.Value = New Date(2017, 3, 27, 0, 0, 0, 0)
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(67, 57)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(196, 29)
        Me.txtFirstName.TabIndex = 9
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(67, 92)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(196, 29)
        Me.txtLastName.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(67, 127)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(196, 29)
        Me.txtEmail.TabIndex = 7
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(67, 22)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(196, 29)
        Me.txtID.TabIndex = 6
        '
        'CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 281)
        Me.Controls.Add(Me.dtpDateOfBirth)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdSave)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "CustomerDetails"
        Me.Text = "CustomerDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents dtpDateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
End Class
