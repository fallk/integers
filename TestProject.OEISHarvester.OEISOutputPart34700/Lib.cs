using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A010734
{
public static readonly long[] Value={ 9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010734Inst : IEnumerable<long>
{
public static readonly long[] Value=A010734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010734.Bytes);
public long this[int i]=>Value[i];

public static A010734Inst Instance=new A010734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010733
{
public static readonly long[] Value={ 8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L,8L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010733Inst : IEnumerable<long>
{
public static readonly long[] Value=A010733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010733.Bytes);
public long this[int i]=>Value[i];

public static A010733Inst Instance=new A010733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010732
{
public static readonly long[] Value={ 8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010732Inst : IEnumerable<long>
{
public static readonly long[] Value=A010732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010732.Bytes);
public long this[int i]=>Value[i];

public static A010732Inst Instance=new A010732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010731
{
public static readonly long[] Value={ 8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010731Inst : IEnumerable<long>
{
public static readonly long[] Value=A010731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010731.Bytes);
public long this[int i]=>Value[i];

public static A010731Inst Instance=new A010731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010730
{
public static readonly long[] Value={ 7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010730Inst : IEnumerable<long>
{
public static readonly long[] Value=A010730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010730.Bytes);
public long this[int i]=>Value[i];

public static A010730Inst Instance=new A010730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010729
{
public static readonly long[] Value={ 7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010729Inst : IEnumerable<long>
{
public static readonly long[] Value=A010729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010729.Bytes);
public long this[int i]=>Value[i];

public static A010729Inst Instance=new A010729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010728
{
public static readonly long[] Value={ 7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010728Inst : IEnumerable<long>
{
public static readonly long[] Value=A010728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010728.Bytes);
public long this[int i]=>Value[i];

public static A010728Inst Instance=new A010728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010727
{
public static readonly long[] Value={ 7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010727Inst : IEnumerable<long>
{
public static readonly long[] Value=A010727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010727.Bytes);
public long this[int i]=>Value[i];

public static A010727Inst Instance=new A010727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010726
{
public static readonly long[] Value={ 6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010726Inst : IEnumerable<long>
{
public static readonly long[] Value=A010726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010726.Bytes);
public long this[int i]=>Value[i];

public static A010726Inst Instance=new A010726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010725
{
public static readonly long[] Value={ 6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010725Inst : IEnumerable<long>
{
public static readonly long[] Value=A010725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010725.Bytes);
public long this[int i]=>Value[i];

public static A010725Inst Instance=new A010725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010724
{
public static readonly long[] Value={ 6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010724Inst : IEnumerable<long>
{
public static readonly long[] Value=A010724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010724.Bytes);
public long this[int i]=>Value[i];

public static A010724Inst Instance=new A010724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010723
{
public static readonly long[] Value={ 6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010723Inst : IEnumerable<long>
{
public static readonly long[] Value=A010723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010723.Bytes);
public long this[int i]=>Value[i];

public static A010723Inst Instance=new A010723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010722
{
public static readonly long[] Value={ 6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010722Inst : IEnumerable<long>
{
public static readonly long[] Value=A010722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010722.Bytes);
public long this[int i]=>Value[i];

public static A010722Inst Instance=new A010722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010721
{
public static readonly long[] Value={ 5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L,5L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010721Inst : IEnumerable<long>
{
public static readonly long[] Value=A010721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010721.Bytes);
public long this[int i]=>Value[i];

public static A010721Inst Instance=new A010721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010720
{
public static readonly long[] Value={ 5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010720Inst : IEnumerable<long>
{
public static readonly long[] Value=A010720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010720.Bytes);
public long this[int i]=>Value[i];

public static A010720Inst Instance=new A010720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010719
{
public static readonly long[] Value={ 5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010719Inst : IEnumerable<long>
{
public static readonly long[] Value=A010719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010719.Bytes);
public long this[int i]=>Value[i];

public static A010719Inst Instance=new A010719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010718
{
public static readonly long[] Value={ 5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010718Inst : IEnumerable<long>
{
public static readonly long[] Value=A010718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010718.Bytes);
public long this[int i]=>Value[i];

public static A010718Inst Instance=new A010718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010701
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010701Inst : IEnumerable<long>
{
public static readonly long[] Value=A010701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010701.Bytes);
public long this[int i]=>Value[i];

public static A010701Inst Instance=new A010701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010700
{
public static readonly long[] Value={ 2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010700Inst : IEnumerable<long>
{
public static readonly long[] Value=A010700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010700.Bytes);
public long this[int i]=>Value[i];

public static A010700Inst Instance=new A010700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010699
{
public static readonly long[] Value={ 2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010699Inst : IEnumerable<long>
{
public static readonly long[] Value=A010699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010699.Bytes);
public long this[int i]=>Value[i];

public static A010699Inst Instance=new A010699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010698
{
public static readonly long[] Value={ 2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010698Inst : IEnumerable<long>
{
public static readonly long[] Value=A010698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010698.Bytes);
public long this[int i]=>Value[i];

public static A010698Inst Instance=new A010698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010697
{
public static readonly long[] Value={ 2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010697Inst : IEnumerable<long>
{
public static readonly long[] Value=A010697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010697.Bytes);
public long this[int i]=>Value[i];

public static A010697Inst Instance=new A010697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010696
{
public static readonly long[] Value={ 2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010696Inst : IEnumerable<long>
{
public static readonly long[] Value=A010696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010696.Bytes);
public long this[int i]=>Value[i];

public static A010696Inst Instance=new A010696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010695
{
public static readonly long[] Value={ 2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010695Inst : IEnumerable<long>
{
public static readonly long[] Value=A010695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010695.Bytes);
public long this[int i]=>Value[i];

public static A010695Inst Instance=new A010695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010694
{
public static readonly long[] Value={ 2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010694Inst : IEnumerable<long>
{
public static readonly long[] Value=A010694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010694.Bytes);
public long this[int i]=>Value[i];

public static A010694Inst Instance=new A010694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010693
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010693Inst : IEnumerable<long>
{
public static readonly long[] Value=A010693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010693.Bytes);
public long this[int i]=>Value[i];

public static A010693Inst Instance=new A010693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010692
{
public static readonly long[] Value={ 10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010692Inst : IEnumerable<long>
{
public static readonly long[] Value=A010692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010692.Bytes);
public long this[int i]=>Value[i];

public static A010692Inst Instance=new A010692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010691
{
public static readonly long[] Value={ 1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010691Inst : IEnumerable<long>
{
public static readonly long[] Value=A010691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010691.Bytes);
public long this[int i]=>Value[i];

public static A010691Inst Instance=new A010691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010690
{
public static readonly long[] Value={ 1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010690Inst : IEnumerable<long>
{
public static readonly long[] Value=A010690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010690.Bytes);
public long this[int i]=>Value[i];

public static A010690Inst Instance=new A010690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010689
{
public static readonly long[] Value={ 1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010689Inst : IEnumerable<long>
{
public static readonly long[] Value=A010689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010689.Bytes);
public long this[int i]=>Value[i];

public static A010689Inst Instance=new A010689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010688
{
public static readonly long[] Value={ 1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010688Inst : IEnumerable<long>
{
public static readonly long[] Value=A010688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010688.Bytes);
public long this[int i]=>Value[i];

public static A010688Inst Instance=new A010688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010687
{
public static readonly long[] Value={ 1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010687Inst : IEnumerable<long>
{
public static readonly long[] Value=A010687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010687.Bytes);
public long this[int i]=>Value[i];

public static A010687Inst Instance=new A010687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010686
{
public static readonly long[] Value={ 1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010686Inst : IEnumerable<long>
{
public static readonly long[] Value=A010686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010686.Bytes);
public long this[int i]=>Value[i];

public static A010686Inst Instance=new A010686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010669
{
public static readonly long[] Value={ 4L,6L,2L,6L,0L,6L,5L,0L,0L,9L,1L,8L,2L,7L,4L,1L,7L,9L,3L,0L,9L,2L,3L,6L,2L,3L,6L,9L,7L,9L,1L,2L,8L,4L,0L,9L,4L,6L,2L,2L,1L,9L,3L,8L,5L,3L,6L,1L,0L,0L,8L,6L,7L,2L,6L,5L,6L,2L,1L,8L,3L,7L,9L,2L,6L,2L,6L,5L,7L,0L,4L,2L,3L,8L,0L,0L,9L,4L,5L,7L,5L,8L,4L,8L,9L,8L,0L,1L,2L,4L,6L,8L,2L,6L,8L,7L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010669Inst : IEnumerable<long>
{
public static readonly long[] Value=A010669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010669.Bytes);
public long this[int i]=>Value[i];

public static A010669Inst Instance=new A010669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010668
{
public static readonly long[] Value={ 4L,6L,1L,0L,4L,3L,6L,2L,9L,2L,0L,5L,8L,4L,4L,6L,5L,6L,9L,6L,7L,4L,6L,9L,6L,0L,9L,7L,9L,4L,0L,6L,7L,4L,9L,3L,2L,4L,9L,8L,3L,7L,5L,5L,9L,9L,0L,1L,1L,8L,2L,6L,8L,5L,4L,9L,0L,3L,4L,5L,5L,1L,0L,6L,6L,0L,6L,6L,9L,2L,5L,4L,5L,4L,3L,0L,0L,7L,1L,8L,2L,0L,5L,1L,2L,6L,5L,9L,9L,6L,5L,5L,7L,6L,8L,4L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010668Inst : IEnumerable<long>
{
public static readonly long[] Value=A010668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010668.Bytes);
public long this[int i]=>Value[i];

public static A010668Inst Instance=new A010668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010667
{
public static readonly long[] Value={ 4L,5L,9L,4L,7L,0L,0L,8L,9L,2L,2L,0L,7L,0L,3L,9L,8L,0L,6L,0L,9L,4L,2L,9L,6L,4L,6L,4L,4L,2L,2L,3L,0L,8L,9L,8L,9L,1L,2L,0L,9L,7L,5L,4L,9L,2L,7L,1L,9L,0L,4L,9L,6L,9L,2L,2L,2L,1L,3L,9L,0L,6L,1L,2L,7L,2L,4L,9L,1L,9L,0L,9L,9L,8L,8L,0L,4L,7L,1L,1L,8L,9L,2L,6L,2L,7L,2L,5L,8L,4L,2L,6L,2L,3L,0L,2L,9L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010667Inst : IEnumerable<long>
{
public static readonly long[] Value=A010667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010667.Bytes);
public long this[int i]=>Value[i];

public static A010667Inst Instance=new A010667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010666
{
public static readonly long[] Value={ 4L,5L,7L,8L,8L,5L,6L,9L,7L,0L,2L,1L,3L,3L,2L,7L,4L,7L,1L,2L,3L,2L,1L,6L,8L,8L,4L,7L,7L,5L,8L,7L,0L,8L,0L,3L,5L,6L,6L,3L,6L,2L,7L,6L,8L,3L,1L,5L,1L,7L,2L,4L,2L,8L,8L,3L,9L,6L,2L,0L,8L,6L,9L,6L,2L,6L,2L,6L,9L,7L,1L,9L,6L,0L,9L,6L,8L,5L,6L,6L,0L,1L,7L,5L,0L,4L,3L,2L,6L,4L,4L,1L,2L,3L,6L,6L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010666Inst : IEnumerable<long>
{
public static readonly long[] Value=A010666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010666.Bytes);
public long this[int i]=>Value[i];

public static A010666Inst Instance=new A010666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010665
{
public static readonly long[] Value={ 4L,5L,6L,2L,9L,0L,2L,6L,3L,5L,3L,8L,6L,9L,6L,6L,7L,2L,7L,5L,6L,3L,9L,3L,5L,9L,0L,6L,3L,0L,0L,4L,2L,8L,1L,7L,7L,2L,5L,4L,2L,1L,7L,6L,3L,7L,2L,4L,4L,1L,0L,5L,5L,7L,9L,9L,0L,0L,1L,2L,3L,7L,1L,7L,3L,1L,5L,2L,3L,2L,8L,3L,7L,1L,6L,2L,8L,4L,4L,7L,8L,8L,7L,5L,7L,6L,9L,3L,3L,3L,7L,8L,1L,9L,1L,9L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010665Inst : IEnumerable<long>
{
public static readonly long[] Value=A010665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010665.Bytes);
public long this[int i]=>Value[i];

public static A010665Inst Instance=new A010665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010664
{
public static readonly long[] Value={ 4L,5L,4L,6L,8L,3L,5L,9L,4L,3L,7L,7L,6L,3L,4L,3L,8L,9L,3L,8L,0L,1L,9L,2L,1L,5L,4L,1L,3L,2L,1L,2L,8L,4L,7L,1L,6L,3L,5L,0L,6L,0L,9L,6L,9L,3L,1L,3L,7L,0L,2L,3L,8L,5L,4L,5L,6L,5L,8L,9L,2L,3L,6L,3L,4L,9L,1L,2L,0L,0L,2L,4L,2L,9L,7L,6L,3L,7L,0L,9L,0L,4L,5L,4L,3L,2L,6L,1L,2L,7L,6L,3L,6L,8L,0L,9L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010664Inst : IEnumerable<long>
{
public static readonly long[] Value=A010664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010664.Bytes);
public long this[int i]=>Value[i];

public static A010664Inst Instance=new A010664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010663
{
public static readonly long[] Value={ 4L,5L,3L,0L,6L,5L,4L,8L,9L,6L,0L,8L,3L,4L,9L,2L,7L,7L,7L,0L,3L,9L,2L,7L,7L,7L,0L,0L,4L,4L,0L,5L,8L,7L,0L,6L,6L,0L,6L,2L,0L,7L,9L,2L,1L,6L,9L,9L,9L,2L,3L,8L,2L,1L,6L,5L,1L,4L,9L,1L,2L,3L,8L,5L,3L,0L,6L,2L,5L,4L,6L,6L,0L,7L,0L,7L,7L,7L,0L,2L,1L,0L,7L,8L,9L,5L,7L,4L,1L,8L,5L,1L,2L,5L,0L,1L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010663Inst : IEnumerable<long>
{
public static readonly long[] Value=A010663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010663.Bytes);
public long this[int i]=>Value[i];

public static A010663Inst Instance=new A010663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010662
{
public static readonly long[] Value={ 4L,5L,1L,4L,3L,5L,7L,4L,3L,5L,4L,7L,4L,0L,0L,1L,3L,7L,9L,4L,4L,5L,0L,6L,2L,7L,0L,2L,6L,6L,4L,5L,8L,7L,1L,4L,1L,4L,5L,7L,5L,5L,5L,1L,9L,3L,7L,7L,3L,0L,8L,4L,9L,8L,7L,3L,6L,3L,8L,1L,0L,4L,5L,2L,5L,2L,1L,4L,8L,6L,5L,6L,7L,9L,4L,1L,7L,2L,5L,4L,4L,6L,0L,3L,0L,4L,9L,1L,0L,0L,4L,9L,3L,6L,1L,5L,7L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010662Inst : IEnumerable<long>
{
public static readonly long[] Value=A010662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010662.Bytes);
public long this[int i]=>Value[i];

public static A010662Inst Instance=new A010662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010661
{
public static readonly long[] Value={ 4L,4L,9L,7L,9L,4L,1L,4L,4L,5L,2L,7L,5L,4L,1L,4L,7L,9L,6L,3L,9L,1L,5L,6L,0L,7L,9L,4L,3L,0L,7L,3L,5L,7L,3L,2L,9L,6L,8L,3L,4L,5L,0L,6L,2L,6L,5L,0L,3L,3L,0L,8L,2L,3L,2L,0L,0L,9L,9L,3L,1L,2L,5L,5L,0L,1L,2L,7L,0L,5L,4L,0L,4L,2L,2L,4L,1L,8L,2L,5L,9L,1L,4L,8L,3L,9L,6L,2L,0L,5L,4L,4L,3L,3L,1L,0L,3L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010661Inst : IEnumerable<long>
{
public static readonly long[] Value=A010661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010661.Bytes);
public long this[int i]=>Value[i];

public static A010661Inst Instance=new A010661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010660
{
public static readonly long[] Value={ 4L,4L,8L,1L,4L,0L,4L,7L,4L,6L,5L,5L,7L,1L,6L,4L,7L,0L,8L,7L,4L,7L,4L,8L,2L,0L,1L,4L,0L,3L,8L,5L,7L,9L,4L,7L,1L,1L,6L,6L,7L,4L,9L,9L,9L,7L,3L,4L,2L,5L,7L,7L,6L,8L,4L,4L,1L,7L,6L,1L,2L,5L,0L,6L,2L,6L,2L,7L,2L,5L,6L,6L,4L,8L,6L,6L,4L,2L,9L,3L,5L,8L,4L,2L,3L,0L,1L,9L,9L,3L,3L,4L,6L,1L,3L,8L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010660Inst : IEnumerable<long>
{
public static readonly long[] Value=A010660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010660.Bytes);
public long this[int i]=>Value[i];

public static A010660Inst Instance=new A010660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010659
{
public static readonly long[] Value={ 4L,4L,6L,4L,7L,4L,5L,0L,9L,5L,5L,8L,4L,5L,3L,7L,6L,3L,3L,4L,3L,3L,9L,6L,8L,4L,8L,1L,0L,7L,4L,2L,6L,9L,4L,9L,5L,0L,6L,7L,9L,7L,9L,2L,4L,7L,4L,2L,1L,7L,3L,5L,7L,1L,6L,2L,8L,4L,6L,4L,1L,6L,3L,5L,4L,1L,3L,9L,8L,0L,8L,2L,5L,3L,4L,6L,3L,2L,2L,0L,1L,2L,0L,2L,7L,1L,8L,1L,8L,7L,3L,4L,9L,0L,7L,2L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010659Inst : IEnumerable<long>
{
public static readonly long[] Value=A010659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010659.Bytes);
public long this[int i]=>Value[i];

public static A010659Inst Instance=new A010659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010658
{
public static readonly long[] Value={ 4L,4L,4L,7L,9L,6L,0L,1L,8L,1L,1L,3L,8L,6L,3L,1L,0L,4L,2L,3L,3L,0L,7L,2L,6L,7L,5L,3L,4L,4L,4L,3L,1L,4L,3L,9L,3L,0L,3L,7L,3L,9L,8L,2L,5L,6L,1L,9L,3L,8L,4L,6L,1L,1L,1L,3L,9L,8L,6L,9L,1L,6L,1L,7L,3L,2L,0L,8L,0L,1L,9L,6L,6L,1L,6L,5L,9L,5L,1L,9L,4L,8L,9L,7L,9L,5L,1L,6L,1L,0L,8L,9L,6L,3L,2L,5L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010658Inst : IEnumerable<long>
{
public static readonly long[] Value=A010658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010658.Bytes);
public long this[int i]=>Value[i];

public static A010658Inst Instance=new A010658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010657
{
public static readonly long[] Value={ 4L,4L,3L,1L,0L,4L,7L,6L,2L,1L,6L,9L,3L,6L,3L,4L,1L,5L,9L,2L,2L,9L,4L,5L,3L,1L,5L,5L,9L,8L,8L,6L,8L,7L,4L,5L,8L,9L,2L,4L,6L,4L,8L,8L,6L,8L,8L,5L,2L,2L,3L,4L,6L,6L,3L,0L,6L,1L,9L,4L,8L,8L,7L,4L,6L,5L,6L,2L,6L,2L,8L,4L,8L,7L,9L,6L,3L,8L,0L,4L,7L,4L,0L,1L,5L,0L,4L,4L,5L,4L,4L,6L,4L,7L,9L,8L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010657Inst : IEnumerable<long>
{
public static readonly long[] Value=A010657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010657.Bytes);
public long this[int i]=>Value[i];

public static A010657Inst Instance=new A010657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010656
{
public static readonly long[] Value={ 4L,4L,1L,4L,0L,0L,4L,9L,6L,2L,4L,4L,2L,1L,0L,3L,7L,7L,2L,4L,5L,1L,6L,4L,1L,4L,3L,8L,6L,5L,3L,3L,5L,1L,3L,2L,2L,3L,0L,5L,2L,7L,6L,5L,3L,2L,0L,7L,8L,5L,6L,3L,8L,8L,5L,6L,1L,7L,8L,8L,9L,3L,6L,6L,4L,1L,7L,0L,7L,2L,3L,3L,5L,0L,8L,8L,2L,5L,9L,6L,5L,9L,9L,7L,0L,1L,6L,3L,2L,9L,9L,8L,0L,2L,5L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010656Inst : IEnumerable<long>
{
public static readonly long[] Value=A010656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010656.Bytes);
public long this[int i]=>Value[i];

public static A010656Inst Instance=new A010656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010655
{
public static readonly long[] Value={ 4L,3L,9L,6L,8L,2L,9L,6L,7L,2L,1L,5L,8L,1L,7L,9L,2L,7L,5L,8L,0L,9L,2L,1L,0L,7L,9L,2L,5L,3L,8L,4L,4L,1L,8L,6L,0L,5L,9L,8L,8L,8L,3L,7L,5L,4L,0L,8L,6L,5L,8L,1L,9L,7L,3L,3L,1L,5L,7L,0L,9L,6L,2L,3L,4L,1L,0L,6L,3L,6L,3L,3L,4L,0L,8L,4L,7L,1L,1L,9L,7L,6L,0L,8L,6L,7L,0L,7L,9L,2L,9L,2L,1L,6L,1L,7L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010655Inst : IEnumerable<long>
{
public static readonly long[] Value=A010655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010655.Bytes);
public long this[int i]=>Value[i];

public static A010655Inst Instance=new A010655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010654
{
public static readonly long[] Value={ 4L,3L,7L,9L,5L,1L,9L,1L,3L,9L,8L,8L,7L,8L,8L,9L,2L,6L,5L,7L,1L,9L,8L,0L,3L,5L,3L,1L,3L,7L,2L,4L,7L,5L,7L,1L,9L,9L,8L,0L,0L,0L,2L,4L,7L,9L,6L,6L,9L,5L,6L,4L,4L,5L,0L,3L,2L,5L,4L,6L,9L,6L,6L,3L,1L,3L,2L,9L,4L,4L,8L,2L,0L,7L,6L,7L,7L,4L,4L,8L,9L,7L,1L,5L,8L,8L,4L,6L,0L,4L,2L,9L,4L,0L,2L,0L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010654Inst : IEnumerable<long>
{
public static readonly long[] Value=A010654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010654.Bytes);
public long this[int i]=>Value[i];

public static A010654Inst Instance=new A010654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010653
{
public static readonly long[] Value={ 4L,3L,6L,2L,0L,7L,0L,6L,7L,1L,4L,5L,4L,8L,3L,7L,5L,6L,4L,7L,1L,3L,9L,7L,9L,4L,7L,6L,6L,7L,5L,9L,4L,7L,8L,1L,0L,6L,9L,2L,4L,9L,3L,1L,9L,5L,7L,5L,0L,3L,1L,2L,0L,1L,5L,4L,2L,7L,8L,2L,9L,5L,8L,2L,8L,8L,4L,1L,3L,6L,0L,3L,7L,1L,3L,0L,1L,9L,3L,8L,0L,6L,2L,7L,3L,6L,1L,7L,9L,7L,1L,6L,7L,7L,3L,0L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010653Inst : IEnumerable<long>
{
public static readonly long[] Value=A010653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010653.Bytes);
public long this[int i]=>Value[i];

public static A010653Inst Instance=new A010653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010652
{
public static readonly long[] Value={ 4L,3L,4L,4L,4L,8L,1L,4L,8L,5L,7L,6L,8L,6L,1L,1L,9L,0L,1L,7L,2L,2L,3L,5L,0L,5L,4L,6L,0L,5L,4L,5L,7L,5L,9L,2L,7L,1L,9L,3L,6L,0L,4L,2L,5L,3L,8L,0L,8L,8L,8L,4L,8L,2L,0L,0L,0L,1L,5L,7L,0L,5L,3L,9L,7L,9L,9L,3L,7L,4L,7L,9L,4L,1L,1L,1L,3L,0L,3L,9L,7L,4L,1L,5L,5L,7L,3L,6L,7L,5L,6L,3L,8L,4L,3L,7L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010652Inst : IEnumerable<long>
{
public static readonly long[] Value=A010652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010652.Bytes);
public long this[int i]=>Value[i];

public static A010652Inst Instance=new A010652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010651
{
public static readonly long[] Value={ 4L,3L,2L,6L,7L,4L,8L,7L,1L,0L,9L,2L,2L,2L,2L,5L,1L,4L,6L,9L,6L,4L,9L,1L,4L,9L,3L,2L,3L,4L,0L,3L,2L,8L,7L,6L,5L,1L,7L,5L,6L,0L,7L,7L,6L,0L,4L,9L,8L,0L,5L,1L,7L,3L,2L,6L,3L,9L,2L,4L,8L,5L,8L,3L,6L,2L,5L,0L,6L,2L,7L,9L,0L,4L,8L,9L,9L,9L,2L,0L,1L,9L,5L,6L,4L,2L,6L,6L,4L,3L,9L,1L,1L,6L,9L,3L,5L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010651Inst : IEnumerable<long>
{
public static readonly long[] Value=A010651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010651.Bytes);
public long this[int i]=>Value[i];

public static A010651Inst Instance=new A010651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010650
{
public static readonly long[] Value={ 4L,3L,0L,8L,8L,6L,9L,3L,8L,0L,0L,6L,3L,7L,6L,7L,4L,4L,3L,5L,1L,8L,5L,8L,7L,1L,3L,3L,0L,3L,8L,7L,0L,0L,9L,9L,0L,5L,1L,8L,6L,8L,9L,8L,8L,4L,3L,8L,4L,2L,1L,7L,1L,6L,4L,9L,7L,8L,4L,7L,1L,0L,1L,2L,6L,9L,2L,8L,2L,2L,2L,1L,3L,2L,9L,6L,6L,8L,1L,6L,0L,0L,3L,7L,0L,8L,8L,3L,0L,0L,7L,0L,8L,6L,4L,8L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010650Inst : IEnumerable<long>
{
public static readonly long[] Value=A010650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010650.Bytes);
public long this[int i]=>Value[i];

public static A010650Inst Instance=new A010650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010649
{
public static readonly long[] Value={ 4L,2L,9L,0L,8L,4L,0L,4L,2L,7L,0L,2L,6L,2L,0L,7L,1L,1L,1L,6L,2L,8L,3L,1L,4L,2L,3L,3L,4L,5L,4L,2L,7L,0L,9L,4L,0L,7L,5L,5L,1L,9L,7L,6L,7L,3L,0L,3L,4L,3L,0L,6L,8L,3L,4L,4L,7L,4L,5L,8L,7L,3L,8L,8L,0L,4L,8L,5L,0L,9L,0L,7L,9L,1L,2L,7L,9L,7L,0L,9L,4L,7L,2L,1L,0L,4L,8L,7L,7L,7L,7L,6L,0L,2L,7L,6L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010649Inst : IEnumerable<long>
{
public static readonly long[] Value=A010649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010649.Bytes);
public long this[int i]=>Value[i];

public static A010649Inst Instance=new A010649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010648
{
public static readonly long[] Value={ 4L,2L,7L,2L,6L,5L,8L,6L,8L,1L,6L,9L,7L,9L,1L,6L,8L,2L,4L,9L,8L,7L,7L,2L,8L,5L,2L,9L,2L,4L,2L,4L,9L,0L,8L,5L,8L,9L,1L,6L,7L,0L,8L,8L,8L,0L,1L,5L,4L,8L,7L,2L,9L,0L,7L,1L,0L,7L,8L,5L,5L,2L,3L,0L,1L,9L,1L,7L,9L,2L,2L,7L,1L,6L,3L,6L,6L,2L,5L,3L,3L,7L,2L,2L,6L,9L,7L,3L,4L,1L,1L,5L,6L,0L,0L,5L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010648Inst : IEnumerable<long>
{
public static readonly long[] Value=A010648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010648.Bytes);
public long this[int i]=>Value[i];

public static A010648Inst Instance=new A010648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010647
{
public static readonly long[] Value={ 4L,2L,5L,4L,3L,2L,0L,8L,6L,5L,1L,1L,5L,0L,0L,5L,7L,7L,6L,0L,7L,3L,3L,6L,8L,6L,6L,2L,1L,2L,4L,4L,1L,6L,7L,0L,2L,9L,6L,0L,4L,0L,7L,8L,8L,7L,1L,1L,2L,2L,7L,3L,9L,3L,3L,3L,0L,3L,6L,9L,4L,4L,7L,1L,8L,1L,7L,7L,8L,4L,8L,1L,4L,9L,8L,6L,9L,1L,5L,2L,6L,1L,4L,8L,8L,8L,9L,0L,1L,8L,5L,6L,2L,8L,9L,3L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010647Inst : IEnumerable<long>
{
public static readonly long[] Value=A010647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010647.Bytes);
public long this[int i]=>Value[i];

public static A010647Inst Instance=new A010647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010646
{
public static readonly long[] Value={ 4L,2L,3L,5L,8L,2L,3L,5L,8L,4L,2L,5L,4L,8L,9L,3L,1L,6L,3L,8L,9L,8L,1L,5L,2L,4L,2L,4L,2L,1L,7L,9L,0L,1L,9L,2L,6L,9L,8L,7L,6L,1L,0L,3L,9L,6L,2L,1L,4L,7L,2L,2L,6L,9L,7L,3L,6L,5L,1L,6L,4L,9L,1L,3L,9L,4L,3L,7L,8L,5L,8L,0L,7L,5L,4L,6L,8L,2L,0L,3L,2L,4L,6L,1L,8L,0L,0L,7L,4L,2L,1L,8L,8L,3L,5L,5L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010646Inst : IEnumerable<long>
{
public static readonly long[] Value=A010646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010646.Bytes);
public long this[int i]=>Value[i];

public static A010646Inst Instance=new A010646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010645
{
public static readonly long[] Value={ 4L,2L,1L,7L,1L,6L,3L,3L,2L,6L,5L,0L,8L,7L,4L,6L,2L,1L,4L,2L,2L,8L,5L,4L,8L,7L,5L,7L,0L,3L,0L,3L,6L,4L,7L,1L,6L,2L,0L,0L,5L,8L,2L,8L,5L,7L,5L,4L,7L,1L,9L,1L,4L,8L,1L,3L,9L,8L,0L,1L,5L,4L,0L,4L,3L,1L,7L,3L,8L,2L,5L,7L,3L,8L,2L,5L,5L,0L,2L,0L,5L,5L,0L,7L,7L,2L,6L,6L,0L,3L,8L,6L,7L,7L,7L,2L,1L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010645Inst : IEnumerable<long>
{
public static readonly long[] Value=A010645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010645.Bytes);
public long this[int i]=>Value[i];

public static A010645Inst Instance=new A010645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010644
{
public static readonly long[] Value={ 4L,1L,9L,8L,3L,3L,6L,4L,5L,3L,8L,0L,8L,4L,0L,7L,7L,2L,2L,1L,5L,3L,2L,9L,8L,5L,9L,2L,6L,6L,5L,2L,2L,0L,1L,5L,0L,0L,9L,5L,0L,6L,7L,9L,2L,3L,5L,7L,0L,2L,6L,0L,7L,7L,8L,2L,7L,2L,1L,5L,9L,2L,5L,2L,3L,7L,4L,8L,7L,4L,1L,0L,1L,0L,0L,5L,1L,6L,3L,3L,7L,0L,6L,5L,4L,2L,2L,0L,8L,7L,1L,9L,4L,3L,6L,1L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010644Inst : IEnumerable<long>
{
public static readonly long[] Value=A010644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010644.Bytes);
public long this[int i]=>Value[i];

public static A010644Inst Instance=new A010644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010643
{
public static readonly long[] Value={ 4L,1L,7L,9L,3L,3L,9L,1L,9L,6L,3L,8L,1L,2L,3L,1L,8L,9L,2L,0L,5L,6L,3L,7L,6L,3L,4L,8L,9L,0L,8L,7L,6L,7L,7L,6L,8L,0L,1L,3L,9L,9L,4L,4L,3L,8L,2L,5L,8L,4L,3L,3L,4L,4L,2L,5L,2L,3L,1L,2L,2L,4L,1L,4L,4L,1L,1L,5L,7L,9L,5L,7L,8L,8L,9L,3L,8L,0L,6L,3L,1L,6L,6L,7L,7L,4L,5L,1L,7L,8L,6L,7L,1L,6L,8L,3L,8L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010643Inst : IEnumerable<long>
{
public static readonly long[] Value=A010643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010643.Bytes);
public long this[int i]=>Value[i];

public static A010643Inst Instance=new A010643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010642
{
public static readonly long[] Value={ 4L,1L,6L,0L,1L,6L,7L,6L,4L,6L,1L,0L,3L,8L,0L,8L,2L,2L,9L,0L,6L,0L,1L,1L,3L,6L,4L,8L,7L,1L,5L,7L,7L,0L,7L,7L,2L,6L,7L,5L,6L,1L,0L,6L,8L,0L,7L,4L,6L,5L,2L,4L,2L,1L,9L,3L,9L,5L,1L,8L,2L,1L,6L,0L,4L,0L,0L,2L,1L,2L,6L,2L,2L,7L,9L,4L,5L,3L,7L,5L,4L,7L,2L,1L,2L,1L,1L,3L,2L,7L,3L,5L,8L,1L,5L,1L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010642Inst : IEnumerable<long>
{
public static readonly long[] Value=A010642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010642.Bytes);
public long this[int i]=>Value[i];

public static A010642Inst Instance=new A010642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010641
{
public static readonly long[] Value={ 4L,1L,4L,0L,8L,1L,7L,7L,4L,9L,4L,2L,2L,8L,5L,3L,2L,5L,0L,0L,0L,4L,5L,1L,8L,8L,0L,9L,3L,2L,5L,5L,7L,1L,8L,3L,8L,1L,5L,9L,3L,5L,0L,7L,9L,0L,7L,3L,2L,0L,9L,1L,6L,9L,7L,1L,8L,3L,4L,9L,2L,8L,2L,9L,7L,7L,9L,4L,7L,5L,6L,5L,9L,8L,7L,2L,3L,9L,6L,0L,3L,3L,4L,2L,6L,3L,9L,5L,7L,4L,1L,8L,7L,6L,5L,7L,9L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010641Inst : IEnumerable<long>
{
public static readonly long[] Value=A010641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010641.Bytes);
public long this[int i]=>Value[i];

public static A010641Inst Instance=new A010641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010640
{
public static readonly long[] Value={ 4L,1L,2L,1L,2L,8L,5L,2L,9L,9L,8L,0L,8L,5L,5L,6L,8L,1L,9L,3L,7L,7L,4L,8L,9L,1L,1L,7L,3L,6L,6L,4L,1L,3L,3L,5L,0L,8L,1L,0L,5L,2L,2L,7L,0L,7L,0L,3L,6L,0L,5L,9L,9L,3L,6L,0L,2L,5L,3L,3L,3L,6L,8L,5L,9L,0L,9L,5L,1L,3L,6L,8L,7L,5L,2L,7L,6L,6L,3L,4L,1L,5L,2L,0L,1L,4L,7L,7L,3L,6L,5L,6L,4L,1L,2L,8L,3L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010640Inst : IEnumerable<long>
{
public static readonly long[] Value=A010640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010640.Bytes);
public long this[int i]=>Value[i];

public static A010640Inst Instance=new A010640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010639
{
public static readonly long[] Value={ 4L,1L,0L,1L,5L,6L,5L,9L,2L,9L,7L,0L,2L,3L,4L,7L,5L,2L,1L,8L,4L,7L,1L,8L,4L,9L,8L,2L,1L,4L,1L,8L,7L,4L,8L,0L,7L,6L,5L,0L,1L,0L,5L,8L,4L,6L,7L,8L,6L,1L,6L,8L,8L,1L,1L,1L,7L,8L,9L,8L,1L,1L,9L,1L,3L,7L,1L,3L,7L,0L,7L,2L,5L,9L,6L,5L,3L,6L,0L,8L,5L,6L,9L,1L,2L,0L,6L,6L,5L,8L,4L,2L,5L,6L,5L,7L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010639Inst : IEnumerable<long>
{
public static readonly long[] Value=A010639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010639.Bytes);
public long this[int i]=>Value[i];

public static A010639Inst Instance=new A010639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010638
{
public static readonly long[] Value={ 4L,0L,8L,1L,6L,5L,5L,1L,0L,1L,9L,1L,7L,3L,4L,8L,0L,7L,0L,5L,6L,5L,7L,8L,1L,6L,1L,3L,2L,2L,6L,0L,4L,2L,9L,6L,5L,2L,0L,7L,2L,7L,6L,5L,8L,2L,4L,5L,3L,4L,3L,8L,9L,5L,5L,2L,0L,9L,3L,3L,9L,4L,0L,1L,3L,0L,2L,6L,5L,2L,7L,2L,8L,2L,2L,3L,3L,5L,6L,9L,6L,4L,4L,6L,3L,8L,1L,1L,3L,0L,9L,8L,7L,5L,0L,9L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010638Inst : IEnumerable<long>
{
public static readonly long[] Value=A010638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010638.Bytes);
public long this[int i]=>Value[i];

public static A010638Inst Instance=new A010638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010637
{
public static readonly long[] Value={ 4L,0L,6L,1L,5L,4L,8L,1L,0L,0L,4L,4L,5L,6L,7L,9L,7L,8L,9L,0L,8L,2L,0L,6L,1L,5L,8L,5L,7L,9L,9L,2L,2L,5L,9L,6L,6L,4L,1L,9L,0L,5L,8L,5L,3L,7L,6L,6L,8L,8L,5L,9L,9L,8L,0L,6L,3L,4L,5L,0L,4L,0L,3L,5L,4L,1L,4L,1L,4L,2L,2L,0L,0L,6L,9L,0L,3L,3L,2L,7L,2L,2L,1L,9L,1L,5L,3L,6L,9L,2L,6L,0L,9L,5L,0L,3L,0L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010637Inst : IEnumerable<long>
{
public static readonly long[] Value=A010637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010637.Bytes);
public long this[int i]=>Value[i];

public static A010637Inst Instance=new A010637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010636
{
public static readonly long[] Value={ 4L,0L,4L,1L,2L,4L,0L,0L,2L,0L,6L,2L,2L,1L,9L,0L,2L,7L,0L,8L,0L,1L,9L,9L,0L,0L,7L,4L,6L,3L,4L,2L,6L,2L,1L,1L,3L,3L,7L,2L,3L,0L,9L,8L,1L,8L,4L,4L,9L,8L,2L,3L,6L,9L,2L,9L,8L,8L,8L,2L,4L,5L,7L,4L,9L,2L,1L,2L,2L,1L,6L,4L,0L,0L,9L,2L,4L,8L,8L,7L,7L,5L,5L,1L,5L,7L,4L,3L,1L,0L,9L,0L,4L,0L,1L,1L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010636Inst : IEnumerable<long>
{
public static readonly long[] Value=A010636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010636.Bytes);
public long this[int i]=>Value[i];

public static A010636Inst Instance=new A010636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010635
{
public static readonly long[] Value={ 4L,0L,2L,0L,7L,2L,5L,7L,5L,8L,5L,8L,9L,0L,5L,7L,9L,7L,6L,0L,8L,6L,5L,4L,4L,5L,1L,4L,4L,3L,1L,4L,8L,8L,7L,5L,9L,8L,0L,6L,9L,8L,6L,6L,4L,4L,0L,1L,0L,5L,2L,0L,4L,8L,9L,2L,8L,8L,1L,7L,1L,3L,4L,9L,1L,1L,2L,7L,8L,6L,9L,8L,3L,5L,8L,9L,0L,2L,7L,3L,9L,7L,7L,7L,4L,4L,7L,7L,8L,0L,9L,7L,1L,0L,9L,6L,7L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010635Inst : IEnumerable<long>
{
public static readonly long[] Value=A010635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010635.Bytes);
public long this[int i]=>Value[i];

public static A010635Inst Instance=new A010635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010634
{
public static readonly long[] Value={ 3L,9L,7L,9L,0L,5L,7L,2L,0L,7L,8L,9L,6L,3L,9L,1L,8L,5L,9L,6L,6L,4L,5L,2L,7L,9L,8L,7L,7L,4L,8L,7L,6L,5L,5L,7L,8L,4L,8L,4L,2L,7L,2L,0L,2L,1L,7L,3L,6L,3L,2L,9L,2L,5L,2L,4L,3L,2L,9L,0L,8L,6L,7L,8L,7L,2L,4L,6L,0L,0L,6L,0L,5L,3L,1L,1L,1L,7L,1L,8L,2L,8L,3L,5L,3L,1L,0L,0L,3L,2L,1L,5L,7L,3L,8L,5L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010634Inst : IEnumerable<long>
{
public static readonly long[] Value=A010634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010634.Bytes);
public long this[int i]=>Value[i];

public static A010634Inst Instance=new A010634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010633
{
public static readonly long[] Value={ 3L,9L,5L,7L,8L,9L,1L,6L,0L,9L,6L,8L,0L,4L,0L,5L,4L,7L,8L,9L,3L,6L,1L,4L,8L,4L,7L,9L,0L,1L,9L,4L,2L,6L,1L,0L,6L,1L,7L,3L,2L,4L,9L,5L,8L,7L,1L,9L,4L,7L,1L,7L,9L,3L,0L,7L,9L,3L,8L,9L,6L,3L,4L,4L,4L,4L,2L,2L,0L,4L,5L,5L,2L,8L,4L,0L,0L,8L,0L,3L,8L,8L,0L,9L,6L,2L,3L,6L,7L,8L,6L,1L,9L,2L,3L,8L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010633Inst : IEnumerable<long>
{
public static readonly long[] Value=A010633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010633.Bytes);
public long this[int i]=>Value[i];

public static A010633Inst Instance=new A010633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010632
{
public static readonly long[] Value={ 3L,9L,3L,6L,4L,9L,7L,1L,8L,3L,1L,0L,2L,1L,7L,3L,1L,9L,5L,8L,2L,8L,8L,5L,1L,3L,7L,3L,0L,3L,2L,1L,4L,7L,8L,5L,8L,6L,3L,8L,5L,5L,5L,9L,4L,5L,1L,8L,9L,8L,9L,4L,8L,2L,6L,9L,8L,3L,3L,5L,7L,9L,1L,0L,5L,8L,2L,3L,8L,1L,0L,2L,5L,5L,9L,4L,1L,1L,1L,6L,3L,4L,5L,0L,9L,3L,8L,9L,2L,5L,0L,6L,7L,5L,8L,8L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010632Inst : IEnumerable<long>
{
public static readonly long[] Value=A010632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010632.Bytes);
public long this[int i]=>Value[i];

public static A010632Inst Instance=new A010632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010631
{
public static readonly long[] Value={ 3L,9L,1L,4L,8L,6L,7L,6L,4L,1L,1L,6L,8L,8L,6L,3L,5L,9L,5L,4L,2L,4L,9L,3L,6L,0L,6L,0L,4L,1L,1L,6L,7L,1L,4L,2L,4L,9L,3L,1L,6L,8L,2L,2L,1L,4L,3L,4L,7L,4L,2L,2L,9L,1L,7L,6L,5L,5L,9L,3L,8L,1L,6L,0L,5L,1L,8L,9L,6L,7L,9L,7L,6L,5L,8L,1L,6L,1L,1L,6L,7L,0L,3L,5L,7L,7L,2L,3L,8L,8L,5L,3L,5L,1L,8L,8L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010631Inst : IEnumerable<long>
{
public static readonly long[] Value=A010631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010631.Bytes);
public long this[int i]=>Value[i];

public static A010631Inst Instance=new A010631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010630
{
public static readonly long[] Value={ 3L,8L,9L,2L,9L,9L,6L,4L,1L,5L,8L,7L,3L,2L,6L,0L,5L,4L,6L,4L,6L,1L,4L,8L,4L,7L,5L,7L,1L,4L,9L,7L,8L,9L,2L,4L,3L,9L,9L,2L,7L,8L,9L,5L,7L,7L,1L,3L,9L,2L,3L,4L,8L,2L,8L,0L,3L,0L,9L,0L,4L,7L,8L,3L,5L,1L,7L,7L,4L,5L,8L,8L,8L,3L,3L,7L,0L,8L,8L,2L,8L,9L,2L,3L,9L,9L,9L,4L,5L,5L,9L,1L,1L,2L,0L,4L,6L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010630Inst : IEnumerable<long>
{
public static readonly long[] Value=A010630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010630.Bytes);
public long this[int i]=>Value[i];

public static A010630Inst Instance=new A010630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010629
{
public static readonly long[] Value={ 3L,8L,7L,0L,8L,7L,6L,6L,4L,0L,6L,2L,7L,7L,9L,6L,7L,4L,7L,2L,1L,3L,3L,1L,4L,2L,2L,6L,3L,4L,4L,8L,0L,1L,7L,4L,0L,9L,9L,1L,3L,4L,0L,4L,6L,2L,3L,7L,3L,9L,8L,1L,8L,4L,7L,0L,1L,0L,0L,7L,4L,5L,7L,6L,1L,1L,4L,1L,0L,9L,8L,3L,1L,6L,1L,1L,8L,9L,0L,5L,1L,8L,9L,7L,7L,5L,0L,8L,2L,0L,0L,8L,0L,1L,0L,5L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010629Inst : IEnumerable<long>
{
public static readonly long[] Value=A010629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010629.Bytes);
public long this[int i]=>Value[i];

public static A010629Inst Instance=new A010629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010628
{
public static readonly long[] Value={ 3L,8L,4L,8L,5L,0L,1L,1L,3L,1L,2L,7L,6L,8L,0L,5L,0L,6L,8L,7L,0L,2L,2L,9L,0L,2L,5L,9L,5L,2L,5L,0L,2L,5L,3L,1L,7L,1L,2L,8L,4L,0L,5L,5L,2L,2L,7L,7L,5L,4L,6L,1L,2L,1L,0L,6L,2L,6L,7L,9L,7L,7L,2L,0L,1L,3L,6L,7L,6L,8L,9L,1L,8L,2L,7L,6L,9L,2L,3L,4L,5L,6L,9L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010628Inst : IEnumerable<long>
{
public static readonly long[] Value=A010628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010628.Bytes);
public long this[int i]=>Value[i];

public static A010628Inst Instance=new A010628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010627
{
public static readonly long[] Value={ 3L,8L,2L,5L,8L,6L,2L,3L,6L,5L,5L,4L,4L,7L,7L,8L,2L,0L,2L,3L,9L,8L,2L,3L,3L,6L,7L,9L,0L,9L,7L,5L,2L,0L,5L,6L,5L,7L,2L,4L,8L,7L,8L,1L,0L,0L,6L,9L,1L,7L,5L,1L,5L,3L,2L,4L,2L,1L,2L,9L,5L,2L,8L,0L,8L,9L,4L,4L,6L,8L,5L,5L,2L,3L,5L,8L,4L,6L,1L,5L,1L,2L,0L,1L,5L,0L,5L,0L,8L,8L,2L,9L,5L,4L,5L,7L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010627Inst : IEnumerable<long>
{
public static readonly long[] Value=A010627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010627.Bytes);
public long this[int i]=>Value[i];

public static A010627Inst Instance=new A010627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010626
{
public static readonly long[] Value={ 3L,8L,0L,2L,9L,5L,2L,4L,6L,0L,7L,6L,1L,3L,9L,1L,6L,1L,8L,5L,4L,6L,7L,3L,5L,4L,7L,3L,8L,4L,8L,7L,1L,5L,1L,9L,7L,2L,8L,8L,7L,1L,5L,5L,9L,4L,9L,1L,1L,3L,5L,4L,9L,6L,9L,4L,5L,9L,9L,4L,9L,7L,3L,0L,3L,9L,1L,6L,0L,1L,3L,2L,5L,4L,0L,7L,6L,7L,1L,6L,5L,6L,7L,8L,5L,9L,9L,6L,4L,6L,3L,5L,5L,4L,1L,0L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010626Inst : IEnumerable<long>
{
public static readonly long[] Value=A010626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010626.Bytes);
public long this[int i]=>Value[i];

public static A010626Inst Instance=new A010626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010625
{
public static readonly long[] Value={ 3L,7L,7L,9L,7L,6L,3L,1L,4L,9L,6L,8L,4L,6L,1L,9L,4L,9L,4L,3L,0L,1L,6L,3L,1L,8L,2L,1L,8L,3L,4L,6L,8L,5L,0L,5L,1L,7L,1L,0L,7L,5L,4L,3L,9L,4L,1L,0L,4L,5L,2L,3L,9L,4L,0L,2L,4L,5L,9L,2L,5L,3L,3L,6L,4L,6L,5L,8L,9L,9L,0L,2L,9L,5L,4L,1L,8L,7L,8L,4L,5L,1L,1L,8L,8L,1L,8L,9L,6L,8L,7L,3L,0L,8L,7L,6L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010625Inst : IEnumerable<long>
{
public static readonly long[] Value=A010625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010625.Bytes);
public long this[int i]=>Value[i];

public static A010625Inst Instance=new A010625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010624
{
public static readonly long[] Value={ 3L,7L,5L,6L,2L,8L,5L,7L,5L,4L,2L,2L,1L,0L,7L,2L,0L,0L,6L,6L,1L,2L,1L,0L,9L,6L,3L,2L,0L,5L,9L,3L,1L,9L,5L,1L,9L,0L,9L,4L,6L,7L,9L,1L,4L,8L,0L,6L,2L,8L,9L,7L,0L,2L,4L,5L,5L,0L,9L,3L,8L,4L,4L,2L,2L,5L,8L,2L,3L,9L,7L,9L,7L,3L,3L,1L,5L,3L,3L,2L,7L,0L,1L,1L,7L,8L,2L,7L,3L,6L,5L,8L,9L,1L,0L,8L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010624Inst : IEnumerable<long>
{
public static readonly long[] Value=A010624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010624.Bytes);
public long this[int i]=>Value[i];

public static A010624Inst Instance=new A010624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010623
{
public static readonly long[] Value={ 3L,7L,3L,2L,5L,1L,1L,1L,5L,6L,8L,1L,7L,2L,4L,8L,2L,4L,2L,9L,6L,5L,1L,5L,0L,6L,0L,7L,3L,5L,6L,5L,4L,1L,0L,7L,8L,7L,0L,1L,1L,2L,5L,4L,3L,3L,8L,0L,8L,2L,9L,0L,8L,0L,9L,9L,0L,7L,6L,9L,9L,5L,8L,5L,8L,5L,3L,5L,2L,4L,6L,2L,2L,3L,9L,1L,1L,0L,2L,4L,1L,7L,3L,9L,6L,9L,7L,6L,3L,1L,8L,4L,4L,8L,1L,7L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010623Inst : IEnumerable<long>
{
public static readonly long[] Value=A010623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010623.Bytes);
public long this[int i]=>Value[i];

public static A010623Inst Instance=new A010623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010622
{
public static readonly long[] Value={ 3L,7L,0L,8L,4L,2L,9L,7L,6L,9L,2L,6L,6L,1L,8L,9L,4L,7L,2L,6L,3L,8L,8L,1L,3L,5L,1L,9L,8L,8L,8L,7L,3L,7L,4L,2L,0L,5L,5L,5L,8L,8L,5L,7L,7L,7L,3L,3L,4L,4L,7L,6L,1L,6L,4L,7L,5L,1L,3L,1L,4L,1L,4L,5L,1L,9L,1L,2L,0L,9L,6L,8L,6L,3L,3L,4L,7L,1L,3L,8L,0L,1L,3L,9L,0L,2L,9L,6L,3L,9L,1L,9L,6L,8L,5L,8L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010622Inst : IEnumerable<long>
{
public static readonly long[] Value=A010622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010622.Bytes);
public long this[int i]=>Value[i];

public static A010622Inst Instance=new A010622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010621
{
public static readonly long[] Value={ 3L,6L,8L,4L,0L,3L,1L,4L,9L,8L,6L,4L,0L,3L,8L,6L,6L,0L,5L,7L,7L,9L,8L,2L,2L,8L,3L,3L,5L,7L,9L,8L,0L,7L,2L,2L,1L,9L,1L,7L,2L,5L,8L,1L,1L,7L,4L,3L,8L,1L,8L,2L,6L,6L,9L,2L,5L,6L,4L,6L,1L,4L,9L,4L,5L,7L,7L,2L,3L,5L,9L,7L,5L,5L,0L,8L,7L,7L,7L,0L,4L,2L,7L,8L,1L,5L,0L,5L,4L,8L,4L,8L,6L,5L,6L,0L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010621Inst : IEnumerable<long>
{
public static readonly long[] Value=A010621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010621.Bytes);
public long this[int i]=>Value[i];

public static A010621Inst Instance=new A010621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010620
{
public static readonly long[] Value={ 3L,6L,5L,9L,3L,0L,5L,7L,1L,0L,0L,2L,2L,9L,7L,1L,5L,1L,7L,2L,3L,8L,0L,7L,3L,3L,1L,0L,1L,1L,9L,4L,0L,8L,2L,6L,3L,4L,8L,7L,1L,0L,3L,6L,6L,8L,8L,4L,3L,3L,2L,4L,0L,3L,3L,1L,7L,8L,6L,3L,6L,4L,6L,7L,0L,1L,2L,0L,6L,3L,7L,5L,6L,5L,9L,4L,6L,8L,7L,1L,2L,3L,0L,9L,3L,6L,4L,3L,8L,5L,0L,7L,8L,5L,3L,7L,4L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010620Inst : IEnumerable<long>
{
public static readonly long[] Value=A010620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010620.Bytes);
public long this[int i]=>Value[i];

public static A010620Inst Instance=new A010620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010619
{
public static readonly long[] Value={ 3L,6L,3L,4L,2L,4L,1L,1L,8L,5L,6L,6L,4L,2L,7L,9L,3L,1L,7L,7L,8L,2L,4L,2L,3L,5L,1L,2L,6L,5L,4L,5L,2L,1L,0L,0L,4L,8L,5L,6L,4L,2L,0L,9L,2L,6L,2L,8L,2L,4L,3L,9L,3L,4L,2L,9L,6L,2L,6L,6L,8L,5L,9L,5L,8L,6L,2L,6L,1L,9L,4L,7L,8L,9L,1L,8L,6L,0L,3L,7L,3L,1L,2L,9L,4L,2L,8L,3L,4L,0L,8L,2L,5L,2L,8L,3L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010619Inst : IEnumerable<long>
{
public static readonly long[] Value=A010619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010619.Bytes);
public long this[int i]=>Value[i];

public static A010619Inst Instance=new A010619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010618
{
public static readonly long[] Value={ 3L,6L,0L,8L,8L,2L,6L,0L,8L,0L,1L,3L,8L,6L,9L,4L,6L,8L,9L,2L,5L,2L,5L,1L,7L,2L,9L,5L,9L,5L,8L,8L,9L,2L,6L,1L,4L,9L,0L,5L,5L,5L,1L,6L,9L,0L,1L,6L,2L,3L,3L,7L,8L,7L,6L,8L,9L,7L,9L,0L,6L,0L,5L,7L,8L,6L,9L,4L,7L,7L,9L,8L,5L,9L,4L,2L,1L,2L,3L,7L,0L,4L,9L,3L,9L,1L,7L,3L,7L,0L,6L,6L,0L,1L,5L,8L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010618Inst : IEnumerable<long>
{
public static readonly long[] Value=A010618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010618.Bytes);
public long this[int i]=>Value[i];

public static A010618Inst Instance=new A010618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010617
{
public static readonly long[] Value={ 3L,5L,8L,3L,0L,4L,7L,8L,7L,1L,0L,1L,5L,9L,4L,6L,4L,8L,5L,3L,8L,6L,9L,6L,3L,6L,7L,4L,5L,8L,0L,6L,6L,6L,2L,7L,2L,1L,5L,4L,8L,2L,0L,5L,9L,3L,0L,9L,5L,6L,3L,5L,1L,5L,7L,0L,4L,3L,9L,8L,0L,3L,6L,5L,4L,3L,9L,4L,8L,6L,4L,8L,5L,9L,5L,7L,7L,1L,1L,4L,7L,7L,1L,6L,4L,7L,4L,6L,1L,3L,4L,5L,2L,5L,1L,1L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010617Inst : IEnumerable<long>
{
public static readonly long[] Value=A010617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010617.Bytes);
public long this[int i]=>Value[i];

public static A010617Inst Instance=new A010617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010616
{
public static readonly long[] Value={ 3L,5L,5L,6L,8L,9L,3L,3L,0L,4L,4L,9L,0L,0L,6L,2L,8L,0L,6L,0L,0L,6L,1L,5L,4L,6L,2L,2L,2L,3L,8L,9L,1L,1L,5L,8L,4L,9L,7L,8L,0L,8L,6L,9L,1L,4L,4L,9L,9L,4L,3L,6L,6L,2L,6L,2L,6L,6L,6L,0L,7L,4L,9L,9L,0L,1L,1L,0L,0L,3L,7L,0L,8L,0L,5L,8L,8L,2L,1L,2L,5L,5L,7L,0L,3L,0L,1L,4L,7L,1L,9L,4L,3L,9L,3L,3L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010616Inst : IEnumerable<long>
{
public static readonly long[] Value=A010616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010616.Bytes);
public long this[int i]=>Value[i];

public static A010616Inst Instance=new A010616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010615
{
public static readonly long[] Value={ 3L,5L,3L,0L,3L,4L,8L,3L,3L,5L,3L,2L,6L,0L,6L,3L,0L,0L,2L,1L,9L,5L,9L,7L,2L,5L,9L,2L,8L,4L,8L,2L,9L,5L,3L,0L,4L,3L,4L,0L,7L,2L,6L,5L,6L,6L,4L,7L,4L,2L,1L,6L,4L,2L,5L,4L,6L,7L,7L,1L,4L,5L,9L,5L,4L,8L,9L,7L,7L,0L,4L,4L,8L,0L,6L,5L,9L,8L,8L,1L,4L,1L,7L,4L,9L,9L,7L,4L,4L,0L,3L,2L,0L,4L,0L,6L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010615Inst : IEnumerable<long>
{
public static readonly long[] Value=A010615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010615.Bytes);
public long this[int i]=>Value[i];

public static A010615Inst Instance=new A010615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010614
{
public static readonly long[] Value={ 3L,5L,0L,3L,3L,9L,8L,0L,6L,0L,3L,8L,6L,7L,2L,4L,1L,7L,0L,6L,1L,4L,3L,3L,3L,7L,5L,8L,1L,8L,9L,1L,2L,9L,7L,3L,7L,2L,4L,8L,7L,5L,6L,7L,8L,6L,9L,1L,5L,3L,9L,2L,4L,0L,1L,7L,1L,5L,3L,2L,2L,6L,1L,0L,4L,3L,7L,2L,1L,0L,5L,3L,2L,6L,1L,4L,5L,6L,3L,6L,1L,5L,6L,6L,8L,0L,4L,0L,9L,9L,5L,3L,5L,5L,3L,9L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010614Inst : IEnumerable<long>
{
public static readonly long[] Value=A010614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010614.Bytes);
public long this[int i]=>Value[i];

public static A010614Inst Instance=new A010614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010613
{
public static readonly long[] Value={ 3L,4L,7L,6L,0L,2L,6L,6L,4L,4L,8L,8L,6L,4L,4L,9L,7L,8L,6L,7L,3L,9L,8L,6L,5L,2L,1L,9L,0L,0L,4L,5L,3L,7L,4L,3L,4L,0L,0L,4L,8L,3L,8L,5L,3L,8L,7L,8L,6L,9L,6L,7L,4L,2L,1L,4L,7L,4L,2L,2L,3L,9L,5L,6L,7L,2L,7L,0L,9L,6L,1L,2L,3L,5L,3L,6L,4L,3L,3L,4L,3L,2L,4L,9L,9L,4L,3L,0L,7L,8L,5L,8L,1L,7L,4L,3L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010613Inst : IEnumerable<long>
{
public static readonly long[] Value=A010613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010613.Bytes);
public long this[int i]=>Value[i];

public static A010613Inst Instance=new A010613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010612
{
public static readonly long[] Value={ 3L,4L,4L,8L,2L,1L,7L,2L,4L,0L,3L,8L,2L,7L,3L,0L,3L,8L,4L,0L,9L,7L,4L,2L,3L,8L,6L,4L,2L,6L,0L,7L,8L,9L,6L,1L,7L,1L,6L,9L,9L,9L,2L,8L,8L,1L,6L,0L,8L,1L,5L,7L,2L,1L,2L,1L,2L,1L,9L,7L,9L,7L,7L,2L,1L,9L,4L,0L,2L,3L,1L,0L,2L,0L,8L,3L,1L,7L,6L,9L,4L,3L,2L,0L,3L,1L,2L,7L,7L,3L,2L,8L,0L,1L,3L,8L,7L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010612Inst : IEnumerable<long>
{
public static readonly long[] Value=A010612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010612.Bytes);
public long this[int i]=>Value[i];

public static A010612Inst Instance=new A010612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010611
{
public static readonly long[] Value={ 3L,4L,1L,9L,9L,5L,1L,8L,9L,3L,3L,5L,3L,3L,9L,3L,9L,7L,8L,7L,0L,6L,2L,1L,7L,7L,4L,5L,0L,8L,7L,7L,2L,0L,2L,1L,9L,7L,3L,6L,1L,1L,0L,2L,2L,1L,0L,8L,6L,1L,0L,9L,8L,4L,8L,7L,6L,5L,7L,2L,3L,4L,1L,4L,8L,8L,8L,5L,9L,1L,8L,4L,1L,0L,0L,8L,3L,4L,6L,4L,3L,2L,5L,1L,4L,3L,7L,4L,0L,2L,0L,0L,4L,0L,3L,7L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010611Inst : IEnumerable<long>
{
public static readonly long[] Value=A010611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010611.Bytes);
public long this[int i]=>Value[i];

public static A010611Inst Instance=new A010611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010610
{
public static readonly long[] Value={ 3L,3L,9L,1L,2L,1L,1L,4L,4L,3L,0L,1L,4L,1L,6L,6L,7L,6L,1L,9L,5L,4L,6L,7L,0L,7L,2L,5L,9L,9L,4L,5L,9L,6L,7L,3L,3L,2L,6L,2L,8L,3L,6L,1L,2L,4L,8L,0L,9L,9L,2L,4L,9L,6L,9L,3L,4L,4L,3L,1L,6L,2L,4L,3L,9L,9L,5L,2L,5L,0L,6L,4L,8L,8L,3L,3L,1L,7L,8L,1L,8L,4L,9L,6L,4L,9L,4L,5L,3L,1L,6L,9L,4L,2L,1L,0L,0L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010610Inst : IEnumerable<long>
{
public static readonly long[] Value=A010610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010610.Bytes);
public long this[int i]=>Value[i];

public static A010610Inst Instance=new A010610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010609
{
public static readonly long[] Value={ 3L,3L,6L,1L,9L,7L,5L,4L,0L,6L,7L,9L,8L,9L,6L,3L,3L,1L,4L,8L,4L,0L,5L,5L,8L,5L,6L,6L,8L,1L,0L,5L,6L,3L,4L,4L,7L,4L,0L,6L,5L,7L,8L,9L,6L,9L,1L,6L,6L,2L,5L,8L,6L,5L,5L,3L,9L,7L,4L,4L,3L,0L,4L,2L,6L,7L,9L,9L,6L,4L,2L,1L,9L,4L,1L,3L,9L,8L,4L,9L,7L,7L,2L,2L,0L,4L,6L,8L,9L,8L,6L,3L,4L,1L,1L,7L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010609Inst : IEnumerable<long>
{
public static readonly long[] Value=A010609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010609.Bytes);
public long this[int i]=>Value[i];

public static A010609Inst Instance=new A010609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010608
{
public static readonly long[] Value={ 3L,3L,3L,2L,2L,2L,1L,8L,5L,1L,6L,4L,5L,9L,5L,3L,2L,6L,0L,0L,9L,5L,4L,5L,0L,5L,0L,5L,1L,8L,5L,1L,1L,9L,0L,0L,4L,4L,0L,9L,6L,1L,6L,6L,7L,1L,9L,5L,0L,0L,6L,2L,3L,5L,9L,1L,3L,2L,9L,6L,6L,6L,5L,0L,9L,8L,0L,4L,0L,5L,3L,4L,2L,4L,3L,8L,8L,6L,5L,6L,5L,2L,4L,2L,4L,9L,1L,5L,5L,8L,3L,5L,6L,7L,6L,6L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010608Inst : IEnumerable<long>
{
public static readonly long[] Value=A010608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010608.Bytes);
public long this[int i]=>Value[i];

public static A010608Inst Instance=new A010608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010607
{
public static readonly long[] Value={ 3L,3L,0L,1L,9L,2L,7L,2L,4L,8L,8L,9L,4L,6L,2L,6L,6L,8L,3L,8L,7L,4L,6L,0L,9L,9L,5L,2L,4L,0L,9L,0L,8L,4L,9L,5L,6L,8L,4L,6L,8L,8L,4L,6L,4L,4L,3L,1L,8L,4L,9L,3L,3L,3L,6L,9L,7L,3L,2L,0L,2L,5L,3L,7L,1L,0L,9L,2L,7L,5L,6L,7L,5L,5L,7L,8L,8L,7L,1L,5L,3L,5L,8L,6L,5L,2L,5L,2L,6L,9L,5L,1L,6L,4L,8L,0L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010607Inst : IEnumerable<long>
{
public static readonly long[] Value=A010607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010607.Bytes);
public long this[int i]=>Value[i];

public static A010607Inst Instance=new A010607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010606
{
public static readonly long[] Value={ 3L,2L,7L,1L,0L,6L,6L,3L,1L,0L,1L,8L,8L,5L,8L,9L,7L,2L,8L,2L,2L,4L,8L,0L,6L,9L,0L,2L,3L,9L,2L,5L,3L,1L,3L,4L,4L,0L,9L,8L,9L,0L,3L,1L,4L,7L,7L,7L,8L,9L,0L,5L,8L,1L,9L,6L,4L,4L,5L,6L,0L,1L,0L,7L,8L,6L,5L,2L,0L,0L,3L,9L,4L,4L,4L,5L,8L,8L,8L,3L,1L,7L,9L,5L,8L,6L,1L,2L,7L,0L,9L,0L,0L,7L,6L,6L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010606Inst : IEnumerable<long>
{
public static readonly long[] Value=A010606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010606.Bytes);
public long this[int i]=>Value[i];

public static A010606Inst Instance=new A010606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010605
{
public static readonly long[] Value={ 3L,2L,3L,9L,6L,1L,1L,8L,0L,1L,2L,7L,7L,4L,8L,3L,3L,8L,4L,0L,7L,1L,4L,6L,9L,9L,2L,4L,2L,7L,2L,0L,2L,9L,7L,0L,0L,3L,7L,8L,3L,7L,8L,9L,6L,8L,5L,2L,6L,5L,2L,8L,8L,1L,6L,5L,1L,5L,1L,2L,5L,7L,6L,2L,1L,2L,4L,6L,8L,2L,6L,5L,3L,2L,2L,8L,5L,8L,2L,1L,9L,6L,3L,9L,7L,2L,1L,9L,5L,8L,0L,8L,3L,4L,2L,6L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010605Inst : IEnumerable<long>
{
public static readonly long[] Value=A010605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010605.Bytes);
public long this[int i]=>Value[i];

public static A010605Inst Instance=new A010605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010604
{
public static readonly long[] Value={ 3L,2L,0L,7L,5L,3L,4L,3L,2L,9L,9L,9L,5L,8L,2L,6L,4L,8L,7L,5L,5L,2L,5L,1L,5L,1L,7L,1L,7L,1L,9L,5L,2L,0L,1L,1L,1L,3L,6L,1L,8L,5L,1L,6L,6L,3L,3L,6L,0L,5L,7L,2L,1L,7L,1L,7L,2L,4L,0L,7L,1L,8L,4L,7L,2L,8L,3L,8L,1L,4L,9L,8L,0L,9L,7L,6L,3L,8L,9L,1L,9L,8L,9L,1L,0L,3L,0L,3L,5L,2L,0L,2L,5L,1L,2L,0L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010604Inst : IEnumerable<long>
{
public static readonly long[] Value=A010604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010604.Bytes);
public long this[int i]=>Value[i];

public static A010604Inst Instance=new A010604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010603
{
public static readonly long[] Value={ 3L,1L,7L,4L,8L,0L,2L,1L,0L,3L,9L,3L,6L,3L,9L,8L,9L,4L,9L,5L,0L,3L,4L,1L,1L,2L,7L,8L,5L,4L,4L,6L,1L,6L,5L,2L,0L,7L,8L,2L,9L,8L,6L,6L,5L,5L,7L,9L,9L,7L,0L,6L,0L,1L,9L,6L,1L,6L,5L,7L,1L,5L,2L,3L,6L,5L,0L,4L,3L,3L,0L,1L,1L,2L,4L,8L,4L,3L,8L,3L,4L,6L,5L,4L,7L,0L,8L,8L,4L,2L,6L,5L,2L,4L,4L,4L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010603Inst : IEnumerable<long>
{
public static readonly long[] Value=A010603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010603.Bytes);
public long this[int i]=>Value[i];

public static A010603Inst Instance=new A010603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}