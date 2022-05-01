<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVolumeWindows
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVolumeWindows))
        Me.BtMute = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BtnVolumeGeral = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BTtopmost_ = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.BtMute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnVolumeGeral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtMute
        '
        Me.BtMute.BackColor = System.Drawing.Color.Transparent
        Me.BtMute.Image = Global.Principal.My.Resources.Resources.sound_mute
        Me.BtMute.ImageActive = Nothing
        Me.BtMute.Location = New System.Drawing.Point(17, 0)
        Me.BtMute.Name = "BtMute"
        Me.BtMute.Size = New System.Drawing.Size(16, 18)
        Me.BtMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtMute.TabIndex = 5
        Me.BtMute.TabStop = False
        Me.BtMute.Zoom = 10
        '
        'BtnVolumeGeral
        '
        Me.BtnVolumeGeral.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolumeGeral.Image = Global.Principal.My.Resources.Resources.configuration_config_system_1540
        Me.BtnVolumeGeral.ImageActive = Nothing
        Me.BtnVolumeGeral.Location = New System.Drawing.Point(19, 13)
        Me.BtnVolumeGeral.Name = "BtnVolumeGeral"
        Me.BtnVolumeGeral.Size = New System.Drawing.Size(14, 18)
        Me.BtnVolumeGeral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnVolumeGeral.TabIndex = 5
        Me.BtnVolumeGeral.TabStop = False
        Me.BtnVolumeGeral.Zoom = 10
        '
        'BTtopmost_
        '
        Me.BTtopmost_.BackColor = System.Drawing.Color.Transparent
        Me.BTtopmost_.ForeColor = System.Drawing.Color.Gray
        Me.BTtopmost_.Location = New System.Drawing.Point(-7, 194)
        Me.BTtopmost_.Name = "BTtopmost_"
        Me.BTtopmost_.Size = New System.Drawing.Size(43, 20)
        Me.BTtopmost_.TabIndex = 1
        Me.BTtopmost_.Text = "Forçar ficar na frente"
        Me.BTtopmost_.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTtopmost_.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(-20, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Volume"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(3, 0)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(14, 162)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 1
        '
        'FrmVolumeWindows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(34, 214)
        Me.Controls.Add(Me.BtnVolumeGeral)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtMute)
        Me.Controls.Add(Me.BTtopmost_)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVolumeWindows"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volume "
        CType(Me.BtMute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnVolumeGeral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtMute As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BtnVolumeGeral As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BTtopmost_ As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TrackBar1 As TrackBar
End Class
