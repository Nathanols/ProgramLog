Imports System.Data.Common

Public Class frm_consultar
    Private Sub frm_consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
        carregar_dados_consulta()
        carregar_tipo_campo_consulta()
        Me.Visible = True

        If acesso = 1 Then
            btn_frm_cad_fun.Enabled = True
        Else
            btn_frm_cad_fun.Enabled = False
            btn_frm_cad_maq.Enabled = False
            btn_frm_cad_obra.Enabled = False
        End If
    End Sub


    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        'Try
        sql = "select tb_obras.id_obra,tb_obras.rua, tb_obras.tipo_construcao,tb_maquinas.placa,tb_maquinas.nome_maquina from tb_obras inner join tb_maquinas on tb_obras.id_obra=tb_maquinas.id_obra where  " & cmb_tipo.Text & " Like '" & txt_busca.Text & "%'"
        rs = db.Execute(sql)
            With dgv_dados_consulta

                .Rows.Clear()
                Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing)

                rs.MoveNext()
                Loop

            End With
        'Catch ex As Exception
        'MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try
    End Sub

    Private Sub btn_menu_Click(sender As Object, e As EventArgs)
        Close()
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

    Private Sub btn_frm_atribuir_Click(sender As Object, e As EventArgs) Handles btn_frm_atribuir.Click
        Me.Visible = False
        frm_atribuir.Visible = True
    End Sub

    Private Sub dgv_dados_consulta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_consulta.CellContentClick

    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged

    End Sub
End Class