// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.SimpleListTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI
{
  public class SimpleListTest : MonoBehaviour
  {
    public bool startMode;
    [Header("Prefabs")]
    public ContextBindRoot elementPrefab;
    [Header("BindRoots")]
    public ContextBindRoot uiRoot;
    public ContextBindRoot controls;
    private Property<bool> mode;
    public UIValueBinder modeControl;
    private DataContext data1;
    private DataContext data2;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateListBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleListTest() => throw null;
  }
}
