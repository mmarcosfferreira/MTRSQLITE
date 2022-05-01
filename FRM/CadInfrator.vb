Imports System.Data.OleDb
Public Class CadInfrator

#Region "Propriedades"

   ''' <summary>
   '''Representa uma conexão aberta com o banco de dados
   ''' </summary>
   Private Conexao As OleDbConnection

   ''' <summary>
   ''' Representa uma instrução SQL ou  um procedimento armazenado a executar contra um fonte de dados
   ''' </summary>
   Private Comando As OleDbCommand '

   ''' <summary>
   ''' Conjunto de comando de dados e uma Conexão c o banco dedados q sao usados p preencher o DataSet e atualizar a fonte de dados
   ''' </summary>
   Private Da As OleDbDataAdapter

   Private Dt As DataTable

   ''' <summary>
   ''' Fornece uma maneira de lerum fluxo somente de encaminhamentos de linha de dados por meio de uma fonte de dados. Esta Classe OledbDataReader n pode ser herdada 
   ''' </summary>
   Private Dr As OleDbDataReader '

#End Region

#Region "Construtor da classe"
   ''' <summary>
   ''' Serve para criar uma instancia da minha classe New aalguma coisa e é chamado automaticamente quando ao executar
   ''' Neste contexto quero iniciar a String de conexão
   ''' </summary>

   Sub New(NomedoArquivo As String)
	 'Conexao = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;Jet OLEDB:Database Password=MyDbPassword;")

	 Conexao = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\BD\" & NomedoArquivo & ";Jet OLEDB:Database Password=FERREIRA;")
   End Sub


#End Region

#Region "propriedades da classe"

   ''' <summary>
   ''' Nome do motorista Infrator
   ''' </summary>
   ''' <returns>Nome do motorista</returns>
   Public Property Motorista As String

   ''' <summary>
   ''' O que ocasionou o motivo do auto da infração
   ''' </summary>
   ''' <returns>Retorna o motivo</returns>


   Public Property Motivo As String
   ''' <summary>
   ''' Id Cad Infratores para fazer a identificação de cada registro, usado tbm para fazer buscas e pesquisas tanto para excluir como atualizar
   ''' </summary>
   ''' <returns>Id da linha afetada</returns>
   Public Property Id As Integer


   ''' <summary>
   ''' Informação auxiliar da Empresa do infrator
   ''' </summary>
   ''' <returns></returns>s
   Public Property Cliente_x_Transportador As String

   ''' <summary>
   ''' ID da Tabela EmpresaxCliente
   ''' </summary>
   ''' <returns></returns>
   Public Property ID_EmpresaxCliente As Integer


#End Region


#Region "Métodos da classe"

   '1 método será o insert que faremos nas linhas afetas usando o método function
   ''' <summary>
   ''' Adiciona um novo cliente
   ''' </summary>
   ''' <returns></returns>
   Public Function NovoCliente_Infrator() As Boolean

	 ' Dim retorno As Boolean
	 Try
	    'instanciar ocomando
	    Comando = New OleDbCommand

	    'CONFIGURAÇÃO DO COMANDO
	    Comando.Connection = Conexao
	    Comando.CommandText = "Insert Into CAD_INFRATORES (Motorista, Motivo, Cliente_x_Transportador) Values (@Motorista, @Motivo, @Empresa)"
	    Comando.Parameters.AddWithValue("@Motorista", Motorista)
	    Comando.Parameters.AddWithValue("@Motivo", Motivo)
	    Comando.Parameters.AddWithValue("@Empresa", Cliente_x_Transportador)
	    Conexao.Open()
	    NovoCliente_Infrator = Comando.ExecuteNonQuery 'Retorna a linha se foi afetada
	    Conexao.Close()

	 Catch ex As Exception
	    Throw ex 'aqui estamos jogando a excessão aonde esta sendo chamado
	 End Try

	 'retorna a função
	 Return NovoCliente_Infrator
   End Function

   ''' <summary>
   ''' Método para cadastrar EmpresaxCliente 
   ''' </summary>
   ''' <returns></returns>
   Public Function NovoCliente_EmpresaxCliente() As Boolean
	 Try
	    Comando = New OleDbCommand
	    Comando.Connection = Conexao
	    Comando.CommandText = "INSERT INTO CAD_EMPRESA(Cliente)VALUES(@Cliente)" 'insira na tabela Cad_empresa do campo Coluna 'Cliente' o parametro @cliente ' será substituido pela propriedade Rmpresaxcliente
	    Comando.Parameters.AddWithValue("@Cliente", Cliente_x_Transportador)
	    Conexao.Open()
	    NovoCliente_EmpresaxCliente = Comando.ExecuteNonQuery
	    Conexao.Close()
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Excepção")
	 End Try

	 Return NovoCliente_EmpresaxCliente

   End Function

   ''' <summary>
   ''' Método para realizar Update nos dados 
   ''' </summary>
   ''' <returns></returns>
   Public Function UpdateCliente() As Boolean
	 Dim Atualizar As New DataTable
	 Comando = New OleDbCommand 'Instancia um novo comando a ser executado
	 Comando.Connection = Conexao 'seta a conexão em aberta c bd
	 Comando.CommandText = "UPDATE CAD_INFRATORES SET MOTORISTA = @MOTORISTA, MOTIVO = @MOTIVO, Cliente_x_Transportador = @Cliente_x_Transportador WHERE CÓDIGO = @CODIGO"
	 Comando.Parameters.AddWithValue("@MOTORISTA", Motorista)
	 Comando.Parameters.AddWithValue("@MOTIVO", Motivo & " " & Now)
	 Comando.Parameters.AddWithValue("@Cliente_x_Transportador", Cliente_x_Transportador)
	 Comando.Parameters.AddWithValue("@CÓDIGO", Id)

	 'abre e fecha a coneção p executar o comando nonquery(linhas afetadas)
	 Conexao.Open()
	 Return Comando.ExecuteNonQuery


	 Da.Fill(Atualizar) 'atualiza meu grid depois de ter adicionada
	 Conexao.Close()

	 Try
	 Catch ex As Exception
	    Throw ex 'aqui estamos jogando a excessão aonde esta sendo chamado
	 End Try

	 Return UpdateCliente

   End Function

   ''' <summary>
   ''' Método para deletar registro
   ''' </summary>
   ''' <returns></returns>
