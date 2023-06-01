// Decompiled with JetBrains decompiler
// Type: KSP.ScriptUI.ScriptUICheckboxControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptUI
{
  public class ScriptUICheckboxControl : ScriptUIControl, ICreateControl
  {
    private string variableName;
    private string script;
    private string label;
    public bool state;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Create(ScriptUIWindow wnd, string variableName, string script, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToLuaVariable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Draw(ScriptUIMgr context, ScriptUIStyles guiStyles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int SetCheckboxState(ScriptUIWindow wnd, int controlID, bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateControl(ScriptUIMgr context, DebugPanelManager debugPanelMgr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptUICheckboxControl() => throw null;
  }
}
