// Decompiled with JetBrains decompiler
// Type: ProceduralStarfield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ProceduralStarfield : MonoBehaviour
{
  public int seed;
  public Vector3 fieldSize;
  public int numStars;
  public bool useStaticStarSize;
  public float staticStarSize;
  public bool useExclusionZone;
  public Vector3 exclusionZone;
  public Vector3 exclusionZoneOffset;
  public ProceduralStarfield.StarClass[] starClasses;
  public Material starMaterial;
  private Vector3 exclusionZoneMin;
  private Vector3 exclusionZoneMax;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private ParticleSystem[] CreateStars(int numStars) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool ExclusionZoneTest(Vector3 position) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ProceduralStarfield() => throw null;

  [Serializable]
  public class StarClass
  {
    public float minSize;
    public float maxSize;
    public float minMagnitude;
    public float maxMagnitude;
    public Color color;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StarClass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StarClass(float minSize, float maxSize, float minMag, float maxMag, Color color) => throw null;
  }
}
