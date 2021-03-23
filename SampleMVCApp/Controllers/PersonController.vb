Imports System.Web.Mvc

Namespace Controllers
    Public Class PersonController
        Inherits Controller

        ' GET: Person
        Function AddPerson() As ActionResult

            ViewBag.Name = "Ibula"
            ViewBag.Address = "Kozhikode"
            ViewBag.Phone = "123456789"
            ViewBag.Stream = "MCA"
            ViewBag.Mark = "100"
            Return View()
        End Function

        Function ListPerson() As ActionResult
            ViewData.Add("Id", "1")

            Return View()
        End Function
    End Class
End Namespace