Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace DXWebApplication1.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

            Return View()
        End Function

        Private db As New DXWebApplication1.Models.Nwind_SalesDataEntities()

        <ValidateInput(False)> _
        Public Function PivotGridPartial() As ActionResult
            Dim model = db.SalesPersons
            Return PartialView("_PivotGridPartial", model.ToList())
        End Function
    End Class
End Namespace