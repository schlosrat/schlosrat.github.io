// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TelemetryMultiLineGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [Serializable]
  public class TelemetryMultiLineGraph : TelemetryTemplateBase
  {
    public TelemetryMultiLineGraph.Settings settings;
    private string m_header;
    private string m_footerLeft;
    private string m_footerRight;
    private string m_footerCenter;
    private int m_pointerEntry;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override float GetDisplayAspectRatio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize(TelemetryDataset dataset, TelemetryTemplateBase.Context context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Rect GetViewportRect(
      TelemetryDataset dataset,
      TelemetryTemplateBase.Context context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Draw(TelemetryDataset dataset, TelemetryTemplateBase.Context context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DrawText(TelemetryDataset dataset, TelemetryTemplateBase.Context context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeChannelsData(
      TelemetryDataset dataset,
      TelemetryTemplateBase.Context context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeAccumulatedValues(
      TelemetryMultiLineGraph.Settings.Channel channel,
      TelemetryDataset dataset,
      TelemetryTemplateBase.Context context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawChannel(
      TelemetryMultiLineGraph.Settings.Channel channel,
      TelemetryDataset dataset,
      TelemetryTemplateBase.Context context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawChannelText(
      TelemetryMultiLineGraph.Settings.Channel channel,
      TelemetryDataset dataset,
      TelemetryTemplateBase.Context context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TelemetryMultiLineGraph() => throw null;

    [Serializable]
    public class Settings
    {
      [Tooltip("Name to show in the telemetry display when this template is selected")]
      public string templateName;
      [Tooltip("Logical vertical units in the graph. Channel's Origin and Range values refer to this range.")]
      public float verticalRange;
      public TelemetryMultiLineGraph.Settings.Channel[] channels;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;

      [Serializable]
      public class Channel
      {
        [Tooltip("Unique channel name to be looked for in the available channel list")]
        public string name;
        [Tooltip("Label for this channel in the telemetry graph. If empty, channel name will be used instead.")]
        public string displayName;
        [Tooltip("Vertical offset to draw the channel label, in lines of text. Used when several channels share the same origin.")]
        public float labelOffset;
        [Tooltip("Origin in the graph to draw this channel's zero. For example, if Vertical Range is 10 then Origin = 5 is the vertical middle of the display.")]
        public float displayOrigin;
        [Tooltip("Graph range for this channel's values with respect to Vertical Range. For example if Range = 2 and the maximum expected value of this channel is 100, then the 0-100 range will use 2 vertical units in the display.")]
        public float displayRange;
        [Tooltip("The color of the line for this channel. Transparency may be used to combine several channels in the same region of the graph.")]
        public Color displayColor;
        [NonSerialized]
        public int index;
        [NonSerialized]
        public bool active;
        [NonSerialized]
        public float frequency;
        [NonSerialized]
        public string valueLabel;
        [NonSerialized]
        public int firstEntry;
        [NonSerialized]
        public int deltaEntry;
        [NonSerialized]
        public float min;
        [NonSerialized]
        public float max;
        [NonSerialized]
        public float avg;
        [NonSerialized]
        public int count;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public void DefaultValues() => throw null;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public Channel() => throw null;
      }
    }
  }
}
