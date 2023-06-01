// Decompiled with JetBrains decompiler
// Type: PerformanceTestUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;

public static class PerformanceTestUtils
{
  public const string MAIN_MENU_SCENE = "kspFlow.unity";

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator CoroutineLoadInitialScene() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator CoroutineShutdownGame() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IEnumerator CoroutinePerformOnTimer(
    float intervalSeconds,
    float timeoutSeconds,
    Action actionToPerform)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CycleCameraMode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SpawnVesselInVAB(PerformanceTestUtils.TestVesselSize testVesselSize) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SpawnVesselOnLaunchpad(
    PerformanceTestUtils.TestVesselSize testVesselSize,
    Action onLaunchCallback)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SpawnVesselInOrbit(
    PerformanceTestUtils.TestVesselSize testVesselSize,
    Action onLaunchCallback)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static string GetTestVesselsDirectory() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static string GetTestVesselFilename(PerformanceTestUtils.TestVesselSize vesselSize) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void OnVABShowComplete() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static IEnumerator CoroutineWaitForAssemblyLoad() => throw null;

  public enum TestVesselSize
  {
    Large,
  }
}
