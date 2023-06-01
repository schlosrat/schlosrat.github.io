// Decompiled with JetBrains decompiler
// Type: KSP.ScriptUI.ScriptUIDropListControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptUI
{
  public class ScriptUIDropListControl : ScriptUIControl, ICreateControl
  {
    private string variableName;
    private string[] contents;
    private string value;
    private string updateScript;
    private int selection;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Create(ScriptUIWindow wnd, string variableName, string contents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUpdateScript(string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToLuaVariable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Draw(ScriptUIMgr context, ScriptUIStyles guiStyles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int SetSliderUpdateScript(ScriptUIWindow wnd, int controlID, string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateControl(ScriptUIMgr context, DebugPanelManager debugPanelMgr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptUIDropListControl() => throw null;
  }
}
