// Decompiled with JetBrains decompiler
// Type: LocalizationParameters02
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LocalizationParameters02 : MonoBehaviour
{
  public Property<string> NumDogsInternal;
  [SerializeField]
  private string numDogs;
  [SerializeField]
  private UIValue_ReadLocalizedString_Text UIBinder;
  private string LastNumDogs;
  public ContextBindRoot target;
  private DataContext paramData;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LocalizationParameters02() => throw null;
}
