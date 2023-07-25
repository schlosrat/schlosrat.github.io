// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.TypeInteropAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  public class TypeInteropAttribute : Attribute
  {
    public Type dataType;
    public string typeNickname;
    public string[] typeAltNames;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TypeInteropAttribute(Type dataType, string typeNickname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TypeInteropAttribute(Type dataType, string typeNickname, string[] typeAltNames) => throw null;
  }
}
