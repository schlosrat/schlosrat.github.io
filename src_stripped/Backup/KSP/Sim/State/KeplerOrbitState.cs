// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.KeplerOrbitState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Converters;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct KeplerOrbitState
  {
    [TypeConverterIgnore]
    public string referenceBodyGuid;
    public double inclination;
    public double eccentricity;
    public double semiMajorAxis;
    public double longitudeOfAscendingNode;
    public double argumentOfPeriapsis;
    public double meanAnomalyAtEpoch;
    public double epoch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FromOrbitComponent(IOrbit orbit, out KeplerOrbitState definition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KeplerOrbitState FromSerialized(SerializedKeplerOrbit serializedOrbit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KeplerOrbitState FromSerializedOrbitProperties(
      SerializedOrbitProperties serializedOrbitProperties)
    {
      throw null;
    }
  }
}
