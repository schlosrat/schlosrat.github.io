// Decompiled with JetBrains decompiler
// Type: KSPAudioProximity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AK.Wwise;
using KSP.Game;
using System.Runtime.CompilerServices;

public class KSPAudioProximity : KerbalMonoBehaviour
{
  public bool _isGlobal;
  public RTPC _Rtpc;
  public Event _audioEventEnteringTheshold;
  public Event _audioEventLeavingTheshold;
  public float _distanceThreshold;
  public float _thresholdThickness;
  public bool _fireOnce;
  public uint _frameDelay;
  private int _currentFrameNb;
  private float _rtpcCachedValue;
  private bool _useThreshold;
  private bool _hasFiredEnterEvent;
  private bool _hasFiredLeaveEvent;
  private bool _isInThresholdZone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool HasFiredAllEvents() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPAudioProximity() => throw null;
}
