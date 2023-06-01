// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadNumber_PathIndicator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadNumber_PathIndicator : UIValueNumberBinder
  {
    [Header("Path")]
    [SerializeField]
    [FormerlySerializedAs("pathIndicator")]
    private RectTransform _pathIndicator;
    [SerializeField]
    private UIPathContainer _pathContainer;
    [SerializeField]
    private UIPathContainer.UpdateMode _updateMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected IEnumerator Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnMappedNumberRangeChanged(
      UIValueNumberRange oldRange,
      bool shouldRedraw)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Evaluate(float value01) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadNumber_PathIndicator() => throw null;
  }
}
