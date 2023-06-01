// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_ReadEnum_GraphicSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    [SerializeField]
    private bool updateColor;
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
