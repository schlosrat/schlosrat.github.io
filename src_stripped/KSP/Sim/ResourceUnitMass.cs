// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceUnitMass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class ResourceUnitMass
  {
    public ResourceDefinitionID resourceID;
    public double units;
    public double mass;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceUnitMass() => throw null;
  }
}
