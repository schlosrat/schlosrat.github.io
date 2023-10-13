// Decompiled with JetBrains decompiler
// Type: KSP.Game.CelestialBodyAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class CelestialBodyAssetLoader : KerbalMonoBehaviour
  {
    private CelestialBodyComponent _currentLoadedReferenceBody;
    private readonly HashSet<string> _loadingMapLocalSpace;
    private readonly HashSet<string> _loadingMapScaledSpace;
    public Action<string, bool> LocalSpaceLoadFinished;
    public Action<string> LocalSpaceUnloadFinished;
    public Action<string, bool> ScaledSpaceLoadFinished;
    public Action<string> ScaledSpaceUnloadFinished;

    public CelestialBodyComponent CurrentLoadedLocalSpaceBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCurrentLoadedLocalSpaceBody(
      CelestialBodyComponent celestialBodyComponent,
      bool force = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLocalPlayersCurrentLoadedLocalSpaceBody() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDistance(Position observerPos, CelestialBodyComponent celestialBodyComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasLocalSpace(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLocalSpaceLoaded(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScaledSpaceLoaded(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLoadingLocalSpace(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLoadingScaledSpace(string bodyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadNewLocalSpaceView(CelestialBodyComponent referenceBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginLoadLocalSpaceView(CelestialBodyComponent model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginLoadLocalSpaceView(
      CelestialBodyComponent model,
      Action<string, bool> finishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator CoroutineLoadLocalSpaceView(CelestialBodyComponent model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnloadLocalSpaceView(CelestialBodyComponent model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginLoadScaledSpaceView(CelestialBodyComponent model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator CoroutineLoadScaledSpaceView(CelestialBodyComponent model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnloadScaledSpaceView(CelestialBodyComponent model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PerformReferenceBodySync(CelestialBodyComponent referenceBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadUnloadVisibleScaledSpaceBodies(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineLoadLocalSpaceView(
      CelestialBodyComponent model,
      Action<string, bool> finishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineLoadScaledSpaceView(
      CelestialBodyComponent model,
      Action<string, bool> finishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Log(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyAssetLoader() => throw null;
  }
}
