// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadVector2Formatted_Field
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  [DisallowMultipleComponent]
  public class UIValue_ReadVector2Formatted_Field : UIValueBinder
  {
    [SerializeField]
    private TMP_InputField field;
    [SerializeField]
    private UIValue_ReadVector2Formatted_Field.VectorAxis axisToDisplay;
    private ToStringDelegate _toStringDelegateFromMetadata;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual string GetValueAsString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateMetadataFromContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadVector2Formatted_Field() => throw null;

    public enum VectorAxis
    {
      X,
      Y,
    }
  }
}
