// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedOABConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
