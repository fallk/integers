using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040252
{
public static readonly long[] Value={ 16L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L,32L,2L,2L };
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
public class A040252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040252Inst : IEnumerable<long>
{
public static readonly long[] Value=A040252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040252.Bytes);
public long this[int i]=>Value[i];

public static A040252Inst Instance=new A040252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040269
{
public static readonly long[] Value={ 16L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L,1L,10L,3L,3L,2L,3L,3L,10L,1L,32L };
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
public class A040269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040269Inst : IEnumerable<long>
{
public static readonly long[] Value=A040269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040269.Bytes);
public long this[int i]=>Value[i];

public static A040269Inst Instance=new A040269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040270
{
public static readonly long[] Value={ 16L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L,1L,32L,1L,15L };
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
public class A040270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040270Inst : IEnumerable<long>
{
public static readonly long[] Value=A040270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040270.Bytes);
public long this[int i]=>Value[i];

public static A040270Inst Instance=new A040270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040271
{
public static readonly long[] Value={ 16L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L,1L,32L };
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
public class A040271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040271Inst : IEnumerable<long>
{
public static readonly long[] Value=A040271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040271.Bytes);
public long this[int i]=>Value[i];

public static A040271Inst Instance=new A040271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040272
{
public static readonly long[] Value={ 17L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L };
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
public class A040272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040272Inst : IEnumerable<long>
{
public static readonly long[] Value=A040272.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040272.Bytes);
public long this[int i]=>Value[i];

public static A040272Inst Instance=new A040272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040273
{
public static readonly long[] Value={ 17L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L,17L,34L };
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
public class A040273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040273Inst : IEnumerable<long>
{
public static readonly long[] Value=A040273.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040273.Bytes);
public long this[int i]=>Value[i];

public static A040273Inst Instance=new A040273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040274
{
public static readonly long[] Value={ 17L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L,11L,2L,1L,3L,8L,3L,1L,2L,11L,34L };
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
public class A040274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040274Inst : IEnumerable<long>
{
public static readonly long[] Value=A040274.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040274.Bytes);
public long this[int i]=>Value[i];

public static A040274Inst Instance=new A040274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040275
{
public static readonly long[] Value={ 17L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L,34L,8L,1L,1L,8L };
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
public class A040275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040275Inst : IEnumerable<long>
{
public static readonly long[] Value=A040275.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040275.Bytes);
public long this[int i]=>Value[i];

public static A040275Inst Instance=new A040275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040276
{
public static readonly long[] Value={ 17L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L,4L,1L,6L,34L,6L,1L };
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
public class A040276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040276Inst : IEnumerable<long>
{
public static readonly long[] Value=A040276.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040276.Bytes);
public long this[int i]=>Value[i];

public static A040276Inst Instance=new A040276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040277
{
public static readonly long[] Value={ 17L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L,6L,2L,3L,2L,1L,5L,34L,5L,1L,2L,3L,2L };
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
public class A040277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040277Inst : IEnumerable<long>
{
public static readonly long[] Value=A040277.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040277.Bytes);
public long this[int i]=>Value[i];

public static A040277Inst Instance=new A040277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040278
{
public static readonly long[] Value={ 17L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L,7L,1L,4L,34L,4L,1L };
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
public class A040278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040278Inst : IEnumerable<long>
{
public static readonly long[] Value=A040278.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040278.Bytes);
public long this[int i]=>Value[i];

public static A040278Inst Instance=new A040278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040279
{
public static readonly long[] Value={ 17L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L,34L,4L,3L,1L,1L,2L,1L,1L,3L,4L };
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
public class A040279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040279Inst : IEnumerable<long>
{
public static readonly long[] Value=A040279.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040279.Bytes);
public long this[int i]=>Value[i];

public static A040279Inst Instance=new A040279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040280
{
public static readonly long[] Value={ 17L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L,1L,4L,5L,1L,1L,5L,4L,1L,3L,34L,3L };
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
public class A040280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040280Inst : IEnumerable<long>
{
public static readonly long[] Value=A040280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040280.Bytes);
public long this[int i]=>Value[i];

public static A040280Inst Instance=new A040280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040281
{
public static readonly long[] Value={ 17L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L,34L,3L,2L,3L };
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
public class A040281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040281Inst : IEnumerable<long>
{
public static readonly long[] Value=A040281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040281.Bytes);
public long this[int i]=>Value[i];

public static A040281Inst Instance=new A040281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040282
{
public static readonly long[] Value={ 17L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L,34L,3L,8L,3L };
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
public class A040282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040282Inst : IEnumerable<long>
{
public static readonly long[] Value=A040282.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040282.Bytes);
public long this[int i]=>Value[i];

public static A040282Inst Instance=new A040282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040283
{
public static readonly long[] Value={ 17L,2L,1L,6L,3L,1L,2L,2L,1L,1L,8L,11L,2L,4L,2L,11L,8L,1L,1L,2L,2L,1L,3L,6L,1L,2L,34L,2L,1L,6L,3L,1L,2L,2L,1L,1L,8L,11L,2L,4L,2L,11L,8L,1L,1L,2L,2L,1L,3L,6L,1L,2L,34L,2L,1L,6L,3L,1L,2L,2L,1L,1L,8L,11L,2L,4L,2L,11L,8L,1L,1L,2L,2L,1L,3L,6L,1L,2L,34L,2L,1L,6L,3L,1L,2L,2L,1L,1L,8L };
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
public class A040283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040283Inst : IEnumerable<long>
{
public static readonly long[] Value=A040283.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040283.Bytes);
public long this[int i]=>Value[i];

public static A040283Inst Instance=new A040283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040284
{
public static readonly long[] Value={ 17L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L,16L,1L,2L,4L,1L,1L,1L,2L,34L,2L,1L,1L,1L,4L,2L,1L };
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
public class A040284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040284Inst : IEnumerable<long>
{
public static readonly long[] Value=A040284.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040284.Bytes);
public long this[int i]=>Value[i];

public static A040284Inst Instance=new A040284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040301
{
public static readonly long[] Value={ 17L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L,3L,1L,3L,4L,1L,5L,6L,1L,34L,1L,6L,5L,1L,4L };
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
public class A040301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040301Inst : IEnumerable<long>
{
public static readonly long[] Value=A040301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040301.Bytes);
public long this[int i]=>Value[i];

public static A040301Inst Instance=new A040301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040302
{
public static readonly long[] Value={ 17L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L,34L,1L,7L,1L };
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
public class A040302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040302Inst : IEnumerable<long>
{
public static readonly long[] Value=A040302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040302.Bytes);
public long this[int i]=>Value[i];

public static A040302Inst Instance=new A040302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040303
{
public static readonly long[] Value={ 17L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L,1L,34L,1L,10L };
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
public class A040303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040303Inst : IEnumerable<long>
{
public static readonly long[] Value=A040303.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040303.Bytes);
public long this[int i]=>Value[i];

public static A040303Inst Instance=new A040303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040304
{
public static readonly long[] Value={ 17L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L,1L,34L,1L,16L };
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
public class A040304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040304Inst : IEnumerable<long>
{
public static readonly long[] Value=A040304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040304.Bytes);
public long this[int i]=>Value[i];

public static A040304Inst Instance=new A040304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040305
{
public static readonly long[] Value={ 17L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L,1L,34L };
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
public class A040305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040305Inst : IEnumerable<long>
{
public static readonly long[] Value=A040305.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040305.Bytes);
public long this[int i]=>Value[i];

public static A040305Inst Instance=new A040305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040306
{
public static readonly long[] Value={ 18L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L,36L };
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
public class A040306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040306Inst : IEnumerable<long>
{
public static readonly long[] Value=A040306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040306.Bytes);
public long this[int i]=>Value[i];

public static A040306Inst Instance=new A040306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040307
{
public static readonly long[] Value={ 18L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L,18L,36L };
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
public class A040307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040307Inst : IEnumerable<long>
{
public static readonly long[] Value=A040307.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040307.Bytes);
public long this[int i]=>Value[i];

public static A040307Inst Instance=new A040307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040308
{
public static readonly long[] Value={ 18L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L,12L,36L };
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
public class A040308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040308Inst : IEnumerable<long>
{
public static readonly long[] Value=A040308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040308.Bytes);
public long this[int i]=>Value[i];

public static A040308Inst Instance=new A040308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040309
{
public static readonly long[] Value={ 18L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L,9L,36L };
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
public class A040309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040309Inst : IEnumerable<long>
{
public static readonly long[] Value=A040309.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040309.Bytes);
public long this[int i]=>Value[i];

public static A040309Inst Instance=new A040309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040310
{
public static readonly long[] Value={ 18L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L,4L,1L,1L,2L,4L,7L,36L,7L,4L,2L,1L,1L };
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
public class A040310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040310Inst : IEnumerable<long>
{
public static readonly long[] Value=A040310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040310.Bytes);
public long this[int i]=>Value[i];

public static A040310Inst Instance=new A040310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040311
{
public static readonly long[] Value={ 18L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L,6L,36L };
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
public class A040311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040311Inst : IEnumerable<long>
{
public static readonly long[] Value=A040311.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040311.Bytes);
public long this[int i]=>Value[i];

public static A040311Inst Instance=new A040311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040312
{
public static readonly long[] Value={ 18L,5L,5L,1L,6L,2L,3L,1L,1L,2L,1L,2L,1L,11L,2L,1L,1L,17L,1L,1L,2L,11L,1L,2L,1L,2L,1L,1L,3L,2L,6L,1L,5L,5L,36L,5L,5L,1L,6L,2L,3L,1L,1L,2L,1L,2L,1L,11L,2L,1L,1L,17L,1L,1L,2L,11L,1L,2L,1L,2L,1L,1L,3L,2L,6L,1L,5L,5L,36L,5L,5L,1L,6L,2L,3L,1L,1L,2L,1L,2L,1L,11L,2L,1L,1L,17L,1L,1L };
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
public class A040312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040312Inst : IEnumerable<long>
{
public static readonly long[] Value=A040312.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040312.Bytes);
public long this[int i]=>Value[i];

public static A040312Inst Instance=new A040312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040313
{
public static readonly long[] Value={ 18L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L,36L,4L,1L,1L,8L,1L,1L,4L };
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
public class A040313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040313Inst : IEnumerable<long>
{
public static readonly long[] Value=A040313.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040313.Bytes);
public long this[int i]=>Value[i];

public static A040313Inst Instance=new A040313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040314
{
public static readonly long[] Value={ 18L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L,4L,36L };
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
public class A040314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040314Inst : IEnumerable<long>
{
public static readonly long[] Value=A040314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040314.Bytes);
public long this[int i]=>Value[i];

public static A040314Inst Instance=new A040314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040315
{
public static readonly long[] Value={ 18L,3L,1L,1L,1L,2L,5L,1L,2L,2L,11L,1L,3L,7L,18L,7L,3L,1L,11L,2L,2L,1L,5L,2L,1L,1L,1L,3L,36L,3L,1L,1L,1L,2L,5L,1L,2L,2L,11L,1L,3L,7L,18L,7L,3L,1L,11L,2L,2L,1L,5L,2L,1L,1L,1L,3L,36L,3L,1L,1L,1L,2L,5L,1L,2L,2L,11L,1L,3L,7L,18L,7L,3L,1L,11L,2L,2L,1L,5L,2L,1L,1L,1L,3L,36L,3L,1L };
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
public class A040315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040315Inst : IEnumerable<long>
{
public static readonly long[] Value=A040315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040315.Bytes);
public long this[int i]=>Value[i];

public static A040315Inst Instance=new A040315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040316
{
public static readonly long[] Value={ 18L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L,36L,3L,3L,3L };
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
public class A040316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040316Inst : IEnumerable<long>
{
public static readonly long[] Value=A040316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040316.Bytes);
public long this[int i]=>Value[i];

public static A040316Inst Instance=new A040316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040333
{
public static readonly long[] Value={ 18L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L,36L,1L,3L,5L,9L,5L,3L,1L };
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
public class A040333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040333Inst : IEnumerable<long>
{
public static readonly long[] Value=A040333.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040333.Bytes);
public long this[int i]=>Value[i];

public static A040333Inst Instance=new A040333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040334
{
public static readonly long[] Value={ 18L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,36L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,36L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,36L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,36L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,36L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L };
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
public class A040334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040334Inst : IEnumerable<long>
{
public static readonly long[] Value=A040334.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040334.Bytes);
public long this[int i]=>Value[i];

public static A040334Inst Instance=new A040334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040335
{
public static readonly long[] Value={ 18L,1L,4L,2L,2L,18L,2L,2L,4L,1L,36L,1L,4L,2L,2L,18L,2L,2L,4L,1L,36L,1L,4L,2L,2L,18L,2L,2L,4L,1L,36L,1L,4L,2L,2L,18L,2L,2L,4L,1L,36L,1L,4L,2L,2L,18L,2L,2L,4L,1L,36L,1L,4L,2L,2L,18L,2L,2L,4L,1L,36L,1L,4L,2L,2L,18L,2L,2L,4L,1L,36L,1L,4L,2L,2L,18L,2L,2L,4L,1L,36L,1L,4L,2L,2L };
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
public class A040335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040335Inst : IEnumerable<long>
{
public static readonly long[] Value=A040335.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040335.Bytes);
public long this[int i]=>Value[i];

public static A040335Inst Instance=new A040335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040336
{
public static readonly long[] Value={ 18L,1L,5L,3L,3L,1L,6L,1L,3L,3L,5L,1L,36L,1L,5L,3L,3L,1L,6L,1L,3L,3L,5L,1L,36L,1L,5L,3L,3L,1L,6L,1L,3L,3L,5L,1L,36L,1L,5L,3L,3L,1L,6L,1L,3L,3L,5L,1L,36L,1L,5L,3L,3L,1L,6L,1L,3L,3L,5L,1L,36L,1L,5L,3L,3L,1L,6L,1L,3L,3L,5L,1L,36L,1L,5L,3L,3L,1L,6L,1L,3L,3L,5L,1L,36L,1L,5L,3L,3L,1L };
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
public class A040336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040336Inst : IEnumerable<long>
{
public static readonly long[] Value=A040336.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040336.Bytes);
public long this[int i]=>Value[i];

public static A040336Inst Instance=new A040336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040337
{
public static readonly long[] Value={ 18L,1L,6L,1L,1L,2L,1L,8L,1L,2L,1L,1L,6L,1L,36L,1L,6L,1L,1L,2L,1L,8L,1L,2L,1L,1L,6L,1L,36L,1L,6L,1L,1L,2L,1L,8L,1L,2L,1L,1L,6L,1L,36L,1L,6L,1L,1L,2L,1L,8L,1L,2L,1L,1L,6L,1L,36L,1L,6L,1L,1L,2L,1L,8L,1L,2L,1L,1L,6L,1L,36L,1L,6L,1L,1L,2L,1L,8L,1L,2L,1L,1L,6L,1L,36L,1L,6L,1L,1L,2L };
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
public class A040337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040337Inst : IEnumerable<long>
{
public static readonly long[] Value=A040337.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040337.Bytes);
public long this[int i]=>Value[i];

public static A040337Inst Instance=new A040337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040338
{
public static readonly long[] Value={ 18L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L,2L,8L,1L,36L,1L,8L };
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
public class A040338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040338Inst : IEnumerable<long>
{
public static readonly long[] Value=A040338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040338.Bytes);
public long this[int i]=>Value[i];

public static A040338Inst Instance=new A040338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040339
{
public static readonly long[] Value={ 18L,1L,11L,1L,1L,1L,3L,1L,1L,4L,1L,5L,2L,18L,2L,5L,1L,4L,1L,1L,3L,1L,1L,1L,11L,1L,36L,1L,11L,1L,1L,1L,3L,1L,1L,4L,1L,5L,2L,18L,2L,5L,1L,4L,1L,1L,3L,1L,1L,1L,11L,1L,36L,1L,11L,1L,1L,1L,3L,1L,1L,4L,1L,5L,2L,18L,2L,5L,1L,4L,1L,1L,3L,1L,1L,1L,11L,1L,36L,1L,11L,1L,1L,1L,3L,1L,1L };
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
public class A040339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040339Inst : IEnumerable<long>
{
public static readonly long[] Value=A040339.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040339.Bytes);
public long this[int i]=>Value[i];

public static A040339Inst Instance=new A040339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040340
{
public static readonly long[] Value={ 18L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L,1L,36L,1L,17L };
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
public class A040340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040340Inst : IEnumerable<long>
{
public static readonly long[] Value=A040340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040340.Bytes);
public long this[int i]=>Value[i];

public static A040340Inst Instance=new A040340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040341
{
public static readonly long[] Value={ 18L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L,1L,36L };
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
public class A040341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040341Inst : IEnumerable<long>
{
public static readonly long[] Value=A040341.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040341.Bytes);
public long this[int i]=>Value[i];

public static A040341Inst Instance=new A040341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040342
{
public static readonly long[] Value={ 19L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L,38L };
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
public class A040342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040342Inst : IEnumerable<long>
{
public static readonly long[] Value=A040342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040342.Bytes);
public long this[int i]=>Value[i];

public static A040342Inst Instance=new A040342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040343
{
public static readonly long[] Value={ 19L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L,19L,38L };
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
public class A040343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040343Inst : IEnumerable<long>
{
public static readonly long[] Value=A040343.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040343.Bytes);
public long this[int i]=>Value[i];

public static A040343Inst Instance=new A040343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040344
{
public static readonly long[] Value={ 19L,12L,1L,2L,3L,1L,8L,1L,3L,2L,1L,12L,38L,12L,1L,2L,3L,1L,8L,1L,3L,2L,1L,12L,38L,12L,1L,2L,3L,1L,8L,1L,3L,2L,1L,12L,38L,12L,1L,2L,3L,1L,8L,1L,3L,2L,1L,12L,38L,12L,1L,2L,3L,1L,8L,1L,3L,2L,1L,12L,38L,12L,1L,2L,3L,1L,8L,1L,3L,2L,1L,12L,38L,12L,1L,2L,3L,1L,8L,1L,3L,2L,1L };
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
public class A040344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040344Inst : IEnumerable<long>
{
public static readonly long[] Value=A040344.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040344.Bytes);
public long this[int i]=>Value[i];

public static A040344Inst Instance=new A040344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040345
{
public static readonly long[] Value={ 19L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L,38L,9L,1L,1L,9L };
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
public class A040345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040345Inst : IEnumerable<long>
{
public static readonly long[] Value=A040345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040345.Bytes);
public long this[int i]=>Value[i];

public static A040345Inst Instance=new A040345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040346
{
public static readonly long[] Value={ 19L,7L,1L,1L,1L,2L,12L,2L,1L,1L,1L,7L,38L,7L,1L,1L,1L,2L,12L,2L,1L,1L,1L,7L,38L,7L,1L,1L,1L,2L,12L,2L,1L,1L,1L,7L,38L,7L,1L,1L,1L,2L,12L,2L,1L,1L,1L,7L,38L,7L,1L,1L,1L,2L,12L,2L,1L,1L,1L,7L,38L,7L,1L,1L,1L,2L,12L,2L,1L,1L,1L,7L,38L,7L,1L,1L,1L,2L,12L,2L,1L,1L,1L,7L,38L,7L,1L };
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
public class A040346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040346Inst : IEnumerable<long>
{
public static readonly long[] Value=A040346.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040346.Bytes);
public long this[int i]=>Value[i];

public static A040346Inst Instance=new A040346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040347
{
public static readonly long[] Value={ 19L,6L,2L,1L,3L,1L,1L,2L,1L,12L,19L,12L,1L,2L,1L,1L,3L,1L,2L,6L,38L,6L,2L,1L,3L,1L,1L,2L,1L,12L,19L,12L,1L,2L,1L,1L,3L,1L,2L,6L,38L,6L,2L,1L,3L,1L,1L,2L,1L,12L,19L,12L,1L,2L,1L,1L,3L,1L,2L,6L,38L,6L,2L,1L,3L,1L,1L,2L,1L,12L,19L,12L,1L,2L,1L,1L,3L,1L,2L,6L,38L,6L,2L,1L,3L,1L };
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
public class A040347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040347Inst : IEnumerable<long>
{
public static readonly long[] Value=A040347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040347.Bytes);
public long this[int i]=>Value[i];

public static A040347Inst Instance=new A040347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040348
{
public static readonly long[] Value={ 19L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L,38L,5L,2L,5L };
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
public class A040348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040348Inst : IEnumerable<long>
{
public static readonly long[] Value=A040348.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040348.Bytes);
public long this[int i]=>Value[i];

public static A040348Inst Instance=new A040348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040365
{
public static readonly long[] Value={ 19L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L,3L,1L,1L,1L,1L,1L,38L,1L,1L,1L,1L,1L,3L,1L,2L,1L };
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
public class A040365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040365Inst : IEnumerable<long>
{
public static readonly long[] Value=A040365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040365.Bytes);
public long this[int i]=>Value[i];

public static A040365Inst Instance=new A040365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040366
{
public static readonly long[] Value={ 19L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L,1L,4L,1L,18L,1L,4L,1L,1L,1L,38L,1L,1L };
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
public class A040366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040366Inst : IEnumerable<long>
{
public static readonly long[] Value=A040366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040366.Bytes);
public long this[int i]=>Value[i];

public static A040366Inst Instance=new A040366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040367
{
public static readonly long[] Value={ 19L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L,19L,2L,1L,38L,1L,2L };
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
public class A040367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040367Inst : IEnumerable<long>
{
public static readonly long[] Value=A040367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040367.Bytes);
public long this[int i]=>Value[i];

public static A040367Inst Instance=new A040367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040368
{
public static readonly long[] Value={ 19L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L,38L,1L,2L,3L,4L,12L,1L,8L,1L,12L,4L,3L,2L,1L };
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
public class A040368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040368Inst : IEnumerable<long>
{
public static readonly long[] Value=A040368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040368.Bytes);
public long this[int i]=>Value[i];

public static A040368Inst Instance=new A040368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040369
{
public static readonly long[] Value={ 19L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L,1L,38L,1L,2L,1L,1L,1L,1L,2L };
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
public class A040369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040369Inst : IEnumerable<long>
{
public static readonly long[] Value=A040369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040369.Bytes);
public long this[int i]=>Value[i];

public static A040369Inst Instance=new A040369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040370
{
public static readonly long[] Value={ 19L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L,38L,1L,2L,1L };
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
public class A040370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040370Inst : IEnumerable<long>
{
public static readonly long[] Value=A040370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040370.Bytes);
public long this[int i]=>Value[i];

public static A040370Inst Instance=new A040370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040371
{
public static readonly long[] Value={ 19L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L,19L,2L,1L,1L,2L,2L,3L,1L,38L,1L,3L,2L,2L,1L,1L,2L };
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
public class A040371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040371Inst : IEnumerable<long>
{
public static readonly long[] Value=A040371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040371.Bytes);
public long this[int i]=>Value[i];

public static A040371Inst Instance=new A040371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040372
{
public static readonly long[] Value={ 19L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L,38L,1L,3L,1L };
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
public class A040372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040372Inst : IEnumerable<long>
{
public static readonly long[] Value=A040372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040372.Bytes);
public long this[int i]=>Value[i];

public static A040372Inst Instance=new A040372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040373
{
public static readonly long[] Value={ 19L,1L,4L,1L,2L,4L,1L,1L,1L,1L,12L,1L,1L,1L,1L,4L,2L,1L,4L,1L,38L,1L,4L,1L,2L,4L,1L,1L,1L,1L,12L,1L,1L,1L,1L,4L,2L,1L,4L,1L,38L,1L,4L,1L,2L,4L,1L,1L,1L,1L,12L,1L,1L,1L,1L,4L,2L,1L,4L,1L,38L,1L,4L,1L,2L,4L,1L,1L,1L,1L,12L,1L,1L,1L,1L,4L,2L,1L,4L,1L,38L,1L,4L,1L,2L,4L,1L,1L,1L,1L };
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
public class A040373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040373Inst : IEnumerable<long>
{
public static readonly long[] Value=A040373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040373.Bytes);
public long this[int i]=>Value[i];

public static A040373Inst Instance=new A040373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040374
{
public static readonly long[] Value={ 19L,1L,5L,1L,1L,1L,3L,1L,3L,5L,2L,2L,5L,3L,1L,3L,1L,1L,1L,5L,1L,38L,1L,5L,1L,1L,1L,3L,1L,3L,5L,2L,2L,5L,3L,1L,3L,1L,1L,1L,5L,1L,38L,1L,5L,1L,1L,1L,3L,1L,3L,5L,2L,2L,5L,3L,1L,3L,1L,1L,1L,5L,1L,38L,1L,5L,1L,1L,1L,3L,1L,3L,5L,2L,2L,5L,3L,1L,3L,1L,1L,1L,5L,1L,38L,1L,5L,1L,1L,1L,3L };
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
public class A040374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040374Inst : IEnumerable<long>
{
public static readonly long[] Value=A040374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040374.Bytes);
public long this[int i]=>Value[i];

public static A040374Inst Instance=new A040374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040375
{
public static readonly long[] Value={ 19L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L,38L,1L,6L,1L };
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
public class A040375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040375Inst : IEnumerable<long>
{
public static readonly long[] Value=A040375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040375.Bytes);
public long this[int i]=>Value[i];

public static A040375Inst Instance=new A040375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040376
{
public static readonly long[] Value={ 19L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L,38L,1L,8L,1L };
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
public class A040376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040376Inst : IEnumerable<long>
{
public static readonly long[] Value=A040376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040376.Bytes);
public long this[int i]=>Value[i];

public static A040376Inst Instance=new A040376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040377
{
public static readonly long[] Value={ 19L,1L,12L,3L,4L,9L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,9L,4L,3L,12L,1L,38L,1L,12L,3L,4L,9L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,9L,4L,3L,12L,1L,38L,1L,12L,3L,4L,9L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,9L,4L,3L,12L,1L,38L,1L,12L,3L,4L,9L,1L,2L,1L,2L,1L,1L,2L,1L,2L,1L,9L,4L,3L,12L,1L,38L,1L,12L };
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
public class A040377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040377Inst : IEnumerable<long>
{
public static readonly long[] Value=A040377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040377.Bytes);
public long this[int i]=>Value[i];

public static A040377Inst Instance=new A040377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040378
{
public static readonly long[] Value={ 19L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L,1L,38L,1L,18L };
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
public class A040378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040378Inst : IEnumerable<long>
{
public static readonly long[] Value=A040378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040378.Bytes);
public long this[int i]=>Value[i];

public static A040378Inst Instance=new A040378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040379
{
public static readonly long[] Value={ 19L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L,1L,38L };
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
public class A040379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040379Inst : IEnumerable<long>
{
public static readonly long[] Value=A040379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040379.Bytes);
public long this[int i]=>Value[i];

public static A040379Inst Instance=new A040379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040380
{
public static readonly long[] Value={ 20L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L,40L };
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
public class A040380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040380Inst : IEnumerable<long>
{
public static readonly long[] Value=A040380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040380.Bytes);
public long this[int i]=>Value[i];

public static A040380Inst Instance=new A040380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040413
{
public static readonly long[] Value={ 20L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L,40L,1L,4L,1L };
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
public class A040413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040413Inst : IEnumerable<long>
{
public static readonly long[] Value=A040413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040413.Bytes);
public long this[int i]=>Value[i];

public static A040413Inst Instance=new A040413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040414
{
public static readonly long[] Value={ 20L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L,40L,1L,5L,1L };
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
public class A040414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040414Inst : IEnumerable<long>
{
public static readonly long[] Value=A040414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040414.Bytes);
public long this[int i]=>Value[i];

public static A040414Inst Instance=new A040414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040415
{
public static readonly long[] Value={ 20L,1L,7L,2L,1L,1L,1L,13L,3L,2L,2L,5L,1L,1L,4L,10L,4L,1L,1L,5L,2L,2L,3L,13L,1L,1L,1L,2L,7L,1L,40L,1L,7L,2L,1L,1L,1L,13L,3L,2L,2L,5L,1L,1L,4L,10L,4L,1L,1L,5L,2L,2L,3L,13L,1L,1L,1L,2L,7L,1L,40L,1L,7L,2L,1L,1L,1L,13L,3L,2L,2L,5L,1L,1L,4L,10L,4L,1L,1L,5L,2L,2L,3L,13L,1L,1L,1L };
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
public class A040415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040415Inst : IEnumerable<long>
{
public static readonly long[] Value=A040415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040415.Bytes);
public long this[int i]=>Value[i];

public static A040415Inst Instance=new A040415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040416
{
public static readonly long[] Value={ 20L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L,2L,9L,1L,40L,1L,9L };
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
public class A040416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040416Inst : IEnumerable<long>
{
public static readonly long[] Value=A040416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040416.Bytes);
public long this[int i]=>Value[i];

public static A040416Inst Instance=new A040416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040417
{
public static readonly long[] Value={ 20L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L,1L,40L,1L,12L };
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
public class A040417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040417Inst : IEnumerable<long>
{
public static readonly long[] Value=A040417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040417.Bytes);
public long this[int i]=>Value[i];

public static A040417Inst Instance=new A040417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040418
{
public static readonly long[] Value={ 20L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L,1L,40L,1L,19L };
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
public class A040418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040418Inst : IEnumerable<long>
{
public static readonly long[] Value=A040418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040418.Bytes);
public long this[int i]=>Value[i];

public static A040418Inst Instance=new A040418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040419
{
public static readonly long[] Value={ 20L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L,1L,40L };
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
public class A040419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040419Inst : IEnumerable<long>
{
public static readonly long[] Value=A040419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040419.Bytes);
public long this[int i]=>Value[i];

public static A040419Inst Instance=new A040419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040420
{
public static readonly long[] Value={ 21L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L,42L };
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
public class A040420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040420Inst : IEnumerable<long>
{
public static readonly long[] Value=A040420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040420.Bytes);
public long this[int i]=>Value[i];

public static A040420Inst Instance=new A040420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040421
{
public static readonly long[] Value={ 21L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L,21L,42L };
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
public class A040421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040421Inst : IEnumerable<long>
{
public static readonly long[] Value=A040421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040421.Bytes);
public long this[int i]=>Value[i];

public static A040421Inst Instance=new A040421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040422
{
public static readonly long[] Value={ 21L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L,14L,42L };
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
public class A040422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040422Inst : IEnumerable<long>
{
public static readonly long[] Value=A040422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040422.Bytes);
public long this[int i]=>Value[i];

public static A040422Inst Instance=new A040422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040423
{
public static readonly long[] Value={ 21L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L,1L,1L,10L,42L,10L };
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
public class A040423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040423Inst : IEnumerable<long>
{
public static readonly long[] Value=A040423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040423.Bytes);
public long this[int i]=>Value[i];

public static A040423Inst Instance=new A040423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040424
{
public static readonly long[] Value={ 21L,8L,2L,2L,1L,3L,1L,1L,20L,1L,1L,3L,1L,2L,2L,8L,42L,8L,2L,2L,1L,3L,1L,1L,20L,1L,1L,3L,1L,2L,2L,8L,42L,8L,2L,2L,1L,3L,1L,1L,20L,1L,1L,3L,1L,2L,2L,8L,42L,8L,2L,2L,1L,3L,1L,1L,20L,1L,1L,3L,1L,2L,2L,8L,42L,8L,2L,2L,1L,3L,1L,1L,20L,1L,1L,3L,1L,2L,2L,8L,42L,8L,2L,2L,1L,3L,1L,1L };
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
public class A040424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040424Inst : IEnumerable<long>
{
public static readonly long[] Value=A040424.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040424.Bytes);
public long this[int i]=>Value[i];

public static A040424Inst Instance=new A040424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040425
{
public static readonly long[] Value={ 21L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L,7L,42L };
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
public class A040425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040425Inst : IEnumerable<long>
{
public static readonly long[] Value=A040425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040425.Bytes);
public long this[int i]=>Value[i];

public static A040425Inst Instance=new A040425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040426
{
public static readonly long[] Value={ 21L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L,6L,42L };
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
public class A040426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040426Inst : IEnumerable<long>
{
public static readonly long[] Value=A040426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040426.Bytes);
public long this[int i]=>Value[i];

public static A040426Inst Instance=new A040426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040427
{
public static readonly long[] Value={ 21L,5L,3L,1L,1L,1L,7L,1L,5L,5L,1L,7L,1L,1L,1L,3L,5L,42L,5L,3L,1L,1L,1L,7L,1L,5L,5L,1L,7L,1L,1L,1L,3L,5L,42L,5L,3L,1L,1L,1L,7L,1L,5L,5L,1L,7L,1L,1L,1L,3L,5L,42L,5L,3L,1L,1L,1L,7L,1L,5L,5L,1L,7L,1L,1L,1L,3L,5L,42L,5L,3L,1L,1L,1L,7L,1L,5L,5L,1L,7L,1L,1L,1L,3L,5L,42L,5L,3L,1L,1L };
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
public class A040427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040427Inst : IEnumerable<long>
{
public static readonly long[] Value=A040427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040427.Bytes);
public long this[int i]=>Value[i];

public static A040427Inst Instance=new A040427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040428
{
public static readonly long[] Value={ 21L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L,42L,4L,1L,2L,4L,2L,1L,4L };
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
public class A040428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040428Inst : IEnumerable<long>
{
public static readonly long[] Value=A040428.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040428.Bytes);
public long this[int i]=>Value[i];

public static A040428Inst Instance=new A040428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040461
{
public static readonly long[] Value={ 21L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L };
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
public class A040461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040461Inst : IEnumerable<long>
{
public static readonly long[] Value=A040461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040461.Bytes);
public long this[int i]=>Value[i];

public static A040461Inst Instance=new A040461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040462
{
public static readonly long[] Value={ 22L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L };
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
public class A040462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040462Inst : IEnumerable<long>
{
public static readonly long[] Value=A040462.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040462.Bytes);
public long this[int i]=>Value[i];

public static A040462Inst Instance=new A040462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040463
{
public static readonly long[] Value={ 22L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L };
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
public class A040463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040463Inst : IEnumerable<long>
{
public static readonly long[] Value=A040463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040463.Bytes);
public long this[int i]=>Value[i];

public static A040463Inst Instance=new A040463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040464
{
public static readonly long[] Value={ 22L,14L,1L,2L,4L,1L,1L,3L,2L,5L,1L,6L,1L,1L,21L,1L,1L,6L,1L,5L,2L,3L,1L,1L,4L,2L,1L,14L,44L,14L,1L,2L,4L,1L,1L,3L,2L,5L,1L,6L,1L,1L,21L,1L,1L,6L,1L,5L,2L,3L,1L,1L,4L,2L,1L,14L,44L,14L,1L,2L,4L,1L,1L,3L,2L,5L,1L,6L,1L,1L,21L,1L,1L,6L,1L,5L,2L,3L,1L,1L,4L,2L,1L,14L,44L,14L,1L };
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
public class A040464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040464Inst : IEnumerable<long>
{
public static readonly long[] Value=A040464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040464.Bytes);
public long this[int i]=>Value[i];

public static A040464Inst Instance=new A040464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040465
{
public static readonly long[] Value={ 22L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L };
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
public class A040465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040465Inst : IEnumerable<long>
{
public static readonly long[] Value=A040465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040465.Bytes);
public long this[int i]=>Value[i];

public static A040465Inst Instance=new A040465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040466
{
public static readonly long[] Value={ 22L,8L,1L,4L,1L,1L,1L,3L,2L,1L,2L,14L,2L,1L,2L,3L,1L,1L,1L,4L,1L,8L,44L,8L,1L,4L,1L,1L,1L,3L,2L,1L,2L,14L,2L,1L,2L,3L,1L,1L,1L,4L,1L,8L,44L,8L,1L,4L,1L,1L,1L,3L,2L,1L,2L,14L,2L,1L,2L,3L,1L,1L,1L,4L,1L,8L,44L,8L,1L,4L,1L,1L,1L,3L,2L,1L,2L,14L,2L,1L,2L,3L,1L,1L,1L,4L,1L,8L,44L,8L };
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
public class A040466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040466Inst : IEnumerable<long>
{
public static readonly long[] Value=A040466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040466.Bytes);
public long this[int i]=>Value[i];

public static A040466Inst Instance=new A040466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040467
{
public static readonly long[] Value={ 22L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L };
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
public class A040467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040467Inst : IEnumerable<long>
{
public static readonly long[] Value=A040467.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040467.Bytes);
public long this[int i]=>Value[i];

public static A040467Inst Instance=new A040467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040468
{
public static readonly long[] Value={ 22L,6L,3L,4L,8L,1L,1L,1L,2L,1L,1L,21L,1L,1L,2L,1L,1L,1L,8L,4L,3L,6L,44L,6L,3L,4L,8L,1L,1L,1L,2L,1L,1L,21L,1L,1L,2L,1L,1L,1L,8L,4L,3L,6L,44L,6L,3L,4L,8L,1L,1L,1L,2L,1L,1L,21L,1L,1L,2L,1L,1L,1L,8L,4L,3L,6L,44L,6L,3L,4L,8L,1L,1L,1L,2L,1L,1L,21L,1L,1L,2L,1L,1L,1L,8L,4L,3L,6L,44L,6L };
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
public class A040468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040468Inst : IEnumerable<long>
{
public static readonly long[] Value=A040468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040468.Bytes);
public long this[int i]=>Value[i];

public static A040468Inst Instance=new A040468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040469
{
public static readonly long[] Value={ 22L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L };
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
public class A040469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040469Inst : IEnumerable<long>
{
public static readonly long[] Value=A040469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040469.Bytes);
public long this[int i]=>Value[i];

public static A040469Inst Instance=new A040469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040470
{
public static readonly long[] Value={ 22L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L };
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
public class A040470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040470Inst : IEnumerable<long>
{
public static readonly long[] Value=A040470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040470.Bytes);
public long this[int i]=>Value[i];

public static A040470Inst Instance=new A040470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040471
{
public static readonly long[] Value={ 22L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L };
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
public class A040471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040471Inst : IEnumerable<long>
{
public static readonly long[] Value=A040471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040471.Bytes);
public long this[int i]=>Value[i];

public static A040471Inst Instance=new A040471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040472
{
public static readonly long[] Value={ 22L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L };
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
public class A040472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040472Inst : IEnumerable<long>
{
public static readonly long[] Value=A040472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040472.Bytes);
public long this[int i]=>Value[i];

public static A040472Inst Instance=new A040472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040473
{
public static readonly long[] Value={ 22L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L };
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
public class A040473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040473Inst : IEnumerable<long>
{
public static readonly long[] Value=A040473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040473.Bytes);
public long this[int i]=>Value[i];

public static A040473Inst Instance=new A040473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040474
{
public static readonly long[] Value={ 22L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L };
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
public class A040474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040474Inst : IEnumerable<long>
{
public static readonly long[] Value=A040474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040474.Bytes);
public long this[int i]=>Value[i];

public static A040474Inst Instance=new A040474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040475
{
public static readonly long[] Value={ 22L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L };
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
public class A040475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040475Inst : IEnumerable<long>
{
public static readonly long[] Value=A040475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040475.Bytes);
public long this[int i]=>Value[i];

public static A040475Inst Instance=new A040475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040476
{
public static readonly long[] Value={ 22L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L };
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
public class A040476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040476Inst : IEnumerable<long>
{
public static readonly long[] Value=A040476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040476.Bytes);
public long this[int i]=>Value[i];

public static A040476Inst Instance=new A040476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040493
{
public static readonly long[] Value={ 22L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L,14L,1L,1L,2L,1L,44L,1L,2L,1L,1L };
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
public class A040493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040493Inst : IEnumerable<long>
{
public static readonly long[] Value=A040493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040493.Bytes);
public long this[int i]=>Value[i];

public static A040493Inst Instance=new A040493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040494
{
public static readonly long[] Value={ 22L,1L,2L,1L,4L,3L,3L,2L,10L,1L,14L,4L,14L,1L,10L,2L,3L,3L,4L,1L,2L,1L,44L,1L,2L,1L,4L,3L,3L,2L,10L,1L,14L,4L,14L,1L,10L,2L,3L,3L,4L,1L,2L,1L,44L,1L,2L,1L,4L,3L,3L,2L,10L,1L,14L,4L,14L,1L,10L,2L,3L,3L,4L,1L,2L,1L,44L,1L,2L,1L,4L,3L,3L,2L,10L,1L,14L,4L,14L,1L,10L,2L,3L,3L };
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
public class A040494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040494Inst : IEnumerable<long>
{
public static readonly long[] Value=A040494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040494.Bytes);
public long this[int i]=>Value[i];

public static A040494Inst Instance=new A040494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040495
{
public static readonly long[] Value={ 22L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L,6L,3L,1L,44L,1L,3L };
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
public class A040495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040495Inst : IEnumerable<long>
{
public static readonly long[] Value=A040495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040495.Bytes);
public long this[int i]=>Value[i];

public static A040495Inst Instance=new A040495Inst();

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