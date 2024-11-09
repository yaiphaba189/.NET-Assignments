<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TypeInfo = New Label()
        Number = New TextBox()
        ResultBox = New TextBox()
        Result = New Label()
        Calculate = New Button()
        SuspendLayout()
        ' 
        ' TypeInfo
        ' 
        TypeInfo.AutoSize = True
        TypeInfo.Font = New Font("Arial", 12F)
        TypeInfo.Location = New Point(172, 156)
        TypeInfo.Margin = New Padding(4, 0, 4, 0)
        TypeInfo.Name = "TypeInfo"
        TypeInfo.Size = New Size(150, 23)
        TypeInfo.TabIndex = 0
        TypeInfo.Text = "Enter the Value:"
        ' 
        ' Number
        ' 
        Number.Location = New Point(329, 152)
        Number.Margin = New Padding(4, 4, 4, 4)
        Number.Name = "Number"
        Number.Size = New Size(231, 30)
        Number.TabIndex = 1
        ' 
        ' ResultBox
        ' 
        ResultBox.Location = New Point(329, 208)
        ResultBox.Margin = New Padding(4, 4, 4, 4)
        ResultBox.Name = "ResultBox"
        ResultBox.Size = New Size(265, 30)
        ResultBox.TabIndex = 3
        ' 
        ' Result
        ' 
        Result.AutoSize = True
        Result.Font = New Font("Arial", 12F)
        Result.Location = New Point(232, 210)
        Result.Margin = New Padding(4, 0, 4, 0)
        Result.Name = "Result"
        Result.Size = New Size(92, 23)
        Result.TabIndex = 2
        Result.Text = "Factorial:"
        ' 
        ' Calculate
        ' 
        Calculate.Font = New Font("Arial", 12F)
        Calculate.ForeColor = SystemColors.InactiveCaptionText
        Calculate.Location = New Point(582, 149)
        Calculate.Margin = New Padding(3, 2, 3, 2)
        Calculate.Name = "Calculate"
        Calculate.Size = New Size(109, 34)
        Calculate.TabIndex = 6
        Calculate.Text = "Result"
        Calculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(942, 529)
        Controls.Add(Calculate)
        Controls.Add(ResultBox)
        Controls.Add(Result)
        Controls.Add(Number)
        Controls.Add(TypeInfo)
        Font = New Font("Arial", 12F)
        ForeColor = SystemColors.ButtonHighlight
        Margin = New Padding(4, 4, 4, 4)
        Name = "Form1"
        Text = "Factorial"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TypeInfo As Label
    Friend WithEvents Number As TextBox
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents Result As Label
    Friend WithEvents Calculate As Button

End Class
