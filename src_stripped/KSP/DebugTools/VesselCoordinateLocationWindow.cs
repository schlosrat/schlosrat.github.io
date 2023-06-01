// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.VesselCoordinateLocationWindow
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
  public class VesselCoordinateLocationWindow : KerbalMonoBehaviour
  {
    private static readonly string PREFAB_KEY;
    private static readonly string FIXED_PRECISION_6_PLACES;
    private static VesselCoordinateLocationWindow Instance;
    [SerializeField]
    private TMP_Text _latitudeText;
    [SerializeField]
    private TMP_Text _longitudeText;
    [SerializeField]
    private TMP_Text _headingText;
    [SerializeField]
    private TMP_Text _zenithText;
    [SerializeField]
    private TMP_Text _horizonPitchText;
    [SerializeField]
    private TMP_Text _celestialBodyText;
    [SerializeField]
    private TMP_Text _semiMajorAxisText;
    [SerializeField]
    private TMP_Text _eccentricityText;
    [SerializeField]
    private TMP_Text _inclinationText;
    [SerializeField]
    private TMP_Text _longitudeAscNodeText;
    [SerializeField]
    private TMP_Text _periapsisText;
    [SerializeField]
    private TMP_Text _epochText;
    [SerializeField]
    private TMP_Text _epochAnomalyText;
    [SerializeField]
    private TMP_Text _originDistanceText;
    [SerializeField]
    private TMP_Text _situationText;
    [SerializeField]
    private TMP_Text _landedText;
    [SerializeField]
    private TMP_Text _splashedText;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyLatitudeText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyLongitudeText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyHeadingText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyHorizonPitchText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyZenithText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyCelestialBodyText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopySemiMajorAxisText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyEccentricityText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyInclinationText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyLongitudeAscNodeText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyPeriapsisText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyEpochText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyEpochAnomalyText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyOriginDistanceText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselCoordinateLocationWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VesselCoordinateLocationWindow() => throw null;
  }
}
