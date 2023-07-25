// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationUIPassive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class NotificationUIPassive : NotificationUI
  {
    private const string PRIMARY_TEXT_PROPERTY_KEY = "primaryText";
    private const string PRIMARY_ICON_PROPERTY_KEY = "primaryIcon";
    private const string INITIAL_VALUE_UNKNOWN = "UNASSIGNED";
    private Property<string> _primaryText;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetupAndLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DismissNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NotificationUIPassive() => throw null;
  }
}
