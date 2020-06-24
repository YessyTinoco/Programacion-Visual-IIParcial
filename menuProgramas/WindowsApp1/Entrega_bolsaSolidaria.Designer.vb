<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrega_bolsaSolidaria
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrega_bolsaSolidaria))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbtnMasculino = New System.Windows.Forms.RadioButton()
        Me.rbtnFemenino = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maskIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmRegular = New System.Windows.Forms.ComboBox()
        Me.CheckExtrema = New System.Windows.Forms.CheckBox()
        Me.CheckPobreza = New System.Windows.Forms.CheckBox()
        Me.cmBasica = New System.Windows.Forms.ComboBox()
        Me.CheckBajo = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckRegular = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBasica = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarHistorial = New System.Windows.Forms.Button()
        Me.dgvEntrega = New System.Windows.Forms.DataGridView()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Municipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Barrio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Integrantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bolsa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmDepartamento = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnGuarrdarHistorial = New System.Windows.Forms.Button()
        Me.btnLiimpiar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvEntrega, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTREGA DE BOLSA SOLIDARIA"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(546, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.rbtnMasculino)
        Me.GroupBox1.Controls.Add(Me.rbtnFemenino)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.maskIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 200)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información personal"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(167, 169)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(40, 21)
        Me.txtCantidad.TabIndex = 32
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(145, 77)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 21)
        Me.txtNombre.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cantidad de integrantes"
        '
        'rbtnMasculino
        '
        Me.rbtnMasculino.AutoSize = True
        Me.rbtnMasculino.Location = New System.Drawing.Point(182, 134)
        Me.rbtnMasculino.Name = "rbtnMasculino"
        Me.rbtnMasculino.Size = New System.Drawing.Size(82, 19)
        Me.rbtnMasculino.TabIndex = 6
        Me.rbtnMasculino.TabStop = True
        Me.rbtnMasculino.Text = "Masculino"
        Me.rbtnMasculino.UseVisualStyleBackColor = True
        '
        'rbtnFemenino
        '
        Me.rbtnFemenino.AutoSize = True
        Me.rbtnFemenino.Location = New System.Drawing.Point(49, 134)
        Me.rbtnFemenino.Name = "rbtnFemenino"
        Me.rbtnFemenino.Size = New System.Drawing.Size(81, 19)
        Me.rbtnFemenino.TabIndex = 5
        Me.rbtnFemenino.TabStop = True
        Me.rbtnFemenino.Text = "Femenino"
        Me.rbtnFemenino.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre "
        '
        'maskIdentidad
        '
        Me.maskIdentidad.Location = New System.Drawing.Point(145, 33)
        Me.maskIdentidad.Mask = "0000-0000-00000"
        Me.maskIdentidad.Name = "maskIdentidad"
        Me.maskIdentidad.Size = New System.Drawing.Size(106, 21)
        Me.maskIdentidad.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Identidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmRegular)
        Me.GroupBox2.Controls.Add(Me.CheckExtrema)
        Me.GroupBox2.Controls.Add(Me.CheckPobreza)
        Me.GroupBox2.Controls.Add(Me.cmBasica)
        Me.GroupBox2.Controls.Add(Me.CheckBajo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CheckRegular)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CheckBasica)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 139)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alimento Solidario"
        '
        'cmRegular
        '
        Me.cmRegular.FormattingEnabled = True
        Me.cmRegular.Items.AddRange(New Object() {"Kit de medicamentos", "Azúcar", "Manteca", "Harina de maíz", "Café ", "Cereal fortificado", "Espagueti", "Arroz blanco", "Frijoles", "Leche ", "Avena"})
        Me.cmRegular.Location = New System.Drawing.Point(399, 80)
        Me.cmRegular.Name = "cmRegular"
        Me.cmRegular.Size = New System.Drawing.Size(110, 21)
        Me.cmRegular.TabIndex = 23
        Me.cmRegular.Text = "Detalles del contenido"
        '
        'CheckExtrema
        '
        Me.CheckExtrema.AutoSize = True
        Me.CheckExtrema.Location = New System.Drawing.Point(45, 107)
        Me.CheckExtrema.Name = "CheckExtrema"
        Me.CheckExtrema.Size = New System.Drawing.Size(105, 17)
        Me.CheckExtrema.TabIndex = 12
        Me.CheckExtrema.Text = "Pobreza extrema"
        Me.CheckExtrema.UseVisualStyleBackColor = True
        '
        'CheckPobreza
        '
        Me.CheckPobreza.AutoSize = True
        Me.CheckPobreza.Location = New System.Drawing.Point(45, 77)
        Me.CheckPobreza.Name = "CheckPobreza"
        Me.CheckPobreza.Size = New System.Drawing.Size(65, 17)
        Me.CheckPobreza.TabIndex = 11
        Me.CheckPobreza.Text = "Pobreza"
        Me.CheckPobreza.UseVisualStyleBackColor = True
        '
        'cmBasica
        '
        Me.cmBasica.FormattingEnabled = True
        Me.cmBasica.Items.AddRange(New Object() {"Kit de medicamentos", "Azúcar", "Manteca", "Harina de maíz", "Café ", "Frijoles"})
        Me.cmBasica.Location = New System.Drawing.Point(258, 80)
        Me.cmBasica.Name = "cmBasica"
        Me.cmBasica.Size = New System.Drawing.Size(110, 21)
        Me.cmBasica.TabIndex = 22
        Me.cmBasica.Text = "Detalles del contenido"
        '
        'CheckBajo
        '
        Me.CheckBajo.AutoSize = True
        Me.CheckBajo.Location = New System.Drawing.Point(45, 48)
        Me.CheckBajo.Name = "CheckBajo"
        Me.CheckBajo.Size = New System.Drawing.Size(155, 17)
        Me.CheckBajo.TabIndex = 10
        Me.CheckBajo.Text = "Bajos recursos económicos"
        Me.CheckBajo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Estado"
        '
        'CheckRegular
        '
        Me.CheckRegular.AutoSize = True
        Me.CheckRegular.Location = New System.Drawing.Point(399, 51)
        Me.CheckRegular.Name = "CheckRegular"
        Me.CheckRegular.Size = New System.Drawing.Size(92, 17)
        Me.CheckRegular.TabIndex = 21
        Me.CheckRegular.Text = "Bolsa Regular"
        Me.CheckRegular.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(232, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tipo de bolsa"
        '
        'CheckBasica
        '
        Me.CheckBasica.AutoSize = True
        Me.CheckBasica.Location = New System.Drawing.Point(258, 51)
        Me.CheckBasica.Name = "CheckBasica"
        Me.CheckBasica.Size = New System.Drawing.Size(87, 17)
        Me.CheckBasica.TabIndex = 20
        Me.CheckBasica.Text = "Bolsa Básica"
        Me.CheckBasica.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpiarHistorial)
        Me.GroupBox3.Controls.Add(Me.dgvEntrega)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 439)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(715, 133)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'btnLimpiarHistorial
        '
        Me.btnLimpiarHistorial.BackgroundImage = CType(resources.GetObject("btnLimpiarHistorial.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiarHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiarHistorial.FlatAppearance.BorderSize = 0
        Me.btnLimpiarHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpiarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarHistorial.Location = New System.Drawing.Point(662, 61)
        Me.btnLimpiarHistorial.Name = "btnLimpiarHistorial"
        Me.btnLimpiarHistorial.Size = New System.Drawing.Size(42, 37)
        Me.btnLimpiarHistorial.TabIndex = 2
        Me.btnLimpiarHistorial.UseVisualStyleBackColor = True
        '
        'dgvEntrega
        '
        Me.dgvEntrega.AllowUserToAddRows = False
        Me.dgvEntrega.AllowUserToDeleteRows = False
        Me.dgvEntrega.AllowUserToOrderColumns = True
        Me.dgvEntrega.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntrega.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identidad, Me.Nombre, Me.Sexo, Me.Departamento, Me.Municipio, Me.Barrio, Me.Integrantes, Me.Estado, Me.Bolsa})
        Me.dgvEntrega.Location = New System.Drawing.Point(9, 19)
        Me.dgvEntrega.Name = "dgvEntrega"
        Me.dgvEntrega.ReadOnly = True
        Me.dgvEntrega.Size = New System.Drawing.Size(642, 108)
        Me.dgvEntrega.TabIndex = 0
        '
        'Identidad
        '
        Me.Identidad.HeaderText = "Número de identidad"
        Me.Identidad.Name = "Identidad"
        Me.Identidad.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'Departamento
        '
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        '
        'Municipio
        '
        Me.Municipio.HeaderText = "Municipio"
        Me.Municipio.Name = "Municipio"
        Me.Municipio.ReadOnly = True
        '
        'Barrio
        '
        Me.Barrio.HeaderText = "Barrio o Colonia"
        Me.Barrio.Name = "Barrio"
        Me.Barrio.ReadOnly = True
        '
        'Integrantes
        '
        Me.Integrantes.HeaderText = "Cantidad de integrantes"
        Me.Integrantes.Name = "Integrantes"
        Me.Integrantes.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Bolsa
        '
        Me.Bolsa.HeaderText = "Tipo de bolsa "
        Me.Bolsa.Name = "Bolsa"
        Me.Bolsa.ReadOnly = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(534, 169)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(41, 38)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(12, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 33)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtBarrio)
        Me.GroupBox4.Controls.Add(Me.txtMunicipio)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cmDepartamento)
        Me.GroupBox4.Location = New System.Drawing.Point(381, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 132)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dirección"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(145, 100)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(150, 20)
        Me.txtBarrio.TabIndex = 31
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(145, 65)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(150, 20)
        Me.txtMunicipio.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 15)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Barrio o Colonia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Municipio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Departamento"
        '
        'cmDepartamento
        '
        Me.cmDepartamento.FormattingEnabled = True
        Me.cmDepartamento.Items.AddRange(New Object() {"Francisco Morazán", "Comayagua", "Olancho", "Copán", "Intibucá", "Gracias a Dios", "La Paz", "El Paraíso", "Atlántida", "Islas de la Bahía", "Yoro", "Colón", "Ocotepeque", "Santa Bárbara", "Valle", "Cortés", "Choluteca", "Lempira"})
        Me.cmDepartamento.Location = New System.Drawing.Point(145, 31)
        Me.cmDepartamento.Name = "cmDepartamento"
        Me.cmDepartamento.Size = New System.Drawing.Size(150, 21)
        Me.cmDepartamento.TabIndex = 26
        Me.cmDepartamento.Text = "Seleccione un departamento"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.btnGuardar)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(750, 225)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'btnGuarrdarHistorial
        '
        Me.btnGuarrdarHistorial.FlatAppearance.BorderSize = 0
        Me.btnGuarrdarHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnGuarrdarHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuarrdarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuarrdarHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuarrdarHistorial.Location = New System.Drawing.Point(588, 370)
        Me.btnGuarrdarHistorial.Name = "btnGuarrdarHistorial"
        Me.btnGuarrdarHistorial.Size = New System.Drawing.Size(75, 48)
        Me.btnGuarrdarHistorial.TabIndex = 6
        Me.btnGuarrdarHistorial.Text = "Mostrar Historial"
        Me.btnGuarrdarHistorial.UseVisualStyleBackColor = True
        '
        'btnLiimpiar
        '
        Me.btnLiimpiar.FlatAppearance.BorderSize = 0
        Me.btnLiimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLiimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLiimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiimpiar.Location = New System.Drawing.Point(588, 309)
        Me.btnLiimpiar.Name = "btnLiimpiar"
        Me.btnLiimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLiimpiar.TabIndex = 7
        Me.btnLiimpiar.Text = "Limpiar"
        Me.btnLiimpiar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Entrega_bolsaSolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 580)
        Me.Controls.Add(Me.btnLiimpiar)
        Me.Controls.Add(Me.btnGuarrdarHistorial)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Entrega_bolsaSolidaria"
        Me.Text = "Entrega_bolsaSolidaria"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvEntrega, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rbtnMasculino As RadioButton
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents maskIdentidad As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckExtrema As CheckBox
    Friend WithEvents CheckPobreza As CheckBox
    Friend WithEvents CheckBajo As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLimpiarHistorial As Button
    Friend WithEvents dgvEntrega As DataGridView
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Departamento As DataGridViewTextBoxColumn
    Friend WithEvents Municipio As DataGridViewTextBoxColumn
    Friend WithEvents Barrio As DataGridViewTextBoxColumn
    Friend WithEvents Integrantes As DataGridViewTextBoxColumn
    Friend WithEvents Esstado As DataGridViewTextBoxColumn
    Friend WithEvents Bolsa As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmDepartamento As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents cmRegular As ComboBox
    Friend WithEvents cmBasica As ComboBox
    Friend WithEvents CheckRegular As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckBasica As CheckBox
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnGuarrdarHistorial As Button
    Friend WithEvents btnLiimpiar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
