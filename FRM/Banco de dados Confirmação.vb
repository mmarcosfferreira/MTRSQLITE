Public Class FRMConfirmarBancodeDados
   Private Sub FRMConfirmarBancodeDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub BTVoltar_Click(sender As Object, e As EventArgs) Handles BTVoltar.Click
	 Close()
	 FrmMTR.Activate()
   End Sub



   Dim Conta As Integer = 1
   Private Sub BTOk_Click(sender As Object, e As EventArgs) Handles BTOk.Click

	 If TxtSenha.Text = "ferreiram" Then
	    FRMConfigurar_banco_de_Dados.Show()
	    Close()
	 Else
	    If Conta <= 3 Then
		  MsgBox("Senha errada! Contate o administrador do sistema.")
		  LblContagem.Text = "Tentativas: " & Conta
		  Conta += 1
		  Return
	    Else
		  MsgBox("O sistema está sendo fechado devido a várias tentativas de acesso sem êxito!")
		  End
	    End If
	 End If


   End Sub
End Class