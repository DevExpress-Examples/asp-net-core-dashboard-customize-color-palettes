Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.AspNetCore.Mvc.RazorPages

Namespace WebDashboardCustomColorPalettes.Pages

    Public Class IndexModel
        Inherits PageModel

        Private ReadOnly _logger As ILogger(Of IndexModel)

        Public Sub New(ByVal logger As ILogger(Of IndexModel))
            _logger = logger
        End Sub

        Public Sub OnGet()
        End Sub
    End Class
End Namespace
