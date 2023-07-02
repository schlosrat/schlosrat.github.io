// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTelemetryTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPTelemetryTools : VehicleBehaviour
  {
    [Header("Channel List")]
    public bool showChannelList;
    public bool sortedByName;
    public string filter;
    [Space(5f)]
    public GUITextBox.Settings listSettings;
    [Header("CSV File")]
    public bool writeToCsv;
    public string csvWriteFolder;
    [Header("Console Debug")]
    public bool enableTelemetryLog;
    [HideInInspector]
    public Font defaultFont;
    private CsvFileWriter m_csvWriter;
    private StringBuilder m_listHeaderText;
    private StringBuilder m_channelList;
    private GUITextBox m_textBox;
    private GUIStyle m_searchFieldStyle;
    private GUIStyle m_sortToggleStyle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateAfterFixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string FormatTime(double t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComposeChannelList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AppendChannel(StringBuilder channelList, int channelIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ComposeTimeAndDistance(Telemetry.DataRow dataRow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTelemetryTools() => throw null;
  }
}
