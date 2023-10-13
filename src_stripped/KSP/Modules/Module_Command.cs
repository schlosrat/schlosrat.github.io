// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Command
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  public class Module_Command : PartBehaviourModule
  {
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_Command dataCommand;
    private int _crewCount;
    private int _totalCrewCount;
    private Data_Command.ControlPoint _activeControlPoint;
    private List<SpatialBehavior> _spatialBehaviors;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int TotalCrewCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool RemoteControl
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHibernating
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveControlNameChanged(string activeControlName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeControlPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetControlPoint(string newControlPointName, bool setDefaultIfMissingId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateControlPointEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MakeReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCommandControlOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCommandControlOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCommandControl(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetHibernationOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetHibernationOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetHibernation(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Command() => throw null;
  }
}