#Region "Deletar Registro"
   Public Function Deletar() As Boolean
	 Dim Comando As New OleDbCommand
	 Try
	    Comando.Connection = Conexao
	    Comando.CommandText = "DELETE FROM CAD_INFRATORES WHERE CÓDIGO=@CODIGO"
	    Comando.Parameters.AddWithValue("@CODIGO", Id)

	    Conexao.Open()
	    Comando.ExecuteNonQuery()
	    Return True
	    Conexao.Close()
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro Gerado!")
	 End Try
	 Return Deletar


   End Function

#End Region

#Region "Pesquisar Registro"
   ''' <summary>
   ''' Pesquisa um registro atrvez do ID 
   ''' </summary>
   ''' <returns></returns>
   Public Function PesquisarRegistro_porID() As Boolean

	 Dim Comando As New OleDbCommand

	 Comando.Connection = Conexao
	 Comando.CommandText = "SELECT*FROM CAD_INFRATORES WHERE Código=@CODIGO"
	 Comando.Parameters.AddWithValue("@CODIGO", Id)
	 Conexao.Open()

	 'Preenche as propriedades com os valores se encontrado aonde estes valores serão atribuidos as respectivas textbox's
	 Dr = Comando.ExecuteReader
	 Do While Dr.Read 'leia linha por linha enquanto houver mais linhas.
	    Motorista = Dr("MOTORISTA") '> Nome da coluna do banco de dados
	    Motivo = Dr("MOTIVO")       '> Nome da coluna do Banco de dados   
	    Cliente_x_Transportador = Dr("Cliente_x_Transportador") '> nome da coluna
	    PesquisarRegistro_porID = True
	 Loop
	 Conexao.Close()
	 Return PesquisarRegistro_porID 'finalmente retorne a minha função
   End Function

#End Region

   ''' <summary>
   ''' Carrega os registros para o dataGrid
   ''' </summary>
   ''' <param name="Nome">Parametro Opticional com valor default= nothoing</param>
   ''' <returns>Se o parametro for vazio usa o Da para fazer um select *from TAbela
   ''' Se o parametro nome não for vazio faz um select usando a clasula where p apontar p o campo motorista</returns>

   Public Function CarregarInfrator_pelo_Nome(Optional Nome As String = Nothing) As DataTable 'Como meu retorno é deste tipo terei q instanciar o data adapter
	 Dim Comando As New OleDbCommand
	 Dim Retorno As New DataTable
	 Comando.Connection = Conexao
	 Try
	    If Nome = String.Empty Then 'Se eu não preencher a caixa de texto significa quequero todos os registros ao pressionar o botão
		  Comando.CommandText = "SELECT*FROM CAD_INFRATORES"

		  ' traga todos registros onde na coluna motorista pode conter qualquer parte do nome q eu digitar a esquerda ou a direita
	    Else 'significa que estou pesquisando algum nome
		  Comando.CommandText = "SELECT*FROM CAD_INFRATORES WHERE MOTORISTA LIKE'%'+@MOTORISTA+'%'"
		  Comando.Parameters.AddWithValue("@MOTORISTA", Nome) ' este nome é do método do carregarinfrator
	    End If

	    If Conexao.State = ConnectionState.Closed Then Conexao.Open()
	    Da = New OleDbDataAdapter(Comando) ' instancio meu dataadapter(da) q ira preencher meu datatable com retorno de um select
	    Da.Fill(Retorno) 'atualizo nosso retorno q é uma tabela
	    Conexao.Close()
	 Catch ex As Exception

	 End Try

	 Return Retorno 'retorno meu datatable
   End Function


   Public Function CarregarEmpresaxClientes() As DataTable
	 '--------preciso de 1 comando, 1tabela,1conexao--------

	 Dim Comando As New OleDbCommand
	 Dim Retorno As DataTable = New DataTable
	 Comando.Connection = Conexao
	 Try

	    Conexao.Open()
	    Comando.CommandText = "SELECT * FROM CAD_EMPRESA where Cliente"
	    Da = New OleDbDataAdapter(Comando) ' instancio meu dataadapter(da) q ira preencher meu datatable com retorno de um select
	    Da.Fill(Retorno) 'atualizo nosso retorno q é uma tabela

	 Catch ex As Exception
	 Finally
	    Conexao.Close()
	 End Try

	 Return Retorno 'retorno meu datatable
	 Conexao.Close()
   End Function


#End Region

End Class
