// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Color
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  public class Module_Color : PartBehaviourModule
  {
    [SerializeField]
    protected Data_Color _dataColor;
    [NonSerialized]
    private MaterialPropertyBlock _propertyBlock;
    [NonSerialized]
    private bool _doColorRedraw;
    [NonSerialized]
    private ProcedurallyEditablePart _procedurallyEditablePart;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void InitForNewOABPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SomeColorUpdated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColors(Color baseColor, Color accentColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public (Color, Color) GetColors() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshColors() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABUpdate(float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Color() => throw null;
  }
}
