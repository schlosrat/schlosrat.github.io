// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainerReadOnlyDatabaseExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
