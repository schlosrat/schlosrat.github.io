// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_ReadEnum_SetInteractible
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
  public class UIValue_ReadEnum_SetInteractible : UIValueEnumBinder
  {
    public Selectable target;
    public CanvasGroup targetCanvasGroup;
    [SerializeField]
    [Header("Choose active for each object")]
    private UIValue_ReadEnum_SetInteractible.ObjectEntry[] objectValues;
    [Header("Fallback - used when value is not mapped")]
    [SerializeField]
    private UIValue_ReadEnum_SetInteractible.FallbackEntry fallbackValue;
    protected Dictionary<string, UIValue_ReadEnum_SetInteractible.ObjectEntry> valueMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadEnum_SetInteractible() => throw null;

    [Serializable]
    public struct ObjectEntry
    {
      public string enumValue;
      public bool interactible;

      public static UIValue_ReadEnum_SetInteractible.ObjectEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    [Serializable]
    public struct FallbackEntry
    {
      public bool interactible;

      public static UIValue_ReadEnum_SetInteractible.FallbackEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
