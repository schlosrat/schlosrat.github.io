// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceUnitMass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
