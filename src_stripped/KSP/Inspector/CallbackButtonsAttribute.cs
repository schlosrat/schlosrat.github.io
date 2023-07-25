// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.CallbackButtonsAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
