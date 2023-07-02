// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Util.TransformModelUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Util
{
  public static class TransformModelUtil
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ITransformModel FindLowestCommonAncestor(
      ITransformModel node1,
      ITransformModel node2)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TransformModel GetSubTreeClone(ITransformModel node1, ITransformModel node2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static HashSet<List<string>> GetGuidsFromBranches(HashSet<List<ITransformModel>> branches) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static HashSet<List<ITransformModel>> GetBranches(ITransformModel ancestor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<ITransformModel> GetLeafTransforms(ITransformModel ancestor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<ITransformModel> GetParentTransformLineage(
      ITransformModel descendantTransform,
      ITransformModel ancestorTransform)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool AddChildFromGuid(
      TransformModel root,
      string locationGuid,
      TransformModel newTransform)
    {
      throw null;
    }
  }
}
