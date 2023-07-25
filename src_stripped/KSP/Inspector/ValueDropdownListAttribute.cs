// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.ValueDropdownListAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
