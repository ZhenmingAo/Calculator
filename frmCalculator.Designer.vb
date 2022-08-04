<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculator))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEquation = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnExponent = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMC = New System.Windows.Forms.Button()
        Me.btnMR = New System.Windows.Forms.Button()
        Me.btnMS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(71, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input:"
        '
        'lblMemory
        '
        Me.lblMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMemory.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMemory.Location = New System.Drawing.Point(145, 188)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Size = New System.Drawing.Size(195, 30)
        Me.lblMemory.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(38, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 30)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Memory:"
        '
        'lblEquation
        '
        Me.lblEquation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEquation.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEquation.Location = New System.Drawing.Point(145, 286)
        Me.lblEquation.Name = "lblEquation"
        Me.lblEquation.Size = New System.Drawing.Size(175, 30)
        Me.lblEquation.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(37, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 30)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Equation:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResult.Location = New System.Drawing.Point(145, 328)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(175, 30)
        Me.lblResult.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(64, 329)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 30)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Result:"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtInput.Location = New System.Drawing.Point(145, 88)
        Me.txtInput.MaxLength = 5
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(195, 36)
        Me.txtInput.TabIndex = 8
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(402, 287)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 35)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(402, 328)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 35)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEqual
        '
        Me.btnEqual.AutoSize = True
        Me.btnEqual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEqual.Location = New System.Drawing.Point(402, 246)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(121, 35)
        Me.btnEqual.TabIndex = 11
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.AutoSize = True
        Me.btnMod.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMod.Location = New System.Drawing.Point(498, 130)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(61, 40)
        Me.btnMod.TabIndex = 17
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.AutoSize = True
        Me.btnMultiply.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiply.Location = New System.Drawing.Point(498, 84)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(61, 40)
        Me.btnMultiply.TabIndex = 18
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.AutoSize = True
        Me.btnDivide.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDivide.Location = New System.Drawing.Point(431, 130)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(61, 40)
        Me.btnDivide.TabIndex = 19
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnExponent
        '
        Me.btnExponent.AutoSize = True
        Me.btnExponent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExponent.Location = New System.Drawing.Point(364, 130)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(61, 40)
        Me.btnExponent.TabIndex = 20
        Me.btnExponent.Text = "^"
        Me.btnExponent.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.AutoSize = True
        Me.btnSubtract.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtract.Location = New System.Drawing.Point(431, 84)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(61, 40)
        Me.btnSubtract.TabIndex = 21
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(364, 84)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(61, 40)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMC
        '
        Me.btnMC.AutoSize = True
        Me.btnMC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMC.Location = New System.Drawing.Point(145, 145)
        Me.btnMC.Name = "btnMC"
        Me.btnMC.Size = New System.Drawing.Size(61, 40)
        Me.btnMC.TabIndex = 23
        Me.btnMC.Text = "MC"
        Me.btnMC.UseVisualStyleBackColor = True
        '
        'btnMR
        '
        Me.btnMR.AutoSize = True
        Me.btnMR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMR.Location = New System.Drawing.Point(212, 145)
        Me.btnMR.Name = "btnMR"
        Me.btnMR.Size = New System.Drawing.Size(61, 40)
        Me.btnMR.TabIndex = 24
        Me.btnMR.Text = "MR"
        Me.btnMR.UseVisualStyleBackColor = True
        '
        'btnMS
        '
        Me.btnMS.AutoSize = True
        Me.btnMS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMS.Location = New System.Drawing.Point(279, 145)
        Me.btnMS.Name = "btnMS"
        Me.btnMS.Size = New System.Drawing.Size(61, 40)
        Me.btnMS.TabIndex = 25
        Me.btnMS.Text = "MS"
        Me.btnMS.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(145, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "* Limited to 5 digit numbers only"
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnMS)
        Me.Controls.Add(Me.btnMR)
        Me.Controls.Add(Me.btnMC)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnExponent)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblEquation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMemory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblMemory As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEquation As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnExponent As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnMC As Button
    Friend WithEvents btnMR As Button
    Friend WithEvents btnMS As Button
    Friend WithEvents Label2 As Label
End Class
