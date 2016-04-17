<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnLoadDatabase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoadDatabase
        '
        Me.btnLoadDatabase.Location = New System.Drawing.Point(90, 101)
        Me.btnLoadDatabase.Name = "btnLoadDatabase"
        Me.btnLoadDatabase.Size = New System.Drawing.Size(156, 71)
        Me.btnLoadDatabase.TabIndex = 0
        Me.btnLoadDatabase.Text = "Load Database"
        Me.btnLoadDatabase.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 263)
        Me.Controls.Add(Me.btnLoadDatabase)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Load Spocosy files to Database"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLoadDatabase As Button
End Class
