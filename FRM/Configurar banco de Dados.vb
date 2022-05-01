Public Class FRMConfigurar_banco_de_Dados


   Friend WithEvents ConfigBanco As FRMConfigurar_banco_de_Dados

   Sub New()
	 Try
	    ' Esta chamada é requerida pelo designer.
	    InitializeComponent()
	    My.Settings.Reload()
	 Catch ex As Exception
	    MsgBox(ex.Message.ToString)
	 End Try



   End Sub



   'Se caso não tiver rede a aplicação vai travar 
   'neste caso deve-se trabalhar com o banco de dados LocalHost
   Private Sub FRMConfigurar_banco_de_Dados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


	 My.Settings.Reload()
	 RadioButtonServer.Checked = My.Settings.Config_ini

	 'Activate()
	 TimerRede.Start()


   End Sub


   'Verifica se temos a conexão
   Friend Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerRede.Tick

	 Internet.Conexão_com_Rede(LblStatusdaRede)

   End Sub

   Private Sub FRMConfigurar_banco_de_Dados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
	 TimerRede.Stop()

	 If RadioButtonServer.Checked = True Then

	    If MsgBox("Deseja salvar configurações para 'Server' ? ", 64 + 4, "Salvamento na nuvem!") = DialogResult.Yes Then

		  My.Settings.Config_ini = RadioButtonServer.Checked

		  RadioButtonLocalHost.Checked = False


		  My.Settings.Save()
		  My.Settings.Reload()
	    End If

	 ElseIf RadioButtonServer.Checked = False Then

	    If MsgBox("Deseja salvar configurações para servidor'LocalHost' ? ", 64 + 4, "Salvamento Local!") = DialogResult.Yes Then

		  My.Settings.Config_ini = RadioButtonServer.Checked
		  My.Settings.Save()
	    End If

	 End If





   End Sub

   Private Sub FRMConfigurar_banco_de_Dados_Invalidated(sender As Object, e As InvalidateEventArgs) Handles Me.Invalidated

   End Sub
End Class