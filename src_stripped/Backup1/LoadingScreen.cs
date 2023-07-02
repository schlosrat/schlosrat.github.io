// Decompiled with JetBrains decompiler
// Type: LoadingScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[Serializable]
public class LoadingScreen
{
  public bool Enabled;
  public bool FadeIn;
  public bool FadeOut;
  public CurtainContext Context;
  public List<string> ScreenKeys;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LoadingScreen() => throw null;
}
