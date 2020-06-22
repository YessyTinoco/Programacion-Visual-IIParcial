<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelSubMenuTa = New System.Windows.Forms.Panel()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.btnAhorros = New System.Windows.Forms.Button()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.panelSubmenu = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnLibreta = New System.Windows.Forms.Button()
        Me.btnArreglo = New System.Windows.Forms.Button()
        Me.btnEjerciciosClase = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.btnMenuu = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tmOCULTAR = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.panelTitulo.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        Me.panelSubMenuTa.SuspendLayout()
        Me.panelSubmenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.btnMenuu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChildForm.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.Turquoise
        Me.panelTitulo.Controls.Add(Me.btnRestaurar)
        Me.panelTitulo.Controls.Add(Me.btnMaximizar)
        Me.panelTitulo.Controls.Add(Me.btnMinimizar)
        Me.panelTitulo.Controls.Add(Me.btnSalir)
        Me.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(1000, 40)
        Me.panelTitulo.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), System.Drawing.Image)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(868, 3)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(33, 34)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(868, 3)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(33, 34)
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(813, 3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(33, 34)
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(930, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(33, 34)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.AutoScroll = True
        Me.panelMenu.BackColor = System.Drawing.Color.Black
        Me.panelMenu.Controls.Add(Me.panelSubMenuTa)
        Me.panelMenu.Controls.Add(Me.btnTareas)
        Me.panelMenu.Controls.Add(Me.panelSubmenu)
        Me.panelMenu.Controls.Add(Me.btnEjerciciosClase)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 40)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(220, 580)
        Me.panelMenu.TabIndex = 1
        '
        'panelSubMenuTa
        '
        Me.panelSubMenuTa.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelSubMenuTa.Controls.Add(Me.Button18)
        Me.panelSubMenuTa.Controls.Add(Me.Button10)
        Me.panelSubMenuTa.Controls.Add(Me.Button11)
        Me.panelSubMenuTa.Controls.Add(Me.Button12)
        Me.panelSubMenuTa.Controls.Add(Me.Button13)
        Me.panelSubMenuTa.Controls.Add(Me.Button14)
        Me.panelSubMenuTa.Controls.Add(Me.Button15)
        Me.panelSubMenuTa.Controls.Add(Me.Button16)
        Me.panelSubMenuTa.Controls.Add(Me.btnAhorros)
        Me.panelSubMenuTa.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubMenuTa.Location = New System.Drawing.Point(0, 336)
        Me.panelSubMenuTa.Name = "panelSubMenuTa"
        Me.panelSubMenuTa.Size = New System.Drawing.Size(220, 229)
        Me.panelSubMenuTa.TabIndex = 4
        '
        'Button18
        '
        Me.Button18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button18.FlatAppearance.BorderSize = 0
        Me.Button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button18.Location = New System.Drawing.Point(0, 200)
        Me.Button18.Name = "Button18"
        Me.Button18.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button18.Size = New System.Drawing.Size(220, 25)
        Me.Button18.TabIndex = 16
        Me.Button18.Text = "Button18"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button10.Location = New System.Drawing.Point(0, 175)
        Me.Button10.Name = "Button10"
        Me.Button10.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button10.Size = New System.Drawing.Size(220, 25)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "Button10"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button11.Location = New System.Drawing.Point(0, 150)
        Me.Button11.Name = "Button11"
        Me.Button11.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button11.Size = New System.Drawing.Size(220, 25)
        Me.Button11.TabIndex = 14
        Me.Button11.Text = "Button11"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button12.Location = New System.Drawing.Point(0, 125)
        Me.Button12.Name = "Button12"
        Me.Button12.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button12.Size = New System.Drawing.Size(220, 25)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "Button12"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button13.Location = New System.Drawing.Point(0, 100)
        Me.Button13.Name = "Button13"
        Me.Button13.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button13.Size = New System.Drawing.Size(220, 25)
        Me.Button13.TabIndex = 12
        Me.Button13.Text = "Button13"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button14.Location = New System.Drawing.Point(0, 75)
        Me.Button14.Name = "Button14"
        Me.Button14.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button14.Size = New System.Drawing.Size(220, 25)
        Me.Button14.TabIndex = 11
        Me.Button14.Text = "Button14"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button15.Location = New System.Drawing.Point(0, 50)
        Me.Button15.Name = "Button15"
        Me.Button15.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button15.Size = New System.Drawing.Size(220, 25)
        Me.Button15.TabIndex = 10
        Me.Button15.Text = "Button15"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button16.FlatAppearance.BorderSize = 0
        Me.Button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button16.Location = New System.Drawing.Point(0, 25)
        Me.Button16.Name = "Button16"
        Me.Button16.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button16.Size = New System.Drawing.Size(220, 25)
        Me.Button16.TabIndex = 9
        Me.Button16.Text = "Button16"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.UseVisualStyleBackColor = True
        '
        'btnAhorros
        '
        Me.btnAhorros.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAhorros.FlatAppearance.BorderSize = 0
        Me.btnAhorros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAhorros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnAhorros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAhorros.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAhorros.Location = New System.Drawing.Point(0, 0)
        Me.btnAhorros.Name = "btnAhorros"
        Me.btnAhorros.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.btnAhorros.Size = New System.Drawing.Size(220, 25)
        Me.btnAhorros.TabIndex = 8
        Me.btnAhorros.Text = "Libreta de Ahorros"
        Me.btnAhorros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAhorros.UseVisualStyleBackColor = True
        '
        'btnTareas
        '
        Me.btnTareas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTareas.FlatAppearance.BorderSize = 0
        Me.btnTareas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTareas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTareas.Location = New System.Drawing.Point(0, 296)
        Me.btnTareas.Name = "btnTareas"
        Me.btnTareas.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnTareas.Size = New System.Drawing.Size(220, 40)
        Me.btnTareas.TabIndex = 3
        Me.btnTareas.Text = "TAREAS"
        Me.btnTareas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTareas.UseVisualStyleBackColor = True
        '
        'panelSubmenu
        '
        Me.panelSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelSubmenu.Controls.Add(Me.Button9)
        Me.panelSubmenu.Controls.Add(Me.Button8)
        Me.panelSubmenu.Controls.Add(Me.Button7)
        Me.panelSubmenu.Controls.Add(Me.Button6)
        Me.panelSubmenu.Controls.Add(Me.Button5)
        Me.panelSubmenu.Controls.Add(Me.Button4)
        Me.panelSubmenu.Controls.Add(Me.btnLibreta)
        Me.panelSubmenu.Controls.Add(Me.btnArreglo)
        Me.panelSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubmenu.Location = New System.Drawing.Point(0, 95)
        Me.panelSubmenu.Name = "panelSubmenu"
        Me.panelSubmenu.Size = New System.Drawing.Size(220, 201)
        Me.panelSubmenu.TabIndex = 2
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button9.Location = New System.Drawing.Point(0, 175)
        Me.Button9.Name = "Button9"
        Me.Button9.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button9.Size = New System.Drawing.Size(220, 25)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "Button9"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Location = New System.Drawing.Point(0, 150)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(220, 25)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Button8"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button7.Location = New System.Drawing.Point(0, 125)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(220, 25)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Button7"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Location = New System.Drawing.Point(0, 100)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(220, 25)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Button6"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Location = New System.Drawing.Point(0, 75)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(220, 25)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Button5"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(0, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(220, 25)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Button4"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnLibreta
        '
        Me.btnLibreta.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLibreta.FlatAppearance.BorderSize = 0
        Me.btnLibreta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLibreta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnLibreta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibreta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLibreta.Location = New System.Drawing.Point(0, 25)
        Me.btnLibreta.Name = "btnLibreta"
        Me.btnLibreta.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.btnLibreta.Size = New System.Drawing.Size(220, 25)
        Me.btnLibreta.TabIndex = 1
        Me.btnLibreta.Text = "Libreta de ahorros"
        Me.btnLibreta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLibreta.UseVisualStyleBackColor = True
        '
        'btnArreglo
        '
        Me.btnArreglo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArreglo.FlatAppearance.BorderSize = 0
        Me.btnArreglo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnArreglo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArreglo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnArreglo.Location = New System.Drawing.Point(0, 0)
        Me.btnArreglo.Name = "btnArreglo"
        Me.btnArreglo.Padding = New System.Windows.Forms.Padding(45, 0, 0, 0)
        Me.btnArreglo.Size = New System.Drawing.Size(220, 25)
        Me.btnArreglo.TabIndex = 0
        Me.btnArreglo.Text = "Arreglos"
        Me.btnArreglo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArreglo.UseVisualStyleBackColor = True
        '
        'btnEjerciciosClase
        '
        Me.btnEjerciciosClase.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEjerciciosClase.FlatAppearance.BorderSize = 0
        Me.btnEjerciciosClase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnEjerciciosClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnEjerciciosClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEjerciciosClase.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEjerciciosClase.Location = New System.Drawing.Point(0, 55)
        Me.btnEjerciciosClase.Name = "btnEjerciciosClase"
        Me.btnEjerciciosClase.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnEjerciciosClase.Size = New System.Drawing.Size(220, 40)
        Me.btnEjerciciosClase.TabIndex = 1
        Me.btnEjerciciosClase.Text = "EJERCICIOS CLASE"
        Me.btnEjerciciosClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEjerciciosClase.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.btnMenuu)
        Me.panelLogo.Controls.Add(Me.PictureBox1)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(220, 55)
        Me.panelLogo.TabIndex = 0
        '
        'btnMenuu
        '
        Me.btnMenuu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuu.Image = CType(resources.GetObject("btnMenuu.Image"), System.Drawing.Image)
        Me.btnMenuu.Location = New System.Drawing.Point(162, 3)
        Me.btnMenuu.Name = "btnMenuu"
        Me.btnMenuu.Size = New System.Drawing.Size(56, 46)
        Me.btnMenuu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenuu.TabIndex = 1
        Me.btnMenuu.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.Transparent
        Me.PanelChildForm.Controls.Add(Me.PictureBox2)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(220, 40)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(780, 580)
        Me.PanelChildForm.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(330, 220)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(106, 116)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'tmOCULTAR
        '
        '
        'tmMostrar
        '
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 620)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTitulo.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelSubMenuTa.ResumeLayout(False)
        Me.panelSubmenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.btnMenuu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChildForm.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTitulo As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents panelMenu As Panel
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents panelSubMenuTa As Panel
    Friend WithEvents Button18 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents btnAhorros As Button
    Friend WithEvents btnTareas As Button
    Friend WithEvents panelSubmenu As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnLibreta As Button
    Friend WithEvents btnArreglo As Button
    Friend WithEvents btnEjerciciosClase As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMenuu As PictureBox
    Friend WithEvents tmOCULTAR As Timer
    Friend WithEvents tmMostrar As Timer
End Class
