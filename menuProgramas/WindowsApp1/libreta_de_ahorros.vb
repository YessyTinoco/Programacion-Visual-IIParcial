Imports System.ComponentModel

Public Class libreta_de_ahorros
    Private monto As Integer
    Private iimpuesto As Integer
    'Private numIdentidad As String
    Private Sub activarControles()
        txtNombre.Enabled = False
        txtMonto.Enabled = False
        txtCiudad.Enabled = False
        txtPais.Enabled = False
        txtEdad.Enabled = False
        masIdentidad.Enabled = False
        btnApertura.Enabled = False
        btnDepositar.Enabled = True
        btnRetirar.Enabled = True
        txtTotal.Enabled = True
        txtImpuesto.Enabled = True
        btnDetalles.Enabled = True
    End Sub
    Private Sub desactivarControles()
        txtNombre.Enabled = True
        txtMonto.Enabled = True
        txtCiudad.Enabled = True
        txtPais.Enabled = True
        txtEdad.Enabled = True
        masIdentidad.Enabled = True
        btnApertura.Enabled = True
        btnDepositar.Enabled = False
        btnRetirar.Enabled = False
        txtTotal.Enabled = False
        txtImpuesto.Enabled = False
        btnDetalles.Enabled = False
    End Sub
    Private Sub mostrarSaldo()
        txtTotal.Text = monto
        iimpuesto = (monto * 0.3)
        txtImpuesto.Text = iimpuesto
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub libreta_de_ahorros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub
    Private Sub identidaad()
        Dim numIdentidad As String
        numIdentidad = masIdentidad.Text
        If (numIdentidad <> "1305200200353") Then
            MessageBox.Show("Número incorrecto", "Ingrese nuevamente su identidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        ' Dim numIdentidad(4) As String
        '  numIdentidad(0) = "130520020053"
        ' numIdentidad(1) = "130520020054"
        'numIdentidad(2) = "130520020055"
        ' numIdentidad(3) = "130520020056"
        ' numIdentidad(4) = "130520020057"

    End Sub
    Private Sub btnApertura_Click(sender As Object, e As EventArgs) Handles btnApertura.Click
        Dim cliente As String
        Dim Edad As Integer

        Edad = Val(txtEdad.Text)
        If (Edad < 18) And (Edad > 110) Then
            MessageBox.Show("Mayores de 18 y menores de 110 años", "Ingrese una edad válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        identidaad()
        cliente = txtNombre.Text
        monto = Val(txtMonto.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operación")
        mostrarSaldo()
        Return cantidad
    End Function
    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        ListDepositar.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retirar As Double
        retirar = leer("Retirar")
        If (retirar > monto) Then
            MessageBox.Show("No se puede retirar una cantidad mayor al monto actual", "Gestión de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retirar
            ListRetirar.Items.Add(retirar)
            mostrarSaldo()
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
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

    Private Sub txtPais_Validating(sender As Object, e As CancelEventArgs) Handles txtPais.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtPais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPais.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCiudad_Validating(sender As Object, e As CancelEventArgs) Handles txtCiudad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtCiudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCiudad.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMonto_Validating(sender As Object, e As CancelEventArgs) Handles txtMonto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
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

    Private Sub btnDetalles_Click(sender As Object, e As EventArgs) Handles btnDetalles.Click
        DataHistorial.Rows.Add(masIdentidad.Text, txtNombre.Text, txtEdad.Text, txtPais.Text, txtCiudad.Text, txtMonto.Text, txtTotal.Text, txtImpuesto.Text)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        desactivarControles()
        txtNombre.Clear()
        txtMonto.Clear()
        txtTotal.Clear()
        ListDepositar.Items.Clear()
        ListRetirar.Items.Clear()
        txtPais.Clear()
        txtCiudad.Clear()
        txtEdad.Clear()
        masIdentidad.Clear()
        txtImpuesto.Clear()
        DataHistorial.Rows.Remove(DataHistorial.CurrentRow)
    End Sub

End Class