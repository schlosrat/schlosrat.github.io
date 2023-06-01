// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.DataBinding03_BusinessLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Iteration.Data;
using KSP.Iteration.Data.impl;
using KSP.Iteration.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI
{
  public class DataBinding03_BusinessLogic : MonoBehaviour
  {
    [SerializeField]
    private RectTransform healthUILocator;
    [SerializeField]
    private UIData_DemoHealth healthUIPrefab;
    private UIData_DemoHealth healthUIInstance;
    [Header("Health Data")]
    [SerializeField]
    private DemoHealth healthData;
    private Property<IDemoHealth> healthProperty;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MaxLives_ValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CurLives_ValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataBinding03_BusinessLogic() => throw null;
  }
}
