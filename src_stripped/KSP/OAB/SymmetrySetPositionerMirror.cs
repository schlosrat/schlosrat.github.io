// Decompiled with JetBrains decompiler
// Type: KSP.OAB.SymmetrySetPositionerMirror
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
