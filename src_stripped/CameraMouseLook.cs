// Decompiled with JetBrains decompiler
// Type: CameraMouseLook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;

public class CameraMouseLook : IDisposable
{
  private GameInstance _game;
  private static bool _mouseLocked;
  private static bool _mouselookToggled;

  public static bool MouseLocked
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static bool MouselookToggled
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool GetMouseLook(bool arbitraryLock = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetMouseLook(bool mLock) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Dispose() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void onGamePause() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnSceneLoaded(Scene scene, LoadSceneMode mode) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnLevelLoaded(int lvl) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnToggleMouselook() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void MouselookRelease() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CameraMouseLook() => throw null;
}
