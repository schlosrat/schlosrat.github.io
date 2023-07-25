// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.IUIValueBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.UI.Binding.Core
{
  public interface IUIValueBinder : IUIValueBindable
  {
    bool IsBound { get; }

    Type BoundType { get; }

    bool IsConvertible { get; }

    object GetObject();

    T GetObjectAs<T>();

    bool TryGetObjectAs<T>(out T value);

    void SetObject(object value);

    void SetObjectAs<T>(T value);
  }
}
