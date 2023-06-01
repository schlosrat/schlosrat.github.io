// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.CallbackButtonsAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Inspector
{
  public class CallbackButtonsAttribute : PropertyAttribute
  {
    public string[] callbackPaths;
    public string[] buttonTexts;

    public bool customTitles
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallbackButtonsAttribute(params string[] callbackFuncs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallbackButtonsAttribute(string[] callbackFuncs, string[] titles) => throw null;
  }
}
