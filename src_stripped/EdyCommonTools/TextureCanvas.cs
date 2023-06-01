// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.TextureCanvas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public class TextureCanvas
  {
    private Texture2D m_texture;
    private int m_pixelsWd;
    private int m_pixelsHt;
    private bool m_dirty;
    private Color32[] m_pixels;
    private Color32[] m_buffer;
    private UnityEngine.Rect m_canvasRect;
    private float m_scaleX;
    private float m_scaleY;
    private UnityEngine.Rect m_clipArea;
    private int m_pixelsXMin;
    private int m_pixelsXMax;
    private int m_pixelsYMin;
    private int m_pixelsYMax;
    private Color32 m_pixelColor;
    private Color m_color;
    private float m_alpha;
    private bool m_alphaBlend;
    private float m_srcBlend;
    private float m_dstBlend;
    private float m_moveX;
    private float m_moveY;
    private int m_step;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureCanvas(int pixelsWd, int pixelsHt, UnityEngine.Rect canvasRect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureCanvas(int pixelsWd, int pixelsHt, float canvasWd, float canvasHt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureCanvas(int pixelsWd, int pixelsHt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResizeTexture(int pixelsWd, int pixelsHt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyTexture() => throw null;

    public UnityEngine.Rect rect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UnityEngine.Rect clipArea
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Pixels2CanvasX(int pixels) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Pixels2CanvasY(int pixels) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPixelX(float x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPixelY(float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPixelWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPixelHeight(float height) => throw null;

    public Color color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float alpha
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool alphaBlend
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public TextureCanvas.LineType lineType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int dotInterval
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int dashInterval
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool doublePixel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetLineType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MoveTo(float x0, float y0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LineTo(float x1, float y1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Line(float x0, float y0, float x1, float y1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HorizontalLine(float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VerticalLine(float x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Circumference(float x, float y, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Circle(float x, float y, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Ellipse(float x, float y, float rx, float ry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FillEllipse(float x, float y, float rx, float ry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Grid(float stepX, float stepY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HorizontalGrid(float stepY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VerticalGrid(float stepX) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DotGrid(float stepX, float stepY) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pixel(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dot(float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cross(float x, float y, int radiusX = 5, int radiusY = 5) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Rectangle(float x, float y, float width, float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FillRect(float x, float y, float width, float height) => throw null;

    public int functionResolution
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Function(
      System.Func<float, float> func,
      float x0,
      float x1,
      float stepSize = -1f,
      float continuityThreshold = -1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Function(System.Func<float, float> func, float stepSize = -1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FunctionWithContinuityCheck(
      System.Func<float, float> func,
      float x0,
      float y0,
      float continuityThreshold = 100f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FunctionWithContinuityCheck(System.Func<float, float> func, float continuityThreshold = 100f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SolidFunction(System.Func<float, float> func, float x0, float x1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SolidFunction(System.Func<float, float> func) => throw null;

    public bool contourPlotDoublePixel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ContourPlot(Func<float, float, Color> evaluate) => throw null;

    public float polarPlotDelta
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PolarPlot(System.Func<float, float> evaluate, float w0 = 0.0f, float w1 = 6.28318548f, float deltaW = -1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HorizontalAction(Action<float> action, float interval, float offset = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void VerticalAction(Action<float> action, float interval, float offset = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Restore() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUIDraw(int x, int y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUIDraw(Vector2Int pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUIStretchDraw(int x, int y, int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUIStretchDraw(int x, int y, int width) => throw null;

    public Texture2D texture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SaveToPNG(string fileNameAndPath) => throw null;

    public bool allowLabelsOutsideCanvas
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUICanvasLabel(
      int x,
      int y,
      float canvasX,
      float canvasY,
      string text,
      GUIStyle style,
      TextAnchor alignment = TextAnchor.UpperLeft)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUILabel(
      int x,
      int y,
      int textureX,
      int textureY,
      string text,
      GUIStyle style,
      TextAnchor alignment = TextAnchor.UpperLeft)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityEngine.Rect GetTextureRectForText(float x, float y, TextAnchor alignment) => throw null;

    [Obsolete("TextureCanvas(pixelsWd, pixelsHt, canvasX0, canvasY0, canvasWd, canvasHt) is obsolete. Use TextureCanvas(pixelsWd, pixelsHt, rect) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextureCanvas(
      int pixelsWd,
      int pixelsHt,
      float canvasX0,
      float canvasY0,
      float canvasWd,
      float canvasHt)
    {
      throw null;
    }

    [Obsolete("CanvasWidth() is obsolete. Use TextureCanvas.rect.width instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CanvasWidth() => throw null;

    [Obsolete("CanvasHeight() is obsolete. Use TextureCanvas.rect.height instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CanvasHeight() => throw null;

    [Obsolete("PixelsWidth() is obsolete. Use TextureCanvas.width instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public int PixelsWidth() => throw null;

    [Obsolete("SetAlpha(alpha) is obsolete. Use TextureCanvas.alpha instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAlpha(float value) => throw null;

    [Obsolete("SetAlphaBlend(alphaBlend) is obsolete. Use TextureCanvas.alphaBlend instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAlphaBlend(bool value) => throw null;

    [Obsolete("SetFunctionResolution(value) is obsolete. Use TextureCanvas.functionResolution instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFunctionResolution(int value) => throw null;

    [Obsolete("Clear(color) is obsolete. Use TextureCanvas.color and TextureCanvas.Clear() instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(Color col) => throw null;

    [Obsolete("Grid(stepX, stepY, color) is obsolete. Use TextureCanvas.color and TextureCanvas.Grid(stepX, stepY) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Grid(float stepX, float stepY, Color col) => throw null;

    [Obsolete("LineV(x, color) is obsolete. Use TextureCanvas.color and TextureCanvas.VerticalLine(x) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LineV(float x, Color col) => throw null;

    [Obsolete("LineH(y, color) is obsolete. Use TextureCanvas.color and TextureCanvas.HorizontalLine(y) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LineH(float y, Color col) => throw null;

    [Obsolete("DashedLineV(x, step, color) is obsolete. Use TextureCanvas.lineType, TextureCanvas.color, TextureCanvas.dashInterval and TextureCanvas.VerticalLine(x) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DashedLineV(float x, int step, Color col) => throw null;

    [Obsolete("DottedLineV(x, step, color) is obsolete. Use TextureCanvas.lineType, TextureCanvas.color, TextureCanvas.dotInterval and TextureCanvas.VerticalLine(x) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DottedLineV(float x, int step, Color col) => throw null;

    [Obsolete("DottedGrid(stepX, stepY, dotStep, color) is obsolete. Use TextureCanvas.lineType, TextureCanvas.color, TextureCanvas.dotInterval and TextureCanvas.Grid(stepX, stepY) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DottedGrid(float stepX, float stepY, int step, Color col) => throw null;

    [Obsolete("Dot(x, y, color) is obsolete. Use TextureCanvas.color and TextureCanvas.Dot(x, y) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dot(float x, float y, Color col) => throw null;

    [Obsolete("Circumference(x, y, radius, color) is obsolete. Use TextureCanvas.color and TextureCanvas.Circumference(x, y, radius) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Circumference(float x, float y, float radius, Color col) => throw null;

    [Obsolete("Rect(x, y, width, height, color) is obsolete. Use TextureCanvas.color and TextureCanvas.Rectangle(x, y, width, height) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Rect(float x, float y, float width, float height, Color col) => throw null;

    [Obsolete("FillRect(x, y, width, height, color) is obsolete. Use TextureCanvas.color and TextureCanvas.FillRect(x, y, width, height) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FillRect(float x, float y, float width, float height, Color col) => throw null;

    [Obsolete("Function(func, color) is obsolete. Use TextureCanvas.color and TextureCanvas.Function(func) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Function(System.Func<float, float> func, Color col) => throw null;

    [Obsolete("Function(func, x0, x1, color, stepSize) is obsolete. Use TextureCanvas.color and TextureCanvas.Function(func, x0, x1, stepSize) instead")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Function(System.Func<float, float> func, float x0, float x1, Color col, float stepSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCanvas(int pixelsWd, int pixelsHt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupPixelColor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color32 GetAlphaBlendedPixel(Color32 dst) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckForPixel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TexPixel(int x, int y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TexLine(int x0, int y0, int x1, int y1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TexSegmentV(int x, int y0, int y1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TexSegmentH(int x0, int x1, int y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TexEllipse(int cx, int cy, int rx, int ry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TexFillEllipse(int cx, int cy, int rx, int ry) => throw null;

    public enum LineType
    {
      Solid,
      Dotted,
      Dashed,
    }
  }
}
