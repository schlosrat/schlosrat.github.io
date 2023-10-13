// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValue_ReadEnum_MaterialSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValue_ReadEnum_MaterialSet : UIValueEnumBinder
  {
    [SerializeField]
    private Renderer[] targetRenderers;
    [SerializeField]
    private UIValue_ReadEnum_MaterialSet.MaterialEntry[] materialValues;
    [SerializeField]
    [Header("Fallback - used when value is not mapped")]
    private UIValue_ReadEnum_MaterialSet.MaterialEntry fallbackValue;
    protected Dictionary<string, UIValue_ReadEnum_MaterialSet.MaterialEntry> valueMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void PopulateValueMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMaterials(Material material, bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadEnum_MaterialSet() => throw null;

    [Serializable]
    public struct MaterialEntry
    {
      public string enumValue;
      public Material material;

      public static UIValue_ReadEnum_MaterialSet.MaterialEntry Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
