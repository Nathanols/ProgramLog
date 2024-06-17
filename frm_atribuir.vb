Public Class frm_atribuir
    Private Sub frm_atribuir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_dados_obra()
        carregar_dados_maq()
        carregar_tipo_campo_obra1()
        carregar_tipo_campo_maq()
        Me.Visible = True

        If acesso = 1 Then
            btn_frm_cad_fun.Enabled = True
        Else
            btn_frm_cad_fun.Enabled = False
            btn_frm_cad_maq.Enabled = False
            btn_frm_cad_obra.Enabled = False
        End If
    End Sub
    Private Sub txt_busca_maq_Click(sender As Object, e As EventArgs) Handles txt_busca_maq.TextChanged
        sql = "select * from tb_maquinas where " & cmb_maq.Text & " Like '" & txt_busca_maq.Text & "%'"
        rs = db.Execute(sql)
        With dgv_dados_maq
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                cont = cont + 1
                rs.MoveNext()
            Loop

        End With
    End Sub
    Private Sub txt_busca_rua_TextChanged(sender As Object, e As EventArgs) Handles txt_busca_rua.TextChanged
        ''Try
        sql = "select * from tb_obras where " & cmb_tipo.Text & " Like '" & txt_busca_rua.Text & "%'"
        rs = db.Execute(sql)
        With dgv_dados_pesq

            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, Nothing, Nothing, Nothing, Nothing)

                rs.MoveNext()
            Loop

        End With
        'Catch ex As Exception
        'MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'nd Try
    End Sub

    Private Sub btn_atribuir_Click(sender As Object, e As EventArgs) Handles btn_atribuir.Click
        Try
            sql = "select * from tb_maquinas where placa='" & txt_placa.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_maquinas set nome_maquina='" & txt_maq_selecionada.Text & "', " &
                                            "marca='" & txt_marca.Text & "', " &
                                            "id_obra='" & txt_id.Text & "'where placa='" & txt_placa.Text & "'"

                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                MsgBox("erro!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            limpar_dados_maq()
            carregar_dados_maq()
        Catch ex As Exception
            MsgBox("Erro ao gravar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub dgv_dados_maq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_maq.CellContentClick
        With dgv_dados_maq
            If .CurrentRow.Cells(5).Selected = True Then
                aux_placa = .CurrentRow.Cells(1).Value
                sql = "select * from tb_maquinas where placa='" & aux_placa & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    txt_placa.Text = rs.Fields(0).Value
                    txt_maq_selecionada.Text = rs.Fields(1).Value
                    txt_marca.Text = rs.Fields(2).Value
                    txt_id.Text = rs.Fields(3).Value
                    txt_placa.Enabled = False
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

    Private Sub btn_frm_cad_obra_Click(sender As Object, e As EventArgs) Handles btn_frm_cad_obra.Click
        Me.Visible = False
        frm_cad_obra.Visible = True
    End Sub

    Private Sub btn_frm_consultar_Click(sender As Object, e As EventArgs) Handles btn_frm_consultar.Click
        Me.Visible = False
        frm_consultar.Visible = True
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub ToolStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub txt_busca_rua_Click(sender As Object, e As EventArgs) Handles txt_busca_rua.Click

    End Sub

    Private Sub dgv_dados_pesq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_pesq.CellContentClick

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub txt_busca_maq_Click_1(sender As Object, e As EventArgs) Handles txt_busca_maq.Click

    End Sub
End Class