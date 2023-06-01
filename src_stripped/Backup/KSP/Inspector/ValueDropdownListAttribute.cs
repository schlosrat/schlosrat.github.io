// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.ValueDropdownListAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector
{
  [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
  public class ValueDropdownListAttribute : PropertyAttribute
  {
    public string sourceMemberName;
    public object[] extraValues;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueDropdownListAttribute(string source, params object[] extraValues) => throw null;
  }
}
