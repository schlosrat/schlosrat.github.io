// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.RuntimeCanvasBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace EdyCommonTools
{
  public class RuntimeCanvasBase : MonoBehaviour
  {
    public RuntimeCanvasBase.Settings settings;
    [HideInInspector]
    public Font defaultFont;
    [HideInInspector]
    [FormerlySerializedAs("width")]
    public int old_width;
    [FormerlySerializedAs("height")]
    [HideInInspector]
    public int old_height;
    [FormerlySerializedAs("rect")]
    [HideInInspector]
    public Rect old_rect;
    [FormerlySerializedAs("gridX")]
    [HideInInspector]
    public float old_gridX;
    [HideInInspector]
    [FormerlySerializedAs("gridY")]
    public float old_gridY;
    [FormerlySerializedAs("autoResetBackground")]
    [HideInInspector]
    public bool old_autoResetBackground;
    [HideInInspector]
    [FormerlySerializedAs("font")]
    public Font old_font;
    [HideInInspector]
    [FormerlySerializedAs("fontSize")]
    public int old_fontSize;
    private TextureCanvas m_canvas;
    private GUIStyle m_style;
    private string m_header;
    private float m_lastGridX;
    private float m_lastGridY;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnSetupBackground() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnUpdateGraphic() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string OnUpdateHeader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDrawText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnMouseClick(int mouseButton, float x, float y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawText(float x, float y, string text, TextAnchor alignment = TextAnchor.UpperLeft) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawText(
      int offsetX,
      int offsetY,
      float x,
      float y,
      string text,
      TextAnchor alignment = TextAnchor.UpperLeft)
    {
      throw null;
    }

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

    public Color textColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public TextureCanvas canvas
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DefaultBackground() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupGraphic() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupText() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGraphic() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessMouseDown(int mouseButton) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimeCanvasBase() => throw null;

    [Serializable]
    public class Settings
    {
      public int x;
      public int y;
      public int width;
      public int height;
      public Rect rect;
      public float gridX;
      public float gridY;
      public bool autoResetBackground;
      public Font font;
      public int fontSize;
      [HideInInspector]
      public int version;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
