// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_ListIndexConditional_Enable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI.Binding.Core;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  public class UIValue_ListIndexConditional_Enable : UIValueBinder<int>
  {
    [Header("Assign in Prefab")]
    public Behaviour target;
    public UIList_ListElement uIList_ListElement;
    private int elementIndex;
    [Space]
    [FormerlySerializedAs("enabledIfNotFound")]
    public bool activeIfNotFound;
    [FormerlySerializedAs("enabledIfValueTrue")]
    public bool activeIfValueTrue;
    private bool queuedEnabled;
    private Coroutine queuedEnabledCoroutine;

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
    public UIValue_ListIndexConditional_Enable() => throw null;
  }
}
