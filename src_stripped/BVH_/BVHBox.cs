// Decompiled with JetBrains decompiler
// Type: BVH_.BVHBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace BVH_
{
  public class BVHBox
  {
    public Vector3 mMin;
    public Vector3 mMax;
    public Vector3 mExtentSize;
    public Vector3 mCenter;
    public int mBoxID;
    public BVHBox.OnChanged OnPositionOrSizeChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void NotifyPositionOrSizeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IsBoxMoved(Vector3 newpos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHBox() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHBox(Vector3 Min, Vector3 Max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHBox(Vector3 Center, Vector3 Extent, int ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool FrustumIntersects(BVHBox box) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IntersectsSphere(Vector3 origin, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ExpandToFit(BVHBox b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHBox ExpandedBy(BVHBox b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IntersectsAABB(BVHBox box) => throw null;

    public delegate void OnChanged(BVHBox Box);
  }
}
