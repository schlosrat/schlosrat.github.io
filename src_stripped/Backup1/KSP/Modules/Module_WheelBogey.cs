// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelBogey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  public class Module_WheelBogey : Module_WheelSubmodule, ILateUpdate
  {
    [SerializeField]
    protected Data_WheelBogey dataWheelBogey;
    [Header("Runtime Variables Below here - Do not change")]
    private Transform _wheelTransformRef;
    private IEnumerable<Transform> _wheelTrfs;
    private Transform _bogey;
    private Transform _bogeyRef;
    public Vector3 bogeyUp;
    private Vector3 _bogeyUp0;
    public Quaternion bogeyRot;
    private Quaternion _bogeyRot0;
    private Quaternion _bogeyRotLast;
    public float bogeyAngle;
    [NonSerialized]
    public Module_Deployable deployModule;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnWheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelBogey() => throw null;
  }
}
