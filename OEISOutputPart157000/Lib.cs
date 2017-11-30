using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200105
{
public static readonly long[] Value={ 6L,9L,8L,9L,3L,3L,6L,0L,4L,7L,3L,2L,9L,0L,3L,3L,0L,9L,3L,3L,7L,9L,8L,9L,5L,4L,4L,7L,3L,3L,5L,6L,7L,9L,5L,6L,2L,3L,3L,5L,7L,2L,4L,8L,5L,1L,5L,7L,6L,1L,0L,5L,7L,8L,0L,2L,5L,6L,9L,3L,4L,7L,2L,6L,5L,4L,9L,7L,8L,8L,3L,8L,4L,7L,5L,3L,2L,4L,6L,6L,6L,4L,5L,4L,3L,4L,0L,8L,3L,2L,6L,4L,0L,4L,9L,2L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200105Inst : IEnumerable<long>
{
public static readonly long[] Value=A200105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200105.Bytes);
public long this[int i]=>Value[i];

public static A200105Inst Instance=new A200105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200106
{
public static readonly long[] Value={ 1L,7L,6L,9L,5L,6L,8L,8L,7L,4L,3L,7L,2L,7L,0L,1L,7L,4L,9L,1L,1L,5L,0L,7L,8L,4L,6L,2L,0L,0L,1L,6L,2L,7L,7L,5L,4L,7L,6L,5L,5L,5L,3L,4L,1L,0L,5L,3L,8L,0L,6L,4L,0L,4L,0L,5L,3L,9L,9L,1L,8L,7L,9L,8L,4L,0L,5L,9L,5L,2L,4L,5L,4L,0L,9L,7L,9L,4L,2L,2L,5L,4L,4L,0L,2L,3L,5L,1L,2L,0L,1L,4L,4L,1L,5L,7L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200106Inst : IEnumerable<long>
{
public static readonly long[] Value=A200106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200106.Bytes);
public long this[int i]=>Value[i];

public static A200106Inst Instance=new A200106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200107
{
public static readonly long[] Value={ 4L,6L,9L,0L,3L,2L,3L,7L,1L,1L,1L,9L,8L,0L,9L,3L,0L,5L,7L,3L,3L,5L,4L,9L,3L,0L,5L,8L,0L,2L,5L,1L,0L,5L,0L,0L,5L,5L,0L,0L,5L,6L,3L,6L,9L,5L,9L,3L,8L,3L,0L,6L,6L,8L,7L,3L,2L,8L,8L,7L,0L,4L,1L,8L,4L,8L,2L,6L,3L,8L,4L,1L,7L,4L,6L,1L,1L,2L,1L,2L,9L,0L,7L,6L,5L,5L,5L,2L,5L,1L,2L,6L,4L,8L,8L,2L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200107Inst : IEnumerable<long>
{
public static readonly long[] Value=A200107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200107.Bytes);
public long this[int i]=>Value[i];

public static A200107Inst Instance=new A200107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200108
{
public static readonly long[] Value={ 8L,4L,0L,2L,6L,3L,5L,1L,7L,7L,1L,5L,7L,6L,7L,8L,9L,9L,3L,4L,7L,9L,7L,3L,4L,9L,9L,6L,4L,8L,3L,5L,5L,7L,9L,7L,3L,6L,5L,0L,2L,5L,3L,9L,0L,5L,3L,5L,1L,5L,2L,6L,6L,1L,1L,7L,3L,5L,4L,3L,6L,3L,9L,2L,5L,1L,7L,4L,5L,5L,5L,6L,5L,3L,6L,2L,5L,0L,2L,1L,5L,6L,7L,8L,0L,3L,5L,1L,8L,3L,7L,2L,4L,6L,3L,0L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200108Inst : IEnumerable<long>
{
public static readonly long[] Value=A200108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200108.Bytes);
public long this[int i]=>Value[i];

public static A200108Inst Instance=new A200108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200109
{
public static readonly long[] Value={ 3L,5L,2L,3L,6L,5L,0L,0L,5L,7L,7L,7L,3L,2L,6L,4L,5L,3L,1L,0L,2L,8L,6L,6L,1L,9L,5L,3L,5L,9L,9L,9L,6L,8L,1L,0L,8L,6L,8L,5L,9L,0L,3L,3L,1L,2L,4L,3L,7L,1L,6L,9L,7L,9L,3L,6L,0L,2L,5L,2L,5L,0L,3L,8L,5L,6L,6L,5L,7L,4L,5L,4L,2L,5L,4L,0L,3L,3L,6L,7L,0L,3L,7L,7L,7L,9L,1L,1L,0L,6L,1L,4L,3L,6L,9L,5L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200109Inst : IEnumerable<long>
{
public static readonly long[] Value=A200109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200109.Bytes);
public long this[int i]=>Value[i];

public static A200109Inst Instance=new A200109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200110
{
public static readonly long[] Value={ 1L,0L,5L,6L,6L,9L,8L,3L,7L,6L,9L,4L,2L,8L,7L,8L,1L,2L,2L,1L,9L,2L,4L,0L,8L,3L,0L,3L,1L,1L,7L,5L,2L,5L,0L,9L,3L,5L,5L,7L,1L,3L,6L,8L,6L,5L,0L,9L,1L,9L,3L,5L,0L,7L,4L,4L,3L,8L,6L,6L,4L,9L,4L,2L,8L,0L,6L,9L,8L,4L,2L,7L,3L,3L,0L,3L,3L,7L,1L,5L,8L,8L,7L,0L,0L,9L,2L,6L,3L,1L,0L,0L,5L,0L,4L,1L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200110Inst : IEnumerable<long>
{
public static readonly long[] Value=A200110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200110.Bytes);
public long this[int i]=>Value[i];

public static A200110Inst Instance=new A200110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200111
{
public static readonly long[] Value={ 2L,7L,4L,1L,8L,5L,9L,2L,8L,0L,5L,9L,8L,3L,1L,5L,7L,9L,0L,1L,2L,9L,3L,8L,5L,7L,6L,1L,6L,5L,9L,2L,6L,1L,0L,6L,7L,1L,9L,3L,4L,6L,4L,4L,2L,6L,5L,9L,6L,6L,3L,7L,1L,8L,4L,8L,3L,7L,3L,1L,3L,2L,8L,7L,6L,3L,4L,5L,8L,4L,4L,1L,6L,6L,5L,1L,5L,9L,0L,3L,6L,8L,1L,0L,1L,8L,6L,6L,3L,2L,2L,3L,7L,2L,6L,9L,8L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200111Inst : IEnumerable<long>
{
public static readonly long[] Value=A200111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200111.Bytes);
public long this[int i]=>Value[i];

public static A200111Inst Instance=new A200111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200112
{
public static readonly long[] Value={ 1L,2L,5L,7L,4L,1L,1L,4L,2L,9L,4L,9L,4L,7L,5L,9L,2L,5L,6L,0L,2L,2L,3L,7L,3L,0L,9L,8L,1L,4L,8L,0L,3L,8L,9L,5L,2L,5L,2L,1L,6L,0L,2L,4L,9L,3L,6L,7L,8L,6L,4L,7L,2L,8L,0L,1L,2L,9L,2L,2L,8L,1L,6L,3L,4L,8L,6L,2L,7L,9L,2L,8L,1L,1L,1L,6L,5L,0L,3L,7L,3L,9L,5L,0L,0L,0L,0L,0L,8L,8L,4L,9L,9L,4L,8L,5L,4L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200112Inst : IEnumerable<long>
{
public static readonly long[] Value=A200112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200112.Bytes);
public long this[int i]=>Value[i];

public static A200112Inst Instance=new A200112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200113
{
public static readonly long[] Value={ 4L,1L,9L,5L,2L,9L,9L,2L,3L,6L,1L,3L,8L,0L,8L,9L,2L,4L,2L,5L,2L,7L,8L,6L,7L,3L,1L,3L,4L,4L,1L,3L,4L,9L,6L,9L,9L,5L,5L,6L,6L,2L,8L,1L,4L,2L,3L,8L,7L,4L,0L,0L,7L,5L,0L,7L,4L,1L,1L,5L,0L,0L,5L,6L,4L,7L,5L,0L,2L,4L,3L,0L,7L,4L,1L,5L,4L,5L,1L,8L,7L,5L,7L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200113Inst : IEnumerable<long>
{
public static readonly long[] Value=A200113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200113.Bytes);
public long this[int i]=>Value[i];

public static A200113Inst Instance=new A200113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200114
{
public static readonly long[] Value={ 2L,2L,1L,2L,3L,4L,7L,1L,6L,8L,5L,6L,5L,5L,0L,8L,4L,5L,9L,2L,8L,7L,5L,1L,6L,1L,4L,5L,6L,5L,1L,7L,9L,1L,5L,6L,6L,1L,6L,0L,0L,1L,8L,4L,8L,1L,0L,3L,7L,5L,1L,2L,2L,6L,1L,0L,9L,7L,5L,6L,4L,8L,7L,2L,2L,1L,3L,6L,8L,0L,3L,2L,0L,7L,6L,1L,3L,9L,5L,9L,6L,8L,0L,3L,8L,5L,5L,3L,6L,8L,5L,1L,5L,0L,2L,9L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200114Inst : IEnumerable<long>
{
public static readonly long[] Value=A200114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200114.Bytes);
public long this[int i]=>Value[i];

public static A200114Inst Instance=new A200114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200115
{
public static readonly long[] Value={ 1L,4L,3L,1L,7L,7L,8L,7L,3L,2L,6L,8L,7L,2L,3L,1L,1L,3L,1L,8L,2L,0L,5L,9L,1L,7L,9L,9L,7L,0L,0L,5L,5L,8L,8L,4L,3L,9L,2L,4L,1L,9L,0L,4L,9L,6L,6L,1L,7L,0L,4L,2L,0L,0L,6L,6L,7L,9L,9L,9L,3L,2L,1L,8L,9L,6L,2L,3L,2L,9L,2L,4L,0L,8L,7L,8L,6L,0L,2L,1L,8L,6L,9L,6L,7L,5L,3L,0L,7L,9L,3L,7L,2L,9L,1L,1L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200115Inst : IEnumerable<long>
{
public static readonly long[] Value=A200115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200115.Bytes);
public long this[int i]=>Value[i];

public static A200115Inst Instance=new A200115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200116
{
public static readonly long[] Value={ 6L,8L,0L,3L,2L,6L,4L,1L,4L,1L,3L,8L,6L,7L,9L,2L,9L,6L,2L,3L,9L,6L,3L,1L,6L,2L,0L,7L,3L,6L,4L,1L,9L,1L,7L,6L,8L,6L,5L,5L,3L,0L,2L,5L,8L,0L,2L,1L,0L,8L,1L,4L,5L,3L,5L,6L,0L,8L,0L,7L,7L,9L,5L,9L,8L,9L,2L,6L,3L,3L,9L,2L,2L,7L,0L,8L,1L,5L,4L,8L,2L,0L,3L,7L,7L,9L,1L,0L,0L,2L,2L,0L,1L,2L,5L,7L,6L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200116Inst : IEnumerable<long>
{
public static readonly long[] Value=A200116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200116.Bytes);
public long this[int i]=>Value[i];

public static A200116Inst Instance=new A200116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200117
{
public static readonly long[] Value={ 9L,8L,4L,7L,1L,2L,6L,9L,9L,3L,6L,3L,0L,6L,7L,3L,5L,2L,4L,9L,9L,1L,3L,8L,0L,0L,9L,0L,7L,4L,8L,4L,5L,5L,2L,4L,3L,2L,3L,5L,0L,7L,8L,9L,3L,1L,1L,5L,1L,0L,5L,9L,5L,6L,0L,4L,9L,2L,5L,3L,6L,5L,5L,6L,9L,1L,3L,4L,7L,6L,9L,8L,2L,7L,3L,6L,3L,5L,2L,6L,1L,9L,1L,6L,0L,4L,3L,4L,8L,3L,7L,0L,8L,5L,6L,3L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200117Inst : IEnumerable<long>
{
public static readonly long[] Value=A200117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200117.Bytes);
public long this[int i]=>Value[i];

public static A200117Inst Instance=new A200117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200118
{
public static readonly long[] Value={ 4L,6L,6L,8L,2L,3L,6L,0L,7L,5L,7L,0L,9L,8L,6L,7L,9L,9L,5L,8L,4L,1L,3L,4L,1L,5L,4L,4L,3L,1L,5L,8L,4L,0L,4L,7L,4L,2L,6L,6L,6L,6L,7L,3L,0L,0L,8L,1L,8L,1L,8L,7L,7L,3L,4L,2L,9L,0L,2L,0L,5L,1L,2L,5L,7L,8L,4L,0L,2L,8L,8L,6L,8L,6L,8L,7L,4L,3L,9L,5L,5L,4L,5L,2L,5L,8L,6L,5L,8L,6L,8L,7L,7L,2L,6L,3L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200118Inst : IEnumerable<long>
{
public static readonly long[] Value=A200118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200118.Bytes);
public long this[int i]=>Value[i];

public static A200118Inst Instance=new A200118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200119
{
public static readonly long[] Value={ 1L,3L,0L,7L,1L,9L,0L,9L,9L,2L,0L,7L,3L,8L,1L,3L,0L,6L,6L,4L,0L,4L,6L,3L,4L,1L,8L,6L,6L,5L,4L,5L,6L,0L,4L,5L,6L,2L,8L,2L,6L,0L,4L,5L,6L,8L,3L,5L,4L,3L,0L,5L,8L,9L,0L,4L,7L,6L,7L,6L,9L,5L,2L,8L,0L,0L,3L,8L,9L,7L,8L,8L,2L,5L,4L,6L,1L,4L,1L,9L,7L,9L,5L,3L,1L,9L,0L,8L,2L,0L,8L,7L,8L,9L,7L,6L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200119Inst : IEnumerable<long>
{
public static readonly long[] Value=A200119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200119.Bytes);
public long this[int i]=>Value[i];

public static A200119Inst Instance=new A200119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200120
{
public static readonly long[] Value={ 8L,1L,5L,2L,3L,3L,2L,2L,3L,4L,1L,0L,5L,1L,4L,1L,3L,1L,2L,0L,5L,9L,2L,1L,2L,0L,0L,0L,2L,2L,2L,2L,0L,9L,7L,0L,3L,0L,0L,7L,3L,1L,1L,5L,4L,3L,9L,1L,2L,1L,5L,4L,0L,2L,0L,2L,5L,7L,2L,7L,1L,6L,8L,7L,7L,0L,1L,3L,5L,7L,9L,2L,2L,8L,9L,8L,8L,1L,8L,1L,7L,6L,1L,0L,0L,3L,9L,4L,0L,2L,9L,3L,5L,5L,6L,3L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200120Inst : IEnumerable<long>
{
public static readonly long[] Value=A200120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200120.Bytes);
public long this[int i]=>Value[i];

public static A200120Inst Instance=new A200120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200121
{
public static readonly long[] Value={ 1L,0L,7L,4L,3L,0L,9L,2L,0L,6L,5L,0L,6L,0L,4L,6L,8L,9L,0L,1L,0L,8L,3L,5L,7L,7L,7L,8L,9L,2L,8L,6L,3L,0L,6L,3L,4L,2L,8L,6L,1L,7L,0L,7L,8L,6L,8L,2L,3L,6L,6L,6L,0L,5L,3L,6L,8L,9L,9L,5L,0L,4L,9L,9L,8L,3L,8L,8L,0L,3L,8L,0L,7L,6L,1L,3L,0L,6L,5L,9L,0L,0L,0L,8L,8L,4L,2L,5L,8L,8L,9L,8L,3L,5L,2L,6L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200121Inst : IEnumerable<long>
{
public static readonly long[] Value=A200121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200121.Bytes);
public long this[int i]=>Value[i];

public static A200121Inst Instance=new A200121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200122
{
public static readonly long[] Value={ 7L,0L,4L,1L,5L,9L,4L,5L,7L,0L,3L,7L,1L,2L,2L,5L,5L,2L,6L,8L,1L,0L,5L,8L,3L,3L,3L,4L,9L,9L,4L,8L,3L,4L,8L,2L,1L,0L,8L,4L,3L,1L,6L,2L,4L,3L,5L,8L,1L,8L,1L,8L,9L,5L,8L,7L,2L,3L,4L,8L,6L,8L,3L,2L,0L,2L,1L,0L,3L,1L,9L,1L,2L,5L,1L,0L,3L,4L,6L,4L,2L,0L,1L,2L,0L,4L,1L,8L,7L,0L,2L,4L,7L,1L,3L,4L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200122Inst : IEnumerable<long>
{
public static readonly long[] Value=A200122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200122.Bytes);
public long this[int i]=>Value[i];

public static A200122Inst Instance=new A200122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200123
{
public static readonly long[] Value={ 1L,2L,1L,0L,3L,0L,1L,1L,0L,2L,1L,5L,6L,0L,5L,7L,8L,5L,9L,1L,9L,2L,8L,4L,4L,2L,4L,6L,7L,5L,9L,4L,3L,4L,7L,8L,0L,3L,8L,1L,4L,9L,4L,7L,5L,5L,4L,4L,3L,5L,2L,6L,5L,4L,1L,2L,5L,5L,9L,4L,7L,5L,6L,4L,0L,2L,5L,1L,2L,6L,1L,3L,0L,6L,7L,4L,9L,2L,0L,3L,2L,8L,7L,4L,6L,6L,2L,1L,4L,2L,7L,4L,1L,2L,6L,4L,8L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200123Inst : IEnumerable<long>
{
public static readonly long[] Value=A200123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200123.Bytes);
public long this[int i]=>Value[i];

public static A200123Inst Instance=new A200123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200124
{
public static readonly long[] Value={ 6L,0L,9L,4L,1L,6L,8L,3L,3L,2L,6L,3L,2L,7L,5L,2L,9L,9L,9L,3L,0L,7L,5L,3L,5L,9L,9L,3L,1L,6L,0L,5L,4L,8L,2L,2L,7L,8L,5L,2L,3L,3L,0L,3L,0L,5L,9L,3L,5L,8L,3L,5L,5L,5L,9L,6L,0L,5L,1L,3L,3L,4L,7L,1L,7L,8L,1L,7L,1L,9L,6L,0L,4L,8L,7L,5L,2L,6L,3L,9L,0L,1L,3L,4L,2L,5L,3L,7L,1L,3L,4L,8L,5L,4L,4L,5L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200124Inst : IEnumerable<long>
{
public static readonly long[] Value=A200124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200124.Bytes);
public long this[int i]=>Value[i];

public static A200124Inst Instance=new A200124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200125
{
public static readonly long[] Value={ 1L,3L,4L,2L,0L,4L,0L,5L,3L,4L,2L,4L,0L,7L,5L,7L,7L,6L,6L,1L,1L,9L,8L,0L,1L,0L,5L,0L,8L,1L,8L,2L,3L,8L,9L,7L,1L,5L,9L,4L,9L,8L,2L,7L,1L,6L,0L,4L,4L,0L,1L,0L,4L,7L,2L,7L,2L,0L,7L,8L,0L,9L,4L,5L,4L,1L,7L,3L,8L,6L,6L,9L,8L,0L,8L,6L,7L,8L,7L,4L,1L,4L,5L,7L,1L,3L,9L,4L,4L,1L,3L,4L,0L,8L,7L,5L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200125Inst : IEnumerable<long>
{
public static readonly long[] Value=A200125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200125.Bytes);
public long this[int i]=>Value[i];

public static A200125Inst Instance=new A200125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200126
{
public static readonly long[] Value={ 5L,3L,0L,6L,3L,3L,0L,4L,7L,4L,9L,6L,8L,4L,8L,8L,8L,0L,1L,6L,6L,8L,0L,4L,1L,7L,5L,6L,7L,1L,0L,6L,4L,1L,0L,0L,2L,8L,1L,6L,1L,9L,5L,6L,3L,6L,8L,5L,3L,5L,6L,4L,4L,6L,1L,4L,8L,4L,3L,4L,2L,1L,2L,0L,9L,6L,5L,7L,3L,0L,5L,4L,4L,1L,6L,7L,8L,8L,8L,3L,6L,3L,9L,5L,4L,1L,6L,4L,1L,4L,1L,5L,8L,8L,6L,7L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200126Inst : IEnumerable<long>
{
public static readonly long[] Value=A200126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200126.Bytes);
public long this[int i]=>Value[i];

public static A200126Inst Instance=new A200126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200127
{
public static readonly long[] Value={ 1L,4L,6L,5L,2L,3L,5L,3L,8L,6L,1L,4L,2L,6L,3L,1L,8L,5L,6L,9L,4L,5L,9L,2L,6L,8L,3L,0L,5L,7L,2L,6L,9L,4L,9L,2L,6L,9L,0L,0L,7L,8L,8L,8L,6L,2L,5L,1L,9L,6L,6L,4L,6L,8L,7L,8L,7L,8L,3L,9L,7L,1L,6L,8L,3L,1L,4L,1L,7L,3L,5L,2L,9L,3L,5L,6L,5L,7L,7L,2L,4L,5L,6L,1L,7L,8L,8L,7L,7L,2L,4L,7L,3L,1L,0L,3L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200127Inst : IEnumerable<long>
{
public static readonly long[] Value=A200127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200127.Bytes);
public long this[int i]=>Value[i];

public static A200127Inst Instance=new A200127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200128
{
public static readonly long[] Value={ 9L,1L,1L,2L,5L,1L,3L,6L,5L,7L,7L,2L,4L,8L,2L,4L,1L,2L,5L,4L,9L,4L,7L,3L,1L,8L,2L,8L,0L,2L,9L,3L,7L,5L,4L,5L,8L,5L,3L,9L,1L,6L,1L,5L,9L,8L,2L,1L,2L,5L,4L,4L,8L,1L,0L,6L,1L,2L,1L,6L,3L,7L,4L,6L,8L,9L,5L,1L,8L,0L,7L,4L,2L,6L,6L,7L,5L,7L,8L,7L,6L,4L,4L,3L,4L,7L,9L,9L,8L,2L,9L,9L,5L,5L,9L,6L,9L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200128Inst : IEnumerable<long>
{
public static readonly long[] Value=A200128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200128.Bytes);
public long this[int i]=>Value[i];

public static A200128Inst Instance=new A200128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200129
{
public static readonly long[] Value={ 1L,1L,3L,7L,4L,0L,1L,1L,9L,9L,5L,2L,6L,8L,6L,8L,5L,2L,6L,5L,0L,2L,7L,8L,8L,0L,3L,0L,8L,4L,2L,5L,4L,4L,8L,8L,0L,5L,3L,0L,2L,1L,1L,9L,6L,5L,1L,5L,2L,5L,1L,3L,6L,5L,2L,7L,2L,9L,1L,7L,5L,8L,7L,9L,5L,2L,0L,9L,9L,5L,9L,6L,1L,9L,0L,2L,0L,3L,1L,5L,1L,9L,0L,1L,7L,9L,8L,3L,6L,9L,7L,0L,1L,2L,9L,6L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200129Inst : IEnumerable<long>
{
public static readonly long[] Value=A200129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200129.Bytes);
public long this[int i]=>Value[i];

public static A200129Inst Instance=new A200129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200130
{
public static readonly long[] Value={ 7L,1L,9L,0L,0L,5L,0L,6L,4L,5L,5L,8L,8L,4L,2L,9L,2L,7L,8L,5L,9L,2L,7L,1L,7L,8L,0L,8L,4L,8L,1L,7L,9L,3L,8L,2L,5L,0L,1L,8L,8L,0L,5L,3L,7L,6L,4L,8L,4L,5L,9L,1L,3L,3L,2L,1L,2L,0L,0L,9L,5L,6L,6L,5L,6L,9L,8L,1L,1L,8L,6L,6L,8L,2L,2L,3L,9L,7L,3L,4L,6L,3L,5L,2L,1L,2L,0L,8L,0L,3L,0L,7L,4L,9L,1L,1L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200130Inst : IEnumerable<long>
{
public static readonly long[] Value=A200130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200130.Bytes);
public long this[int i]=>Value[i];

public static A200130Inst Instance=new A200130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200131
{
public static readonly long[] Value={ 1L,3L,6L,8L,1L,4L,9L,1L,1L,2L,0L,4L,2L,0L,6L,7L,6L,6L,7L,9L,9L,7L,6L,9L,9L,1L,0L,8L,8L,9L,0L,6L,9L,2L,6L,6L,7L,5L,9L,0L,3L,6L,3L,8L,6L,9L,7L,9L,8L,2L,3L,5L,6L,8L,8L,7L,6L,8L,3L,8L,1L,0L,1L,7L,8L,4L,0L,2L,0L,0L,9L,5L,7L,2L,9L,5L,6L,3L,9L,7L,4L,8L,1L,6L,1L,3L,1L,7L,9L,1L,3L,4L,2L,8L,1L,1L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200131Inst : IEnumerable<long>
{
public static readonly long[] Value=A200131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200131.Bytes);
public long this[int i]=>Value[i];

public static A200131Inst Instance=new A200131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200132
{
public static readonly long[] Value={ 4L,1L,3L,7L,5L,1L,7L,5L,9L,1L,4L,4L,7L,7L,3L,9L,3L,7L,6L,8L,4L,4L,0L,0L,2L,7L,9L,8L,9L,8L,9L,2L,7L,5L,6L,4L,5L,9L,9L,2L,2L,5L,1L,3L,8L,5L,5L,5L,7L,8L,6L,6L,1L,8L,6L,3L,7L,5L,1L,5L,2L,8L,7L,7L,7L,8L,7L,6L,3L,1L,5L,3L,2L,0L,3L,3L,8L,4L,9L,9L,6L,1L,7L,4L,1L,5L,9L,0L,0L,6L,9L,1L,1L,8L,7L,6L,2L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200132Inst : IEnumerable<long>
{
public static readonly long[] Value=A200132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200132.Bytes);
public long this[int i]=>Value[i];

public static A200132Inst Instance=new A200132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200133
{
public static readonly long[] Value={ 6L,8L,4L,8L,5L,3L,0L,7L,8L,6L,2L,3L,2L,0L,1L,1L,5L,9L,5L,6L,3L,6L,9L,4L,4L,6L,8L,6L,4L,9L,5L,4L,2L,8L,8L,8L,4L,5L,1L,8L,4L,2L,6L,1L,0L,3L,1L,8L,2L,0L,2L,6L,7L,1L,9L,2L,8L,2L,6L,1L,9L,9L,7L,6L,4L,6L,0L,2L,2L,5L,8L,4L,0L,3L,1L,2L,9L,4L,4L,3L,2L,7L,9L,2L,2L,5L,9L,2L,5L,2L,4L,0L,4L,6L,8L,1L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200133Inst : IEnumerable<long>
{
public static readonly long[] Value=A200133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200133.Bytes);
public long this[int i]=>Value[i];

public static A200133Inst Instance=new A200133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200134
{
public static readonly long[] Value={ 1L,0L,8L,5L,8L,6L,0L,8L,7L,9L,7L,8L,6L,4L,7L,2L,1L,6L,9L,6L,2L,6L,8L,8L,6L,7L,6L,2L,8L,1L,7L,1L,8L,0L,6L,9L,3L,1L,7L,0L,0L,7L,5L,0L,3L,9L,3L,3L,3L,1L,3L,6L,4L,5L,0L,6L,8L,0L,3L,3L,4L,9L,6L,7L,2L,1L,1L,1L,4L,0L,3L,8L,9L,5L,4L,3L,6L,4L,4L,3L,1L,8L,4L,4L,0L,5L,1L,9L,6L,3L,1L,6L,0L,9L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200134Inst : IEnumerable<long>
{
public static readonly long[] Value=A200134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200134.Bytes);
public long this[int i]=>Value[i];

public static A200134Inst Instance=new A200134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200135
{
public static readonly long[] Value={ 5L,2L,8L,9L,0L,3L,9L,8L,9L,6L,5L,9L,2L,1L,8L,8L,2L,9L,5L,5L,4L,7L,2L,0L,7L,9L,6L,2L,4L,4L,9L,9L,5L,2L,1L,0L,4L,8L,2L,5L,5L,8L,8L,2L,7L,4L,2L,0L,6L,6L,4L,2L,8L,1L,0L,1L,7L,5L,8L,5L,8L,6L,6L,4L,1L,9L,1L,6L,2L,4L,7L,5L,4L,0L,9L,1L,6L,1L,9L,6L,5L,2L,5L,4L,6L,5L,7L,7L,8L,2L,4L,3L,1L,9L,5L,7L,0L,3L,6L,2L,4L,1L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200135Inst : IEnumerable<long>
{
public static readonly long[] Value=A200135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200135.Bytes);
public long this[int i]=>Value[i];

public static A200135Inst Instance=new A200135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200136
{
public static readonly long[] Value={ 2L,5L,6L,1L,3L,8L,4L,5L,4L,4L,5L,8L,5L,1L,1L,6L,1L,4L,5L,7L,3L,0L,6L,7L,5L,4L,8L,2L,0L,4L,7L,5L,2L,8L,4L,5L,5L,8L,2L,6L,3L,6L,1L,0L,9L,6L,5L,1L,0L,8L,1L,0L,1L,5L,7L,2L,3L,3L,9L,5L,3L,6L,7L,5L,2L,1L,2L,6L,1L,1L,0L,4L,2L,9L,3L,0L,5L,4L,1L,3L,8L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200136Inst : IEnumerable<long>
{
public static readonly long[] Value=A200136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200136.Bytes);
public long this[int i]=>Value[i];

public static A200136Inst Instance=new A200136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200137
{
public static readonly long[] Value={ 1L,5L,4L,0L,6L,1L,9L,2L,1L,3L,8L,9L,3L,1L,9L,0L,4L,1L,4L,7L,6L,0L,6L,6L,3L,9L,4L,8L,8L,0L,6L,2L,3L,1L,9L,4L,1L,5L,1L,0L,5L,3L,4L,2L,5L,4L,6L,8L,9L,6L,0L,7L,2L,0L,8L,2L,6L,6L,6L,8L,5L,2L,6L,3L,2L,6L,1L,1L,6L,8L,8L,4L,1L,2L,4L,1L,1L,0L,2L,4L,6L,6L,0L,7L,3L,3L,4L,2L,4L,6L,7L,7L,1L,9L,7L,7L,8L,8L,2L,0L,1L,0L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200137Inst : IEnumerable<long>
{
public static readonly long[] Value=A200137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200137.Bytes);
public long this[int i]=>Value[i];

public static A200137Inst Instance=new A200137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200138
{
public static readonly long[] Value={ 9L,6L,5L,0L,0L,8L,5L,6L,6L,7L,0L,6L,1L,3L,8L,4L,5L,9L,3L,9L,1L,2L,9L,7L,6L,3L,3L,1L,5L,6L,8L,3L,5L,4L,1L,9L,6L,3L,4L,1L,6L,0L,4L,8L,9L,6L,9L,5L,2L,2L,2L,8L,2L,9L,1L,0L,9L,8L,1L,0L,7L,9L,4L,2L,4L,4L,9L,6L,1L,2L,0L,7L,3L,8L,5L,6L,8L,4L,0L,0L,4L,3L,0L,6L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200138Inst : IEnumerable<long>
{
public static readonly long[] Value=A200138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200138.Bytes);
public long this[int i]=>Value[i];

public static A200138Inst Instance=new A200138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200139
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,4L,8L,5L,1L,8L,20L,18L,7L,1L,16L,48L,56L,32L,9L,1L,32L,112L,160L,120L,50L,11L,1L,64L,256L,432L,400L,220L,72L,13L,1L,128L,576L,1120L,1232L,840L,364L,98L,15L,1L,256L,1280L,2816L,3584L,2912L,1568L,560L,128L,17L,1L,512L,2816L,6912L,9984L,9408L,6048L,2688L,816L,162L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200139Inst : IEnumerable<long>
{
public static readonly long[] Value=A200139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200139.Bytes);
public long this[int i]=>Value[i];

public static A200139Inst Instance=new A200139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200140
{
public static readonly BigInteger[] Value={ 1L,7L,-54L,827L,-14012L,259898L,-5116318L,105172355L,-2234053248L,48692954312L,-1083547583038L,24527041757402L,-563187320485774L,13089954727844002L,-307442412559624318L,7286803572075349907L,BigInteger.Parse("-174090195438541310248"),BigInteger.Parse("4188665368980014572652"),BigInteger.Parse("-101416065009218889929998"),BigInteger.Parse("2469364164437930871076352") };
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
public class A200140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200140Inst Instance=new A200140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200141
{
public static readonly long[] Value={ 1L,1L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L,3L,6L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200141Inst : IEnumerable<long>
{
public static readonly long[] Value=A200141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200141.Bytes);
public long this[int i]=>Value[i];

public static A200141Inst Instance=new A200141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200142
{
public static readonly BigInteger[] Value={ 3L,30L,315L,3780L,51975L,810810L,14189175L,275675400L,5892561675L,137493105750L,3478575575475L,94870242967500L,2774954606799375L,86663966950811250L,2878481759437659375L,BigInteger.Parse("101322557932205610000"),BigInteger.Parse("3767932623103896121875"),BigInteger.Parse("147614301587482048068750") };
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
public class A200142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200142Inst Instance=new A200142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200143
{
public static readonly long[] Value={ 5L,7L,11L,13L,23L,47L,61L,83L,131L,191L,211L,223L,241L,317L,331L,397L,467L,479L,491L,503L,509L,563L,577L,613L,727L,743L,757L,829L,887L,907L,941L,947L,997L,1009L,1021L,1039L,1069L,1087L,1097L,1109L,1223L,1229L,1237L,1381L,1399L,1423L,1447L,1523L,1543L,1549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200143Inst : IEnumerable<long>
{
public static readonly long[] Value=A200143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200143.Bytes);
public long this[int i]=>Value[i];

public static A200143Inst Instance=new A200143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200144
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,7L,14L,17L,27L,34L,55L,64L,100L,121L,167L,213L,296L,354L,489L,594L,776L,964L,1254L,1511L,1951L,2378L,2986L,3643L,4564L,5483L,6841L,8245L,10099L,12190L,14862L,17783L,21636L,25849L,31184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200144Inst : IEnumerable<long>
{
public static readonly long[] Value=A200144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200144.Bytes);
public long this[int i]=>Value[i];

public static A200144Inst Instance=new A200144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200145
{
public static readonly long[] Value={ 2145L,2730L,4641L,4845L,5005L,5610L,7410L,8778L,9177L,11305L,11730L,13485L,13585L,17017L,20010L,20930L,21489L,21505L,23529L,26445L,29946L,31465L,31857L,32538L,33649L,34410L,35409L,35581L,36685L,38570L,38874L,41106L,42441L,43401L,45066L,46189L,46345L,47730L,49569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200145Inst : IEnumerable<long>
{
public static readonly long[] Value=A200145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200145.Bytes);
public long this[int i]=>Value[i];

public static A200145Inst Instance=new A200145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200146
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,3L,1L,1L,1L,1L,1L,2L,3L,4L,5L,1L,1L,1L,1L,1L,1L,1L,0L,3L,0L,5L,0L,7L,1L,4L,0L,7L,7L,0L,4L,1L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200146Inst : IEnumerable<long>
{
public static readonly long[] Value=A200146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200146.Bytes);
public long this[int i]=>Value[i];

public static A200146Inst Instance=new A200146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200147
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,8L,2L,16L,6L,32L,2L,64L,2L,144L,14L,256L,2L,512L,2L,1024L,6L,2048L,2L,4096L,50L,8192L,6L,16384L,2L,34816L,2L,66176L,6L,147456L,130L,262168L,2L,524288L,38L,1048576L,2L,2127872L,2L,4194304L,134L,8388608L,2L,17825792L,4098L,33554432L,6L,67108864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200147Inst : IEnumerable<long>
{
public static readonly long[] Value=A200147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200147.Bytes);
public long this[int i]=>Value[i];

public static A200147Inst Instance=new A200147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200148
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,39L,45L,129L,149L,243L,369L,1365L,2061L,5901L,5951L,7785L,10519L,42519L,59473L,213561L,157559L,278835L,503513L,1553481L,1051639L,2491707L,2981747L,6622209L,10056593L,34139241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200148Inst : IEnumerable<long>
{
public static readonly long[] Value=A200148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200148.Bytes);
public long this[int i]=>Value[i];

public static A200148Inst Instance=new A200148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200149
{
public static readonly long[] Value={ 1L,4L,8L,22L,40L,112L,182L,688L,844L,2090L,2478L,21056L,20762L,112864L,113870L,204796L,141246L,2255872L,1610768L,18946704L,15066098L,20640826L,12378248L,332333696L,279217826L,531539936L,618937930L,1715570198L,330283576L,20131457680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200149Inst : IEnumerable<long>
{
public static readonly long[] Value=A200149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200149.Bytes);
public long this[int i]=>Value[i];

public static A200149Inst Instance=new A200149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200150
{
public static readonly long[] Value={ 1L,5L,13L,41L,103L,275L,685L,2525L,5221L,13897L,32717L,176145L,321963L,1390895L,2223445L,3845743L,10539177L,76756525L,147653093L,808935605L,934179307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200150Inst : IEnumerable<long>
{
public static readonly long[] Value=A200150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200150.Bytes);
public long this[int i]=>Value[i];

public static A200150Inst Instance=new A200150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200151
{
public static readonly long[] Value={ 1L,6L,18L,66L,202L,730L,2036L,7488L,19262L,62772L,190408L,1077600L,2185196L,12081408L,21927244L,52980770L,148851716L,1353060240L,2585159746L,16942421808L,28793485330L,51092435876L,106822624510L,1565885020128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200151Inst : IEnumerable<long>
{
public static readonly long[] Value=A200151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200151.Bytes);
public long this[int i]=>Value[i];

public static A200151Inst Instance=new A200151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200152
{
public static readonly long[] Value={ 1L,7L,25L,107L,381L,1589L,5153L,18809L,68813L,256859L,883247L,4997167L,12448095L,76804553L,181129817L,522024177L,1884097881L,16163873397L,38888615377L,239811969005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200152Inst : IEnumerable<long>
{
public static readonly long[] Value=A200152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200152.Bytes);
public long this[int i]=>Value[i];

public static A200152Inst Instance=new A200152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200153
{
public static readonly long[] Value={ 1L,8L,32L,158L,636L,3000L,11370L,52166L,194818L,841122L,3338446L,18901856L,57842348L,378064896L,1073497924L,3840517750L,15453709184L,133757694784L,361144763380L,2500726090816L,6776168788838L,17399866594576L,65044240487692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200153Inst : IEnumerable<long>
{
public static readonly long[] Value=A200153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200153.Bytes);
public long this[int i]=>Value[i];

public static A200153Inst Instance=new A200153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200154
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,5L,4L,1L,5L,8L,9L,2L,1L,6L,13L,22L,15L,8L,1L,7L,18L,41L,40L,39L,2L,1L,8L,25L,66L,103L,112L,45L,16L,1L,9L,32L,107L,202L,275L,182L,129L,6L,1L,10L,41L,158L,381L,730L,685L,688L,149L,32L,1L,11L,50L,219L,636L,1589L,2036L,2525L,844L,243L,2L,1L,12L,61L,304L,1033L,3000L,5153L,7488L,5221L,2090L,369L,64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200154Inst : IEnumerable<long>
{
public static readonly long[] Value=A200154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200154.Bytes);
public long this[int i]=>Value[i];

public static A200154Inst Instance=new A200154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200155
{
public static readonly long[] Value={ 4L,9L,22L,41L,66L,107L,158L,219L,304L,403L,516L,661L,824L,1005L,1226L,1469L,1734L,2047L,2386L,2751L,3172L,3623L,4104L,4649L,5228L,5841L,6526L,7249L,8010L,8851L,9734L,10659L,11672L,12731L,13836L,15037L,16288L,17589L,18994L,20453L,21966L,23591L,25274L,27015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200155Inst : IEnumerable<long>
{
public static readonly long[] Value=A200155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200155.Bytes);
public long this[int i]=>Value[i];

public static A200155Inst Instance=new A200155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200156
{
public static readonly long[] Value={ 2L,15L,40L,103L,202L,381L,636L,1033L,1550L,2287L,3212L,4451L,5946L,7869L,10140L,12969L,16238L,20211L,24744L,30147L,36222L,43349L,51296L,60493L,70646L,82267L,95016L,109467L,125206L,142897L,162076L,183477L,206546L,232123L,259596L,289879L,322262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200156Inst : IEnumerable<long>
{
public static readonly long[] Value=A200156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200156.Bytes);
public long this[int i]=>Value[i];

public static A200156Inst Instance=new A200156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200157
{
public static readonly long[] Value={ 8L,39L,112L,275L,730L,1589L,3000L,5181L,8350L,13871L,21588L,32019L,45682L,63225L,88580L,120521L,159996L,208123L,266020L,342493L,433532L,540855L,666180L,811455L,992870L,1201725L,1440468L,1711817L,2018490L,2387707L,2803024L,3268059L,3786430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200157Inst : IEnumerable<long>
{
public static readonly long[] Value=A200157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200157.Bytes);
public long this[int i]=>Value[i];

public static A200157Inst Instance=new A200157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200158
{
public static readonly long[] Value={ 2L,45L,182L,685L,2036L,5153L,11370L,23035L,43284L,76523L,129052L,208597L,324900L,491519L,723994L,1041095L,1467042L,2029069L,2759166L,3697749L,4888510L,6381185L,8237500L,10523625L,13313648L,16697587L,20769202L,25633157L,31415424L,38246327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200158Inst : IEnumerable<long>
{
public static readonly long[] Value=A200158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200158.Bytes);
public long this[int i]=>Value[i];

public static A200158Inst Instance=new A200158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200159
{
public static readonly long[] Value={ 4L,8L,34L,76L,276L,700L,2276L,5992L,18542L,50488L,151814L,420680L,1241580L,3481308L,10162686L,28707288L,83211126L,236138900L,681383716L,1939299184L,5579324890L,15908310224L,45678520824L,130391096068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200159Inst : IEnumerable<long>
{
public static readonly long[] Value=A200159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200159.Bytes);
public long this[int i]=>Value[i];

public static A200159Inst Instance=new A200159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200160
{
public static readonly long[] Value={ 6L,24L,128L,576L,2778L,12440L,57992L,262444L,1202540L,5463896L,24922570L,113239064L,515471532L,2342330752L,10649798938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200160Inst : IEnumerable<long>
{
public static readonly long[] Value=A200160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200160.Bytes);
public long this[int i]=>Value[i];

public static A200160Inst Instance=new A200160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200161
{
public static readonly long[] Value={ 8L,48L,348L,2256L,15040L,96884L,631638L,4072228L,26327538L,169703920L,1094685786L,7052320656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200161Inst : IEnumerable<long>
{
public static readonly long[] Value=A200161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200161.Bytes);
public long this[int i]=>Value[i];

public static A200161Inst Instance=new A200161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200162
{
public static readonly long[] Value={ 10L,80L,726L,6160L,52486L,438968L,3687480L,30776992L,257108784L,2144437176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200162Inst : IEnumerable<long>
{
public static readonly long[] Value=A200162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200162.Bytes);
public long this[int i]=>Value[i];

public static A200162Inst Instance=new A200162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200163
{
public static readonly long[] Value={ 12L,120L,1326L,13888L,145482L,1504820L,15586972L,160772064L,1658521710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200163Inst : IEnumerable<long>
{
public static readonly long[] Value=A200163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200163.Bytes);
public long this[int i]=>Value[i];

public static A200163Inst Instance=new A200163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200164
{
public static readonly long[] Value={ 14L,168L,2180L,27160L,336992L,4141212L,50917674L,624074768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200164Inst : IEnumerable<long>
{
public static readonly long[] Value=A200164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200164.Bytes);
public long this[int i]=>Value[i];

public static A200164Inst Instance=new A200164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200165
{
public static readonly long[] Value={ 2L,4L,0L,6L,8L,2L,8L,24L,34L,0L,10L,48L,128L,76L,2L,12L,80L,348L,576L,276L,0L,14L,120L,726L,2256L,2778L,700L,2L,16L,168L,1326L,6160L,15040L,12440L,2276L,0L,18L,224L,2180L,13888L,52486L,96884L,57992L,5992L,2L,20L,288L,3352L,27160L,145482L,438968L,631638L,262444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200165Inst : IEnumerable<long>
{
public static readonly long[] Value=A200165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200165.Bytes);
public long this[int i]=>Value[i];

public static A200165Inst Instance=new A200165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200166
{
public static readonly long[] Value={ 2L,34L,128L,348L,726L,1326L,2180L,3352L,4874L,6810L,9192L,12084L,15518L,19558L,24236L,29616L,35730L,42642L,50384L,59020L,68582L,79134L,90708L,103368L,117146L,132106L,148280L,165732L,184494L,204630L,226172L,249184L,273698L,299778L,327456L,356796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200166Inst : IEnumerable<long>
{
public static readonly long[] Value=A200166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200166.Bytes);
public long this[int i]=>Value[i];

public static A200166Inst Instance=new A200166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200167
{
public static readonly long[] Value={ 0L,76L,576L,2256L,6160L,13888L,27160L,48380L,80096L,125412L,187552L,270688L,378512L,515980L,687836L,899548L,1156496L,1465440L,1832040L,2263800L,2767676L,3351476L,4022752L,4790848L,5663388L,6650440L,7761148L,9005676L,10393744L,11937276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200167Inst : IEnumerable<long>
{
public static readonly long[] Value=A200167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200167.Bytes);
public long this[int i]=>Value[i];

public static A200167Inst Instance=new A200167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200168
{
public static readonly long[] Value={ 2L,276L,2778L,15040L,52486L,145482L,336992L,695778L,1309052L,2298830L,3808116L,6034796L,9189086L,13554364L,19435742L,27212132L,37285690L,50170962L,66371288L,86532042L,111309444L,141482278L,177842124L,221369312L,272987306L,333851184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200168Inst : IEnumerable<long>
{
public static readonly long[] Value=A200168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200168.Bytes);
public long this[int i]=>Value[i];

public static A200168Inst Instance=new A200168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200169
{
public static readonly long[] Value={ 0L,700L,12440L,96884L,438968L,1504820L,4141212L,9922424L,21253088L,41894660L,76920336L,133925952L,222142748L,354645912L,547265784L,820450936L,1198350296L,1712627752L,2397846536L,3298959016L,4465613072L,5958544292L,7844423744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200169Inst : IEnumerable<long>
{
public static readonly long[] Value=A200169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200169.Bytes);
public long this[int i]=>Value[i];

public static A200169Inst Instance=new A200169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200170
{
public static readonly long[] Value={ 2L,2276L,57992L,631638L,3687480L,15586972L,50917674L,141509152L,344941886L,762917274L,1552478008L,2969607490L,5365606152L,9271467482L,15395275250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200170Inst : IEnumerable<long>
{
public static readonly long[] Value=A200170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200170.Bytes);
public long this[int i]=>Value[i];

public static A200170Inst Instance=new A200170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200171
{
public static readonly long[] Value={ 1L,4L,1L,-3L,7L,1L,16L,-19L,11L,1L,-40L,86L,-54L,16L,1L,134L,-328L,302L,-118L,22L,1L,-427L,1289L,-1483L,827L,-223L,29L,1L,1432L,-5003L,7009L,-5003L,1927L,-383L,37L,1L,-4860L,19450L,-32030L,28030L,-14012L,4006L,-614L,46L,1L,16798L,-75580L,143210L,-148510L,91730L,-34396L,7646L,-934L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200171Inst : IEnumerable<long>
{
public static readonly long[] Value=A200171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200171.Bytes);
public long this[int i]=>Value[i];

public static A200171Inst Instance=new A200171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200172
{
public static readonly long[] Value={ 1L,11L,-54L,302L,-1483L,7009L,-32030L,143210L,-629848L,2735812L,-11767534L,50220042L,-212952283L,898198877L,-3771484798L,15775723922L,-65770848988L,273420862112L,-1133802617998L,4691140763402L,-19371432850768L,79850555673176L,-328627887379774L,1350540667070002L,-5543004766417298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200172Inst : IEnumerable<long>
{
public static readonly long[] Value=A200172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200172.Bytes);
public long this[int i]=>Value[i];

public static A200172Inst Instance=new A200172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200173
{
public static readonly long[] Value={ 1L,16L,-118L,827L,-5003L,28030L,-148510L,755822L,-3730648L,17978182L,-84987758L,395482817L,-1816357723L,8250123002L,-37119350398L,165645101162L,-733919156188L,3231337461302L,-14147884841998L,61636377252452L,-267325773340624L,1154761882042826L,-4969989654817598L,21319249101605002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200173Inst : IEnumerable<long>
{
public static readonly long[] Value=A200173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200173.Bytes);
public long this[int i]=>Value[i];

public static A200173Inst Instance=new A200173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200174
{
public static readonly long[] Value={ 1L,1L,3L,3L,2L,6L,10L,7L,12L,28L,29L,29L,70L,105L,96L,169L,327L,363L,449L,914L,1302L,1426L,2455L,4220L,5030L,6925L,12579L,17582L,21687L,36154L,57823L,73301L,106333L,179101L,250064L,332708L,538040L,825039L,1097810L,1630708L,2613839L,3676575L,5125886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200174Inst : IEnumerable<long>
{
public static readonly long[] Value=A200174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200174.Bytes);
public long this[int i]=>Value[i];

public static A200174Inst Instance=new A200174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200175
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,15L,29L,72L,133L,214L,394L,853L,1782L,3087L,5597L,11777L,24069L,45200L,83805L,167284L,342971L,664695L,1257505L,2476990L,4999659L,9864713L,19023479L,37228518L,74480796L,147868410L,288747975L,565957525L,1124938149L,2237002991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200175Inst : IEnumerable<long>
{
public static readonly long[] Value=A200175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200175.Bytes);
public long this[int i]=>Value[i];

public static A200175Inst Instance=new A200175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200176
{
public static readonly long[] Value={ 1L,3L,5L,11L,15L,29L,78L,160L,283L,574L,1428L,3087L,5800L,12563L,30105L,63994L,128826L,285423L,656667L,1407398L,2951141L,6564161L,14805297L,31974359L,68620812L,152674200L,340729396L,740843841L,1612122145L,3583332695L,7954071929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200176Inst : IEnumerable<long>
{
public static readonly long[] Value=A200176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200176.Bytes);
public long this[int i]=>Value[i];

public static A200176Inst Instance=new A200176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200177
{
public static readonly long[] Value={ 1L,4L,5L,14L,24L,48L,100L,280L,608L,1094L,2558L,6656L,14475L,29638L,69174L,170043L,384938L,830598L,1910747L,4608078L,10600467L,23514477L,54265809L,129118292L,298774740L,676277578L,1564120363L,3687870415L,8572421420L,19643806169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200177Inst : IEnumerable<long>
{
public static readonly long[] Value=A200177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200177.Bytes);
public long this[int i]=>Value[i];

public static A200177Inst Instance=new A200177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200178
{
public static readonly long[] Value={ 1L,5L,7L,19L,31L,72L,186L,460L,891L,1934L,5241L,12431L,25680L,59390L,152436L,359303L,789835L,1853143L,4609254L,10926157L,24817557L,58735668L,144083442L,342433339L,794002110L,1892015431L,4599853709L,10962118986L,25773744159L,61646299147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200178Inst : IEnumerable<long>
{
public static readonly long[] Value=A200178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200178.Bytes);
public long this[int i]=>Value[i];

public static A200178Inst Instance=new A200178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200179
{
public static readonly long[] Value={ 1L,6L,7L,26L,48L,103L,246L,700L,1573L,3247L,8034L,21608L,50100L,109071L,268358L,690150L,1629202L,3709231L,9026969L,22707455L,54349757L,126747830L,308139152L,765740522L,1845805544L,4379391584L,10654557350L,26290537792L,63724232354L,152906665554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200179Inst : IEnumerable<long>
{
public static readonly long[] Value=A200179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200179.Bytes);
public long this[int i]=>Value[i];

public static A200179Inst Instance=new A200179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200180
{
public static readonly long[] Value={ 1L,7L,9L,31L,53L,141L,380L,1010L,2152L,5014L,14018L,35542L,78385L,188789L,503051L,1241939L,2859687L,6957672L,17863397L,43991846L,103888178L,253531752L,640390692L,1575397895L,3777406958L,9259136398L,23167497450L,57008137128L,138220165963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200180Inst : IEnumerable<long>
{
public static readonly long[] Value=A200180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200180.Bytes);
public long this[int i]=>Value[i];

public static A200180Inst Instance=new A200180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200181
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,3L,3L,1L,4L,5L,6L,2L,1L,5L,5L,11L,12L,6L,1L,6L,7L,14L,15L,15L,10L,1L,7L,7L,19L,24L,29L,29L,7L,1L,8L,9L,26L,31L,48L,78L,72L,12L,1L,9L,9L,31L,48L,72L,100L,160L,133L,28L,1L,10L,11L,38L,53L,103L,186L,280L,283L,214L,29L,1L,11L,11L,47L,74L,141L,246L,460L,608L,574L,394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200181Inst : IEnumerable<long>
{
public static readonly long[] Value=A200181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200181.Bytes);
public long this[int i]=>Value[i];

public static A200181Inst Instance=new A200181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200182
{
public static readonly long[] Value={ 3L,6L,11L,14L,19L,26L,31L,38L,47L,54L,63L,74L,83L,94L,107L,118L,131L,146L,159L,174L,191L,206L,223L,242L,259L,278L,299L,318L,339L,362L,383L,406L,431L,454L,479L,506L,531L,558L,587L,614L,643L,674L,703L,734L,767L,798L,831L,866L,899L,934L,971L,1006L,1043L,1082L,1119L,1158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200182Inst : IEnumerable<long>
{
public static readonly long[] Value=A200182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200182.Bytes);
public long this[int i]=>Value[i];

public static A200182Inst Instance=new A200182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200183
{
public static readonly long[] Value={ 2L,12L,15L,24L,31L,48L,53L,74L,83L,108L,119L,148L,159L,196L,209L,246L,263L,308L,323L,372L,391L,444L,465L,522L,543L,608L,631L,696L,723L,796L,821L,898L,927L,1008L,1039L,1124L,1155L,1248L,1281L,1374L,1411L,1512L,1547L,1652L,1691L,1800L,1841L,1954L,1995L,2116L,2159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200183Inst : IEnumerable<long>
{
public static readonly long[] Value=A200183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200183.Bytes);
public long this[int i]=>Value[i];

public static A200183Inst Instance=new A200183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200184
{
public static readonly long[] Value={ 6L,15L,29L,48L,72L,103L,141L,186L,244L,309L,385L,472L,572L,685L,813L,954L,1110L,1283L,1475L,1682L,1910L,2155L,2421L,2710L,3020L,3351L,3707L,4086L,4492L,4923L,5381L,5864L,6378L,6921L,7493L,8096L,8730L,9395L,10097L,10830L,11598L,12401L,13241L,14118L,15034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200184Inst : IEnumerable<long>
{
public static readonly long[] Value=A200184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200184.Bytes);
public long this[int i]=>Value[i];

public static A200184Inst Instance=new A200184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200185
{
public static readonly long[] Value={ 10L,29L,78L,100L,186L,246L,380L,464L,686L,798L,1096L,1276L,1658L,1878L,2408L,2668L,3306L,3672L,4432L,4852L,5814L,6288L,7398L,8010L,9278L,9960L,11486L,12236L,13944L,14870L,16774L,17780L,19998L,21088L,23528L,24826L,27494L,28890L,31930L,33424L,36720L,38456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200185Inst : IEnumerable<long>
{
public static readonly long[] Value=A200185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200185.Bytes);
public long this[int i]=>Value[i];

public static A200185Inst Instance=new A200185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200186
{
public static readonly long[] Value={ 1L,4L,6L,14L,24L,54L,104L,230L,464L,1028L,2128L,4720L,9918L,22038L,46760L,104056L,222338L,495358L,1064138L,2373070L,5119796L,11425974L,24738074L,55242788L,119958510L,268018844L,583462384L,1304179214L,2845288284L,6362293924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200186Inst : IEnumerable<long>
{
public static readonly long[] Value=A200186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200186.Bytes);
public long this[int i]=>Value[i];

public static A200186Inst Instance=new A200186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200187
{
public static readonly long[] Value={ 1L,6L,14L,48L,144L,482L,1534L,5148L,16826L,56918L,188706L,642300L,2149072L,7348408L,24749244L,84919630L,287439908L,988917344L,3360535304L,11586463472L,39498606276L,136421151864L,466287543690L,1612808711870L,5524756100592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200187Inst : IEnumerable<long>
{
public static readonly long[] Value=A200187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200187.Bytes);
public long this[int i]=>Value[i];

public static A200187Inst Instance=new A200187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200188
{
public static readonly long[] Value={ 1L,8L,28L,120L,506L,2240L,9856L,44562L,199932L,914676L,4152696L,19143782L,87622590L,406118090L,1869888346L,8701509206L,40245967276L,187867050760L,872020225984L,4080661245080L,18995817588580L,89071683414448L,415623180115020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200188Inst : IEnumerable<long>
{
public static readonly long[] Value=A200188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200188.Bytes);
public long this[int i]=>Value[i];

public static A200188Inst Instance=new A200188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200189
{
public static readonly long[] Value={ 1L,10L,44L,242L,1298L,7266L,40632L,231916L,1320876L,7630236L,43951298L,255926506L,1485664226L,8700154180L,50792100530L,298703878402L,1751415860436L,10333766393384L,60797757383394L,359661008763242L,2121869963574120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200189Inst : IEnumerable<long>
{
public static readonly long[] Value=A200189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200189.Bytes);
public long this[int i]=>Value[i];

public static A200189Inst Instance=new A200189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200190
{
public static readonly long[] Value={ 1L,12L,66L,426L,2794L,18838L,127800L,881008L,6081086L,42452472L,296258332L,2085263400L,14662923954L,103810065802L,734016517080L,5219300699654L,37060739113354L,264413563521598L,1883784631395118L,13476226807283384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200190Inst : IEnumerable<long>
{
public static readonly long[] Value=A200190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200190.Bytes);
public long this[int i]=>Value[i];

public static A200190Inst Instance=new A200190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200191
{
public static readonly long[] Value={ 1L,14L,90L,688L,5300L,41938L,334278L,2702398L,21910764L,179391752L,1470318926L,12138752566L,100237526220L,832451175714L,6911760321744L,57654489610890L,480698731253616L,4023489592590784L,33656450218770442L,282477294114249058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200191Inst : IEnumerable<long>
{
public static readonly long[] Value=A200191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200191.Bytes);
public long this[int i]=>Value[i];

public static A200191Inst Instance=new A200191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200192
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,0L,1L,6L,6L,2L,1L,8L,14L,14L,0L,1L,10L,28L,48L,24L,2L,1L,12L,44L,120L,144L,54L,0L,1L,14L,66L,242L,506L,482L,104L,2L,1L,16L,90L,426L,1298L,2240L,1534L,230L,0L,1L,18L,120L,688L,2794L,7266L,9856L,5148L,464L,2L,1L,20L,152L,1040L,5300L,18838L,40632L,44562L,16826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200192Inst : IEnumerable<long>
{
public static readonly long[] Value=A200192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200192.Bytes);
public long this[int i]=>Value[i];

public static A200192Inst Instance=new A200192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200193
{
public static readonly long[] Value={ 2L,14L,48L,120L,242L,426L,688L,1040L,1494L,2066L,2768L,3612L,4614L,5786L,7140L,8692L,10454L,12438L,14660L,17132L,19866L,22878L,26180L,29784L,33706L,37958L,42552L,47504L,52826L,58530L,64632L,71144L,78078L,85450L,93272L,101556L,110318L,119570L,129324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200193Inst : IEnumerable<long>
{
public static readonly long[] Value=A200193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200193.Bytes);
public long this[int i]=>Value[i];

public static A200193Inst Instance=new A200193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200194
{
public static readonly long[] Value={ 0L,24L,144L,506L,1298L,2794L,5300L,9220L,14974L,23094L,34120L,48712L,67524L,91346L,120950L,157254L,201146L,253672L,315838L,388820L,473738L,571896L,684534L,813084L,958900L,1123544L,1308488L,1515422L,1745934L,2001842L,2284852L,2596912L,2939842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200194Inst : IEnumerable<long>
{
public static readonly long[] Value=A200194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200194.Bytes);
public long this[int i]=>Value[i];

public static A200194Inst Instance=new A200194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200195
{
public static readonly long[] Value={ 2L,54L,482L,2240L,7266L,18838L,41938L,83600L,153278L,263198L,428718L,668684L,1005790L,1466934L,2083578L,2892104L,3934174L,5257082L,6914122L,8964936L,11475878L,14520370L,18179258L,22541172L,27702886L,33769670L,40855654L,49084180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200195Inst : IEnumerable<long>
{
public static readonly long[] Value=A200195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200195.Bytes);
public long this[int i]=>Value[i];

public static A200195Inst Instance=new A200195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200196
{
public static readonly long[] Value={ 0L,104L,1534L,9856L,40632L,127800L,334278L,765598L,1585416L,3034396L,5450616L,9293800L,15170448L,23863548L,36362438L,53897896L,77976766L,110422568L,153414642L,209534448L,281809258L,373763982L,489469484L,633600106L,811486280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200196Inst : IEnumerable<long>
{
public static readonly long[] Value=A200196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200196.Bytes);
public long this[int i]=>Value[i];

public static A200196Inst Instance=new A200196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200197
{
public static readonly long[] Value={ 12L,22L,50L,90L,192L,360L,752L,1472L,3060L,6104L,12596L,25368L,52230L,106038L,218204L,445350L,916598L,1877598L,3866920L,7942794L,16372182L,33699352L,69526894L,143344944L,296012610L,611113112L,1263073756L,2610512928L,5399923198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200197Inst : IEnumerable<long>
{
public static readonly long[] Value=A200197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200197.Bytes);
public long this[int i]=>Value[i];

public static A200197Inst Instance=new A200197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200198
{
public static readonly long[] Value={ 68L,246L,1042L,3940L,16092L,63326L,256314L,1028100L,4169932L,16889228L,68746558L,279997576L,1143494160L,4675439056L,19150647962L,78534289030L,322481118006L,1325578996662L,5454538071104L,22464846352590L,92602356718092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200198Inst : IEnumerable<long>
{
public static readonly long[] Value=A200198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200198.Bytes);
public long this[int i]=>Value[i];

public static A200198Inst Instance=new A200198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200199
{
public static readonly long[] Value={ 186L,1106L,6418L,37226L,217946L,1282168L,7609122L,45311478L,270793444L,1623115640L,9752855676L,58737147004L,354446311678L,2142635088724L,12972537700224L,78651690691664L,477462935113362L,2901805987457704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200199Inst : IEnumerable<long>
{
public static readonly long[] Value=A200199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200199.Bytes);
public long this[int i]=>Value[i];

public static A200199Inst Instance=new A200199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200200
{
public static readonly long[] Value={ 422L,3196L,24542L,187530L,1453304L,11315108L,88657470L,697548282L,5508571400L,43635932538L,346582563516L,2759102483488L,22009380252406L,175882840702296L,1407766935222636L,11283861015674038L,90561415687714086L,727670172922068894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200200Inst : IEnumerable<long>
{
public static readonly long[] Value=A200200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200200.Bytes);
public long this[int i]=>Value[i];

public static A200200Inst Instance=new A200200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200201
{
public static readonly long[] Value={ 798L,7450L,70400L,667620L,6428538L,62141592L,604864626L,5910438976L,57975632400L,570460963084L,5628281238070L,55659731103340L,551565557625452L,5475686423922678L,54447753338275452L,542185148049168142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200201Inst : IEnumerable<long>
{
public static readonly long[] Value=A200201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200201.Bytes);
public long this[int i]=>Value[i];

public static A200201Inst Instance=new A200201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200202
{
public static readonly long[] Value={ 1316L,14842L,168054L,1910006L,21939870L,253625670L,2949336370L,34451583494L,403936559664L,4751104584700L,56034400780878L,662427465209118L,7847270531133920L,93130188698344434L,1107048144990218486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200202Inst : IEnumerable<long>
{
public static readonly long[] Value=A200202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200202.Bytes);
public long this[int i]=>Value[i];

public static A200202Inst Instance=new A200202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200203
{
public static readonly ulong[] Value={ 2064L,26932L,352840L,4664818L,62361448L,838749476L,11349503058L,154248783948L,2104280597600L,28798650135574L,395207143815892L,5436349736878032L,74936087200093134L,1034832015199700638L,14313834216014729042UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200203Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A200203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200203.Bytes);
public ulong this[int i]=>Value[i];

public static A200203Inst Instance=new A200203Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200204
{
public static readonly long[] Value={ 12L,68L,22L,186L,246L,50L,422L,1106L,1042L,90L,798L,3196L,6418L,3940L,192L,1316L,7450L,24542L,37226L,16092L,360L,2064L,14842L,70400L,187530L,217946L,63326L,752L,3048L,26932L,168054L,667620L,1453304L,1282168L,256314L,1472L,4254L,44910L,352840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200204Inst : IEnumerable<long>
{
public static readonly long[] Value=A200204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200204.Bytes);
public long this[int i]=>Value[i];

public static A200204Inst Instance=new A200204Inst();

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