// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.DataBinding01_Intro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
