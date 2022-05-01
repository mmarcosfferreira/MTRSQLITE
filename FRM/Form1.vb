Imports System.Runtime.InteropServices

Public Class Form1
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8

    Dim TRACKANTERIOR As Integer
    Dim BANDERA As Boolean = False

    Private Sub TrackBar1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseDown
        BANDERA = True
    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TrackBar1.MouseUp
        If BANDERA = True Then
            If TrackBar1.Value > TRACKANTERIOR Then
                For I = TRACKANTERIOR To TrackBar1.Value
                    SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
                Next
            ElseIf TrackBar1.Value < TRACKANTERIOR Then
                For I = TrackBar1.Value To TRACKANTERIOR
                    SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
                Next
            End If
            TRACKANTERIOR = TrackBar1.Value
            Label1.Text = TrackBar1.Value * 2 & "  %"
            BANDERA = False
            ButtonMUTE.BackColor = Color.Black
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TrackBar1.Maximum = 50
        TrackBar1.Value = 25
        Label1.Text = TrackBar1.Value * 2 & "  %"
        TRACKANTERIOR = TrackBar1.Value
    End Sub

    Private Sub ButtonMUTE_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMUTE.Click
        If ButtonMUTE.BackColor = Color.Black Then
            ButtonMUTE.BackColor = Color.Red
        Else
            ButtonMUTE.BackColor = Color.Black
        End If
        SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

    End Sub
End Class
