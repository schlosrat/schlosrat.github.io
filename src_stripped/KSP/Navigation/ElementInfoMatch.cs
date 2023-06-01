// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.ElementInfoMatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace KSP.Navigation
{
  public struct ElementInfoMatch
  {
    public float Offset;
    public float DirectionalDistance;
    public float DistanceSqr;
    public SelectableElementInfo ResultInfo;
    public NavigationParameter Parameter;
    private ElementInfoMatch.DeltaElementInfo Delta;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ElementInfoMatch(SelectableElementInfo baseInfo, NavigationParameter parameter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Match(SelectableElementInfo target, MoveDirection dir) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchByDirectionalDistanceOnly(
      SelectableElementInfo target,
      MoveDirection dir,
      bool calcDelta = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchByOffsetOnly(SelectableElementInfo target, MoveDirection dir, bool calcDelta = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchByDistanceOnly(
      SelectableElementInfo target,
      MoveDirection dir,
      bool calcDelta = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchByMixedOffsetAndDistance(
      SelectableElementInfo target,
      MoveDirection dir,
      bool calcDelta = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MatchByOffsetWithMixedTolerance(
      SelectableElementInfo target,
      MoveDirection dir,
      bool calcDelta = true)
    {
      throw null;
    }

    private struct DeltaElementInfo
    {
      public SelectableElementInfo Base;
      public bool IsDirectionCorrect;
      public bool IsAngleInRange;
      public float Offset;
      public float DirectionalDistance;
      public float DistanceSqr;
      private float _tanAngularRange;
      private float _angularRange;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DeltaElementInfo(SelectableElementInfo baseInfo) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void CalculateDelta(
        SelectableElementInfo target,
        MoveDirection dir,
        NavigationParameter parameter)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Reset() => throw null;
    }
  }
}
