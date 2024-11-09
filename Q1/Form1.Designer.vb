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
        Number1 = New TextBox()
        Number2 = New TextBox()
        Result = New TextBox()
        Addbt = New Button()
        Subbt = New Button()
        Mulbt = New Button()
        Divbt = New Button()
        Powbt = New Button()
        Clearbt = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Number1
        ' 
        Number1.Location = New Point(212, 183)
        Number1.Multiline = True
        Number1.Name = "Number1"
        Number1.Size = New Size(63, 35)
        Number1.TabIndex = 0
        ' 
        ' Number2
        ' 
        Number2.Location = New Point(311, 183)
        Number2.Multiline = True
        Number2.Name = "Number2"
        Number2.Size = New Size(61, 35)
        Number2.TabIndex = 1
        ' 
        ' Result
        ' 
        Result.Location = New Point(418, 183)
        Result.Multiline = True
        Result.Name = "Result"
        Result.Size = New Size(125, 35)
        Result.TabIndex = 2
        ' 
        ' Addbt
        ' 
        Addbt.Font = New Font("Segoe UI", 12F)
        Addbt.Location = New Point(412, 252)
        Addbt.Name = "Addbt"
        Addbt.Size = New Size(42, 39)
        Addbt.TabIndex = 3
        Addbt.Text = "+"
        Addbt.UseVisualStyleBackColor = True
        ' 
        ' Subbt
        ' 
        Subbt.Font = New Font("Segoe UI", 12F)
        Subbt.Location = New Point(105, 252)
        Subbt.Name = "Subbt"
        Subbt.Size = New Size(42, 39)
        Subbt.TabIndex = 4
        Subbt.Text = "-"
        Subbt.UseVisualStyleBackColor = True
        ' 
        ' Mulbt
        ' 
        Mulbt.Font = New Font("Segoe UI", 12F)
        Mulbt.Location = New Point(203, 252)
        Mulbt.Name = "Mulbt"
        Mulbt.Size = New Size(42, 39)
        Mulbt.TabIndex = 5
        Mulbt.Text = "x"
        Mulbt.UseVisualStyleBackColor = True
        ' 
        ' Divbt
        ' 
        Divbt.Font = New Font("Segoe UI", 12F)
        Divbt.Location = New Point(510, 252)
        Divbt.Name = "Divbt"
        Divbt.Size = New Size(42, 39)
        Divbt.TabIndex = 6
        Divbt.Text = "/"
        Divbt.UseVisualStyleBackColor = True
        ' 
        ' Powbt
        ' 
        Powbt.Font = New Font("Segoe UI", 12F)
        Powbt.Location = New Point(309, 252)
        Powbt.Name = "Powbt"
        Powbt.Size = New Size(42, 39)
        Powbt.TabIndex = 7
        Powbt.Text = "^"
        Powbt.UseVisualStyleBackColor = True
        ' 
        ' Clearbt
        ' 
        Clearbt.Font = New Font("Segoe UI", 12F)
        Clearbt.Location = New Point(616, 252)
        Clearbt.Name = "Clearbt"
        Clearbt.Size = New Size(42, 39)
        Clearbt.TabIndex = 8
        Clearbt.Text = "C"
        Clearbt.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(212, 147)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 9
        Label1.Text = "Frist no."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(312, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 10
        Label2.Text = "Second No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(418, 147)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 11
        Label3.Text = "Result"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 30F)
        Label4.Location = New Point(232, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(248, 67)
        Label4.TabIndex = 12
        Label4.Text = "Calculator"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Chartreuse
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Clearbt)
        Controls.Add(Powbt)
        Controls.Add(Divbt)
        Controls.Add(Mulbt)
        Controls.Add(Subbt)
        Controls.Add(Addbt)
        Controls.Add(Result)
        Controls.Add(Number2)
        Controls.Add(Number1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Number1 As TextBox
    Friend WithEvents Number2 As TextBox
    Friend WithEvents Result As TextBox
    Friend WithEvents Addbt As Button
    Friend WithEvents Subbt As Button
    Friend WithEvents Mulbt As Button
    Friend WithEvents Divbt As Button
    Friend WithEvents Powbt As Button
    Friend WithEvents Clearbt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
