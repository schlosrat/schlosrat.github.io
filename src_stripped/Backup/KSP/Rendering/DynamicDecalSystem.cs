// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.DynamicDecalSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class DynamicDecalSystem : KerbalMonoBehaviour
  {
    private PartBehavior _partBehavior;
    private Module_Kerbal _kerbalModule;
    private GameObject _leftFoot;
    private GameObject _rightFoot;
    private SubscriptionHandle _messageHandler;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnKerbalRigLoadComplete(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LeftFootprintEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RightFootprintEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FireVFXEvent(GameObject initiator) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicDecalSystem() => throw null;
  }
}
