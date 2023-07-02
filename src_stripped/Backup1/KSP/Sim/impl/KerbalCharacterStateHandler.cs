// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.KerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public abstract class KerbalCharacterStateHandler
  {
    protected KerbalBehavior _kerbalBehavior;
    protected KerbalCharacterStateHandlerType _handlerType;
    protected bool _isInitialized;
    protected bool _isActive;
    protected bool _isPermanent;
    protected float _normalToSprintLerp;

    public KerbalCharacterStateHandlerType HandlerType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected VesselComponent KerbalVesselComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalCharacterStateHandler(
      KerbalBehavior kerbalBehavior,
      KerbalCharacterStateHandlerType handlerType,
      bool isPermanent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Deinitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void FixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool Update(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool LateUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool CanBeActivatedByInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool CanBeDeactivatedByLocomotionHandler(
      KerbalCharacterStateHandler deactivateByHandler)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool ShouldApplyStaticFriction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool ShouldApplyUpright() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ShouldApplyPhysics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AcceptMessage(KerbalCharacterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool ShouldBeActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ResetAnimationStateMoveVars() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected float CalcNormalToSprintLerp(float normalModeBasedValue, float sprintModeBasedValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected double CalcNormalToSprintLerp(
      double normalModeBasedValue,
      double sprintModeBasedValue)
    {
      throw null;
    }
  }
}
