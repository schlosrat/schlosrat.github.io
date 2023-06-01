// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtRingMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Ring Mesh")]
  [ExecuteInEditMode]
  [RequireComponent(typeof (SgtRing))]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtRingMesh")]
  public class SgtRingMesh : MonoBehaviour
  {
    [SerializeField]
    [FormerlySerializedAs("Segments")]
    private int segments;
    [FormerlySerializedAs("SegmentDetail")]
    [SerializeField]
    private int segmentDetail;
    [FormerlySerializedAs("RadiusMin")]
    [SerializeField]
    private float radiusMin;
    [SerializeField]
    [FormerlySerializedAs("RadiusMax")]
    private float radiusMax;
    [SerializeField]
    [FormerlySerializedAs("RadiusDetail")]
    private int radiusDetail;
    [FormerlySerializedAs("BoundsShift")]
    [SerializeField]
    private float boundsShift;
    [FormerlySerializedAs("Shadow")]
    [SerializeField]
    private SgtShadowRing shadow;
    [NonSerialized]
    private Mesh generatedMesh;
    [NonSerialized]
    private SgtRing cachedRing;
    [NonSerialized]
    private bool cachedRingSet;

    public int Segments
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSegments(int value) => throw null;

    public int SegmentDetail
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSegmentDetail(int value) => throw null;

    public float RadiusMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRadiusMin(float value) => throw null;

    public float RadiusMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRadiusMax(float value) => throw null;

    public int RadiusDetail
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRadiusDetail(int value) => throw null;

    public float BoundsShift
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoundsShift(float value) => throw null;

    public SgtShadowRing Shadow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Mesh GeneratedMesh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [ContextMenu("Update Mesh")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMesh() => throw null;

    [ContextMenu("Apply Mesh")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyMesh() => throw null;

    [ContextMenu("Remove Mesh")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtRingMesh() => throw null;
  }
}
