// Decompiled with JetBrains decompiler
// Type: KSP.OAB.FairingCrossSection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class FairingCrossSection : IComparable<FairingCrossSection>
  {
    public float Height;
    public float Radius;
    public bool IsLast;
    public bool IsCap;
    public bool IsValid;
    public Color Color;
    public float DefaultHeight;
    public float DefaultRadius;
    [NonSerialized]
    private FairingCrossSection _lerpLHS;
    [NonSerialized]
    private FairingCrossSection _lerpRHS;
    public List<FairingPanelAttachments> FairingPanelAttachedParts;
    private bool _isLerp;

    public bool IsLerp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingCrossSection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingCrossSection(bool isCap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingCrossSection(FairingCrossSection from, FairingCrossSection to) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FairingCrossSection(FairingCrossSection cloneOf) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNewFairingPanel(int panelIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLerp(float t, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetSlopeAngle(FairingCrossSection from, FairingCrossSection to) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(FairingCrossSection b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ConeCast(
      FairingCrossSection crossSecFrom,
      FairingCrossSection crossSecTo,
      Vector3 wAxis,
      Vector3 wPivot,
      Vector3 wRadial,
      float radiusOffset,
      int nRays,
      int layerMask,
      out float hitLengthScalar,
      out RaycastHit hit,
      float aOffset = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float CircleCast(
      FairingCrossSection crossSection,
      Vector3 wAxis,
      Vector3 wPivot,
      Vector3 wRadial,
      int nRays,
      float rLength,
      int layerMask,
      out float lVariance)
    {
      throw null;
    }
  }
}
