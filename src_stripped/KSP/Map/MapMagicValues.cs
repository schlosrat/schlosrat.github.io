// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapMagicValues
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Shapes;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public static class MapMagicValues
  {
    private static bool _isInitialized;
    private static OrbitRendererConfiguration _rendererConfig;
    public const string MapKSCSimObject = "kerbin_KSC_Object";
    public const float MapDoubleClickTime = 0.3f;
    public const float Map3DTooltipSquishScalar = 0.8f;
    public const float Map3DTooltipMinSize = 0.02f;
    public const float Map3DMinOrbitWidth = 0.02f;
    public const float MapCameraPivotDistance = 20f;
    public const float MapCameraPivotResetAlpha = 1.3f;
    public const float MapCameraPivotFadeScalar = 2f;
    public const double MapInvScalarDefault = 100000.0;
    public const double MapInvScalarSmallestValue = 1500.0;
    public const double MapInvScalarLargestValue = 1E+16;
    public const double MapCelestialBodyScalarDefault = 2000.0;
    public static readonly int Map3DLayer;
    public const string TRACKING_STATION_BASE_LOC_PATH = "Menu/TrackingStation/";
    public const string TRACKING_STATION_FILTERS_LOC_PATH = "Menu/TrackingStation/Filters/";
    public const string TRACKING_STATION_TOOLTIP_LOC_PATH = "Menu/TrackingStation/Tooltips/";
    public const string TRACKING_STATION_CONFIRMATION_DIALOG_LOC_PATH = "Menu/TrackingStation/ConfirmationDialog/";
    public const string TRACKING_STATION_UNITS_LOC_PATH = "Menu/TrackingStation/Units/";
    public const string INFORMATION_PANEL_UNITS_LOC_PATH = "Map/Info/Units/";
    public const string CELESTIAL_BODY_LOC_PATH = "CelestialBody/";
    public const string TO_COMPLETE = "ToComplete";
    public const string MET = "MET";
    public const string PRELAUNCH = "Prelaunch";
    public const string IN_FLIGHT = "InFlight";
    public const string ESCAPING = "Escaping";
    public const string SUBORBITAL = "Suborbital";
    public const string IN_ORBIT = "InOrbit";
    public const string LANDED = "Landed";
    public const string SPLASHED = "Splashed";
    public const string CONFIRM = "Confirm";
    public const string CONFIRM_DESTROY = "ConfirmDestroy";
    public const string CONFIRM_RECOVERY = "ConfirmRecovery";
    public const string CONFIRM_OBJECT_DESTROY = "ConfirmObjectDestroy";
    public const string CONFIRM_OBJECT_RECOVERY = "ConfirmObjectRecover";
    public const string DESTORY_OBJECT = "DestroyObject";
    public const string RECOVER_OBJECT = "RecoverObject";
    public const string DASH = "-";
    public const string COLON = ":";
    public const string YEARS = "y";
    public const string DAYS = "d";
    public const string HOURS = "h";
    public const string MINUTES = "m";
    public const string SECONDS = "s";
    public const string UNKNOWN = "Unknown";
    public const string KSC_NAME = "KSC";
    public const string ACCORDION_CONTENT = "AccordianContent";
    public const string DATA_CONTEXT_NAME = "MapUISelectableDataContext";
    public const string NOTIFICATION_CANNOT_LEAVE_ACTIVE_VESSEL = "NOTIFICATION_CANNOT_LEAVE_ACTIVE_VESSEL";
    public const double DISTANCE_FROM_CB_LIMIT = 600000997669.0;
    public const string REPORTS_EARNED_OUT_OF_AVAILABLE = "12/45";
    public const string SCIENCE_EARNED_OUT_OF_AVAILABLE = "200/1000";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Initialize() => throw null;

    public static int MaxIterations
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static SubdivisionHeuristic SubdivisionHeuristics
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static double TriangleAreaMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static double ScreenSizeRatioMax
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static double SquarePerimeterSizeRatioMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static double SquaredPerimeterMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static int SeedPointsPerPeriod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static int MaxSeedPointsToGenerate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static int MaxCountPerPeriod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float GenerationDelay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool UsePolyline
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static ShapesBlendMode BlendMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static ThicknessSpace ThicknessSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool ThicknessUsesMapScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool FadeScreenspaceThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float MinScreenspacePixelThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color ThicknessFadeColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color ActiveVesselColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color NonActiveVesselColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color DefaultMapObjectColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static int MapDefaultDottedLineSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color TrajectoryOrbitStartColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color TrajectoryOrbitEndColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float TrajectoryOrbitThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static OrbitRenderSegment.RenderStyle TrajectoryOrbitRenderStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float TrajectoryOrbitDashLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float TrajectoryOrbitDashGap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color ManeuverCoastingStartColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color ManeuverCoastingEndColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float ManeuverOrbitThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static OrbitRenderSegment.RenderStyle ManeuverOrbitRenderStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float ManeuverOrbitDashLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float ManeuverOrbitDashGap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color ManeuverNonImpulseStartColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color ManeuverNonImpulseEndColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static OrbitRenderSegment.RenderStyle ManeuverNonImpulseRenderStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float ManeuverNonImpulseDashLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float ManeuverNonImpulseDashGap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float CelestialBodyOrbitThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static OrbitRenderSegment.RenderStyle CelestialBodyRenderStyle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float CelestialBodyOrbitDashLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float CelestialBodyOrbitDashGap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color NonActiveVesselOrbitStartColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color NonActiveVesselOrbitEndColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color NonLocallyOwnedOrbitStartColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color NonLocallyOwnedOrbitEndColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color TargetOrbitStartColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color TargetOrbitEndColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Color AnDnColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float AnDnLineThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float TrajectoryConnectorThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float TrajectoryConnectorDashLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float TrajectoryConnectorDashGap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool PerPatchGradients
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MapMagicValues() => throw null;
  }
}
