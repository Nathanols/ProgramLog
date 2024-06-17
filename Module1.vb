Module Module1
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, aux_cred, aux_rua, aux_placa, aux_placa1, aux_obra, resp As String
    Public txt_status, txt_placa As String
    Public dir_banco = Application.StartupPath & "\banco\Dados.mdb"
    Public cont As Integer
    Public acesso As Integer
    Public usuario As String

    Sub conecta_banco_access()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data Source=" & dir_banco)
        Catch ex As Exception
            MsgBox("Erro de Conexão", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Sub limpar_dados_fun()
        Try
            With frm_cad_fun
                .txt_senha.Clear()
                .txt_nome_fun.Clear()
                .txt_credencial.Clear()
                .txt_cargo.Clear()
                .txt_nome_fun.Enabled = True
                .txt_nome_fun.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_dados_obra()
        Try
            With frm_cad_obra
                .txt_rua.Clear()
                .txt_numero.Clear()
                .txt_bairro.Clear()
                .txt_cidade.Clear()
                .txt_estado.Clear()
                .txt_tipo.Clear()
                .txt_rua.Enabled = True
                .txt_rua.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_dados_cadmaq()
        Try
            With frm_cad_maq
                .txt_nome_maq.Clear()
                .txt_placa.Clear()
                .txt_marca.Clear()
                .txt_nome_maq.Enabled = True
                .txt_nome_maq.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_dados_maq()
        Try
            With frm_atribuir
                .txt_id.Clear()
                .txt_maq_selecionada.Clear()
                .txt_id.Enabled = True
                .txt_id.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao limpar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_dados_fun()
        Try
            sql = "select * from tb_equipe order by credencial asc"
            rs = db.Execute(sql)
            With frm_cad_fun.dgv_dados_fun
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing)
                    cont = cont + 1
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Sub carregar_dados_cadobra()
        'Try
        sql = "select * from tb_obras order by rua asc"
            rs = db.Execute(sql)
            With frm_cad_obra.dgv_dados_obra

            .Rows.Clear()
                Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, Nothing)

                rs.MoveNext()
                Loop

            End With
        'Catch ex As Exception
        'MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try

    End Sub



    Sub carregar_dados_obra()
        Try
            sql = "select * from tb_obras order by id_obra asc"
            rs = db.Execute(sql)
            With frm_atribuir.dgv_dados_pesq

                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, Nothing)

                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Sub carregar_dados_maq()
        ' Try
        'If rs.Fields(3).Value = 0 Then

        sql = "select * from tb_maquinas order by placa asc"
            rs = db.Execute(sql)
            With frm_atribuir.dgv_dados_maq
                cont = 1
            .Rows.Clear()


            Do While rs.EOF = False
                'If rs.Fields(3).Value = 0 Then

                .Rows.Add(cont, rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing)
                cont = cont + 1
                rs.MoveNext()

            Loop

        End With
        'End If
        'Catch ex As Exception
        'MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        'End Try

    End Sub

    Sub carregar_dados_cadmaq()
        Try
            sql = "select * from tb_maquinas order by placa asc"
            rs = db.Execute(sql)
            With frm_cad_maq.dgv_dados_cadmaq
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

    Sub carregar_dados_consulta()
        'Try
        sql = "select tb_obras.id_obra,tb_obras.rua, tb_obras.tipo_construcao,tb_maquinas.placa,tb_maquinas.nome_maquina from tb_obras inner join tb_maquinas on tb_obras.id_obra=tb_maquinas.id_obra"
        rs = db.Execute(sql)
        With frm_consultar.dgv_dados_consulta

            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing)

                rs.MoveNext()
            Loop

        End With
        'Catch ex As Exception
        'MsgBox("Erro ao carregar dados!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        ' End Try

    End Sub


    Sub carregar_tipo_campo_fun()
        Try
            With frm_cad_fun.cmb_tipo.Items
                .Add("NOME_FUN")
                .Add("CARGO")
            End With
            frm_cad_fun.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar tipo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_campo_consulta()
        Try
            With frm_consultar.cmb_tipo.Items
                .Add("TIPO_CONSTRUCAO")
                .Add("NOME_MAQUINA")
                .Add("RUA")
                .Add("PLACA")
            End With
            frm_consultar.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar tipo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_campo_obra1()
        Try
            With frm_atribuir.cmb_tipo.Items
                .Add("TIPO_CONSTRUCAO")
                .Add("RUA")
            End With
            frm_atribuir.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar tipo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_campo_cadmaq()
        Try
            With frm_cad_maq.cmb_tipo_maq.Items
                .Add("NOME_MAQUINA")
                .Add("MARCA")
                .Add("PLACA")
            End With
            frm_cad_maq.cmb_tipo_maq.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar tipo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo_campo_maq()
        Try
            With frm_atribuir.cmb_maq.Items
                .Add("ID_OBRA")
                .Add("PLACA")
            End With
            frm_atribuir.cmb_maq.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar tipo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub
End Module