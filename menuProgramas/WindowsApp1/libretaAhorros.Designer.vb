<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class libretaAhorros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListRetiros = New System.Windows.Forms.ListBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListDepositos = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.btnAperturar)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de información"
        '
        'btnAperturar
        '
        Me.btnAperturar.Location = New System.Drawing.Point(483, 59)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(82, 50)
        Me.btnAperturar.TabIndex = 4
        Me.btnAperturar.Text = "Aperturar cuenta"
        Me.btnAperturar.UseVisualStyleBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(204, 98)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(138, 20)
        Me.txtMonto.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(204, 50)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(138, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.btnRetirar)
        Me.GroupBox2.Controls.Add(Me.btnDepositar)
        Me.GroupBox2.Location = New System.Drawing.Point(70, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones"
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(364, 43)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(82, 50)
        Me.btnRetirar.TabIndex = 6
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(210, 43)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(82, 50)
        Me.btnDepositar.TabIndex = 5
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.ListRetiros)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ListDepositos)
        Me.GroupBox3.Location = New System.Drawing.Point(70, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 148)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operaciones"
        '
        'ListRetiros
        '
        Me.ListRetiros.FormattingEnabled = True
        Me.ListRetiros.Location = New System.Drawing.Point(244, 21)
        Me.ListRetiros.Name = "ListRetiros"
        Me.ListRetiros.Size = New System.Drawing.Size(206, 121)
        Me.ListRetiros.TabIndex = 6
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(534, 67)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(466, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Saldo Total"
        '
        'ListDepositos
        '
        Me.ListDepositos.FormattingEnabled = True
        Me.ListDepositos.Location = New System.Drawing.Point(21, 19)
        Me.ListDepositos.Name = "ListDepositos"
        Me.ListDepositos.Size = New System.Drawing.Size(206, 121)
        Me.ListDepositos.TabIndex = 0
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLimpiar.Location = New System.Drawing.Point(464, 501)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(82, 28)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCerrar.Location = New System.Drawing.Point(604, 501)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(82, 28)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'libretaAhorros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 541)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "libretaAhorros"
        Me.Text = "libretaAhorros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAperturar As Button
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListRetiros As ListBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListDepositos As ListBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCerrar As Button
End Class
