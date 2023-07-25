// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_Fairing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_Fairing : PartComponentModule
  {
    protected Data_Fairing _dataFairing;
    protected AttachNodeData _dynamicAttachNode;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static AttachNodeData CreateDynamicFlightAttachNode(
      PartComponent part,
      Data_Fairing data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SyncDynamicAttachNodeToData(
      AttachNodeData dynamicAttachNode,
      Data_Fairing data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_Fairing() => throw null;
  }
}
