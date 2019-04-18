﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat

Public Class ucrFilter
    Public bFirstLoad As Boolean
    Public clsFilterView As ROperator
    Public clsFilterFunction As RFunction
    Private clsConditionsList As RFunction
    Public bFilterDefined As Boolean
    Public Event FilterChanged()
    Public strDefaultColumn = ""
    Public strDefaultDataFrame = ""

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        bFilterDefined = False
        clsFilterView = New ROperator
        clsFilterView.strOperation = "&"
        clsFilterFunction = New RFunction
        clsFilterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_filter")
        clsConditionsList = New RFunction
        clsConditionsList.SetRCommand("list")
        clsFilterFunction.AddParameter("filter", clsRFunctionParameter:=clsConditionsList)
    End Sub

    Private Sub ucrFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            SetDefaults()
            bFirstLoad = False
        End If
        ClearConditions()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForFitler.SetDataframe(strDefaultDataFrame, False)
        End If
        If strDefaultColumn <> "" Then
            ucrFilterByReceiver.Add(strDefaultColumn)
            SetDefaultColumn("")
        End If
    End Sub

    Private Sub InitialiseControl()
        ucrFilterPreview.txtInput.ReadOnly = True
        ucrFilterByReceiver.Selector = ucrSelectorForFitler
        ucrFilterOperation.SetItems({"==", "<", "<=", ">", ">=", "!=", "==NA", "!=NA"})
        ucrValueForFilter.SetItems({""})
        ucrValueForFilter.SetDropDownStyleAsEditable(True)
        ucrFilterOperation.SetDropDownStyleAsNonEditable()
        ucrFactorLevels.SetAsMultipleSelector()
        ucrFactorLevels.SetReceiver(ucrFilterByReceiver)
        ucrFactorLevels.SetIncludeLevels(False)
        ucrFactorLevels.bIncludeNA = True
        clsFilterView.bForceIncludeOperation = False
        lstFilters.Columns.Add("Variable")
        lstFilters.Columns.Add("Condition")
        ucrInputFilterName.SetItemsTypeAsFilters()
        ucrInputFilterName.SetDataFrameSelector(ucrSelectorForFitler.ucrAvailableDataFrames)
        ucrInputFilterName.SetPrefix("Filter")
        ucrInputFilterName.SetDefaultTypeAsFilter()
        ucrSelectorForFitler.btnDataOptions.Visible = False
    End Sub

    Private Sub SetDefaults()
        ucrFilterByReceiver.SetMeAsReceiver()
        VariableTypeProperties()
        ucrFilterOperation.SetName("==")
    End Sub

    Private Sub ucrFilterVariable_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFilterByReceiver.SelectionChanged
        VariableTypeProperties()
    End Sub

    Private Sub VariableTypeProperties()

        If ucrFilterByReceiver.IsEmpty() Then
            ucrValueForFilter.Visible = False
            lblSelectLevels.Visible = False
            ucrFactorLevels.Visible = False
            cmdToggleSelectAll.Visible = False
            ucrFilterOperation.Visible = False
            ucrFilterDateTimePicker.Visible = False

        ElseIf Not ucrFilterByReceiver.IsEmpty Then

            If ucrFilterByReceiver.strCurrDataType.Contains("factor") Then
                lblSelectLevels.Visible = True
                ucrFactorLevels.Visible = True
                cmdToggleSelectAll.Visible = True
                ucrFilterOperation.Visible = False
            ElseIf ucrFilterByReceiver.strCurrDataType.Contains("logical") Then
                lblSelectLevels.Visible = False
                ucrFactorLevels.Visible = False
                cmdToggleSelectAll.Visible = False
                ucrFilterOperation.Visible = True
                ucrFilterOperation.SetItems({"==", "!="})
            ElseIf ucrFilterByReceiver.strCurrDataType.Contains("Date") Then
                lblSelectLevels.Visible = False
                ucrFactorLevels.Visible = False
                cmdToggleSelectAll.Visible = False
                ucrFilterOperation.Visible = True
                ucrFilterOperation.SetItems({"==", "<", "<=", ">", ">=", "!=", "==NA", "!=NA"})
            Else
                lblSelectLevels.Visible = False
                ucrFactorLevels.Visible = False
                cmdToggleSelectAll.Visible = False
                ucrFilterOperation.Visible = True
                ucrFilterOperation.SetItems({"==", "<", "<=", ">", ">=", "!=", "==NA", "!=NA"})
            End If
            DataTypes()
        End If
        SetToggleButtonSettings()
        CheckAddEnabled()
    End Sub

    Private Sub DataTypes()
        If ucrFilterOperation.Visible Then
            Select Case ucrFilterOperation.GetText
                Case "==NA"
                    ucrValueForFilter.Visible = False
                    ucrFilterDateTimePicker.Visible = False
                Case "!=NA"
                    ucrValueForFilter.Visible = False
                    ucrFilterDateTimePicker.Visible = False
                Case Else
                    If ucrFilterByReceiver.strCurrDataType.Contains("Date") Then
                        ucrValueForFilter.Visible = False
                        ucrFilterDateTimePicker.Visible = True
                    ElseIf ucrFilterByReceiver.strCurrDataType.Contains("logical") Then
                        ucrValueForFilter.Visible = True
                        ucrValueForFilter.SetItems({"TRUE", "FALSE", "NA"})
                        ucrFilterDateTimePicker.Visible = False
                    ElseIf ucrFilterByReceiver.strCurrDataType.Contains("factor") Then
                        ucrValueForFilter.Visible = False
                        ucrFilterDateTimePicker.Visible = False
                        ucrFilterOperation.Visible = False
                    Else
                        ucrValueForFilter.Visible = True
                        ucrFilterDateTimePicker.Visible = False
                    End If
            End Select
        Else
            ucrValueForFilter.Visible = False
            ucrFilterDateTimePicker.Visible = False

        End If

    End Sub

    Private Sub CheckAddEnabled()
        If Not ucrFilterByReceiver.IsEmpty() Then
            If ucrFilterByReceiver.strCurrDataType.Contains("factor") AndAlso ucrFactorLevels.GetSelectedLevels() <> "" Then
                cmdAddCondition.Enabled = True
            ElseIf (Not ucrFilterOperation.IsEmpty) AndAlso (Not ucrValueForFilter.IsEmpty) Then
                cmdAddCondition.Enabled = True
            ElseIf (Not ucrFilterOperation.IsEmpty) AndAlso ucrFilterDateTimePicker.Visible = True Then
                cmdAddCondition.Enabled = True
            ElseIf ucrFilterOperation.GetText = "==NA" OrElse ucrFilterOperation.GetText = "!=NA" Then
                cmdAddCondition.Enabled = True
            Else
                cmdAddCondition.Enabled = False
            End If
        Else
            cmdAddCondition.Enabled = False
        End If
    End Sub

    Private Sub cmdAddFilter_Click(sender As Object, e As EventArgs) Handles cmdAddCondition.Click
        Dim clsCurrentConditionView As New ROperator
        Dim clsCurrentConditionList As New RFunction
        Dim lviCondition As ListViewItem
        Dim strCondition As String

        clsCurrentConditionList.SetRCommand("list")
        clsCurrentConditionView.AddParameter(iPosition:=0, strParameterValue:=ucrFilterByReceiver.GetVariableNames(False))
        clsCurrentConditionList.AddParameter("column", ucrFilterByReceiver.GetVariableNames())
        If ucrFilterByReceiver.strCurrDataType.Contains("factor") Then
            clsCurrentConditionView.SetOperation("%in%")
            clsCurrentConditionList.AddParameter("operation", Chr(34) & "%in%" & Chr(34))
            strCondition = ucrFactorLevels.GetSelectedLevels()
        Else
            clsCurrentConditionView.SetOperation(ucrFilterOperation.GetText())
            clsCurrentConditionList.AddParameter("operation", Chr(34) & ucrFilterOperation.GetText() & Chr(34))
            If ucrFilterByReceiver.strCurrDataType = "character" AndAlso ucrValueForFilter.GetText() <> "NA" Then
                strCondition = Chr(34) & ucrValueForFilter.GetText() & Chr(34)
            ElseIf ucrFilterOperation.GetText = "==NA" Then
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "==" & Chr(34))
                strCondition = Chr(34) & "NA" & Chr(34)
            ElseIf ucrFilterOperation.GetText = "!=NA" Then
                clsCurrentConditionList.AddParameter("operation", Chr(34) & "!=" & Chr(34))
                strCondition = Chr(34) & "NA" & Chr(34)
            ElseIf ucrFilterByReceiver.strCurrDataType = "Date" Then
                'TODO; this might need to be done in the control i.e ucrDateTimePicker
                strCondition = Chr(34) & ucrFilterDateTimePicker.dtpDateTime.Value.Year & "/" & ucrFilterDateTimePicker.dtpDateTime.Value.Month & "/" & ucrFilterDateTimePicker.dtpDateTime.Value.Day & Chr(34)
            Else
                strCondition = ucrValueForFilter.GetText()
            End If
        End If
        clsCurrentConditionView.AddParameter(strParameterValue:=strCondition.Replace(Chr(34), Chr(39)))
        clsCurrentConditionList.AddParameter("value", strCondition)
        clsConditionsList.AddParameter("C" & clsConditionsList.clsParameters.Count, clsRFunctionParameter:=(clsCurrentConditionList))
        lviCondition = New ListViewItem({ucrFilterByReceiver.GetVariableNames(), clsCurrentConditionView.strOperation & " " & strCondition})
        lstFilters.Items.Add(lviCondition)
        If clsFilterView.clsParameters.Count = 0 Then
            clsFilterView.AddParameter(iPosition:=0, clsROperatorParameter:=(clsCurrentConditionView))
        Else
            clsFilterView.AddParameter(strParameterName:="Condition" & clsFilterView.clsParameters.Count - 1, clsROperatorParameter:=(clsCurrentConditionView))
        End If
        lstFilters.Columns(0).Width = -2
        lstFilters.Columns(1).Width = -2
        ucrFilterPreview.SetName(clsFilterView.ToScript())
        ucrFilterByReceiver.Clear()
        RaiseEvent FilterChanged()
        CheckAddEnabled()
    End Sub

    Private Sub cmdToggleSelectAll_Click(sender As Object, e As EventArgs) Handles cmdToggleSelectAll.Click
        ucrFactorLevels.SetSelectionAllLevels(Not ucrFactorLevels.IsAllSelected())
    End Sub

    Private Sub SetToggleButtonSettings()
        If ucrFactorLevels.IsAllSelected() Then
            cmdToggleSelectAll.Text = "Deselect All Levels"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Flat
        Else
            cmdToggleSelectAll.Text = "Select All Levels"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Popup
        End If
    End Sub

    Private Sub ucrFilterOperation_NameChanged() Handles ucrFilterOperation.NameChanged
        CheckAddEnabled()
    End Sub

    Private Sub ucrValueForFilter_NameChanged()
        CheckAddEnabled()
    End Sub

    Private Sub ucrFactorLevels_SelectedLevelChanged() Handles ucrFactorLevels.SelectedLevelChanged
        SetToggleButtonSettings()
        CheckAddEnabled()
    End Sub

    Private Sub ucrSelectorForFitler_DataFrameChanged() Handles ucrSelectorForFitler.DataFrameChanged
        ClearConditions()
        clsFilterFunction.AddParameter("data_name", Chr(34) & ucrSelectorForFitler.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub cmdClearConditions_Click(sender As Object, e As EventArgs) Handles cmdClearConditions.Click
        ClearConditions()
    End Sub

    Private Sub ClearConditions()
        clsFilterView.ClearParameters()
        clsConditionsList.ClearParameters()
        lstFilters.Items.Clear()
        ucrFilterPreview.SetName("")
        RaiseEvent FilterChanged()
    End Sub

    Private Sub ucrFilter_FilterChanged() Handles Me.FilterChanged
        bFilterDefined = lstFilters.Items.Count > 0
    End Sub

    Private Sub ucrInputFilterName_NameChanged() Handles ucrInputFilterName.NameChanged
        If clsFilterFunction IsNot Nothing Then
            If Not ucrInputFilterName.IsEmpty() Then
                clsFilterFunction.AddParameter("filter_name", Chr(34) & ucrInputFilterName.GetText() & Chr(34))
            Else
                clsFilterFunction.RemoveParameterByName("filter_name")
            End If
        End If
    End Sub

    Private Sub ucrValueForFilter_ContentsChanged() Handles ucrValueForFilter.ControlContentsChanged
        CheckAddEnabled()
    End Sub

    Public Function GetFilteredVariables(Optional bWithQuotes As Boolean = True) As List(Of String)
        Dim lstVariables As New List(Of String)

        For Each itmTemp As ListViewItem In lstFilters.Items
            If bWithQuotes Then
                lstVariables.Add(itmTemp.Text)
            Else
                lstVariables.Add(itmTemp.Text.Replace(Chr(34), ""))
            End If
        Next
        Return lstVariables
    End Function

    Public Sub SetDefaultColumn(strColumn As String)
        strDefaultColumn = strColumn
    End Sub

    Public Sub SetDefaultDataFrame(strDataFrame As String)
        strDefaultDataFrame = strDataFrame
    End Sub

    Private Sub ucrFilterOperation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrFilterOperation.ControlContentsChanged
        DataTypes()
    End Sub
End Class
