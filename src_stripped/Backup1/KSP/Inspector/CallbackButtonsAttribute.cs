// Decompiled with JetBrains decompiler
// Type: KSP.Inspector.CallbackButtonsAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
