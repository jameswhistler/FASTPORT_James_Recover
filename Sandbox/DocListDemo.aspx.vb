Imports Telerik.Web.UI

Partial Class DocRLV
    Inherits System.Web.UI.Page


    Protected Sub DocPageRS_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim selectedValue As Decimal = DirectCast(sender, RadSlider).Value

        If selectedValue = 1D Then
            ImageHeight = Unit.Pixel(150)
            ImageWidth = Unit.Pixel(198)
            DocPageRLV.PageSize = 40
        ElseIf selectedValue = 2D Then
            ImageHeight = Unit.Pixel(250)
            ImageWidth = Unit.Pixel(324)
            DocPageRLV.PageSize = 40
        ElseIf selectedValue = 4D Then
            ImageHeight = Unit.Pixel(350)
            ImageWidth = Unit.Pixel(454)
            DocPageRLV.PageSize = 20
        ElseIf selectedValue = 5D Then
            ImageHeight = Unit.Pixel(450)
            ImageWidth = Unit.Pixel(583)
            DocPageRLV.PageSize = 15
        ElseIf selectedValue = 6D Then
            ImageHeight = Unit.Pixel(650)
            ImageWidth = Unit.Pixel(842)
            DocPageRLV.PageSize = 15
        ElseIf selectedValue = 7D Then
            ImageHeight = Unit.Pixel(750)
            ImageWidth = Unit.Pixel(972)
            DocPageRLV.PageSize = 10
        ElseIf selectedValue = 8D Then
            ImageHeight = Unit.Pixel(850)
            ImageWidth = Unit.Pixel(1101)
            DocPageRLV.PageSize = 10
        ElseIf selectedValue = 9D Then
            ImageHeight = Unit.Pixel(950)
            ImageWidth = Unit.Pixel(1231)
            DocPageRLV.PageSize = 6
        ElseIf selectedValue = 10D Then
            ImageHeight = Unit.Pixel(1050)
            ImageWidth = Unit.Pixel(1361)
            DocPageRLV.PageSize = 6
        ElseIf selectedValue = 11D Then
            ImageHeight = Unit.Pixel(1150)
            ImageWidth = Unit.Pixel(1490)
            DocPageRLV.PageSize = 6
        End If

        DocPageRLV.CurrentPageIndex = 0
        DocPageRLV.Rebind()

    End Sub

    Protected Property ImageWidth() As Unit
        Get
            Dim state As Object = If(ViewState("ImageWidth"), Unit.Pixel(450))
            Return DirectCast(state, Unit)
        End Get
        Private Set(ByVal value As Unit)
            ViewState("ImageWidth") = value
        End Set
    End Property

    Protected Property ImageHeight() As Unit
        Get
            Dim state As Object = If(ViewState("ImageHeight"), Unit.Pixel(583))
            Return DirectCast(state, Unit)
        End Get
        Private Set(ByVal value As Unit)
            ViewState("ImageHeight") = value
        End Set
    End Property


End Class
