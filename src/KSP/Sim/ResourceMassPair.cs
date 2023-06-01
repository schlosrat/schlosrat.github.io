// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceMassPair
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
  public class ResourceMassPair
  {
    public ResourceDefinitionID resourceID;
    public double mass;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceMassPair() => throw null;
  }
}
