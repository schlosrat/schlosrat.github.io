// Decompiled with JetBrains decompiler
// Type: UIValue_AnyTrue_Disable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.Generic;
using KSP.UI.Binding.Core;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UIValue_AnyTrue_Disable : UIValueBinder<List<IProperty<bool>>>
{
  [SerializeField]
  private GameObject target;
  [SerializeField]
  private bool activeIfNotFound;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void RedrawValue(bool instant = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetTargetActive(bool isBound) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIValue_AnyTrue_Disable() => throw null;
}
