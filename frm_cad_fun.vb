Imports System.ComponentModel.Design
Imports System.Net.Sockets

Public Class frm_cad_fun
    Private Sub frm_cad_fun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_dados_fun()
        carregar_tipo_campo_fun()

        If acesso = 1 Then
            btn_frm_cad_fun.Enabled = True
        Else
            btn_frm_cad_fun.Enabled = False
            btn_frm_cad_maq.Enabled = False
            btn_frm_cad_obra.Enabled = False
        End If
    End Sub

    Private Sub btn_cad_fun_Click(sender As Object, e As EventArgs) Handles btn_cad_fun.Click
        Try
            sql = "select * from tb_equipe where credencial='" & txt_credencial.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_equipe  set nome_fun='" & txt_nome_fun.Text & "', " &
                                             "cargo='" & txt_cargo.Text & "', " &
                                            "status='" & txt_status & "' , " &
                                            "senha='" & txt_senha.Text & "'  where credencial='" & txt_credencial.Text & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "insert into tb_equipe values ('" & txt_credencial.Text & "', " &
                                                        "'" & txt_nome_fun.Text & "', " &
                                                         "'" & txt_cargo.Text & "', " &
                                                         "'" & txt_senha.Text & "', " &
                                                        "'" & txt_status & "') "
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            limpar_dados_fun()
            carregar_dados_fun()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_excluir_fun_Click(sender As Object, e As EventArgs) Handles btn_excluir_fun.Click
        With dgv_dados_fun
            aux_cred = .CurrentRow.Cells(1).Value
            sql = "select * from tb_equipe where credencial='" & aux_cred & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                resp = MsgBox("Deseja realmente excluir a" + vbNewLine &
                            "Credencial: " & aux_cred & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_equipe where credencial ='" & aux_cred & "'"
                    rs = db.Execute(sql)
                    carregar_dados_fun()
                    limpar_dados_fun()
                End If
            End If
        End With
    End Sub

    Private Sub dgv_dados_fun_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_fun.CellContentClick
        With dgv_dados_fun

            If .CurrentRow.Cells(7).Selected = True Then
                txt_status = "ATIVO"
                aux_cred = .CurrentRow.Cells(1).Value

                sql = "update tb_equipe set status='" & txt_status & "' where credencial='" & aux_cred & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Funcionário Ativo!", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "ATENÇÃO")
                carregar_dados_fun()

            ElseIf .CurrentRow.Cells(6).Selected = True Then
                txt_status = "BLOQUEADO"
                aux_cred = .CurrentRow.Cells(1).Value

                sql = "update tb_equipe set status='" & txt_status & "' where credencial='" & aux_cred & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Funcionário Bloqueado!", MsgBoxStyle.Question + MsgBoxStyle.OkOnly, "ATENÇÃO")
                carregar_dados_fun()

            ElseIf .CurrentRow.Cells(5).Selected = True Then
                aux_cred = .CurrentRow.Cells(1).Value
                sql = "select * from tb_equipe where credencial='" & aux_cred & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_credencial.Text = rs.Fields(0).Value
                    txt_nome_fun.Text = rs.Fields(1).Value
                    txt_cargo.Text = rs.Fields(2).Value
                    txt_senha.Text = rs.Fields(3).Value
                    'txt_credencial.Enabled = TRUE


                End If
            End If
        End With

    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            sql = "select * from tb_equipe where " & cmb_tipo.Text & " Like '" & txt_busca.Text & "%'"
            rs = db.Execute(sql)
            With dgv_dados_fun
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_busca_Click(sender As Object, e As EventArgs) Handles txt_busca.Click

    End Sub

    Private Sub btn_frm_cad_maq_Click(sender As Object, e As EventArgs) Handles btn_frm_cad_maq.Click
        Me.Visible = False
        frm_cad_maq.Visible = True
    End Sub

    Private Sub btn_frm_cad_obra_Click(sender As Object, e As EventArgs) Handles btn_frm_cad_obra.Click
        Me.Visible = False
        frm_cad_obra.Visible = True
    End Sub

    Private Sub btn_frm_consultar_Click(sender As Object, e As EventArgs) Handles btn_frm_consultar.Click
        Me.Visible = False
        frm_consultar.Visible = True
    End Sub

    Private Sub btn_frm_atribuir_Click(sender As Object, e As EventArgs) Handles btn_frm_atribuir.Click
        Me.Visible = False
        frm_atribuir.Visible = True
    End Sub
End Class