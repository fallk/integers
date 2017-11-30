using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021141
{
public static readonly long[] Value={ 0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L,2L,9L,9L,2L,7L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021141Inst : IEnumerable<long>
{
public static readonly long[] Value=A021141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021141.Bytes);
public long this[int i]=>Value[i];

public static A021141Inst Instance=new A021141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021140
{
public static readonly long[] Value={ 0L,0L,7L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021140Inst : IEnumerable<long>
{
public static readonly long[] Value=A021140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021140.Bytes);
public long this[int i]=>Value[i];

public static A021140Inst Instance=new A021140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021139
{
public static readonly long[] Value={ 0L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021139Inst : IEnumerable<long>
{
public static readonly long[] Value=A021139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021139.Bytes);
public long this[int i]=>Value[i];

public static A021139Inst Instance=new A021139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021138
{
public static readonly long[] Value={ 0L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021138Inst : IEnumerable<long>
{
public static readonly long[] Value=A021138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021138.Bytes);
public long this[int i]=>Value[i];

public static A021138Inst Instance=new A021138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021137
{
public static readonly long[] Value={ 0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021137Inst : IEnumerable<long>
{
public static readonly long[] Value=A021137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021137.Bytes);
public long this[int i]=>Value[i];

public static A021137Inst Instance=new A021137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021136
{
public static readonly long[] Value={ 0L,0L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021136Inst : IEnumerable<long>
{
public static readonly long[] Value=A021136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021136.Bytes);
public long this[int i]=>Value[i];

public static A021136Inst Instance=new A021136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021135
{
public static readonly long[] Value={ 0L,0L,7L,6L,3L,3L,5L,8L,7L,7L,8L,6L,2L,5L,9L,5L,4L,1L,9L,8L,4L,7L,3L,2L,8L,2L,4L,4L,2L,7L,4L,8L,0L,9L,1L,6L,0L,3L,0L,5L,3L,4L,3L,5L,1L,1L,4L,5L,0L,3L,8L,1L,6L,7L,9L,3L,8L,9L,3L,1L,2L,9L,7L,7L,0L,9L,9L,2L,3L,6L,6L,4L,1L,2L,2L,1L,3L,7L,4L,0L,4L,5L,8L,0L,1L,5L,2L,6L,7L,1L,7L,5L,5L,7L,2L,5L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021135Inst : IEnumerable<long>
{
public static readonly long[] Value=A021135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021135.Bytes);
public long this[int i]=>Value[i];

public static A021135Inst Instance=new A021135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021134
{
public static readonly long[] Value={ 1L,17L,200L,2050L,19731L,184047L,1688890L,15362600L,139076861L,1255760077L,11322184380L,102001381950L,918521058391L,8269232646107L,74435809450670L,669985863300100L,6030190661052321L,54273305406490137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021134Inst : IEnumerable<long>
{
public static readonly long[] Value=A021134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021134.Bytes);
public long this[int i]=>Value[i];

public static A021134Inst Instance=new A021134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021133
{
public static readonly long[] Value={ 0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L,1L,2L,4L,0L,3L,1L,0L,0L,7L,7L,5L,1L,9L,3L,7L,9L,8L,4L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021133Inst : IEnumerable<long>
{
public static readonly long[] Value=A021133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021133.Bytes);
public long this[int i]=>Value[i];

public static A021133Inst Instance=new A021133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021132
{
public static readonly long[] Value={ 0L,0L,7L,8L,1L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021132Inst : IEnumerable<long>
{
public static readonly long[] Value=A021132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021132.Bytes);
public long this[int i]=>Value[i];

public static A021132Inst Instance=new A021132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021131
{
public static readonly long[] Value={ 0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021131Inst : IEnumerable<long>
{
public static readonly long[] Value=A021131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021131.Bytes);
public long this[int i]=>Value[i];

public static A021131Inst Instance=new A021131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021130
{
public static readonly long[] Value={ 0L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L,9L,3L,6L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021130Inst : IEnumerable<long>
{
public static readonly long[] Value=A021130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021130.Bytes);
public long this[int i]=>Value[i];

public static A021130Inst Instance=new A021130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021129
{
public static readonly long[] Value={ 1L,16L,175L,1650L,14481L,122316L,1010995L,8250550L,66817861L,538611216L,4329233415L,34735589850L,278393339641L,2229689837716L,17850234337435L,142865452943550L,1143241514899821L,9147521576217816L,73188119895363055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021129Inst : IEnumerable<long>
{
public static readonly long[] Value=A021129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021129.Bytes);
public long this[int i]=>Value[i];

public static A021129Inst Instance=new A021129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021128
{
public static readonly long[] Value={ 0L,0L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021128Inst : IEnumerable<long>
{
public static readonly long[] Value=A021128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021128.Bytes);
public long this[int i]=>Value[i];

public static A021128Inst Instance=new A021128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021127
{
public static readonly long[] Value={ 0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L,3L,0L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021127Inst : IEnumerable<long>
{
public static readonly long[] Value=A021127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021127.Bytes);
public long this[int i]=>Value[i];

public static A021127Inst Instance=new A021127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021126
{
public static readonly long[] Value={ 0L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021126Inst : IEnumerable<long>
{
public static readonly long[] Value=A021126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021126.Bytes);
public long this[int i]=>Value[i];

public static A021126Inst Instance=new A021126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021125
{
public static readonly long[] Value={ 0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L,9L,9L,1L,7L,3L,5L,5L,3L,7L,1L,9L,0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L,9L,9L,1L,7L,3L,5L,5L,3L,7L,1L,9L,0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L,9L,9L,1L,7L,3L,5L,5L,3L,7L,1L,9L,0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L,9L,9L,1L,7L,3L,5L,5L,3L,7L,1L,9L,0L,0L,8L,2L,6L,4L,4L,6L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021125Inst : IEnumerable<long>
{
public static readonly long[] Value=A021125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021125.Bytes);
public long this[int i]=>Value[i];

public static A021125Inst Instance=new A021125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021124
{
public static readonly long[] Value={ 1L,15L,152L,1314L,10479L,79821L,591214L,4301088L,30921077L,220515867L,1563954756L,11049405822L,77854461595L,547524351753L,3845386097978L,26981280929916L,189186857860833L,1325897462045079L,9289229519936080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021124Inst : IEnumerable<long>
{
public static readonly long[] Value=A021124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021124.Bytes);
public long this[int i]=>Value[i];

public static A021124Inst Instance=new A021124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021123
{
public static readonly long[] Value={ 0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021123Inst : IEnumerable<long>
{
public static readonly long[] Value=A021123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021123.Bytes);
public long this[int i]=>Value[i];

public static A021123Inst Instance=new A021123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021122
{
public static readonly long[] Value={ 0L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021122Inst : IEnumerable<long>
{
public static readonly long[] Value=A021122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021122.Bytes);
public long this[int i]=>Value[i];

public static A021122Inst Instance=new A021122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021121
{
public static readonly long[] Value={ 0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L,5L,4L,7L,0L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021121Inst : IEnumerable<long>
{
public static readonly long[] Value=A021121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021121.Bytes);
public long this[int i]=>Value[i];

public static A021121Inst Instance=new A021121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021120
{
public static readonly long[] Value={ 0L,0L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021120Inst : IEnumerable<long>
{
public static readonly long[] Value=A021120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021120.Bytes);
public long this[int i]=>Value[i];

public static A021120Inst Instance=new A021120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021119
{
public static readonly long[] Value={ 0L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021119Inst : IEnumerable<long>
{
public static readonly long[] Value=A021119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021119.Bytes);
public long this[int i]=>Value[i];

public static A021119Inst Instance=new A021119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021118
{
public static readonly long[] Value={ 0L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021118Inst : IEnumerable<long>
{
public static readonly long[] Value=A021118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021118.Bytes);
public long this[int i]=>Value[i];

public static A021118Inst Instance=new A021118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021117
{
public static readonly long[] Value={ 0L,0L,8L,8L,4L,9L,5L,5L,7L,5L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L,3L,1L,8L,5L,8L,4L,0L,7L,0L,7L,9L,6L,4L,6L,0L,1L,7L,6L,9L,9L,1L,1L,5L,0L,4L,4L,2L,4L,7L,7L,8L,7L,6L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021117Inst : IEnumerable<long>
{
public static readonly long[] Value=A021117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021117.Bytes);
public long this[int i]=>Value[i];

public static A021117Inst Instance=new A021117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021116
{
public static readonly long[] Value={ 0L,0L,8L,9L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021116Inst : IEnumerable<long>
{
public static readonly long[] Value=A021116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021116.Bytes);
public long this[int i]=>Value[i];

public static A021116Inst Instance=new A021116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021115
{
public static readonly long[] Value={ 0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021115Inst : IEnumerable<long>
{
public static readonly long[] Value=A021115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021115.Bytes);
public long this[int i]=>Value[i];

public static A021115Inst Instance=new A021115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021114
{
public static readonly long[] Value={ 1L,14L,131L,1036L,7497L,51450L,341167L,2209592L,14071013L,88494406L,551310123L,3409583268L,20966120449L,128339843282L,782754695399L,4760106416464L,28878529850205L,174860636120478L,1057111102343395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021114Inst : IEnumerable<long>
{
public static readonly long[] Value=A021114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021114.Bytes);
public long this[int i]=>Value[i];

public static A021114Inst Instance=new A021114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021113
{
public static readonly long[] Value={ 0L,0L,9L,1L,7L,4L,3L,1L,1L,9L,2L,6L,6L,0L,5L,5L,0L,4L,5L,8L,7L,1L,5L,5L,9L,6L,3L,3L,0L,2L,7L,5L,2L,2L,9L,3L,5L,7L,7L,9L,8L,1L,6L,5L,1L,3L,7L,6L,1L,4L,6L,7L,8L,8L,9L,9L,0L,8L,2L,5L,6L,8L,8L,0L,7L,3L,3L,9L,4L,4L,9L,5L,4L,1L,2L,8L,4L,4L,0L,3L,6L,6L,9L,7L,2L,4L,7L,7L,0L,6L,4L,2L,2L,0L,1L,8L,3L,4L,8L,6L,2L,3L,8L,5L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021113Inst : IEnumerable<long>
{
public static readonly long[] Value=A021113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021113.Bytes);
public long this[int i]=>Value[i];

public static A021113Inst Instance=new A021113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021112
{
public static readonly long[] Value={ 9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021112Inst : IEnumerable<long>
{
public static readonly long[] Value=A021112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021112.Bytes);
public long this[int i]=>Value[i];

public static A021112Inst Instance=new A021112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021111
{
public static readonly long[] Value={ 0L,0L,9L,3L,4L,5L,7L,9L,4L,3L,9L,2L,5L,2L,3L,3L,6L,4L,4L,8L,5L,9L,8L,1L,3L,0L,8L,4L,1L,1L,2L,1L,4L,9L,5L,3L,2L,7L,1L,0L,2L,8L,0L,3L,7L,3L,8L,3L,1L,7L,7L,5L,7L,0L,0L,9L,3L,4L,5L,7L,9L,4L,3L,9L,2L,5L,2L,3L,3L,6L,4L,4L,8L,5L,9L,8L,1L,3L,0L,8L,4L,1L,1L,2L,1L,4L,9L,5L,3L,2L,7L,1L,0L,2L,8L,0L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021111Inst : IEnumerable<long>
{
public static readonly long[] Value=A021111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021111.Bytes);
public long this[int i]=>Value[i];

public static A021111Inst Instance=new A021111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021110
{
public static readonly long[] Value={ 0L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L,2L,2L,6L,4L,1L,5L,0L,9L,4L,3L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021110Inst : IEnumerable<long>
{
public static readonly long[] Value=A021110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021110.Bytes);
public long this[int i]=>Value[i];

public static A021110Inst Instance=new A021110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021109
{
public static readonly long[] Value={ 0L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021109Inst : IEnumerable<long>
{
public static readonly long[] Value=A021109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021109.Bytes);
public long this[int i]=>Value[i];

public static A021109Inst Instance=new A021109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021108
{
public static readonly long[] Value={ 0L,0L,9L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021108Inst : IEnumerable<long>
{
public static readonly long[] Value=A021108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021108.Bytes);
public long this[int i]=>Value[i];

public static A021108Inst Instance=new A021108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021107
{
public static readonly long[] Value={ 0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L,0L,2L,9L,1L,2L,6L,2L,1L,3L,5L,9L,2L,2L,3L,3L,0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L,0L,2L,9L,1L,2L,6L,2L,1L,3L,5L,9L,2L,2L,3L,3L,0L,0L,9L,7L,0L,8L,7L,3L,7L,8L,6L,4L,0L,7L,7L,6L,6L,9L,9L,0L,2L,9L,1L,2L,6L,2L,1L,3L,5L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021107Inst : IEnumerable<long>
{
public static readonly long[] Value=A021107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021107.Bytes);
public long this[int i]=>Value[i];

public static A021107Inst Instance=new A021107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021106
{
public static readonly long[] Value={ 0L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021106Inst : IEnumerable<long>
{
public static readonly long[] Value=A021106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021106.Bytes);
public long this[int i]=>Value[i];

public static A021106Inst Instance=new A021106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021105
{
public static readonly long[] Value={ 0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L,9L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021105Inst : IEnumerable<long>
{
public static readonly long[] Value=A021105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021105.Bytes);
public long this[int i]=>Value[i];

public static A021105Inst Instance=new A021105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021104
{
public static readonly long[] Value={ 1L,19L,263L,3311L,40383L,487263L,5857951L,70338847L,844240415L,10131583007L,121581790239L,1458992663583L,17507956694047L,210095659269151L,2521148627024927L,30253786387545119L,363045448103656479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021104Inst : IEnumerable<long>
{
public static readonly long[] Value=A021104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021104.Bytes);
public long this[int i]=>Value[i];

public static A021104Inst Instance=new A021104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021103
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,9L,44L,294L,2893L,36496L,545808L,9029737L,159563559L,2952794985L,56589742050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021103Inst : IEnumerable<long>
{
public static readonly long[] Value=A021103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021103.Bytes);
public long this[int i]=>Value[i];

public static A021103Inst Instance=new A021103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021102
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021102Inst : IEnumerable<long>
{
public static readonly long[] Value=A021102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021102.Bytes);
public long this[int i]=>Value[i];

public static A021102Inst Instance=new A021102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021101
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,9L,2L,7L,8L,3L,5L,0L,5L,1L,5L,4L,6L,3L,9L,1L,7L,5L,2L,5L,7L,7L,3L,1L,9L,5L,8L,7L,6L,2L,8L,8L,6L,5L,9L,7L,9L,3L,8L,1L,4L,4L,3L,2L,9L,8L,9L,6L,9L,0L,7L,2L,1L,6L,4L,9L,4L,8L,4L,5L,3L,6L,0L,8L,2L,4L,7L,4L,2L,2L,6L,8L,0L,4L,1L,2L,3L,7L,1L,1L,3L,4L,0L,2L,0L,6L,1L,8L,5L,5L,6L,7L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021101Inst : IEnumerable<long>
{
public static readonly long[] Value=A021101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021101.Bytes);
public long this[int i]=>Value[i];

public static A021101Inst Instance=new A021101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021100
{
public static readonly long[] Value={ 0L,1L,0L,4L,1L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021100Inst : IEnumerable<long>
{
public static readonly long[] Value=A021100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021100.Bytes);
public long this[int i]=>Value[i];

public static A021100Inst Instance=new A021100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021099
{
public static readonly long[] Value={ 0L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021099Inst : IEnumerable<long>
{
public static readonly long[] Value=A021099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021099.Bytes);
public long this[int i]=>Value[i];

public static A021099Inst Instance=new A021099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021098
{
public static readonly long[] Value={ 0L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021098Inst : IEnumerable<long>
{
public static readonly long[] Value=A021098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021098.Bytes);
public long this[int i]=>Value[i];

public static A021098Inst Instance=new A021098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021097
{
public static readonly long[] Value={ 0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021097Inst : IEnumerable<long>
{
public static readonly long[] Value=A021097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021097.Bytes);
public long this[int i]=>Value[i];

public static A021097Inst Instance=new A021097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021096
{
public static readonly long[] Value={ 0L,1L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021096Inst : IEnumerable<long>
{
public static readonly long[] Value=A021096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021096.Bytes);
public long this[int i]=>Value[i];

public static A021096Inst Instance=new A021096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021095
{
public static readonly long[] Value={ 0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L,9L,8L,9L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021095Inst : IEnumerable<long>
{
public static readonly long[] Value=A021095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021095.Bytes);
public long this[int i]=>Value[i];

public static A021095Inst Instance=new A021095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021094
{
public static readonly long[] Value={ 1L,18L,233L,2718L,30549L,338706L,3736561L,41145606L,452775917L,4981233114L,54796358409L,602771123214L,6630527086405L,72935976891042L,802296461596577L,8825263940808342L,97077914802006813L,1067857108634797290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021094Inst : IEnumerable<long>
{
public static readonly long[] Value=A021094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021094.Bytes);
public long this[int i]=>Value[i];

public static A021094Inst Instance=new A021094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021093
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021093Inst : IEnumerable<long>
{
public static readonly long[] Value=A021093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021093.Bytes);
public long this[int i]=>Value[i];

public static A021093Inst Instance=new A021093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021092
{
public static readonly long[] Value={ 1L,17L,205L,2205L,22701L,229677L,2307565L,23119085L,231365101L,2314349037L,23146284525L,231474025965L,2314784990701L,23148028847597L,231481004271085L,2314812905956845L,23148140512683501L,231481450939557357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021092Inst : IEnumerable<long>
{
public static readonly long[] Value=A021092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021092.Bytes);
public long this[int i]=>Value[i];

public static A021092Inst Instance=new A021092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021091
{
public static readonly long[] Value={ 0L,1L,1L,4L,9L,4L,2L,5L,2L,8L,7L,3L,5L,6L,3L,2L,1L,8L,3L,9L,0L,8L,0L,4L,5L,9L,7L,7L,0L,1L,1L,4L,9L,4L,2L,5L,2L,8L,7L,3L,5L,6L,3L,2L,1L,8L,3L,9L,0L,8L,0L,4L,5L,9L,7L,7L,0L,1L,1L,4L,9L,4L,2L,5L,2L,8L,7L,3L,5L,6L,3L,2L,1L,8L,3L,9L,0L,8L,0L,4L,5L,9L,7L,7L,0L,1L,1L,4L,9L,4L,2L,5L,2L,8L,7L,3L,5L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021091Inst : IEnumerable<long>
{
public static readonly long[] Value=A021091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021091.Bytes);
public long this[int i]=>Value[i];

public static A021091Inst Instance=new A021091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021090
{
public static readonly long[] Value={ 0L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021090Inst : IEnumerable<long>
{
public static readonly long[] Value=A021090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021090.Bytes);
public long this[int i]=>Value[i];

public static A021090Inst Instance=new A021090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021089
{
public static readonly long[] Value={ 0L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021089Inst : IEnumerable<long>
{
public static readonly long[] Value=A021089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021089.Bytes);
public long this[int i]=>Value[i];

public static A021089Inst Instance=new A021089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021088
{
public static readonly long[] Value={ 0L,1L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021088Inst : IEnumerable<long>
{
public static readonly long[] Value=A021088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021088.Bytes);
public long this[int i]=>Value[i];

public static A021088Inst Instance=new A021088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021087
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,8L,1L,9L,2L,7L,7L,1L,0L,8L,4L,3L,3L,7L,3L,4L,9L,3L,9L,7L,5L,9L,0L,3L,6L,1L,4L,4L,5L,7L,8L,3L,1L,3L,2L,5L,3L,0L,1L,2L,0L,4L,8L,1L,9L,2L,7L,7L,1L,0L,8L,4L,3L,3L,7L,3L,4L,9L,3L,9L,7L,5L,9L,0L,3L,6L,1L,4L,4L,5L,7L,8L,3L,1L,3L,2L,5L,3L,0L,1L,2L,0L,4L,8L,1L,9L,2L,7L,7L,1L,0L,8L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021087Inst : IEnumerable<long>
{
public static readonly long[] Value=A021087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021087.Bytes);
public long this[int i]=>Value[i];

public static A021087Inst Instance=new A021087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021086
{
public static readonly long[] Value={ 0L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L,9L,5L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021086Inst : IEnumerable<long>
{
public static readonly long[] Value=A021086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021086.Bytes);
public long this[int i]=>Value[i];

public static A021086Inst Instance=new A021086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021085
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021085Inst : IEnumerable<long>
{
public static readonly long[] Value=A021085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021085.Bytes);
public long this[int i]=>Value[i];

public static A021085Inst Instance=new A021085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021084
{
public static readonly long[] Value={ 1L,16L,179L,1766L,16545L,151572L,1374943L,12417922L,111935549L,1008117968L,9075855867L,81693883518L,735289682713L,6617786085004L,59560790560151L,536049978287354L,4824461257701237L,43420197132033480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021084Inst : IEnumerable<long>
{
public static readonly long[] Value=A021084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021084.Bytes);
public long this[int i]=>Value[i];

public static A021084Inst Instance=new A021084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021083
{
public static readonly long[] Value={ 0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021083Inst : IEnumerable<long>
{
public static readonly long[] Value=A021083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021083.Bytes);
public long this[int i]=>Value[i];

public static A021083Inst Instance=new A021083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021082
{
public static readonly long[] Value={ 0L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021082Inst : IEnumerable<long>
{
public static readonly long[] Value=A021082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021082.Bytes);
public long this[int i]=>Value[i];

public static A021082Inst Instance=new A021082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021081
{
public static readonly long[] Value={ 0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L,9L,8L,7L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021081Inst : IEnumerable<long>
{
public static readonly long[] Value=A021081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021081.Bytes);
public long this[int i]=>Value[i];

public static A021081Inst Instance=new A021081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021080
{
public static readonly long[] Value={ 0L,1L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021080Inst : IEnumerable<long>
{
public static readonly long[] Value=A021080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021080.Bytes);
public long this[int i]=>Value[i];

public static A021080Inst Instance=new A021080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021079
{
public static readonly long[] Value={ 1L,14L,133L,1086L,8253L,60438L,433861L,3080462L,21737485L,152860422L,1072817109L,7520900478L,52691034397L,369016181366L,2583829064677L,18089666698734L,126639120006189L,886519652765670L,6205820820773365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021079Inst : IEnumerable<long>
{
public static readonly long[] Value=A021079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021079.Bytes);
public long this[int i]=>Value[i];

public static A021079Inst Instance=new A021079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021078
{
public static readonly long[] Value={ 0L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021078Inst : IEnumerable<long>
{
public static readonly long[] Value=A021078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021078.Bytes);
public long this[int i]=>Value[i];

public static A021078Inst Instance=new A021078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021077
{
public static readonly long[] Value={ 0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L,6L,9L,8L,6L,3L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021077Inst : IEnumerable<long>
{
public static readonly long[] Value=A021077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021077.Bytes);
public long this[int i]=>Value[i];

public static A021077Inst Instance=new A021077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021076
{
public static readonly long[] Value={ 1L,13L,113L,833L,5649L,36561L,230161L,1424401L,8720657L,53021969L,320925969L,1936736529L,11665150225L,70169841937L,421734846737L,2533272326417L,15211087073553L,91312335163665L,548057262395665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021076Inst : IEnumerable<long>
{
public static readonly long[] Value=A021076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021076.Bytes);
public long this[int i]=>Value[i];

public static A021076Inst Instance=new A021076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021075
{
public static readonly long[] Value={ 0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021075Inst : IEnumerable<long>
{
public static readonly long[] Value=A021075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021075.Bytes);
public long this[int i]=>Value[i];

public static A021075Inst Instance=new A021075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021074
{
public static readonly long[] Value={ 1L,12L,95L,630L,3801L,21672L,119155L,639210L,3370301L,17549532L,90541815L,463889790L,2364180001L,11999840592L,60714998075L,306438236370L,1543644296901L,7764034206852L,39003422447935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021074Inst : IEnumerable<long>
{
public static readonly long[] Value=A021074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021074.Bytes);
public long this[int i]=>Value[i];

public static A021074Inst Instance=new A021074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021073
{
public static readonly long[] Value={ 0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L,3L,1L,8L,8L,4L,0L,5L,7L,9L,7L,1L,0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L,3L,1L,8L,8L,4L,0L,5L,7L,9L,7L,1L,0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L,3L,1L,8L,8L,4L,0L,5L,7L,9L,7L,1L,0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L,3L,1L,8L,8L,4L,0L,5L,7L,9L,7L,1L,0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021073Inst : IEnumerable<long>
{
public static readonly long[] Value=A021073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021073.Bytes);
public long this[int i]=>Value[i];

public static A021073Inst Instance=new A021073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021072
{
public static readonly long[] Value={ 0L,1L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021072Inst : IEnumerable<long>
{
public static readonly long[] Value=A021072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021072.Bytes);
public long this[int i]=>Value[i];

public static A021072Inst Instance=new A021072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021071
{
public static readonly long[] Value={ 0L,1L,4L,9L,2L,5L,3L,7L,3L,1L,3L,4L,3L,2L,8L,3L,5L,8L,2L,0L,8L,9L,5L,5L,2L,2L,3L,8L,8L,0L,5L,9L,7L,0L,1L,4L,9L,2L,5L,3L,7L,3L,1L,3L,4L,3L,2L,8L,3L,5L,8L,2L,0L,8L,9L,5L,5L,2L,2L,3L,8L,8L,0L,5L,9L,7L,0L,1L,4L,9L,2L,5L,3L,7L,3L,1L,3L,4L,3L,2L,8L,3L,5L,8L,2L,0L,8L,9L,5L,5L,2L,2L,3L,8L,8L,0L,5L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021071Inst : IEnumerable<long>
{
public static readonly long[] Value=A021071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021071.Bytes);
public long this[int i]=>Value[i];

public static A021071Inst Instance=new A021071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021070
{
public static readonly long[] Value={ 0L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021070Inst : IEnumerable<long>
{
public static readonly long[] Value=A021070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021070.Bytes);
public long this[int i]=>Value[i];

public static A021070Inst Instance=new A021070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021069
{
public static readonly long[] Value={ 0L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021069Inst : IEnumerable<long>
{
public static readonly long[] Value=A021069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021069.Bytes);
public long this[int i]=>Value[i];

public static A021069Inst Instance=new A021069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021068
{
public static readonly long[] Value={ 0L,1L,5L,6L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021068Inst : IEnumerable<long>
{
public static readonly long[] Value=A021068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021068.Bytes);
public long this[int i]=>Value[i];

public static A021068Inst Instance=new A021068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021067
{
public static readonly long[] Value={ 0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L,8L,7L,3L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021067Inst : IEnumerable<long>
{
public static readonly long[] Value=A021067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021067.Bytes);
public long this[int i]=>Value[i];

public static A021067Inst Instance=new A021067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021066
{
public static readonly long[] Value={ 0L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021066Inst : IEnumerable<long>
{
public static readonly long[] Value=A021066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021066.Bytes);
public long this[int i]=>Value[i];

public static A021066Inst Instance=new A021066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021065
{
public static readonly long[] Value={ 0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021065Inst : IEnumerable<long>
{
public static readonly long[] Value=A021065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021065.Bytes);
public long this[int i]=>Value[i];

public static A021065Inst Instance=new A021065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021064
{
public static readonly long[] Value={ 1L,18L,241L,2982L,36085L,433986L,5210857L,62539614L,750503869L,9006132954L,108073857073L,1296887073846L,15562647261253L,186751774276722L,2241021312778489L,26892255817780878L,322707070006818637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021064Inst : IEnumerable<long>
{
public static readonly long[] Value=A021064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021064.Bytes);
public long this[int i]=>Value[i];

public static A021064Inst Instance=new A021064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021063
{
public static readonly long[] Value={ 0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021063Inst : IEnumerable<long>
{
public static readonly long[] Value=A021063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021063.Bytes);
public long this[int i]=>Value[i];

public static A021063Inst Instance=new A021063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021062
{
public static readonly long[] Value={ 0L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L,8L,2L,7L,5L,8L,6L,2L,0L,6L,8L,9L,6L,5L,5L,1L,7L,2L,4L,1L,3L,7L,9L,3L,1L,0L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021062Inst : IEnumerable<long>
{
public static readonly long[] Value=A021062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021062.Bytes);
public long this[int i]=>Value[i];

public static A021062Inst Instance=new A021062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021061
{
public static readonly long[] Value={ 0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021061Inst : IEnumerable<long>
{
public static readonly long[] Value=A021061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021061.Bytes);
public long this[int i]=>Value[i];

public static A021061Inst Instance=new A021061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021060
{
public static readonly long[] Value={ 0L,1L,7L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021060Inst : IEnumerable<long>
{
public static readonly long[] Value=A021060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021060.Bytes);
public long this[int i]=>Value[i];

public static A021060Inst Instance=new A021060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021059
{
public static readonly long[] Value={ 0L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021059Inst : IEnumerable<long>
{
public static readonly long[] Value=A021059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021059.Bytes);
public long this[int i]=>Value[i];

public static A021059Inst Instance=new A021059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021058
{
public static readonly long[] Value={ 0L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L,5L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021058Inst : IEnumerable<long>
{
public static readonly long[] Value=A021058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021058.Bytes);
public long this[int i]=>Value[i];

public static A021058Inst Instance=new A021058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021057
{
public static readonly long[] Value={ 0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021057Inst : IEnumerable<long>
{
public static readonly long[] Value=A021057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021057.Bytes);
public long this[int i]=>Value[i];

public static A021057Inst Instance=new A021057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021056
{
public static readonly long[] Value={ 0L,1L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021056Inst : IEnumerable<long>
{
public static readonly long[] Value=A021056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021056.Bytes);
public long this[int i]=>Value[i];

public static A021056Inst Instance=new A021056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021055
{
public static readonly long[] Value={ 0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021055Inst : IEnumerable<long>
{
public static readonly long[] Value=A021055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021055.Bytes);
public long this[int i]=>Value[i];

public static A021055Inst Instance=new A021055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021054
{
public static readonly long[] Value={ 1L,17L,212L,2422L,26943L,297339L,3273754L,36020624L,396255365L,4358895541L,47948112576L,527430027306L,5801732675467L,63819066571823L,702009753747878L,7722107355665668L,84943181105770449L,934374992744081385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021054Inst : IEnumerable<long>
{
public static readonly long[] Value=A021054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021054.Bytes);
public long this[int i]=>Value[i];

public static A021054Inst Instance=new A021054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021053
{
public static readonly long[] Value={ 0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021053Inst : IEnumerable<long>
{
public static readonly long[] Value=A021053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021053.Bytes);
public long this[int i]=>Value[i];

public static A021053Inst Instance=new A021053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021052
{
public static readonly long[] Value={ 0L,2L,0L,8L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021052Inst : IEnumerable<long>
{
public static readonly long[] Value=A021052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021052.Bytes);
public long this[int i]=>Value[i];

public static A021052Inst Instance=new A021052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021051
{
public static readonly long[] Value={ 0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021051Inst : IEnumerable<long>
{
public static readonly long[] Value=A021051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021051.Bytes);
public long this[int i]=>Value[i];

public static A021051Inst Instance=new A021051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021050
{
public static readonly long[] Value={ 0L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021050Inst : IEnumerable<long>
{
public static readonly long[] Value=A021050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021050.Bytes);
public long this[int i]=>Value[i];

public static A021050Inst Instance=new A021050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021049
{
public static readonly long[] Value={ 1L,16L,185L,1940L,19701L,197976L,1982785L,19837180L,198400301L,1984089536L,19841156985L,198412358820L,1984125963301L,19841266774696L,198412689204785L,1984126956486860L,19841269758316701L,198412698163773456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021049Inst : IEnumerable<long>
{
public static readonly long[] Value=A021049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021049.Bytes);
public long this[int i]=>Value[i];

public static A021049Inst Instance=new A021049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021048
{
public static readonly long[] Value={ 1L,15L,160L,1530L,14071L,127605L,1151470L,10372560L,93381541L,840520395L,7564945180L,68085295590L,612770035411L,5514937460385L,49634458601290L,446710191850620L,4020391920103681L,36183527861539575L,325651752496199800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021048Inst : IEnumerable<long>
{
public static readonly long[] Value=A021048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021048.Bytes);
public long this[int i]=>Value[i];

public static A021048Inst Instance=new A021048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021047
{
public static readonly long[] Value={ 0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L,3L,7L,2L,0L,9L,3L,0L,2L,3L,2L,5L,5L,8L,1L,3L,9L,5L,3L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021047Inst : IEnumerable<long>
{
public static readonly long[] Value=A021047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021047.Bytes);
public long this[int i]=>Value[i];

public static A021047Inst Instance=new A021047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021046
{
public static readonly long[] Value={ 0L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L,8L,0L,9L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021046Inst : IEnumerable<long>
{
public static readonly long[] Value=A021046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021046.Bytes);
public long this[int i]=>Value[i];

public static A021046Inst Instance=new A021046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021045
{
public static readonly long[] Value={ 0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L,9L,0L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021045Inst : IEnumerable<long>
{
public static readonly long[] Value=A021045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021045.Bytes);
public long this[int i]=>Value[i];

public static A021045Inst Instance=new A021045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021044
{
public static readonly long[] Value={ 1L,14L,137L,1186L,9789L,79278L,637249L,5107322L,40887077L,327183142L,2617726761L,20942603058L,167543199565L,1340352738206L,10722843363473L,85782811346794L,686262684222453L,5490102054386070L,43920818177432185L,351366550647536930L,2810932420866630941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021044Inst : IEnumerable<long>
{
public static readonly long[] Value=A021044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021044.Bytes);
public long this[int i]=>Value[i];

public static A021044Inst Instance=new A021044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021043
{
public static readonly long[] Value={ 0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L,6L,4L,1L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021043Inst : IEnumerable<long>
{
public static readonly long[] Value=A021043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021043.Bytes);
public long this[int i]=>Value[i];

public static A021043Inst Instance=new A021043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021042
{
public static readonly long[] Value={ 0L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021042Inst : IEnumerable<long>
{
public static readonly long[] Value=A021042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021042.Bytes);
public long this[int i]=>Value[i];

public static A021042Inst Instance=new A021042Inst();

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