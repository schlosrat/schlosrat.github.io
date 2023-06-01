// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.IPQSRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Unity.Collections;

namespace KSP.Rendering.Planets
{
  public interface IPQSRenderer
  {
    void OnPQSUpdated(
      NativeList<PQJob.PQ> PQs,
      NativeList<int> destroyedQuads,
      NativeList<int> addedQuads,
      NativeList<int> changedEdges,
      NativeList<int> changedSubdiv,
      NativeList<int> changedCollapsed,
      NativeQueue<int> quadCache,
      NativeHashSet<int> uniqueQuadCache);
  }
}
