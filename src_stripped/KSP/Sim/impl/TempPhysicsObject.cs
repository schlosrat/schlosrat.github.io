// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.TempPhysicsObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  [RequireComponent(typeof (Rigidbody))]
  public class TempPhysicsObject : KerbalMonoBehaviour
  {
    public float MaxDistance;
    private Rigidbody _rigidbody;
    private TimeWarp _timeWarp;
    private UniverseObserver _observer;
    private IPhysicsSpaceProvider _physicsSpaceProvider;
    private Vector3d _localPosRelativeToObserver;
    private QuaternionD _localRotRelativeToObserver;

    public Rigidbody Rigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFrameSnapEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFrameSnapStart(List<Action> obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TempPhysicsObject() => throw null;
  }
}
