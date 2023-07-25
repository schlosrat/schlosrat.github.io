// Decompiled with JetBrains decompiler
// Type: KSP.UI.CommNetFlightHUDTooltipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class CommNetFlightHUDTooltipData : BasicTextTooltipData
  {
    private const string COMMNET_STATUS_INFORMATION_PROPERTY_KEY = "TooltipBody";
    private const string VESSEL_CONTROL_STATE_PROPERTY_KEY = "VesselControlState";
    private const string FULL_CONTROL_TITLE_LOC_KEY = "HUD/Tooltips/Commnet/FullControl";
    private const string FULL_CONTROL_BODY_LOC_KEY = "HUD/Tooltips/Commnet/FullControlInformation";
    private const string HIBERNATION_TITLE_LOC_KEY = "HUD/Tooltips/Commnet/Hibernation";
    private const string HIBERNATION_BODY_LOC_KEY = "HUD/Tooltips/Commnet/HibernationInformation";
    private const string NO_COMMNET_TITLE_LOC_KEY = "HUD/Tooltips/Commnet/NoCommnet";
    private const string NO_COMMNET_BODY_LOC_KEY = "HUD/Tooltips/Commnet/NoCommnetInformation";
    private const string NO_CONTROL_TITLE_LOC_KEY = "HUD/Tooltips/Commnet/NoControl";
    private const string NO_CONTROL_BODY_LOC_KEY = "HUD/Tooltips/Commnet/NoControlInformation";
    private const string UNKNOWN_INITIAL_VALUE = "Unknown";
    private Property<VesselControlState> _vesselControlState;
    private Property<string> _commnetStatusInformation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(Basic2DTooltipTarget tooltipTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ValidateData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsEmpty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CommNetFlightHUDTooltipData() => throw null;
  }
}
