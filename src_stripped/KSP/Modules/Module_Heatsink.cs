// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Heatsink
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Heatsink : Module_Cooler
  {
    [SerializeField]
    protected Data_Heatsink dataHeatsink;
    private Transform _contactTransform;
    private RaycastHit _impactHitInfo;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnBeforeSetStatusString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isProbeBuriedOrUnderwater() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Heatsink() => throw null;
  }
}
