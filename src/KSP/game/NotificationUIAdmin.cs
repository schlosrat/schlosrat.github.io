// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationUIAdmin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class NotificationUIAdmin : NotificationUI
  {
    private const string TITLE_TEXT_PROPERTY_KEY = "adminTitle";
    private const string BODY_CONTENT_PROPERTY_KEY = "adminBodyContent";
    private const string PRIMARY_ICON_PROPERTY_KEY = "adminIcon";
    private const string INITIAL_VALUE_UNKNOWN = "UNASSIGNED";
    [SerializeField]
    private GameObject _alertTitle;
    private Property<string> _title;
    private Property<string> _bodyContent;
    private Property<Sprite> _icon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetupAndLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupAndLocalizeBodyContent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DismissNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NotificationUIAdmin() => throw null;
  }
}
