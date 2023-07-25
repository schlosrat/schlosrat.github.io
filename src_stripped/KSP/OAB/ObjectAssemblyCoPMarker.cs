// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyCoPMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyCoPMarker : ObjectAssemblyMarker
  {
    public Vector3 referenceVelocity;
    public float referencePitch;
    public float referenceSpeed;
    public double refAlt;
    public double refStP;
    public double refDens;
    private Ray _CoP;
    private double refTemp;
    private GameInstance _currentGameInstance;
    private static ObjectAssemblyCOPressureQuery _lQry;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool TryUpdatePosition(ref Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Ray FindCoP(
      IObjectAssemblyPart rootPart,
      Vector3 refVel,
      double refAlt,
      double refStp,
      double refDens,
      out bool noLift)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RecurseParts(
      IObjectAssemblyPart part,
      Vector3 refVel,
      ref Vector3 CoP,
      ref Vector3 DoL,
      ref float t,
      double refAlt,
      double refStp,
      double refDens)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyCoPMarker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectAssemblyCoPMarker() => throw null;
  }
}
