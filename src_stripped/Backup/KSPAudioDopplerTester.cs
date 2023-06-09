﻿// Decompiled with JetBrains decompiler
// Type: KSPAudioDopplerTester
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AK.Wwise;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPAudioDopplerTester : MonoBehaviour
{
  [SerializeField]
  public Transform PointA;
  [SerializeField]
  public Transform PointB;
  [SerializeField]
  public Transform PointC;
  [SerializeField]
  public Transform PointABC;
  [SerializeField]
  public bool JustGoFromAToBThankYou;
  [SerializeField]
  [Space(10f)]
  public GameObject AudioListener;
  [Space(20f)]
  [SerializeField]
  public float Speed;
  [SerializeField]
  public float SpeedOfSound;
  [SerializeField]
  public float MaxDistance;
  [SerializeField]
  public float PauseTimeOnPoints;
  [Space(10f)]
  [SerializeField]
  public bool Verbose;
  [Space(20f)]
  [SerializeField]
  [Range(0.0f, 1f)]
  public float ThrustPercentage;
  [SerializeField]
  public float StaticPressure;
  [SerializeField]
  public float Mass;
  [SerializeField]
  public float GForce;
  [Space(10f)]
  [SerializeField]
  public RTPC RTPC_01;
  [SerializeField]
  public float RTPC_01_Value;
  private float _rtpc01Cache;
  [Space(5f)]
  [SerializeField]
  public RTPC RTPC_02;
  [SerializeField]
  public float RTPC_02_Value;
  private float _rtpc02Cache;
  [SerializeField]
  [Space(5f)]
  public RTPC RTPC_03;
  [SerializeField]
  public float RTPC_03_Value;
  private float _rtpc03Cache;
  [SerializeField]
  [Space(5f)]
  public RTPC RTPC_04;
  [SerializeField]
  public float RTPC_04_Value;
  private float _rtpc04Cache;
  [Space(5f)]
  [SerializeField]
  public RTPC RTPC_05;
  [SerializeField]
  public float RTPC_05_Value;
  private float _rtpc05Cache;
  private float _interpAmount;
  private float _lastInterpAmount;
  private AkGameObj _audioEmitter;
  private Vector3 _previousListenerPosition;
  private Vector3 _previousSourcePosition;
  private float _currentPauseTime;
  private bool _isInPause;
  private float _rtpcDopplerCache;
  private float _rtpcThrustPercentageCache;
  private float _rtpcStaticPressureCache;
  private float _rtpcGForceCache;
  private float _rtpcMassCache;
  private float _rtpcAttachmentCache;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateDopplerRTPC() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetDefaultEngineRTPCs() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateCustomRTPC() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPAudioDopplerTester() => throw null;
}
