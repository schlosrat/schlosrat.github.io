// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ReadObject_SetActive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  public class UIValue_ReadObject_SetActive : UIValueBinder
  {
    public GameObject target;
    [FormerlySerializedAs("enabledIfKeyFound")]
    [Space]
    public bool activeIfKeyFound;
    private bool queuedActive;
    private Coroutine queuedActiveCoroutine;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleIsBoundChanged(bool isBound) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DelayAction(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetQueuedActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_ReadObject_SetActive() => throw null;
  }
}
