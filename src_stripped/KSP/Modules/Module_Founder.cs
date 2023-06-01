// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Founder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Founder : Module_Deployable
  {
    [SerializeField]
    protected Data_Founder _moduleData;
    private ModuleAction _actionFoundColony;
    private ModuleAction _actionEnterBAE;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsColony
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateActionStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFoundColony() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActionCreateColony() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnterBAE() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Founder() => throw null;
  }
}
