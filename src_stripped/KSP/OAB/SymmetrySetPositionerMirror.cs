// Decompiled with JetBrains decompiler
// Type: KSP.OAB.SymmetrySetPositionerMirror
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class SymmetrySetPositionerMirror : ISymmetrySetPositioner
  {
    private ObjectAssemblyBehaviorValues _cachedBehavioralValues;

    public SymmetryType SymmetryType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public BuilderSymmetryMode BuilderSymmetryMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymmetrySetPositionerMirror() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PositionData> PositionFromAnchor(
      IObjectAssemblyPart temporaryParent,
      PositionData anchorData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PositionData> PositionFromAnchor(
      IObjectAssemblyPart temporaryParent,
      PositionData anchorData,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode)
    {
      throw null;
    }
  }
}
