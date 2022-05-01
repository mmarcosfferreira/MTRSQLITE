Public Class Frmpesoliquido
   Private Sub Frmpesoliquido_Load(sender As Object, e As EventArgs) Handles MyBase.Load


	 txtpesobruto.Text = 0
	 txtpesotara.Text = 0
	 Me.Activate()

   End Sub

   Private Sub Txtpesoliquido_TextChanged(sender As Object, e As EventArgs) Handles txtpesoliquido.TextChanged
	 Try
	    Dim Result As Decimal
	    Dim PB As Double = Val(txtpesobruto.Text)
	    Dim PT As Double = Val(txtpesotara.Text)
	    Result = PB - PT
	    txtpesoliquido.Text = Result
	 Catch ex As Exception
	    ex.Message.ToString()
	 End Try

   End Sub

   Private Sub Txtpesobruto_TextChanged(sender As Object, e As EventArgs) Handles txtpesobruto.TextChanged
	 Try
	    Dim Result As Decimal
	    Dim PB As Double = Val(txtpesobruto.Text)
	    Dim PT As Double = Val(txtpesotara.Text)
	    Result = PB - PT
	    txtpesoliquido.Text = Result
	 Catch ex As Exception
	    ex.Message.ToString()
	 End Try

   End Sub

   Private Sub Txtpesotara_TextChanged(sender As Object, e As EventArgs) Handles txtpesotara.TextChanged

	 Try
	    Dim Result As Decimal
	    Dim PB As Double = Val(txtpesobruto.Text)
	    Dim PT As Double = Val(txtpesotara.Text)
	    Result = PB - PT
	    txtpesoliquido.Text = Result
	 Catch ex As Exception
	    ex.Message.ToString()
	 End Try

   End Sub

   Private Sub Frmpesoliquido_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
	 If e.KeyCode = Keys.Escape Then
	    Close()
	 End If
	 If e.KeyValue = Keys.F3 Then
	    Visible = False

	 ElseIf e.KeyValue = Keys.F3 Then
	    Visible = False



	 End If

   End Sub

   Private Sub Txtpesobruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesobruto.KeyPress

	 'ASC(e.keychar)=8     >> deleta a esquerda
	 'ASC(e.keychar)=127   >> deleta a direita
	 If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 127 AndAlso Asc(e.KeyChar) <> 8 Then
	    e.Handled = True  'ENTÃO BLOQUEIE
	 Else

	 End If
   End Sub

   Private Sub Txtpesotara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpesotara.KeyPress



	 'ASC(e.keychar)=8     >> deleta a esquerda
	 'ASC(e.keychar)=127   >> deleta a direita
	 ' If Not Char.IsNumber(e.KeyChar)  se não é um numero
	 If Not Char.IsNumber(e.KeyChar) AndAlso Asc(e.KeyChar) <> 127 AndAlso Asc(e.KeyChar) <> 8 Then
	    e.Handled = True  'ENTÃO BLOQUEIE
	 Else

	 End If



   End Sub

   Private Sub Frmpesoliquido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
	 If e.KeyChar = Chr(27) Then
	    Me.Hide()
	 End If
   End Sub

   Private Sub Frmpesoliquido_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
	 Hide()



   End Sub

   Private Sub Txtpesobruto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpesobruto.KeyDown, txtpesotara.KeyDown, txtpesoliquido.KeyDown
	 If e.KeyValue = Keys.Alt + Keys.P And Me.Visible = True Then
	    Visible = True

	 End If
   End Sub

   Private Sub lblliquido_Click(sender As Object, e As EventArgs) Handles lblliquido.Click

   End Sub

   Private Sub CheckBoxTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTopMost.CheckedChanged
	 If CheckBoxTopMost.Checked = True Then
	    Call TopMost_.TopMost_(sender, Me)
	 ElseIf Me.CheckBoxTopMost.Checked = False Then
	    TopMost = False
	 Else
	    CheckBoxTopMost.CheckState = CheckState.Indeterminate
	 End If
   End Sub
End Class