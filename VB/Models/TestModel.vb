Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace T283418.Models
	Public Class Data
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateSomeData As String
		Public Property SomeData() As String
			Get
				Return privateSomeData
			End Get
			Set(ByVal value As String)
				privateSomeData = value
			End Set
		End Property
		Private privateAnotherData As String
		Public Property AnotherData() As String
			Get
				Return privateAnotherData
			End Get
			Set(ByVal value As String)
				privateAnotherData = value
			End Set
		End Property
		Public Shared Function GetData() As List(Of Data)
            Return Enumerable.Range(0, 50).Select(Function(i) New Data() With {.ID = i, .SomeData = "Data " & i, .AnotherData = "AnotherData" & i}).ToList()
		End Function
	End Class
End Namespace