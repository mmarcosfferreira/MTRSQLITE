

Public Class FrmSomarHoras
   '
   Dim Horas As Integer = 0
   Dim Minutos As Integer = 0
   Dim Segundos As Integer = 0


   'COLOCAR FORM NO TOPO CENTRALIZDO
   'Public Sub Topo(ByVal Formulario As Form)

   '    Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, 180)
   '    ' Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, 0)
   'End Sub

   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	 'Carregar o form no topo e centralizado
	 '  Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, 0)

	 '========================================================================================

	 Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, 180)
	 KeyPreview = True
	 Label1.Text = V



   End Sub



   Private Sub Calcular2()

	 'cont = DateTimePicker1.Value.Hour & ":" & DateTimePicker1.Value.Minute & ":" & DateTimePicker1.Value.Second

	 Horas += DateTimePicker1.Value.Hour * 3600
	 Minutos += DateTimePicker1.Value.Minute * 60
	 Segundos += DateTimePicker1.Value.Second


	 Dim n1, n2, n3, n4, n5, n6, n7 As Double

	 n1 = Val(Horas + Minutos + Segundos)    'total de segundos

	 If n1 < 86400 AndAlso RadioButton1.Checked = True Then
	    n2 = Math.Truncate(n1 / 3600) 'acha a hora

	    n3 = n1 Mod 3600 'guarda a sobra da hora

	    n4 = Math.Truncate(n3 / 60)     'encontra os minutos do resto em n3

	    n5 = n3 Mod 60 'guarda o resto

	    Label1.Text = String.Format("{00}:{01}:{02}", n2 & " horas ", n4 & " minutos", n5 & " segundos")

	    '==================================================================================================================

	 ElseIf n1 >= 86400 AndAlso RadioButton1.Checked = True Then

	    n2 = Math.Truncate(n1 / 86400) 'acha a parte inteira do dia
	    n3 = n1 Mod 86400 'pega o resto do (dia em segundos) e armazena em nesta variavel
	    n4 = Math.Truncate(n3 / 3600) 'acha a parte inteira da (HORA) q esta guardada na variavel n3
	    n5 = n3 Mod 3600            'pega o resto da hora e armazen  nesta variavel
	    n6 = Math.Truncate(n5 / 60) ' acha os minutos e armazena nesta variavel
	    n7 = n5 Mod 60   'acha os milimetros


	    Label1.Text = String.Format("{00}:{01}:{02}:{03}", n2 & " dias ", n4 & " horas ", n6 & " minutos", (n7) & " segundos ")
	    '=================================================================================

	 ElseIf n1 < 86400 AndAlso RadioButton2.Checked = True Then 'Se é menor q um dia

	    DateTimePicker2.Enabled = True
	    'Zerar_var()
	    Label1.Text = V


	    Dim Guardar As Single = Horas + Minutos + Segundos

	    n2 = Math.Truncate(n1 / 3600) 'acha a hora

	    n3 = n1 Mod 3600 'guarda a sobra da hora

	    n4 = Math.Truncate(n3 / 60)     'encontra os minutos do resto em n3

	    n5 = n3 Mod 60 'guarda o resto

	    Dim f As String = String.Format("{00}:{01}:{02}", n2 & " hora's' ", n4 & " minuto's' ", n5 & " segundo's' " & "  (" & Guardar & " Segundo's' )")

	    Dim HoraInicial As Date = DateTimePicker1.Value.ToLongTimeString
	    Dim HoraFinal As Date = DateTimePicker2.Value.ToLongTimeString
	    Label1.Text = HoraInicial.Subtract(HoraFinal).ToString

	    ' Dim x As New TimeSpan(DateTimePicker1.Value.Hour, DateTimePicker1.Value.Minute, DateTimePicker1.Value.Second)
	    ' MsgBox(x.ToString)



	 End If


   End Sub


   Private Sub CalcularSubtração()
	 Dim A0 As TimeSpan
	 Dim A1, A2 As Date

	 A1 = DateTimePicker1.Value.ToString
	 A2 = DateTimePicker2.Value.ToString

	 A0 += A1.Subtract(A2)  'A2

	 Label1.Text = A0.ToString

   End Sub


   Private Sub Zerar_var()
	 Label1.Text = V

	 Horas = 0
	 Minutos = 0
	 Segundos = 0

   End Sub



   ''' função Asc() : capturar codigo ascii de um caractere
   ''' função AscW() : capturara codigo Unicode de um caractere
   ''' função Chr() : descobrir caractere apartir de seu codigo

   Private Sub DateTimePicker1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker1.KeyPress, DateTimePicker2.KeyPress

	 'se teclar enter mande o valor do objeto  para incremento de soma acumulativa

	 If e.KeyChar = Chr(13) Then

	    If RadioButton1.Checked = True Then
		  Calcular2()
		  ' se teclar enter para DENTRO DO
	    ElseIf RadioButton2.Checked = True And DateTimePicker1.Value > DateTimePicker2.Value Then
		  CalcularSubtração()
	    End If

	 ElseIf e.KeyChar = Chr(8) Then '8


	    Zerar_var()
	    Label1.Text = V


	 ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(35) Then

	    Hide()

	    ' se teclar Esc pergunte se realmente quer sair
	 ElseIf e.KeyChar = Chr(27) AndAlso MessageBox.Show("Deseja sair da aplicação?", "Atenção " & UsuarioLogado.UsuarioLogado, MessageBoxButtons.YesNo) = DialogResult.Yes Then
	    Close()

	 End If


   End Sub

   'Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer
   'Private ctrlKey As Boolean = GetAsyncKeyState(Keys.ControlKey)
   'Private shiftKey As Boolean = GetAsyncKeyState(Keys.ShiftKey)
   'Private theKey As Boolean = GetAsyncKeyState(Keys.K)


   Const V As String = "__:__:__"

   Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown, DateTimePicker2.KeyDown

	 'se teclar delete para direita
	 If e.KeyCode = Keys.Delete Then
	    Zerar_var()
	    Label1.Text = V

	 End If


   End Sub




   Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
	 If RadioButton2.Checked = True Then
	    DateTimePicker1.Enabled = True
	    DateTimePicker2.Enabled = True
	 End If


   End Sub

   Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
	 DateTimePicker2.Enabled = False

   End Sub



   Private Sub FrmSomarHoras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
	 If e.KeyChar = Chr(32) Then
	    MsgBox("Ocultar ?  ", Buttons:=MsgBoxStyle.Exclamation, UsuarioLogado.UsuarioLogado)
	    Me.Visible = False
	 End If

   End Sub




   Private Sub FrmSomarHoras_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

   End Sub

   Private Sub FrmSomarHoras_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
	 FrmPrincipal.Show()

   End Sub

   Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

   End Sub
End Class
