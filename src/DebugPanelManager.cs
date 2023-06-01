// Decompiled with JetBrains decompiler
// Type: DebugPanelManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.ScriptUI;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugPanelManager : KerbalMonoBehaviour
{
  public GameObject DebugPanelWindowPrefab;
  [HideInInspector]
  public GameObject prefabControlButton;
  [HideInInspector]
  public GameObject prefabControlNumericField;
  [HideInInspector]
  public GameObject prefabControlLabel;
  [HideInInspector]
  public GameObject prefabControlDropList;
  [HideInInspector]
  public GameObject prefabControlCheckbox;
  [HideInInspector]
  public GameObject prefabControlHorizontalSlider;
  [HideInInspector]
  public ScriptUIMgr scriptUIMgr;
  private Dictionary<int, DebugPanelWindow> mWindows;
  private bool enableInput;

  public event DebugPanelManager.RemoveWindowDelegate RemoveWindowEvent
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RemoveDebugPanelWindow(int windowID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void CreateDebugPanelWindow(List<ScriptUIWindow> wins) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private DebugPanelWindow CreatePrefab(int windowID) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitWindow(ScriptUIWindow sWin, DebugPanelWindow dWin) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugPanelManager() => throw null;

  public delegate void RemoveWindowDelegate(int id);
}
