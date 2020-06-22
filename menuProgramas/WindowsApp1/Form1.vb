Imports System.Runtime.InteropServices
Public Class MENU
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub hideSubMenu()
        panelSubmenu.Visible = False
        panelSubMenuTa.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnEjerciciosClase_Click(sender As Object, e As EventArgs) Handles btnEjerciciosClase.Click
        showSubmenu(panelSubmenu)
    End Sub

    Private Sub btnTareas_Click(sender As Object, e As EventArgs) Handles btnTareas.Click
        showSubmenu(panelSubMenuTa)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnArreglo.Click
        openChildForm(New Arreglos())
        hideSubMenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLibreta.Click
        openChildForm(New libretaAhorros())
        hideSubMenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        hideSubMenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        hideSubMenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        hideSubMenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        hideSubMenu()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        hideSubMenu()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        hideSubMenu()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnAhorros.Click
        openChildForm(New libreta_de_ahorros())
        hideSubMenu()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        hideSubMenu()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        hideSubMenu()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        hideSubMenu()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        hideSubMenu()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        hideSubMenu()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        hideSubMenu()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        hideSubMenu()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        hideSubMenu()
    End Sub
    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub panelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles panelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If panelMenu.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width - 5
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrar.Tick
        If panelMenu.Width >= 220 Then
            Me.tmMostrar.Enabled = False
        Else
            Me.panelMenu.Width = panelMenu.Width + 5
        End If
    End Sub
    Private Sub btnMenuu_Click(sender As Object, e As EventArgs) Handles btnMenuu.Click
        If panelMenu.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf panelMenu.Width = 60 Then
            tmMostrar.Enabled = True
        End If
    End Sub
End Class
