// Decompiled with JetBrains decompiler
// Type: CameraMouseLook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
