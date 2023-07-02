// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TelemetryTemplateBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class TelemetryTemplateBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string GetDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual float GetDisplayAspectRatio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize(TelemetryDataset dataset, TelemetryTemplateBase.Context context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rect GetViewportRect(
      TelemetryDataset dataset,
      TelemetryTemplateBase.Context context)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Draw(TelemetryDataset dataset, TelemetryTemplateBase.Context context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void DrawText(TelemetryDataset dataset, TelemetryTemplateBase.Context context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UserCommand(
      TelemetryTemplateBase.Command command,
      float floatParam,
      int intParam)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FormatTimeLong(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FormatTimeLap(float t, bool milliseconds = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FormatTime(float t, bool milliseconds = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FormatDistance(float d, bool precision = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TelemetryTemplateBase() => throw null;

    public enum DataReference
    {
      Time,
      Distance,
    }

    public enum DataDrawMode
    {
      Lines,
      Samples,
      Both,
    }

    public enum ValueDisplayMode
    {
      Immediate,
      Accumulated,
    }

    public delegate void DrawTextFn(
      int offsetX,
      int offsetY,
      float x,
      float y,
      string text,
      Color color,
      TextAnchor alignment);

    public class Context
    {
      public TelemetryTemplateBase.DataReference reference;
      public float referenceStart;
      public float referenceEnd;
      public float referenceSpan;
      public int datasetFirst;
      public int datasetLast;
      public int datasetCount;
      public float datasetFrequency;
      public TextureCanvas canvas;
      public TelemetryTemplateBase.DataDrawMode drawMode;
      public TelemetryTemplateBase.ValueDisplayMode valueMode;
      public float plotDensity;
      public Color backgroundColor;
      public Vector2 pointerPosition;
      public bool pointerInCanvas;
      public bool pointerButtonPressed;
      public Vector2 buttonPressedPosition;
      public Vector2 buttonPressedDeltaPosition;
      public Color textColor;
      public float textLineHeight;
      public float textDigitWidth;
      public int textMarginX;
      public int textMarginY;
      public TelemetryTemplateBase.DrawTextFn drawTextFn;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Context() => throw null;
    }

    public enum Command
    {
      MoveX,
      MoveY,
      Zoom,
      ZoomX,
      ZoomY,
      Reset,
      ResetX,
      ResetY,
      AutoPan,
      MoveSegment,
      SegmentBegin,
      SegmentEnd,
      SelectSegment,
    }
  }
}
