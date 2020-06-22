Public Class libretaAhorros
    Private monto As Integer
    Private Sub activarControles()
        txtUsuario.Enabled = False
        txtMonto.Enabled = False
        btnAperturar.Enabled = False
        btnDepositar.Enabled = True
        btnRetirar.Enabled = True
    End Sub
    Private Sub desactivarControles()
        txtUsuario.Enabled = True
        txtMonto.Enabled = True
        btnAperturar.Enabled = True
        btnDepositar.Enabled = False
        btnRetirar.Enabled = False
    End Sub
    Private Sub mostrarSaldo()
        txtTotal.Text = monto
    End Sub
    Private Sub libretaAhorros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        desactivarControles()
        txtUsuario.Clear()
        txtMonto.Clear()
        txtTotal.Clear()
        ListDepositos.Items.Clear()
        ListRetiros.Items.Clear()
    End Sub

    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        Dim cliente As String
        cliente = txtUsuario.Text
        monto = Val(txtMonto.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a" & mensaje, "Operación")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        ListDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retirar As Double
        retirar = leer("Retirar")
        If (retirar > monto) Then
            MessageBox.Show("No se puede retirar una cantidad mayor al monto actual", "Gestión de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retirar
            ListRetiros.Items.Add(retirar)
            mostrarSaldo()
        End If
    End Sub
End Class