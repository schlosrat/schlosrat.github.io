// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtFloatingOrigin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [RequireComponent(typeof (SgtFloatingPoint))]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtFloatingOrigin")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Floating Origin")]
  public class SgtFloatingOrigin : SgtLinkedBehaviour<SgtFloatingOrigin>
  {
    public static bool currentPointSet;
    public static SgtFloatingPoint currentPoint;
    [NonSerialized]
    private SgtFloatingPoint cachedPoint;

    public static SgtFloatingPoint CurrentPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Create() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtFloatingOrigin() => throw null;
  }
}
