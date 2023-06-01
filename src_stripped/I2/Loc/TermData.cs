// Decompiled with JetBrains decompiler
// Type: I2.Loc.TermData
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
  [Serializable]
  public class TermData
  {
    public string Term;
    public eTermType TermType;
    [NonSerialized]
    public string Description;
    public string[] Languages;
    public byte[] Flags;
    [SerializeField]
    private string[] Languages_Touch;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetTranslation(int idx, string specialization = null, bool editMode = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTranslation(int idx, string translation, string specialization = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveSpecialization(string specialization) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveSpecialization(int idx, string specialization) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAutoTranslated(int idx, bool IsTouch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Validate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsTerm(string name, bool allowCategoryMistmatch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasSpecializations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<string> GetAllSpecializations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TermData() => throw null;
  }
}
