using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021553
{
public static readonly long[] Value={ 0L,0L,1L,8L,2L,1L,4L,9L,3L,6L,2L,4L,7L,7L,2L,3L,1L,3L,2L,9L,6L,9L,0L,3L,4L,6L,0L,8L,3L,7L,8L,8L,7L,0L,6L,7L,3L,9L,5L,2L,6L,4L,1L,1L,6L,5L,7L,5L,5L,9L,1L,9L,8L,5L,4L,2L,8L,0L,5L,1L,0L,0L,1L,8L,2L,1L,4L,9L,3L,6L,2L,4L,7L,7L,2L,3L,1L,3L,2L,9L,6L,9L,0L,3L,4L,6L,0L,8L,3L,7L,8L,8L,7L,0L,6L,7L,3L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021553Inst : IEnumerable<long>
{
public static readonly long[] Value=A021553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021553.Bytes);
public long this[int i]=>Value[i];

public static A021553Inst Instance=new A021553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021552
{
public static readonly long[] Value={ 0L,0L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L,8L,2L,4L,8L,1L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021552Inst : IEnumerable<long>
{
public static readonly long[] Value=A021552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021552.Bytes);
public long this[int i]=>Value[i];

public static A021552Inst Instance=new A021552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021551
{
public static readonly long[] Value={ 0L,0L,1L,8L,2L,8L,1L,5L,3L,5L,6L,4L,8L,9L,9L,4L,5L,1L,5L,5L,3L,9L,3L,0L,5L,3L,0L,1L,6L,4L,5L,3L,3L,8L,2L,0L,8L,4L,0L,9L,5L,0L,6L,3L,9L,8L,5L,3L,7L,4L,7L,7L,1L,4L,8L,0L,8L,0L,4L,3L,8L,7L,5L,6L,8L,5L,5L,5L,7L,5L,8L,6L,8L,3L,7L,2L,9L,4L,3L,3L,2L,7L,2L,3L,9L,4L,8L,8L,1L,1L,7L,0L,0L,1L,8L,2L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021551Inst : IEnumerable<long>
{
public static readonly long[] Value=A021551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021551.Bytes);
public long this[int i]=>Value[i];

public static A021551Inst Instance=new A021551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021550
{
public static readonly long[] Value={ 0L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L,8L,3L,1L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021550Inst : IEnumerable<long>
{
public static readonly long[] Value=A021550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021550.Bytes);
public long this[int i]=>Value[i];

public static A021550Inst Instance=new A021550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021533
{
public static readonly long[] Value={ 0L,0L,1L,8L,9L,0L,3L,5L,9L,1L,6L,8L,2L,4L,1L,9L,6L,5L,9L,7L,3L,5L,3L,4L,9L,7L,1L,6L,4L,4L,6L,1L,2L,4L,7L,6L,3L,7L,0L,5L,1L,0L,3L,9L,6L,9L,7L,5L,4L,2L,5L,3L,3L,0L,8L,1L,2L,8L,5L,4L,4L,4L,2L,3L,4L,4L,0L,4L,5L,3L,6L,8L,6L,2L,0L,0L,3L,7L,8L,0L,7L,1L,8L,3L,3L,6L,4L,8L,3L,9L,3L,1L,9L,4L,7L,0L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021533Inst : IEnumerable<long>
{
public static readonly long[] Value=A021533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021533.Bytes);
public long this[int i]=>Value[i];

public static A021533Inst Instance=new A021533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021532
{
public static readonly long[] Value={ 0L,0L,1L,8L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021532Inst : IEnumerable<long>
{
public static readonly long[] Value=A021532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021532.Bytes);
public long this[int i]=>Value[i];

public static A021532Inst Instance=new A021532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021531
{
public static readonly long[] Value={ 0L,0L,1L,8L,9L,7L,5L,3L,3L,2L,0L,6L,8L,3L,1L,1L,1L,9L,5L,4L,4L,5L,9L,2L,0L,3L,0L,3L,6L,0L,5L,3L,1L,3L,0L,9L,2L,9L,7L,9L,1L,2L,7L,1L,3L,4L,7L,2L,4L,8L,5L,7L,6L,8L,5L,0L,0L,9L,4L,8L,7L,6L,6L,6L,0L,3L,4L,1L,5L,5L,5L,9L,7L,7L,2L,2L,9L,6L,0L,1L,5L,1L,8L,0L,2L,6L,5L,6L,5L,4L,6L,4L,8L,9L,5L,6L,3L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021531Inst : IEnumerable<long>
{
public static readonly long[] Value=A021531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021531.Bytes);
public long this[int i]=>Value[i];

public static A021531Inst Instance=new A021531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021530
{
public static readonly long[] Value={ 0L,0L,1L,9L,0L,1L,1L,4L,0L,6L,8L,4L,4L,1L,0L,6L,4L,6L,3L,8L,7L,8L,3L,2L,6L,9L,9L,6L,1L,9L,7L,7L,1L,8L,6L,3L,1L,1L,7L,8L,7L,0L,7L,2L,2L,4L,3L,3L,4L,6L,0L,0L,7L,6L,0L,4L,5L,6L,2L,7L,3L,7L,6L,4L,2L,5L,8L,5L,5L,5L,1L,3L,3L,0L,7L,9L,8L,4L,7L,9L,0L,8L,7L,4L,5L,2L,4L,7L,1L,4L,8L,2L,8L,8L,9L,7L,3L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021530Inst : IEnumerable<long>
{
public static readonly long[] Value=A021530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021530.Bytes);
public long this[int i]=>Value[i];

public static A021530Inst Instance=new A021530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021529
{
public static readonly long[] Value={ 0L,0L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021529Inst : IEnumerable<long>
{
public static readonly long[] Value=A021529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021529.Bytes);
public long this[int i]=>Value[i];

public static A021529Inst Instance=new A021529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021528
{
public static readonly long[] Value={ 0L,0L,1L,9L,0L,8L,3L,9L,6L,9L,4L,6L,5L,6L,4L,8L,8L,5L,4L,9L,6L,1L,8L,3L,2L,0L,6L,1L,0L,6L,8L,7L,0L,2L,2L,9L,0L,0L,7L,6L,3L,3L,5L,8L,7L,7L,8L,6L,2L,5L,9L,5L,4L,1L,9L,8L,4L,7L,3L,2L,8L,2L,4L,4L,2L,7L,4L,8L,0L,9L,1L,6L,0L,3L,0L,5L,3L,4L,3L,5L,1L,1L,4L,5L,0L,3L,8L,1L,6L,7L,9L,3L,8L,9L,3L,1L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021528Inst : IEnumerable<long>
{
public static readonly long[] Value=A021528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021528.Bytes);
public long this[int i]=>Value[i];

public static A021528Inst Instance=new A021528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021527
{
public static readonly long[] Value={ 0L,0L,1L,9L,1L,2L,0L,4L,5L,8L,8L,9L,1L,0L,1L,3L,3L,8L,4L,3L,2L,1L,2L,2L,3L,7L,0L,9L,3L,6L,9L,0L,2L,4L,8L,5L,6L,5L,9L,6L,5L,5L,8L,3L,1L,7L,3L,9L,9L,6L,1L,7L,5L,9L,0L,8L,2L,2L,1L,7L,9L,7L,3L,2L,3L,1L,3L,5L,7L,5L,5L,2L,5L,8L,1L,2L,6L,1L,9L,5L,0L,2L,8L,6L,8L,0L,6L,8L,8L,3L,3L,6L,5L,2L,0L,0L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021527Inst : IEnumerable<long>
{
public static readonly long[] Value=A021527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021527.Bytes);
public long this[int i]=>Value[i];

public static A021527Inst Instance=new A021527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021526
{
public static readonly long[] Value={ 0L,0L,1L,9L,1L,5L,7L,0L,8L,8L,1L,2L,2L,6L,0L,5L,3L,6L,3L,9L,8L,4L,6L,7L,4L,3L,2L,9L,5L,0L,1L,9L,1L,5L,7L,0L,8L,8L,1L,2L,2L,6L,0L,5L,3L,6L,3L,9L,8L,4L,6L,7L,4L,3L,2L,9L,5L,0L,1L,9L,1L,5L,7L,0L,8L,8L,1L,2L,2L,6L,0L,5L,3L,6L,3L,9L,8L,4L,6L,7L,4L,3L,2L,9L,5L,0L,1L,9L,1L,5L,7L,0L,8L,8L,1L,2L,2L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021526Inst : IEnumerable<long>
{
public static readonly long[] Value=A021526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021526.Bytes);
public long this[int i]=>Value[i];

public static A021526Inst Instance=new A021526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021525
{
public static readonly long[] Value={ 0L,0L,1L,9L,1L,9L,3L,8L,5L,7L,9L,6L,5L,4L,5L,1L,0L,5L,5L,6L,6L,2L,1L,8L,8L,0L,9L,9L,8L,0L,8L,0L,6L,1L,4L,2L,0L,3L,4L,5L,4L,8L,9L,4L,4L,3L,3L,7L,8L,1L,1L,9L,0L,0L,1L,9L,1L,9L,3L,8L,5L,7L,9L,6L,5L,4L,5L,1L,0L,5L,5L,6L,6L,2L,1L,8L,8L,0L,9L,9L,8L,0L,8L,0L,6L,1L,4L,2L,0L,3L,4L,5L,4L,8L,9L,4L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021525Inst : IEnumerable<long>
{
public static readonly long[] Value=A021525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021525.Bytes);
public long this[int i]=>Value[i];

public static A021525Inst Instance=new A021525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021524
{
public static readonly long[] Value={ 1L,21L,304L,3822L,45031L,513639L,5760910L,64038576L,708445573L,7817058249L,86132670988L,948329828082L,10436851589347L,114836710756971L,1263391885146058L,13898439159046260L,152889601348716673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021524Inst : IEnumerable<long>
{
public static readonly long[] Value=A021524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021524.Bytes);
public long this[int i]=>Value[i];

public static A021524Inst Instance=new A021524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021523
{
public static readonly long[] Value={ 0L,0L,1L,9L,2L,6L,7L,8L,2L,2L,7L,3L,6L,0L,3L,0L,8L,2L,8L,5L,1L,6L,3L,7L,7L,6L,4L,9L,3L,2L,5L,6L,2L,6L,2L,0L,4L,2L,3L,8L,9L,2L,1L,0L,0L,1L,9L,2L,6L,7L,8L,2L,2L,7L,3L,6L,0L,3L,0L,8L,2L,8L,5L,1L,6L,3L,7L,7L,6L,4L,9L,3L,2L,5L,6L,2L,6L,2L,0L,4L,2L,3L,8L,9L,2L,1L,0L,0L,1L,9L,2L,6L,7L,8L,2L,2L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021523Inst : IEnumerable<long>
{
public static readonly long[] Value=A021523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021523.Bytes);
public long this[int i]=>Value[i];

public static A021523Inst Instance=new A021523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021522
{
public static readonly long[] Value={ 0L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L,9L,3L,0L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021522Inst : IEnumerable<long>
{
public static readonly long[] Value=A021522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021522.Bytes);
public long this[int i]=>Value[i];

public static A021522Inst Instance=new A021522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021521
{
public static readonly long[] Value={ 0L,0L,1L,9L,3L,4L,2L,3L,5L,9L,7L,6L,7L,8L,9L,1L,6L,8L,2L,7L,8L,5L,2L,9L,9L,8L,0L,6L,5L,7L,6L,4L,0L,2L,3L,2L,1L,0L,8L,3L,1L,7L,2L,1L,4L,7L,0L,0L,1L,9L,3L,4L,2L,3L,5L,9L,7L,6L,7L,8L,9L,1L,6L,8L,2L,7L,8L,5L,2L,9L,9L,8L,0L,6L,5L,7L,6L,4L,0L,2L,3L,2L,1L,0L,8L,3L,1L,7L,2L,1L,4L,7L,0L,0L,1L,9L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021521Inst : IEnumerable<long>
{
public static readonly long[] Value=A021521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021521.Bytes);
public long this[int i]=>Value[i];

public static A021521Inst Instance=new A021521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021520
{
public static readonly long[] Value={ 0L,0L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021520Inst : IEnumerable<long>
{
public static readonly long[] Value=A021520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021520.Bytes);
public long this[int i]=>Value[i];

public static A021520Inst Instance=new A021520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021519
{
public static readonly long[] Value={ 0L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L,0L,5L,8L,2L,5L,2L,4L,2L,7L,1L,8L,4L,4L,6L,6L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L,0L,5L,8L,2L,5L,2L,4L,2L,7L,1L,8L,4L,4L,6L,6L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L,0L,5L,8L,2L,5L,2L,4L,2L,7L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021519Inst : IEnumerable<long>
{
public static readonly long[] Value=A021519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021519.Bytes);
public long this[int i]=>Value[i];

public static A021519Inst Instance=new A021519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021518
{
public static readonly long[] Value={ 0L,0L,1L,9L,4L,5L,5L,2L,5L,2L,9L,1L,8L,2L,8L,7L,9L,3L,7L,7L,4L,3L,1L,9L,0L,6L,6L,1L,4L,7L,8L,5L,9L,9L,2L,2L,1L,7L,8L,9L,8L,8L,3L,2L,6L,8L,4L,8L,2L,4L,9L,0L,2L,7L,2L,3L,7L,3L,5L,4L,0L,8L,5L,6L,0L,3L,1L,1L,2L,8L,4L,0L,4L,6L,6L,9L,2L,6L,0L,7L,0L,0L,3L,8L,9L,1L,0L,5L,0L,5L,8L,3L,6L,5L,7L,5L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021518Inst : IEnumerable<long>
{
public static readonly long[] Value=A021518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021518.Bytes);
public long this[int i]=>Value[i];

public static A021518Inst Instance=new A021518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021501
{
public static readonly long[] Value={ 0L,0L,2L,0L,1L,2L,0L,7L,2L,4L,3L,4L,6L,0L,7L,6L,4L,5L,8L,7L,5L,2L,5L,1L,5L,0L,9L,0L,5L,4L,3L,2L,5L,9L,5L,5L,7L,3L,4L,4L,0L,6L,4L,3L,8L,6L,3L,1L,7L,9L,0L,7L,4L,4L,4L,6L,6L,8L,0L,0L,8L,0L,4L,8L,2L,8L,9L,7L,3L,8L,4L,3L,0L,5L,8L,3L,5L,0L,1L,0L,0L,6L,0L,3L,6L,2L,1L,7L,3L,0L,3L,8L,2L,2L,9L,3L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021501Inst : IEnumerable<long>
{
public static readonly long[] Value=A021501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021501.Bytes);
public long this[int i]=>Value[i];

public static A021501Inst Instance=new A021501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021500
{
public static readonly long[] Value={ 0L,0L,2L,0L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021500Inst : IEnumerable<long>
{
public static readonly long[] Value=A021500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021500.Bytes);
public long this[int i]=>Value[i];

public static A021500Inst Instance=new A021500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021499
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021499Inst : IEnumerable<long>
{
public static readonly long[] Value=A021499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021499.Bytes);
public long this[int i]=>Value[i];

public static A021499Inst Instance=new A021499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021498
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L,4L,9L,7L,9L,7L,5L,7L,0L,8L,5L,0L,2L,0L,2L,4L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021498Inst : IEnumerable<long>
{
public static readonly long[] Value=A021498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021498.Bytes);
public long this[int i]=>Value[i];

public static A021498Inst Instance=new A021498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021497
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,8L,3L,9L,7L,5L,6L,5L,9L,2L,2L,9L,2L,0L,8L,9L,2L,4L,9L,4L,9L,2L,9L,0L,0L,6L,0L,8L,5L,1L,9L,2L,6L,9L,7L,7L,6L,8L,7L,6L,2L,6L,7L,7L,4L,8L,4L,7L,8L,7L,0L,1L,8L,2L,5L,5L,5L,7L,8L,0L,9L,3L,3L,0L,6L,2L,8L,8L,0L,3L,2L,4L,5L,4L,3L,6L,1L,0L,5L,4L,7L,6L,6L,7L,3L,4L,2L,7L,9L,9L,1L,8L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021497Inst : IEnumerable<long>
{
public static readonly long[] Value=A021497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021497.Bytes);
public long this[int i]=>Value[i];

public static A021497Inst Instance=new A021497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021496
{
public static readonly long[] Value={ 0L,0L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L,3L,2L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021496Inst : IEnumerable<long>
{
public static readonly long[] Value=A021496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021496.Bytes);
public long this[int i]=>Value[i];

public static A021496Inst Instance=new A021496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021495
{
public static readonly long[] Value={ 0L,0L,2L,0L,3L,6L,6L,5L,9L,8L,7L,7L,8L,0L,0L,4L,0L,7L,3L,3L,1L,9L,7L,5L,5L,6L,0L,0L,8L,1L,4L,6L,6L,3L,9L,5L,1L,1L,2L,0L,1L,6L,2L,9L,3L,2L,7L,9L,0L,2L,2L,4L,0L,3L,2L,5L,8L,6L,5L,5L,8L,0L,4L,4L,8L,0L,6L,5L,1L,7L,3L,1L,1L,6L,0L,8L,9L,6L,1L,3L,0L,3L,4L,6L,2L,3L,2L,1L,7L,9L,2L,2L,6L,0L,6L,9L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021495Inst : IEnumerable<long>
{
public static readonly long[] Value=A021495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021495.Bytes);
public long this[int i]=>Value[i];

public static A021495Inst Instance=new A021495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021494
{
public static readonly long[] Value={ 1L,17L,192L,1822L,15743L,128499L,1010374L,7741184L,58209525L,431623621L,3166395596L,23035216386L,166469995147L,1196633240183L,8564499500658L,61079918944228L,434330031817409L,3080934011678985L,21810281396626360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021494Inst : IEnumerable<long>
{
public static readonly long[] Value=A021494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021494.Bytes);
public long this[int i]=>Value[i];

public static A021494Inst Instance=new A021494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021493
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,4L,9L,8L,9L,7L,7L,5L,0L,5L,1L,1L,2L,4L,7L,4L,4L,3L,7L,6L,2L,7L,8L,1L,1L,8L,6L,0L,9L,4L,0L,6L,9L,5L,2L,9L,6L,5L,2L,3L,5L,1L,7L,3L,8L,2L,4L,1L,3L,0L,8L,7L,9L,3L,4L,5L,6L,0L,3L,2L,7L,1L,9L,8L,3L,6L,4L,0L,0L,8L,1L,7L,9L,9L,5L,9L,1L,0L,0L,2L,0L,4L,4L,9L,8L,9L,7L,7L,5L,0L,5L,1L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021493Inst : IEnumerable<long>
{
public static readonly long[] Value=A021493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021493.Bytes);
public long this[int i]=>Value[i];

public static A021493Inst Instance=new A021493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021492
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021492Inst : IEnumerable<long>
{
public static readonly long[] Value=A021492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021492.Bytes);
public long this[int i]=>Value[i];

public static A021492Inst Instance=new A021492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021491
{
public static readonly long[] Value={ 0L,0L,2L,0L,5L,3L,3L,8L,8L,0L,9L,0L,3L,4L,9L,0L,7L,5L,9L,7L,5L,3L,5L,9L,3L,4L,2L,9L,1L,5L,8L,1L,1L,0L,8L,8L,2L,9L,5L,6L,8L,7L,8L,8L,5L,0L,1L,0L,2L,6L,6L,9L,4L,0L,4L,5L,1L,7L,4L,5L,3L,7L,9L,8L,7L,6L,7L,9L,6L,7L,1L,4L,5L,7L,9L,0L,5L,5L,4L,4L,1L,4L,7L,8L,4L,3L,9L,4L,2L,5L,0L,5L,1L,3L,3L,4L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021491Inst : IEnumerable<long>
{
public static readonly long[] Value=A021491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021491.Bytes);
public long this[int i]=>Value[i];

public static A021491Inst Instance=new A021491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021490
{
public static readonly long[] Value={ 0L,0L,2L,0L,5L,7L,6L,1L,3L,1L,6L,8L,7L,2L,4L,2L,7L,9L,8L,3L,5L,3L,9L,0L,9L,4L,6L,5L,0L,2L,0L,5L,7L,6L,1L,3L,1L,6L,8L,7L,2L,4L,2L,7L,9L,8L,3L,5L,3L,9L,0L,9L,4L,6L,5L,0L,2L,0L,5L,7L,6L,1L,3L,1L,6L,8L,7L,2L,4L,2L,7L,9L,8L,3L,5L,3L,9L,0L,9L,4L,6L,5L,0L,2L,0L,5L,7L,6L,1L,3L,1L,6L,8L,7L,2L,4L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021490Inst : IEnumerable<long>
{
public static readonly long[] Value=A021490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021490.Bytes);
public long this[int i]=>Value[i];

public static A021490Inst Instance=new A021490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021489
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,1L,8L,5L,5L,6L,7L,0L,1L,0L,3L,0L,9L,2L,7L,8L,3L,5L,0L,5L,1L,5L,4L,6L,3L,9L,1L,7L,5L,2L,5L,7L,7L,3L,1L,9L,5L,8L,7L,6L,2L,8L,8L,6L,5L,9L,7L,9L,3L,8L,1L,4L,4L,3L,2L,9L,8L,9L,6L,9L,0L,7L,2L,1L,6L,4L,9L,4L,8L,4L,5L,3L,6L,0L,8L,2L,4L,7L,4L,2L,2L,6L,8L,0L,4L,1L,2L,3L,7L,1L,1L,3L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021489Inst : IEnumerable<long>
{
public static readonly long[] Value=A021489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021489.Bytes);
public long this[int i]=>Value[i];

public static A021489Inst Instance=new A021489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021488
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,6L,1L,1L,5L,7L,0L,2L,4L,7L,9L,3L,3L,8L,8L,4L,2L,9L,7L,5L,2L,0L,6L,6L,1L,1L,5L,7L,0L,2L,4L,7L,9L,3L,3L,8L,8L,4L,2L,9L,7L,5L,2L,0L,6L,6L,1L,1L,5L,7L,0L,2L,4L,7L,9L,3L,3L,8L,8L,4L,2L,9L,7L,5L,2L,0L,6L,6L,1L,1L,5L,7L,0L,2L,4L,7L,9L,3L,3L,8L,8L,4L,2L,9L,7L,5L,2L,0L,6L,6L,1L,1L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021488Inst : IEnumerable<long>
{
public static readonly long[] Value=A021488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021488.Bytes);
public long this[int i]=>Value[i];

public static A021488Inst Instance=new A021488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021487
{
public static readonly long[] Value={ 0L,0L,2L,0L,7L,0L,3L,9L,3L,3L,7L,4L,7L,4L,1L,2L,0L,0L,8L,2L,8L,1L,5L,7L,3L,4L,9L,8L,9L,6L,4L,8L,0L,3L,3L,1L,2L,6L,2L,9L,3L,9L,9L,5L,8L,5L,9L,2L,1L,3L,2L,5L,0L,5L,1L,7L,5L,9L,8L,3L,4L,3L,6L,8L,5L,3L,0L,0L,2L,0L,7L,0L,3L,9L,3L,3L,7L,4L,7L,4L,1L,2L,0L,0L,8L,2L,8L,1L,5L,7L,3L,4L,9L,8L,9L,6L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021487Inst : IEnumerable<long>
{
public static readonly long[] Value=A021487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021487.Bytes);
public long this[int i]=>Value[i];

public static A021487Inst Instance=new A021487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021486
{
public static readonly long[] Value={ 0L,0L,2L,0L,7L,4L,6L,8L,8L,7L,9L,6L,6L,8L,0L,4L,9L,7L,9L,2L,5L,3L,1L,1L,2L,0L,3L,3L,1L,9L,5L,0L,2L,0L,7L,4L,6L,8L,8L,7L,9L,6L,6L,8L,0L,4L,9L,7L,9L,2L,5L,3L,1L,1L,2L,0L,3L,3L,1L,9L,5L,0L,2L,0L,7L,4L,6L,8L,8L,7L,9L,6L,6L,8L,0L,4L,9L,7L,9L,2L,5L,3L,1L,1L,2L,0L,3L,3L,1L,9L,5L,0L,2L,0L,7L,4L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021486Inst : IEnumerable<long>
{
public static readonly long[] Value=A021486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021486.Bytes);
public long this[int i]=>Value[i];

public static A021486Inst Instance=new A021486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021469
{
public static readonly long[] Value={ 0L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L,6L,3L,4L,4L,0L,8L,6L,0L,2L,1L,5L,0L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021469Inst : IEnumerable<long>
{
public static readonly long[] Value=A021469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021469.Bytes);
public long this[int i]=>Value[i];

public static A021469Inst Instance=new A021469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021468
{
public static readonly long[] Value={ 0L,0L,2L,1L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021468Inst : IEnumerable<long>
{
public static readonly long[] Value=A021468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021468.Bytes);
public long this[int i]=>Value[i];

public static A021468Inst Instance=new A021468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021467
{
public static readonly long[] Value={ 0L,0L,2L,1L,5L,9L,8L,2L,7L,2L,1L,3L,8L,2L,2L,8L,9L,4L,1L,6L,8L,4L,6L,6L,5L,2L,2L,6L,7L,8L,1L,8L,5L,7L,4L,5L,1L,4L,0L,3L,8L,8L,7L,6L,8L,8L,9L,8L,4L,8L,8L,1L,2L,0L,9L,5L,0L,3L,2L,3L,9L,7L,4L,0L,8L,2L,0L,7L,3L,4L,3L,4L,1L,2L,5L,2L,6L,9L,9L,7L,8L,4L,0L,1L,7L,2L,7L,8L,6L,1L,7L,7L,1L,0L,5L,8L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021467Inst : IEnumerable<long>
{
public static readonly long[] Value=A021467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021467.Bytes);
public long this[int i]=>Value[i];

public static A021467Inst Instance=new A021467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021466
{
public static readonly long[] Value={ 0L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L,1L,6L,4L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021466Inst : IEnumerable<long>
{
public static readonly long[] Value=A021466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021466.Bytes);
public long this[int i]=>Value[i];

public static A021466Inst Instance=new A021466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021465
{
public static readonly long[] Value={ 0L,0L,2L,1L,6L,9L,1L,9L,7L,3L,9L,6L,9L,6L,3L,1L,2L,3L,6L,4L,4L,2L,5L,1L,6L,2L,6L,8L,9L,8L,0L,4L,7L,7L,2L,2L,3L,4L,2L,7L,3L,3L,1L,8L,8L,7L,2L,0L,1L,7L,3L,5L,3L,5L,7L,9L,1L,7L,5L,7L,0L,4L,9L,8L,9L,1L,5L,4L,0L,1L,3L,0L,1L,5L,1L,8L,4L,3L,8L,1L,7L,7L,8L,7L,4L,1L,8L,6L,5L,5L,0L,9L,7L,6L,1L,3L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021465Inst : IEnumerable<long>
{
public static readonly long[] Value=A021465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021465.Bytes);
public long this[int i]=>Value[i];

public static A021465Inst Instance=new A021465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021464
{
public static readonly long[] Value={ 1L,19L,248L,2810L,29871L,307929L,3126478L,31504000L,316245941L,3168518639L,31715571108L,317307900390L,3173840747611L,31742218586149L,317441248586138L,3174507821007980L,31745554950382881L,317457933399054459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021464Inst : IEnumerable<long>
{
public static readonly long[] Value=A021464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021464.Bytes);
public long this[int i]=>Value[i];

public static A021464Inst Instance=new A021464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021463
{
public static readonly long[] Value={ 0L,0L,2L,1L,7L,8L,6L,4L,9L,2L,3L,7L,4L,7L,2L,7L,6L,6L,8L,8L,4L,5L,3L,1L,5L,9L,0L,4L,1L,3L,9L,4L,3L,3L,5L,5L,1L,1L,9L,8L,2L,5L,7L,0L,8L,0L,6L,1L,0L,0L,2L,1L,7L,8L,6L,4L,9L,2L,3L,7L,4L,7L,2L,7L,6L,6L,8L,8L,4L,5L,3L,1L,5L,9L,0L,4L,1L,3L,9L,4L,3L,3L,5L,5L,1L,1L,9L,8L,2L,5L,7L,0L,8L,0L,6L,1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021463Inst : IEnumerable<long>
{
public static readonly long[] Value=A021463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021463.Bytes);
public long this[int i]=>Value[i];

public static A021463Inst Instance=new A021463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021462
{
public static readonly long[] Value={ 0L,0L,2L,1L,8L,3L,4L,0L,6L,1L,1L,3L,5L,3L,7L,1L,1L,7L,9L,0L,3L,9L,3L,0L,1L,3L,1L,0L,0L,4L,3L,6L,6L,8L,1L,2L,2L,2L,7L,0L,7L,4L,2L,3L,5L,8L,0L,7L,8L,6L,0L,2L,6L,2L,0L,0L,8L,7L,3L,3L,6L,2L,4L,4L,5L,4L,1L,4L,8L,4L,7L,1L,6L,1L,5L,7L,2L,0L,5L,2L,4L,0L,1L,7L,4L,6L,7L,2L,4L,8L,9L,0L,8L,2L,9L,6L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021462Inst : IEnumerable<long>
{
public static readonly long[] Value=A021462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021462.Bytes);
public long this[int i]=>Value[i];

public static A021462Inst Instance=new A021462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021461
{
public static readonly long[] Value={ 0L,0L,2L,1L,8L,8L,1L,8L,3L,8L,0L,7L,4L,3L,9L,8L,2L,4L,9L,4L,5L,2L,9L,5L,4L,0L,4L,8L,1L,4L,0L,0L,4L,3L,7L,6L,3L,6L,7L,6L,1L,4L,8L,7L,9L,6L,4L,9L,8L,9L,0L,5L,9L,0L,8L,0L,9L,6L,2L,8L,0L,0L,8L,7L,5L,2L,7L,3L,5L,2L,2L,9L,7L,5L,9L,2L,9L,9L,7L,8L,1L,1L,8L,1L,6L,1L,9L,2L,5L,6L,0L,1L,7L,5L,0L,5L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021461Inst : IEnumerable<long>
{
public static readonly long[] Value=A021461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021461.Bytes);
public long this[int i]=>Value[i];

public static A021461Inst Instance=new A021461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021460
{
public static readonly long[] Value={ 0L,0L,2L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021460Inst : IEnumerable<long>
{
public static readonly long[] Value=A021460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021460.Bytes);
public long this[int i]=>Value[i];

public static A021460Inst Instance=new A021460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021459
{
public static readonly long[] Value={ 0L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L,1L,9L,7L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021459Inst : IEnumerable<long>
{
public static readonly long[] Value=A021459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021459.Bytes);
public long this[int i]=>Value[i];

public static A021459Inst Instance=new A021459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021458
{
public static readonly long[] Value={ 0L,0L,2L,2L,0L,2L,6L,4L,3L,1L,7L,1L,8L,0L,6L,1L,6L,7L,4L,0L,0L,8L,8L,1L,0L,5L,7L,2L,6L,8L,7L,2L,2L,4L,6L,6L,9L,6L,0L,3L,5L,2L,4L,2L,2L,9L,0L,7L,4L,8L,8L,9L,8L,6L,7L,8L,4L,1L,4L,0L,9L,6L,9L,1L,6L,2L,9L,9L,5L,5L,9L,4L,7L,1L,3L,6L,5L,6L,3L,8L,7L,6L,6L,5L,1L,9L,8L,2L,3L,7L,8L,8L,5L,4L,6L,2L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021458Inst : IEnumerable<long>
{
public static readonly long[] Value=A021458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021458.Bytes);
public long this[int i]=>Value[i];

public static A021458Inst Instance=new A021458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021457
{
public static readonly long[] Value={ 0L,0L,2L,2L,0L,7L,5L,0L,5L,5L,1L,8L,7L,6L,3L,7L,9L,6L,9L,0L,9L,4L,9L,2L,2L,7L,3L,7L,3L,0L,6L,8L,4L,3L,2L,6L,7L,1L,0L,8L,1L,6L,7L,7L,7L,0L,4L,1L,9L,4L,2L,6L,0L,4L,8L,5L,6L,5L,1L,2L,1L,4L,1L,2L,8L,0L,3L,5L,3L,2L,0L,0L,8L,8L,3L,0L,0L,2L,2L,0L,7L,5L,0L,5L,5L,1L,8L,7L,6L,3L,7L,9L,6L,9L,0L,9L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021457Inst : IEnumerable<long>
{
public static readonly long[] Value=A021457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021457.Bytes);
public long this[int i]=>Value[i];

public static A021457Inst Instance=new A021457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021456
{
public static readonly long[] Value={ 0L,0L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L,3L,1L,8L,5L,8L,4L,0L,7L,0L,7L,9L,6L,4L,6L,0L,1L,7L,6L,9L,9L,1L,1L,5L,0L,4L,4L,2L,4L,7L,7L,8L,7L,6L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L,5L,9L,2L,9L,2L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021456Inst : IEnumerable<long>
{
public static readonly long[] Value=A021456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021456.Bytes);
public long this[int i]=>Value[i];

public static A021456Inst Instance=new A021456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021455
{
public static readonly long[] Value={ 0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L,9L,0L,0L,2L,2L,1L,7L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021455Inst : IEnumerable<long>
{
public static readonly long[] Value=A021455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021455.Bytes);
public long this[int i]=>Value[i];

public static A021455Inst Instance=new A021455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021454
{
public static readonly long[] Value={ 1L,18L,220L,2310L,22561L,212268L,1957600L,17857620L,161924521L,1463379918L,13200803980L,118959425130L,1071396569881L,9646380238968L,86836484875360L,781623699024840L,7035090031526641L,63318194178965418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021454Inst : IEnumerable<long>
{
public static readonly long[] Value=A021454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021454.Bytes);
public long this[int i]=>Value[i];

public static A021454Inst Instance=new A021454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021437
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,9L,4L,6L,8L,8L,2L,2L,1L,7L,0L,9L,0L,0L,6L,9L,2L,8L,4L,0L,6L,4L,6L,6L,5L,1L,2L,7L,0L,2L,0L,7L,8L,5L,2L,1L,9L,3L,9L,9L,5L,3L,8L,1L,0L,6L,2L,3L,5L,5L,6L,5L,8L,1L,9L,8L,6L,1L,4L,3L,1L,8L,7L,0L,6L,6L,9L,7L,4L,5L,9L,5L,8L,4L,2L,9L,5L,6L,1L,2L,0L,0L,9L,2L,3L,7L,8L,7L,5L,2L,8L,8L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021437Inst : IEnumerable<long>
{
public static readonly long[] Value=A021437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021437.Bytes);
public long this[int i]=>Value[i];

public static A021437Inst Instance=new A021437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021436
{
public static readonly long[] Value={ 0L,0L,2L,3L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021436Inst : IEnumerable<long>
{
public static readonly long[] Value=A021436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021436.Bytes);
public long this[int i]=>Value[i];

public static A021436Inst Instance=new A021436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021435
{
public static readonly long[] Value={ 0L,0L,2L,3L,2L,0L,1L,8L,5L,6L,1L,4L,8L,4L,9L,1L,8L,7L,9L,3L,5L,0L,3L,4L,8L,0L,2L,7L,8L,4L,2L,2L,2L,7L,3L,7L,8L,1L,9L,0L,2L,5L,5L,2L,2L,0L,4L,1L,7L,6L,3L,3L,4L,1L,0L,6L,7L,2L,8L,5L,3L,8L,2L,8L,3L,0L,6L,2L,6L,4L,5L,0L,1L,1L,6L,0L,0L,9L,2L,8L,0L,7L,4L,2L,4L,5L,9L,3L,9L,6L,7L,5L,1L,7L,4L,0L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021435Inst : IEnumerable<long>
{
public static readonly long[] Value=A021435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021435.Bytes);
public long this[int i]=>Value[i];

public static A021435Inst Instance=new A021435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021434
{
public static readonly long[] Value={ 1L,17L,194L,1882L,16827L,143835L,1197868L,9822164L,79783253L,644325253L,5184986742L,41632083246L,333818409679L,2674358387471L,21413929824416L,171406773741928L,1371730930238505L,10976231337133689L,87821770754328490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021434Inst : IEnumerable<long>
{
public static readonly long[] Value=A021434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021434.Bytes);
public long this[int i]=>Value[i];

public static A021434Inst Instance=new A021434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021433
{
public static readonly long[] Value={ 0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L,3L,3L,1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021433Inst : IEnumerable<long>
{
public static readonly long[] Value=A021433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021433.Bytes);
public long this[int i]=>Value[i];

public static A021433Inst Instance=new A021433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021432
{
public static readonly long[] Value={ 0L,0L,2L,3L,3L,6L,4L,4L,8L,5L,9L,8L,1L,3L,0L,8L,4L,1L,1L,2L,1L,4L,9L,5L,3L,2L,7L,1L,0L,2L,8L,0L,3L,7L,3L,8L,3L,1L,7L,7L,5L,7L,0L,0L,9L,3L,4L,5L,7L,9L,4L,3L,9L,2L,5L,2L,3L,3L,6L,4L,4L,8L,5L,9L,8L,1L,3L,0L,8L,4L,1L,1L,2L,1L,4L,9L,5L,3L,2L,7L,1L,0L,2L,8L,0L,3L,7L,3L,8L,3L,1L,7L,7L,5L,7L,0L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021432Inst : IEnumerable<long>
{
public static readonly long[] Value=A021432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021432.Bytes);
public long this[int i]=>Value[i];

public static A021432Inst Instance=new A021432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021431
{
public static readonly long[] Value={ 0L,0L,2L,3L,4L,1L,9L,2L,0L,3L,7L,4L,7L,0L,7L,2L,5L,9L,9L,5L,3L,1L,6L,1L,5L,9L,2L,5L,0L,5L,8L,5L,4L,8L,0L,0L,9L,3L,6L,7L,6L,8L,1L,4L,9L,8L,8L,2L,9L,0L,3L,9L,8L,1L,2L,6L,4L,6L,3L,7L,0L,0L,2L,3L,4L,1L,9L,2L,0L,3L,7L,4L,7L,0L,7L,2L,5L,9L,9L,5L,3L,1L,6L,1L,5L,9L,2L,5L,0L,5L,8L,5L,4L,8L,0L,0L,9L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021431Inst : IEnumerable<long>
{
public static readonly long[] Value=A021431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021431.Bytes);
public long this[int i]=>Value[i];

public static A021431Inst Instance=new A021431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021430
{
public static readonly long[] Value={ 0L,0L,2L,3L,4L,7L,4L,1L,7L,8L,4L,0L,3L,7L,5L,5L,8L,6L,8L,5L,4L,4L,6L,0L,0L,9L,3L,8L,9L,6L,7L,1L,3L,6L,1L,5L,0L,2L,3L,4L,7L,4L,1L,7L,8L,4L,0L,3L,7L,5L,5L,8L,6L,8L,5L,4L,4L,6L,0L,0L,9L,3L,8L,9L,6L,7L,1L,3L,6L,1L,5L,0L,2L,3L,4L,7L,4L,1L,7L,8L,4L,0L,3L,7L,5L,5L,8L,6L,8L,5L,4L,4L,6L,0L,0L,9L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021430Inst : IEnumerable<long>
{
public static readonly long[] Value=A021430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021430.Bytes);
public long this[int i]=>Value[i];

public static A021430Inst Instance=new A021430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021429
{
public static readonly long[] Value={ 0L,0L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021429Inst : IEnumerable<long>
{
public static readonly long[] Value=A021429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021429.Bytes);
public long this[int i]=>Value[i];

public static A021429Inst Instance=new A021429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021428
{
public static readonly long[] Value={ 0L,0L,2L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021428Inst : IEnumerable<long>
{
public static readonly long[] Value=A021428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021428.Bytes);
public long this[int i]=>Value[i];

public static A021428Inst Instance=new A021428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021427
{
public static readonly long[] Value={ 0L,0L,2L,3L,6L,4L,0L,6L,6L,1L,9L,3L,8L,5L,3L,4L,2L,7L,8L,9L,5L,9L,8L,1L,0L,8L,7L,4L,7L,0L,4L,4L,9L,1L,7L,2L,5L,7L,6L,8L,3L,2L,1L,5L,1L,3L,0L,0L,2L,3L,6L,4L,0L,6L,6L,1L,9L,3L,8L,5L,3L,4L,2L,7L,8L,9L,5L,9L,8L,1L,0L,8L,7L,4L,7L,0L,4L,4L,9L,1L,7L,2L,5L,7L,6L,8L,3L,2L,1L,5L,1L,3L,0L,0L,2L,3L,6L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021427Inst : IEnumerable<long>
{
public static readonly long[] Value=A021427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021427.Bytes);
public long this[int i]=>Value[i];

public static A021427Inst Instance=new A021427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021426
{
public static readonly long[] Value={ 0L,0L,2L,3L,6L,9L,6L,6L,8L,2L,4L,6L,4L,4L,5L,4L,9L,7L,6L,3L,0L,3L,3L,1L,7L,5L,3L,5L,5L,4L,5L,0L,2L,3L,6L,9L,6L,6L,8L,2L,4L,6L,4L,4L,5L,4L,9L,7L,6L,3L,0L,3L,3L,1L,7L,5L,3L,5L,5L,4L,5L,0L,2L,3L,6L,9L,6L,6L,8L,2L,4L,6L,4L,4L,5L,4L,9L,7L,6L,3L,0L,3L,3L,1L,7L,5L,3L,5L,5L,4L,5L,0L,2L,3L,6L,9L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021426Inst : IEnumerable<long>
{
public static readonly long[] Value=A021426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021426.Bytes);
public long this[int i]=>Value[i];

public static A021426Inst Instance=new A021426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021425
{
public static readonly long[] Value={ 0L,0L,2L,3L,7L,5L,2L,9L,6L,9L,1L,2L,1L,1L,4L,0L,1L,4L,2L,5L,1L,7L,8L,1L,4L,7L,2L,6L,8L,4L,0L,8L,5L,5L,1L,0L,6L,8L,8L,8L,3L,6L,1L,0L,4L,5L,1L,3L,0L,6L,4L,1L,3L,3L,0L,1L,6L,6L,2L,7L,0L,7L,8L,3L,8L,4L,7L,9L,8L,0L,9L,9L,7L,6L,2L,4L,7L,0L,3L,0L,8L,7L,8L,8L,5L,9L,8L,5L,7L,4L,8L,2L,1L,8L,5L,2L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021425Inst : IEnumerable<long>
{
public static readonly long[] Value=A021425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021425.Bytes);
public long this[int i]=>Value[i];

public static A021425Inst Instance=new A021425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021424
{
public static readonly long[] Value={ 1L,16L,170L,1520L,12411L,96096L,719860L,5278240L,38153621L,273134576L,1942326750L,13748476560L,97001079631L,682818667456L,4798793396840L,33686888924480L,236284962774441L,1656378634646736L,11606570499786130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021424Inst : IEnumerable<long>
{
public static readonly long[] Value=A021424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021424.Bytes);
public long this[int i]=>Value[i];

public static A021424Inst Instance=new A021424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021423
{
public static readonly long[] Value={ 0L,0L,2L,3L,8L,6L,6L,3L,4L,8L,4L,4L,8L,6L,8L,7L,3L,5L,0L,8L,3L,5L,3L,2L,2L,1L,9L,5L,7L,0L,4L,0L,5L,7L,2L,7L,9L,2L,3L,6L,2L,7L,6L,8L,4L,9L,6L,4L,2L,0L,0L,4L,7L,7L,3L,2L,6L,9L,6L,8L,9L,7L,3L,7L,4L,7L,0L,1L,6L,7L,0L,6L,4L,4L,3L,9L,1L,4L,0L,8L,1L,1L,4L,5L,5L,8L,4L,7L,2L,5L,5L,3L,6L,9L,9L,2L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021423Inst : IEnumerable<long>
{
public static readonly long[] Value=A021423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021423.Bytes);
public long this[int i]=>Value[i];

public static A021423Inst Instance=new A021423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021422
{
public static readonly long[] Value={ 0L,0L,2L,3L,9L,2L,3L,4L,4L,4L,9L,7L,6L,0L,7L,6L,5L,5L,5L,0L,2L,3L,9L,2L,3L,4L,4L,4L,9L,7L,6L,0L,7L,6L,5L,5L,5L,0L,2L,3L,9L,2L,3L,4L,4L,4L,9L,7L,6L,0L,7L,6L,5L,5L,5L,0L,2L,3L,9L,2L,3L,4L,4L,4L,9L,7L,6L,0L,7L,6L,5L,5L,5L,0L,2L,3L,9L,2L,3L,4L,4L,4L,9L,7L,6L,0L,7L,6L,5L,5L,5L,0L,2L,3L,9L,2L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021422Inst : IEnumerable<long>
{
public static readonly long[] Value=A021422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021422.Bytes);
public long this[int i]=>Value[i];

public static A021422Inst Instance=new A021422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021405
{
public static readonly long[] Value={ 0L,0L,2L,4L,9L,3L,7L,6L,5L,5L,8L,6L,0L,3L,4L,9L,1L,2L,7L,1L,8L,2L,0L,4L,4L,8L,8L,7L,7L,8L,0L,5L,4L,8L,6L,2L,8L,4L,2L,8L,9L,2L,7L,6L,8L,0L,7L,9L,8L,0L,0L,4L,9L,8L,7L,5L,3L,1L,1L,7L,2L,0L,6L,9L,8L,2L,5L,4L,3L,6L,4L,0L,8L,9L,7L,7L,5L,5L,6L,1L,0L,9L,7L,2L,5L,6L,8L,5L,7L,8L,5L,5L,3L,6L,1L,5L,9L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021405Inst : IEnumerable<long>
{
public static readonly long[] Value=A021405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021405.Bytes);
public long this[int i]=>Value[i];

public static A021405Inst Instance=new A021405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021404
{
public static readonly long[] Value={ 1L,20L,285L,3640L,44681L,540540L,6505045L,78138080L,937976961L,11257033060L,135089723405L,1621098253320L,19453266126841L,233439544261580L,2801275941271365L,33615316957309360L,403383826200494321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021404Inst : IEnumerable<long>
{
public static readonly long[] Value=A021404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021404.Bytes);
public long this[int i]=>Value[i];

public static A021404Inst Instance=new A021404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021403
{
public static readonly long[] Value={ 0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L,6L,6L,4L,1L,6L,0L,4L,0L,1L,0L,0L,2L,5L,0L,6L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021403Inst : IEnumerable<long>
{
public static readonly long[] Value=A021403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021403.Bytes);
public long this[int i]=>Value[i];

public static A021403Inst Instance=new A021403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021402
{
public static readonly long[] Value={ 0L,0L,2L,5L,1L,2L,5L,6L,2L,8L,1L,4L,0L,7L,0L,3L,5L,1L,7L,5L,8L,7L,9L,3L,9L,6L,9L,8L,4L,9L,2L,4L,6L,2L,3L,1L,1L,5L,5L,7L,7L,8L,8L,9L,4L,4L,7L,2L,3L,6L,1L,8L,0L,9L,0L,4L,5L,2L,2L,6L,1L,3L,0L,6L,5L,3L,2L,6L,6L,3L,3L,1L,6L,5L,8L,2L,9L,1L,4L,5L,7L,2L,8L,6L,4L,3L,2L,1L,6L,0L,8L,0L,4L,0L,2L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021402Inst : IEnumerable<long>
{
public static readonly long[] Value=A021402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021402.Bytes);
public long this[int i]=>Value[i];

public static A021402Inst Instance=new A021402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021401
{
public static readonly long[] Value={ 0L,0L,2L,5L,1L,8L,8L,9L,1L,6L,8L,7L,6L,5L,7L,4L,3L,0L,7L,3L,0L,4L,7L,8L,5L,8L,9L,4L,2L,0L,6L,5L,4L,9L,1L,1L,8L,3L,8L,7L,9L,0L,9L,3L,1L,9L,8L,9L,9L,2L,4L,4L,3L,3L,2L,4L,9L,3L,7L,0L,2L,7L,7L,0L,7L,8L,0L,8L,5L,6L,4L,2L,3L,1L,7L,3L,8L,0L,3L,5L,2L,6L,4L,4L,8L,3L,6L,2L,7L,2L,0L,4L,0L,3L,0L,2L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021401Inst : IEnumerable<long>
{
public static readonly long[] Value=A021401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021401.Bytes);
public long this[int i]=>Value[i];

public static A021401Inst Instance=new A021401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021400
{
public static readonly long[] Value={ 0L,0L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021400Inst : IEnumerable<long>
{
public static readonly long[] Value=A021400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021400.Bytes);
public long this[int i]=>Value[i];

public static A021400Inst Instance=new A021400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021399
{
public static readonly long[] Value={ 0L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021399Inst : IEnumerable<long>
{
public static readonly long[] Value=A021399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021399.Bytes);
public long this[int i]=>Value[i];

public static A021399Inst Instance=new A021399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021398
{
public static readonly long[] Value={ 0L,0L,2L,5L,3L,8L,0L,7L,1L,0L,6L,5L,9L,8L,9L,8L,4L,7L,7L,1L,5L,7L,3L,6L,0L,4L,0L,6L,0L,9L,1L,3L,7L,0L,5L,5L,8L,3L,7L,5L,6L,3L,4L,5L,1L,7L,7L,6L,6L,4L,9L,7L,4L,6L,1L,9L,2L,8L,9L,3L,4L,0L,1L,0L,1L,5L,2L,2L,8L,4L,2L,6L,3L,9L,5L,9L,3L,9L,0L,8L,6L,2L,9L,4L,4L,1L,6L,2L,4L,3L,6L,5L,4L,8L,2L,2L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021398Inst : IEnumerable<long>
{
public static readonly long[] Value=A021398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021398.Bytes);
public long this[int i]=>Value[i];

public static A021398Inst Instance=new A021398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021397
{
public static readonly long[] Value={ 0L,0L,2L,5L,4L,4L,5L,2L,9L,2L,6L,2L,0L,8L,6L,5L,1L,3L,9L,9L,4L,9L,1L,0L,9L,4L,1L,4L,7L,5L,8L,2L,6L,9L,7L,2L,0L,1L,0L,1L,7L,8L,1L,1L,7L,0L,4L,8L,3L,4L,6L,0L,5L,5L,9L,7L,9L,6L,4L,3L,7L,6L,5L,9L,0L,3L,3L,0L,7L,8L,8L,8L,0L,4L,0L,7L,1L,2L,4L,6L,8L,1L,9L,3L,3L,8L,4L,2L,2L,3L,9L,1L,8L,5L,7L,5L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021397Inst : IEnumerable<long>
{
public static readonly long[] Value=A021397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021397.Bytes);
public long this[int i]=>Value[i];

public static A021397Inst Instance=new A021397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021396
{
public static readonly long[] Value={ 0L,0L,2L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021396Inst : IEnumerable<long>
{
public static readonly long[] Value=A021396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021396.Bytes);
public long this[int i]=>Value[i];

public static A021396Inst Instance=new A021396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021395
{
public static readonly long[] Value={ 0L,0L,2L,5L,5L,7L,5L,4L,4L,7L,5L,7L,0L,3L,3L,2L,4L,8L,0L,8L,1L,8L,4L,1L,4L,3L,2L,2L,2L,5L,0L,6L,3L,9L,3L,8L,6L,1L,8L,9L,2L,5L,8L,3L,1L,2L,0L,2L,0L,4L,6L,0L,3L,5L,8L,0L,5L,6L,2L,6L,5L,9L,8L,4L,6L,5L,4L,7L,3L,1L,4L,5L,7L,8L,0L,0L,5L,1L,1L,5L,0L,8L,9L,5L,1L,4L,0L,6L,6L,4L,9L,6L,1L,6L,3L,6L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021395Inst : IEnumerable<long>
{
public static readonly long[] Value=A021395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021395.Bytes);
public long this[int i]=>Value[i];

public static A021395Inst Instance=new A021395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021394
{
public static readonly long[] Value={ 1L,19L,254L,3014L,34155L,380073L,4199368L,46270588L,509296469L,5603570687L,61644604242L,678112219122L,7459321497343L,82052887210261L,902583169445276L,9928420525951016L,109212648498243177L,1201339224525513195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021394Inst : IEnumerable<long>
{
public static readonly long[] Value=A021394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021394.Bytes);
public long this[int i]=>Value[i];

public static A021394Inst Instance=new A021394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021393
{
public static readonly long[] Value={ 0L,0L,2L,5L,7L,0L,6L,9L,4L,0L,8L,7L,4L,0L,3L,5L,9L,8L,9L,7L,1L,7L,2L,2L,3L,6L,5L,0L,3L,8L,5L,6L,0L,4L,1L,1L,3L,1L,1L,0L,5L,3L,9L,8L,4L,5L,7L,5L,8L,3L,5L,4L,7L,5L,5L,7L,8L,4L,0L,6L,1L,6L,9L,6L,6L,5L,8L,0L,9L,7L,6L,8L,6L,3L,7L,5L,3L,2L,1L,3L,3L,6L,7L,6L,0L,9L,2L,5L,4L,4L,9L,8L,7L,1L,4L,6L,5L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021393Inst : IEnumerable<long>
{
public static readonly long[] Value=A021393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021393.Bytes);
public long this[int i]=>Value[i];

public static A021393Inst Instance=new A021393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021392
{
public static readonly long[] Value={ 0L,0L,2L,5L,7L,7L,3L,1L,9L,5L,8L,7L,6L,2L,8L,8L,6L,5L,9L,7L,9L,3L,8L,1L,4L,4L,3L,2L,9L,8L,9L,6L,9L,0L,7L,2L,1L,6L,4L,9L,4L,8L,4L,5L,3L,6L,0L,8L,2L,4L,7L,4L,2L,2L,6L,8L,0L,4L,1L,2L,3L,7L,1L,1L,3L,4L,0L,2L,0L,6L,1L,8L,5L,5L,6L,7L,0L,1L,0L,3L,0L,9L,2L,7L,8L,3L,5L,0L,5L,1L,5L,4L,6L,3L,9L,1L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021392Inst : IEnumerable<long>
{
public static readonly long[] Value=A021392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021392.Bytes);
public long this[int i]=>Value[i];

public static A021392Inst Instance=new A021392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021391
{
public static readonly long[] Value={ 0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L,3L,7L,4L,6L,7L,7L,0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L,3L,7L,4L,6L,7L,7L,0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L,3L,7L,4L,6L,7L,7L,0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L,3L,7L,4L,6L,7L,7L,0L,0L,2L,5L,8L,3L,9L,7L,9L,3L,2L,8L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021391Inst : IEnumerable<long>
{
public static readonly long[] Value=A021391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021391.Bytes);
public long this[int i]=>Value[i];

public static A021391Inst Instance=new A021391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021390
{
public static readonly long[] Value={ 0L,0L,2L,5L,9L,0L,6L,7L,3L,5L,7L,5L,1L,2L,9L,5L,3L,3L,6L,7L,8L,7L,5L,6L,4L,7L,6L,6L,8L,3L,9L,3L,7L,8L,2L,3L,8L,3L,4L,1L,9L,6L,8L,9L,1L,1L,9L,1L,7L,0L,9L,8L,4L,4L,5L,5L,9L,5L,8L,5L,4L,9L,2L,2L,2L,7L,9L,7L,9L,2L,7L,4L,6L,1L,1L,3L,9L,8L,9L,6L,3L,7L,3L,0L,5L,6L,9L,9L,4L,8L,1L,8L,6L,5L,2L,8L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021390Inst : IEnumerable<long>
{
public static readonly long[] Value=A021390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021390.Bytes);
public long this[int i]=>Value[i];

public static A021390Inst Instance=new A021390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021373
{
public static readonly long[] Value={ 0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L,1L,0L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021373Inst : IEnumerable<long>
{
public static readonly long[] Value=A021373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021373.Bytes);
public long this[int i]=>Value[i];

public static A021373Inst Instance=new A021373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021372
{
public static readonly long[] Value={ 0L,0L,2L,7L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021372Inst : IEnumerable<long>
{
public static readonly long[] Value=A021372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021372.Bytes);
public long this[int i]=>Value[i];

public static A021372Inst Instance=new A021372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021371
{
public static readonly long[] Value={ 0L,0L,2L,7L,2L,4L,7L,9L,5L,6L,4L,0L,3L,2L,6L,9L,7L,5L,4L,7L,6L,8L,3L,9L,2L,3L,7L,0L,5L,7L,2L,2L,0L,7L,0L,8L,4L,4L,6L,8L,6L,6L,4L,8L,5L,0L,1L,3L,6L,2L,3L,9L,7L,8L,2L,0L,1L,6L,3L,4L,8L,7L,7L,3L,8L,4L,1L,9L,6L,1L,8L,5L,2L,8L,6L,1L,0L,3L,5L,4L,2L,2L,3L,4L,3L,3L,2L,4L,2L,5L,0L,6L,8L,1L,1L,9L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021371Inst : IEnumerable<long>
{
public static readonly long[] Value=A021371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021371.Bytes);
public long this[int i]=>Value[i];

public static A021371Inst Instance=new A021371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021370
{
public static readonly long[] Value={ 0L,0L,2L,7L,3L,2L,2L,4L,0L,4L,3L,7L,1L,5L,8L,4L,6L,9L,9L,4L,5L,3L,5L,5L,1L,9L,1L,2L,5L,6L,8L,3L,0L,6L,0L,1L,0L,9L,2L,8L,9L,6L,1L,7L,4L,8L,6L,3L,3L,8L,7L,9L,7L,8L,1L,4L,2L,0L,7L,6L,5L,0L,2L,7L,3L,2L,2L,4L,0L,4L,3L,7L,1L,5L,8L,4L,6L,9L,9L,4L,5L,3L,5L,5L,1L,9L,1L,2L,5L,6L,8L,3L,0L,6L,0L,1L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021370Inst : IEnumerable<long>
{
public static readonly long[] Value=A021370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021370.Bytes);
public long this[int i]=>Value[i];

public static A021370Inst Instance=new A021370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021369
{
public static readonly long[] Value={ 0L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L,7L,3L,9L,7L,2L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021369Inst : IEnumerable<long>
{
public static readonly long[] Value=A021369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021369.Bytes);
public long this[int i]=>Value[i];

public static A021369Inst Instance=new A021369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021368
{
public static readonly long[] Value={ 0L,0L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L,7L,4L,7L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021368Inst : IEnumerable<long>
{
public static readonly long[] Value=A021368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021368.Bytes);
public long this[int i]=>Value[i];

public static A021368Inst Instance=new A021368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021367
{
public static readonly long[] Value={ 0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L,6L,6L,3L,9L,1L,1L,8L,4L,5L,7L,3L,0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L,6L,6L,3L,9L,1L,1L,8L,4L,5L,7L,3L,0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L,6L,6L,3L,9L,1L,1L,8L,4L,5L,7L,3L,0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L,6L,6L,3L,9L,1L,1L,8L,4L,5L,7L,3L,0L,0L,2L,7L,5L,4L,8L,2L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021367Inst : IEnumerable<long>
{
public static readonly long[] Value=A021367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021367.Bytes);
public long this[int i]=>Value[i];

public static A021367Inst Instance=new A021367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021366
{
public static readonly long[] Value={ 0L,0L,2L,7L,6L,2L,4L,3L,0L,9L,3L,9L,2L,2L,6L,5L,1L,9L,3L,3L,7L,0L,1L,6L,5L,7L,4L,5L,8L,5L,6L,3L,5L,3L,5L,9L,1L,1L,6L,0L,2L,2L,0L,9L,9L,4L,4L,7L,5L,1L,3L,8L,1L,2L,1L,5L,4L,6L,9L,6L,1L,3L,2L,5L,9L,6L,6L,8L,5L,0L,8L,2L,8L,7L,2L,9L,2L,8L,1L,7L,6L,7L,9L,5L,5L,8L,0L,1L,1L,0L,4L,9L,7L,2L,3L,7L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021366Inst : IEnumerable<long>
{
public static readonly long[] Value=A021366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021366.Bytes);
public long this[int i]=>Value[i];

public static A021366Inst Instance=new A021366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021365
{
public static readonly long[] Value={ 0L,0L,2L,7L,7L,0L,0L,8L,3L,1L,0L,2L,4L,9L,3L,0L,7L,4L,7L,9L,2L,2L,4L,3L,7L,6L,7L,3L,1L,3L,0L,1L,9L,3L,9L,0L,5L,8L,1L,7L,1L,7L,4L,5L,1L,5L,2L,3L,5L,4L,5L,7L,0L,6L,3L,7L,1L,1L,9L,1L,1L,3L,5L,7L,3L,4L,0L,7L,2L,0L,2L,2L,1L,6L,0L,6L,6L,4L,8L,1L,9L,9L,4L,4L,5L,9L,8L,3L,3L,7L,9L,5L,0L,1L,3L,8L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021365Inst : IEnumerable<long>
{
public static readonly long[] Value=A021365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021365.Bytes);
public long this[int i]=>Value[i];

public static A021365Inst Instance=new A021365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021364
{
public static readonly long[] Value={ 1L,15L,150L,1270L,9891L,73605L,533800L,3814140L,27018981L,190442395L,1338423450L,9390536610L,65820843271L,461096642385L,3229086629100L,22609268456680L,158287591978761L,1108104188689575L,7757094081310750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021364Inst : IEnumerable<long>
{
public static readonly long[] Value=A021364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021364.Bytes);
public long this[int i]=>Value[i];

public static A021364Inst Instance=new A021364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021363
{
public static readonly long[] Value={ 0L,0L,2L,7L,8L,5L,5L,1L,5L,3L,2L,0L,3L,3L,4L,2L,6L,1L,8L,3L,8L,4L,4L,0L,1L,1L,1L,4L,2L,0L,6L,1L,2L,8L,1L,3L,3L,7L,0L,4L,7L,3L,5L,3L,7L,6L,0L,4L,4L,5L,6L,8L,2L,4L,5L,1L,2L,5L,3L,4L,8L,1L,8L,9L,4L,1L,5L,0L,4L,1L,7L,8L,2L,7L,2L,9L,8L,0L,5L,0L,1L,3L,9L,2L,7L,5L,7L,6L,6L,0L,1L,6L,7L,1L,3L,0L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021363Inst : IEnumerable<long>
{
public static readonly long[] Value=A021363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021363.Bytes);
public long this[int i]=>Value[i];

public static A021363Inst Instance=new A021363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021362
{
public static readonly long[] Value={ 0L,0L,2L,7L,9L,3L,2L,9L,6L,0L,8L,9L,3L,8L,5L,4L,7L,4L,8L,6L,0L,3L,3L,5L,1L,9L,5L,5L,3L,0L,7L,2L,6L,2L,5L,6L,9L,8L,3L,2L,4L,0L,2L,2L,3L,4L,6L,3L,6L,8L,7L,1L,5L,0L,8L,3L,7L,9L,8L,8L,8L,2L,6L,8L,1L,5L,6L,4L,2L,4L,5L,8L,1L,0L,0L,5L,5L,8L,6L,5L,9L,2L,1L,7L,8L,7L,7L,0L,9L,4L,9L,7L,2L,0L,6L,7L,0L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021362Inst : IEnumerable<long>
{
public static readonly long[] Value=A021362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021362.Bytes);
public long this[int i]=>Value[i];

public static A021362Inst Instance=new A021362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021361
{
public static readonly long[] Value={ 0L,0L,2L,8L,0L,1L,1L,2L,0L,4L,4L,8L,1L,7L,9L,2L,7L,1L,7L,0L,8L,6L,8L,3L,4L,7L,3L,3L,8L,9L,3L,5L,5L,7L,4L,2L,2L,9L,6L,9L,1L,8L,7L,6L,7L,5L,0L,7L,0L,0L,2L,8L,0L,1L,1L,2L,0L,4L,4L,8L,1L,7L,9L,2L,7L,1L,7L,0L,8L,6L,8L,3L,4L,7L,3L,3L,8L,9L,3L,5L,5L,7L,4L,2L,2L,9L,6L,9L,1L,8L,7L,6L,7L,5L,0L,7L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021361Inst : IEnumerable<long>
{
public static readonly long[] Value=A021361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021361.Bytes);
public long this[int i]=>Value[i];

public static A021361Inst Instance=new A021361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021360
{
public static readonly long[] Value={ 0L,0L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021360Inst : IEnumerable<long>
{
public static readonly long[] Value=A021360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021360.Bytes);
public long this[int i]=>Value[i];

public static A021360Inst Instance=new A021360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021359
{
public static readonly long[] Value={ 0L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021359Inst : IEnumerable<long>
{
public static readonly long[] Value=A021359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021359.Bytes);
public long this[int i]=>Value[i];

public static A021359Inst Instance=new A021359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021358
{
public static readonly long[] Value={ 0L,0L,2L,8L,2L,4L,8L,5L,8L,7L,5L,7L,0L,6L,2L,1L,4L,6L,8L,9L,2L,6L,5L,5L,3L,6L,7L,2L,3L,1L,6L,3L,8L,4L,1L,8L,0L,7L,9L,0L,9L,6L,0L,4L,5L,1L,9L,7L,7L,4L,0L,1L,1L,2L,9L,9L,4L,3L,5L,0L,2L,8L,2L,4L,8L,5L,8L,7L,5L,7L,0L,6L,2L,1L,4L,6L,8L,9L,2L,6L,5L,5L,3L,6L,7L,2L,3L,1L,6L,3L,8L,4L,1L,8L,0L,7L,9L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021358Inst : IEnumerable<long>
{
public static readonly long[] Value=A021358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021358.Bytes);
public long this[int i]=>Value[i];

public static A021358Inst Instance=new A021358Inst();

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