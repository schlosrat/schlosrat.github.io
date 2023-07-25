// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_NumberConditional_SetActive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_NumberConditional_SetActive : UIValueNumberBinderConditional
  {
    [Space]
    public GameObject target;
    private bool queuedActive;
    private Coroutine queuedActiveCoroutine;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleConditionalResult(bool result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayAction(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetQueuedActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_NumberConditional_SetActive() => throw null;
  }
}
