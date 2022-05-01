Imports System.Management


Module ObjManager


   Public Sub ObjManager(ByVal l As RichTextBox)
	 Dim objEv As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT * FROM Win32_Environment")
	 For Each objMgmt As ManagementObject In objEv.Get
	    l.Text = (objMgmt("Name") & " = " & objMgmt("VariableValue"))
	 Next
   End Sub

   Public Sub TemperaturaPc(ByVal CTL As Control)

	 Try

	    Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature")



	    For Each queryObj As ManagementObject In searcher.Get()

		  Dim temp As Double = CDbl(queryObj("CurrentTemperature"))

		  temp = (temp - 2732) / 10.0
		  CTL.Text = temp & " Graus"
		  'MessageBox.Show(temp.ToString)
	    Next


	 Catch err As ManagementException

	    MessageBox.Show("Voce não é administrador!: " & err.Message)

	 End Try



   End Sub


   Public Sub FreeSpace(ByVal CT2 As Control)


	 Dim Test As String = ""
	 Test = "\\Sua_máquina\root\CIMV2"
	 Try


	    Dim searcher As New ManagementObjectSearcher(Test, "SELECT * FROM Win32_LogicalDisk")

	    For Each queryObj As ManagementObject In searcher.Get()

		  CT2.Text = queryObj("FreeSpace")

	    Next

	 Catch err As ManagementException

	    MessageBox.Show("Ocorreu o seguinte erro ao consultar os dados WMI: " & err.Message)

	 End Try

   End Sub

End Module
