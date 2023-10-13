// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.DataBinding01_Intro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.Generic;
using KSP.Iteration.Data;
using KSP.Iteration.Data.impl;
using KSP.Iteration.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI
{
  public class DataBinding01_Intro : MonoBehaviour
  {
    [SerializeField]
    private RectTransform entityUILocator;
    [SerializeField]
    private UIData_DemoEntity entityUIPrefab;
    private UIData_DemoEntity entityUIInstance;
    [SerializeField]
    [Header("Entity Data")]
    private DemoEntity entityData;
    private IProperty<IDemoEntity> entityProperty;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Guid_ValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Name_ValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Size_ValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataBinding01_Intro() => throw null;
  }
}
