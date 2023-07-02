// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FlightInputHandlerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Input;
using KSP.Messages;
using KSP.Sim.State;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class FlightInputHandlerBase : KerbalMonoBehaviour
  {
    protected GameInput _input;
    protected FlightCtrlState _flightCtrlState;
    protected int _cursorEnabledCount;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlightControlState(FlightCtrlState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCreated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnColonyFounded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewLeft(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetInputLockingState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableVesselInputState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableColonyInputState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableEVAInputState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableEVAInputState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlightInputHandlerBase() => throw null;
  }
}
