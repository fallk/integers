using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021577
{
public static readonly long[] Value={ 0L,0L,1L,7L,4L,5L,2L,0L,0L,6L,9L,8L,0L,8L,0L,2L,7L,9L,2L,3L,2L,1L,1L,1L,6L,9L,2L,8L,4L,4L,6L,7L,7L,1L,3L,7L,8L,7L,0L,8L,5L,5L,1L,4L,8L,3L,4L,2L,0L,5L,9L,3L,3L,6L,8L,2L,3L,7L,3L,4L,7L,2L,9L,4L,9L,3L,8L,9L,1L,7L,9L,7L,5L,5L,6L,7L,1L,9L,0L,2L,2L,6L,8L,7L,6L,0L,9L,0L,7L,5L,0L,4L,3L,6L,3L,0L,0L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021577Inst : IEnumerable<long>
{
public static readonly long[] Value=A021577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021577.Bytes);
public long this[int i]=>Value[i];

public static A021577Inst Instance=new A021577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021578
{
public static readonly long[] Value={ 0L,0L,1L,7L,4L,2L,1L,6L,0L,2L,7L,8L,7L,4L,5L,6L,4L,4L,5L,9L,9L,3L,0L,3L,1L,3L,5L,8L,8L,8L,5L,0L,1L,7L,4L,2L,1L,6L,0L,2L,7L,8L,7L,4L,5L,6L,4L,4L,5L,9L,9L,3L,0L,3L,1L,3L,5L,8L,8L,8L,5L,0L,1L,7L,4L,2L,1L,6L,0L,2L,7L,8L,7L,4L,5L,6L,4L,4L,5L,9L,9L,3L,0L,3L,1L,3L,5L,8L,8L,8L,5L,0L,1L,7L,4L,2L,1L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021578Inst : IEnumerable<long>
{
public static readonly long[] Value=A021578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021578.Bytes);
public long this[int i]=>Value[i];

public static A021578Inst Instance=new A021578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021579
{
public static readonly long[] Value={ 0L,0L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L,4L,7L,8L,2L,6L,0L,8L,6L,9L,5L,6L,5L,2L,1L,7L,3L,9L,1L,3L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021579Inst : IEnumerable<long>
{
public static readonly long[] Value=A021579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021579.Bytes);
public long this[int i]=>Value[i];

public static A021579Inst Instance=new A021579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021580
{
public static readonly long[] Value={ 0L,0L,1L,7L,3L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021580Inst : IEnumerable<long>
{
public static readonly long[] Value=A021580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021580.Bytes);
public long this[int i]=>Value[i];

public static A021580Inst Instance=new A021580Inst();

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

public static class A021598
{
public static readonly long[] Value={ 0L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L,6L,8L,3L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021598Inst : IEnumerable<long>
{
public static readonly long[] Value=A021598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021598.Bytes);
public long this[int i]=>Value[i];

public static A021598Inst Instance=new A021598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021599
{
public static readonly long[] Value={ 0L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021599Inst : IEnumerable<long>
{
public static readonly long[] Value=A021599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021599.Bytes);
public long this[int i]=>Value[i];

public static A021599Inst Instance=new A021599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021600
{
public static readonly long[] Value={ 0L,0L,1L,6L,7L,7L,8L,5L,2L,3L,4L,8L,9L,9L,3L,2L,8L,8L,5L,9L,0L,6L,0L,4L,0L,2L,6L,8L,4L,5L,6L,3L,7L,5L,8L,3L,8L,9L,2L,6L,1L,7L,4L,4L,9L,6L,6L,4L,4L,2L,9L,5L,3L,0L,2L,0L,1L,3L,4L,2L,2L,8L,1L,8L,7L,9L,1L,9L,4L,6L,3L,0L,8L,7L,2L,4L,8L,3L,2L,2L,1L,4L,7L,6L,5L,1L,0L,0L,6L,7L,1L,1L,4L,0L,9L,3L,9L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021600Inst : IEnumerable<long>
{
public static readonly long[] Value=A021600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021600.Bytes);
public long this[int i]=>Value[i];

public static A021600Inst Instance=new A021600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021601
{
public static readonly long[] Value={ 0L,0L,1L,6L,7L,5L,0L,4L,1L,8L,7L,6L,0L,4L,6L,9L,0L,1L,1L,7L,2L,5L,2L,9L,3L,1L,3L,2L,3L,2L,8L,3L,0L,8L,2L,0L,7L,7L,0L,5L,1L,9L,2L,6L,2L,9L,8L,1L,5L,7L,4L,5L,3L,9L,3L,6L,3L,4L,8L,4L,0L,8L,7L,1L,0L,2L,1L,7L,7L,5L,5L,4L,4L,3L,8L,8L,6L,0L,9L,7L,1L,5L,2L,4L,2L,8L,8L,1L,0L,7L,2L,0L,2L,6L,8L,0L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021601Inst : IEnumerable<long>
{
public static readonly long[] Value=A021601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021601.Bytes);
public long this[int i]=>Value[i];

public static A021601Inst Instance=new A021601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021602
{
public static readonly long[] Value={ 0L,0L,1L,6L,7L,2L,2L,4L,0L,8L,0L,2L,6L,7L,5L,5L,8L,5L,2L,8L,4L,2L,8L,0L,9L,3L,6L,4L,5L,4L,8L,4L,9L,4L,9L,8L,3L,2L,7L,7L,5L,9L,1L,9L,7L,3L,2L,4L,4L,1L,4L,7L,1L,5L,7L,1L,9L,0L,6L,3L,5L,4L,5L,1L,5L,0L,5L,0L,1L,6L,7L,2L,2L,4L,0L,8L,0L,2L,6L,7L,5L,5L,8L,5L,2L,8L,4L,2L,8L,0L,9L,3L,6L,4L,5L,4L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021602Inst : IEnumerable<long>
{
public static readonly long[] Value=A021602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021602.Bytes);
public long this[int i]=>Value[i];

public static A021602Inst Instance=new A021602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021603
{
public static readonly long[] Value={ 0L,0L,1L,6L,6L,9L,4L,4L,9L,0L,8L,1L,8L,0L,3L,0L,0L,5L,0L,0L,8L,3L,4L,7L,2L,4L,5L,4L,0L,9L,0L,1L,5L,0L,2L,5L,0L,4L,1L,7L,3L,6L,2L,2L,7L,0L,4L,5L,0L,7L,5L,1L,2L,5L,2L,0L,8L,6L,8L,1L,1L,3L,5L,2L,2L,5L,3L,7L,5L,6L,2L,6L,0L,4L,3L,4L,0L,5L,6L,7L,6L,1L,2L,6L,8L,7L,8L,1L,3L,0L,2L,1L,7L,0L,2L,8L,3L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021603Inst : IEnumerable<long>
{
public static readonly long[] Value=A021603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021603.Bytes);
public long this[int i]=>Value[i];

public static A021603Inst Instance=new A021603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021604
{
public static readonly long[] Value={ 1L,21L,300L,3670L,41511L,449151L,4730890L,48987840L,501640821L,5098774681L,51564400680L,519680849610L,5225067192931L,52448485198611L,525869552045670L,5268388442396980L,52751734942121841L,527992303241992941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021604Inst : IEnumerable<long>
{
public static readonly long[] Value=A021604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021604.Bytes);
public long this[int i]=>Value[i];

public static A021604Inst Instance=new A021604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021605
{
public static readonly long[] Value={ 0L,0L,1L,6L,6L,3L,8L,9L,3L,5L,1L,0L,8L,1L,5L,3L,0L,7L,8L,2L,0L,2L,9L,9L,5L,0L,0L,8L,3L,1L,9L,4L,6L,7L,5L,5L,4L,0L,7L,6L,5L,3L,9L,1L,0L,1L,4L,9L,7L,5L,0L,4L,1L,5L,9L,7L,3L,3L,7L,7L,7L,0L,3L,8L,2L,6L,9L,5L,5L,0L,7L,4L,8L,7L,5L,2L,0L,7L,9L,8L,6L,6L,8L,8L,8L,5L,1L,9L,1L,3L,4L,7L,7L,5L,3L,7L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021605Inst : IEnumerable<long>
{
public static readonly long[] Value=A021605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021605.Bytes);
public long this[int i]=>Value[i];

public static A021605Inst Instance=new A021605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021606
{
public static readonly long[] Value={ 0L,0L,1L,6L,6L,1L,1L,2L,9L,5L,6L,8L,1L,0L,6L,3L,1L,2L,2L,9L,2L,3L,5L,8L,8L,0L,3L,9L,8L,6L,7L,1L,0L,9L,6L,3L,4L,5L,5L,1L,4L,9L,5L,0L,1L,6L,6L,1L,1L,2L,9L,5L,6L,8L,1L,0L,6L,3L,1L,2L,2L,9L,2L,3L,5L,8L,8L,0L,3L,9L,8L,6L,7L,1L,0L,9L,6L,3L,4L,5L,5L,1L,4L,9L,5L,0L,1L,6L,6L,1L,1L,2L,9L,5L,6L,8L,1L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021606Inst : IEnumerable<long>
{
public static readonly long[] Value=A021606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021606.Bytes);
public long this[int i]=>Value[i];

public static A021606Inst Instance=new A021606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021607
{
public static readonly long[] Value={ 0L,0L,1L,6L,5L,8L,3L,7L,4L,7L,9L,2L,7L,0L,3L,1L,5L,0L,9L,1L,2L,1L,0L,6L,1L,3L,5L,9L,8L,6L,7L,3L,3L,0L,0L,1L,6L,5L,8L,3L,7L,4L,7L,9L,2L,7L,0L,3L,1L,5L,0L,9L,1L,2L,1L,0L,6L,1L,3L,5L,9L,8L,6L,7L,3L,3L,0L,0L,1L,6L,5L,8L,3L,7L,4L,7L,9L,2L,7L,0L,3L,1L,5L,0L,9L,1L,2L,1L,0L,6L,1L,3L,5L,9L,8L,6L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021607Inst : IEnumerable<long>
{
public static readonly long[] Value=A021607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021607.Bytes);
public long this[int i]=>Value[i];

public static A021607Inst Instance=new A021607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021608
{
public static readonly long[] Value={ 0L,0L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L,8L,2L,1L,1L,9L,2L,0L,5L,2L,9L,8L,0L,1L,3L,2L,4L,5L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L,3L,6L,4L,2L,3L,8L,4L,1L,0L,5L,9L,6L,0L,2L,6L,4L,9L,0L,0L,6L,6L,2L,2L,5L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L,8L,2L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021608Inst : IEnumerable<long>
{
public static readonly long[] Value=A021608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021608.Bytes);
public long this[int i]=>Value[i];

public static A021608Inst Instance=new A021608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021609
{
public static readonly long[] Value={ 0L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L,1L,9L,8L,3L,4L,7L,1L,0L,7L,4L,3L,8L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L,1L,9L,8L,3L,4L,7L,1L,0L,7L,4L,3L,8L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L,1L,9L,8L,3L,4L,7L,1L,0L,7L,4L,3L,8L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L,1L,9L,8L,3L,4L,7L,1L,0L,7L,4L,3L,8L,0L,1L,6L,5L,2L,8L,9L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021609Inst : IEnumerable<long>
{
public static readonly long[] Value=A021609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021609.Bytes);
public long this[int i]=>Value[i];

public static A021609Inst Instance=new A021609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021610
{
public static readonly long[] Value={ 0L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L,6L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021610Inst : IEnumerable<long>
{
public static readonly long[] Value=A021610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021610.Bytes);
public long this[int i]=>Value[i];

public static A021610Inst Instance=new A021610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021611
{
public static readonly long[] Value={ 0L,0L,1L,6L,4L,7L,4L,4L,6L,4L,5L,7L,9L,9L,0L,1L,1L,5L,3L,2L,1L,2L,5L,2L,0L,5L,9L,3L,0L,8L,0L,7L,2L,4L,8L,7L,6L,4L,4L,1L,5L,1L,5L,6L,5L,0L,7L,4L,1L,3L,5L,0L,9L,0L,6L,0L,9L,5L,5L,5L,1L,8L,9L,4L,5L,6L,3L,4L,2L,6L,6L,8L,8L,6L,3L,2L,6L,1L,9L,4L,3L,9L,8L,6L,8L,2L,0L,4L,2L,8L,3L,3L,6L,0L,7L,9L,0L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021611Inst : IEnumerable<long>
{
public static readonly long[] Value=A021611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021611.Bytes);
public long this[int i]=>Value[i];

public static A021611Inst Instance=new A021611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021612
{
public static readonly long[] Value={ 0L,0L,1L,6L,4L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021612Inst : IEnumerable<long>
{
public static readonly long[] Value=A021612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021612.Bytes);
public long this[int i]=>Value[i];

public static A021612Inst Instance=new A021612Inst();

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

public static class A021630
{
public static readonly long[] Value={ 0L,0L,1L,5L,9L,7L,4L,4L,4L,0L,8L,9L,4L,5L,6L,8L,6L,9L,0L,0L,9L,5L,8L,4L,6L,6L,4L,5L,3L,6L,7L,4L,1L,2L,1L,4L,0L,5L,7L,5L,0L,7L,9L,8L,7L,2L,2L,0L,4L,4L,7L,2L,8L,4L,3L,4L,5L,0L,4L,7L,9L,2L,3L,3L,2L,2L,6L,8L,3L,7L,0L,6L,0L,7L,0L,2L,8L,7L,5L,3L,9L,9L,3L,6L,1L,0L,2L,2L,3L,6L,4L,2L,1L,7L,2L,5L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021630Inst : IEnumerable<long>
{
public static readonly long[] Value=A021630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021630.Bytes);
public long this[int i]=>Value[i];

public static A021630Inst Instance=new A021630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021631
{
public static readonly long[] Value={ 0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L,3L,3L,1L,7L,3L,8L,4L,3L,7L,0L,0L,1L,5L,9L,4L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021631Inst : IEnumerable<long>
{
public static readonly long[] Value=A021631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021631.Bytes);
public long this[int i]=>Value[i];

public static A021631Inst Instance=new A021631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021632
{
public static readonly long[] Value={ 0L,0L,1L,5L,9L,2L,3L,5L,6L,6L,8L,7L,8L,9L,8L,0L,8L,9L,1L,7L,1L,9L,7L,4L,5L,2L,2L,2L,9L,2L,9L,9L,3L,6L,3L,0L,5L,7L,3L,2L,4L,8L,4L,0L,7L,6L,4L,3L,3L,1L,2L,1L,0L,1L,9L,1L,0L,8L,2L,8L,0L,2L,5L,4L,7L,7L,7L,0L,7L,0L,0L,6L,3L,6L,9L,4L,2L,6L,7L,5L,1L,5L,9L,2L,3L,5L,6L,6L,8L,7L,8L,9L,8L,0L,8L,9L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021632Inst : IEnumerable<long>
{
public static readonly long[] Value=A021632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021632.Bytes);
public long this[int i]=>Value[i];

public static A021632Inst Instance=new A021632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021633
{
public static readonly long[] Value={ 0L,0L,1L,5L,8L,9L,8L,2L,5L,1L,1L,9L,2L,3L,6L,8L,8L,3L,9L,4L,2L,7L,6L,6L,2L,9L,5L,7L,0L,7L,4L,7L,2L,1L,7L,8L,0L,6L,0L,4L,1L,3L,3L,5L,4L,5L,3L,1L,0L,0L,1L,5L,8L,9L,8L,2L,5L,1L,1L,9L,2L,3L,6L,8L,8L,3L,9L,4L,2L,7L,6L,6L,2L,9L,5L,7L,0L,7L,4L,7L,2L,1L,7L,8L,0L,6L,0L,4L,1L,3L,3L,5L,4L,5L,3L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021633Inst : IEnumerable<long>
{
public static readonly long[] Value=A021633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021633.Bytes);
public long this[int i]=>Value[i];

public static A021633Inst Instance=new A021633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021634
{
public static readonly long[] Value={ 1L,21L,298L,3594L,39763L,417567L,4236796L,41963988L,408348325L,3920543913L,37248255694L,350941450782L,3284131050487L,30562445793459L,283104150028192L,2612274474873576L,24025167335391049L,220344082704460605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021634Inst : IEnumerable<long>
{
public static readonly long[] Value=A021634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021634.Bytes);
public long this[int i]=>Value[i];

public static A021634Inst Instance=new A021634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021635
{
public static readonly long[] Value={ 0L,0L,1L,5L,8L,4L,7L,8L,6L,0L,5L,3L,8L,8L,2L,7L,2L,5L,8L,3L,2L,0L,1L,2L,6L,7L,8L,2L,8L,8L,4L,3L,1L,0L,6L,1L,8L,0L,6L,6L,5L,6L,1L,0L,1L,4L,2L,6L,3L,0L,7L,4L,4L,8L,4L,9L,4L,4L,5L,3L,2L,4L,8L,8L,1L,1L,4L,1L,0L,4L,5L,9L,5L,8L,7L,9L,5L,5L,6L,2L,5L,9L,9L,0L,4L,9L,1L,2L,8L,3L,6L,7L,6L,7L,0L,3L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021635Inst : IEnumerable<long>
{
public static readonly long[] Value=A021635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021635.Bytes);
public long this[int i]=>Value[i];

public static A021635Inst Instance=new A021635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021636
{
public static readonly long[] Value={ 0L,0L,1L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L,8L,4L,8L,1L,0L,1L,2L,6L,5L,8L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021636Inst : IEnumerable<long>
{
public static readonly long[] Value=A021636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021636.Bytes);
public long this[int i]=>Value[i];

public static A021636Inst Instance=new A021636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021637
{
public static readonly long[] Value={ 0L,0L,1L,5L,7L,9L,7L,7L,8L,8L,3L,0L,9L,6L,3L,6L,6L,5L,0L,8L,6L,8L,8L,7L,8L,3L,5L,7L,0L,3L,0L,0L,1L,5L,7L,9L,7L,7L,8L,8L,3L,0L,9L,6L,3L,6L,6L,5L,0L,8L,6L,8L,8L,7L,8L,3L,5L,7L,0L,3L,0L,0L,1L,5L,7L,9L,7L,7L,8L,8L,3L,0L,9L,6L,3L,6L,6L,5L,0L,8L,6L,8L,8L,7L,8L,3L,5L,7L,0L,3L,0L,0L,1L,5L,7L,9L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021637Inst : IEnumerable<long>
{
public static readonly long[] Value=A021637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021637.Bytes);
public long this[int i]=>Value[i];

public static A021637Inst Instance=new A021637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021638
{
public static readonly long[] Value={ 0L,0L,1L,5L,7L,7L,2L,8L,7L,0L,6L,6L,2L,4L,6L,0L,5L,6L,7L,8L,2L,3L,3L,4L,3L,8L,4L,8L,5L,8L,0L,4L,4L,1L,6L,4L,0L,3L,7L,8L,5L,4L,8L,8L,9L,5L,8L,9L,9L,0L,5L,3L,6L,2L,7L,7L,6L,0L,2L,5L,2L,3L,6L,5L,9L,3L,0L,5L,9L,9L,3L,6L,9L,0L,8L,5L,1L,7L,3L,5L,0L,1L,5L,7L,7L,2L,8L,7L,0L,6L,6L,2L,4L,6L,0L,5L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021638Inst : IEnumerable<long>
{
public static readonly long[] Value=A021638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021638.Bytes);
public long this[int i]=>Value[i];

public static A021638Inst Instance=new A021638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021639
{
public static readonly long[] Value={ 0L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021639Inst : IEnumerable<long>
{
public static readonly long[] Value=A021639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021639.Bytes);
public long this[int i]=>Value[i];

public static A021639Inst Instance=new A021639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021640
{
public static readonly long[] Value={ 0L,0L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L,7L,0L,4L,4L,0L,2L,5L,1L,5L,7L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021640Inst : IEnumerable<long>
{
public static readonly long[] Value=A021640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021640.Bytes);
public long this[int i]=>Value[i];

public static A021640Inst Instance=new A021640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021641
{
public static readonly long[] Value={ 0L,0L,1L,5L,6L,9L,8L,5L,8L,7L,1L,2L,7L,1L,5L,8L,5L,5L,5L,7L,2L,9L,9L,8L,4L,3L,0L,1L,4L,1L,2L,8L,7L,2L,8L,4L,1L,4L,4L,4L,2L,7L,0L,0L,1L,5L,6L,9L,8L,5L,8L,7L,1L,2L,7L,1L,5L,8L,5L,5L,5L,7L,2L,9L,9L,8L,4L,3L,0L,1L,4L,1L,2L,8L,7L,2L,8L,4L,1L,4L,4L,4L,2L,7L,0L,0L,1L,5L,6L,9L,8L,5L,8L,7L,1L,2L,7L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021641Inst : IEnumerable<long>
{
public static readonly long[] Value=A021641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021641.Bytes);
public long this[int i]=>Value[i];

public static A021641Inst Instance=new A021641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021642
{
public static readonly long[] Value={ 0L,0L,1L,5L,6L,7L,3L,9L,8L,1L,1L,9L,1L,2L,2L,2L,5L,7L,0L,5L,3L,2L,9L,1L,5L,3L,6L,0L,5L,0L,1L,5L,6L,7L,3L,9L,8L,1L,1L,9L,1L,2L,2L,2L,5L,7L,0L,5L,3L,2L,9L,1L,5L,3L,6L,0L,5L,0L,1L,5L,6L,7L,3L,9L,8L,1L,1L,9L,1L,2L,2L,2L,5L,7L,0L,5L,3L,2L,9L,1L,5L,3L,6L,0L,5L,0L,1L,5L,6L,7L,3L,9L,8L,1L,1L,9L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021642Inst : IEnumerable<long>
{
public static readonly long[] Value=A021642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021642.Bytes);
public long this[int i]=>Value[i];

public static A021642Inst Instance=new A021642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021643
{
public static readonly long[] Value={ 0L,0L,1L,5L,6L,4L,9L,4L,5L,2L,2L,6L,9L,1L,7L,0L,5L,7L,9L,0L,2L,9L,7L,3L,3L,9L,5L,9L,3L,1L,1L,4L,2L,4L,1L,0L,0L,1L,5L,6L,4L,9L,4L,5L,2L,2L,6L,9L,1L,7L,0L,5L,7L,9L,0L,2L,9L,7L,3L,3L,9L,5L,9L,3L,1L,1L,4L,2L,4L,1L,0L,0L,1L,5L,6L,4L,9L,4L,5L,2L,2L,6L,9L,1L,7L,0L,5L,7L,9L,0L,2L,9L,7L,3L,3L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021643Inst : IEnumerable<long>
{
public static readonly long[] Value=A021643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021643.Bytes);
public long this[int i]=>Value[i];

public static A021643Inst Instance=new A021643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021644
{
public static readonly long[] Value={ 1L,22L,329L,4202L,49437L,554070L,6019393L,64026754L,670939973L,6954808718L,71511447657L,730821626106L,7433874254509L,75344008884166L,761482226728721L,7679159391907058L,77306290980599445L,777180486491935614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021644Inst : IEnumerable<long>
{
public static readonly long[] Value=A021644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021644.Bytes);
public long this[int i]=>Value[i];

public static A021644Inst Instance=new A021644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021645
{
public static readonly long[] Value={ 0L,0L,1L,5L,6L,0L,0L,6L,2L,4L,0L,2L,4L,9L,6L,0L,9L,9L,8L,4L,3L,9L,9L,3L,7L,5L,9L,7L,5L,0L,3L,9L,0L,0L,1L,5L,6L,0L,0L,6L,2L,4L,0L,2L,4L,9L,6L,0L,9L,9L,8L,4L,3L,9L,9L,3L,7L,5L,9L,7L,5L,0L,3L,9L,0L,0L,1L,5L,6L,0L,0L,6L,2L,4L,0L,2L,4L,9L,6L,0L,9L,9L,8L,4L,3L,9L,9L,3L,7L,5L,9L,7L,5L,0L,3L,9L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021645Inst : IEnumerable<long>
{
public static readonly long[] Value=A021645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021645.Bytes);
public long this[int i]=>Value[i];

public static A021645Inst Instance=new A021645Inst();

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

public static class A021806
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,6L,8L,8L,2L,7L,9L,3L,0L,1L,7L,4L,5L,6L,3L,5L,9L,1L,0L,2L,2L,4L,4L,3L,8L,9L,0L,2L,7L,4L,3L,1L,4L,2L,1L,4L,4L,6L,3L,8L,4L,0L,3L,9L,9L,0L,0L,2L,4L,9L,3L,7L,6L,5L,5L,8L,6L,0L,3L,4L,9L,1L,2L,7L,1L,8L,2L,0L,4L,4L,8L,8L,7L,7L,8L,0L,5L,4L,8L,6L,2L,8L,4L,2L,8L,9L,2L,7L,6L,8L,0L,7L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021806Inst : IEnumerable<long>
{
public static readonly long[] Value=A021806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021806.Bytes);
public long this[int i]=>Value[i];

public static A021806Inst Instance=new A021806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021807
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L,2L,4L,5L,3L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021807Inst : IEnumerable<long>
{
public static readonly long[] Value=A021807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021807.Bytes);
public long this[int i]=>Value[i];

public static A021807Inst Instance=new A021807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021808
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L,0L,0L,4L,9L,7L,5L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L,0L,0L,4L,9L,7L,5L,1L,2L,4L,3L,7L,8L,1L,0L,9L,4L,5L,2L,7L,3L,6L,3L,1L,8L,4L,0L,7L,9L,6L,0L,1L,9L,9L,0L,0L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021808Inst : IEnumerable<long>
{
public static readonly long[] Value=A021808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021808.Bytes);
public long this[int i]=>Value[i];

public static A021808Inst Instance=new A021808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021809
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L,4L,9L,6L,8L,9L,4L,4L,0L,9L,9L,3L,7L,8L,8L,8L,1L,9L,8L,7L,5L,7L,7L,6L,3L,9L,7L,5L,1L,5L,5L,2L,7L,9L,5L,0L,3L,1L,0L,5L,5L,9L,0L,0L,6L,2L,1L,1L,1L,8L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L,4L,9L,6L,8L,9L,4L,4L,0L,9L,9L,3L,7L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021809Inst : IEnumerable<long>
{
public static readonly long[] Value=A021809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021809.Bytes);
public long this[int i]=>Value[i];

public static A021809Inst Instance=new A021809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021810
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,0L,6L,9L,4L,7L,8L,9L,0L,8L,1L,8L,8L,5L,8L,5L,6L,0L,7L,9L,4L,0L,4L,4L,6L,6L,5L,0L,1L,2L,4L,0L,6L,9L,4L,7L,8L,9L,0L,8L,1L,8L,8L,5L,8L,5L,6L,0L,7L,9L,4L,0L,4L,4L,6L,6L,5L,0L,1L,2L,4L,0L,6L,9L,4L,7L,8L,9L,0L,8L,1L,8L,8L,5L,8L,5L,6L,0L,7L,9L,4L,0L,4L,4L,6L,6L,5L,0L,1L,2L,4L,0L,6L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021810Inst : IEnumerable<long>
{
public static readonly long[] Value=A021810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021810.Bytes);
public long this[int i]=>Value[i];

public static A021810Inst Instance=new A021810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021811
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,9L,1L,5L,7L,3L,7L,2L,9L,8L,6L,3L,6L,9L,2L,6L,8L,8L,9L,7L,1L,4L,9L,9L,3L,8L,0L,4L,2L,1L,3L,1L,3L,5L,0L,6L,8L,1L,5L,3L,6L,5L,5L,5L,1L,4L,2L,5L,0L,3L,0L,9L,7L,8L,9L,3L,4L,3L,2L,4L,6L,5L,9L,2L,3L,1L,7L,2L,2L,4L,2L,8L,7L,4L,8L,4L,5L,1L,0L,5L,3L,2L,8L,3L,7L,6L,7L,0L,3L,8L,4L,1L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021811Inst : IEnumerable<long>
{
public static readonly long[] Value=A021811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021811.Bytes);
public long this[int i]=>Value[i];

public static A021811Inst Instance=new A021811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021812
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L,2L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021812Inst : IEnumerable<long>
{
public static readonly long[] Value=A021812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021812.Bytes);
public long this[int i]=>Value[i];

public static A021812Inst Instance=new A021812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021813
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,6L,0L,9L,3L,9L,4L,3L,1L,3L,9L,6L,7L,8L,6L,1L,5L,5L,7L,4L,7L,8L,3L,6L,8L,3L,5L,5L,9L,9L,5L,0L,5L,5L,6L,2L,4L,2L,2L,7L,4L,4L,1L,2L,8L,5L,5L,3L,7L,7L,0L,0L,8L,6L,5L,2L,6L,5L,7L,6L,0L,1L,9L,7L,7L,7L,5L,0L,3L,0L,9L,0L,2L,3L,4L,8L,5L,7L,8L,4L,9L,1L,9L,6L,5L,3L,8L,9L,3L,6L,9L,5L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021813Inst : IEnumerable<long>
{
public static readonly long[] Value=A021813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021813.Bytes);
public long this[int i]=>Value[i];

public static A021813Inst Instance=new A021813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021814
{
public static readonly long[] Value={ 1L,19L,239L,2519L,24135L,218343L,1903783L,16194343L,135426599L,1118993447L,9166829607L,74629521447L,604827848743L,4885462331431L,39365093814311L,316610553147431L,2543028967600167L,20405121901817895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021814Inst : IEnumerable<long>
{
public static readonly long[] Value=A021814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021814.Bytes);
public long this[int i]=>Value[i];

public static A021814Inst Instance=new A021814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021815
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,3L,0L,4L,5L,6L,2L,2L,6L,8L,8L,0L,3L,9L,4L,5L,7L,4L,5L,9L,9L,2L,6L,0L,1L,7L,2L,6L,2L,6L,3L,8L,7L,1L,7L,6L,3L,2L,5L,5L,2L,4L,0L,4L,4L,3L,8L,9L,6L,4L,2L,4L,1L,6L,7L,6L,9L,4L,2L,0L,4L,6L,8L,5L,5L,7L,3L,3L,6L,6L,2L,1L,4L,5L,4L,9L,9L,3L,8L,3L,4L,7L,7L,1L,8L,8L,6L,5L,5L,9L,8L,0L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021815Inst : IEnumerable<long>
{
public static readonly long[] Value=A021815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021815.Bytes);
public long this[int i]=>Value[i];

public static A021815Inst Instance=new A021815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021816
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,1L,5L,2L,7L,0L,9L,3L,5L,9L,6L,0L,5L,9L,1L,1L,3L,3L,0L,0L,4L,9L,2L,6L,1L,0L,8L,3L,7L,4L,3L,8L,4L,2L,3L,6L,4L,5L,3L,2L,0L,1L,9L,7L,0L,4L,4L,3L,3L,4L,9L,7L,5L,3L,6L,9L,4L,5L,8L,1L,2L,8L,0L,7L,8L,8L,1L,7L,7L,3L,3L,9L,9L,0L,1L,4L,7L,7L,8L,3L,2L,5L,1L,2L,3L,1L,5L,2L,7L,0L,9L,3L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021816Inst : IEnumerable<long>
{
public static readonly long[] Value=A021816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021816.Bytes);
public long this[int i]=>Value[i];

public static A021816Inst Instance=new A021816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021817
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L,3L,0L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021817Inst : IEnumerable<long>
{
public static readonly long[] Value=A021817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021817.Bytes);
public long this[int i]=>Value[i];

public static A021817Inst Instance=new A021817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021818
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L,2L,2L,8L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021818Inst : IEnumerable<long>
{
public static readonly long[] Value=A021818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021818.Bytes);
public long this[int i]=>Value[i];

public static A021818Inst Instance=new A021818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021819
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,6L,9L,9L,3L,8L,6L,5L,0L,3L,0L,6L,7L,4L,8L,4L,6L,6L,2L,5L,7L,6L,6L,8L,7L,1L,1L,6L,5L,6L,4L,4L,1L,7L,1L,7L,7L,9L,1L,4L,1L,1L,0L,4L,2L,9L,4L,4L,7L,8L,5L,2L,7L,6L,0L,7L,3L,6L,1L,9L,6L,3L,1L,9L,0L,1L,8L,4L,0L,4L,9L,0L,7L,9L,7L,5L,4L,6L,0L,1L,2L,2L,6L,9L,9L,3L,8L,6L,5L,0L,3L,0L,6L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021819Inst : IEnumerable<long>
{
public static readonly long[] Value=A021819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021819.Bytes);
public long this[int i]=>Value[i];

public static A021819Inst Instance=new A021819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021820
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L,7L,2L,5L,4L,9L,0L,1L,9L,6L,0L,7L,8L,4L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021820Inst : IEnumerable<long>
{
public static readonly long[] Value=A021820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021820.Bytes);
public long this[int i]=>Value[i];

public static A021820Inst Instance=new A021820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021821
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,3L,9L,9L,0L,2L,0L,8L,0L,7L,8L,3L,3L,5L,3L,7L,3L,3L,1L,7L,0L,1L,3L,4L,6L,3L,8L,9L,2L,2L,8L,8L,8L,6L,1L,6L,8L,9L,1L,0L,6L,4L,8L,7L,1L,4L,8L,1L,0L,2L,8L,1L,5L,1L,7L,7L,4L,7L,8L,5L,8L,0L,1L,7L,1L,3L,5L,8L,6L,2L,9L,1L,3L,0L,9L,6L,6L,9L,5L,2L,2L,6L,4L,3L,8L,1L,8L,8L,4L,9L,4L,4L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021821Inst : IEnumerable<long>
{
public static readonly long[] Value=A021821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021821.Bytes);
public long this[int i]=>Value[i];

public static A021821Inst Instance=new A021821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021838
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,9L,0L,4L,0L,7L,6L,7L,3L,8L,6L,0L,9L,1L,1L,2L,7L,0L,9L,8L,3L,2L,1L,3L,4L,2L,9L,2L,5L,6L,5L,9L,4L,7L,2L,4L,2L,2L,0L,6L,2L,3L,5L,0L,1L,1L,9L,9L,0L,4L,0L,7L,6L,7L,3L,8L,6L,0L,9L,1L,1L,2L,7L,0L,9L,8L,3L,2L,1L,3L,4L,2L,9L,2L,5L,6L,5L,9L,4L,7L,2L,4L,2L,2L,0L,6L,2L,3L,5L,0L,1L,1L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021838Inst : IEnumerable<long>
{
public static readonly long[] Value=A021838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021838.Bytes);
public long this[int i]=>Value[i];

public static A021838Inst Instance=new A021838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021839
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,7L,6L,0L,4L,7L,9L,0L,4L,1L,9L,1L,6L,1L,6L,7L,6L,6L,4L,6L,7L,0L,6L,5L,8L,6L,8L,2L,6L,3L,4L,7L,3L,0L,5L,3L,8L,9L,2L,2L,1L,5L,5L,6L,8L,8L,6L,2L,2L,7L,5L,4L,4L,9L,1L,0L,1L,7L,9L,6L,4L,0L,7L,1L,8L,5L,6L,2L,8L,7L,4L,2L,5L,1L,4L,9L,7L,0L,0L,5L,9L,8L,8L,0L,2L,3L,9L,5L,2L,0L,9L,5L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021839Inst : IEnumerable<long>
{
public static readonly long[] Value=A021839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021839.Bytes);
public long this[int i]=>Value[i];

public static A021839Inst Instance=new A021839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021840
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L,2L,4L,8L,8L,0L,3L,8L,2L,7L,7L,5L,1L,1L,9L,6L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021840Inst : IEnumerable<long>
{
public static readonly long[] Value=A021840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021840.Bytes);
public long this[int i]=>Value[i];

public static A021840Inst Instance=new A021840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021841
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L,1L,3L,0L,2L,2L,7L,0L,0L,1L,1L,9L,4L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021841Inst : IEnumerable<long>
{
public static readonly long[] Value=A021841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021841.Bytes);
public long this[int i]=>Value[i];

public static A021841Inst Instance=new A021841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021842
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,3L,3L,1L,7L,4L,2L,2L,4L,3L,4L,3L,6L,7L,5L,4L,1L,7L,6L,6L,1L,0L,9L,7L,8L,5L,2L,0L,2L,8L,6L,3L,9L,6L,1L,8L,1L,3L,8L,4L,2L,4L,8L,2L,1L,0L,0L,2L,3L,8L,6L,6L,3L,4L,8L,4L,4L,8L,6L,8L,7L,3L,5L,0L,8L,3L,5L,3L,2L,2L,1L,9L,5L,7L,0L,4L,0L,5L,7L,2L,7L,9L,2L,3L,6L,2L,7L,6L,8L,4L,9L,6L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021842Inst : IEnumerable<long>
{
public static readonly long[] Value=A021842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021842.Bytes);
public long this[int i]=>Value[i];

public static A021842Inst Instance=new A021842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021843
{
public static readonly long[] Value={ 0L,0L,1L,1L,9L,1L,8L,9L,5L,1L,1L,3L,2L,3L,0L,0L,3L,5L,7L,5L,6L,8L,5L,3L,3L,9L,6L,9L,0L,1L,0L,7L,2L,7L,0L,5L,6L,0L,1L,9L,0L,7L,0L,3L,2L,1L,8L,1L,1L,6L,8L,0L,5L,7L,2L,1L,0L,9L,6L,5L,4L,3L,5L,0L,4L,1L,7L,1L,6L,3L,2L,8L,9L,6L,3L,0L,5L,1L,2L,5L,1L,4L,8L,9L,8L,6L,8L,8L,9L,1L,5L,3L,7L,5L,4L,4L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021843Inst : IEnumerable<long>
{
public static readonly long[] Value=A021843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021843.Bytes);
public long this[int i]=>Value[i];

public static A021843Inst Instance=new A021843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021844
{
public static readonly long[] Value={ 1L,23L,363L,4963L,63539L,787731L,9609811L,116281811L,1401253587L,16850623699L,202422366419L,2430363281619L,29172151056595L,350112652220627L,4201633221810387L,50421288464357587L,605065606114711763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021844Inst : IEnumerable<long>
{
public static readonly long[] Value=A021844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021844.Bytes);
public long this[int i]=>Value[i];

public static A021844Inst Instance=new A021844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021845
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,9L,0L,6L,0L,6L,4L,2L,0L,9L,2L,7L,4L,6L,7L,3L,0L,0L,8L,3L,2L,3L,4L,2L,4L,4L,9L,4L,6L,4L,9L,2L,2L,7L,1L,1L,0L,5L,8L,2L,6L,3L,9L,7L,1L,4L,6L,2L,5L,4L,4L,5L,8L,9L,7L,7L,4L,0L,7L,8L,4L,7L,8L,0L,0L,2L,3L,7L,8L,1L,2L,1L,2L,8L,4L,1L,8L,5L,4L,9L,3L,4L,6L,0L,1L,6L,6L,4L,6L,8L,4L,8L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021845Inst : IEnumerable<long>
{
public static readonly long[] Value=A021845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021845.Bytes);
public long this[int i]=>Value[i];

public static A021845Inst Instance=new A021845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021846
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,7L,6L,4L,8L,4L,5L,6L,0L,5L,7L,0L,0L,7L,1L,2L,5L,8L,9L,0L,7L,3L,6L,3L,4L,2L,0L,4L,2L,7L,5L,5L,3L,4L,4L,4L,1L,8L,0L,5L,2L,2L,5L,6L,5L,3L,2L,0L,6L,6L,5L,0L,8L,3L,1L,3L,5L,3L,9L,1L,9L,2L,3L,9L,9L,0L,4L,9L,8L,8L,1L,2L,3L,5L,1L,5L,4L,3L,9L,4L,2L,9L,9L,2L,8L,7L,4L,1L,0L,9L,2L,6L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021846Inst : IEnumerable<long>
{
public static readonly long[] Value=A021846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021846.Bytes);
public long this[int i]=>Value[i];

public static A021846Inst Instance=new A021846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021847
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,6L,2L,3L,9L,6L,2L,0L,4L,0L,3L,3L,2L,1L,4L,7L,0L,9L,3L,7L,1L,2L,9L,3L,0L,0L,1L,1L,8L,6L,2L,3L,9L,6L,2L,0L,4L,0L,3L,3L,2L,1L,4L,7L,0L,9L,3L,7L,1L,2L,9L,3L,0L,0L,1L,1L,8L,6L,2L,3L,9L,6L,2L,0L,4L,0L,3L,3L,2L,1L,4L,7L,0L,9L,3L,7L,1L,2L,9L,3L,0L,0L,1L,1L,8L,6L,2L,3L,9L,6L,2L,0L,4L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021847Inst : IEnumerable<long>
{
public static readonly long[] Value=A021847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021847.Bytes);
public long this[int i]=>Value[i];

public static A021847Inst Instance=new A021847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021848
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,4L,8L,3L,4L,1L,2L,3L,2L,2L,2L,7L,4L,8L,8L,1L,5L,1L,6L,5L,8L,7L,6L,7L,7L,7L,2L,5L,1L,1L,8L,4L,8L,3L,4L,1L,2L,3L,2L,2L,2L,7L,4L,8L,8L,1L,5L,1L,6L,5L,8L,7L,6L,7L,7L,7L,2L,5L,1L,1L,8L,4L,8L,3L,4L,1L,2L,3L,2L,2L,2L,7L,4L,8L,8L,1L,5L,1L,6L,5L,8L,7L,6L,7L,7L,7L,2L,5L,1L,1L,8L,4L,8L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021848Inst : IEnumerable<long>
{
public static readonly long[] Value=A021848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021848.Bytes);
public long this[int i]=>Value[i];

public static A021848Inst Instance=new A021848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021849
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,3L,4L,3L,1L,9L,5L,2L,6L,6L,2L,7L,2L,1L,8L,9L,3L,4L,9L,1L,1L,2L,4L,2L,6L,0L,3L,5L,5L,0L,2L,9L,5L,8L,5L,7L,9L,8L,8L,1L,6L,5L,6L,8L,0L,4L,7L,3L,3L,7L,2L,7L,8L,1L,0L,6L,5L,0L,8L,8L,7L,5L,7L,3L,9L,6L,4L,4L,9L,7L,0L,4L,1L,4L,2L,0L,1L,1L,8L,3L,4L,3L,1L,9L,5L,2L,6L,6L,2L,7L,2L,1L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021849Inst : IEnumerable<long>
{
public static readonly long[] Value=A021849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021849.Bytes);
public long this[int i]=>Value[i];

public static A021849Inst Instance=new A021849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021850
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,2L,0L,3L,3L,0L,9L,6L,9L,2L,6L,7L,1L,3L,9L,4L,7L,9L,9L,0L,5L,4L,3L,7L,3L,5L,2L,2L,4L,5L,8L,6L,2L,8L,8L,4L,1L,6L,0L,7L,5L,6L,5L,0L,1L,1L,8L,2L,0L,3L,3L,0L,9L,6L,9L,2L,6L,7L,1L,3L,9L,4L,7L,9L,9L,0L,5L,4L,3L,7L,3L,5L,2L,2L,4L,5L,8L,6L,2L,8L,8L,4L,1L,6L,0L,7L,5L,6L,5L,0L,1L,1L,8L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021850Inst : IEnumerable<long>
{
public static readonly long[] Value=A021850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021850.Bytes);
public long this[int i]=>Value[i];

public static A021850Inst Instance=new A021850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021851
{
public static readonly long[] Value={ 0L,0L,1L,1L,8L,0L,6L,3L,7L,5L,4L,4L,2L,7L,3L,9L,0L,7L,9L,1L,0L,2L,7L,1L,5L,4L,6L,6L,3L,5L,1L,8L,2L,9L,9L,8L,8L,1L,9L,3L,6L,2L,4L,5L,5L,7L,2L,6L,0L,9L,2L,0L,8L,9L,7L,2L,8L,4L,5L,3L,3L,6L,4L,8L,1L,7L,0L,0L,1L,1L,8L,0L,6L,3L,7L,5L,4L,4L,2L,7L,3L,9L,0L,7L,9L,1L,0L,2L,7L,1L,5L,4L,6L,6L,3L,5L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021851Inst : IEnumerable<long>
{
public static readonly long[] Value=A021851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021851.Bytes);
public long this[int i]=>Value[i];

public static A021851Inst Instance=new A021851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021852
{
public static readonly long[] Value={ 0L,0L,1L,1L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L,5L,2L,8L,3L,0L,1L,8L,8L,6L,7L,9L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021852Inst : IEnumerable<long>
{
public static readonly long[] Value=A021852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021852.Bytes);
public long this[int i]=>Value[i];

public static A021852Inst Instance=new A021852Inst();

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