// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPartStageInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyPartStageInfo : IObjectAssemblyPartStageInfo
  {
    public List<IObjectAssemblyPart> Parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyPartStageInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetChildMass(
      IObjectAssemblyPart part,
      ref List<int> decoupled,
      ref List<int> usedFuel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyPart[] GetConnectedFuelTanks(
      IObjectAssemblyPart part,
      ref List<int> usedTank)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<IObjectAssemblyPart> GetPartsFromCategory(PartCategories desiredCategory) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<IObjectAssemblyPart> GetPartsNotFromCategory(PartCategories desiredCategory) => throw null;
  }
}
