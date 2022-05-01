Module Checking_da_Instancia_aplicação
   Dim EmExecução As Boolean
   Dim EmExecuçãoFRM As Boolean
   ''' <summary>
   ''' Obtem o nome do processo mediante o retorno da variavel bolean! Se ele for maior que 1 significa que existe mais de uma instancia rodando da aplicação 
   ''' neste caso ela se chama {System.Diagnostics.Process (Principal)}
   ''' </summary>
   Public Sub AbrirUmaInstanciadaAplicação()

	 EmExecução = Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1
	 If EmExecução = True Then
	    If MsgBox("Há mais de uma instancia do projeto em aberto: " & Application.ExecutablePath, " " & vbNewLine & MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Atenção") = DialogResult.Yes Then
		  End
	    Else
		  MsgBox("É altamente recomendável fechar uma das instancias afim de não gerar erros!")
	    End If
	 End If
   End Sub



End Module
