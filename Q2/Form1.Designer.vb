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
        Resultbt = New Button()
        Even = New TextBox()
        Termbox = New TextBox()
        Odd = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Resultbt
        ' 
        Resultbt.Location = New Point(422, 117)
        Resultbt.Name = "Resultbt"
        Resultbt.Size = New Size(131, 36)
        Resultbt.TabIndex = 0
        Resultbt.Text = "Result"
        Resultbt.UseVisualStyleBackColor = True
        ' 
        ' Even
        ' 
        Even.Location = New Point(115, 217)
        Even.Multiline = True
        Even.Name = "Even"
        Even.Size = New Size(257, 82)
        Even.TabIndex = 1
        ' 
        ' Termbox
        ' 
        Termbox.Location = New Point(281, 117)
        Termbox.Multiline = True
        Termbox.Name = "Termbox"
        Termbox.Size = New Size(131, 32)
        Termbox.TabIndex = 2
        ' 
        ' Odd
        ' 
        Odd.Location = New Point(411, 217)
        Odd.Multiline = True
        Odd.Name = "Odd"
        Odd.Size = New Size(261, 82)
        Odd.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(184, 125)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 4
        Label1.Text = "Enter term"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(115, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 20)
        Label2.TabIndex = 5
        Label2.Text = "Even Number List"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 20)
        Label3.TabIndex = 6
        Label3.Text = "Odd Number List"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Bisque
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Odd)
        Controls.Add(Termbox)
        Controls.Add(Even)
        Controls.Add(Resultbt)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Resultbt As Button
    Friend WithEvents Even As TextBox
    Friend WithEvents Termbox As TextBox
    Friend WithEvents Odd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
