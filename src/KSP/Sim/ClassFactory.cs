// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ClassFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class ClassFactory : Attribute
  {
    public Type classType;
    public Type dataType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClassFactory(Type classType, Type dataType) => throw null;
  }
}
