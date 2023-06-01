// Decompiled with JetBrains decompiler
// Type: I2.Loc.LocalizationParamsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace I2.Loc
{
  public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
  {
    [SerializeField]
    public List<LocalizationParamsManager.ParamValue> _Params;
    public bool _IsGlobalManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetParameterValue(string ParamName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParameterValue(string ParamName, string ParamValue, bool localize = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoAutoRegister() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizationParamsManager() => throw null;

    [Serializable]
    public struct ParamValue
    {
      public string Name;
      public string Value;
    }
  }
}
