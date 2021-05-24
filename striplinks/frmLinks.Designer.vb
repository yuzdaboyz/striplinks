<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLinks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLinks))
        Me.rtxt1 = New System.Windows.Forms.RichTextBox()
        Me.btnStrip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtxt1
        '
        Me.rtxt1.Location = New System.Drawing.Point(9, 9)
        Me.rtxt1.Name = "rtxt1"
        Me.rtxt1.Size = New System.Drawing.Size(1614, 598)
        Me.rtxt1.TabIndex = 0
        Me.rtxt1.Text = ""
        '
        'btnStrip
        '
        Me.btnStrip.Location = New System.Drawing.Point(1626, 9)
        Me.btnStrip.Name = "btnStrip"
        Me.btnStrip.Size = New System.Drawing.Size(87, 103)
        Me.btnStrip.TabIndex = 1
        Me.btnStrip.Text = "Run"
        Me.btnStrip.UseVisualStyleBackColor = True
        '
        'frmLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1716, 616)
        Me.Controls.Add(Me.btnStrip)
        Me.Controls.Add(Me.rtxt1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLinks"
        Me.Text = "Strip Links"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtxt1 As RichTextBox
    Friend WithEvents btnStrip As Button
End Class
