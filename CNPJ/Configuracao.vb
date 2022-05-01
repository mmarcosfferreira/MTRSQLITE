Imports System.IO


Public Class DadosEmpresa

   '<JsonProperty("Atividade_principal")> Quando querer seguir a norma padrão de a propreidade iniciar letra maiuscula
   Public Property atividade_principal() As List(Of Atividade_Principal)   'lista
   Public Property data_situacao As String
   Public Property tipo As String
   Public Property nome As String
   Public Property uf As String
   Public Property telefone As String
   Public Property email As String
   Public Property atividades_secundarias() As IEnumerable(Of Atividades_Secundarias) 'ienumerador
   Public Property situacao As String
   Public Property bairro As String
   Public Property logradouro As String
   Public Property numero As String
   Public Property cep As String
   Public Property municipio As String
   Public Property porte As String
   Public Property abertura As String
   Public Property natureza_juridica As String
   Public Property cnpj As String
   Public Property ultima_atualizacao As Date
   Public Property status As String
   Public Property fantasia As String
   Public Property complemento As String
   Public Property efr As String
   Public Property motivo_situacao As String
   Public Property situacao_especial As String
   Public Property data_situacao_especial As String
   Public Property capital_social As String
   Public Property qsa() As Object
   Public Property extra As Extra
   Public Property billing As Billing


   ''' <summary>
   ''' Método que executa uma rotina p Salvar arquivo JSon
   ''' </summary>
   ''' <param name="strJason">strJason vai receber uma string Json</param>
   ''' <param name="path">O nome de um arquivo com o caminho todo</param>
   Public Sub Salvar(strJason As String, path As String)
	 Try
	    Using sw = New StreamWriter(path)
		  sw.WriteLine(strJason)
	    End Using

	 Catch ex As Exception
	    MsgBox("Falha: " + ex.Message)
	 End Try

   End Sub


End Class


Public Class Extra

End Class

Public Class Billing
   Public Property free As Boolean
   Public Property database As Boolean
End Class

Public Class Atividade_Principal
   Public Property text As String
   Public Property code As String
End Class


Public Class Atividades_Secundarias
   Public Property text As String
   Public Property code As String
End Class











