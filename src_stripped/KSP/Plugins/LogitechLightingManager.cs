// Decompiled with JetBrains decompiler
// Type: KSP.Plugins.LogitechLightingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Messages;
using KSP.Messages.PropertyWatchers;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace KSP.Plugins
{
  public class LogitechLightingManager : IUpdate
  {
    private bool _isInitialized;
    private bool _isEnabled;
    private GameInstance _game;
    private GameState _currentGameState;
    private VesselComponent _activeVessel;
    private ElectricityLevel _electricityLevelWatcher;
    private VesselSOIPropertyWatcher _vesselSOIWatcher;
    private CelestialBodySelected _celestialBodySelectedWatcher;
    private TimeZoomStepSelectedPropertyWatcher _timeZoomStepSelectedPropertyWatcher;
    private Dictionary<string, LogitechLightingManager.LogitechKeyboardBitmapKeys> _unityBindingsMap;
    private byte[] _lightingBitmap;
    private Color _rotationControlsColor;
    private Color _translationControlsColor;
    private Color _kerbalMovementControlsColor;
    private Color _kerbalJetpackMovementControlsColor;
    private const float _rcsControlFlashPeriod = 1f;
    private Color _throttleControlsColor;
    private Color _readyActionGroupColor;
    private Color _partialReadyActionGroupColor;
    private Color _notReadyActionGroupColor;
    private bool _playLowPowerEffect;
    private const float _lowPowerEffectPeriod = 1f;
    private Color _lowPowerEffectColor;
    private bool _playLaunchPendingEffect;
    private const float _launchPendingEffectPeriod = 2f;
    private Color _playLaunchPendingEffectColor;
    private Dictionary<int, (Color, LogitechLightingManager.LogitechKeyboardBitmapKeys[])> _countdownEffectFrames;
    private float _launchSequenceCountdownEffectDuration;
    private float _launchSequenceCountdownEffectStart;
    private const float _stageActivatedEffectDuration = 0.75f;
    private float _stageActivatedEffectStart;
    private Color _stageActivatedEffectColor;
    private bool _playStageOutOfFuelEffect;
    private const float _stageOutOfFuelEffectPeriod = 0.5f;
    private Color _stageOutOfFuelEffectColor;
    private const float _partDestroyedEffectDuration = 0.75f;
    private float _partDestroyedEffectStart;
    private Color _partDestroyedEffectColor;
    private bool _vesselDestroyedEffect;
    private const float _vesselDestroyedEffectDuration = 0.75f;
    private float _vesselDestroyedEffectStart;
    private Color _vesselDestroyedEffectColor;
    private const LogitechLightingManager.LogitechKeyboardBitmapKeys _landingEffectCenterKey = LogitechLightingManager.LogitechKeyboardBitmapKeys.G;
    private Dictionary<int, HashSet<LogitechLightingManager.LogitechKeyboardBitmapKeys>> _landingEffectFrames;
    private float _landingEffectStart;
    private float _landingEffectStep;
    private const float _landingEffectDuration = 5f;
    private const float _landingEffectDimAmount = 1f;
    private const int _landingEffectAnimationNumberOfPulses = 5;
    private Color _timewarpEffectColor;
    private Color _timewarpPauseEffectColor;
    private const float _timewarpEffectDimAmount = 0.66f;
    private double _timewarpEffectStep;
    private const double _timewarpEffectMaxStep = 150.0;
    private const LogitechLightingManager.LogitechKeyboardBitmapKeys _timewarpEffectRow1StartingKey = LogitechLightingManager.LogitechKeyboardBitmapKeys.Q;
    private const LogitechLightingManager.LogitechKeyboardBitmapKeys _timewarpEffectRow2StartingKey = LogitechLightingManager.LogitechKeyboardBitmapKeys.A;
    private const LogitechLightingManager.LogitechKeyboardBitmapKeys _timewarpEffectRow3StartingKey = LogitechLightingManager.LogitechKeyboardBitmapKeys.BACKSLASH_UK;
    private const int _timewarpEffectAffectedKeys = 12;
    private const int _timewarpEffectNumberOfChevrons = 3;
    private const int _timewarpEffectChevronSpacing = 4;
    private bool _pauseEffect;
    private LogitechLightingManager.LogitechKeyboardBitmapKeys[] _pauseEffectKeys;
    private Color _defaultEnvironmentColor;
    private Dictionary<string, Color> _celestialBodyColorMap;
    private const LogitechLightingManager.LogitechKeyboardBitmapKeys _logitechBitmapSentinel = ~LogitechLightingManager.LogitechKeyboardBitmapKeys.ESC;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LogitechLightingManager(GameInstance game) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeSDK() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UninitializeSDK() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableIntegration(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidLogitechKey(
      LogitechLightingManager.LogitechKeyboardBitmapKeys key)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private LogitechLightingManager.LogitechKeyboardBitmapKeys ToLogitechKeyboardBitmapKey(
      int x,
      int y)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateSuccessfulLandingAnimation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisconnectEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float dt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetActionGroupColor(KSPActionGroupState groupState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetBitmapWithColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DimBitmap(float dimAmount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBitmapColorForKey(
      LogitechLightingManager.LogitechKeyboardBitmapKeys key,
      Color color)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBitmapColorForBindings(ReadOnlyArray<InputBinding> bindings, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private LogitechLightingManager.LogitechKeyboardBitmapKeys ToLogitechKey(InputBinding binding) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<int, HashSet<LogitechLightingManager.LogitechKeyboardBitmapKeys>> GenerateCircleBitmapsAroundKey(
      LogitechLightingManager.LogitechKeyboardBitmapKeys centerKey,
      int maxRadius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPauseStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStageChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselOutOfElectricity(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEngineOutOfFuel(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLaunchFromVAB(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLaunched(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreLaunchSequenceInitiated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLaunchSequenceInitiated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLaunchSequenceComplete(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselCreated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVesselSituationChangedMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVesselLandedOnGroundMessage(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnVesselLandedInWaterMessage(MessageCenterMessage msg) => throw null;

    private enum LogitechKeyboardBitmapKeys
    {
      ESC = 0,
      F1 = 4,
      F2 = 8,
      F3 = 12, // 0x0000000C
      F4 = 16, // 0x00000010
      F5 = 20, // 0x00000014
      F6 = 24, // 0x00000018
      F7 = 28, // 0x0000001C
      F8 = 32, // 0x00000020
      F9 = 36, // 0x00000024
      F10 = 40, // 0x00000028
      F11 = 44, // 0x0000002C
      F12 = 48, // 0x00000030
      PRINT_SCREEN = 52, // 0x00000034
      SCROLL_LOCK = 56, // 0x00000038
      PAUSE_BREAK = 60, // 0x0000003C
      TILDE = 84, // 0x00000054
      ONE = 88, // 0x00000058
      TWO = 92, // 0x0000005C
      THREE = 96, // 0x00000060
      FOUR = 100, // 0x00000064
      FIVE = 104, // 0x00000068
      SIX = 108, // 0x0000006C
      SEVEN = 112, // 0x00000070
      EIGHT = 116, // 0x00000074
      NINE = 120, // 0x00000078
      ZERO = 124, // 0x0000007C
      MINUS = 128, // 0x00000080
      EQUALS = 132, // 0x00000084
      BACKSPACE = 136, // 0x00000088
      INSERT = 140, // 0x0000008C
      HOME = 144, // 0x00000090
      PAGE_UP = 148, // 0x00000094
      NUM_LOCK = 152, // 0x00000098
      NUM_SLASH = 156, // 0x0000009C
      NUM_ASTERISK = 160, // 0x000000A0
      NUM_MINUS = 164, // 0x000000A4
      TAB = 168, // 0x000000A8
      Q = 172, // 0x000000AC
      W = 176, // 0x000000B0
      E = 180, // 0x000000B4
      R = 184, // 0x000000B8
      T = 188, // 0x000000BC
      Y = 192, // 0x000000C0
      U = 196, // 0x000000C4
      I = 200, // 0x000000C8
      O = 204, // 0x000000CC
      P = 208, // 0x000000D0
      OPEN_BRACKET = 212, // 0x000000D4
      CLOSE_BRACKET = 216, // 0x000000D8
      BACKSLASH = 220, // 0x000000DC
      KEYBOARD_DELETE = 224, // 0x000000E0
      END = 228, // 0x000000E4
      PAGE_DOWN = 232, // 0x000000E8
      NUM_SEVEN = 236, // 0x000000EC
      NUM_EIGHT = 240, // 0x000000F0
      NUM_NINE = 244, // 0x000000F4
      NUM_PLUS = 248, // 0x000000F8
      CAPS_LOCK = 252, // 0x000000FC
      A = 256, // 0x00000100
      S = 260, // 0x00000104
      D = 264, // 0x00000108
      F = 268, // 0x0000010C
      G = 272, // 0x00000110
      H = 276, // 0x00000114
      J = 280, // 0x00000118
      K = 284, // 0x0000011C
      L = 288, // 0x00000120
      SEMICOLON = 292, // 0x00000124
      APOSTROPHE = 296, // 0x00000128
      HASHTAG = 300, // 0x0000012C
      ENTER = 304, // 0x00000130
      NUM_FOUR = 320, // 0x00000140
      NUM_FIVE = 324, // 0x00000144
      NUM_SIX = 328, // 0x00000148
      LEFT_SHIFT = 336, // 0x00000150
      BACKSLASH_UK = 340, // 0x00000154
      Z = 344, // 0x00000158
      X = 348, // 0x0000015C
      C = 352, // 0x00000160
      V = 356, // 0x00000164
      B = 360, // 0x00000168
      N = 364, // 0x0000016C
      M = 368, // 0x00000170
      COMMA = 372, // 0x00000174
      PERIOD = 376, // 0x00000178
      FORWARD_SLASH = 380, // 0x0000017C
      OEM102 = 384, // 0x00000180
      RIGHT_SHIFT = 388, // 0x00000184
      ARROW_UP = 396, // 0x0000018C
      NUM_ONE = 404, // 0x00000194
      NUM_TWO = 408, // 0x00000198
      NUM_THREE = 412, // 0x0000019C
      NUM_ENTER = 416, // 0x000001A0
      LEFT_CONTROL = 420, // 0x000001A4
      LEFT_WINDOWS = 424, // 0x000001A8
      LEFT_ALT = 428, // 0x000001AC
      JPN_MUHENKAN = 436, // 0x000001B4
      SPACE = 440, // 0x000001B8
      JPN_HENKAN = 452, // 0x000001C4
      JPN_HIRAGANA_KATAKANA = 456, // 0x000001C8
      RIGHT_ALT = 464, // 0x000001D0
      RIGHT_WINDOWS = 468, // 0x000001D4
      APPLICATION_SELECT = 472, // 0x000001D8
      RIGHT_CONTROL = 476, // 0x000001DC
      ARROW_LEFT = 480, // 0x000001E0
      ARROW_DOWN = 484, // 0x000001E4
      ARROW_RIGHT = 488, // 0x000001E8
      NUM_ZERO = 492, // 0x000001EC
      NUM_PERIOD = 496, // 0x000001F0
    }
  }
}
