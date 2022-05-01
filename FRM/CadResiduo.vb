Imports System.Data.SQLite
Imports Microsoft.Data.Sqlite

Public Class CadResiduo
#Region "Propriedades das variáveis do banco de dados"
   ''' <summary>
   '''Representa uma conexão aberta com o banco de dados
   ''' </summary>
   Private Conexao As SqliteConnection

   ''' <summary>
   ''' Representa uma instrução SQL ou  um procedimento armazenado a executar contra um fonte de dados
   ''' </summary>
   Private Comando As SqliteCommand '

   '''' <summary>
   '''' Conjunto de comando de dados e uma Conexão c o banco dedados q sao usados p preencher o DataSet e atualizar a fonte de dados
   '''' </summary>
   'Private Da As SQLiteDataAdapter

   Private Dt As DataTable

   ''' <summary>
   ''' Fornece uma maneira de lerum fluxo somente de encaminhamentos de linha de dados por meio de uma fonte de dados. Esta Classe OledbDataReader n pode ser herdada 
   ''' </summary>
   Private Dr As SqliteDataReader '

#End Region

   Sub New(ByVal NomedoArquivo As String)
	 'definindo a conexao
	 Conexao = New SqliteConnection("Data Source=" & Application.StartupPath & "\BD\" & NomedoArquivo)
   End Sub



#Region "propriedades da classe"
   Public Property Codigo As Integer
   Public Property RESIDUO As String


#End Region

#Region "Métodos da classe"
   'adicionar
   ''' <summary>
   ''' Adiciona um novo registro no formulário MTR
   ''' </summary>
   ''' <returns></returns>
   Public Function Adicionar() As Boolean
	 Dim Tabela As New DataTable 'p atualizar o grid depois q adicionar
	 Comando = New SqliteCommand
	 Comando.Connection = Conexao
	 Try
	    Conexao.Open()
	    Comando = New SqliteCommand("Select count(*) from CAD_RESIDUO where RESIDUO=" & "'" & RESIDUO & "'", Conexao)               '"insert into cad_mtr (mtr, datahora, op_entrada, observacao) values (@mtr, @datahora, @op_entrada, @observacao)"))
	    Dim I As Integer = Comando.ExecuteScalar

	    If I = 0 Then
		  Comando = New SqliteCommand("insert into cad_residuo (RESIDUO) values (?)", Conexao)
		  Comando.Parameters.AddWithValue("@RESIDUO", RESIDUO) 'aqui adiciona
		  Adicionar = Comando.ExecuteNonQuery
		  Conexao.Close()
	    Else
		  MsgBox("Existe um registro com esses dados informados", vbCritical, "MarcosFerreira - Projetos T.I")
	    End If

	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro")
	 Finally
	    Conexao.Close()
	 End Try
	 Return Adicionar
   End Function

   Public Function Carregar() As DataTable

	 Dim Tabela As New DataTable

	 Using Con As New SqliteConnection(Conexao.ConnectionString)
	    Con.Open()
	    Using da As New SQLiteDataAdapter("SELECT * FROM CAD_RESIDUO", Con)
		  da.Fill(Tabela)
	    End Using
	    Con.Close()
	 End Using
	 Return Tabela

	 '   Dim I As CadResiduo = New CadResiduo("BDVITAL.db")
	 'try
	 '   If Conexao.State = ConnectionState.Closed Then Conexao.Open() 'ABRE A ACONEXÃO
	 '   Comando.CommandText = "select * from CAD_RESIDUO WHERE RESIDUO"
	 '   Da = New SQLiteDataAdapter(Comando)
	 '   Da.Fill(Tabela)
	 '   Conexao.Close()

	 'Catch ex As Exception
	 '   MsgBox(ex.Message, vbCritical, "Erro não tratado")
	 'End Try

   End Function




#End Region

End Class
