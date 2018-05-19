Imports Microsoft.VisualBasic
Imports DevExpress.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports T283418.Models

Namespace T283418
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function GridViewPartial() As ActionResult
			Dim model = Data.GetData()
			Return PartialView(model)
		End Function
		Public Function GridViewBatchUpdatePartial(ByVal values As MVCxGridViewBatchUpdateValues(Of Integer, Data)) As ActionResult
			Dim model = Data.GetData()
			Return PartialView("GridViewPartial", model)
		End Function
	End Class
End Namespace