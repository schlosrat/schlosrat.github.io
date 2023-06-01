// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.GUICanvasBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public class GUICanvasBox
  {
    public int x;
    public int y;
    private TextureCanvas m_canvas;
    private GUIStyle m_style;
    private int m_width;
    private int m_height;

    public TextureCanvas canvas
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int width
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int fontSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Font font
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2Int screenPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float lineHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float digitWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSize(int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Draw() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawText(
      int offsetX,
      int offsetY,
      float x,
      float y,
      string text,
      Color color,
      TextAnchor alignment = TextAnchor.UpperLeft)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 MousePosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupCanvas(int width, int height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GUICanvasBox() => throw null;
  }
}
