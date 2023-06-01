// Decompiled with JetBrains decompiler
// Type: KSPAudioWheelManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class KSPAudioWheelManager
{
  private static KSPAudioWheelManager _instance;
  private HashSet<KSPPartWheelAudio> _wheelsOnGround;
  private HashSet<KSPPartWheelAudio> _activeVesselWheels;
  private float _wheelsOnGroundDuration;
  private float _wheelsOffGroundDuration;
  private bool _isLandVehicle;

  public static KSPAudioWheelManager Instance
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RegisterGroundedWheel(KSPPartWheelAudio wheel) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UnregisterGroundedWheel(KSPPartWheelAudio wheel) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RegisterActiveVesselWheel(KSPPartWheelAudio wheel) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UnregisterActiveVesselWheel(KSPPartWheelAudio wheel) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool AtLeastOneWheelMoving() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPAudioWheelManager() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static KSPAudioWheelManager() => throw null;
}
