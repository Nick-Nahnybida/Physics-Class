<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtV2i = New System.Windows.Forms.TextBox()
        Me.txtV2f = New System.Windows.Forms.TextBox()
        Me.txtV1i = New System.Windows.Forms.TextBox()
        Me.txtV1f = New System.Windows.Forms.TextBox()
        Me.txtM2 = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblM1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "M1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "M2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "V1 f:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "V1 i:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "V2 f:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "V2 i:"
        '
        'txtV2i
        '
        Me.txtV2i.Location = New System.Drawing.Point(107, 193)
        Me.txtV2i.Name = "txtV2i"
        Me.txtV2i.Size = New System.Drawing.Size(100, 20)
        Me.txtV2i.TabIndex = 7
        '
        'txtV2f
        '
        Me.txtV2f.Location = New System.Drawing.Point(107, 156)
        Me.txtV2f.Name = "txtV2f"
        Me.txtV2f.Size = New System.Drawing.Size(100, 20)
        Me.txtV2f.TabIndex = 8
        '
        'txtV1i
        '
        Me.txtV1i.Location = New System.Drawing.Point(107, 109)
        Me.txtV1i.Name = "txtV1i"
        Me.txtV1i.Size = New System.Drawing.Size(100, 20)
        Me.txtV1i.TabIndex = 9
        '
        'txtV1f
        '
        Me.txtV1f.Location = New System.Drawing.Point(107, 70)
        Me.txtV1f.Name = "txtV1f"
        Me.txtV1f.Size = New System.Drawing.Size(100, 20)
        Me.txtV1f.TabIndex = 10
        '
        'txtM2
        '
        Me.txtM2.Location = New System.Drawing.Point(107, 26)
        Me.txtM2.Name = "txtM2"
        Me.txtM2.Size = New System.Drawing.Size(100, 20)
        Me.txtM2.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(52, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(180, 326)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblM1
        '
        Me.lblM1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblM1.Location = New System.Drawing.Point(107, 259)
        Me.lblM1.Name = "lblM1"
        Me.lblM1.Size = New System.Drawing.Size(100, 23)
        Me.lblM1.TabIndex = 14
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(319, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 448)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblM1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtM2)
        Me.Controls.Add(Me.txtV1f)
        Me.Controls.Add(Me.txtV1i)
        Me.Controls.Add(Me.txtV2f)
        Me.Controls.Add(Me.txtV2i)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Collision Model"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtV2i As System.Windows.Forms.TextBox
    Friend WithEvents txtV2f As System.Windows.Forms.TextBox
    Friend WithEvents txtV1i As System.Windows.Forms.TextBox
    Friend WithEvents txtV1f As System.Windows.Forms.TextBox
    Friend WithEvents txtM2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblM1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
