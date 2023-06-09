﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Rotation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [DebuggerDisplay("{_Value_ForDebuggerOnly}")]
  public struct Rotation
  {
    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public QuaternionD localRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation(ICoordinateSystem coordinateSystem, QuaternionD localRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reframe(ICoordinateSystem newCoordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation Reframed(Rotation rotation, ICoordinateSystem newReferenceFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation Lerp(Rotation from, Rotation to, double lerp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation Slerp(Rotation from, Rotation to, double lerp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation FromTo(Vector from, Vector to) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation FlipRotation(Rotation toFlip, Vector axis, double angleDeg = 180.0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Rotation LookRotation(Vector forward, Vector upwards) => throw null;
  }
}
