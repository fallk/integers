using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A011168
{
public static readonly long[] Value={ 2L,4L,2L,0L,0L,0L,1L,4L,0L,6L,9L,6L,5L,9L,6L,2L,4L,2L,2L,0L,0L,0L,2L,2L,5L,7L,3L,3L,4L,5L,1L,0L,0L,8L,5L,6L,1L,6L,8L,5L,5L,2L,0L,4L,6L,8L,1L,2L,7L,5L,2L,0L,3L,7L,6L,9L,2L,5L,5L,0L,6L,1L,2L,7L,0L,7L,9L,4L,2L,2L,6L,2L,9L,4L,9L,3L,5L,8L,7L,1L,7L,3L,3L,1L,9L,3L,3L,4L,9L,3L,1L,8L,3L,4L,4L,6L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011168Inst : IEnumerable<long>
{
public static readonly long[] Value=A011168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011168.Bytes);
public long this[int i]=>Value[i];

public static A011168Inst Instance=new A011168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011167
{
public static readonly long[] Value={ 2L,4L,1L,4L,1L,4L,1L,7L,7L,0L,6L,0L,3L,7L,3L,5L,8L,3L,1L,3L,1L,6L,5L,4L,1L,2L,0L,8L,4L,8L,1L,1L,0L,0L,6L,7L,0L,5L,3L,1L,1L,7L,5L,4L,5L,1L,5L,3L,9L,2L,2L,2L,7L,8L,7L,1L,8L,5L,3L,5L,4L,8L,2L,4L,4L,4L,8L,1L,4L,2L,4L,0L,3L,5L,5L,5L,7L,5L,4L,2L,0L,0L,6L,4L,9L,0L,8L,1L,4L,3L,1L,2L,0L,0L,9L,2L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011167Inst : IEnumerable<long>
{
public static readonly long[] Value=A011167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011167.Bytes);
public long this[int i]=>Value[i];

public static A011167Inst Instance=new A011167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011166
{
public static readonly long[] Value={ 2L,4L,0L,8L,2L,2L,4L,6L,8L,5L,2L,8L,0L,6L,9L,2L,0L,4L,6L,2L,8L,5L,5L,0L,8L,6L,1L,4L,1L,9L,1L,1L,5L,4L,3L,2L,9L,1L,0L,0L,3L,5L,7L,0L,1L,8L,5L,8L,8L,5L,0L,7L,2L,3L,4L,9L,4L,6L,7L,8L,3L,7L,9L,8L,4L,7L,0L,7L,3L,7L,7L,3L,1L,2L,6L,3L,6L,4L,7L,4L,0L,2L,5L,9L,8L,9L,5L,4L,2L,9L,9L,6L,7L,7L,1L,8L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011166Inst : IEnumerable<long>
{
public static readonly long[] Value=A011166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011166.Bytes);
public long this[int i]=>Value[i];

public static A011166Inst Instance=new A011166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011149
{
public static readonly long[] Value={ 2L,2L,9L,7L,3L,9L,6L,7L,0L,9L,9L,9L,4L,0L,7L,0L,0L,1L,3L,5L,9L,7L,2L,5L,3L,8L,9L,3L,5L,5L,5L,8L,5L,5L,1L,7L,8L,8L,8L,7L,7L,0L,1L,7L,7L,8L,1L,9L,5L,5L,9L,5L,0L,1L,1L,0L,2L,7L,4L,2L,2L,2L,3L,6L,9L,8L,7L,2L,0L,6L,4L,1L,2L,5L,0L,7L,0L,2L,6L,1L,1L,3L,6L,2L,2L,9L,4L,6L,2L,2L,6L,0L,2L,3L,0L,1L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011149Inst : IEnumerable<long>
{
public static readonly long[] Value=A011149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011149.Bytes);
public long this[int i]=>Value[i];

public static A011149Inst Instance=new A011149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011148
{
public static readonly long[] Value={ 2L,2L,9L,0L,1L,7L,2L,0L,4L,8L,9L,2L,3L,5L,8L,2L,4L,9L,0L,1L,2L,3L,9L,0L,6L,4L,0L,2L,3L,6L,4L,0L,0L,0L,9L,7L,9L,5L,6L,0L,5L,4L,6L,6L,1L,3L,7L,1L,8L,0L,1L,8L,0L,7L,6L,5L,8L,7L,4L,8L,7L,2L,8L,8L,1L,6L,0L,6L,0L,4L,1L,6L,2L,7L,9L,0L,9L,8L,8L,0L,0L,0L,8L,8L,4L,2L,5L,5L,5L,7L,1L,0L,7L,0L,6L,9L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011148Inst : IEnumerable<long>
{
public static readonly long[] Value=A011148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011148.Bytes);
public long this[int i]=>Value[i];

public static A011148Inst Instance=new A011148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011147
{
public static readonly long[] Value={ 2L,2L,8L,2L,8L,5L,5L,0L,5L,5L,7L,0L,1L,6L,2L,8L,9L,8L,2L,1L,4L,5L,3L,7L,9L,4L,7L,7L,5L,4L,7L,9L,6L,3L,0L,2L,2L,3L,4L,0L,7L,1L,5L,7L,3L,8L,5L,1L,1L,6L,3L,3L,2L,6L,8L,0L,3L,1L,3L,4L,7L,2L,0L,6L,6L,9L,2L,0L,1L,6L,0L,3L,5L,5L,0L,4L,4L,7L,9L,3L,0L,4L,9L,3L,4L,5L,8L,8L,8L,3L,9L,5L,4L,2L,6L,9L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011147Inst : IEnumerable<long>
{
public static readonly long[] Value=A011147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011147.Bytes);
public long this[int i]=>Value[i];

public static A011147Inst Instance=new A011147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011146
{
public static readonly long[] Value={ 2L,2L,7L,5L,4L,4L,3L,0L,3L,2L,1L,1L,4L,5L,3L,0L,3L,3L,7L,9L,1L,4L,6L,4L,3L,8L,2L,6L,7L,7L,6L,6L,4L,3L,2L,5L,5L,8L,2L,4L,8L,9L,5L,4L,8L,1L,9L,5L,8L,3L,6L,2L,1L,8L,9L,6L,2L,8L,1L,2L,9L,7L,2L,0L,4L,5L,2L,2L,5L,4L,0L,5L,6L,1L,1L,0L,4L,5L,2L,4L,1L,1L,5L,3L,5L,3L,1L,1L,4L,0L,0L,9L,9L,1L,1L,8L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011146Inst : IEnumerable<long>
{
public static readonly long[] Value=A011146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011146.Bytes);
public long this[int i]=>Value[i];

public static A011146Inst Instance=new A011146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011145
{
public static readonly long[] Value={ 2L,2L,6L,7L,9L,3L,3L,1L,5L,5L,2L,6L,6L,0L,5L,4L,4L,1L,9L,2L,3L,2L,0L,1L,7L,8L,8L,8L,9L,7L,7L,2L,6L,0L,8L,0L,1L,4L,0L,4L,2L,4L,5L,7L,4L,6L,8L,3L,8L,7L,6L,1L,4L,5L,6L,1L,3L,8L,6L,7L,1L,9L,4L,7L,8L,7L,0L,5L,3L,8L,2L,2L,0L,1L,8L,3L,6L,2L,7L,0L,0L,3L,3L,6L,8L,6L,4L,0L,8L,5L,4L,1L,9L,9L,5L,4L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011145Inst : IEnumerable<long>
{
public static readonly long[] Value=A011145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011145.Bytes);
public long this[int i]=>Value[i];

public static A011145Inst Instance=new A011145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011144
{
public static readonly long[] Value={ 2L,2L,6L,0L,3L,2L,2L,4L,6L,9L,6L,2L,6L,8L,1L,5L,7L,0L,3L,6L,9L,7L,6L,1L,8L,8L,9L,4L,9L,1L,5L,4L,0L,5L,8L,0L,5L,6L,9L,1L,1L,1L,9L,9L,4L,8L,4L,5L,6L,1L,5L,2L,0L,0L,5L,9L,7L,3L,7L,0L,3L,2L,5L,8L,9L,8L,4L,7L,6L,9L,0L,1L,5L,6L,9L,7L,2L,9L,8L,6L,7L,4L,0L,7L,8L,7L,8L,5L,7L,5L,5L,8L,9L,1L,1L,0L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011144Inst : IEnumerable<long>
{
public static readonly long[] Value=A011144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011144.Bytes);
public long this[int i]=>Value[i];

public static A011144Inst Instance=new A011144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011143
{
public static readonly long[] Value={ 2L,2L,5L,2L,6L,0L,7L,8L,7L,8L,4L,3L,2L,3L,2L,5L,4L,1L,1L,5L,1L,5L,4L,7L,6L,6L,7L,5L,2L,7L,7L,2L,7L,0L,6L,7L,6L,7L,4L,3L,5L,0L,7L,4L,8L,2L,9L,3L,6L,2L,1L,4L,3L,4L,6L,1L,1L,2L,8L,6L,3L,6L,5L,5L,0L,9L,3L,0L,3L,9L,3L,0L,5L,4L,4L,9L,0L,4L,0L,2L,6L,6L,0L,2L,7L,4L,1L,4L,6L,9L,7L,0L,3L,0L,2L,2L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011143Inst : IEnumerable<long>
{
public static readonly long[] Value=A011143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011143.Bytes);
public long this[int i]=>Value[i];

public static A011143Inst Instance=new A011143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011142
{
public static readonly long[] Value={ 2L,2L,4L,4L,7L,8L,6L,1L,3L,4L,3L,6L,4L,0L,9L,2L,0L,7L,0L,5L,9L,5L,0L,1L,1L,0L,1L,6L,7L,0L,6L,7L,6L,1L,4L,8L,3L,6L,0L,5L,9L,3L,8L,6L,9L,9L,2L,0L,2L,2L,8L,1L,7L,2L,0L,7L,1L,8L,7L,3L,4L,7L,2L,1L,4L,4L,1L,7L,4L,7L,9L,4L,5L,1L,0L,9L,0L,1L,0L,6L,0L,2L,9L,2L,0L,8L,0L,6L,9L,6L,0L,0L,0L,1L,9L,8L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011142Inst : IEnumerable<long>
{
public static readonly long[] Value=A011142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011142.Bytes);
public long this[int i]=>Value[i];

public static A011142Inst Instance=new A011142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011141
{
public static readonly long[] Value={ 2L,2L,3L,6L,8L,5L,3L,8L,2L,9L,4L,4L,0L,2L,8L,9L,3L,3L,8L,4L,1L,0L,0L,1L,4L,4L,0L,9L,6L,4L,8L,5L,5L,0L,2L,9L,7L,3L,7L,4L,7L,4L,2L,1L,1L,1L,2L,9L,1L,7L,1L,8L,6L,6L,4L,3L,0L,2L,6L,1L,6L,1L,5L,4L,8L,3L,6L,1L,7L,4L,5L,1L,5L,0L,2L,2L,3L,7L,6L,3L,8L,7L,7L,0L,2L,0L,5L,4L,2L,7L,8L,7L,5L,1L,0L,2L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011141Inst : IEnumerable<long>
{
public static readonly long[] Value=A011141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011141.Bytes);
public long this[int i]=>Value[i];

public static A011141Inst Instance=new A011141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011140
{
public static readonly long[] Value={ 2L,2L,2L,8L,8L,0L,7L,3L,8L,4L,0L,3L,3L,5L,1L,8L,6L,0L,7L,2L,1L,2L,8L,0L,1L,4L,5L,4L,6L,0L,6L,9L,9L,3L,8L,0L,1L,4L,6L,3L,5L,3L,7L,7L,7L,6L,6L,7L,8L,7L,3L,9L,2L,6L,9L,9L,2L,6L,1L,5L,7L,9L,0L,9L,4L,0L,5L,4L,2L,8L,7L,0L,8L,8L,0L,1L,5L,9L,3L,5L,2L,4L,2L,5L,3L,9L,4L,9L,0L,6L,0L,8L,6L,3L,3L,6L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011140Inst : IEnumerable<long>
{
public static readonly long[] Value=A011140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011140.Bytes);
public long this[int i]=>Value[i];

public static A011140Inst Instance=new A011140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011139
{
public static readonly long[] Value={ 2L,2L,2L,0L,6L,4L,3L,0L,3L,4L,9L,2L,2L,9L,2L,0L,0L,8L,8L,3L,0L,6L,6L,6L,3L,0L,5L,0L,8L,4L,6L,0L,5L,5L,0L,3L,2L,4L,3L,3L,9L,1L,9L,8L,5L,2L,8L,5L,3L,9L,1L,5L,0L,9L,2L,0L,3L,8L,9L,3L,1L,8L,8L,1L,2L,6L,1L,5L,3L,7L,7L,9L,3L,7L,4L,4L,5L,9L,2L,6L,5L,9L,5L,3L,2L,2L,3L,0L,2L,6L,7L,7L,1L,2L,4L,2L,7L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011139Inst : IEnumerable<long>
{
public static readonly long[] Value=A011139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011139.Bytes);
public long this[int i]=>Value[i];

public static A011139Inst Instance=new A011139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011138
{
public static readonly long[] Value={ 2L,2L,1L,2L,3L,5L,6L,8L,2L,2L,2L,7L,6L,1L,1L,6L,7L,4L,0L,0L,4L,6L,6L,2L,0L,2L,9L,0L,7L,8L,1L,3L,4L,5L,2L,0L,9L,1L,0L,3L,2L,4L,9L,6L,3L,1L,0L,3L,3L,8L,8L,3L,0L,2L,5L,2L,1L,4L,2L,2L,0L,3L,1L,6L,4L,3L,8L,0L,1L,1L,5L,7L,2L,8L,1L,2L,6L,5L,8L,2L,1L,3L,0L,7L,6L,6L,8L,4L,3L,5L,6L,7L,6L,4L,7L,6L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011138Inst : IEnumerable<long>
{
public static readonly long[] Value=A011138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011138.Bytes);
public long this[int i]=>Value[i];

public static A011138Inst Instance=new A011138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011137
{
public static readonly long[] Value={ 2L,2L,0L,3L,9L,4L,4L,5L,7L,5L,4L,4L,2L,9L,6L,0L,2L,9L,3L,3L,4L,3L,9L,0L,2L,9L,2L,1L,4L,5L,2L,7L,9L,8L,6L,1L,3L,3L,3L,8L,4L,9L,7L,4L,7L,0L,1L,9L,8L,7L,1L,7L,8L,6L,2L,7L,1L,7L,8L,3L,2L,8L,5L,0L,9L,5L,2L,2L,0L,7L,3L,3L,3L,7L,0L,0L,8L,6L,2L,0L,5L,2L,9L,8L,2L,0L,2L,4L,8L,0L,4L,5L,9L,4L,1L,3L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011137Inst : IEnumerable<long>
{
public static readonly long[] Value=A011137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011137.Bytes);
public long this[int i]=>Value[i];

public static A011137Inst Instance=new A011137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011136
{
public static readonly long[] Value={ 2L,1L,9L,5L,4L,0L,1L,8L,9L,7L,4L,2L,7L,4L,8L,9L,9L,0L,6L,5L,6L,3L,6L,7L,9L,4L,3L,0L,4L,5L,5L,5L,3L,0L,1L,0L,3L,5L,3L,6L,0L,0L,8L,7L,7L,7L,3L,1L,0L,5L,2L,4L,6L,0L,7L,0L,6L,2L,1L,3L,9L,0L,2L,9L,8L,3L,2L,8L,1L,0L,6L,6L,1L,6L,7L,9L,9L,4L,1L,6L,3L,4L,3L,9L,6L,3L,1L,6L,2L,7L,9L,7L,3L,9L,4L,6L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011136Inst : IEnumerable<long>
{
public static readonly long[] Value=A011136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011136.Bytes);
public long this[int i]=>Value[i];

public static A011136Inst Instance=new A011136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011135
{
public static readonly long[] Value={ 2L,1L,8L,6L,7L,2L,4L,1L,4L,7L,8L,8L,6L,5L,5L,6L,1L,1L,2L,7L,3L,7L,5L,2L,8L,8L,9L,6L,0L,7L,1L,2L,8L,5L,6L,4L,4L,8L,6L,6L,2L,2L,2L,6L,7L,7L,6L,5L,7L,9L,9L,8L,4L,2L,5L,7L,3L,4L,0L,1L,4L,7L,1L,2L,6L,2L,4L,0L,8L,2L,7L,4L,3L,9L,6L,5L,5L,6L,0L,8L,8L,3L,6L,3L,7L,7L,3L,0L,9L,8L,6L,1L,3L,6L,2L,0L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011135Inst : IEnumerable<long>
{
public static readonly long[] Value=A011135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011135.Bytes);
public long this[int i]=>Value[i];

public static A011135Inst Instance=new A011135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011134
{
public static readonly long[] Value={ 2L,1L,7L,7L,9L,0L,6L,4L,2L,4L,4L,8L,2L,7L,7L,9L,8L,9L,4L,6L,6L,5L,2L,6L,4L,8L,3L,5L,5L,7L,5L,2L,0L,7L,1L,0L,7L,0L,1L,0L,6L,6L,6L,4L,8L,6L,0L,9L,6L,1L,6L,2L,0L,2L,1L,7L,7L,7L,9L,0L,8L,8L,1L,8L,5L,1L,9L,1L,4L,9L,3L,6L,7L,1L,3L,6L,9L,2L,4L,3L,5L,4L,5L,2L,0L,6L,2L,4L,3L,7L,9L,7L,5L,4L,5L,5L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011134Inst : IEnumerable<long>
{
public static readonly long[] Value=A011134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011134.Bytes);
public long this[int i]=>Value[i];

public static A011134Inst Instance=new A011134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011133
{
public static readonly long[] Value={ 2L,1L,6L,8L,9L,4L,3L,5L,4L,2L,3L,9L,5L,3L,9L,7L,2L,2L,7L,4L,9L,1L,2L,1L,9L,8L,4L,4L,8L,2L,2L,3L,5L,9L,5L,0L,4L,4L,2L,1L,4L,7L,2L,6L,8L,2L,5L,0L,7L,9L,1L,9L,7L,4L,8L,0L,0L,8L,0L,6L,9L,7L,7L,2L,7L,1L,4L,5L,5L,8L,8L,8L,4L,9L,0L,2L,4L,9L,0L,3L,0L,2L,8L,2L,2L,9L,6L,6L,5L,4L,7L,8L,9L,1L,7L,6L,7L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011133Inst : IEnumerable<long>
{
public static readonly long[] Value=A011133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011133.Bytes);
public long this[int i]=>Value[i];

public static A011133Inst Instance=new A011133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011132
{
public static readonly long[] Value={ 2L,1L,5L,9L,8L,3L,0L,0L,1L,1L,7L,6L,4L,4L,6L,6L,1L,5L,5L,6L,4L,3L,0L,2L,1L,9L,7L,5L,7L,6L,7L,8L,5L,0L,7L,4L,9L,5L,9L,6L,5L,2L,0L,6L,7L,1L,6L,6L,6L,9L,2L,7L,7L,1L,7L,2L,4L,9L,6L,2L,8L,0L,1L,6L,8L,8L,6L,3L,8L,4L,0L,7L,3L,9L,1L,3L,8L,9L,3L,3L,2L,7L,0L,5L,0L,3L,0L,9L,8L,8L,4L,6L,3L,7L,8L,0L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011132Inst : IEnumerable<long>
{
public static readonly long[] Value=A011132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011132.Bytes);
public long this[int i]=>Value[i];

public static A011132Inst Instance=new A011132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011131
{
public static readonly long[] Value={ 2L,1L,5L,0L,5L,6L,0L,0L,1L,2L,8L,1L,1L,1L,3L,9L,4L,7L,6L,8L,4L,7L,4L,5L,0L,3L,6L,8L,8L,5L,8L,7L,7L,5L,3L,5L,7L,6L,3L,9L,1L,7L,9L,2L,8L,0L,4L,5L,8L,0L,4L,8L,5L,7L,0L,0L,8L,0L,3L,4L,9L,8L,4L,0L,6L,4L,7L,6L,6L,9L,1L,8L,2L,1L,3L,0L,6L,3L,7L,3L,5L,9L,4L,4L,7L,2L,1L,4L,3L,9L,0L,4L,4L,7L,6L,2L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011131Inst : IEnumerable<long>
{
public static readonly long[] Value=A011131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011131.Bytes);
public long this[int i]=>Value[i];

public static A011131Inst Instance=new A011131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011130
{
public static readonly long[] Value={ 2L,1L,4L,1L,1L,2L,7L,3L,6L,8L,3L,3L,8L,3L,2L,3L,8L,4L,2L,3L,4L,6L,8L,6L,7L,3L,6L,0L,0L,4L,1L,7L,2L,9L,5L,5L,3L,7L,7L,7L,4L,5L,8L,7L,4L,0L,1L,6L,9L,9L,3L,4L,7L,5L,0L,0L,8L,8L,0L,5L,4L,7L,9L,1L,7L,9L,5L,9L,1L,0L,2L,7L,9L,4L,2L,0L,4L,7L,0L,1L,9L,4L,8L,1L,5L,7L,9L,8L,0L,6L,3L,9L,7L,7L,8L,2L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011130Inst : IEnumerable<long>
{
public static readonly long[] Value=A011130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011130.Bytes);
public long this[int i]=>Value[i];

public static A011130Inst Instance=new A011130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011129
{
public static readonly long[] Value={ 2L,1L,3L,1L,5L,2L,5L,5L,1L,3L,2L,7L,0L,9L,4L,8L,4L,8L,7L,1L,9L,1L,3L,3L,4L,8L,1L,0L,3L,6L,7L,3L,9L,1L,9L,7L,3L,9L,8L,7L,8L,6L,2L,7L,3L,8L,4L,6L,6L,5L,0L,4L,9L,9L,9L,1L,2L,6L,0L,1L,9L,5L,8L,3L,1L,1L,8L,7L,7L,4L,8L,5L,0L,3L,8L,0L,1L,4L,2L,8L,2L,6L,6L,8L,3L,8L,3L,5L,6L,0L,5L,2L,4L,6L,3L,8L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011129Inst : IEnumerable<long>
{
public static readonly long[] Value=A011129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011129.Bytes);
public long this[int i]=>Value[i];

public static A011129Inst Instance=new A011129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011128
{
public static readonly long[] Value={ 2L,1L,2L,1L,7L,4L,7L,4L,6L,0L,8L,4L,1L,8L,9L,7L,8L,5L,2L,6L,3L,9L,9L,0L,5L,0L,3L,1L,0L,7L,9L,4L,1L,6L,8L,3L,3L,4L,4L,2L,4L,4L,7L,8L,9L,9L,3L,7L,7L,3L,0L,0L,1L,3L,5L,8L,4L,5L,5L,0L,6L,4L,0L,4L,9L,6L,4L,6L,7L,7L,3L,7L,9L,2L,9L,4L,4L,1L,5L,6L,3L,7L,7L,5L,5L,0L,0L,3L,4L,9L,7L,6L,8L,0L,1L,5L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011128Inst : IEnumerable<long>
{
public static readonly long[] Value=A011128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011128.Bytes);
public long this[int i]=>Value[i];

public static A011128Inst Instance=new A011128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011127
{
public static readonly long[] Value={ 2L,1L,1L,1L,7L,8L,5L,7L,6L,4L,9L,6L,6L,7L,5L,3L,9L,1L,2L,7L,3L,2L,5L,6L,7L,3L,3L,0L,5L,5L,0L,2L,3L,3L,4L,8L,6L,3L,0L,3L,2L,0L,2L,6L,5L,3L,6L,3L,0L,6L,3L,7L,8L,2L,0L,8L,0L,9L,0L,3L,8L,7L,8L,6L,0L,3L,7L,6L,2L,2L,6L,4L,9L,6L,9L,5L,4L,0L,5L,6L,4L,4L,8L,4L,4L,7L,9L,1L,1L,4L,2L,5L,5L,4L,8L,9L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011127Inst : IEnumerable<long>
{
public static readonly long[] Value=A011127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011127.Bytes);
public long this[int i]=>Value[i];

public static A011127Inst Instance=new A011127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011126
{
public static readonly long[] Value={ 2L,1L,0L,1L,6L,3L,2L,4L,7L,8L,2L,7L,5L,7L,8L,4L,7L,3L,1L,4L,2L,8L,8L,2L,9L,9L,0L,4L,7L,6L,6L,7L,3L,8L,8L,4L,4L,2L,3L,6L,7L,9L,2L,8L,8L,9L,9L,5L,9L,0L,5L,5L,8L,7L,4L,2L,6L,8L,5L,3L,6L,6L,7L,7L,0L,1L,1L,1L,2L,8L,8L,5L,5L,9L,7L,3L,0L,3L,2L,5L,6L,0L,3L,7L,4L,0L,2L,7L,6L,3L,3L,5L,4L,9L,2L,2L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011126Inst : IEnumerable<long>
{
public static readonly long[] Value=A011126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011126.Bytes);
public long this[int i]=>Value[i];

public static A011126Inst Instance=new A011126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011125
{
public static readonly long[] Value={ 2L,0L,9L,1L,2L,7L,9L,1L,0L,5L,1L,8L,2L,5L,4L,6L,4L,6L,1L,3L,0L,5L,9L,7L,0L,5L,8L,2L,4L,4L,1L,0L,3L,6L,5L,0L,4L,9L,4L,0L,6L,8L,9L,7L,4L,3L,0L,1L,2L,3L,8L,1L,3L,8L,1L,8L,0L,0L,7L,3L,2L,7L,6L,0L,9L,6L,6L,3L,9L,9L,5L,0L,0L,5L,5L,8L,0L,8L,7L,1L,9L,7L,2L,3L,7L,5L,4L,6L,1L,7L,6L,7L,0L,7L,8L,3L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011125Inst : IEnumerable<long>
{
public static readonly long[] Value=A011125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011125.Bytes);
public long this[int i]=>Value[i];

public static A011125Inst Instance=new A011125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011124
{
public static readonly long[] Value={ 2L,0L,8L,0L,7L,1L,6L,5L,4L,9L,2L,6L,1L,8L,4L,3L,7L,2L,9L,6L,9L,2L,7L,4L,2L,2L,9L,8L,7L,5L,8L,5L,8L,4L,2L,3L,2L,4L,8L,1L,0L,2L,9L,1L,0L,1L,4L,6L,4L,4L,2L,6L,9L,8L,6L,6L,4L,4L,5L,0L,8L,1L,8L,5L,9L,1L,9L,1L,2L,9L,0L,4L,9L,0L,9L,5L,2L,2L,5L,4L,7L,5L,5L,5L,4L,9L,8L,0L,8L,8L,6L,2L,5L,4L,3L,4L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011124Inst : IEnumerable<long>
{
public static readonly long[] Value=A011124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011124.Bytes);
public long this[int i]=>Value[i];

public static A011124Inst Instance=new A011124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011123
{
public static readonly long[] Value={ 2L,0L,6L,9L,9L,3L,5L,0L,5L,4L,0L,8L,1L,6L,1L,4L,0L,6L,1L,5L,4L,2L,6L,2L,3L,4L,2L,0L,5L,4L,8L,6L,8L,9L,1L,9L,9L,8L,5L,1L,6L,1L,4L,4L,8L,6L,7L,3L,3L,9L,0L,2L,1L,1L,8L,0L,0L,3L,3L,8L,8L,6L,1L,3L,6L,1L,0L,5L,0L,5L,2L,7L,4L,4L,4L,4L,2L,4L,9L,8L,0L,2L,6L,9L,3L,8L,0L,9L,3L,9L,9L,6L,3L,5L,5L,9L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011123Inst : IEnumerable<long>
{
public static readonly long[] Value=A011123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011123.Bytes);
public long this[int i]=>Value[i];

public static A011123Inst Instance=new A011123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011122
{
public static readonly long[] Value={ 2L,0L,5L,8L,9L,2L,4L,1L,3L,6L,4L,7L,8L,5L,1L,7L,2L,5L,2L,4L,6L,0L,0L,3L,0L,4L,1L,6L,0L,6L,6L,1L,8L,6L,5L,8L,6L,9L,1L,8L,1L,3L,3L,7L,9L,9L,4L,6L,4L,7L,2L,2L,0L,0L,0L,6L,1L,4L,6L,7L,4L,0L,0L,3L,1L,1L,2L,0L,9L,0L,6L,6L,0L,3L,9L,8L,6L,0L,9L,1L,8L,2L,2L,5L,1L,8L,5L,6L,1L,3L,6L,7L,7L,9L,1L,1L,5L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011122Inst : IEnumerable<long>
{
public static readonly long[] Value=A011122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011122.Bytes);
public long this[int i]=>Value[i];

public static A011122Inst Instance=new A011122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011121
{
public static readonly long[] Value={ 2L,0L,4L,7L,6L,7L,2L,5L,1L,1L,0L,7L,9L,2L,1L,9L,2L,9L,6L,2L,1L,2L,8L,3L,7L,3L,5L,6L,3L,2L,8L,6L,2L,1L,8L,7L,5L,4L,9L,6L,2L,1L,9L,1L,8L,5L,1L,9L,6L,6L,9L,0L,2L,1L,1L,9L,5L,5L,8L,2L,1L,6L,3L,1L,8L,6L,1L,5L,0L,8L,6L,5L,2L,4L,2L,5L,8L,9L,2L,1L,3L,3L,8L,7L,0L,1L,8L,2L,1L,2L,7L,3L,3L,9L,9L,4L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011121Inst : IEnumerable<long>
{
public static readonly long[] Value=A011121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011121.Bytes);
public long this[int i]=>Value[i];

public static A011121Inst Instance=new A011121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011120
{
public static readonly long[] Value={ 2L,0L,3L,6L,1L,6L,8L,0L,0L,4L,6L,4L,0L,3L,9L,8L,0L,1L,7L,3L,6L,0L,8L,7L,4L,1L,6L,4L,1L,4L,5L,3L,1L,7L,6L,9L,4L,2L,6L,1L,8L,1L,6L,1L,6L,7L,5L,7L,8L,5L,3L,5L,1L,8L,6L,1L,1L,3L,5L,5L,0L,0L,8L,5L,2L,9L,1L,4L,1L,4L,9L,4L,6L,8L,6L,5L,9L,1L,3L,5L,9L,1L,0L,6L,7L,6L,1L,3L,0L,8L,8L,9L,9L,3L,4L,3L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011120Inst : IEnumerable<long>
{
public static readonly long[] Value=A011120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011120.Bytes);
public long this[int i]=>Value[i];

public static A011120Inst Instance=new A011120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011119
{
public static readonly long[] Value={ 2L,0L,2L,4L,3L,9L,7L,4L,5L,8L,4L,9L,9L,8L,8L,5L,0L,4L,2L,5L,1L,0L,8L,1L,7L,2L,4L,5L,5L,4L,1L,9L,3L,7L,4L,1L,9L,1L,1L,4L,6L,2L,1L,7L,0L,1L,0L,7L,3L,1L,1L,8L,3L,5L,5L,3L,6L,1L,9L,7L,9L,5L,0L,7L,7L,7L,4L,9L,8L,8L,7L,2L,1L,8L,5L,6L,6L,2L,2L,3L,3L,9L,4L,7L,8L,2L,4L,5L,6L,9L,2L,0L,2L,1L,9L,1L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011119Inst : IEnumerable<long>
{
public static readonly long[] Value=A011119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011119.Bytes);
public long this[int i]=>Value[i];

public static A011119Inst Instance=new A011119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011118
{
public static readonly long[] Value={ 2L,0L,1L,2L,3L,4L,6L,6L,1L,7L,0L,8L,5L,5L,5L,8L,3L,2L,4L,7L,7L,8L,5L,6L,0L,8L,6L,2L,9L,9L,5L,5L,2L,4L,6L,6L,6L,5L,2L,4L,1L,3L,4L,7L,2L,6L,2L,3L,6L,5L,0L,3L,2L,3L,4L,6L,7L,5L,1L,3L,5L,9L,1L,2L,0L,9L,9L,1L,0L,4L,4L,4L,2L,1L,8L,2L,4L,6L,8L,6L,6L,5L,9L,0L,6L,3L,6L,8L,6L,5L,9L,5L,3L,5L,5L,1L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011118Inst : IEnumerable<long>
{
public static readonly long[] Value=A011118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011118.Bytes);
public long this[int i]=>Value[i];

public static A011118Inst Instance=new A011118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011117
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,7L,11L,1L,4L,12L,28L,45L,1L,5L,18L,52L,121L,197L,1L,6L,25L,84L,237L,550L,903L,1L,7L,33L,125L,403L,1119L,2591L,4279L,1L,8L,42L,176L,630L,1976L,5424L,12536L,20793L,1L,9L,52L,238L,930L,3206L,9860L,26832L,61921L,103049L,1L,10L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011117Inst : IEnumerable<long>
{
public static readonly long[] Value=A011117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011117.Bytes);
public long this[int i]=>Value[i];

public static A011117Inst Instance=new A011117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011116
{
public static readonly long[] Value={ 1L,9L,8L,7L,3L,4L,0L,7L,5L,4L,6L,6L,4L,4L,5L,7L,9L,5L,8L,5L,6L,6L,3L,0L,3L,6L,7L,3L,6L,0L,7L,4L,5L,9L,6L,7L,5L,0L,5L,1L,3L,2L,6L,1L,8L,4L,6L,2L,2L,4L,5L,6L,4L,6L,1L,4L,0L,9L,6L,7L,0L,4L,5L,0L,3L,9L,1L,3L,7L,0L,0L,4L,0L,5L,2L,5L,8L,3L,1L,6L,8L,7L,9L,8L,2L,5L,2L,2L,2L,1L,2L,8L,6L,7L,3L,4L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011116Inst : IEnumerable<long>
{
public static readonly long[] Value=A011116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011116.Bytes);
public long this[int i]=>Value[i];

public static A011116Inst Instance=new A011116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011115
{
public static readonly long[] Value={ 1L,9L,7L,4L,3L,5L,0L,4L,8L,5L,8L,3L,4L,8L,1L,9L,8L,4L,2L,6L,7L,2L,8L,3L,6L,1L,7L,2L,4L,0L,8L,4L,5L,3L,1L,8L,2L,6L,8L,2L,2L,6L,7L,2L,4L,8L,0L,9L,5L,3L,5L,4L,7L,1L,6L,7L,9L,4L,0L,7L,7L,9L,4L,3L,3L,9L,4L,2L,4L,7L,1L,9L,8L,1L,0L,7L,0L,2L,1L,2L,4L,6L,1L,4L,5L,3L,2L,3L,2L,4L,9L,7L,8L,2L,4L,3L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011115Inst : IEnumerable<long>
{
public static readonly long[] Value=A011115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011115.Bytes);
public long this[int i]=>Value[i];

public static A011115Inst Instance=new A011115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011114
{
public static readonly long[] Value={ 1L,9L,6L,1L,0L,0L,9L,0L,5L,7L,4L,5L,4L,5L,4L,8L,0L,1L,3L,2L,0L,6L,3L,5L,6L,8L,5L,0L,0L,9L,7L,8L,2L,4L,1L,4L,3L,7L,6L,7L,8L,1L,3L,9L,3L,1L,6L,8L,9L,0L,8L,9L,6L,0L,7L,7L,7L,3L,6L,3L,9L,9L,8L,2L,9L,1L,3L,2L,2L,1L,1L,0L,6L,8L,0L,9L,6L,6L,2L,7L,1L,8L,0L,9L,0L,4L,8L,4L,4L,6L,1L,0L,9L,0L,1L,8L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011114Inst : IEnumerable<long>
{
public static readonly long[] Value=A011114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011114.Bytes);
public long this[int i]=>Value[i];

public static A011114Inst Instance=new A011114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011113
{
public static readonly long[] Value={ 1L,9L,4L,7L,2L,9L,4L,3L,6L,1L,2L,3L,0L,3L,3L,6L,2L,7L,3L,0L,5L,2L,4L,1L,0L,2L,1L,1L,8L,4L,2L,6L,6L,8L,4L,6L,6L,8L,3L,8L,7L,1L,7L,6L,2L,1L,9L,9L,4L,5L,4L,1L,5L,9L,0L,9L,7L,0L,9L,1L,1L,7L,5L,3L,1L,2L,3L,9L,1L,4L,4L,7L,5L,2L,5L,4L,9L,5L,6L,6L,5L,3L,9L,5L,5L,5L,5L,2L,4L,6L,3L,4L,2L,2L,8L,1L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011113Inst : IEnumerable<long>
{
public static readonly long[] Value=A011113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011113.Bytes);
public long this[int i]=>Value[i];

public static A011113Inst Instance=new A011113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011112
{
public static readonly long[] Value={ 1L,9L,3L,3L,1L,8L,2L,0L,4L,4L,9L,3L,1L,7L,6L,2L,7L,5L,1L,5L,2L,4L,8L,7L,8L,9L,4L,3L,2L,6L,6L,1L,6L,8L,1L,4L,6L,0L,6L,1L,8L,6L,0L,6L,2L,8L,4L,0L,2L,3L,0L,6L,8L,2L,4L,6L,3L,8L,5L,4L,6L,8L,8L,0L,4L,9L,8L,3L,9L,4L,6L,9L,0L,7L,5L,6L,5L,3L,7L,3L,0L,8L,1L,6L,6L,4L,3L,1L,1L,3L,6L,5L,2L,4L,5L,1L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011112Inst : IEnumerable<long>
{
public static readonly long[] Value=A011112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011112.Bytes);
public long this[int i]=>Value[i];

public static A011112Inst Instance=new A011112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011111
{
public static readonly long[] Value={ 1L,9L,1L,8L,6L,4L,5L,1L,9L,1L,6L,2L,5L,3L,0L,6L,2L,4L,7L,8L,6L,4L,2L,7L,8L,5L,6L,7L,1L,8L,5L,7L,3L,3L,0L,8L,8L,4L,2L,1L,5L,0L,6L,5L,2L,8L,6L,9L,4L,2L,8L,9L,2L,8L,2L,0L,2L,4L,2L,0L,8L,2L,2L,9L,5L,2L,3L,3L,5L,8L,0L,2L,9L,4L,9L,5L,4L,7L,5L,2L,6L,1L,1L,9L,1L,5L,5L,3L,8L,7L,7L,6L,0L,4L,9L,5L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011111Inst : IEnumerable<long>
{
public static readonly long[] Value=A011111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011111.Bytes);
public long this[int i]=>Value[i];

public static A011111Inst Instance=new A011111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011110
{
public static readonly long[] Value={ 1L,9L,0L,3L,6L,5L,3L,9L,3L,8L,7L,1L,5L,8L,7L,8L,4L,8L,9L,8L,9L,6L,1L,4L,7L,2L,8L,8L,1L,1L,9L,0L,9L,7L,7L,7L,8L,6L,5L,5L,0L,6L,2L,5L,8L,6L,1L,0L,8L,5L,6L,0L,5L,5L,2L,5L,8L,2L,3L,6L,1L,6L,8L,6L,9L,7L,2L,1L,1L,8L,2L,6L,3L,4L,4L,4L,6L,0L,5L,7L,8L,6L,9L,4L,4L,1L,9L,6L,2L,2L,5L,8L,4L,2L,2L,2L,3L,0L,4L,9L,9L,8L,5L,2L,4L,1L,1L,7L,6L,1L,4L,6L,6L,2L,6L,2L,7L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011110Inst : IEnumerable<long>
{
public static readonly long[] Value=A011110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011110.Bytes);
public long this[int i]=>Value[i];

public static A011110Inst Instance=new A011110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011109
{
public static readonly long[] Value={ 1L,8L,8L,8L,1L,7L,5L,0L,2L,2L,5L,8L,9L,8L,0L,3L,9L,6L,4L,3L,2L,8L,1L,2L,9L,4L,8L,9L,4L,5L,5L,5L,0L,5L,5L,1L,2L,4L,5L,2L,3L,8L,7L,4L,0L,4L,2L,3L,0L,0L,3L,0L,6L,7L,1L,5L,0L,2L,0L,9L,9L,7L,9L,0L,7L,0L,5L,5L,8L,6L,4L,8L,6L,5L,1L,3L,7L,8L,8L,9L,9L,6L,3L,1L,2L,8L,7L,7L,6L,3L,0L,3L,1L,8L,7L,1L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011109Inst : IEnumerable<long>
{
public static readonly long[] Value=A011109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011109.Bytes);
public long this[int i]=>Value[i];

public static A011109Inst Instance=new A011109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011108
{
public static readonly long[] Value={ 1L,8L,7L,2L,1L,7L,1L,2L,3L,0L,5L,5L,4L,8L,5L,7L,4L,1L,6L,6L,9L,5L,6L,5L,7L,8L,8L,1L,4L,5L,1L,9L,4L,3L,2L,0L,0L,9L,7L,2L,8L,6L,6L,4L,6L,7L,0L,8L,7L,9L,2L,9L,1L,7L,4L,0L,2L,7L,1L,3L,0L,0L,2L,7L,5L,1L,8L,2L,4L,6L,2L,0L,8L,3L,6L,4L,7L,0L,1L,3L,2L,3L,0L,9L,4L,8L,9L,4L,9L,9L,7L,3L,6L,8L,6L,1L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011108Inst : IEnumerable<long>
{
public static readonly long[] Value=A011108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011108.Bytes);
public long this[int i]=>Value[i];

public static A011108Inst Instance=new A011108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011107
{
public static readonly long[] Value={ 1L,8L,5L,5L,6L,0L,0L,7L,3L,6L,2L,5L,8L,0L,8L,4L,3L,3L,4L,7L,3L,2L,7L,7L,0L,5L,2L,1L,3L,2L,1L,6L,7L,4L,7L,9L,4L,5L,9L,9L,4L,9L,0L,5L,3L,7L,1L,5L,1L,9L,1L,8L,5L,0L,9L,1L,6L,3L,3L,2L,1L,3L,1L,7L,9L,8L,1L,5L,0L,1L,0L,7L,6L,9L,7L,0L,9L,2L,8L,3L,9L,0L,2L,3L,0L,1L,9L,7L,1L,5L,2L,0L,6L,6L,5L,3L,1L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011107Inst : IEnumerable<long>
{
public static readonly long[] Value=A011107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011107.Bytes);
public long this[int i]=>Value[i];

public static A011107Inst Instance=new A011107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011106
{
public static readonly long[] Value={ 1L,8L,3L,8L,4L,1L,6L,2L,8L,7L,2L,5L,2L,5L,4L,4L,0L,3L,6L,7L,0L,2L,7L,9L,8L,8L,0L,7L,1L,8L,4L,2L,2L,4L,0L,4L,2L,0L,4L,6L,7L,5L,4L,0L,3L,5L,4L,0L,4L,3L,0L,1L,7L,1L,2L,7L,3L,9L,6L,7L,8L,6L,4L,0L,5L,1L,3L,3L,5L,2L,9L,4L,1L,4L,0L,6L,3L,8L,5L,6L,8L,3L,6L,0L,7L,6L,9L,5L,4L,9L,7L,7L,6L,2L,1L,3L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011106Inst : IEnumerable<long>
{
public static readonly long[] Value=A011106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011106.Bytes);
public long this[int i]=>Value[i];

public static A011106Inst Instance=new A011106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011105
{
public static readonly long[] Value={ 1L,8L,2L,0L,5L,6L,4L,2L,0L,3L,0L,2L,6L,0L,8L,0L,2L,6L,4L,3L,7L,9L,4L,2L,1L,0L,5L,4L,7L,0L,5L,4L,6L,2L,9L,8L,4L,9L,3L,7L,6L,8L,7L,4L,2L,7L,9L,5L,8L,8L,4L,5L,1L,4L,5L,8L,2L,1L,7L,2L,4L,1L,8L,2L,6L,9L,6L,9L,2L,3L,8L,5L,3L,5L,8L,6L,6L,9L,0L,9L,9L,2L,9L,0L,1L,4L,8L,9L,1L,9L,1L,3L,0L,3L,5L,8L,7L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011105Inst : IEnumerable<long>
{
public static readonly long[] Value=A011105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011105.Bytes);
public long this[int i]=>Value[i];

public static A011105Inst Instance=new A011105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011104
{
public static readonly long[] Value={ 1L,8L,0L,1L,9L,8L,3L,1L,2L,7L,3L,1L,7L,1L,4L,2L,3L,0L,5L,1L,8L,2L,5L,5L,3L,9L,5L,2L,9L,6L,1L,8L,9L,0L,2L,5L,8L,9L,4L,3L,7L,0L,9L,7L,0L,2L,2L,8L,0L,0L,5L,3L,2L,6L,8L,0L,3L,7L,2L,5L,2L,0L,3L,0L,4L,2L,9L,4L,0L,7L,6L,2L,3L,5L,6L,3L,0L,6L,7L,0L,2L,6L,6L,8L,8L,0L,4L,4L,2L,5L,7L,5L,4L,4L,4L,8L,3L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011104Inst : IEnumerable<long>
{
public static readonly long[] Value=A011104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011104.Bytes);
public long this[int i]=>Value[i];

public static A011104Inst Instance=new A011104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011103
{
public static readonly long[] Value={ 1L,7L,8L,2L,6L,0L,2L,4L,5L,7L,9L,6L,6L,0L,0L,3L,3L,5L,5L,4L,9L,4L,8L,8L,7L,4L,7L,2L,1L,4L,0L,0L,8L,6L,6L,1L,0L,6L,3L,5L,8L,9L,5L,6L,9L,4L,7L,2L,7L,9L,9L,5L,8L,6L,0L,1L,4L,4L,1L,2L,2L,1L,5L,4L,9L,7L,2L,5L,2L,8L,8L,8L,1L,5L,6L,0L,5L,9L,0L,6L,4L,3L,4L,0L,9L,5L,8L,2L,3L,3L,3L,0L,4L,8L,4L,4L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011103Inst : IEnumerable<long>
{
public static readonly long[] Value=A011103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011103.Bytes);
public long this[int i]=>Value[i];

public static A011103Inst Instance=new A011103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011102
{
public static readonly long[] Value={ 1L,7L,6L,2L,3L,4L,0L,3L,4L,7L,8L,3L,2L,3L,1L,7L,0L,1L,3L,8L,6L,1L,0L,0L,2L,2L,5L,3L,5L,6L,4L,8L,6L,9L,9L,2L,8L,0L,8L,3L,0L,2L,9L,2L,8L,1L,9L,5L,8L,1L,6L,0L,8L,9L,7L,2L,3L,3L,2L,3L,1L,2L,3L,3L,0L,1L,8L,9L,5L,3L,7L,8L,8L,7L,2L,6L,4L,2L,9L,5L,7L,3L,1L,2L,7L,3L,9L,3L,0L,0L,1L,7L,0L,8L,9L,8L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011102Inst : IEnumerable<long>
{
public static readonly long[] Value=A011102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011102.Bytes);
public long this[int i]=>Value[i];

public static A011102Inst Instance=new A011102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011085
{
public static readonly long[] Value={ 3L,1L,1L,3L,7L,3L,7L,2L,5L,8L,4L,7L,7L,7L,6L,9L,8L,3L,3L,7L,0L,6L,4L,7L,2L,7L,9L,2L,0L,6L,7L,1L,2L,7L,3L,8L,1L,3L,0L,1L,8L,5L,8L,1L,9L,8L,4L,8L,5L,6L,2L,9L,0L,5L,9L,6L,8L,2L,0L,3L,9L,9L,7L,2L,3L,7L,8L,3L,7L,2L,5L,8L,7L,3L,2L,8L,6L,0L,2L,2L,8L,9L,5L,1L,5L,8L,7L,1L,0L,8L,9L,6L,0L,0L,3L,5L,9L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011085Inst : IEnumerable<long>
{
public static readonly long[] Value=A011085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011085.Bytes);
public long this[int i]=>Value[i];

public static A011085Inst Instance=new A011085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011084
{
public static readonly long[] Value={ 3L,1L,0L,5L,4L,2L,2L,7L,9L,9L,0L,7L,1L,4L,8L,1L,5L,0L,5L,6L,5L,8L,0L,8L,3L,7L,3L,2L,2L,8L,5L,6L,1L,4L,0L,5L,4L,2L,0L,3L,0L,9L,7L,8L,9L,0L,2L,2L,6L,6L,2L,3L,3L,1L,3L,9L,9L,0L,7L,9L,5L,4L,8L,6L,1L,2L,9L,4L,4L,4L,7L,2L,8L,7L,2L,7L,9L,7L,3L,0L,5L,0L,5L,7L,6L,6L,5L,9L,0L,4L,6L,0L,4L,0L,1L,7L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011084Inst : IEnumerable<long>
{
public static readonly long[] Value=A011084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011084.Bytes);
public long this[int i]=>Value[i];

public static A011084Inst Instance=new A011084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011083
{
public static readonly long[] Value={ 3L,0L,9L,7L,0L,4L,1L,0L,1L,4L,6L,8L,2L,4L,7L,2L,5L,3L,8L,7L,2L,6L,4L,6L,1L,2L,0L,5L,6L,9L,0L,9L,6L,9L,7L,0L,1L,4L,8L,3L,7L,0L,7L,2L,3L,6L,5L,5L,0L,1L,6L,2L,3L,3L,1L,3L,0L,5L,4L,6L,7L,7L,0L,7L,5L,6L,2L,7L,9L,2L,1L,0L,2L,2L,0L,2L,5L,8L,1L,9L,3L,3L,6L,7L,9L,8L,3L,8L,2L,7L,7L,3L,8L,1L,1L,9L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011083Inst : IEnumerable<long>
{
public static readonly long[] Value=A011083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011083.Bytes);
public long this[int i]=>Value[i];

public static A011083Inst Instance=new A011083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011082
{
public static readonly long[] Value={ 3L,0L,8L,8L,5L,9L,0L,6L,1L,9L,3L,8L,7L,6L,6L,1L,1L,7L,3L,9L,4L,2L,0L,5L,7L,9L,1L,8L,6L,9L,1L,4L,4L,6L,1L,9L,0L,1L,8L,0L,7L,3L,7L,5L,4L,9L,5L,4L,1L,9L,3L,0L,1L,6L,2L,9L,7L,2L,6L,4L,1L,7L,3L,8L,8L,6L,4L,9L,5L,1L,3L,2L,6L,5L,4L,6L,3L,5L,0L,0L,5L,0L,4L,4L,2L,3L,1L,4L,0L,6L,3L,8L,8L,2L,7L,7L,4L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011082Inst : IEnumerable<long>
{
public static readonly long[] Value=A011082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011082.Bytes);
public long this[int i]=>Value[i];

public static A011082Inst Instance=new A011082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011081
{
public static readonly long[] Value={ 3L,0L,8L,0L,0L,7L,0L,2L,8L,8L,2L,4L,1L,0L,2L,2L,9L,1L,7L,1L,9L,1L,7L,1L,7L,7L,6L,6L,8L,4L,5L,7L,3L,9L,9L,1L,1L,4L,5L,7L,1L,9L,8L,7L,7L,6L,5L,7L,6L,4L,0L,3L,4L,8L,1L,6L,4L,2L,7L,9L,6L,6L,1L,5L,8L,4L,6L,3L,8L,8L,9L,0L,8L,2L,9L,7L,2L,4L,5L,1L,7L,9L,7L,2L,5L,4L,3L,9L,3L,5L,2L,5L,3L,5L,0L,0L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011081Inst : IEnumerable<long>
{
public static readonly long[] Value=A011081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011081.Bytes);
public long this[int i]=>Value[i];

public static A011081Inst Instance=new A011081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011080
{
public static readonly long[] Value={ 3L,0L,7L,1L,4L,7L,8L,6L,5L,5L,6L,4L,0L,7L,3L,2L,8L,8L,9L,2L,7L,1L,8L,8L,0L,9L,6L,3L,5L,0L,7L,4L,5L,2L,4L,4L,6L,4L,6L,4L,2L,9L,6L,8L,8L,7L,1L,6L,0L,2L,0L,1L,8L,4L,6L,1L,7L,4L,7L,8L,7L,9L,5L,8L,6L,8L,6L,6L,2L,4L,1L,4L,8L,0L,2L,9L,7L,9L,3L,2L,4L,5L,0L,7L,4L,4L,1L,7L,8L,5L,3L,8L,7L,2L,4L,9L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011080Inst : IEnumerable<long>
{
public static readonly long[] Value=A011080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011080.Bytes);
public long this[int i]=>Value[i];

public static A011080Inst Instance=new A011080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011079
{
public static readonly long[] Value={ 3L,0L,6L,2L,8L,1L,4L,3L,1L,3L,6L,0L,8L,7L,8L,6L,0L,3L,1L,1L,8L,9L,0L,6L,0L,8L,2L,2L,9L,8L,2L,7L,0L,9L,5L,6L,6L,5L,7L,5L,3L,8L,6L,1L,2L,5L,0L,6L,7L,1L,0L,1L,9L,2L,1L,7L,3L,0L,7L,5L,6L,2L,6L,8L,5L,1L,4L,9L,6L,6L,9L,8L,9L,9L,4L,3L,9L,3L,0L,7L,6L,4L,8L,0L,6L,1L,7L,0L,5L,7L,4L,4L,3L,0L,0L,0L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011079Inst : IEnumerable<long>
{
public static readonly long[] Value=A011079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011079.Bytes);
public long this[int i]=>Value[i];

public static A011079Inst Instance=new A011079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011078
{
public static readonly long[] Value={ 3L,0L,5L,4L,0L,7L,5L,8L,0L,9L,9L,7L,7L,3L,5L,1L,4L,0L,4L,6L,3L,8L,8L,3L,2L,8L,8L,2L,0L,5L,7L,4L,8L,9L,4L,4L,7L,6L,1L,5L,0L,2L,2L,4L,7L,9L,9L,9L,8L,6L,8L,2L,1L,6L,4L,9L,0L,0L,9L,3L,0L,0L,5L,4L,6L,5L,4L,6L,5L,2L,8L,3L,5L,4L,4L,2L,6L,3L,9L,6L,7L,5L,5L,5L,5L,7L,5L,3L,0L,6L,5L,1L,6L,3L,4L,2L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011078Inst : IEnumerable<long>
{
public static readonly long[] Value=A011078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011078.Bytes);
public long this[int i]=>Value[i];

public static A011078Inst Instance=new A011078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011077
{
public static readonly long[] Value={ 3L,0L,4L,5L,2L,6L,1L,6L,4L,6L,4L,7L,5L,6L,6L,9L,2L,1L,5L,5L,0L,0L,0L,0L,6L,1L,4L,8L,1L,4L,4L,2L,5L,4L,2L,9L,1L,2L,8L,5L,8L,7L,2L,7L,2L,6L,7L,6L,3L,6L,5L,2L,8L,4L,0L,3L,6L,7L,0L,0L,9L,0L,4L,9L,7L,2L,0L,8L,0L,6L,0L,3L,9L,5L,5L,9L,5L,2L,2L,8L,1L,3L,9L,4L,4L,9L,4L,1L,0L,4L,9L,8L,8L,8L,7L,4L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011077Inst : IEnumerable<long>
{
public static readonly long[] Value=A011077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011077.Bytes);
public long this[int i]=>Value[i];

public static A011077Inst Instance=new A011077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011076
{
public static readonly long[] Value={ 3L,0L,3L,6L,3L,7L,0L,2L,7L,6L,7L,1L,0L,8L,1L,1L,0L,5L,7L,4L,6L,8L,1L,8L,0L,4L,5L,8L,8L,8L,8L,1L,0L,4L,3L,6L,6L,0L,8L,4L,5L,0L,3L,0L,4L,3L,0L,4L,5L,8L,7L,8L,3L,2L,6L,0L,0L,5L,9L,5L,2L,4L,5L,9L,2L,6L,9L,4L,5L,1L,2L,0L,9L,8L,3L,6L,9L,7L,4L,6L,6L,3L,2L,4L,1L,0L,1L,7L,6L,3L,4L,9L,5L,9L,8L,8L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011076Inst : IEnumerable<long>
{
public static readonly long[] Value=A011076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011076.Bytes);
public long this[int i]=>Value[i];

public static A011076Inst Instance=new A011076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011075
{
public static readonly long[] Value={ 3L,0L,2L,7L,4L,0L,0L,1L,0L,4L,0L,3L,5L,0L,9L,1L,0L,3L,3L,5L,3L,9L,6L,5L,9L,1L,1L,8L,4L,7L,9L,8L,9L,0L,1L,4L,5L,5L,0L,2L,7L,2L,0L,7L,2L,6L,5L,2L,2L,2L,8L,2L,9L,8L,7L,0L,2L,2L,3L,9L,4L,4L,1L,6L,4L,2L,8L,0L,4L,4L,5L,3L,4L,4L,9L,5L,1L,7L,3L,5L,6L,0L,2L,8L,0L,2L,5L,1L,1L,3L,8L,7L,1L,8L,3L,1L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011075Inst : IEnumerable<long>
{
public static readonly long[] Value=A011075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011075.Bytes);
public long this[int i]=>Value[i];

public static A011075Inst Instance=new A011075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011074
{
public static readonly long[] Value={ 3L,0L,1L,8L,3L,4L,9L,4L,7L,9L,2L,9L,2L,3L,3L,3L,1L,8L,6L,2L,5L,5L,9L,5L,8L,9L,6L,6L,2L,5L,8L,2L,7L,8L,6L,6L,7L,9L,7L,7L,0L,2L,3L,5L,4L,0L,0L,3L,7L,4L,9L,7L,1L,4L,2L,7L,1L,0L,3L,2L,5L,2L,7L,4L,7L,9L,7L,9L,5L,9L,9L,9L,5L,2L,9L,5L,0L,9L,9L,8L,2L,0L,7L,7L,1L,0L,6L,0L,7L,2L,5L,8L,4L,8L,7L,0L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011074Inst : IEnumerable<long>
{
public static readonly long[] Value=A011074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011074.Bytes);
public long this[int i]=>Value[i];

public static A011074Inst Instance=new A011074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011073
{
public static readonly long[] Value={ 3L,0L,0L,9L,2L,1L,6L,6L,9L,8L,4L,3L,4L,5L,6L,3L,8L,2L,2L,5L,5L,9L,4L,0L,8L,5L,2L,3L,3L,7L,8L,2L,3L,5L,8L,3L,9L,6L,2L,8L,1L,1L,4L,0L,0L,2L,2L,9L,3L,1L,6L,0L,4L,5L,8L,1L,4L,3L,6L,0L,9L,1L,5L,2L,3L,9L,4L,4L,9L,5L,8L,1L,1L,7L,5L,0L,2L,4L,8L,4L,6L,1L,9L,5L,3L,4L,2L,8L,4L,0L,7L,4L,2L,0L,9L,8L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011073Inst : IEnumerable<long>
{
public static readonly long[] Value=A011073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011073.Bytes);
public long this[int i]=>Value[i];

public static A011073Inst Instance=new A011073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011072
{
public static readonly long[] Value={ 2L,9L,9L,0L,6L,9L,7L,5L,6L,2L,4L,4L,2L,4L,4L,1L,0L,8L,3L,8L,2L,3L,7L,9L,7L,9L,8L,8L,2L,8L,1L,8L,2L,6L,7L,9L,0L,7L,2L,6L,9L,1L,9L,5L,1L,5L,2L,2L,9L,4L,1L,2L,6L,9L,1L,0L,3L,3L,1L,8L,7L,0L,0L,0L,0L,9L,5L,8L,4L,2L,9L,3L,3L,9L,4L,5L,9L,9L,4L,0L,2L,5L,6L,9L,7L,2L,4L,8L,8L,5L,1L,4L,1L,4L,9L,7L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011072Inst : IEnumerable<long>
{
public static readonly long[] Value=A011072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011072.Bytes);
public long this[int i]=>Value[i];

public static A011072Inst Instance=new A011072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011071
{
public static readonly long[] Value={ 2L,9L,8L,1L,3L,0L,7L,5L,0L,1L,3L,0L,1L,3L,3L,1L,5L,2L,1L,2L,1L,9L,7L,9L,6L,6L,7L,4L,3L,2L,6L,3L,6L,4L,8L,0L,7L,2L,2L,0L,3L,8L,9L,0L,5L,6L,7L,6L,8L,3L,1L,9L,7L,5L,1L,8L,3L,0L,4L,7L,6L,2L,1L,8L,0L,9L,0L,3L,7L,7L,9L,3L,7L,2L,8L,0L,9L,3L,6L,6L,6L,5L,9L,2L,9L,5L,4L,0L,2L,2L,9L,5L,1L,9L,5L,4L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011071Inst : IEnumerable<long>
{
public static readonly long[] Value=A011071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011071.Bytes);
public long this[int i]=>Value[i];

public static A011071Inst Instance=new A011071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011070
{
public static readonly long[] Value={ 2L,9L,7L,1L,8L,2L,7L,8L,6L,6L,2L,0L,0L,8L,4L,1L,5L,2L,7L,9L,3L,3L,1L,8L,3L,6L,9L,9L,3L,4L,4L,3L,0L,0L,8L,1L,0L,8L,6L,1L,3L,2L,6L,5L,0L,1L,3L,7L,2L,8L,1L,6L,9L,6L,3L,9L,9L,4L,4L,6L,6L,3L,4L,9L,1L,3L,5L,6L,8L,7L,1L,0L,4L,7L,7L,5L,5L,4L,2L,9L,8L,0L,5L,8L,4L,5L,3L,5L,1L,5L,7L,1L,5L,3L,7L,3L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011070Inst : IEnumerable<long>
{
public static readonly long[] Value=A011070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011070.Bytes);
public long this[int i]=>Value[i];

public static A011070Inst Instance=new A011070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011069
{
public static readonly long[] Value={ 2L,9L,6L,2L,2L,5L,6L,6L,3L,7L,6L,6L,5L,2L,9L,8L,9L,2L,1L,3L,9L,1L,8L,2L,7L,6L,8L,1L,2L,3L,7L,3L,2L,6L,2L,7L,3L,6L,7L,0L,8L,8L,2L,0L,9L,2L,8L,1L,5L,4L,9L,6L,1L,0L,2L,4L,7L,8L,4L,7L,0L,5L,1L,6L,8L,3L,1L,5L,8L,2L,2L,2L,3L,3L,7L,2L,7L,7L,8L,1L,2L,8L,4L,0L,3L,1L,5L,1L,7L,7L,0L,7L,7L,9L,2L,7L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011069Inst : IEnumerable<long>
{
public static readonly long[] Value=A011069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011069.Bytes);
public long this[int i]=>Value[i];

public static A011069Inst Instance=new A011069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011068
{
public static readonly long[] Value={ 2L,9L,5L,2L,5L,9L,1L,7L,2L,3L,7L,3L,7L,1L,8L,9L,3L,5L,4L,8L,6L,7L,4L,2L,1L,3L,0L,6L,3L,2L,0L,1L,4L,0L,1L,0L,0L,2L,8L,7L,3L,4L,8L,0L,8L,1L,2L,0L,4L,0L,6L,3L,7L,2L,5L,0L,6L,4L,1L,3L,5L,3L,1L,2L,7L,9L,9L,5L,8L,6L,1L,9L,4L,5L,9L,8L,5L,4L,2L,6L,9L,8L,4L,7L,1L,5L,4L,6L,2L,5L,2L,3L,4L,0L,8L,1L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011068Inst : IEnumerable<long>
{
public static readonly long[] Value=A011068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011068.Bytes);
public long this[int i]=>Value[i];

public static A011068Inst Instance=new A011068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011067
{
public static readonly long[] Value={ 2L,9L,4L,2L,8L,3L,0L,9L,5L,6L,3L,8L,2L,7L,1L,1L,8L,4L,5L,3L,5L,7L,3L,1L,1L,6L,7L,4L,0L,9L,8L,1L,7L,1L,1L,6L,7L,5L,1L,8L,1L,3L,4L,3L,7L,1L,4L,4L,4L,9L,7L,1L,1L,1L,6L,3L,3L,5L,0L,4L,2L,1L,9L,1L,9L,5L,1L,7L,3L,5L,6L,3L,2L,6L,9L,9L,4L,5L,0L,4L,4L,8L,1L,7L,7L,5L,8L,5L,0L,1L,3L,8L,9L,3L,3L,8L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011067Inst : IEnumerable<long>
{
public static readonly long[] Value=A011067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011067.Bytes);
public long this[int i]=>Value[i];

public static A011067Inst Instance=new A011067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011066
{
public static readonly long[] Value={ 2L,9L,3L,2L,9L,7L,2L,0L,8L,7L,6L,6L,8L,5L,1L,8L,3L,2L,9L,8L,6L,4L,7L,8L,6L,8L,7L,5L,0L,8L,9L,7L,7L,1L,2L,9L,1L,9L,3L,6L,5L,0L,3L,8L,5L,3L,9L,1L,6L,1L,6L,5L,5L,6L,2L,0L,9L,9L,8L,1L,2L,9L,2L,0L,6L,7L,9L,4L,6L,2L,6L,3L,1L,7L,3L,0L,2L,2L,1L,3L,1L,3L,5L,4L,8L,7L,8L,5L,8L,7L,6L,1L,4L,8L,1L,8L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011066Inst : IEnumerable<long>
{
public static readonly long[] Value=A011066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011066.Bytes);
public long this[int i]=>Value[i];

public static A011066Inst Instance=new A011066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011065
{
public static readonly long[] Value={ 2L,9L,2L,3L,0L,1L,2L,7L,8L,5L,6L,9L,1L,7L,6L,4L,8L,3L,9L,8L,8L,4L,7L,3L,3L,8L,1L,4L,5L,5L,6L,1L,6L,0L,9L,3L,4L,3L,4L,9L,6L,4L,3L,0L,0L,9L,9L,4L,2L,7L,7L,8L,2L,9L,3L,9L,6L,2L,9L,4L,0L,5L,1L,4L,1L,2L,3L,1L,3L,8L,9L,0L,0L,3L,7L,7L,0L,5L,0L,9L,5L,6L,8L,6L,2L,2L,8L,9L,0L,3L,6L,2L,8L,1L,3L,9L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011065Inst : IEnumerable<long>
{
public static readonly long[] Value=A011065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011065.Bytes);
public long this[int i]=>Value[i];

public static A011065Inst Instance=new A011065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011064
{
public static readonly long[] Value={ 2L,9L,1L,2L,9L,5L,0L,6L,3L,0L,2L,4L,3L,9L,4L,0L,5L,2L,1L,7L,0L,2L,3L,2L,3L,7L,6L,4L,9L,4L,6L,5L,0L,4L,8L,7L,4L,2L,7L,9L,5L,3L,9L,1L,4L,7L,0L,6L,9L,4L,9L,1L,2L,6L,2L,1L,8L,3L,7L,7L,5L,2L,9L,8L,5L,8L,7L,0L,1L,4L,4L,7L,1L,7L,3L,7L,1L,7L,0L,1L,3L,9L,1L,7L,1L,7L,9L,8L,1L,5L,7L,9L,2L,6L,2L,6L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011064Inst : IEnumerable<long>
{
public static readonly long[] Value=A011064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011064.Bytes);
public long this[int i]=>Value[i];

public static A011064Inst Instance=new A011064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011063
{
public static readonly long[] Value={ 2L,9L,0L,2L,7L,8L,3L,1L,0L,8L,1L,8L,7L,0L,9L,9L,5L,7L,4L,1L,3L,0L,3L,4L,7L,6L,0L,8L,3L,8L,2L,6L,9L,6L,0L,5L,0L,8L,1L,1L,9L,3L,1L,5L,8L,5L,4L,8L,4L,6L,2L,7L,9L,1L,5L,2L,9L,5L,4L,8L,1L,0L,5L,1L,3L,1L,1L,8L,8L,7L,1L,0L,6L,3L,9L,9L,1L,5L,3L,6L,2L,6L,3L,5L,9L,9L,2L,5L,9L,9L,2L,6L,8L,8L,5L,2L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011063Inst : IEnumerable<long>
{
public static readonly long[] Value=A011063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011063.Bytes);
public long this[int i]=>Value[i];

public static A011063Inst Instance=new A011063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011062
{
public static readonly long[] Value={ 2L,8L,9L,2L,5L,0L,7L,6L,0L,8L,5L,1L,9L,0L,7L,7L,9L,4L,5L,9L,3L,2L,9L,7L,3L,7L,2L,9L,9L,5L,1L,5L,3L,0L,6L,4L,0L,0L,3L,5L,0L,9L,8L,3L,5L,6L,0L,3L,8L,4L,7L,1L,5L,1L,7L,8L,5L,4L,9L,0L,5L,4L,6L,4L,2L,2L,6L,2L,3L,4L,2L,2L,3L,8L,8L,3L,6L,8L,3L,0L,4L,8L,8L,7L,2L,9L,6L,4L,0L,4L,3L,6L,4L,5L,5L,8L,7L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011062Inst : IEnumerable<long>
{
public static readonly long[] Value=A011062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011062.Bytes);
public long this[int i]=>Value[i];

public static A011062Inst Instance=new A011062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011061
{
public static readonly long[] Value={ 2L,8L,8L,2L,1L,2L,1L,4L,1L,7L,1L,0L,2L,0L,0L,5L,9L,3L,2L,1L,7L,6L,4L,9L,6L,0L,7L,6L,9L,3L,6L,1L,4L,6L,6L,6L,5L,5L,6L,5L,1L,0L,1L,8L,1L,4L,3L,0L,0L,5L,7L,4L,3L,7L,1L,3L,2L,6L,8L,9L,7L,8L,7L,8L,9L,6L,8L,6L,4L,8L,9L,0L,1L,0L,6L,4L,1L,8L,0L,6L,4L,6L,3L,9L,9L,2L,3L,3L,4L,8L,6L,1L,0L,5L,5L,3L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011061Inst : IEnumerable<long>
{
public static readonly long[] Value=A011061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011061.Bytes);
public long this[int i]=>Value[i];

public static A011061Inst Instance=new A011061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011060
{
public static readonly long[] Value={ 2L,8L,7L,1L,6L,2L,1L,7L,1L,1L,0L,2L,5L,9L,0L,0L,6L,2L,2L,2L,9L,8L,6L,0L,1L,3L,7L,5L,5L,1L,2L,5L,6L,6L,4L,6L,7L,6L,1L,9L,5L,1L,8L,1L,4L,5L,6L,1L,8L,6L,3L,5L,6L,6L,1L,0L,4L,1L,4L,2L,0L,8L,7L,2L,4L,7L,9L,0L,6L,6L,6L,8L,0L,2L,8L,7L,9L,5L,6L,5L,9L,9L,7L,2L,5L,4L,6L,9L,3L,0L,6L,1L,4L,8L,7L,5L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011060Inst : IEnumerable<long>
{
public static readonly long[] Value=A011060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011060.Bytes);
public long this[int i]=>Value[i];

public static A011060Inst Instance=new A011060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011059
{
public static readonly long[] Value={ 2L,8L,6L,1L,0L,0L,5L,5L,5L,2L,5L,7L,6L,3L,0L,5L,2L,8L,9L,4L,6L,6L,5L,5L,7L,4L,4L,5L,1L,9L,6L,2L,4L,7L,0L,1L,7L,1L,1L,9L,5L,5L,3L,1L,7L,5L,8L,9L,6L,2L,9L,1L,8L,0L,1L,9L,2L,9L,4L,1L,8L,5L,8L,5L,5L,0L,8L,0L,7L,8L,3L,4L,4L,6L,7L,8L,1L,0L,8L,8L,3L,0L,3L,1L,5L,8L,2L,1L,7L,9L,5L,2L,0L,9L,9L,7L,7L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011059Inst : IEnumerable<long>
{
public static readonly long[] Value=A011059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011059.Bytes);
public long this[int i]=>Value[i];

public static A011059Inst Instance=new A011059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011058
{
public static readonly long[] Value={ 2L,8L,5L,0L,2L,6L,9L,8L,8L,2L,7L,7L,1L,7L,9L,8L,2L,1L,8L,7L,6L,6L,7L,4L,6L,7L,8L,3L,0L,6L,3L,8L,4L,2L,7L,2L,8L,1L,1L,5L,4L,7L,2L,3L,0L,5L,6L,1L,5L,6L,8L,9L,9L,8L,7L,9L,2L,1L,1L,9L,5L,3L,4L,5L,2L,2L,2L,1L,9L,0L,4L,7L,8L,1L,6L,4L,1L,4L,7L,1L,3L,7L,7L,0L,5L,6L,6L,2L,1L,2L,8L,2L,9L,1L,4L,8L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011058Inst : IEnumerable<long>
{
public static readonly long[] Value=A011058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011058.Bytes);
public long this[int i]=>Value[i];

public static A011058Inst Instance=new A011058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011057
{
public static readonly long[] Value={ 2L,8L,3L,9L,4L,1L,1L,5L,1L,4L,4L,3L,3L,6L,7L,7L,4L,4L,4L,0L,8L,2L,2L,6L,2L,9L,3L,9L,0L,7L,9L,9L,2L,6L,3L,4L,0L,1L,1L,9L,6L,8L,1L,7L,1L,1L,7L,4L,3L,5L,5L,3L,4L,3L,5L,1L,2L,9L,4L,6L,4L,7L,9L,4L,4L,8L,9L,9L,9L,3L,8L,6L,3L,3L,1L,3L,3L,9L,0L,6L,3L,4L,8L,7L,4L,9L,1L,4L,9L,8L,3L,9L,7L,4L,8L,4L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011057Inst : IEnumerable<long>
{
public static readonly long[] Value=A011057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011057.Bytes);
public long this[int i]=>Value[i];

public static A011057Inst Instance=new A011057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011056
{
public static readonly long[] Value={ 2L,8L,1L,7L,3L,1L,3L,2L,4L,7L,2L,6L,1L,2L,5L,7L,5L,5L,8L,7L,7L,5L,9L,2L,5L,4L,4L,9L,8L,1L,5L,6L,6L,7L,0L,7L,8L,3L,7L,7L,7L,6L,5L,4L,5L,6L,8L,1L,7L,1L,2L,1L,5L,5L,7L,7L,1L,1L,6L,3L,4L,8L,3L,0L,1L,3L,7L,3L,4L,2L,6L,9L,6L,0L,5L,6L,3L,7L,1L,0L,1L,6L,8L,8L,9L,5L,6L,3L,3L,0L,3L,0L,4L,0L,6L,4L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011056Inst : IEnumerable<long>
{
public static readonly long[] Value=A011056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011056.Bytes);
public long this[int i]=>Value[i];

public static A011056Inst Instance=new A011056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011055
{
public static readonly long[] Value={ 2L,8L,0L,6L,0L,6L,6L,2L,6L,3L,2L,9L,6L,6L,8L,3L,2L,7L,3L,7L,6L,1L,4L,8L,8L,7L,6L,8L,4L,9L,9L,9L,3L,5L,7L,0L,0L,5L,0L,6L,0L,5L,4L,0L,3L,8L,5L,4L,6L,0L,4L,8L,6L,5L,2L,6L,1L,0L,2L,2L,9L,3L,5L,4L,7L,3L,3L,2L,1L,8L,2L,1L,7L,4L,1L,1L,4L,6L,2L,8L,5L,6L,1L,1L,5L,6L,9L,2L,9L,7L,8L,3L,2L,2L,2L,9L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011055Inst : IEnumerable<long>
{
public static readonly long[] Value=A011055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011055.Bytes);
public long this[int i]=>Value[i];

public static A011055Inst Instance=new A011055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011054
{
public static readonly long[] Value={ 2L,7L,9L,4L,6L,8L,2L,3L,9L,2L,6L,7L,1L,2L,4L,1L,3L,4L,3L,9L,9L,2L,9L,7L,3L,8L,1L,6L,5L,8L,8L,4L,5L,8L,9L,7L,3L,4L,7L,3L,3L,9L,1L,1L,0L,0L,2L,7L,0L,1L,4L,3L,3L,1L,0L,2L,8L,0L,1L,7L,0L,5L,7L,9L,2L,8L,1L,3L,7L,6L,8L,6L,9L,0L,9L,7L,2L,9L,9L,9L,1L,6L,5L,8L,8L,5L,0L,8L,1L,5L,3L,0L,2L,6L,2L,0L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011054Inst : IEnumerable<long>
{
public static readonly long[] Value=A011054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011054.Bytes);
public long this[int i]=>Value[i];

public static A011054Inst Instance=new A011054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011053
{
public static readonly long[] Value={ 2L,7L,8L,3L,1L,5L,7L,6L,8L,3L,7L,1L,3L,7L,4L,0L,6L,0L,2L,1L,0L,7L,5L,0L,6L,4L,5L,2L,8L,5L,4L,4L,7L,4L,0L,3L,3L,9L,2L,6L,9L,9L,0L,3L,9L,2L,2L,3L,6L,6L,0L,7L,1L,1L,8L,5L,7L,1L,8L,4L,4L,2L,7L,2L,1L,2L,0L,3L,7L,0L,4L,9L,3L,9L,8L,1L,6L,7L,7L,3L,3L,1L,8L,6L,1L,5L,8L,1L,6L,7L,7L,8L,5L,0L,9L,9L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011053Inst : IEnumerable<long>
{
public static readonly long[] Value=A011053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011053.Bytes);
public long this[int i]=>Value[i];

public static A011053Inst Instance=new A011053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011052
{
public static readonly long[] Value={ 2L,7L,7L,1L,4L,8L,8L,0L,0L,2L,4L,7L,6L,0L,3L,6L,0L,0L,8L,3L,8L,9L,5L,2L,4L,4L,5L,5L,2L,5L,4L,6L,9L,4L,0L,9L,4L,7L,4L,1L,9L,4L,1L,3L,3L,2L,0L,8L,6L,1L,2L,0L,7L,6L,5L,0L,7L,8L,2L,3L,2L,2L,9L,4L,9L,3L,5L,6L,1L,9L,4L,3L,3L,3L,2L,0L,2L,7L,3L,2L,8L,7L,0L,6L,7L,8L,9L,4L,5L,4L,1L,9L,6L,0L,7L,4L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011052Inst : IEnumerable<long>
{
public static readonly long[] Value=A011052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011052.Bytes);
public long this[int i]=>Value[i];

public static A011052Inst Instance=new A011052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011051
{
public static readonly long[] Value={ 2L,7L,5L,9L,6L,6L,9L,0L,2L,1L,0L,7L,1L,8L,9L,4L,4L,6L,3L,0L,0L,2L,0L,2L,5L,7L,4L,4L,2L,5L,8L,2L,5L,9L,2L,5L,1L,0L,0L,4L,8L,4L,2L,8L,2L,3L,9L,7L,1L,2L,5L,3L,2L,9L,5L,4L,8L,1L,6L,6L,4L,5L,2L,4L,7L,4L,6L,6L,9L,6L,9L,5L,3L,3L,3L,9L,5L,8L,3L,8L,2L,5L,6L,6L,5L,4L,6L,4L,2L,1L,7L,7L,7L,0L,9L,9L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011051Inst : IEnumerable<long>
{
public static readonly long[] Value=A011051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011051.Bytes);
public long this[int i]=>Value[i];

public static A011051Inst Instance=new A011051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011050
{
public static readonly long[] Value={ 2L,7L,4L,7L,6L,9L,6L,2L,0L,5L,0L,5L,4L,4L,7L,2L,4L,8L,3L,4L,7L,3L,4L,2L,6L,3L,4L,1L,8L,1L,2L,4L,7L,7L,4L,7L,3L,7L,0L,3L,4L,2L,8L,8L,4L,5L,1L,7L,5L,5L,9L,8L,5L,5L,7L,8L,4L,2L,8L,8L,8L,6L,6L,4L,0L,4L,5L,5L,0L,2L,6L,6L,6L,6L,6L,0L,4L,7L,7L,4L,7L,5L,0L,9L,7L,9L,0L,4L,9L,0L,4L,6L,7L,6L,4L,0L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011050Inst : IEnumerable<long>
{
public static readonly long[] Value=A011050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011050.Bytes);
public long this[int i]=>Value[i];

public static A011050Inst Instance=new A011050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011049
{
public static readonly long[] Value={ 2L,7L,3L,5L,5L,6L,4L,7L,9L,9L,7L,3L,4L,7L,6L,0L,9L,4L,7L,9L,2L,1L,4L,5L,7L,7L,0L,2L,2L,4L,2L,2L,5L,2L,6L,6L,5L,7L,5L,8L,0L,0L,6L,8L,0L,4L,6L,3L,5L,1L,2L,3L,3L,2L,5L,0L,2L,9L,8L,5L,5L,3L,9L,7L,0L,4L,8L,6L,4L,2L,8L,3L,5L,9L,0L,7L,2L,9L,4L,2L,7L,3L,2L,4L,2L,0L,8L,7L,4L,5L,8L,4L,1L,9L,7L,1L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011049Inst : IEnumerable<long>
{
public static readonly long[] Value=A011049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011049.Bytes);
public long this[int i]=>Value[i];

public static A011049Inst Instance=new A011049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011048
{
public static readonly long[] Value={ 2L,7L,2L,3L,2L,6L,9L,8L,1L,5L,3L,3L,1L,5L,0L,0L,1L,5L,3L,5L,3L,9L,0L,4L,7L,1L,5L,6L,2L,5L,9L,1L,5L,7L,0L,1L,3L,0L,8L,1L,5L,4L,8L,3L,6L,0L,5L,4L,1L,5L,9L,1L,2L,4L,7L,9L,0L,1L,0L,9L,3L,6L,1L,6L,7L,8L,8L,0L,8L,1L,4L,0L,1L,8L,3L,9L,5L,1L,8L,5L,5L,9L,4L,3L,6L,0L,1L,3L,8L,6L,0L,0L,4L,3L,0L,7L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011048Inst : IEnumerable<long>
{
public static readonly long[] Value=A011048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011048.Bytes);
public long this[int i]=>Value[i];

public static A011048Inst Instance=new A011048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011047
{
public static readonly long[] Value={ 2L,7L,1L,0L,8L,0L,6L,0L,1L,0L,8L,2L,9L,5L,3L,4L,4L,9L,5L,8L,8L,6L,6L,5L,4L,1L,5L,8L,6L,7L,4L,3L,3L,2L,5L,7L,0L,6L,6L,6L,0L,5L,1L,1L,2L,1L,8L,0L,9L,4L,3L,0L,5L,4L,7L,1L,1L,2L,9L,6L,8L,8L,5L,8L,7L,4L,0L,3L,0L,9L,3L,9L,7L,0L,7L,3L,8L,3L,4L,3L,2L,9L,4L,9L,3L,3L,1L,0L,6L,3L,6L,1L,8L,1L,2L,0L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011047Inst : IEnumerable<long>
{
public static readonly long[] Value=A011047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011047.Bytes);
public long this[int i]=>Value[i];

public static A011047Inst Instance=new A011047Inst();

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