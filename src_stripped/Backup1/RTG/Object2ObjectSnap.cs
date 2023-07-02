// Decompiled with JetBrains decompiler
// Type: RTG.Object2ObjectSnap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class Object2ObjectSnap
  {
    private static List<GameObject> _nearbyObjectBuffer;
    private static Object2ObjectSnap.Config _defaultConfig;

    public static int MaxSourceObjects
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Object2ObjectSnap() => throw null;

    public static Object2ObjectSnap.Config DefaultConfig
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Object2ObjectSnap.SnapResult Snap(
      List<GameObject> roots,
      Object2ObjectSnap.Config snapConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Object2ObjectSnap.SnapResult Snap(
      GameObject root,
      Object2ObjectSnap.Config snapConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Object2ObjectSnap.SnapResult CalculateSnapResult(
      GameObject root,
      Object2ObjectSnap.Config snapConfig)
    {
      throw null;
    }

    [Flags]
    public enum Prefs
    {
      None = 0,
      TryMatchArea = 1,
      All = TryMatchArea, // 0x00000001
    }

    public enum SnapFailReson
    {
      None,
      MaxObjectsExceeded,
      InvalidSourceObjects,
      NoDestinationFound,
    }

    public struct SnapResult
    {
      private bool _success;
      private Vector3 _snapPivot;
      private Vector3 _snapDestination;
      private float _snapDistance;
      private Object2ObjectSnap.SnapFailReson _failReason;

      public bool Success
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Vector3 SnapPivot
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Vector3 SnapDestination
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public float SnapDistance
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public Object2ObjectSnap.SnapFailReson FailReason
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SnapResult(Object2ObjectSnap.SnapFailReson failReson) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SnapResult(Vector3 snapPivot, Vector3 snapDestination, float snapDistance) => throw null;
    }

    public struct Config
    {
      private float _areaMatchEps;
      public List<GameObject> IgnoreDestObjects;
      public int DestinationLayers;
      public float SnapRadius;
      public Object2ObjectSnap.Prefs Prefs;

      public float AreaMatchEps
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }
    }

    private struct SnapSortData
    {
      public GameObject SrcObject;
      public GameObject DestObject;
      public BoxFace SrcSnapFace;
      public BoxFace DestSnapFace;
      public bool FaceAreasMatch;
      public float FaceAreaDiff;
      public Vector3 SnapPivot;
      public Vector3 SnapDest;
      public float SnapDistance;
    }
  }
}
