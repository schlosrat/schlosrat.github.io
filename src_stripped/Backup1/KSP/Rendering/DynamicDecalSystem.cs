// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.DynamicDecalSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
