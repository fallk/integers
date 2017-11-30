using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040496
{
public static readonly long[] Value={ 22L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L,1L,3L,1L,1L,2L,1L,2L,3L,7L,3L,2L,1L,2L,1L,1L,3L,1L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040496Inst : IEnumerable<long>
{
public static readonly long[] Value=A040496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040496.Bytes);
public long this[int i]=>Value[i];

public static A040496Inst Instance=new A040496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040497
{
public static readonly long[] Value={ 22L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L,11L,4L,1L,44L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040497Inst : IEnumerable<long>
{
public static readonly long[] Value=A040497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040497.Bytes);
public long this[int i]=>Value[i];

public static A040497Inst Instance=new A040497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040498
{
public static readonly long[] Value={ 22L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L,2L,1L,4L,1L,44L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L,2L,1L,4L,1L,44L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L,2L,1L,4L,1L,44L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L,2L,1L,4L,1L,44L,1L,4L,1L,2L,1L,2L,8L,1L,3L,3L,1L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040498Inst : IEnumerable<long>
{
public static readonly long[] Value=A040498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040498.Bytes);
public long this[int i]=>Value[i];

public static A040498Inst Instance=new A040498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040499
{
public static readonly long[] Value={ 22L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L,44L,1L,5L,1L,1L,4L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040499Inst : IEnumerable<long>
{
public static readonly long[] Value=A040499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040499.Bytes);
public long this[int i]=>Value[i];

public static A040499Inst Instance=new A040499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040500
{
public static readonly long[] Value={ 22L,1L,6L,1L,1L,1L,4L,2L,3L,14L,1L,21L,1L,14L,3L,2L,4L,1L,1L,1L,6L,1L,44L,1L,6L,1L,1L,1L,4L,2L,3L,14L,1L,21L,1L,14L,3L,2L,4L,1L,1L,1L,6L,1L,44L,1L,6L,1L,1L,1L,4L,2L,3L,14L,1L,21L,1L,14L,3L,2L,4L,1L,1L,1L,6L,1L,44L,1L,6L,1L,1L,1L,4L,2L,3L,14L,1L,21L,1L,14L,3L,2L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040500Inst : IEnumerable<long>
{
public static readonly long[] Value=A040500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040500.Bytes);
public long this[int i]=>Value[i];

public static A040500Inst Instance=new A040500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040501
{
public static readonly long[] Value={ 22L,1L,8L,5L,1L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,1L,5L,8L,1L,44L,1L,8L,5L,1L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,1L,5L,8L,1L,44L,1L,8L,5L,1L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,1L,5L,8L,1L,44L,1L,8L,5L,1L,1L,1L,1L,2L,1L,10L,1L,2L,1L,1L,1L,1L,5L,8L,1L,44L,1L,8L,5L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040501Inst : IEnumerable<long>
{
public static readonly long[] Value=A040501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040501.Bytes);
public long this[int i]=>Value[i];

public static A040501Inst Instance=new A040501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040502
{
public static readonly long[] Value={ 22L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L,2L,10L,1L,44L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040502Inst : IEnumerable<long>
{
public static readonly long[] Value=A040502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040502.Bytes);
public long this[int i]=>Value[i];

public static A040502Inst Instance=new A040502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040503
{
public static readonly long[] Value={ 22L,1L,14L,3L,4L,1L,3L,2L,1L,3L,1L,8L,2L,1L,1L,2L,2L,6L,7L,2L,22L,2L,7L,6L,2L,2L,1L,1L,2L,8L,1L,3L,1L,2L,3L,1L,4L,3L,14L,1L,44L,1L,14L,3L,4L,1L,3L,2L,1L,3L,1L,8L,2L,1L,1L,2L,2L,6L,7L,2L,22L,2L,7L,6L,2L,2L,1L,1L,2L,8L,1L,3L,1L,2L,3L,1L,4L,3L,14L,1L,44L,1L,14L,3L,4L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040503Inst : IEnumerable<long>
{
public static readonly long[] Value=A040503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040503.Bytes);
public long this[int i]=>Value[i];

public static A040503Inst Instance=new A040503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040504
{
public static readonly long[] Value={ 22L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L,1L,44L,1L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040504Inst : IEnumerable<long>
{
public static readonly long[] Value=A040504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040504.Bytes);
public long this[int i]=>Value[i];

public static A040504Inst Instance=new A040504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040505
{
public static readonly long[] Value={ 22L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L,1L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040505Inst : IEnumerable<long>
{
public static readonly long[] Value=A040505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040505.Bytes);
public long this[int i]=>Value[i];

public static A040505Inst Instance=new A040505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040506
{
public static readonly long[] Value={ 23L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040506Inst : IEnumerable<long>
{
public static readonly long[] Value=A040506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040506.Bytes);
public long this[int i]=>Value[i];

public static A040506Inst Instance=new A040506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040507
{
public static readonly long[] Value={ 23L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L,23L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040507Inst : IEnumerable<long>
{
public static readonly long[] Value=A040507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040507.Bytes);
public long this[int i]=>Value[i];

public static A040507Inst Instance=new A040507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040508
{
public static readonly long[] Value={ 23L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L,15L,2L,1L,4L,2L,4L,1L,2L,15L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040508Inst : IEnumerable<long>
{
public static readonly long[] Value=A040508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040508.Bytes);
public long this[int i]=>Value[i];

public static A040508Inst Instance=new A040508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040573
{
public static readonly long[] Value={ 24L,2L,4L,1L,15L,2L,15L,1L,4L,2L,48L,2L,4L,1L,15L,2L,15L,1L,4L,2L,48L,2L,4L,1L,15L,2L,15L,1L,4L,2L,48L,2L,4L,1L,15L,2L,15L,1L,4L,2L,48L,2L,4L,1L,15L,2L,15L,1L,4L,2L,48L,2L,4L,1L,15L,2L,15L,1L,4L,2L,48L,2L,4L,1L,15L,2L,15L,1L,4L,2L,48L,2L,4L,1L,15L,2L,15L,1L,4L,2L,48L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040573Inst : IEnumerable<long>
{
public static readonly long[] Value=A040573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040573.Bytes);
public long this[int i]=>Value[i];

public static A040573Inst Instance=new A040573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040574
{
public static readonly long[] Value={ 24L,2L,9L,3L,2L,1L,1L,3L,1L,6L,4L,1L,2L,1L,23L,1L,2L,1L,4L,6L,1L,3L,1L,1L,2L,3L,9L,2L,48L,2L,9L,3L,2L,1L,1L,3L,1L,6L,4L,1L,2L,1L,23L,1L,2L,1L,4L,6L,1L,3L,1L,1L,2L,3L,9L,2L,48L,2L,9L,3L,2L,1L,1L,3L,1L,6L,4L,1L,2L,1L,23L,1L,2L,1L,4L,6L,1L,3L,1L,1L,2L,3L,9L,2L,48L,2L,9L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040574Inst : IEnumerable<long>
{
public static readonly long[] Value=A040574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040574.Bytes);
public long this[int i]=>Value[i];

public static A040574Inst Instance=new A040574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040575
{
public static readonly long[] Value={ 24L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L,2L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040575Inst : IEnumerable<long>
{
public static readonly long[] Value=A040575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040575.Bytes);
public long this[int i]=>Value[i];

public static A040575Inst Instance=new A040575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040576
{
public static readonly long[] Value={ 24L,1L,1L,15L,1L,5L,5L,3L,1L,1L,2L,1L,2L,2L,1L,9L,9L,1L,2L,2L,1L,2L,1L,1L,3L,5L,5L,1L,15L,1L,1L,48L,1L,1L,15L,1L,5L,5L,3L,1L,1L,2L,1L,2L,2L,1L,9L,9L,1L,2L,2L,1L,2L,1L,1L,3L,5L,5L,1L,15L,1L,1L,48L,1L,1L,15L,1L,5L,5L,3L,1L,1L,2L,1L,2L,2L,1L,9L,9L,1L,2L,2L,1L,2L,1L,1L,3L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040576Inst : IEnumerable<long>
{
public static readonly long[] Value=A040576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040576.Bytes);
public long this[int i]=>Value[i];

public static A040576Inst Instance=new A040576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040577
{
public static readonly long[] Value={ 24L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L,6L,1L,1L,48L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040577Inst : IEnumerable<long>
{
public static readonly long[] Value=A040577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040577.Bytes);
public long this[int i]=>Value[i];

public static A040577Inst Instance=new A040577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040578
{
public static readonly long[] Value={ 24L,1L,1L,3L,1L,23L,1L,3L,1L,1L,48L,1L,1L,3L,1L,23L,1L,3L,1L,1L,48L,1L,1L,3L,1L,23L,1L,3L,1L,1L,48L,1L,1L,3L,1L,23L,1L,3L,1L,1L,48L,1L,1L,3L,1L,23L,1L,3L,1L,1L,48L,1L,1L,3L,1L,23L,1L,3L,1L,1L,48L,1L,1L,3L,1L,23L,1L,3L,1L,1L,48L,1L,1L,3L,1L,23L,1L,3L,1L,1L,48L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040578Inst : IEnumerable<long>
{
public static readonly long[] Value=A040578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040578.Bytes);
public long this[int i]=>Value[i];

public static A040578Inst Instance=new A040578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040579
{
public static readonly long[] Value={ 24L,1L,1L,2L,1L,3L,2L,1L,1L,1L,1L,1L,4L,1L,5L,3L,9L,1L,1L,15L,1L,6L,12L,6L,1L,15L,1L,1L,9L,3L,5L,1L,4L,1L,1L,1L,1L,1L,2L,3L,1L,2L,1L,1L,48L,1L,1L,2L,1L,3L,2L,1L,1L,1L,1L,1L,4L,1L,5L,3L,9L,1L,1L,15L,1L,6L,12L,6L,1L,15L,1L,1L,9L,3L,5L,1L,4L,1L,1L,1L,1L,1L,2L,3L,1L,2L,1L,1L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040579Inst : IEnumerable<long>
{
public static readonly long[] Value=A040579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040579.Bytes);
public long this[int i]=>Value[i];

public static A040579Inst Instance=new A040579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040580
{
public static readonly long[] Value={ 24L,1L,1L,2L,11L,1L,8L,1L,11L,2L,1L,1L,48L,1L,1L,2L,11L,1L,8L,1L,11L,2L,1L,1L,48L,1L,1L,2L,11L,1L,8L,1L,11L,2L,1L,1L,48L,1L,1L,2L,11L,1L,8L,1L,11L,2L,1L,1L,48L,1L,1L,2L,11L,1L,8L,1L,11L,2L,1L,1L,48L,1L,1L,2L,11L,1L,8L,1L,11L,2L,1L,1L,48L,1L,1L,2L,11L,1L,8L,1L,11L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040580Inst : IEnumerable<long>
{
public static readonly long[] Value=A040580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040580.Bytes);
public long this[int i]=>Value[i];

public static A040580Inst Instance=new A040580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040581
{
public static readonly long[] Value={ 24L,1L,1L,1L,1L,1L,1L,2L,1L,9L,8L,9L,1L,2L,1L,1L,1L,1L,1L,1L,48L,1L,1L,1L,1L,1L,1L,2L,1L,9L,8L,9L,1L,2L,1L,1L,1L,1L,1L,1L,48L,1L,1L,1L,1L,1L,1L,2L,1L,9L,8L,9L,1L,2L,1L,1L,1L,1L,1L,1L,48L,1L,1L,1L,1L,1L,1L,2L,1L,9L,8L,9L,1L,2L,1L,1L,1L,1L,1L,1L,48L,1L,1L,1L,1L,1L,1L,2L,1L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040581Inst : IEnumerable<long>
{
public static readonly long[] Value=A040581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040581.Bytes);
public long this[int i]=>Value[i];

public static A040581Inst Instance=new A040581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040582
{
public static readonly long[] Value={ 24L,1L,1L,1L,3L,7L,1L,15L,1L,1L,4L,1L,23L,1L,4L,1L,1L,15L,1L,7L,3L,1L,1L,1L,48L,1L,1L,1L,3L,7L,1L,15L,1L,1L,4L,1L,23L,1L,4L,1L,1L,15L,1L,7L,3L,1L,1L,1L,48L,1L,1L,1L,3L,7L,1L,15L,1L,1L,4L,1L,23L,1L,4L,1L,1L,15L,1L,7L,3L,1L,1L,1L,48L,1L,1L,1L,3L,7L,1L,15L,1L,1L,4L,1L,23L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040582Inst : IEnumerable<long>
{
public static readonly long[] Value=A040582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040582.Bytes);
public long this[int i]=>Value[i];

public static A040582Inst Instance=new A040582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040583
{
public static readonly long[] Value={ 24L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L,11L,1L,1L,1L,48L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040583Inst : IEnumerable<long>
{
public static readonly long[] Value=A040583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040583.Bytes);
public long this[int i]=>Value[i];

public static A040583Inst Instance=new A040583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040584
{
public static readonly long[] Value={ 24L,1L,2L,9L,1L,1L,6L,1L,1L,9L,2L,1L,48L,1L,2L,9L,1L,1L,6L,1L,1L,9L,2L,1L,48L,1L,2L,9L,1L,1L,6L,1L,1L,9L,2L,1L,48L,1L,2L,9L,1L,1L,6L,1L,1L,9L,2L,1L,48L,1L,2L,9L,1L,1L,6L,1L,1L,9L,2L,1L,48L,1L,2L,9L,1L,1L,6L,1L,1L,9L,2L,1L,48L,1L,2L,9L,1L,1L,6L,1L,1L,9L,2L,1L,48L,1L,2L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040584Inst : IEnumerable<long>
{
public static readonly long[] Value=A040584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040584.Bytes);
public long this[int i]=>Value[i];

public static A040584Inst Instance=new A040584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040585
{
public static readonly long[] Value={ 24L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L,1L,48L,1L,2L,3L,5L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040585Inst : IEnumerable<long>
{
public static readonly long[] Value=A040585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040585.Bytes);
public long this[int i]=>Value[i];

public static A040585Inst Instance=new A040585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040586
{
public static readonly long[] Value={ 24L,1L,2L,1L,1L,4L,2L,1L,2L,4L,1L,1L,2L,1L,48L,1L,2L,1L,1L,4L,2L,1L,2L,4L,1L,1L,2L,1L,48L,1L,2L,1L,1L,4L,2L,1L,2L,4L,1L,1L,2L,1L,48L,1L,2L,1L,1L,4L,2L,1L,2L,4L,1L,1L,2L,1L,48L,1L,2L,1L,1L,4L,2L,1L,2L,4L,1L,1L,2L,1L,48L,1L,2L,1L,1L,4L,2L,1L,2L,4L,1L,1L,2L,1L,48L,1L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040586Inst : IEnumerable<long>
{
public static readonly long[] Value=A040586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040586.Bytes);
public long this[int i]=>Value[i];

public static A040586Inst Instance=new A040586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040587
{
public static readonly long[] Value={ 24L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L,48L,1L,2L,1L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040587Inst : IEnumerable<long>
{
public static readonly long[] Value=A040587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040587.Bytes);
public long this[int i]=>Value[i];

public static A040587Inst Instance=new A040587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040588
{
public static readonly long[] Value={ 24L,1L,3L,6L,1L,4L,1L,1L,1L,3L,2L,11L,1L,15L,1L,1L,2L,2L,1L,1L,15L,1L,11L,2L,3L,1L,1L,1L,4L,1L,6L,3L,1L,48L,1L,3L,6L,1L,4L,1L,1L,1L,3L,2L,11L,1L,15L,1L,1L,2L,2L,1L,1L,15L,1L,11L,2L,3L,1L,1L,1L,4L,1L,6L,3L,1L,48L,1L,3L,6L,1L,4L,1L,1L,1L,3L,2L,11L,1L,15L,1L,1L,2L,2L,1L,1L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040588Inst : IEnumerable<long>
{
public static readonly long[] Value=A040588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040588.Bytes);
public long this[int i]=>Value[i];

public static A040588Inst Instance=new A040588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040621
{
public static readonly long[] Value={ 25L,2L,3L,2L,2L,1L,1L,4L,25L,4L,1L,1L,2L,2L,3L,2L,50L,2L,3L,2L,2L,1L,1L,4L,25L,4L,1L,1L,2L,2L,3L,2L,50L,2L,3L,2L,2L,1L,1L,4L,25L,4L,1L,1L,2L,2L,3L,2L,50L,2L,3L,2L,2L,1L,1L,4L,25L,4L,1L,1L,2L,2L,3L,2L,50L,2L,3L,2L,2L,1L,1L,4L,25L,4L,1L,1L,2L,2L,3L,2L,50L,2L,3L,2L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040621Inst : IEnumerable<long>
{
public static readonly long[] Value=A040621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040621.Bytes);
public long this[int i]=>Value[i];

public static A040621Inst Instance=new A040621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040622
{
public static readonly long[] Value={ 25L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L,6L,5L,2L,50L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040622Inst : IEnumerable<long>
{
public static readonly long[] Value=A040622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040622.Bytes);
public long this[int i]=>Value[i];

public static A040622Inst Instance=new A040622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040623
{
public static readonly long[] Value={ 25L,2L,9L,1L,2L,3L,1L,1L,2L,1L,4L,1L,16L,6L,3L,4L,3L,6L,16L,1L,4L,1L,2L,1L,1L,3L,2L,1L,9L,2L,50L,2L,9L,1L,2L,3L,1L,1L,2L,1L,4L,1L,16L,6L,3L,4L,3L,6L,16L,1L,4L,1L,2L,1L,1L,3L,2L,1L,9L,2L,50L,2L,9L,1L,2L,3L,1L,1L,2L,1L,4L,1L,16L,6L,3L,4L,3L,6L,16L,1L,4L,1L,2L,1L,1L,3L,2L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040623Inst : IEnumerable<long>
{
public static readonly long[] Value=A040623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040623.Bytes);
public long this[int i]=>Value[i];

public static A040623Inst Instance=new A040623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040624
{
public static readonly long[] Value={ 25L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L,2L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040624Inst : IEnumerable<long>
{
public static readonly long[] Value=A040624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040624.Bytes);
public long this[int i]=>Value[i];

public static A040624Inst Instance=new A040624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040625
{
public static readonly long[] Value={ 25L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L,16L,1L,1L,50L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040625Inst : IEnumerable<long>
{
public static readonly long[] Value=A040625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040625.Bytes);
public long this[int i]=>Value[i];

public static A040625Inst Instance=new A040625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040626
{
public static readonly long[] Value={ 25L,1L,1L,6L,1L,3L,1L,3L,2L,5L,1L,16L,5L,1L,1L,1L,1L,2L,12L,2L,1L,1L,1L,1L,5L,16L,1L,5L,2L,3L,1L,3L,1L,6L,1L,1L,50L,1L,1L,6L,1L,3L,1L,3L,2L,5L,1L,16L,5L,1L,1L,1L,1L,2L,12L,2L,1L,1L,1L,1L,5L,16L,1L,5L,2L,3L,1L,3L,1L,6L,1L,1L,50L,1L,1L,6L,1L,3L,1L,3L,2L,5L,1L,16L,5L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040626Inst : IEnumerable<long>
{
public static readonly long[] Value=A040626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040626.Bytes);
public long this[int i]=>Value[i];

public static A040626Inst Instance=new A040626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040627
{
public static readonly long[] Value={ 25L,1L,1L,4L,7L,12L,1L,1L,1L,3L,3L,1L,1L,1L,12L,7L,4L,1L,1L,50L,1L,1L,4L,7L,12L,1L,1L,1L,3L,3L,1L,1L,1L,12L,7L,4L,1L,1L,50L,1L,1L,4L,7L,12L,1L,1L,1L,3L,3L,1L,1L,1L,12L,7L,4L,1L,1L,50L,1L,1L,4L,7L,12L,1L,1L,1L,3L,3L,1L,1L,1L,12L,7L,4L,1L,1L,50L,1L,1L,4L,7L,12L,1L,1L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040627Inst : IEnumerable<long>
{
public static readonly long[] Value=A040627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040627.Bytes);
public long this[int i]=>Value[i];

public static A040627Inst Instance=new A040627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040628
{
public static readonly long[] Value={ 25L,1L,1L,2L,1L,9L,1L,1L,16L,1L,1L,9L,1L,2L,1L,1L,50L,1L,1L,2L,1L,9L,1L,1L,16L,1L,1L,9L,1L,2L,1L,1L,50L,1L,1L,2L,1L,9L,1L,1L,16L,1L,1L,9L,1L,2L,1L,1L,50L,1L,1L,2L,1L,9L,1L,1L,16L,1L,1L,9L,1L,2L,1L,1L,50L,1L,1L,2L,1L,9L,1L,1L,16L,1L,1L,9L,1L,2L,1L,1L,50L,1L,1L,2L,1L,9L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040628Inst : IEnumerable<long>
{
public static readonly long[] Value=A040628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040628.Bytes);
public long this[int i]=>Value[i];

public static A040628Inst Instance=new A040628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040629
{
public static readonly long[] Value={ 25L,1L,1L,2L,5L,3L,2L,8L,10L,8L,2L,3L,5L,2L,1L,1L,50L,1L,1L,2L,5L,3L,2L,8L,10L,8L,2L,3L,5L,2L,1L,1L,50L,1L,1L,2L,5L,3L,2L,8L,10L,8L,2L,3L,5L,2L,1L,1L,50L,1L,1L,2L,5L,3L,2L,8L,10L,8L,2L,3L,5L,2L,1L,1L,50L,1L,1L,2L,5L,3L,2L,8L,10L,8L,2L,3L,5L,2L,1L,1L,50L,1L,1L,2L,5L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040629Inst : IEnumerable<long>
{
public static readonly long[] Value=A040629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040629.Bytes);
public long this[int i]=>Value[i];

public static A040629Inst Instance=new A040629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040630
{
public static readonly long[] Value={ 25L,1L,1L,1L,1L,2L,1L,1L,1L,1L,50L,1L,1L,1L,1L,2L,1L,1L,1L,1L,50L,1L,1L,1L,1L,2L,1L,1L,1L,1L,50L,1L,1L,1L,1L,2L,1L,1L,1L,1L,50L,1L,1L,1L,1L,2L,1L,1L,1L,1L,50L,1L,1L,1L,1L,2L,1L,1L,1L,1L,50L,1L,1L,1L,1L,2L,1L,1L,1L,1L,50L,1L,1L,1L,1L,2L,1L,1L,1L,1L,50L,1L,1L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040630Inst : IEnumerable<long>
{
public static readonly long[] Value=A040630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040630.Bytes);
public long this[int i]=>Value[i];

public static A040630Inst Instance=new A040630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040631
{
public static readonly long[] Value={ 25L,1L,1L,1L,2L,1L,1L,5L,1L,4L,1L,5L,1L,1L,2L,1L,1L,1L,50L,1L,1L,1L,2L,1L,1L,5L,1L,4L,1L,5L,1L,1L,2L,1L,1L,1L,50L,1L,1L,1L,2L,1L,1L,5L,1L,4L,1L,5L,1L,1L,2L,1L,1L,1L,50L,1L,1L,1L,2L,1L,1L,5L,1L,4L,1L,5L,1L,1L,2L,1L,1L,1L,50L,1L,1L,1L,2L,1L,1L,5L,1L,4L,1L,5L,1L,1L,2L,1L,1L,1L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040631Inst : IEnumerable<long>
{
public static readonly long[] Value=A040631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040631.Bytes);
public long this[int i]=>Value[i];

public static A040631Inst Instance=new A040631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040632
{
public static readonly long[] Value={ 25L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L,50L,1L,1L,1L,6L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040632Inst : IEnumerable<long>
{
public static readonly long[] Value=A040632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040632.Bytes);
public long this[int i]=>Value[i];

public static A040632Inst Instance=new A040632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040633
{
public static readonly long[] Value={ 25L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L,25L,2L,1L,50L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040633Inst : IEnumerable<long>
{
public static readonly long[] Value=A040633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040633.Bytes);
public long this[int i]=>Value[i];

public static A040633Inst Instance=new A040633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040634
{
public static readonly long[] Value={ 25L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L,4L,2L,1L,50L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040634Inst : IEnumerable<long>
{
public static readonly long[] Value=A040634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040634.Bytes);
public long this[int i]=>Value[i];

public static A040634Inst Instance=new A040634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040635
{
public static readonly long[] Value={ 25L,1L,2L,2L,4L,4L,16L,1L,9L,2L,1L,12L,5L,1L,1L,1L,2L,1L,3L,1L,1L,3L,1L,2L,1L,1L,1L,5L,12L,1L,2L,9L,1L,16L,4L,4L,2L,2L,1L,50L,1L,2L,2L,4L,4L,16L,1L,9L,2L,1L,12L,5L,1L,1L,1L,2L,1L,3L,1L,1L,3L,1L,2L,1L,1L,1L,5L,12L,1L,2L,9L,1L,16L,4L,4L,2L,2L,1L,50L,1L,2L,2L,4L,4L,16L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040635Inst : IEnumerable<long>
{
public static readonly long[] Value=A040635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040635.Bytes);
public long this[int i]=>Value[i];

public static A040635Inst Instance=new A040635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040636
{
public static readonly long[] Value={ 25L,1L,2L,1L,2L,3L,1L,1L,2L,6L,1L,24L,1L,6L,2L,1L,1L,3L,2L,1L,2L,1L,50L,1L,2L,1L,2L,3L,1L,1L,2L,6L,1L,24L,1L,6L,2L,1L,1L,3L,2L,1L,2L,1L,50L,1L,2L,1L,2L,3L,1L,1L,2L,6L,1L,24L,1L,6L,2L,1L,1L,3L,2L,1L,2L,1L,50L,1L,2L,1L,2L,3L,1L,1L,2L,6L,1L,24L,1L,6L,2L,1L,1L,3L,2L,1L,2L,1L,50L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040636Inst : IEnumerable<long>
{
public static readonly long[] Value=A040636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040636.Bytes);
public long this[int i]=>Value[i];

public static A040636Inst Instance=new A040636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040813
{
public static readonly long[] Value={ 29L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L,29L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040813Inst : IEnumerable<long>
{
public static readonly long[] Value=A040813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040813.Bytes);
public long this[int i]=>Value[i];

public static A040813Inst Instance=new A040813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040814
{
public static readonly long[] Value={ 29L,19L,2L,1L,5L,1L,3L,1L,1L,1L,1L,1L,2L,6L,1L,7L,2L,3L,2L,2L,11L,4L,1L,3L,14L,3L,1L,4L,11L,2L,2L,3L,2L,7L,1L,6L,2L,1L,1L,1L,1L,1L,3L,1L,5L,1L,2L,19L,58L,19L,2L,1L,5L,1L,3L,1L,1L,1L,1L,1L,2L,6L,1L,7L,2L,3L,2L,2L,11L,4L,1L,3L,14L,3L,1L,4L,11L,2L,2L,3L,2L,7L,1L,6L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040814Inst : IEnumerable<long>
{
public static readonly long[] Value=A040814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040814.Bytes);
public long this[int i]=>Value[i];

public static A040814Inst Instance=new A040814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040815
{
public static readonly long[] Value={ 29L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L,1L,1L,14L,58L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040815Inst : IEnumerable<long>
{
public static readonly long[] Value=A040815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040815.Bytes);
public long this[int i]=>Value[i];

public static A040815Inst Instance=new A040815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040816
{
public static readonly long[] Value={ 29L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,11L,58L,11L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040816Inst : IEnumerable<long>
{
public static readonly long[] Value=A040816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040816.Bytes);
public long this[int i]=>Value[i];

public static A040816Inst Instance=new A040816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040817
{
public static readonly long[] Value={ 29L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L,58L,9L,1L,2L,6L,8L,6L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040817Inst : IEnumerable<long>
{
public static readonly long[] Value=A040817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040817.Bytes);
public long this[int i]=>Value[i];

public static A040817Inst Instance=new A040817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040818
{
public static readonly long[] Value={ 29L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L,3L,3L,8L,58L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040818Inst : IEnumerable<long>
{
public static readonly long[] Value=A040818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040818.Bytes);
public long this[int i]=>Value[i];

public static A040818Inst Instance=new A040818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040819
{
public static readonly long[] Value={ 29L,7L,3L,1L,2L,1L,7L,1L,1L,2L,4L,11L,2L,2L,1L,18L,1L,2L,2L,11L,4L,2L,1L,1L,7L,1L,2L,1L,3L,7L,58L,7L,3L,1L,2L,1L,7L,1L,1L,2L,4L,11L,2L,2L,1L,18L,1L,2L,2L,11L,4L,2L,1L,1L,7L,1L,2L,1L,3L,7L,58L,7L,3L,1L,2L,1L,7L,1L,1L,2L,4L,11L,2L,2L,1L,18L,1L,2L,2L,11L,4L,2L,1L,1L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040819Inst : IEnumerable<long>
{
public static readonly long[] Value=A040819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040819.Bytes);
public long this[int i]=>Value[i];

public static A040819Inst Instance=new A040819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040820
{
public static readonly long[] Value={ 29L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L,58L,6L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040820Inst : IEnumerable<long>
{
public static readonly long[] Value=A040820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040820.Bytes);
public long this[int i]=>Value[i];

public static A040820Inst Instance=new A040820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040821
{
public static readonly long[] Value={ 29L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L,1L,7L,2L,4L,1L,5L,58L,5L,1L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040821Inst : IEnumerable<long>
{
public static readonly long[] Value=A040821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040821.Bytes);
public long this[int i]=>Value[i];

public static A040821Inst Instance=new A040821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040822
{
public static readonly long[] Value={ 29L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L,58L,5L,3L,2L,4L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040822Inst : IEnumerable<long>
{
public static readonly long[] Value=A040822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040822.Bytes);
public long this[int i]=>Value[i];

public static A040822Inst Instance=new A040822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040823
{
public static readonly long[] Value={ 29L,4L,1L,5L,1L,2L,4L,1L,1L,14L,19L,2L,2L,19L,14L,1L,1L,4L,2L,1L,5L,1L,4L,58L,4L,1L,5L,1L,2L,4L,1L,1L,14L,19L,2L,2L,19L,14L,1L,1L,4L,2L,1L,5L,1L,4L,58L,4L,1L,5L,1L,2L,4L,1L,1L,14L,19L,2L,2L,19L,14L,1L,1L,4L,2L,1L,5L,1L,4L,58L,4L,1L,5L,1L,2L,4L,1L,1L,14L,19L,2L,2L,19L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040823Inst : IEnumerable<long>
{
public static readonly long[] Value=A040823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040823.Bytes);
public long this[int i]=>Value[i];

public static A040823Inst Instance=new A040823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040824
{
public static readonly long[] Value={ 29L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L,2L,4L,58L,4L,2L,11L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040824Inst : IEnumerable<long>
{
public static readonly long[] Value=A040824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040824.Bytes);
public long this[int i]=>Value[i];

public static A040824Inst Instance=new A040824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040825
{
public static readonly long[] Value={ 29L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L,58L,4L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040825Inst : IEnumerable<long>
{
public static readonly long[] Value=A040825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040825.Bytes);
public long this[int i]=>Value[i];

public static A040825Inst Instance=new A040825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040826
{
public static readonly long[] Value={ 29L,3L,1L,7L,1L,1L,1L,1L,4L,3L,1L,2L,6L,7L,6L,2L,1L,3L,4L,1L,1L,1L,1L,7L,1L,3L,58L,3L,1L,7L,1L,1L,1L,1L,4L,3L,1L,2L,6L,7L,6L,2L,1L,3L,4L,1L,1L,1L,1L,7L,1L,3L,58L,3L,1L,7L,1L,1L,1L,1L,4L,3L,1L,2L,6L,7L,6L,2L,1L,3L,4L,1L,1L,1L,1L,7L,1L,3L,58L,3L,1L,7L,1L,1L,1L,1L,4L,3L,1L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040826Inst : IEnumerable<long>
{
public static readonly long[] Value=A040826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040826.Bytes);
public long this[int i]=>Value[i];

public static A040826Inst Instance=new A040826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040827
{
public static readonly long[] Value={ 29L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L,3L,1L,6L,1L,1L,6L,1L,3L,1L,1L,1L,3L,58L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040827Inst : IEnumerable<long>
{
public static readonly long[] Value=A040827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040827.Bytes);
public long this[int i]=>Value[i];

public static A040827Inst Instance=new A040827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040828
{
public static readonly long[] Value={ 29L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L,58L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040828Inst : IEnumerable<long>
{
public static readonly long[] Value=A040828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040828.Bytes);
public long this[int i]=>Value[i];

public static A040828Inst Instance=new A040828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040845
{
public static readonly long[] Value={ 29L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,58L,1L,1L,2L,1L,1L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040845Inst : IEnumerable<long>
{
public static readonly long[] Value=A040845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040845.Bytes);
public long this[int i]=>Value[i];

public static A040845Inst Instance=new A040845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040846
{
public static readonly long[] Value={ 29L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L,14L,2L,1L,1L,58L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040846Inst : IEnumerable<long>
{
public static readonly long[] Value=A040846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040846.Bytes);
public long this[int i]=>Value[i];

public static A040846Inst Instance=new A040846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040847
{
public static readonly long[] Value={ 29L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L,58L,1L,1L,1L,1L,2L,4L,1L,1L,4L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040847Inst : IEnumerable<long>
{
public static readonly long[] Value=A040847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040847.Bytes);
public long this[int i]=>Value[i];

public static A040847Inst Instance=new A040847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040848
{
public static readonly long[] Value={ 29L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L,28L,1L,4L,2L,2L,1L,1L,1L,58L,1L,1L,1L,2L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040848Inst : IEnumerable<long>
{
public static readonly long[] Value=A040848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040848.Bytes);
public long this[int i]=>Value[i];

public static A040848Inst Instance=new A040848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040849
{
public static readonly long[] Value={ 29L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L,1L,1L,1L,5L,3L,1L,3L,2L,9L,2L,3L,1L,3L,5L,1L,1L,1L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040849Inst : IEnumerable<long>
{
public static readonly long[] Value=A040849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040849.Bytes);
public long this[int i]=>Value[i];

public static A040849Inst Instance=new A040849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040850
{
public static readonly long[] Value={ 29L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L,58L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040850Inst : IEnumerable<long>
{
public static readonly long[] Value=A040850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040850.Bytes);
public long this[int i]=>Value[i];

public static A040850Inst Instance=new A040850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040851
{
public static readonly long[] Value={ 29L,1L,2L,7L,11L,1L,2L,1L,3L,1L,4L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,11L,7L,2L,1L,58L,1L,2L,7L,11L,1L,2L,1L,3L,1L,4L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,11L,7L,2L,1L,58L,1L,2L,7L,11L,1L,2L,1L,3L,1L,4L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,11L,7L,2L,1L,58L,1L,2L,7L,11L,1L,2L,1L,3L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040851Inst : IEnumerable<long>
{
public static readonly long[] Value=A040851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040851.Bytes);
public long this[int i]=>Value[i];

public static A040851Inst Instance=new A040851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040852
{
public static readonly long[] Value={ 29L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L,58L,1L,2L,3L,6L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040852Inst : IEnumerable<long>
{
public static readonly long[] Value=A040852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040852.Bytes);
public long this[int i]=>Value[i];

public static A040852Inst Instance=new A040852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040853
{
public static readonly long[] Value={ 29L,1L,2L,1L,1L,19L,4L,5L,6L,2L,2L,2L,1L,2L,1L,1L,2L,8L,9L,1L,3L,1L,2L,29L,2L,1L,3L,1L,9L,8L,2L,1L,1L,2L,1L,2L,2L,2L,6L,5L,4L,19L,1L,1L,2L,1L,58L,1L,2L,1L,1L,19L,4L,5L,6L,2L,2L,2L,1L,2L,1L,1L,2L,8L,9L,1L,3L,1L,2L,29L,2L,1L,3L,1L,9L,8L,2L,1L,1L,2L,1L,2L,2L,2L,6L,5L,4L,19L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040853Inst : IEnumerable<long>
{
public static readonly long[] Value=A040853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040853.Bytes);
public long this[int i]=>Value[i];

public static A040853Inst Instance=new A040853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040854
{
public static readonly long[] Value={ 29L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L,58L,1L,2L,1L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040854Inst : IEnumerable<long>
{
public static readonly long[] Value=A040854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040854.Bytes);
public long this[int i]=>Value[i];

public static A040854Inst Instance=new A040854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040855
{
public static readonly long[] Value={ 29L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L,58L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040855Inst : IEnumerable<long>
{
public static readonly long[] Value=A040855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040855.Bytes);
public long this[int i]=>Value[i];

public static A040855Inst Instance=new A040855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040856
{
public static readonly long[] Value={ 29L,1L,3L,3L,1L,2L,1L,1L,5L,2L,1L,1L,1L,9L,3L,2L,1L,1L,19L,3L,1L,11L,6L,1L,1L,7L,1L,28L,1L,7L,1L,1L,6L,11L,1L,3L,19L,1L,1L,2L,3L,9L,1L,1L,1L,2L,5L,1L,1L,2L,1L,3L,3L,1L,58L,1L,3L,3L,1L,2L,1L,1L,5L,2L,1L,1L,1L,9L,3L,2L,1L,1L,19L,3L,1L,11L,6L,1L,1L,7L,1L,28L,1L,7L,1L,1L,6L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040856Inst : IEnumerable<long>
{
public static readonly long[] Value=A040856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040856.Bytes);
public long this[int i]=>Value[i];

public static A040856Inst Instance=new A040856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040857
{
public static readonly long[] Value={ 29L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L,1L,1L,2L,29L,2L,1L,1L,3L,1L,58L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040857Inst : IEnumerable<long>
{
public static readonly long[] Value=A040857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040857.Bytes);
public long this[int i]=>Value[i];

public static A040857Inst Instance=new A040857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040858
{
public static readonly long[] Value={ 29L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L,58L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040858Inst : IEnumerable<long>
{
public static readonly long[] Value=A040858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040858.Bytes);
public long this[int i]=>Value[i];

public static A040858Inst Instance=new A040858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040859
{
public static readonly long[] Value={ 29L,1L,4L,2L,3L,1L,1L,11L,2L,1L,3L,19L,1L,1L,1L,1L,6L,1L,5L,1L,3L,8L,3L,1L,5L,1L,6L,1L,1L,1L,1L,19L,3L,1L,2L,11L,1L,1L,3L,2L,4L,1L,58L,1L,4L,2L,3L,1L,1L,11L,2L,1L,3L,19L,1L,1L,1L,1L,6L,1L,5L,1L,3L,8L,3L,1L,5L,1L,6L,1L,1L,1L,1L,19L,3L,1L,2L,11L,1L,1L,3L,2L,4L,1L,58L,1L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040859Inst : IEnumerable<long>
{
public static readonly long[] Value=A040859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040859.Bytes);
public long this[int i]=>Value[i];

public static A040859Inst Instance=new A040859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040860
{
public static readonly long[] Value={ 29L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L,58L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040860Inst : IEnumerable<long>
{
public static readonly long[] Value=A040860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040860.Bytes);
public long this[int i]=>Value[i];

public static A040860Inst Instance=new A040860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040909
{
public static readonly long[] Value={ 30L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L,14L,1L,1L,1L,60L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040909Inst : IEnumerable<long>
{
public static readonly long[] Value=A040909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040909.Bytes);
public long this[int i]=>Value[i];

public static A040909Inst Instance=new A040909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040910
{
public static readonly long[] Value={ 30L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L,1L,11L,2L,1L,60L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L,1L,11L,2L,1L,60L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L,1L,11L,2L,1L,60L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L,1L,11L,2L,1L,60L,1L,2L,11L,1L,14L,2L,2L,1L,1L,2L,2L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040910Inst : IEnumerable<long>
{
public static readonly long[] Value=A040910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040910.Bytes);
public long this[int i]=>Value[i];

public static A040910Inst Instance=new A040910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040911
{
public static readonly long[] Value={ 30L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L,20L,4L,2L,1L,60L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040911Inst : IEnumerable<long>
{
public static readonly long[] Value=A040911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040911.Bytes);
public long this[int i]=>Value[i];

public static A040911Inst Instance=new A040911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040912
{
public static readonly long[] Value={ 30L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L,2L,2L,1L,60L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040912Inst : IEnumerable<long>
{
public static readonly long[] Value=A040912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040912.Bytes);
public long this[int i]=>Value[i];

public static A040912Inst Instance=new A040912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040913
{
public static readonly long[] Value={ 30L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L,2L,1L,1L,1L,2L,1L,60L,1L,2L,1L,1L,1L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040913Inst : IEnumerable<long>
{
public static readonly long[] Value=A040913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040913.Bytes);
public long this[int i]=>Value[i];

public static A040913Inst Instance=new A040913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040914
{
public static readonly long[] Value={ 30L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L,12L,6L,1L,2L,1L,60L,1L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040914Inst : IEnumerable<long>
{
public static readonly long[] Value=A040914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040914.Bytes);
public long this[int i]=>Value[i];

public static A040914Inst Instance=new A040914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040915
{
public static readonly long[] Value={ 30L,1L,3L,8L,1L,1L,6L,3L,3L,1L,3L,1L,1L,1L,2L,30L,2L,1L,1L,1L,3L,1L,3L,3L,6L,1L,1L,8L,3L,1L,60L,1L,3L,8L,1L,1L,6L,3L,3L,1L,3L,1L,1L,1L,2L,30L,2L,1L,1L,1L,3L,1L,3L,3L,6L,1L,1L,8L,3L,1L,60L,1L,3L,8L,1L,1L,6L,3L,3L,1L,3L,1L,1L,1L,2L,30L,2L,1L,1L,1L,3L,1L,3L,3L,6L,1L,1L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040915Inst : IEnumerable<long>
{
public static readonly long[] Value=A040915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040915.Bytes);
public long this[int i]=>Value[i];

public static A040915Inst Instance=new A040915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040916
{
public static readonly long[] Value={ 30L,1L,3L,2L,2L,2L,1L,4L,1L,7L,1L,29L,1L,7L,1L,4L,1L,2L,2L,2L,3L,1L,60L,1L,3L,2L,2L,2L,1L,4L,1L,7L,1L,29L,1L,7L,1L,4L,1L,2L,2L,2L,3L,1L,60L,1L,3L,2L,2L,2L,1L,4L,1L,7L,1L,29L,1L,7L,1L,4L,1L,2L,2L,2L,3L,1L,60L,1L,3L,2L,2L,2L,1L,4L,1L,7L,1L,29L,1L,7L,1L,4L,1L,2L,2L,2L,3L,1L,60L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040916Inst : IEnumerable<long>
{
public static readonly long[] Value=A040916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040916.Bytes);
public long this[int i]=>Value[i];

public static A040916Inst Instance=new A040916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040917
{
public static readonly long[] Value={ 30L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L,20L,3L,1L,3L,1L,60L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040917Inst : IEnumerable<long>
{
public static readonly long[] Value=A040917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040917.Bytes);
public long this[int i]=>Value[i];

public static A040917Inst Instance=new A040917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040918
{
public static readonly long[] Value={ 30L,1L,4L,6L,1L,1L,1L,4L,2L,14L,1L,19L,1L,1L,1L,1L,19L,1L,14L,2L,4L,1L,1L,1L,6L,4L,1L,60L,1L,4L,6L,1L,1L,1L,4L,2L,14L,1L,19L,1L,1L,1L,1L,19L,1L,14L,2L,4L,1L,1L,1L,6L,4L,1L,60L,1L,4L,6L,1L,1L,1L,4L,2L,14L,1L,19L,1L,1L,1L,1L,19L,1L,14L,2L,4L,1L,1L,1L,6L,4L,1L,60L,1L,4L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040918Inst : IEnumerable<long>
{
public static readonly long[] Value=A040918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040918.Bytes);
public long this[int i]=>Value[i];

public static A040918Inst Instance=new A040918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040919
{
public static readonly long[] Value={ 30L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,60L,1L,4L,1L,1L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040919Inst : IEnumerable<long>
{
public static readonly long[] Value=A040919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040919.Bytes);
public long this[int i]=>Value[i];

public static A040919Inst Instance=new A040919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040920
{
public static readonly long[] Value={ 30L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L,1L,5L,5L,2L,3L,1L,1L,1L,9L,1L,1L,1L,3L,2L,5L,5L,1L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040920Inst : IEnumerable<long>
{
public static readonly long[] Value=A040920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040920.Bytes);
public long this[int i]=>Value[i];

public static A040920Inst Instance=new A040920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040921
{
public static readonly long[] Value={ 30L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L,60L,1L,5L,1L,6L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040921Inst : IEnumerable<long>
{
public static readonly long[] Value=A040921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040921.Bytes);
public long this[int i]=>Value[i];

public static A040921Inst Instance=new A040921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040922
{
public static readonly long[] Value={ 30L,1L,6L,1L,2L,1L,3L,8L,1L,1L,4L,4L,1L,1L,8L,3L,1L,2L,1L,6L,1L,60L,1L,6L,1L,2L,1L,3L,8L,1L,1L,4L,4L,1L,1L,8L,3L,1L,2L,1L,6L,1L,60L,1L,6L,1L,2L,1L,3L,8L,1L,1L,4L,4L,1L,1L,8L,3L,1L,2L,1L,6L,1L,60L,1L,6L,1L,2L,1L,3L,8L,1L,1L,4L,4L,1L,1L,8L,3L,1L,2L,1L,6L,1L,60L,1L,6L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040922Inst : IEnumerable<long>
{
public static readonly long[] Value=A040922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040922.Bytes);
public long this[int i]=>Value[i];

public static A040922Inst Instance=new A040922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040923
{
public static readonly long[] Value={ 30L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L,2L,6L,2L,3L,5L,1L,7L,1L,60L,1L,7L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040923Inst : IEnumerable<long>
{
public static readonly long[] Value=A040923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040923.Bytes);
public long this[int i]=>Value[i];

public static A040923Inst Instance=new A040923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040924
{
public static readonly long[] Value={ 30L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L,12L,5L,1L,1L,6L,3L,9L,1L,60L,1L,9L,3L,6L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040924Inst : IEnumerable<long>
{
public static readonly long[] Value=A040924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040924.Bytes);
public long this[int i]=>Value[i];

public static A040924Inst Instance=new A040924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041053
{
public static readonly long[] Value={ 1L,1L,2L,3L,32L,35L,67L,102L,1087L,1189L,2276L,3465L,36926L,40391L,77317L,117708L,1254397L,1372105L,2626502L,3998607L,42612572L,46611179L,89223751L,135834930L,1447573051L,1583407981L,3030981032L,4614389013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041053Inst : IEnumerable<long>
{
public static readonly long[] Value=A041053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041053.Bytes);
public long this[int i]=>Value[i];

public static A041053Inst Instance=new A041053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041054
{
public static readonly long[] Value={ 5L,6L,17L,23L,247L,270L,787L,1057L,11357L,12414L,36185L,48599L,522175L,570774L,1663723L,2234497L,24008693L,26243190L,76495073L,102738263L,1103877703L,1206615966L,3517109635L,4723725601L,50754365645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041054Inst : IEnumerable<long>
{
public static readonly long[] Value=A041054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041054.Bytes);
public long this[int i]=>Value[i];

public static A041054Inst Instance=new A041054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041055
{
public static readonly long[] Value={ 1L,1L,3L,4L,43L,47L,137L,184L,1977L,2161L,6299L,8460L,90899L,99359L,289617L,388976L,4179377L,4568353L,13316083L,17884436L,192160443L,210044879L,612250201L,822295080L,8835201001L,9657496081L,28150193163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041055Inst : IEnumerable<long>
{
public static readonly long[] Value=A041055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041055.Bytes);
public long this[int i]=>Value[i];

public static A041055Inst Instance=new A041055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041056
{
public static readonly long[] Value={ 5L,6L,29L,35L,379L,414L,2035L,2449L,26525L,28974L,142421L,171395L,1856371L,2027766L,9967435L,11995201L,129919445L,141914646L,697578029L,839492675L,9092504779L,9931997454L,48820494595L,58752492049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041056Inst : IEnumerable<long>
{
public static readonly long[] Value=A041056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041056.Bytes);
public long this[int i]=>Value[i];

public static A041056Inst Instance=new A041056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041057
{
public static readonly long[] Value={ 1L,1L,5L,6L,65L,71L,349L,420L,4549L,4969L,24425L,29394L,318365L,347759L,1709401L,2057160L,22281001L,24338161L,119633645L,143971806L,1559351705L,1703323511L,8372645749L,10075969260L,109132338349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041057Inst : IEnumerable<long>
{
public static readonly long[] Value=A041057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041057.Bytes);
public long this[int i]=>Value[i];

public static A041057Inst Instance=new A041057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041058
{
public static readonly long[] Value={ 5L,6L,65L,71L,775L,846L,9235L,10081L,110045L,120126L,1311305L,1431431L,15625615L,17057046L,186196075L,203253121L,2218727285L,2421980406L,26438531345L,28860511751L,315043648855L,343904160606L,3754085254915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041058Inst : IEnumerable<long>
{
public static readonly long[] Value=A041058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041058.Bytes);
public long this[int i]=>Value[i];

public static A041058Inst Instance=new A041058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A041059
{
public static readonly long[] Value={ 1L,1L,11L,12L,131L,143L,1561L,1704L,18601L,20305L,221651L,241956L,2641211L,2883167L,31472881L,34356048L,375033361L,409389409L,4468927451L,4878316860L,53252096051L,58130412911L,634556225161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A041059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A041059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A041059Inst : IEnumerable<long>
{
public static readonly long[] Value=A041059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A041059.Bytes);
public long this[int i]=>Value[i];

public static A041059Inst Instance=new A041059Inst();

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