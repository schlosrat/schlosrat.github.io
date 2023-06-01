// Decompiled with JetBrains decompiler
// Type: KSP.Tools.BenchmarkTestSplineConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Tools
{
  [CreateAssetMenu(menuName = "KSP/Benchmark/Benchmark Scene Spline Config")]
  [ExecuteInEditMode]
  public class BenchmarkTestSplineConfig : ScriptableObject
  {
    public List<BenchmarkTestSplineConfig.SplineNode> nodes;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetDisplayKey(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BenchmarkTestSplineConfig.SplineNode GetNode(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNode(BenchmarkTestSplineConfig.SplineNode node, int index = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateNode(int index, PQSFreeCamState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveNode(BenchmarkTestSplineConfig.SplineNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveNode(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BenchmarkTestSplineConfig.SplineNode ConvertToNode(PQSFreeCamState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BenchmarkTestSplineConfig() => throw null;

    [Serializable]
    public class SplineNode
    {
      public float latitude;
      public float longitude;
      public float altitude;
      public float heading;
      public float pitch;
      public float speedMultiplier;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SplineNode() => throw null;
    }
  }
}
