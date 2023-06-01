// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainerExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public static class IResourceContainerExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnionAll(
      this IResourceContainer target,
      IResourceContainerReadOnly source,
      bool restrictToSharedResources = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnionCapacities(
      this IResourceContainer target,
      IResourceContainerReadOnly source,
      bool restrictToSharedResources = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TransferFrom(this IResourceContainer target, IResourceContainer source) => throw null;
  }
}
