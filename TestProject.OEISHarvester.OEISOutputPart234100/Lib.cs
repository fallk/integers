using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011341
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,7L,8L,8L,4L,7L,7L,9L,6L,1L,4L,4L,8L,3L,4L,5L,2L,2L,8L,9L,1L,2L,2L,6L,2L,3L,4L,9L,2L,7L,9L,8L,1L,2L,3L,0L,6L,9L,8L,3L,0L,4L,2L,1L,9L,4L,3L,9L,2L,9L,3L,0L,2L,2L,9L,3L,1L,6L,8L,4L,8L,0L,5L,2L,8L,7L,7L,4L,0L,1L,9L,5L,8L,6L,5L,9L,8L,7L,9L,4L,0L,0L,4L,1L,4L,0L,0L,9L,6L,4L,9L,2L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011341Inst : IEnumerable<long>
{
public static readonly long[] Value=A011341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011341.Bytes);
public long this[int i]=>Value[i];

public static A011341Inst Instance=new A011341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011342
{
public static readonly long[] Value={ 1L,2L,2L,5L,0L,7L,7L,8L,7L,0L,7L,9L,2L,7L,4L,0L,0L,5L,8L,3L,7L,8L,9L,8L,7L,9L,2L,3L,6L,9L,3L,9L,3L,8L,2L,4L,7L,5L,6L,9L,6L,3L,7L,1L,0L,6L,9L,2L,4L,2L,0L,2L,3L,0L,0L,9L,2L,6L,3L,7L,5L,9L,4L,4L,7L,8L,6L,4L,3L,5L,9L,1L,0L,0L,4L,5L,3L,5L,2L,1L,2L,3L,4L,0L,7L,7L,1L,0L,7L,5L,6L,0L,2L,4L,2L,1L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011342Inst : IEnumerable<long>
{
public static readonly long[] Value=A011342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011342.Bytes);
public long this[int i]=>Value[i];

public static A011342Inst Instance=new A011342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011343
{
public static readonly long[] Value={ 1L,2L,0L,7L,4L,4L,2L,0L,2L,7L,4L,1L,8L,4L,1L,1L,3L,1L,0L,4L,0L,7L,4L,6L,9L,8L,7L,6L,1L,6L,8L,9L,3L,2L,9L,6L,3L,9L,3L,1L,9L,1L,2L,6L,5L,7L,7L,8L,4L,4L,2L,2L,1L,5L,7L,0L,0L,3L,9L,1L,3L,4L,1L,7L,4L,3L,4L,8L,2L,0L,7L,9L,0L,2L,4L,3L,5L,8L,1L,9L,7L,1L,1L,7L,1L,9L,3L,9L,5L,2L,5L,5L,0L,1L,7L,9L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011343Inst : IEnumerable<long>
{
public static readonly long[] Value=A011343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011343.Bytes);
public long this[int i]=>Value[i];

public static A011343Inst Instance=new A011343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011344
{
public static readonly long[] Value={ 1L,1L,9L,2L,3L,6L,3L,1L,2L,2L,6L,0L,2L,4L,5L,8L,6L,7L,7L,6L,4L,3L,7L,1L,7L,0L,0L,9L,3L,4L,7L,4L,7L,5L,9L,9L,6L,6L,6L,3L,1L,5L,0L,5L,2L,1L,1L,6L,6L,6L,5L,0L,6L,6L,5L,0L,5L,8L,0L,6L,5L,3L,1L,5L,7L,0L,4L,7L,8L,8L,9L,1L,6L,8L,7L,3L,5L,0L,8L,1L,7L,1L,6L,6L,1L,7L,2L,5L,8L,2L,9L,5L,0L,4L,4L,0L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011344Inst : IEnumerable<long>
{
public static readonly long[] Value=A011344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011344.Bytes);
public long this[int i]=>Value[i];

public static A011344Inst Instance=new A011344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011345
{
public static readonly long[] Value={ 1L,1L,7L,9L,3L,2L,3L,6L,3L,4L,5L,7L,2L,9L,9L,4L,6L,1L,4L,0L,6L,2L,1L,2L,1L,3L,2L,3L,5L,8L,2L,2L,1L,1L,5L,2L,5L,0L,4L,6L,6L,7L,7L,9L,6L,7L,6L,0L,0L,1L,4L,1L,4L,8L,6L,0L,1L,0L,1L,1L,9L,2L,4L,8L,5L,3L,0L,6L,5L,7L,5L,5L,5L,0L,0L,8L,7L,9L,9L,7L,5L,7L,9L,4L,2L,2L,7L,7L,5L,8L,4L,3L,0L,8L,5L,6L,9L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011345Inst : IEnumerable<long>
{
public static readonly long[] Value=A011345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011345.Bytes);
public long this[int i]=>Value[i];

public static A011345Inst Instance=new A011345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011346
{
public static readonly long[] Value={ 1L,1L,6L,7L,9L,3L,6L,6L,7L,5L,1L,4L,1L,6L,5L,1L,5L,8L,4L,9L,3L,3L,6L,4L,5L,7L,4L,2L,1L,0L,7L,0L,0L,8L,9L,4L,4L,5L,2L,3L,4L,4L,7L,5L,5L,7L,7L,5L,8L,3L,6L,9L,1L,9L,6L,7L,5L,5L,1L,1L,8L,5L,9L,4L,2L,3L,4L,0L,5L,1L,6L,2L,2L,1L,6L,9L,3L,6L,0L,3L,3L,1L,3L,4L,9L,7L,8L,7L,5L,8L,1L,1L,9L,6L,6L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011346Inst : IEnumerable<long>
{
public static readonly long[] Value=A011346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011346.Bytes);
public long this[int i]=>Value[i];

public static A011346Inst Instance=new A011346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011347
{
public static readonly long[] Value={ 1L,1L,5L,7L,9L,0L,7L,2L,6L,7L,5L,2L,8L,4L,8L,4L,1L,6L,6L,8L,7L,2L,1L,7L,5L,1L,0L,3L,4L,9L,8L,9L,3L,0L,4L,4L,1L,5L,8L,3L,7L,0L,4L,0L,3L,5L,8L,2L,9L,9L,6L,0L,4L,7L,9L,4L,2L,5L,0L,1L,1L,7L,0L,2L,0L,5L,2L,8L,4L,8L,6L,7L,1L,3L,4L,6L,5L,2L,6L,0L,2L,5L,1L,8L,1L,1L,5L,7L,1L,1L,8L,9L,8L,4L,6L,7L,0L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011347Inst : IEnumerable<long>
{
public static readonly long[] Value=A011347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011347.Bytes);
public long this[int i]=>Value[i];

public static A011347Inst Instance=new A011347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011348
{
public static readonly long[] Value={ 1L,1L,4L,9L,0L,0L,6L,6L,1L,2L,8L,8L,5L,9L,1L,2L,8L,3L,3L,8L,0L,6L,6L,0L,7L,9L,9L,2L,5L,3L,5L,5L,8L,5L,7L,3L,6L,7L,0L,4L,0L,1L,9L,2L,7L,3L,6L,4L,4L,0L,1L,7L,9L,7L,7L,1L,2L,0L,3L,9L,0L,8L,9L,6L,1L,5L,9L,3L,7L,4L,0L,1L,0L,4L,1L,3L,2L,0L,9L,3L,5L,0L,7L,9L,4L,1L,5L,2L,4L,3L,6L,6L,0L,7L,8L,7L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011348Inst : IEnumerable<long>
{
public static readonly long[] Value=A011348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011348.Bytes);
public long this[int i]=>Value[i];

public static A011348Inst Instance=new A011348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011349
{
public static readonly long[] Value={ 1L,1L,4L,1L,0L,5L,4L,5L,3L,6L,0L,8L,3L,8L,2L,2L,6L,4L,0L,5L,7L,2L,8L,1L,7L,9L,2L,7L,0L,8L,4L,9L,6L,1L,7L,8L,6L,7L,0L,8L,0L,3L,2L,7L,3L,1L,3L,1L,1L,6L,7L,5L,2L,3L,6L,2L,6L,2L,7L,5L,0L,5L,8L,6L,2L,2L,1L,0L,6L,6L,4L,5L,4L,5L,0L,7L,9L,2L,9L,7L,0L,5L,7L,9L,4L,2L,4L,4L,3L,9L,0L,5L,5L,0L,4L,8L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011349Inst : IEnumerable<long>
{
public static readonly long[] Value=A011349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011349.Bytes);
public long this[int i]=>Value[i];

public static A011349Inst Instance=new A011349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011350
{
public static readonly long[] Value={ 1L,5L,7L,0L,4L,1L,7L,8L,0L,2L,4L,7L,5L,0L,1L,9L,7L,3L,5L,3L,1L,0L,5L,2L,9L,6L,6L,7L,0L,0L,2L,6L,2L,3L,3L,4L,9L,4L,5L,8L,3L,7L,7L,7L,7L,6L,6L,5L,8L,1L,3L,5L,3L,3L,7L,8L,9L,6L,2L,8L,9L,9L,3L,8L,4L,0L,0L,7L,4L,6L,5L,8L,5L,2L,9L,2L,6L,0L,5L,4L,2L,2L,2L,1L,3L,4L,3L,4L,6L,9L,0L,4L,8L,9L,0L,6L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011350Inst : IEnumerable<long>
{
public static readonly long[] Value=A011350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011350.Bytes);
public long this[int i]=>Value[i];

public static A011350Inst Instance=new A011350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011351
{
public static readonly long[] Value={ 1L,4L,7L,2L,3L,5L,6L,7L,0L,0L,1L,8L,0L,3L,4L,6L,9L,2L,3L,7L,1L,2L,7L,9L,0L,0L,0L,0L,9L,7L,4L,0L,2L,4L,2L,3L,2L,7L,9L,6L,1L,6L,6L,4L,0L,7L,5L,4L,6L,7L,7L,5L,7L,6L,3L,4L,6L,8L,2L,8L,2L,2L,1L,4L,8L,3L,9L,3L,8L,8L,2L,6L,5L,5L,3L,8L,1L,2L,3L,5L,3L,5L,0L,2L,8L,0L,8L,3L,0L,3L,4L,9L,8L,6L,5L,0L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011351Inst : IEnumerable<long>
{
public static readonly long[] Value=A011351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011351.Bytes);
public long this[int i]=>Value[i];

public static A011351Inst Instance=new A011351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011352
{
public static readonly long[] Value={ 1L,4L,0L,2L,8L,5L,0L,5L,5L,2L,0L,0L,6L,6L,7L,4L,1L,6L,5L,8L,6L,6L,2L,3L,7L,8L,5L,2L,7L,5L,1L,5L,1L,4L,4L,0L,4L,8L,3L,0L,8L,1L,1L,7L,4L,6L,4L,0L,8L,9L,6L,8L,1L,5L,2L,6L,2L,0L,0L,9L,5L,1L,2L,6L,0L,5L,5L,2L,8L,4L,7L,1L,5L,6L,9L,4L,8L,3L,0L,4L,3L,3L,1L,0L,9L,4L,7L,4L,5L,3L,0L,3L,6L,4L,1L,1L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011352Inst : IEnumerable<long>
{
public static readonly long[] Value=A011352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011352.Bytes);
public long this[int i]=>Value[i];

public static A011352Inst Instance=new A011352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011353
{
public static readonly long[] Value={ 1L,3L,5L,1L,0L,6L,6L,7L,5L,1L,6L,0L,1L,7L,7L,0L,8L,3L,1L,3L,4L,6L,1L,9L,8L,1L,5L,4L,0L,3L,1L,1L,0L,4L,1L,6L,7L,9L,4L,8L,9L,0L,0L,4L,0L,3L,4L,5L,0L,6L,8L,2L,0L,2L,8L,2L,8L,4L,6L,7L,7L,7L,5L,0L,4L,1L,8L,4L,7L,7L,9L,4L,6L,6L,6L,7L,4L,8L,8L,8L,3L,9L,8L,8L,3L,4L,0L,1L,8L,0L,2L,5L,7L,4L,3L,3L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011353Inst : IEnumerable<long>
{
public static readonly long[] Value=A011353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011353.Bytes);
public long this[int i]=>Value[i];

public static A011353Inst Instance=new A011353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011354
{
public static readonly long[] Value={ 1L,3L,1L,1L,0L,1L,9L,4L,2L,3L,0L,3L,9L,7L,4L,9L,9L,2L,5L,2L,0L,4L,5L,5L,6L,4L,0L,7L,0L,5L,2L,8L,0L,4L,3L,3L,0L,7L,3L,2L,0L,1L,6L,4L,3L,4L,7L,8L,3L,5L,3L,5L,3L,9L,3L,1L,0L,6L,1L,2L,6L,9L,1L,9L,7L,0L,2L,3L,3L,4L,7L,2L,8L,5L,6L,3L,4L,4L,0L,8L,9L,2L,6L,0L,8L,6L,3L,3L,9L,8L,7L,4L,7L,2L,3L,7L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011354Inst : IEnumerable<long>
{
public static readonly long[] Value=A011354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011354.Bytes);
public long this[int i]=>Value[i];

public static A011354Inst Instance=new A011354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011355
{
public static readonly long[] Value={ 1L,2L,7L,9L,1L,3L,7L,9L,5L,9L,5L,1L,2L,4L,0L,0L,9L,7L,0L,5L,8L,2L,8L,5L,3L,4L,9L,4L,1L,9L,1L,7L,7L,2L,9L,7L,7L,9L,0L,2L,2L,5L,7L,3L,4L,8L,1L,3L,1L,0L,4L,2L,9L,2L,8L,4L,9L,4L,7L,5L,1L,2L,9L,8L,9L,4L,7L,9L,4L,6L,4L,9L,8L,1L,0L,6L,0L,8L,5L,6L,8L,5L,3L,5L,7L,6L,8L,6L,2L,4L,8L,3L,5L,2L,0L,5L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011355Inst : IEnumerable<long>
{
public static readonly long[] Value=A011355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011355.Bytes);
public long this[int i]=>Value[i];

public static A011355Inst Instance=new A011355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011356
{
public static readonly long[] Value={ 1L,2L,5L,3L,1L,6L,3L,1L,1L,8L,8L,6L,1L,6L,3L,4L,7L,6L,2L,2L,8L,6L,4L,3L,4L,9L,2L,6L,5L,9L,1L,1L,8L,5L,4L,4L,4L,4L,5L,2L,4L,7L,7L,7L,8L,4L,3L,1L,2L,4L,6L,7L,9L,7L,6L,5L,2L,9L,6L,2L,1L,7L,3L,3L,6L,3L,1L,5L,0L,9L,9L,8L,0L,7L,9L,6L,2L,8L,0L,1L,7L,5L,0L,2L,2L,9L,5L,3L,7L,8L,2L,8L,9L,8L,3L,3L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011356Inst : IEnumerable<long>
{
public static readonly long[] Value=A011356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011356.Bytes);
public long this[int i]=>Value[i];

public static A011356Inst Instance=new A011356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011357
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,9L,6L,8L,1L,8L,6L,1L,2L,2L,4L,8L,4L,5L,7L,0L,7L,0L,7L,4L,0L,0L,5L,3L,1L,8L,3L,7L,4L,6L,1L,2L,0L,2L,4L,4L,7L,4L,3L,6L,0L,9L,2L,2L,9L,2L,7L,4L,3L,1L,7L,6L,2L,8L,5L,9L,5L,1L,4L,7L,4L,7L,8L,7L,5L,3L,4L,8L,9L,9L,0L,1L,4L,3L,7L,6L,4L,9L,1L,3L,2L,2L,3L,7L,8L,4L,6L,5L,0L,7L,7L,4L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011357Inst : IEnumerable<long>
{
public static readonly long[] Value=A011357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011357.Bytes);
public long this[int i]=>Value[i];

public static A011357Inst Instance=new A011357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011358
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,0L,7L,0L,6L,2L,8L,5L,2L,5L,0L,6L,6L,0L,8L,7L,7L,8L,0L,9L,4L,6L,5L,1L,8L,6L,8L,6L,4L,7L,5L,6L,4L,9L,7L,3L,4L,4L,8L,2L,6L,1L,4L,8L,4L,6L,6L,7L,3L,5L,1L,8L,7L,4L,2L,5L,5L,8L,2L,4L,8L,8L,6L,0L,8L,4L,5L,6L,9L,7L,5L,5L,8L,6L,5L,2L,1L,2L,8L,1L,6L,1L,1L,8L,0L,7L,5L,8L,6L,9L,9L,7L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011358Inst : IEnumerable<long>
{
public static readonly long[] Value=A011358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011358.Bytes);
public long this[int i]=>Value[i];

public static A011358Inst Instance=new A011358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011359
{
public static readonly long[] Value={ 1L,1L,9L,7L,8L,6L,0L,0L,5L,8L,2L,6L,9L,6L,3L,6L,2L,4L,4L,4L,2L,7L,1L,6L,2L,8L,8L,1L,8L,1L,0L,0L,7L,5L,4L,6L,4L,3L,8L,0L,9L,0L,1L,7L,3L,8L,8L,9L,2L,8L,4L,1L,6L,9L,1L,6L,4L,4L,6L,5L,0L,9L,8L,7L,2L,9L,8L,3L,6L,4L,8L,5L,9L,0L,6L,9L,6L,4L,8L,1L,0L,3L,9L,3L,8L,5L,3L,7L,9L,5L,5L,0L,3L,2L,6L,3L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011359Inst : IEnumerable<long>
{
public static readonly long[] Value=A011359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011359.Bytes);
public long this[int i]=>Value[i];

public static A011359Inst Instance=new A011359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011360
{
public static readonly long[] Value={ 1L,1L,8L,4L,4L,1L,9L,9L,2L,2L,1L,5L,8L,8L,0L,6L,8L,8L,7L,1L,7L,4L,6L,8L,9L,9L,8L,5L,2L,2L,0L,2L,0L,7L,9L,4L,3L,4L,0L,9L,8L,2L,9L,2L,2L,5L,0L,3L,6L,2L,6L,9L,4L,3L,9L,7L,7L,1L,4L,0L,0L,1L,5L,1L,9L,9L,7L,5L,8L,8L,1L,4L,9L,2L,9L,5L,9L,4L,3L,8L,1L,1L,8L,1L,2L,0L,1L,0L,1L,8L,8L,6L,2L,1L,2L,3L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011360Inst : IEnumerable<long>
{
public static readonly long[] Value=A011360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011360.Bytes);
public long this[int i]=>Value[i];

public static A011360Inst Instance=new A011360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011361
{
public static readonly long[] Value={ 1L,1L,7L,2L,6L,8L,6L,2L,6L,5L,6L,1L,5L,2L,6L,3L,2L,8L,6L,9L,6L,7L,7L,7L,4L,7L,5L,0L,2L,9L,3L,6L,3L,4L,5L,5L,9L,1L,8L,8L,3L,6L,6L,4L,1L,4L,9L,5L,7L,7L,0L,4L,9L,6L,6L,5L,8L,5L,7L,2L,3L,5L,0L,3L,4L,5L,0L,1L,4L,1L,1L,1L,8L,2L,3L,2L,7L,7L,2L,1L,6L,8L,3L,8L,0L,4L,9L,5L,2L,5L,2L,4L,6L,0L,4L,8L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011361Inst : IEnumerable<long>
{
public static readonly long[] Value=A011361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011361.Bytes);
public long this[int i]=>Value[i];

public static A011361Inst Instance=new A011361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011362
{
public static readonly long[] Value={ 1L,1L,6L,2L,3L,5L,3L,9L,7L,0L,0L,1L,1L,6L,1L,8L,6L,3L,4L,2L,7L,2L,8L,5L,5L,4L,3L,7L,2L,1L,6L,2L,2L,8L,4L,5L,9L,6L,2L,9L,4L,7L,0L,5L,4L,7L,2L,4L,0L,6L,9L,3L,6L,6L,3L,1L,1L,2L,5L,8L,5L,3L,4L,0L,9L,4L,2L,7L,0L,7L,1L,0L,2L,1L,3L,8L,5L,9L,5L,6L,6L,3L,7L,3L,0L,8L,9L,1L,6L,7L,8L,8L,8L,6L,2L,0L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011362Inst : IEnumerable<long>
{
public static readonly long[] Value=A011362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011362.Bytes);
public long this[int i]=>Value[i];

public static A011362Inst Instance=new A011362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011363
{
public static readonly long[] Value={ 1L,1L,5L,3L,1L,8L,6L,4L,7L,4L,3L,9L,3L,2L,9L,9L,4L,6L,9L,6L,4L,6L,2L,2L,6L,6L,0L,2L,8L,2L,5L,1L,4L,1L,9L,2L,8L,1L,6L,8L,3L,6L,2L,6L,1L,6L,7L,5L,8L,6L,7L,1L,3L,8L,3L,6L,5L,6L,8L,2L,4L,4L,8L,0L,8L,3L,6L,5L,8L,6L,0L,9L,6L,5L,8L,1L,5L,7L,2L,7L,6L,5L,5L,6L,1L,7L,5L,3L,4L,7L,0L,9L,7L,5L,1L,2L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011363Inst : IEnumerable<long>
{
public static readonly long[] Value=A011363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011363.Bytes);
public long this[int i]=>Value[i];

public static A011363Inst Instance=new A011363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011364
{
public static readonly long[] Value={ 1L,1L,4L,4L,9L,9L,7L,5L,6L,4L,6L,4L,3L,5L,8L,9L,0L,6L,7L,4L,0L,4L,4L,9L,1L,6L,6L,5L,5L,2L,5L,5L,9L,6L,2L,6L,8L,5L,6L,9L,2L,7L,2L,6L,0L,3L,7L,4L,9L,1L,8L,3L,7L,7L,9L,2L,3L,1L,1L,3L,8L,7L,0L,2L,4L,6L,4L,4L,3L,6L,6L,5L,9L,7L,0L,5L,9L,3L,9L,6L,8L,1L,0L,1L,9L,3L,4L,3L,3L,5L,2L,9L,3L,0L,1L,2L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011364Inst : IEnumerable<long>
{
public static readonly long[] Value=A011364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011364.Bytes);
public long this[int i]=>Value[i];

public static A011364Inst Instance=new A011364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011365
{
public static readonly long[] Value={ 1L,-2L,-3L,-11L,-49L,-244L,-1301L,-7265L,-41945L,-248357L,-1499838L,-9202478L,-57204263L,-359491066L,-2280171089L,-14578108497L,-93850280001L,-607856133804L,-3958143058643L,-25897182540675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011365Inst : IEnumerable<long>
{
public static readonly long[] Value=A011365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011365.Bytes);
public long this[int i]=>Value[i];

public static A011365Inst Instance=new A011365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011366
{
public static readonly long[] Value={ 1L,4L,8L,5L,9L,9L,4L,2L,8L,9L,1L,3L,6L,9L,4L,8L,4L,2L,4L,7L,9L,9L,8L,5L,3L,2L,8L,6L,7L,1L,4L,5L,9L,2L,6L,0L,6L,3L,2L,3L,7L,1L,1L,3L,5L,9L,4L,3L,7L,1L,0L,9L,7L,3L,3L,3L,5L,6L,5L,0L,3L,1L,9L,7L,1L,5L,0L,7L,9L,0L,8L,5L,8L,3L,4L,0L,5L,5L,6L,2L,0L,0L,4L,9L,6L,3L,9L,7L,9L,9L,4L,0L,9L,1L,2L,3L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011366Inst : IEnumerable<long>
{
public static readonly long[] Value=A011366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011366.Bytes);
public long this[int i]=>Value[i];

public static A011366Inst Instance=new A011366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011367
{
public static readonly long[] Value={ 1L,2L,8L,29L,107L,393L,1445L,5312L,19528L,71789L,263911L,970191L,3566621L,13111630L,48201040L,177196905L,651412151L,2394724617L,8803498649L,32363465892L,118974735648L,437375519969L,1607882080395L,5910904169119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011367Inst : IEnumerable<long>
{
public static readonly long[] Value=A011367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011367.Bytes);
public long this[int i]=>Value[i];

public static A011367Inst Instance=new A011367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011368
{
public static readonly long[] Value={ 1L,3L,6L,0L,7L,9L,0L,0L,0L,0L,1L,7L,4L,3L,7L,6L,9L,6L,4L,2L,5L,5L,6L,8L,0L,3L,7L,5L,3L,2L,4L,8L,1L,3L,0L,9L,8L,8L,7L,0L,1L,2L,6L,6L,9L,8L,7L,3L,9L,3L,2L,7L,8L,6L,3L,6L,6L,4L,7L,9L,9L,7L,1L,4L,9L,6L,6L,6L,5L,3L,2L,7L,6L,0L,8L,8L,7L,4L,6L,8L,2L,5L,7L,2L,1L,7L,6L,2L,8L,4L,1L,2L,2L,9L,5L,4L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011368Inst : IEnumerable<long>
{
public static readonly long[] Value=A011368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011368.Bytes);
public long this[int i]=>Value[i];

public static A011368Inst Instance=new A011368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011369
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,1L,6L,14L,1L,22L,56L,1L,90L,234L,1L,378L,988L,1L,1598L,4182L,1L,6766L,17712L,1L,28658L,75026L,1L,121394L,317812L,1L,514230L,1346270L,1L,2178310L,5702888L,1L,9227466L,24157818L,1L,39088170L,102334156L,1L,165580142L,433494438L,1L,701408734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011369Inst : IEnumerable<long>
{
public static readonly long[] Value=A011369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011369.Bytes);
public long this[int i]=>Value[i];

public static A011369Inst Instance=new A011369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011370
{
public static readonly long[] Value={ 1L,2L,8L,6L,6L,6L,4L,8L,9L,8L,0L,0L,9L,4L,3L,1L,7L,9L,0L,4L,4L,2L,6L,6L,4L,3L,5L,3L,5L,7L,7L,2L,4L,8L,3L,9L,0L,9L,5L,2L,4L,6L,1L,1L,2L,4L,3L,2L,6L,8L,2L,7L,9L,5L,5L,9L,8L,0L,5L,8L,5L,7L,1L,1L,8L,7L,4L,9L,4L,6L,4L,4L,8L,4L,7L,9L,1L,0L,1L,1L,4L,0L,7L,9L,5L,3L,6L,6L,5L,5L,6L,5L,9L,5L,9L,5L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011370Inst : IEnumerable<long>
{
public static readonly long[] Value=A011370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011370.Bytes);
public long this[int i]=>Value[i];

public static A011370Inst Instance=new A011370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011371
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,3L,4L,4L,7L,7L,8L,8L,10L,10L,11L,11L,15L,15L,16L,16L,18L,18L,19L,19L,22L,22L,23L,23L,25L,25L,26L,26L,31L,31L,32L,32L,34L,34L,35L,35L,38L,38L,39L,39L,41L,41L,42L,42L,46L,46L,47L,47L,49L,49L,50L,50L,53L,53L,54L,54L,56L,56L,57L,57L,63L,63L,64L,64L,66L,66L,67L,67L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011371Inst : IEnumerable<long>
{
public static readonly long[] Value=A011371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011371.Bytes);
public long this[int i]=>Value[i];

public static A011371Inst Instance=new A011371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011372
{
public static readonly long[] Value={ 1L,2L,3L,7L,7L,2L,6L,2L,8L,5L,3L,0L,5L,4L,2L,8L,0L,4L,7L,6L,3L,7L,0L,6L,2L,0L,3L,8L,9L,6L,4L,3L,4L,7L,9L,8L,7L,2L,0L,0L,6L,3L,1L,5L,1L,0L,3L,9L,6L,7L,3L,8L,3L,4L,4L,0L,2L,9L,0L,4L,9L,0L,8L,3L,5L,5L,3L,7L,4L,8L,5L,5L,7L,1L,7L,0L,6L,2L,6L,4L,9L,8L,7L,7L,9L,5L,3L,8L,3L,9L,7L,3L,3L,4L,7L,1L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011372Inst : IEnumerable<long>
{
public static readonly long[] Value=A011372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011372.Bytes);
public long this[int i]=>Value[i];

public static A011372Inst Instance=new A011372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011373
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,3L,3L,2L,5L,4L,2L,5L,6L,4L,8L,7L,4L,5L,8L,6L,8L,11L,6L,6L,9L,11L,11L,12L,8L,11L,9L,13L,12L,11L,12L,14L,10L,12L,16L,17L,14L,16L,18L,15L,21L,13L,12L,18L,18L,17L,17L,17L,16L,22L,21L,16L,24L,20L,16L,19L,26L,23L,20L,25L,19L,26L,15L,23L,23L,22L,25L,27L,24L,23L,23L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011373Inst : IEnumerable<long>
{
public static readonly long[] Value=A011373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011373.Bytes);
public long this[int i]=>Value[i];

public static A011373Inst Instance=new A011373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011406
{
public static readonly long[] Value={ 1L,1L,8L,5L,3L,3L,0L,7L,7L,1L,9L,8L,2L,4L,7L,8L,9L,5L,5L,7L,4L,3L,2L,6L,2L,2L,1L,4L,9L,4L,8L,3L,5L,5L,3L,4L,1L,5L,5L,7L,8L,0L,0L,6L,4L,6L,2L,9L,5L,5L,9L,9L,7L,0L,4L,9L,5L,6L,4L,6L,8L,8L,2L,7L,8L,2L,4L,4L,7L,4L,9L,0L,3L,4L,4L,8L,1L,7L,6L,4L,2L,8L,2L,3L,1L,3L,5L,1L,8L,5L,0L,3L,3L,6L,1L,3L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011406Inst : IEnumerable<long>
{
public static readonly long[] Value=A011406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011406.Bytes);
public long this[int i]=>Value[i];

public static A011406Inst Instance=new A011406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011407
{
public static readonly long[] Value={ 1L,1L,7L,4L,1L,8L,7L,2L,5L,3L,0L,9L,9L,6L,6L,1L,5L,2L,9L,5L,1L,2L,3L,3L,2L,3L,2L,5L,8L,9L,5L,5L,5L,8L,1L,6L,7L,5L,7L,0L,2L,4L,7L,9L,6L,7L,7L,1L,9L,9L,9L,3L,8L,9L,1L,2L,0L,8L,3L,6L,0L,8L,3L,9L,9L,5L,4L,7L,7L,5L,7L,0L,3L,0L,9L,4L,3L,4L,0L,5L,3L,9L,7L,1L,9L,4L,3L,3L,9L,8L,2L,7L,8L,1L,5L,8L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011407Inst : IEnumerable<long>
{
public static readonly long[] Value=A011407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011407.Bytes);
public long this[int i]=>Value[i];

public static A011407Inst Instance=new A011407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011408
{
public static readonly long[] Value={ 1L,1L,6L,4L,3L,0L,5L,5L,6L,6L,8L,8L,3L,3L,7L,0L,0L,1L,2L,7L,2L,5L,6L,1L,4L,1L,6L,0L,5L,0L,4L,8L,6L,1L,9L,6L,1L,4L,0L,3L,5L,6L,0L,0L,7L,1L,6L,5L,5L,8L,8L,1L,9L,1L,8L,1L,8L,9L,0L,5L,5L,1L,1L,8L,9L,8L,6L,7L,1L,7L,4L,7L,0L,8L,1L,1L,2L,9L,7L,7L,0L,4L,1L,7L,5L,6L,7L,2L,0L,5L,9L,2L,1L,2L,5L,2L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011408Inst : IEnumerable<long>
{
public static readonly long[] Value=A011408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011408.Bytes);
public long this[int i]=>Value[i];

public static A011408Inst Instance=new A011408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011409
{
public static readonly long[] Value={ 1L,1L,5L,5L,4L,8L,3L,1L,7L,2L,7L,6L,3L,8L,0L,6L,6L,0L,4L,4L,2L,5L,9L,7L,0L,0L,6L,1L,5L,2L,6L,1L,0L,6L,5L,0L,5L,6L,7L,4L,1L,0L,9L,6L,6L,5L,9L,9L,4L,7L,8L,5L,2L,2L,2L,6L,5L,4L,0L,0L,9L,6L,3L,6L,5L,6L,8L,0L,9L,2L,9L,5L,5L,0L,2L,9L,0L,2L,5L,6L,5L,9L,1L,5L,4L,4L,4L,5L,2L,9L,3L,1L,8L,2L,1L,8L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011409Inst : IEnumerable<long>
{
public static readonly long[] Value=A011409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011409.Bytes);
public long this[int i]=>Value[i];

public static A011409Inst Instance=new A011409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011410
{
public static readonly long[] Value={ 1L,6L,3L,3L,5L,2L,4L,3L,0L,3L,0L,7L,0L,4L,9L,4L,5L,3L,0L,7L,2L,4L,6L,7L,0L,1L,8L,3L,5L,9L,0L,3L,8L,7L,2L,8L,8L,7L,0L,8L,8L,2L,7L,8L,4L,9L,4L,1L,5L,5L,8L,6L,5L,6L,2L,9L,0L,9L,4L,7L,4L,8L,5L,0L,5L,6L,1L,9L,9L,2L,6L,1L,3L,4L,4L,9L,5L,5L,5L,0L,2L,9L,2L,1L,5L,9L,6L,6L,8L,7L,1L,0L,1L,6L,9L,9L,1L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011410Inst : IEnumerable<long>
{
public static readonly long[] Value=A011410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011410.Bytes);
public long this[int i]=>Value[i];

public static A011410Inst Instance=new A011410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011411
{
public static readonly long[] Value={ 1L,5L,2L,2L,9L,2L,6L,9L,9L,8L,2L,1L,8L,7L,5L,3L,3L,9L,3L,3L,8L,6L,9L,6L,8L,1L,9L,1L,5L,2L,7L,1L,9L,2L,9L,9L,8L,6L,2L,1L,4L,1L,8L,2L,0L,4L,5L,7L,2L,2L,1L,8L,5L,7L,3L,4L,3L,8L,0L,6L,8L,0L,7L,9L,7L,7L,3L,2L,1L,4L,9L,4L,1L,3L,8L,6L,2L,1L,6L,1L,5L,6L,0L,1L,0L,2L,3L,9L,2L,5L,8L,1L,6L,1L,2L,0L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011411Inst : IEnumerable<long>
{
public static readonly long[] Value=A011411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011411.Bytes);
public long this[int i]=>Value[i];

public static A011411Inst Instance=new A011411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011412
{
public static readonly long[] Value={ 1L,4L,4L,4L,9L,2L,1L,3L,2L,3L,0L,9L,3L,3L,5L,2L,3L,5L,0L,0L,6L,7L,2L,4L,6L,0L,9L,9L,9L,2L,7L,2L,4L,7L,2L,7L,7L,5L,6L,1L,1L,7L,6L,9L,1L,1L,8L,4L,7L,6L,9L,0L,7L,6L,2L,2L,0L,7L,2L,0L,5L,2L,9L,8L,3L,9L,4L,9L,2L,6L,9L,7L,4L,7L,4L,0L,8L,7L,5L,2L,2L,2L,5L,2L,9L,1L,7L,9L,9L,2L,6L,3L,6L,6L,6L,9L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011412Inst : IEnumerable<long>
{
public static readonly long[] Value=A011412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011412.Bytes);
public long this[int i]=>Value[i];

public static A011412Inst Instance=new A011412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011413
{
public static readonly long[] Value={ 1L,3L,8L,7L,0L,2L,3L,2L,2L,5L,8L,4L,4L,2L,1L,9L,1L,9L,7L,7L,3L,5L,5L,1L,7L,5L,4L,3L,1L,8L,0L,5L,8L,0L,2L,6L,0L,6L,9L,7L,6L,2L,5L,6L,8L,2L,6L,3L,0L,5L,3L,6L,5L,2L,8L,7L,4L,9L,8L,5L,6L,9L,3L,9L,3L,2L,1L,8L,9L,0L,1L,5L,3L,2L,2L,6L,2L,6L,0L,9L,1L,1L,0L,3L,6L,1L,8L,3L,4L,6L,0L,6L,5L,3L,7L,1L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011413Inst : IEnumerable<long>
{
public static readonly long[] Value=A011413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011413.Bytes);
public long this[int i]=>Value[i];

public static A011413Inst Instance=new A011413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011414
{
public static readonly long[] Value={ 1L,3L,4L,2L,3L,7L,9L,6L,5L,0L,9L,6L,2L,1L,0L,4L,7L,9L,8L,0L,9L,3L,7L,8L,3L,7L,9L,3L,0L,0L,0L,2L,9L,2L,3L,4L,6L,6L,8L,9L,8L,7L,7L,9L,8L,5L,7L,6L,3L,7L,5L,5L,2L,5L,6L,5L,6L,9L,4L,0L,1L,6L,5L,4L,3L,1L,3L,0L,2L,7L,5L,7L,6L,8L,0L,0L,2L,5L,4L,4L,7L,6L,8L,1L,7L,5L,4L,4L,2L,6L,5L,5L,2L,5L,9L,4L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011414Inst : IEnumerable<long>
{
public static readonly long[] Value=A011414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011414.Bytes);
public long this[int i]=>Value[i];

public static A011414Inst Instance=new A011414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011415
{
public static readonly long[] Value={ 1L,3L,0L,6L,9L,2L,3L,9L,8L,2L,1L,1L,2L,7L,0L,1L,1L,9L,1L,6L,5L,8L,6L,8L,3L,1L,1L,2L,8L,9L,8L,2L,5L,6L,7L,6L,1L,3L,3L,1L,8L,6L,7L,0L,9L,0L,8L,2L,9L,5L,2L,9L,0L,5L,5L,8L,0L,1L,6L,8L,5L,7L,1L,5L,1L,5L,8L,0L,4L,0L,3L,0L,9L,2L,5L,8L,9L,2L,5L,7L,3L,9L,7L,0L,9L,4L,5L,2L,5L,2L,3L,5L,7L,7L,7L,6L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011415Inst : IEnumerable<long>
{
public static readonly long[] Value=A011415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011415.Bytes);
public long this[int i]=>Value[i];

public static A011415Inst Instance=new A011415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011416
{
public static readonly long[] Value={ 1L,2L,7L,8L,0L,9L,4L,0L,1L,1L,8L,2L,7L,9L,6L,1L,9L,4L,6L,0L,0L,0L,8L,3L,6L,5L,5L,3L,3L,1L,5L,5L,1L,9L,4L,1L,0L,6L,0L,0L,9L,8L,0L,7L,2L,2L,0L,6L,2L,9L,4L,6L,4L,3L,2L,2L,3L,0L,5L,9L,6L,2L,4L,4L,6L,9L,0L,9L,6L,7L,1L,5L,1L,5L,3L,6L,2L,1L,5L,6L,1L,4L,0L,4L,4L,5L,6L,3L,0L,7L,8L,8L,7L,4L,0L,9L,1L,5L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011416Inst : IEnumerable<long>
{
public static readonly long[] Value=A011416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011416.Bytes);
public long this[int i]=>Value[i];

public static A011416Inst Instance=new A011416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011417
{
public static readonly long[] Value={ 1L,2L,5L,4L,1L,9L,6L,7L,2L,2L,7L,3L,3L,2L,0L,4L,6L,5L,8L,6L,6L,1L,0L,4L,4L,2L,3L,2L,7L,2L,4L,0L,1L,3L,1L,3L,4L,0L,2L,2L,3L,0L,9L,1L,0L,8L,6L,7L,5L,3L,9L,8L,1L,1L,5L,3L,3L,7L,1L,8L,1L,2L,3L,1L,1L,6L,9L,6L,3L,8L,0L,7L,4L,3L,4L,4L,5L,3L,0L,1L,3L,8L,3L,2L,9L,6L,7L,4L,0L,6L,0L,9L,2L,9L,7L,4L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011417Inst : IEnumerable<long>
{
public static readonly long[] Value=A011417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011417.Bytes);
public long this[int i]=>Value[i];

public static A011417Inst Instance=new A011417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011418
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,6L,9L,2L,8L,4L,2L,0L,5L,2L,0L,7L,5L,7L,7L,8L,5L,3L,0L,0L,2L,4L,7L,4L,3L,4L,0L,3L,6L,9L,7L,4L,5L,0L,0L,4L,1L,3L,1L,0L,1L,8L,4L,7L,7L,1L,6L,6L,0L,9L,4L,6L,7L,5L,7L,6L,2L,0L,4L,1L,8L,4L,4L,4L,7L,6L,1L,8L,4L,1L,9L,5L,0L,3L,2L,1L,2L,8L,5L,6L,8L,3L,6L,4L,3L,6L,2L,9L,8L,8L,4L,5L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011418Inst : IEnumerable<long>
{
public static readonly long[] Value=A011418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011418.Bytes);
public long this[int i]=>Value[i];

public static A011418Inst Instance=new A011418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011419
{
public static readonly long[] Value={ 1L,2L,1L,6L,8L,8L,6L,9L,6L,7L,7L,8L,1L,2L,2L,4L,7L,3L,7L,9L,3L,8L,0L,0L,2L,9L,8L,8L,5L,0L,8L,3L,5L,0L,9L,6L,0L,1L,3L,2L,8L,9L,6L,1L,6L,5L,6L,5L,1L,6L,9L,1L,4L,5L,2L,8L,0L,7L,3L,4L,3L,5L,8L,3L,6L,2L,8L,2L,2L,9L,8L,1L,8L,3L,4L,9L,5L,8L,8L,4L,5L,3L,8L,0L,3L,8L,4L,7L,2L,6L,5L,6L,9L,0L,1L,5L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011419Inst : IEnumerable<long>
{
public static readonly long[] Value=A011419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011419.Bytes);
public long this[int i]=>Value[i];

public static A011419Inst Instance=new A011419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011420
{
public static readonly long[] Value={ 1L,2L,0L,2L,0L,4L,8L,8L,0L,2L,2L,9L,2L,7L,1L,5L,7L,1L,3L,7L,0L,9L,2L,5L,2L,3L,8L,4L,7L,7L,7L,5L,2L,3L,4L,8L,0L,7L,1L,6L,3L,5L,6L,0L,1L,6L,3L,3L,0L,3L,6L,9L,7L,2L,8L,5L,3L,7L,2L,7L,2L,7L,4L,5L,9L,7L,5L,7L,1L,8L,5L,1L,6L,5L,4L,1L,1L,3L,1L,9L,8L,3L,9L,0L,8L,5L,2L,9L,6L,7L,2L,9L,5L,7L,4L,7L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011420Inst : IEnumerable<long>
{
public static readonly long[] Value=A011420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011420.Bytes);
public long this[int i]=>Value[i];

public static A011420Inst Instance=new A011420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011421
{
public static readonly long[] Value={ 1L,1L,8L,9L,1L,0L,6L,6L,2L,8L,5L,7L,4L,0L,7L,7L,0L,6L,4L,0L,0L,0L,5L,1L,3L,8L,0L,3L,1L,0L,7L,2L,2L,9L,1L,9L,0L,6L,3L,0L,6L,4L,6L,9L,4L,8L,3L,7L,3L,0L,8L,2L,2L,0L,2L,4L,1L,1L,1L,9L,7L,7L,7L,5L,8L,3L,6L,8L,6L,8L,9L,5L,6L,4L,0L,7L,1L,7L,4L,8L,1L,9L,9L,3L,5L,8L,9L,6L,8L,5L,5L,9L,8L,4L,5L,8L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011421Inst : IEnumerable<long>
{
public static readonly long[] Value=A011421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011421.Bytes);
public long this[int i]=>Value[i];

public static A011421Inst Instance=new A011421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011422
{
public static readonly long[] Value={ 1L,1L,7L,7L,7L,1L,9L,5L,0L,2L,1L,9L,2L,3L,5L,9L,5L,5L,2L,9L,0L,2L,4L,8L,5L,3L,2L,6L,0L,8L,0L,5L,2L,8L,8L,9L,7L,3L,8L,9L,4L,8L,0L,8L,6L,5L,3L,6L,4L,0L,1L,3L,0L,2L,5L,7L,3L,0L,4L,0L,5L,1L,7L,3L,9L,3L,3L,4L,2L,2L,4L,6L,8L,9L,7L,4L,3L,2L,0L,3L,2L,6L,1L,9L,2L,5L,8L,9L,2L,1L,3L,7L,8L,4L,6L,2L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011422Inst : IEnumerable<long>
{
public static readonly long[] Value=A011422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011422.Bytes);
public long this[int i]=>Value[i];

public static A011422Inst Instance=new A011422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011423
{
public static readonly long[] Value={ 1L,1L,6L,7L,6L,2L,3L,4L,8L,3L,6L,9L,6L,1L,0L,7L,6L,2L,4L,0L,8L,3L,3L,1L,3L,8L,8L,3L,1L,6L,1L,0L,8L,0L,1L,5L,6L,5L,9L,1L,5L,0L,2L,3L,6L,4L,3L,0L,8L,3L,5L,7L,9L,1L,7L,0L,8L,3L,9L,2L,5L,0L,1L,3L,8L,3L,3L,4L,0L,3L,6L,4L,6L,9L,8L,9L,1L,7L,1L,9L,7L,2L,2L,6L,8L,4L,1L,7L,6L,6L,8L,8L,7L,0L,2L,6L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011423Inst : IEnumerable<long>
{
public static readonly long[] Value=A011423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011423.Bytes);
public long this[int i]=>Value[i];

public static A011423Inst Instance=new A011423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011424
{
public static readonly long[] Value={ 1L,1L,5L,8L,6L,1L,1L,0L,8L,7L,0L,1L,8L,4L,6L,3L,1L,5L,3L,6L,7L,3L,1L,7L,1L,6L,5L,3L,7L,4L,0L,9L,3L,0L,0L,6L,3L,6L,0L,1L,2L,9L,6L,3L,8L,6L,5L,7L,1L,8L,2L,7L,9L,9L,9L,1L,3L,4L,8L,8L,9L,6L,1L,8L,2L,7L,3L,7L,8L,7L,0L,1L,9L,3L,2L,3L,9L,3L,5L,5L,3L,2L,8L,2L,0L,7L,1L,2L,4L,4L,5L,2L,1L,7L,2L,3L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011424Inst : IEnumerable<long>
{
public static readonly long[] Value=A011424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011424.Bytes);
public long this[int i]=>Value[i];

public static A011424Inst Instance=new A011424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011425
{
public static readonly long[] Value={ 1L,6L,4L,7L,5L,4L,8L,9L,7L,2L,4L,4L,2L,0L,6L,5L,7L,0L,2L,4L,7L,0L,2L,5L,9L,3L,7L,3L,9L,8L,9L,3L,2L,9L,0L,7L,7L,1L,3L,7L,3L,2L,5L,0L,8L,4L,8L,2L,8L,1L,3L,5L,1L,5L,9L,1L,4L,1L,5L,8L,2L,3L,8L,5L,8L,1L,4L,3L,2L,7L,4L,8L,2L,5L,5L,8L,1L,1L,2L,9L,3L,9L,3L,2L,2L,9L,6L,3L,5L,2L,2L,2L,2L,2L,8L,1L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011425Inst : IEnumerable<long>
{
public static readonly long[] Value=A011425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011425.Bytes);
public long this[int i]=>Value[i];

public static A011425Inst Instance=new A011425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011426
{
public static readonly long[] Value={ 1L,5L,3L,4L,1L,2L,7L,4L,0L,4L,6L,3L,4L,3L,9L,0L,9L,8L,1L,2L,7L,7L,8L,3L,5L,1L,2L,7L,2L,9L,5L,4L,1L,4L,8L,2L,8L,1L,5L,3L,4L,1L,6L,5L,0L,7L,2L,2L,9L,0L,1L,9L,1L,6L,1L,1L,7L,7L,3L,2L,0L,1L,1L,2L,4L,5L,5L,0L,7L,9L,6L,9L,6L,3L,8L,0L,8L,7L,9L,7L,6L,4L,2L,2L,0L,8L,5L,0L,1L,9L,3L,1L,7L,7L,0L,2L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011426Inst : IEnumerable<long>
{
public static readonly long[] Value=A011426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011426.Bytes);
public long this[int i]=>Value[i];

public static A011426Inst Instance=new A011426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011427
{
public static readonly long[] Value={ 1L,4L,5L,4L,2L,1L,5L,4L,3L,3L,4L,4L,8L,9L,5L,3L,6L,8L,3L,2L,8L,4L,3L,2L,3L,4L,5L,4L,9L,5L,6L,2L,9L,5L,6L,1L,2L,4L,7L,7L,3L,4L,7L,1L,0L,8L,0L,7L,9L,9L,0L,3L,6L,1L,9L,7L,0L,5L,1L,9L,7L,6L,2L,0L,5L,4L,7L,8L,8L,6L,3L,6L,1L,0L,3L,0L,9L,2L,7L,8L,5L,1L,9L,4L,0L,2L,1L,9L,3L,1L,5L,3L,8L,8L,3L,8L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011427Inst : IEnumerable<long>
{
public static readonly long[] Value=A011427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011427.Bytes);
public long this[int i]=>Value[i];

public static A011427Inst Instance=new A011427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011428
{
public static readonly long[] Value={ 1L,3L,9L,4L,9L,5L,0L,7L,9L,3L,9L,6L,2L,4L,2L,0L,9L,7L,9L,3L,6L,5L,9L,2L,8L,7L,1L,8L,8L,6L,1L,8L,3L,8L,9L,6L,5L,5L,5L,3L,3L,8L,6L,4L,6L,5L,7L,9L,3L,3L,6L,6L,7L,3L,6L,0L,3L,8L,2L,9L,7L,4L,1L,5L,3L,9L,2L,5L,1L,3L,0L,3L,9L,9L,1L,4L,9L,2L,3L,1L,5L,3L,2L,9L,2L,3L,6L,7L,1L,4L,8L,7L,4L,2L,0L,3L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011428Inst : IEnumerable<long>
{
public static readonly long[] Value=A011428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011428.Bytes);
public long this[int i]=>Value[i];

public static A011428Inst Instance=new A011428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011429
{
public static readonly long[] Value={ 1L,3L,4L,9L,2L,8L,2L,8L,4L,7L,6L,7L,3L,5L,6L,3L,3L,1L,5L,1L,2L,2L,2L,1L,9L,7L,0L,5L,8L,0L,9L,0L,3L,2L,7L,6L,6L,6L,9L,1L,8L,8L,8L,4L,4L,9L,1L,3L,7L,5L,9L,5L,3L,4L,8L,5L,2L,5L,0L,6L,0L,6L,1L,4L,1L,6L,6L,5L,9L,4L,7L,7L,2L,5L,6L,7L,1L,0L,3L,5L,4L,7L,6L,9L,4L,6L,5L,0L,2L,6L,3L,6L,2L,5L,3L,3L,0L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011429Inst : IEnumerable<long>
{
public static readonly long[] Value=A011429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011429.Bytes);
public long this[int i]=>Value[i];

public static A011429Inst Instance=new A011429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011430
{
public static readonly long[] Value={ 1L,3L,1L,3L,0L,3L,2L,4L,3L,4L,4L,8L,7L,8L,8L,3L,9L,2L,6L,4L,3L,0L,9L,3L,0L,5L,1L,0L,4L,3L,8L,0L,4L,0L,8L,4L,0L,4L,7L,6L,0L,1L,0L,8L,3L,1L,2L,8L,3L,5L,3L,0L,0L,4L,7L,6L,0L,8L,5L,7L,1L,6L,3L,3L,7L,3L,7L,6L,4L,5L,1L,7L,5L,7L,8L,7L,7L,1L,7L,8L,3L,3L,0L,5L,7L,8L,4L,5L,5L,5L,0L,4L,6L,8L,9L,2L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011430Inst : IEnumerable<long>
{
public static readonly long[] Value=A011430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011430.Bytes);
public long this[int i]=>Value[i];

public static A011430Inst Instance=new A011430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011431
{
public static readonly long[] Value={ 1L,2L,8L,3L,5L,6L,8L,8L,4L,2L,1L,1L,2L,5L,1L,6L,2L,6L,2L,8L,6L,2L,6L,6L,5L,9L,4L,5L,1L,8L,2L,2L,1L,7L,4L,0L,1L,2L,3L,0L,7L,2L,1L,2L,6L,1L,9L,8L,2L,5L,0L,9L,5L,1L,6L,5L,9L,0L,3L,4L,6L,3L,1L,0L,0L,4L,6L,7L,0L,1L,8L,1L,4L,8L,0L,2L,7L,7L,4L,0L,2L,7L,3L,4L,0L,6L,3L,5L,7L,4L,5L,3L,6L,5L,6L,2L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011431Inst : IEnumerable<long>
{
public static readonly long[] Value=A011431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011431.Bytes);
public long this[int i]=>Value[i];

public static A011431Inst Instance=new A011431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011432
{
public static readonly long[] Value={ 1L,2L,5L,9L,1L,5L,5L,1L,0L,4L,5L,7L,6L,5L,7L,2L,6L,5L,4L,6L,7L,9L,1L,4L,6L,7L,3L,0L,0L,5L,6L,3L,7L,8L,1L,6L,9L,7L,4L,8L,6L,4L,4L,3L,1L,9L,5L,0L,9L,9L,3L,5L,4L,4L,5L,6L,5L,1L,1L,4L,6L,2L,6L,2L,9L,0L,3L,4L,8L,5L,1L,3L,7L,3L,7L,2L,2L,7L,8L,1L,3L,4L,7L,6L,9L,0L,2L,9L,9L,0L,0L,9L,7L,0L,7L,8L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011432Inst : IEnumerable<long>
{
public static readonly long[] Value=A011432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011432.Bytes);
public long this[int i]=>Value[i];

public static A011432Inst Instance=new A011432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011433
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,9L,8L,9L,6L,8L,4L,4L,5L,5L,5L,4L,2L,0L,5L,0L,3L,1L,1L,6L,2L,5L,0L,6L,8L,6L,0L,1L,1L,5L,3L,6L,8L,3L,5L,5L,7L,3L,8L,0L,0L,7L,9L,6L,3L,1L,9L,0L,2L,3L,4L,6L,0L,1L,7L,1L,3L,3L,4L,7L,0L,8L,9L,8L,9L,1L,6L,1L,9L,4L,0L,8L,2L,2L,4L,6L,2L,7L,2L,7L,6L,2L,8L,7L,0L,2L,8L,0L,7L,5L,5L,5L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011433Inst : IEnumerable<long>
{
public static readonly long[] Value=A011433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011433.Bytes);
public long this[int i]=>Value[i];

public static A011433Inst Instance=new A011433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011434
{
public static readonly long[] Value={ 1L,2L,2L,1L,0L,5L,5L,3L,0L,0L,0L,6L,7L,5L,6L,8L,1L,5L,0L,6L,0L,0L,8L,1L,4L,2L,6L,1L,2L,4L,5L,4L,0L,8L,8L,1L,7L,1L,6L,4L,2L,6L,7L,7L,7L,9L,3L,4L,9L,0L,5L,6L,7L,3L,6L,1L,8L,7L,4L,5L,8L,8L,7L,5L,6L,6L,2L,9L,5L,0L,1L,6L,4L,0L,2L,7L,2L,5L,2L,8L,0L,8L,5L,2L,9L,7L,1L,2L,3L,6L,4L,2L,0L,9L,1L,6L,9L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011434Inst : IEnumerable<long>
{
public static readonly long[] Value=A011434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011434.Bytes);
public long this[int i]=>Value[i];

public static A011434Inst Instance=new A011434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011435
{
public static readonly long[] Value={ 1L,2L,0L,5L,9L,0L,8L,5L,5L,1L,0L,3L,0L,6L,9L,6L,3L,9L,1L,6L,2L,1L,8L,9L,7L,2L,0L,0L,7L,6L,7L,7L,9L,3L,0L,1L,8L,0L,8L,6L,5L,9L,4L,3L,7L,4L,9L,2L,3L,1L,1L,7L,4L,5L,6L,7L,2L,2L,6L,3L,8L,9L,4L,8L,4L,9L,1L,6L,7L,6L,9L,5L,8L,6L,1L,7L,0L,8L,0L,9L,4L,6L,6L,0L,9L,0L,8L,3L,9L,0L,3L,8L,2L,8L,9L,0L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011435Inst : IEnumerable<long>
{
public static readonly long[] Value=A011435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011435.Bytes);
public long this[int i]=>Value[i];

public static A011435Inst Instance=new A011435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011436
{
public static readonly long[] Value={ 1L,1L,9L,2L,6L,9L,9L,8L,8L,1L,8L,0L,4L,2L,5L,8L,4L,0L,8L,6L,3L,9L,9L,8L,3L,7L,1L,7L,4L,4L,0L,8L,0L,8L,4L,8L,2L,3L,0L,0L,3L,2L,1L,7L,8L,3L,6L,7L,5L,2L,0L,9L,7L,4L,4L,1L,9L,0L,6L,1L,4L,9L,4L,0L,8L,2L,9L,4L,7L,7L,8L,0L,3L,5L,0L,0L,3L,1L,9L,8L,0L,9L,2L,4L,2L,6L,8L,8L,5L,9L,6L,0L,3L,3L,0L,8L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011436Inst : IEnumerable<long>
{
public static readonly long[] Value=A011436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011436.Bytes);
public long this[int i]=>Value[i];

public static A011436Inst Instance=new A011436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011437
{
public static readonly long[] Value={ 1L,1L,8L,1L,0L,8L,0L,3L,5L,0L,3L,4L,1L,3L,3L,9L,3L,8L,4L,4L,2L,4L,3L,6L,0L,3L,5L,0L,8L,8L,6L,6L,4L,2L,7L,7L,0L,6L,8L,1L,0L,8L,1L,8L,4L,3L,4L,3L,4L,3L,0L,3L,4L,6L,9L,9L,0L,6L,5L,4L,5L,9L,7L,3L,7L,3L,5L,2L,7L,9L,4L,1L,1L,5L,3L,8L,7L,5L,8L,9L,2L,2L,0L,5L,9L,6L,0L,5L,0L,3L,6L,8L,4L,4L,2L,3L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011437Inst : IEnumerable<long>
{
public static readonly long[] Value=A011437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011437.Bytes);
public long this[int i]=>Value[i];

public static A011437Inst Instance=new A011437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011438
{
public static readonly long[] Value={ 1L,1L,7L,0L,7L,7L,9L,9L,1L,3L,7L,2L,2L,7L,7L,9L,3L,3L,3L,2L,5L,7L,6L,4L,0L,9L,4L,4L,8L,9L,8L,3L,4L,4L,0L,4L,7L,5L,6L,0L,0L,1L,7L,8L,9L,0L,3L,3L,2L,7L,8L,8L,4L,9L,6L,2L,5L,1L,4L,8L,3L,2L,9L,8L,3L,1L,2L,5L,2L,8L,6L,6L,3L,1L,1L,7L,5L,1L,2L,4L,0L,2L,8L,5L,1L,1L,8L,1L,3L,4L,9L,2L,8L,6L,7L,3L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011438Inst : IEnumerable<long>
{
public static readonly long[] Value=A011438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011438.Bytes);
public long this[int i]=>Value[i];

public static A011438Inst Instance=new A011438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011439
{
public static readonly long[] Value={ 1L,1L,6L,1L,5L,8L,6L,3L,4L,9L,6L,4L,1L,5L,4L,2L,2L,8L,1L,8L,0L,8L,7L,2L,1L,2L,2L,4L,2L,4L,5L,6L,7L,6L,8L,4L,3L,4L,5L,5L,4L,3L,6L,6L,3L,8L,1L,9L,0L,7L,2L,9L,7L,7L,5L,8L,4L,4L,4L,6L,6L,4L,2L,8L,4L,1L,5L,5L,2L,0L,2L,3L,3L,3L,0L,0L,2L,0L,2L,2L,8L,6L,6L,0L,6L,2L,0L,2L,4L,2L,3L,9L,4L,2L,8L,3L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011439Inst : IEnumerable<long>
{
public static readonly long[] Value=A011439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011439.Bytes);
public long this[int i]=>Value[i];

public static A011439Inst Instance=new A011439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011440
{
public static readonly long[] Value={ 1L,1L,5L,6L,0L,1L,3L,2L,8L,1L,0L,0L,0L,8L,0L,3L,2L,7L,2L,6L,9L,5L,3L,9L,7L,0L,8L,0L,8L,9L,5L,1L,0L,7L,1L,3L,2L,1L,4L,1L,3L,1L,3L,6L,5L,6L,8L,7L,6L,6L,7L,6L,8L,5L,4L,9L,4L,1L,8L,1L,6L,1L,7L,9L,4L,0L,0L,7L,6L,3L,0L,6L,7L,6L,6L,0L,9L,0L,8L,9L,5L,6L,1L,0L,4L,5L,3L,4L,4L,6L,1L,1L,1L,9L,8L,7L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011440Inst : IEnumerable<long>
{
public static readonly long[] Value=A011440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011440.Bytes);
public long this[int i]=>Value[i];

public static A011440Inst Instance=new A011440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011441
{
public static readonly long[] Value={ 1L,1L,5L,0L,8L,5L,1L,3L,0L,0L,3L,5L,8L,2L,7L,8L,7L,8L,5L,4L,2L,4L,5L,5L,9L,7L,9L,6L,2L,3L,7L,4L,7L,8L,8L,8L,8L,9L,1L,4L,3L,3L,3L,4L,5L,6L,0L,4L,8L,1L,7L,5L,8L,8L,7L,1L,2L,7L,2L,3L,2L,8L,2L,3L,9L,9L,6L,8L,7L,8L,6L,5L,4L,2L,7L,8L,5L,3L,8L,7L,1L,5L,6L,2L,4L,3L,2L,2L,6L,4L,3L,6L,1L,9L,5L,3L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011441Inst : IEnumerable<long>
{
public static readonly long[] Value=A011441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011441.Bytes);
public long this[int i]=>Value[i];

public static A011441Inst Instance=new A011441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011442
{
public static readonly long[] Value={ 1L,1L,4L,6L,0L,5L,5L,2L,5L,8L,2L,2L,3L,4L,8L,4L,1L,8L,0L,3L,3L,1L,4L,3L,6L,9L,4L,4L,4L,7L,8L,2L,5L,9L,8L,1L,8L,2L,9L,2L,4L,0L,1L,7L,2L,5L,1L,9L,4L,5L,7L,4L,8L,4L,6L,3L,4L,7L,4L,1L,9L,7L,2L,5L,1L,2L,9L,6L,9L,0L,2L,0L,0L,0L,1L,1L,7L,2L,1L,3L,4L,0L,5L,8L,7L,0L,6L,6L,2L,7L,7L,7L,7L,6L,3L,4L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011442Inst : IEnumerable<long>
{
public static readonly long[] Value=A011442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011442.Bytes);
public long this[int i]=>Value[i];

public static A011442Inst Instance=new A011442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011443
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,8L,6L,4L,4L,0L,6L,3L,2L,1L,6L,3L,4L,2L,4L,4L,6L,0L,8L,2L,9L,3L,6L,5L,1L,9L,7L,2L,7L,7L,6L,7L,6L,1L,6L,0L,8L,5L,1L,6L,8L,3L,2L,0L,5L,5L,4L,1L,4L,6L,9L,1L,1L,6L,8L,3L,1L,0L,3L,8L,7L,0L,5L,8L,0L,3L,7L,6L,1L,6L,5L,9L,9L,5L,3L,2L,5L,8L,9L,1L,2L,4L,8L,4L,3L,4L,4L,6L,5L,0L,9L,6L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011443Inst : IEnumerable<long>
{
public static readonly long[] Value=A011443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011443.Bytes);
public long this[int i]=>Value[i];

public static A011443Inst Instance=new A011443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011444
{
public static readonly long[] Value={ 1L,1L,3L,7L,4L,1L,1L,4L,6L,1L,7L,5L,6L,0L,2L,8L,7L,1L,7L,7L,9L,9L,3L,6L,3L,3L,6L,0L,5L,8L,9L,5L,7L,6L,4L,6L,6L,5L,6L,0L,8L,6L,4L,4L,4L,8L,3L,3L,1L,8L,7L,9L,4L,5L,4L,9L,1L,2L,0L,9L,7L,0L,5L,5L,4L,1L,1L,1L,6L,5L,0L,2L,0L,7L,5L,3L,2L,6L,8L,2L,7L,5L,0L,4L,1L,4L,1L,8L,6L,8L,6L,5L,6L,8L,7L,8L,5L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011444Inst : IEnumerable<long>
{
public static readonly long[] Value=A011444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011444.Bytes);
public long this[int i]=>Value[i];

public static A011444Inst Instance=new A011444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011445
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,0L,1L,3L,7L,6L,4L,5L,8L,7L,0L,7L,7L,5L,3L,4L,2L,0L,5L,7L,3L,3L,5L,0L,4L,8L,1L,1L,7L,0L,4L,5L,9L,2L,1L,7L,7L,3L,2L,0L,2L,3L,2L,4L,9L,0L,9L,4L,8L,7L,4L,0L,2L,4L,2L,2L,8L,7L,4L,0L,7L,9L,9L,7L,0L,2L,9L,2L,4L,1L,8L,2L,8L,7L,3L,7L,8L,9L,6L,9L,5L,8L,6L,9L,0L,6L,2L,9L,5L,7L,0L,5L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011445Inst : IEnumerable<long>
{
public static readonly long[] Value=A011445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011445.Bytes);
public long this[int i]=>Value[i];

public static A011445Inst Instance=new A011445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011446
{
public static readonly long[] Value={ 1L,1L,2L,9L,8L,3L,0L,9L,6L,3L,9L,0L,9L,7L,5L,3L,0L,3L,2L,6L,1L,2L,1L,6L,6L,1L,0L,4L,2L,8L,2L,8L,4L,1L,8L,7L,4L,4L,8L,4L,0L,0L,3L,8L,9L,3L,8L,3L,6L,8L,4L,9L,6L,2L,9L,8L,9L,3L,1L,5L,1L,2L,0L,1L,5L,4L,1L,1L,0L,6L,0L,3L,3L,6L,8L,1L,2L,0L,0L,7L,9L,5L,4L,7L,2L,3L,7L,2L,0L,0L,0L,2L,6L,5L,8L,5L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011446Inst : IEnumerable<long>
{
public static readonly long[] Value=A011446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011446.Bytes);
public long this[int i]=>Value[i];

public static A011446Inst Instance=new A011446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011447
{
public static readonly long[] Value={ 1L,1L,2L,6L,3L,7L,8L,1L,4L,5L,2L,5L,0L,8L,7L,3L,6L,7L,4L,9L,8L,3L,1L,7L,0L,3L,6L,0L,7L,0L,0L,6L,8L,7L,5L,0L,3L,9L,7L,3L,0L,0L,9L,9L,5L,6L,9L,7L,9L,0L,2L,8L,2L,9L,4L,7L,0L,2L,9L,9L,5L,3L,3L,2L,3L,5L,5L,0L,6L,8L,2L,4L,3L,9L,0L,2L,1L,1L,5L,5L,2L,1L,0L,7L,7L,4L,4L,5L,5L,3L,9L,3L,7L,5L,8L,3L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011447Inst : IEnumerable<long>
{
public static readonly long[] Value=A011447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011447.Bytes);
public long this[int i]=>Value[i];

public static A011447Inst Instance=new A011447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011448
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,5L,0L,7L,0L,9L,1L,7L,9L,4L,0L,8L,9L,0L,0L,2L,7L,8L,4L,4L,6L,5L,5L,6L,6L,8L,7L,1L,7L,8L,8L,8L,3L,9L,2L,5L,3L,8L,8L,3L,3L,7L,0L,4L,1L,7L,0L,7L,8L,2L,9L,3L,3L,9L,5L,4L,2L,7L,6L,4L,1L,5L,7L,4L,8L,4L,9L,3L,9L,1L,1L,7L,9L,0L,2L,9L,4L,7L,1L,9L,4L,1L,0L,1L,9L,0L,5L,6L,4L,3L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011448Inst : IEnumerable<long>
{
public static readonly long[] Value=A011448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011448.Bytes);
public long this[int i]=>Value[i];

public static A011448Inst Instance=new A011448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011449
{
public static readonly long[] Value={ 1L,1L,2L,0L,0L,4L,9L,9L,0L,9L,1L,5L,0L,1L,9L,6L,5L,2L,8L,8L,5L,6L,3L,8L,1L,8L,3L,0L,6L,0L,6L,6L,9L,3L,1L,8L,1L,9L,8L,8L,3L,4L,3L,3L,0L,4L,7L,4L,6L,8L,9L,2L,6L,2L,2L,0L,2L,5L,5L,5L,9L,7L,8L,8L,0L,1L,9L,9L,1L,3L,9L,1L,3L,0L,2L,9L,1L,2L,3L,1L,8L,1L,5L,4L,3L,3L,0L,2L,0L,1L,8L,4L,6L,0L,4L,9L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011449Inst : IEnumerable<long>
{
public static readonly long[] Value=A011449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011449.Bytes);
public long this[int i]=>Value[i];

public static A011449Inst Instance=new A011449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011450
{
public static readonly long[] Value={ 1L,1L,1L,7L,1L,4L,2L,1L,5L,9L,2L,5L,0L,4L,5L,6L,2L,0L,4L,6L,4L,5L,5L,7L,1L,8L,0L,8L,6L,1L,8L,9L,5L,5L,8L,0L,8L,5L,9L,0L,8L,9L,3L,8L,9L,0L,2L,1L,5L,8L,0L,3L,8L,8L,6L,1L,2L,1L,2L,4L,5L,5L,8L,1L,1L,6L,5L,6L,1L,7L,1L,2L,0L,5L,2L,5L,1L,3L,7L,5L,6L,2L,2L,0L,5L,3L,8L,9L,0L,3L,4L,1L,5L,9L,6L,6L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011450Inst : IEnumerable<long>
{
public static readonly long[] Value=A011450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011450.Bytes);
public long this[int i]=>Value[i];

public static A011450Inst Instance=new A011450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011451
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,8L,6L,7L,4L,2L,5L,9L,5L,8L,9L,2L,5L,3L,6L,3L,0L,8L,8L,1L,2L,9L,5L,6L,9L,1L,9L,6L,0L,3L,0L,6L,7L,8L,0L,0L,4L,5L,7L,3L,3L,5L,4L,8L,4L,3L,6L,8L,8L,3L,8L,5L,0L,9L,4L,4L,1L,0L,7L,0L,2L,2L,6L,2L,6L,0L,5L,6L,3L,9L,3L,9L,7L,5L,5L,7L,7L,4L,4L,5L,7L,6L,0L,2L,3L,2L,8L,4L,6L,7L,9L,0L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011451Inst : IEnumerable<long>
{
public static readonly long[] Value=A011451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011451.Bytes);
public long this[int i]=>Value[i];

public static A011451Inst Instance=new A011451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011452
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,7L,1L,5L,9L,5L,0L,4L,3L,2L,0L,8L,7L,4L,5L,6L,1L,0L,5L,4L,8L,4L,1L,5L,8L,1L,9L,6L,0L,2L,6L,2L,7L,8L,9L,1L,8L,0L,2L,1L,3L,6L,2L,8L,1L,9L,6L,7L,1L,4L,2L,5L,6L,4L,6L,8L,2L,2L,6L,0L,6L,8L,5L,1L,3L,7L,7L,8L,6L,2L,1L,2L,7L,6L,7L,1L,6L,7L,1L,0L,4L,3L,5L,3L,6L,6L,5L,7L,0L,6L,3L,3L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011452Inst : IEnumerable<long>
{
public static readonly long[] Value=A011452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011452.Bytes);
public long this[int i]=>Value[i];

public static A011452Inst Instance=new A011452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011453
{
public static readonly long[] Value={ 1L,1L,0L,9L,2L,8L,5L,9L,1L,2L,2L,6L,3L,0L,4L,3L,0L,8L,2L,2L,2L,3L,9L,5L,8L,3L,0L,3L,3L,6L,1L,6L,8L,7L,7L,6L,1L,3L,9L,1L,4L,4L,5L,7L,4L,4L,1L,9L,5L,3L,0L,9L,4L,7L,7L,1L,8L,7L,2L,5L,4L,1L,4L,1L,3L,6L,7L,9L,4L,4L,7L,9L,8L,6L,3L,9L,6L,9L,6L,3L,9L,5L,9L,2L,2L,5L,9L,6L,4L,1L,6L,5L,2L,8L,2L,1L,3L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011453Inst : IEnumerable<long>
{
public static readonly long[] Value=A011453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011453.Bytes);
public long this[int i]=>Value[i];

public static A011453Inst Instance=new A011453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011486
{
public static readonly long[] Value={ 1L,0L,6L,4L,7L,6L,7L,6L,4L,9L,9L,0L,9L,0L,5L,1L,9L,1L,1L,0L,6L,3L,4L,9L,6L,8L,0L,7L,9L,9L,0L,8L,4L,3L,2L,4L,3L,0L,3L,1L,2L,3L,4L,1L,4L,4L,6L,7L,7L,3L,2L,3L,4L,6L,8L,6L,1L,5L,7L,5L,3L,9L,1L,9L,0L,9L,0L,5L,3L,8L,2L,9L,9L,8L,6L,6L,3L,3L,5L,9L,6L,3L,5L,2L,4L,3L,8L,0L,8L,9L,9L,9L,5L,9L,9L,5L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011486Inst : IEnumerable<long>
{
public static readonly long[] Value=A011486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011486.Bytes);
public long this[int i]=>Value[i];

public static A011486Inst Instance=new A011486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011487
{
public static readonly long[] Value={ 1L,0L,6L,4L,0L,1L,7L,2L,2L,9L,4L,7L,0L,4L,2L,6L,3L,8L,9L,9L,7L,7L,9L,0L,6L,6L,0L,6L,5L,1L,0L,7L,9L,4L,0L,2L,1L,3L,8L,7L,9L,0L,7L,2L,2L,6L,2L,7L,3L,9L,1L,2L,7L,6L,0L,8L,8L,5L,0L,8L,3L,6L,4L,8L,5L,4L,6L,7L,7L,9L,4L,9L,4L,3L,9L,4L,4L,7L,2L,1L,9L,5L,8L,1L,0L,8L,3L,2L,8L,9L,3L,7L,6L,0L,5L,2L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011487Inst : IEnumerable<long>
{
public static readonly long[] Value=A011487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011487.Bytes);
public long this[int i]=>Value[i];

public static A011487Inst Instance=new A011487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011488
{
public static readonly long[] Value={ 1L,0L,6L,3L,2L,8L,5L,7L,3L,3L,4L,9L,1L,8L,5L,1L,9L,5L,8L,3L,2L,4L,9L,6L,3L,1L,2L,2L,9L,2L,7L,4L,1L,6L,1L,7L,8L,6L,8L,1L,7L,0L,6L,0L,4L,3L,8L,5L,6L,7L,5L,2L,7L,9L,0L,0L,1L,5L,0L,2L,2L,7L,6L,7L,1L,0L,2L,2L,5L,9L,0L,9L,0L,1L,3L,7L,0L,3L,6L,1L,1L,2L,3L,8L,1L,9L,7L,3L,8L,6L,3L,2L,1L,8L,7L,7L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011488Inst : IEnumerable<long>
{
public static readonly long[] Value=A011488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011488.Bytes);
public long this[int i]=>Value[i];

public static A011488Inst Instance=new A011488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011489
{
public static readonly long[] Value={ 1L,0L,6L,2L,5L,7L,2L,4L,3L,0L,2L,8L,4L,0L,9L,2L,4L,5L,8L,0L,4L,2L,7L,2L,6L,5L,5L,8L,4L,9L,6L,6L,0L,3L,4L,5L,2L,9L,6L,7L,7L,7L,3L,0L,0L,1L,6L,9L,4L,0L,7L,4L,7L,4L,9L,1L,1L,9L,2L,0L,4L,6L,1L,5L,2L,1L,1L,9L,7L,7L,4L,8L,9L,4L,2L,4L,8L,0L,4L,2L,5L,4L,6L,2L,4L,9L,5L,0L,2L,7L,3L,7L,4L,0L,6L,2L,0L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011489Inst : IEnumerable<long>
{
public static readonly long[] Value=A011489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011489.Bytes);
public long this[int i]=>Value[i];

public static A011489Inst Instance=new A011489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011490
{
public static readonly long[] Value={ 1L,0L,6L,1L,8L,7L,6L,6L,2L,6L,0L,5L,3L,6L,1L,9L,5L,6L,2L,0L,6L,1L,1L,6L,8L,8L,2L,5L,9L,0L,9L,8L,5L,2L,6L,4L,4L,6L,3L,7L,2L,4L,6L,2L,7L,2L,0L,5L,0L,1L,7L,1L,3L,0L,5L,5L,2L,0L,2L,7L,0L,5L,9L,5L,7L,7L,6L,7L,7L,0L,6L,8L,3L,7L,4L,7L,8L,3L,1L,1L,7L,5L,4L,4L,1L,9L,4L,3L,8L,7L,6L,2L,8L,8L,0L,2L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011490Inst : IEnumerable<long>
{
public static readonly long[] Value=A011490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011490.Bytes);
public long this[int i]=>Value[i];

public static A011490Inst Instance=new A011490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011491
{
public static readonly long[] Value={ 1L,0L,6L,1L,1L,9L,7L,6L,6L,2L,4L,5L,5L,3L,5L,5L,6L,8L,1L,2L,1L,6L,5L,1L,2L,2L,0L,5L,4L,6L,4L,1L,6L,8L,3L,9L,1L,9L,7L,8L,8L,1L,0L,3L,6L,8L,1L,4L,8L,3L,1L,1L,5L,5L,8L,8L,3L,3L,9L,5L,9L,9L,8L,9L,7L,9L,7L,0L,8L,8L,1L,6L,3L,9L,5L,1L,0L,4L,1L,3L,2L,1L,2L,1L,6L,7L,3L,5L,0L,6L,8L,8L,4L,4L,7L,6L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011491Inst : IEnumerable<long>
{
public static readonly long[] Value=A011491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011491.Bytes);
public long this[int i]=>Value[i];

public static A011491Inst Instance=new A011491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011492
{
public static readonly long[] Value={ 1L,0L,6L,0L,5L,3L,4L,9L,1L,4L,3L,3L,3L,9L,0L,9L,6L,8L,3L,6L,9L,9L,5L,2L,2L,5L,1L,2L,3L,1L,2L,2L,6L,9L,1L,5L,0L,2L,1L,0L,8L,5L,9L,5L,0L,1L,5L,8L,4L,9L,0L,9L,4L,7L,9L,6L,1L,9L,7L,9L,0L,0L,7L,4L,3L,2L,4L,6L,0L,3L,6L,0L,4L,2L,3L,1L,9L,7L,4L,4L,3L,7L,8L,4L,1L,7L,7L,7L,1L,8L,2L,2L,7L,4L,6L,4L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011492Inst : IEnumerable<long>
{
public static readonly long[] Value=A011492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011492.Bytes);
public long this[int i]=>Value[i];

public static A011492Inst Instance=new A011492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011493
{
public static readonly long[] Value={ 1L,0L,5L,9L,8L,8L,7L,7L,8L,7L,6L,3L,6L,5L,0L,5L,4L,2L,0L,9L,3L,0L,6L,4L,1L,0L,7L,8L,7L,1L,2L,0L,8L,8L,2L,8L,5L,0L,9L,6L,8L,6L,4L,1L,6L,7L,7L,2L,5L,9L,1L,9L,4L,8L,1L,2L,7L,4L,8L,7L,1L,0L,8L,2L,0L,8L,5L,9L,9L,6L,0L,9L,2L,5L,3L,9L,1L,3L,3L,2L,8L,1L,6L,9L,1L,2L,6L,2L,4L,2L,7L,3L,4L,9L,9L,4L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011493Inst : IEnumerable<long>
{
public static readonly long[] Value=A011493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011493.Bytes);
public long this[int i]=>Value[i];

public static A011493Inst Instance=new A011493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011494
{
public static readonly long[] Value={ 1L,0L,5L,9L,2L,5L,5L,7L,1L,7L,4L,8L,2L,4L,9L,8L,2L,7L,0L,3L,3L,3L,6L,4L,0L,0L,4L,9L,8L,1L,5L,0L,1L,4L,4L,7L,4L,6L,0L,5L,6L,0L,3L,3L,1L,1L,6L,6L,3L,9L,0L,3L,3L,8L,0L,9L,9L,7L,2L,7L,4L,9L,1L,8L,9L,6L,5L,5L,8L,1L,4L,6L,1L,6L,2L,9L,1L,3L,2L,5L,4L,3L,6L,0L,4L,8L,3L,7L,6L,1L,1L,6L,4L,1L,6L,4L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011494Inst : IEnumerable<long>
{
public static readonly long[] Value=A011494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011494.Bytes);
public long this[int i]=>Value[i];

public static A011494Inst Instance=new A011494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011495
{
public static readonly long[] Value={ 1L,0L,5L,8L,6L,3L,8L,1L,6L,6L,3L,7L,5L,8L,7L,9L,6L,3L,9L,2L,8L,0L,8L,5L,7L,0L,6L,9L,0L,3L,2L,3L,8L,1L,9L,0L,4L,3L,5L,4L,8L,7L,3L,8L,1L,5L,4L,2L,8L,5L,1L,3L,7L,9L,5L,6L,2L,5L,6L,1L,5L,2L,5L,3L,0L,1L,6L,2L,9L,6L,6L,1L,1L,0L,4L,0L,8L,7L,4L,4L,3L,6L,0L,0L,7L,8L,7L,9L,3L,3L,2L,9L,7L,5L,0L,5L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011495Inst : IEnumerable<long>
{
public static readonly long[] Value=A011495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011495.Bytes);
public long this[int i]=>Value[i];

public static A011495Inst Instance=new A011495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011496
{
public static readonly long[] Value={ 1L,0L,5L,8L,0L,3L,4L,6L,2L,2L,5L,4L,8L,5L,0L,7L,1L,5L,3L,1L,3L,4L,8L,5L,1L,2L,7L,0L,8L,7L,5L,4L,0L,3L,8L,0L,0L,9L,8L,2L,8L,3L,0L,0L,7L,4L,1L,8L,1L,6L,1L,1L,8L,6L,3L,9L,8L,1L,1L,9L,9L,7L,2L,1L,8L,5L,8L,5L,2L,8L,0L,5L,1L,8L,2L,5L,2L,6L,2L,1L,9L,5L,2L,8L,3L,9L,1L,2L,3L,1L,6L,8L,7L,6L,6L,8L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011496Inst : IEnumerable<long>
{
public static readonly long[] Value=A011496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011496.Bytes);
public long this[int i]=>Value[i];

public static A011496Inst Instance=new A011496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011497
{
public static readonly long[] Value={ 1L,0L,5L,7L,4L,4L,4L,5L,9L,8L,4L,2L,2L,9L,8L,9L,4L,4L,0L,0L,6L,7L,6L,2L,1L,2L,4L,4L,2L,5L,4L,8L,4L,3L,9L,3L,1L,9L,8L,7L,7L,5L,8L,7L,8L,9L,1L,5L,4L,3L,9L,1L,7L,6L,3L,0L,5L,0L,1L,1L,3L,6L,9L,0L,4L,4L,1L,6L,5L,1L,6L,7L,9L,4L,0L,5L,8L,0L,4L,6L,0L,7L,6L,8L,0L,0L,3L,6L,9L,4L,2L,4L,3L,8L,5L,8L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011497Inst : IEnumerable<long>
{
public static readonly long[] Value=A011497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011497.Bytes);
public long this[int i]=>Value[i];

public static A011497Inst Instance=new A011497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011498
{
public static readonly long[] Value={ 1L,0L,5L,6L,8L,6L,7L,6L,2L,9L,1L,8L,5L,2L,1L,6L,6L,8L,9L,2L,6L,7L,3L,3L,3L,5L,2L,6L,3L,3L,4L,7L,0L,2L,1L,3L,2L,7L,4L,1L,6L,1L,7L,8L,8L,3L,9L,0L,2L,2L,2L,9L,0L,3L,2L,1L,9L,0L,5L,1L,7L,4L,0L,9L,9L,4L,0L,5L,0L,4L,7L,8L,8L,1L,2L,1L,4L,5L,2L,6L,9L,8L,9L,1L,8L,6L,7L,3L,3L,9L,4L,8L,6L,3L,1L,6L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011498Inst : IEnumerable<long>
{
public static readonly long[] Value=A011498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011498.Bytes);
public long this[int i]=>Value[i];

public static A011498Inst Instance=new A011498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011499
{
public static readonly long[] Value={ 1L,0L,5L,6L,3L,0L,3L,2L,7L,1L,4L,5L,7L,4L,7L,6L,8L,4L,4L,1L,9L,4L,0L,5L,0L,0L,0L,1L,0L,2L,8L,9L,8L,2L,2L,3L,3L,4L,0L,6L,9L,2L,2L,4L,8L,3L,1L,8L,2L,6L,0L,2L,4L,2L,5L,6L,6L,5L,8L,7L,4L,8L,1L,2L,3L,1L,0L,8L,9L,0L,8L,4L,8L,8L,7L,4L,7L,5L,5L,8L,1L,3L,2L,4L,0L,8L,7L,2L,0L,4L,2L,2L,5L,9L,5L,4L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011499Inst : IEnumerable<long>
{
public static readonly long[] Value=A011499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011499.Bytes);
public long this[int i]=>Value[i];

public static A011499Inst Instance=new A011499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011500
{
public static readonly long[] Value={ 1L,0L,5L,5L,7L,5L,1L,1L,0L,2L,0L,6L,3L,9L,4L,5L,7L,5L,7L,2L,5L,3L,0L,4L,9L,2L,1L,3L,4L,3L,3L,3L,0L,2L,9L,5L,1L,2L,6L,8L,3L,2L,8L,7L,9L,2L,7L,7L,0L,5L,6L,9L,4L,6L,3L,3L,4L,3L,0L,0L,6L,9L,7L,0L,7L,6L,7L,7L,0L,8L,0L,1L,8L,9L,8L,2L,2L,5L,3L,2L,6L,2L,6L,8L,3L,5L,9L,0L,1L,9L,2L,0L,5L,4L,8L,2L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011500Inst : IEnumerable<long>
{
public static readonly long[] Value=A011500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011500.Bytes);
public long this[int i]=>Value[i];

public static A011500Inst Instance=new A011500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011501
{
public static readonly long[] Value={ 1L,0L,5L,5L,2L,1L,0L,7L,1L,6L,8L,8L,1L,0L,9L,9L,5L,2L,4L,7L,5L,9L,9L,0L,7L,3L,8L,9L,8L,9L,3L,4L,0L,7L,3L,0L,9L,4L,3L,9L,5L,2L,0L,7L,1L,3L,7L,4L,9L,7L,0L,0L,1L,7L,8L,0L,5L,1L,3L,1L,9L,3L,1L,6L,2L,8L,9L,3L,4L,0L,2L,4L,1L,0L,2L,2L,0L,7L,6L,2L,9L,4L,5L,5L,5L,0L,4L,7L,6L,4L,6L,9L,7L,6L,0L,0L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011501Inst : IEnumerable<long>
{
public static readonly long[] Value=A011501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011501.Bytes);
public long this[int i]=>Value[i];

public static A011501Inst Instance=new A011501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011534
{
public static readonly long[] Value={ 4L,14L,24L,34L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,54L,64L,74L,84L,94L,104L,114L,124L,134L,140L,141L,142L,143L,144L,145L,146L,147L,148L,149L,154L,164L,174L,184L,194L,204L,214L,224L,234L,240L,241L,242L,243L,244L,245L,246L,247L,248L,249L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011534Inst : IEnumerable<long>
{
public static readonly long[] Value=A011534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011534.Bytes);
public long this[int i]=>Value[i];

public static A011534Inst Instance=new A011534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011535
{
public static readonly long[] Value={ 5L,15L,25L,35L,45L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,65L,75L,85L,95L,105L,115L,125L,135L,145L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,165L,175L,185L,195L,205L,215L,225L,235L,245L,250L,251L,252L,253L,254L,255L,256L,257L,258L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011535Inst : IEnumerable<long>
{
public static readonly long[] Value=A011535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011535.Bytes);
public long this[int i]=>Value[i];

public static A011535Inst Instance=new A011535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011536
{
public static readonly long[] Value={ 6L,16L,26L,36L,46L,56L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,76L,86L,96L,106L,116L,126L,136L,146L,156L,160L,161L,162L,163L,164L,165L,166L,167L,168L,169L,176L,186L,196L,206L,216L,226L,236L,246L,256L,260L,261L,262L,263L,264L,265L,266L,267L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011536Inst : IEnumerable<long>
{
public static readonly long[] Value=A011536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011536.Bytes);
public long this[int i]=>Value[i];

public static A011536Inst Instance=new A011536Inst();

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