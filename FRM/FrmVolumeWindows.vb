
Imports System.Runtime.InteropServices
Public Class FrmVolumeWindows


   Private Sub BTtopmost__Click(sender As Object, e As EventArgs)
	 TopMost_.TopMost_(sender, Me)
   End Sub


   <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
   End Function
   Const WM_APPCOMMAND As UInteger = &H319
   Const APPCOMMAND_VOLUME_UP As UInteger = &HA
   Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
   Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8

   Dim TRACKANTERIOR As Integer
   Dim BANDERA As Boolean = False
   Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)

	 'If TrackBar1.Value > TRACKANTERIOR Then
	 '    For i = TRACKANTERIOR To TrackBar1.Value
	 '        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
	 '    Next

	 'ElseIf TrackBar1.Value < TRACKANTERIOR Then
	 '    For i = TrackBar1.Value To TRACKANTERIOR
	 '        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
	 '    Next
	 'End If
	 'TRACKANTERIOR = TrackBar1.Value
	 'Label2.Text = TrackBar1.Value * 2 & "  %"



	 'If Count >= 0 And Count <= 100 Then

	 '    If TrackBar1.Value > _croll3 Then
	 '        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
	 '    End If


	 '    If TrackBar1.Value < _croll3 Then
	 '        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
	 '    End If


	 'End If

	 '_croll3 = TrackBar1.Value
	 'Count = 0 '1




	 '        Imports System.Runtime.InteropServices
	 'Public Class Form1
	 '        <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
	 '        End Function

	 '        Const WM_APPCOMMAND As UInteger = &H319
	 '        Const APPCOMMAND_VOLUME_UP As UInteger = &HA
	 '        Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
	 '        Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8

	 '        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
	 '            SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
	 '        End Sub
	 '        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
	 '            SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
	 '        End Sub
	 '        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
	 '            SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
	 '        End Sub
	 '    End Class

   End Sub

   Private Sub BtnVolumeGeral_Click(sender As Object, e As EventArgs) Handles BtnVolumeGeral.Click
	 Volume_do_Windows.TodosCanais()
   End Sub

   Private Sub BtMute_Click(sender As Object, e As EventArgs) Handles BtMute.Click
	 Volume_do_Windows.btnMute_Click(BtMute, e)
   End Sub

   Private Sub BTtopmost__Click_1(sender As Object, e As EventArgs) Handles BTtopmost_.Click
	 TopMost_.TopMost_(BTtopmost_, Me)
   End Sub


   Private Sub TrackBar1_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseDown
	 BANDERA = True
   End Sub


   Private Sub FrmVolumeWindows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	 TrackBar1.Maximum = 50

	 TrackBar1.Value = 25
	 Label2.Text = TrackBar1.Value * 2 & "  %"
	 TRACKANTERIOR = TrackBar1.Value


   End Sub

   Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
	 If BANDERA = True Then
	    If TrackBar1.Value > TRACKANTERIOR Then
		  For i = TRACKANTERIOR To TrackBar1.Value
			SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
		  Next

	    ElseIf TrackBar1.Value < TRACKANTERIOR Then
		  For i = TrackBar1.Value To TRACKANTERIOR
			SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
		  Next
	    End If
	    TRACKANTERIOR = TrackBar1.Value
	    Label2.Text = TrackBar1.Value * 2 & "  %"
	    BANDERA = False
	 End If
   End Sub

   Private Sub TrackBar1_Scroll_1(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
	 If BANDERA = True Then
	    If TrackBar1.Value > TRACKANTERIOR Then
		  For i = TRACKANTERIOR To TrackBar1.Value
			SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
		  Next

	    ElseIf TrackBar1.Value < TRACKANTERIOR Then
		  For i = TrackBar1.Value To TRACKANTERIOR
			SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
		  Next
	    End If
	    TRACKANTERIOR = TrackBar1.Value
	    Label2.Text = TrackBar1.Value * 2 & "  %"
	    BANDERA = False
	 End If
   End Sub

   Private Sub FrmVolumeWindows_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick



	 'With Me
	 '    .Location = New System.Drawing.Point(0, -30)
	 '    .Size = New System.Drawing.Point(1390, 56)
	 'End With

   End Sub

   Private Sub TrackBar1_KeyUp(sender As Object, e As KeyEventArgs) Handles TrackBar1.KeyUp
	 BANDERA = True
	 If BANDERA = True Then

	    If TrackBar1.Value > TRACKANTERIOR Then
		  For i = TRACKANTERIOR To TrackBar1.Value
			SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
		  Next

	    ElseIf TrackBar1.Value < TRACKANTERIOR Then
		  For i = TrackBar1.Value To TRACKANTERIOR
			SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
		  Next
	    End If
	    TRACKANTERIOR = TrackBar1.Value
	    Label2.Text = TrackBar1.Value * 2 & "  %"

	 End If
	 BANDERA = False


   End Sub

   Private Sub FrmVolumeWindows_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

	 If e.KeyChar = Chr(43) Then '+
	    btnIncVol_Click(Me, e)
	 Else
	    If e.KeyChar = Chr(45) Then '-
		  btnDecVol_Click(Me, e)
	    Else
		  If e.KeyChar = Chr(42) Then '*
			btnMute_Click(Me, e)
		  End If
	    End If
	 End If
   End Sub

   Private Sub TrackBar1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TrackBar1.KeyPress
	 TrackBar1.Maximum = 100
	 TrackBar1.Minimum = 1

	 If e.KeyChar = Chr(43) Then '+

	    If TrackBar1.Value >= 100 Then
		  TrackBar1.Value = 100
	    Else

		  TrackBar1.Value += 1
		  btnIncVol_Click(Me, e)
	    End If

	 Else
	    If e.KeyChar = Chr(45) Then '-
		  If TrackBar1.Value <= 1 Then
			TrackBar1.Value = 1
		  Else
			TrackBar1.Value -= 1
			btnDecVol_Click(Me, e)
		  End If
	    Else
		  If e.KeyChar = Chr(42) Then '*
			TrackBar1.Value = 1
			btnMute_Click(Me, e)
		  End If
	    End If
	 End If
   End Sub

   Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

   End Sub

   Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

   End Sub
End Class