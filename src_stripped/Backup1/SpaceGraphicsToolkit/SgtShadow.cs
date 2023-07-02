// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShadow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  public abstract class SgtShadow : SgtLinkedBehaviour<SgtShadow>
  {
    private static List<SgtShadow.ShadowProperties> cachedShadowProperties;
    private static List<string> cachedShadowKeywords;
    private static List<SgtShadow> tempShadows;
    [NonSerialized]
    private bool calculatedThisFrame;
    [NonSerialized]
    protected bool cachedActive;
    [NonSerialized]
    protected Texture cachedTexture;
    [NonSerialized]
    protected Matrix4x4 cachedMatrix;
    [NonSerialized]
    protected float cachedRatio;
    [NonSerialized]
    protected float cachedRadius;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract Texture GetTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void CalculateShadow(SgtLight light) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SgtShadow.ShadowProperties GetShadowProperties(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetShadowKeyword(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SgtShadow> Find(bool lit, int mask, List<SgtLight> lights) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FilterOutSphere(Vector3 center) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FilterOutRing(Vector3 center) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FilterOutMiss(Vector3 center, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Write(bool lit, int maxShadows) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SgtShadow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SgtShadow() => throw null;

    private class ShadowProperties
    {
      public int Texture;
      public int Matrix;
      public int Ratio;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ShadowProperties() => throw null;
    }
  }
}
