// Decompiled with JetBrains decompiler
// Type: KSP.Game.MapProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Map;
using KSP.Messages;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class MapProvider
  {
    private MapCore _core;
    private GameInstance _game;

    public MapMode ModeMostRecent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapProvider(GameInstance game) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadMapSystems(Action onComplete) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeSystems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetMapCore(out MapCore mapCore) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableFlightMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableFlightTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransitionToMapTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransitionToMapTrackingStationFlight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapTrackingStationTransition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTrackingStationLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableTrackingStation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableMap() => throw null;
  }
}
