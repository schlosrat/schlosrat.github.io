// Decompiled with JetBrains decompiler
// Type: I2.Loc.TermData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
