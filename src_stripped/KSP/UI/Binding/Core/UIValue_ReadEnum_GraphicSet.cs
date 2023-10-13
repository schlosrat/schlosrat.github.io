// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_ReadEnum_GraphicSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding.Core
{
  public class UIValue_ReadEnum_GraphicSet : UIValueEnumBinder
  {
    [SerializeField]
    private Graphic[] targetGraphics;
    [Tooltip("Sets the cross fade color value on the graphic")]
    [SerializeField]
    private bool updateColor;
    [Tooltip("Sets the raw color value on the graphic")]
    [SerializeField]
    private bool setGraphicColor;
    [SerializeField]
    private float colorFadeDuration;
    [Header("Choose Sprite/Color for each Value")]
    [SerializeField]
    private UIValue_ReadEnum_GraphicSet.GraphicEntry[] graphicValues;
    [Header("Fallback - used when value is not mapped")]
    [SerializeField]
    private UIValue_ReadEnum_GraphicSet.FallbackEntry fallbackValue;
    protected Dictionary<string, UIValue_ReadEnum_GraphicSet.GraphicEntry> valueMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSprite(Sprite sprite) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateColor(Color color, bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadEnum_GraphicSet() => throw null;

    [Serializable]
    public struct GraphicEntry
    {
      public string enumValue;
      public Sprite sprite;
      public Color color;

      public static UIValue_ReadEnum_GraphicSet.GraphicEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct FallbackEntry
    {
      public Sprite sprite;
      public Color color;

      public static UIValue_ReadEnum_GraphicSet.FallbackEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
