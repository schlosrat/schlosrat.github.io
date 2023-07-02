// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VesselSurfaceInteractionVFXManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [Serializable]
  public class VesselSurfaceInteractionVFXManager
  {
    private VesselBehavior _vessel;
    private SubscriptionHandle _handlePartDestroyed;
    private SubscriptionHandle _handlePartDetached;
    private SubscriptionHandle _handleVesselCreated;
    private List<Module_Engine> _vesselEngines;
    private List<VesselSurfaceInteractionVFXManager.EngineThrustInstance> _activeGroundBlastVFX;
    private Dictionary<IGGuid, VesselSurfaceInteractionVFXManager.PartSurfaceContact> _activeSurfaceContacts;

    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselSurfaceInteractionVFXManager(VesselBehavior vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyedOrDetached(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshEngineObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(FXContextData contextData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckGroundBlastConditions(Module_Engine engine) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateGroundBlast(VesselBehavior vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGroundBlastEnded(Module_Engine engine, int transformIdx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnWheelCollisionEnter(
      PartBehavior part,
      Vector3 contactPoint,
      Collider hitObject,
      float relativeVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCollisionEnter(
      PartBehavior part,
      Vector3 contactPoint,
      Collider hitCollider,
      float relativeVelocity,
      bool wheel = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCollisionStay(
      PartBehavior part,
      Collider hitCollider,
      Vector3 contactPoint,
      float relativeVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCollisionExit(PartBehavior part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPersistentSurfaceContactEnded(IGGuid partGUID) => throw null;

    internal class EngineThrustInstance
    {
      public Module_Engine SourceEngine;
      public List<bool> ThrustActive;
      public List<FXGroundBlastContextualEvent> CFXEvents;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EngineThrustInstance() => throw null;
    }

    internal class PartSurfaceContact
    {
      public PartBehavior OriginatingPart;
      public bool Active;
      public FXCollisionContextualEvent CFXEvent;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PartSurfaceContact(PartBehavior part) => throw null;
    }
  }
}
