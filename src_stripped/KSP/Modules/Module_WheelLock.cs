// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_WheelLock : Module_WheelSubmodule
  {
    [SerializeField]
    protected Data_WheelLock dataWheelLock;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnWheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelLock() => throw null;
  }
}
