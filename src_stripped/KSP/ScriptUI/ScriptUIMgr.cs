// Decompiled with JetBrains decompiler
// Type: KSP.ScriptUI.ScriptUIMgr
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.ScriptInterop;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.ScriptUI
{
  public class ScriptUIMgr : KerbalMonoBehaviour
  {
    private static string DefaultActivationScript;
    private List<ScriptUIWindow> currentWindows;
    private DebugPanelManager dpMgr;
    public static int nextWindowID;
    private ScriptUIStyles guiStyles;
    private IScriptEnvironment ScriptInjector;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleDebugWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int ExecuteScript(string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateWindow(int x, int y, int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int DestroyWindow(int windowID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ScriptUIWindow GetScriptWindow(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveWindow(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetWindowTitle(int id, string title) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CloseAndRun(int id, string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateButton(int id, string script, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateCheckbox(int id, string variableName, string script, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateTextField(int id, string variableName, string initialText, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateNumericField(int id, string variableName, string initialText, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateLabel(int id, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateDropList(int id, string variableName, string dropListContents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetDropListUpdateScript(int wndID, int ctrlID, string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateSeparator(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CreateHorizontalSlider(int id, string variableName, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetCheckboxState(int wndId, int ctrlID, bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetSliderRange(int wndId, int ctrlID, float minValue, float maxValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetSliderCurrentValue(int wndId, int ctrlID, float currentValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetSliderUpdateScript(int wndID, int ctrlID, string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetSliderLabel(int wndID, int ctrlID, string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawScriptWindow(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadScriptCode(string fileName, Action<string> callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InjectLuaFile(string fileName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InjectControlScript(ScriptUIWindow wnd, string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ExectuteLua(string luaScript) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptUIMgr() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ScriptUIMgr() => throw null;
  }
}
