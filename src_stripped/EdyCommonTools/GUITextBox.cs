// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.GUITextBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
      [Space(5f)]
      [Range(0.0f, 200f)]
      public int scrollLines;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
