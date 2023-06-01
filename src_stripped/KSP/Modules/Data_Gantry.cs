// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Gantry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Gantry : ModuleData
  {
    [KSPDefinition]
    public OABEnvironmentType environmentType;

    public override Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Gantry() => throw null;
  }
}
