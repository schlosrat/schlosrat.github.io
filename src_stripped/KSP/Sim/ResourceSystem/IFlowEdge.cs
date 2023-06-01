// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IFlowEdge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Sim.ResourceSystem
{
  public interface IFlowEdge
  {
    bool IsStructureBoundary { get; }

    bool CanBeFlowSearched { get; }

    bool IsCrossfeedEnabled { get; }

    bool IsCompoundConnection { get; }
  }
}
