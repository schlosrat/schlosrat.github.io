// Decompiled with JetBrains decompiler
// Type: DragCube
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class DragCube
{
  public const int NUM_FACES = 6;
  [SerializeField]
  private float[] area;
  [SerializeField]
  private float[] drag;
  [SerializeField]
  private float[] depth;
  [FormerlySerializedAs("dragModifiers")]
  [SerializeField]
  private float[] dragMultiplier;
  [SerializeField]
  private Vector3 center;
  [SerializeField]
  private Vector3 size;
  [SerializeField]
  private string name;
  [SerializeField]
  private float weight;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DragCube() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DragCube(string name) => throw null;

  public float[] Area
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float[] Drag
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float[] Depth
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public float[] DragMultiplier
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 Center
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Vector3 Size
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public string Name
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public float Weight
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Load(string[] data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public string SaveToString() => throw null;

  public enum DragFace
  {
    XP,
    XN,
    YP,
    YN,
    ZP,
    ZN,
  }
}
