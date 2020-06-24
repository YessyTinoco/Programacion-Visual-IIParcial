Imports System.ComponentModel

Public Class Entrega_bolsaSolidaria
    Private Sub activarControles()
        txtNombre.Enabled = False
        maskIdentidad.Enabled = False
        rbtnFemenino.Enabled = False
        rbtnMasculino.Enabled = False
        txtCantidad.Enabled = False
        cmDepartamento.Enabled = False
        txtMunicipio.Enabled = False
        txtBarrio.Enabled = False
        CheckBajo.Enabled = True
        CheckExtrema.Enabled = True
        CheckPobreza.Enabled = True
        btnGuardar.Enabled = False
        btnLiimpiar.Enabled = True
        btnGuarrdarHistorial.Enabled = True
        btnLimpiarHistorial.Enabled = True
        CheckBasica.Enabled = False
        CheckRegular.Enabled = False

    End Sub
    Private Sub desactivarControles()
        txtNombre.Enabled = True
        CheckBasica.Enabled = False
        maskIdentidad.Enabled = True
        rbtnFemenino.Enabled = True
        rbtnMasculino.Enabled = True
        txtCantidad.Enabled = True
        cmDepartamento.Enabled = True
        txtMunicipio.Enabled = True
        txtBarrio.Enabled = True
        CheckBajo.Enabled = False
        CheckExtrema.Enabled = False
        CheckPobreza.Enabled = False
        btnGuardar.Enabled = True
        btnLiimpiar.Enabled = False
        btnGuarrdarHistorial.Enabled = False
        btnLimpiarHistorial.Enabled = False
        CheckRegular.Enabled = False
    End Sub
    Private Sub habilitarBasica()
        CheckBasica.Checked = True

        cmBasica.Enabled = True
        CheckRegular.Enabled = False
        cmRegular.Enabled = False
    End Sub
    Private Sub habilitarRegular()
        CheckBasica.Enabled = False
        cmBasica.Enabled = False
        CheckRegular.Checked = True
        cmRegular.Enabled = True
    End Sub
    Private Sub estadoSituacion()
        If CheckExtrema.Checked = True Then
            CheckBajo.Checked = False
            CheckPobreza.Checked = False
        ElseIf CheckBajo.Checked = True Then
            CheckExtrema.Checked = False
            CheckPobreza.Checked = False
        ElseIf CheckPobreza.Checked = True Then
            CheckExtrema.Checked = False
            CheckBajo.Checked = False
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim persona As String
        Dim cantidad As Integer
        Dim identidad As String

        identidad = maskIdentidad.Text
        If identidad.Length < 13 And identidad.Length > 13 Then
            MessageBox.Show("Número inválido", "Ingresar nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        persona = txtNombre.Text
        cantidad = Val(txtCantidad.Text)
        If (cantidad >= 1) And (cantidad <= 3) Then
            habilitarBasica()
        ElseIf (cantidad > 3) Then
            habilitarRegular()
        End If
        activarControles()
    End Sub
    Private Function rdButtonItem()
        Dim selected As String = ""
        If rbtnFemenino.Checked Then
            selected = "Femenino"
        ElseIf rbtnMasculino.Checked Then
            selected = "Masculino"
        End If
        Return selected
    End Function
    Private Function estadoItem()
        Dim selected As String = ""
        If CheckBajo.Checked Then
            selected = "Bajos recursos económicos"
        ElseIf CheckPobreza.Checked Then
            selected = "Pobreza"
        ElseIf CheckExtrema.Checked Then
            selected = "Pobreza extrema"
        End If
        Return selected
    End Function
    Private Function bolsaItem()
        Dim selected As String = ""
        If CheckBasica.Checked Then
            selected = "Bolsa básica"
        ElseIf CheckRegular.Checked Then
            selected = "Bolsa Regular"
        End If
        Return selected
    End Function
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Entrega_bolsaSolidaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub CheckBajo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBajo.CheckedChanged
        estadoSituacion()
    End Sub

    Private Sub CheckPobreza_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPobreza.CheckedChanged
        estadoSituacion()
    End Sub

    Private Sub CheckExtrema_CheckedChanged(sender As Object, e As EventArgs) Handles CheckExtrema.CheckedChanged
        estadoSituacion()
    End Sub
    Private Sub btnLiimpiar_Click(sender As Object, e As EventArgs) Handles btnLiimpiar.Click
        desactivarControles()
        maskIdentidad.Clear()
        txtNombre.Clear()
        rbtnFemenino.Checked = False
        rbtnMasculino.Checked = False
        txtCantidad.Clear()
        cmDepartamento.ResetText()
        txtMunicipio.Clear()
        txtBarrio.Clear()
        CheckBajo.Checked = False
        CheckExtrema.Checked = False
        CheckPobreza.Checked = False
        CheckRegular.Checked = False
        CheckBasica.Checked = False
        cmBasica.ResetText()
        cmRegular.ResetText()
    End Sub
    Private Sub btnGuarrdarHistorial_Click(sender As Object, e As EventArgs) Handles btnGuarrdarHistorial.Click
        dgvEntrega.Rows.Add(maskIdentidad.Text, txtNombre.Text, rdButtonItem(), cmDepartamento.SelectedItem, txtMunicipio.Text, txtBarrio.Text, txtCantidad.Text, estadoItem(), bolsaItem())
    End Sub

    Private Sub btnLimpiarHistorial_Click(sender As Object, e As EventArgs) Handles btnLimpiarHistorial.Click
        dgvEntrega.Rows.Remove(dgvEntrega.CurrentRow)
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

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese la cantidad de personas con las que vive")
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
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

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtMunicipio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMunicipio.KeyPress
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

    Private Sub txtBarrio_Validating(sender As Object, e As CancelEventArgs) Handles txtBarrio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtBarrio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarrio.KeyPress
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

End Class