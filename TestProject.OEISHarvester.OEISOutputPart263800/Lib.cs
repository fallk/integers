using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A021549
{
public static readonly long[] Value={ 0L,0L,1L,8L,3L,4L,8L,6L,2L,3L,8L,5L,3L,2L,1L,1L,0L,0L,9L,1L,7L,4L,3L,1L,1L,9L,2L,6L,6L,0L,5L,5L,0L,4L,5L,8L,7L,1L,5L,5L,9L,6L,3L,3L,0L,2L,7L,5L,2L,2L,9L,3L,5L,7L,7L,9L,8L,1L,6L,5L,1L,3L,7L,6L,1L,4L,6L,7L,8L,8L,9L,9L,0L,8L,2L,5L,6L,8L,8L,0L,7L,3L,3L,9L,4L,4L,9L,5L,4L,1L,2L,8L,4L,4L,0L,3L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021549Inst : IEnumerable<long>
{
public static readonly long[] Value=A021549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021549.Bytes);
public long this[int i]=>Value[i];

public static A021549Inst Instance=new A021549Inst();

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

public static class A021554
{
public static readonly long[] Value={ 0L,0L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021554Inst : IEnumerable<long>
{
public static readonly long[] Value=A021554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021554.Bytes);
public long this[int i]=>Value[i];

public static A021554Inst Instance=new A021554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021555
{
public static readonly long[] Value={ 0L,0L,1L,8L,1L,4L,8L,8L,2L,0L,3L,2L,6L,6L,7L,8L,7L,6L,5L,8L,8L,0L,2L,1L,7L,7L,8L,5L,8L,4L,3L,9L,2L,0L,1L,4L,5L,1L,9L,0L,5L,6L,2L,6L,1L,3L,4L,3L,0L,1L,2L,7L,0L,4L,1L,7L,4L,2L,2L,8L,6L,7L,5L,1L,3L,6L,1L,1L,6L,1L,5L,2L,4L,5L,0L,0L,9L,0L,7L,4L,4L,1L,0L,1L,6L,3L,3L,3L,9L,3L,8L,2L,9L,4L,0L,1L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021555Inst : IEnumerable<long>
{
public static readonly long[] Value=A021555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021555.Bytes);
public long this[int i]=>Value[i];

public static A021555Inst Instance=new A021555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021556
{
public static readonly long[] Value={ 0L,0L,1L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021556Inst : IEnumerable<long>
{
public static readonly long[] Value=A021556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021556.Bytes);
public long this[int i]=>Value[i];

public static A021556Inst Instance=new A021556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021557
{
public static readonly long[] Value={ 0L,0L,1L,8L,0L,8L,3L,1L,8L,2L,6L,4L,0L,1L,4L,4L,6L,6L,5L,4L,6L,1L,1L,2L,1L,1L,5L,7L,3L,2L,3L,6L,8L,8L,9L,6L,9L,2L,5L,8L,5L,8L,9L,5L,1L,1L,7L,5L,4L,0L,6L,8L,7L,1L,6L,0L,9L,4L,0L,3L,2L,5L,4L,9L,7L,2L,8L,7L,5L,2L,2L,6L,0L,3L,9L,7L,8L,3L,0L,0L,1L,8L,0L,8L,3L,1L,8L,2L,6L,4L,0L,1L,4L,4L,6L,6L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021557Inst : IEnumerable<long>
{
public static readonly long[] Value=A021557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021557.Bytes);
public long this[int i]=>Value[i];

public static A021557Inst Instance=new A021557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021558
{
public static readonly long[] Value={ 0L,0L,1L,8L,0L,5L,0L,5L,4L,1L,5L,1L,6L,2L,4L,5L,4L,8L,7L,3L,6L,4L,6L,2L,0L,9L,3L,8L,6L,2L,8L,1L,5L,8L,8L,4L,4L,7L,6L,5L,3L,4L,2L,9L,6L,0L,2L,8L,8L,8L,0L,8L,6L,6L,4L,2L,5L,9L,9L,2L,7L,7L,9L,7L,8L,3L,3L,9L,3L,5L,0L,1L,8L,0L,5L,0L,5L,4L,1L,5L,1L,6L,2L,4L,5L,4L,8L,7L,3L,6L,4L,6L,2L,0L,9L,3L,8L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021558Inst : IEnumerable<long>
{
public static readonly long[] Value=A021558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021558.Bytes);
public long this[int i]=>Value[i];

public static A021558Inst Instance=new A021558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021559
{
public static readonly long[] Value={ 0L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021559Inst : IEnumerable<long>
{
public static readonly long[] Value=A021559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021559.Bytes);
public long this[int i]=>Value[i];

public static A021559Inst Instance=new A021559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021560
{
public static readonly long[] Value={ 0L,0L,1L,7L,9L,8L,5L,6L,1L,1L,5L,1L,0L,7L,9L,1L,3L,6L,6L,9L,0L,6L,4L,7L,4L,8L,2L,0L,1L,4L,3L,8L,8L,4L,8L,9L,2L,0L,8L,6L,3L,3L,0L,9L,3L,5L,2L,5L,1L,7L,9L,8L,5L,6L,1L,1L,5L,1L,0L,7L,9L,1L,3L,6L,6L,9L,0L,6L,4L,7L,4L,8L,2L,0L,1L,4L,3L,8L,8L,4L,8L,9L,2L,0L,8L,6L,3L,3L,0L,9L,3L,5L,2L,5L,1L,7L,9L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021560Inst : IEnumerable<long>
{
public static readonly long[] Value=A021560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021560.Bytes);
public long this[int i]=>Value[i];

public static A021560Inst Instance=new A021560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021561
{
public static readonly long[] Value={ 0L,0L,1L,7L,9L,5L,3L,3L,2L,1L,3L,6L,4L,4L,5L,2L,4L,2L,3L,6L,9L,8L,3L,8L,4L,2L,0L,1L,0L,7L,7L,1L,9L,9L,2L,8L,1L,8L,6L,7L,1L,4L,5L,4L,2L,1L,9L,0L,3L,0L,5L,2L,0L,6L,4L,6L,3L,1L,9L,5L,6L,9L,1L,2L,0L,2L,8L,7L,2L,5L,3L,1L,4L,1L,8L,3L,1L,2L,3L,8L,7L,7L,9L,1L,7L,4L,1L,4L,7L,2L,1L,7L,2L,3L,5L,1L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021561Inst : IEnumerable<long>
{
public static readonly long[] Value=A021561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021561.Bytes);
public long this[int i]=>Value[i];

public static A021561Inst Instance=new A021561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021562
{
public static readonly long[] Value={ 0L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L,6L,9L,5L,3L,4L,0L,5L,0L,1L,7L,9L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021562Inst : IEnumerable<long>
{
public static readonly long[] Value=A021562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021562.Bytes);
public long this[int i]=>Value[i];

public static A021562Inst Instance=new A021562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021563
{
public static readonly long[] Value={ 0L,0L,1L,7L,8L,8L,9L,0L,8L,7L,6L,5L,6L,5L,2L,9L,5L,1L,6L,9L,9L,4L,6L,3L,3L,2L,7L,3L,7L,0L,3L,0L,4L,1L,1L,4L,4L,9L,0L,1L,6L,1L,0L,0L,1L,7L,8L,8L,9L,0L,8L,7L,6L,5L,6L,5L,2L,9L,5L,1L,6L,9L,9L,4L,6L,3L,3L,2L,7L,3L,7L,0L,3L,0L,4L,1L,1L,4L,4L,9L,0L,1L,6L,1L,0L,0L,1L,7L,8L,8L,9L,0L,8L,7L,6L,5L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021563Inst : IEnumerable<long>
{
public static readonly long[] Value=A021563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021563.Bytes);
public long this[int i]=>Value[i];

public static A021563Inst Instance=new A021563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021564
{
public static readonly long[] Value={ 0L,0L,1L,7L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021564Inst : IEnumerable<long>
{
public static readonly long[] Value=A021564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021564.Bytes);
public long this[int i]=>Value[i];

public static A021564Inst Instance=new A021564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021581
{
public static readonly long[] Value={ 0L,0L,1L,7L,3L,3L,1L,0L,2L,2L,5L,3L,0L,3L,2L,9L,2L,8L,9L,4L,2L,8L,0L,7L,6L,2L,5L,6L,4L,9L,9L,1L,3L,3L,4L,4L,8L,8L,7L,3L,4L,8L,3L,5L,3L,5L,5L,2L,8L,5L,9L,6L,1L,8L,7L,1L,7L,5L,0L,4L,3L,3L,2L,7L,5L,5L,6L,3L,2L,5L,8L,2L,3L,2L,2L,3L,5L,7L,0L,1L,9L,0L,6L,4L,1L,2L,4L,7L,8L,3L,3L,6L,2L,2L,1L,8L,3L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021581Inst : IEnumerable<long>
{
public static readonly long[] Value=A021581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021581.Bytes);
public long this[int i]=>Value[i];

public static A021581Inst Instance=new A021581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021582
{
public static readonly long[] Value={ 0L,0L,1L,7L,3L,0L,1L,0L,3L,8L,0L,6L,2L,2L,8L,3L,7L,3L,7L,0L,2L,4L,2L,2L,1L,4L,5L,3L,2L,8L,7L,1L,9L,7L,2L,3L,1L,8L,3L,3L,9L,1L,0L,0L,3L,4L,6L,0L,2L,0L,7L,6L,1L,2L,4L,5L,6L,7L,4L,7L,4L,0L,4L,8L,4L,4L,2L,9L,0L,6L,5L,7L,4L,3L,9L,4L,4L,6L,3L,6L,6L,7L,8L,2L,0L,0L,6L,9L,2L,0L,4L,1L,5L,2L,2L,4L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021582Inst : IEnumerable<long>
{
public static readonly long[] Value=A021582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021582.Bytes);
public long this[int i]=>Value[i];

public static A021582Inst Instance=new A021582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021583
{
public static readonly long[] Value={ 0L,0L,1L,7L,2L,7L,1L,1L,5L,7L,1L,6L,7L,5L,3L,0L,2L,2L,4L,5L,2L,5L,0L,4L,3L,1L,7L,7L,8L,9L,2L,9L,1L,8L,8L,2L,5L,5L,6L,1L,3L,1L,2L,6L,0L,7L,9L,4L,4L,7L,3L,2L,2L,9L,7L,0L,6L,3L,9L,0L,3L,2L,8L,1L,5L,1L,9L,8L,6L,1L,8L,3L,0L,7L,4L,2L,6L,5L,9L,7L,5L,8L,2L,0L,3L,7L,9L,9L,6L,5L,4L,5L,7L,6L,8L,5L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021583Inst : IEnumerable<long>
{
public static readonly long[] Value=A021583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021583.Bytes);
public long this[int i]=>Value[i];

public static A021583Inst Instance=new A021583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021584
{
public static readonly long[] Value={ 0L,0L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021584Inst : IEnumerable<long>
{
public static readonly long[] Value=A021584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021584.Bytes);
public long this[int i]=>Value[i];

public static A021584Inst Instance=new A021584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021585
{
public static readonly long[] Value={ 0L,0L,1L,7L,2L,1L,1L,7L,0L,3L,9L,5L,8L,6L,9L,1L,9L,1L,0L,4L,9L,9L,1L,3L,9L,4L,1L,4L,8L,0L,2L,0L,6L,5L,4L,0L,4L,4L,7L,5L,0L,4L,3L,0L,2L,9L,2L,5L,9L,8L,9L,6L,7L,2L,9L,7L,7L,6L,2L,4L,7L,8L,4L,8L,5L,3L,7L,0L,0L,5L,1L,6L,3L,5L,1L,1L,1L,8L,7L,6L,0L,7L,5L,7L,3L,1L,4L,9L,7L,4L,1L,8L,2L,4L,4L,4L,0L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021585Inst : IEnumerable<long>
{
public static readonly long[] Value=A021585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021585.Bytes);
public long this[int i]=>Value[i];

public static A021585Inst Instance=new A021585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021586
{
public static readonly long[] Value={ 0L,0L,1L,7L,1L,8L,2L,1L,3L,0L,5L,8L,4L,1L,9L,2L,4L,3L,9L,8L,6L,2L,5L,4L,2L,9L,5L,5L,3L,2L,6L,4L,6L,0L,4L,8L,1L,0L,9L,9L,6L,5L,6L,3L,5L,7L,3L,8L,8L,3L,1L,6L,1L,5L,1L,2L,0L,2L,7L,4L,9L,1L,4L,0L,8L,9L,3L,4L,7L,0L,7L,9L,0L,3L,7L,8L,0L,0L,6L,8L,7L,2L,8L,5L,2L,2L,3L,3L,6L,7L,6L,9L,7L,5L,9L,4L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021586Inst : IEnumerable<long>
{
public static readonly long[] Value=A021586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021586.Bytes);
public long this[int i]=>Value[i];

public static A021586Inst Instance=new A021586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021587
{
public static readonly long[] Value={ 0L,0L,1L,7L,1L,5L,2L,6L,5L,8L,6L,6L,2L,0L,9L,2L,6L,2L,4L,3L,5L,6L,7L,7L,5L,3L,0L,0L,1L,7L,1L,5L,2L,6L,5L,8L,6L,6L,2L,0L,9L,2L,6L,2L,4L,3L,5L,6L,7L,7L,5L,3L,0L,0L,1L,7L,1L,5L,2L,6L,5L,8L,6L,6L,2L,0L,9L,2L,6L,2L,4L,3L,5L,6L,7L,7L,5L,3L,0L,0L,1L,7L,1L,5L,2L,6L,5L,8L,6L,6L,2L,0L,9L,2L,6L,2L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021587Inst : IEnumerable<long>
{
public static readonly long[] Value=A021587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021587.Bytes);
public long this[int i]=>Value[i];

public static A021587Inst Instance=new A021587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021588
{
public static readonly long[] Value={ 0L,0L,1L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L,7L,1L,2L,3L,2L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021588Inst : IEnumerable<long>
{
public static readonly long[] Value=A021588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021588.Bytes);
public long this[int i]=>Value[i];

public static A021588Inst Instance=new A021588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021589
{
public static readonly long[] Value={ 0L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L,7L,0L,9L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021589Inst : IEnumerable<long>
{
public static readonly long[] Value=A021589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021589.Bytes);
public long this[int i]=>Value[i];

public static A021589Inst Instance=new A021589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021590
{
public static readonly long[] Value={ 0L,0L,1L,7L,0L,6L,4L,8L,4L,6L,4L,1L,6L,3L,8L,2L,2L,5L,2L,5L,5L,9L,7L,2L,6L,9L,6L,2L,4L,5L,7L,3L,3L,7L,8L,8L,3L,9L,5L,9L,0L,4L,4L,3L,6L,8L,6L,0L,0L,6L,8L,2L,5L,9L,3L,8L,5L,6L,6L,5L,5L,2L,9L,0L,1L,0L,2L,3L,8L,9L,0L,7L,8L,4L,9L,8L,2L,9L,3L,5L,1L,5L,3L,5L,8L,3L,6L,1L,7L,7L,4L,7L,4L,4L,0L,2L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021590Inst : IEnumerable<long>
{
public static readonly long[] Value=A021590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021590.Bytes);
public long this[int i]=>Value[i];

public static A021590Inst Instance=new A021590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021591
{
public static readonly long[] Value={ 0L,0L,1L,7L,0L,3L,5L,7L,7L,5L,1L,2L,7L,7L,6L,8L,3L,1L,3L,4L,5L,8L,2L,6L,2L,3L,5L,0L,9L,3L,6L,9L,6L,7L,6L,3L,2L,0L,2L,7L,2L,5L,7L,2L,4L,0L,2L,0L,4L,4L,2L,9L,3L,0L,1L,5L,3L,3L,2L,1L,9L,7L,6L,1L,4L,9L,9L,1L,4L,8L,2L,1L,1L,2L,4L,3L,6L,1L,1L,5L,8L,4L,3L,2L,7L,0L,8L,6L,8L,8L,2L,4L,5L,3L,1L,5L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021591Inst : IEnumerable<long>
{
public static readonly long[] Value=A021591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021591.Bytes);
public long this[int i]=>Value[i];

public static A021591Inst Instance=new A021591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021592
{
public static readonly long[] Value={ 0L,0L,1L,7L,0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L,8L,4L,3L,5L,3L,7L,4L,1L,4L,9L,6L,5L,9L,8L,6L,3L,9L,4L,5L,5L,7L,8L,2L,3L,1L,2L,9L,2L,5L,1L,7L,0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L,8L,4L,3L,5L,3L,7L,4L,1L,4L,9L,6L,5L,9L,8L,6L,3L,9L,4L,5L,5L,7L,8L,2L,3L,1L,2L,9L,2L,5L,1L,7L,0L,0L,6L,8L,0L,2L,7L,2L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021592Inst : IEnumerable<long>
{
public static readonly long[] Value=A021592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021592.Bytes);
public long this[int i]=>Value[i];

public static A021592Inst Instance=new A021592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021593
{
public static readonly long[] Value={ 0L,0L,1L,6L,9L,7L,7L,9L,2L,8L,6L,9L,2L,6L,9L,9L,4L,9L,0L,6L,6L,2L,1L,3L,9L,2L,1L,9L,0L,1L,5L,2L,8L,0L,1L,3L,5L,8L,2L,3L,4L,2L,9L,5L,4L,1L,5L,9L,5L,9L,2L,5L,2L,9L,7L,1L,1L,3L,7L,5L,2L,1L,2L,2L,2L,4L,1L,0L,8L,6L,5L,8L,7L,4L,3L,6L,3L,3L,2L,7L,6L,7L,4L,0L,2L,3L,7L,6L,9L,1L,0L,0L,1L,6L,9L,7L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021593Inst : IEnumerable<long>
{
public static readonly long[] Value=A021593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021593.Bytes);
public long this[int i]=>Value[i];

public static A021593Inst Instance=new A021593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021594
{
public static readonly long[] Value={ 1L,20L,270L,3100L,32711L,328440L,3195340L,30437000L,285695421L,2653625260L,24459281210L,224170373700L,2045792060131L,18609941810480L,168874176353880L,1529560509125200L,13833895100278841L,124980009723284100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021594Inst : IEnumerable<long>
{
public static readonly long[] Value=A021594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021594.Bytes);
public long this[int i]=>Value[i];

public static A021594Inst Instance=new A021594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021595
{
public static readonly long[] Value={ 0L,0L,1L,6L,9L,2L,0L,4L,7L,3L,7L,7L,3L,2L,6L,5L,6L,5L,1L,4L,3L,8L,2L,4L,0L,2L,7L,0L,7L,2L,7L,5L,8L,0L,3L,7L,2L,2L,5L,0L,4L,2L,3L,0L,1L,1L,8L,4L,4L,3L,3L,1L,6L,4L,1L,2L,8L,5L,9L,5L,6L,0L,0L,6L,7L,6L,8L,1L,8L,9L,5L,0L,9L,3L,0L,6L,2L,6L,0L,5L,7L,5L,2L,9L,6L,1L,0L,8L,2L,9L,1L,0L,3L,2L,1L,4L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021595Inst : IEnumerable<long>
{
public static readonly long[] Value=A021595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021595.Bytes);
public long this[int i]=>Value[i];

public static A021595Inst Instance=new A021595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021596
{
public static readonly long[] Value={ 0L,0L,1L,6L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L,1L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021596Inst : IEnumerable<long>
{
public static readonly long[] Value=A021596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021596.Bytes);
public long this[int i]=>Value[i];

public static A021596Inst Instance=new A021596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021613
{
public static readonly long[] Value={ 0L,0L,1L,6L,4L,2L,0L,3L,6L,1L,2L,4L,7L,9L,4L,7L,4L,5L,4L,8L,4L,4L,0L,0L,6L,5L,6L,8L,1L,4L,4L,4L,9L,9L,1L,7L,8L,9L,8L,1L,9L,3L,7L,6L,0L,2L,6L,2L,7L,2L,5L,7L,7L,9L,9L,6L,7L,1L,5L,9L,2L,7L,7L,5L,0L,4L,1L,0L,5L,0L,9L,0L,3L,1L,1L,9L,8L,6L,8L,6L,3L,7L,1L,1L,0L,0L,1L,6L,4L,2L,0L,3L,6L,1L,2L,4L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021613Inst : IEnumerable<long>
{
public static readonly long[] Value=A021613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021613.Bytes);
public long this[int i]=>Value[i];

public static A021613Inst Instance=new A021613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021614
{
public static readonly long[] Value={ 1L,22L,332L,4322L,52353L,609924L,6948544L,78112924L,871004585L,9663416906L,106874239836L,1179653481006L,13004446987897L,143246730136168L,1577098731557408L,17357778969071768L,191003419177941489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021614Inst : IEnumerable<long>
{
public static readonly long[] Value=A021614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021614.Bytes);
public long this[int i]=>Value[i];

public static A021614Inst Instance=new A021614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021615
{
public static readonly long[] Value={ 0L,0L,1L,6L,3L,6L,6L,6L,1L,2L,1L,1L,1L,2L,9L,2L,9L,6L,2L,3L,5L,6L,7L,9L,2L,1L,4L,4L,0L,2L,6L,1L,8L,6L,5L,7L,9L,3L,7L,8L,0L,6L,8L,7L,3L,9L,7L,7L,0L,8L,6L,7L,4L,3L,0L,4L,4L,1L,8L,9L,8L,5L,2L,7L,0L,0L,4L,9L,0L,9L,9L,8L,3L,6L,3L,3L,3L,8L,7L,8L,8L,8L,7L,0L,7L,0L,3L,7L,6L,4L,3L,2L,0L,7L,8L,5L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021615Inst : IEnumerable<long>
{
public static readonly long[] Value=A021615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021615.Bytes);
public long this[int i]=>Value[i];

public static A021615Inst Instance=new A021615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021616
{
public static readonly long[] Value={ 0L,0L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L,6L,3L,3L,9L,8L,6L,9L,2L,8L,1L,0L,4L,5L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021616Inst : IEnumerable<long>
{
public static readonly long[] Value=A021616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021616.Bytes);
public long this[int i]=>Value[i];

public static A021616Inst Instance=new A021616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021617
{
public static readonly long[] Value={ 0L,0L,1L,6L,3L,1L,3L,2L,1L,3L,7L,0L,3L,0L,9L,9L,5L,1L,0L,6L,0L,3L,5L,8L,8L,9L,0L,7L,0L,1L,4L,6L,8L,1L,8L,9L,2L,3L,3L,2L,7L,8L,9L,5L,5L,9L,5L,4L,3L,2L,3L,0L,0L,1L,6L,3L,1L,3L,2L,1L,3L,7L,0L,3L,0L,9L,9L,5L,1L,0L,6L,0L,3L,5L,8L,8L,9L,0L,7L,0L,1L,4L,6L,8L,1L,8L,9L,2L,3L,3L,2L,7L,8L,9L,5L,5L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021617Inst : IEnumerable<long>
{
public static readonly long[] Value=A021617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021617.Bytes);
public long this[int i]=>Value[i];

public static A021617Inst Instance=new A021617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021618
{
public static readonly long[] Value={ 0L,0L,1L,6L,2L,8L,6L,6L,4L,4L,9L,5L,1L,1L,4L,0L,0L,6L,5L,1L,4L,6L,5L,7L,9L,8L,0L,4L,5L,6L,0L,2L,6L,0L,5L,8L,6L,3L,1L,9L,2L,1L,8L,2L,4L,1L,0L,4L,2L,3L,4L,5L,2L,7L,6L,8L,7L,2L,9L,6L,4L,1L,6L,9L,3L,8L,1L,1L,0L,7L,4L,9L,1L,8L,5L,6L,6L,7L,7L,5L,2L,4L,4L,2L,9L,9L,6L,7L,4L,2L,6L,7L,1L,0L,0L,9L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021618Inst : IEnumerable<long>
{
public static readonly long[] Value=A021618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021618.Bytes);
public long this[int i]=>Value[i];

public static A021618Inst Instance=new A021618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021619
{
public static readonly long[] Value={ 0L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L,2L,6L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021619Inst : IEnumerable<long>
{
public static readonly long[] Value=A021619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021619.Bytes);
public long this[int i]=>Value[i];

public static A021619Inst Instance=new A021619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021620
{
public static readonly long[] Value={ 0L,0L,1L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L,6L,2L,3L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021620Inst : IEnumerable<long>
{
public static readonly long[] Value=A021620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021620.Bytes);
public long this[int i]=>Value[i];

public static A021620Inst Instance=new A021620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021621
{
public static readonly long[] Value={ 0L,0L,1L,6L,2L,0L,7L,4L,5L,5L,4L,2L,9L,4L,9L,7L,5L,6L,8L,8L,8L,1L,6L,8L,5L,5L,7L,5L,3L,6L,4L,6L,6L,7L,7L,4L,7L,1L,6L,3L,6L,9L,5L,2L,9L,9L,8L,3L,7L,9L,2L,5L,4L,4L,5L,7L,0L,5L,0L,2L,4L,3L,1L,1L,1L,8L,3L,1L,4L,4L,2L,4L,6L,3L,5L,3L,3L,2L,2L,5L,2L,8L,3L,6L,3L,0L,4L,7L,0L,0L,1L,6L,2L,0L,7L,4L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021621Inst : IEnumerable<long>
{
public static readonly long[] Value=A021621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021621.Bytes);
public long this[int i]=>Value[i];

public static A021621Inst Instance=new A021621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021622
{
public static readonly long[] Value={ 0L,0L,1L,6L,1L,8L,1L,2L,2L,9L,7L,7L,3L,4L,6L,2L,7L,8L,3L,1L,7L,1L,5L,2L,1L,0L,3L,5L,5L,9L,8L,7L,0L,5L,5L,0L,1L,6L,1L,8L,1L,2L,2L,9L,7L,7L,3L,4L,6L,2L,7L,8L,3L,1L,7L,1L,5L,2L,1L,0L,3L,5L,5L,9L,8L,7L,0L,5L,5L,0L,1L,6L,1L,8L,1L,2L,2L,9L,7L,7L,3L,4L,6L,2L,7L,8L,3L,1L,7L,1L,5L,2L,1L,0L,3L,5L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021622Inst : IEnumerable<long>
{
public static readonly long[] Value=A021622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021622.Bytes);
public long this[int i]=>Value[i];

public static A021622Inst Instance=new A021622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021623
{
public static readonly long[] Value={ 0L,0L,1L,6L,1L,5L,5L,0L,8L,8L,8L,5L,2L,9L,8L,8L,6L,9L,1L,4L,3L,7L,8L,0L,2L,9L,0L,7L,9L,1L,5L,9L,9L,3L,5L,3L,7L,9L,6L,4L,4L,5L,8L,8L,0L,4L,5L,2L,3L,4L,2L,4L,8L,7L,8L,8L,3L,6L,8L,3L,3L,6L,0L,2L,5L,8L,4L,8L,1L,4L,2L,1L,6L,4L,7L,8L,1L,9L,0L,6L,3L,0L,0L,4L,8L,4L,6L,5L,2L,6L,6L,5L,5L,8L,9L,6L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021623Inst : IEnumerable<long>
{
public static readonly long[] Value=A021623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021623.Bytes);
public long this[int i]=>Value[i];

public static A021623Inst Instance=new A021623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021624
{
public static readonly long[] Value={ 0L,0L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021624Inst : IEnumerable<long>
{
public static readonly long[] Value=A021624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021624.Bytes);
public long this[int i]=>Value[i];

public static A021624Inst Instance=new A021624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021625
{
public static readonly long[] Value={ 0L,0L,1L,6L,1L,0L,3L,0L,5L,9L,5L,8L,1L,3L,2L,0L,4L,5L,0L,8L,8L,5L,6L,6L,8L,2L,7L,6L,9L,7L,2L,6L,2L,4L,7L,9L,8L,7L,1L,1L,7L,5L,5L,2L,3L,3L,4L,9L,4L,3L,6L,3L,9L,2L,9L,1L,4L,6L,5L,3L,7L,8L,4L,2L,1L,9L,0L,0L,1L,6L,1L,0L,3L,0L,5L,9L,5L,8L,1L,3L,2L,0L,4L,5L,0L,8L,8L,5L,6L,6L,8L,2L,7L,6L,9L,7L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021625Inst : IEnumerable<long>
{
public static readonly long[] Value=A021625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021625.Bytes);
public long this[int i]=>Value[i];

public static A021625Inst Instance=new A021625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021626
{
public static readonly long[] Value={ 0L,0L,1L,6L,0L,7L,7L,1L,7L,0L,4L,1L,8L,0L,0L,6L,4L,3L,0L,8L,6L,8L,1L,6L,7L,2L,0L,2L,5L,7L,2L,3L,4L,7L,2L,6L,6L,8L,8L,1L,0L,2L,8L,9L,3L,8L,9L,0L,6L,7L,5L,2L,4L,1L,1L,5L,7L,5L,5L,6L,2L,7L,0L,0L,9L,6L,4L,6L,3L,0L,2L,2L,5L,0L,8L,0L,3L,8L,5L,8L,5L,2L,0L,9L,0L,0L,3L,2L,1L,5L,4L,3L,4L,0L,8L,3L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021626Inst : IEnumerable<long>
{
public static readonly long[] Value=A021626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021626.Bytes);
public long this[int i]=>Value[i];

public static A021626Inst Instance=new A021626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021627
{
public static readonly long[] Value={ 0L,0L,1L,6L,0L,5L,1L,3L,6L,4L,3L,6L,5L,9L,7L,1L,1L,0L,7L,5L,4L,4L,1L,4L,1L,2L,5L,2L,0L,0L,6L,4L,2L,0L,5L,4L,5L,7L,4L,6L,3L,8L,8L,4L,4L,3L,0L,1L,7L,6L,5L,6L,5L,0L,0L,8L,0L,2L,5L,6L,8L,2L,1L,8L,2L,9L,8L,5L,5L,5L,3L,7L,7L,2L,0L,7L,0L,6L,2L,6L,0L,0L,3L,2L,1L,0L,2L,7L,2L,8L,7L,3L,1L,9L,4L,2L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021627Inst : IEnumerable<long>
{
public static readonly long[] Value=A021627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021627.Bytes);
public long this[int i]=>Value[i];

public static A021627Inst Instance=new A021627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021628
{
public static readonly long[] Value={ 0L,0L,1L,6L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021628Inst : IEnumerable<long>
{
public static readonly long[] Value=A021628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021628.Bytes);
public long this[int i]=>Value[i];

public static A021628Inst Instance=new A021628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021661
{
public static readonly long[] Value={ 0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L,5L,2L,2L,0L,7L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021661Inst : IEnumerable<long>
{
public static readonly long[] Value=A021661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021661.Bytes);
public long this[int i]=>Value[i];

public static A021661Inst Instance=new A021661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021662
{
public static readonly long[] Value={ 0L,0L,1L,5L,1L,9L,7L,5L,6L,8L,3L,8L,9L,0L,5L,7L,7L,5L,0L,7L,5L,9L,8L,7L,8L,4L,1L,9L,4L,5L,2L,8L,8L,7L,5L,3L,7L,9L,9L,3L,9L,2L,0L,9L,7L,2L,6L,4L,4L,3L,7L,6L,8L,9L,9L,6L,9L,6L,0L,4L,8L,6L,3L,2L,2L,1L,8L,8L,4L,4L,9L,8L,4L,8L,0L,2L,4L,3L,1L,6L,1L,0L,9L,4L,2L,2L,4L,9L,2L,4L,0L,1L,2L,1L,5L,8L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021662Inst : IEnumerable<long>
{
public static readonly long[] Value=A021662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021662.Bytes);
public long this[int i]=>Value[i];

public static A021662Inst Instance=new A021662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021663
{
public static readonly long[] Value={ 0L,0L,1L,5L,1L,7L,4L,5L,0L,6L,8L,2L,8L,5L,2L,8L,0L,7L,2L,8L,3L,7L,6L,3L,2L,7L,7L,6L,9L,3L,4L,7L,4L,9L,6L,2L,0L,6L,3L,7L,3L,2L,9L,2L,8L,6L,7L,9L,8L,1L,7L,9L,0L,5L,9L,1L,8L,0L,5L,7L,6L,6L,3L,1L,2L,5L,9L,4L,8L,4L,0L,6L,6L,7L,6L,7L,8L,3L,0L,0L,4L,5L,5L,2L,3L,5L,2L,0L,4L,8L,5L,5L,8L,4L,2L,1L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021663Inst : IEnumerable<long>
{
public static readonly long[] Value=A021663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021663.Bytes);
public long this[int i]=>Value[i];

public static A021663Inst Instance=new A021663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021664
{
public static readonly long[] Value={ 1L,23L,362L,4894L,61251L,733461L,8546764L,97847228L,1106991941L,12422320339L,138608884206L,1540404875802L,17070111627271L,188776494239057L,2084583574516688L,22994756444303416L,253457017948866441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021664Inst : IEnumerable<long>
{
public static readonly long[] Value=A021664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021664.Bytes);
public long this[int i]=>Value[i];

public static A021664Inst Instance=new A021664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021665
{
public static readonly long[] Value={ 0L,0L,1L,5L,1L,2L,8L,5L,9L,3L,0L,4L,0L,8L,4L,7L,2L,0L,1L,2L,1L,0L,2L,8L,7L,4L,4L,3L,2L,6L,7L,7L,7L,6L,0L,9L,6L,8L,2L,2L,9L,9L,5L,4L,6L,1L,4L,2L,2L,0L,8L,7L,7L,4L,5L,8L,3L,9L,6L,3L,6L,9L,1L,3L,7L,6L,7L,0L,1L,9L,6L,6L,7L,1L,7L,0L,9L,5L,3L,1L,0L,1L,3L,6L,1L,5L,7L,3L,3L,7L,3L,6L,7L,6L,2L,4L,8L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021665Inst : IEnumerable<long>
{
public static readonly long[] Value=A021665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021665.Bytes);
public long this[int i]=>Value[i];

public static A021665Inst Instance=new A021665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021666
{
public static readonly long[] Value={ 0L,0L,1L,5L,1L,0L,5L,7L,4L,0L,1L,8L,1L,2L,6L,8L,8L,8L,2L,1L,7L,5L,2L,2L,6L,5L,8L,6L,1L,0L,2L,7L,1L,9L,0L,3L,3L,2L,3L,2L,6L,2L,8L,3L,9L,8L,7L,9L,1L,5L,4L,0L,7L,8L,5L,4L,9L,8L,4L,8L,9L,4L,2L,5L,9L,8L,1L,8L,7L,3L,1L,1L,1L,7L,8L,2L,4L,7L,7L,3L,4L,1L,3L,8L,9L,7L,2L,8L,0L,9L,6L,6L,7L,6L,7L,3L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021666Inst : IEnumerable<long>
{
public static readonly long[] Value=A021666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021666.Bytes);
public long this[int i]=>Value[i];

public static A021666Inst Instance=new A021666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021667
{
public static readonly long[] Value={ 0L,0L,1L,5L,0L,8L,2L,9L,5L,6L,2L,5L,9L,4L,2L,6L,8L,4L,7L,6L,6L,2L,1L,4L,1L,7L,7L,9L,7L,8L,8L,8L,3L,8L,6L,1L,2L,3L,6L,8L,0L,2L,4L,1L,3L,2L,7L,3L,0L,0L,1L,5L,0L,8L,2L,9L,5L,6L,2L,5L,9L,4L,2L,6L,8L,4L,7L,6L,6L,2L,1L,4L,1L,7L,7L,9L,7L,8L,8L,8L,3L,8L,6L,1L,2L,3L,6L,8L,0L,2L,4L,1L,3L,2L,7L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021667Inst : IEnumerable<long>
{
public static readonly long[] Value=A021667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021667.Bytes);
public long this[int i]=>Value[i];

public static A021667Inst Instance=new A021667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021668
{
public static readonly long[] Value={ 0L,0L,1L,5L,0L,6L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L,2L,1L,6L,8L,6L,7L,4L,6L,9L,8L,7L,9L,5L,1L,8L,0L,7L,2L,2L,8L,9L,1L,5L,6L,6L,2L,6L,5L,0L,6L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L,2L,1L,6L,8L,6L,7L,4L,6L,9L,8L,7L,9L,5L,1L,8L,0L,7L,2L,2L,8L,9L,1L,5L,6L,6L,2L,6L,5L,0L,6L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021668Inst : IEnumerable<long>
{
public static readonly long[] Value=A021668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021668.Bytes);
public long this[int i]=>Value[i];

public static A021668Inst Instance=new A021668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021669
{
public static readonly long[] Value={ 0L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021669Inst : IEnumerable<long>
{
public static readonly long[] Value=A021669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021669.Bytes);
public long this[int i]=>Value[i];

public static A021669Inst Instance=new A021669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021670
{
public static readonly long[] Value={ 0L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021670Inst : IEnumerable<long>
{
public static readonly long[] Value=A021670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021670.Bytes);
public long this[int i]=>Value[i];

public static A021670Inst Instance=new A021670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021671
{
public static readonly long[] Value={ 0L,0L,1L,4L,9L,9L,2L,5L,0L,3L,7L,4L,8L,1L,2L,5L,9L,3L,7L,0L,3L,1L,4L,8L,4L,2L,5L,7L,8L,7L,1L,0L,6L,4L,4L,6L,7L,7L,6L,6L,1L,1L,6L,9L,4L,1L,5L,2L,9L,2L,3L,5L,3L,8L,2L,3L,0L,8L,8L,4L,5L,5L,7L,7L,2L,1L,1L,3L,9L,4L,3L,0L,2L,8L,4L,8L,5L,7L,5L,7L,1L,2L,1L,4L,3L,9L,2L,8L,0L,3L,5L,9L,8L,2L,0L,0L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021671Inst : IEnumerable<long>
{
public static readonly long[] Value=A021671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021671.Bytes);
public long this[int i]=>Value[i];

public static A021671Inst Instance=new A021671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021672
{
public static readonly long[] Value={ 0L,0L,1L,4L,9L,7L,0L,0L,5L,9L,8L,8L,0L,2L,3L,9L,5L,2L,0L,9L,5L,8L,0L,8L,3L,8L,3L,2L,3L,3L,5L,3L,2L,9L,3L,4L,1L,3L,1L,7L,3L,6L,5L,2L,6L,9L,4L,6L,1L,0L,7L,7L,8L,4L,4L,3L,1L,1L,3L,7L,7L,2L,4L,5L,5L,0L,8L,9L,8L,2L,0L,3L,5L,9L,2L,8L,1L,4L,3L,7L,1L,2L,5L,7L,4L,8L,5L,0L,2L,9L,9L,4L,0L,1L,1L,9L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021672Inst : IEnumerable<long>
{
public static readonly long[] Value=A021672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021672.Bytes);
public long this[int i]=>Value[i];

public static A021672Inst Instance=new A021672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021673
{
public static readonly long[] Value={ 0L,0L,1L,4L,9L,4L,7L,6L,8L,3L,1L,0L,9L,1L,1L,8L,0L,8L,6L,6L,9L,6L,5L,6L,2L,0L,3L,2L,8L,8L,4L,9L,0L,2L,8L,4L,0L,0L,5L,9L,7L,9L,0L,7L,3L,2L,4L,3L,6L,4L,7L,2L,3L,4L,6L,7L,8L,6L,2L,4L,8L,1L,3L,1L,5L,3L,9L,6L,1L,1L,3L,6L,0L,2L,3L,9L,1L,6L,2L,9L,2L,9L,7L,4L,5L,8L,8L,9L,3L,8L,7L,1L,4L,4L,9L,9L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021673Inst : IEnumerable<long>
{
public static readonly long[] Value=A021673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021673.Bytes);
public long this[int i]=>Value[i];

public static A021673Inst Instance=new A021673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021674
{
public static readonly long[] Value={ 1L,24L,397L,5676L,75529L,966048L,12071269L,148688052L,1814929057L,22024557672L,266258052541L,3210803780028L,38655303353785L,464868906584496L,5586469016901013L,67101965327432004L,805738280990712913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021674Inst : IEnumerable<long>
{
public static readonly long[] Value=A021674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021674.Bytes);
public long this[int i]=>Value[i];

public static A021674Inst Instance=new A021674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021675
{
public static readonly long[] Value={ 0L,0L,1L,4L,9L,0L,3L,1L,2L,9L,6L,5L,7L,2L,2L,8L,0L,1L,7L,8L,8L,3L,7L,5L,5L,5L,8L,8L,6L,7L,3L,6L,2L,1L,4L,6L,0L,5L,0L,6L,7L,0L,6L,4L,0L,8L,3L,4L,5L,7L,5L,2L,6L,0L,8L,0L,4L,7L,6L,9L,0L,0L,1L,4L,9L,0L,3L,1L,2L,9L,6L,5L,7L,2L,2L,8L,0L,1L,7L,8L,8L,3L,7L,5L,5L,5L,8L,8L,6L,7L,3L,6L,2L,1L,4L,6L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021675Inst : IEnumerable<long>
{
public static readonly long[] Value=A021675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021675.Bytes);
public long this[int i]=>Value[i];

public static A021675Inst Instance=new A021675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021676
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021676Inst : IEnumerable<long>
{
public static readonly long[] Value=A021676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021676.Bytes);
public long this[int i]=>Value[i];

public static A021676Inst Instance=new A021676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021677
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,5L,8L,8L,4L,1L,0L,1L,0L,4L,0L,1L,1L,8L,8L,7L,0L,7L,2L,8L,0L,8L,3L,2L,0L,9L,5L,0L,9L,6L,5L,8L,2L,4L,6L,6L,5L,6L,7L,6L,0L,7L,7L,2L,6L,5L,9L,7L,3L,2L,5L,4L,0L,8L,6L,1L,8L,1L,2L,7L,7L,8L,6L,0L,3L,2L,6L,8L,9L,4L,5L,0L,2L,2L,2L,8L,8L,2L,6L,1L,5L,1L,5L,6L,0L,1L,7L,8L,3L,0L,6L,0L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021677Inst : IEnumerable<long>
{
public static readonly long[] Value=A021677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021677.Bytes);
public long this[int i]=>Value[i];

public static A021677Inst Instance=new A021677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021678
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,3L,6L,7L,9L,5L,2L,5L,2L,2L,2L,5L,5L,1L,9L,2L,8L,7L,8L,3L,3L,8L,2L,7L,8L,9L,3L,1L,7L,5L,0L,7L,4L,1L,8L,3L,9L,7L,6L,2L,6L,1L,1L,2L,7L,5L,9L,6L,4L,3L,9L,1L,6L,9L,1L,3L,9L,4L,6L,5L,8L,7L,5L,3L,7L,0L,9L,1L,9L,8L,8L,1L,3L,0L,5L,6L,3L,7L,9L,8L,2L,1L,9L,5L,8L,4L,5L,6L,9L,7L,3L,2L,9L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021678Inst : IEnumerable<long>
{
public static readonly long[] Value=A021678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021678.Bytes);
public long this[int i]=>Value[i];

public static A021678Inst Instance=new A021678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021679
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021679Inst : IEnumerable<long>
{
public static readonly long[] Value=A021679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021679.Bytes);
public long this[int i]=>Value[i];

public static A021679Inst Instance=new A021679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021680
{
public static readonly long[] Value={ 0L,0L,1L,4L,7L,9L,2L,8L,9L,9L,4L,0L,8L,2L,8L,4L,0L,2L,3L,6L,6L,8L,6L,3L,9L,0L,5L,3L,2L,5L,4L,4L,3L,7L,8L,6L,9L,8L,2L,2L,4L,8L,5L,2L,0L,7L,1L,0L,0L,5L,9L,1L,7L,1L,5L,9L,7L,6L,3L,3L,1L,3L,6L,0L,9L,4L,6L,7L,4L,5L,5L,6L,2L,1L,3L,0L,1L,7L,7L,5L,1L,4L,7L,9L,2L,8L,9L,9L,4L,0L,8L,2L,8L,4L,0L,2L,3L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021680Inst : IEnumerable<long>
{
public static readonly long[] Value=A021680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021680.Bytes);
public long this[int i]=>Value[i];

public static A021680Inst Instance=new A021680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021681
{
public static readonly long[] Value={ 0L,0L,1L,4L,7L,7L,1L,0L,4L,8L,7L,4L,4L,4L,6L,0L,8L,5L,6L,7L,2L,0L,8L,2L,7L,1L,7L,8L,7L,2L,9L,6L,8L,9L,8L,0L,7L,9L,7L,6L,3L,6L,6L,3L,2L,2L,0L,0L,8L,8L,6L,2L,6L,2L,9L,2L,4L,6L,6L,7L,6L,5L,1L,4L,0L,3L,2L,4L,9L,6L,3L,0L,7L,2L,3L,7L,8L,1L,3L,8L,8L,4L,7L,8L,5L,8L,1L,9L,7L,9L,3L,2L,0L,5L,3L,1L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021681Inst : IEnumerable<long>
{
public static readonly long[] Value=A021681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021681.Bytes);
public long this[int i]=>Value[i];

public static A021681Inst Instance=new A021681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021682
{
public static readonly long[] Value={ 0L,0L,1L,4L,7L,4L,9L,2L,6L,2L,5L,3L,6L,8L,7L,3L,1L,5L,6L,3L,4L,2L,1L,8L,2L,8L,9L,0L,8L,5L,5L,4L,5L,7L,2L,2L,7L,1L,3L,8L,6L,4L,3L,0L,6L,7L,8L,4L,6L,6L,0L,7L,6L,6L,9L,6L,1L,6L,5L,1L,9L,1L,7L,4L,0L,4L,1L,2L,9L,7L,9L,3L,5L,1L,0L,3L,2L,4L,4L,8L,3L,7L,7L,5L,8L,1L,1L,2L,0L,9L,4L,3L,9L,5L,2L,8L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021682Inst : IEnumerable<long>
{
public static readonly long[] Value=A021682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021682.Bytes);
public long this[int i]=>Value[i];

public static A021682Inst Instance=new A021682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021683
{
public static readonly long[] Value={ 0L,0L,1L,4L,7L,2L,7L,5L,4L,0L,5L,0L,0L,7L,3L,6L,3L,7L,7L,0L,2L,5L,0L,3L,6L,8L,1L,8L,8L,5L,1L,2L,5L,1L,8L,4L,0L,9L,4L,2L,5L,6L,2L,5L,9L,2L,0L,4L,7L,1L,2L,8L,1L,2L,9L,6L,0L,2L,3L,5L,6L,4L,0L,6L,4L,8L,0L,1L,1L,7L,8L,2L,0L,3L,2L,4L,0L,0L,5L,8L,9L,1L,0L,1L,6L,2L,0L,0L,2L,9L,4L,5L,5L,0L,8L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021683Inst : IEnumerable<long>
{
public static readonly long[] Value=A021683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021683.Bytes);
public long this[int i]=>Value[i];

public static A021683Inst Instance=new A021683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021684
{
public static readonly long[] Value={ 1L,23L,360L,4810L,59111L,690573L,7801990L,86089520L,933531621L,9989073523L,105774639620L,1110701801430L,11583617458531L,120125571974873L,1239860303429250L,12746044308940540L,130587414625807841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021684Inst : IEnumerable<long>
{
public static readonly long[] Value=A021684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021684.Bytes);
public long this[int i]=>Value[i];

public static A021684Inst Instance=new A021684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021685
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,8L,4L,2L,8L,7L,8L,1L,2L,0L,4L,1L,1L,1L,6L,0L,0L,5L,8L,7L,3L,7L,1L,5L,1L,2L,4L,8L,1L,6L,4L,4L,6L,4L,0L,2L,3L,4L,9L,4L,8L,6L,0L,4L,9L,9L,2L,6L,5L,7L,8L,5L,6L,0L,9L,3L,9L,7L,9L,4L,4L,1L,9L,9L,7L,0L,6L,3L,1L,4L,2L,4L,3L,7L,5L,9L,1L,7L,7L,6L,7L,9L,8L,8L,2L,5L,2L,5L,6L,9L,7L,5L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021685Inst : IEnumerable<long>
{
public static readonly long[] Value=A021685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021685.Bytes);
public long this[int i]=>Value[i];

public static A021685Inst Instance=new A021685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021686
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,6L,2L,7L,5L,6L,5L,9L,8L,2L,4L,0L,4L,6L,9L,2L,0L,8L,2L,1L,1L,1L,4L,3L,6L,9L,5L,0L,1L,4L,6L,6L,2L,7L,5L,6L,5L,9L,8L,2L,4L,0L,4L,6L,9L,2L,0L,8L,2L,1L,1L,1L,4L,3L,6L,9L,5L,0L,1L,4L,6L,6L,2L,7L,5L,6L,5L,9L,8L,2L,4L,0L,4L,6L,9L,2L,0L,8L,2L,1L,1L,1L,4L,3L,6L,9L,5L,0L,1L,4L,6L,6L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021686Inst : IEnumerable<long>
{
public static readonly long[] Value=A021686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021686.Bytes);
public long this[int i]=>Value[i];

public static A021686Inst Instance=new A021686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021687
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,4L,1L,2L,8L,8L,4L,3L,3L,3L,8L,2L,1L,3L,7L,6L,2L,8L,1L,1L,1L,2L,7L,3L,7L,9L,2L,0L,9L,3L,7L,0L,4L,2L,4L,5L,9L,7L,3L,6L,4L,5L,6L,8L,0L,8L,1L,9L,9L,1L,2L,1L,5L,2L,2L,6L,9L,3L,9L,9L,7L,0L,7L,1L,7L,4L,2L,3L,1L,3L,3L,2L,3L,5L,7L,2L,4L,7L,4L,3L,7L,7L,7L,4L,5L,2L,4L,1L,5L,8L,1L,2L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021687Inst : IEnumerable<long>
{
public static readonly long[] Value=A021687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021687.Bytes);
public long this[int i]=>Value[i];

public static A021687Inst Instance=new A021687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021688
{
public static readonly long[] Value={ 0L,0L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L,3L,0L,4L,0L,9L,3L,5L,6L,7L,2L,5L,1L,4L,6L,1L,9L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021688Inst : IEnumerable<long>
{
public static readonly long[] Value=A021688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021688.Bytes);
public long this[int i]=>Value[i];

public static A021688Inst Instance=new A021688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021689
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L,4L,5L,9L,8L,5L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021689Inst : IEnumerable<long>
{
public static readonly long[] Value=A021689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021689.Bytes);
public long this[int i]=>Value[i];

public static A021689Inst Instance=new A021689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021690
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,7L,7L,2L,5L,9L,4L,7L,5L,2L,1L,8L,6L,5L,8L,8L,9L,2L,1L,2L,8L,2L,7L,9L,8L,8L,3L,3L,8L,1L,9L,2L,4L,1L,9L,8L,2L,5L,0L,7L,2L,8L,8L,6L,2L,9L,7L,3L,7L,6L,0L,9L,3L,2L,9L,4L,4L,6L,0L,6L,4L,1L,3L,9L,9L,4L,1L,6L,9L,0L,9L,6L,2L,0L,9L,9L,1L,2L,5L,3L,6L,4L,4L,3L,1L,4L,8L,6L,8L,8L,0L,4L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021690Inst : IEnumerable<long>
{
public static readonly long[] Value=A021690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021690.Bytes);
public long this[int i]=>Value[i];

public static A021690Inst Instance=new A021690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021691
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,5L,6L,0L,4L,0L,7L,5L,6L,9L,1L,4L,1L,1L,9L,3L,5L,9L,5L,3L,4L,2L,0L,6L,6L,9L,5L,7L,7L,8L,7L,4L,8L,1L,8L,0L,4L,9L,4L,9L,0L,5L,3L,8L,5L,7L,3L,5L,0L,8L,0L,0L,5L,8L,2L,2L,4L,1L,6L,3L,0L,2L,7L,6L,5L,6L,4L,7L,7L,4L,3L,8L,1L,3L,6L,8L,2L,6L,7L,8L,3L,1L,1L,4L,9L,9L,2L,7L,2L,1L,9L,7L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021691Inst : IEnumerable<long>
{
public static readonly long[] Value=A021691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021691.Bytes);
public long this[int i]=>Value[i];

public static A021691Inst Instance=new A021691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021692
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021692Inst : IEnumerable<long>
{
public static readonly long[] Value=A021692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021692.Bytes);
public long this[int i]=>Value[i];

public static A021692Inst Instance=new A021692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021693
{
public static readonly long[] Value={ 0L,0L,1L,4L,5L,1L,3L,7L,8L,8L,0L,9L,8L,6L,9L,3L,7L,5L,9L,0L,7L,1L,1L,1L,7L,5L,6L,1L,6L,8L,3L,5L,9L,9L,4L,1L,9L,4L,4L,8L,4L,7L,6L,0L,5L,2L,2L,4L,9L,6L,3L,7L,1L,5L,5L,2L,9L,7L,5L,3L,2L,6L,5L,6L,0L,2L,3L,2L,2L,2L,0L,6L,0L,9L,5L,7L,9L,1L,0L,0L,1L,4L,5L,1L,3L,7L,8L,8L,0L,9L,8L,6L,9L,3L,7L,5L,9L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021693Inst : IEnumerable<long>
{
public static readonly long[] Value=A021693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021693.Bytes);
public long this[int i]=>Value[i];

public static A021693Inst Instance=new A021693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021694
{
public static readonly long[] Value={ 1L,24L,394L,5544L,71995L,891408L,10701748L,125788848L,1456313749L,16673208552L,189289198462L,2135136588312L,23963101915663L,267883518461856L,2985323286760936L,33185997429018336L,368172943255604137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021694Inst : IEnumerable<long>
{
public static readonly long[] Value=A021694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021694.Bytes);
public long this[int i]=>Value[i];

public static A021694Inst Instance=new A021694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021695
{
public static readonly long[] Value={ 0L,0L,1L,4L,4L,7L,1L,7L,8L,0L,0L,2L,8L,9L,4L,3L,5L,6L,0L,0L,5L,7L,8L,8L,7L,1L,2L,0L,1L,1L,5L,7L,7L,4L,2L,4L,0L,2L,3L,1L,5L,4L,8L,4L,8L,0L,4L,6L,3L,0L,9L,6L,9L,6L,0L,9L,2L,6L,1L,9L,3L,9L,2L,1L,8L,5L,2L,3L,8L,7L,8L,4L,3L,7L,0L,4L,7L,7L,5L,6L,8L,7L,4L,0L,9L,5L,5L,1L,3L,7L,4L,8L,1L,9L,1L,0L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021695Inst : IEnumerable<long>
{
public static readonly long[] Value=A021695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021695.Bytes);
public long this[int i]=>Value[i];

public static A021695Inst Instance=new A021695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021696
{
public static readonly long[] Value={ 0L,0L,1L,4L,4L,5L,0L,8L,6L,7L,0L,5L,2L,0L,2L,3L,1L,2L,1L,3L,8L,7L,2L,8L,3L,2L,3L,6L,9L,9L,4L,2L,1L,9L,6L,5L,3L,1L,7L,9L,1L,9L,0L,7L,5L,1L,4L,4L,5L,0L,8L,6L,7L,0L,5L,2L,0L,2L,3L,1L,2L,1L,3L,8L,7L,2L,8L,3L,2L,3L,6L,9L,9L,4L,2L,1L,9L,6L,5L,3L,1L,7L,9L,1L,9L,0L,7L,5L,1L,4L,4L,5L,0L,8L,6L,7L,0L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021696Inst : IEnumerable<long>
{
public static readonly long[] Value=A021696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021696.Bytes);
public long this[int i]=>Value[i];

public static A021696Inst Instance=new A021696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021697
{
public static readonly long[] Value={ 0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L,4L,4L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021697Inst : IEnumerable<long>
{
public static readonly long[] Value=A021697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021697.Bytes);
public long this[int i]=>Value[i];

public static A021697Inst Instance=new A021697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021698
{
public static readonly long[] Value={ 0L,0L,1L,4L,4L,0L,9L,2L,2L,1L,9L,0L,2L,0L,1L,7L,2L,9L,1L,0L,6L,6L,2L,8L,2L,4L,2L,0L,7L,4L,9L,2L,7L,9L,5L,3L,8L,9L,0L,4L,8L,9L,9L,1L,3L,5L,4L,4L,6L,6L,8L,5L,8L,7L,8L,9L,6L,2L,5L,3L,6L,0L,2L,3L,0L,5L,4L,7L,5L,5L,0L,4L,3L,2L,2L,7L,6L,6L,5L,7L,0L,6L,0L,5L,1L,8L,7L,3L,1L,9L,8L,8L,4L,7L,2L,6L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021698Inst : IEnumerable<long>
{
public static readonly long[] Value=A021698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021698.Bytes);
public long this[int i]=>Value[i];

public static A021698Inst Instance=new A021698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021699
{
public static readonly long[] Value={ 0L,0L,1L,4L,3L,8L,8L,4L,8L,9L,2L,0L,8L,6L,3L,3L,0L,9L,3L,5L,2L,5L,1L,7L,9L,8L,5L,6L,1L,1L,5L,1L,0L,7L,9L,1L,3L,6L,6L,9L,0L,6L,4L,7L,4L,8L,2L,0L,1L,4L,3L,8L,8L,4L,8L,9L,2L,0L,8L,6L,3L,3L,0L,9L,3L,5L,2L,5L,1L,7L,9L,8L,5L,6L,1L,1L,5L,1L,0L,7L,9L,1L,3L,6L,6L,9L,0L,6L,4L,7L,4L,8L,2L,0L,1L,4L,3L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021699Inst : IEnumerable<long>
{
public static readonly long[] Value=A021699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021699.Bytes);
public long this[int i]=>Value[i];

public static A021699Inst Instance=new A021699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021700
{
public static readonly long[] Value={ 0L,0L,1L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021700Inst : IEnumerable<long>
{
public static readonly long[] Value=A021700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021700.Bytes);
public long this[int i]=>Value[i];

public static A021700Inst Instance=new A021700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021701
{
public static readonly long[] Value={ 0L,0L,1L,4L,3L,4L,7L,2L,0L,2L,2L,9L,5L,5L,5L,2L,3L,6L,7L,2L,8L,8L,3L,7L,8L,7L,6L,6L,1L,4L,0L,6L,0L,2L,5L,8L,2L,4L,9L,6L,4L,1L,3L,1L,9L,9L,4L,2L,6L,1L,1L,1L,9L,0L,8L,1L,7L,7L,9L,0L,5L,3L,0L,8L,4L,6L,4L,8L,4L,9L,3L,5L,4L,3L,7L,5L,8L,9L,6L,7L,0L,0L,1L,4L,3L,4L,7L,2L,0L,2L,2L,9L,5L,5L,5L,2L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021701Inst : IEnumerable<long>
{
public static readonly long[] Value=A021701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021701.Bytes);
public long this[int i]=>Value[i];

public static A021701Inst Instance=new A021701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021702
{
public static readonly long[] Value={ 0L,0L,1L,4L,3L,2L,6L,6L,4L,7L,5L,6L,4L,4L,6L,9L,9L,1L,4L,0L,4L,0L,1L,1L,4L,6L,1L,3L,1L,8L,0L,5L,1L,5L,7L,5L,9L,3L,1L,2L,3L,2L,0L,9L,1L,6L,9L,0L,5L,4L,4L,4L,1L,2L,6L,0L,7L,4L,4L,9L,8L,5L,6L,7L,3L,3L,5L,2L,4L,3L,5L,5L,3L,0L,0L,8L,5L,9L,5L,9L,8L,8L,5L,3L,8L,6L,8L,1L,9L,4L,8L,4L,2L,4L,0L,6L,8L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021702Inst : IEnumerable<long>
{
public static readonly long[] Value=A021702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021702.Bytes);
public long this[int i]=>Value[i];

public static A021702Inst Instance=new A021702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021703
{
public static readonly long[] Value={ 0L,0L,1L,4L,3L,0L,6L,1L,5L,1L,6L,4L,5L,2L,0L,7L,4L,3L,9L,1L,9L,8L,8L,5L,5L,5L,0L,7L,8L,6L,8L,3L,8L,3L,4L,0L,4L,8L,6L,4L,0L,9L,1L,5L,5L,9L,3L,7L,0L,5L,2L,9L,3L,2L,7L,6L,1L,0L,8L,7L,2L,6L,7L,5L,2L,5L,0L,3L,5L,7L,6L,5L,3L,7L,9L,1L,1L,3L,0L,1L,8L,5L,9L,7L,9L,9L,7L,1L,3L,8L,7L,6L,9L,6L,7L,0L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021703Inst : IEnumerable<long>
{
public static readonly long[] Value=A021703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021703.Bytes);
public long this[int i]=>Value[i];

public static A021703Inst Instance=new A021703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021704
{
public static readonly long[] Value={ 1L,25L,430L,6370L,87451L,1148875L,14682760L,184262740L,2283789301L,28059228925L,342594651490L,4164091223110L,50445694121551L,609637726848175L,7354257305858620L,88598528944951480L,1066309318875820201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021704Inst : IEnumerable<long>
{
public static readonly long[] Value=A021704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021704.Bytes);
public long this[int i]=>Value[i];

public static A021704Inst Instance=new A021704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021705
{
public static readonly long[] Value={ 0L,0L,1L,4L,2L,6L,5L,3L,3L,5L,2L,3L,5L,3L,7L,8L,0L,3L,1L,3L,8L,3L,7L,3L,7L,5L,1L,7L,8L,3L,1L,6L,6L,9L,0L,4L,4L,2L,2L,2L,5L,3L,9L,2L,2L,9L,6L,7L,1L,8L,9L,7L,2L,8L,9L,5L,8L,6L,3L,0L,5L,2L,7L,8L,1L,7L,4L,0L,3L,7L,0L,8L,9L,8L,7L,1L,6L,1L,1L,9L,8L,2L,8L,8L,1L,5L,9L,7L,7L,1L,7L,5L,4L,6L,3L,6L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021705Inst : IEnumerable<long>
{
public static readonly long[] Value=A021705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021705.Bytes);
public long this[int i]=>Value[i];

public static A021705Inst Instance=new A021705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021706
{
public static readonly long[] Value={ 0L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L,4L,2L,4L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021706Inst : IEnumerable<long>
{
public static readonly long[] Value=A021706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021706.Bytes);
public long this[int i]=>Value[i];

public static A021706Inst Instance=new A021706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021707
{
public static readonly long[] Value={ 0L,0L,1L,4L,2L,2L,4L,7L,5L,1L,0L,6L,6L,8L,5L,6L,3L,3L,0L,0L,1L,4L,2L,2L,4L,7L,5L,1L,0L,6L,6L,8L,5L,6L,3L,3L,0L,0L,1L,4L,2L,2L,4L,7L,5L,1L,0L,6L,6L,8L,5L,6L,3L,3L,0L,0L,1L,4L,2L,2L,4L,7L,5L,1L,0L,6L,6L,8L,5L,6L,3L,3L,0L,0L,1L,4L,2L,2L,4L,7L,5L,1L,0L,6L,6L,8L,5L,6L,3L,3L,0L,0L,1L,4L,2L,2L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021707Inst : IEnumerable<long>
{
public static readonly long[] Value=A021707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021707.Bytes);
public long this[int i]=>Value[i];

public static A021707Inst Instance=new A021707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021708
{
public static readonly long[] Value={ 0L,0L,1L,4L,2L,0L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021708Inst : IEnumerable<long>
{
public static readonly long[] Value=A021708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021708.Bytes);
public long this[int i]=>Value[i];

public static A021708Inst Instance=new A021708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021709
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,8L,4L,3L,9L,7L,1L,6L,3L,1L,2L,0L,5L,6L,7L,3L,7L,5L,8L,8L,6L,5L,2L,4L,8L,2L,2L,6L,9L,5L,0L,3L,5L,4L,6L,0L,9L,9L,2L,9L,0L,7L,8L,0L,1L,4L,1L,8L,4L,3L,9L,7L,1L,6L,3L,1L,2L,0L,5L,6L,7L,3L,7L,5L,8L,8L,6L,5L,2L,4L,8L,2L,2L,6L,9L,5L,0L,3L,5L,4L,6L,0L,9L,9L,2L,9L,0L,7L,8L,0L,1L,4L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021709Inst : IEnumerable<long>
{
public static readonly long[] Value=A021709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021709.Bytes);
public long this[int i]=>Value[i];

public static A021709Inst Instance=new A021709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021710
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,6L,4L,3L,0L,5L,9L,4L,9L,0L,0L,8L,4L,9L,8L,5L,8L,3L,5L,6L,9L,4L,0L,5L,0L,9L,9L,1L,5L,0L,1L,4L,1L,6L,4L,3L,0L,5L,9L,4L,9L,0L,0L,8L,4L,9L,8L,5L,8L,3L,5L,6L,9L,4L,0L,5L,0L,9L,9L,1L,5L,0L,1L,4L,1L,6L,4L,3L,0L,5L,9L,4L,9L,0L,0L,8L,4L,9L,8L,5L,8L,3L,5L,6L,9L,4L,0L,5L,0L,9L,9L,1L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021710Inst : IEnumerable<long>
{
public static readonly long[] Value=A021710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021710.Bytes);
public long this[int i]=>Value[i];

public static A021710Inst Instance=new A021710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021711
{
public static readonly long[] Value={ 0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L,4L,1L,4L,4L,2L,7L,1L,5L,7L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021711Inst : IEnumerable<long>
{
public static readonly long[] Value=A021711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021711.Bytes);
public long this[int i]=>Value[i];

public static A021711Inst Instance=new A021711Inst();

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