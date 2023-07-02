// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ParticleFieldModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class ParticleFieldModifier : KerbalMonoBehaviour, IFixedUpdate
  {
    [SerializeField]
    private float farClip;
    [SerializeField]
    private float _alphaNear;
    [SerializeField]
    private float _alphaFar;
    [SerializeField]
    private float _alphaMax;
    [SerializeField]
    private bool _useDensity;
    private CelestialBodyRing _ring;
    private CelestialBodyBehavior _behavior;
    private string _bodyName;
    private PAParticleField _field;
    private Camera _camera;
    private float _innerRadius;
    private float _outerRadius;
    private float _alphaEdge;
    private Texture2D _texture;
    private CelestialBodyRingSimHelper _ringHelper;
    private SubscriptionHandle _handlePauseStateChanged;
    private bool _isPaused;

    private IPhysicsSpaceProvider PhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IScaledSpaceProvider ScaledSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      PAParticleField field,
      string bodyName,
      CelestialBodyRing ring,
      Camera camera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPauseStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IFixedUpdate.OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableField() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableField(bool updateField = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RingFieldFixedUpdate(
      Plane ringPlanePhysics,
      Vector3 cameraPosPhysics,
      Vector3 closestPosPhysics,
      Vector3 ringPosPhysics)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color ReadTextureColor(Texture2D tex, float min, float max, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float TextureEdgeAlpha(Texture2D tex, float min, float max, float distance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector CalculateTangentialVelocity(Vector angularVelocityVector, Vector positionVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParticleFieldModifier() => throw null;
  }
}
