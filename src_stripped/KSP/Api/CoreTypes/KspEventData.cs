// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.KspEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class KspEventData
  {
    public Dictionary<string, object> eventProperties;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object FindData(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T FindData<T>(string name = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KspEventData() => throw null;
  }
}
