



Imports System.Data.SQLite

Public Class Cad_Controle_de_Pesagem_Manual_Transportador

   'Propriedades do banco
   Private Conexao As SQLiteConnection 'trata da conexão
   Private Comando As SQLiteCommand    'Trata do comando
   'Private Da As SQLiteDataAdapter     'trata do preenchimento e atualização do dataSet
   Private Dt As DataTable            'Trata das tabelas de um data Set
   Private Dr As SQLiteDataReader      'Trata das leituras dos fluxos dos dados: Data set, tabela texto etc
   Private Da As SQLiteDataAdapter

   'Construtor
   Sub New(NomedoArquivo As String)
	 'definindo a conexao
	 Conexao = New SQLiteConnection("Data Source=" & Application.StartupPath & "\BD\" & NomedoArquivo)
   End Sub



   'propriedades da classe 
   Public Property Código As Integer
   Public Property Transportador_Fornecedor As String


   'Métodos ou funções da classe
   Public Function Adicionar() As Boolean
	 Dim Tabela As New DataTable
	 Comando = New SQLiteCommand
	 Comando.Connection = Conexao
	 Try
	    Conexao.Open()
	    Comando = New SQLiteCommand("select count(*) from 
                                       CAD_CONTROLE_PESAGEM_MANUAL_TRANSPORTADOR_FORNECEDOR 
                                       where TRANSPORTADOR_FORNECEDOR=" & "'" & Transportador_Fornecedor & "'", Conexao)
	    Dim I As Integer = Comando.ExecuteScalar
	    If I = 0 Then
		  Comando = New SQLiteCommand("insert into CAD_CONTROLE_PESAGEM_MANUAL_TRANSPORTADOR_FORNECEDOR(TRANSPORTADOR_FORNECEDOR) values (?)", Conexao)
		  Comando.Parameters.AddWithValue("@TRANSPORTADOR_FORNECEDOR", Transportador_Fornecedor)
		  Adicionar = Comando.ExecuteNonQuery
		  Conexao.Close()
	    Else
		  MsgBox("Existe um registro com esses dados informados", vbCritical, "MarcosFerreira - Projetos T.I")
	    End If
	 Catch ex As Exception
	    MsgBox(ex.Message, vbCritical, "Erro")
	 End Try
	 Return Adicionar
   End Function

   ''' <summary>
   ''' Função para carregar a tabela do banco !
   ''' </summary>
   ''' <param name="nome">Nome do banco de dados</param>
   ''' <returns></returns>
   Public Function Carregar(nome As String) As DataTable

	 Dim Comando As New SQLiteCommand
	 Dim Tabela As New DataTable

	 Comando.Connection = Conexao
	 Comando.CommandText = "select * from CAD_CONTROLE_PESAGEM_MANUAL_TRANSPORTADOR_FORNECEDOR"
	 If Conexao.State = ConnectionState.Closed Then Conexao.Open()

	 Da = New SQLiteDataAdapter(Comando)
	 Da.Fill(Tabela)
	 Conexao.Close()
	 Return Tabela

   End Function




End Class
