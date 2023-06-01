// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.IUIValueBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
