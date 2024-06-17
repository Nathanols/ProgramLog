Imports System.Data.OleDb

Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        Me.Visible = True

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        VerificarCredenciais()

    End Sub
    Private Sub VerificarCredenciais()

        sql = "select * from tb_equipe where credencial='" & txt_login.Text & "' and senha='" & txt_senha.Text & "'"
        rs = db.Execute(sql)


        If txt_login.Text = "adm" And txt_senha.Text = "1234" Then
            MsgBox("Conexão efetuada com sucesso!", vbInformation, "Aviso")
            acesso = 1
            usuario = txt_login.Text
            Me.Visible = False
            frm_consultar.Visible = True

        ElseIf rs.EOF = True Then
            MsgBox("Usuário ou senha inválidos.", vbExclamation, "Atenção")
            txt_login.Clear()
            txt_senha.Clear()
            txt_login.Focus()
        Else
            txt_status = rs.Fields(4).Value

            If txt_status = "DISPONÍVEL" Then
                MsgBox("Conta Ativa", vbInformation, "Aviso")
                acesso = 2
                usuario = rs.Fields(1).Value
                Me.Visible = False
                frm_consultar.Visible = True
            Else
                MsgBox("Conta bloqueada", vbExclamation, "Aviso")

            End If
        End If
    End Sub



End Class