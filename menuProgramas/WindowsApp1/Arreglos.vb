Imports System.ComponentModel

Public Class Arreglos
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean = False
    Private Sub Arreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim computadoras(4) As String

        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"
        computadoras(4) = "Lenovo"

        For i = 0 To (computadoras.Length - 1) Step 1
            cmGenerar.Items.Add(computadoras(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrecio.Click
        Dim precio(3) As Integer
        precio(0) = "22500"
        precio(1) = "21000"
        precio(2) = "20000"
        precio(3) = "42000"


        For i = 0 To (precio.Length - 1) Step 1
            cmPrecio.Items.Add(precio(i))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmPrecio.SelectedIndexChanged

    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Dim Cantidad As Integer
        Dim computadora() As String
        Cantidad = Val(txtcantidad.Text)
        'Asignar tamaño
        ReDim computadora(Cantidad)
        'Se solicita la informacion 
        For i = 0 To Cantidad Step 1
            computadora(i) = InputBox("Ingrese la marca de la pc", "Ingreso")
        Next
        'Muestra la inforacion 
        For j = 0 To Cantidad Step 1
            cmCantidadCom.Items.Add(computadora(j))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cmPrecio.Items.Clear()
        cmGenerar.Items.Clear()
        cmCantidadCom.Items.Clear()
        txtVenta.Clear()
        txtModelo.Clear()
        txtPrecio.Clear()
        txtMarca.Clear()
        txtCantidaad.Clear()
        txtcantidad.Clear()
    End Sub

    Private Sub frmArreglosVectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModelo.Enabled = False
        txtPrecio.Enabled = False
        txtCantidaad.Enabled = False
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        cantComputadoras = Val(txtCantidadComputadoras.Text)
        ReDim mComputadoras(cantComputadoras, 3)
        'Un arreglo de 3x3 comienza a contar desde 0
        For i = 0 To (cantComputadoras - 1) Step 1
            mComputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
            mComputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
            mComputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
            mComputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")
            index = i
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim marca As String
        marca = txtMarca.Text
        For i = 0 To (cantComputadoras - 1) Step 1
            If (mComputadoras(i, 0) = marca) Then
                txtModelo.Text = mComputadoras(i, 1)
                txtPrecio.Text = mComputadoras(i, 2)
                txtcantidad.Text = mComputadoras(i, 3)
                encuentra = True
                btnVender.Enabled = True
                btnBuscar.Enabled = True
            End If
        Next
        If (encuentra = False) Then
            MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim cantVender, stock As Integer
        cantVender = Val(txtVenta.Text)
        stock = mComputadoras(index, 3)
        If (cantVender >= stock) Then
            MessageBox.Show("Sin Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            mComputadoras(index, 3) = stock - cantVender
            MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub txtcantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtCantidadComputadoras_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidadComputadoras.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub


    Private Sub txtMarca_Validating(sender As Object, e As CancelEventArgs) Handles txtMarca.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub


    Private Sub txtModelo_Validating(sender As Object, e As CancelEventArgs) Handles txtModelo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub


    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtCantidaad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidaad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "ERROR")
        Else
            Me.ErrorProvider.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidadComputadoras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadComputadoras.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtCantidaad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidaad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class