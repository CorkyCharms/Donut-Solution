<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbFilled = New System.Windows.Forms.RadioButton()
        Me.rbSugar = New System.Windows.Forms.RadioButton()
        Me.rbChocolate = New System.Windows.Forms.RadioButton()
        Me.rbGlazed = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCappuccino = New System.Windows.Forms.RadioButton()
        Me.rbRegular = New System.Windows.Forms.RadioButton()
        Me.rbNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSalestax = New System.Windows.Forms.Label()
        Me.lblTotaldue = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(482, 292)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(69, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(60, 0, 64, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(539, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Our doughnuts and coffee are the best in town!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTitle.UseCompatibleTextRendering = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbFilled)
        Me.GroupBox1.Controls.Add(Me.rbSugar)
        Me.GroupBox1.Controls.Add(Me.rbChocolate)
        Me.GroupBox1.Controls.Add(Me.rbGlazed)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 186)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doughnut choices"
        '
        'rbFilled
        '
        Me.rbFilled.AutoSize = True
        Me.rbFilled.Location = New System.Drawing.Point(25, 151)
        Me.rbFilled.Margin = New System.Windows.Forms.Padding(8)
        Me.rbFilled.Name = "rbFilled"
        Me.rbFilled.Size = New System.Drawing.Size(115, 24)
        Me.rbFilled.TabIndex = 3
        Me.rbFilled.TabStop = True
        Me.rbFilled.Text = "&Filled ($1.50)"
        Me.rbFilled.UseVisualStyleBackColor = True
        '
        'rbSugar
        '
        Me.rbSugar.AutoSize = True
        Me.rbSugar.Location = New System.Drawing.Point(23, 71)
        Me.rbSugar.Margin = New System.Windows.Forms.Padding(8)
        Me.rbSugar.Name = "rbSugar"
        Me.rbSugar.Size = New System.Drawing.Size(117, 24)
        Me.rbSugar.TabIndex = 1
        Me.rbSugar.TabStop = True
        Me.rbSugar.Text = "&Sugar ($1.05)"
        Me.rbSugar.UseVisualStyleBackColor = True
        '
        'rbChocolate
        '
        Me.rbChocolate.AutoSize = True
        Me.rbChocolate.Location = New System.Drawing.Point(25, 111)
        Me.rbChocolate.Margin = New System.Windows.Forms.Padding(8)
        Me.rbChocolate.Name = "rbChocolate"
        Me.rbChocolate.Size = New System.Drawing.Size(146, 24)
        Me.rbChocolate.TabIndex = 2
        Me.rbChocolate.TabStop = True
        Me.rbChocolate.Text = "C&hocolate ($1.25)"
        Me.rbChocolate.UseVisualStyleBackColor = True
        '
        'rbGlazed
        '
        Me.rbGlazed.AutoSize = True
        Me.rbGlazed.Location = New System.Drawing.Point(23, 31)
        Me.rbGlazed.Margin = New System.Windows.Forms.Padding(8)
        Me.rbGlazed.Name = "rbGlazed"
        Me.rbGlazed.Size = New System.Drawing.Size(125, 24)
        Me.rbGlazed.TabIndex = 0
        Me.rbGlazed.TabStop = True
        Me.rbGlazed.Text = "&Glazed ($1.05)"
        Me.rbGlazed.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCappuccino)
        Me.GroupBox2.Controls.Add(Me.rbRegular)
        Me.GroupBox2.Controls.Add(Me.rbNone)
        Me.GroupBox2.Location = New System.Drawing.Point(118, 256)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 153)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee choices"
        '
        'rbCappuccino
        '
        Me.rbCappuccino.AutoSize = True
        Me.rbCappuccino.Location = New System.Drawing.Point(25, 111)
        Me.rbCappuccino.Margin = New System.Windows.Forms.Padding(8)
        Me.rbCappuccino.Name = "rbCappuccino"
        Me.rbCappuccino.Size = New System.Drawing.Size(157, 24)
        Me.rbCappuccino.TabIndex = 2
        Me.rbCappuccino.TabStop = True
        Me.rbCappuccino.Text = "Ca&ppuccino ($2.75)"
        Me.rbCappuccino.UseVisualStyleBackColor = True
        '
        'rbRegular
        '
        Me.rbRegular.AutoSize = True
        Me.rbRegular.Location = New System.Drawing.Point(23, 71)
        Me.rbRegular.Margin = New System.Windows.Forms.Padding(8)
        Me.rbRegular.Name = "rbRegular"
        Me.rbRegular.Size = New System.Drawing.Size(130, 24)
        Me.rbRegular.TabIndex = 1
        Me.rbRegular.TabStop = True
        Me.rbRegular.Text = "&Regular ($1.50)"
        Me.rbRegular.UseVisualStyleBackColor = True
        '
        'rbNone
        '
        Me.rbNone.AutoSize = True
        Me.rbNone.Location = New System.Drawing.Point(25, 31)
        Me.rbNone.Margin = New System.Windows.Forms.Padding(8)
        Me.rbNone.Name = "rbNone"
        Me.rbNone.Size = New System.Drawing.Size(66, 24)
        Me.rbNone.TabIndex = 0
        Me.rbNone.TabStop = True
        Me.rbNone.Text = "&None"
        Me.rbNone.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.lblSalestax)
        Me.GroupBox3.Controls.Add(Me.lblTotaldue)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblSales)
        Me.GroupBox3.Controls.Add(Me.lblSub)
        Me.GroupBox3.Location = New System.Drawing.Point(384, 54)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 186)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubtotal.Location = New System.Drawing.Point(104, 37)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(66, 25)
        Me.lblSubtotal.TabIndex = 1
        '
        'lblSalestax
        '
        Me.lblSalestax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalestax.Location = New System.Drawing.Point(104, 84)
        Me.lblSalestax.Name = "lblSalestax"
        Me.lblSalestax.Size = New System.Drawing.Size(66, 25)
        Me.lblSalestax.TabIndex = 3
        '
        'lblTotaldue
        '
        Me.lblTotaldue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotaldue.Location = New System.Drawing.Point(104, 137)
        Me.lblTotaldue.Name = "lblTotaldue"
        Me.lblTotaldue.Size = New System.Drawing.Size(66, 25)
        Me.lblTotaldue.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(24, 138)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(74, 20)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total due:"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(24, 89)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(70, 20)
        Me.lblSales.TabIndex = 2
        Me.lblSales.Text = "Sales tax:"
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Location = New System.Drawing.Point(24, 37)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(68, 20)
        Me.lblSub.TabIndex = 0
        Me.lblSub.Text = "Subtotal:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(482, 256)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 30)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 418)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donut Shoppe"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnCalculate As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbSugar As RadioButton
    Friend WithEvents rbChocolate As RadioButton
    Friend WithEvents rbGlazed As RadioButton
    Friend WithEvents rbCappuccino As RadioButton
    Friend WithEvents rbRegular As RadioButton
    Friend WithEvents rbNone As RadioButton
    Friend WithEvents rbFilled As RadioButton
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblSalestax As Label
    Friend WithEvents lblTotaldue As Label
End Class
