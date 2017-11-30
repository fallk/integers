using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198357
{
public static readonly long[] Value={ 7L,4L,6L,0L,7L,4L,3L,6L,2L,1L,2L,8L,5L,6L,4L,4L,6L,1L,7L,3L,2L,5L,7L,4L,1L,8L,9L,8L,5L,6L,5L,3L,0L,6L,7L,3L,5L,6L,8L,5L,1L,9L,0L,1L,4L,6L,8L,5L,0L,2L,7L,8L,5L,6L,9L,0L,8L,2L,2L,9L,6L,4L,8L,7L,6L,6L,2L,2L,9L,3L,3L,0L,9L,6L,2L,0L,1L,6L,5L,1L,3L,7L,8L,3L,6L,3L,0L,2L,6L,7L,3L,7L,8L,0L,4L,5L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198357Inst : IEnumerable<long>
{
public static readonly long[] Value=A198357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198357.Bytes);
public long this[int i]=>Value[i];

public static A198357Inst Instance=new A198357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198358
{
public static readonly long[] Value={ 2L,9L,9L,0L,0L,5L,8L,7L,4L,5L,5L,0L,3L,1L,7L,3L,5L,7L,0L,3L,7L,4L,6L,8L,3L,5L,0L,7L,2L,4L,5L,4L,1L,9L,3L,9L,3L,2L,7L,5L,7L,6L,1L,9L,1L,7L,0L,1L,7L,3L,6L,6L,4L,0L,3L,0L,6L,4L,6L,5L,8L,6L,5L,0L,6L,8L,3L,1L,7L,8L,6L,7L,7L,0L,8L,4L,2L,8L,0L,2L,3L,5L,9L,0L,7L,3L,6L,2L,5L,6L,6L,1L,7L,4L,9L,4L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198358Inst : IEnumerable<long>
{
public static readonly long[] Value=A198358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198358.Bytes);
public long this[int i]=>Value[i];

public static A198358Inst Instance=new A198358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198359
{
public static readonly long[] Value={ 9L,5L,4L,3L,4L,7L,7L,7L,6L,6L,0L,8L,7L,5L,5L,6L,7L,2L,1L,2L,0L,9L,0L,0L,9L,5L,4L,7L,9L,3L,3L,9L,1L,3L,7L,3L,2L,9L,4L,4L,2L,8L,2L,7L,1L,3L,8L,3L,6L,2L,0L,7L,0L,8L,3L,5L,8L,2L,4L,7L,6L,5L,0L,6L,4L,0L,9L,9L,8L,5L,6L,9L,4L,5L,8L,2L,9L,1L,3L,1L,7L,6L,9L,1L,7L,4L,3L,5L,0L,6L,3L,4L,2L,2L,2L,0L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198359Inst : IEnumerable<long>
{
public static readonly long[] Value=A198359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198359.Bytes);
public long this[int i]=>Value[i];

public static A198359Inst Instance=new A198359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198360
{
public static readonly long[] Value={ 5L,8L,0L,4L,5L,7L,1L,2L,4L,4L,4L,5L,9L,3L,3L,1L,6L,1L,7L,9L,7L,2L,1L,9L,6L,5L,1L,4L,2L,8L,8L,1L,9L,0L,7L,5L,8L,9L,3L,8L,9L,8L,1L,1L,3L,7L,0L,7L,3L,9L,1L,2L,4L,9L,1L,2L,2L,4L,0L,8L,6L,1L,6L,7L,8L,2L,2L,5L,7L,9L,9L,5L,6L,9L,8L,9L,0L,1L,5L,7L,4L,9L,7L,7L,1L,6L,1L,8L,5L,9L,2L,6L,3L,4L,7L,2L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198360Inst : IEnumerable<long>
{
public static readonly long[] Value=A198360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198360.Bytes);
public long this[int i]=>Value[i];

public static A198360Inst Instance=new A198360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198361
{
public static readonly long[] Value={ 9L,1L,6L,1L,5L,1L,0L,6L,1L,0L,9L,6L,8L,3L,5L,7L,7L,0L,0L,0L,1L,3L,5L,0L,7L,2L,8L,0L,3L,9L,4L,6L,3L,9L,1L,8L,9L,1L,2L,6L,5L,1L,0L,6L,8L,0L,9L,3L,7L,1L,6L,1L,7L,1L,8L,8L,4L,2L,5L,1L,7L,8L,5L,3L,2L,1L,3L,7L,6L,0L,0L,8L,0L,0L,5L,1L,4L,4L,9L,3L,8L,7L,1L,5L,7L,8L,9L,2L,0L,1L,9L,0L,1L,3L,3L,8L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198361Inst : IEnumerable<long>
{
public static readonly long[] Value=A198361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198361.Bytes);
public long this[int i]=>Value[i];

public static A198361Inst Instance=new A198361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198362
{
public static readonly long[] Value={ 2L,4L,4L,0L,4L,5L,3L,2L,2L,6L,2L,9L,1L,3L,5L,5L,9L,1L,4L,6L,6L,8L,5L,8L,2L,8L,2L,9L,3L,9L,4L,4L,8L,0L,7L,9L,4L,9L,3L,2L,8L,4L,3L,7L,5L,3L,3L,7L,6L,0L,8L,7L,5L,4L,6L,7L,2L,2L,2L,3L,1L,3L,5L,5L,5L,6L,1L,9L,0L,4L,2L,7L,8L,6L,2L,9L,9L,9L,9L,7L,3L,4L,9L,3L,8L,4L,1L,6L,5L,2L,3L,1L,4L,6L,8L,5L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198362Inst : IEnumerable<long>
{
public static readonly long[] Value=A198362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198362.Bytes);
public long this[int i]=>Value[i];

public static A198362Inst Instance=new A198362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198363
{
public static readonly long[] Value={ 1L,0L,1L,1L,9L,6L,4L,0L,7L,1L,9L,5L,4L,1L,5L,9L,6L,5L,5L,1L,6L,4L,3L,9L,2L,2L,5L,1L,6L,8L,6L,8L,1L,0L,4L,7L,8L,4L,3L,1L,4L,0L,0L,1L,4L,0L,3L,1L,8L,0L,2L,4L,9L,9L,0L,9L,8L,2L,2L,2L,2L,1L,0L,5L,2L,6L,4L,8L,1L,9L,8L,6L,2L,5L,9L,0L,1L,3L,6L,4L,3L,3L,5L,8L,7L,3L,1L,1L,1L,5L,1L,0L,7L,8L,2L,1L,9L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198363Inst : IEnumerable<long>
{
public static readonly long[] Value=A198363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198363.Bytes);
public long this[int i]=>Value[i];

public static A198363Inst Instance=new A198363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198364
{
public static readonly long[] Value={ 4L,0L,0L,3L,0L,3L,9L,9L,5L,2L,5L,5L,1L,8L,5L,9L,1L,4L,6L,3L,0L,6L,3L,7L,1L,8L,6L,8L,3L,4L,2L,0L,3L,5L,7L,2L,4L,6L,4L,1L,5L,2L,9L,6L,5L,1L,0L,7L,0L,7L,9L,4L,9L,2L,4L,4L,3L,2L,3L,2L,8L,6L,3L,4L,2L,8L,9L,9L,3L,8L,5L,5L,3L,3L,2L,2L,1L,0L,4L,0L,7L,9L,7L,1L,9L,7L,5L,3L,3L,2L,5L,6L,9L,3L,1L,9L,2L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198364Inst : IEnumerable<long>
{
public static readonly long[] Value=A198364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198364.Bytes);
public long this[int i]=>Value[i];

public static A198364Inst Instance=new A198364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198365
{
public static readonly long[] Value={ 1L,0L,7L,8L,5L,9L,7L,1L,0L,9L,5L,6L,8L,8L,5L,8L,1L,1L,1L,7L,1L,8L,0L,8L,5L,4L,1L,8L,6L,3L,3L,0L,1L,1L,1L,6L,6L,7L,3L,5L,9L,6L,9L,2L,8L,3L,0L,7L,4L,9L,8L,8L,8L,0L,6L,3L,6L,7L,3L,4L,7L,6L,2L,1L,9L,2L,7L,5L,0L,2L,2L,0L,9L,4L,3L,8L,5L,3L,7L,7L,2L,3L,7L,1L,1L,8L,9L,7L,0L,5L,1L,5L,9L,6L,7L,2L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198365Inst : IEnumerable<long>
{
public static readonly long[] Value=A198365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198365.Bytes);
public long this[int i]=>Value[i];

public static A198365Inst Instance=new A198365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198366
{
public static readonly long[] Value={ 5L,1L,5L,5L,7L,8L,8L,1L,1L,1L,6L,4L,6L,6L,2L,3L,2L,2L,9L,1L,6L,7L,6L,0L,6L,2L,2L,0L,0L,9L,0L,9L,2L,1L,8L,3L,1L,2L,9L,5L,9L,3L,7L,5L,7L,1L,8L,7L,5L,1L,0L,0L,0L,1L,4L,2L,6L,2L,7L,6L,0L,4L,3L,6L,4L,4L,5L,3L,7L,8L,8L,4L,6L,1L,0L,7L,2L,5L,0L,0L,9L,0L,1L,0L,9L,5L,2L,5L,3L,0L,7L,6L,1L,7L,4L,6L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198366Inst : IEnumerable<long>
{
public static readonly long[] Value=A198366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198366.Bytes);
public long this[int i]=>Value[i];

public static A198366Inst Instance=new A198366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198367
{
public static readonly long[] Value={ 1L,1L,2L,8L,8L,6L,4L,4L,2L,0L,5L,2L,3L,9L,8L,6L,1L,3L,9L,4L,7L,7L,0L,0L,4L,6L,6L,3L,0L,6L,1L,8L,8L,9L,5L,7L,3L,6L,9L,5L,9L,7L,3L,2L,4L,1L,1L,0L,7L,6L,5L,2L,1L,7L,0L,0L,9L,7L,5L,6L,1L,3L,7L,9L,9L,7L,7L,1L,6L,8L,9L,1L,6L,9L,3L,8L,1L,2L,9L,9L,6L,0L,9L,6L,8L,4L,1L,0L,2L,9L,1L,6L,3L,7L,6L,9L,9L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198367Inst : IEnumerable<long>
{
public static readonly long[] Value=A198367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198367.Bytes);
public long this[int i]=>Value[i];

public static A198367Inst Instance=new A198367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198368
{
public static readonly long[] Value={ 6L,0L,6L,0L,7L,7L,7L,8L,3L,6L,4L,8L,6L,2L,6L,4L,5L,3L,6L,6L,5L,7L,9L,7L,7L,5L,7L,9L,9L,0L,5L,6L,2L,9L,1L,0L,5L,7L,8L,9L,9L,1L,3L,1L,8L,1L,7L,8L,8L,5L,7L,2L,2L,2L,5L,3L,4L,2L,4L,7L,5L,8L,6L,3L,2L,8L,9L,9L,8L,4L,2L,0L,5L,8L,9L,6L,2L,9L,7L,9L,1L,6L,6L,8L,0L,4L,3L,0L,9L,4L,1L,8L,4L,6L,8L,0L,6L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198368Inst : IEnumerable<long>
{
public static readonly long[] Value=A198368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198368.Bytes);
public long this[int i]=>Value[i];

public static A198368Inst Instance=new A198368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198369
{
public static readonly long[] Value={ 1L,1L,0L,2L,3L,8L,4L,7L,4L,6L,2L,7L,9L,4L,3L,9L,5L,9L,5L,8L,0L,5L,8L,1L,8L,3L,6L,5L,8L,6L,7L,8L,8L,1L,3L,9L,4L,4L,9L,1L,9L,2L,4L,8L,4L,6L,4L,3L,3L,1L,7L,4L,9L,1L,7L,4L,3L,6L,5L,7L,0L,7L,8L,7L,4L,1L,5L,7L,9L,8L,0L,2L,0L,1L,8L,1L,3L,2L,9L,9L,5L,9L,2L,5L,9L,7L,1L,9L,5L,8L,2L,4L,5L,4L,1L,1L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198369Inst : IEnumerable<long>
{
public static readonly long[] Value=A198369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198369.Bytes);
public long this[int i]=>Value[i];

public static A198369Inst Instance=new A198369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198370
{
public static readonly long[] Value={ 2L,0L,3L,4L,5L,1L,3L,2L,5L,5L,3L,1L,9L,2L,5L,0L,4L,1L,5L,5L,5L,1L,1L,6L,8L,0L,5L,0L,6L,0L,6L,1L,1L,9L,9L,5L,6L,1L,1L,6L,1L,8L,6L,7L,7L,8L,9L,0L,3L,4L,4L,6L,3L,3L,3L,3L,1L,5L,2L,7L,0L,3L,1L,3L,9L,3L,5L,5L,9L,1L,7L,6L,0L,6L,0L,1L,6L,8L,6L,0L,1L,3L,4L,9L,1L,7L,1L,6L,3L,2L,3L,1L,6L,6L,3L,3L,7L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198370Inst : IEnumerable<long>
{
public static readonly long[] Value=A198370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198370.Bytes);
public long this[int i]=>Value[i];

public static A198370Inst Instance=new A198370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198371
{
public static readonly long[] Value={ 1L,2L,1L,5L,0L,1L,2L,9L,8L,4L,2L,6L,4L,3L,5L,2L,4L,5L,7L,0L,4L,8L,8L,7L,1L,2L,8L,4L,9L,9L,1L,5L,0L,2L,5L,4L,8L,7L,5L,7L,7L,7L,4L,5L,5L,1L,7L,6L,4L,2L,1L,2L,8L,7L,0L,7L,3L,1L,8L,8L,3L,5L,3L,0L,9L,4L,3L,4L,5L,6L,6L,3L,5L,5L,5L,9L,7L,9L,3L,2L,3L,0L,6L,9L,0L,0L,6L,0L,6L,1L,6L,6L,4L,1L,0L,2L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198371Inst : IEnumerable<long>
{
public static readonly long[] Value=A198371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198371.Bytes);
public long this[int i]=>Value[i];

public static A198371Inst Instance=new A198371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198372
{
public static readonly long[] Value={ 4L,6L,0L,1L,9L,4L,9L,9L,7L,7L,5L,0L,9L,3L,0L,9L,7L,1L,4L,2L,4L,7L,9L,7L,2L,7L,7L,9L,6L,4L,5L,5L,8L,8L,6L,1L,6L,5L,4L,5L,0L,0L,5L,1L,8L,5L,7L,4L,4L,9L,2L,0L,1L,8L,4L,8L,3L,1L,1L,1L,0L,4L,0L,7L,7L,7L,4L,6L,4L,8L,7L,8L,7L,8L,6L,5L,8L,1L,6L,3L,2L,7L,1L,7L,8L,9L,2L,8L,3L,6L,1L,8L,1L,4L,4L,0L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198372Inst : IEnumerable<long>
{
public static readonly long[] Value=A198372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198372.Bytes);
public long this[int i]=>Value[i];

public static A198372Inst Instance=new A198372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198373
{
public static readonly long[] Value={ 3L,6L,9L,9L,4L,8L,1L,7L,0L,5L,8L,9L,8L,6L,6L,5L,2L,8L,6L,9L,1L,6L,0L,2L,0L,8L,8L,6L,2L,0L,2L,9L,5L,2L,2L,3L,4L,7L,7L,1L,8L,4L,0L,7L,6L,5L,5L,2L,3L,8L,5L,9L,0L,0L,3L,7L,1L,8L,4L,1L,4L,6L,5L,1L,5L,5L,7L,4L,0L,2L,7L,9L,2L,0L,1L,4L,5L,2L,4L,1L,6L,9L,0L,1L,6L,1L,6L,5L,5L,9L,1L,3L,0L,6L,1L,6L,0L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198373Inst : IEnumerable<long>
{
public static readonly long[] Value=A198373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198373.Bytes);
public long this[int i]=>Value[i];

public static A198373Inst Instance=new A198373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198374
{
public static readonly long[] Value={ 7L,6L,3L,3L,9L,4L,5L,3L,8L,2L,1L,0L,1L,9L,2L,3L,3L,6L,9L,9L,2L,6L,7L,4L,5L,3L,6L,3L,8L,4L,8L,3L,7L,6L,1L,4L,5L,3L,2L,9L,5L,7L,8L,9L,0L,4L,0L,5L,6L,9L,1L,4L,2L,3L,6L,4L,4L,7L,5L,5L,0L,5L,1L,4L,0L,8L,4L,3L,9L,2L,8L,3L,4L,2L,2L,7L,0L,1L,7L,1L,3L,8L,3L,7L,8L,4L,3L,6L,3L,3L,4L,0L,4L,1L,3L,5L,6L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198374Inst : IEnumerable<long>
{
public static readonly long[] Value=A198374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198374.Bytes);
public long this[int i]=>Value[i];

public static A198374Inst Instance=new A198374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198375
{
public static readonly BigInteger[] Value={ 1L,12L,113L,1114L,11115L,111116L,1111117L,11111118L,111111119L,1111111125L,0L,111111111126L,0L,11111111111127L,111111111111135L,1111111111111128L,0L,111111111111111129L,0L,11111111111111111145UL,BigInteger.Parse("111111111111111111137"),0L,0L,BigInteger.Parse("111111111111111111111138") };
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
public class A198375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198375Inst Instance=new A198375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198376
{
public static readonly BigInteger[] Value={ 1L,21L,311L,4111L,51111L,611111L,7111111L,81111111L,911111111L,5211111111L,0L,621111111111L,0L,72111111111111L,531111111111111L,8211111111111111L,0L,921111111111111111L,0L,BigInteger.Parse("54111111111111111111"),BigInteger.Parse("731111111111111111111"),0L,0L,BigInteger.Parse("831111111111111111111111") };
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
public class A198376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198376Inst Instance=new A198376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198377
{
public static readonly long[] Value={ 0L,10L,25L,39L,77L,679L,6788L,68889L,2677889L,26888999L,3778889989L,277777788888899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198377Inst : IEnumerable<long>
{
public static readonly long[] Value=A198377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198377.Bytes);
public long this[int i]=>Value[i];

public static A198377Inst Instance=new A198377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198378
{
public static readonly long[] Value={ 59L,11L,2L,3L,41L,5L,23L,7L,29L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198378Inst : IEnumerable<long>
{
public static readonly long[] Value=A198378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198378.Bytes);
public long this[int i]=>Value[i];

public static A198378Inst Instance=new A198378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198379
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,2L,1L,0L,0L,0L,3L,1L,0L,0L,-1L,0L,4L,1L,0L,0L,0L,-4L,0L,5L,1L,0L,0L,0L,0L,-10L,0L,6L,1L,0L,0L,0L,2L,0L,-20L,0L,7L,1L,0L,0L,0L,0L,12L,0L,-35L,0L,8L,1L,0L,0L,0L,0L,0L,42L,0L,-56L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198379Inst : IEnumerable<long>
{
public static readonly long[] Value=A198379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198379.Bytes);
public long this[int i]=>Value[i];

public static A198379Inst Instance=new A198379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198380
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,1L,3L,2L,4L,4L,2L,2L,4L,1L,2L,3L,4L,4L,2L,2L,1L,4L,3L,1L,3L,3L,5L,5L,3L,2L,5L,4L,6L,6L,4L,4L,6L,2L,4L,5L,6L,6L,4L,4L,2L,6L,5L,2L,5L,4L,6L,6L,4L,1L,3L,2L,4L,4L,2L,3L,5L,4L,6L,6L,5L,5L,3L,6L,4L,5L,6L,4L,6L,2L,4L,5L,6L,2L,4L,1L,2L,3L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198380Inst : IEnumerable<long>
{
public static readonly long[] Value=A198380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198380.Bytes);
public long this[int i]=>Value[i];

public static A198380Inst Instance=new A198380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198381
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,6L,10L,20L,32L,54L,81L,128L,184L,273L,385L,549L,754L,1048L,1412L,1917L,2547L,3392L,4444L,5837L,7556L,9791L,12553L,16086L,20429L,25935L,32665L,41108L,51404L,64190L,79721L,98882L,122043L,150417L,184618L,226239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198381Inst : IEnumerable<long>
{
public static readonly long[] Value=A198381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198381.Bytes);
public long this[int i]=>Value[i];

public static A198381Inst Instance=new A198381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198382
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,10L,12L,14L,17L,18L,19L,22L,25L,26L,27L,28L,29L,32L,35L,38L,39L,40L,41L,43L,46L,48L,49L,55L,56L,57L,59L,60L,61L,67L,69L,70L,71L,73L,77L,78L,80L,82L,83L,85L,87L,92L,96L,101L,104L,116L,117L,118L,120L,124L,125L,127L,131L,133L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198382Inst : IEnumerable<long>
{
public static readonly long[] Value=A198382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198382.Bytes);
public long this[int i]=>Value[i];

public static A198382Inst Instance=new A198382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198383
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,10L,20L,22L,37L,40L,80L,72L,144L,158L,278L,283L,566L,548L,1096L,1120L,2106L,2162L,4324L,4210L,8389L,8584L,16650L,16772L,33544L,33194L,66388L,66968L,131882L,132690L,265222L,263607L,527214L,530138L,1052078L,1054254L,2108508L,2103282L,4206564L,4216760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198383Inst : IEnumerable<long>
{
public static readonly long[] Value=A198383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198383.Bytes);
public long this[int i]=>Value[i];

public static A198383Inst Instance=new A198383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198384
{
public static readonly long[] Value={ 1L,4L,49L,9L,49L,16L,289L,196L,25L,1L,36L,196L,529L,49L,961L,441L,64L,1156L,81L,784L,441L,100L,2401L,289L,121L,2209L,4L,144L,1225L,529L,169L,784L,2601L,2116L,5041L,196L,3844L,1764L,49L,225L,256L,1681L,1225L,289L,1681L,2401L,6241L,9L,4624L,324L,9409L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198384Inst : IEnumerable<long>
{
public static readonly long[] Value=A198384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198384.Bytes);
public long this[int i]=>Value[i];

public static A198384Inst Instance=new A198384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198385
{
public static readonly long[] Value={ 25L,100L,169L,225L,289L,400L,625L,676L,625L,841L,900L,1156L,1369L,1225L,1681L,1521L,1600L,2500L,2025L,2704L,2601L,2500L,3721L,2809L,3025L,4225L,3364L,3600L,4225L,4225L,4225L,4624L,5625L,5476L,7225L,4900L,6724L,6084L,5329L,5625L,6400L,7225L,7225L,7225L,7921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198385Inst : IEnumerable<long>
{
public static readonly long[] Value=A198385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198385.Bytes);
public long this[int i]=>Value[i];

public static A198385Inst Instance=new A198385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198386
{
public static readonly long[] Value={ 49L,196L,289L,441L,529L,784L,961L,1156L,1225L,1681L,1764L,2116L,2209L,2401L,2401L,2601L,3136L,3844L,3969L,4624L,4761L,4900L,5041L,5329L,5929L,6241L,6724L,7056L,7225L,7921L,8281L,8464L,8649L,8836L,9409L,9604L,9604L,10404L,10609L,11025L,12544L,12769L,13225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198386Inst : IEnumerable<long>
{
public static readonly long[] Value=A198386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198386.Bytes);
public long this[int i]=>Value[i];

public static A198386Inst Instance=new A198386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198387
{
public static readonly long[] Value={ 24L,96L,120L,216L,240L,384L,336L,480L,600L,840L,864L,960L,840L,1176L,720L,1080L,1536L,1344L,1944L,1920L,2160L,2400L,1320L,2520L,2904L,2016L,3360L,3456L,3000L,3696L,4056L,3840L,3024L,3360L,2184L,4704L,2880L,4320L,5280L,5400L,6144L,5544L,6000L,6936L,6240L,5880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198387Inst : IEnumerable<long>
{
public static readonly long[] Value=A198387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198387.Bytes);
public long this[int i]=>Value[i];

public static A198387Inst Instance=new A198387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198388
{
public static readonly long[] Value={ 1L,2L,7L,3L,7L,4L,17L,14L,5L,1L,6L,14L,23L,7L,31L,21L,8L,34L,9L,28L,21L,10L,49L,17L,11L,47L,2L,12L,35L,23L,13L,28L,51L,46L,71L,14L,62L,42L,7L,15L,16L,41L,35L,17L,41L,49L,79L,3L,68L,18L,97L,19L,56L,7L,42L,20L,69L,98L,34L,21L,93L,31L,63L,22L,85L,94L,23L,49L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198388Inst : IEnumerable<long>
{
public static readonly long[] Value=A198388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198388.Bytes);
public long this[int i]=>Value[i];

public static A198388Inst Instance=new A198388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198389
{
public static readonly long[] Value={ 5L,10L,13L,15L,17L,20L,25L,26L,25L,29L,30L,34L,37L,35L,41L,39L,40L,50L,45L,52L,51L,50L,61L,53L,55L,65L,58L,60L,65L,65L,65L,68L,75L,74L,85L,70L,82L,78L,73L,75L,80L,85L,85L,85L,89L,91L,101L,87L,100L,90L,113L,95L,104L,97L,102L,100L,111L,122L,106L,105L,123L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198389Inst : IEnumerable<long>
{
public static readonly long[] Value=A198389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198389.Bytes);
public long this[int i]=>Value[i];

public static A198389Inst Instance=new A198389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198390
{
public static readonly long[] Value={ 7L,14L,17L,21L,23L,28L,31L,34L,35L,41L,42L,46L,47L,49L,49L,51L,56L,62L,63L,68L,69L,70L,71L,73L,77L,79L,82L,84L,85L,89L,91L,92L,93L,94L,97L,98L,98L,102L,103L,105L,112L,113L,115L,119L,119L,119L,119L,123L,124L,126L,127L,133L,136L,137L,138L,140L,141L,142L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198390Inst : IEnumerable<long>
{
public static readonly long[] Value=A198390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198390.Bytes);
public long this[int i]=>Value[i];

public static A198390Inst Instance=new A198390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198391
{
public static readonly long[] Value={ 2L,15L,20L,272L,476L,19024L,47425L,65792L,125172L,216900L,539280L,1222976L,1372736L,2770496L,3494336L,5321808L,5844528L,6177168L,7032528L,8885808L,20670768L,60727876L,69081344L,82724356L,95579136L,544382208L,907440192L,1657497600L,4295032832L,5048574976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198391Inst : IEnumerable<long>
{
public static readonly long[] Value=A198391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198391.Bytes);
public long this[int i]=>Value[i];

public static A198391Inst Instance=new A198391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198392
{
public static readonly long[] Value={ 2L,4L,12L,18L,31L,41L,59L,73L,96L,114L,142L,164L,197L,223L,261L,291L,334L,368L,416L,454L,507L,549L,607L,653L,716L,766L,834L,888L,961L,1019L,1097L,1159L,1242L,1308L,1396L,1466L,1559L,1633L,1731L,1809L,1912L,1994L,2102L,2188L,2301L,2391L,2509L,2603L,2726L,2824L,2952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198392Inst : IEnumerable<long>
{
public static readonly long[] Value=A198392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198392.Bytes);
public long this[int i]=>Value[i];

public static A198392Inst Instance=new A198392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198393
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,2L,1L,0L,1L,0L,1L,2L,1L,0L,1L,1L,2L,1L,0L,2L,1L,1L,1L,1L,1L,1L,2L,0L,0L,1L,1L,1L,1L,0L,0L,2L,2L,0L,1L,1L,1L,2L,1L,1L,2L,2L,1L,0L,2L,0L,0L,1L,2L,1L,0L,1L,1L,2L,2L,1L,0L,2L,1L,3L,1L,2L,1L,0L,0L,1L,0L,2L,3L,1L,0L,2L,1L,1L,0L,1L,1L,2L,1L,1L,3L,1L,0L,1L,2L,0L,0L,1L,2L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198393Inst : IEnumerable<long>
{
public static readonly long[] Value=A198393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198393.Bytes);
public long this[int i]=>Value[i];

public static A198393Inst Instance=new A198393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198394
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,11L,15L,20L,29L,30L,35L,36L,39L,49L,51L,52L,56L,62L,69L,70L,72L,76L,80L,88L,91L,92L,96L,102L,104L,105L,106L,108L,111L,113L,115L,117L,121L,126L,129L,130L,135L,137L,138L,139L,140L,148L,151L,152L,153L,170L,173L,176L,192L,199L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198394Inst : IEnumerable<long>
{
public static readonly long[] Value=A198394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198394.Bytes);
public long this[int i]=>Value[i];

public static A198394Inst Instance=new A198394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198395
{
public static readonly long[] Value={ 0L,5L,9L,13L,17L,21L,25L,29L,33L,38L,42L,46L,50L,54L,58L,62L,66L,71L,75L,79L,83L,87L,91L,95L,99L,104L,108L,112L,116L,120L,124L,128L,132L,137L,141L,145L,149L,153L,157L,161L,165L,170L,174L,178L,182L,186L,190L,194L,198L,203L,207L,211L,215L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198395Inst : IEnumerable<long>
{
public static readonly long[] Value=A198395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198395.Bytes);
public long this[int i]=>Value[i];

public static A198395Inst Instance=new A198395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198396
{
public static readonly long[] Value={ 1L,0L,24L,198L,1272L,7746L,46620L,279894L,1679568L,10077642L,60466116L,362796990L,2176782264L,13060693938L,78364164012L,470184984486L,2821109907360L,16926659444634L,101559956668308L,609359740010382L,3656158440062856L,21936950640377730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198396Inst : IEnumerable<long>
{
public static readonly long[] Value=A198396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198396.Bytes);
public long this[int i]=>Value[i];

public static A198396Inst Instance=new A198396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198397
{
public static readonly long[] Value={ 1L,0L,35L,322L,2373L,16772L,117607L,823494L,5764745L,40353544L,282475179L,1977326666L,13841287117L,96889010316L,678223072751L,4747561509838L,33232930569489L,232630513987088L,1628413597910323L,11398895185373010L,79792266297611861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198397Inst : IEnumerable<long>
{
public static readonly long[] Value=A198397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198397.Bytes);
public long this[int i]=>Value[i];

public static A198397Inst Instance=new A198397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198398
{
public static readonly long[] Value={ 1L,0L,48L,488L,4064L,32728L,262096L,2097096L,16777152L,134217656L,1073741744L,8589934504L,68719476640L,549755813784L,4398046510992L,35184372088712L,281474976710528L,2251799813685112L,18014398509481840L,144115188075855720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198398Inst : IEnumerable<long>
{
public static readonly long[] Value=A198398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198398.Bytes);
public long this[int i]=>Value[i];

public static A198398Inst Instance=new A198398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198399
{
public static readonly long[] Value={ 1L,0L,63L,702L,6525L,59004L,531387L,4782906L,43046649L,387420408L,3486784311L,31381059510L,282429536373L,2541865828212L,22876792454835L,205891132094514L,1853020188851697L,16677181699666416L,150094635296998959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198399Inst : IEnumerable<long>
{
public static readonly long[] Value=A198399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198399.Bytes);
public long this[int i]=>Value[i];

public static A198399Inst Instance=new A198399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198400
{
public static readonly long[] Value={ 1L,0L,80L,970L,9960L,99950L,999940L,9999930L,99999920L,999999910L,9999999900L,99999999890L,999999999880L,9999999999870L,99999999999860L,999999999999850L,9999999999999840L,99999999999999830L,999999999999999820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198400Inst : IEnumerable<long>
{
public static readonly long[] Value=A198400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198400.Bytes);
public long this[int i]=>Value[i];

public static A198400Inst Instance=new A198400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198401
{
public static readonly long[] Value={ 1L,9L,320L,7073L,69632L,423393L,1941760L,7861953L,33554432L,177264449L,1173741824L,8804293473L,69149458432L,550571544609L,4399522300160L,35186934979457L,281479271677952L,2251806789442689L,18014409529442560L,144115205059418913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198401Inst : IEnumerable<long>
{
public static readonly long[] Value=A198401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198401.Bytes);
public long this[int i]=>Value[i];

public static A198401Inst Instance=new A198401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198402
{
public static readonly long[] Value={ 0L,5L,800L,30375L,640000L,9765625L,121500000L,1313046875L,12800000000L,115330078125L,976562500000L,7863818359375L,60750000000000L,453238525390625L,3282617187500000L,23174285888671875L,160000000000000000L,1083264923095703125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198402Inst : IEnumerable<long>
{
public static readonly long[] Value=A198402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198402.Bytes);
public long this[int i]=>Value[i];

public static A198402Inst Instance=new A198402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198403
{
public static readonly long[] Value={ 0L,6L,2304L,157464L,5308416L,121500000L,2176782336L,32934190464L,440301256704L,5355700839936L,60466176000000L,642717115324416L,6499837226778624L,63041475422674944L,590045794670739456L,5355700839936000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198403Inst : IEnumerable<long>
{
public static readonly long[] Value=A198403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198403.Bytes);
public long this[int i]=>Value[i];

public static A198403Inst Instance=new A198403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198404
{
public static readonly BigInteger[] Value={ 0L,8L,16384L,3359232L,268435456L,12800000000L,440301256704L,12089663946752L,281474976710656L,5777633090469888L,107374182400000000L,1841328767004311552L,BigInteger.Parse("29548117155177824256"),BigInteger.Parse("448452706436800053248"),BigInteger.Parse("6490588908866265677824"),BigInteger.Parse("90173697372979200000000") };
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
public class A198404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198404Inst Instance=new A198404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198405
{
public static readonly BigInteger[] Value={ 2L,17L,377L,11473L,375273L,12456897L,414711897L,13814539697L,460231956937L,15333001667233L,510833776539193L,17018936996199057L,567002973887727017L,BigInteger.Parse("18890274083549781377"),BigInteger.Parse("629348476275500726297"),BigInteger.Parse("20967377362990867086193") };
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
public class A198405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198405Inst Instance=new A198405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198406
{
public static readonly BigInteger[] Value={ 17L,6986L,5057327L,3850206168L,2970439193698L,2302126761338667L,1786986687280410199L,BigInteger.Parse("1387873766175721022708"),BigInteger.Parse("1078103379003130131290922"),BigInteger.Parse("837527575449508082133268374"),BigInteger.Parse("650650234699083836241245595580") };
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
public class A198406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198406Inst Instance=new A198406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198407
{
public static readonly BigInteger[] Value={ 377L,5057327L,85013617830L,1506130430723528L,BigInteger.Parse("27330079651426584414") };
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
public class A198407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198407Inst Instance=new A198407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198408
{
public static readonly long[] Value={ 2L,17L,17L,377L,6986L,377L,11473L,5057327L,5057327L,11473L,375273L,3850206168L,85013617830L,3850206168L,375273L,12456897L,2970439193698L,1506130430723528L,1506130430723528L,2970439193698L,12456897L,414711897L,2302126761338667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198408Inst : IEnumerable<long>
{
public static readonly long[] Value=A198408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198408.Bytes);
public long this[int i]=>Value[i];

public static A198408Inst Instance=new A198408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198409
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,13L,15L,23L,24L,26L,30L,35L,39L,42L,45L,47L,51L,54L,62L,69L,70L,72L,83L,84L,88L,97L,98L,102L,107L,114L,115L,124L,126L,129L,136L,141L,142L,143L,156L,157L,167L,169L,172L,177L,181L,188L,191L,201L,205L,208L,214L,218L,229L,230L,237L,244L,249L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198409Inst : IEnumerable<long>
{
public static readonly long[] Value=A198409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198409.Bytes);
public long this[int i]=>Value[i];

public static A198409Inst Instance=new A198409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198410
{
public static readonly BigInteger[] Value={ 7L,37L,271L,2269L,19927L,177877L,1596511L,14355469L,129159847L,1162320517L,10460530351L,94143710269L,847290203767L,7625602267957L,68630391713791L,617673439330669L,5559060695695687L,50031545486420197L,450283907053258831L,4052555156505760669L,BigInteger.Parse("36472996387631139607") };
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
public class A198410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198410Inst Instance=new A198410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198411
{
public static readonly BigInteger[] Value={ 1L,3L,39L,9399L,613576119L,2635249154000645559L,BigInteger.Parse("48611766702991209068831621643639680439"),BigInteger.Parse("16541727033902313631938712144098272550515752433223071786131565516477842550199") };
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
public class A198411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198411Inst Instance=new A198411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198412
{
public static readonly BigInteger[] Value={ 0L,19L,15067L,11061667L,8068935979L,5882573095795L,4288416187929211L,3126256706670452803L,BigInteger.Parse("2279041222725643804363"),BigInteger.Parse("1661421056715018890883091"),BigInteger.Parse("1211175950687522343133931035"),BigInteger.Parse("882947268073109296732165817059"),BigInteger.Parse("643668558426698629867350806558827") };
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
public class A198412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198412Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198412.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198412Inst Instance=new A198412Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198413
{
public static readonly long[] Value={ 1L,1L,3L,11L,46L,205L,962L,4668L,23268L,118374L,612305L,3210348L,17023682L,91140496L,491968036L,2674572509L,14631157562L,80480706331L,444865534251L,2469826058736L,13766223517639L,77003660186990L,432131032213098L,2432230966070833L,13726899289265314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198413Inst : IEnumerable<long>
{
public static readonly long[] Value=A198413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198413.Bytes);
public long this[int i]=>Value[i];

public static A198413Inst Instance=new A198413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198414
{
public static readonly long[] Value={ 1L,4L,0L,4L,4L,1L,4L,8L,2L,4L,0L,9L,2L,4L,3L,4L,3L,6L,4L,1L,4L,8L,3L,2L,7L,9L,4L,3L,7L,4L,5L,7L,5L,8L,6L,0L,3L,7L,2L,5L,7L,1L,6L,1L,3L,7L,0L,4L,9L,1L,1L,4L,8L,1L,0L,9L,4L,4L,8L,2L,4L,3L,5L,4L,8L,7L,7L,5L,2L,5L,2L,9L,5L,6L,1L,7L,1L,4L,4L,3L,6L,2L,1L,2L,0L,5L,1L,0L,1L,5L,2L,4L,8L,2L,0L,8L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198414Inst : IEnumerable<long>
{
public static readonly long[] Value=A198414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198414.Bytes);
public long this[int i]=>Value[i];

public static A198414Inst Instance=new A198414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198415
{
public static readonly long[] Value={ 1L,7L,2L,2L,1L,2L,5L,1L,1L,2L,0L,7L,6L,7L,2L,3L,5L,9L,9L,4L,1L,5L,1L,4L,0L,0L,7L,3L,4L,7L,1L,7L,7L,4L,0L,5L,8L,1L,9L,0L,5L,0L,8L,1L,5L,5L,9L,3L,9L,2L,2L,3L,9L,8L,9L,2L,2L,2L,0L,0L,6L,0L,9L,5L,6L,8L,1L,2L,9L,5L,0L,8L,4L,2L,3L,2L,6L,5L,7L,5L,2L,2L,9L,7L,6L,8L,7L,4L,6L,9L,2L,0L,5L,2L,4L,9L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198415Inst : IEnumerable<long>
{
public static readonly long[] Value=A198415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198415.Bytes);
public long this[int i]=>Value[i];

public static A198415Inst Instance=new A198415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198416
{
public static readonly long[] Value={ 1L,9L,3L,3L,7L,5L,3L,7L,6L,2L,8L,2L,7L,0L,2L,1L,2L,5L,3L,3L,0L,8L,4L,7L,5L,6L,6L,9L,0L,9L,0L,6L,8L,0L,0L,5L,6L,5L,3L,7L,0L,9L,4L,1L,3L,7L,5L,9L,7L,6L,2L,1L,7L,2L,1L,8L,0L,2L,5L,6L,4L,4L,8L,1L,0L,5L,4L,9L,3L,2L,9L,4L,9L,5L,8L,0L,6L,4L,0L,7L,4L,6L,8L,7L,6L,4L,8L,0L,2L,2L,7L,0L,3L,2L,1L,4L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198416Inst : IEnumerable<long>
{
public static readonly long[] Value=A198416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198416.Bytes);
public long this[int i]=>Value[i];

public static A198416Inst Instance=new A198416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198417
{
public static readonly long[] Value={ 7L,9L,5L,5L,8L,9L,8L,7L,3L,4L,7L,3L,9L,2L,5L,1L,8L,1L,8L,0L,6L,2L,7L,3L,2L,5L,9L,0L,1L,3L,0L,3L,5L,9L,6L,1L,1L,2L,8L,1L,7L,1L,0L,6L,4L,5L,4L,6L,1L,3L,4L,7L,0L,5L,2L,9L,8L,3L,1L,3L,2L,8L,0L,2L,2L,5L,6L,5L,7L,5L,1L,8L,1L,3L,4L,1L,9L,2L,8L,4L,2L,3L,3L,9L,2L,4L,8L,3L,5L,1L,6L,8L,9L,4L,0L,1L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198417Inst : IEnumerable<long>
{
public static readonly long[] Value=A198417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198417.Bytes);
public long this[int i]=>Value[i];

public static A198417Inst Instance=new A198417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198418
{
public static readonly long[] Value={ 1L,2L,6L,3L,3L,2L,1L,4L,4L,7L,9L,4L,9L,3L,6L,9L,1L,0L,6L,6L,7L,0L,4L,7L,5L,9L,3L,4L,3L,3L,0L,0L,0L,6L,4L,8L,1L,5L,8L,0L,7L,3L,0L,2L,3L,6L,0L,5L,5L,4L,6L,4L,5L,5L,3L,1L,5L,7L,0L,4L,4L,8L,2L,1L,9L,1L,8L,3L,4L,2L,2L,1L,6L,9L,6L,0L,9L,0L,9L,8L,2L,0L,9L,4L,0L,7L,0L,9L,4L,6L,5L,9L,9L,5L,1L,8L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198418Inst : IEnumerable<long>
{
public static readonly long[] Value=A198418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198418.Bytes);
public long this[int i]=>Value[i];

public static A198418Inst Instance=new A198418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198419
{
public static readonly long[] Value={ 1L,5L,6L,1L,5L,1L,0L,9L,9L,1L,0L,7L,4L,2L,6L,9L,1L,2L,1L,8L,7L,3L,6L,8L,3L,2L,0L,7L,3L,7L,6L,9L,5L,2L,3L,2L,9L,2L,1L,5L,3L,4L,1L,6L,4L,4L,9L,4L,0L,3L,0L,7L,9L,1L,6L,9L,4L,8L,1L,2L,6L,9L,6L,6L,1L,9L,2L,4L,0L,2L,3L,0L,2L,1L,1L,8L,4L,8L,1L,0L,8L,5L,4L,8L,5L,7L,0L,4L,9L,4L,0L,4L,8L,4L,2L,0L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198419Inst : IEnumerable<long>
{
public static readonly long[] Value=A198419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198419.Bytes);
public long this[int i]=>Value[i];

public static A198419Inst Instance=new A198419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198420
{
public static readonly long[] Value={ 1L,6L,1L,7L,5L,4L,5L,2L,8L,6L,0L,6L,2L,2L,5L,4L,7L,5L,3L,0L,2L,7L,4L,2L,8L,8L,1L,3L,8L,2L,0L,5L,2L,5L,2L,8L,0L,1L,7L,6L,9L,9L,4L,7L,6L,1L,9L,0L,7L,9L,5L,9L,6L,1L,2L,7L,9L,9L,7L,8L,3L,0L,3L,8L,7L,7L,1L,4L,2L,0L,4L,6L,5L,4L,8L,3L,1L,3L,4L,0L,4L,8L,9L,6L,6L,5L,4L,4L,7L,1L,8L,4L,1L,9L,1L,5L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198420Inst : IEnumerable<long>
{
public static readonly long[] Value=A198420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198420.Bytes);
public long this[int i]=>Value[i];

public static A198420Inst Instance=new A198420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198421
{
public static readonly long[] Value={ 1L,9L,5L,1L,4L,8L,7L,5L,3L,4L,0L,9L,5L,6L,6L,9L,7L,7L,6L,5L,4L,7L,0L,7L,3L,8L,5L,1L,8L,7L,7L,5L,5L,4L,9L,1L,8L,5L,1L,6L,9L,3L,7L,9L,3L,3L,0L,4L,4L,3L,5L,5L,4L,6L,7L,3L,2L,4L,7L,1L,8L,3L,4L,2L,8L,0L,3L,8L,6L,4L,2L,7L,1L,9L,2L,2L,5L,1L,5L,2L,2L,5L,7L,3L,2L,2L,0L,9L,9L,7L,9L,1L,2L,9L,5L,7L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198421Inst : IEnumerable<long>
{
public static readonly long[] Value=A198421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198421.Bytes);
public long this[int i]=>Value[i];

public static A198421Inst Instance=new A198421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198422
{
public static readonly long[] Value={ 2L,1L,5L,7L,7L,0L,1L,7L,7L,1L,4L,4L,1L,4L,3L,8L,6L,1L,1L,4L,3L,7L,6L,7L,8L,7L,1L,1L,9L,7L,1L,7L,3L,1L,5L,7L,0L,5L,5L,1L,4L,9L,1L,5L,2L,3L,0L,5L,8L,2L,4L,4L,5L,3L,4L,0L,0L,6L,8L,6L,0L,4L,9L,8L,3L,9L,0L,7L,3L,3L,8L,1L,3L,2L,2L,6L,4L,6L,0L,5L,7L,5L,2L,0L,8L,3L,9L,3L,1L,9L,3L,6L,7L,7L,5L,1L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198422Inst : IEnumerable<long>
{
public static readonly long[] Value=A198422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198422.Bytes);
public long this[int i]=>Value[i];

public static A198422Inst Instance=new A198422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198423
{
public static readonly long[] Value={ 2L,2L,9L,8L,8L,5L,3L,5L,8L,2L,2L,7L,7L,4L,0L,3L,2L,9L,5L,2L,0L,6L,0L,5L,9L,1L,9L,6L,1L,5L,3L,4L,3L,3L,3L,5L,0L,8L,7L,3L,9L,3L,2L,2L,5L,2L,2L,3L,1L,3L,2L,3L,3L,0L,8L,3L,4L,5L,5L,7L,6L,0L,3L,5L,8L,5L,5L,5L,9L,6L,2L,5L,4L,0L,0L,2L,4L,3L,9L,7L,6L,8L,9L,5L,0L,6L,4L,7L,0L,4L,2L,0L,0L,8L,4L,0L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198423Inst : IEnumerable<long>
{
public static readonly long[] Value=A198423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198423.Bytes);
public long this[int i]=>Value[i];

public static A198423Inst Instance=new A198423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198424
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,3L,5L,6L,0L,7L,5L,7L,9L,3L,0L,7L,2L,4L,4L,4L,5L,2L,1L,2L,0L,8L,7L,1L,0L,2L,1L,6L,7L,4L,7L,7L,2L,9L,5L,5L,4L,8L,5L,0L,7L,7L,5L,8L,3L,8L,0L,7L,8L,1L,4L,0L,0L,7L,5L,1L,8L,7L,2L,5L,9L,5L,9L,5L,1L,7L,1L,0L,9L,0L,0L,2L,5L,4L,3L,5L,9L,1L,8L,9L,6L,5L,5L,3L,8L,8L,9L,9L,2L,1L,8L,7L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198424Inst : IEnumerable<long>
{
public static readonly long[] Value=A198424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198424.Bytes);
public long this[int i]=>Value[i];

public static A198424Inst Instance=new A198424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198425
{
public static readonly long[] Value={ 7L,3L,6L,2L,3L,2L,1L,5L,0L,5L,5L,4L,7L,4L,8L,1L,9L,9L,5L,6L,0L,8L,9L,1L,8L,9L,2L,5L,8L,9L,0L,7L,6L,8L,1L,2L,9L,9L,3L,9L,8L,0L,5L,8L,9L,5L,5L,1L,3L,2L,5L,8L,2L,5L,9L,0L,5L,4L,8L,4L,3L,5L,5L,0L,3L,2L,9L,7L,8L,8L,2L,6L,6L,0L,0L,4L,3L,1L,9L,8L,5L,8L,4L,3L,7L,3L,4L,7L,0L,0L,9L,1L,6L,4L,9L,3L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198425Inst : IEnumerable<long>
{
public static readonly long[] Value=A198425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198425.Bytes);
public long this[int i]=>Value[i];

public static A198425Inst Instance=new A198425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198426
{
public static readonly long[] Value={ 1L,1L,6L,0L,5L,9L,1L,8L,6L,7L,1L,9L,0L,0L,5L,4L,1L,5L,7L,3L,1L,3L,3L,0L,8L,2L,5L,0L,4L,3L,3L,0L,5L,5L,3L,3L,6L,3L,1L,7L,9L,7L,1L,3L,3L,9L,1L,5L,9L,1L,0L,6L,1L,2L,8L,3L,8L,4L,9L,9L,4L,1L,2L,5L,7L,6L,1L,4L,2L,2L,3L,4L,0L,0L,1L,8L,4L,9L,8L,2L,7L,4L,7L,9L,5L,0L,6L,5L,3L,9L,1L,8L,4L,9L,1L,6L,2L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198426Inst : IEnumerable<long>
{
public static readonly long[] Value=A198426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198426.Bytes);
public long this[int i]=>Value[i];

public static A198426Inst Instance=new A198426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198427
{
public static readonly long[] Value={ 2L,3L,1L,6L,9L,3L,4L,2L,8L,8L,6L,2L,3L,7L,3L,9L,7L,9L,1L,5L,2L,2L,7L,3L,2L,0L,4L,9L,8L,8L,7L,4L,4L,0L,9L,0L,5L,3L,7L,1L,8L,0L,2L,6L,1L,6L,1L,4L,7L,6L,2L,8L,3L,1L,6L,4L,4L,2L,7L,5L,0L,1L,7L,0L,9L,9L,7L,3L,1L,6L,6L,4L,6L,1L,7L,2L,2L,7L,3L,4L,1L,6L,1L,4L,2L,8L,7L,6L,2L,3L,6L,7L,7L,5L,8L,4L,8L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198427Inst : IEnumerable<long>
{
public static readonly long[] Value=A198427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198427.Bytes);
public long this[int i]=>Value[i];

public static A198427Inst Instance=new A198427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198428
{
public static readonly long[] Value={ 2L,4L,8L,8L,4L,2L,5L,2L,5L,9L,6L,5L,3L,5L,6L,6L,0L,1L,7L,4L,8L,7L,4L,9L,8L,4L,9L,4L,9L,3L,6L,1L,7L,9L,7L,1L,5L,4L,5L,0L,6L,5L,3L,5L,8L,9L,9L,6L,7L,9L,0L,2L,6L,4L,9L,4L,5L,5L,8L,5L,2L,6L,5L,1L,3L,6L,4L,2L,3L,8L,9L,5L,1L,6L,0L,2L,0L,1L,2L,7L,8L,7L,7L,4L,7L,4L,2L,4L,6L,9L,1L,2L,5L,4L,5L,6L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198428Inst : IEnumerable<long>
{
public static readonly long[] Value=A198428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198428.Bytes);
public long this[int i]=>Value[i];

public static A198428Inst Instance=new A198428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198429
{
public static readonly long[] Value={ 2L,5L,9L,7L,6L,5L,9L,6L,1L,1L,1L,6L,7L,3L,4L,8L,3L,5L,2L,7L,1L,9L,8L,6L,0L,8L,4L,6L,9L,3L,1L,7L,8L,3L,6L,0L,0L,8L,5L,5L,8L,8L,8L,4L,5L,7L,5L,1L,7L,1L,7L,1L,2L,2L,1L,7L,1L,2L,5L,0L,6L,4L,6L,3L,5L,0L,1L,6L,7L,0L,4L,6L,4L,6L,9L,9L,4L,8L,4L,6L,1L,4L,5L,4L,4L,8L,9L,2L,8L,4L,8L,7L,3L,2L,4L,1L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198429Inst : IEnumerable<long>
{
public static readonly long[] Value=A198429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198429.Bytes);
public long this[int i]=>Value[i];

public static A198429Inst Instance=new A198429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198430
{
public static readonly long[] Value={ 2L,6L,7L,4L,0L,9L,8L,0L,8L,7L,0L,5L,0L,6L,8L,0L,8L,5L,1L,5L,5L,3L,6L,3L,9L,3L,8L,9L,9L,9L,2L,3L,0L,5L,6L,7L,6L,6L,6L,6L,7L,1L,8L,7L,7L,3L,7L,0L,6L,6L,1L,7L,8L,6L,1L,1L,8L,9L,8L,0L,0L,4L,8L,2L,6L,7L,9L,1L,0L,9L,2L,4L,8L,8L,1L,6L,1L,5L,6L,5L,2L,8L,8L,4L,4L,1L,9L,3L,6L,8L,6L,8L,2L,5L,6L,9L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198430Inst : IEnumerable<long>
{
public static readonly long[] Value=A198430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198430.Bytes);
public long this[int i]=>Value[i];

public static A198430Inst Instance=new A198430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198431
{
public static readonly long[] Value={ 3L,0L,3L,5L,0L,4L,0L,8L,2L,2L,4L,3L,8L,0L,4L,8L,8L,4L,6L,8L,6L,7L,1L,2L,3L,0L,7L,0L,9L,6L,4L,8L,2L,3L,7L,8L,0L,6L,0L,1L,5L,8L,8L,8L,1L,0L,7L,1L,5L,5L,2L,2L,2L,8L,5L,3L,9L,0L,3L,6L,8L,9L,6L,4L,8L,2L,0L,9L,9L,4L,8L,0L,8L,1L,5L,2L,9L,5L,4L,8L,2L,9L,3L,9L,5L,3L,0L,9L,5L,9L,8L,8L,1L,8L,3L,3L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198431Inst : IEnumerable<long>
{
public static readonly long[] Value=A198431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198431.Bytes);
public long this[int i]=>Value[i];

public static A198431Inst Instance=new A198431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198432
{
public static readonly long[] Value={ 3L,0L,5L,5L,9L,6L,8L,7L,2L,7L,2L,1L,4L,7L,5L,7L,9L,0L,7L,5L,3L,9L,2L,8L,5L,6L,3L,7L,5L,4L,8L,4L,4L,3L,0L,6L,9L,8L,8L,3L,1L,3L,6L,3L,8L,9L,4L,4L,6L,8L,2L,4L,5L,3L,4L,4L,3L,9L,9L,9L,2L,5L,8L,0L,0L,2L,0L,5L,3L,0L,5L,9L,2L,0L,8L,9L,3L,3L,0L,5L,6L,7L,1L,1L,3L,5L,5L,9L,2L,5L,9L,0L,5L,6L,0L,9L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198432Inst : IEnumerable<long>
{
public static readonly long[] Value=A198432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198432.Bytes);
public long this[int i]=>Value[i];

public static A198432Inst Instance=new A198432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198433
{
public static readonly long[] Value={ 3L,0L,6L,9L,9L,5L,0L,1L,8L,6L,9L,4L,8L,3L,1L,3L,1L,4L,7L,4L,5L,5L,1L,1L,5L,7L,7L,3L,8L,8L,3L,1L,8L,1L,6L,1L,1L,2L,7L,4L,3L,7L,2L,7L,7L,8L,6L,8L,4L,8L,4L,5L,1L,0L,8L,4L,5L,3L,1L,7L,5L,0L,2L,0L,6L,7L,3L,1L,9L,3L,9L,3L,5L,5L,2L,4L,8L,2L,8L,9L,5L,7L,7L,5L,2L,0L,1L,0L,2L,3L,7L,1L,4L,6L,5L,3L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198433Inst : IEnumerable<long>
{
public static readonly long[] Value=A198433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198433.Bytes);
public long this[int i]=>Value[i];

public static A198433Inst Instance=new A198433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198434
{
public static readonly BigInteger[] Value={ 2L,10L,90L,966L,12338L,181470L,3018082L,55995486L,1146939010L,25716746430L,626755197698L,16502357651966L,466944932413442L,14133259249586174L,455715081098876418L,15596665064842012158UL,BigInteger.Parse("564724372634695925762"),BigInteger.Parse("21568978799171323200510"),BigInteger.Parse("866674159679235417061378"),BigInteger.Parse("36548294282449538711357438") };
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
public class A198434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198434Inst Instance=new A198434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198435
{
public static readonly long[] Value={ 1L,49L,49L,289L,1L,529L,961L,2401L,289L,2209L,529L,5041L,49L,1681L,1681L,6241L,9409L,49L,961L,5329L,16129L,14161L,7921L,289L,25921L,2209L,12769L,27889L,14161L,1L,39601L,2401L,5329L,10609L,25921L,49729L,58081L,529L,961L,10609L,7921L,36481L,82369L,22801L,47089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198435Inst : IEnumerable<long>
{
public static readonly long[] Value=A198435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198435.Bytes);
public long this[int i]=>Value[i];

public static A198435Inst Instance=new A198435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198436
{
public static readonly long[] Value={ 25L,169L,289L,625L,841L,1369L,1681L,3721L,2809L,4225L,4225L,7225L,5329L,7225L,7921L,10201L,12769L,9409L,11881L,15625L,21025L,21025L,22201L,18769L,32761L,24649L,29929L,38809L,34225L,28561L,48841L,34225L,37249L,42025L,52441L,66049L,70225L,42025L,48841L,54289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198436Inst : IEnumerable<long>
{
public static readonly long[] Value=A198436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198436.Bytes);
public long this[int i]=>Value[i];

public static A198436Inst Instance=new A198436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198437
{
public static readonly long[] Value={ 49L,289L,529L,961L,1681L,2209L,2401L,5041L,5329L,6241L,7921L,9409L,10609L,12769L,14161L,14161L,16129L,18769L,22801L,25921L,25921L,27889L,36481L,37249L,39601L,47089L,47089L,49729L,54289L,57121L,58081L,66049L,69169L,73441L,78961L,82369L,82369L,83521L,96721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198437Inst : IEnumerable<long>
{
public static readonly long[] Value=A198437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198437.Bytes);
public long this[int i]=>Value[i];

public static A198437Inst Instance=new A198437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198438
{
public static readonly long[] Value={ 24L,120L,240L,336L,840L,840L,720L,1320L,2520L,2016L,3696L,2184L,5280L,5544L,6240L,3960L,3360L,9360L,10920L,10296L,4896L,6864L,14280L,18480L,6840L,22440L,17160L,10920L,20064L,28560L,9240L,31824L,31920L,31416L,26520L,16320L,12144L,41496L,47880L,43680L,50160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198438Inst : IEnumerable<long>
{
public static readonly long[] Value=A198438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198438.Bytes);
public long this[int i]=>Value[i];

public static A198438Inst Instance=new A198438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198439
{
public static readonly long[] Value={ 1L,7L,7L,17L,1L,23L,31L,49L,17L,47L,23L,71L,7L,41L,41L,79L,97L,7L,31L,73L,127L,119L,89L,17L,161L,47L,113L,167L,119L,1L,199L,49L,73L,103L,161L,223L,241L,23L,31L,103L,89L,191L,287L,151L,217L,287L,137L,233L,71L,337L,79L,137L,17L,281L,359L,391L,49L,113L,119L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198439Inst : IEnumerable<long>
{
public static readonly long[] Value=A198439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198439.Bytes);
public long this[int i]=>Value[i];

public static A198439Inst Instance=new A198439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198440
{
public static readonly long[] Value={ 5L,13L,17L,25L,29L,37L,41L,61L,53L,65L,65L,85L,73L,85L,89L,101L,113L,97L,109L,125L,145L,145L,149L,137L,181L,157L,173L,197L,185L,169L,221L,185L,193L,205L,229L,257L,265L,205L,221L,233L,241L,269L,313L,265L,293L,325L,277L,317L,281L,365L,289L,305L,305L,365L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198440Inst : IEnumerable<long>
{
public static readonly long[] Value=A198440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198440.Bytes);
public long this[int i]=>Value[i];

public static A198440Inst Instance=new A198440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198441
{
public static readonly long[] Value={ 7L,17L,23L,31L,41L,47L,49L,71L,73L,79L,89L,97L,103L,113L,119L,119L,127L,137L,151L,161L,161L,167L,191L,193L,199L,217L,217L,223L,233L,239L,241L,257L,263L,271L,281L,287L,287L,289L,311L,313L,329L,329L,337L,343L,353L,359L,367L,383L,391L,391L,401L,409L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198441Inst : IEnumerable<long>
{
public static readonly long[] Value=A198441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198441.Bytes);
public long this[int i]=>Value[i];

public static A198441Inst Instance=new A198441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198442
{
public static readonly long[] Value={ 0L,0L,2L,3L,6L,8L,12L,15L,20L,24L,30L,35L,42L,48L,56L,63L,72L,80L,90L,99L,110L,120L,132L,143L,156L,168L,182L,195L,210L,224L,240L,255L,272L,288L,306L,323L,342L,360L,380L,399L,420L,440L,462L,483L,506L,528L,552L,575L,600L,624L,650L,675L,702L,728L,756L,783L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198442Inst : IEnumerable<long>
{
public static readonly long[] Value=A198442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198442.Bytes);
public long this[int i]=>Value[i];

public static A198442Inst Instance=new A198442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198443
{
public static readonly long[] Value={ 3L,4L,11L,26L,37L,368L,1828L,2180L,7825L,8177L,8217L,71393L,72481L,75154L,118409L,175485L,203697L,206370L,1049148L,1058224L,1843945L,1846618L,8186369L,8197633L,9600802L,96020524L,169503449L,294638801L,305158594L,305192969L,657099024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198443Inst : IEnumerable<long>
{
public static readonly long[] Value=A198443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198443.Bytes);
public long this[int i]=>Value[i];

public static A198443Inst Instance=new A198443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198444
{
public static readonly long[] Value={ 1L,2L,5L,23L,27L,73L,96L,104L,396L,404L,432L,686L,723L,735L,1130L,1159L,2019L,2031L,3861L,5310L,18219L,18231L,25592L,25608L,44367L,200141L,213842L,308228L,390615L,390635L,549976L,631544L,1579129L,1657086L,2941211L,2941239L,5523608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198444Inst : IEnumerable<long>
{
public static readonly long[] Value=A198444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198444.Bytes);
public long this[int i]=>Value[i];

public static A198444Inst Instance=new A198444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198445
{
public static readonly long[] Value={ 2L,6L,56L,2537L,3788L,45531L,90298L,110302L,3120599L,3280601L,3878907L,12325663L,14055482L,14645977L,42923597L,45730778L,183164286L,185898039L,926295393L,2054642668L,44803437862L,44877249113L,104775699199L,104939539201L,414619915847L,17920089051165L,21146208937291L,52744869326263L,95361328242187L,9537353527343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198445Inst : IEnumerable<long>
{
public static readonly long[] Value=A198445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198445.Bytes);
public long this[int i]=>Value[i];

public static A198445Inst Instance=new A198445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198446
{
public static readonly long[] Value={ 3L,177L,26704L,13048509L,22496409154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198446Inst : IEnumerable<long>
{
public static readonly long[] Value=A198446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198446.Bytes);
public long this[int i]=>Value[i];

public static A198446Inst Instance=new A198446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198447
{
public static readonly long[] Value={ 3L,13L,71L,433L,2763L,17941L,117263L,768313L,5038611L,33054493L,216872663L,1422982081L,9336876123L,61264171813L,401987528351L,2637661006153L,17307148601763L,113561761317421L,745141474228583L,4889285086978513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198447Inst : IEnumerable<long>
{
public static readonly long[] Value=A198447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198447.Bytes);
public long this[int i]=>Value[i];

public static A198447Inst Instance=new A198447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198448
{
public static readonly long[] Value={ 13L,177L,1399L,14109L,146187L,1532249L,16411255L,176845253L,1916108803L,20825391089L,226732488271L,2471217945565L,26951222470875L,294040889182217L,3208725606852775L,35019790320698997L,382232607221676979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198448Inst : IEnumerable<long>
{
public static readonly long[] Value=A198448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198448.Bytes);
public long this[int i]=>Value[i];

public static A198448Inst Instance=new A198448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198449
{
public static readonly BigInteger[] Value={ 71L,1399L,26704L,421185L,7302285L,128955464L,2298267371L,41395566911L,751621555932L,13730905146849L,252013755082625L,4641945567249588L,85732037231734899L,1586580667067965067L,BigInteger.Parse("29406033308587639544") };
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
public class A198449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198449Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198449.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198449Inst Instance=new A198449Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198450
{
public static readonly BigInteger[] Value={ 433L,14109L,421185L,13048509L,396482929L,12354617337L,388054368497L,12268223577717L,389802133342121L,12442366745406193L,398756914767870161L,12824613775169911957UL,BigInteger.Parse("413731612612141327185"),BigInteger.Parse("13383113394670397174673") };
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
public class A198450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198450Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198450.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198450.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198450Inst Instance=new A198450Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198451
{
public static readonly long[] Value={ 2763L,146187L,7302285L,396482929L,22496409154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198451Inst : IEnumerable<long>
{
public static readonly long[] Value=A198451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198451.Bytes);
public long this[int i]=>Value[i];

public static A198451Inst Instance=new A198451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198452
{
public static readonly long[] Value={ 3L,13L,13L,71L,177L,71L,433L,1399L,1399L,433L,2763L,14109L,26704L,14109L,2763L,17941L,146187L,421185L,421185L,146187L,17941L,117263L,1532249L,7302285L,13048509L,7302285L,1532249L,117263L,768313L,16411255L,128955464L,396482929L,396482929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198452Inst : IEnumerable<long>
{
public static readonly long[] Value=A198452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198452.Bytes);
public long this[int i]=>Value[i];

public static A198452Inst Instance=new A198452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198453
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,6L,4L,9L,10L,5L,6L,8L,5L,14L,15L,6L,9L,11L,6L,20L,21L,7L,27L,28L,8L,10L,13L,8L,35L,36L,9L,13L,16L,9L,21L,23L,9L,44L,45L,10L,26L,28L,10L,54L,55L,11L,14L,18L,11L,20L,23L,11L,65L,66L,12L,17L,21L,12L,24L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198453Inst : IEnumerable<long>
{
public static readonly long[] Value=A198453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198453.Bytes);
public long this[int i]=>Value[i];

public static A198453Inst Instance=new A198453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198454
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,23L,23L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198454Inst : IEnumerable<long>
{
public static readonly long[] Value=A198454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198454.Bytes);
public long this[int i]=>Value[i];

public static A198454Inst Instance=new A198454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198455
{
public static readonly long[] Value={ 2L,5L,9L,6L,14L,9L,20L,27L,10L,35L,13L,21L,44L,26L,54L,14L,20L,65L,17L,24L,77L,44L,90L,14L,18L,33L,51L,104L,21L,38L,119L,135L,22L,49L,75L,152L,25L,55L,84L,170L,35L,45L,189L,26L,39L,50L,68L,209L,29L,35L,75L,114L,230L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198455Inst : IEnumerable<long>
{
public static readonly long[] Value=A198455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198455.Bytes);
public long this[int i]=>Value[i];

public static A198455Inst Instance=new A198455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198456
{
public static readonly long[] Value={ 3L,6L,10L,8L,15L,11L,21L,28L,13L,36L,16L,23L,45L,28L,55L,18L,23L,66L,21L,27L,78L,46L,91L,20L,23L,36L,53L,105L,26L,41L,120L,136L,28L,52L,77L,153L,31L,58L,86L,171L,40L,49L,190L,33L,44L,54L,71L,210L,36L,41L,78L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198456Inst : IEnumerable<long>
{
public static readonly long[] Value=A198456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198456.Bytes);
public long this[int i]=>Value[i];

public static A198456Inst Instance=new A198456Inst();

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