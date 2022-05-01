
Public Class FrmInfratores

   Private Banco As CadInfrator
   Private Sub BTADICIONAR_Click(sender As Object, e As EventArgs) Handles BTADICIONAR.Click
	 Banco = New CadInfrator("BDVITAL.accdb")
	 Try
	    Banco.Motorista = TxtMotorista.Text
	    Banco.Motivo = TxtMotivo.Text & " " & Now
	    Banco.Cliente_x_Transportador = CBOEmpresa.Text
	    If Banco.NovoCliente_Infrator = True Then
		  MsgBox("Cliente adicionado com sucesso!", vbInformation, "Atenção")
		  TxtMotorista.Text = ""
		  TxtMotivo.Text = ""
		  TxtMotorista.Focus()

		  'atualiza para q possa aparecer c novo valor adicionado
		  Dim Tabela As DataTable
		  Tabela = Banco.CarregarInfrator_pelo_Nome("")
		  DGVdados.DataSource = Tabela
	    Else
		  MessageBox.Show("Problema ao adicionar cliente!")
	    End If
	 Catch ex As Exception
	    MessageBox.Show(ex.Message)
	 End Try


   End Sub

   Private Sub BTEDITAR_Click(sender As Object, e As EventArgs) Handles BTEDITAR.Click

	 Banco = New CadInfrator("BDVITAL.accdb")
	 Try
	    Banco.Id = Convert.ToInt32(TXTID.Text)
	    Banco.Motorista = TxtMotorista.Text
	    Banco.Motivo = TxtMotivo.Text
	    Banco.Cliente_x_Transportador = CBOEmpresa.Text
	    If Banco.UpdateCliente = True Then
		  MsgBox("Cliente atualizado com sucesso!")

		  Dim Tabela As DataTable
		  Tabela = Banco.CarregarInfrator_pelo_Nome(Nothing)
		  DGVdados.DataSource = Tabela
	    Else
		  MessageBox.Show("Problema ao atualizar cliente!")
	    End If
	 Catch ex As Exception
	    MessageBox.Show(ex.Message)
	 End Try



   End Sub

#Region "Buscar por ID"
   ''' <summary>
   ''' Rotina para pesquisar infrator pelo id
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub BTBUSCAR_Click(sender As Object, e As EventArgs) Handles BTBUSCAR.Click

	 Banco = New CadInfrator("BDVITAL.accdb")
	 Try
	    Banco.Id = CInt(TXTID.Text)
	    If Banco.PesquisarRegistro_porID = True Then
		  TxtMotorista.Text = Banco.Motorista
		  TxtMotivo.Text = Banco.Motivo
	    Else
		  MsgBox("Id não encontrado", vbInformation, "Pesquisa concluída")
	    End If

	 Catch ex As Exception
	    MsgBox("Detalhes da excepção " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Foi gerado uma excepção!")
	 End Try

   End Sub

#End Region



   Private Sub BTEXCLUIR_Click(sender As Object, e As EventArgs) Handles BTEXCLUIR.Click
	 Banco = New CadInfrator("BDVITAL.accdb")
	 Try
	    Banco.Id = Convert.ToInt32(TXTID.Text)

	    If Banco.Deletar = True Then
		  MsgBox("Registro deletado com sucesso!")
		  TxtMotorista.Text = ""
		  TxtMotivo.Text = ""
		  TxtMotorista.Focus()

		  Dim Tabela As DataTable
		  Tabela = Banco.CarregarInfrator_pelo_Nome("")
		  DGVdados.DataSource = Tabela

	    Else
		  MessageBox.Show("Problema ao tentar deletar cliente!")
	    End If
	 Catch ex As Exception
	    MessageBox.Show(ex.Message & " " & "talves vc tenha q selecionar o id")
	 End Try


   End Sub


   Private Sub BTSAIR_Click(sender As Object, e As EventArgs) Handles BTSAIR.Click
	 Close()
   End Sub

   'Dim str() As String = New String() {IB}
   'CBOEmpresa.Items.AddRange(str)
   Private Sub BTCADEMPRESA_Click(sender As Object, e As EventArgs) Handles BTCADEMPRESA.Click


	 Dim Banco = New CadInfrator("BDVITAL.accdb")

	 Dim IB = InputBox("Digite o nome da Empresa x Cliente", "Cadastro de ClientexEmpresa",, 340, 340)
	 If IB <> String.Empty And IB <> "" Then

	    Banco.Cliente_x_Transportador = IB  'ATRIBUO A MINHA PROPRIEDADE O VALOR DA VARIAVEL

	    If Banco.NovoCliente_EmpresaxCliente = True Then
		  'CBOEmpresa.Items.Add(IB.ToString)
		  MsgBox("Adicionado corretamente!", vbInformation, "Informação")
	    End If
	 Else
	    IB = DialogResult.Cancel
	    MsgBox("Você cancelou a operação ou não digitou!", vbInformation, "Informação")
	 End If


   End Sub


   Private Sub LLCarregarAtualizar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLCarregarAtualizar.LinkClicked

	 Banco = New CadInfrator("BDVITAL.accdb")
	 Dim Dt As DataTable
	 Try

	    Dt = Banco.CarregarEmpresaxClientes
	    CBOEmpresa.DisplayMember = "Cliente"
	    CBOEmpresa.DataSource = Dt

	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Excepção Encontrada")
	 End Try

   End Sub

   ''' <summary>
   ''' Esta rotina lista oq for digitado na caixa de texto Motorista com parâmetro opcional e usando um operador like
   '''  Comando.CommandText = "SELECT*FROM CAD_INFRATORES WHERE MOTORISTA LIKE'%'+@MOTORISTA+'%'" para pesquisar ou listar
   ''' </summary>
   ''' <param name="sender"></param>
   ''' <param name="e"></param>
   Private Sub BTLISTAR_INFRATORES_Click(sender As Object, e As EventArgs) Handles BTLISTAR_INFRATORES.Click
	 Banco = New CadInfrator("BDVITAL.accdb")
	 Dim Tabela As DataTable
	 Try
	    Tabela = Banco.CarregarInfrator_pelo_Nome(TxtMotorista.Text)
	    DGVdados.DataSource = Tabela
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Excepção Encontrada")

	 End Try

   End Sub



   Private Sub DGVdados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVdados.CellContentDoubleClick
	 TXTID.Text = DGVdados.CurrentRow.Cells(0).Value.ToString
	 TxtMotorista.Text = DGVdados.CurrentRow.Cells(1).Value.ToString
	 TxtMotivo.Text = DGVdados.CurrentRow.Cells(2).Value.ToString

	 CBOEmpresa.Text = DGVdados.CurrentRow.Cells(3).Value.ToString

   End Sub

   Private Sub FrmInfratores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	 'addhandler Manipulador de evento, addressof Função/Rotina/Sub o nome de um método/rotina sem parenteses
	 'AddHandler LLCarregarAtualizar.LinkClicked, AddressOf LLCarregarAtualizar_LinkClicked
	 AddHandler LLCarregarAtualizar.LinkClicked, AddressOf LLCarregarAtualizar_LinkClicked

   End Sub
End Class