// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.KspEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
