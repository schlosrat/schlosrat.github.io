// Decompiled with JetBrains decompiler
// Type: KSP.ScriptUI.ScriptUIHorizontalSliderControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptUI
{
  public class ScriptUIHorizontalSliderControl : ScriptUIControl, ICreateControl
  {
    private string variableName;
    private string label;
    private string updateScript;
    private float minValue;
    private float maxValue;
    private float currentValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int Create(ScriptUIWindow wnd, string variableName, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRange(float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentValue(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUpdateScript(string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLabel(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToLuaVariable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Draw(ScriptUIMgr context, ScriptUIStyles guiStyles) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int SetSliderRange(ScriptUIWindow wnd, int controlID, float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int SetSliderCurrentValue(ScriptUIWindow wnd, int controlID, float currentValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int SetSliderUpdateScript(ScriptUIWindow wnd, int controlID, string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int SetSliderLabel(ScriptUIWindow wnd, int controlID, string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CreateControl(ScriptUIMgr context, DebugPanelManager debugPanelMgr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSlider(ControlHorizontalSlider horizontalSlider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptUIHorizontalSliderControl() => throw null;
  }
}
