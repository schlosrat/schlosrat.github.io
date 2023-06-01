// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainerReadOnlyDatabaseExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Logging;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public static class IResourceContainerReadOnlyDatabaseExtensions
  {
    private const LogFilter LOG_FILTER = LogFilter.Simulation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string LOG_PREFIX([CallerMemberName] string memberName = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ComputeResourcesTotalMass(
      this IResourceContainerReadOnly container,
      ResourceDefinitionDatabase definitionDatabase)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ComputeResourceStoredMass(
      this IResourceContainerReadOnly container,
      ResourceDefinitionID resourceID,
      ResourceDefinitionDatabase definitionDatabase)
    {
      throw null;
    }
  }
}
