// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ISymmetrySetPositioner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;

namespace KSP.OAB
{
  public interface ISymmetrySetPositioner
  {
    SymmetryType SymmetryType { get; }

    BuilderSymmetryMode BuilderSymmetryMode { get; }

    List<PositionData> PositionFromAnchor(IObjectAssemblyPart temporaryParent, PositionData anchor);

    List<PositionData> PositionFromAnchor(
      IObjectAssemblyPart temporaryParent,
      PositionData anchor,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode);
  }
}
