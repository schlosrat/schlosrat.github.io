// Decompiled with JetBrains decompiler
// Type: KSP.UI.TutorialsItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  [Serializable]
  public class TutorialsItems
  {
    public MainTutorialsItem[] Tutorials;
    public SubTutorialsItem[] Lessons;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TutorialsItems() => throw null;
  }
}
