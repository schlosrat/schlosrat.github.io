// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtRingMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Ring Mesh")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtRingMesh")]
  [RequireComponent(typeof (SgtRing))]
  [ExecuteInEditMode]
  public class SgtRingMesh : MonoBehaviour
  {
    [FormerlySerializedAs("Segments")]
    [SerializeField]
    private int segments;
    [FormerlySerializedAs("SegmentDetail")]
    [SerializeField]
    private int segmentDetail;
    [SerializeField]
    [FormerlySerializedAs("RadiusMin")]
    private float radiusMin;
    [SerializeField]
    [FormerlySerializedAs("RadiusMax")]
    private float radiusMax;
    [FormerlySerializedAs("RadiusDetail")]
    [SerializeField]
    private int radiusDetail;
    [FormerlySerializedAs("BoundsShift")]
    [SerializeField]
    private float boundsShift;
    [SerializeField]
    [FormerlySerializedAs("Shadow")]
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
