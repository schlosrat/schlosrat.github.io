// Decompiled with JetBrains decompiler
// Type: KSP.ScriptUI.ScriptUITextFieldControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptUI
{
  public class ScriptUITextFieldControl : ScriptUIControl, ICreateControl
  {
    private string variableName;
    private string text;
    private string label;
    private bool numeric;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Create(
      ScriptUIWindow wnd,
      string variableName,
      string initialText,
      string label,
      bool numeric)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToLuaVariable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Draw(ScriptUIMgr context, ScriptUIStyles guiStyles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateControl(ScriptUIMgr context, DebugPanelManager debugPanelMgr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptUITextFieldControl() => throw null;
  }
}
