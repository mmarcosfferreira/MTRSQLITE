Imports System.IO
Imports Newtonsoft.Json

Public Class ArquivoJson

    '''' <summary>
    '''' Método que executa uma rotina p Salvar arquivo JSon
    '''' </summary>
    '''' <param name="strJason">strJason vai receber uma string Json</param>
    '''' <param name="path">O nome de um arquivo com o caminho todo</param>
    'Public Sub Salvar(strJason As String, path As String)
    '    Try
    '        Using sw = New StreamWriter(path)

    '            sw.WriteLine(strJason)
    '            strJason = JsonConvert.SerializeObject(strJason, Formatting.Indented)
    '            'Threading.Thread.Sleep(10)

    '        End Using

    '    Catch ex As Exception
    '        MsgBox("Falha: " + ex.Message)
    '    End Try

    'End Sub


    '''' <summary>
    '''' Método que vai carregar o arquivo JSon para o Objeto Configuracao e retorna-lo
    '''' </summary>
    '''' <param name="path">O caminho do objeto Json as Carregado</param>
    '''' <returns>Fz a leitura de um objeto Json dado um caminho e retorna este Objeto</returns>
    'Public Function Carregar(path As String) As Configuracao

    '    Dim strJson As Object = ""
    '    Dim cnf = New Configuracao()

    '    Try
    '        Using sr = New StreamReader(path)

    '            strJson = sr.ReadToEnd
    '            cnf = JsonConvert.DeserializeObject(Of Configuracao)(strJson)
    '            ' Dim H As Configuracao() = JsonConvert.DeserializeObject(Of Configuracao())(strJson)
    '            Return cnf
    '        End Using
    '    Catch ex As Exception
    '        MsgBox("Falha: " & ex.Message)
    '    End Try
    '    Return cnf

    'End Function


    '' Objecto único
    'Dim obj As JObject = JObject.Parse(a_tua_função())
    'MessageBox.Show(obj("nome_campo").ToString())

    '' Vários objectos
    'Dim obj As JArray = JArray.Parse(a_tua_função())

    'For Each item In obj
    '    MessageBox.Show(item("nome_campo").ToString())
    'Next
End Class

