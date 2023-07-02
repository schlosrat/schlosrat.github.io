// Decompiled with JetBrains decompiler
// Type: KSP.Game.ActionGroupElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class ActionGroupElement : ApiDataContext
  {
    [DataProperty("DisplayName")]
    public PropertyReadonly<string> DisplayName;
    [DataProperty("ActionGroup")]
    public PropertyReadonly<KSPActionGroup> ActionGroup;
    [DataProperty("ActionGroupName")]
    public PropertyReadonly<string> ActionGroupName;
    [DataProperty("PartsCount")]
    public PropertyExternal<int> PartsCount;
    private int _partsCount;
    [DataProperty("IsTriggerActive")]
    public PropertyExternal<bool> IsTriggerActive;
    [DataProperty("IsTriggerVisible")]
    public PropertyReadonly<bool> IsTriggerVisible;
    internal Action<KSPActionGroup> _showActionDetails;

    [DataAction("TriggerAction")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerAction() => throw null;

    [DataAction("ShowActionGroupDetails")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowGroup(string groupName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroupElement(KSPActionGroup action, bool isTriggerVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UpdateElement(KSPActionGroup action) => throw null;
  }
}
