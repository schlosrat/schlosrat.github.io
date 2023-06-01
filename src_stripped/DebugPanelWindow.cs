// Decompiled with JetBrains decompiler
// Type: DebugPanelWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.ScriptUI;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DebugPanelWindow : MonoBehaviour
{
  public Image ImageWindowBackground;
  public Image ImageWindowTitleBar;
  public Text TextWindowTitle;
  public Button ButtonRemoveWindow;
  [HideInInspector]
  public int windowID;
  [HideInInspector]
  public DebugPanelManager debugPanelMgr;
  public ScriptUIWindow scriptUIWindow;
  private RectTransform windowRectTransform;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RemoveDebugPanelWindow() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitWindow(
    string titleName,
    float windowWidth,
    float windowHeight,
    float titleBarHeight)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitWindowControls() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugPanelWindow() => throw null;
}
