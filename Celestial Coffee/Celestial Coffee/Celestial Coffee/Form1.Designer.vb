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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRegular = New System.Windows.Forms.Label()
        Me.lblLbs1 = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblDecaf = New System.Windows.Forms.Label()
        Me.lblLbs2 = New System.Windows.Forms.Label()
        Me.txtRegular = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDecaf = New System.Windows.Forms.TextBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lstMessage = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Celestial Coffee"
        '
        'lblRegular
        '
        Me.lblRegular.AutoSize = True
        Me.lblRegular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegular.Location = New System.Drawing.Point(490, 145)
        Me.lblRegular.Name = "lblRegular"
        Me.lblRegular.Size = New System.Drawing.Size(76, 24)
        Me.lblRegular.TabIndex = 1
        Me.lblRegular.Text = "Regular"
        Me.lblRegular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLbs1
        '
        Me.lblLbs1.AutoSize = True
        Me.lblLbs1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLbs1.Location = New System.Drawing.Point(735, 145)
        Me.lblLbs1.Name = "lblLbs1"
        Me.lblLbs1.Size = New System.Drawing.Size(39, 24)
        Me.lblLbs1.TabIndex = 5
        Me.lblLbs1.Text = "lbs."
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(60, 746)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(88, 24)
        Me.lblZip.TabIndex = 6
        Me.lblZip.Text = "Zip Code"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(97, 693)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(51, 24)
        Me.lblState.TabIndex = 7
        Me.lblState.Text = "State"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(108, 636)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(40, 24)
        Me.lblCity.TabIndex = 8
        Me.lblCity.Text = "City"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(68, 577)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(80, 24)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(87, 522)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 24)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollars.Location = New System.Drawing.Point(546, 377)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(20, 24)
        Me.lblDollars.TabIndex = 11
        Me.lblDollars.Text = "$"
        Me.lblDollars.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDecaf
        '
        Me.lblDecaf.AutoSize = True
        Me.lblDecaf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecaf.Location = New System.Drawing.Point(508, 199)
        Me.lblDecaf.Name = "lblDecaf"
        Me.lblDecaf.Size = New System.Drawing.Size(58, 24)
        Me.lblDecaf.TabIndex = 12
        Me.lblDecaf.Text = "Decaf"
        Me.lblDecaf.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLbs2
        '
        Me.lblLbs2.AutoSize = True
        Me.lblLbs2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLbs2.Location = New System.Drawing.Point(735, 199)
        Me.lblLbs2.Name = "lblLbs2"
        Me.lblLbs2.Size = New System.Drawing.Size(39, 24)
        Me.lblLbs2.TabIndex = 13
        Me.lblLbs2.Text = "lbs."
        '
        'txtRegular
        '
        Me.txtRegular.Location = New System.Drawing.Point(576, 149)
        Me.txtRegular.Name = "txtRegular"
        Me.txtRegular.Size = New System.Drawing.Size(153, 20)
        Me.txtRegular.TabIndex = 14
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(158, 750)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(153, 20)
        Me.txtZip.TabIndex = 15
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(158, 697)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(153, 20)
        Me.txtState.TabIndex = 16
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(158, 640)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(153, 20)
        Me.txtCity.TabIndex = 17
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(158, 581)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(153, 20)
        Me.txtAddress.TabIndex = 18
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(158, 526)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(153, 20)
        Me.txtName.TabIndex = 19
        '
        'txtDecaf
        '
        Me.txtDecaf.Location = New System.Drawing.Point(576, 203)
        Me.txtDecaf.Name = "txtDecaf"
        Me.txtDecaf.Size = New System.Drawing.Size(153, 20)
        Me.txtDecaf.TabIndex = 21
        '
        'btnTotal
        '
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(576, 247)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(153, 105)
        Me.btnTotal.TabIndex = 22
        Me.btnTotal.Text = "Calculate Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(735, 377)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(99, 24)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "Total Price"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(73, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 385)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(576, 381)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(153, 20)
        Me.txtTotal.TabIndex = 27
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(405, 541)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(153, 105)
        Me.btnOrder.TabIndex = 28
        Me.btnOrder.Text = "Confirm Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lstMessage
        '
        Me.lstMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMessage.FormattingEnabled = True
        Me.lstMessage.ItemHeight = 25
        Me.lstMessage.Location = New System.Drawing.Point(603, 486)
        Me.lstMessage.Name = "lstMessage"
        Me.lstMessage.Size = New System.Drawing.Size(326, 304)
        Me.lstMessage.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(999, 834)
        Me.Controls.Add(Me.lstMessage)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.txtDecaf)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtRegular)
        Me.Controls.Add(Me.lblLbs2)
        Me.Controls.Add(Me.lblDecaf)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblLbs1)
        Me.Controls.Add(Me.lblRegular)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblRegular As Label
    Friend WithEvents lblLbs1 As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDollars As Label
    Friend WithEvents lblDecaf As Label
    Friend WithEvents lblLbs2 As Label
    Friend WithEvents txtRegular As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDecaf As TextBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents lstMessage As ListBox
End Class
