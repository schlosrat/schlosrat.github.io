// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DataLogger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using EdyCommonTools;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  public class DataLogger
  {
    public float minViewportWidth;
    public float maxViewPortWidth;
    public float minViewportHeight;
    public float topLimit;
    public float bottomLimit;
    public int rightMarginOnRecord;
    public float horizontalZoomCenter;
    public float verticalZoomCenter;
    public bool autoRefresh;
    public DataLogger.GridSettings primaryGrid;
    public DataLogger.GridSettings secondaryGrid;
    public DataLogger.GridSettings dotGrid;
    public Color channelOriginColor;
    public int channelCaptionMargin;
    public GUIStyle textStyle;
    private DataRecorder m_dataRecorder;
    private TextureCanvas m_canvas;
    private DataLogger.DisplaySettings m_displaySettings;
    private int m_displayX;
    private int m_displayY;
    private List<DataLogger.Channel> m_channels;
    private float m_bufferTime;
    private float m_deltaTime;
    private bool m_dirty;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataLogger(
      float bufferTime,
      float deltaTime,
      DataLogger.DisplaySettings textureSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConfigureDisplay(DataLogger.DisplaySettings textureSettings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUIDrawGraphic() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUIDrawLabels(GUIStyle style = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUILabel(int x, int y, string label, GUIStyle style = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUILabelOnTexture(int x, int y, string label, GUIStyle style = null) => throw null;

    public Rect rect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Rect ClampView(Rect rc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MovePosition(float offsetX, float offsetY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HorizontalZoom(float rate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VerticalZoom(float rate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NextFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataLogger.Channel NewChannel(string name) => throw null;

    [Obsolete("Use NewChannel(name), then set channel.color and channel.origin separately")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataLogger.Channel NewChannel(string name, Color color, float origin = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FrameCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Restart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlotChannels(DataLogger.PlotAction plotAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool BoundsCheck(float bound0, float bound1, float value0, float value1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlotLines(
      DataLogger.Channel channel,
      bool hasValue1,
      float value1,
      float t1,
      bool hasValue2,
      float value2,
      float t2)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlotDots(
      DataLogger.Channel channel,
      bool hasValue1,
      float value1,
      float t1,
      bool hasValue2,
      float value2,
      float t2)
    {
      throw null;
    }

    [Serializable]
    public class DisplaySettings
    {
      public int x;
      public int y;
      public int width;
      public int height;
      public Color backgroundColor;
      [FormerlySerializedAs("backgroundAlpha")]
      public float chartAlpha;
      public float textAlpha;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DisplaySettings() => throw null;
    }

    [Serializable]
    public class GridSettings
    {
      public bool show;
      public DataLogger.GridSettings.Type type;
      public Vector2 resolution;
      public Color color;
      public int autoHidePixels;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool CheckVisibility(TextureCanvas canvas) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Draw(TextureCanvas canvas) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void DrawDots(TextureCanvas canvas) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GridSettings() => throw null;

      public enum Type
      {
        Full,
        Vertical,
        Horizontal,
      }
    }

    public class Channel
    {
      public string name;
      public float origin;
      public float scale;
      public Color color;
      public bool alphaBlend;
      public bool show;
      public bool showSegmentBegin;
      public bool showSegmentEnd;
      public float captionPositionY;
      public string valueFormat;
      private int m_channelId;
      private DataRecorder m_recorder;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Channel(DataRecorder recorder) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Write(float value) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float Read() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetOriginAndSpan(float origin, float span, float valueUnits = 1f) => throw null;
    }

    private delegate void PlotAction(
      DataLogger.Channel channel,
      bool hasValue1,
      float value1,
      float t1,
      bool hasValue2,
      float value2,
      float t2);
  }
}
