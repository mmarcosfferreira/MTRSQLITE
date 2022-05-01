'Imports System
'Imports System.Drawing
'Imports System.Collections
'Imports System.ComponentModel
'Imports System.Windows.Forms


'Public Class InputBox_Personalizado
'    Inherits System.Windows.Forms.Form


'    Private VarBt As New System.Windows.Forms.Button
'    Private VarLbl As New System.Windows.Forms.Label
'    Private VarTxt As New System.Windows.Forms.TextBox

'    Friend WithEvents BunifuCustomTextbox1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
'    Friend WithEvents BtnOK As Button
'    Friend WithEvents BtnCancelar As Button


'    Private Varcomponents As System.ComponentModel.Container = Nothing


'    Public Property EntradaTexto
'    Public Property LabelTexto
'    Public Property TextoForm





'    Public Property InputResponse


'    Public Sub New()
'        InitializeComponent()
'    End Sub

'    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'        If disposing Then

'            If Varcomponents IsNot Nothing Then
'                Varcomponents.Dispose()
'            End If
'        End If

'        MyBase.Dispose(disposing)
'    End Sub




'    Private Sub BtnOKClick(sender As Object, e As EventArgs)
'        InputResponse = VarTxt.Text
'        Me.Close()
'    End Sub

'    Private Sub BtnCancelClick(sender As Object, e As EventArgs)
'        Me.Close()
'    End Sub

'    Sub InitializeComponent()
'        Me.BunifuCustomTextbox1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
'        Me.BtnOK = New System.Windows.Forms.Button()
'        Me.BtnCancelar = New System.Windows.Forms.Button()
'        Me.SuspendLayout()
'        '
'        'BunifuCustomTextbox1
'        '
'        Me.BunifuCustomTextbox1.BackColor = System.Drawing.Color.LightSkyBlue
'        Me.BunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen
'        Me.BunifuCustomTextbox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.BunifuCustomTextbox1.ForeColor = System.Drawing.Color.DodgerBlue
'        Me.BunifuCustomTextbox1.Location = New System.Drawing.Point(12, 94)
'        Me.BunifuCustomTextbox1.Name = "BunifuCustomTextbox1"
'        Me.BunifuCustomTextbox1.Size = New System.Drawing.Size(338, 29)
'        Me.BunifuCustomTextbox1.TabIndex = 0
'        '
'        'BtnOK
'        '
'        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.BtnOK.ForeColor = System.Drawing.Color.DodgerBlue
'        Me.BtnOK.Location = New System.Drawing.Point(287, 24)
'        Me.BtnOK.Name = "BtnOK"
'        Me.BtnOK.Size = New System.Drawing.Size(63, 25)
'        Me.BtnOK.TabIndex = 1
'        Me.BtnOK.Text = "OK"
'        Me.BtnOK.UseVisualStyleBackColor = True
'        '
'        'BtnCancelar
'        '
'        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.BtnCancelar.ForeColor = System.Drawing.Color.DodgerBlue
'        Me.BtnCancelar.Location = New System.Drawing.Point(262, 55)
'        Me.BtnCancelar.Name = "BtnCancelar"
'        Me.BtnCancelar.Size = New System.Drawing.Size(88, 25)
'        Me.BtnCancelar.TabIndex = 1
'        Me.BtnCancelar.Text = "CANCELAR"
'        Me.BtnCancelar.UseVisualStyleBackColor = True
'        '
'        'InputBox_Personalizado
'        '
'        Me.BackColor = System.Drawing.Color.LightSkyBlue
'        Me.ClientSize = New System.Drawing.Size(361, 135)
'        Me.Controls.Add(Me.BtnCancelar)
'        Me.Controls.Add(Me.BtnOK)
'        Me.Controls.Add(Me.BunifuCustomTextbox1)
'        Me.MaximizeBox = False
'        Me.Name = "InputBox_Personalizado"
'        Me.ResumeLayout(False)
'        Me.PerformLayout()

'    End Sub


'    Private Sub InputBox_Personalizado_Load(sender As Object, e As System.EventArgs)
'        VarTxt.Text = EntradaTexto

'        VarLbl.Text = LabelTexto
'        Text = TextoForm

'        VarTxt.SelectionStart = 0
'        VarTxt.SelectionLength = Me.VarTxt.Text.Length
'        VarTxt.Focus()

'    End Sub

'End Class
