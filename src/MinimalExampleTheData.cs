// Decompiled with JetBrains decompiler
// Type: MinimalExampleTheData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MinimalExampleTheData : MonoBehaviour
{
  public ContextBindRoot bindRoot;
  private DataContext dataContext;
  private Property<int> intThing;
  private Property<string> stringThing;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MinimalExampleTheData() => throw null;
}
