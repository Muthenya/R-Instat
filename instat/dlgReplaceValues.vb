﻿' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgReplaceValues
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsReplace As New RFunction
    Private clsReplaceNaLocf As New RFunction
    Private Sub dlgReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 47

        'ucrSelector
        ucrSelectorReplace.SetParameter(New RParameter("data_name", 0))
        ucrSelectorReplace.SetParameterIsString()

        'ucrReceiver
        ucrReceiverReplace.SetParameter(New RParameter("col_names", 1))
        ucrReceiverReplace.Selector = ucrSelectorReplace
        ucrReceiverReplace.SetMeAsReceiver()
        ucrReceiverReplace.SetSingleTypeStatus(True)
        ' ucrReceiverReplace.bForceAsDataFrame = True
        ucrReceiverReplace.SetParameterIsString()
        ucrReceiverReplace.SetExcludedDataTypes({"Date"})
        ' rdoNewFromAbove.Enabled = False

        '' Old:
        ucrPnlOld.AddRadioButton(rdoOldValue)
        ucrPnlOld.AddRadioButton(rdoOldMissing)
        ucrPnlOld.AddRadioButton(rdoOldInterval)

        ucrPnlOld.AddParameterPresentCondition(rdoOldValue, "old_value")
        ucrPnlOld.AddParameterValuesCondition(rdoOldMissing, "old_is_missing", "TRUE")
        ucrPnlOld.AddParameterPresentCondition(rdoOldInterval, "start_value")
        ucrPnlOld.AddParameterPresentCondition(rdoOldInterval, "end_value")

        ucrPnlOld.AddToLinkedControls(ucrInputOldValue, {rdoOldValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlOld.AddToLinkedControls(ucrInputRangeFrom, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrPnlOld.AddToLinkedControls(ucrInputRangeTo, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlOld.AddToLinkedControls(ucrChkMin, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOld.AddToLinkedControls(ucrChkMax, {rdoOldInterval}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputOldValue
        ucrInputOldValue.SetParameter(New RParameter("old_value", 2))
        ucrInputOldValue.bAddRemoveParameter = False

        'ucrInputRangeFrom
        ucrInputRangeFrom.SetParameter(New RParameter("start_value", 2))
        ucrInputRangeFrom.AddQuotesIfUnrecognised = False
        ucrInputRangeFrom.bAddRemoveParameter = False
        ucrInputRangeFrom.SetLinkedDisplayControl(lblRangeMin)

        ucrChkMin.SetParameter(New RParameter("closed_start_value"))
        ucrChkMin.SetText("Including")
        ucrChkMin.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMin.bAddRemoveParameter = False
        ucrChkMin.SetRDefault("FALSE")

        'ucrInputRangeTo
        ucrInputRangeTo.SetParameter(New RParameter("end_value", 3))
        ucrInputRangeTo.AddQuotesIfUnrecognised = False
        ucrInputRangeTo.bAddRemoveParameter = False
        ucrInputRangeTo.SetLinkedDisplayControl(lblRangeMax)

        ucrChkMax.SetParameter(New RParameter("closed_end_value"))
        ucrChkMax.SetText("Including")
        ucrChkMax.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMax.bAddRemoveParameter = False
        ucrChkMax.SetRDefault("FALSE")

        ''ucrInputNewValue
        ucrInputNewValue.SetParameter(New RParameter("new_value", 4))
        ucrInputNewValue.bAddRemoveParameter = False

        '' NEW VALUES:
        'ucrPnlNew.SetParameter(New RParameter("new_is_missing"))
        ucrPnlNew.AddRadioButton(rdoNewFromAbove)
        ucrPnlNew.AddRadioButton(rdoNewFromBelow)
        ucrPnlNew.AddRadioButton(rdoNewValue)
        ucrPnlNew.AddRadioButton(rdoNewMissing)

        ucrPnlNew.AddParameterPresentCondition(rdoNewValue, "new_value")
        ucrPnlNew.AddParameterPresentCondition(rdoNewMissing, "new_value", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, "new_value", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromBelow, "new_value", False)

        ucrPnlNew.AddParameterValuesCondition(rdoNewMissing, "new_is_missing", "TRUE")
        ucrPnlNew.AddParameterPresentCondition(rdoNewValue, "new_is_missing", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, "new_is_missing", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromBelow, "new_is_missing", False)
        '  ucrPnlNew.AddParameterValuesCondition(rdoNewMissing, "old_value",


        ucrPnlNew.AddParameterValuesCondition(rdoNewFromBelow, "from_last", "TRUE")
        ucrPnlNew.AddParameterPresentCondition(rdoNewMissing, "from_last", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewValue, "from_last", False)
        ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, "from_last", False)

        'ucrPnlNew.AddParameterValuesCondition(rdoNewFromAbove, "from_last", "TRUE")
        'ucrPnlNew.AddParameterValuesCondition(rdoNewMissing, "from_last", "TRUE", False)
        'ucrPnlNew.AddParameterValuesCondition(rdoNewValue, "from_last", "TRUE", False)
        'ucrPnlNew.AddParameterValuesCondition(rdoNewFromBelow, "from_last", "TRUE", False)

        'ucrPnlNew.AddParameterPresentCondition(rdoNewMissing, "old_value", False)
        'ucrPnlNew.AddParameterPresentCondition(rdoNewFromBelow, "old_value", False)
        'ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, "old_value", False)

        ' ucrPnlNew.AddParameterValuesCondition(rdoNewMissing, "old_is_missing", False)
        'ucrPnlNew.AddParameterPresentCondition(rdoNewFromAbove, "old_is_missing", False)
        'ucrPnlNew.AddParameterPresentCondition(rdoNewFromBelow, "old_is_missing", False)

        ucrPnlNew.AddToLinkedControls(ucrInputNewValue, {rdoNewValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

    End Sub

    Private Sub SetDefaults()
        clsReplace = New RFunction
        clsReplaceNaLocf = New RFunction
        'ucrPnlNew.AddToLinkedControls(ucrNewDataFrame, {rdoNewFromAbove, rdoNewFromBelow}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

        ucrSelectorReplace.Reset()
        EnableRange()
        clsReplace.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        clsReplace.AddParameter("old_value", "-99")
        clsReplace.AddParameter("new_value", "1")
        'clsReplace.AddParameter("new_is_missing", "TRUE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsReplace)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ' ucrPnlNew.AddAdditionalCodeParameterPair(clsReplace, New RParameter("new_is_missing"), iAdditionalPairNo:=1)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        'If (Not ucrReceiverReplace.IsEmpty()) Then
        '    If ((rdoOldValue.Checked AndAlso Not ucrInputOldValue.IsEmpty) OrElse (rdoOldInterval.Checked AndAlso Not ucrInputRangeFrom.IsEmpty() AndAlso Not ucrInputRangeTo.IsEmpty()) OrElse rdoOldMissing.Checked) AndAlso ((rdoNewValue.Checked AndAlso Not ucrInputNewValue.IsEmpty) OrElse rdoNewMissing.Checked) Then
        '        ucrBase.OKEnabled(True)
        '    Else
        '        ucrBase.OKEnabled(False)
        '    End If
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
        ucrBase.OKEnabled(True)
    End Sub

    Private Sub ucrBaseReplace_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub InputValue()
        Dim strVarType As String

        If Not ucrReceiverReplace.IsEmpty Then
            strVarType = ucrReceiverReplace.GetCurrentItemTypes(True)(0)
            If rdoOldValue.Checked Then
                clsReplace.AddParameter("locf", "FALSE")
                clsReplace.RemoveParameterByName("from_last")
                If (strVarType = "numeric" OrElse strVarType = "integer") Then
                    ucrInputOldValue.AddQuotesIfUnrecognised = False
                Else
                    ucrInputOldValue.AddQuotesIfUnrecognised = True
                End If
                clsReplace.RemoveParameterByName("old_is_missing")

            ElseIf rdoOldMissing.Checked Then
                clsReplace.AddParameter("old_is_missing", "TRUE")
            Else
                clsReplace.RemoveParameterByName("old_is_missing")
            End If
            If rdoNewValue.Checked Then
                clsReplace.AddParameter("locf", "FALSE")
                clsReplace.RemoveParameterByName("from_last")
                If (strVarType = "numeric" OrElse strVarType = "integer") Then
                    ucrInputNewValue.AddQuotesIfUnrecognised = False
                Else
                    ucrInputNewValue.AddQuotesIfUnrecognised = True
                End If
                clsReplace.RemoveParameterByName("new_is_missing")
            ElseIf rdoNewMissing.Checked Then
                clsReplace.AddParameter("new_is_missing", "TRUE")
            Else
                clsReplace.RemoveParameterByName("new_is_missing")
            End If
            If rdoNewFromAbove.Checked OrElse rdoNewFromBelow.Checked Then
                clsReplace.AddParameter("locf", "TRUE")
                clsReplace.RemoveParameterByName("new_is_missing")
                clsReplace.RemoveParameterByName("old_value")
                If rdoNewFromAbove.Checked Then
                    clsReplace.AddParameter("from_last", "TRUE")
                ElseIf rdoNewFromBelow.Checked Then
                    clsReplace.AddParameter("from_last", "FALSE")
                End If
            End If
        End If
    End Sub

    Private Sub EnableRange()
        Dim strVarType As String

        If Not ucrReceiverReplace.IsEmpty Then
            strVarType = ucrReceiverReplace.GetCurrentItemTypes(True)(0)
        Else
            strVarType = ""
        End If
        If strVarType = "" OrElse strVarType = "numeric" OrElse strVarType = "integer" Then
            rdoOldInterval.Enabled = True
        Else
            rdoOldInterval.Enabled = False
        End If

        If rdoOldInterval.Enabled = False Then
            If rdoOldInterval.Checked = True Then
                rdoOldValue.Checked = True
                rdoOldInterval.Checked = False
            End If
        End If
    End Sub

    Private Sub ucrReceiverReplace_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReplace.ControlContentsChanged, ucrPnlNew.ControlContentsChanged, ucrPnlOld.ControlContentsChanged, ucrInputNewValue.ControlContentsChanged, ucrInputOldValue.ControlContentsChanged, ucrInputRangeFrom.ControlContentsChanged, ucrInputRangeTo.ControlContentsChanged, ucrNewDataFrame.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOld_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOld.ControlValueChanged, ucrPnlNew.ControlValueChanged
        InputValue()
        EnableRange()
    End Sub

    Private Sub ucrReceiverReplace_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReplace.ControlValueChanged
        InputValue()
        EnableRange()
    End Sub

End Class