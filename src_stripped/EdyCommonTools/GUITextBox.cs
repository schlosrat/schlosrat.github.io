// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.GUITextBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public class GUITextBox
  {
    public string title;
    public GUITextBox.Settings settings;
    private bool m_dirty;
    private GUIStyle m_textStyle;
    private string m_headerText;
    private Vector2 m_headerTextSize;
    private string m_mainText;
    private Vector2 m_mainTextSize;
    private float m_scrollViewHeight;
    private Vector2 m_scrollPosition;
    private float m_boxWidth;
    private float m_boxHeight;
    private float m_margin;
    private Rect m_boxRect;
    public bool richText;

    public string header
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Rect boxRect
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float margin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeBoxSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GUITextBox() => throw null;

    [Serializable]
    public class Settings
    {
      public Vector2 position;
      [Space(5f)]
      public Font font;
      [Range(6f, 100f)]
      public int fontSize;
      public Color fontColor;
      [Range(0.0f, 200f)]
      [Space(5f)]
      public int scrollLines;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
