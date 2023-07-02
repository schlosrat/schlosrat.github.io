// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ISymmetrySetPositioner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
