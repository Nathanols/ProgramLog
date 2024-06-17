<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_maq
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cad_maq))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.busca = New System.Windows.Forms.ToolStripButton()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cmb_tipo_maq = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_dados_cadmaq = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome_maq = New System.Windows.Forms.TextBox()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.btn_excluir_cadmaq = New System.Windows.Forms.Button()
        Me.btn_cad_maq = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_frm_atribuir = New System.Windows.Forms.Button()
        Me.btn_frm_consultar = New System.Windows.Forms.Button()
        Me.btn_frm_cad_obra = New System.Windows.Forms.Button()
        Me.btn_frm_cad_maq = New System.Windows.Forms.Button()
        Me.btn_frm_cad_fun = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_dados_cadmaq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToolStrip2)
        Me.GroupBox1.Controls.Add(Me.dgv_dados_cadmaq)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(544, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 351)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MÁQUINAS"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.busca, Me.txt_busca, Me.ToolStripButton1, Me.cmb_tipo_maq})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(677, 28)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'busca
        '
        Me.busca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.busca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busca.Image = CType(resources.GetObject("busca.Image"), System.Drawing.Image)
        Me.busca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.busca.Name = "busca"
        Me.busca.Size = New System.Drawing.Size(92, 25)
        Me.busca.Text = "Pesquisar:"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(76, 28)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(114, 25)
        Me.ToolStripButton1.Text = "Procurar por:"
        '
        'cmb_tipo_maq
        '
        Me.cmb_tipo_maq.Name = "cmb_tipo_maq"
        Me.cmb_tipo_maq.Size = New System.Drawing.Size(92, 28)
        '
        'dgv_dados_cadmaq
        '
        Me.dgv_dados_cadmaq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_cadmaq.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_dados_cadmaq.Location = New System.Drawing.Point(6, 53)
        Me.dgv_dados_cadmaq.Name = "dgv_dados_cadmaq"
        Me.dgv_dados_cadmaq.RowHeadersWidth = 51
        Me.dgv_dados_cadmaq.Size = New System.Drawing.Size(677, 293)
        Me.dgv_dados_cadmaq.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "N°"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "PLACA"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "MÁQUINA"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "MARCA"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "EDITAR"
        Me.Column5.Image = CType(resources.GetObject("Column5.Image"), System.Drawing.Image)
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(544, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nome Máquina:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(643, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Placa:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(637, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Marca:"
        '
        'txt_nome_maq
        '
        Me.txt_nome_maq.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_maq.Location = New System.Drawing.Point(736, 100)
        Me.txt_nome_maq.Name = "txt_nome_maq"
        Me.txt_nome_maq.Size = New System.Drawing.Size(261, 29)
        Me.txt_nome_maq.TabIndex = 18
        '
        'txt_placa
        '
        Me.txt_placa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_placa.Location = New System.Drawing.Point(736, 140)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(261, 29)
        Me.txt_placa.TabIndex = 19
        '
        'txt_marca
        '
        Me.txt_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_marca.Location = New System.Drawing.Point(736, 183)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(261, 29)
        Me.txt_marca.TabIndex = 20
        '
        'btn_excluir_cadmaq
        '
        Me.btn_excluir_cadmaq.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_excluir_cadmaq.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_excluir_cadmaq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excluir_cadmaq.Location = New System.Drawing.Point(1078, 167)
        Me.btn_excluir_cadmaq.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_excluir_cadmaq.Name = "btn_excluir_cadmaq"
        Me.btn_excluir_cadmaq.Size = New System.Drawing.Size(141, 44)
        Me.btn_excluir_cadmaq.TabIndex = 23
        Me.btn_excluir_cadmaq.Text = "Excluir"
        Me.btn_excluir_cadmaq.UseVisualStyleBackColor = False
        '
        'btn_cad_maq
        '
        Me.btn_cad_maq.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_cad_maq.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cad_maq.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cad_maq.Location = New System.Drawing.Point(1078, 100)
        Me.btn_cad_maq.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cad_maq.Name = "btn_cad_maq"
        Me.btn_cad_maq.Size = New System.Drawing.Size(141, 44)
        Me.btn_cad_maq.TabIndex = 22
        Me.btn_cad_maq.Text = "Cadastrar"
        Me.btn_cad_maq.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btn_frm_atribuir)
        Me.Panel1.Controls.Add(Me.btn_frm_consultar)
        Me.Panel1.Controls.Add(Me.btn_frm_cad_obra)
        Me.Panel1.Controls.Add(Me.btn_frm_cad_maq)
        Me.Panel1.Controls.Add(Me.btn_frm_cad_fun)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 607)
        Me.Panel1.TabIndex = 24
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(251, 489)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 41
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(281, 489)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(275, 386)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(275, 288)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(275, 191)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(275, 106)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'btn_frm_atribuir
        '
        Me.btn_frm_atribuir.BackColor = System.Drawing.Color.Orange
        Me.btn_frm_atribuir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_frm_atribuir.Font = New System.Drawing.Font("Dubai Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_frm_atribuir.Location = New System.Drawing.Point(11, 479)
        Me.btn_frm_atribuir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_frm_atribuir.Name = "btn_frm_atribuir"
        Me.btn_frm_atribuir.Size = New System.Drawing.Size(301, 42)
        Me.btn_frm_atribuir.TabIndex = 26
        Me.btn_frm_atribuir.Text = "Atribuir Máquinas"
        Me.btn_frm_atribuir.UseVisualStyleBackColor = False
        '
        'btn_frm_consultar
        '
        Me.btn_frm_consultar.BackColor = System.Drawing.Color.Orange
        Me.btn_frm_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_frm_consultar.Font = New System.Drawing.Font("Dubai Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_frm_consultar.Location = New System.Drawing.Point(11, 377)
        Me.btn_frm_consultar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_frm_consultar.Name = "btn_frm_consultar"
        Me.btn_frm_consultar.Size = New System.Drawing.Size(301, 42)
        Me.btn_frm_consultar.TabIndex = 26
        Me.btn_frm_consultar.Text = "Consultar Obras"
        Me.btn_frm_consultar.UseVisualStyleBackColor = False
        '
        'btn_frm_cad_obra
        '
        Me.btn_frm_cad_obra.BackColor = System.Drawing.Color.Orange
        Me.btn_frm_cad_obra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_frm_cad_obra.Font = New System.Drawing.Font("Dubai Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_frm_cad_obra.Location = New System.Drawing.Point(11, 278)
        Me.btn_frm_cad_obra.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_frm_cad_obra.Name = "btn_frm_cad_obra"
        Me.btn_frm_cad_obra.Size = New System.Drawing.Size(301, 42)
        Me.btn_frm_cad_obra.TabIndex = 26
        Me.btn_frm_cad_obra.Text = "Cadastrar Nova Obra"
        Me.btn_frm_cad_obra.UseVisualStyleBackColor = False
        '
        'btn_frm_cad_maq
        '
        Me.btn_frm_cad_maq.BackColor = System.Drawing.Color.Orange
        Me.btn_frm_cad_maq.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_frm_cad_maq.Font = New System.Drawing.Font("Dubai Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_frm_cad_maq.Location = New System.Drawing.Point(11, 181)
        Me.btn_frm_cad_maq.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_frm_cad_maq.Name = "btn_frm_cad_maq"
        Me.btn_frm_cad_maq.Size = New System.Drawing.Size(301, 42)
        Me.btn_frm_cad_maq.TabIndex = 26
        Me.btn_frm_cad_maq.Text = "Cadastrar Máquinas"
        Me.btn_frm_cad_maq.UseVisualStyleBackColor = False
        '
        'btn_frm_cad_fun
        '
        Me.btn_frm_cad_fun.BackColor = System.Drawing.Color.Orange
        Me.btn_frm_cad_fun.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_frm_cad_fun.Font = New System.Drawing.Font("Dubai Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_frm_cad_fun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_frm_cad_fun.Location = New System.Drawing.Point(11, 99)
        Me.btn_frm_cad_fun.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_frm_cad_fun.Name = "btn_frm_cad_fun"
        Me.btn_frm_cad_fun.Size = New System.Drawing.Size(301, 42)
        Me.btn_frm_cad_fun.TabIndex = 1
        Me.btn_frm_cad_fun.Text = "Gerir Equipe"
        Me.btn_frm_cad_fun.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(102, 44)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(122, 10)
        Me.Panel8.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 45)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "MENU"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Gray
        Me.Panel7.Location = New System.Drawing.Point(0, 479)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(12, 42)
        Me.Panel7.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.Panel6.Location = New System.Drawing.Point(0, 99)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(12, 42)
        Me.Panel6.TabIndex = 28
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Location = New System.Drawing.Point(0, 181)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(12, 42)
        Me.Panel5.TabIndex = 28
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Location = New System.Drawing.Point(0, 278)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(12, 42)
        Me.Panel4.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Location = New System.Drawing.Point(0, 377)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(12, 42)
        Me.Panel3.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(412, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(317, 45)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "CADASTRAR MÁQUINAS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Orange
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(310, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1198, 44)
        Me.Panel2.TabIndex = 33
        '
        'frm_cad_maq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1443, 607)
        Me.Controls.Add(Me.btn_excluir_cadmaq)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_cad_maq)
        Me.Controls.Add(Me.txt_marca)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_placa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome_maq)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_cad_maq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRAR MÁQUINAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_dados_cadmaq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome_maq As TextBox
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents btn_excluir_cadmaq As Button
    Friend WithEvents btn_cad_maq As Button
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents busca As ToolStripButton
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents cmb_tipo_maq As ToolStripComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_frm_cad_fun As Button
    Friend WithEvents btn_frm_cad_maq As Button
    Friend WithEvents btn_frm_cad_obra As Button
    Friend WithEvents btn_frm_consultar As Button
    Friend WithEvents btn_frm_atribuir As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv_dados_cadmaq As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewImageColumn
End Class
