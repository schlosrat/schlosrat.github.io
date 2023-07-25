// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedOABConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedOABConfig
  {
    public OABVariant Variant;
    public OABEnvironmentType EnvironmentType;
    public OABConstructionType ConstructionType;
    public string CelestialBodyDependencyName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Matches(SerializedOABConfig other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedOABConfig() => throw null;
  }
}
