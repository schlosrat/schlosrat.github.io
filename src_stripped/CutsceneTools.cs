// Decompiled with JetBrains decompiler
// Type: CutsceneTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CutsceneTools
{
  public static bool CutsceneModeIsEnabled;
  public static Coroutine RunningCutscene;
  private IViewController viewController;
  private Camera[] OriginalCameras;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CutsceneTools(IViewController _viewController) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ToggleCutsceneMode(bool isOn) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayShot(Camera cam) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayShot(Camera cam, Animator anim) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartCutscene(CutsceneTools.CutsceneShotDefinition[] shotList) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator PlayCutscene(CutsceneTools.CutsceneDefinition cutScene) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleGameCam(bool isEnabled) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleCutsceneCamera(Camera cam, bool isEnabled) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static CutsceneTools() => throw null;

  [Serializable]
  public struct CutsceneShotDefinition
  {
    public Camera Camera;
    public Animator Anim;
    public float ShotLength;
  }

  [Serializable]
  public struct CutsceneDefinition
  {
    public CutsceneTools.CutsceneShotDefinition[] shotList;
  }
}
