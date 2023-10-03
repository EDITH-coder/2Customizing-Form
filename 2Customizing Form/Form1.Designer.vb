<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnClose = New Button()
        EventHandlerBtn = New Button()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(318, 76)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(188, 78)
        btnClose.TabIndex = 0
        btnClose.Text = "Close Here"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' EventHandlerBtn
        ' 
        EventHandlerBtn.Location = New Point(298, 197)
        EventHandlerBtn.Name = "EventHandlerBtn"
        EventHandlerBtn.Size = New Size(243, 66)
        EventHandlerBtn.TabIndex = 1
        EventHandlerBtn.Text = "Handle Events"
        EventHandlerBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(EventHandlerBtn)
        Controls.Add(btnClose)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents EventHandlerBtn As Button
End Class
