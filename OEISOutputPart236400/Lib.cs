using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011169
{
public static readonly long[] Value={ 2L,4L,2L,5L,8L,0L,4L,8L,3L,4L,3L,2L,3L,4L,6L,5L,4L,1L,8L,8L,0L,9L,8L,3L,0L,8L,2L,9L,7L,0L,3L,5L,5L,4L,7L,4L,3L,2L,6L,4L,3L,1L,2L,7L,4L,8L,2L,6L,1L,2L,9L,4L,4L,9L,7L,9L,0L,7L,3L,8L,8L,6L,4L,4L,8L,4L,4L,0L,4L,0L,7L,0L,7L,9L,2L,5L,9L,9L,4L,9L,6L,2L,9L,4L,5L,0L,5L,3L,3L,3L,9L,6L,0L,8L,8L,8L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011169Inst : IEnumerable<long>
{
public static readonly long[] Value=A011169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011169.Bytes);
public long this[int i]=>Value[i];

public static A011169Inst Instance=new A011169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011170
{
public static readonly long[] Value={ 2L,4L,3L,1L,5L,5L,3L,2L,5L,1L,4L,9L,4L,1L,2L,2L,3L,4L,6L,5L,1L,8L,7L,0L,1L,1L,7L,7L,3L,5L,3L,0L,7L,3L,0L,1L,4L,6L,5L,0L,5L,5L,4L,4L,3L,7L,4L,9L,3L,5L,1L,2L,3L,9L,3L,9L,5L,4L,9L,9L,7L,8L,8L,2L,0L,9L,0L,6L,4L,2L,3L,3L,4L,2L,1L,2L,7L,2L,1L,1L,6L,4L,8L,3L,4L,9L,0L,1L,1L,1L,9L,9L,2L,4L,2L,6L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011170Inst : IEnumerable<long>
{
public static readonly long[] Value=A011170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011170.Bytes);
public long this[int i]=>Value[i];

public static A011170Inst Instance=new A011170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011171
{
public static readonly long[] Value={ 2L,4L,3L,7L,2L,4L,7L,8L,1L,7L,9L,8L,8L,2L,2L,4L,0L,1L,1L,6L,0L,9L,0L,6L,4L,5L,5L,0L,9L,6L,1L,4L,4L,5L,1L,4L,6L,8L,7L,6L,0L,4L,3L,0L,0L,1L,0L,7L,8L,3L,5L,3L,3L,4L,7L,5L,3L,1L,5L,5L,7L,9L,9L,5L,9L,3L,8L,8L,8L,0L,2L,8L,4L,3L,7L,4L,6L,6L,9L,7L,1L,1L,4L,9L,9L,6L,3L,6L,2L,5L,8L,6L,7L,9L,1L,3L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011171Inst : IEnumerable<long>
{
public static readonly long[] Value=A011171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011171.Bytes);
public long this[int i]=>Value[i];

public static A011171Inst Instance=new A011171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011172
{
public static readonly long[] Value={ 2L,4L,4L,2L,8L,8L,9L,6L,5L,5L,7L,3L,7L,3L,9L,4L,0L,9L,7L,5L,5L,3L,0L,0L,2L,9L,1L,7L,6L,2L,9L,1L,3L,5L,9L,9L,5L,2L,3L,0L,9L,9L,6L,3L,9L,5L,7L,0L,6L,5L,6L,1L,2L,8L,5L,5L,8L,9L,4L,0L,1L,9L,8L,9L,3L,2L,7L,4L,8L,3L,8L,4L,2L,4L,5L,2L,1L,1L,1L,6L,3L,9L,0L,8L,7L,6L,4L,6L,6L,4L,7L,9L,9L,3L,3L,4L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011172Inst : IEnumerable<long>
{
public static readonly long[] Value=A011172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011172.Bytes);
public long this[int i]=>Value[i];

public static A011172Inst Instance=new A011172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011173
{
public static readonly long[] Value={ 2L,4L,4L,8L,4L,7L,9L,8L,5L,0L,7L,2L,8L,5L,4L,9L,2L,3L,7L,8L,7L,1L,0L,2L,3L,2L,9L,6L,9L,2L,7L,2L,6L,1L,2L,8L,6L,8L,2L,1L,2L,0L,2L,0L,5L,4L,4L,9L,4L,8L,4L,8L,8L,6L,8L,9L,4L,4L,4L,8L,4L,6L,5L,3L,9L,6L,3L,0L,9L,5L,1L,3L,1L,2L,5L,9L,8L,7L,4L,3L,7L,4L,9L,0L,3L,9L,1L,2L,5L,6L,6L,0L,5L,1L,4L,4L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011173Inst : IEnumerable<long>
{
public static readonly long[] Value=A011173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011173.Bytes);
public long this[int i]=>Value[i];

public static A011173Inst Instance=new A011173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011174
{
public static readonly long[] Value={ 2L,4L,5L,4L,0L,1L,9L,4L,5L,4L,5L,4L,9L,1L,3L,0L,5L,0L,3L,7L,1L,0L,1L,7L,8L,3L,7L,5L,9L,6L,1L,0L,2L,6L,6L,5L,5L,3L,9L,3L,2L,1L,4L,4L,8L,7L,8L,3L,0L,9L,7L,4L,1L,8L,6L,5L,5L,3L,2L,8L,0L,0L,6L,4L,7L,3L,9L,8L,4L,8L,4L,0L,5L,2L,0L,7L,9L,6L,8L,9L,3L,9L,2L,9L,3L,6L,6L,7L,6L,8L,9L,2L,2L,8L,5L,4L,0L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011174Inst : IEnumerable<long>
{
public static readonly long[] Value=A011174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011174.Bytes);
public long this[int i]=>Value[i];

public static A011174Inst Instance=new A011174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011175
{
public static readonly long[] Value={ 2L,4L,5L,9L,5L,0L,9L,4L,8L,5L,8L,4L,9L,3L,6L,3L,2L,5L,3L,0L,7L,0L,7L,2L,8L,9L,6L,8L,5L,5L,9L,2L,0L,6L,7L,7L,9L,4L,5L,3L,8L,8L,3L,9L,6L,4L,5L,4L,0L,9L,1L,9L,5L,6L,4L,3L,8L,1L,1L,0L,3L,4L,0L,4L,4L,4L,3L,9L,8L,1L,0L,7L,1L,7L,6L,4L,7L,3L,4L,0L,3L,9L,7L,5L,7L,3L,6L,3L,8L,8L,8L,8L,8L,0L,2L,7L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011175Inst : IEnumerable<long>
{
public static readonly long[] Value=A011175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011175.Bytes);
public long this[int i]=>Value[i];

public static A011175Inst Instance=new A011175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011176
{
public static readonly long[] Value={ 2L,4L,6L,4L,9L,5L,0L,9L,3L,1L,7L,2L,6L,8L,6L,9L,2L,0L,1L,1L,3L,7L,6L,9L,6L,7L,7L,0L,9L,8L,5L,5L,1L,0L,9L,1L,6L,1L,6L,0L,8L,3L,7L,9L,3L,8L,6L,5L,3L,3L,0L,1L,9L,6L,9L,5L,1L,6L,5L,1L,1L,4L,9L,6L,2L,2L,4L,4L,2L,4L,0L,2L,9L,4L,3L,4L,0L,4L,1L,7L,2L,6L,3L,5L,7L,6L,9L,6L,9L,1L,8L,1L,9L,4L,8L,2L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011176Inst : IEnumerable<long>
{
public static readonly long[] Value=A011176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011176.Bytes);
public long this[int i]=>Value[i];

public static A011176Inst Instance=new A011176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011177
{
public static readonly long[] Value={ 2L,4L,7L,0L,3L,4L,4L,7L,4L,9L,0L,3L,8L,5L,5L,8L,4L,4L,6L,9L,1L,3L,0L,9L,7L,0L,4L,9L,8L,6L,4L,2L,6L,3L,8L,1L,3L,2L,7L,0L,9L,2L,1L,6L,8L,2L,5L,0L,8L,8L,0L,6L,7L,2L,4L,2L,5L,7L,0L,2L,0L,7L,9L,2L,8L,8L,6L,9L,0L,0L,5L,5L,8L,2L,2L,5L,2L,3L,2L,5L,3L,9L,8L,9L,4L,6L,6L,5L,9L,2L,6L,3L,2L,9L,3L,0L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011177Inst : IEnumerable<long>
{
public static readonly long[] Value=A011177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011177.Bytes);
public long this[int i]=>Value[i];

public static A011177Inst Instance=new A011177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011178
{
public static readonly long[] Value={ 2L,4L,7L,5L,6L,9L,1L,8L,6L,5L,6L,4L,4L,3L,6L,6L,5L,0L,9L,7L,4L,6L,4L,9L,6L,2L,3L,4L,0L,5L,1L,8L,9L,8L,5L,0L,0L,1L,3L,7L,0L,2L,3L,7L,9L,0L,6L,8L,4L,4L,8L,4L,4L,3L,2L,8L,3L,8L,2L,3L,1L,0L,3L,2L,8L,3L,3L,9L,4L,0L,6L,0L,4L,3L,8L,8L,5L,3L,2L,5L,8L,5L,5L,2L,5L,3L,7L,5L,8L,5L,9L,8L,4L,0L,3L,9L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011178Inst : IEnumerable<long>
{
public static readonly long[] Value=A011178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011178.Bytes);
public long this[int i]=>Value[i];

public static A011178Inst Instance=new A011178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011179
{
public static readonly long[] Value={ 2L,4L,8L,0L,9L,9L,3L,1L,8L,1L,5L,8L,7L,0L,6L,9L,0L,3L,9L,1L,3L,9L,3L,1L,0L,1L,8L,7L,0L,8L,3L,4L,8L,6L,4L,2L,3L,5L,0L,8L,9L,8L,2L,9L,5L,6L,4L,7L,3L,4L,5L,0L,0L,1L,9L,1L,9L,0L,1L,4L,6L,8L,0L,9L,6L,3L,3L,4L,1L,6L,3L,3L,7L,9L,3L,5L,1L,6L,3L,7L,8L,3L,6L,4L,5L,4L,9L,8L,2L,5L,6L,6L,6L,6L,1L,1L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011179Inst : IEnumerable<long>
{
public static readonly long[] Value=A011179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011179.Bytes);
public long this[int i]=>Value[i];

public static A011179Inst Instance=new A011179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011180
{
public static readonly long[] Value={ 2L,4L,8L,6L,2L,4L,9L,5L,7L,0L,2L,1L,2L,1L,0L,1L,9L,3L,8L,2L,5L,3L,5L,8L,1L,8L,8L,8L,7L,3L,9L,3L,2L,0L,9L,3L,5L,5L,0L,6L,1L,7L,0L,9L,4L,6L,8L,5L,7L,3L,4L,9L,1L,9L,8L,3L,5L,7L,9L,5L,8L,7L,7L,9L,4L,4L,9L,6L,4L,4L,3L,8L,9L,8L,0L,4L,9L,3L,1L,4L,5L,6L,5L,5L,3L,2L,7L,9L,8L,2L,6L,3L,1L,6L,1L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011180Inst : IEnumerable<long>
{
public static readonly long[] Value=A011180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011180.Bytes);
public long this[int i]=>Value[i];

public static A011180Inst Instance=new A011180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011181
{
public static readonly long[] Value={ 2L,4L,9L,1L,4L,6L,1L,8L,7L,9L,2L,3L,1L,0L,3L,4L,6L,5L,1L,9L,3L,3L,3L,6L,0L,6L,7L,3L,2L,8L,0L,6L,1L,0L,1L,6L,1L,8L,7L,8L,6L,1L,9L,9L,8L,6L,1L,3L,7L,5L,5L,9L,6L,2L,2L,0L,9L,2L,3L,4L,6L,0L,2L,8L,7L,2L,1L,4L,9L,3L,3L,0L,7L,5L,5L,0L,9L,8L,7L,1L,3L,3L,2L,1L,1L,7L,9L,0L,2L,8L,9L,1L,7L,6L,2L,4L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011181Inst : IEnumerable<long>
{
public static readonly long[] Value=A011181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011181.Bytes);
public long this[int i]=>Value[i];

public static A011181Inst Instance=new A011181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011182
{
public static readonly long[] Value={ 2L,4L,9L,6L,6L,3L,0L,9L,3L,1L,7L,3L,2L,0L,8L,7L,0L,3L,7L,4L,2L,3L,6L,1L,7L,8L,6L,8L,1L,5L,5L,0L,8L,9L,7L,8L,6L,3L,5L,8L,2L,8L,1L,8L,2L,0L,1L,8L,5L,2L,8L,7L,1L,2L,5L,4L,4L,8L,1L,2L,5L,6L,9L,6L,1L,6L,5L,7L,3L,0L,4L,0L,2L,3L,6L,4L,7L,5L,7L,9L,0L,2L,1L,9L,6L,9L,0L,3L,7L,8L,4L,3L,3L,9L,0L,5L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011182Inst : IEnumerable<long>
{
public static readonly long[] Value=A011182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011182.Bytes);
public long this[int i]=>Value[i];

public static A011182Inst Instance=new A011182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011183
{
public static readonly long[] Value={ 2L,5L,0L,1L,7L,5L,7L,5L,2L,7L,1L,4L,0L,8L,4L,3L,5L,1L,3L,0L,8L,7L,2L,4L,4L,8L,5L,4L,9L,2L,6L,2L,9L,8L,3L,7L,2L,0L,6L,0L,4L,5L,7L,4L,7L,0L,6L,8L,0L,9L,7L,7L,9L,7L,9L,9L,3L,2L,6L,1L,3L,5L,7L,8L,6L,5L,1L,7L,1L,6L,3L,9L,7L,0L,0L,6L,1L,1L,8L,9L,9L,7L,4L,2L,2L,8L,0L,0L,7L,9L,8L,8L,3L,3L,3L,9L,8L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011183Inst : IEnumerable<long>
{
public static readonly long[] Value=A011183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011183.Bytes);
public long this[int i]=>Value[i];

public static A011183Inst Instance=new A011183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011184
{
public static readonly long[] Value={ 2L,5L,0L,6L,8L,4L,2L,4L,4L,2L,1L,3L,4L,1L,0L,0L,2L,2L,3L,9L,3L,2L,2L,6L,1L,6L,5L,2L,3L,6L,8L,4L,9L,2L,9L,2L,1L,0L,4L,2L,9L,2L,0L,4L,6L,5L,9L,6L,3L,1L,4L,4L,0L,0L,2L,5L,6L,9L,5L,4L,3L,0L,9L,1L,0L,2L,8L,8L,4L,3L,8L,0L,7L,2L,5L,1L,0L,1L,1L,4L,1L,6L,3L,1L,7L,6L,5L,7L,8L,3L,3L,0L,0L,1L,3L,2L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011184Inst : IEnumerable<long>
{
public static readonly long[] Value=A011184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011184.Bytes);
public long this[int i]=>Value[i];

public static A011184Inst Instance=new A011184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011185
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,13L,21L,30L,39L,53L,74L,95L,128L,152L,182L,212L,258L,316L,374L,413L,476L,531L,546L,608L,717L,798L,862L,965L,1060L,1161L,1307L,1386L,1435L,1556L,1722L,1834L,1934L,2058L,2261L,2497L,2699L,2874L,3061L,3197L,3332L,3629L,3712L,3868L,4140L,4447L,4640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011185Inst : IEnumerable<long>
{
public static readonly long[] Value=A011185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011185.Bytes);
public long this[int i]=>Value[i];

public static A011185Inst Instance=new A011185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011186
{
public static readonly long[] Value={ 1L,2L,1L,9L,0L,1L,3L,6L,5L,4L,2L,0L,4L,4L,7L,5L,4L,4L,0L,9L,1L,1L,6L,9L,1L,0L,0L,2L,5L,9L,2L,5L,6L,0L,8L,5L,7L,2L,7L,7L,4L,1L,1L,9L,3L,5L,8L,5L,9L,9L,6L,0L,8L,0L,6L,5L,9L,0L,9L,7L,1L,5L,1L,4L,8L,3L,2L,0L,6L,7L,2L,9L,5L,4L,5L,9L,6L,6L,7L,9L,9L,3L,8L,1L,7L,2L,5L,8L,1L,4L,0L,3L,1L,3L,7L,0L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011186Inst : IEnumerable<long>
{
public static readonly long[] Value=A011186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011186.Bytes);
public long this[int i]=>Value[i];

public static A011186Inst Instance=new A011186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011187
{
public static readonly long[] Value={ 3L,79L,457645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011187Inst : IEnumerable<long>
{
public static readonly long[] Value=A011187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011187.Bytes);
public long this[int i]=>Value[i];

public static A011187Inst Instance=new A011187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011188
{
public static readonly long[] Value={ 1L,1L,6L,6L,5L,2L,9L,0L,3L,9L,5L,7L,6L,1L,1L,6L,5L,8L,0L,8L,9L,3L,6L,9L,2L,6L,3L,4L,6L,6L,0L,6L,6L,8L,0L,6L,1L,4L,1L,7L,9L,0L,9L,1L,5L,3L,8L,9L,8L,8L,9L,8L,3L,5L,4L,9L,0L,9L,2L,6L,5L,7L,6L,1L,7L,7L,2L,3L,5L,4L,2L,2L,0L,4L,9L,0L,1L,7L,8L,1L,3L,9L,9L,4L,5L,0L,6L,2L,5L,4L,0L,8L,2L,7L,9L,4L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011188Inst : IEnumerable<long>
{
public static readonly long[] Value=A011188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011188.Bytes);
public long this[int i]=>Value[i];

public static A011188Inst Instance=new A011188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011189
{
public static readonly long[] Value={ 5L,5L,4L,7L,35L,12L,38L,70L,10L,82L,92L,118L,94L,121L,133L,184L,98L,306L,7L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011189Inst : IEnumerable<long>
{
public static readonly long[] Value=A011189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011189.Bytes);
public long this[int i]=>Value[i];

public static A011189Inst Instance=new A011189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011190
{
public static readonly long[] Value={ 1L,1L,3L,4L,3L,1L,2L,5L,2L,2L,1L,9L,5L,4L,6L,2L,5L,8L,0L,9L,9L,2L,4L,9L,7L,7L,3L,2L,9L,1L,7L,1L,1L,9L,1L,3L,8L,9L,3L,8L,3L,0L,1L,9L,2L,0L,7L,9L,6L,6L,9L,5L,9L,6L,2L,0L,1L,6L,1L,9L,2L,6L,6L,4L,3L,1L,8L,2L,8L,7L,1L,0L,5L,7L,7L,8L,0L,4L,9L,0L,0L,9L,0L,4L,8L,0L,3L,7L,0L,4L,8L,4L,1L,6L,3L,0L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011190Inst : IEnumerable<long>
{
public static readonly long[] Value=A011190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011190.Bytes);
public long this[int i]=>Value[i];

public static A011190Inst Instance=new A011190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011191
{
public static readonly long[] Value={ 6L,3L,7L,4L,18L,1L,21L,35L,76L,82L,56L,25L,98L,149L,111L,170L,166L,195L,113L,306L,221L,367L,533L,373L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011191Inst : IEnumerable<long>
{
public static readonly long[] Value=A011191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011191.Bytes);
public long this[int i]=>Value[i];

public static A011191Inst Instance=new A011191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011192
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,3L,1L,4L,7L,6L,0L,9L,6L,4L,8L,6L,9L,2L,0L,2L,6L,2L,0L,8L,8L,9L,7L,7L,1L,4L,9L,3L,9L,1L,3L,5L,3L,8L,4L,5L,0L,5L,3L,1L,7L,8L,1L,8L,0L,4L,8L,2L,0L,9L,7L,2L,1L,1L,8L,0L,4L,8L,4L,4L,0L,9L,0L,5L,5L,6L,2L,5L,2L,1L,0L,0L,5L,8L,2L,4L,1L,6L,2L,0L,0L,5L,8L,7L,7L,6L,8L,8L,8L,0L,4L,7L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011192Inst : IEnumerable<long>
{
public static readonly long[] Value=A011192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011192.Bytes);
public long this[int i]=>Value[i];

public static A011192Inst Instance=new A011192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011193
{
public static readonly long[] Value={ 2L,9L,16L,25L,2L,38L,16L,31L,93L,115L,112L,128L,117L,173L,254L,96L,15L,88L,235L,308L,13L,501L,151L,171L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011193Inst : IEnumerable<long>
{
public static readonly long[] Value=A011193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011193.Bytes);
public long this[int i]=>Value[i];

public static A011193Inst Instance=new A011193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011194
{
public static readonly long[] Value={ 1L,0L,9L,6L,8L,2L,4L,9L,7L,9L,6L,9L,4L,6L,2L,5L,9L,6L,0L,6L,8L,1L,4L,7L,1L,7L,7L,8L,0L,2L,8L,8L,0L,3L,3L,8L,7L,8L,2L,7L,8L,4L,7L,3L,2L,1L,5L,2L,7L,1L,4L,2L,3L,5L,0L,0L,4L,2L,0L,2L,6L,5L,9L,0L,5L,1L,1L,5L,2L,5L,7L,1L,8L,7L,2L,8L,1L,1L,2L,0L,9L,9L,3L,2L,1L,9L,0L,9L,2L,2L,7L,1L,0L,3L,9L,4L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011194Inst : IEnumerable<long>
{
public static readonly long[] Value=A011194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011194.Bytes);
public long this[int i]=>Value[i];

public static A011194Inst Instance=new A011194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011195
{
public static readonly long[] Value={ 0L,4L,35L,140L,390L,880L,1729L,3080L,5100L,7980L,11935L,17204L,24050L,32760L,43645L,57040L,73304L,92820L,115995L,143260L,175070L,211904L,254265L,302680L,357700L,419900L,489879L,568260L,655690L,752840L,860405L,979104L,1109680L,1252900L,1409555L,1580460L,1766454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011195Inst : IEnumerable<long>
{
public static readonly long[] Value=A011195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011195.Bytes);
public long this[int i]=>Value[i];

public static A011195Inst Instance=new A011195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011196
{
public static readonly long[] Value={ 1L,0L,8L,4L,9L,6L,3L,9L,1L,3L,6L,4L,3L,6L,3L,7L,1L,2L,9L,6L,6L,7L,0L,7L,7L,5L,2L,3L,8L,7L,5L,4L,5L,4L,8L,4L,7L,6L,1L,1L,6L,8L,6L,3L,6L,9L,4L,7L,7L,6L,5L,0L,7L,7L,5L,2L,3L,8L,0L,6L,9L,2L,6L,4L,4L,3L,2L,3L,3L,2L,8L,8L,3L,7L,8L,7L,6L,0L,4L,3L,1L,9L,5L,6L,3L,5L,9L,3L,5L,9L,0L,3L,9L,9L,2L,5L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011196Inst : IEnumerable<long>
{
public static readonly long[] Value=A011196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011196.Bytes);
public long this[int i]=>Value[i];

public static A011196Inst Instance=new A011196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011197
{
public static readonly long[] Value={ 0L,20L,315L,1820L,6630L,18480L,43225L,89320L,168300L,295260L,489335L,774180L,1178450L,1736280L,2487765L,3479440L,4764760L,6404580L,8467635L,11031020L,14180670L,18011840L,22629585L,28149240L,34696900L,42409900L,51437295L,61940340L,74092970L,88082280L,104109005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011197Inst : IEnumerable<long>
{
public static readonly long[] Value=A011197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011197.Bytes);
public long this[int i]=>Value[i];

public static A011197Inst Instance=new A011197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011214
{
public static readonly long[] Value={ 1L,0L,8L,3L,7L,9L,8L,3L,8L,6L,7L,3L,4L,3L,6L,8L,1L,3L,9L,8L,3L,9L,2L,3L,3L,4L,8L,4L,9L,2L,6L,4L,8L,6L,5L,5L,5L,4L,7L,3L,3L,8L,7L,2L,8L,4L,3L,3L,5L,9L,7L,0L,5L,6L,7L,2L,7L,7L,1L,1L,6L,9L,8L,6L,5L,7L,6L,4L,5L,8L,8L,6L,5L,6L,1L,5L,7L,5L,0L,3L,1L,2L,5L,1L,0L,8L,5L,0L,0L,6L,8L,4L,3L,2L,1L,2L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011214Inst : IEnumerable<long>
{
public static readonly long[] Value=A011214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011214.Bytes);
public long this[int i]=>Value[i];

public static A011214Inst Instance=new A011214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011215
{
public static readonly long[] Value={ 1L,3L,4L,8L,0L,0L,6L,1L,5L,4L,5L,9L,7L,2L,7L,7L,6L,6L,7L,3L,7L,4L,2L,3L,6L,3L,1L,3L,9L,0L,3L,0L,7L,8L,6L,7L,5L,5L,3L,6L,4L,9L,7L,8L,3L,0L,2L,6L,6L,4L,6L,2L,2L,8L,4L,6L,6L,6L,3L,0L,1L,8L,8L,3L,3L,6L,7L,2L,7L,5L,7L,7L,8L,7L,7L,6L,5L,5L,4L,8L,1L,4L,9L,2L,6L,8L,6L,8L,0L,2L,3L,8L,4L,2L,4L,1L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011215Inst : IEnumerable<long>
{
public static readonly long[] Value=A011215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011215.Bytes);
public long this[int i]=>Value[i];

public static A011215Inst Instance=new A011215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011216
{
public static readonly long[] Value={ 1L,2L,9L,1L,7L,0L,8L,3L,4L,2L,0L,9L,0L,7L,4L,6L,6L,0L,6L,8L,2L,7L,5L,0L,9L,7L,5L,5L,3L,6L,5L,4L,7L,7L,9L,8L,1L,9L,0L,7L,0L,6L,8L,7L,3L,3L,4L,5L,9L,7L,3L,7L,3L,6L,2L,8L,1L,1L,4L,5L,6L,0L,7L,1L,9L,0L,8L,5L,0L,5L,1L,7L,8L,4L,9L,0L,8L,8L,1L,2L,1L,6L,6L,6L,9L,3L,4L,0L,3L,4L,4L,4L,0L,9L,5L,0L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011216Inst : IEnumerable<long>
{
public static readonly long[] Value=A011216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011216.Bytes);
public long this[int i]=>Value[i];

public static A011216Inst Instance=new A011216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011217
{
public static readonly long[] Value={ 1L,2L,5L,1L,0L,3L,3L,4L,0L,4L,8L,5L,9L,0L,7L,3L,8L,2L,3L,6L,7L,8L,0L,4L,3L,7L,1L,7L,7L,7L,9L,8L,4L,7L,2L,5L,2L,8L,8L,8L,5L,6L,1L,0L,6L,1L,8L,6L,1L,1L,5L,2L,4L,2L,3L,8L,5L,8L,8L,7L,9L,6L,6L,2L,6L,3L,3L,3L,1L,4L,6L,0L,5L,0L,4L,5L,4L,0L,0L,3L,9L,1L,1L,7L,7L,6L,7L,3L,0L,4L,4L,3L,7L,5L,6L,5L,8L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011217Inst : IEnumerable<long>
{
public static readonly long[] Value=A011217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011217.Bytes);
public long this[int i]=>Value[i];

public static A011217Inst Instance=new A011217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011218
{
public static readonly long[] Value={ 1L,2L,2L,0L,2L,8L,4L,9L,3L,5L,8L,7L,2L,8L,1L,0L,4L,5L,6L,0L,5L,7L,9L,5L,4L,8L,5L,1L,0L,1L,1L,8L,3L,8L,3L,2L,4L,0L,1L,7L,3L,5L,8L,4L,6L,9L,3L,2L,6L,1L,3L,2L,5L,0L,7L,0L,1L,9L,7L,3L,6L,0L,1L,4L,7L,6L,3L,2L,7L,7L,5L,9L,7L,0L,5L,7L,7L,3L,2L,4L,7L,4L,2L,8L,9L,1L,2L,0L,0L,9L,8L,4L,8L,9L,7L,6L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011218Inst : IEnumerable<long>
{
public static readonly long[] Value=A011218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011218.Bytes);
public long this[int i]=>Value[i];

public static A011218Inst Instance=new A011218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011219
{
public static readonly long[] Value={ 1L,1L,9L,6L,2L,3L,1L,1L,9L,8L,8L,5L,1L,3L,1L,5L,4L,8L,9L,7L,3L,3L,8L,1L,9L,1L,4L,3L,4L,1L,3L,7L,7L,3L,6L,7L,1L,5L,3L,7L,5L,4L,9L,9L,1L,7L,4L,1L,1L,5L,8L,7L,1L,1L,5L,7L,5L,5L,6L,7L,5L,7L,6L,1L,7L,8L,5L,2L,8L,5L,5L,7L,0L,5L,6L,6L,2L,9L,9L,4L,1L,7L,6L,8L,2L,0L,2L,4L,4L,6L,8L,9L,9L,3L,4L,9L,0L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011219Inst : IEnumerable<long>
{
public static readonly long[] Value=A011219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011219.Bytes);
public long this[int i]=>Value[i];

public static A011219Inst Instance=new A011219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011220
{
public static readonly long[] Value={ 1L,1L,7L,6L,9L,0L,3L,9L,5L,6L,2L,4L,2L,8L,5L,2L,7L,0L,8L,9L,2L,5L,3L,2L,6L,4L,2L,1L,6L,8L,1L,7L,9L,7L,8L,5L,2L,8L,3L,1L,9L,3L,7L,8L,1L,2L,9L,3L,8L,4L,4L,4L,3L,1L,3L,4L,0L,3L,0L,2L,7L,0L,1L,8L,9L,6L,9L,9L,7L,9L,2L,8L,9L,8L,5L,4L,3L,0L,0L,5L,2L,0L,3L,9L,5L,4L,6L,1L,6L,0L,4L,3L,9L,3L,9L,4L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011220Inst : IEnumerable<long>
{
public static readonly long[] Value=A011220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011220.Bytes);
public long this[int i]=>Value[i];

public static A011220Inst Instance=new A011220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011221
{
public static readonly long[] Value={ 1L,1L,6L,1L,0L,3L,6L,6L,7L,2L,3L,7L,3L,9L,9L,4L,2L,5L,1L,9L,3L,7L,9L,6L,3L,1L,6L,7L,7L,2L,1L,7L,3L,4L,9L,8L,1L,0L,3L,8L,2L,9L,3L,8L,6L,4L,0L,5L,2L,9L,1L,7L,2L,3L,0L,3L,5L,1L,6L,7L,8L,8L,3L,5L,9L,6L,5L,6L,1L,5L,7L,3L,0L,2L,0L,1L,3L,7L,4L,6L,1L,7L,4L,6L,7L,1L,0L,2L,0L,1L,9L,3L,8L,3L,0L,6L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011221Inst : IEnumerable<long>
{
public static readonly long[] Value=A011221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011221.Bytes);
public long this[int i]=>Value[i];

public static A011221Inst Instance=new A011221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011222
{
public static readonly long[] Value={ 1L,1L,4L,7L,7L,7L,7L,7L,1L,5L,4L,3L,4L,7L,9L,8L,6L,0L,3L,0L,5L,8L,7L,6L,5L,7L,4L,2L,5L,3L,2L,6L,0L,1L,6L,4L,1L,2L,2L,7L,3L,9L,2L,4L,5L,7L,1L,1L,5L,2L,7L,2L,4L,5L,0L,6L,3L,0L,6L,2L,9L,1L,9L,0L,7L,6L,6L,8L,1L,5L,4L,8L,9L,9L,3L,1L,9L,6L,8L,7L,1L,7L,3L,2L,6L,2L,7L,0L,0L,9L,4L,6L,1L,0L,9L,7L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011222Inst : IEnumerable<long>
{
public static readonly long[] Value=A011222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011222.Bytes);
public long this[int i]=>Value[i];

public static A011222Inst Instance=new A011222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011223
{
public static readonly long[] Value={ 1L,1L,3L,6L,5L,3L,3L,4L,7L,6L,0L,0L,9L,7L,2L,4L,3L,2L,0L,1L,7L,8L,0L,6L,0L,1L,1L,0L,6L,3L,8L,8L,1L,4L,3L,7L,0L,8L,6L,9L,0L,8L,5L,1L,0L,0L,1L,9L,6L,8L,9L,5L,2L,2L,3L,2L,0L,2L,0L,3L,9L,1L,2L,3L,2L,5L,6L,3L,3L,2L,3L,5L,4L,5L,4L,3L,1L,8L,1L,0L,9L,1L,7L,6L,7L,0L,4L,0L,0L,5L,6L,9L,8L,8L,2L,9L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011223Inst : IEnumerable<long>
{
public static readonly long[] Value=A011223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011223.Bytes);
public long this[int i]=>Value[i];

public static A011223Inst Instance=new A011223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011224
{
public static readonly long[] Value={ 1L,1L,2L,6L,8L,7L,7L,6L,1L,0L,1L,9L,0L,8L,2L,6L,4L,2L,4L,8L,3L,0L,0L,9L,1L,3L,9L,0L,1L,5L,3L,1L,0L,5L,7L,3L,9L,4L,6L,5L,0L,2L,8L,5L,8L,3L,5L,9L,1L,9L,6L,2L,3L,9L,1L,8L,0L,3L,5L,1L,7L,7L,0L,5L,7L,0L,3L,0L,3L,1L,8L,5L,2L,5L,0L,2L,2L,8L,7L,1L,9L,9L,3L,2L,6L,5L,2L,0L,1L,7L,1L,2L,5L,8L,0L,5L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011224Inst : IEnumerable<long>
{
public static readonly long[] Value=A011224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011224.Bytes);
public long this[int i]=>Value[i];

public static A011224Inst Instance=new A011224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011225
{
public static readonly long[] Value={ 1L,1L,1L,8L,4L,9L,6L,0L,4L,5L,9L,7L,3L,8L,2L,1L,8L,5L,9L,9L,2L,8L,7L,5L,5L,8L,0L,6L,5L,9L,9L,5L,4L,2L,3L,1L,6L,1L,0L,4L,6L,3L,6L,8L,2L,0L,5L,6L,7L,5L,7L,7L,3L,4L,8L,5L,6L,3L,5L,1L,5L,0L,1L,6L,7L,9L,9L,7L,8L,7L,0L,0L,4L,7L,9L,7L,5L,2L,6L,0L,0L,4L,6L,4L,1L,1L,0L,1L,2L,1L,5L,6L,8L,3L,4L,4L,4L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011225Inst : IEnumerable<long>
{
public static readonly long[] Value=A011225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011225.Bytes);
public long this[int i]=>Value[i];

public static A011225Inst Instance=new A011225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011226
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,2L,3L,3L,4L,2L,9L,7L,0L,4L,2L,5L,1L,8L,7L,6L,3L,3L,1L,7L,4L,9L,3L,8L,3L,1L,8L,3L,9L,1L,0L,1L,1L,0L,9L,2L,2L,8L,7L,4L,1L,7L,9L,4L,6L,7L,7L,4L,7L,1L,7L,8L,4L,5L,8L,5L,7L,3L,0L,3L,4L,9L,6L,4L,3L,3L,6L,9L,0L,3L,1L,5L,0L,6L,7L,0L,2L,1L,0L,6L,6L,2L,4L,7L,8L,3L,0L,4L,9L,3L,0L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011226Inst : IEnumerable<long>
{
public static readonly long[] Value=A011226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011226.Bytes);
public long this[int i]=>Value[i];

public static A011226Inst Instance=new A011226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011227
{
public static readonly long[] Value={ 1L,1L,0L,4L,6L,6L,5L,0L,7L,8L,5L,9L,7L,4L,9L,5L,2L,9L,4L,2L,7L,0L,9L,7L,2L,7L,9L,1L,7L,8L,0L,3L,7L,0L,7L,1L,6L,2L,0L,1L,0L,5L,3L,5L,8L,5L,9L,5L,8L,3L,8L,8L,6L,5L,3L,1L,3L,5L,0L,5L,3L,3L,6L,7L,3L,9L,7L,8L,1L,5L,4L,1L,5L,5L,2L,2L,8L,5L,3L,7L,2L,2L,2L,9L,7L,7L,4L,1L,6L,5L,2L,4L,8L,3L,6L,7L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011227Inst : IEnumerable<long>
{
public static readonly long[] Value=A011227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011227.Bytes);
public long this[int i]=>Value[i];

public static A011227Inst Instance=new A011227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011228
{
public static readonly long[] Value={ 1L,0L,9L,8L,8L,9L,2L,8L,0L,2L,7L,6L,5L,5L,2L,4L,7L,0L,5L,4L,7L,1L,1L,1L,2L,8L,4L,8L,2L,5L,3L,5L,2L,5L,8L,4L,1L,7L,5L,6L,4L,9L,6L,2L,5L,8L,3L,4L,2L,1L,1L,5L,6L,3L,6L,1L,9L,9L,7L,0L,8L,9L,7L,0L,0L,0L,1L,2L,0L,6L,7L,8L,6L,3L,6L,9L,0L,4L,1L,6L,6L,1L,2L,5L,1L,4L,0L,7L,3L,8L,9L,4L,7L,4L,8L,5L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011228Inst : IEnumerable<long>
{
public static readonly long[] Value=A011228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011228.Bytes);
public long this[int i]=>Value[i];

public static A011228Inst Instance=new A011228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011229
{
public static readonly long[] Value={ 1L,0L,9L,3L,7L,2L,3L,5L,4L,7L,7L,2L,6L,4L,4L,2L,3L,8L,3L,2L,5L,3L,4L,0L,7L,5L,4L,8L,3L,4L,5L,8L,9L,0L,6L,5L,3L,0L,6L,6L,5L,4L,7L,4L,9L,3L,5L,1L,8L,8L,2L,3L,4L,4L,0L,6L,4L,9L,4L,0L,7L,6L,0L,7L,7L,6L,4L,9L,5L,9L,0L,5L,0L,2L,3L,1L,7L,3L,1L,2L,2L,8L,1L,7L,6L,8L,4L,3L,3L,0L,2L,6L,2L,6L,9L,8L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011229Inst : IEnumerable<long>
{
public static readonly long[] Value=A011229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011229.Bytes);
public long this[int i]=>Value[i];

public static A011229Inst Instance=new A011229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011230
{
public static readonly long[] Value={ 1L,3L,8L,3L,0L,8L,7L,5L,5L,4L,2L,6L,8L,4L,8L,8L,4L,9L,2L,6L,4L,0L,6L,5L,8L,5L,1L,3L,5L,3L,4L,8L,2L,2L,5L,9L,0L,8L,7L,7L,0L,4L,2L,7L,3L,6L,2L,1L,0L,2L,5L,1L,1L,4L,8L,7L,1L,9L,0L,8L,4L,2L,9L,2L,5L,3L,9L,7L,5L,8L,7L,5L,9L,4L,5L,4L,9L,0L,7L,9L,5L,4L,8L,5L,5L,1L,4L,6L,4L,7L,8L,4L,7L,3L,3L,4L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011230Inst : IEnumerable<long>
{
public static readonly long[] Value=A011230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011230.Bytes);
public long this[int i]=>Value[i];

public static A011230Inst Instance=new A011230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011231
{
public static readonly long[] Value={ 1L,3L,2L,0L,4L,6L,9L,2L,4L,7L,7L,5L,6L,1L,2L,3L,7L,9L,1L,8L,0L,9L,3L,2L,7L,3L,3L,1L,5L,0L,0L,2L,6L,3L,0L,8L,2L,7L,3L,6L,6L,0L,0L,1L,5L,1L,9L,7L,3L,3L,5L,8L,2L,5L,1L,8L,0L,2L,6L,6L,1L,2L,8L,8L,3L,5L,4L,6L,7L,1L,7L,4L,3L,6L,5L,2L,8L,9L,1L,9L,8L,5L,5L,3L,3L,7L,2L,8L,8L,2L,4L,0L,9L,4L,6L,7L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011231Inst : IEnumerable<long>
{
public static readonly long[] Value=A011231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011231.Bytes);
public long this[int i]=>Value[i];

public static A011231Inst Instance=new A011231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011232
{
public static readonly long[] Value={ 1L,2L,7L,5L,3L,7L,3L,1L,0L,6L,8L,5L,8L,4L,5L,4L,0L,8L,5L,3L,8L,6L,0L,0L,9L,7L,5L,0L,4L,5L,8L,7L,9L,2L,2L,7L,3L,4L,5L,3L,7L,0L,4L,7L,5L,5L,3L,9L,6L,7L,7L,0L,4L,2L,7L,5L,5L,2L,3L,6L,1L,3L,2L,2L,9L,6L,9L,5L,0L,6L,9L,6L,1L,9L,3L,9L,9L,3L,9L,9L,4L,8L,3L,6L,1L,6L,7L,6L,0L,1L,4L,9L,0L,8L,0L,5L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011232Inst : IEnumerable<long>
{
public static readonly long[] Value=A011232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011232.Bytes);
public long this[int i]=>Value[i];

public static A011232Inst Instance=new A011232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011233
{
public static readonly long[] Value={ 1L,2L,4L,1L,3L,6L,5L,8L,1L,7L,0L,1L,5L,2L,0L,8L,6L,7L,7L,5L,7L,6L,6L,2L,6L,3L,9L,1L,2L,9L,5L,0L,9L,3L,6L,2L,2L,9L,6L,7L,5L,9L,6L,7L,0L,0L,5L,5L,1L,5L,3L,2L,4L,2L,2L,3L,7L,5L,0L,8L,9L,4L,2L,3L,8L,6L,0L,1L,8L,6L,8L,2L,3L,3L,8L,1L,3L,9L,6L,9L,3L,0L,4L,5L,7L,9L,6L,0L,3L,6L,5L,9L,4L,2L,8L,0L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011233Inst : IEnumerable<long>
{
public static readonly long[] Value=A011233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011233.Bytes);
public long this[int i]=>Value[i];

public static A011233Inst Instance=new A011233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011234
{
public static readonly long[] Value={ 1L,2L,1L,4L,8L,1L,4L,0L,4L,4L,0L,3L,9L,0L,6L,6L,9L,3L,9L,3L,9L,8L,7L,4L,7L,3L,8L,1L,4L,0L,5L,0L,9L,1L,2L,9L,0L,7L,1L,8L,3L,8L,8L,0L,3L,5L,0L,6L,4L,1L,2L,7L,5L,4L,3L,5L,5L,6L,2L,5L,1L,1L,8L,0L,5L,9L,5L,0L,3L,3L,6L,5L,8L,2L,2L,3L,7L,1L,7L,4L,7L,9L,9L,0L,9L,7L,2L,5L,9L,8L,4L,6L,9L,0L,0L,0L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011234Inst : IEnumerable<long>
{
public static readonly long[] Value=A011234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011234.Bytes);
public long this[int i]=>Value[i];

public static A011234Inst Instance=new A011234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011235
{
public static readonly long[] Value={ 1L,1L,9L,3L,5L,1L,2L,8L,3L,7L,1L,6L,9L,6L,2L,0L,2L,5L,0L,8L,1L,7L,6L,2L,7L,5L,5L,4L,0L,3L,5L,8L,5L,8L,6L,9L,2L,3L,7L,4L,8L,0L,9L,3L,2L,4L,8L,4L,6L,6L,1L,4L,5L,5L,8L,1L,6L,2L,2L,4L,5L,1L,8L,6L,6L,9L,4L,7L,8L,4L,0L,6L,3L,0L,7L,1L,0L,1L,6L,2L,4L,9L,1L,6L,1L,8L,0L,8L,9L,5L,3L,1L,1L,7L,3L,4L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011235Inst : IEnumerable<long>
{
public static readonly long[] Value=A011235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011235.Bytes);
public long this[int i]=>Value[i];

public static A011235Inst Instance=new A011235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011236
{
public static readonly long[] Value={ 1L,1L,7L,6L,0L,4L,7L,4L,2L,8L,5L,7L,9L,5L,1L,4L,5L,9L,9L,4L,3L,3L,6L,6L,3L,8L,8L,7L,3L,1L,1L,3L,8L,0L,8L,9L,8L,7L,3L,7L,4L,0L,4L,5L,7L,2L,4L,7L,7L,8L,7L,9L,6L,2L,6L,6L,4L,2L,7L,1L,2L,2L,4L,1L,7L,2L,4L,4L,6L,4L,6L,0L,0L,4L,5L,7L,2L,2L,8L,7L,1L,9L,8L,6L,0L,4L,6L,9L,3L,8L,8L,0L,7L,4L,1L,4L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011236Inst : IEnumerable<long>
{
public static readonly long[] Value=A011236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011236.Bytes);
public long this[int i]=>Value[i];

public static A011236Inst Instance=new A011236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011237
{
public static readonly long[] Value={ 1L,1L,6L,1L,4L,6L,8L,7L,8L,2L,6L,1L,3L,1L,0L,5L,6L,5L,9L,5L,0L,6L,5L,9L,7L,7L,8L,4L,8L,5L,9L,2L,4L,0L,8L,6L,5L,7L,9L,8L,3L,4L,7L,6L,2L,4L,1L,7L,5L,9L,4L,9L,1L,7L,1L,8L,8L,9L,7L,4L,0L,2L,5L,9L,1L,2L,4L,2L,9L,0L,6L,9L,6L,1L,4L,2L,0L,1L,0L,5L,3L,8L,6L,7L,7L,4L,6L,5L,3L,8L,4L,8L,6L,2L,6L,7L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011237Inst : IEnumerable<long>
{
public static readonly long[] Value=A011237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011237.Bytes);
public long this[int i]=>Value[i];

public static A011237Inst Instance=new A011237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011238
{
public static readonly long[] Value={ 1L,1L,4L,9L,1L,1L,6L,7L,2L,5L,0L,3L,5L,4L,1L,7L,7L,1L,0L,4L,1L,9L,3L,1L,0L,5L,0L,0L,1L,0L,9L,9L,5L,0L,5L,1L,3L,1L,5L,3L,9L,5L,3L,2L,9L,6L,4L,7L,3L,1L,7L,8L,4L,0L,4L,0L,8L,3L,7L,2L,2L,9L,1L,0L,9L,9L,5L,8L,4L,3L,5L,7L,4L,0L,3L,0L,1L,0L,8L,7L,6L,3L,0L,3L,1L,3L,3L,9L,5L,7L,9L,2L,1L,5L,4L,8L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011238Inst : IEnumerable<long>
{
public static readonly long[] Value=A011238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011238.Bytes);
public long this[int i]=>Value[i];

public static A011238Inst Instance=new A011238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011239
{
public static readonly long[] Value={ 1L,1L,3L,8L,5L,1L,7L,9L,1L,6L,4L,2L,9L,3L,6L,4L,2L,9L,7L,1L,7L,0L,6L,7L,4L,1L,3L,3L,9L,4L,9L,5L,8L,1L,1L,8L,7L,6L,1L,5L,1L,3L,3L,9L,3L,5L,7L,3L,4L,6L,9L,1L,8L,7L,2L,7L,7L,2L,1L,2L,7L,0L,7L,5L,1L,0L,3L,1L,2L,7L,1L,6L,2L,5L,8L,5L,9L,4L,8L,8L,1L,8L,7L,9L,6L,4L,4L,2L,5L,8L,0L,4L,6L,1L,8L,4L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011239Inst : IEnumerable<long>
{
public static readonly long[] Value=A011239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011239.Bytes);
public long this[int i]=>Value[i];

public static A011239Inst Instance=new A011239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011240
{
public static readonly long[] Value={ 1L,1L,2L,9L,3L,2L,4L,1L,8L,1L,4L,7L,2L,4L,6L,5L,4L,5L,4L,1L,7L,0L,0L,5L,7L,3L,6L,8L,6L,1L,7L,8L,2L,1L,9L,2L,4L,4L,5L,7L,9L,5L,8L,6L,6L,2L,4L,0L,9L,6L,1L,4L,3L,2L,8L,3L,3L,3L,1L,6L,9L,9L,5L,2L,6L,6L,8L,5L,9L,5L,1L,0L,8L,5L,8L,6L,0L,7L,8L,7L,8L,9L,3L,1L,6L,4L,4L,2L,3L,5L,1L,7L,7L,8L,4L,9L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011240Inst : IEnumerable<long>
{
public static readonly long[] Value=A011240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011240.Bytes);
public long this[int i]=>Value[i];

public static A011240Inst Instance=new A011240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011241
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,7L,3L,7L,3L,5L,4L,2L,5L,9L,4L,5L,5L,3L,9L,7L,9L,0L,5L,1L,8L,1L,8L,0L,4L,6L,2L,8L,9L,2L,2L,3L,2L,8L,1L,8L,3L,9L,3L,5L,0L,5L,4L,7L,1L,6L,8L,9L,1L,0L,1L,9L,9L,8L,2L,8L,3L,0L,9L,7L,7L,0L,3L,8L,2L,4L,6L,1L,8L,6L,5L,0L,6L,9L,0L,9L,3L,7L,4L,3L,4L,7L,7L,2L,8L,8L,1L,0L,4L,2L,1L,8L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011241Inst : IEnumerable<long>
{
public static readonly long[] Value=A011241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011241.Bytes);
public long this[int i]=>Value[i];

public static A011241Inst Instance=new A011241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011242
{
public static readonly long[] Value={ 1L,1L,1L,4L,1L,6L,5L,9L,7L,3L,7L,2L,8L,8L,7L,3L,4L,2L,9L,7L,2L,4L,3L,5L,6L,6L,5L,7L,7L,3L,8L,7L,0L,6L,1L,0L,7L,2L,7L,8L,0L,2L,3L,9L,7L,1L,7L,8L,0L,0L,0L,7L,4L,2L,2L,0L,9L,5L,1L,0L,5L,8L,4L,1L,3L,9L,2L,2L,9L,4L,0L,7L,8L,6L,7L,4L,2L,4L,8L,2L,3L,5L,1L,3L,9L,7L,7L,8L,5L,2L,5L,5L,1L,6L,0L,3L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011242Inst : IEnumerable<long>
{
public static readonly long[] Value=A011242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011242.Bytes);
public long this[int i]=>Value[i];

public static A011242Inst Instance=new A011242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011243
{
public static readonly long[] Value={ 1L,1L,0L,7L,8L,4L,4L,5L,9L,7L,6L,2L,1L,8L,0L,1L,1L,3L,5L,8L,9L,7L,1L,7L,0L,5L,4L,5L,5L,9L,7L,7L,9L,1L,4L,2L,5L,8L,9L,8L,2L,1L,1L,0L,6L,0L,2L,8L,1L,7L,4L,3L,8L,4L,2L,5L,8L,8L,5L,4L,6L,4L,6L,3L,1L,9L,4L,3L,3L,4L,5L,0L,7L,5L,9L,8L,0L,8L,8L,5L,1L,6L,1L,7L,5L,4L,5L,0L,3L,8L,2L,2L,9L,2L,8L,7L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011243Inst : IEnumerable<long>
{
public static readonly long[] Value=A011243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011243.Bytes);
public long this[int i]=>Value[i];

public static A011243Inst Instance=new A011243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011244
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,8L,6L,0L,2L,9L,6L,8L,7L,8L,5L,0L,3L,5L,2L,8L,5L,7L,9L,9L,7L,1L,1L,1L,0L,6L,5L,8L,2L,1L,7L,9L,1L,6L,2L,1L,9L,8L,9L,3L,2L,3L,6L,3L,4L,3L,6L,7L,8L,0L,3L,2L,7L,8L,7L,9L,3L,5L,8L,3L,4L,3L,5L,4L,8L,3L,7L,5L,8L,1L,8L,4L,9L,5L,3L,8L,8L,3L,2L,4L,5L,0L,2L,3L,4L,5L,1L,5L,3L,9L,7L,0L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011244Inst : IEnumerable<long>
{
public static readonly long[] Value=A011244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011244.Bytes);
public long this[int i]=>Value[i];

public static A011244Inst Instance=new A011244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011245
{
public static readonly long[] Value={ 1L,120L,945L,3640L,9945L,22176L,43225L,76560L,126225L,196840L,293601L,422280L,589225L,801360L,1066185L,1391776L,1786785L,2260440L,2822545L,3483480L,4254201L,5146240L,6171705L,7343280L,8674225L,10178376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011245Inst : IEnumerable<long>
{
public static readonly long[] Value=A011245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011245.Bytes);
public long this[int i]=>Value[i];

public static A011245Inst Instance=new A011245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011246
{
public static readonly long[] Value={ 1L,3L,4L,5L,9L,0L,0L,1L,9L,2L,6L,3L,2L,3L,5L,6L,1L,3L,1L,9L,4L,2L,8L,3L,2L,6L,0L,3L,7L,5L,0L,9L,4L,1L,9L,0L,4L,3L,6L,6L,2L,4L,7L,0L,2L,6L,7L,7L,7L,4L,7L,6L,7L,2L,3L,2L,5L,0L,2L,8L,3L,1L,3L,1L,8L,8L,8L,5L,0L,0L,2L,0L,8L,2L,9L,3L,5L,4L,8L,7L,5L,2L,9L,3L,3L,9L,8L,8L,1L,9L,5L,3L,8L,7L,7L,1L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011246Inst : IEnumerable<long>
{
public static readonly long[] Value=A011246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011246.Bytes);
public long this[int i]=>Value[i];

public static A011246Inst Instance=new A011246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011247
{
public static readonly long[] Value={ 1L,2L,9L,6L,8L,3L,9L,5L,5L,4L,6L,5L,1L,0L,0L,9L,6L,6L,5L,9L,3L,3L,7L,5L,4L,1L,1L,7L,7L,9L,2L,4L,5L,1L,1L,5L,9L,8L,3L,5L,3L,4L,5L,1L,4L,9L,4L,2L,4L,9L,6L,5L,5L,1L,2L,8L,0L,7L,7L,9L,0L,5L,2L,2L,6L,2L,9L,0L,1L,4L,6L,2L,5L,6L,4L,7L,3L,4L,4L,3L,5L,5L,6L,1L,4L,5L,9L,5L,9L,0L,7L,5L,7L,2L,3L,9L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011247Inst : IEnumerable<long>
{
public static readonly long[] Value=A011247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011247.Bytes);
public long this[int i]=>Value[i];

public static A011247Inst Instance=new A011247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011248
{
public static readonly BigInteger[] Value={ 2L,2L,10L,122L,2770L,101042L,5405530L,398721962L,38783024290L,4809759350882L,740742376475050L,138697748786275802L,BigInteger.Parse("31029068327114173810"),BigInteger.Parse("8174145018586247784722") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011248Inst Instance=new A011248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011249
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,4L,4L,4L,1L,3L,3L,4L,4L,9L,1L,6L,2L,8L,4L,4L,9L,9L,3L,9L,3L,0L,6L,9L,1L,6L,7L,7L,4L,3L,1L,0L,9L,8L,7L,6L,1L,3L,7L,7L,6L,1L,1L,0L,0L,8L,1L,7L,7L,9L,4L,3L,3L,7L,0L,6L,5L,5L,3L,8L,2L,4L,6L,1L,0L,0L,7L,1L,9L,7L,1L,9L,3L,5L,8L,4L,5L,8L,4L,0L,4L,0L,2L,2L,7L,4L,9L,6L,5L,0L,8L,9L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011249Inst : IEnumerable<long>
{
public static readonly long[] Value=A011249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011249.Bytes);
public long this[int i]=>Value[i];

public static A011249Inst Instance=new A011249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011250
{
public static readonly long[] Value={ 1L,2L,0L,8L,0L,8L,9L,4L,4L,4L,4L,0L,4L,4L,4L,7L,3L,1L,3L,2L,8L,9L,2L,4L,2L,2L,1L,0L,4L,7L,6L,2L,4L,7L,5L,6L,5L,0L,0L,3L,6L,8L,1L,3L,5L,7L,9L,0L,4L,2L,6L,6L,1L,9L,4L,1L,5L,1L,1L,3L,6L,0L,7L,1L,2L,3L,5L,8L,5L,6L,3L,1L,7L,0L,5L,0L,3L,5L,0L,6L,4L,7L,0L,9L,4L,3L,8L,2L,5L,8L,6L,5L,6L,8L,2L,6L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011250Inst : IEnumerable<long>
{
public static readonly long[] Value=A011250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011250.Bytes);
public long this[int i]=>Value[i];

public static A011250Inst Instance=new A011250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011251
{
public static readonly long[] Value={ 312L,560L,588L,1400L,85632L,147492L,556160L,569328L,1590816L,2013216L,3343776L,4695456L,9745728L,12558912L,22013952L,23336172L,30002960L,52021242L,75007400L,137617728L,153587720L,699117024L,904683264L,2468053248L,2834395104L,21669802880L,48444151296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011251Inst : IEnumerable<long>
{
public static readonly long[] Value=A011251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011251.Bytes);
public long this[int i]=>Value[i];

public static A011251Inst Instance=new A011251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011252
{
public static readonly long[] Value={ 1L,1L,7L,3L,4L,6L,0L,4L,6L,0L,0L,0L,4L,6L,2L,6L,3L,9L,1L,0L,9L,5L,4L,4L,1L,7L,5L,2L,9L,8L,5L,3L,2L,6L,9L,8L,9L,1L,2L,8L,8L,2L,3L,6L,0L,9L,4L,1L,1L,6L,7L,4L,0L,9L,5L,2L,5L,7L,1L,4L,0L,1L,1L,8L,0L,5L,6L,3L,8L,9L,3L,4L,9L,7L,6L,5L,5L,2L,8L,3L,5L,2L,2L,6L,5L,0L,2L,2L,0L,1L,3L,5L,5L,5L,4L,4L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011252Inst : IEnumerable<long>
{
public static readonly long[] Value=A011252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011252.Bytes);
public long this[int i]=>Value[i];

public static A011252Inst Instance=new A011252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011253
{
public static readonly long[] Value={ 1L,1L,6L,0L,1L,2L,9L,3L,8L,6L,1L,6L,0L,1L,6L,2L,7L,9L,7L,5L,3L,0L,0L,5L,9L,4L,9L,7L,1L,9L,0L,5L,5L,1L,7L,5L,7L,9L,0L,2L,1L,0L,4L,8L,6L,6L,2L,4L,8L,8L,7L,5L,5L,5L,4L,8L,1L,2L,6L,4L,2L,5L,0L,3L,0L,6L,2L,6L,7L,8L,2L,3L,8L,4L,8L,2L,8L,9L,2L,5L,6L,0L,7L,1L,6L,0L,3L,9L,9L,4L,3L,6L,0L,7L,3L,1L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011253Inst : IEnumerable<long>
{
public static readonly long[] Value=A011253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011253.Bytes);
public long this[int i]=>Value[i];

public static A011253Inst Instance=new A011253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011254
{
public static readonly long[] Value={ 23760L,59400L,153720L,4563000L,45326160L,113315400L,402831360L,731601000L,803685120L,865950624L,919501200L,1178491680L,3504597120L,3786686400L,6429564000L,14924714400L,25310621952L,26998616736L,53138687040L,86955675840L,513969369984L,1054373308800L,1868445408960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011254Inst : IEnumerable<long>
{
public static readonly long[] Value=A011254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011254.Bytes);
public long this[int i]=>Value[i];

public static A011254Inst Instance=new A011254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011255
{
public static readonly long[] Value={ 1L,1L,3L,8L,7L,8L,8L,6L,3L,4L,7L,5L,6L,6L,9L,1L,6L,5L,3L,7L,0L,3L,8L,3L,0L,2L,8L,3L,8L,4L,1L,5L,1L,1L,2L,5L,4L,7L,2L,0L,2L,4L,3L,1L,0L,6L,2L,6L,7L,1L,6L,9L,5L,0L,3L,8L,6L,1L,7L,9L,5L,4L,1L,2L,4L,9L,5L,2L,1L,7L,7L,3L,4L,3L,9L,4L,5L,2L,4L,8L,9L,6L,0L,2L,2L,7L,9L,5L,4L,0L,3L,4L,3L,0L,1L,0L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011255Inst : IEnumerable<long>
{
public static readonly long[] Value=A011255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011255.Bytes);
public long this[int i]=>Value[i];

public static A011255Inst Instance=new A011255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011256
{
public static readonly long[] Value={ 1L,1L,3L,0L,1L,1L,5L,7L,8L,3L,4L,2L,9L,3L,2L,9L,8L,2L,7L,9L,1L,6L,4L,2L,0L,8L,6L,8L,1L,5L,1L,7L,3L,4L,7L,7L,8L,0L,7L,0L,8L,8L,0L,8L,3L,7L,1L,6L,6L,1L,6L,8L,2L,3L,5L,9L,6L,1L,5L,4L,1L,0L,8L,1L,5L,2L,5L,2L,0L,5L,8L,9L,9L,6L,3L,1L,4L,3L,1L,7L,8L,9L,9L,3L,3L,0L,0L,2L,0L,2L,1L,7L,4L,7L,9L,7L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011256Inst : IEnumerable<long>
{
public static readonly long[] Value=A011256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011256.Bytes);
public long this[int i]=>Value[i];

public static A011256Inst Instance=new A011256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011257
{
public static readonly long[] Value={ 1L,14L,30L,51L,105L,170L,194L,248L,264L,364L,405L,418L,477L,595L,679L,714L,760L,780L,1023L,1455L,1463L,1485L,1496L,1512L,1524L,1674L,1715L,1731L,1796L,1804L,2058L,2080L,2651L,2754L,2945L,3080L,3135L,3192L,3410L,3534L,3567L,3596L,3828L,3956L,4064L,4381L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011257Inst : IEnumerable<long>
{
public static readonly long[] Value=A011257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011257.Bytes);
public long this[int i]=>Value[i];

public static A011257Inst Instance=new A011257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011258
{
public static readonly long[] Value={ 1L,1L,1L,5L,6L,5L,7L,9L,1L,7L,7L,6L,1L,5L,4L,3L,6L,6L,6L,8L,8L,5L,8L,0L,9L,9L,9L,4L,0L,1L,9L,1L,1L,2L,2L,0L,8L,5L,4L,3L,1L,9L,6L,8L,4L,7L,6L,8L,1L,6L,8L,4L,2L,9L,5L,9L,4L,1L,1L,4L,3L,1L,1L,2L,1L,7L,4L,7L,9L,4L,2L,6L,8L,0L,1L,4L,5L,4L,6L,2L,6L,7L,8L,0L,0L,4L,2L,5L,6L,9L,1L,3L,0L,9L,4L,6L,5L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011258Inst : IEnumerable<long>
{
public static readonly long[] Value=A011258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011258.Bytes);
public long this[int i]=>Value[i];

public static A011258Inst Instance=new A011258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011259
{
public static readonly long[] Value={ 1L,1L,0L,9L,5L,6L,9L,4L,7L,2L,0L,6L,7L,8L,4L,5L,0L,0L,8L,4L,8L,9L,3L,7L,8L,3L,5L,7L,7L,3L,0L,6L,3L,6L,6L,6L,6L,4L,5L,5L,6L,7L,3L,1L,6L,5L,4L,2L,2L,1L,8L,5L,4L,1L,0L,8L,9L,6L,1L,3L,7L,1L,6L,4L,3L,9L,3L,1L,5L,5L,7L,6L,1L,3L,7L,7L,1L,9L,8L,1L,1L,9L,5L,7L,3L,7L,4L,8L,4L,2L,3L,9L,0L,9L,0L,7L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011259Inst : IEnumerable<long>
{
public static readonly long[] Value=A011259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011259.Bytes);
public long this[int i]=>Value[i];

public static A011259Inst Instance=new A011259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011260
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,6L,18L,16L,48L,60L,176L,144L,630L,756L,1800L,2048L,7710L,7776L,27594L,24000L,84672L,120032L,356960L,276480L,1296000L,1719900L,4202496L,4741632L,18407808L,17820000L,69273666L,67108864L,211016256L,336849900L,929275200L,725594112L,3697909056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011260Inst : IEnumerable<long>
{
public static readonly long[] Value=A011260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011260.Bytes);
public long this[int i]=>Value[i];

public static A011260Inst Instance=new A011260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011261
{
public static readonly long[] Value={ 1L,3L,6L,8L,7L,3L,8L,1L,0L,6L,6L,4L,2L,2L,0L,1L,6L,7L,4L,8L,4L,2L,3L,6L,7L,7L,8L,8L,6L,6L,4L,0L,2L,9L,6L,5L,3L,0L,4L,9L,7L,8L,6L,9L,7L,9L,8L,1L,9L,0L,8L,2L,5L,9L,9L,3L,4L,9L,9L,2L,0L,2L,4L,3L,0L,2L,7L,7L,4L,4L,9L,2L,9L,5L,9L,9L,3L,5L,1L,6L,0L,4L,8L,5L,9L,7L,5L,8L,8L,5L,5L,5L,6L,0L,3L,0L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011261Inst : IEnumerable<long>
{
public static readonly long[] Value=A011261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011261.Bytes);
public long this[int i]=>Value[i];

public static A011261Inst Instance=new A011261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011278
{
public static readonly long[] Value={ 1L,2L,9L,1L,5L,4L,9L,6L,6L,5L,0L,1L,4L,8L,8L,3L,8L,7L,5L,4L,1L,0L,0L,7L,5L,5L,4L,6L,4L,7L,2L,0L,8L,7L,5L,4L,2L,9L,7L,5L,9L,5L,5L,2L,6L,3L,1L,6L,0L,7L,8L,2L,5L,1L,0L,3L,0L,5L,4L,9L,8L,7L,2L,3L,6L,3L,5L,4L,5L,2L,2L,6L,7L,5L,4L,4L,4L,6L,6L,3L,4L,0L,6L,5L,5L,7L,0L,2L,0L,0L,1L,6L,7L,9L,4L,6L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011278Inst : IEnumerable<long>
{
public static readonly long[] Value=A011278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011278.Bytes);
public long this[int i]=>Value[i];

public static A011278Inst Instance=new A011278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011279
{
public static readonly long[] Value={ 1L,2L,5L,8L,9L,2L,5L,4L,1L,1L,7L,9L,4L,1L,6L,7L,2L,1L,0L,4L,2L,3L,9L,5L,4L,1L,0L,6L,3L,9L,5L,8L,0L,0L,6L,0L,6L,0L,9L,3L,6L,1L,7L,4L,0L,9L,4L,6L,6L,9L,3L,1L,0L,6L,9L,1L,0L,7L,9L,2L,3L,0L,1L,9L,5L,2L,6L,6L,4L,7L,6L,1L,5L,7L,8L,2L,5L,0L,2L,0L,2L,4L,1L,2L,1L,0L,5L,0L,9L,6L,6L,2L,7L,5L,9L,4L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011279Inst : IEnumerable<long>
{
public static readonly long[] Value=A011279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011279.Bytes);
public long this[int i]=>Value[i];

public static A011279Inst Instance=new A011279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011280
{
public static readonly long[] Value={ 1L,2L,3L,2L,8L,4L,6L,7L,3L,9L,4L,4L,2L,0L,6L,6L,1L,3L,9L,0L,5L,3L,4L,0L,0L,7L,8L,9L,7L,3L,0L,9L,4L,8L,0L,2L,2L,7L,6L,9L,9L,7L,5L,3L,4L,8L,3L,2L,0L,1L,5L,8L,9L,3L,0L,5L,3L,0L,9L,2L,0L,2L,1L,9L,7L,1L,3L,2L,3L,9L,8L,9L,7L,2L,4L,7L,4L,4L,2L,3L,7L,1L,7L,7L,6L,2L,8L,0L,1L,6L,4L,9L,9L,8L,2L,5L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011280Inst : IEnumerable<long>
{
public static readonly long[] Value=A011280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011280.Bytes);
public long this[int i]=>Value[i];

public static A011280Inst Instance=new A011280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011281
{
public static readonly long[] Value={ 1L,2L,1L,1L,5L,2L,7L,6L,5L,8L,6L,2L,8L,5L,8L,8L,4L,4L,6L,3L,5L,8L,6L,0L,2L,9L,3L,3L,3L,2L,2L,9L,3L,8L,2L,2L,7L,7L,5L,0L,3L,2L,0L,1L,1L,6L,8L,1L,3L,3L,0L,6L,2L,6L,2L,5L,8L,2L,0L,3L,4L,4L,1L,5L,3L,9L,6L,5L,3L,5L,8L,2L,6L,0L,4L,0L,3L,3L,7L,8L,5L,6L,3L,1L,8L,2L,8L,4L,4L,5L,0L,5L,8L,4L,9L,2L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011281Inst : IEnumerable<long>
{
public static readonly long[] Value=A011281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011281.Bytes);
public long this[int i]=>Value[i];

public static A011281Inst Instance=new A011281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011282
{
public static readonly long[] Value={ 1L,1L,9L,3L,7L,7L,6L,6L,4L,1L,7L,1L,4L,4L,3L,6L,5L,0L,6L,0L,9L,1L,6L,8L,1L,5L,7L,4L,0L,5L,7L,7L,2L,5L,6L,4L,9L,2L,3L,4L,4L,4L,0L,5L,9L,6L,0L,6L,9L,7L,7L,8L,9L,3L,5L,8L,5L,6L,6L,1L,6L,9L,5L,1L,0L,6L,2L,1L,7L,9L,8L,4L,5L,9L,6L,7L,1L,5L,1L,0L,9L,5L,0L,0L,8L,8L,9L,8L,0L,9L,8L,7L,1L,8L,4L,7L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011282Inst : IEnumerable<long>
{
public static readonly long[] Value=A011282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011282.Bytes);
public long this[int i]=>Value[i];

public static A011282Inst Instance=new A011282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011283
{
public static readonly long[] Value={ 1L,1L,7L,8L,7L,6L,8L,6L,3L,4L,7L,9L,3L,5L,8L,7L,3L,1L,9L,2L,3L,1L,3L,8L,5L,4L,7L,9L,8L,8L,7L,2L,0L,6L,8L,9L,6L,8L,6L,2L,9L,6L,5L,5L,5L,5L,8L,1L,2L,7L,0L,5L,1L,7L,8L,3L,6L,8L,1L,5L,4L,5L,1L,7L,3L,0L,4L,8L,5L,1L,4L,9L,6L,7L,1L,6L,2L,8L,1L,4L,0L,7L,6L,5L,7L,9L,6L,5L,8L,9L,5L,8L,4L,5L,8L,5L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011283Inst : IEnumerable<long>
{
public static readonly long[] Value=A011283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011283.Bytes);
public long this[int i]=>Value[i];

public static A011283Inst Instance=new A011283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011284
{
public static readonly long[] Value={ 1L,1L,6L,5L,9L,1L,4L,4L,0L,1L,1L,7L,9L,8L,3L,1L,7L,3L,6L,1L,4L,9L,1L,5L,2L,3L,9L,6L,8L,9L,5L,7L,6L,9L,8L,7L,6L,8L,0L,5L,1L,3L,2L,0L,5L,8L,7L,8L,2L,9L,3L,6L,5L,7L,6L,0L,0L,7L,6L,4L,3L,6L,3L,7L,8L,9L,9L,7L,2L,8L,7L,9L,4L,9L,6L,8L,8L,2L,1L,5L,0L,1L,6L,1L,2L,0L,8L,7L,1L,5L,9L,6L,9L,6L,0L,4L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011284Inst : IEnumerable<long>
{
public static readonly long[] Value=A011284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011284.Bytes);
public long this[int i]=>Value[i];

public static A011284Inst Instance=new A011284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011285
{
public static readonly long[] Value={ 1L,1L,5L,4L,7L,8L,1L,9L,8L,4L,6L,8L,9L,4L,5L,8L,1L,7L,9L,6L,6L,6L,4L,8L,2L,8L,8L,7L,2L,9L,5L,5L,0L,8L,2L,8L,1L,5L,6L,6L,9L,4L,8L,0L,4L,1L,4L,7L,9L,6L,1L,1L,1L,2L,9L,9L,7L,7L,4L,2L,6L,8L,4L,8L,7L,1L,7L,9L,2L,9L,2L,0L,6L,9L,8L,0L,0L,4L,8L,1L,4L,0L,6L,0L,8L,5L,1L,3L,8L,1L,8L,0L,0L,8L,2L,7L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011285Inst : IEnumerable<long>
{
public static readonly long[] Value=A011285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011285.Bytes);
public long this[int i]=>Value[i];

public static A011285Inst Instance=new A011285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011286
{
public static readonly long[] Value={ 1L,1L,4L,5L,0L,4L,7L,5L,6L,9L,9L,3L,8L,2L,8L,1L,7L,6L,2L,2L,5L,2L,1L,6L,6L,3L,7L,8L,7L,2L,5L,5L,4L,5L,1L,9L,9L,3L,3L,5L,6L,1L,6L,8L,8L,2L,8L,7L,8L,1L,0L,0L,0L,8L,4L,0L,5L,1L,9L,8L,9L,2L,5L,7L,2L,5L,2L,8L,7L,8L,7L,2L,2L,5L,3L,8L,6L,8L,4L,7L,5L,4L,7L,0L,2L,1L,2L,7L,0L,8L,4L,6L,0L,4L,9L,5L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011286Inst : IEnumerable<long>
{
public static readonly long[] Value=A011286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011286.Bytes);
public long this[int i]=>Value[i];

public static A011286Inst Instance=new A011286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011287
{
public static readonly long[] Value={ 1L,1L,3L,6L,4L,6L,3L,6L,6L,6L,3L,8L,5L,7L,2L,4L,7L,4L,6L,6L,3L,7L,5L,6L,2L,9L,6L,7L,3L,2L,4L,7L,6L,2L,4L,0L,8L,7L,7L,4L,0L,8L,2L,2L,5L,3L,2L,3L,2L,0L,9L,0L,7L,2L,7L,6L,4L,2L,2L,2L,2L,2L,7L,3L,8L,2L,6L,6L,6L,3L,2L,9L,3L,9L,1L,1L,9L,5L,4L,8L,0L,6L,7L,5L,7L,3L,0L,5L,8L,7L,5L,2L,4L,4L,2L,9L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011287Inst : IEnumerable<long>
{
public static readonly long[] Value=A011287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011287.Bytes);
public long this[int i]=>Value[i];

public static A011287Inst Instance=new A011287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011288
{
public static readonly long[] Value={ 1L,1L,2L,8L,8L,3L,7L,8L,9L,1L,6L,8L,4L,6L,8L,9L,0L,5L,6L,3L,2L,4L,1L,5L,6L,0L,8L,6L,0L,5L,1L,5L,1L,4L,3L,5L,4L,9L,3L,7L,5L,0L,7L,8L,4L,8L,8L,2L,7L,8L,2L,7L,8L,1L,2L,0L,7L,3L,1L,3L,6L,0L,5L,4L,6L,1L,2L,6L,2L,3L,4L,2L,6L,1L,4L,3L,1L,5L,1L,2L,2L,1L,1L,3L,8L,5L,1L,2L,8L,2L,1L,7L,9L,3L,0L,9L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011288Inst : IEnumerable<long>
{
public static readonly long[] Value=A011288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011288.Bytes);
public long this[int i]=>Value[i];

public static A011288Inst Instance=new A011288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011289
{
public static readonly long[] Value={ 1L,1L,2L,2L,0L,1L,8L,4L,5L,4L,3L,0L,1L,9L,6L,3L,4L,3L,5L,5L,9L,1L,0L,3L,8L,9L,4L,6L,4L,7L,7L,9L,0L,5L,7L,3L,6L,7L,2L,2L,3L,0L,8L,5L,0L,7L,3L,6L,0L,5L,5L,2L,9L,6L,2L,4L,4L,5L,0L,7L,4L,4L,4L,8L,1L,7L,0L,1L,0L,3L,3L,0L,2L,6L,8L,6L,2L,2L,4L,3L,5L,5L,9L,4L,2L,3L,2L,2L,4L,1L,0L,6L,9L,3L,1L,9L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011289Inst : IEnumerable<long>
{
public static readonly long[] Value=A011289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011289.Bytes);
public long this[int i]=>Value[i];

public static A011289Inst Instance=new A011289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011290
{
public static readonly long[] Value={ 1L,4L,9L,1L,3L,0L,1L,4L,7L,5L,4L,1L,3L,1L,0L,8L,9L,2L,4L,2L,0L,1L,4L,9L,4L,6L,6L,8L,7L,6L,4L,8L,2L,5L,3L,4L,4L,5L,4L,2L,6L,7L,6L,1L,2L,5L,3L,2L,6L,1L,5L,7L,7L,9L,8L,1L,5L,1L,8L,4L,8L,3L,1L,4L,7L,4L,1L,2L,8L,9L,3L,6L,0L,0L,1L,5L,4L,6L,4L,6L,6L,1L,7L,7L,9L,2L,7L,5L,9L,6L,9L,5L,4L,4L,8L,6L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011290Inst : IEnumerable<long>
{
public static readonly long[] Value=A011290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011290.Bytes);
public long this[int i]=>Value[i];

public static A011290Inst Instance=new A011290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011291
{
public static readonly long[] Value={ 1L,4L,0L,8L,5L,4L,3L,8L,8L,8L,4L,2L,8L,6L,9L,9L,4L,1L,1L,4L,0L,6L,5L,8L,4L,6L,2L,8L,7L,5L,6L,8L,3L,1L,1L,6L,0L,4L,9L,8L,8L,5L,3L,4L,1L,2L,3L,4L,7L,8L,2L,0L,2L,4L,4L,6L,8L,9L,2L,2L,6L,3L,0L,2L,7L,1L,6L,8L,8L,8L,4L,2L,9L,0L,3L,2L,3L,3L,4L,4L,0L,6L,1L,1L,3L,5L,0L,7L,8L,0L,2L,7L,5L,1L,3L,8L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011291Inst : IEnumerable<long>
{
public static readonly long[] Value=A011291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011291.Bytes);
public long this[int i]=>Value[i];

public static A011291Inst Instance=new A011291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011292
{
public static readonly long[] Value={ 1L,3L,4L,9L,5L,0L,3L,7L,1L,8L,7L,1L,9L,5L,4L,1L,6L,9L,0L,7L,8L,0L,6L,1L,8L,8L,6L,7L,5L,0L,0L,8L,1L,2L,2L,4L,6L,4L,7L,3L,8L,9L,6L,4L,4L,0L,5L,6L,6L,7L,6L,0L,4L,0L,1L,1L,3L,4L,3L,9L,5L,4L,3L,7L,8L,8L,2L,8L,5L,6L,7L,4L,2L,9L,7L,1L,6L,2L,0L,0L,7L,5L,8L,0L,0L,5L,1L,0L,9L,6L,7L,1L,3L,8L,2L,8L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011292Inst : IEnumerable<long>
{
public static readonly long[] Value=A011292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011292.Bytes);
public long this[int i]=>Value[i];

public static A011292Inst Instance=new A011292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011293
{
public static readonly long[] Value={ 1L,3L,0L,5L,2L,9L,9L,8L,8L,0L,7L,9L,4L,9L,1L,9L,7L,8L,4L,0L,3L,3L,2L,9L,4L,8L,4L,1L,0L,5L,9L,1L,2L,9L,6L,6L,6L,3L,6L,8L,6L,2L,5L,4L,9L,6L,0L,8L,0L,0L,6L,1L,5L,9L,7L,0L,1L,7L,6L,1L,8L,5L,2L,0L,6L,2L,8L,8L,0L,7L,0L,6L,1L,3L,9L,9L,1L,5L,9L,9L,3L,5L,9L,6L,7L,2L,2L,9L,6L,9L,2L,2L,4L,9L,8L,9L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011293Inst : IEnumerable<long>
{
public static readonly long[] Value=A011293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011293.Bytes);
public long this[int i]=>Value[i];

public static A011293Inst Instance=new A011293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011294
{
public static readonly long[] Value={ 1L,2L,7L,0L,9L,8L,1L,6L,1L,5L,2L,1L,0L,1L,4L,0L,6L,3L,8L,6L,0L,5L,5L,3L,5L,1L,3L,7L,5L,2L,8L,4L,4L,2L,4L,2L,3L,9L,2L,3L,8L,7L,9L,1L,5L,6L,3L,7L,4L,9L,0L,9L,5L,8L,0L,4L,1L,2L,2L,5L,0L,2L,9L,3L,9L,8L,7L,6L,4L,6L,5L,8L,1L,8L,5L,1L,1L,2L,0L,3L,1L,6L,4L,7L,5L,0L,6L,4L,1L,5L,1L,2L,8L,3L,1L,9L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011294Inst : IEnumerable<long>
{
public static readonly long[] Value=A011294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011294.Bytes);
public long this[int i]=>Value[i];

public static A011294Inst Instance=new A011294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011295
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,5L,2L,2L,7L,9L,1L,2L,3L,7L,0L,7L,3L,5L,0L,7L,9L,7L,9L,1L,7L,1L,1L,9L,0L,9L,5L,3L,6L,4L,9L,8L,0L,5L,5L,2L,1L,2L,6L,4L,1L,6L,6L,6L,3L,7L,5L,0L,6L,9L,8L,2L,2L,5L,6L,3L,2L,4L,8L,6L,9L,5L,9L,6L,1L,0L,8L,1L,6L,8L,2L,1L,7L,8L,3L,7L,1L,5L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011295Inst : IEnumerable<long>
{
public static readonly long[] Value=A011295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011295.Bytes);
public long this[int i]=>Value[i];

public static A011295Inst Instance=new A011295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011296
{
public static readonly long[] Value={ 1L,2L,2L,1L,1L,8L,8L,5L,5L,0L,3L,1L,1L,9L,9L,3L,7L,6L,3L,8L,2L,3L,0L,2L,0L,8L,4L,3L,1L,3L,6L,9L,4L,6L,5L,5L,7L,1L,5L,1L,1L,6L,8L,6L,1L,1L,7L,9L,9L,2L,7L,2L,1L,5L,0L,5L,7L,1L,1L,0L,0L,0L,8L,8L,8L,2L,4L,8L,6L,5L,5L,0L,2L,2L,7L,8L,3L,9L,3L,2L,0L,7L,6L,6L,6L,0L,4L,3L,1L,0L,7L,5L,7L,1L,7L,8L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011296Inst : IEnumerable<long>
{
public static readonly long[] Value=A011296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011296.Bytes);
public long this[int i]=>Value[i];

public static A011296Inst Instance=new A011296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011297
{
public static readonly long[] Value={ 1L,2L,0L,2L,5L,6L,1L,0L,3L,9L,8L,7L,8L,1L,8L,4L,3L,0L,5L,7L,6L,8L,2L,9L,6L,6L,5L,0L,0L,4L,3L,5L,1L,5L,4L,2L,4L,3L,8L,9L,8L,2L,6L,9L,3L,1L,6L,2L,1L,5L,2L,3L,7L,0L,1L,3L,1L,4L,1L,5L,0L,5L,1L,2L,1L,3L,9L,3L,9L,2L,6L,1L,1L,5L,3L,7L,3L,6L,0L,6L,9L,4L,5L,3L,6L,8L,3L,3L,5L,3L,0L,9L,2L,1L,6L,8L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011297Inst : IEnumerable<long>
{
public static readonly long[] Value=A011297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011297.Bytes);
public long this[int i]=>Value[i];

public static A011297Inst Instance=new A011297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011298
{
public static readonly long[] Value={ 1L,1L,8L,6L,8L,2L,0L,9L,1L,6L,7L,4L,7L,2L,1L,4L,8L,2L,0L,2L,5L,5L,2L,6L,3L,6L,1L,7L,6L,9L,4L,6L,7L,0L,4L,7L,5L,5L,1L,4L,7L,5L,3L,1L,7L,4L,9L,3L,7L,7L,7L,1L,3L,0L,0L,9L,9L,4L,4L,6L,9L,9L,1L,0L,7L,5L,0L,9L,6L,5L,9L,5L,4L,3L,0L,5L,8L,2L,9L,6L,8L,0L,5L,5L,0L,2L,0L,5L,3L,6L,7L,7L,5L,3L,6L,0L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011298Inst : IEnumerable<long>
{
public static readonly long[] Value=A011298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011298.Bytes);
public long this[int i]=>Value[i];

public static A011298Inst Instance=new A011298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011299
{
public static readonly long[] Value={ 1L,1L,7L,3L,3L,4L,6L,2L,2L,1L,1L,9L,3L,4L,0L,5L,0L,6L,7L,4L,4L,8L,2L,1L,8L,7L,8L,5L,6L,6L,6L,6L,9L,6L,5L,6L,7L,2L,1L,6L,6L,4L,9L,1L,6L,3L,0L,3L,2L,5L,5L,7L,4L,9L,9L,7L,1L,2L,6L,3L,6L,0L,0L,0L,8L,9L,7L,7L,2L,8L,4L,7L,8L,5L,4L,9L,9L,4L,1L,7L,8L,3L,1L,7L,3L,3L,1L,2L,2L,0L,0L,7L,2L,3L,8L,2L,4L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011299Inst : IEnumerable<long>
{
public static readonly long[] Value=A011299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011299.Bytes);
public long this[int i]=>Value[i];

public static A011299Inst Instance=new A011299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011300
{
public static readonly long[] Value={ 1L,1L,6L,1L,6L,8L,1L,4L,1L,8L,7L,7L,1L,7L,4L,8L,1L,4L,8L,1L,5L,9L,2L,5L,0L,1L,7L,3L,7L,4L,8L,4L,0L,2L,1L,1L,5L,3L,2L,5L,2L,7L,1L,0L,1L,2L,3L,8L,5L,5L,7L,6L,2L,2L,1L,7L,6L,0L,1L,1L,7L,6L,9L,9L,3L,0L,8L,2L,1L,2L,5L,3L,3L,1L,8L,1L,9L,9L,6L,6L,9L,3L,0L,9L,2L,7L,6L,6L,8L,6L,1L,9L,7L,4L,6L,2L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011300Inst : IEnumerable<long>
{
public static readonly long[] Value=A011300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011300.Bytes);
public long this[int i]=>Value[i];

public static A011300Inst Instance=new A011300Inst();

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