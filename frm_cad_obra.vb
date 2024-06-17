Imports System.Data.Common

Public Class frm_cad_obra


    Private Sub frm_cad_obra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_dados_cadobra()
        Me.Visible = True

        If acesso = 1 Then
            btn_frm_cad_fun.Enabled = True
        Else
            btn_frm_cad_fun.Enabled = False
            btn_frm_cad_maq.Enabled = False
            btn_frm_cad_obra.Enabled = False
        End If
    End Sub



    Private Sub btn_cad_obra_Click(sender As Object, e As EventArgs) Handles btn_cad_obra.Click
        'Try

        sql = "select * from tb_obras where rua='" & txt_rua.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
            sql = "update tb_obras  set numero='" & txt_numero.Text & "', " &
                                                    "bairro='" & txt_bairro.Text & "', " &
                                                   "cidade='" & txt_cidade.Text & "' , " &
                                                   "estado='" & txt_estado.Text & "' , " &
                                                   "tipo_construcao='" & txt_tipo.Text & "'where rua='" & txt_rua.Text & "'"

            rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
            sql = "INSERT INTO tb_obras (rua, numero, bairro, cidade, estado, tipo_construcao) VALUES ('" & txt_rua.Text & "', " &
                                                            "'" & txt_numero.Text & "', " &
                                                           "'" & txt_bairro.Text & "', " &
                                                             "'" & txt_cidade.Text & "', " &
                                                             "'" & txt_estado.Text & "', " &
                                                              "'" & txt_tipo.Text & "') "



            '"insert into tb_obras values ( '" & cont & "', " &
            '                                                "'" & txt_rua.Text & "', " &
            ''                                                "'" & txt_numero.Text & "', " &
            '                                                "'" & txt_bairro.Text & "', " &
            '                                                 "'" & txt_cidade.Text & "', " &
            '                                                 "'" & txt_estado.Text & "', " &
            '                                                  "'" & txt_tipo.Text & "') "
            rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            limpar_dados_obra()
            carregar_dados_cadobra()
        'Catch ex As Exception
        'MsgBox("Erro ao gravar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try

    End Sub

    Private Sub btn_excluir_maq_Click(sender As Object, e As EventArgs) Handles btn_excluir_maq.Click

        With dgv_dados_obra
            aux_rua = .CurrentRow.Cells(1).Value
            sql = "select * from tb_obras where rua='" & aux_rua & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                resp = MsgBox("Deseja realmente excluir a" + vbNewLine &
                                "essa obra: " & aux_rua & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_obras where rua ='" & aux_rua & "'"
                    rs = db.Execute(sql)
                    carregar_dados_cadobra()
                    limpar_dados_obra()
                End If
            End If
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_obra.CellContentClick
        With dgv_dados_obra
            If .CurrentRow.Cells(7).Selected = True Then
                aux_rua = .CurrentRow.Cells(1).Value
                sql = "select * from tb_obras where rua='" & aux_rua & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_rua.Text = rs.Fields(1).Value
                    txt_numero.Text = rs.Fields(2).Value
                    txt_bairro.Text = rs.Fields(3).Value
                    txt_cidade.Text = rs.Fields(4).Value
                    txt_estado.Text = rs.Fields(5).Value
                    txt_tipo.Text = rs.Fields(6).Value
                    txt_rua.Enabled = False
                End If
            End If
        End With
    End Sub

    Private Sub btn_frm_cad_fun_Click(sender As Object, e As EventArgs) Handles btn_frm_cad_fun.Click
        Me.Visible = False
        frm_cad_fun.Visible = True
    End Sub

    Private Sub btn_frm_cad_maq_Click(sender As Object, e As EventArgs) Handles btn_frm_cad_maq.Click
        Me.Visible = False
        frm_cad_maq.Visible = True
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