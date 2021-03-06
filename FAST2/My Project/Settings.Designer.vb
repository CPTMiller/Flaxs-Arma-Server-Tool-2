﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
    
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
    
    Public Shared ReadOnly Property [Default]() As MySettings
        Get
            
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property isDark() As Boolean
        Get
            Return CType(Me("isDark"),Boolean)
        End Get
        Set
            Me("isDark") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property setupRun() As Boolean
        Get
            Return CType(Me("setupRun"),Boolean)
        End Get
        Set
            Me("setupRun") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property serverPath() As String
        Get
            Return CType(Me("serverPath"),String)
        End Get
        Set
            Me("serverPath") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property steamCMDPath() As String
        Get
            Return CType(Me("steamCMDPath"),String)
        End Get
        Set
            Me("steamCMDPath") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property steamUserName() As String
        Get
            Return CType(Me("steamUserName"),String)
        End Get
        Set
            Me("steamUserName") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Configuration.DefaultSettingValueAttribute("")>
    Public Property steamPassword() As String
        Get
            Return CType(Me("steamPassword"), String)
        End Get
        Set
            Me("steamPassword") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Configuration.DefaultSettingValueAttribute("")>
    Public Property steamApiKey() As String
        Get
            Return CType(Me("steamApiKey"), String)
        End Get
        Set
            Me("steamApiKey") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
    Public Property firstRun() As Boolean
        Get
            Return CType(Me("firstRun"),Boolean)
        End Get
        Set
            Me("firstRun") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Property Servers() As Global.FAST2.Models.ServerCollection
        Get
            Return CType(Me("Servers"),Global.FAST2.Models.ServerCollection)
        End Get
        Set
            Me("Servers") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
    Public Property clearSettings() As Boolean
        Get
            Return CType(Me("clearSettings"),Boolean)
        End Get
        Set
            Me("clearSettings") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Configuration.DefaultSettingValueAttribute("True")>
    Public Property checkForModUpdates() As Boolean
        Get
            Return CType(Me("checkForModUpdates"), Boolean)
        End Get
        Set
            Me("checkForModUpdates") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),
        Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
        Global.System.Configuration.DefaultSettingValueAttribute("True")>
    Public Property checkForAppUpdates() As Boolean
        Get
            Return CType(Me("checkForAppUpdates"), Boolean)
        End Get
        Set
            Me("checkForAppUpdates") = Value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("LightBlue")>  _
    Public Property primaryColour() As String
        Get
            Return CType(Me("primaryColour"),String)
        End Get
        Set
            Me("primaryColour") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("LightBlue")>  _
    Public Property accentColour() As String
        Get
            Return CType(Me("accentColour"),String)
        End Get
        Set
            Me("accentColour") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Stable")>  _
    Public Property serverBranch() As String
        Get
            Return CType(Me("serverBranch"),String)
        End Get
        Set
            Me("serverBranch") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property steamMods() As System.Collections.Generic.List(Of FAST2.Models.steamMod)
        Get
            Return CType(Me("steamMods"),System.Collections.Generic.List(Of FAST2.Models.steamMod))
        End Get
        Set
            Me("steamMods") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property localMods() As System.Collections.Generic.List(Of FAST2.Models.localMod)
        Get
            Return CType(Me("localMods"),System.Collections.Generic.List(Of FAST2.Models.localMod))
        End Get
        Set
            Me("localMods") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("")>  _
    Public Property localModFolders() As System.Collections.Generic.List(Of String)
        Get
            Return CType(Me("localModFolders"),System.Collections.Generic.List(Of String))
        End Get
        Set
            Me("localModFolders") = value
        End Set
    End Property
End Class

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.FAST2.MySettings
            Get
                Return Global.FAST2.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
