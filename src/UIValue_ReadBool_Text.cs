// Decompiled with JetBrains decompiler
// Type: UIValue_ReadBool_Text
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[RequireComponent(typeof (TextMeshProUGUI))]
public class UIValue_ReadBool_Text : UIValueBinder<bool>
{
  [SerializeField]
  private TextMeshProUGUI _target;
  [SerializeField]
  private string _onText;
  [SerializeField]
  private string _offText;
  [SerializeField]
  private bool _treatTextAsLocKey;
  private ToStringDelegate _toStringDelegateFromMetadata;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void RedrawValue(bool instant = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void UpdateMetadataFromContext() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIValue_ReadBool_Text() => throw null;
}
