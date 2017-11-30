using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198557
{
public static readonly long[] Value={ 1L,0L,6L,9L,8L,5L,8L,4L,8L,0L,7L,6L,7L,5L,6L,5L,4L,2L,5L,5L,4L,2L,3L,4L,5L,6L,2L,6L,8L,0L,4L,1L,1L,8L,0L,2L,1L,6L,2L,7L,2L,6L,3L,9L,7L,2L,4L,2L,9L,2L,4L,0L,6L,0L,1L,2L,4L,9L,1L,2L,7L,9L,0L,4L,9L,1L,6L,5L,2L,5L,4L,3L,6L,7L,0L,8L,2L,3L,1L,3L,2L,1L,4L,3L,4L,2L,2L,2L,6L,6L,7L,4L,6L,9L,8L,9L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198557Inst : IEnumerable<long>
{
public static readonly long[] Value=A198557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198557.Bytes);
public long this[int i]=>Value[i];

public static A198557Inst Instance=new A198557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198558
{
public static readonly long[] Value={ 1L,3L,5L,9L,5L,8L,6L,5L,2L,9L,9L,4L,5L,8L,2L,9L,4L,8L,7L,2L,4L,3L,6L,8L,4L,8L,5L,8L,7L,3L,0L,6L,9L,7L,1L,1L,8L,5L,8L,5L,4L,0L,9L,3L,6L,9L,5L,1L,1L,7L,3L,7L,6L,7L,7L,0L,3L,0L,3L,1L,8L,0L,1L,0L,6L,3L,1L,6L,4L,7L,0L,3L,8L,3L,5L,3L,6L,0L,3L,2L,3L,2L,3L,3L,5L,1L,3L,0L,5L,4L,9L,5L,2L,5L,2L,8L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198558Inst : IEnumerable<long>
{
public static readonly long[] Value=A198558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198558.Bytes);
public long this[int i]=>Value[i];

public static A198558Inst Instance=new A198558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198559
{
public static readonly long[] Value={ 1L,8L,0L,7L,0L,3L,4L,0L,8L,1L,7L,3L,9L,4L,1L,0L,8L,8L,6L,1L,3L,7L,8L,3L,3L,4L,2L,0L,9L,6L,8L,5L,9L,8L,0L,6L,4L,8L,6L,7L,0L,2L,9L,9L,7L,9L,5L,6L,3L,2L,1L,2L,1L,6L,1L,5L,1L,0L,9L,6L,3L,5L,6L,8L,0L,2L,7L,3L,7L,0L,7L,7L,8L,6L,2L,5L,3L,7L,4L,7L,6L,0L,9L,0L,6L,5L,3L,9L,6L,7L,8L,6L,8L,8L,9L,4L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198559Inst : IEnumerable<long>
{
public static readonly long[] Value=A198559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198559.Bytes);
public long this[int i]=>Value[i];

public static A198559Inst Instance=new A198559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198560
{
public static readonly long[] Value={ 9L,5L,1L,8L,9L,3L,1L,0L,2L,9L,8L,1L,4L,0L,6L,3L,5L,6L,9L,5L,1L,1L,8L,5L,3L,9L,5L,7L,7L,4L,1L,9L,2L,4L,9L,5L,4L,0L,2L,1L,4L,5L,4L,6L,9L,8L,7L,8L,1L,1L,3L,4L,5L,8L,5L,4L,1L,2L,5L,7L,9L,7L,3L,1L,1L,1L,0L,8L,8L,7L,3L,2L,5L,2L,1L,6L,2L,4L,8L,8L,4L,2L,3L,7L,2L,5L,9L,6L,4L,0L,8L,7L,1L,9L,9L,5L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198560Inst : IEnumerable<long>
{
public static readonly long[] Value=A198560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198560.Bytes);
public long this[int i]=>Value[i];

public static A198560Inst Instance=new A198560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198561
{
public static readonly long[] Value={ 1L,1L,8L,7L,3L,6L,4L,0L,6L,6L,1L,9L,5L,2L,4L,5L,8L,3L,4L,7L,2L,4L,9L,0L,3L,0L,1L,1L,2L,7L,1L,0L,0L,3L,9L,5L,6L,2L,4L,6L,6L,1L,5L,0L,3L,1L,6L,6L,7L,4L,8L,0L,0L,1L,7L,0L,9L,6L,6L,3L,5L,3L,7L,2L,9L,0L,5L,7L,3L,6L,2L,8L,6L,0L,2L,4L,5L,1L,3L,1L,7L,6L,1L,7L,7L,9L,9L,6L,3L,6L,4L,1L,4L,2L,4L,2L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198561Inst : IEnumerable<long>
{
public static readonly long[] Value=A198561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198561.Bytes);
public long this[int i]=>Value[i];

public static A198561Inst Instance=new A198561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198562
{
public static readonly long[] Value={ 1L,3L,7L,8L,6L,6L,0L,9L,4L,8L,1L,9L,9L,5L,4L,9L,1L,9L,3L,0L,5L,2L,5L,5L,6L,8L,5L,4L,2L,7L,5L,9L,0L,4L,1L,2L,5L,6L,1L,8L,2L,4L,6L,7L,0L,3L,8L,6L,5L,0L,2L,2L,2L,9L,7L,1L,5L,6L,0L,5L,6L,4L,9L,2L,8L,3L,5L,7L,5L,6L,6L,6L,5L,6L,7L,2L,9L,6L,8L,7L,1L,9L,8L,0L,1L,4L,8L,5L,6L,8L,6L,0L,9L,8L,6L,6L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198562Inst : IEnumerable<long>
{
public static readonly long[] Value=A198562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198562.Bytes);
public long this[int i]=>Value[i];

public static A198562Inst Instance=new A198562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198563
{
public static readonly long[] Value={ 1L,5L,3L,4L,8L,2L,4L,8L,6L,7L,5L,8L,2L,1L,6L,4L,9L,3L,3L,6L,2L,4L,8L,2L,8L,4L,7L,7L,8L,0L,5L,9L,3L,7L,8L,8L,8L,9L,1L,1L,1L,7L,0L,8L,5L,1L,9L,8L,6L,7L,4L,7L,6L,3L,5L,9L,7L,5L,0L,9L,1L,6L,5L,2L,2L,2L,2L,1L,1L,1L,7L,5L,0L,6L,9L,9L,1L,9L,0L,4L,8L,7L,5L,4L,7L,6L,9L,4L,7L,9L,8L,3L,4L,6L,5L,2L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198563Inst : IEnumerable<long>
{
public static readonly long[] Value=A198563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198563.Bytes);
public long this[int i]=>Value[i];

public static A198563Inst Instance=new A198563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198564
{
public static readonly long[] Value={ 7L,2L,8L,4L,6L,8L,2L,3L,9L,3L,5L,6L,9L,9L,0L,7L,6L,8L,3L,6L,1L,5L,3L,2L,2L,7L,8L,1L,4L,9L,9L,0L,7L,4L,7L,0L,5L,2L,5L,0L,9L,5L,3L,6L,5L,0L,7L,0L,5L,2L,8L,5L,5L,4L,9L,5L,9L,3L,8L,6L,9L,5L,3L,7L,9L,3L,9L,9L,9L,0L,4L,3L,2L,8L,0L,1L,7L,1L,5L,3L,8L,2L,4L,9L,5L,2L,2L,5L,1L,2L,2L,6L,1L,7L,5L,8L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198564Inst : IEnumerable<long>
{
public static readonly long[] Value=A198564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198564.Bytes);
public long this[int i]=>Value[i];

public static A198564Inst Instance=new A198564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198565
{
public static readonly long[] Value={ 1L,1L,0L,6L,1L,4L,4L,3L,7L,3L,0L,5L,1L,6L,3L,8L,9L,9L,9L,9L,2L,1L,4L,1L,0L,6L,2L,6L,1L,0L,6L,5L,0L,8L,6L,4L,3L,7L,2L,1L,5L,6L,5L,2L,7L,0L,0L,0L,3L,3L,2L,4L,5L,1L,5L,3L,5L,7L,5L,0L,2L,7L,3L,0L,0L,5L,5L,3L,5L,3L,4L,0L,4L,9L,6L,5L,4L,9L,2L,8L,7L,0L,6L,5L,4L,6L,5L,4L,7L,3L,6L,7L,9L,0L,8L,3L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198565Inst : IEnumerable<long>
{
public static readonly long[] Value=A198565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198565.Bytes);
public long this[int i]=>Value[i];

public static A198565Inst Instance=new A198565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198566
{
public static readonly long[] Value={ 1L,7L,7L,5L,6L,9L,0L,6L,2L,0L,3L,6L,4L,4L,8L,1L,1L,3L,9L,3L,2L,4L,8L,0L,1L,8L,5L,2L,3L,3L,7L,8L,6L,0L,9L,6L,0L,2L,7L,5L,1L,1L,5L,6L,4L,1L,9L,4L,2L,4L,1L,6L,1L,8L,8L,0L,4L,7L,9L,7L,5L,9L,8L,3L,2L,1L,3L,4L,0L,5L,4L,8L,4L,4L,9L,6L,4L,3L,2L,6L,2L,0L,1L,9L,5L,4L,6L,6L,8L,8L,0L,6L,4L,0L,7L,4L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198566Inst : IEnumerable<long>
{
public static readonly long[] Value=A198566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198566.Bytes);
public long this[int i]=>Value[i];

public static A198566Inst Instance=new A198566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198567
{
public static readonly long[] Value={ 1L,9L,6L,8L,3L,9L,7L,5L,0L,7L,8L,5L,8L,7L,3L,2L,8L,4L,1L,3L,8L,2L,8L,9L,9L,1L,8L,4L,6L,0L,1L,6L,9L,6L,2L,4L,0L,7L,8L,6L,7L,2L,2L,4L,1L,9L,7L,3L,7L,3L,7L,3L,7L,8L,8L,8L,9L,4L,2L,2L,1L,6L,4L,7L,1L,6L,3L,9L,2L,1L,6L,3L,5L,0L,9L,9L,5L,1L,6L,9L,3L,7L,2L,5L,0L,0L,6L,6L,2L,2L,3L,4L,3L,4L,3L,8L,2L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198567Inst : IEnumerable<long>
{
public static readonly long[] Value=A198567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198567.Bytes);
public long this[int i]=>Value[i];

public static A198567Inst Instance=new A198567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198568
{
public static readonly long[] Value={ 2L,1L,1L,0L,0L,2L,1L,9L,8L,8L,4L,5L,7L,5L,4L,0L,1L,0L,5L,8L,4L,4L,9L,9L,4L,5L,5L,5L,2L,8L,4L,5L,6L,3L,2L,6L,5L,1L,4L,7L,7L,3L,6L,6L,8L,1L,4L,4L,0L,4L,3L,8L,2L,5L,6L,4L,8L,6L,1L,4L,9L,9L,4L,1L,4L,6L,2L,5L,2L,8L,5L,8L,7L,4L,0L,3L,3L,2L,4L,3L,2L,0L,5L,2L,9L,6L,9L,3L,6L,2L,7L,8L,6L,0L,8L,4L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198568Inst : IEnumerable<long>
{
public static readonly long[] Value=A198568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198568.Bytes);
public long this[int i]=>Value[i];

public static A198568Inst Instance=new A198568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198569
{
public static readonly long[] Value={ 2L,2L,1L,8L,7L,2L,9L,3L,7L,4L,8L,7L,5L,6L,3L,8L,2L,6L,7L,3L,3L,6L,7L,8L,2L,5L,8L,6L,8L,3L,7L,6L,2L,5L,7L,1L,8L,9L,2L,0L,1L,6L,5L,0L,0L,6L,8L,2L,0L,5L,8L,6L,4L,3L,0L,3L,9L,0L,7L,6L,1L,4L,0L,5L,4L,5L,9L,4L,1L,9L,4L,9L,4L,4L,1L,4L,5L,2L,5L,3L,9L,5L,4L,4L,7L,7L,1L,5L,3L,9L,8L,5L,8L,2L,2L,8L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198569Inst : IEnumerable<long>
{
public static readonly long[] Value=A198569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198569.Bytes);
public long this[int i]=>Value[i];

public static A198569Inst Instance=new A198569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198570
{
public static readonly long[] Value={ 1L,2L,5L,2L,7L,3L,8L,2L,1L,9L,7L,7L,6L,4L,1L,5L,0L,9L,2L,9L,2L,2L,1L,8L,1L,0L,2L,8L,4L,8L,1L,8L,6L,9L,9L,4L,2L,4L,0L,1L,9L,2L,1L,0L,1L,4L,5L,7L,7L,4L,9L,3L,0L,6L,7L,8L,2L,5L,5L,4L,7L,2L,3L,3L,6L,9L,3L,6L,2L,2L,7L,3L,9L,8L,5L,3L,8L,2L,3L,7L,1L,2L,1L,0L,1L,8L,1L,8L,0L,2L,9L,4L,0L,9L,2L,0L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198570Inst : IEnumerable<long>
{
public static readonly long[] Value=A198570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198570.Bytes);
public long this[int i]=>Value[i];

public static A198570Inst Instance=new A198570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198571
{
public static readonly long[] Value={ 1L,4L,5L,5L,0L,9L,6L,5L,9L,1L,5L,6L,2L,8L,6L,6L,1L,5L,2L,4L,5L,9L,5L,4L,0L,8L,8L,7L,6L,0L,4L,6L,0L,6L,3L,5L,6L,6L,8L,1L,0L,9L,2L,2L,3L,1L,1L,2L,5L,7L,5L,3L,9L,2L,0L,4L,2L,1L,6L,0L,6L,5L,6L,9L,1L,3L,1L,4L,2L,8L,0L,5L,1L,4L,7L,3L,6L,1L,5L,0L,9L,9L,5L,9L,6L,8L,2L,2L,5L,5L,7L,5L,3L,8L,4L,9L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198571Inst : IEnumerable<long>
{
public static readonly long[] Value=A198571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198571.Bytes);
public long this[int i]=>Value[i];

public static A198571Inst Instance=new A198571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198572
{
public static readonly long[] Value={ 1L,7L,4L,9L,8L,1L,0L,4L,9L,6L,2L,9L,8L,1L,8L,3L,3L,9L,8L,7L,6L,1L,2L,9L,7L,0L,6L,4L,7L,5L,3L,4L,8L,6L,6L,5L,2L,0L,1L,0L,0L,6L,4L,3L,2L,3L,3L,5L,0L,0L,4L,2L,5L,7L,1L,8L,9L,1L,1L,7L,0L,7L,7L,1L,8L,8L,1L,7L,7L,2L,5L,8L,1L,9L,7L,0L,6L,4L,1L,1L,7L,9L,4L,4L,3L,0L,7L,7L,6L,9L,1L,0L,2L,2L,7L,5L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198572Inst : IEnumerable<long>
{
public static readonly long[] Value=A198572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198572.Bytes);
public long this[int i]=>Value[i];

public static A198572Inst Instance=new A198572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198573
{
public static readonly long[] Value={ 9L,6L,3L,1L,0L,4L,6L,2L,0L,6L,8L,8L,1L,9L,1L,7L,8L,6L,3L,7L,3L,7L,3L,9L,5L,4L,9L,1L,8L,5L,5L,0L,0L,1L,8L,1L,6L,3L,6L,1L,5L,9L,2L,0L,3L,6L,0L,3L,6L,9L,9L,9L,8L,6L,5L,6L,5L,0L,2L,3L,9L,9L,2L,5L,0L,1L,7L,0L,4L,7L,7L,3L,0L,4L,6L,6L,3L,6L,7L,0L,3L,1L,1L,4L,4L,6L,5L,1L,5L,7L,1L,7L,3L,2L,3L,9L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198573Inst : IEnumerable<long>
{
public static readonly long[] Value=A198573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198573.Bytes);
public long this[int i]=>Value[i];

public static A198573Inst Instance=new A198573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198574
{
public static readonly long[] Value={ 1L,1L,4L,7L,3L,0L,4L,8L,9L,8L,1L,3L,5L,2L,4L,9L,4L,2L,9L,1L,7L,5L,0L,4L,3L,0L,1L,1L,7L,0L,6L,4L,1L,7L,4L,1L,6L,3L,7L,4L,4L,6L,2L,8L,7L,2L,2L,1L,2L,2L,0L,6L,6L,2L,5L,4L,7L,2L,0L,8L,4L,3L,5L,6L,9L,5L,2L,4L,9L,8L,4L,8L,2L,5L,6L,4L,3L,6L,6L,9L,2L,0L,1L,1L,0L,4L,4L,8L,7L,2L,6L,6L,1L,4L,0L,3L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198574Inst : IEnumerable<long>
{
public static readonly long[] Value=A198574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198574.Bytes);
public long this[int i]=>Value[i];

public static A198574Inst Instance=new A198574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198575
{
public static readonly long[] Value={ 1L,3L,0L,4L,6L,3L,1L,7L,1L,0L,3L,9L,4L,7L,8L,7L,3L,7L,9L,5L,8L,7L,4L,6L,7L,0L,6L,5L,2L,3L,2L,9L,9L,3L,9L,6L,9L,3L,7L,6L,0L,7L,2L,9L,2L,1L,8L,0L,3L,6L,7L,2L,6L,1L,8L,0L,0L,6L,5L,1L,6L,2L,6L,1L,0L,6L,3L,9L,7L,0L,5L,3L,0L,3L,6L,7L,0L,5L,2L,7L,1L,3L,2L,3L,2L,6L,7L,2L,8L,3L,6L,5L,1L,8L,6L,1L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198575Inst : IEnumerable<long>
{
public static readonly long[] Value=A198575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198575.Bytes);
public long this[int i]=>Value[i];

public static A198575Inst Instance=new A198575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198576
{
public static readonly long[] Value={ 1L,4L,3L,8L,9L,2L,8L,0L,8L,7L,7L,2L,6L,5L,9L,7L,5L,5L,5L,0L,1L,0L,4L,7L,7L,7L,9L,9L,0L,0L,1L,5L,2L,7L,9L,9L,9L,5L,4L,8L,2L,0L,5L,2L,7L,9L,5L,3L,8L,2L,7L,1L,2L,6L,2L,9L,7L,9L,9L,0L,4L,4L,2L,8L,5L,9L,1L,6L,1L,0L,8L,7L,4L,5L,1L,1L,0L,3L,3L,4L,3L,9L,3L,1L,3L,0L,5L,8L,8L,7L,1L,2L,8L,7L,8L,8L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198576Inst : IEnumerable<long>
{
public static readonly long[] Value=A198576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198576.Bytes);
public long this[int i]=>Value[i];

public static A198576Inst Instance=new A198576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198577
{
public static readonly long[] Value={ 2L,1L,8L,6L,6L,5L,0L,7L,8L,3L,2L,6L,6L,9L,0L,6L,1L,7L,9L,5L,8L,5L,5L,4L,5L,2L,7L,5L,4L,8L,1L,7L,9L,4L,6L,4L,2L,1L,0L,4L,2L,1L,1L,2L,2L,2L,7L,3L,1L,3L,3L,9L,8L,1L,8L,5L,6L,6L,8L,7L,2L,1L,7L,5L,8L,6L,4L,9L,2L,6L,3L,6L,0L,0L,2L,0L,8L,3L,0L,9L,4L,5L,2L,3L,6L,7L,7L,3L,6L,1L,7L,4L,4L,5L,3L,9L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198577Inst : IEnumerable<long>
{
public static readonly long[] Value=A198577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198577.Bytes);
public long this[int i]=>Value[i];

public static A198577Inst Instance=new A198577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198578
{
public static readonly long[] Value={ 2L,4L,1L,3L,5L,4L,7L,7L,4L,2L,1L,1L,6L,9L,0L,9L,7L,6L,6L,0L,1L,4L,3L,0L,9L,2L,8L,4L,2L,1L,1L,6L,2L,3L,7L,3L,0L,0L,2L,6L,0L,3L,6L,5L,3L,7L,8L,7L,8L,5L,0L,7L,7L,7L,0L,3L,8L,2L,8L,3L,1L,1L,0L,5L,7L,6L,4L,0L,2L,8L,1L,5L,4L,2L,1L,7L,3L,2L,7L,1L,3L,9L,4L,3L,6L,4L,0L,2L,3L,3L,4L,1L,9L,6L,9L,5L,0L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198578Inst : IEnumerable<long>
{
public static readonly long[] Value=A198578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198578.Bytes);
public long this[int i]=>Value[i];

public static A198578Inst Instance=new A198578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198579
{
public static readonly long[] Value={ 1L,5L,4L,8L,5L,3L,6L,9L,5L,2L,6L,1L,0L,6L,5L,6L,1L,2L,6L,2L,4L,3L,1L,2L,2L,5L,4L,1L,2L,4L,9L,3L,6L,9L,7L,5L,0L,3L,3L,9L,8L,3L,9L,3L,5L,1L,5L,4L,9L,5L,1L,1L,8L,0L,7L,3L,0L,4L,5L,8L,0L,8L,1L,5L,3L,3L,6L,7L,2L,6L,1L,6L,6L,3L,3L,6L,6L,1L,5L,2L,6L,9L,0L,0L,6L,0L,6L,0L,1L,7L,7L,9L,0L,8L,8L,4L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198579Inst : IEnumerable<long>
{
public static readonly long[] Value=A198579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198579.Bytes);
public long this[int i]=>Value[i];

public static A198579Inst Instance=new A198579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198580
{
public static readonly long[] Value={ 1L,7L,1L,7L,3L,6L,3L,2L,4L,5L,1L,5L,0L,8L,9L,5L,4L,2L,9L,4L,6L,3L,7L,2L,2L,9L,9L,5L,4L,5L,1L,4L,2L,4L,3L,0L,0L,2L,1L,2L,3L,3L,3L,5L,0L,7L,9L,9L,5L,0L,6L,1L,3L,5L,2L,6L,0L,8L,6L,6L,1L,2L,1L,0L,6L,8L,9L,6L,2L,0L,4L,8L,5L,3L,3L,0L,3L,9L,7L,0L,2L,1L,4L,7L,8L,9L,5L,6L,5L,6L,8L,6L,8L,2L,2L,8L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198580Inst : IEnumerable<long>
{
public static readonly long[] Value=A198580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198580.Bytes);
public long this[int i]=>Value[i];

public static A198580Inst Instance=new A198580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198581
{
public static readonly long[] Value={ 1L,8L,5L,2L,0L,5L,7L,1L,8L,2L,2L,3L,6L,2L,6L,4L,6L,5L,3L,6L,0L,7L,1L,9L,5L,4L,0L,2L,2L,6L,4L,9L,4L,1L,4L,1L,5L,6L,9L,4L,5L,8L,0L,0L,1L,2L,4L,2L,6L,3L,5L,2L,6L,5L,8L,1L,3L,0L,1L,4L,7L,9L,7L,9L,1L,3L,6L,7L,4L,4L,9L,9L,1L,4L,7L,8L,8L,2L,0L,6L,7L,8L,6L,9L,1L,3L,5L,3L,6L,8L,5L,9L,5L,2L,7L,4L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198581Inst : IEnumerable<long>
{
public static readonly long[] Value=A198581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198581.Bytes);
public long this[int i]=>Value[i];

public static A198581Inst Instance=new A198581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198582
{
public static readonly long[] Value={ 1L,9L,6L,1L,7L,2L,7L,9L,5L,1L,6L,4L,6L,5L,3L,9L,8L,4L,1L,6L,0L,9L,6L,2L,7L,4L,0L,1L,6L,7L,6L,7L,5L,3L,1L,7L,0L,0L,7L,7L,8L,3L,6L,6L,8L,4L,9L,9L,8L,3L,0L,8L,2L,9L,5L,0L,5L,7L,0L,5L,7L,6L,7L,3L,8L,9L,1L,0L,2L,8L,9L,7L,3L,8L,3L,4L,9L,5L,9L,4L,4L,0L,0L,0L,1L,3L,6L,6L,9L,6L,3L,9L,2L,1L,8L,5L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198582Inst : IEnumerable<long>
{
public static readonly long[] Value=A198582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198582.Bytes);
public long this[int i]=>Value[i];

public static A198582Inst Instance=new A198582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198583
{
public static readonly long[] Value={ 4L,8L,0L,9L,4L,5L,9L,5L,7L,7L,2L,8L,1L,2L,9L,6L,5L,7L,7L,6L,6L,2L,9L,7L,8L,5L,6L,5L,3L,7L,6L,5L,6L,3L,8L,3L,3L,8L,5L,4L,0L,7L,0L,8L,5L,9L,1L,3L,4L,6L,6L,3L,6L,7L,3L,2L,9L,2L,5L,6L,2L,6L,9L,9L,9L,6L,3L,9L,8L,8L,3L,9L,3L,6L,3L,9L,6L,1L,1L,1L,9L,9L,5L,1L,9L,4L,0L,8L,7L,2L,8L,1L,3L,9L,2L,8L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198583Inst : IEnumerable<long>
{
public static readonly long[] Value=A198583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198583.Bytes);
public long this[int i]=>Value[i];

public static A198583Inst Instance=new A198583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198584
{
public static readonly long[] Value={ 3L,13L,53L,113L,213L,227L,453L,853L,909L,1813L,3413L,3637L,7253L,7281L,13653L,14549L,14563L,29013L,29125L,54613L,58197L,58253L,116053L,116501L,218453L,232789L,233013L,464213L,466005L,466033L,873813L,931157L,932053L,932067L,1856853L,1864021L,1864133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198584Inst : IEnumerable<long>
{
public static readonly long[] Value=A198584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198584.Bytes);
public long this[int i]=>Value[i];

public static A198584Inst Instance=new A198584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198585
{
public static readonly long[] Value={ 5L,5L,5L,85L,5L,341L,85L,5L,341L,85L,5L,341L,85L,5461L,5L,341L,21845L,85L,5461L,5L,341L,21845L,85L,5461L,5L,341L,21845L,85L,5461L,349525L,5L,341L,21845L,1398101L,85L,5461L,349525L,5L,341L,21845L,1398101L,85L,5461L,349525L,5L,341L,21845L,1398101L,85L,5461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198585Inst : IEnumerable<long>
{
public static readonly long[] Value=A198585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198585.Bytes);
public long this[int i]=>Value[i];

public static A198585Inst Instance=new A198585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198586
{
public static readonly long[] Value={ 5L,85L,341L,5461L,21845L,349525L,1398101L,22369621L,89478485L,1431655765L,5726623061L,91625968981L,366503875925L,5864062014805L,23456248059221L,375299968947541L,1501199875790165L,24019198012642645L,96076792050570581L,1537228672809129301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198586Inst : IEnumerable<long>
{
public static readonly long[] Value=A198586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198586.Bytes);
public long this[int i]=>Value[i];

public static A198586Inst Instance=new A198586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198587
{
public static readonly long[] Value={ 17L,35L,69L,75L,141L,151L,277L,301L,565L,605L,1109L,1137L,1205L,2261L,2275L,2417L,2421L,4437L,4549L,4821L,4835L,4849L,9045L,9101L,9669L,9685L,9699L,17749L,18197L,19285L,19341L,19397L,19417L,36181L,36405L,38677L,38741L,38797L,38833L,38835L,70997L,72789L,72817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198587Inst : IEnumerable<long>
{
public static readonly long[] Value=A198587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198587.Bytes);
public long this[int i]=>Value[i];

public static A198587Inst Instance=new A198587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198588
{
public static readonly long[] Value={ 11L,23L,45L,93L,181L,201L,369L,373L,401L,403L,725L,739L,753L,803L,805L,1477L,1493L,1507L,1605L,1611L,1613L,2901L,2957L,3013L,3033L,3213L,3221L,3223L,5909L,5973L,6029L,6065L,6067L,6421L,6445L,6453L,6465L,11605L,11829L,12053L,12131L,12133L,12853L,12885L,12893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198588Inst : IEnumerable<long>
{
public static readonly long[] Value=A198588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198588.Bytes);
public long this[int i]=>Value[i];

public static A198588Inst Instance=new A198588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198589
{
public static readonly long[] Value={ 7L,15L,29L,61L,117L,241L,245L,267L,469L,483L,497L,535L,537L,965L,981L,985L,995L,1069L,1073L,1075L,1877L,1933L,1969L,1971L,1989L,2009L,2141L,2147L,2149L,3861L,3925L,3939L,3941L,3981L,4017L,4019L,4043L,4277L,4293L,4297L,4301L,7509L,7733L,7877L,7885L,7957L,8035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198589Inst : IEnumerable<long>
{
public static readonly long[] Value=A198589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198589.Bytes);
public long this[int i]=>Value[i];

public static A198589Inst Instance=new A198589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198590
{
public static readonly long[] Value={ 9L,19L,37L,77L,81L,149L,163L,309L,321L,325L,331L,597L,625L,643L,653L,663L,713L,715L,1237L,1251L,1285L,1301L,1313L,1325L,1339L,1425L,1427L,1431L,1433L,2389L,2501L,2573L,2577L,2613L,2625L,2627L,2653L,2679L,2695L,2851L,2853L,2861L,2865L,2867L,4949L,5005L,5141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198590Inst : IEnumerable<long>
{
public static readonly long[] Value=A198590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198590.Bytes);
public long this[int i]=>Value[i];

public static A198590Inst Instance=new A198590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198591
{
public static readonly long[] Value={ 25L,49L,51L,99L,101L,197L,205L,217L,397L,405L,433L,435L,441L,475L,789L,821L,833L,857L,867L,869L,875L,883L,951L,953L,955L,1589L,1621L,1649L,1667L,1713L,1715L,1733L,1741L,1751L,1765L,1785L,1901L,1907L,1911L,3157L,3185L,3285L,3299L,3333L,3427L,3429L,3469L,3477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198591Inst : IEnumerable<long>
{
public static readonly long[] Value=A198591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198591.Bytes);
public long this[int i]=>Value[i];

public static A198591Inst Instance=new A198591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198592
{
public static readonly long[] Value={ 33L,65L,67L,131L,133L,261L,269L,273L,289L,525L,529L,533L,547L,555L,571L,577L,579L,583L,633L,635L,1045L,1059L,1077L,1093L,1099L,1111L,1143L,1155L,1157L,1167L,1177L,1267L,1271L,1273L,2101L,2117L,2123L,2133L,2161L,2189L,2199L,2221L,2285L,2309L,2317L,2321L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198592Inst : IEnumerable<long>
{
public static readonly long[] Value=A198592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198592.Bytes);
public long this[int i]=>Value[i];

public static A198592Inst Instance=new A198592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198593
{
public static readonly long[] Value={ 43L,87L,89L,173L,177L,179L,349L,355L,357L,385L,423L,693L,705L,709L,717L,729L,761L,769L,771L,777L,847L,1393L,1397L,1411L,1415L,1421L,1429L,1457L,1459L,1465L,1481L,1523L,1539L,1541L,1547L,1555L,1569L,1689L,1693L,1697L,2773L,2787L,2801L,2821L,2831L,2837L,2869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198593Inst : IEnumerable<long>
{
public static readonly long[] Value=A198593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198593.Bytes);
public long this[int i]=>Value[i];

public static A198593Inst Instance=new A198593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198594
{
public static readonly BigInteger[] Value={ 17L,2684L,511661L,101749556L,20489929961L,4142124332044L,838329027803141L,169730671672463748L,BigInteger.Parse("34367910101781840193"),BigInteger.Parse("6959214284742747147804"),BigInteger.Parse("1409196791555539177862621"),BigInteger.Parse("285354290765682664063587924") };
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
public class A198594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198594Inst Instance=new A198594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198595
{
public static readonly long[] Value={ 272L,511661L,1208560656L,3082580273539L,8057520048724340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198595Inst : IEnumerable<long>
{
public static readonly long[] Value=A198595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198595.Bytes);
public long this[int i]=>Value[i];

public static A198595Inst Instance=new A198595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198596
{
public static readonly long[] Value={ 2L,17L,17L,272L,2684L,272L,4667L,511661L,511661L,4667L,80702L,101749556L,1208560656L,101749556L,80702L,1397477L,20489929961L,3082580273539L,3082580273539L,20489929961L,1397477L,24207692L,4142124332044L,8057520048724340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198596Inst : IEnumerable<long>
{
public static readonly long[] Value=A198596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198596.Bytes);
public long this[int i]=>Value[i];

public static A198596Inst Instance=new A198596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198597
{
public static readonly long[] Value={ 1L,5L,674L,844228L,8055413256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198597Inst : IEnumerable<long>
{
public static readonly long[] Value=A198597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198597.Bytes);
public long this[int i]=>Value[i];

public static A198597Inst Instance=new A198597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198598
{
public static readonly long[] Value={ 1L,5L,32L,251L,1985L,15761L,125168L,994127L,7895777L,62711837L,498086240L,3956031011L,31420628321L,249557171369L,1982098563440L,15742744249463L,125036161801025L,993095073749045L,7887620760000800L,62647135102634315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198598Inst : IEnumerable<long>
{
public static readonly long[] Value=A198598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198598.Bytes);
public long this[int i]=>Value[i];

public static A198598Inst Instance=new A198598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198599
{
public static readonly BigInteger[] Value={ 2L,32L,674L,14396L,309770L,6671450L,143724590L,3096625676L,66720604082L,1437592096184L,30975107870150L,667406503209962L,14380307969705594L,309846066281809304L,6676114885818492290L,BigInteger.Parse("143847269049688259540") };
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
public class A198599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198599Inst Instance=new A198599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198600
{
public static readonly BigInteger[] Value={ 5L,251L,14396L,844228L,49726877L,2934981667L,173328303620L,10237927785188L,604754378402213L,35723495136378379L,2110237768703448092L,BigInteger.Parse("124654981592741709892"),BigInteger.Parse("7363565234193825044093"),BigInteger.Parse("434977425639969487046579") };
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
public class A198600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198600Inst Instance=new A198600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198601
{
public static readonly BigInteger[] Value={ 14L,1985L,309770L,49726877L,8055413256L,1308245895665L,212660032469362L,34578446232234461L,5622954055105266638L,BigInteger.Parse("914399588312051428232"),BigInteger.Parse("148700162991801408836106"),BigInteger.Parse("24181772212240990503470021") };
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
public class A198601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198601Inst Instance=new A198601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198602
{
public static readonly long[] Value={ 41L,15761L,6671450L,2934981667L,1308245895665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198602Inst : IEnumerable<long>
{
public static readonly long[] Value=A198602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198602.Bytes);
public long this[int i]=>Value[i];

public static A198602Inst Instance=new A198602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198603
{
public static readonly long[] Value={ 122L,125168L,143724590L,173328303620L,212660032469362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198603Inst : IEnumerable<long>
{
public static readonly long[] Value=A198603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198603.Bytes);
public long this[int i]=>Value[i];

public static A198603Inst Instance=new A198603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198604
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,5L,32L,32L,5L,14L,251L,674L,251L,14L,41L,1985L,14396L,14396L,1985L,41L,122L,15761L,309770L,844228L,309770L,15761L,122L,365L,125168L,6671450L,49726877L,49726877L,6671450L,125168L,365L,1094L,994127L,143724590L,2934981667L,8055413256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198604Inst : IEnumerable<long>
{
public static readonly long[] Value=A198604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198604.Bytes);
public long this[int i]=>Value[i];

public static A198604Inst Instance=new A198604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198605
{
public static readonly long[] Value={ 1L,1L,7L,6L,9L,2L,1L,0L,5L,9L,4L,6L,4L,3L,6L,6L,4L,4L,2L,8L,4L,1L,8L,7L,1L,4L,5L,2L,2L,0L,8L,6L,0L,6L,1L,1L,3L,3L,6L,9L,1L,4L,1L,1L,5L,0L,5L,1L,7L,4L,3L,7L,7L,5L,0L,1L,9L,8L,8L,4L,8L,9L,2L,8L,7L,6L,2L,1L,9L,5L,3L,0L,0L,6L,1L,2L,0L,7L,5L,8L,3L,6L,5L,4L,4L,5L,2L,5L,4L,5L,2L,7L,0L,5L,1L,9L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198605Inst : IEnumerable<long>
{
public static readonly long[] Value=A198605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198605.Bytes);
public long this[int i]=>Value[i];

public static A198605Inst Instance=new A198605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198606
{
public static readonly long[] Value={ 1L,0L,5L,8L,8L,9L,1L,2L,6L,8L,5L,3L,1L,9L,7L,4L,4L,7L,9L,4L,7L,0L,3L,8L,8L,9L,5L,8L,4L,5L,1L,4L,8L,1L,1L,2L,1L,2L,1L,2L,2L,6L,8L,9L,4L,6L,7L,7L,1L,7L,6L,8L,8L,9L,0L,6L,7L,0L,8L,8L,6L,5L,7L,5L,0L,6L,4L,4L,8L,4L,9L,4L,2L,5L,4L,0L,5L,9L,7L,3L,6L,6L,8L,0L,2L,8L,0L,5L,2L,5L,2L,4L,1L,6L,1L,7L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198606Inst : IEnumerable<long>
{
public static readonly long[] Value=A198606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198606.Bytes);
public long this[int i]=>Value[i];

public static A198606Inst Instance=new A198606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198607
{
public static readonly long[] Value={ 7L,2L,3L,2L,9L,3L,0L,7L,1L,3L,3L,5L,8L,5L,3L,3L,3L,5L,5L,3L,5L,0L,3L,6L,4L,9L,3L,2L,0L,9L,7L,8L,9L,7L,3L,9L,2L,7L,4L,5L,7L,0L,7L,8L,4L,4L,6L,8L,6L,3L,6L,1L,1L,2L,1L,8L,6L,2L,4L,7L,0L,9L,5L,8L,5L,8L,9L,2L,7L,1L,6L,0L,6L,5L,6L,3L,9L,9L,5L,8L,3L,0L,5L,0L,9L,6L,3L,5L,9L,8L,5L,3L,8L,2L,7L,8L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198607Inst : IEnumerable<long>
{
public static readonly long[] Value=A198607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198607.Bytes);
public long this[int i]=>Value[i];

public static A198607Inst Instance=new A198607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198608
{
public static readonly long[] Value={ 1L,0L,9L,3L,9L,2L,2L,7L,3L,9L,9L,0L,5L,4L,9L,9L,0L,8L,9L,0L,5L,7L,3L,4L,5L,8L,0L,3L,9L,5L,2L,1L,9L,6L,2L,2L,7L,6L,0L,4L,6L,8L,8L,2L,5L,0L,1L,9L,1L,3L,7L,3L,8L,4L,3L,9L,4L,4L,4L,9L,8L,2L,6L,5L,8L,9L,3L,0L,7L,8L,4L,6L,6L,1L,5L,8L,1L,2L,8L,4L,6L,9L,0L,0L,1L,9L,6L,6L,6L,2L,2L,2L,5L,3L,3L,6L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198608Inst : IEnumerable<long>
{
public static readonly long[] Value=A198608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198608.Bytes);
public long this[int i]=>Value[i];

public static A198608Inst Instance=new A198608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198609
{
public static readonly long[] Value={ 5L,4L,9L,5L,8L,5L,9L,7L,7L,0L,0L,5L,8L,3L,2L,3L,3L,1L,6L,7L,8L,5L,3L,6L,9L,2L,1L,1L,2L,6L,3L,7L,1L,7L,8L,0L,2L,5L,8L,9L,5L,9L,1L,0L,5L,8L,0L,0L,3L,5L,1L,8L,1L,3L,8L,5L,3L,4L,4L,5L,0L,4L,0L,8L,6L,1L,5L,9L,7L,3L,0L,9L,1L,8L,9L,0L,2L,8L,7L,8L,8L,2L,6L,8L,6L,0L,9L,9L,7L,2L,1L,9L,3L,5L,2L,4L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198609Inst : IEnumerable<long>
{
public static readonly long[] Value=A198609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198609.Bytes);
public long this[int i]=>Value[i];

public static A198609Inst Instance=new A198609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198610
{
public static readonly long[] Value={ 4L,3L,6L,9L,6L,0L,1L,2L,5L,5L,4L,0L,8L,8L,5L,2L,8L,3L,5L,4L,3L,9L,3L,2L,8L,4L,0L,4L,4L,2L,6L,1L,0L,9L,6L,3L,0L,5L,3L,1L,1L,2L,2L,3L,2L,1L,7L,0L,4L,4L,9L,3L,1L,3L,3L,7L,1L,9L,8L,8L,3L,0L,6L,9L,6L,0L,4L,2L,6L,2L,4L,9L,7L,1L,4L,5L,5L,1L,4L,4L,9L,4L,2L,4L,2L,1L,3L,3L,6L,1L,0L,5L,0L,8L,9L,2L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198610Inst : IEnumerable<long>
{
public static readonly long[] Value=A198610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198610.Bytes);
public long this[int i]=>Value[i];

public static A198610Inst Instance=new A198610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198611
{
public static readonly long[] Value={ 1L,7L,1L,0L,5L,4L,5L,2L,1L,0L,9L,1L,8L,0L,8L,4L,4L,0L,1L,8L,7L,3L,4L,0L,3L,7L,7L,3L,0L,1L,4L,4L,0L,3L,1L,9L,7L,6L,5L,7L,9L,5L,1L,0L,1L,0L,5L,0L,4L,5L,2L,6L,8L,1L,7L,6L,5L,8L,6L,3L,2L,4L,4L,8L,0L,1L,2L,8L,3L,7L,4L,7L,8L,9L,5L,6L,4L,1L,0L,7L,6L,4L,0L,7L,6L,3L,1L,5L,0L,6L,2L,0L,7L,9L,3L,2L,4L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198611Inst : IEnumerable<long>
{
public static readonly long[] Value=A198611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198611.Bytes);
public long this[int i]=>Value[i];

public static A198611Inst Instance=new A198611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198612
{
public static readonly long[] Value={ 5L,8L,3L,7L,5L,1L,7L,2L,0L,0L,2L,1L,7L,0L,9L,5L,2L,9L,6L,1L,3L,8L,8L,6L,7L,0L,9L,8L,9L,8L,0L,3L,4L,2L,3L,0L,9L,0L,5L,3L,3L,4L,0L,5L,3L,1L,9L,8L,2L,9L,5L,6L,1L,4L,4L,6L,8L,3L,3L,3L,3L,1L,3L,5L,4L,6L,3L,9L,5L,7L,2L,4L,3L,8L,3L,5L,0L,4L,3L,0L,5L,3L,8L,1L,7L,1L,7L,1L,1L,6L,0L,3L,6L,1L,7L,7L,3L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198612Inst : IEnumerable<long>
{
public static readonly long[] Value=A198612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198612.Bytes);
public long this[int i]=>Value[i];

public static A198612Inst Instance=new A198612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198613
{
public static readonly long[] Value={ 3L,3L,9L,7L,0L,7L,6L,2L,3L,5L,2L,7L,0L,9L,1L,3L,0L,3L,2L,1L,7L,1L,6L,3L,0L,0L,8L,6L,9L,3L,5L,9L,4L,3L,8L,3L,9L,6L,9L,3L,5L,9L,3L,6L,7L,5L,6L,3L,6L,0L,2L,4L,4L,0L,5L,8L,0L,7L,0L,5L,4L,8L,6L,5L,1L,8L,0L,7L,7L,7L,8L,7L,2L,3L,9L,1L,6L,3L,2L,3L,0L,1L,6L,6L,4L,2L,9L,6L,6L,4L,4L,7L,8L,4L,5L,9L,7L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198613Inst : IEnumerable<long>
{
public static readonly long[] Value=A198613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198613.Bytes);
public long this[int i]=>Value[i];

public static A198613Inst Instance=new A198613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198614
{
public static readonly long[] Value={ 3L,1L,6L,7L,0L,0L,4L,3L,8L,1L,8L,0L,9L,2L,6L,2L,5L,6L,0L,4L,3L,8L,5L,2L,4L,0L,0L,0L,8L,7L,9L,7L,6L,8L,1L,6L,7L,8L,5L,1L,3L,8L,6L,8L,4L,6L,9L,6L,8L,8L,9L,6L,0L,7L,0L,9L,5L,9L,9L,4L,4L,2L,8L,5L,6L,7L,1L,2L,6L,9L,7L,6L,8L,6L,3L,0L,5L,3L,9L,1L,7L,2L,2L,4L,1L,2L,3L,8L,7L,9L,7L,4L,6L,9L,8L,6L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198614Inst : IEnumerable<long>
{
public static readonly long[] Value=A198614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198614.Bytes);
public long this[int i]=>Value[i];

public static A198614Inst Instance=new A198614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198615
{
public static readonly long[] Value={ 5L,9L,0L,5L,1L,5L,7L,3L,7L,9L,3L,9L,5L,5L,8L,9L,6L,4L,6L,2L,8L,8L,7L,1L,7L,3L,7L,8L,1L,9L,3L,3L,8L,3L,0L,3L,0L,4L,8L,7L,0L,7L,1L,2L,1L,9L,5L,1L,0L,6L,0L,5L,7L,6L,0L,4L,8L,9L,1L,2L,2L,2L,1L,6L,0L,5L,7L,3L,3L,2L,4L,8L,9L,6L,3L,8L,2L,7L,3L,0L,7L,4L,3L,6L,7L,6L,0L,6L,8L,8L,3L,4L,2L,6L,1L,4L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198615Inst : IEnumerable<long>
{
public static readonly long[] Value=A198615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198615.Bytes);
public long this[int i]=>Value[i];

public static A198615Inst Instance=new A198615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198616
{
public static readonly long[] Value={ 6L,9L,2L,6L,9L,1L,1L,2L,3L,3L,5L,8L,2L,4L,7L,4L,1L,6L,8L,9L,9L,8L,6L,2L,8L,1L,1L,2L,6L,0L,4L,6L,1L,8L,4L,0L,8L,5L,5L,3L,3L,2L,9L,8L,7L,2L,6L,7L,2L,0L,4L,3L,6L,7L,0L,3L,0L,8L,2L,1L,3L,3L,0L,0L,6L,5L,0L,5L,7L,7L,2L,7L,6L,0L,4L,1L,8L,2L,3L,6L,3L,2L,6L,3L,8L,5L,1L,5L,5L,3L,2L,6L,4L,4L,2L,4L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198616Inst : IEnumerable<long>
{
public static readonly long[] Value=A198616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198616.Bytes);
public long this[int i]=>Value[i];

public static A198616Inst Instance=new A198616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198617
{
public static readonly long[] Value={ 3L,4L,6L,6L,0L,1L,4L,4L,8L,0L,7L,6L,9L,6L,1L,0L,6L,3L,3L,0L,5L,4L,2L,4L,5L,4L,8L,2L,3L,3L,6L,6L,8L,0L,4L,9L,1L,5L,7L,6L,3L,9L,4L,9L,0L,0L,7L,1L,7L,1L,6L,4L,2L,2L,1L,7L,7L,2L,8L,1L,5L,0L,0L,5L,9L,7L,8L,8L,8L,5L,0L,3L,5L,7L,5L,3L,7L,2L,9L,3L,1L,4L,4L,1L,1L,5L,8L,5L,4L,7L,3L,3L,4L,2L,5L,2L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198617Inst : IEnumerable<long>
{
public static readonly long[] Value=A198617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198617.Bytes);
public long this[int i]=>Value[i];

public static A198617Inst Instance=new A198617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198618
{
public static readonly long[] Value={ 3L,1L,1L,8L,2L,9L,7L,4L,9L,6L,8L,4L,4L,7L,6L,4L,3L,6L,7L,5L,8L,9L,8L,9L,9L,3L,4L,7L,9L,0L,2L,4L,5L,1L,1L,6L,8L,2L,6L,3L,7L,0L,1L,2L,7L,1L,2L,8L,3L,1L,6L,6L,0L,8L,5L,5L,2L,2L,5L,7L,6L,5L,9L,7L,4L,4L,5L,7L,5L,8L,4L,2L,5L,8L,5L,8L,0L,3L,0L,8L,2L,9L,6L,7L,7L,2L,1L,6L,9L,9L,0L,3L,1L,6L,4L,7L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198618Inst : IEnumerable<long>
{
public static readonly long[] Value=A198618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198618.Bytes);
public long this[int i]=>Value[i];

public static A198618Inst Instance=new A198618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198619
{
public static readonly long[] Value={ 3L,5L,4L,1L,0L,0L,5L,7L,7L,3L,1L,0L,0L,7L,7L,1L,7L,0L,2L,1L,0L,9L,0L,2L,2L,6L,2L,6L,0L,6L,3L,1L,5L,4L,5L,2L,9L,4L,5L,9L,6L,5L,9L,4L,4L,9L,5L,0L,0L,0L,6L,7L,0L,3L,3L,5L,0L,1L,5L,3L,9L,7L,6L,6L,0L,2L,5L,0L,5L,3L,2L,8L,8L,6L,6L,9L,4L,7L,2L,6L,3L,0L,1L,5L,6L,6L,3L,7L,7L,1L,3L,6L,1L,8L,8L,4L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198619Inst : IEnumerable<long>
{
public static readonly long[] Value=A198619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198619.Bytes);
public long this[int i]=>Value[i];

public static A198619Inst Instance=new A198619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198620
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,6L,11L,23L,47L,103L,226L,518L,1200L,2866L,6939L,17184L,43133L,110122L,284485L,744297L,1965907L,5240825L,14072796L,38039586L,103368602L,282201932L,773327639L,2126010274L,5860104847L,16188449006L,44801184159L,124173477355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198620Inst : IEnumerable<long>
{
public static readonly long[] Value=A198620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198620.Bytes);
public long this[int i]=>Value[i];

public static A198620Inst Instance=new A198620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198621
{
public static readonly long[] Value={ 1L,3L,14L,76L,488L,3521L,28009L,241590L,2223711L,21519533L,216099699L,2228023793L,23394765858L,248722671553L,2666496996271L,28746778089814L,311062415257234L,3374225209472645L,36661349689794535L,398760168220542400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198621Inst : IEnumerable<long>
{
public static readonly long[] Value=A198621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198621.Bytes);
public long this[int i]=>Value[i];

public static A198621Inst Instance=new A198621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198622
{
public static readonly BigInteger[] Value={ 1L,14L,185L,3904L,98330L,3003238L,102181788L,3756159287L,143881181753L,5646945550174L,224449531632679L,8983735573661052L,360899833600169940L,14527041510634994082UL,BigInteger.Parse("585360583605415473815"),BigInteger.Parse("23600147044273485824546") };
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
public class A198622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198622.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198622Inst Instance=new A198622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198623
{
public static readonly BigInteger[] Value={ 2L,76L,3904L,342414L,38208073L,5040999127L,713917706692L,104761044616109L,15592916566103795L,2336049130708319067L,BigInteger.Parse("350907921051582692624"),BigInteger.Parse("52773848213221906515449"),BigInteger.Parse("7940710788554386562472855") };
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
public class A198623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198623Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198623.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198623.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198623Inst Instance=new A198623Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198624
{
public static readonly BigInteger[] Value={ 3L,488L,98330L,38208073L,18048413395L,9630271257812L,5291151764465150L,2951559987278650909L,BigInteger.Parse("1652290176778975311860") };
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
public class A198624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198624Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198624.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198624.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198624Inst Instance=new A198624Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198625
{
public static readonly long[] Value={ 6L,3521L,3003238L,5040999127L,9630271257812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198625Inst : IEnumerable<long>
{
public static readonly long[] Value=A198625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198625.Bytes);
public long this[int i]=>Value[i];

public static A198625Inst Instance=new A198625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198626
{
public static readonly long[] Value={ 11L,28009L,102181788L,713917706692L,5291151764465150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198626Inst : IEnumerable<long>
{
public static readonly long[] Value=A198626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198626.Bytes);
public long this[int i]=>Value[i];

public static A198626Inst Instance=new A198626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198627
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,14L,14L,2L,3L,76L,185L,76L,3L,6L,488L,3904L,3904L,488L,6L,11L,3521L,98330L,342414L,98330L,3521L,11L,23L,28009L,3003238L,38208073L,38208073L,3003238L,28009L,23L,47L,241590L,102181788L,5040999127L,18048413395L,5040999127L,102181788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198627Inst : IEnumerable<long>
{
public static readonly long[] Value=A198627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198627.Bytes);
public long this[int i]=>Value[i];

public static A198627Inst Instance=new A198627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198628
{
public static readonly long[] Value={ 1L,3L,15L,81L,435L,2313L,12195L,63801L,331395L,1710153L,8775075L,44808921L,227890755L,1155180393L,5839846755L,29458152441L,148335904515L,745888593033L,3746364947235L,18799770158361L,94271405748675L,472449569948073L,2366624981836515L,11850654345690681L,59323452211439235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198628Inst : IEnumerable<long>
{
public static readonly long[] Value=A198628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198628.Bytes);
public long this[int i]=>Value[i];

public static A198628Inst Instance=new A198628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198629
{
public static readonly long[] Value={ 0L,1L,7L,45L,287L,1821L,11487L,72045L,449407L,2789181L,17230367L,105996045L,649630527L,3968504541L,24174772447L,146908944045L,890924667647L,5393590283901L,32604530573727L,196853323284045L,1187295678104767L,7154833690143261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198629Inst : IEnumerable<long>
{
public static readonly long[] Value=A198629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198629.Bytes);
public long this[int i]=>Value[i];

public static A198629Inst Instance=new A198629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198630
{
public static readonly long[] Value={ 1L,4L,28L,208L,1540L,11344L,83188L,607408L,4416580L,31986064L,230784148L,1659338608L,11892395620L,84983496784L,605698755508L,4306834677808L,30560156566660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198630Inst : IEnumerable<long>
{
public static readonly long[] Value=A198630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198630.Bytes);
public long this[int i]=>Value[i];

public static A198630Inst Instance=new A198630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198631
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-1L,0L,1L,0L,-17L,0L,31L,0L,-691L,0L,5461L,0L,-929569L,0L,3202291L,0L,-221930581L,0L,4722116521L,0L,-968383680827L,0L,14717667114151L,0L,-2093660879252671L,0L,86125672563201181L,0L,BigInteger.Parse("-129848163681107301953"),0L,BigInteger.Parse("868320396104950823611"),0L };
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
public class A198631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198631Inst Instance=new A198631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198632
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,3L,0L,2L,4L,4L,0L,2L,8L,6L,5L,0L,2L,16L,14L,8L,6L,0L,2L,32L,36L,20L,10L,7L,0L,2L,64L,94L,56L,26L,12L,8L,0L,2L,128L,246L,164L,76L,32L,14L,9L,0L,2L,256L,644L,488L,234L,96L,38L,16L,10L,0L,2L,512L,1686L,1460L,740L,304L,116L,44L,18L,11L,0L,2L,1024L,4414L,4376L,2372L,992L,374L,136L,50L,20L,12L,0L,2L,2048L,11556L,13124L,7654L,3296L,1244L,444L,156L,56L,22L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198632Inst : IEnumerable<long>
{
public static readonly long[] Value=A198632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198632.Bytes);
public long this[int i]=>Value[i];

public static A198632Inst Instance=new A198632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198633
{
public static readonly long[] Value={ 3L,4L,8L,16L,32L,64L,128L,256L,512L,1024L,2048L,4096L,8192L,16384L,32768L,65536L,131072L,262144L,524288L,1048576L,2097152L,4194304L,8388608L,16777216L,33554432L,67108864L,134217728L,268435456L,536870912L,1073741824L,2147483648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198633Inst : IEnumerable<long>
{
public static readonly long[] Value=A198633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198633.Bytes);
public long this[int i]=>Value[i];

public static A198633Inst Instance=new A198633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198634
{
public static readonly long[] Value={ 1L,2L,4L,11L,33L,152L,1006L,11805L,257542L,11011758L,917095022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198634Inst : IEnumerable<long>
{
public static readonly long[] Value=A198634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198634.Bytes);
public long this[int i]=>Value[i];

public static A198634Inst Instance=new A198634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198635
{
public static readonly long[] Value={ 5L,8L,20L,56L,164L,488L,1460L,4376L,13124L,39368L,118100L,354296L,1062884L,3188648L,9565940L,28697816L,86093444L,258280328L,774840980L,2324522936L,6973568804L,20920706408L,62762119220L,188286357656L,564859072964L,1694577218888L,5083731656660L,15251194969976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198635Inst : IEnumerable<long>
{
public static readonly long[] Value=A198635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198635.Bytes);
public long this[int i]=>Value[i];

public static A198635Inst Instance=new A198635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198636
{
public static readonly long[] Value={ 3L,5L,13L,38L,117L,370L,1186L,3827L,12389L,40169L,130338L,423065L,1373466L,4459278L,14478659L,47011093L,152642789L,495626046L,1609284589L,5225309458L,16966465802L,55089756851L,178875298901L,580804419201L,1885860059450L,6123349080945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198636Inst : IEnumerable<long>
{
public static readonly long[] Value=A198636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198636.Bytes);
public long this[int i]=>Value[i];

public static A198636Inst Instance=new A198636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198637
{
public static readonly long[] Value={ 1L,0L,1L,-4L,0L,1L,-2L,-3L,0L,1L,0L,0L,-4L,0L,1L,-2L,5L,0L,-5L,0L,1L,-4L,0L,9L,0L,-6L,0L,1L,-2L,-7L,0L,14L,0L,-7L,0L,1L,0L,0L,-16L,0L,20L,0L,-8L,0L,1L,-2L,9L,0L,-30L,0L,27L,0L,-9L,0L,1L,-4L,0L,25L,0L,-50L,0L,35L,0L,-10L,0L,1L,-2L,-11L,0L,55L,0L,-77L,0L,44L,0L,-11L,0L,1L,0L,0L,-36L,0L,105L,0L,-112L,0L,54L,0L,-12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198637Inst : IEnumerable<long>
{
public static readonly long[] Value=A198637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198637.Bytes);
public long this[int i]=>Value[i];

public static A198637Inst Instance=new A198637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198638
{
public static readonly long[] Value={ 4L,36L,376L,3936L,41216L,431616L,4519936L,47333376L,495681536L,5190844416L,54359228416L,569257230336L,5961339109376L,62427953627136L,653754017775616L,6846200955273216L,71694347178868736L,750792950862053376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198638Inst : IEnumerable<long>
{
public static readonly long[] Value=A198638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198638.Bytes);
public long this[int i]=>Value[i];

public static A198638Inst Instance=new A198638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198639
{
public static readonly BigInteger[] Value={ 36L,2436L,162776L,10937316L,734979136L,49393306556L,3319433387656L,223079838087956L,14991902921730896L,1007518927448282476L,BigInteger.Parse("67709509526621985176"),BigInteger.Parse("4550363827896811116996"),BigInteger.Parse("305803588199889010224736") };
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
public class A198639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198639.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198639Inst Instance=new A198639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198640
{
public static readonly BigInteger[] Value={ 376L,162776L,70145916L,30189380016L,13004327687556L,5601924832399656L,2413172096267222836L,BigInteger.Parse("1039537719846439186376"),BigInteger.Parse("447808510571760655158776"),BigInteger.Parse("192905432626763894473193096"),BigInteger.Parse("83099149713982969238814113576") };
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
public class A198640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198640Inst Instance=new A198640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198641
{
public static readonly long[] Value={ 3936L,10937316L,30189380016L,83436203795656L,230598746057340176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198641Inst : IEnumerable<long>
{
public static readonly long[] Value=A198641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198641.Bytes);
public long this[int i]=>Value[i];

public static A198641Inst Instance=new A198641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198642
{
public static readonly long[] Value={ 4L,36L,36L,376L,2436L,376L,3936L,162776L,162776L,3936L,41216L,10937316L,70145916L,10937316L,41216L,431616L,734979136L,30189380016L,30189380016L,734979136L,431616L,4519936L,49393306556L,13004327687556L,83436203795656L,13004327687556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198642Inst : IEnumerable<long>
{
public static readonly long[] Value=A198642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198642.Bytes);
public long this[int i]=>Value[i];

public static A198642Inst Instance=new A198642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198643
{
public static readonly long[] Value={ 4L,14L,44L,134L,404L,1214L,3644L,10934L,32804L,98414L,295244L,885734L,2657204L,7971614L,23914844L,71744534L,215233604L,645700814L,1937102444L,5811307334L,17433922004L,52301766014L,156905298044L,470715894134L,1412147682404L,4236443047214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198643Inst : IEnumerable<long>
{
public static readonly long[] Value=A198643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198643.Bytes);
public long this[int i]=>Value[i];

public static A198643Inst Instance=new A198643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198644
{
public static readonly long[] Value={ 7L,23L,71L,215L,647L,1943L,5831L,17495L,52487L,157463L,472391L,1417175L,4251527L,12754583L,38263751L,114791255L,344373767L,1033121303L,3099363911L,9298091735L,27894275207L,83682825623L,251048476871L,753145430615L,2259436291847L,6778308875543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198644Inst : IEnumerable<long>
{
public static readonly long[] Value=A198644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198644.Bytes);
public long this[int i]=>Value[i];

public static A198644Inst Instance=new A198644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198645
{
public static readonly long[] Value={ 9L,29L,89L,269L,809L,2429L,7289L,21869L,65609L,196829L,590489L,1771469L,5314409L,15943229L,47829689L,143489069L,430467209L,1291401629L,3874204889L,11622614669L,34867844009L,104603532029L,313810596089L,941431788269L,2824295364809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198645Inst : IEnumerable<long>
{
public static readonly long[] Value=A198645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198645.Bytes);
public long this[int i]=>Value[i];

public static A198645Inst Instance=new A198645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198646
{
public static readonly long[] Value={ 10L,32L,98L,296L,890L,2672L,8018L,24056L,72170L,216512L,649538L,1948616L,5845850L,17537552L,52612658L,157837976L,473513930L,1420541792L,4261625378L,12784876136L,38354628410L,115063885232L,345191655698L,1035574967096L,3106724901290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198646Inst : IEnumerable<long>
{
public static readonly long[] Value=A198646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198646.Bytes);
public long this[int i]=>Value[i];

public static A198646Inst Instance=new A198646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198647
{
public static readonly long[] Value={ 2L,20L,146L,1028L,7202L,50420L,352946L,2470628L,17294402L,121060820L,847425746L,5931980228L,41523861602L,290667031220L,2034669218546L,14242684529828L,99698791708802L,697891541961620L,4885240793731346L,34196685556119428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198647Inst : IEnumerable<long>
{
public static readonly long[] Value=A198647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198647.Bytes);
public long this[int i]=>Value[i];

public static A198647Inst Instance=new A198647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198648
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,6L,11L,23L,47L,103L,226L,518L,1200L,2867L,6946L,17233L,43385L,111354L,289861L,766767L,2054605L,5579891L,15325432L,42559486L,119312586L,337469019L,961850000L,2760643085L,7971239103L,23140321458L,67486362815L,197615025815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198648Inst : IEnumerable<long>
{
public static readonly long[] Value=A198648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198648.Bytes);
public long this[int i]=>Value[i];

public static A198648Inst Instance=new A198648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198649
{
public static readonly long[] Value={ 1L,3L,14L,76L,488L,3521L,28030L,242849L,2264711L,22514016L,236355581L,2595953878L,29564752028L,346348460016L,4145325240330L,50411121219126L,620250713489362L,7696399884065815L,96085558605681094L,1204839099133770019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198649Inst : IEnumerable<long>
{
public static readonly long[] Value=A198649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198649.Bytes);
public long this[int i]=>Value[i];

public static A198649Inst Instance=new A198649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198650
{
public static readonly BigInteger[] Value={ 1L,14L,185L,3904L,98467L,3050721L,108395401L,4339928301L,188551345053L,8682042687375L,414695014034677L,20274597802217045L,1005296894185682274L,BigInteger.Parse("50276641088590089228"),BigInteger.Parse("2527391863873547297914"),BigInteger.Parse("127445954014211525204603") };
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
public class A198650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198650Inst Instance=new A198650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198651
{
public static readonly BigInteger[] Value={ 2L,76L,3904L,344008L,39898934L,5870175231L,996290832880L,184906809944845L,35956430134255744L,7167834458473450500L,BigInteger.Parse("1446698354699811336454"),BigInteger.Parse("293844456856748839234741"),BigInteger.Parse("59872951529043615795454004") };
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
public class A198651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198651Inst Instance=new A198651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198652
{
public static readonly long[] Value={ 3L,488L,98467L,39898934L,21787578805L,15022218265442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198652Inst : IEnumerable<long>
{
public static readonly long[] Value=A198652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198652.Bytes);
public long this[int i]=>Value[i];

public static A198652Inst Instance=new A198652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198653
{
public static readonly long[] Value={ 6L,3521L,3050721L,5870175231L,15022218265442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198653Inst : IEnumerable<long>
{
public static readonly long[] Value=A198653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198653.Bytes);
public long this[int i]=>Value[i];

public static A198653Inst Instance=new A198653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198654
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,14L,14L,2L,3L,76L,185L,76L,3L,6L,488L,3904L,3904L,488L,6L,11L,3521L,98467L,344008L,98467L,3521L,11L,23L,28030L,3050721L,39898934L,39898934L,3050721L,28030L,23L,47L,242849L,108395401L,5870175231L,21787578805L,5870175231L,108395401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198654Inst : IEnumerable<long>
{
public static readonly long[] Value=A198654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198654.Bytes);
public long this[int i]=>Value[i];

public static A198654Inst Instance=new A198654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198655
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,6L,11L,23L,47L,103L,226L,518L,1200L,2867L,6946L,17234L,43393L,111418L,290233L,768819L,2064637L,5626757L,15531220L,43432402L,122878654L,351665399L,1016952840L,2970387672L,8755225931L,26027153206L,77972236615L,235260594303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198655Inst : IEnumerable<long>
{
public static readonly long[] Value=A198655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198655.Bytes);
public long this[int i]=>Value[i];

public static A198655Inst Instance=new A198655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198656
{
public static readonly long[] Value={ 1L,3L,14L,76L,488L,3521L,28030L,242883L,2267306L,22621072L,239604079L,2677734762L,31381450817L,383270472363L,4847901589642L,63125725801101L,841517900517550L,11429291342102135L,157506922063918536L,2195111769933116471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198656Inst : IEnumerable<long>
{
public static readonly long[] Value=A198656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198656.Bytes);
public long this[int i]=>Value[i];

public static A198656Inst Instance=new A198656Inst();

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