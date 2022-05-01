Imports Newtonsoft.Json
Public Class SingleValueArrayConverter(Of T)
   Inherits JsonConverter

   Public Overrides Sub WriteJson(ByVal writer As JsonWriter,
						    ByVal value As Object,
						    ByVal serializer As JsonSerializer)

	 Throw New NotImplementedException()
   End Sub

   Public Overrides Function ReadJson(ByVal reader As JsonReader,
							   ByVal objectType As Type,
							   ByVal existingValue As Object,
							   ByVal serializer As JsonSerializer) As Object

	 Dim RetornarValor As Object = New Object()


	 If reader.TokenType = JsonToken.StartObject Then
	    Dim instance As T = CType(serializer.Deserialize(reader, GetType(T)), T)
	    RetornarValor = New List(Of T)() From {
	    instance
	}
	 ElseIf reader.TokenType = JsonToken.StartArray Then
	    RetornarValor = serializer.Deserialize(reader, objectType)
	 End If

	 Return RetornarValor
   End Function

   Public Overrides Function CanConvert(ByVal objectType As Type) As Boolean
	 Return True
   End Function
End Class

