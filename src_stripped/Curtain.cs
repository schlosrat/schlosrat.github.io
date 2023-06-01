// Decompiled with JetBrains decompiler
// Type: Curtain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Curtain : KerbalMonoBehaviour
{
  public const CurtainContext DEFAULT_CURTAIN_CONTEXT = CurtainContext.None;
  public const byte DEFAULT_CURTAIN_CONTEXT_PARAM = 0;
  public const bool DEFAULT_FADE_IN_OPTION = false;
  public const bool DEFAULT_FADE_OUT_OPTION = true;
  public const float DEFAULT_FADE_TO_IMAGE_TIME_SECONDS = 0.5f;
  public const float DEFAULT_FADE_TO_SCENE_TIME_SECONDS = 0.5f;
  public const float MAX_TIME_SECONDS_PER_FRAME_FOR_FADE = 0.1f;
  public const float MINIMUM_ENFORCED_FADE_TIME = 0.001f;
  [HideInInspector]
  [NonSerialized]
  public Dictionary<CurtainContext, LoadingScreen> LoadingScreens;
  [HideInInspector]
  [NonSerialized]
  public float FadeInTime;
  [HideInInspector]
  [NonSerialized]
  public float FadeOutTime;
  private CurtainContextData _curtainContextData;
  private Curtain.StateEnum _curtainState;
  private bool _isTransitioning;
  private float _curtainAlpha;
  private bool _isShowing;
  private Sprite _loadedSprite;
  private Action _onTransitionFinished;
  [SerializeField]
  private Image _image;
  [SerializeField]
  private bool _showDuringLoading;
  [SerializeField]
  private Sprite _defaultFallbackLoadingScreenSprite;
  [SerializeField]
  private Sprite _appStartLoadingScreenSprite1;
  [SerializeField]
  private Sprite _appStartLoadingScreenSprite2;
  [SerializeField]
  private Sprite _appStartLoadingScreenSprite3;
  private List<Sprite> _appStartLoadingScreenSpriteOptions;
  private Sprite _curDefaultLoadingScreenSprite;

  public CurtainContextData CurtainContextData
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool IsShowing
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SelectRandomImage(CurtainContextData contextData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetImage(CurtainContextData contextData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Sprite PickRandomStartingSprite() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetShowing(bool isEnabled, Action onTransitionFinished) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void StartCurtain(Action onFinished) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void EndCurtain(Action onFinished) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsBusy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetCurtainContextData(CurtainContextData curtainContextData) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateCurtainColor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ImmediatelyDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float ClampDT(float deltaTime, bool logClamps = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Curtain() => throw null;

  private enum StateEnum
  {
    STATE_FADETOIMAGE,
    STATE_FADETOSCENE,
    STATE_DONE,
  }
}
