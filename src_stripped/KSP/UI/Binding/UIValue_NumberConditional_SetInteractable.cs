// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_NumberConditional_SetInteractable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI.Binding
{
  public class UIValue_NumberConditional_SetInteractable : UIValueNumberBinderConditional
  {
    [Space]
    public Selectable target;
    public bool interactableIfValueTrue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleConditionalResult(bool result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_NumberConditional_SetInteractable() => throw null;
  }
}
