// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_ReadEnum_ColorSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValue_ReadEnum_ColorSet : UIValueEnumBinder
  {
    [SerializeField]
    private TMP_Text targetText;
    [SerializeField]
    private float colorFadeDuration;
    [SerializeField]
    [Header("Choose Text to print for each Value")]
    private UIValue_ReadEnum_ColorSet.ColorEntry[] colorValues;
    [Header("Fallback - used when value is not mapped")]
    [SerializeField]
    private UIValue_ReadEnum_ColorSet.FallbackColorEntry fallbackValue;
    protected Dictionary<string, UIValue_ReadEnum_ColorSet.ColorEntry> valueMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateColor(Color color, bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadEnum_ColorSet() => throw null;

    [Serializable]
    public struct ColorEntry
    {
      private const string DEFAULT_ENUM_VALUE = "SET ME - Enum Value";
      public string enumValue;
      public Color textColor;

      public static UIValue_ReadEnum_ColorSet.ColorEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct FallbackColorEntry
    {
      public Color textColor;

      public static UIValue_ReadEnum_ColorSet.FallbackColorEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
