// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.ThermalDebugToolWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.DebugTools
{
  public class ThermalDebugToolWindow : KerbalMonoBehaviour
  {
    private static readonly string PREFAB_KEY;
    private static readonly string FIXED_PRECISION_6_PLACES;
    private static ThermalDebugToolWindow Instance;
    [SerializeField]
    private TMP_Text _currentValuesText;
    [SerializeField]
    private TMP_InputField _globalAtmosphereFluxScaleInputField;
    [SerializeField]
    private TMP_InputField _globalBodySurfaceFluxScaleInputField;
    [SerializeField]
    private TMP_InputField _globalBodyLocalFluxScaleInputField;
    [SerializeField]
    private TMP_InputField _globalEnvironmentFluxScaleInputField;
    [SerializeField]
    private TMP_InputField _globalReentryFluxScaleInputField;
    [SerializeField]
    private TMP_InputField _globalEngineExhaustFluxScaleInputField;
    [SerializeField]
    private TMP_InputField _globalPositivePartTemperatureChangeRateScaleInputField;
    [SerializeField]
    private TMP_InputField _globalNegativePartTemperatureChangeRateScaleInputField;
    [SerializeField]
    private TMP_InputField _globalBackgroundPartTemperatureChangeRateScaleInputField;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ThermalDebugToolWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ThermalDebugToolWindow() => throw null;
  }
}
