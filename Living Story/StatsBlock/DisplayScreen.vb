Imports BaseClasses

Public Class DisplayScreen

    Private _Asset As Asset

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub LoadAsset(_newAsset As Asset)
        _Asset = _newAsset

        StoryScreen.Text = Parser.Parse(_Asset)

        UpdateButtons()

    End Sub

    Public Sub UpdateButtons()

        ' Button 1
        Button1.Name = _Asset.Buttons(0).Name
        Button1.Text = _Asset.Buttons(0).Caption
        Button1.Tag = _Asset.Buttons(0).LeadsTo
        Button1.Visible = _Asset.Buttons(0).IsShown
        Button1.Enabled = ValidateRequisites.Validate(_Asset.Buttons(0).Requisites)

        ' Button 2
        Button2.Name = _Asset.Buttons(1).Name
        Button2.Text = _Asset.Buttons(1).Caption
        Button2.Tag = _Asset.Buttons(1).LeadsTo
        Button2.Visible = _Asset.Buttons(1).IsShown
        Button2.Enabled = ValidateRequisites.Validate(_Asset.Buttons(1).Requisites)

        ' Button 3
        Button3.Name = _Asset.Buttons(2).Name
        Button3.Text = _Asset.Buttons(2).Caption
        Button3.Tag = _Asset.Buttons(2).LeadsTo
        Button3.Visible = _Asset.Buttons(2).IsShown
        Button3.Enabled = ValidateRequisites.Validate(_Asset.Buttons(2).Requisites)

        ' Button 4
        Button4.Name = _Asset.Buttons(3).Name
        Button4.Text = _Asset.Buttons(3).Caption
        Button4.Tag = _Asset.Buttons(3).LeadsTo
        Button4.Visible = _Asset.Buttons(3).IsShown
        Button4.Enabled = ValidateRequisites.Validate(_Asset.Buttons(3).Requisites)

        ' Button 5
        Button5.Name = _Asset.Buttons(4).Name
        Button5.Text = _Asset.Buttons(4).Caption
        Button5.Tag = _Asset.Buttons(4).LeadsTo
        Button5.Visible = _Asset.Buttons(4).IsShown
        Button5.Enabled = ValidateRequisites.Validate(_Asset.Buttons(4).Requisites)

        ' Button 6
        Button6.Name = _Asset.Buttons(5).Name
        Button6.Text = _Asset.Buttons(5).Caption
        Button6.Tag = _Asset.Buttons(5).LeadsTo
        Button6.Visible = _Asset.Buttons(5).IsShown
        Button6.Enabled = ValidateRequisites.Validate(_Asset.Buttons(5).Requisites)

        ' Button 7
        Button7.Name = _Asset.Buttons(6).Name
        Button7.Text = _Asset.Buttons(6).Caption
        Button7.Tag = _Asset.Buttons(6).LeadsTo
        Button7.Visible = _Asset.Buttons(6).IsShown
        Button7.Enabled = ValidateRequisites.Validate(_Asset.Buttons(6).Requisites)

        ' Button 8
        Button8.Name = _Asset.Buttons(7).Name
        Button8.Text = _Asset.Buttons(7).Caption
        Button8.Tag = _Asset.Buttons(7).LeadsTo
        Button8.Visible = _Asset.Buttons(7).IsShown
        Button8.Enabled = ValidateRequisites.Validate(_Asset.Buttons(7).Requisites)

        ' Button 9
        Button9.Name = _Asset.Buttons(8).Name
        Button9.Text = _Asset.Buttons(8).Caption
        Button9.Tag = _Asset.Buttons(8).LeadsTo
        Button9.Visible = _Asset.Buttons(8).IsShown
        Button9.Enabled = ValidateRequisites.Validate(_Asset.Buttons(8).Requisites)

        ' Button 10
        Button10.Name = _Asset.Buttons(9).Name
        Button10.Text = _Asset.Buttons(9).Caption
        Button10.Tag = _Asset.Buttons(9).LeadsTo
        Button10.Visible = _Asset.Buttons(9).IsShown
        Button10.Enabled = ValidateRequisites.Validate(_Asset.Buttons(9).Requisites)

        ' Button 11
        Button11.Name = _Asset.Buttons(10).Name
        Button11.Text = _Asset.Buttons(10).Caption
        Button11.Tag = _Asset.Buttons(10).LeadsTo
        Button11.Visible = _Asset.Buttons(10).IsShown
        Button11.Enabled = ValidateRequisites.Validate(_Asset.Buttons(10).Requisites)

        ' Button 12
        Button12.Name = _Asset.Buttons(11).Name
        Button12.Text = _Asset.Buttons(11).Caption
        Button12.Tag = _Asset.Buttons(11).LeadsTo
        Button12.Visible = _Asset.Buttons(11).IsShown
        Button12.Enabled = ValidateRequisites.Validate(_Asset.Buttons(11).Requisites)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button1.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button2.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button3.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button4.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button5.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button6.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button7.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button8.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button9.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button10.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button11.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim _newAsset As Asset = AssetController.FindAssetByID(Button12.Tag)
        If _newAsset IsNot Nothing Then LoadAsset(_newAsset)

    End Sub

End Class
