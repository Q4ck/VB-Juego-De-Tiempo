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
        lblWord = New Label()
        lblTimer = New Label()
        lblRound = New Label()
        btnSubmit = New Button()
        txtInput = New TextBox()
        cmbDifficulty = New ComboBox()
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' lblWord
        ' 
        lblWord.AutoSize = True
        lblWord.Location = New Point(153, 74)
        lblWord.Name = "lblWord"
        lblWord.Size = New Size(53, 20)
        lblWord.TabIndex = 0
        lblWord.Text = "Label1"
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.Location = New Point(382, 71)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(53, 20)
        lblTimer.TabIndex = 1
        lblTimer.Text = "Label2"
        lblTimer.Visible = False
        ' 
        ' lblRound
        ' 
        lblRound.AutoSize = True
        lblRound.Location = New Point(629, 62)
        lblRound.Name = "lblRound"
        lblRound.Size = New Size(53, 20)
        lblRound.TabIndex = 2
        lblRound.Text = "Label3"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(502, 232)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 3
        btnSubmit.Text = "Button1"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(162, 223)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 4
        ' 
        ' cmbDifficulty
        ' 
        cmbDifficulty.FormattingEnabled = True
        cmbDifficulty.Location = New Point(334, 139)
        cmbDifficulty.Name = "cmbDifficulty"
        cmbDifficulty.Size = New Size(151, 28)
        cmbDifficulty.TabIndex = 5
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(663, 138)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(94, 29)
        btnStart.TabIndex = 6
        btnStart.Text = "btnStart"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnStart)
        Controls.Add(cmbDifficulty)
        Controls.Add(txtInput)
        Controls.Add(btnSubmit)
        Controls.Add(lblRound)
        Controls.Add(lblTimer)
        Controls.Add(lblWord)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWord As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblRound As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents cmbDifficulty As ComboBox
    Friend WithEvents btnStart As Button

End Class
