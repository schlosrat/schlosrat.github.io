// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartSymmetrySet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class PartSymmetrySet
  {
    public const int INVALID_SYMMETRY_SET_DATA_ID = -1;
    private const int FIRST_SYMMETRY_SET_DATA_ID = 100;
    private static int NextSymmetrySetDataId;
    public int Id;
    public SymmetrySetData Data;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GenerateSymmetrySetDataId() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartSymmetrySet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PartSymmetrySet() => throw null;
  }
}
