﻿Imports System.Web
Imports System.Web.SessionState

Namespace FASTPORT
    Public Class [Global]
        Inherits BaseClasses.Global


        Protected Overrides Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)

            Dim wordslicense As New Aspose.Words.License()
            wordslicense.SetLicense("Aspose.Total.lic")

            Dim BarcodeLicence As New Aspose.BarCode.License()
            BarcodeLicence.SetLicense("Aspose.Total.lic")

            Dim BarcodeRecognitionLicence As New Aspose.BarCodeRecognition.License()
            BarcodeRecognitionLicence.SetLicense("Aspose.Total.lic")

            Dim pdflicense As New Aspose.Pdf.License()
            pdflicense.SetLicense("Aspose.Total.lic")

        End Sub

        'Protected Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        'End Sub

        'Protected Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        'End Sub

        'Protected Sub Application_EndRequest(ByVal sender As Object, ByVal e As EventArgs)
        'End Sub

        'Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        'End Sub

        'Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        'End Sub

        'Protected Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        'End Sub

        'Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        'End Sub

#Region " Component Designer Generated Code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Component Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call

        End Sub

        'Required by the Component Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Component Designer
        'It can be modified using the Component Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            components = New System.ComponentModel.Container()
        End Sub

#End Region

    End Class
End Namespace