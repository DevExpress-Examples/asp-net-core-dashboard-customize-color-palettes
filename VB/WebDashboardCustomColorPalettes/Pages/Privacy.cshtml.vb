Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.AspNetCore.Mvc.RazorPages

Namespace WebDashboardCustomColorPalettes.Pages

    Public Class PrivacyModel
        Inherits PageModel

        Private ReadOnly _logger As ILogger(Of PrivacyModel)

        Public Sub New(ByVal logger As ILogger(Of PrivacyModel))
            _logger = logger
        End Sub

        Public Sub OnGet()
        End Sub
    End Class
End Namespace
