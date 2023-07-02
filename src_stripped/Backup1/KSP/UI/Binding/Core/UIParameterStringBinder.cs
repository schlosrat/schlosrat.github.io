// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIParameterStringBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public abstract class UIParameterStringBinder : UIDataContextBindBase
  {
    [SerializeField]
    protected bool ShowEmptyKeys;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void HandleStringRebuild() => throw null;

    protected abstract string ParameterString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private string ParameterFormatString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private ISet<string> Keys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private IList<string> ParameterKeyOrder
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected override bool CheckSelfForContextProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Dictionary<string, object> KeyValueCache
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Dictionary<string, IProperty> KeyProperties
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Dictionary<IProperty, Action<object>> PropertyCallbacks
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIParameterStringBinder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CheckForKeyRebinds(IDataContextReadonly context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void RebuildOnValueChanged(string key, object newObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string BuildOutputString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddNewProperty(string key, IProperty newProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveOldProperty(string key, IProperty oldProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryCacheNewValue(string key, object newObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string ExtractParameterFormat(
      string paramString,
      ISet<string> keys,
      IList<string> keyOrder)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string FillParameterFormat(
      string formatString,
      IList<string> keyOrder,
      IDictionary<string, object> paramValues,
      bool showEmptyKeys)
    {
      throw null;
    }
  }
}
