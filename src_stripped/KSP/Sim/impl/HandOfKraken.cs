// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.HandOfKraken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class HandOfKraken : IUpdate, IFixedUpdate, IPriorityOverride
  {
    private bool _isEnabled;
    private PartOwnerBehavior _owner;
    private GameInstance _game;
    private float _currentOrbitCoolDown;
    private bool _shouldBeCorrectingOrbit;
    private bool _wasVesselUnderAcceleration;
    private bool _wasVesselInRBPhysicsMode;
    private bool _pendingOnUpdateCalcs;

    public Position ExpectedOrbitPos
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsCorrectingOrbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInOrbitCorrectionDelay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasExpectedOrbitPos
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsVesselUnderAcceleration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsVesselInRBPhysicsMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HandOfKraken(PartOwnerBehavior partOwner, GameInstance game) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Register() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Unregister() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    public int ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartOrbitCorrectStandOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartOrbitCorrectInitialDelay() => throw null;
  }
}
