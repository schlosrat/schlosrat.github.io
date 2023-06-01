// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.ValidateObjectFieldAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector
{
  [AttributeUsage(AttributeTargets.Field, Inherited = true)]
  public class ValidateObjectFieldAttribute : PropertyAttribute
  {
    public System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ValidateObjectMode Mode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool AllowSceneObjects
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValidateObjectFieldAttribute(System.Type type, bool allowSceneObjects = true) => throw null;
  }
}
