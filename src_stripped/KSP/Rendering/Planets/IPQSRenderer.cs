// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.IPQSRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
