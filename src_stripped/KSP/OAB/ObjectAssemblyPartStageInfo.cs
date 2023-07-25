// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPartStageInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
