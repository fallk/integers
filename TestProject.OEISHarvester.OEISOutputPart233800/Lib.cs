using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A010465
{
public static readonly long[] Value={ 2L,6L,4L,5L,7L,5L,1L,3L,1L,1L,0L,6L,4L,5L,9L,0L,5L,9L,0L,5L,0L,1L,6L,1L,5L,7L,5L,3L,6L,3L,9L,2L,6L,0L,4L,2L,5L,7L,1L,0L,2L,5L,9L,1L,8L,3L,0L,8L,2L,4L,5L,0L,1L,8L,0L,3L,6L,8L,3L,3L,4L,4L,5L,9L,2L,0L,1L,0L,6L,8L,8L,2L,3L,2L,3L,0L,2L,8L,3L,6L,2L,7L,7L,6L,0L,3L,9L,2L,8L,8L,6L,4L,7L,4L,5L,4L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010465Inst : IEnumerable<long>
{
public static readonly long[] Value=A010465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010465.Bytes);
public long this[int i]=>Value[i];

public static A010465Inst Instance=new A010465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010466
{
public static readonly long[] Value={ 2L,8L,2L,8L,4L,2L,7L,1L,2L,4L,7L,4L,6L,1L,9L,0L,0L,9L,7L,6L,0L,3L,3L,7L,7L,4L,4L,8L,4L,1L,9L,3L,9L,6L,1L,5L,7L,1L,3L,9L,3L,4L,3L,7L,5L,0L,7L,5L,3L,8L,9L,6L,1L,4L,6L,3L,5L,3L,3L,5L,9L,4L,7L,5L,9L,8L,1L,4L,6L,4L,9L,5L,6L,9L,2L,4L,2L,1L,4L,0L,7L,7L,7L,0L,0L,7L,7L,5L,0L,6L,8L,6L,5L,5L,2L,8L,3L,1L,4L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010466Inst : IEnumerable<long>
{
public static readonly long[] Value=A010466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010466.Bytes);
public long this[int i]=>Value[i];

public static A010466Inst Instance=new A010466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010467
{
public static readonly long[] Value={ 3L,1L,6L,2L,2L,7L,7L,6L,6L,0L,1L,6L,8L,3L,7L,9L,3L,3L,1L,9L,9L,8L,8L,9L,3L,5L,4L,4L,4L,3L,2L,7L,1L,8L,5L,3L,3L,7L,1L,9L,5L,5L,5L,1L,3L,9L,3L,2L,5L,2L,1L,6L,8L,2L,6L,8L,5L,7L,5L,0L,4L,8L,5L,2L,7L,9L,2L,5L,9L,4L,4L,3L,8L,6L,3L,9L,2L,3L,8L,2L,2L,1L,3L,4L,4L,2L,4L,8L,1L,0L,8L,3L,7L,9L,3L,0L,0L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010467Inst : IEnumerable<long>
{
public static readonly long[] Value=A010467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010467.Bytes);
public long this[int i]=>Value[i];

public static A010467Inst Instance=new A010467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010468
{
public static readonly long[] Value={ 3L,3L,1L,6L,6L,2L,4L,7L,9L,0L,3L,5L,5L,3L,9L,9L,8L,4L,9L,1L,1L,4L,9L,3L,2L,7L,3L,6L,6L,7L,0L,6L,8L,6L,6L,8L,3L,9L,2L,7L,0L,8L,8L,5L,4L,5L,5L,8L,9L,3L,5L,3L,5L,9L,7L,0L,5L,8L,6L,8L,2L,1L,4L,6L,1L,1L,6L,4L,8L,4L,6L,4L,2L,6L,0L,9L,0L,4L,3L,8L,4L,6L,7L,0L,8L,8L,4L,3L,3L,9L,9L,1L,2L,8L,2L,9L,0L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010468Inst : IEnumerable<long>
{
public static readonly long[] Value=A010468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010468.Bytes);
public long this[int i]=>Value[i];

public static A010468Inst Instance=new A010468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010469
{
public static readonly long[] Value={ 3L,4L,6L,4L,1L,0L,1L,6L,1L,5L,1L,3L,7L,7L,5L,4L,5L,8L,7L,0L,5L,4L,8L,9L,2L,6L,8L,3L,0L,1L,1L,7L,4L,4L,7L,3L,3L,8L,8L,5L,6L,1L,0L,5L,0L,7L,6L,2L,0L,7L,6L,1L,2L,5L,6L,1L,1L,1L,6L,1L,3L,9L,5L,8L,9L,0L,3L,8L,6L,6L,0L,3L,3L,8L,1L,7L,6L,0L,0L,0L,7L,4L,1L,6L,2L,2L,9L,2L,3L,7L,3L,5L,1L,4L,4L,9L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010469Inst : IEnumerable<long>
{
public static readonly long[] Value=A010469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010469.Bytes);
public long this[int i]=>Value[i];

public static A010469Inst Instance=new A010469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010470
{
public static readonly long[] Value={ 3L,6L,0L,5L,5L,5L,1L,2L,7L,5L,4L,6L,3L,9L,8L,9L,2L,9L,3L,1L,1L,9L,2L,2L,1L,2L,6L,7L,4L,7L,0L,4L,9L,5L,9L,4L,6L,2L,5L,1L,2L,9L,6L,5L,7L,3L,8L,4L,5L,2L,4L,6L,2L,1L,2L,7L,1L,0L,4L,5L,3L,0L,5L,6L,2L,2L,7L,1L,6L,6L,9L,4L,8L,2L,9L,3L,0L,1L,0L,4L,4L,5L,2L,0L,4L,6L,1L,9L,0L,8L,2L,0L,1L,8L,4L,9L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010470Inst : IEnumerable<long>
{
public static readonly long[] Value=A010470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010470.Bytes);
public long this[int i]=>Value[i];

public static A010470Inst Instance=new A010470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010471
{
public static readonly long[] Value={ 3L,7L,4L,1L,6L,5L,7L,3L,8L,6L,7L,7L,3L,9L,4L,1L,3L,8L,5L,5L,8L,3L,7L,4L,8L,7L,3L,2L,3L,1L,6L,5L,4L,9L,3L,0L,1L,7L,5L,6L,0L,1L,9L,8L,0L,7L,7L,7L,8L,7L,2L,6L,9L,4L,6L,3L,0L,3L,7L,4L,5L,4L,6L,7L,3L,2L,0L,0L,3L,5L,1L,5L,6L,3L,0L,6L,9L,3L,9L,0L,2L,7L,9L,7L,6L,8L,0L,9L,8L,9L,5L,1L,9L,4L,3L,7L,9L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010471Inst : IEnumerable<long>
{
public static readonly long[] Value=A010471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010471.Bytes);
public long this[int i]=>Value[i];

public static A010471Inst Instance=new A010471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010472
{
public static readonly long[] Value={ 3L,8L,7L,2L,9L,8L,3L,3L,4L,6L,2L,0L,7L,4L,1L,6L,8L,8L,5L,1L,7L,9L,2L,6L,5L,3L,9L,9L,7L,8L,2L,3L,9L,9L,6L,1L,0L,8L,3L,2L,9L,2L,1L,7L,0L,5L,2L,9L,1L,5L,9L,0L,8L,2L,6L,5L,8L,7L,5L,7L,3L,7L,6L,6L,1L,1L,3L,4L,8L,3L,0L,9L,1L,9L,3L,6L,9L,7L,9L,0L,3L,3L,5L,1L,9L,2L,8L,7L,3L,7L,6L,8L,5L,8L,6L,7L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010472Inst : IEnumerable<long>
{
public static readonly long[] Value=A010472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010472.Bytes);
public long this[int i]=>Value[i];

public static A010472Inst Instance=new A010472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010473
{
public static readonly long[] Value={ 4L,1L,2L,3L,1L,0L,5L,6L,2L,5L,6L,1L,7L,6L,6L,0L,5L,4L,9L,8L,2L,1L,4L,0L,9L,8L,5L,5L,9L,7L,4L,0L,7L,7L,0L,2L,5L,1L,4L,7L,1L,9L,9L,2L,2L,5L,3L,7L,3L,6L,2L,0L,4L,3L,4L,3L,9L,8L,6L,3L,3L,5L,7L,3L,0L,9L,4L,9L,5L,4L,3L,4L,6L,3L,3L,7L,6L,2L,1L,5L,9L,3L,5L,8L,7L,8L,6L,3L,6L,5L,0L,8L,1L,0L,6L,8L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010473Inst : IEnumerable<long>
{
public static readonly long[] Value=A010473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010473.Bytes);
public long this[int i]=>Value[i];

public static A010473Inst Instance=new A010473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010474
{
public static readonly long[] Value={ 4L,2L,4L,2L,6L,4L,0L,6L,8L,7L,1L,1L,9L,2L,8L,5L,1L,4L,6L,4L,0L,5L,0L,6L,6L,1L,7L,2L,6L,2L,9L,0L,9L,4L,2L,3L,5L,7L,0L,9L,0L,1L,5L,6L,2L,6L,1L,3L,0L,8L,4L,4L,2L,1L,9L,5L,3L,0L,0L,3L,9L,2L,1L,3L,9L,7L,2L,1L,9L,7L,4L,3L,5L,3L,8L,6L,3L,2L,1L,1L,1L,6L,5L,5L,1L,1L,6L,2L,6L,0L,2L,9L,8L,2L,9L,2L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010474Inst : IEnumerable<long>
{
public static readonly long[] Value=A010474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010474.Bytes);
public long this[int i]=>Value[i];

public static A010474Inst Instance=new A010474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010475
{
public static readonly long[] Value={ 4L,3L,5L,8L,8L,9L,8L,9L,4L,3L,5L,4L,0L,6L,7L,3L,5L,5L,2L,2L,3L,6L,9L,8L,1L,9L,8L,3L,8L,5L,9L,6L,1L,5L,6L,5L,9L,1L,3L,7L,0L,0L,3L,9L,2L,5L,2L,3L,2L,4L,4L,4L,9L,3L,6L,8L,9L,0L,3L,4L,4L,1L,3L,8L,1L,5L,9L,5L,5L,7L,3L,2L,8L,2L,0L,3L,1L,5L,8L,0L,8L,5L,6L,5L,6L,1L,5L,9L,1L,5L,5L,8L,5L,1L,9L,4L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010475Inst : IEnumerable<long>
{
public static readonly long[] Value=A010475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010475.Bytes);
public long this[int i]=>Value[i];

public static A010475Inst Instance=new A010475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010476
{
public static readonly long[] Value={ 4L,4L,7L,2L,1L,3L,5L,9L,5L,4L,9L,9L,9L,5L,7L,9L,3L,9L,2L,8L,1L,8L,3L,4L,7L,3L,3L,7L,4L,6L,2L,5L,5L,2L,4L,7L,0L,8L,8L,1L,2L,3L,6L,7L,1L,9L,2L,2L,3L,0L,5L,1L,4L,4L,8L,5L,4L,1L,7L,9L,4L,4L,9L,0L,8L,2L,1L,0L,4L,1L,8L,5L,1L,2L,7L,5L,6L,0L,9L,7L,9L,8L,8L,2L,8L,8L,2L,8L,8L,1L,6L,7L,5L,7L,5L,6L,4L,5L,4L,9L,9L,3L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010476Inst : IEnumerable<long>
{
public static readonly long[] Value=A010476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010476.Bytes);
public long this[int i]=>Value[i];

public static A010476Inst Instance=new A010476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010477
{
public static readonly long[] Value={ 4L,5L,8L,2L,5L,7L,5L,6L,9L,4L,9L,5L,5L,8L,4L,0L,0L,0L,6L,5L,8L,8L,0L,4L,7L,1L,9L,3L,7L,2L,8L,0L,0L,8L,4L,8L,8L,9L,8L,4L,4L,5L,6L,5L,7L,6L,7L,6L,7L,9L,7L,1L,9L,0L,2L,6L,0L,7L,2L,4L,2L,1L,2L,3L,9L,0L,6L,8L,6L,8L,4L,2L,5L,5L,4L,7L,7L,7L,0L,8L,8L,6L,6L,0L,4L,3L,6L,1L,5L,5L,9L,4L,9L,3L,4L,4L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010477Inst : IEnumerable<long>
{
public static readonly long[] Value=A010477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010477.Bytes);
public long this[int i]=>Value[i];

public static A010477Inst Instance=new A010477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010526
{
public static readonly long[] Value={ 8L,6L,0L,2L,3L,2L,5L,2L,6L,7L,0L,4L,2L,6L,2L,6L,7L,7L,1L,7L,2L,9L,4L,7L,3L,5L,3L,5L,0L,4L,9L,7L,1L,3L,6L,3L,2L,0L,2L,7L,5L,3L,5L,5L,5L,7L,2L,9L,0L,7L,3L,5L,6L,1L,9L,5L,0L,8L,0L,4L,5L,6L,4L,1L,2L,3L,7L,4L,2L,6L,9L,3L,4L,6L,6L,3L,0L,1L,7L,0L,1L,2L,7L,8L,3L,3L,3L,0L,8L,9L,0L,6L,9L,8L,9L,6L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010526Inst : IEnumerable<long>
{
public static readonly long[] Value=A010526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010526.Bytes);
public long this[int i]=>Value[i];

public static A010526Inst Instance=new A010526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010527
{
public static readonly long[] Value={ 8L,6L,6L,0L,2L,5L,4L,0L,3L,7L,8L,4L,4L,3L,8L,6L,4L,6L,7L,6L,3L,7L,2L,3L,1L,7L,0L,7L,5L,2L,9L,3L,6L,1L,8L,3L,4L,7L,1L,4L,0L,2L,6L,2L,6L,9L,0L,5L,1L,9L,0L,3L,1L,4L,0L,2L,7L,9L,0L,3L,4L,8L,9L,7L,2L,5L,9L,6L,6L,5L,0L,8L,4L,5L,4L,4L,0L,0L,0L,1L,8L,5L,4L,0L,5L,7L,3L,0L,9L,3L,3L,7L,8L,6L,2L,4L,2L,8L,7L,8L,3L,7L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010527Inst : IEnumerable<long>
{
public static readonly long[] Value=A010527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010527.Bytes);
public long this[int i]=>Value[i];

public static A010527Inst Instance=new A010527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010528
{
public static readonly long[] Value={ 8L,7L,1L,7L,7L,9L,7L,8L,8L,7L,0L,8L,1L,3L,4L,7L,1L,0L,4L,4L,7L,3L,9L,6L,3L,9L,6L,7L,7L,1L,9L,2L,3L,1L,3L,1L,8L,2L,7L,4L,0L,0L,7L,8L,5L,0L,4L,6L,4L,8L,8L,9L,8L,7L,3L,7L,8L,0L,6L,8L,8L,2L,7L,6L,3L,1L,9L,1L,1L,4L,6L,5L,6L,4L,0L,6L,3L,1L,6L,1L,7L,1L,3L,1L,2L,3L,1L,8L,3L,1L,1L,7L,0L,3L,8L,8L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010528Inst : IEnumerable<long>
{
public static readonly long[] Value=A010528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010528.Bytes);
public long this[int i]=>Value[i];

public static A010528Inst Instance=new A010528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010529
{
public static readonly long[] Value={ 8L,7L,7L,4L,9L,6L,4L,3L,8L,7L,3L,9L,2L,1L,2L,2L,0L,6L,0L,4L,0L,6L,3L,8L,8L,3L,0L,7L,4L,1L,6L,3L,0L,9L,5L,6L,0L,8L,7L,5L,8L,7L,6L,8L,2L,7L,5L,5L,4L,5L,0L,3L,5L,9L,0L,9L,2L,7L,6L,9L,5L,6L,2L,9L,7L,8L,2L,7L,6L,4L,6L,4L,6L,2L,1L,9L,3L,0L,6L,2L,8L,1L,6L,7L,5L,6L,9L,3L,1L,5L,7L,0L,6L,8L,7L,0L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010529Inst : IEnumerable<long>
{
public static readonly long[] Value=A010529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010529.Bytes);
public long this[int i]=>Value[i];

public static A010529Inst Instance=new A010529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010530
{
public static readonly long[] Value={ 8L,8L,3L,1L,7L,6L,0L,8L,6L,6L,3L,2L,7L,8L,4L,6L,8L,5L,4L,7L,6L,4L,0L,4L,2L,7L,2L,6L,9L,5L,9L,2L,5L,3L,9L,6L,4L,1L,7L,4L,6L,3L,9L,4L,8L,0L,9L,3L,1L,4L,1L,7L,8L,2L,6L,2L,1L,0L,2L,0L,2L,9L,7L,2L,5L,5L,7L,1L,3L,9L,9L,3L,8L,2L,3L,5L,4L,4L,2L,8L,4L,0L,3L,7L,0L,4L,3L,5L,5L,3L,9L,4L,1L,4L,7L,7L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010530Inst : IEnumerable<long>
{
public static readonly long[] Value=A010530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010530.Bytes);
public long this[int i]=>Value[i];

public static A010530Inst Instance=new A010530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010531
{
public static readonly long[] Value={ 8L,8L,8L,8L,1L,9L,4L,4L,1L,7L,3L,1L,5L,5L,8L,8L,8L,5L,0L,0L,9L,1L,4L,4L,1L,6L,7L,5L,4L,0L,8L,7L,2L,7L,8L,1L,7L,0L,7L,6L,4L,5L,0L,6L,0L,3L,7L,2L,9L,5L,2L,6L,2L,9L,8L,3L,5L,4L,7L,2L,0L,1L,1L,6L,3L,7L,6L,1L,0L,0L,5L,9L,9L,6L,2L,8L,5L,9L,9L,5L,9L,6L,0L,2L,3L,5L,9L,2L,9L,5L,2L,7L,1L,3L,6L,3L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010531Inst : IEnumerable<long>
{
public static readonly long[] Value=A010531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010531.Bytes);
public long this[int i]=>Value[i];

public static A010531Inst Instance=new A010531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010532
{
public static readonly long[] Value={ 8L,9L,4L,4L,2L,7L,1L,9L,0L,9L,9L,9L,9L,1L,5L,8L,7L,8L,5L,6L,3L,6L,6L,9L,4L,6L,7L,4L,9L,2L,5L,1L,0L,4L,9L,4L,1L,7L,6L,2L,4L,7L,3L,4L,3L,8L,4L,4L,6L,1L,0L,2L,8L,9L,7L,0L,8L,3L,5L,8L,8L,9L,8L,1L,6L,4L,2L,0L,8L,3L,7L,0L,2L,5L,5L,1L,2L,1L,9L,5L,9L,7L,6L,5L,7L,6L,5L,7L,6L,3L,3L,5L,1L,5L,1L,2L,9L,0L,9L,9L,8L,7L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010532Inst : IEnumerable<long>
{
public static readonly long[] Value=A010532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010532.Bytes);
public long this[int i]=>Value[i];

public static A010532Inst Instance=new A010532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010533
{
public static readonly long[] Value={ 9L,0L,5L,5L,3L,8L,5L,1L,3L,8L,1L,3L,7L,4L,1L,6L,6L,2L,6L,5L,7L,3L,8L,0L,8L,1L,6L,6L,9L,8L,4L,0L,6L,6L,4L,1L,3L,0L,5L,2L,1L,2L,4L,4L,6L,4L,0L,9L,6L,9L,4L,0L,2L,7L,6L,5L,8L,1L,7L,4L,1L,2L,3L,0L,0L,1L,8L,6L,5L,7L,9L,8L,0L,7L,6L,6L,0L,5L,9L,2L,3L,3L,3L,8L,4L,9L,6L,0L,6L,7L,8L,5L,9L,0L,9L,9L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010533Inst : IEnumerable<long>
{
public static readonly long[] Value=A010533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010533.Bytes);
public long this[int i]=>Value[i];

public static A010533Inst Instance=new A010533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010534
{
public static readonly long[] Value={ 9L,1L,1L,0L,4L,3L,3L,5L,7L,9L,1L,4L,4L,2L,9L,8L,8L,8L,1L,9L,4L,5L,6L,2L,6L,1L,0L,4L,6L,8L,8L,6L,6L,9L,1L,9L,0L,0L,9L,9L,1L,3L,9L,1L,6L,8L,2L,6L,4L,9L,5L,5L,8L,5L,2L,4L,9L,6L,9L,3L,8L,4L,6L,5L,0L,6L,6L,0L,2L,1L,1L,9L,4L,2L,8L,3L,4L,0L,5L,6L,6L,5L,5L,8L,5L,3L,4L,1L,4L,6L,0L,9L,2L,9L,1L,7L,7L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010534Inst : IEnumerable<long>
{
public static readonly long[] Value=A010534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010534.Bytes);
public long this[int i]=>Value[i];

public static A010534Inst Instance=new A010534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010535
{
public static readonly long[] Value={ 9L,1L,6L,5L,1L,5L,1L,3L,8L,9L,9L,1L,1L,6L,8L,0L,0L,1L,3L,1L,7L,6L,0L,9L,4L,3L,8L,7L,4L,5L,6L,0L,1L,6L,9L,7L,7L,9L,6L,8L,9L,1L,3L,1L,5L,3L,5L,3L,5L,9L,4L,3L,8L,0L,5L,2L,1L,4L,4L,8L,4L,2L,4L,7L,8L,1L,3L,7L,3L,6L,8L,5L,1L,0L,9L,5L,5L,4L,1L,7L,7L,3L,2L,0L,8L,7L,2L,3L,1L,1L,8L,9L,8L,6L,8L,9L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010535Inst : IEnumerable<long>
{
public static readonly long[] Value=A010535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010535.Bytes);
public long this[int i]=>Value[i];

public static A010535Inst Instance=new A010535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010536
{
public static readonly long[] Value={ 9L,2L,1L,9L,5L,4L,4L,4L,5L,7L,2L,9L,2L,8L,8L,7L,3L,1L,0L,0L,0L,2L,2L,7L,4L,2L,8L,1L,7L,6L,2L,7L,9L,3L,1L,5L,7L,2L,4L,6L,8L,0L,5L,0L,4L,8L,7L,2L,2L,4L,6L,4L,0L,0L,8L,0L,0L,7L,7L,5L,2L,2L,0L,5L,4L,4L,2L,6L,7L,1L,0L,2L,6L,8L,0L,1L,8L,7L,5L,4L,6L,0L,7L,6L,7L,8L,9L,4L,0L,9L,0L,7L,9L,3L,2L,8L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010536Inst : IEnumerable<long>
{
public static readonly long[] Value=A010536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010536.Bytes);
public long this[int i]=>Value[i];

public static A010536Inst Instance=new A010536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010537
{
public static readonly long[] Value={ 9L,2L,7L,3L,6L,1L,8L,4L,9L,5L,4L,9L,5L,7L,0L,3L,7L,5L,2L,5L,1L,6L,4L,1L,6L,0L,7L,3L,9L,9L,0L,1L,7L,4L,6L,2L,6L,2L,6L,3L,4L,6L,8L,9L,1L,2L,0L,7L,6L,2L,9L,8L,2L,1L,3L,3L,7L,3L,8L,2L,6L,5L,9L,8L,3L,2L,8L,2L,3L,6L,8L,3L,6L,4L,6L,3L,8L,4L,3L,0L,2L,3L,2L,3L,2L,0L,4L,5L,8L,5L,7L,3L,5L,8L,4L,7L,4L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010537Inst : IEnumerable<long>
{
public static readonly long[] Value=A010537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010537.Bytes);
public long this[int i]=>Value[i];

public static A010537Inst Instance=new A010537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010538
{
public static readonly long[] Value={ 9L,3L,2L,7L,3L,7L,9L,0L,5L,3L,0L,8L,8L,8L,1L,5L,0L,4L,5L,5L,5L,4L,4L,7L,5L,5L,4L,2L,3L,2L,0L,5L,5L,6L,9L,8L,3L,2L,7L,6L,2L,4L,0L,6L,9L,4L,1L,9L,1L,6L,5L,4L,6L,7L,1L,0L,5L,6L,1L,9L,7L,2L,9L,8L,4L,4L,6L,7L,8L,4L,5L,4L,8L,8L,0L,7L,2L,4L,9L,6L,7L,8L,4L,1L,4L,2L,2L,0L,5L,6L,2L,9L,1L,1L,8L,8L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010538Inst : IEnumerable<long>
{
public static readonly long[] Value=A010538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010538.Bytes);
public long this[int i]=>Value[i];

public static A010538Inst Instance=new A010538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010539
{
public static readonly long[] Value={ 9L,3L,8L,0L,8L,3L,1L,5L,1L,9L,6L,4L,6L,8L,5L,9L,1L,0L,9L,1L,3L,1L,2L,6L,0L,2L,2L,7L,0L,8L,8L,9L,3L,2L,5L,6L,1L,1L,7L,6L,4L,5L,6L,7L,0L,6L,8L,2L,3L,4L,7L,4L,3L,0L,7L,2L,1L,1L,4L,0L,3L,7L,8L,2L,0L,3L,4L,0L,4L,9L,2L,6L,5L,5L,0L,6L,4L,7L,9L,4L,4L,2L,9L,6L,4L,2L,3L,1L,1L,9L,2L,1L,2L,3L,0L,8L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010539Inst : IEnumerable<long>
{
public static readonly long[] Value=A010539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010539.Bytes);
public long this[int i]=>Value[i];

public static A010539Inst Instance=new A010539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010540
{
public static readonly long[] Value={ 9L,4L,3L,3L,9L,8L,1L,1L,3L,2L,0L,5L,6L,6L,0L,3L,8L,1L,1L,3L,2L,0L,6L,6L,0L,3L,7L,7L,6L,2L,2L,6L,4L,0L,7L,1L,6L,9L,8L,3L,6L,2L,2L,6L,3L,3L,4L,1L,5L,1L,2L,1L,3L,2L,0L,6L,6L,2L,9L,8L,1L,4L,4L,8L,9L,8L,0L,0L,2L,2L,9L,0L,9L,5L,8L,5L,1L,1L,8L,0L,5L,8L,5L,4L,1L,0L,2L,6L,9L,8L,6L,8L,9L,0L,3L,8L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010540Inst : IEnumerable<long>
{
public static readonly long[] Value=A010540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010540.Bytes);
public long this[int i]=>Value[i];

public static A010540Inst Instance=new A010540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010541
{
public static readonly long[] Value={ 9L,4L,8L,6L,8L,3L,2L,9L,8L,0L,5L,0L,5L,1L,3L,7L,9L,9L,5L,9L,9L,6L,6L,8L,0L,6L,3L,3L,2L,9L,8L,1L,5L,5L,6L,0L,1L,1L,5L,8L,6L,6L,5L,4L,1L,7L,9L,7L,5L,6L,5L,0L,4L,8L,0L,5L,7L,2L,5L,1L,4L,5L,5L,8L,3L,7L,7L,7L,8L,3L,3L,1L,5L,9L,1L,7L,7L,1L,4L,6L,6L,4L,0L,3L,2L,7L,4L,4L,3L,2L,5L,1L,3L,7L,9L,0L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010541Inst : IEnumerable<long>
{
public static readonly long[] Value=A010541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010541.Bytes);
public long this[int i]=>Value[i];

public static A010541Inst Instance=new A010541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010574
{
public static readonly long[] Value={ 6L,60L,2040L,104040L,6487020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010574Inst : IEnumerable<long>
{
public static readonly long[] Value=A010574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010574.Bytes);
public long this[int i]=>Value[i];

public static A010574Inst Instance=new A010574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010575
{
public static readonly long[] Value={ 1L,8L,56L,392L,2696L,18584L,127160L,871256L,5946200L,40613816L,276750536L,1886784200L,12843449288L,87456597656L,594876193016L,4047352264616L,27514497698984L,187083712725224L,1271271096363128L,8639846411760440L,58689235680164600L,398715967140863864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010575Inst : IEnumerable<long>
{
public static readonly long[] Value=A010575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010575.Bytes);
public long this[int i]=>Value[i];

public static A010575Inst Instance=new A010575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010576
{
public static readonly ulong[] Value={ 1L,10L,90L,810L,7210L,64250L,570330L,5065530L,44906970L,398227610L,3527691690L,31255491850L,276741169130L,2450591960890L,21690684337690L,192003889675210L,1699056192681930L,15035937610909770L,133030135015071770L,1177032340670878170L,10412322608416261050UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010576Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A010576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010576.Bytes);
public ulong this[int i]=>Value[i];

public static A010576Inst Instance=new A010576Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010577
{
public static readonly BigInteger[] Value={ 1L,12L,132L,1452L,15852L,173172L,1887492L,20578452L,224138292L,2441606532L,26583605772L,289455960492L,3150796704012L,34298615880372L,373292253262692L,4062873240668412L,44214072776280252L,481167126859845852L,5235893033922430692L,BigInteger.Parse("56975931806991140292"),BigInteger.Parse("619957835069070600132"),BigInteger.Parse("6745858105534183489092") };
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
public class A010577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010577Inst Instance=new A010577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010578
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010578Inst : IEnumerable<long>
{
public static readonly long[] Value=A010578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010578.Bytes);
public long this[int i]=>Value[i];

public static A010578Inst Instance=new A010578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010579
{
public static readonly long[] Value={ 1L,10L,90L,810L,7210L,64170L,568970L,5044810L,44649930L,395180650L,3494051130L,30893156970L,272971707930L,2411975074570L,21302972395370L,188151452434090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010579Inst : IEnumerable<long>
{
public static readonly long[] Value=A010579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010579.Bytes);
public long this[int i]=>Value[i];

public static A010579Inst Instance=new A010579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010580
{
public static readonly long[] Value={ 1L,12L,132L,1452L,15852L,173052L,1884972L,20532252L,223437852L,2431526492L,26447593812L,287669976492L,3128064123732L,34013987172972L,369792173040492L,4020299656610636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010580Inst : IEnumerable<long>
{
public static readonly long[] Value=A010580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010580.Bytes);
public long this[int i]=>Value[i];

public static A010580Inst Instance=new A010580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010581
{
public static readonly long[] Value={ 2L,0L,8L,0L,0L,8L,3L,8L,2L,3L,0L,5L,1L,9L,0L,4L,1L,1L,4L,5L,3L,0L,0L,5L,6L,8L,2L,4L,3L,5L,7L,8L,8L,5L,3L,8L,6L,3L,3L,7L,8L,0L,5L,3L,4L,0L,3L,7L,3L,2L,6L,2L,1L,0L,9L,6L,9L,7L,5L,9L,1L,0L,8L,0L,2L,0L,0L,1L,0L,6L,3L,1L,1L,3L,9L,7L,2L,6L,8L,7L,7L,3L,6L,0L,6L,0L,5L,6L,6L,3L,6L,7L,9L,0L,7L,5L,7L,4L,8L,6L,7L,2L,8L,6L,7L,1L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010581Inst : IEnumerable<long>
{
public static readonly long[] Value=A010581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010581.Bytes);
public long this[int i]=>Value[i];

public static A010581Inst Instance=new A010581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010582
{
public static readonly long[] Value={ 2L,1L,5L,4L,4L,3L,4L,6L,9L,0L,0L,3L,1L,8L,8L,3L,7L,2L,1L,7L,5L,9L,2L,9L,3L,5L,6L,6L,5L,1L,9L,3L,5L,0L,4L,9L,5L,2L,5L,9L,3L,4L,4L,9L,4L,2L,1L,9L,2L,1L,0L,8L,5L,8L,2L,4L,8L,9L,2L,3L,5L,5L,0L,6L,3L,4L,6L,4L,1L,1L,1L,0L,6L,6L,4L,8L,3L,4L,0L,8L,0L,0L,1L,8L,5L,4L,4L,1L,5L,0L,3L,5L,4L,3L,2L,4L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010582Inst : IEnumerable<long>
{
public static readonly long[] Value=A010582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010582.Bytes);
public long this[int i]=>Value[i];

public static A010582Inst Instance=new A010582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010583
{
public static readonly long[] Value={ 2L,2L,2L,3L,9L,8L,0L,0L,9L,0L,5L,6L,9L,3L,1L,5L,5L,2L,1L,1L,6L,5L,3L,6L,3L,3L,7L,6L,7L,2L,2L,1L,5L,7L,1L,9L,6L,5L,1L,8L,6L,9L,9L,1L,2L,8L,0L,9L,6L,9L,2L,3L,0L,5L,5L,6L,9L,9L,3L,4L,5L,8L,0L,8L,6L,6L,0L,4L,0L,0L,9L,8L,3L,0L,8L,2L,9L,7L,5L,9L,7L,4L,4L,8L,9L,7L,5L,8L,0L,5L,4L,4L,8L,1L,6L,2L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010583Inst : IEnumerable<long>
{
public static readonly long[] Value=A010583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010583.Bytes);
public long this[int i]=>Value[i];

public static A010583Inst Instance=new A010583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010584
{
public static readonly long[] Value={ 2L,2L,8L,9L,4L,2L,8L,4L,8L,5L,1L,0L,6L,6L,6L,3L,7L,3L,5L,6L,1L,6L,0L,8L,4L,4L,2L,3L,8L,7L,9L,3L,5L,4L,0L,1L,7L,8L,3L,1L,8L,1L,3L,8L,4L,1L,5L,7L,5L,8L,6L,2L,1L,4L,4L,1L,9L,8L,1L,0L,4L,3L,4L,8L,1L,3L,1L,3L,4L,8L,5L,9L,8L,0L,4L,8L,4L,2L,8L,3L,0L,0L,8L,7L,5L,2L,1L,6L,3L,2L,2L,0L,6L,1L,8L,3L,4L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010584Inst : IEnumerable<long>
{
public static readonly long[] Value=A010584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010584.Bytes);
public long this[int i]=>Value[i];

public static A010584Inst Instance=new A010584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010585
{
public static readonly long[] Value={ 2L,3L,5L,1L,3L,3L,4L,6L,8L,7L,7L,2L,0L,7L,5L,7L,4L,8L,9L,5L,0L,0L,0L,1L,6L,3L,3L,9L,9L,5L,6L,9L,1L,4L,5L,2L,6L,9L,1L,5L,8L,4L,1L,9L,8L,3L,4L,6L,2L,1L,7L,5L,1L,0L,5L,0L,4L,0L,2L,5L,4L,3L,1L,1L,5L,8L,8L,3L,4L,2L,6L,8L,0L,9L,9L,6L,5L,6L,6L,8L,4L,9L,8L,0L,7L,9L,1L,1L,6L,0L,4L,2L,0L,2L,8L,4L,4L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010585Inst : IEnumerable<long>
{
public static readonly long[] Value=A010585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010585.Bytes);
public long this[int i]=>Value[i];

public static A010585Inst Instance=new A010585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010586
{
public static readonly long[] Value={ 2L,4L,1L,0L,1L,4L,2L,2L,6L,4L,1L,7L,5L,2L,2L,9L,9L,8L,6L,1L,2L,8L,3L,6L,9L,6L,6L,7L,6L,0L,3L,2L,7L,2L,8L,9L,5L,3L,5L,4L,5L,8L,1L,2L,8L,9L,9L,8L,0L,8L,6L,7L,6L,5L,4L,1L,6L,4L,1L,3L,9L,7L,1L,0L,4L,1L,3L,2L,9L,1L,7L,2L,6L,9L,2L,2L,5L,9L,3L,8L,3L,3L,8L,2L,2L,6L,1L,1L,5L,1L,6L,2L,2L,6L,8L,1L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010586Inst : IEnumerable<long>
{
public static readonly long[] Value=A010586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010586.Bytes);
public long this[int i]=>Value[i];

public static A010586Inst Instance=new A010586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010587
{
public static readonly long[] Value={ 2L,4L,6L,6L,2L,1L,2L,0L,7L,4L,3L,3L,0L,4L,7L,0L,1L,0L,1L,4L,9L,1L,6L,1L,1L,3L,2L,3L,1L,5L,4L,5L,8L,9L,0L,4L,2L,7L,3L,5L,4L,8L,4L,4L,8L,6L,6L,2L,8L,0L,5L,3L,7L,6L,0L,1L,7L,8L,7L,8L,7L,4L,1L,0L,2L,9L,3L,3L,7L,6L,9L,5L,2L,9L,2L,2L,8L,9L,7L,4L,6L,3L,2L,1L,6L,2L,9L,8L,7L,0L,2L,6L,6L,4L,3L,4L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010587Inst : IEnumerable<long>
{
public static readonly long[] Value=A010587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010587.Bytes);
public long this[int i]=>Value[i];

public static A010587Inst Instance=new A010587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010588
{
public static readonly long[] Value={ 2L,5L,1L,9L,8L,4L,2L,0L,9L,9L,7L,8L,9L,7L,4L,6L,3L,2L,9L,5L,3L,4L,4L,2L,1L,2L,1L,4L,5L,5L,6L,4L,5L,6L,7L,0L,1L,1L,4L,0L,5L,0L,2L,9L,2L,9L,4L,0L,3L,0L,1L,5L,9L,6L,0L,1L,6L,3L,9L,5L,0L,2L,2L,4L,3L,1L,0L,5L,9L,9L,3L,5L,3L,0L,2L,7L,9L,1L,8L,9L,6L,7L,4L,5L,8L,7L,9L,3L,1L,2L,4L,8L,7L,2L,5L,1L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010588Inst : IEnumerable<long>
{
public static readonly long[] Value=A010588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010588.Bytes);
public long this[int i]=>Value[i];

public static A010588Inst Instance=new A010588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010589
{
public static readonly long[] Value={ 2L,5L,7L,1L,2L,8L,1L,5L,9L,0L,6L,5L,8L,2L,3L,5L,3L,5L,5L,4L,5L,3L,1L,8L,7L,2L,0L,8L,7L,3L,9L,7L,2L,6L,1L,1L,6L,4L,2L,7L,9L,0L,1L,6L,3L,2L,4L,5L,4L,6L,9L,6L,2L,5L,9L,8L,4L,8L,0L,2L,2L,3L,7L,6L,2L,1L,9L,9L,3L,9L,9L,3L,3L,0L,3L,0L,6L,7L,0L,1L,5L,0L,3L,2L,4L,3L,5L,1L,5L,3L,0L,4L,4L,5L,6L,5L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010589Inst : IEnumerable<long>
{
public static readonly long[] Value=A010589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010589.Bytes);
public long this[int i]=>Value[i];

public static A010589Inst Instance=new A010589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010670
{
public static readonly long[] Value={ 4L,6L,4L,1L,5L,8L,8L,8L,3L,3L,6L,1L,2L,7L,7L,8L,8L,9L,2L,4L,1L,0L,0L,7L,6L,3L,5L,0L,9L,1L,9L,4L,4L,6L,5L,7L,6L,5L,5L,1L,3L,4L,9L,1L,2L,5L,0L,1L,1L,2L,4L,3L,6L,3L,7L,6L,5L,0L,6L,9L,2L,8L,5L,8L,6L,8L,4L,7L,7L,7L,8L,6L,9L,6L,9L,2L,8L,4L,4L,8L,2L,6L,1L,8L,9L,9L,5L,9L,0L,7L,0L,8L,9L,7L,5L,7L,1L,3L,7L,9L,8L,4L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010670Inst : IEnumerable<long>
{
public static readonly long[] Value=A010670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010670.Bytes);
public long this[int i]=>Value[i];

public static A010670Inst Instance=new A010670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010671
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010671Inst : IEnumerable<long>
{
public static readonly long[] Value=A010671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010671.Bytes);
public long this[int i]=>Value[i];

public static A010671Inst Instance=new A010671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010672
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,12L,20L,29L,38L,52L,73L,94L,127L,151L,181L,211L,257L,315L,373L,412L,475L,530L,545L,607L,716L,797L,861L,964L,1059L,1160L,1306L,1385L,1434L,1555L,1721L,1833L,1933L,2057L,2260L,2496L,2698L,2873L,3060L,3196L,3331L,3628L,3711L,3867L,4139L,4446L,4639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010672Inst : IEnumerable<long>
{
public static readonly long[] Value=A010672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010672.Bytes);
public long this[int i]=>Value[i];

public static A010672Inst Instance=new A010672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010673
{
public static readonly long[] Value={ 0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010673Inst : IEnumerable<long>
{
public static readonly long[] Value=A010673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010673.Bytes);
public long this[int i]=>Value[i];

public static A010673Inst Instance=new A010673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010674
{
public static readonly long[] Value={ 0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010674Inst : IEnumerable<long>
{
public static readonly long[] Value=A010674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010674.Bytes);
public long this[int i]=>Value[i];

public static A010674Inst Instance=new A010674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010675
{
public static readonly long[] Value={ 0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010675Inst : IEnumerable<long>
{
public static readonly long[] Value=A010675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010675.Bytes);
public long this[int i]=>Value[i];

public static A010675Inst Instance=new A010675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010676
{
public static readonly long[] Value={ 0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010676Inst : IEnumerable<long>
{
public static readonly long[] Value=A010676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010676.Bytes);
public long this[int i]=>Value[i];

public static A010676Inst Instance=new A010676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010677
{
public static readonly long[] Value={ 0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010677Inst : IEnumerable<long>
{
public static readonly long[] Value=A010677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010677.Bytes);
public long this[int i]=>Value[i];

public static A010677Inst Instance=new A010677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010678
{
public static readonly long[] Value={ 0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010678Inst : IEnumerable<long>
{
public static readonly long[] Value=A010678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010678.Bytes);
public long this[int i]=>Value[i];

public static A010678Inst Instance=new A010678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010679
{
public static readonly long[] Value={ 0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010679Inst : IEnumerable<long>
{
public static readonly long[] Value=A010679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010679.Bytes);
public long this[int i]=>Value[i];

public static A010679Inst Instance=new A010679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010680
{
public static readonly long[] Value={ 0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010680Inst : IEnumerable<long>
{
public static readonly long[] Value=A010680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010680.Bytes);
public long this[int i]=>Value[i];

public static A010680Inst Instance=new A010680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010681
{
public static readonly long[] Value={ 0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L,0L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010681Inst : IEnumerable<long>
{
public static readonly long[] Value=A010681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010681.Bytes);
public long this[int i]=>Value[i];

public static A010681Inst Instance=new A010681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010682
{
public static readonly long[] Value={ 1L,1L,3L,11L,145L,197L,903L,4279L,20793L,103049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010682Inst : IEnumerable<long>
{
public static readonly long[] Value=A010682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010682.Bytes);
public long this[int i]=>Value[i];

public static A010682Inst Instance=new A010682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010683
{
public static readonly long[] Value={ 1L,2L,7L,28L,121L,550L,2591L,12536L,61921L,310954L,1582791L,8147796L,42344121L,221866446L,1170747519L,6216189936L,33186295681L,178034219986L,959260792775L,5188835909516L,28167068630713L,153395382655222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010683Inst : IEnumerable<long>
{
public static readonly long[] Value=A010683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010683.Bytes);
public long this[int i]=>Value[i];

public static A010683Inst Instance=new A010683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010684
{
public static readonly long[] Value={ 1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010684Inst : IEnumerable<long>
{
public static readonly long[] Value=A010684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010684.Bytes);
public long this[int i]=>Value[i];

public static A010684Inst Instance=new A010684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010685
{
public static readonly long[] Value={ 1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010685Inst : IEnumerable<long>
{
public static readonly long[] Value=A010685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010685.Bytes);
public long this[int i]=>Value[i];

public static A010685Inst Instance=new A010685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010702
{
public static readonly long[] Value={ 3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010702Inst : IEnumerable<long>
{
public static readonly long[] Value=A010702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010702.Bytes);
public long this[int i]=>Value[i];

public static A010702Inst Instance=new A010702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010703
{
public static readonly long[] Value={ 3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010703Inst : IEnumerable<long>
{
public static readonly long[] Value=A010703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010703.Bytes);
public long this[int i]=>Value[i];

public static A010703Inst Instance=new A010703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010704
{
public static readonly long[] Value={ 3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010704Inst : IEnumerable<long>
{
public static readonly long[] Value=A010704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010704.Bytes);
public long this[int i]=>Value[i];

public static A010704Inst Instance=new A010704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010705
{
public static readonly long[] Value={ 3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010705Inst : IEnumerable<long>
{
public static readonly long[] Value=A010705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010705.Bytes);
public long this[int i]=>Value[i];

public static A010705Inst Instance=new A010705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010706
{
public static readonly long[] Value={ 3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010706Inst : IEnumerable<long>
{
public static readonly long[] Value=A010706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010706.Bytes);
public long this[int i]=>Value[i];

public static A010706Inst Instance=new A010706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010707
{
public static readonly long[] Value={ 3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010707Inst : IEnumerable<long>
{
public static readonly long[] Value=A010707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010707.Bytes);
public long this[int i]=>Value[i];

public static A010707Inst Instance=new A010707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010708
{
public static readonly long[] Value={ 3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010708Inst : IEnumerable<long>
{
public static readonly long[] Value=A010708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010708.Bytes);
public long this[int i]=>Value[i];

public static A010708Inst Instance=new A010708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010709
{
public static readonly long[] Value={ 4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010709Inst : IEnumerable<long>
{
public static readonly long[] Value=A010709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010709.Bytes);
public long this[int i]=>Value[i];

public static A010709Inst Instance=new A010709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010710
{
public static readonly long[] Value={ 4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010710Inst : IEnumerable<long>
{
public static readonly long[] Value=A010710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010710.Bytes);
public long this[int i]=>Value[i];

public static A010710Inst Instance=new A010710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010711
{
public static readonly long[] Value={ 4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010711Inst : IEnumerable<long>
{
public static readonly long[] Value=A010711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010711.Bytes);
public long this[int i]=>Value[i];

public static A010711Inst Instance=new A010711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010712
{
public static readonly long[] Value={ 4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010712Inst : IEnumerable<long>
{
public static readonly long[] Value=A010712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010712.Bytes);
public long this[int i]=>Value[i];

public static A010712Inst Instance=new A010712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010713
{
public static readonly long[] Value={ 4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010713Inst : IEnumerable<long>
{
public static readonly long[] Value=A010713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010713.Bytes);
public long this[int i]=>Value[i];

public static A010713Inst Instance=new A010713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010714
{
public static readonly long[] Value={ 4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010714Inst : IEnumerable<long>
{
public static readonly long[] Value=A010714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010714.Bytes);
public long this[int i]=>Value[i];

public static A010714Inst Instance=new A010714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010715
{
public static readonly long[] Value={ 4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010715Inst : IEnumerable<long>
{
public static readonly long[] Value=A010715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010715.Bytes);
public long this[int i]=>Value[i];

public static A010715Inst Instance=new A010715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010716
{
public static readonly long[] Value={ 5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010716Inst : IEnumerable<long>
{
public static readonly long[] Value=A010716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010716.Bytes);
public long this[int i]=>Value[i];

public static A010716Inst Instance=new A010716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010717
{
public static readonly long[] Value={ 5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010717Inst : IEnumerable<long>
{
public static readonly long[] Value=A010717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010717.Bytes);
public long this[int i]=>Value[i];

public static A010717Inst Instance=new A010717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010782
{
public static readonly long[] Value={ 1L,0L,3L,5L,2L,6L,4L,9L,2L,3L,8L,4L,1L,3L,7L,7L,5L,0L,4L,3L,4L,7L,7L,8L,8L,1L,9L,4L,2L,1L,1L,2L,4L,6L,1L,9L,7L,7L,2L,9L,6L,1L,0L,9L,1L,0L,3L,2L,4L,6L,3L,0L,1L,5L,7L,9L,7L,6L,6L,9L,8L,3L,2L,3L,0L,2L,2L,8L,2L,5L,5L,1L,4L,0L,1L,5L,9L,9L,1L,6L,4L,4L,7L,4L,4L,2L,2L,1L,7L,2L,5L,3L,3L,4L,1L,5L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010782Inst : IEnumerable<long>
{
public static readonly long[] Value=A010782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010782.Bytes);
public long this[int i]=>Value[i];

public static A010782Inst Instance=new A010782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010783
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,1L,2L,4L,1L,1L,1L,2L,5L,1L,1L,1L,2L,3L,6L,1L,1L,1L,1L,2L,3L,7L,1L,1L,1L,1L,2L,2L,4L,8L,1L,1L,1L,1L,1L,2L,3L,4L,9L,1L,1L,1L,1L,1L,2L,2L,3L,5L,10L,1L,1L,1L,1L,1L,1L,2L,2L,3L,5L,11L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,6L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010783Inst : IEnumerable<long>
{
public static readonly long[] Value=A010783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010783.Bytes);
public long this[int i]=>Value[i];

public static A010783Inst Instance=new A010783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010784
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,102L,103L,104L,105L,106L,107L,108L,109L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010784Inst : IEnumerable<long>
{
public static readonly long[] Value=A010784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010784.Bytes);
public long this[int i]=>Value[i];

public static A010784Inst Instance=new A010784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010785
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,111L,222L,333L,444L,555L,666L,777L,888L,999L,1111L,2222L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,11111L,22222L,33333L,44444L,55555L,66666L,77777L,88888L,99999L,111111L,222222L,333333L,444444L,555555L,666666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010785Inst : IEnumerable<long>
{
public static readonly long[] Value=A010785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010785.Bytes);
public long this[int i]=>Value[i];

public static A010785Inst Instance=new A010785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010786
{
public static readonly long[] Value={ 1L,2L,3L,8L,10L,36L,42L,128L,216L,600L,660L,3456L,3744L,9408L,18900L,61440L,65280L,279936L,295488L,1152000L,2116800L,4878720L,5100480L,31850496L,41472000L,93450240L,163762560L,568995840L,589317120L,3265920000L,3374784000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010786Inst : IEnumerable<long>
{
public static readonly long[] Value=A010786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010786.Bytes);
public long this[int i]=>Value[i];

public static A010786Inst Instance=new A010786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010787
{
public static readonly long[] Value={ 1L,1L,2L,6L,25L,135L,913L,7499L,73191L,833597L,10917343L,162402263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010787Inst : IEnumerable<long>
{
public static readonly long[] Value=A010787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010787.Bytes);
public long this[int i]=>Value[i];

public static A010787Inst Instance=new A010787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010788
{
public static readonly BigInteger[] Value={ 0L,-1L,-2L,-1L,148L,7499L,435898L,32241299L,3034190248L,357512009399L,51798976006198L,9074564088169799L,1893681694795266748L,BigInteger.Parse("464586802573524130499"),BigInteger.Parse("132469958743645663494898"),BigInteger.Parse("43458963744363238693849499"),BigInteger.Parse("16258850448552441418587853648"),BigInteger.Parse("6882131151536073693976060834799"),BigInteger.Parse("3272832457519325432770128200645998") };
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
public class A010788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010788Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010788.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010788.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010788Inst Instance=new A010788Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010789
{
public static readonly BigInteger[] Value={ 1L,2L,31L,692L,32821L,2182982L,220761451L,29587628072L,5271224958121L,1181874030353162L,329170919623534231L,BigInteger.Parse("110868894348113861852"),BigInteger.Parse("44548277847630426340381"),BigInteger.Parse("21016319125189602127144142") };
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
public class A010789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010789Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010789.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010789.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010789Inst Instance=new A010789Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010790
{
public static readonly BigInteger[] Value={ 1L,2L,12L,144L,2880L,86400L,3628800L,203212800L,14631321600L,1316818944000L,144850083840000L,19120211066880000L,2982752926433280000L,BigInteger.Parse("542861032610856960000"),BigInteger.Parse("114000816848279961600000"),BigInteger.Parse("27360196043587190784000000"),BigInteger.Parse("7441973323855715893248000000") };
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
public class A010790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010790Inst Instance=new A010790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010791
{
public static readonly BigInteger[] Value={ 1L,3L,24L,360L,8640L,302400L,14515200L,914457600L,73156608000L,7242504192000L,869100503040000L,124281371934720000L,BigInteger.Parse("20879270485032960000"),BigInteger.Parse("4071457744581427200000"),BigInteger.Parse("912006534786239692800000") };
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
public class A010791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010791Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010791.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010791.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010791Inst Instance=new A010791Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010792
{
public static readonly BigInteger[] Value={ 1L,4L,40L,720L,20160L,806400L,43545600L,3048192000L,268240896000L,28970016768000L,3766102179840000L,579979735695360000L,BigInteger.Parse("104396352425164800000"),BigInteger.Parse("21714441304434278400000"),BigInteger.Parse("5168037030455358259200000"),BigInteger.Parse("1395369998222946729984000000"),BigInteger.Parse("424192479459775805915136000000") };
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
public class A010792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010792Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010792.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010792.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010792Inst Instance=new A010792Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010793
{
public static readonly BigInteger[] Value={ 1L,5L,60L,1260L,40320L,1814400L,108864000L,8382528000L,804722688000L,94152554496000L,13181357629440000L,2174924008857600000L,BigInteger.Parse("417585409700659200000"),BigInteger.Parse("92286375543845683200000") };
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
public class A010793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010793Inst Instance=new A010793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010794
{
public static readonly BigInteger[] Value={ 1L,6L,84L,2016L,72576L,3628800L,239500800L,20118067200L,2092278988800L,263627152588800L,39544072888320000L,6959756828344320000L,BigInteger.Parse("1419790392982241280000"),BigInteger.Parse("332230951957844459520000"),BigInteger.Parse("88373433220786626232320000"),BigInteger.Parse("26512029966235987869696000000") };
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
public class A010794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010794Inst Instance=new A010794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010795
{
public static readonly BigInteger[] Value={ 1L,7L,112L,3024L,120960L,6652800L,479001600L,43589145600L,4881984307200L,659067881472000L,105450861035520000L,BigInteger.Parse("19719311013642240000"),BigInteger.Parse("4259371178946723840000"),BigInteger.Parse("1052064681199840788480000") };
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
public class A010795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010795Inst Instance=new A010795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010796
{
public static readonly BigInteger[] Value={ 1L,6L,72L,1440L,43200L,1814400L,101606400L,7315660800L,658409472000L,72425041920000L,9560105533440000L,1491376463216640000L,BigInteger.Parse("271430516305428480000"),BigInteger.Parse("57000408424139980800000"),BigInteger.Parse("13680098021793595392000000"),BigInteger.Parse("3720986661927857946624000000") };
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
public class A010796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010796Inst Instance=new A010796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010797
{
public static readonly BigInteger[] Value={ 1L,24L,1440L,172800L,36288000L,12192768000L,6145155072000L,4424511651840000L,4380266535321600000L,BigInteger.Parse("5781951826624512000000"),BigInteger.Parse("9921829334487662592000000"),BigInteger.Parse("21669275266521055100928000000") };
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
public class A010797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010797Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010797.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010797.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010797Inst Instance=new A010797Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010798
{
public static readonly BigInteger[] Value={ 1L,120L,43200L,36288000L,60963840000L,184354652160000L,929147446886400000L,BigInteger.Parse("7358847779340288000000"),BigInteger.Parse("87423111618562621440000000"),BigInteger.Parse("1500180595374534583910400000000"),BigInteger.Parse("36040338623277818843863449600000000") };
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
public class A010798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010798.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010798Inst Instance=new A010798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010799
{
public static readonly BigInteger[] Value={ 1L,720L,1814400L,12192768000L,184354652160000L,5574884681318400000L,BigInteger.Parse("309071606732292096000000"),BigInteger.Parse("29374165503837040803840000000"),BigInteger.Parse("4536546120412592581745049600000000") };
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
public class A010799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010799Inst Instance=new A010799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010800
{
public static readonly BigInteger[] Value={ 1L,5040L,101606400L,6145155072000L,929147446886400000L,BigInteger.Parse("309071606732292096000000"),BigInteger.Parse("205619158526859285626880000000"),BigInteger.Parse("254046582743105184577722777600000000"),BigInteger.Parse("549289359343832305886569080815616000000000"),BigInteger.Parse("1979419135331434097492840339627153817600000000000") };
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
public class A010800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010800Inst Instance=new A010800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010801
{
public static readonly long[] Value={ 0L,1L,8192L,1594323L,67108864L,1220703125L,13060694016L,96889010407L,549755813888L,2541865828329L,10000000000000L,34522712143931L,106993205379072L,302875106592253L,793714773254144L,1946195068359375L,4503599627370496L,9904578032905937L,20822964865671168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010801Inst : IEnumerable<long>
{
public static readonly long[] Value=A010801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010801.Bytes);
public long this[int i]=>Value[i];

public static A010801Inst Instance=new A010801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010802
{
public static readonly long[] Value={ 0L,1L,16384L,4782969L,268435456L,6103515625L,78364164096L,678223072849L,4398046511104L,22876792454961L,100000000000000L,379749833583241L,1283918464548864L,3937376385699289L,11112006825558016L,29192926025390625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010802Inst : IEnumerable<long>
{
public static readonly long[] Value=A010802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010802.Bytes);
public long this[int i]=>Value[i];

public static A010802Inst Instance=new A010802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010803
{
public static readonly long[] Value={ 0L,1L,32768L,14348907L,1073741824L,30517578125L,470184984576L,4747561509943L,35184372088832L,205891132094649L,1000000000000000L,4177248169415651L,15407021574586368L,51185893014090757L,155568095557812224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010803Inst : IEnumerable<long>
{
public static readonly long[] Value=A010803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010803.Bytes);
public long this[int i]=>Value[i];

public static A010803Inst Instance=new A010803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010804
{
public static readonly long[] Value={ 0L,1L,65536L,43046721L,4294967296L,152587890625L,2821109907456L,33232930569601L,281474976710656L,1853020188851841L,10000000000000000L,45949729863572161L,184884258895036416L,665416609183179841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010804Inst : IEnumerable<long>
{
public static readonly long[] Value=A010804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010804.Bytes);
public long this[int i]=>Value[i];

public static A010804Inst Instance=new A010804Inst();

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