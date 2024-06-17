Imports System.ComponentModel.Design
Imports System.Net.Sockets

Public Class frm_cad_maq
    Private Sub frm_cad_maq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_dados_cadmaq()
        carregar_tipo_campo_cadmaq()
        Me.Visible = True

        If acesso = 1 Then
            btn_frm_cad_fun.Enabled = True
        Else
            btn_frm_cad_fun.Enabled = False
            btn_frm_cad_maq.Enabled = False
            btn_frm_cad_obra.Enabled = False
        End If
    End Sub

    Private Sub btn_cad_maq_Click(sender As Object, e As EventArgs) Handles btn_cad_maq.Click
        'Try
        sql = "select * from tb_maquinas where placa='" & txt_placa.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            sql = "update tb_maquinas  set nome_maquina='" & txt_nome_maq.Text & "', " &
                                             "marca='" & txt_marca.Text &
                                             "'where placa='" & txt_placa.Text & "'"

            rs = db.Execute(UCase(sql))
            MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Else
            sql = "insert into tb_maquinas (placa, nome_maquina, marca) values ('" & txt_placa.Text & "', " &
                                                        "'" & txt_nome_maq.Text & "', " &
                                                        "'" & txt_marca.Text & "') "
            rs = db.Execute(UCase(sql))
            MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
        limpar_dados_cadmaq()
        carregar_dados_cadmaq()
        'Catch ex As Exception
        ' MsgBox("Erro ao gravar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub
    Private Sub btn_excluir_cadmaq_Click(sender As Object, e As EventArgs) Handles btn_excluir_cadmaq.Click
        With dgv_dados_cadmaq
            aux_placa1 = .CurrentRow.Cells(1).Value
            sql = "select * from tb_maquinas where placa='" & aux_placa1 & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                resp = MsgBox("Deseja realmente excluir a" + vbNewLine &
                                "Maquina: " & aux_placa1 & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_maquinas where placa ='" & aux_placa1 & "'"
                    rs = db.Execute(sql)
                    carregar_dados_cadmaq()
                    limpar_dados_cadmaq()
                End If
            End If
        End With
    End Sub

    Private Sub dgv_dados_cadmaq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_cadmaq.CellContentClick

        With dgv_dados_cadmaq
            If .CurrentRow.Cells(4).Selected = True Then
                aux_placa = .CurrentRow.Cells(1).Value
                sql = "select * from tb_maquinas where placa='" & aux_placa & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    txt_placa.Text = rs.Fields(0).Value
                    txt_nome_maq.Text = rs.Fields(1).Value
                    txt_marca.Text = rs.Fields(2).Value
                    txt_placa.Enabled = False
                End If


            End If
        End With
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        Try
            sql = "select * from tb_maquinas where " & cmb_tipo_maq.Text & " Like '" & txt_busca.Text & "%'"
            rs = db.Execute(sql)
            With dgv_dados_cadmaq
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_frm_cad_fun_Click(sender As Object, e As EventArgs) Handles btn_frm_cad_fun.Click
        Me.Visible = False
        frm_cad_fun.Visible = True
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

    Private Sub cmb_tipo_maq_Click(sender As Object, e As EventArgs) Handles cmb_tipo_maq.Click

    End Sub

    Private Sub busca_Click(sender As Object, e As EventArgs) Handles busca.Click

    End Sub
End Class