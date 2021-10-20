Public Class Form_principal
    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1
    Private HTCAPTION As Integer = &H2

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = New IntPtr(HTCLIENT) Then
                    m.Result = New IntPtr(HTCAPTION)
                End If
        End Select
    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim num5 As Integer
            num5 = 0

            If txt_senha.Text = "" Then
                txt_erroCopia.Visible = True
                'MsgBox("Não tem senha para copiar!", MsgBoxStyle.OkOnly, "Copiar Senha")
            Else
                txt_copiado.Visible = True
            End If

            Clipboard.SetText(txt_senha.Text)
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If checked_car.Checked = True Then

            Dim chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@!.><~"
            Dim random = New Random()
            Dim tamanho As Integer = txt_qtd.Text  'Número de caracteres
            Dim result = New String(Enumerable.Repeat(chars, tamanho).[Select](Function(s) s(random.[Next](s.Length))).ToArray())

            txt_senha.Text = "" & result & ""

        ElseIf checked_mm.Checked = True Then
            Dim chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxy"
            Dim random = New Random()
            Dim tamanho As Integer = txt_qtd.Text  'Número de caracteres
            Dim result = New String(Enumerable.Repeat(chars, tamanho).[Select](Function(s) s(random.[Next](s.Length))).ToArray())

            txt_senha.Text = "" & result & ""

        ElseIf checked_numeros.Checked = True Then
            Dim chars = "0123456789"
            Dim random = New Random()
            Dim tamanho As Integer = txt_qtd.Text  'Número de caracteres
            Dim result = New String(Enumerable.Repeat(chars, tamanho).[Select](Function(s) s(random.[Next](s.Length))).ToArray())

            txt_senha.Text = "" & result & ""

        ElseIf Checked_tudo.Checked = True Then
            Dim chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxy@!.><~"
            Dim random = New Random()
            Dim tamanho As Integer = txt_qtd.Text  'Número de caracteres
            Dim result = New String(Enumerable.Repeat(chars, tamanho).[Select](Function(s) s(random.[Next](s.Length))).ToArray())

            txt_senha.Text = "" & result & ""

        ElseIf checked_car.Checked = False And checked_mm.Checked = False Or checked_numeros.Checked = False Or Checked_tudo.Checked = False Then
            MsgBox("Selecione uma opção para poder gerar uma senha!", vbOKOnly, "Atenção!")
        End If

        'faz a verificação da quantidade de caracteres
        If txt_qtd.Text > 20 Then
            MsgBox("O número máximo de caracteres é de 20!", MsgBoxStyle.OkOnly, "Atenção!")
            txt_qtd.Text = "14"
        ElseIf txt_qtd.Text < 6 Then
            MsgBox("O número minimo de caracteres é de 6!", MsgBoxStyle.OkOnly, "Atenção!")
            txt_qtd.Text = "14"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles checked_numeros.CheckedChanged

        If checked_numeros.Checked = True Then
            checked_car.Checked = False
            checked_mm.Checked = False
            Checked_tudo.Checked = False
        End If
    End Sub

    Private Sub checked_car_CheckedChanged(sender As Object, e As EventArgs) Handles checked_car.CheckedChanged
        If checked_car.Checked = True Then
            checked_numeros.Checked = False
            checked_mm.Checked = False
            Checked_tudo.Checked = False
        End If
    End Sub

    Private Sub checked_mm_CheckedChanged(sender As Object, e As EventArgs) Handles checked_mm.CheckedChanged
        If checked_mm.Checked = True Then
            checked_numeros.Checked = False
            checked_car.Checked = False
            Checked_tudo.Checked = False
        End If
    End Sub

    Private Sub Checked_tudo_CheckedChanged(sender As Object, e As EventArgs) Handles Checked_tudo.CheckedChanged

        If Checked_tudo.Checked = True Then
            checked_numeros.Checked = False
            checked_car.Checked = False
            checked_mm.Checked = False

        End If
    End Sub


    Private Sub txt_qtd_LostFocus(sender As Object, e As EventArgs)
        If txt_qtd.Text > 20 Then
            MsgBox("O número máximo de caracteres é de 20!", MsgBoxStyle.OkOnly, "Atenção!")
            txt_qtd.Text = "14"
        ElseIf txt_qtd.Text < 6 Then
            MsgBox("O número minimo de caracteres é de 6!", MsgBoxStyle.OkOnly, "Atenção!")
            txt_qtd.Text = "14"
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        txt_qtd.Text = txt_qtd.Text + 1

        If txt_qtd.Text > 20 Then
            MsgBox("O número máximo de caracteres é de 20!", MsgBoxStyle.OkOnly, "Atenção!")
            txt_qtd.Text = "14"
        ElseIf txt_qtd.Text < 6 Then
            MsgBox("O número minimo de caracteres é de 6!", MsgBoxStyle.OkOnly, "Atenção!")
            txt_qtd.Text = "14"
        Else
            Exit Sub
        End If
    End Sub


    Private Sub Button2_LostFocus(sender As Object, e As EventArgs) Handles Button2.LostFocus
        txt_copiado.Visible = False
        txt_erroCopia.Visible = False
    End Sub
End Class