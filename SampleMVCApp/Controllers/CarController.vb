Imports System.Web.Mvc

Namespace Controllers
    Public Class CarController
        Inherits Controller

        ' GET: Car
        Function AddCar() As ActionResult
            Return View()
        End Function

        Function ListCar() As ActionResult
            Return View()
            For index = 1 To 10

            Next
        End Function
    End Class
End Namespace