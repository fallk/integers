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

public static class A040285
{
public static readonly long[] Value={ 17L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L,5L,2L,2L,34L,2L,2L };
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
public class A040285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040285Inst : IEnumerable<long>
{
public static readonly long[] Value=A040285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040285.Bytes);
public long this[int i]=>Value[i];

public static A040285Inst Instance=new A040285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040286
{
public static readonly long[] Value={ 17L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L,1L,1L,1L,2L,3L,2L,34L,2L,3L,2L,1L,1L };
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
public class A040286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040286Inst : IEnumerable<long>
{
public static readonly long[] Value=A040286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040286.Bytes);
public long this[int i]=>Value[i];

public static A040286Inst Instance=new A040286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040287
{
public static readonly long[] Value={ 17L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L,34L,2L,6L,2L };
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
public class A040287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040287Inst : IEnumerable<long>
{
public static readonly long[] Value=A040287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040287.Bytes);
public long this[int i]=>Value[i];

public static A040287Inst Instance=new A040287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040288
{
public static readonly long[] Value={ 17L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L,2L,34L };
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
public class A040288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040288Inst : IEnumerable<long>
{
public static readonly long[] Value=A040288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040288.Bytes);
public long this[int i]=>Value[i];

public static A040288Inst Instance=new A040288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040289
{
public static readonly long[] Value={ 17L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L,1L,1L,34L,1L,1L,11L,5L,1L,3L,17L,3L,1L,5L,11L };
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
public class A040289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040289Inst : IEnumerable<long>
{
public static readonly long[] Value=A040289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040289.Bytes);
public long this[int i]=>Value[i];

public static A040289Inst Instance=new A040289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040290
{
public static readonly long[] Value={ 17L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L,4L,1L,1L,34L,1L,1L };
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
public class A040290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040290Inst : IEnumerable<long>
{
public static readonly long[] Value=A040290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040290.Bytes);
public long this[int i]=>Value[i];

public static A040290Inst Instance=new A040290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040291
{
public static readonly long[] Value={ 17L,1L,1L,2L,1L,2L,4L,1L,1L,1L,8L,6L,1L,10L,1L,6L,8L,1L,1L,1L,4L,2L,1L,2L,1L,1L,34L,1L,1L,2L,1L,2L,4L,1L,1L,1L,8L,6L,1L,10L,1L,6L,8L,1L,1L,1L,4L,2L,1L,2L,1L,1L,34L,1L,1L,2L,1L,2L,4L,1L,1L,1L,8L,6L,1L,10L,1L,6L,8L,1L,1L,1L,4L,2L,1L,2L,1L,1L,34L,1L,1L,2L,1L,2L,4L,1L,1L,1L,8L,6L };
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
public class A040291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040291Inst : IEnumerable<long>
{
public static readonly long[] Value=A040291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040291.Bytes);
public long this[int i]=>Value[i];

public static A040291Inst Instance=new A040291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040292
{
public static readonly long[] Value={ 17L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L,3L,5L,1L,1L,1L,1L,34L,1L,1L,1L,1L,5L,3L,1L,2L,1L };
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
public class A040292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040292Inst : IEnumerable<long>
{
public static readonly long[] Value=A040292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040292.Bytes);
public long this[int i]=>Value[i];

public static A040292Inst Instance=new A040292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040293
{
public static readonly long[] Value={ 17L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L,17L,3L,6L,1L,2L,1L,1L,1L,34L,1L,1L,1L,2L,1L,6L,3L };
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
public class A040293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040293Inst : IEnumerable<long>
{
public static readonly long[] Value=A040293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040293.Bytes);
public long this[int i]=>Value[i];

public static A040293Inst Instance=new A040293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040294
{
public static readonly long[] Value={ 17L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L,34L,1L,1L,1L };
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
public class A040294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040294Inst : IEnumerable<long>
{
public static readonly long[] Value=A040294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040294.Bytes);
public long this[int i]=>Value[i];

public static A040294Inst Instance=new A040294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040295
{
public static readonly long[] Value={ 17L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L,1L,2L,4L,11L,1L,1L,3L,2L,2L,3L,1L,1L,11L,4L,2L,1L,34L };
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
public class A040295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040295Inst : IEnumerable<long>
{
public static readonly long[] Value=A040295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040295.Bytes);
public long this[int i]=>Value[i];

public static A040295Inst Instance=new A040295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040296
{
public static readonly long[] Value={ 17L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L,1L,1L,2L,1L,34L,1L,2L };
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
public class A040296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040296Inst : IEnumerable<long>
{
public static readonly long[] Value=A040296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040296.Bytes);
public long this[int i]=>Value[i];

public static A040296Inst Instance=new A040296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040297
{
public static readonly long[] Value={ 17L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L,34L,1L,2L,1L };
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
public class A040297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040297Inst : IEnumerable<long>
{
public static readonly long[] Value=A040297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040297.Bytes);
public long this[int i]=>Value[i];

public static A040297Inst Instance=new A040297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040298
{
public static readonly long[] Value={ 17L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L,34L,1L,3L,2L,8L,2L,3L,1L };
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
public class A040298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040298Inst : IEnumerable<long>
{
public static readonly long[] Value=A040298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040298.Bytes);
public long this[int i]=>Value[i];

public static A040298Inst Instance=new A040298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040299
{
public static readonly long[] Value={ 17L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L,4L,8L,1L,2L,2L,1L,8L,4L,1L,34L,1L };
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
public class A040299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040299Inst : IEnumerable<long>
{
public static readonly long[] Value=A040299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040299.Bytes);
public long this[int i]=>Value[i];

public static A040299Inst Instance=new A040299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040300
{
public static readonly long[] Value={ 17L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L,34L,1L,4L,1L };
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
public class A040300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040300Inst : IEnumerable<long>
{
public static readonly long[] Value=A040300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040300.Bytes);
public long this[int i]=>Value[i];

public static A040300Inst Instance=new A040300Inst();

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

public static class A040349
{
public static readonly long[] Value={ 19L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L,4L,7L,2L,3L,1L,4L,38L,4L,1L,3L,2L,7L };
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
public class A040349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040349Inst : IEnumerable<long>
{
public static readonly long[] Value=A040349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040349.Bytes);
public long this[int i]=>Value[i];

public static A040349Inst Instance=new A040349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040350
{
public static readonly long[] Value={ 19L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L,38L,4L,4L };
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
public class A040350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040350Inst : IEnumerable<long>
{
public static readonly long[] Value=A040350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040350.Bytes);
public long this[int i]=>Value[i];

public static A040350Inst Instance=new A040350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040351
{
public static readonly long[] Value={ 19L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L,4L,1L,3L,38L,3L,1L };
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
public class A040351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040351Inst : IEnumerable<long>
{
public static readonly long[] Value=A040351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040351.Bytes);
public long this[int i]=>Value[i];

public static A040351Inst Instance=new A040351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040352
{
public static readonly long[] Value={ 19L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L,12L,2L,3L,38L,3L,2L };
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
public class A040352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040352Inst : IEnumerable<long>
{
public static readonly long[] Value=A040352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040352.Bytes);
public long this[int i]=>Value[i];

public static A040352Inst Instance=new A040352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040353
{
public static readonly long[] Value={ 19L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L,38L,3L,5L,5L,3L };
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
public class A040353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040353Inst : IEnumerable<long>
{
public static readonly long[] Value=A040353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040353.Bytes);
public long this[int i]=>Value[i];

public static A040353Inst Instance=new A040353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040354
{
public static readonly long[] Value={ 19L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L,18L,1L,2L,38L,2L,1L };
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
public class A040354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040354Inst : IEnumerable<long>
{
public static readonly long[] Value=A040354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040354.Bytes);
public long this[int i]=>Value[i];

public static A040354Inst Instance=new A040354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040355
{
public static readonly long[] Value={ 19L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L,38L,2L,1L,2L,1L,5L,1L,2L,1L,2L };
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
public class A040355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040355Inst : IEnumerable<long>
{
public static readonly long[] Value=A040355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040355.Bytes);
public long this[int i]=>Value[i];

public static A040355Inst Instance=new A040355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040356
{
public static readonly long[] Value={ 19L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L,2L,1L,3L,1L,1L,2L,38L,2L,1L,1L,3L,1L,2L,2L,4L,2L };
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
public class A040356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040356Inst : IEnumerable<long>
{
public static readonly long[] Value=A040356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040356.Bytes);
public long this[int i]=>Value[i];

public static A040356Inst Instance=new A040356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040357
{
public static readonly long[] Value={ 19L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L,38L,2L,2L,2L };
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
public class A040357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040357Inst : IEnumerable<long>
{
public static readonly long[] Value=A040357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040357.Bytes);
public long this[int i]=>Value[i];

public static A040357Inst Instance=new A040357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040358
{
public static readonly long[] Value={ 19L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L,38L,2L,3L,1L,4L,1L,3L,2L };
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
public class A040358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040358Inst : IEnumerable<long>
{
public static readonly long[] Value=A040358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040358.Bytes);
public long this[int i]=>Value[i];

public static A040358Inst Instance=new A040358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040359
{
public static readonly long[] Value={ 19L,2L,7L,3L,2L,2L,6L,12L,1L,4L,1L,1L,1L,3L,4L,19L,4L,3L,1L,1L,1L,4L,1L,12L,6L,2L,2L,3L,7L,2L,38L,2L,7L,3L,2L,2L,6L,12L,1L,4L,1L,1L,1L,3L,4L,19L,4L,3L,1L,1L,1L,4L,1L,12L,6L,2L,2L,3L,7L,2L,38L,2L,7L,3L,2L,2L,6L,12L,1L,4L,1L,1L,1L,3L,4L,19L,4L,3L,1L,1L,1L,4L,1L,12L,6L,2L,2L };
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
public class A040359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040359Inst : IEnumerable<long>
{
public static readonly long[] Value=A040359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040359.Bytes);
public long this[int i]=>Value[i];

public static A040359Inst Instance=new A040359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040360
{
public static readonly long[] Value={ 19L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L,2L,38L };
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
public class A040360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040360Inst : IEnumerable<long>
{
public static readonly long[] Value=A040360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040360.Bytes);
public long this[int i]=>Value[i];

public static A040360Inst Instance=new A040360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040361
{
public static readonly long[] Value={ 19L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L,12L,1L,1L,38L,1L,1L };
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
public class A040361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040361Inst : IEnumerable<long>
{
public static readonly long[] Value=A040361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040361.Bytes);
public long this[int i]=>Value[i];

public static A040361Inst Instance=new A040361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040362
{
public static readonly long[] Value={ 19L,1L,1L,5L,12L,1L,5L,1L,1L,2L,3L,1L,18L,1L,3L,2L,1L,1L,5L,1L,12L,5L,1L,1L,38L,1L,1L,5L,12L,1L,5L,1L,1L,2L,3L,1L,18L,1L,3L,2L,1L,1L,5L,1L,12L,5L,1L,1L,38L,1L,1L,5L,12L,1L,5L,1L,1L,2L,3L,1L,18L,1L,3L,2L,1L,1L,5L,1L,12L,5L,1L,1L,38L,1L,1L,5L,12L,1L,5L,1L,1L,2L,3L,1L,18L,1L,3L };
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
public class A040362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040362Inst : IEnumerable<long>
{
public static readonly long[] Value=A040362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040362.Bytes);
public long this[int i]=>Value[i];

public static A040362Inst Instance=new A040362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040363
{
public static readonly long[] Value={ 19L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L,19L,3L,1L,1L,38L,1L,1L,3L };
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
public class A040363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040363Inst : IEnumerable<long>
{
public static readonly long[] Value=A040363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040363.Bytes);
public long this[int i]=>Value[i];

public static A040363Inst Instance=new A040363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040364
{
public static readonly long[] Value={ 19L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L,38L,1L,1L,2L,9L,2L,1L,1L };
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
public class A040364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040364Inst : IEnumerable<long>
{
public static readonly long[] Value=A040364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040364.Bytes);
public long this[int i]=>Value[i];

public static A040364Inst Instance=new A040364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040397
{
public static readonly long[] Value={ 20L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L,20L,4L,2L,40L,2L,4L };
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
public class A040397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040397Inst : IEnumerable<long>
{
public static readonly long[] Value=A040397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040397.Bytes);
public long this[int i]=>Value[i];

public static A040397Inst Instance=new A040397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040398
{
public static readonly long[] Value={ 20L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L,2L,40L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L,2L,40L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L,2L,40L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L,2L,40L,2L,7L,1L,2L,3L,1L,2L,1L,19L,1L,2L,1L,3L,2L,1L,7L };
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
public class A040398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040398Inst : IEnumerable<long>
{
public static readonly long[] Value=A040398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040398.Bytes);
public long this[int i]=>Value[i];

public static A040398Inst Instance=new A040398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040399
{
public static readonly long[] Value={ 20L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L,2L,40L };
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
public class A040399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040399Inst : IEnumerable<long>
{
public static readonly long[] Value=A040399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040399.Bytes);
public long this[int i]=>Value[i];

public static A040399Inst Instance=new A040399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040400
{
public static readonly long[] Value={ 20L,1L,1L,13L,5L,1L,3L,1L,2L,1L,1L,1L,2L,9L,1L,7L,3L,3L,2L,2L,3L,3L,7L,1L,9L,2L,1L,1L,1L,2L,1L,3L,1L,5L,13L,1L,1L,40L,1L,1L,13L,5L,1L,3L,1L,2L,1L,1L,1L,2L,9L,1L,7L,3L,3L,2L,2L,3L,3L,7L,1L,9L,2L,1L,1L,1L,2L,1L,3L,1L,5L,13L,1L,1L,40L,1L,1L,13L,5L,1L,3L,1L,2L,1L,1L,1L,2L,9L,1L,7L };
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
public class A040400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040400Inst : IEnumerable<long>
{
public static readonly long[] Value=A040400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040400.Bytes);
public long this[int i]=>Value[i];

public static A040400Inst Instance=new A040400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040401
{
public static readonly long[] Value={ 20L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L,5L,2L,1L,3L,20L,3L,1L,2L,5L,1L,1L,40L,1L,1L };
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
public class A040401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040401Inst : IEnumerable<long>
{
public static readonly long[] Value=A040401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040401.Bytes);
public long this[int i]=>Value[i];

public static A040401Inst Instance=new A040401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040402
{
public static readonly long[] Value={ 20L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L,40L,1L,1L,3L,4L,3L,1L,1L };
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
public class A040402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040402Inst : IEnumerable<long>
{
public static readonly long[] Value=A040402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040402.Bytes);
public long this[int i]=>Value[i];

public static A040402Inst Instance=new A040402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040403
{
public static readonly long[] Value={ 20L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L,1L,1L,2L,4L,5L,1L,1L,1L,9L,1L,1L,1L,5L,4L,2L,1L,1L,40L };
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
public class A040403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040403Inst : IEnumerable<long>
{
public static readonly long[] Value=A040403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040403.Bytes);
public long this[int i]=>Value[i];

public static A040403Inst Instance=new A040403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040404
{
public static readonly long[] Value={ 20L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L,1L,1L,1L,1L,40L,1L,1L };
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
public class A040404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040404Inst : IEnumerable<long>
{
public static readonly long[] Value=A040404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040404.Bytes);
public long this[int i]=>Value[i];

public static A040404Inst Instance=new A040404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040405
{
public static readonly long[] Value={ 20L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L,6L,2L,3L,1L,1L,1L,40L,1L,1L,1L,3L,2L };
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
public class A040405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040405Inst : IEnumerable<long>
{
public static readonly long[] Value=A040405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040405.Bytes);
public long this[int i]=>Value[i];

public static A040405Inst Instance=new A040405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040406
{
public static readonly long[] Value={ 20L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L,40L,1L,1L,1L };
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
public class A040406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040406Inst : IEnumerable<long>
{
public static readonly long[] Value=A040406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040406.Bytes);
public long this[int i]=>Value[i];

public static A040406Inst Instance=new A040406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040407
{
public static readonly long[] Value={ 20L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L,4L,1L,5L,10L,5L,1L,4L,2L,1L,40L,1L,2L };
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
public class A040407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040407Inst : IEnumerable<long>
{
public static readonly long[] Value=A040407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040407.Bytes);
public long this[int i]=>Value[i];

public static A040407Inst Instance=new A040407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040408
{
public static readonly long[] Value={ 20L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L,2L,9L,1L,12L,1L,9L,2L,2L,1L,40L,1L,2L };
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
public class A040408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040408Inst : IEnumerable<long>
{
public static readonly long[] Value=A040408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040408.Bytes);
public long this[int i]=>Value[i];

public static A040408Inst Instance=new A040408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040409
{
public static readonly long[] Value={ 20L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L,6L,8L,6L,1L,3L,1L,2L,1L,40L,1L,2L,1L,3L,1L };
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
public class A040409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040409Inst : IEnumerable<long>
{
public static readonly long[] Value=A040409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040409.Bytes);
public long this[int i]=>Value[i];

public static A040409Inst Instance=new A040409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040410
{
public static readonly long[] Value={ 20L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L,19L,1L,7L,2L,1L,5L,3L,1L,40L,1L,3L,5L,1L,2L,7L,1L };
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
public class A040410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040410Inst : IEnumerable<long>
{
public static readonly long[] Value=A040410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040410.Bytes);
public long this[int i]=>Value[i];

public static A040410Inst Instance=new A040410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040411
{
public static readonly long[] Value={ 20L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L,40L,1L,3L,1L,1L,1L,3L,1L };
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
public class A040411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040411Inst : IEnumerable<long>
{
public static readonly long[] Value=A040411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040411.Bytes);
public long this[int i]=>Value[i];

public static A040411Inst Instance=new A040411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040412
{
public static readonly long[] Value={ 20L,1L,4L,4L,2L,2L,1L,3L,13L,1L,1L,1L,1L,13L,3L,1L,2L,2L,4L,4L,1L,40L,1L,4L,4L,2L,2L,1L,3L,13L,1L,1L,1L,1L,13L,3L,1L,2L,2L,4L,4L,1L,40L,1L,4L,4L,2L,2L,1L,3L,13L,1L,1L,1L,1L,13L,3L,1L,2L,2L,4L,4L,1L,40L,1L,4L,4L,2L,2L,1L,3L,13L,1L,1L,1L,1L,13L,3L,1L,2L,2L,4L,4L,1L,40L,1L,4L };
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
public class A040412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040412Inst : IEnumerable<long>
{
public static readonly long[] Value=A040412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040412.Bytes);
public long this[int i]=>Value[i];

public static A040412Inst Instance=new A040412Inst();

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

public static class A040429
{
public static readonly long[] Value={ 21L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L,21L,8L,2L,4L,4L,42L,4L,4L,2L,8L };
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
public class A040429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040429Inst : IEnumerable<long>
{
public static readonly long[] Value=A040429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040429.Bytes);
public long this[int i]=>Value[i];

public static A040429Inst Instance=new A040429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040430
{
public static readonly long[] Value={ 21L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L,10L,3L,5L,1L,3L,42L,3L,1L,5L,3L };
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
public class A040430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040430Inst : IEnumerable<long>
{
public static readonly long[] Value=A040430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040430.Bytes);
public long this[int i]=>Value[i];

public static A040430Inst Instance=new A040430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040431
{
public static readonly long[] Value={ 21L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L,1L,3L,42L,3L,1L,1L,10L,14L,10L,1L };
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
public class A040431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040431Inst : IEnumerable<long>
{
public static readonly long[] Value=A040431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040431.Bytes);
public long this[int i]=>Value[i];

public static A040431Inst Instance=new A040431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040432
{
public static readonly long[] Value={ 21L,3L,3L,1L,13L,2L,3L,2L,1L,1L,4L,6L,1L,7L,1L,1L,1L,20L,1L,1L,1L,7L,1L,6L,4L,1L,1L,2L,3L,2L,13L,1L,3L,3L,42L,3L,3L,1L,13L,2L,3L,2L,1L,1L,4L,6L,1L,7L,1L,1L,1L,20L,1L,1L,1L,7L,1L,6L,4L,1L,1L,2L,3L,2L,13L,1L,3L,3L,42L,3L,3L,1L,13L,2L,3L,2L,1L,1L,4L,6L,1L,7L,1L,1L,1L,20L,1L,1L };
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
public class A040432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040432Inst : IEnumerable<long>
{
public static readonly long[] Value=A040432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040432.Bytes);
public long this[int i]=>Value[i];

public static A040432Inst Instance=new A040432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040433
{
public static readonly long[] Value={ 21L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L,3L,42L };
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
public class A040433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040433Inst : IEnumerable<long>
{
public static readonly long[] Value=A040433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040433.Bytes);
public long this[int i]=>Value[i];

public static A040433Inst Instance=new A040433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040434
{
public static readonly long[] Value={ 21L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L,4L,1L,2L,42L,2L,1L };
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
public class A040434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040434Inst : IEnumerable<long>
{
public static readonly long[] Value=A040434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040434.Bytes);
public long this[int i]=>Value[i];

public static A040434Inst Instance=new A040434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040435
{
public static readonly long[] Value={ 21L,2L,1L,1L,1L,5L,2L,13L,1L,3L,1L,4L,1L,1L,4L,1L,3L,1L,13L,2L,5L,1L,1L,1L,2L,42L,2L,1L,1L,1L,5L,2L,13L,1L,3L,1L,4L,1L,1L,4L,1L,3L,1L,13L,2L,5L,1L,1L,1L,2L,42L,2L,1L,1L,1L,5L,2L,13L,1L,3L,1L,4L,1L,1L,4L,1L,3L,1L,13L,2L,5L,1L,1L,1L,2L,42L,2L,1L,1L,1L,5L,2L,13L,1L,3L,1L,4L,1L };
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
public class A040435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040435Inst : IEnumerable<long>
{
public static readonly long[] Value=A040435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040435.Bytes);
public long this[int i]=>Value[i];

public static A040435Inst Instance=new A040435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040436
{
public static readonly long[] Value={ 21L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L,42L,2L,2L };
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
public class A040436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040436Inst : IEnumerable<long>
{
public static readonly long[] Value=A040436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040436.Bytes);
public long this[int i]=>Value[i];

public static A040436Inst Instance=new A040436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040437
{
public static readonly long[] Value={ 21L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L,21L,4L,1L,2L,2L,42L,2L,2L,1L,4L };
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
public class A040437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040437Inst : IEnumerable<long>
{
public static readonly long[] Value=A040437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040437.Bytes);
public long this[int i]=>Value[i];

public static A040437Inst Instance=new A040437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040438
{
public static readonly long[] Value={ 21L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L,3L,1L,2L,10L,2L,1L,3L,4L,2L,42L,2L,4L };
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
public class A040438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040438Inst : IEnumerable<long>
{
public static readonly long[] Value=A040438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040438.Bytes);
public long this[int i]=>Value[i];

public static A040438Inst Instance=new A040438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040439
{
public static readonly long[] Value={ 21L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,8L,2L,42L,2L,8L,10L,1L,1L,1L,1L,1L,1L };
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
public class A040439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040439Inst : IEnumerable<long>
{
public static readonly long[] Value=A040439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040439.Bytes);
public long this[int i]=>Value[i];

public static A040439Inst Instance=new A040439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040440
{
public static readonly long[] Value={ 21L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L,2L,42L };
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
public class A040440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040440Inst : IEnumerable<long>
{
public static readonly long[] Value=A040440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040440.Bytes);
public long this[int i]=>Value[i];

public static A040440Inst Instance=new A040440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040441
{
public static readonly long[] Value={ 21L,1L,1L,13L,1L,5L,4L,1L,1L,1L,1L,2L,2L,6L,1L,3L,21L,3L,1L,6L,2L,2L,1L,1L,1L,1L,4L,5L,1L,13L,1L,1L,42L,1L,1L,13L,1L,5L,4L,1L,1L,1L,1L,2L,2L,6L,1L,3L,21L,3L,1L,6L,2L,2L,1L,1L,1L,1L,4L,5L,1L,13L,1L,1L,42L,1L,1L,13L,1L,5L,4L,1L,1L,1L,1L,2L,2L,6L,1L,3L,21L,3L,1L,6L,2L,2L,1L,1L,1L };
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
public class A040441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040441Inst : IEnumerable<long>
{
public static readonly long[] Value=A040441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040441.Bytes);
public long this[int i]=>Value[i];

public static A040441Inst Instance=new A040441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040442
{
public static readonly long[] Value={ 21L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L,42L,1L,1L,5L,1L,1L,1L,5L,1L,1L };
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
public class A040442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040442Inst : IEnumerable<long>
{
public static readonly long[] Value=A040442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040442.Bytes);
public long this[int i]=>Value[i];

public static A040442Inst Instance=new A040442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040443
{
public static readonly long[] Value={ 21L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L,42L,1L,1L,3L,2L,2L,2L,3L,1L,1L };
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
public class A040443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040443Inst : IEnumerable<long>
{
public static readonly long[] Value=A040443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040443.Bytes);
public long this[int i]=>Value[i];

public static A040443Inst Instance=new A040443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040444
{
public static readonly long[] Value={ 21L,1L,1L,2L,2L,1L,2L,5L,1L,3L,1L,20L,1L,3L,1L,5L,2L,1L,2L,2L,1L,1L,42L,1L,1L,2L,2L,1L,2L,5L,1L,3L,1L,20L,1L,3L,1L,5L,2L,1L,2L,2L,1L,1L,42L,1L,1L,2L,2L,1L,2L,5L,1L,3L,1L,20L,1L,3L,1L,5L,2L,1L,2L,2L,1L,1L,42L,1L,1L,2L,2L,1L,2L,5L,1L,3L,1L,20L,1L,3L,1L,5L,2L,1L,2L,2L,1L,1L,42L,1L };
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
public class A040444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040444Inst : IEnumerable<long>
{
public static readonly long[] Value=A040444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040444.Bytes);
public long this[int i]=>Value[i];

public static A040444Inst Instance=new A040444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040445
{
public static readonly long[] Value={ 21L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L,1L,1L,3L,3L,21L,3L,3L,1L,1L,1L,1L,42L,1L,1L };
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
public class A040445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040445Inst : IEnumerable<long>
{
public static readonly long[] Value=A040445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040445.Bytes);
public long this[int i]=>Value[i];

public static A040445Inst Instance=new A040445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040446
{
public static readonly long[] Value={ 21L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L,42L,1L,1L,1L,2L,1L,1L,1L };
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
public class A040446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040446Inst : IEnumerable<long>
{
public static readonly long[] Value=A040446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040446.Bytes);
public long this[int i]=>Value[i];

public static A040446Inst Instance=new A040446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040447
{
public static readonly long[] Value={ 21L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L,1L,1L,10L,6L,10L,1L,1L,1L,42L,1L };
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
public class A040447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040447Inst : IEnumerable<long>
{
public static readonly long[] Value=A040447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040447.Bytes);
public long this[int i]=>Value[i];

public static A040447Inst Instance=new A040447Inst();

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