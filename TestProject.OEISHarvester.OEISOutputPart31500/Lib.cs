using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A016702
{
public static readonly long[] Value={ 4L,3L,6L,9L,4L,4L,7L,8L,5L,2L,4L,6L,7L,0L,2L,1L,4L,9L,4L,1L,7L,2L,9L,4L,5L,5L,4L,1L,4L,8L,1L,4L,1L,0L,9L,2L,2L,1L,7L,3L,5L,4L,1L,2L,2L,4L,4L,2L,2L,6L,0L,9L,6L,2L,5L,4L,1L,2L,1L,7L,1L,1L,1L,7L,5L,5L,9L,8L,0L,6L,0L,6L,1L,1L,2L,4L,4L,3L,2L,2L,7L,8L,1L,4L,5L,9L,4L,0L,3L,6L,5L,7L,7L,4L,0L,7L,9L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016702Inst : IEnumerable<long>
{
public static readonly long[] Value=A016702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016702.Bytes);
public long this[int i]=>Value[i];

public static A016702Inst Instance=new A016702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016701
{
public static readonly long[] Value={ 4L,3L,5L,6L,7L,0L,8L,8L,2L,6L,6L,8L,9L,5L,9L,1L,7L,3L,6L,8L,6L,5L,9L,6L,4L,7L,9L,9L,9L,4L,6L,0L,2L,0L,8L,7L,7L,5L,2L,8L,2L,5L,8L,6L,3L,6L,9L,4L,3L,2L,1L,1L,8L,2L,2L,2L,7L,4L,4L,1L,9L,8L,5L,3L,7L,9L,4L,3L,5L,2L,5L,8L,2L,5L,1L,2L,7L,1L,3L,8L,6L,1L,8L,7L,9L,0L,5L,3L,7L,4L,5L,2L,5L,0L,6L,4L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016701Inst : IEnumerable<long>
{
public static readonly long[] Value=A016701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016701.Bytes);
public long this[int i]=>Value[i];

public static A016701Inst Instance=new A016701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016700
{
public static readonly long[] Value={ 4L,3L,4L,3L,8L,0L,5L,4L,2L,1L,8L,5L,3L,6L,8L,3L,8L,4L,9L,1L,6L,7L,2L,9L,6L,3L,2L,1L,4L,0L,8L,3L,0L,9L,0L,2L,9L,4L,5L,8L,7L,9L,1L,5L,8L,3L,5L,1L,9L,2L,7L,8L,3L,6L,3L,6L,7L,7L,9L,5L,7L,8L,5L,9L,0L,6L,8L,1L,5L,3L,4L,8L,6L,6L,6L,5L,3L,0L,5L,9L,8L,0L,8L,6L,2L,7L,1L,3L,2L,0L,6L,5L,9L,0L,5L,0L,6L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016700Inst : IEnumerable<long>
{
public static readonly long[] Value=A016700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016700.Bytes);
public long this[int i]=>Value[i];

public static A016700Inst Instance=new A016700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016699
{
public static readonly long[] Value={ 4L,3L,3L,0L,7L,3L,3L,3L,4L,0L,2L,8L,6L,3L,3L,1L,0L,7L,8L,8L,4L,3L,4L,9L,1L,6L,7L,4L,8L,0L,4L,2L,0L,6L,6L,7L,3L,3L,8L,8L,3L,7L,9L,5L,3L,0L,0L,1L,9L,6L,3L,9L,3L,2L,6L,7L,7L,9L,3L,2L,0L,2L,5L,5L,3L,9L,6L,0L,7L,9L,9L,4L,6L,0L,0L,3L,5L,8L,6L,7L,1L,9L,9L,2L,5L,8L,8L,5L,0L,3L,7L,8L,0L,8L,5L,7L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016699Inst : IEnumerable<long>
{
public static readonly long[] Value=A016699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016699.Bytes);
public long this[int i]=>Value[i];

public static A016699Inst Instance=new A016699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016698
{
public static readonly long[] Value={ 4L,3L,1L,7L,4L,8L,8L,1L,1L,3L,5L,3L,6L,3L,1L,0L,4L,4L,0L,5L,9L,6L,7L,6L,3L,9L,0L,3L,3L,7L,4L,9L,0L,0L,9L,8L,3L,6L,9L,8L,6L,9L,3L,2L,6L,6L,3L,5L,9L,7L,8L,4L,8L,9L,5L,5L,5L,9L,9L,9L,0L,1L,1L,6L,5L,8L,5L,8L,5L,2L,2L,6L,8L,6L,3L,3L,9L,2L,4L,4L,9L,6L,1L,3L,3L,8L,8L,3L,5L,1L,1L,0L,0L,0L,0L,9L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016698Inst : IEnumerable<long>
{
public static readonly long[] Value=A016698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016698.Bytes);
public long this[int i]=>Value[i];

public static A016698Inst Instance=new A016698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016697
{
public static readonly long[] Value={ 4L,3L,0L,4L,0L,6L,5L,0L,9L,3L,2L,0L,4L,1L,6L,9L,7L,5L,3L,7L,8L,5L,3L,2L,7L,7L,9L,2L,4L,8L,9L,6L,2L,3L,7L,3L,1L,9L,7L,5L,5L,7L,7L,7L,2L,1L,5L,2L,7L,8L,9L,1L,4L,1L,7L,7L,6L,5L,5L,9L,2L,6L,9L,0L,6L,8L,6L,3L,8L,3L,3L,6L,8L,9L,6L,0L,0L,5L,5L,7L,8L,1L,0L,0L,4L,8L,8L,4L,8L,6L,0L,6L,6L,8L,5L,8L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016697Inst : IEnumerable<long>
{
public static readonly long[] Value=A016697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016697.Bytes);
public long this[int i]=>Value[i];

public static A016697Inst Instance=new A016697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016696
{
public static readonly long[] Value={ 4L,2L,9L,0L,4L,5L,9L,4L,4L,1L,1L,4L,8L,3L,9L,1L,1L,2L,9L,0L,9L,2L,1L,0L,8L,8L,5L,7L,4L,3L,8L,5L,4L,2L,5L,7L,0L,9L,0L,4L,7L,5L,2L,8L,4L,4L,8L,7L,1L,5L,9L,7L,6L,6L,4L,5L,9L,5L,6L,9L,8L,8L,5L,7L,1L,6L,1L,7L,8L,9L,9L,7L,5L,9L,2L,0L,5L,9L,7L,2L,9L,3L,2L,7L,6L,3L,2L,9L,3L,2L,2L,8L,3L,4L,8L,5L,8L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016696Inst : IEnumerable<long>
{
public static readonly long[] Value=A016696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016696.Bytes);
public long this[int i]=>Value[i];

public static A016696Inst Instance=new A016696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016695
{
public static readonly long[] Value={ 4L,2L,7L,6L,6L,6L,6L,1L,1L,9L,0L,1L,6L,0L,5L,5L,3L,1L,1L,0L,4L,2L,1L,8L,6L,8L,3L,8L,2L,1L,9L,5L,8L,1L,1L,1L,3L,5L,2L,1L,4L,8L,1L,5L,1L,8L,7L,2L,6L,2L,6L,4L,6L,6L,5L,8L,3L,1L,4L,2L,8L,6L,9L,5L,7L,5L,5L,1L,6L,9L,4L,5L,2L,3L,4L,6L,3L,0L,2L,0L,8L,0L,5L,6L,4L,8L,2L,1L,4L,9L,0L,6L,1L,6L,7L,2L,0L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016695Inst : IEnumerable<long>
{
public static readonly long[] Value=A016695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016695.Bytes);
public long this[int i]=>Value[i];

public static A016695Inst Instance=new A016695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016694
{
public static readonly long[] Value={ 4L,2L,6L,2L,6L,7L,9L,8L,7L,7L,0L,4L,1L,3L,1L,5L,4L,2L,1L,3L,2L,9L,4L,5L,4L,5L,3L,2L,5L,1L,3L,0L,3L,4L,0L,9L,6L,7L,5L,9L,5L,7L,6L,5L,2L,6L,7L,1L,0L,5L,6L,6L,1L,0L,8L,1L,2L,1L,4L,2L,5L,8L,0L,2L,0L,2L,7L,3L,5L,1L,5L,0L,6L,8L,2L,4L,2L,3L,0L,3L,6L,5L,9L,6L,6L,2L,4L,3L,3L,2L,4L,2L,7L,2L,6L,3L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016694Inst : IEnumerable<long>
{
public static readonly long[] Value=A016694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016694.Bytes);
public long this[int i]=>Value[i];

public static A016694Inst Instance=new A016694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016693
{
public static readonly long[] Value={ 4L,2L,4L,8L,4L,9L,5L,2L,4L,2L,0L,4L,9L,3L,5L,8L,9L,8L,9L,1L,2L,3L,3L,4L,4L,1L,9L,8L,1L,2L,7L,5L,4L,3L,9L,3L,7L,2L,3L,8L,1L,8L,6L,2L,1L,8L,2L,1L,0L,6L,3L,4L,1L,6L,4L,4L,9L,2L,7L,1L,8L,0L,5L,0L,9L,0L,5L,1L,5L,2L,4L,7L,2L,4L,2L,9L,4L,2L,1L,7L,4L,8L,0L,2L,3L,6L,5L,5L,7L,0L,3L,6L,7L,7L,4L,6L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016693Inst : IEnumerable<long>
{
public static readonly long[] Value=A016693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016693.Bytes);
public long this[int i]=>Value[i];

public static A016693Inst Instance=new A016693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016692
{
public static readonly long[] Value={ 4L,2L,3L,4L,1L,0L,6L,5L,0L,4L,5L,9L,7L,2L,5L,9L,3L,8L,2L,2L,0L,1L,9L,9L,8L,0L,6L,8L,7L,3L,2L,7L,2L,1L,8L,2L,3L,0L,8L,9L,8L,7L,0L,8L,7L,2L,6L,6L,3L,1L,8L,5L,1L,9L,3L,7L,3L,3L,3L,2L,9L,7L,1L,1L,1L,2L,0L,4L,8L,7L,5L,3L,9L,2L,0L,3L,4L,0L,7L,2L,6L,5L,0L,7L,2L,0L,1L,6L,8L,4L,6L,9L,6L,6L,7L,2L,6L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016692Inst : IEnumerable<long>
{
public static readonly long[] Value=A016692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016692.Bytes);
public long this[int i]=>Value[i];

public static A016692Inst Instance=new A016692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016691
{
public static readonly long[] Value={ 4L,2L,1L,9L,5L,0L,7L,7L,0L,5L,1L,7L,6L,1L,0L,6L,6L,9L,9L,0L,8L,3L,9L,9L,8L,8L,6L,0L,7L,8L,9L,4L,7L,9L,6L,7L,1L,7L,3L,9L,2L,0L,3L,2L,8L,1L,3L,0L,6L,2L,5L,5L,2L,9L,5L,5L,3L,8L,5L,9L,7L,7L,5L,6L,8L,6L,9L,0L,7L,9L,8L,1L,9L,7L,4L,0L,3L,2L,0L,7L,1L,2L,1L,2L,3L,8L,2L,1L,5L,2L,2L,0L,3L,0L,3L,4L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016691Inst : IEnumerable<long>
{
public static readonly long[] Value=A016691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016691.Bytes);
public long this[int i]=>Value[i];

public static A016691Inst Instance=new A016691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016690
{
public static readonly long[] Value={ 4L,2L,0L,4L,6L,9L,2L,6L,1L,9L,3L,9L,0L,9L,6L,6L,0L,5L,9L,6L,7L,0L,0L,7L,1L,9L,9L,6L,3L,6L,3L,7L,2L,2L,7L,5L,0L,5L,6L,6L,9L,3L,2L,9L,0L,3L,2L,2L,1L,8L,9L,5L,3L,3L,7L,1L,3L,7L,7L,8L,4L,1L,3L,0L,7L,7L,5L,2L,6L,8L,5L,0L,5L,5L,2L,8L,0L,8L,6L,8L,9L,6L,6L,3L,8L,9L,1L,4L,1L,8L,7L,8L,2L,1L,0L,2L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016690Inst : IEnumerable<long>
{
public static readonly long[] Value=A016690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016690.Bytes);
public long this[int i]=>Value[i];

public static A016690Inst Instance=new A016690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016689
{
public static readonly long[] Value={ 4L,1L,8L,9L,6L,5L,4L,7L,4L,2L,0L,2L,6L,4L,2L,5L,5L,4L,4L,8L,7L,4L,4L,2L,0L,9L,3L,6L,3L,4L,5L,8L,3L,1L,5L,7L,2L,5L,4L,4L,6L,9L,7L,5L,4L,6L,1L,2L,0L,4L,2L,1L,8L,8L,1L,0L,7L,3L,9L,4L,2L,0L,5L,2L,2L,6L,1L,4L,6L,1L,5L,3L,9L,1L,0L,1L,5L,4L,0L,3L,9L,5L,5L,5L,4L,5L,3L,3L,7L,8L,9L,8L,1L,2L,7L,8L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016689Inst : IEnumerable<long>
{
public static readonly long[] Value=A016689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016689.Bytes);
public long this[int i]=>Value[i];

public static A016689Inst Instance=new A016689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016688
{
public static readonly long[] Value={ 4L,1L,7L,4L,3L,8L,7L,2L,6L,9L,8L,9L,5L,6L,3L,7L,1L,1L,0L,6L,5L,4L,2L,4L,6L,7L,7L,4L,7L,9L,1L,5L,0L,6L,2L,4L,4L,3L,3L,0L,8L,6L,9L,2L,9L,9L,0L,2L,8L,7L,2L,4L,8L,3L,8L,3L,3L,1L,6L,9L,3L,4L,0L,2L,1L,3L,7L,6L,4L,3L,6L,5L,5L,0L,3L,2L,0L,6L,7L,9L,4L,4L,0L,2L,9L,7L,0L,8L,5L,4L,1L,5L,3L,3L,6L,6L,9L,0L,9L,9L,5L,6L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016688Inst : IEnumerable<long>
{
public static readonly long[] Value=A016688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016688.Bytes);
public long this[int i]=>Value[i];

public static A016688Inst Instance=new A016688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016687
{
public static readonly long[] Value={ 4L,1L,5L,8L,8L,8L,3L,0L,8L,3L,3L,5L,9L,6L,7L,1L,8L,5L,6L,5L,0L,3L,3L,9L,2L,7L,2L,8L,7L,4L,9L,0L,5L,9L,4L,0L,8L,4L,5L,3L,0L,0L,0L,8L,0L,6L,1L,6L,1L,5L,3L,1L,5L,2L,4L,7L,2L,4L,0L,8L,0L,0L,5L,6L,9L,6L,0L,3L,6L,1L,7L,3L,1L,8L,1L,8L,1L,6L,8L,2L,9L,3L,6L,3L,5L,1L,7L,9L,9L,6L,1L,9L,7L,8L,5L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016687Inst : IEnumerable<long>
{
public static readonly long[] Value=A016687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016687.Bytes);
public long this[int i]=>Value[i];

public static A016687Inst Instance=new A016687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016686
{
public static readonly long[] Value={ 4L,1L,4L,3L,1L,3L,4L,7L,2L,6L,3L,9L,1L,5L,3L,2L,6L,8L,7L,8L,9L,5L,8L,4L,3L,2L,1L,7L,2L,8L,8L,2L,3L,1L,1L,3L,8L,9L,3L,2L,0L,6L,5L,8L,4L,5L,2L,2L,7L,3L,6L,0L,0L,9L,1L,9L,2L,8L,7L,7L,8L,8L,1L,7L,2L,1L,2L,5L,6L,8L,4L,4L,9L,1L,8L,9L,2L,8L,7L,2L,0L,1L,5L,3L,4L,8L,9L,0L,0L,0L,8L,2L,1L,5L,3L,3L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016686Inst : IEnumerable<long>
{
public static readonly long[] Value=A016686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016686.Bytes);
public long this[int i]=>Value[i];

public static A016686Inst Instance=new A016686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016669
{
public static readonly long[] Value={ 3L,8L,2L,8L,6L,4L,1L,3L,9L,6L,4L,8L,9L,0L,9L,5L,0L,0L,0L,2L,2L,3L,9L,8L,4L,9L,5L,3L,2L,6L,8L,3L,7L,2L,6L,8L,6L,5L,1L,7L,8L,8L,0L,4L,4L,9L,2L,0L,0L,6L,9L,0L,9L,9L,6L,1L,1L,9L,3L,1L,5L,3L,8L,6L,9L,7L,6L,3L,8L,6L,8L,6L,7L,9L,5L,4L,4L,9L,3L,0L,1L,3L,8L,0L,4L,2L,6L,4L,4L,1L,9L,1L,4L,9L,4L,1L,3L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016669Inst : IEnumerable<long>
{
public static readonly long[] Value=A016669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016669.Bytes);
public long this[int i]=>Value[i];

public static A016669Inst Instance=new A016669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016668
{
public static readonly long[] Value={ 3L,8L,0L,6L,6L,6L,2L,4L,8L,9L,7L,7L,0L,3L,1L,9L,7L,5L,7L,3L,9L,1L,2L,4L,9L,8L,0L,7L,0L,7L,1L,2L,3L,9L,0L,4L,8L,8L,2L,0L,5L,8L,2L,4L,6L,9L,9L,1L,4L,0L,1L,6L,6L,2L,5L,3L,8L,2L,0L,3L,6L,5L,5L,8L,7L,4L,9L,1L,6L,7L,5L,7L,4L,1L,4L,4L,8L,7L,5L,6L,9L,8L,3L,7L,7L,3L,6L,5L,3L,8L,7L,7L,2L,0L,6L,4L,3L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016668Inst : IEnumerable<long>
{
public static readonly long[] Value=A016668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016668.Bytes);
public long this[int i]=>Value[i];

public static A016668Inst Instance=new A016668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016667
{
public static readonly long[] Value={ 3L,7L,8L,4L,1L,8L,9L,6L,3L,3L,9L,1L,8L,2L,6L,1L,1L,6L,2L,8L,9L,6L,4L,0L,7L,8L,2L,0L,8L,8L,1L,4L,8L,2L,4L,3L,5L,9L,7L,2L,7L,0L,7L,1L,2L,2L,6L,5L,7L,9L,2L,7L,6L,8L,3L,4L,5L,9L,9L,2L,7L,7L,2L,8L,1L,1L,7L,3L,6L,0L,8L,6L,7L,8L,5L,2L,6L,2L,6L,1L,4L,4L,2L,8L,6L,7L,8L,1L,3L,6L,1L,9L,9L,5L,4L,7L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016667Inst : IEnumerable<long>
{
public static readonly long[] Value=A016667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016667.Bytes);
public long this[int i]=>Value[i];

public static A016667Inst Instance=new A016667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016666
{
public static readonly long[] Value={ 3L,7L,6L,1L,2L,0L,0L,1L,1L,5L,6L,9L,3L,5L,6L,2L,4L,2L,3L,4L,7L,2L,8L,4L,2L,5L,1L,3L,3L,4L,5L,8L,4L,7L,0L,3L,5L,5L,5L,9L,1L,3L,6L,1L,8L,4L,8L,8L,1L,5L,5L,5L,4L,1L,5L,1L,9L,1L,6L,8L,5L,2L,6L,4L,9L,2L,2L,8L,5L,9L,1L,7L,3L,8L,7L,2L,9L,8L,6L,4L,3L,8L,5L,3L,7L,5L,9L,1L,9L,9L,8L,0L,8L,3L,9L,9L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016666Inst : IEnumerable<long>
{
public static readonly long[] Value=A016666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016666.Bytes);
public long this[int i]=>Value[i];

public static A016666Inst Instance=new A016666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016665
{
public static readonly long[] Value={ 3L,7L,3L,7L,6L,6L,9L,6L,1L,8L,2L,8L,3L,3L,6L,8L,3L,0L,5L,9L,1L,7L,8L,3L,0L,1L,0L,1L,8L,2L,3L,8L,8L,2L,0L,0L,2L,3L,6L,0L,0L,7L,5L,4L,2L,1L,7L,6L,4L,8L,6L,5L,8L,9L,4L,3L,1L,4L,7L,6L,4L,4L,9L,3L,0L,6L,8L,4L,6L,7L,7L,7L,7L,9L,4L,0L,3L,7L,2L,9L,5L,0L,2L,6L,7L,1L,3L,7L,5L,8L,0L,3L,9L,8L,0L,2L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016665Inst : IEnumerable<long>
{
public static readonly long[] Value=A016665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016665.Bytes);
public long this[int i]=>Value[i];

public static A016665Inst Instance=new A016665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016664
{
public static readonly long[] Value={ 3L,7L,1L,3L,5L,7L,2L,0L,6L,6L,7L,0L,4L,3L,0L,7L,8L,0L,3L,8L,6L,6L,7L,6L,3L,3L,7L,3L,0L,3L,7L,4L,0L,7L,5L,8L,8L,3L,7L,6L,4L,1L,0L,4L,6L,9L,3L,9L,9L,3L,0L,1L,6L,3L,3L,6L,1L,9L,2L,6L,2L,9L,1L,0L,2L,5L,9L,9L,7L,8L,6L,1L,6L,4L,0L,5L,6L,5L,7L,5L,0L,5L,9L,6L,2L,3L,1L,7L,1L,4L,1L,3L,7L,1L,9L,8L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016664Inst : IEnumerable<long>
{
public static readonly long[] Value=A016664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016664.Bytes);
public long this[int i]=>Value[i];

public static A016664Inst Instance=new A016664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016663
{
public static readonly long[] Value={ 3L,6L,8L,8L,8L,7L,9L,4L,5L,4L,1L,1L,3L,9L,3L,6L,3L,0L,2L,8L,5L,2L,4L,5L,5L,6L,9L,7L,6L,0L,0L,7L,1L,7L,3L,4L,3L,7L,5L,2L,1L,0L,1L,7L,5L,7L,3L,4L,9L,2L,8L,3L,4L,8L,4L,2L,7L,4L,6L,8L,7L,9L,1L,9L,9L,5L,4L,3L,5L,9L,8L,5L,3L,6L,1L,6L,7L,4L,1L,9L,1L,1L,4L,4L,7L,7L,2L,3L,8L,5L,9L,0L,8L,2L,4L,3L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016663Inst : IEnumerable<long>
{
public static readonly long[] Value=A016663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016663.Bytes);
public long this[int i]=>Value[i];

public static A016663Inst Instance=new A016663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016662
{
public static readonly long[] Value={ 3L,6L,6L,3L,5L,6L,1L,6L,4L,6L,1L,2L,9L,6L,4L,6L,4L,2L,7L,4L,4L,8L,7L,3L,2L,6L,7L,8L,4L,8L,7L,8L,4L,4L,3L,0L,9L,4L,5L,2L,7L,5L,8L,5L,0L,2L,5L,8L,2L,9L,5L,6L,5L,6L,8L,1L,5L,3L,7L,3L,9L,8L,4L,4L,3L,0L,0L,9L,5L,8L,9L,6L,0L,5L,4L,3L,0L,1L,9L,1L,4L,6L,2L,7L,3L,1L,9L,0L,4L,1L,8L,2L,5L,4L,2L,2L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016662Inst : IEnumerable<long>
{
public static readonly long[] Value=A016662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016662.Bytes);
public long this[int i]=>Value[i];

public static A016662Inst Instance=new A016662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016661
{
public static readonly long[] Value={ 3L,6L,3L,7L,5L,8L,6L,1L,5L,9L,7L,2L,6L,3L,8L,5L,7L,6L,9L,4L,2L,6L,2L,5L,9L,5L,5L,3L,3L,4L,6L,0L,3L,0L,1L,0L,5L,3L,1L,2L,8L,7L,9L,3L,9L,5L,6L,5L,9L,3L,8L,4L,0L,7L,2L,6L,5L,8L,6L,4L,0L,2L,4L,5L,9L,0L,2L,6L,8L,6L,3L,2L,4L,0L,3L,3L,8L,9L,2L,0L,0L,4L,3L,2L,0L,0L,2L,1L,7L,1L,0L,8L,1L,2L,1L,5L,8L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016661Inst : IEnumerable<long>
{
public static readonly long[] Value=A016661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016661.Bytes);
public long this[int i]=>Value[i];

public static A016661Inst Instance=new A016661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016660
{
public static readonly long[] Value={ 3L,6L,1L,0L,9L,1L,7L,9L,1L,2L,6L,4L,4L,2L,2L,4L,4L,4L,4L,3L,6L,8L,0L,9L,5L,6L,7L,1L,0L,3L,1L,4L,4L,7L,1L,6L,3L,9L,0L,0L,0L,7L,7L,5L,8L,7L,1L,6L,7L,6L,3L,6L,1L,6L,3L,6L,4L,4L,9L,1L,2L,6L,8L,1L,1L,9L,2L,9L,8L,9L,7L,4L,6L,9L,9L,0L,3L,6L,1L,0L,6L,5L,3L,9L,9L,0L,2L,1L,5L,3L,3L,6L,7L,2L,1L,6L,8L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016660Inst : IEnumerable<long>
{
public static readonly long[] Value=A016660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016660.Bytes);
public long this[int i]=>Value[i];

public static A016660Inst Instance=new A016660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016659
{
public static readonly long[] Value={ 3L,5L,8L,3L,5L,1L,8L,9L,3L,8L,4L,5L,6L,1L,1L,0L,0L,0L,1L,6L,2L,4L,9L,5L,4L,7L,1L,6L,7L,6L,1L,4L,0L,4L,5L,4L,5L,4L,4L,5L,9L,8L,1L,3L,8L,4L,3L,6L,6L,0L,0L,9L,4L,1L,1L,7L,1L,0L,7L,4L,8L,6L,8L,6L,2L,6L,1L,7L,7L,5L,8L,3L,0L,3L,7L,6L,6L,0L,7L,3L,6L,4L,9L,5L,8L,9L,5L,8L,1L,6L,3L,6L,2L,0L,3L,0L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016659Inst : IEnumerable<long>
{
public static readonly long[] Value=A016659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016659.Bytes);
public long this[int i]=>Value[i];

public static A016659Inst Instance=new A016659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016658
{
public static readonly long[] Value={ 3L,5L,5L,5L,3L,4L,8L,0L,6L,1L,4L,8L,9L,4L,1L,3L,6L,7L,9L,7L,0L,6L,1L,1L,2L,0L,7L,6L,6L,6L,9L,3L,6L,7L,3L,6L,9L,1L,6L,2L,6L,8L,6L,0L,8L,3L,8L,5L,0L,3L,7L,8L,9L,1L,0L,3L,7L,2L,0L,3L,8L,0L,4L,1L,4L,1L,1L,7L,5L,8L,8L,5L,0L,4L,5L,9L,7L,2L,7L,0L,3L,2L,4L,1L,7L,7L,9L,2L,3L,7L,6L,6L,8L,1L,0L,5L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016658Inst : IEnumerable<long>
{
public static readonly long[] Value=A016658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016658.Bytes);
public long this[int i]=>Value[i];

public static A016658Inst Instance=new A016658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016657
{
public static readonly long[] Value={ 3L,5L,2L,6L,3L,6L,0L,5L,2L,4L,6L,1L,6L,1L,6L,1L,3L,8L,9L,6L,6L,6L,7L,6L,6L,7L,3L,9L,3L,3L,1L,3L,0L,3L,1L,0L,3L,6L,6L,3L,7L,0L,3L,1L,4L,6L,9L,4L,6L,0L,0L,0L,0L,4L,1L,4L,1L,7L,9L,1L,7L,7L,4L,7L,3L,7L,5L,6L,8L,6L,1L,9L,7L,7L,7L,0L,6L,2L,5L,9L,9L,6L,5L,1L,7L,9L,5L,8L,1L,9L,5L,0L,3L,3L,9L,2L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016657Inst : IEnumerable<long>
{
public static readonly long[] Value=A016657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016657.Bytes);
public long this[int i]=>Value[i];

public static A016657Inst Instance=new A016657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016656
{
public static readonly long[] Value={ 3L,4L,9L,6L,5L,0L,7L,5L,6L,1L,4L,6L,6L,4L,8L,0L,2L,3L,5L,4L,5L,7L,1L,8L,8L,8L,1L,4L,8L,8L,7L,6L,5L,5L,0L,0L,4L,4L,6L,9L,1L,9L,7L,4L,1L,1L,7L,6L,0L,1L,6L,6L,6L,2L,6L,9L,5L,3L,2L,6L,2L,0L,4L,2L,7L,6L,8L,0L,6L,7L,9L,1L,7L,1L,3L,1L,8L,4L,5L,6L,7L,9L,9L,4L,8L,6L,7L,0L,4L,6L,2L,8L,1L,6L,3L,6L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016656Inst : IEnumerable<long>
{
public static readonly long[] Value=A016656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016656.Bytes);
public long this[int i]=>Value[i];

public static A016656Inst Instance=new A016656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016655
{
public static readonly long[] Value={ 3L,4L,6L,5L,7L,3L,5L,9L,0L,2L,7L,9L,9L,7L,2L,6L,5L,4L,7L,0L,8L,6L,1L,6L,0L,6L,0L,7L,2L,9L,0L,8L,8L,2L,8L,4L,0L,3L,7L,7L,5L,0L,0L,6L,7L,1L,8L,0L,1L,2L,7L,6L,2L,7L,0L,6L,0L,3L,4L,0L,0L,0L,4L,7L,4L,6L,6L,9L,6L,8L,1L,0L,9L,8L,4L,8L,4L,7L,3L,5L,7L,8L,0L,2L,9L,3L,1L,6L,6L,3L,4L,9L,8L,2L,0L,9L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016655Inst : IEnumerable<long>
{
public static readonly long[] Value=A016655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016655.Bytes);
public long this[int i]=>Value[i];

public static A016655Inst Instance=new A016655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016654
{
public static readonly long[] Value={ 3L,4L,3L,3L,9L,8L,7L,2L,0L,4L,4L,8L,5L,1L,4L,6L,2L,4L,5L,9L,2L,9L,1L,6L,4L,3L,2L,4L,5L,4L,2L,3L,5L,7L,2L,1L,0L,4L,4L,9L,9L,3L,8L,9L,3L,0L,4L,8L,0L,5L,9L,1L,9L,7L,1L,7L,5L,6L,7L,1L,8L,0L,7L,2L,4L,7L,4L,9L,8L,1L,4L,1L,6L,5L,9L,7L,5L,5L,1L,2L,3L,2L,2L,1L,3L,8L,6L,4L,8L,3L,1L,3L,3L,6L,0L,8L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016654Inst : IEnumerable<long>
{
public static readonly long[] Value=A016654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016654.Bytes);
public long this[int i]=>Value[i];

public static A016654Inst Instance=new A016654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016653
{
public static readonly long[] Value={ 3L,4L,0L,1L,1L,9L,7L,3L,8L,1L,6L,6L,2L,1L,5L,5L,3L,7L,5L,4L,1L,3L,2L,3L,6L,6L,9L,1L,6L,0L,6L,8L,8L,9L,9L,1L,2L,2L,4L,8L,5L,9L,2L,0L,4L,6L,4L,5L,1L,5L,2L,2L,4L,2L,7L,7L,6L,8L,0L,2L,2L,2L,3L,4L,6L,0L,5L,0L,6L,6L,9L,0L,2L,8L,9L,5L,9L,6L,1L,4L,4L,7L,1L,0L,9L,6L,1L,2L,9L,5L,9L,9L,0L,3L,3L,3L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016653Inst : IEnumerable<long>
{
public static readonly long[] Value=A016653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016653.Bytes);
public long this[int i]=>Value[i];

public static A016653Inst Instance=new A016653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016652
{
public static readonly long[] Value={ 3L,3L,6L,7L,2L,9L,5L,8L,2L,9L,9L,8L,6L,4L,7L,4L,0L,2L,7L,1L,8L,3L,2L,7L,2L,0L,3L,2L,3L,6L,1L,9L,1L,1L,6L,0L,5L,4L,9L,4L,5L,1L,2L,9L,1L,3L,9L,2L,2L,7L,4L,4L,0L,7L,8L,9L,2L,1L,6L,7L,0L,3L,5L,1L,6L,4L,2L,7L,8L,0L,7L,8L,1L,1L,3L,7L,8L,5L,2L,3L,3L,3L,2L,9L,3L,3L,6L,7L,1L,1L,4L,8L,1L,7L,8L,5L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016652Inst : IEnumerable<long>
{
public static readonly long[] Value=A016652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016652.Bytes);
public long this[int i]=>Value[i];

public static A016652Inst Instance=new A016652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016651
{
public static readonly long[] Value={ 3L,3L,3L,2L,2L,0L,4L,5L,1L,0L,1L,7L,5L,2L,0L,3L,9L,2L,3L,9L,3L,9L,8L,1L,6L,9L,8L,6L,3L,5L,9L,5L,3L,2L,8L,6L,5L,7L,8L,8L,0L,8L,4L,9L,9L,8L,3L,0L,2L,3L,7L,1L,6L,9L,6L,7L,0L,0L,7L,5L,0L,1L,6L,8L,9L,2L,4L,3L,6L,7L,1L,0L,6L,6L,9L,1L,4L,5L,8L,6L,9L,8L,9L,9L,9L,3L,8L,5L,1L,5L,2L,5L,8L,0L,7L,0L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016651Inst : IEnumerable<long>
{
public static readonly long[] Value=A016651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016651.Bytes);
public long this[int i]=>Value[i];

public static A016651Inst Instance=new A016651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016650
{
public static readonly long[] Value={ 3L,2L,9L,5L,8L,3L,6L,8L,6L,6L,0L,0L,4L,3L,2L,9L,0L,7L,4L,1L,8L,5L,7L,3L,5L,7L,1L,0L,7L,6L,7L,5L,7L,7L,1L,1L,3L,9L,4L,2L,4L,7L,1L,6L,7L,3L,4L,6L,8L,2L,4L,8L,3L,5L,5L,2L,0L,4L,0L,8L,3L,0L,0L,0L,9L,1L,2L,4L,8L,2L,8L,7L,9L,6L,5L,5L,8L,2L,6L,9L,0L,0L,6L,2L,0L,8L,4L,7L,2L,6L,4L,4L,4L,1L,1L,9L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016650Inst : IEnumerable<long>
{
public static readonly long[] Value=A016650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016650.Bytes);
public long this[int i]=>Value[i];

public static A016650Inst Instance=new A016650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016649
{
public static readonly long[] Value={ 3L,2L,5L,8L,0L,9L,6L,5L,3L,8L,0L,2L,1L,4L,8L,2L,0L,4L,5L,4L,7L,0L,7L,1L,9L,5L,6L,3L,0L,2L,3L,4L,9L,5L,1L,7L,2L,8L,8L,0L,7L,6L,8L,0L,7L,9L,1L,2L,0L,4L,6L,2L,3L,7L,0L,5L,3L,9L,7L,2L,5L,5L,2L,0L,1L,5L,6L,8L,5L,8L,2L,8L,9L,2L,9L,4L,1L,0L,4L,8L,9L,5L,0L,0L,5L,4L,3L,7L,9L,9L,0L,4L,3L,6L,9L,0L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016649Inst : IEnumerable<long>
{
public static readonly long[] Value=A016649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016649.Bytes);
public long this[int i]=>Value[i];

public static A016649Inst Instance=new A016649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016648
{
public static readonly long[] Value={ 3L,2L,1L,8L,8L,7L,5L,8L,2L,4L,8L,6L,8L,2L,0L,0L,7L,4L,9L,2L,0L,1L,5L,1L,8L,6L,6L,6L,4L,5L,2L,3L,7L,5L,2L,7L,9L,0L,5L,1L,2L,0L,2L,7L,0L,8L,5L,3L,7L,0L,3L,5L,4L,4L,3L,8L,2L,5L,2L,9L,5L,7L,8L,2L,9L,4L,8L,3L,5L,7L,9L,7L,5L,4L,1L,5L,3L,1L,5L,5L,2L,9L,2L,6L,0L,2L,6L,7L,7L,5L,6L,1L,8L,6L,3L,5L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016648Inst : IEnumerable<long>
{
public static readonly long[] Value=A016648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016648.Bytes);
public long this[int i]=>Value[i];

public static A016648Inst Instance=new A016648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016647
{
public static readonly long[] Value={ 3L,1L,7L,8L,0L,5L,3L,8L,3L,0L,3L,4L,7L,9L,4L,5L,6L,1L,9L,6L,4L,6L,9L,4L,1L,6L,0L,1L,2L,9L,7L,0L,5L,5L,4L,0L,8L,8L,7L,3L,9L,9L,0L,9L,6L,0L,9L,0L,3L,5L,1L,5L,2L,1L,4L,0L,9L,6L,7L,3L,4L,3L,6L,2L,1L,1L,7L,6L,7L,5L,1L,5L,9L,1L,2L,7L,6L,9L,3L,1L,1L,3L,6L,9L,1L,2L,0L,5L,7L,3L,5L,8L,0L,2L,9L,8L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016647Inst : IEnumerable<long>
{
public static readonly long[] Value=A016647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016647.Bytes);
public long this[int i]=>Value[i];

public static A016647Inst Instance=new A016647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016646
{
public static readonly long[] Value={ 3L,1L,3L,5L,4L,9L,4L,2L,1L,5L,9L,2L,9L,1L,4L,9L,6L,9L,0L,8L,0L,6L,7L,5L,2L,8L,3L,1L,8L,1L,0L,1L,9L,6L,1L,1L,8L,4L,4L,2L,3L,8L,0L,3L,1L,4L,8L,4L,0L,4L,3L,5L,7L,4L,1L,9L,9L,8L,6L,3L,5L,3L,7L,7L,4L,8L,2L,9L,9L,3L,2L,4L,5L,9L,8L,4L,7L,9L,8L,2L,9L,8L,1L,9L,8L,4L,0L,1L,0L,9L,2L,1L,5L,2L,9L,9L,4L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016646Inst : IEnumerable<long>
{
public static readonly long[] Value=A016646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016646.Bytes);
public long this[int i]=>Value[i];

public static A016646Inst Instance=new A016646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016645
{
public static readonly long[] Value={ 3L,0L,9L,1L,0L,4L,2L,4L,5L,3L,3L,5L,8L,3L,1L,5L,8L,5L,3L,4L,7L,9L,1L,7L,5L,6L,9L,9L,4L,2L,3L,3L,0L,5L,8L,6L,7L,8L,9L,7L,2L,0L,6L,9L,8L,8L,2L,9L,7L,6L,7L,2L,4L,2L,9L,3L,3L,9L,2L,4L,7L,7L,1L,8L,6L,2L,3L,9L,6L,7L,2L,4L,5L,8L,8L,2L,9L,3L,1L,4L,2L,8L,6L,8L,0L,9L,1L,8L,0L,3L,4L,9L,9L,9L,0L,5L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016645Inst : IEnumerable<long>
{
public static readonly long[] Value=A016645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016645.Bytes);
public long this[int i]=>Value[i];

public static A016645Inst Instance=new A016645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016644
{
public static readonly long[] Value={ 3L,0L,4L,4L,5L,2L,2L,4L,3L,7L,7L,2L,3L,4L,2L,2L,9L,9L,6L,5L,0L,0L,5L,9L,7L,9L,8L,0L,3L,6L,5L,7L,0L,5L,4L,3L,4L,2L,8L,4L,5L,7L,5L,2L,8L,7L,4L,0L,4L,6L,1L,0L,6L,4L,0L,1L,9L,4L,0L,8L,4L,4L,8L,3L,5L,7L,5L,0L,7L,4L,1L,5L,5L,9L,7L,0L,6L,7L,8L,2L,3L,4L,6L,6L,1L,2L,7L,4L,2L,5L,3L,4L,0L,1L,6L,0L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016644Inst : IEnumerable<long>
{
public static readonly long[] Value=A016644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016644.Bytes);
public long this[int i]=>Value[i];

public static A016644Inst Instance=new A016644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016643
{
public static readonly long[] Value={ 2L,9L,9L,5L,7L,3L,2L,2L,7L,3L,5L,5L,3L,9L,9L,0L,9L,9L,3L,4L,3L,5L,2L,2L,3L,5L,7L,6L,1L,4L,2L,5L,4L,0L,7L,7L,5L,6L,7L,6L,6L,0L,1L,6L,2L,2L,9L,8L,9L,0L,2L,8L,2L,3L,0L,1L,5L,4L,0L,0L,7L,9L,1L,0L,4L,6L,0L,9L,6L,6L,2L,3L,1L,6L,4L,7L,0L,4L,7L,1L,9L,5L,8L,4L,1L,8L,6L,0L,5L,3L,2L,0L,8L,6L,0L,1L,6L,9L,8L,5L,8L,8L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016643Inst : IEnumerable<long>
{
public static readonly long[] Value=A016643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016643.Bytes);
public long this[int i]=>Value[i];

public static A016643Inst Instance=new A016643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016642
{
public static readonly long[] Value={ 2L,9L,4L,4L,4L,3L,8L,9L,7L,9L,1L,6L,6L,4L,4L,0L,4L,6L,0L,0L,0L,9L,0L,2L,7L,4L,3L,1L,8L,8L,7L,8L,5L,3L,5L,3L,7L,2L,3L,7L,3L,7L,9L,2L,6L,1L,2L,9L,9L,1L,2L,8L,8L,1L,8L,5L,3L,7L,9L,6L,0L,2L,3L,6L,4L,0L,9L,2L,9L,2L,7L,0L,2L,0L,6L,4L,1L,9L,7L,2L,8L,8L,7L,1L,4L,1L,5L,8L,3L,8L,3L,8L,1L,5L,7L,3L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016642Inst : IEnumerable<long>
{
public static readonly long[] Value=A016642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016642.Bytes);
public long this[int i]=>Value[i];

public static A016642Inst Instance=new A016642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016641
{
public static readonly long[] Value={ 2L,8L,9L,0L,3L,7L,1L,7L,5L,7L,8L,9L,6L,1L,6L,4L,6L,9L,2L,2L,0L,7L,7L,2L,2L,5L,9L,5L,3L,0L,3L,2L,2L,7L,9L,7L,7L,3L,7L,0L,4L,8L,1L,2L,5L,0L,0L,0L,5L,7L,5L,4L,1L,5L,7L,5L,9L,0L,0L,6L,8L,6L,7L,6L,7L,6L,8L,3L,8L,2L,2L,0L,8L,4L,0L,6L,9L,1L,2L,6L,4L,9L,3L,5L,3L,0L,9L,4L,8L,3L,6L,6L,2L,3L,8L,8L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016641Inst : IEnumerable<long>
{
public static readonly long[] Value=A016641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016641.Bytes);
public long this[int i]=>Value[i];

public static A016641Inst Instance=new A016641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016640
{
public static readonly long[] Value={ 2L,8L,3L,3L,2L,1L,3L,3L,4L,4L,0L,5L,6L,2L,1L,6L,0L,8L,0L,2L,4L,9L,5L,3L,4L,6L,1L,7L,8L,7L,3L,1L,2L,6L,5L,3L,5L,5L,8L,8L,2L,0L,3L,0L,1L,2L,5L,8L,5L,7L,4L,4L,7L,8L,7L,2L,9L,7L,2L,3L,7L,7L,3L,7L,8L,8L,2L,2L,9L,2L,5L,7L,5L,8L,0L,0L,9L,3L,1L,2L,8L,0L,9L,1L,2L,0L,9L,4L,8L,6L,8L,0L,3L,7L,5L,0L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016640Inst : IEnumerable<long>
{
public static readonly long[] Value=A016640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016640.Bytes);
public long this[int i]=>Value[i];

public static A016640Inst Instance=new A016640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016639
{
public static readonly long[] Value={ 2L,7L,7L,2L,5L,8L,8L,7L,2L,2L,2L,3L,9L,7L,8L,1L,2L,3L,7L,6L,6L,8L,9L,2L,8L,4L,8L,5L,8L,3L,2L,7L,0L,6L,2L,7L,2L,3L,0L,2L,0L,0L,0L,5L,3L,7L,4L,4L,1L,0L,2L,1L,0L,1L,6L,4L,8L,2L,7L,2L,0L,0L,3L,7L,9L,7L,3L,5L,7L,4L,4L,8L,7L,8L,7L,8L,7L,7L,8L,8L,6L,2L,4L,2L,3L,4L,5L,3L,3L,0L,7L,9L,8L,5L,6L,7L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016639Inst : IEnumerable<long>
{
public static readonly long[] Value=A016639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016639.Bytes);
public long this[int i]=>Value[i];

public static A016639Inst Instance=new A016639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016638
{
public static readonly long[] Value={ 2L,7L,0L,8L,0L,5L,0L,2L,0L,1L,1L,0L,2L,2L,1L,0L,0L,6L,5L,9L,9L,6L,0L,0L,4L,5L,7L,0L,1L,4L,8L,7L,1L,3L,3L,4L,4L,1L,7L,3L,0L,9L,1L,9L,1L,2L,0L,9L,1L,2L,6L,7L,1L,7L,3L,6L,4L,7L,3L,4L,2L,2L,2L,5L,1L,1L,1L,6L,7L,3L,2L,8L,0L,9L,2L,6L,2L,6L,6L,7L,3L,1L,5L,0L,3L,7L,4L,9L,6L,3L,2L,9L,0L,6L,9L,1L,1L,6L,9L,9L,5L,8L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016638Inst : IEnumerable<long>
{
public static readonly long[] Value=A016638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016638.Bytes);
public long this[int i]=>Value[i];

public static A016638Inst Instance=new A016638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016621
{
public static readonly long[] Value={ 3L,7L,9L,5L,4L,8L,9L,1L,8L,9L,1L,7L,2L,1L,9L,4L,5L,2L,8L,9L,0L,0L,5L,8L,3L,4L,1L,9L,2L,1L,1L,6L,7L,2L,6L,5L,1L,3L,2L,9L,1L,6L,0L,2L,5L,2L,7L,7L,2L,7L,0L,4L,1L,0L,9L,9L,8L,6L,0L,1L,7L,5L,6L,7L,7L,9L,4L,5L,6L,0L,2L,7L,0L,8L,0L,9L,7L,6L,1L,5L,3L,0L,8L,4L,1L,2L,0L,0L,2L,2L,4L,9L,5L,3L,0L,5L,7L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016621Inst : IEnumerable<long>
{
public static readonly long[] Value=A016621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016621.Bytes);
public long this[int i]=>Value[i];

public static A016621Inst Instance=new A016621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016620
{
public static readonly long[] Value={ 3L,7L,7L,2L,7L,6L,0L,9L,3L,8L,0L,9L,4L,6L,3L,8L,4L,0L,9L,1L,6L,1L,2L,8L,5L,1L,4L,7L,8L,2L,6L,2L,6L,0L,7L,4L,2L,0L,6L,6L,5L,0L,3L,3L,3L,7L,3L,8L,5L,2L,3L,8L,2L,7L,6L,5L,3L,5L,6L,8L,4L,6L,7L,5L,7L,8L,6L,8L,8L,1L,4L,5L,2L,3L,8L,6L,7L,6L,6L,5L,8L,4L,5L,6L,1L,1L,1L,9L,5L,4L,2L,6L,3L,5L,1L,6L,9L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016620Inst : IEnumerable<long>
{
public static readonly long[] Value=A016620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016620.Bytes);
public long this[int i]=>Value[i];

public static A016620Inst Instance=new A016620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016619
{
public static readonly long[] Value={ 3L,7L,4L,9L,5L,0L,4L,0L,7L,5L,9L,3L,0L,3L,7L,1L,1L,4L,5L,4L,3L,3L,0L,6L,1L,8L,2L,9L,6L,4L,1L,1L,3L,7L,6L,0L,7L,0L,3L,8L,3L,0L,4L,2L,3L,2L,4L,9L,4L,0L,0L,7L,2L,5L,5L,0L,8L,9L,2L,0L,5L,6L,1L,9L,8L,6L,3L,0L,7L,7L,9L,4L,1L,5L,3L,8L,8L,9L,4L,3L,2L,9L,9L,3L,6L,3L,6L,5L,4L,1L,9L,1L,3L,4L,2L,6L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016619Inst : IEnumerable<long>
{
public static readonly long[] Value=A016619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016619.Bytes);
public long this[int i]=>Value[i];

public static A016619Inst Instance=new A016619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016618
{
public static readonly long[] Value={ 3L,7L,2L,5L,6L,9L,3L,4L,2L,7L,2L,3L,6L,6L,5L,2L,6L,1L,4L,0L,5L,8L,2L,4L,0L,1L,0L,1L,8L,3L,3L,1L,9L,3L,8L,8L,4L,9L,5L,3L,8L,1L,2L,9L,2L,2L,3L,0L,2L,9L,8L,1L,1L,1L,6L,0L,6L,7L,2L,6L,3L,4L,5L,3L,4L,4L,5L,1L,8L,5L,3L,6L,7L,9L,1L,9L,2L,9L,5L,8L,9L,0L,2L,3L,2L,5L,6L,3L,9L,6L,9L,9L,7L,4L,1L,5L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016618Inst : IEnumerable<long>
{
public static readonly long[] Value=A016618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016618.Bytes);
public long this[int i]=>Value[i];

public static A016618Inst Instance=new A016618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016617
{
public static readonly long[] Value={ 3L,7L,0L,1L,3L,0L,1L,9L,7L,4L,1L,1L,2L,4L,9L,3L,4L,5L,6L,1L,6L,3L,7L,4L,8L,8L,2L,6L,2L,3L,1L,9L,2L,6L,2L,5L,0L,5L,1L,4L,4L,6L,2L,0L,9L,6L,9L,3L,0L,7L,4L,2L,5L,5L,2L,8L,1L,8L,0L,9L,7L,3L,2L,5L,0L,5L,6L,5L,8L,3L,5L,5L,0L,9L,0L,4L,7L,4L,1L,1L,5L,1L,8L,8L,8L,5L,9L,9L,6L,9L,2L,2L,5L,8L,5L,0L,9L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016617Inst : IEnumerable<long>
{
public static readonly long[] Value=A016617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016617.Bytes);
public long this[int i]=>Value[i];

public static A016617Inst Instance=new A016617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016616
{
public static readonly long[] Value={ 3L,6L,7L,6L,3L,0L,0L,6L,7L,1L,9L,0L,7L,0L,7L,6L,1L,8L,4L,7L,5L,5L,7L,1L,3L,4L,2L,0L,0L,2L,3L,2L,3L,4L,3L,5L,4L,0L,9L,8L,0L,4L,1L,0L,9L,0L,0L,6L,2L,3L,5L,4L,3L,7L,1L,2L,9L,1L,4L,9L,1L,1L,0L,8L,0L,6L,6L,4L,1L,2L,4L,3L,9L,1L,5L,4L,7L,3L,7L,5L,6L,2L,5L,4L,0L,0L,7L,7L,0L,3L,8L,7L,7L,7L,6L,6L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016616Inst : IEnumerable<long>
{
public static readonly long[] Value=A016616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016616.Bytes);
public long this[int i]=>Value[i];

public static A016616Inst Instance=new A016616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016615
{
public static readonly long[] Value={ 3L,6L,5L,0L,6L,5L,8L,2L,4L,1L,2L,9L,3L,7L,3L,8L,5L,3L,9L,7L,5L,0L,0L,6L,4L,1L,9L,9L,9L,5L,0L,1L,3L,2L,4L,6L,1L,3L,8L,3L,2L,9L,1L,4L,4L,9L,1L,5L,9L,0L,2L,3L,1L,0L,9L,5L,5L,7L,2L,7L,7L,8L,4L,9L,5L,7L,4L,7L,5L,9L,8L,6L,4L,6L,9L,5L,6L,1L,1L,2L,6L,5L,2L,5L,6L,8L,4L,9L,8L,7L,9L,5L,9L,4L,0L,8L,7L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016615Inst : IEnumerable<long>
{
public static readonly long[] Value=A016615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016615.Bytes);
public long this[int i]=>Value[i];

public static A016615Inst Instance=new A016615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016614
{
public static readonly long[] Value={ 3L,6L,2L,4L,3L,4L,0L,9L,3L,2L,9L,7L,6L,3L,6L,5L,1L,3L,1L,1L,7L,9L,5L,3L,1L,7L,8L,1L,9L,1L,6L,7L,2L,4L,4L,1L,5L,6L,2L,3L,1L,9L,3L,1L,3L,1L,9L,9L,9L,5L,2L,9L,6L,4L,1L,4L,3L,9L,3L,1L,0L,1L,0L,7L,0L,9L,2L,4L,5L,8L,6L,4L,6L,6L,6L,4L,2L,2L,9L,7L,8L,0L,5L,2L,8L,0L,2L,0L,1L,8L,4L,0L,0L,3L,6L,7L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016614Inst : IEnumerable<long>
{
public static readonly long[] Value=A016614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016614.Bytes);
public long this[int i]=>Value[i];

public static A016614Inst Instance=new A016614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016613
{
public static readonly long[] Value={ 3L,5L,9L,7L,3L,1L,2L,2L,6L,0L,5L,8L,8L,4L,4L,5L,8L,1L,9L,6L,7L,4L,8L,7L,6L,7L,3L,5L,9L,8L,0L,3L,6L,6L,0L,0L,2L,8L,2L,9L,2L,5L,2L,7L,1L,0L,5L,1L,1L,3L,4L,2L,4L,1L,0L,4L,7L,5L,0L,1L,8L,8L,4L,7L,6L,6L,8L,3L,9L,6L,3L,5L,3L,9L,5L,0L,9L,0L,2L,5L,7L,7L,6L,7L,0L,4L,6L,5L,9L,9L,5L,8L,3L,8L,4L,4L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016613Inst : IEnumerable<long>
{
public static readonly long[] Value=A016613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016613.Bytes);
public long this[int i]=>Value[i];

public static A016613Inst Instance=new A016613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016612
{
public static readonly long[] Value={ 3L,5L,6L,9L,5L,3L,2L,6L,9L,6L,4L,8L,1L,3L,7L,0L,1L,1L,1L,9L,1L,2L,2L,2L,2L,4L,1L,1L,0L,5L,4L,8L,5L,7L,5L,2L,8L,6L,8L,4L,0L,7L,6L,3L,9L,2L,3L,5L,0L,3L,1L,0L,8L,5L,4L,0L,0L,0L,7L,4L,5L,7L,9L,2L,5L,3L,3L,9L,5L,7L,8L,8L,4L,8L,5L,4L,5L,3L,5L,6L,5L,0L,3L,6L,0L,3L,7L,9L,9L,9L,7L,2L,7L,6L,2L,1L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016612Inst : IEnumerable<long>
{
public static readonly long[] Value=A016612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016612.Bytes);
public long this[int i]=>Value[i];

public static A016612Inst Instance=new A016612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016611
{
public static readonly long[] Value={ 3L,5L,4L,0L,9L,5L,9L,3L,2L,4L,0L,3L,7L,3L,1L,4L,0L,7L,2L,7L,8L,4L,7L,6L,5L,9L,4L,7L,2L,7L,4L,5L,4L,5L,2L,5L,5L,0L,1L,4L,3L,7L,0L,7L,3L,8L,3L,0L,2L,9L,2L,9L,9L,3L,9L,6L,1L,2L,6L,4L,9L,7L,0L,1L,6L,2L,7L,0L,9L,3L,9L,1L,7L,2L,3L,3L,7L,1L,2L,5L,4L,9L,4L,6L,6L,1L,5L,3L,5L,1L,9L,9L,7L,0L,3L,0L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016611Inst : IEnumerable<long>
{
public static readonly long[] Value=A016611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016611.Bytes);
public long this[int i]=>Value[i];

public static A016611Inst Instance=new A016611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016610
{
public static readonly long[] Value={ 3L,5L,1L,1L,5L,4L,5L,4L,3L,8L,8L,3L,1L,0L,2L,0L,7L,5L,0L,2L,5L,2L,8L,3L,9L,8L,7L,4L,9L,0L,5L,5L,4L,6L,1L,8L,2L,4L,9L,1L,4L,3L,2L,7L,6L,8L,8L,6L,1L,6L,4L,0L,0L,8L,3L,0L,1L,7L,1L,0L,4L,1L,2L,1L,2L,8L,1L,8L,7L,4L,8L,8L,3L,5L,5L,8L,3L,9L,2L,1L,8L,1L,0L,3L,3L,0L,5L,0L,8L,6L,0L,8L,2L,4L,6L,0L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016610Inst : IEnumerable<long>
{
public static readonly long[] Value=A016610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016610.Bytes);
public long this[int i]=>Value[i];

public static A016610Inst Instance=new A016610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016609
{
public static readonly long[] Value={ 3L,4L,8L,1L,2L,4L,0L,0L,8L,9L,3L,3L,5L,6L,9L,1L,8L,0L,1L,2L,3L,7L,0L,1L,4L,6L,5L,3L,3L,3L,3L,3L,2L,9L,6L,7L,6L,2L,5L,5L,3L,6L,9L,1L,6L,4L,6L,6L,8L,4L,6L,9L,5L,8L,4L,2L,1L,1L,0L,1L,3L,3L,9L,2L,6L,4L,4L,2L,5L,0L,0L,3L,3L,0L,6L,2L,3L,7L,3L,2L,2L,8L,4L,2L,3L,8L,4L,5L,2L,1L,4L,5L,3L,7L,2L,5L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016609Inst : IEnumerable<long>
{
public static readonly long[] Value=A016609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016609.Bytes);
public long this[int i]=>Value[i];

public static A016609Inst Instance=new A016609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016608
{
public static readonly long[] Value={ 3L,4L,4L,9L,9L,8L,7L,5L,4L,5L,8L,3L,1L,5L,8L,7L,3L,7L,8L,4L,7L,8L,6L,1L,1L,0L,9L,5L,8L,3L,0L,0L,5L,4L,5L,7L,0L,8L,5L,6L,5L,6L,5L,7L,1L,0L,8L,6L,7L,1L,0L,4L,8L,3L,7L,8L,0L,8L,0L,9L,8L,8L,0L,7L,7L,1L,9L,1L,7L,4L,8L,2L,7L,2L,1L,9L,5L,9L,2L,4L,8L,5L,9L,2L,9L,0L,2L,6L,6L,8L,1L,2L,1L,8L,9L,1L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016608Inst : IEnumerable<long>
{
public static readonly long[] Value=A016608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016608.Bytes);
public long this[int i]=>Value[i];

public static A016608Inst Instance=new A016608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016607
{
public static readonly long[] Value={ 3L,4L,1L,7L,7L,2L,6L,6L,8L,3L,6L,1L,3L,3L,6L,5L,9L,3L,9L,3L,3L,4L,1L,5L,6L,9L,8L,1L,9L,6L,7L,4L,3L,8L,1L,7L,8L,2L,4L,0L,1L,8L,1L,6L,0L,8L,7L,2L,1L,0L,0L,5L,8L,0L,8L,8L,1L,6L,7L,0L,3L,6L,3L,6L,9L,2L,6L,0L,4L,6L,1L,8L,4L,8L,7L,5L,2L,5L,4L,0L,1L,5L,5L,7L,9L,5L,6L,5L,8L,7L,9L,1L,0L,3L,6L,8L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016607Inst : IEnumerable<long>
{
public static readonly long[] Value=A016607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016607.Bytes);
public long this[int i]=>Value[i];

public static A016607Inst Instance=new A016607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016606
{
public static readonly long[] Value={ 3L,3L,8L,4L,3L,9L,0L,2L,6L,3L,3L,4L,5L,7L,7L,4L,1L,4L,1L,1L,9L,8L,8L,1L,8L,2L,5L,2L,2L,6L,1L,5L,2L,1L,0L,5L,5L,9L,8L,7L,8L,4L,6L,6L,5L,4L,9L,7L,0L,1L,9L,9L,2L,7L,5L,3L,9L,1L,3L,5L,6L,6L,8L,7L,5L,6L,5L,8L,0L,6L,4L,9L,2L,2L,9L,5L,7L,3L,2L,7L,6L,1L,7L,5L,3L,4L,7L,6L,6L,3L,2L,8L,0L,6L,2L,1L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016606Inst : IEnumerable<long>
{
public static readonly long[] Value=A016606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016606.Bytes);
public long this[int i]=>Value[i];

public static A016606Inst Instance=new A016606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016605
{
public static readonly long[] Value={ 3L,3L,4L,9L,9L,0L,4L,0L,8L,7L,2L,7L,4L,6L,0L,4L,8L,4L,1L,9L,8L,7L,0L,4L,0L,5L,4L,7L,3L,5L,2L,2L,0L,2L,6L,7L,3L,8L,0L,9L,3L,6L,9L,6L,8L,4L,7L,6L,1L,6L,2L,3L,0L,1L,6L,1L,5L,1L,9L,7L,4L,5L,6L,0L,5L,5L,3L,3L,9L,3L,3L,7L,3L,3L,1L,3L,1L,1L,1L,5L,3L,9L,9L,8L,1L,9L,1L,0L,8L,1L,1L,6L,3L,3L,0L,5L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016605Inst : IEnumerable<long>
{
public static readonly long[] Value=A016605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016605.Bytes);
public long this[int i]=>Value[i];

public static A016605Inst Instance=new A016605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016604
{
public static readonly long[] Value={ 3L,3L,1L,4L,1L,8L,6L,0L,0L,4L,6L,7L,2L,5L,2L,5L,6L,0L,9L,2L,4L,5L,4L,7L,0L,7L,8L,9L,7L,3L,3L,1L,4L,0L,3L,7L,1L,2L,7L,1L,8L,0L,8L,0L,7L,3L,8L,4L,5L,6L,7L,9L,6L,4L,3L,0L,1L,0L,5L,3L,5L,5L,9L,1L,1L,1L,1L,3L,5L,8L,9L,8L,9L,6L,5L,1L,1L,9L,9L,7L,6L,2L,0L,9L,9L,3L,2L,5L,2L,5L,9L,0L,9L,9L,3L,9L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016604Inst : IEnumerable<long>
{
public static readonly long[] Value=A016604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016604.Bytes);
public long this[int i]=>Value[i];

public static A016604Inst Instance=new A016604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016603
{
public static readonly long[] Value={ 3L,2L,7L,7L,1L,4L,4L,7L,3L,2L,9L,9L,2L,1L,7L,6L,5L,2L,4L,7L,2L,7L,2L,3L,7L,0L,1L,7L,5L,7L,0L,8L,8L,1L,2L,0L,2L,2L,8L,4L,4L,7L,7L,6L,1L,8L,5L,5L,0L,9L,6L,2L,3L,4L,8L,9L,2L,7L,4L,4L,9L,4L,6L,0L,5L,2L,4L,6L,1L,1L,0L,1L,1L,9L,7L,3L,7L,9L,5L,1L,4L,2L,9L,2L,8L,7L,9L,6L,6L,1L,7L,4L,8L,9L,5L,0L,2L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016603Inst : IEnumerable<long>
{
public static readonly long[] Value=A016603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016603.Bytes);
public long this[int i]=>Value[i];

public static A016603Inst Instance=new A016603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016602
{
public static readonly long[] Value={ 3L,2L,3L,8L,6L,7L,8L,4L,5L,2L,1L,6L,4L,3L,8L,0L,4L,6L,2L,2L,2L,7L,5L,4L,7L,7L,3L,3L,3L,3L,7L,4L,7L,5L,6L,7L,2L,1L,6L,0L,1L,9L,3L,4L,3L,6L,0L,4L,8L,2L,3L,8L,9L,8L,4L,9L,1L,1L,2L,5L,2L,0L,6L,2L,0L,2L,6L,3L,9L,3L,2L,4L,7L,0L,4L,9L,8L,4L,5L,5L,3L,2L,1L,7L,9L,8L,4L,7L,2L,9L,5L,8L,5L,4L,8L,1L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016602Inst : IEnumerable<long>
{
public static readonly long[] Value=A016602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016602.Bytes);
public long this[int i]=>Value[i];

public static A016602Inst Instance=new A016602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016601
{
public static readonly long[] Value={ 3L,1L,9L,8L,6L,7L,3L,1L,1L,7L,5L,5L,0L,6L,8L,1L,3L,0L,0L,7L,9L,3L,4L,7L,3L,3L,6L,5L,4L,2L,8L,1L,8L,2L,8L,9L,1L,1L,9L,8L,6L,6L,9L,3L,2L,4L,8L,0L,3L,4L,6L,7L,1L,2L,2L,7L,9L,8L,1L,0L,0L,2L,9L,0L,3L,8L,1L,7L,6L,6L,1L,0L,3L,5L,3L,4L,4L,4L,3L,8L,1L,9L,9L,6L,9L,4L,5L,3L,6L,7L,0L,1L,7L,9L,3L,2L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016601Inst : IEnumerable<long>
{
public static readonly long[] Value=A016601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016601.Bytes);
public long this[int i]=>Value[i];

public static A016601Inst Instance=new A016601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016600
{
public static readonly long[] Value={ 3L,1L,5L,7L,0L,0L,0L,4L,2L,1L,1L,5L,0L,1L,1L,3L,2L,7L,7L,4L,0L,3L,7L,1L,8L,5L,4L,8L,3L,1L,3L,9L,9L,7L,1L,4L,0L,8L,2L,0L,5L,5L,0L,3L,6L,7L,6L,5L,9L,9L,6L,8L,7L,7L,9L,0L,7L,9L,8L,2L,8L,3L,3L,7L,3L,1L,3L,4L,2L,4L,5L,9L,1L,5L,3L,6L,1L,0L,6L,3L,5L,7L,0L,0L,4L,8L,2L,6L,4L,2L,6L,4L,3L,8L,3L,2L,7L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016600Inst : IEnumerable<long>
{
public static readonly long[] Value=A016600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016600.Bytes);
public long this[int i]=>Value[i];

public static A016600Inst Instance=new A016600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016599
{
public static readonly long[] Value={ 3L,1L,1L,3L,5L,1L,5L,3L,0L,9L,2L,1L,0L,3L,7L,4L,4L,4L,7L,9L,7L,4L,0L,1L,7L,6L,8L,5L,6L,1L,3L,0L,6L,2L,4L,8L,0L,7L,4L,5L,0L,8L,2L,3L,3L,5L,5L,5L,3L,7L,6L,1L,3L,7L,1L,2L,6L,1L,3L,5L,6L,5L,4L,9L,2L,5L,5L,7L,7L,3L,9L,5L,2L,1L,7L,5L,1L,8L,0L,9L,8L,2L,7L,7L,1L,5L,0L,2L,0L,6L,0L,7L,2L,4L,2L,2L,5L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016599Inst : IEnumerable<long>
{
public static readonly long[] Value=A016599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016599.Bytes);
public long this[int i]=>Value[i];

public static A016599Inst Instance=new A016599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016598
{
public static readonly long[] Value={ 3L,0L,6L,8L,0L,5L,2L,9L,3L,5L,1L,3L,3L,6L,1L,7L,1L,1L,4L,0L,5L,5L,6L,1L,0L,3L,9L,1L,8L,8L,7L,6L,7L,0L,4L,6L,7L,4L,8L,3L,6L,3L,6L,0L,5L,0L,5L,2L,1L,3L,0L,0L,1L,6L,1L,0L,7L,1L,0L,0L,5L,2L,5L,5L,4L,2L,9L,4L,6L,5L,5L,5L,1L,9L,0L,3L,2L,9L,1L,7L,2L,2L,9L,3L,1L,7L,2L,8L,6L,7L,1L,0L,8L,7L,5L,7L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016598Inst : IEnumerable<long>
{
public static readonly long[] Value=A016598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016598.Bytes);
public long this[int i]=>Value[i];

public static A016598Inst Instance=new A016598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016597
{
public static readonly long[] Value={ 3L,0L,2L,0L,4L,2L,4L,8L,8L,6L,1L,4L,4L,3L,6L,2L,4L,9L,4L,4L,4L,9L,5L,3L,1L,2L,5L,1L,5L,7L,9L,2L,3L,1L,0L,2L,0L,3L,0L,0L,9L,1L,0L,3L,3L,5L,0L,3L,9L,0L,4L,6L,3L,7L,9L,4L,9L,8L,5L,8L,2L,9L,0L,0L,7L,6L,6L,5L,8L,4L,9L,9L,4L,4L,3L,5L,9L,6L,2L,7L,9L,0L,3L,5L,6L,4L,5L,3L,8L,1L,4L,3L,7L,5L,5L,6L,8L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016597Inst : IEnumerable<long>
{
public static readonly long[] Value=A016597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016597.Bytes);
public long this[int i]=>Value[i];

public static A016597Inst Instance=new A016597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016596
{
public static readonly long[] Value={ 2L,9L,7L,0L,4L,1L,4L,4L,6L,5L,5L,6L,9L,7L,0L,1L,1L,1L,8L,0L,3L,1L,5L,0L,0L,5L,5L,7L,0L,2L,9L,6L,6L,7L,7L,4L,1L,3L,7L,7L,2L,5L,8L,3L,6L,8L,2L,2L,2L,7L,0L,1L,3L,1L,4L,0L,3L,3L,0L,5L,9L,8L,3L,4L,8L,0L,7L,5L,6L,5L,3L,3L,8L,5L,7L,3L,3L,2L,4L,4L,3L,0L,6L,6L,7L,3L,2L,7L,0L,9L,1L,2L,5L,7L,8L,0L,2L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016596Inst : IEnumerable<long>
{
public static readonly long[] Value=A016596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016596.Bytes);
public long this[int i]=>Value[i];

public static A016596Inst Instance=new A016596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016595
{
public static readonly long[] Value={ 2L,9L,1L,7L,7L,7L,0L,7L,3L,2L,0L,8L,4L,2L,7L,9L,1L,3L,4L,9L,5L,0L,8L,6L,3L,5L,4L,9L,5L,7L,3L,2L,7L,0L,5L,9L,5L,8L,2L,4L,5L,7L,7L,4L,5L,2L,8L,0L,7L,3L,8L,0L,9L,0L,9L,5L,2L,4L,2L,3L,2L,6L,7L,1L,6L,9L,9L,5L,9L,6L,1L,2L,5L,0L,2L,0L,6L,6L,6L,3L,4L,9L,7L,9L,3L,1L,5L,8L,2L,0L,6L,6L,7L,5L,7L,4L,9L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016595Inst : IEnumerable<long>
{
public static readonly long[] Value=A016595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016595.Bytes);
public long this[int i]=>Value[i];

public static A016595Inst Instance=new A016595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016594
{
public static readonly long[] Value={ 2L,8L,6L,2L,2L,0L,0L,8L,8L,0L,9L,2L,9L,4L,6L,8L,3L,7L,0L,2L,8L,8L,8L,7L,9L,9L,5L,5L,2L,1L,1L,1L,9L,0L,8L,0L,1L,0L,8L,7L,1L,8L,5L,9L,4L,9L,4L,9L,0L,1L,2L,3L,6L,5L,6L,2L,5L,1L,3L,5L,8L,0L,3L,1L,9L,1L,8L,3L,6L,5L,2L,2L,8L,4L,9L,0L,0L,3L,2L,3L,1L,6L,8L,1L,1L,9L,2L,9L,0L,4L,9L,6L,8L,4L,6L,3L,2L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016594Inst : IEnumerable<long>
{
public static readonly long[] Value=A016594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016594.Bytes);
public long this[int i]=>Value[i];

public static A016594Inst Instance=new A016594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016593
{
public static readonly long[] Value={ 2L,8L,0L,3L,3L,6L,0L,3L,8L,0L,9L,0L,6L,5L,3L,4L,9L,2L,6L,0L,3L,9L,9L,5L,6L,6L,9L,3L,4L,2L,9L,4L,7L,8L,4L,3L,6L,3L,9L,3L,6L,9L,7L,2L,7L,7L,3L,9L,9L,9L,1L,1L,3L,7L,2L,8L,3L,2L,5L,8L,2L,0L,3L,3L,2L,7L,4L,6L,7L,4L,2L,9L,5L,1L,6L,2L,1L,5L,0L,9L,6L,4L,3L,4L,2L,8L,0L,7L,1L,3L,5L,8L,1L,9L,9L,4L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016593Inst : IEnumerable<long>
{
public static readonly long[] Value=A016593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016593.Bytes);
public long this[int i]=>Value[i];

public static A016593Inst Instance=new A016593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016592
{
public static readonly long[] Value={ 2L,7L,4L,0L,8L,4L,0L,0L,2L,3L,9L,2L,5L,2L,0L,0L,9L,3L,6L,5L,1L,1L,9L,3L,2L,2L,0L,3L,0L,8L,4L,1L,8L,0L,6L,4L,2L,3L,7L,4L,4L,3L,8L,7L,9L,6L,1L,2L,0L,3L,3L,6L,7L,1L,7L,6L,3L,6L,0L,3L,8L,0L,6L,2L,9L,8L,1L,5L,8L,7L,7L,9L,4L,6L,2L,7L,8L,5L,6L,5L,1L,6L,6L,0L,8L,0L,0L,1L,5L,0L,4L,3L,3L,9L,6L,6L,7L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016592Inst : IEnumerable<long>
{
public static readonly long[] Value=A016592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016592.Bytes);
public long this[int i]=>Value[i];

public static A016592Inst Instance=new A016592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016591
{
public static readonly long[] Value={ 2L,6L,7L,4L,1L,4L,8L,6L,4L,9L,4L,2L,6L,5L,2L,8L,7L,1L,7L,7L,6L,6L,0L,3L,9L,9L,1L,0L,9L,0L,3L,7L,3L,5L,0L,3L,7L,4L,1L,9L,0L,1L,2L,7L,7L,9L,5L,6L,2L,4L,8L,8L,8L,2L,4L,8L,0L,0L,9L,9L,0L,3L,4L,2L,1L,4L,9L,3L,8L,7L,1L,5L,9L,1L,6L,8L,1L,5L,7L,6L,1L,7L,6L,8L,7L,5L,0L,3L,7L,8L,7L,8L,2L,1L,4L,3L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016591Inst : IEnumerable<long>
{
public static readonly long[] Value=A016591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016591.Bytes);
public long this[int i]=>Value[i];

public static A016591Inst Instance=new A016591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016590
{
public static readonly long[] Value={ 2L,6L,0L,2L,6L,8L,9L,6L,8L,5L,4L,4L,4L,3L,8L,3L,7L,6L,4L,7L,6L,8L,5L,0L,3L,5L,8L,9L,3L,0L,9L,4L,0L,0L,5L,4L,5L,8L,6L,6L,9L,7L,1L,5L,3L,9L,1L,0L,7L,9L,9L,3L,1L,0L,1L,0L,8L,3L,4L,0L,2L,9L,9L,1L,4L,1L,9L,0L,8L,9L,2L,5L,7L,6L,8L,6L,1L,3L,2L,1L,8L,5L,0L,1L,4L,9L,8L,3L,9L,3L,7L,4L,4L,4L,7L,7L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016590Inst : IEnumerable<long>
{
public static readonly long[] Value=A016590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016590.Bytes);
public long this[int i]=>Value[i];

public static A016590Inst Instance=new A016590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016589
{
public static readonly long[] Value={ 2L,5L,2L,5L,7L,2L,8L,6L,4L,4L,3L,0L,8L,2L,5L,5L,4L,3L,9L,7L,8L,4L,2L,8L,6L,5L,4L,4L,9L,9L,4L,1L,9L,8L,7L,1L,0L,9L,7L,5L,7L,0L,2L,5L,7L,4L,1L,7L,6L,7L,8L,0L,1L,8L,9L,7L,0L,4L,6L,1L,5L,7L,7L,3L,4L,5L,4L,9L,6L,4L,3L,5L,3L,4L,4L,5L,6L,2L,0L,8L,1L,3L,6L,5L,4L,4L,0L,4L,4L,2L,9L,1L,8L,9L,9L,4L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016589Inst : IEnumerable<long>
{
public static readonly long[] Value=A016589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016589.Bytes);
public long this[int i]=>Value[i];

public static A016589Inst Instance=new A016589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016588
{
public static readonly long[] Value={ 2L,4L,4L,2L,3L,4L,7L,0L,3L,5L,3L,6L,9L,2L,0L,4L,3L,8L,1L,3L,8L,9L,5L,2L,0L,7L,1L,0L,3L,5L,2L,0L,1L,9L,5L,5L,0L,3L,6L,6L,8L,8L,0L,1L,8L,0L,4L,8L,0L,1L,8L,0L,4L,8L,7L,8L,7L,7L,9L,5L,5L,3L,6L,7L,9L,8L,9L,5L,9L,9L,6L,2L,4L,0L,1L,5L,1L,0L,3L,5L,8L,2L,5L,9L,2L,5L,3L,7L,7L,6L,5L,1L,5L,6L,5L,7L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016588Inst : IEnumerable<long>
{
public static readonly long[] Value=A016588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016588.Bytes);
public long this[int i]=>Value[i];

public static A016588Inst Instance=new A016588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016587
{
public static readonly long[] Value={ 2L,3L,5L,1L,3L,7L,5L,2L,5L,7L,1L,6L,3L,4L,7L,7L,6L,8L,7L,0L,8L,3L,3L,6L,5L,8L,5L,8L,9L,0L,7L,5L,2L,8L,8L,6L,6L,2L,0L,9L,0L,7L,5L,1L,5L,3L,0L,4L,4L,3L,5L,5L,3L,8L,6L,0L,7L,3L,4L,0L,4L,4L,7L,4L,0L,8L,1L,6L,8L,0L,5L,3L,4L,0L,0L,0L,9L,8L,3L,5L,1L,9L,0L,5L,5L,4L,1L,0L,9L,2L,6L,4L,0L,5L,1L,8L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016587Inst : IEnumerable<long>
{
public static readonly long[] Value=A016587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016587.Bytes);
public long this[int i]=>Value[i];

public static A016587Inst Instance=new A016587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016586
{
public static readonly long[] Value={ 2L,2L,5L,1L,2L,9L,1L,7L,9L,8L,6L,0L,6L,4L,9L,5L,1L,5L,0L,5L,9L,1L,7L,9L,5L,3L,1L,0L,4L,2L,9L,6L,7L,6L,9L,6L,9L,1L,6L,1L,8L,7L,9L,1L,2L,6L,9L,3L,8L,8L,7L,3L,5L,6L,4L,4L,1L,7L,2L,8L,0L,2L,2L,6L,9L,1L,5L,8L,9L,9L,0L,8L,0L,0L,9L,4L,5L,0L,2L,5L,7L,3L,1L,0L,8L,2L,9L,5L,0L,5L,6L,8L,1L,9L,3L,2L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016586Inst : IEnumerable<long>
{
public static readonly long[] Value=A016586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016586.Bytes);
public long this[int i]=>Value[i];

public static A016586Inst Instance=new A016586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016585
{
public static readonly long[] Value={ 2L,1L,4L,0L,0L,6L,6L,1L,6L,3L,4L,9L,6L,2L,7L,0L,7L,7L,0L,8L,3L,2L,3L,0L,2L,4L,9L,6L,4L,1L,4L,9L,4L,9L,9L,6L,7L,5L,1L,2L,7L,0L,2L,8L,7L,8L,2L,2L,5L,4L,8L,9L,5L,3L,3L,1L,7L,6L,5L,5L,7L,7L,2L,8L,3L,8L,8L,8L,9L,8L,9L,5L,3L,8L,3L,1L,2L,3L,6L,5L,6L,5L,3L,0L,6L,2L,3L,1L,5L,4L,1L,0L,4L,1L,0L,8L,4L,2L,5L,9L,9L,7L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016585Inst : IEnumerable<long>
{
public static readonly long[] Value=A016585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016585.Bytes);
public long this[int i]=>Value[i];

public static A016585Inst Instance=new A016585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016584
{
public static readonly long[] Value={ 2L,0L,1L,4L,9L,0L,3L,0L,2L,0L,5L,4L,2L,2L,6L,4L,7L,5L,6L,5L,7L,8L,7L,7L,2L,4L,4L,8L,6L,9L,0L,5L,3L,6L,7L,7L,6L,0L,9L,7L,5L,9L,1L,7L,7L,7L,7L,3L,1L,0L,1L,1L,9L,1L,9L,5L,2L,6L,6L,6L,2L,2L,1L,5L,6L,1L,8L,2L,7L,9L,6L,5L,8L,9L,5L,6L,5L,7L,2L,0L,1L,5L,8L,9L,7L,8L,8L,6L,3L,0L,5L,9L,1L,0L,4L,9L,3L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016584Inst : IEnumerable<long>
{
public static readonly long[] Value=A016584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016584.Bytes);
public long this[int i]=>Value[i];

public static A016584Inst Instance=new A016584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016583
{
public static readonly long[] Value={ 1L,8L,7L,1L,8L,0L,2L,1L,7L,6L,9L,0L,1L,5L,9L,1L,4L,2L,6L,6L,3L,6L,2L,5L,5L,3L,2L,0L,1L,0L,7L,1L,4L,2L,0L,3L,6L,7L,2L,9L,7L,6L,7L,8L,1L,0L,3L,9L,9L,9L,5L,1L,8L,6L,2L,2L,9L,8L,3L,6L,5L,5L,0L,1L,1L,7L,0L,0L,7L,1L,0L,4L,5L,3L,5L,4L,7L,1L,5L,4L,6L,3L,7L,9L,3L,7L,1L,1L,3L,3L,6L,4L,4L,4L,0L,7L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016583Inst : IEnumerable<long>
{
public static readonly long[] Value=A016583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016583.Bytes);
public long this[int i]=>Value[i];

public static A016583Inst Instance=new A016583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016582
{
public static readonly long[] Value={ 1L,7L,0L,4L,7L,4L,8L,0L,9L,2L,2L,3L,8L,4L,2L,5L,2L,3L,4L,6L,4L,4L,7L,1L,1L,4L,5L,6L,5L,0L,6L,9L,5L,2L,7L,3L,1L,7L,4L,6L,2L,0L,6L,7L,1L,9L,5L,7L,7L,1L,6L,1L,9L,2L,1L,0L,9L,7L,8L,8L,7L,6L,9L,9L,6L,3L,7L,1L,8L,0L,0L,0L,1L,9L,4L,3L,5L,4L,1L,9L,9L,7L,4L,6L,9L,1L,9L,1L,3L,8L,1L,0L,0L,6L,2L,1L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016582Inst : IEnumerable<long>
{
public static readonly long[] Value=A016582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016582.Bytes);
public long this[int i]=>Value[i];

public static A016582Inst Instance=new A016582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016581
{
public static readonly long[] Value={ 1L,5L,0L,4L,0L,7L,7L,3L,9L,6L,7L,7L,6L,2L,7L,4L,0L,7L,3L,3L,7L,3L,2L,5L,8L,3L,5L,2L,3L,8L,6L,8L,7L,4L,8L,4L,1L,2L,1L,9L,4L,8L,0L,9L,8L,1L,2L,8L,5L,2L,4L,3L,6L,4L,9L,3L,4L,8L,7L,0L,8L,6L,5L,7L,7L,8L,1L,5L,9L,4L,9L,6L,4L,4L,6L,7L,5L,2L,3L,2L,1L,8L,1L,4L,1L,3L,6L,8L,1L,8L,2L,6L,3L,1L,0L,4L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016581Inst : IEnumerable<long>
{
public static readonly long[] Value=A016581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016581.Bytes);
public long this[int i]=>Value[i];

public static A016581Inst Instance=new A016581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016580
{
public static readonly long[] Value={ 1L,2L,5L,2L,7L,6L,2L,9L,6L,8L,4L,9L,5L,3L,6L,7L,9L,9L,5L,6L,8L,8L,1L,2L,0L,6L,2L,1L,9L,8L,5L,0L,0L,3L,1L,6L,1L,5L,6L,1L,5L,8L,4L,5L,9L,5L,2L,2L,1L,6L,0L,5L,9L,3L,4L,3L,3L,8L,7L,1L,0L,1L,4L,0L,4L,4L,4L,1L,8L,6L,2L,4L,0L,7L,8L,2L,3L,7L,4L,5L,5L,2L,1L,8L,1L,7L,9L,5L,1L,7L,1L,5L,9L,1L,4L,5L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016580Inst : IEnumerable<long>
{
public static readonly long[] Value=A016580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016580.Bytes);
public long this[int i]=>Value[i];

public static A016580Inst Instance=new A016580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016579
{
public static readonly long[] Value={ 9L,1L,6L,2L,9L,0L,7L,3L,1L,8L,7L,4L,1L,5L,5L,0L,6L,5L,1L,8L,3L,5L,2L,7L,2L,1L,1L,7L,6L,8L,0L,1L,1L,0L,7L,1L,4L,5L,0L,1L,0L,1L,2L,1L,9L,9L,0L,8L,2L,6L,2L,4L,6L,7L,7L,9L,1L,9L,6L,7L,8L,8L,1L,9L,8L,0L,7L,8L,5L,3L,6L,5L,7L,3L,7L,9L,6L,3L,0L,4L,9L,0L,2L,4L,2L,7L,0L,5L,5L,1L,0L,9L,6L,7L,6L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016579Inst : IEnumerable<long>
{
public static readonly long[] Value=A016579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016579.Bytes);
public long this[int i]=>Value[i];

public static A016579Inst Instance=new A016579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016578
{
public static readonly long[] Value={ 4L,0L,5L,4L,6L,5L,1L,0L,8L,1L,0L,8L,1L,6L,4L,3L,8L,1L,9L,7L,8L,0L,1L,3L,1L,1L,5L,4L,6L,4L,3L,4L,9L,1L,3L,6L,5L,7L,1L,9L,9L,0L,4L,2L,3L,4L,6L,2L,4L,9L,4L,1L,9L,7L,6L,1L,4L,0L,1L,4L,3L,2L,4L,1L,4L,4L,1L,0L,0L,6L,7L,1L,2L,4L,8L,9L,1L,4L,2L,5L,1L,2L,6L,7L,7L,5L,2L,4L,2L,7L,8L,1L,7L,3L,1L,3L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016578Inst : IEnumerable<long>
{
public static readonly long[] Value=A016578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016578.Bytes);
public long this[int i]=>Value[i];

public static A016578Inst Instance=new A016578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016577
{
public static readonly long[] Value={ 3L,1L,9L,4L,1L,31L,1L,1L,5L,7L,4L,2L,6L,2L,1L,5L,14L,2L,4L,1L,1L,3L,1L,22L,2L,3L,2L,2L,2L,1L,12L,2L,1L,1L,1L,1L,1L,2L,6L,2L,2L,4L,1L,7L,2L,1L,9L,27L,2L,1L,14L,6L,1L,4L,6L,2L,48L,2L,7L,17L,10L,1L,1L,4L,2L,2L,2L,2L,5L,7L,1L,19L,1L,1L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016577Inst : IEnumerable<long>
{
public static readonly long[] Value=A016577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016577.Bytes);
public long this[int i]=>Value[i];

public static A016577Inst Instance=new A016577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016576
{
public static readonly long[] Value={ 3L,1L,7L,2L,3L,1L,10L,1L,1L,1L,6L,1L,5L,32L,2L,1L,1L,10L,1L,3L,1L,1L,2L,3L,1L,32L,1L,1L,3L,18L,1L,3L,2L,1L,8L,1L,3L,1L,60L,1L,1L,1L,2L,6L,2L,1L,4L,1L,159L,1L,3L,1L,1L,1L,1L,1L,1L,8L,1L,52L,1L,1L,2L,29L,1L,2L,22L,5L,11L,3L,3L,2L,1L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016576Inst : IEnumerable<long>
{
public static readonly long[] Value=A016576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016576.Bytes);
public long this[int i]=>Value[i];

public static A016576Inst Instance=new A016576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016575
{
public static readonly long[] Value={ 3L,1L,6L,5L,1L,1L,4L,1L,5L,11L,1L,1L,3L,1L,2L,1L,2L,1L,1L,1L,19L,2L,1L,1L,1L,3L,2L,8L,5L,1L,1L,1L,1L,4L,6L,1L,1L,2L,191L,4L,1L,14L,1L,1L,1L,1L,17L,2L,4L,9L,1L,2L,2L,3L,1L,31L,2L,2L,1L,3L,3L,1L,21L,101L,2L,1L,1L,1L,3L,2L,2L,7L,6L,2L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016575Inst : IEnumerable<long>
{
public static readonly long[] Value=A016575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016575.Bytes);
public long this[int i]=>Value[i];

public static A016575Inst Instance=new A016575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016574
{
public static readonly long[] Value={ 3L,1L,5L,4L,2L,1L,2L,7L,4L,1L,1L,12L,22L,1L,2L,2L,6L,16L,10L,1L,2L,129L,1L,1L,7L,1L,96L,1L,2L,3L,8L,1L,2L,1L,5L,5L,4L,1L,7L,2L,1L,1L,406L,1L,18L,1L,1L,2L,1L,17L,1L,2L,3L,15L,1L,1L,1L,1L,3L,6L,1L,1L,20L,1L,1L,1L,1L,5L,1L,11L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016574Inst : IEnumerable<long>
{
public static readonly long[] Value=A016574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016574.Bytes);
public long this[int i]=>Value[i];

public static A016574Inst Instance=new A016574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016573
{
public static readonly long[] Value={ 3L,1L,4L,2L,17L,6L,1L,2L,1L,4L,34L,1L,1L,1L,2L,5L,1L,4L,2L,1L,1L,2L,30L,2L,7L,4L,5L,2L,1L,2L,1L,2L,3L,1L,1L,1L,9L,6L,2L,5L,1L,7L,2L,1L,1L,1L,2L,1L,1L,4L,1L,3L,1L,13L,1L,5L,1L,7L,3L,1L,1L,1L,2L,37L,3L,1L,20L,1L,11L,1L,7L,1L,2L,1L,1L,18L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016573Inst : IEnumerable<long>
{
public static readonly long[] Value=A016573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016573.Bytes);
public long this[int i]=>Value[i];

public static A016573Inst Instance=new A016573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016572
{
public static readonly long[] Value={ 3L,1L,3L,1L,8L,14L,1L,3L,1L,9L,2L,9L,22L,59L,11L,1L,2L,3L,2L,5L,3L,3L,4L,1L,7L,1L,65L,1L,6L,1L,3L,1L,7L,1L,2L,2L,1L,30L,1L,1L,1L,1L,1L,50L,1L,1L,1L,1L,4L,13L,13L,4L,1L,23L,1L,2L,2L,8L,1L,2L,2L,3L,2L,2L,3L,1L,1L,1L,8L,1L,4L,1L,1L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016572Inst : IEnumerable<long>
{
public static readonly long[] Value=A016572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016572.Bytes);
public long this[int i]=>Value[i];

public static A016572Inst Instance=new A016572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A016571
{
public static readonly long[] Value={ 3L,1L,3L,2L,2L,60L,1L,26L,15L,1L,1L,4L,1L,1L,2L,2L,3L,1L,1L,1L,5L,1L,8L,2L,1L,1L,1L,4L,3L,21L,2L,1L,6L,1L,3L,1L,7L,6L,29L,1L,1L,14L,2L,19L,2L,3L,2L,2L,3L,2L,3L,1L,1L,1L,1L,4L,3L,1L,7L,1L,2L,4L,17L,5L,1L,3L,14L,2L,97L,1L,8L,3L,1L,9L,1L,5L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A016571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A016571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A016571Inst : IEnumerable<long>
{
public static readonly long[] Value=A016571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A016571.Bytes);
public long this[int i]=>Value[i];

public static A016571Inst Instance=new A016571Inst();

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