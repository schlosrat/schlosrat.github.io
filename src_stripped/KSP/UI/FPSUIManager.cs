// Decompiled with JetBrains decompiler
// Type: KSP.UI.FPSUIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class FPSUIManager : KerbalMonoBehaviour
  {
    private const float UPDATE_INTERVAL = 0.5f;
    private const string FPS_LOC_KEY = "Menu/FPS/FPS";
    private const string FPS_SMOOTHED_LOC_KEY = "Menu/FPS/SmoothedFPS";
    private const string MSPERFRAME_LOC_KEY = "Menu/FPS/msPerFrame";
    private const string MSPERFRAME_SMOOTHED_LOC_KEY = "Menu/FPS/SmoothedmsPerFrame";
    private const string FPS_VALUE_DECIMAL_PLACES = "{1:0.00}";
    private const string SMOOTHED_FPS_VALUE_DECIMAL_PLACES = "{3:0.00}";
    private const string DATA_CONTEXT_NAME = "FPS Data Context";
    private const string FPS_PROPERTY_NAME = "FPS";
    private const string IS_MINIMIZED_PROPERTY_NAME = "IsMinimized";
    private const string TOGGLE_MINIMIZE_ACTION_NAME = "ToggleMinimize";
    [SerializeField]
    private ContextBindRoot _fpsUIManagerBindRoot;
    private DataContext _fpsDataContext;
    private bool _renderFrameTimes;
    private KSP2UIWindow _ksp2UIWindow;
    private Property<string> _fpsText;
    private Property<bool> _isMinimized;
    private string _fpsOutputTemplate;
    private readonly List<float> _fpsTimingsBuffer;
    private float _lastUpdateTime;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LocalizeText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetFPSUIValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShowFPS(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleMinimize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FPSUIManager() => throw null;
  }
}
