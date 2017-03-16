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

Public Class sdgWindrose
    Public bControlsInitialised As Boolean = False
    Public clsWindRoseFunc As New RFunction
    Private Sub sdgWindrose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctThemePairs As New Dictionary(Of String, String)

        ucrNudCalmWind.SetParameter(New RParameter("calm_wind", 6))
        ucrNudCalmWind.SetRDefault(0)

        ucrNudNoOfDirections.SetParameter(New RParameter("n_directions", 3))
        ucrNudNoOfDirections.SetRDefault(12)

        ucrNudNoOfSpeeds.SetParameter(New RParameter("n_speeds", 4))
        ucrNudNoOfSpeeds.SetRDefault(5)

        ucrInputSpeedCuts.SetParameter(New RParameter("speed_cuts", 5))
        ucrInputSpeedCuts.SetRDefault("NA")

        ucrInputTheme.SetParameter(New RParameter("ggtheme"))
        dctThemePairs.Add("grey", Chr(34) & "grey" & Chr(34))
        dctThemePairs.Add("gray", Chr(34) & "gray" & Chr(34))
        dctThemePairs.Add("bw", Chr(34) & "bw" & Chr(34))
        dctThemePairs.Add("linedraw", Chr(34) & "linedraw" & Chr(34))
        dctThemePairs.Add("light", Chr(34) & "light" & Chr(34))
        dctThemePairs.Add("minimal", Chr(34) & "minimal" & Chr(34))
        dctThemePairs.Add("classic", Chr(34) & "classic" & Chr(34))
        ucrInputTheme.SetItems(dctThemePairs)
        bControlsInitialised = True

    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsWindRoseFunc = clsNewRFunction
        SetRCode(Me, clsWindRoseFunc, bReset)
    End Sub

    Private Sub UseNoOfSpeeds()
        'Number of speeds used when Speed cuts is NA
        If ucrInputSpeedCuts.GetText <> "NA" Then
            ucrNudNoOfSpeeds.Enabled = False
            clsWindRoseFunc.RemoveParameterByName("n_speeds")
        Else
            ucrNudNoOfSpeeds.Enabled = True
        End If
    End Sub

    Private Sub ucrInputSpeedCuts_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputSpeedCuts.ControlContentsChanged
        UseNoOfSpeeds()
    End Sub
End Class