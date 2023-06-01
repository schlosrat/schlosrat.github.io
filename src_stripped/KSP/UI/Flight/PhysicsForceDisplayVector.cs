// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.PhysicsForceDisplayVector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  public class PhysicsForceDisplayVector
  {
    public const float ARROWHEAD_RADIUS = 0.25f;
    public const float ARROWHEAD_RADIUS_TO_HEIGHT_MUL = 3.236068f;
    public const float DRAW_FORCE_MAGNITUDE_THRESHOLD = 0.05f;

    public System.Type ForceType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IForce Force
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public DebugShapesDraw.Arrow ShapesArrow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform PartTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartComponent PartComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PhysicsForceDisplayVector() => throw null;
  }
}
