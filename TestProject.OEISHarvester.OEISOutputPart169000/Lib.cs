using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199457
{
public static readonly long[] Value={ 2L,3L,3L,3L,8L,5L,4L,8L,5L,0L,2L,8L,5L,2L,9L,2L,1L,2L,8L,3L,3L,0L,3L,7L,1L,0L,9L,9L,3L,1L,7L,4L,8L,0L,5L,3L,9L,2L,4L,4L,2L,0L,9L,2L,5L,7L,3L,8L,2L,2L,0L,6L,5L,2L,3L,3L,3L,0L,4L,2L,7L,0L,8L,2L,5L,6L,1L,6L,1L,8L,9L,6L,9L,1L,7L,1L,8L,1L,0L,8L,0L,6L,6L,3L,5L,9L,9L,8L,3L,8L,0L,0L,8L,5L,0L,5L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199457Inst : IEnumerable<long>
{
public static readonly long[] Value=A199457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199457.Bytes);
public long this[int i]=>Value[i];

public static A199457Inst Instance=new A199457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199458
{
public static readonly long[] Value={ 2L,1L,7L,0L,8L,5L,3L,3L,9L,9L,9L,4L,4L,2L,6L,8L,4L,6L,6L,1L,8L,2L,9L,6L,7L,7L,8L,9L,6L,2L,4L,5L,3L,8L,9L,9L,3L,1L,8L,7L,7L,3L,3L,2L,7L,6L,9L,0L,3L,4L,8L,5L,9L,1L,8L,0L,8L,0L,1L,0L,9L,5L,9L,7L,0L,0L,1L,5L,1L,5L,5L,8L,6L,4L,8L,0L,9L,7L,7L,9L,1L,2L,2L,0L,6L,3L,3L,3L,8L,1L,2L,6L,1L,1L,7L,3L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199458Inst : IEnumerable<long>
{
public static readonly long[] Value=A199458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199458.Bytes);
public long this[int i]=>Value[i];

public static A199458Inst Instance=new A199458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199459
{
public static readonly long[] Value={ 2L,0L,1L,7L,7L,4L,6L,7L,6L,0L,9L,2L,2L,1L,1L,8L,4L,5L,3L,5L,4L,7L,3L,0L,6L,4L,1L,9L,4L,0L,3L,2L,6L,0L,3L,7L,4L,4L,1L,3L,2L,6L,5L,9L,4L,0L,2L,6L,5L,5L,5L,1L,1L,3L,6L,9L,8L,7L,5L,6L,6L,2L,7L,3L,2L,5L,2L,1L,2L,0L,5L,9L,7L,9L,4L,3L,2L,3L,0L,1L,0L,7L,9L,6L,8L,1L,4L,3L,8L,5L,4L,2L,4L,7L,5L,5L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199459Inst : IEnumerable<long>
{
public static readonly long[] Value=A199459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199459.Bytes);
public long this[int i]=>Value[i];

public static A199459Inst Instance=new A199459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199460
{
public static readonly long[] Value={ 1L,8L,9L,5L,4L,9L,4L,2L,6L,7L,0L,3L,3L,9L,8L,0L,9L,4L,7L,1L,4L,4L,0L,3L,5L,7L,3L,8L,0L,9L,3L,6L,0L,1L,6L,9L,1L,7L,5L,1L,3L,4L,6L,6L,2L,7L,3L,8L,5L,4L,2L,3L,9L,6L,2L,0L,0L,0L,1L,7L,7L,4L,8L,9L,5L,9L,3L,2L,7L,8L,5L,4L,5L,3L,1L,8L,8L,7L,7L,2L,1L,5L,7L,8L,0L,4L,4L,5L,4L,5L,2L,9L,4L,0L,3L,7L,5L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199460Inst : IEnumerable<long>
{
public static readonly long[] Value=A199460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199460.Bytes);
public long this[int i]=>Value[i];

public static A199460Inst Instance=new A199460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199461
{
public static readonly long[] Value={ 1L,8L,1L,1L,1L,1L,0L,8L,1L,4L,2L,4L,8L,3L,1L,9L,7L,6L,2L,7L,9L,6L,5L,4L,9L,7L,0L,9L,7L,5L,6L,7L,2L,9L,6L,1L,7L,6L,9L,1L,0L,3L,1L,2L,5L,8L,1L,3L,5L,3L,4L,3L,1L,2L,9L,4L,9L,2L,7L,3L,5L,6L,4L,4L,6L,3L,4L,5L,4L,9L,8L,0L,6L,3L,7L,3L,5L,5L,8L,2L,7L,5L,1L,0L,0L,2L,7L,3L,9L,7L,7L,6L,1L,4L,2L,6L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199461Inst : IEnumerable<long>
{
public static readonly long[] Value=A199461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199461.Bytes);
public long this[int i]=>Value[i];

public static A199461Inst Instance=new A199461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199462
{
public static readonly long[] Value={ 1L,7L,5L,6L,0L,2L,6L,6L,9L,2L,4L,5L,9L,7L,0L,3L,4L,3L,2L,9L,4L,2L,5L,3L,3L,4L,8L,9L,2L,6L,4L,2L,3L,9L,2L,3L,5L,8L,1L,0L,8L,1L,2L,7L,8L,0L,7L,1L,8L,9L,9L,0L,8L,7L,2L,7L,0L,9L,2L,3L,9L,0L,3L,3L,7L,1L,8L,2L,4L,9L,9L,5L,0L,7L,4L,5L,3L,3L,0L,2L,3L,0L,8L,4L,1L,0L,3L,0L,8L,4L,9L,5L,1L,0L,5L,1L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199462Inst : IEnumerable<long>
{
public static readonly long[] Value=A199462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199462.Bytes);
public long this[int i]=>Value[i];

public static A199462Inst Instance=new A199462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199463
{
public static readonly long[] Value={ 1L,7L,1L,9L,4L,7L,9L,3L,6L,6L,6L,5L,1L,9L,3L,4L,7L,2L,7L,4L,8L,4L,2L,9L,8L,6L,8L,3L,7L,6L,4L,3L,2L,6L,5L,8L,7L,2L,0L,0L,7L,1L,1L,8L,4L,3L,8L,3L,2L,9L,8L,2L,1L,6L,7L,8L,0L,0L,7L,0L,5L,4L,3L,4L,0L,4L,3L,2L,7L,8L,6L,5L,9L,7L,4L,2L,4L,2L,8L,7L,1L,4L,9L,9L,3L,5L,7L,8L,6L,1L,4L,1L,7L,4L,0L,1L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199463Inst : IEnumerable<long>
{
public static readonly long[] Value=A199463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199463.Bytes);
public long this[int i]=>Value[i];

public static A199463Inst Instance=new A199463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199464
{
public static readonly long[] Value={ 1L,0L,2L,0L,6L,5L,1L,9L,4L,4L,5L,5L,0L,7L,1L,4L,2L,8L,1L,7L,9L,2L,0L,8L,0L,1L,0L,9L,8L,5L,8L,2L,5L,7L,4L,0L,9L,1L,6L,7L,9L,8L,4L,7L,5L,0L,6L,4L,8L,2L,8L,7L,3L,4L,9L,6L,3L,7L,4L,1L,3L,8L,6L,4L,8L,3L,0L,9L,7L,0L,7L,6L,4L,4L,0L,3L,8L,5L,2L,9L,0L,1L,1L,9L,7L,1L,9L,6L,8L,8L,0L,4L,5L,5L,8L,9L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199464Inst : IEnumerable<long>
{
public static readonly long[] Value=A199464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199464.Bytes);
public long this[int i]=>Value[i];

public static A199464Inst Instance=new A199464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199465
{
public static readonly long[] Value={ 2L,4L,7L,9L,8L,1L,6L,1L,6L,7L,5L,8L,0L,7L,5L,2L,6L,9L,9L,1L,5L,6L,8L,6L,7L,4L,4L,6L,0L,3L,4L,3L,4L,4L,2L,9L,3L,2L,3L,8L,5L,7L,1L,2L,5L,0L,4L,0L,5L,9L,8L,1L,6L,9L,3L,3L,8L,7L,5L,4L,6L,4L,0L,9L,5L,3L,5L,6L,6L,7L,0L,9L,3L,5L,5L,4L,0L,8L,7L,6L,2L,9L,5L,8L,9L,3L,1L,1L,9L,0L,5L,5L,3L,8L,6L,2L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199465Inst : IEnumerable<long>
{
public static readonly long[] Value=A199465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199465.Bytes);
public long this[int i]=>Value[i];

public static A199465Inst Instance=new A199465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199466
{
public static readonly long[] Value={ 2L,3L,7L,8L,1L,0L,9L,6L,9L,6L,1L,2L,0L,3L,2L,4L,8L,0L,6L,8L,2L,3L,0L,8L,7L,8L,4L,9L,8L,2L,6L,0L,8L,6L,3L,1L,8L,0L,9L,4L,7L,1L,5L,7L,4L,2L,2L,8L,8L,5L,5L,9L,6L,3L,5L,0L,6L,8L,0L,9L,8L,3L,4L,7L,7L,9L,1L,8L,0L,0L,4L,7L,7L,4L,9L,7L,1L,5L,9L,3L,6L,8L,2L,2L,3L,7L,3L,3L,3L,4L,2L,5L,1L,4L,1L,2L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199466Inst : IEnumerable<long>
{
public static readonly long[] Value=A199466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199466.Bytes);
public long this[int i]=>Value[i];

public static A199466Inst Instance=new A199466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199467
{
public static readonly long[] Value={ 2L,2L,7L,8L,8L,6L,2L,6L,6L,0L,0L,7L,5L,8L,2L,8L,3L,1L,2L,6L,9L,9L,9L,5L,1L,1L,0L,4L,5L,6L,1L,8L,8L,8L,6L,2L,8L,8L,1L,8L,2L,7L,4L,7L,4L,0L,7L,3L,9L,7L,7L,6L,5L,1L,6L,5L,2L,5L,5L,8L,5L,5L,2L,9L,2L,4L,8L,3L,4L,4L,4L,6L,4L,7L,0L,1L,8L,3L,9L,1L,8L,6L,2L,5L,6L,7L,8L,1L,3L,4L,0L,5L,8L,0L,1L,4L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199467Inst : IEnumerable<long>
{
public static readonly long[] Value=A199467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199467.Bytes);
public long this[int i]=>Value[i];

public static A199467Inst Instance=new A199467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199468
{
public static readonly long[] Value={ 2L,1L,8L,5L,9L,8L,5L,9L,9L,6L,7L,8L,6L,2L,2L,7L,3L,7L,3L,3L,4L,5L,4L,3L,3L,5L,9L,6L,3L,5L,7L,7L,0L,0L,1L,5L,7L,3L,3L,8L,5L,6L,4L,6L,1L,7L,1L,9L,8L,5L,6L,8L,9L,9L,3L,7L,5L,9L,8L,8L,2L,9L,6L,1L,5L,5L,6L,6L,1L,5L,2L,7L,3L,2L,9L,5L,3L,3L,0L,5L,1L,8L,9L,5L,6L,6L,8L,4L,6L,2L,2L,6L,4L,2L,4L,7L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199468Inst : IEnumerable<long>
{
public static readonly long[] Value=A199468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199468.Bytes);
public long this[int i]=>Value[i];

public static A199468Inst Instance=new A199468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199469
{
public static readonly long[] Value={ 2L,1L,0L,2L,8L,3L,6L,8L,6L,0L,9L,1L,4L,1L,0L,4L,7L,0L,1L,4L,7L,2L,7L,6L,8L,5L,1L,1L,8L,2L,4L,7L,0L,2L,2L,2L,9L,9L,9L,0L,3L,9L,3L,3L,8L,5L,4L,9L,9L,5L,6L,0L,5L,1L,0L,6L,5L,9L,1L,6L,7L,8L,9L,9L,6L,1L,1L,3L,4L,2L,1L,8L,0L,7L,9L,3L,0L,9L,6L,1L,6L,1L,0L,6L,8L,9L,3L,9L,1L,4L,1L,1L,3L,8L,0L,6L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199469Inst : IEnumerable<long>
{
public static readonly long[] Value=A199469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199469.Bytes);
public long this[int i]=>Value[i];

public static A199469Inst Instance=new A199469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199470
{
public static readonly long[] Value={ 2L,0L,3L,1L,2L,5L,7L,6L,4L,0L,3L,3L,3L,0L,7L,3L,1L,3L,5L,8L,3L,7L,7L,6L,4L,7L,6L,6L,2L,1L,1L,2L,0L,1L,5L,1L,8L,8L,0L,5L,1L,4L,2L,6L,5L,7L,7L,0L,3L,0L,6L,3L,6L,3L,9L,4L,9L,0L,3L,8L,0L,2L,4L,6L,0L,1L,8L,2L,5L,5L,9L,9L,7L,6L,6L,7L,8L,4L,7L,3L,5L,5L,5L,4L,6L,2L,7L,3L,0L,0L,1L,7L,3L,3L,8L,8L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199470Inst : IEnumerable<long>
{
public static readonly long[] Value=A199470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199470.Bytes);
public long this[int i]=>Value[i];

public static A199470Inst Instance=new A199470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199471
{
public static readonly long[] Value={ 7L,9L,6L,4L,3L,0L,4L,1L,6L,7L,9L,6L,3L,4L,3L,0L,7L,9L,6L,9L,6L,3L,5L,9L,0L,0L,2L,2L,9L,6L,5L,8L,8L,1L,1L,8L,0L,2L,1L,2L,7L,0L,7L,5L,2L,2L,7L,0L,7L,1L,0L,8L,5L,5L,1L,7L,3L,5L,2L,0L,8L,9L,5L,9L,9L,2L,9L,7L,7L,8L,0L,5L,4L,9L,8L,6L,0L,9L,3L,1L,0L,3L,9L,6L,6L,9L,6L,1L,4L,5L,4L,8L,1L,7L,2L,9L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199471Inst : IEnumerable<long>
{
public static readonly long[] Value=A199471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199471.Bytes);
public long this[int i]=>Value[i];

public static A199471Inst Instance=new A199471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199472
{
public static readonly long[] Value={ 9L,8L,1L,6L,9L,4L,7L,0L,9L,7L,8L,6L,9L,3L,6L,6L,7L,9L,9L,9L,4L,0L,7L,2L,2L,4L,2L,9L,8L,8L,2L,1L,1L,1L,6L,5L,4L,1L,3L,3L,7L,7L,7L,6L,7L,8L,4L,0L,4L,1L,5L,1L,8L,0L,5L,2L,1L,8L,3L,3L,9L,4L,1L,7L,9L,8L,6L,8L,2L,1L,4L,7L,8L,4L,8L,1L,7L,8L,9L,2L,1L,0L,5L,5L,4L,9L,0L,9L,7L,8L,5L,6L,7L,2L,2L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199472Inst : IEnumerable<long>
{
public static readonly long[] Value=A199472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199472.Bytes);
public long this[int i]=>Value[i];

public static A199472Inst Instance=new A199472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199473
{
public static readonly long[] Value={ 1L,0L,8L,6L,0L,2L,7L,2L,1L,1L,8L,4L,3L,7L,3L,0L,4L,0L,7L,8L,4L,5L,6L,6L,9L,7L,3L,4L,7L,7L,2L,0L,2L,7L,2L,0L,9L,3L,1L,6L,1L,2L,6L,5L,0L,0L,6L,0L,1L,5L,2L,1L,5L,7L,9L,1L,6L,7L,5L,1L,3L,1L,2L,6L,0L,7L,1L,8L,1L,6L,1L,2L,2L,6L,3L,1L,6L,6L,3L,3L,3L,8L,9L,6L,8L,8L,9L,7L,1L,1L,2L,8L,2L,2L,4L,2L,9L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199473Inst : IEnumerable<long>
{
public static readonly long[] Value=A199473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199473.Bytes);
public long this[int i]=>Value[i];

public static A199473Inst Instance=new A199473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199474
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,3L,5L,4L,3L,6L,5L,4L,7L,6L,5L,4L,8L,7L,6L,5L,9L,8L,7L,6L,5L,10L,9L,8L,7L,6L,11L,10L,9L,8L,7L,6L,12L,11L,10L,9L,8L,7L,13L,12L,11L,10L,9L,8L,7L,14L,13L,12L,11L,10L,9L,8L,15L,14L,13L,12L,11L,10L,9L,8L,16L,15L,14L,13L,12L,11L,10L,9L,17L,16L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199474Inst : IEnumerable<long>
{
public static readonly long[] Value=A199474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199474.Bytes);
public long this[int i]=>Value[i];

public static A199474Inst Instance=new A199474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199475
{
public static readonly long[] Value={ 1L,2L,7L,34L,195L,1225L,8146L,56336L,401005L,2918308L,21614216L,162385693L,1234515922L,9479336440L,73410868630L,572719097908L,4496923141241L,35509806367132L,281814387290431L,2246608404455588L,17982234787607464L,144458551104066553L,1164342291135424494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199475Inst : IEnumerable<long>
{
public static readonly long[] Value=A199475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199475.Bytes);
public long this[int i]=>Value[i];

public static A199475Inst Instance=new A199475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199476
{
public static readonly long[] Value={ 2L,2L,6L,1L,5L,16L,1L,2L,12L,34L,1L,1L,6L,28L,77L,1L,1L,2L,14L,61L,157L,1L,1L,1L,6L,34L,133L,328L,1L,1L,1L,2L,15L,74L,277L,655L,1L,1L,1L,1L,6L,36L,165L,572L,1309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199476Inst : IEnumerable<long>
{
public static readonly long[] Value=A199476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199476.Bytes);
public long this[int i]=>Value[i];

public static A199476Inst Instance=new A199476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199477
{
public static readonly long[] Value={ 2L,6L,16L,34L,77L,157L,328L,655L,1309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199477Inst : IEnumerable<long>
{
public static readonly long[] Value=A199477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199477.Bytes);
public long this[int i]=>Value[i];

public static A199477Inst Instance=new A199477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199478
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,5L,2L,1L,7L,8L,1L,9L,18L,4L,1L,11L,32L,20L,1L,13L,50L,56L,8L,1L,15L,72L,120L,48L,1L,17L,98L,220L,160L,16L,1L,19L,128L,364L,400L,112L,1L,21L,162L,560L,840L,432L,32L,1L,23L,200L,816L,1568L,1232L,256L,1L,25L,242L,1140L,2688L,2912L,1120L,64L,1L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199478Inst : IEnumerable<long>
{
public static readonly long[] Value=A199478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199478.Bytes);
public long this[int i]=>Value[i];

public static A199478Inst Instance=new A199478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199479
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,5L,9L,5L,1L,7L,20L,27L,13L,1L,9L,35L,73L,80L,34L,1L,11L,54L,151L,252L,234L,89L,1L,13L,77L,269L,597L,837L,677L,233L,1L,15L,104L,435L,1199L,2225L,2702L,1941L,610L,1L,17L,135L,657L,2158L,4956L,7943L,8533L,5523L,1597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199479Inst : IEnumerable<long>
{
public static readonly long[] Value=A199479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199479.Bytes);
public long this[int i]=>Value[i];

public static A199479Inst Instance=new A199479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199480
{
public static readonly BigInteger[] Value={ 1L,1L,5L,19L,113L,701L,5269L,42883L,393441L,3887065L,42013381L,484389731L,6008730001L,78857557013L,1101462510485L,16168488228691L,250664264773825L,4061840593263921L,69116855497839109L,1223722811124319219L,BigInteger.Parse("22651504652950552241") };
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
public class A199480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199480.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199480Inst Instance=new A199480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199481
{
public static readonly long[] Value={ 1L,1L,2L,6L,22L,88L,369L,1600L,7122L,32370L,149612L,701046L,3322671L,15901030L,76729203L,372918345L,1823872039L,8969769017L,44330916829L,220062127756L,1096744496191L,5485585559684L,27526824797373L,138542038343946L,699184051431377L,3537456038149028L,17938918589386868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199481Inst : IEnumerable<long>
{
public static readonly long[] Value=A199481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199481.Bytes);
public long this[int i]=>Value[i];

public static A199481Inst Instance=new A199481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199482
{
public static readonly BigInteger[] Value={ 1L,1L,2L,-6L,-168L,-2600L,-10800L,727440L,43263360L,1032103296L,-228614400L,-3068098387200L,-194799891686400L,-9157262446126080L,406734380101969920L,BigInteger.Parse("68528048007234816000"),BigInteger.Parse("9942165414475886592000"),BigInteger.Parse("179947145139068340633600"),BigInteger.Parse("-678953675518129505894400") };
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
public class A199482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199482Inst Instance=new A199482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199483
{
public static readonly long[] Value={ 7L,43L,295L,2059L,14407L,100843L,705895L,4941259L,34588807L,242121643L,1694851495L,11863960459L,83047723207L,581334062443L,4069338437095L,28485369059659L,199397583417607L,1395783083923243L,9770481587462695L,68393371112238859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199483Inst : IEnumerable<long>
{
public static readonly long[] Value=A199483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199483.Bytes);
public long this[int i]=>Value[i];

public static A199483Inst Instance=new A199483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199484
{
public static readonly long[] Value={ 3L,19L,131L,915L,6403L,44819L,313731L,2196115L,15372803L,107609619L,753267331L,5272871315L,36910099203L,258370694419L,1808594860931L,12660164026515L,88621148185603L,620348037299219L,4342436261094531L,30397053827661715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199484Inst : IEnumerable<long>
{
public static readonly long[] Value=A199484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199484.Bytes);
public long this[int i]=>Value[i];

public static A199484Inst Instance=new A199484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199485
{
public static readonly long[] Value={ 9L,57L,393L,2745L,19209L,134457L,941193L,6588345L,46118409L,322828857L,2259801993L,15818613945L,110730297609L,775112083257L,5425784582793L,37980492079545L,265863444556809L,1861044111897657L,13027308783283593L,91191161482985145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199485Inst : IEnumerable<long>
{
public static readonly long[] Value=A199485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199485.Bytes);
public long this[int i]=>Value[i];

public static A199485Inst Instance=new A199485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199486
{
public static readonly long[] Value={ 5L,32L,221L,1544L,10805L,75632L,529421L,3705944L,25941605L,181591232L,1271138621L,8897970344L,62285792405L,436000546832L,3052003827821L,21364026794744L,149548187563205L,1046837312942432L,7327861190597021L,51295028334179144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199486Inst : IEnumerable<long>
{
public static readonly long[] Value=A199486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199486.Bytes);
public long this[int i]=>Value[i];

public static A199486Inst Instance=new A199486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199487
{
public static readonly long[] Value={ 10L,64L,442L,3088L,21610L,151264L,1058842L,7411888L,51883210L,363182464L,2542277242L,17795940688L,124571584810L,872001093664L,6104007655642L,42728053589488L,299096375126410L,2093674625884864L,14655722381194042L,102590056668358288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199487Inst : IEnumerable<long>
{
public static readonly long[] Value=A199487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199487.Bytes);
public long this[int i]=>Value[i];

public static A199487Inst Instance=new A199487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199488
{
public static readonly long[] Value={ 11L,71L,491L,3431L,24011L,168071L,1176491L,8235431L,57648011L,403536071L,2824752491L,19773267431L,138412872011L,968890104071L,6782230728491L,47475615099431L,332329305696011L,2326305139872071L,16284135979104491L,113988951853731431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199488Inst : IEnumerable<long>
{
public static readonly long[] Value=A199488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199488.Bytes);
public long this[int i]=>Value[i];

public static A199488Inst Instance=new A199488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199489
{
public static readonly long[] Value={ 2L,13L,90L,629L,4402L,30813L,215690L,1509829L,10568802L,73981613L,517871290L,3625099029L,25375693202L,177629852413L,1243408966890L,8703862768229L,60927039377602L,426489275643213L,2985424929502490L,20897974506517429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199489Inst : IEnumerable<long>
{
public static readonly long[] Value=A199489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199489.Bytes);
public long this[int i]=>Value[i];

public static A199489Inst Instance=new A199489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199490
{
public static readonly long[] Value={ 4L,26L,180L,1258L,8804L,61626L,431380L,3019658L,21137604L,147963226L,1035742580L,7250198058L,50751386404L,355259704826L,2486817933780L,17407725536458L,121854078755204L,852978551286426L,5970849859004980L,41795949013034858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199490Inst : IEnumerable<long>
{
public static readonly long[] Value=A199490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199490.Bytes);
public long this[int i]=>Value[i];

public static A199490Inst Instance=new A199490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199491
{
public static readonly long[] Value={ 6L,39L,270L,1887L,13206L,92439L,647070L,4529487L,31706406L,221944839L,1553613870L,10875297087L,76127079606L,532889557239L,3730226900670L,26111588304687L,182781118132806L,1279467826929639L,8956274788507470L,62693923519552287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199491Inst : IEnumerable<long>
{
public static readonly long[] Value=A199491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199491.Bytes);
public long this[int i]=>Value[i];

public static A199491Inst Instance=new A199491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199492
{
public static readonly long[] Value={ 12L,78L,540L,3774L,26412L,184878L,1294140L,9058974L,63412812L,443889678L,3107227740L,21750594174L,152254159212L,1065779114478L,7460453801340L,52223176609374L,365562236265612L,2558935653859278L,17912549577014940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199492Inst : IEnumerable<long>
{
public static readonly long[] Value=A199492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199492.Bytes);
public long this[int i]=>Value[i];

public static A199492Inst Instance=new A199492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199493
{
public static readonly long[] Value={ 3L,17L,129L,1025L,8193L,65537L,524289L,4194305L,33554433L,268435457L,2147483649L,17179869185L,137438953473L,1099511627777L,8796093022209L,70368744177665L,562949953421313L,4503599627370497L,36028797018963969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199493Inst : IEnumerable<long>
{
public static readonly long[] Value=A199493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199493.Bytes);
public long this[int i]=>Value[i];

public static A199493Inst Instance=new A199493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199494
{
public static readonly long[] Value={ 4L,25L,193L,1537L,12289L,98305L,786433L,6291457L,50331649L,402653185L,3221225473L,25769803777L,206158430209L,1649267441665L,13194139533313L,105553116266497L,844424930131969L,6755399441055745L,54043195528445953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199494Inst : IEnumerable<long>
{
public static readonly long[] Value=A199494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199494.Bytes);
public long this[int i]=>Value[i];

public static A199494Inst Instance=new A199494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199495
{
public static readonly BigInteger[] Value={ 0L,1L,0L,2L,4L,36L,144L,1440L,8640L,100800L,806400L,10886400L,108864000L,1676505600L,20118067200L,348713164800L,4881984307200L,94152554496000L,1506440871936000L,32011868528640000L,576213633515520000L,13380961044971520000UL,BigInteger.Parse("267619220899430400000") };
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
public class A199495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199495Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199495.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199495.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199495Inst Instance=new A199495Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199496
{
public static readonly BigInteger[] Value={ 367806L,939787L,952764389446L,12438517260105L,35495694227489L,5853886516781223L,23415546067124892L,38115991067861271L,322001299796379844L,9870884617163518770UL,BigInteger.Parse("42532374580189966073"),BigInteger.Parse("51698891432429706382"),BigInteger.Parse("601724682280310364065") };
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
public class A199496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199496Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199496.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199496.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199496Inst Instance=new A199496Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199497
{
public static readonly long[] Value={ 207L,307L,852135L,2767769L,5190544L,1641843L,105077952L,30032270L,548147655L,1651035656L,1878790553L,4101044247L,13027681441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199497Inst : IEnumerable<long>
{
public static readonly long[] Value=A199497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199497.Bytes);
public long this[int i]=>Value[i];

public static A199497Inst Instance=new A199497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199498
{
public static readonly BigInteger[] Value={ 223063347L,911054064L,929989991784733049L,BigInteger.Parse("43868513629203032816"),BigInteger.Parse("211477180624706647625"),BigInteger.Parse("447884928428402042307918"),BigInteger.Parse("3583079427427216338463344"),BigInteger.Parse("7441505802879036345061579"),BigInteger.Parse("182720147509505842286585077"),BigInteger.Parse("31012309752051601656131750312"),BigInteger.Parse("277382747164996776244709473092") };
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
public class A199498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199498.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199498Inst Instance=new A199498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199499
{
public static readonly long[] Value={ 2L,2L,4L,9L,6L,1L,1L,3L,7L,5L,5L,5L,2L,3L,6L,7L,4L,2L,4L,2L,4L,3L,2L,7L,0L,7L,1L,1L,5L,9L,0L,0L,7L,8L,6L,9L,5L,0L,5L,9L,9L,9L,2L,7L,5L,2L,9L,0L,8L,8L,8L,9L,2L,8L,6L,1L,2L,5L,0L,2L,9L,4L,7L,7L,4L,6L,4L,4L,7L,0L,2L,9L,1L,5L,0L,7L,3L,3L,8L,6L,3L,9L,7L,6L,4L,0L,6L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199499Inst : IEnumerable<long>
{
public static readonly long[] Value=A199499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199499.Bytes);
public long this[int i]=>Value[i];

public static A199499Inst Instance=new A199499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199500
{
public static readonly long[] Value={ 4L,4L,4L,5L,2L,1L,2L,2L,3L,0L,2L,8L,7L,8L,2L,4L,5L,2L,2L,6L,4L,2L,8L,1L,8L,5L,3L,9L,0L,1L,6L,6L,4L,0L,9L,5L,7L,8L,7L,4L,0L,7L,7L,6L,8L,9L,6L,4L,8L,2L,1L,3L,6L,9L,3L,3L,7L,5L,2L,2L,6L,0L,9L,3L,8L,0L,0L,7L,7L,8L,0L,8L,1L,0L,0L,7L,5L,9L,7L,4L,4L,2L,0L,3L,2L,1L,3L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199500Inst : IEnumerable<long>
{
public static readonly long[] Value=A199500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199500.Bytes);
public long this[int i]=>Value[i];

public static A199500Inst Instance=new A199500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199501
{
public static readonly long[] Value={ 2L,6L,1L,7L,3L,5L,5L,3L,7L,8L,1L,9L,4L,7L,7L,7L,7L,7L,7L,7L,9L,3L,5L,3L,5L,7L,2L,2L,8L,3L,0L,1L,9L,0L,8L,0L,2L,9L,2L,2L,7L,4L,4L,3L,7L,8L,0L,4L,8L,3L,2L,4L,9L,1L,8L,1L,0L,2L,4L,0L,8L,9L,8L,3L,3L,9L,1L,6L,4L,6L,2L,9L,9L,7L,9L,6L,3L,7L,2L,8L,4L,8L,7L,4L,1L,6L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199501Inst : IEnumerable<long>
{
public static readonly long[] Value=A199501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199501.Bytes);
public long this[int i]=>Value[i];

public static A199501Inst Instance=new A199501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199502
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,10L,11L,12L,13L,18L,19L,20L,21L,30L,31L,36L,37L,38L,39L,48L,49L,54L,55L,56L,57L,70L,71L,80L,81L,86L,87L,88L,89L,102L,103L,112L,113L,118L,119L,120L,121L,138L,139L,152L,153L,162L,163L,168L,169L,170L,171L,188L,189L,202L,203L,212L,213L,218L,219L,220L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199502Inst : IEnumerable<long>
{
public static readonly long[] Value=A199502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199502.Bytes);
public long this[int i]=>Value[i];

public static A199502Inst Instance=new A199502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199503
{
public static readonly long[] Value={ 1L,0L,9L,7L,7L,0L,6L,0L,7L,3L,0L,6L,5L,1L,9L,0L,4L,2L,9L,4L,0L,1L,6L,2L,8L,9L,5L,8L,2L,9L,1L,9L,3L,9L,0L,1L,3L,0L,0L,5L,9L,7L,8L,9L,1L,0L,4L,8L,2L,8L,7L,5L,8L,9L,8L,9L,3L,4L,7L,3L,6L,4L,0L,5L,3L,3L,8L,2L,8L,7L,7L,4L,1L,6L,6L,9L,5L,4L,6L,7L,6L,5L,2L,6L,0L,1L,1L,2L,4L,7L,4L,7L,6L,1L,7L,3L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199503Inst : IEnumerable<long>
{
public static readonly long[] Value=A199503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199503.Bytes);
public long this[int i]=>Value[i];

public static A199503Inst Instance=new A199503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199504
{
public static readonly long[] Value={ 1L,2L,8L,6L,6L,8L,5L,6L,4L,4L,8L,1L,2L,6L,8L,3L,7L,2L,1L,5L,4L,6L,8L,2L,1L,3L,9L,6L,1L,2L,0L,2L,6L,7L,9L,7L,6L,9L,1L,0L,3L,8L,6L,3L,7L,2L,6L,3L,9L,1L,3L,7L,9L,5L,6L,4L,1L,3L,3L,7L,1L,6L,3L,5L,8L,7L,8L,7L,3L,9L,4L,9L,5L,6L,3L,4L,5L,3L,7L,4L,1L,9L,7L,8L,0L,9L,8L,2L,9L,3L,0L,6L,0L,3L,8L,6L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199504Inst : IEnumerable<long>
{
public static readonly long[] Value=A199504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199504.Bytes);
public long this[int i]=>Value[i];

public static A199504Inst Instance=new A199504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199505
{
public static readonly long[] Value={ 6L,2L,6L,4L,7L,0L,1L,4L,9L,1L,6L,1L,3L,5L,9L,1L,8L,6L,5L,7L,0L,2L,4L,4L,2L,7L,0L,7L,0L,8L,7L,0L,4L,2L,8L,7L,0L,5L,8L,4L,7L,2L,3L,7L,1L,4L,2L,7L,3L,9L,7L,8L,8L,7L,7L,5L,3L,7L,3L,8L,4L,2L,5L,2L,9L,4L,9L,7L,3L,2L,1L,3L,7L,6L,9L,5L,0L,4L,7L,7L,4L,7L,6L,3L,0L,2L,5L,0L,0L,1L,9L,0L,7L,5L,9L,5L,3L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199505Inst : IEnumerable<long>
{
public static readonly long[] Value=A199505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199505.Bytes);
public long this[int i]=>Value[i];

public static A199505Inst Instance=new A199505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199506
{
public static readonly long[] Value={ 8L,0L,9L,4L,7L,6L,4L,1L,5L,8L,7L,5L,0L,6L,2L,2L,6L,6L,8L,3L,5L,3L,1L,7L,9L,1L,3L,8L,4L,5L,9L,8L,9L,1L,9L,4L,0L,0L,4L,1L,4L,8L,2L,5L,5L,6L,7L,1L,8L,2L,7L,6L,1L,6L,4L,1L,5L,5L,5L,8L,3L,5L,5L,2L,3L,5L,4L,4L,5L,5L,0L,7L,3L,5L,0L,8L,6L,3L,9L,7L,5L,5L,3L,1L,2L,9L,5L,5L,5L,5L,7L,0L,3L,8L,0L,3L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199506Inst : IEnumerable<long>
{
public static readonly long[] Value=A199506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199506.Bytes);
public long this[int i]=>Value[i];

public static A199506Inst Instance=new A199506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199507
{
public static readonly long[] Value={ 9L,2L,1L,5L,5L,7L,1L,1L,0L,1L,7L,0L,3L,2L,1L,7L,2L,5L,9L,9L,3L,7L,4L,8L,1L,2L,3L,1L,8L,8L,3L,0L,5L,6L,5L,5L,9L,3L,4L,3L,0L,5L,1L,9L,6L,4L,9L,7L,8L,9L,7L,8L,8L,4L,1L,8L,9L,1L,4L,0L,2L,5L,4L,4L,1L,6L,0L,0L,8L,7L,3L,9L,9L,6L,2L,9L,8L,5L,5L,5L,4L,1L,2L,5L,5L,5L,1L,4L,3L,3L,9L,8L,3L,5L,5L,5L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199507Inst : IEnumerable<long>
{
public static readonly long[] Value=A199507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199507.Bytes);
public long this[int i]=>Value[i];

public static A199507Inst Instance=new A199507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199508
{
public static readonly long[] Value={ 7L,7L,3L,9L,8L,1L,1L,1L,7L,4L,2L,7L,4L,6L,7L,1L,7L,7L,5L,2L,1L,6L,5L,7L,3L,0L,3L,9L,8L,6L,7L,2L,5L,3L,0L,3L,0L,1L,6L,7L,5L,0L,3L,8L,2L,4L,5L,6L,8L,1L,7L,2L,2L,8L,9L,4L,8L,8L,0L,9L,5L,8L,6L,5L,4L,7L,3L,7L,5L,2L,0L,7L,1L,3L,0L,3L,6L,9L,4L,8L,6L,9L,5L,3L,6L,3L,5L,9L,1L,3L,0L,4L,2L,1L,2L,0L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199508Inst : IEnumerable<long>
{
public static readonly long[] Value=A199508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199508.Bytes);
public long this[int i]=>Value[i];

public static A199508Inst Instance=new A199508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199509
{
public static readonly long[] Value={ 9L,5L,0L,2L,9L,4L,9L,7L,6L,8L,6L,9L,9L,4L,6L,6L,5L,8L,5L,6L,2L,0L,9L,2L,4L,9L,4L,1L,9L,4L,4L,0L,1L,7L,8L,3L,6L,7L,4L,8L,7L,2L,9L,6L,6L,6L,1L,7L,0L,5L,0L,8L,5L,3L,1L,1L,8L,6L,9L,8L,2L,8L,4L,9L,6L,1L,3L,2L,9L,0L,3L,4L,0L,5L,3L,6L,3L,4L,4L,0L,8L,9L,1L,0L,6L,7L,3L,2L,3L,4L,4L,8L,5L,2L,4L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199509Inst : IEnumerable<long>
{
public static readonly long[] Value=A199509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199509.Bytes);
public long this[int i]=>Value[i];

public static A199509Inst Instance=new A199509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199510
{
public static readonly long[] Value={ 1L,0L,5L,1L,1L,1L,0L,2L,2L,8L,8L,4L,3L,7L,2L,8L,0L,1L,1L,4L,2L,5L,7L,1L,1L,4L,5L,8L,1L,1L,9L,4L,1L,9L,6L,8L,5L,1L,2L,4L,5L,1L,6L,6L,6L,3L,2L,2L,4L,9L,7L,1L,6L,7L,3L,6L,5L,4L,6L,3L,1L,8L,0L,3L,4L,1L,2L,6L,0L,5L,5L,7L,2L,6L,6L,1L,2L,0L,3L,1L,6L,1L,5L,6L,7L,4L,6L,9L,3L,5L,3L,2L,0L,3L,9L,3L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199510Inst : IEnumerable<long>
{
public static readonly long[] Value=A199510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199510.Bytes);
public long this[int i]=>Value[i];

public static A199510Inst Instance=new A199510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199511
{
public static readonly long[] Value={ 1L,0L,2L,3L,4L,0L,4L,6L,7L,4L,6L,7L,4L,9L,5L,2L,1L,1L,5L,8L,9L,1L,5L,0L,3L,3L,9L,8L,3L,4L,0L,4L,5L,2L,4L,6L,0L,8L,8L,2L,7L,7L,3L,1L,5L,4L,4L,1L,5L,9L,5L,1L,3L,7L,7L,4L,8L,6L,0L,7L,7L,7L,8L,3L,3L,0L,7L,7L,9L,5L,1L,1L,5L,8L,3L,2L,4L,1L,0L,2L,9L,4L,8L,1L,4L,0L,3L,8L,9L,3L,2L,6L,5L,2L,0L,5L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199511Inst : IEnumerable<long>
{
public static readonly long[] Value=A199511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199511.Bytes);
public long this[int i]=>Value[i];

public static A199511Inst Instance=new A199511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199512
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,5L,3L,5L,8L,13L,5L,8L,13L,21L,34L,8L,13L,21L,34L,55L,89L,13L,21L,34L,55L,89L,144L,233L,21L,34L,55L,89L,144L,233L,377L,610L,34L,55L,89L,144L,233L,377L,610L,987L,1597L,55L,89L,144L,233L,377L,610L,987L,1597L,2584L,4181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199512Inst : IEnumerable<long>
{
public static readonly long[] Value=A199512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199512.Bytes);
public long this[int i]=>Value[i];

public static A199512Inst Instance=new A199512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199513
{
public static readonly long[] Value={ 1L,1L,4L,9L,6L,7L,4L,5L,4L,4L,0L,9L,4L,0L,7L,8L,3L,7L,0L,6L,0L,2L,8L,6L,5L,5L,8L,7L,5L,7L,5L,1L,5L,9L,4L,3L,0L,3L,4L,7L,1L,0L,5L,2L,0L,7L,6L,5L,5L,6L,5L,5L,7L,9L,0L,1L,0L,3L,2L,3L,8L,2L,5L,8L,5L,2L,1L,3L,6L,7L,5L,2L,8L,0L,0L,9L,3L,6L,0L,2L,7L,7L,5L,7L,1L,0L,3L,5L,0L,5L,8L,3L,4L,8L,0L,4L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199513Inst : IEnumerable<long>
{
public static readonly long[] Value=A199513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199513.Bytes);
public long this[int i]=>Value[i];

public static A199513Inst Instance=new A199513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199514
{
public static readonly long[] Value={ 2L,3L,0L,5L,3L,7L,0L,0L,5L,11L,0L,13L,7L,15L,0L,17L,0L,19L,0L,7L,11L,23L,0L,0L,13L,0L,0L,29L,15L,31L,0L,33L,17L,35L,0L,37L,19L,13L,0L,41L,7L,43L,0L,0L,23L,47L,0L,0L,0L,51L,0L,53L,0L,11L,0L,19L,29L,59L,0L,61L,31L,0L,0L,65L,33L,67L,0L,69L,35L,71L,0L,73L,37L,0L,0L,77L,13L,79L,0L,0L,41L,83L,0L,85L,43L,87L,0L,89L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199514Inst : IEnumerable<long>
{
public static readonly long[] Value=A199514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199514.Bytes);
public long this[int i]=>Value[i];

public static A199514Inst Instance=new A199514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199515
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,4L,7L,1L,1L,1L,1L,1L,3L,6L,1L,1L,1L,7L,1L,1L,1L,11L,1L,1L,13L,9L,11L,1L,1L,10L,5L,1L,1L,5L,1L,1L,1L,12L,1L,1L,1L,1L,19L,1L,1L,1L,3L,1L,7L,15L,1L,1L,1L,16L,1L,1L,17L,23L,1L,1L,25L,23L,1L,1L,1L,19L,1L,1L,17L,9L,1L,1L,1L,21L,1L,1L,21L,22L,31L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199515Inst : IEnumerable<long>
{
public static readonly long[] Value=A199515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199515.Bytes);
public long this[int i]=>Value[i];

public static A199515Inst Instance=new A199515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199516
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,45L,105L,105L,1260L,6300L,15400L,15400L,200200L,1051050L,2627625L,2627625L,35735700L,192972780L,488864376L,488864376L,6844101264L,37642556952L,96197645544L,96197645544L,1374252079200L,7656547298400L,19688264481600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199516Inst : IEnumerable<long>
{
public static readonly long[] Value=A199516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199516.Bytes);
public long this[int i]=>Value[i];

public static A199516Inst Instance=new A199516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199517
{
public static readonly long[] Value={ 1L,1L,45L,105L,6300L,15400L,1030230L,2559433L,182663916L,457744440L,34150210658L,86068056429L,6629396556290L,16775738245132L,1323517639910370L,3359302469625303L,270024529787133744L,686970966254338640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199517Inst : IEnumerable<long>
{
public static readonly long[] Value=A199517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199517.Bytes);
public long this[int i]=>Value[i];

public static A199517Inst Instance=new A199517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199518
{
public static readonly BigInteger[] Value={ 1L,45L,1260L,15400L,2513869L,174524175L,5866391058L,78538951349L,14918883751196L,1134907763429651L,40321453946092356L,558398606969183196L,BigInteger.Parse("113331120839472129952"),BigInteger.Parse("8998123036816556850222"),BigInteger.Parse("328615244611727182223731") };
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
public class A199518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199518Inst Instance=new A199518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199519
{
public static readonly BigInteger[] Value={ 1L,105L,15400L,2491383L,425836476L,76066541392L,14045226977086L,2659503142845964L,513629992322483274L,BigInteger.Parse("100788315834577397826"),BigInteger.Parse("20037985877897676968942") };
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
public class A199519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199519Inst Instance=new A199519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199520
{
public static readonly long[] Value={ 10L,6300L,2513869L,425836476L,1036302685728L,1049206835165446L,506637005741617919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199520Inst : IEnumerable<long>
{
public static readonly long[] Value=A199520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199520.Bytes);
public long this[int i]=>Value[i];

public static A199520Inst Instance=new A199520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199521
{
public static readonly long[] Value={ 45L,15400L,174524175L,76066541392L,1049206835165446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199521Inst : IEnumerable<long>
{
public static readonly long[] Value=A199521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199521.Bytes);
public long this[int i]=>Value[i];

public static A199521Inst Instance=new A199521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199522
{
public static readonly long[] Value={ 105L,1030230L,5866391058L,14045226977086L,506637005741617919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199522Inst : IEnumerable<long>
{
public static readonly long[] Value=A199522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199522.Bytes);
public long this[int i]=>Value[i];

public static A199522Inst Instance=new A199522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199523
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,45L,45L,1L,10L,105L,1260L,105L,10L,45L,6300L,15400L,15400L,6300L,45L,105L,15400L,2513869L,2491383L,2513869L,15400L,105L,105L,1030230L,174524175L,425836476L,425836476L,174524175L,1030230L,105L,1260L,2559433L,5866391058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199523Inst : IEnumerable<long>
{
public static readonly long[] Value=A199523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199523.Bytes);
public long this[int i]=>Value[i];

public static A199523Inst Instance=new A199523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199524
{
public static readonly long[] Value={ 1L,4L,18L,72L,320L,1414L,6346L,28766L,131246L,602390L,2777638L,12857572L,59712940L,278096674L,1298309782L,6074112952L,28470828008L,133671581490L,628526085270L,2959291856816L,13950087683416L,65832860408434L,310987879638926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199524Inst : IEnumerable<long>
{
public static readonly long[] Value=A199524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199524.Bytes);
public long this[int i]=>Value[i];

public static A199524Inst Instance=new A199524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199525
{
public static readonly long[] Value={ 1L,6L,36L,212L,1324L,8342L,53302L,343710L,2232322L,14582218L,95702528L,630544704L,4168091856L,27630031358L,183604587444L,1222672695812L,8157398577024L,54515075729370L,364861668341252L,2445239266293460L,16407415704050100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199525Inst : IEnumerable<long>
{
public static readonly long[] Value=A199525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199525.Bytes);
public long this[int i]=>Value[i];

public static A199525Inst Instance=new A199525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199526
{
public static readonly long[] Value={ 1L,8L,60L,464L,3734L,30484L,252154L,2105064L,17701326L,149708146L,1272108368L,10851700690L,92875809416L,797134845184L,6858361265978L,59133629878796L,510815878314050L,4419961056157870L,38301854208088068L,332355738077962284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199526Inst : IEnumerable<long>
{
public static readonly long[] Value=A199526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199526.Bytes);
public long this[int i]=>Value[i];

public static A199526Inst Instance=new A199526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199527
{
public static readonly long[] Value={ 1L,10L,90L,860L,8470L,84852L,860854L,8815392L,90927530L,943302430L,9832131238L,102882332054L,1080105471952L,11371474312404L,120012768975248L,1269300095287288L,13449845528174042L,142756162602411602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199527Inst : IEnumerable<long>
{
public static readonly long[] Value=A199527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199527.Bytes);
public long this[int i]=>Value[i];

public static A199527Inst Instance=new A199527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199528
{
public static readonly long[] Value={ 1L,12L,126L,1432L,16682L,197962L,2378412L,28844590L,352355640L,4329146404L,53439881140L,662256127274L,8234161234932L,102668802658902L,1283270183281782L,16074009129375488L,201718956009659774L,2535677513896048744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199528Inst : IEnumerable<long>
{
public static readonly long[] Value=A199528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199528.Bytes);
public long this[int i]=>Value[i];

public static A199528Inst Instance=new A199528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199529
{
public static readonly long[] Value={ 1L,14L,168L,2212L,29750L,407946L,5662636L,79345982L,1119873360L,15897133212L,226731289148L,3246399497138L,46636478912912L,671855095655758L,9702557118121642L,140418234266554336L,2035998107250999870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199529Inst : IEnumerable<long>
{
public static readonly long[] Value=A199529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199529.Bytes);
public long this[int i]=>Value[i];

public static A199529Inst Instance=new A199529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199530
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,6L,1L,6L,18L,12L,1L,8L,36L,72L,32L,1L,10L,60L,212L,320L,80L,1L,12L,90L,464L,1324L,1414L,200L,1L,14L,126L,860L,3734L,8342L,6346L,520L,1L,16L,168L,1432L,8470L,30484L,53302L,28766L,1336L,1L,18L,216L,2212L,16682L,84852L,252154L,343710L,131246L,3472L,1L,20L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199530Inst : IEnumerable<long>
{
public static readonly long[] Value=A199530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199530.Bytes);
public long this[int i]=>Value[i];

public static A199530Inst Instance=new A199530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199531
{
public static readonly long[] Value={ 12L,72L,212L,464L,860L,1432L,2212L,3232L,4524L,6120L,8052L,10352L,13052L,16184L,19780L,23872L,28492L,33672L,39444L,45840L,52892L,60632L,69092L,78304L,88300L,99112L,110772L,123312L,136764L,151160L,166532L,182912L,200332L,218824L,238420L,259152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199531Inst : IEnumerable<long>
{
public static readonly long[] Value=A199531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199531.Bytes);
public long this[int i]=>Value[i];

public static A199531Inst Instance=new A199531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199532
{
public static readonly long[] Value={ 32L,320L,1324L,3734L,8470L,16682L,29750L,49284L,77124L,115340L,166232L,232330L,316394L,421414L,550610L,707432L,895560L,1118904L,1381604L,1688030L,2042782L,2450690L,2916814L,3446444L,4045100L,4718532L,5472720L,6313874L,7248434L,8283070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199532Inst : IEnumerable<long>
{
public static readonly long[] Value=A199532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199532.Bytes);
public long this[int i]=>Value[i];

public static A199532Inst Instance=new A199532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199533
{
public static readonly long[] Value={ 80L,1414L,8342L,30484L,84852L,197962L,407946L,766664L,1341816L,2219054L,3504094L,5324828L,7833436L,11208498L,15657106L,21416976L,28758560L,37987158L,49445030L,63513508L,80615108L,101215642L,125826330L,155005912L,189362760L,229556990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199533Inst : IEnumerable<long>
{
public static readonly long[] Value=A199533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199533.Bytes);
public long this[int i]=>Value[i];

public static A199533Inst Instance=new A199533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199534
{
public static readonly long[] Value={ 200L,6346L,53302L,252154L,860854L,2378412L,5662636L,12071420L,23627580L,43207238L,74751754L,123503206L,196263418L,301676536L,450535152L,656109976L,934503056L,1305024546L,1790593022L,2418159346L,3219154078L,4229958436L,5492398804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199534Inst : IEnumerable<long>
{
public static readonly long[] Value=A199534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199534.Bytes);
public long this[int i]=>Value[i];

public static A199534Inst Instance=new A199534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199535
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,6L,5L,11L,9L,10L,8L,18L,15L,17L,12L,13L,29L,24L,27L,19L,14L,21L,47L,39L,44L,31L,23L,16L,34L,76L,63L,71L,50L,37L,25L,20L,55L,123L,102L,115L,81L,60L,41L,33L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199535Inst : IEnumerable<long>
{
public static readonly long[] Value=A199535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199535.Bytes);
public long this[int i]=>Value[i];

public static A199535Inst Instance=new A199535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199536
{
public static readonly long[] Value={ 1L,4L,6L,10L,12L,14L,16L,20L,22L,26L,28L,30L,32L,36L,38L,40L,42L,46L,48L,52L,54L,56L,58L,62L,64L,68L,70L,72L,74L,78L,80L,82L,84L,88L,90L,94L,96L,98L,100L,104L,106L,108L,110L,114L,116L,120L,122L,124L,126L,130L,132L,136L,138L,140L,142L,146L,148L,150L,152L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199536Inst : IEnumerable<long>
{
public static readonly long[] Value=A199536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199536.Bytes);
public long this[int i]=>Value[i];

public static A199536Inst Instance=new A199536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199537
{
public static readonly long[] Value={ 2L,7L,9L,17L,19L,23L,25L,33L,35L,43L,45L,49L,51L,59L,61L,65L,67L,75L,77L,85L,87L,91L,93L,101L,103L,111L,113L,117L,119L,127L,129L,133L,135L,143L,145L,153L,155L,159L,161L,169L,171L,175L,177L,185L,187L,195L,197L,201L,203L,211L,213L,221L,223L,227L,229L,237L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199537Inst : IEnumerable<long>
{
public static readonly long[] Value=A199537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199537.Bytes);
public long this[int i]=>Value[i];

public static A199537Inst Instance=new A199537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199538
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,1L,3L,4L,2L,5L,1L,6L,3L,7L,4L,2L,5L,8L,1L,9L,6L,3L,7L,10L,4L,11L,2L,12L,5L,13L,8L,1L,9L,14L,6L,15L,3L,16L,7L,17L,10L,4L,11L,18L,2L,19L,12L,5L,13L,20L,8L,21L,1L,22L,9L,23L,14L,6L,15L,24L,3L,25L,16L,7L,17L,26L,10L,27L,4L,28L,11L,29L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199538Inst : IEnumerable<long>
{
public static readonly long[] Value=A199538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199538.Bytes);
public long this[int i]=>Value[i];

public static A199538Inst Instance=new A199538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199539
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,2L,5L,2L,1L,3L,1L,6L,1L,3L,1L,2L,4L,2L,1L,7L,1L,2L,4L,2L,1L,3L,1L,5L,1L,3L,1L,2L,8L,2L,1L,3L,1L,5L,1L,3L,1L,2L,4L,2L,1L,6L,1L,2L,4L,2L,1L,3L,1L,9L,1L,3L,1L,2L,4L,2L,1L,6L,1L,2L,4L,2L,1L,3L,1L,5L,1L,3L,1L,2L,7L,2L,1L,3L,1L,5L,1L,3L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199539Inst : IEnumerable<long>
{
public static readonly long[] Value=A199539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199539.Bytes);
public long this[int i]=>Value[i];

public static A199539Inst Instance=new A199539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199540
{
public static readonly BigInteger[] Value={ 1L,1L,4L,24L,192L,-320L,-138240L,-10214400L,-669204480L,-43782488064L,-2628064051200L,-91419903590400L,14288196206592000L,5367226212019077120L,BigInteger.Parse("1259862249808204922880"),BigInteger.Parse("257126813359346810880000"),BigInteger.Parse("46529454048255997378560000") };
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
public class A199540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199540Inst Instance=new A199540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199541
{
public static readonly BigInteger[] Value={ 1L,-2L,3L,96L,-820L,5760L,189000L,1720320L,1632960L,1393459200L,430921814400L,2452488192000L,204726089018880L,8224795200061440L,10001273371689600000UL,BigInteger.Parse("47991858533498880000"),BigInteger.Parse("-33369402947130515865600") };
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
public class A199541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199541Inst Instance=new A199541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199542
{
public static readonly long[] Value={ 1L,0L,1L,-12L,0L,1L,0L,-96L,0L,1L,-320L,0L,-400L,0L,1L,0L,8640L,0L,-1200L,0L,1L,-53760L,0L,188160L,0L,-2940L,0L,1L,0L,4300800L,0L,1630720L,0L,-6272L,0L,1L,-27869184L,0L,3870720L,0L,9144576L,0L,-12096L,0L,1L,0L,4877107200L,0L,-1548288000L,0L,38949120L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199542Inst : IEnumerable<long>
{
public static readonly long[] Value=A199542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199542.Bytes);
public long this[int i]=>Value[i];

public static A199542Inst Instance=new A199542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199543
{
public static readonly BigInteger[] Value={ 1L,2L,9L,59L,462L,4011L,37253L,362877L,3662590L,38001809L,403118473L,4354812135L,47769686769L,530912871966L,5968147436150L,67766781921248L,776407323511627L,8967754230210974L,104351087348892229L,1222602680134075216L,14416253295843685409UL,BigInteger.Parse("171018068867340738997") };
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
public class A199543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199543Inst Instance=new A199543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199544
{
public static readonly BigInteger[] Value={ 1L,3L,23L,271L,3876L,61809L,1057324L,18999550L,354126904L,6790260312L,133193201306L,2661966127599L,54046089492190L,1112240570177203L,23161201079072759L,487383250552812705L,10353102122586909350UL,BigInteger.Parse("221819714961583800336"),BigInteger.Parse("4790442570608936302923") };
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
public class A199544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199544Inst Instance=new A199544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199545
{
public static readonly long[] Value={ 24L,48L,48L,72L,96L,96L,120L,240L,240L,288L,480L,576L,576L,1152L,1440L,1440L,2880L,2880L,5760L,5760L,6912L,17280L,34560L,34560L,69120L,414720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199545Inst : IEnumerable<long>
{
public static readonly long[] Value=A199545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199545.Bytes);
public long this[int i]=>Value[i];

public static A199545Inst Instance=new A199545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199546
{
public static readonly long[] Value={ 144L,144L,288L,360L,360L,360L,720L,720L,720L,720L,1800L,3456L,8640L,8640L,8640L,8640L,17280L,17280L,21600L,43200L,43200L,207360L,207360L,518400L,518400L,1036800L,12441600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199546Inst : IEnumerable<long>
{
public static readonly long[] Value=A199546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199546.Bytes);
public long this[int i]=>Value[i];

public static A199546Inst Instance=new A199546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199547
{
public static readonly long[] Value={ 26861L,616841L,616849L,616877L,616897L,616909L,616933L,616943L,616951L,616961L,616991L,616997L,616999L,617011L,617269L,617273L,617293L,617311L,617327L,617333L,617339L,617341L,617359L,617369L,617401L,617429L,617453L,617521L,617537L,617689L,617693L,617699L,617717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199547Inst : IEnumerable<long>
{
public static readonly long[] Value=A199547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199547.Bytes);
public long this[int i]=>Value[i];

public static A199547Inst Instance=new A199547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199548
{
public static readonly BigInteger[] Value={ 1L,3L,14L,88L,650L,5257L,45017L,401010L,3677344L,34481492L,329082191L,3186043296L,31214870385L,308901931412L,3083146893716L,31001118379636L,313734072027372L,3193097704841990L,32662597147529218L,335616736745247652L,3462524444288857191L,BigInteger.Parse("35853293611333010079") };
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
public class A199548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199548.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199548Inst Instance=new A199548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199549
{
public static readonly long[] Value={ 576L,576L,1152L,1440L,1440L,2880L,2880L,2880L,2880L,7200L,13824L,34560L,34560L,34560L,34560L,69120L,69120L,172800L,172800L,86400L,829440L,829440L,2073600L,2073600L,4147200L,49766400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199549Inst : IEnumerable<long>
{
public static readonly long[] Value=A199549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199549.Bytes);
public long this[int i]=>Value[i];

public static A199549Inst Instance=new A199549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199550
{
public static readonly long[] Value={ 1L,4L,7L,6L,6L,8L,4L,3L,3L,7L,3L,5L,7L,8L,6L,9L,9L,4L,7L,0L,8L,9L,2L,3L,5L,5L,8L,5L,3L,7L,3L,8L,8L,9L,8L,3L,8L,6L,5L,5L,1L,6L,8L,9L,3L,0L,9L,8L,5L,5L,2L,6L,9L,8L,4L,4L,6L,4L,4L,0L,3L,1L,4L,7L,6L,2L,1L,6L,9L,8L,0L,0L,2L,9L,1L,8L,8L,2L,1L,5L,2L,8L,5L,9L,7L,1L,4L,7L,2L,4L,0L,8L,4L,4L,0L,2L,6L,9L,5L,7L,9L,8L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199550Inst : IEnumerable<long>
{
public static readonly long[] Value=A199550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199550.Bytes);
public long this[int i]=>Value[i];

public static A199550Inst Instance=new A199550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199551
{
public static readonly long[] Value={ 1L,2L,33L,51L,69L,105L,195L,250L,294L,1250L,4913L,9583L,13778L,48778L,65603L,83521L,111265L,228939L,651695L,984150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199551Inst : IEnumerable<long>
{
public static readonly long[] Value=A199551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199551.Bytes);
public long this[int i]=>Value[i];

public static A199551Inst Instance=new A199551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199552
{
public static readonly long[] Value={ 5L,33L,257L,2049L,16385L,131073L,1048577L,8388609L,67108865L,536870913L,4294967297L,34359738369L,274877906945L,2199023255553L,17592186044417L,140737488355329L,1125899906842625L,9007199254740993L,72057594037927937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199552Inst : IEnumerable<long>
{
public static readonly long[] Value=A199552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199552.Bytes);
public long this[int i]=>Value[i];

public static A199552Inst Instance=new A199552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199553
{
public static readonly long[] Value={ 6L,41L,321L,2561L,20481L,163841L,1310721L,10485761L,83886081L,671088641L,5368709121L,42949672961L,343597383681L,2748779069441L,21990232555521L,175921860444161L,1407374883553281L,11258999068426241L,90071992547409921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199553Inst : IEnumerable<long>
{
public static readonly long[] Value=A199553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199553.Bytes);
public long this[int i]=>Value[i];

public static A199553Inst Instance=new A199553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199554
{
public static readonly long[] Value={ 7L,49L,385L,3073L,24577L,196609L,1572865L,12582913L,100663297L,805306369L,6442450945L,51539607553L,412316860417L,3298534883329L,26388279066625L,211106232532993L,1688849860263937L,13510798882111489L,108086391056891905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199554Inst : IEnumerable<long>
{
public static readonly long[] Value=A199554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199554.Bytes);
public long this[int i]=>Value[i];

public static A199554Inst Instance=new A199554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199555
{
public static readonly long[] Value={ 8L,57L,449L,3585L,28673L,229377L,1835009L,14680065L,117440513L,939524097L,7516192769L,60129542145L,481036337153L,3848290697217L,30786325577729L,246290604621825L,1970324836974593L,15762598695796737L,126100789566373889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199555Inst : IEnumerable<long>
{
public static readonly long[] Value=A199555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199555.Bytes);
public long this[int i]=>Value[i];

public static A199555Inst Instance=new A199555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199556
{
public static readonly long[] Value={ 10L,73L,577L,4609L,36865L,294913L,2359297L,18874369L,150994945L,1207959553L,9663676417L,77309411329L,618475290625L,4947802324993L,39582418599937L,316659348799489L,2533274790395905L,20266198323167233L,162129586585337857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199556Inst : IEnumerable<long>
{
public static readonly long[] Value=A199556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199556.Bytes);
public long this[int i]=>Value[i];

public static A199556Inst Instance=new A199556Inst();

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