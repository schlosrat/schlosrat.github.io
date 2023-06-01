// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.FlagComponentDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public struct FlagComponentDefinition
  {
    public string Name;
    public string LocationName;
    public string LocationDescription;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static FlagComponentDefinition GetDefaultDefinition() => throw null;
  }
}
