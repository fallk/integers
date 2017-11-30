using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021537
{
public static readonly long[] Value={ 0L,0L,1L,8L,7L,6L,1L,7L,2L,6L,0L,7L,8L,7L,9L,9L,2L,4L,9L,5L,3L,0L,9L,5L,6L,8L,4L,8L,0L,3L,0L,0L,1L,8L,7L,6L,1L,7L,2L,6L,0L,7L,8L,7L,9L,9L,2L,4L,9L,5L,3L,0L,9L,5L,6L,8L,4L,8L,0L,3L,0L,0L,1L,8L,7L,6L,1L,7L,2L,6L,0L,7L,8L,7L,9L,9L,2L,4L,9L,5L,3L,0L,9L,5L,6L,8L,4L,8L,0L,3L,0L,0L,1L,8L,7L,6L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021537Inst : IEnumerable<long>
{
public static readonly long[] Value=A021537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021537.Bytes);
public long this[int i]=>Value[i];

public static A021537Inst Instance=new A021537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021536
{
public static readonly long[] Value={ 0L,0L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021536Inst : IEnumerable<long>
{
public static readonly long[] Value=A021536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021536.Bytes);
public long this[int i]=>Value[i];

public static A021536Inst Instance=new A021536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021535
{
public static readonly long[] Value={ 0L,0L,1L,8L,8L,3L,2L,3L,9L,1L,7L,1L,3L,7L,4L,7L,6L,4L,5L,9L,5L,1L,0L,3L,5L,7L,8L,1L,5L,4L,4L,2L,5L,6L,1L,2L,0L,5L,2L,7L,3L,0L,6L,9L,6L,7L,9L,8L,4L,9L,3L,4L,0L,8L,6L,6L,2L,9L,0L,0L,1L,8L,8L,3L,2L,3L,9L,1L,7L,1L,3L,7L,4L,7L,6L,4L,5L,9L,5L,1L,0L,3L,5L,7L,8L,1L,5L,4L,4L,2L,5L,6L,1L,2L,0L,5L,2L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021535Inst : IEnumerable<long>
{
public static readonly long[] Value=A021535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021535.Bytes);
public long this[int i]=>Value[i];

public static A021535Inst Instance=new A021535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021534
{
public static readonly long[] Value={ 1L,22L,337L,4522L,57253L,705334L,8574889L,103567234L,1246828045L,14986093486L,179978152081L,2160608272186L,25932522746677L,311221616234278L,3734847461630713L,44819297962008178L,537838346143305949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021534Inst : IEnumerable<long>
{
public static readonly long[] Value=A021534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021534.Bytes);
public long this[int i]=>Value[i];

public static A021534Inst Instance=new A021534Inst();

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

public static class A021517
{
public static readonly long[] Value={ 0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021517Inst : IEnumerable<long>
{
public static readonly long[] Value=A021517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021517.Bytes);
public long this[int i]=>Value[i];

public static A021517Inst Instance=new A021517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021516
{
public static readonly long[] Value={ 0L,0L,1L,9L,5L,3L,1L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021516Inst : IEnumerable<long>
{
public static readonly long[] Value=A021516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021516.Bytes);
public long this[int i]=>Value[i];

public static A021516Inst Instance=new A021516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021515
{
public static readonly long[] Value={ 0L,0L,1L,9L,5L,6L,9L,4L,7L,1L,6L,2L,4L,2L,6L,6L,1L,4L,4L,8L,1L,4L,0L,9L,0L,0L,1L,9L,5L,6L,9L,4L,7L,1L,6L,2L,4L,2L,6L,6L,1L,4L,4L,8L,1L,4L,0L,9L,0L,0L,1L,9L,5L,6L,9L,4L,7L,1L,6L,2L,4L,2L,6L,6L,1L,4L,4L,8L,1L,4L,0L,9L,0L,0L,1L,9L,5L,6L,9L,4L,7L,1L,6L,2L,4L,2L,6L,6L,1L,4L,4L,8L,1L,4L,0L,9L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021515Inst : IEnumerable<long>
{
public static readonly long[] Value=A021515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021515.Bytes);
public long this[int i]=>Value[i];

public static A021515Inst Instance=new A021515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021514
{
public static readonly long[] Value={ 1L,20L,273L,3208L,35069L,368988L,3800761L,38676176L,390782997L,3931986916L,39464899409L,395519441304L,3960417893485L,39635522209004L,396543288909417L,3966561311533792L,39672383714545733L,396764460934414452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021514Inst : IEnumerable<long>
{
public static readonly long[] Value=A021514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021514.Bytes);
public long this[int i]=>Value[i];

public static A021514Inst Instance=new A021514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021513
{
public static readonly long[] Value={ 0L,0L,1L,9L,6L,4L,6L,3L,6L,5L,4L,2L,2L,3L,9L,6L,8L,5L,6L,5L,8L,1L,5L,3L,2L,4L,1L,6L,5L,0L,2L,9L,4L,6L,9L,5L,4L,8L,1L,3L,3L,5L,9L,5L,2L,8L,4L,8L,7L,2L,2L,9L,8L,6L,2L,4L,7L,5L,4L,4L,2L,0L,4L,3L,2L,2L,2L,0L,0L,3L,9L,2L,9L,2L,7L,3L,0L,8L,4L,4L,7L,9L,3L,7L,1L,3L,1L,6L,3L,0L,6L,4L,8L,3L,3L,0L,0L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021513Inst : IEnumerable<long>
{
public static readonly long[] Value=A021513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021513.Bytes);
public long this[int i]=>Value[i];

public static A021513Inst Instance=new A021513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021512
{
public static readonly long[] Value={ 0L,0L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021512Inst : IEnumerable<long>
{
public static readonly long[] Value=A021512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021512.Bytes);
public long this[int i]=>Value[i];

public static A021512Inst Instance=new A021512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021511
{
public static readonly long[] Value={ 0L,0L,1L,9L,7L,2L,3L,8L,6L,5L,8L,7L,7L,7L,1L,2L,0L,3L,1L,5L,5L,8L,1L,8L,5L,4L,0L,4L,3L,3L,9L,2L,5L,0L,4L,9L,3L,0L,9L,6L,6L,4L,6L,9L,4L,2L,8L,0L,0L,7L,8L,8L,9L,5L,4L,6L,3L,5L,1L,0L,8L,4L,8L,1L,2L,6L,2L,3L,2L,7L,4L,1L,6L,1L,7L,3L,5L,7L,0L,0L,1L,9L,7L,2L,3L,8L,6L,5L,8L,7L,7L,7L,1L,2L,0L,3L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021511Inst : IEnumerable<long>
{
public static readonly long[] Value=A021511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021511.Bytes);
public long this[int i]=>Value[i];

public static A021511Inst Instance=new A021511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021510
{
public static readonly long[] Value={ 0L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L,4L,9L,8L,0L,2L,3L,7L,1L,5L,4L,1L,5L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L,4L,9L,8L,0L,2L,3L,7L,1L,5L,4L,1L,5L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L,4L,9L,8L,0L,2L,3L,7L,1L,5L,4L,1L,5L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L,4L,9L,8L,0L,2L,3L,7L,1L,5L,4L,1L,5L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021510Inst : IEnumerable<long>
{
public static readonly long[] Value=A021510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021510.Bytes);
public long this[int i]=>Value[i];

public static A021510Inst Instance=new A021510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021509
{
public static readonly long[] Value={ 0L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021509Inst : IEnumerable<long>
{
public static readonly long[] Value=A021509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021509.Bytes);
public long this[int i]=>Value[i];

public static A021509Inst Instance=new A021509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021508
{
public static readonly long[] Value={ 0L,0L,1L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021508Inst : IEnumerable<long>
{
public static readonly long[] Value=A021508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021508.Bytes);
public long this[int i]=>Value[i];

public static A021508Inst Instance=new A021508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021507
{
public static readonly long[] Value={ 0L,0L,1L,9L,8L,8L,0L,7L,1L,5L,7L,0L,5L,7L,6L,5L,4L,0L,7L,5L,5L,4L,6L,7L,1L,9L,6L,8L,1L,9L,0L,8L,5L,4L,8L,7L,0L,7L,7L,5L,3L,4L,7L,9L,1L,2L,5L,2L,4L,8L,5L,0L,8L,9L,4L,6L,3L,2L,2L,0L,6L,7L,5L,9L,4L,4L,3L,3L,3L,9L,9L,6L,0L,2L,3L,8L,5L,6L,8L,5L,8L,8L,4L,6L,9L,1L,8L,4L,8L,9L,0L,6L,5L,6L,0L,6L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021507Inst : IEnumerable<long>
{
public static readonly long[] Value=A021507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021507.Bytes);
public long this[int i]=>Value[i];

public static A021507Inst Instance=new A021507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021506
{
public static readonly long[] Value={ 0L,0L,1L,9L,9L,2L,0L,3L,1L,8L,7L,2L,5L,0L,9L,9L,6L,0L,1L,5L,9L,3L,6L,2L,5L,4L,9L,8L,0L,0L,7L,9L,6L,8L,1L,2L,7L,4L,9L,0L,0L,3L,9L,8L,4L,0L,6L,3L,7L,4L,5L,0L,1L,9L,9L,2L,0L,3L,1L,8L,7L,2L,5L,0L,9L,9L,6L,0L,1L,5L,9L,3L,6L,2L,5L,4L,9L,8L,0L,0L,7L,9L,6L,8L,1L,2L,7L,4L,9L,0L,0L,3L,9L,8L,4L,0L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021506Inst : IEnumerable<long>
{
public static readonly long[] Value=A021506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021506.Bytes);
public long this[int i]=>Value[i];

public static A021506Inst Instance=new A021506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021505
{
public static readonly long[] Value={ 0L,0L,1L,9L,9L,6L,0L,0L,7L,9L,8L,4L,0L,3L,1L,9L,3L,6L,1L,2L,7L,7L,4L,4L,5L,1L,0L,9L,7L,8L,0L,4L,3L,9L,1L,2L,1L,7L,5L,6L,4L,8L,7L,0L,2L,5L,9L,4L,8L,1L,0L,3L,7L,9L,2L,4L,1L,5L,1L,6L,9L,6L,6L,0L,6L,7L,8L,6L,4L,2L,7L,1L,4L,5L,7L,0L,8L,5L,8L,2L,8L,3L,4L,3L,3L,1L,3L,3L,7L,3L,2L,5L,3L,4L,9L,3L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021505Inst : IEnumerable<long>
{
public static readonly long[] Value=A021505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021505.Bytes);
public long this[int i]=>Value[i];

public static A021505Inst Instance=new A021505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021504
{
public static readonly long[] Value={ 1L,19L,244L,2674L,27055L,261793L,2467018L,22871728L,209866789L,1912958047L,17361652672L,157125321262L,1419351371803L,12805505620381L,115437617402806L,1040066979064876L,9367373410791697L,84346984486082395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021504Inst : IEnumerable<long>
{
public static readonly long[] Value=A021504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021504.Bytes);
public long this[int i]=>Value[i];

public static A021504Inst Instance=new A021504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021503
{
public static readonly long[] Value={ 1L,18L,217L,2214L,20701L,183906L,1582129L,13325598L,110626021L,909165114L,7418351161L,60217256502L,486961532461L,3927035533842L,31604351090113L,253963231160526L,2038476448492021L,16348435376893290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021503Inst : IEnumerable<long>
{
public static readonly long[] Value=A021503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021503.Bytes);
public long this[int i]=>Value[i];

public static A021503Inst Instance=new A021503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021502
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,8L,0L,3L,2L,1L,2L,8L,5L,1L,4L,0L,5L,6L,2L,2L,4L,8L,9L,9L,5L,9L,8L,3L,9L,3L,5L,7L,4L,2L,9L,7L,1L,8L,8L,7L,5L,5L,0L,2L,0L,0L,8L,0L,3L,2L,1L,2L,8L,5L,1L,4L,0L,5L,6L,2L,2L,4L,8L,9L,9L,5L,9L,8L,3L,9L,3L,5L,7L,4L,2L,9L,7L,1L,8L,8L,7L,5L,5L,0L,2L,0L,0L,8L,0L,3L,2L,1L,2L,8L,5L,1L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021502Inst : IEnumerable<long>
{
public static readonly long[] Value=A021502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021502.Bytes);
public long this[int i]=>Value[i];

public static A021502Inst Instance=new A021502Inst();

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

public static class A021421
{
public static readonly long[] Value={ 0L,0L,2L,3L,9L,8L,0L,8L,1L,5L,3L,4L,7L,7L,2L,1L,8L,2L,2L,5L,4L,1L,9L,6L,6L,4L,2L,6L,8L,5L,8L,5L,1L,3L,1L,8L,9L,4L,4L,8L,4L,4L,1L,2L,4L,7L,0L,0L,2L,3L,9L,8L,0L,8L,1L,5L,3L,4L,7L,7L,2L,1L,8L,2L,2L,5L,4L,1L,9L,6L,6L,4L,2L,6L,8L,5L,8L,5L,1L,3L,1L,8L,9L,4L,4L,8L,4L,4L,1L,2L,4L,7L,0L,0L,2L,3L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021421Inst : IEnumerable<long>
{
public static readonly long[] Value=A021421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021421.Bytes);
public long this[int i]=>Value[i];

public static A021421Inst Instance=new A021421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021420
{
public static readonly long[] Value={ 0L,0L,2L,4L,0L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021420Inst : IEnumerable<long>
{
public static readonly long[] Value=A021420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021420.Bytes);
public long this[int i]=>Value[i];

public static A021420Inst Instance=new A021420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021419
{
public static readonly long[] Value={ 0L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L,2L,1L,6L,8L,6L,7L,4L,6L,9L,8L,7L,9L,5L,1L,8L,0L,7L,2L,2L,8L,9L,1L,5L,6L,6L,2L,6L,5L,0L,6L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L,2L,1L,6L,8L,6L,7L,4L,6L,9L,8L,7L,9L,5L,1L,8L,0L,7L,2L,2L,8L,9L,1L,5L,6L,6L,2L,6L,5L,0L,6L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L,2L,1L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021419Inst : IEnumerable<long>
{
public static readonly long[] Value=A021419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021419.Bytes);
public long this[int i]=>Value[i];

public static A021419Inst Instance=new A021419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021418
{
public static readonly long[] Value={ 0L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L,7L,1L,9L,8L,0L,6L,7L,6L,3L,2L,8L,5L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L,7L,1L,9L,8L,0L,6L,7L,6L,3L,2L,8L,5L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L,7L,1L,9L,8L,0L,6L,7L,6L,3L,2L,8L,5L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L,7L,1L,9L,8L,0L,6L,7L,6L,3L,2L,8L,5L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021418Inst : IEnumerable<long>
{
public static readonly long[] Value=A021418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021418.Bytes);
public long this[int i]=>Value[i];

public static A021418Inst Instance=new A021418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021417
{
public static readonly long[] Value={ 0L,0L,2L,4L,2L,1L,3L,0L,7L,5L,0L,6L,0L,5L,3L,2L,6L,8L,7L,6L,5L,1L,3L,3L,1L,7L,1L,9L,1L,2L,8L,3L,2L,9L,2L,9L,7L,8L,2L,0L,8L,2L,3L,2L,4L,4L,5L,5L,2L,0L,5L,8L,1L,1L,1L,3L,8L,0L,1L,4L,5L,2L,7L,8L,4L,5L,0L,3L,6L,3L,1L,9L,6L,1L,2L,5L,9L,0L,7L,9L,9L,0L,3L,1L,4L,7L,6L,9L,9L,7L,5L,7L,8L,6L,9L,2L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021417Inst : IEnumerable<long>
{
public static readonly long[] Value=A021417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021417.Bytes);
public long this[int i]=>Value[i];

public static A021417Inst Instance=new A021417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021416
{
public static readonly long[] Value={ 0L,0L,2L,4L,2L,7L,1L,8L,4L,4L,6L,6L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L,0L,5L,8L,2L,5L,2L,4L,2L,7L,1L,8L,4L,4L,6L,6L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L,0L,5L,8L,2L,5L,2L,4L,2L,7L,1L,8L,4L,4L,6L,6L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021416Inst : IEnumerable<long>
{
public static readonly long[] Value=A021416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021416.Bytes);
public long this[int i]=>Value[i];

public static A021416Inst Instance=new A021416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021415
{
public static readonly long[] Value={ 0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021415Inst : IEnumerable<long>
{
public static readonly long[] Value=A021415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021415.Bytes);
public long this[int i]=>Value[i];

public static A021415Inst Instance=new A021415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021414
{
public static readonly long[] Value={ 1L,15L,148L,1218L,9079L,63693L,429346L,2815296L,18097717L,114645531L,718257904L,4461736734L,27532164115L,169004094729L,1033087293022L,6293858904732L,38239893731473L,231823257614487L,1402859602945900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021414Inst : IEnumerable<long>
{
public static readonly long[] Value=A021414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021414.Bytes);
public long this[int i]=>Value[i];

public static A021414Inst Instance=new A021414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021413
{
public static readonly long[] Value={ 0L,0L,2L,4L,4L,4L,9L,8L,7L,7L,7L,5L,0L,6L,1L,1L,2L,4L,6L,9L,4L,3L,7L,6L,5L,2L,8L,1L,1L,7L,3L,5L,9L,4L,1L,3L,2L,0L,2L,9L,3L,3L,9L,8L,5L,3L,3L,0L,0L,7L,3L,3L,4L,9L,6L,3L,3L,2L,5L,1L,8L,3L,3L,7L,4L,0L,8L,3L,1L,2L,9L,5L,8L,4L,3L,5L,2L,0L,7L,8L,2L,3L,9L,6L,0L,8L,8L,0L,1L,9L,5L,5L,9L,9L,0L,2L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021413Inst : IEnumerable<long>
{
public static readonly long[] Value=A021413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021413.Bytes);
public long this[int i]=>Value[i];

public static A021413Inst Instance=new A021413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021412
{
public static readonly long[] Value={ 0L,0L,2L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021412Inst : IEnumerable<long>
{
public static readonly long[] Value=A021412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021412.Bytes);
public long this[int i]=>Value[i];

public static A021412Inst Instance=new A021412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021411
{
public static readonly long[] Value={ 0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021411Inst : IEnumerable<long>
{
public static readonly long[] Value=A021411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021411.Bytes);
public long this[int i]=>Value[i];

public static A021411Inst Instance=new A021411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021410
{
public static readonly long[] Value={ 0L,0L,2L,4L,6L,3L,0L,5L,4L,1L,8L,7L,1L,9L,2L,1L,1L,8L,2L,2L,6L,6L,0L,0L,9L,8L,5L,2L,2L,1L,6L,7L,4L,8L,7L,6L,8L,4L,7L,2L,9L,0L,6L,4L,0L,3L,9L,4L,0L,8L,8L,6L,6L,9L,9L,5L,0L,7L,3L,8L,9L,1L,6L,2L,5L,6L,1L,5L,7L,6L,3L,5L,4L,6L,7L,9L,8L,0L,2L,9L,5L,5L,6L,6L,5L,0L,2L,4L,6L,3L,0L,5L,4L,1L,8L,7L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021410Inst : IEnumerable<long>
{
public static readonly long[] Value=A021410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021410.Bytes);
public long this[int i]=>Value[i];

public static A021410Inst Instance=new A021410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021409
{
public static readonly long[] Value={ 0L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021409Inst : IEnumerable<long>
{
public static readonly long[] Value=A021409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021409.Bytes);
public long this[int i]=>Value[i];

public static A021409Inst Instance=new A021409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021408
{
public static readonly long[] Value={ 0L,0L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021408Inst : IEnumerable<long>
{
public static readonly long[] Value=A021408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021408.Bytes);
public long this[int i]=>Value[i];

public static A021408Inst Instance=new A021408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021407
{
public static readonly long[] Value={ 0L,0L,2L,4L,8L,1L,3L,8L,9L,5L,7L,8L,1L,6L,3L,7L,7L,1L,7L,1L,2L,1L,5L,8L,8L,0L,8L,9L,3L,3L,0L,0L,2L,4L,8L,1L,3L,8L,9L,5L,7L,8L,1L,6L,3L,7L,7L,1L,7L,1L,2L,1L,5L,8L,8L,0L,8L,9L,3L,3L,0L,0L,2L,4L,8L,1L,3L,8L,9L,5L,7L,8L,1L,6L,3L,7L,7L,1L,7L,1L,2L,1L,5L,8L,8L,0L,8L,9L,3L,3L,0L,0L,2L,4L,8L,1L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021407Inst : IEnumerable<long>
{
public static readonly long[] Value=A021407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021407.Bytes);
public long this[int i]=>Value[i];

public static A021407Inst Instance=new A021407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021406
{
public static readonly long[] Value={ 0L,0L,2L,4L,8L,7L,5L,6L,2L,1L,8L,9L,0L,5L,4L,7L,2L,6L,3L,6L,8L,1L,5L,9L,2L,0L,3L,9L,8L,0L,0L,9L,9L,5L,0L,2L,4L,8L,7L,5L,6L,2L,1L,8L,9L,0L,5L,4L,7L,2L,6L,3L,6L,8L,1L,5L,9L,2L,0L,3L,9L,8L,0L,0L,9L,9L,5L,0L,2L,4L,8L,7L,5L,6L,2L,1L,8L,9L,0L,5L,4L,7L,2L,6L,3L,6L,8L,1L,5L,9L,2L,0L,3L,9L,8L,0L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021406Inst : IEnumerable<long>
{
public static readonly long[] Value=A021406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021406.Bytes);
public long this[int i]=>Value[i];

public static A021406Inst Instance=new A021406Inst();

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

public static class A021388
{
public static readonly long[] Value={ 0L,0L,2L,6L,0L,4L,1L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021388Inst : IEnumerable<long>
{
public static readonly long[] Value=A021388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021388.Bytes);
public long this[int i]=>Value[i];

public static A021388Inst Instance=new A021388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021387
{
public static readonly long[] Value={ 0L,0L,2L,6L,1L,0L,9L,6L,6L,0L,5L,7L,4L,4L,1L,2L,5L,3L,2L,6L,3L,7L,0L,7L,5L,7L,1L,8L,0L,1L,5L,6L,6L,5L,7L,9L,6L,3L,4L,4L,6L,4L,7L,5L,1L,9L,5L,8L,2L,2L,4L,5L,4L,3L,0L,8L,0L,9L,3L,9L,9L,4L,7L,7L,8L,0L,6L,7L,8L,8L,5L,1L,1L,7L,4L,9L,3L,4L,7L,2L,5L,8L,4L,8L,5L,6L,3L,9L,6L,8L,6L,6L,8L,4L,0L,7L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021387Inst : IEnumerable<long>
{
public static readonly long[] Value=A021387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021387.Bytes);
public long this[int i]=>Value[i];

public static A021387Inst Instance=new A021387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021386
{
public static readonly long[] Value={ 0L,0L,2L,6L,1L,7L,8L,0L,1L,0L,4L,7L,1L,2L,0L,4L,1L,8L,8L,4L,8L,1L,6L,7L,5L,3L,9L,2L,6L,7L,0L,1L,5L,7L,0L,6L,8L,0L,6L,2L,8L,2L,7L,2L,2L,5L,1L,3L,0L,8L,9L,0L,0L,5L,2L,3L,5L,6L,0L,2L,0L,9L,4L,2L,4L,0L,8L,3L,7L,6L,9L,6L,3L,3L,5L,0L,7L,8L,5L,3L,4L,0L,3L,1L,4L,1L,3L,6L,1L,2L,5L,6L,5L,4L,4L,5L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021386Inst : IEnumerable<long>
{
public static readonly long[] Value=A021386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021386.Bytes);
public long this[int i]=>Value[i];

public static A021386Inst Instance=new A021386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021385
{
public static readonly long[] Value={ 0L,0L,2L,6L,2L,4L,6L,7L,1L,9L,1L,6L,0L,1L,0L,4L,9L,8L,6L,8L,7L,6L,6L,4L,0L,4L,1L,9L,9L,4L,7L,5L,0L,6L,5L,6L,1L,6L,7L,9L,7L,9L,0L,0L,2L,6L,2L,4L,6L,7L,1L,9L,1L,6L,0L,1L,0L,4L,9L,8L,6L,8L,7L,6L,6L,4L,0L,4L,1L,9L,9L,4L,7L,5L,0L,6L,5L,6L,1L,6L,7L,9L,7L,9L,0L,0L,2L,6L,2L,4L,6L,7L,1L,9L,1L,6L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021385Inst : IEnumerable<long>
{
public static readonly long[] Value=A021385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021385.Bytes);
public long this[int i]=>Value[i];

public static A021385Inst Instance=new A021385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021384
{
public static readonly long[] Value={ 1L,18L,225L,2470L,25701L,261378L,2632345L,26400990L,264329901L,2644608538L,26451412065L,264535693110L,2645444018101L,26454790920498L,264549319337385L,2645498855426830L,26455011267050301L,264550203715341258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021384Inst : IEnumerable<long>
{
public static readonly long[] Value=A021384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021384.Bytes);
public long this[int i]=>Value[i];

public static A021384Inst Instance=new A021384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021383
{
public static readonly long[] Value={ 0L,0L,2L,6L,3L,8L,5L,2L,2L,4L,2L,7L,4L,4L,0L,6L,3L,3L,2L,4L,5L,3L,8L,2L,5L,8L,5L,7L,5L,1L,9L,7L,8L,8L,9L,1L,8L,2L,0L,5L,8L,0L,4L,7L,4L,9L,3L,4L,0L,3L,6L,9L,3L,9L,3L,1L,3L,9L,8L,4L,1L,6L,8L,8L,6L,5L,4L,3L,5L,3L,5L,6L,2L,0L,0L,5L,2L,7L,7L,0L,4L,4L,8L,5L,4L,8L,8L,1L,2L,6L,6L,4L,9L,0L,7L,6L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021383Inst : IEnumerable<long>
{
public static readonly long[] Value=A021383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021383.Bytes);
public long this[int i]=>Value[i];

public static A021383Inst Instance=new A021383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021382
{
public static readonly long[] Value={ 0L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021382Inst : IEnumerable<long>
{
public static readonly long[] Value=A021382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021382.Bytes);
public long this[int i]=>Value[i];

public static A021382Inst Instance=new A021382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021381
{
public static readonly long[] Value={ 0L,0L,2L,6L,5L,2L,5L,1L,9L,8L,9L,3L,8L,9L,9L,2L,0L,4L,2L,4L,4L,0L,3L,1L,8L,3L,0L,2L,3L,8L,7L,2L,6L,7L,9L,0L,4L,5L,0L,9L,2L,8L,3L,8L,1L,9L,6L,2L,8L,6L,4L,7L,2L,1L,4L,8L,5L,4L,1L,1L,1L,4L,0L,5L,8L,3L,5L,5L,4L,3L,7L,6L,6L,5L,7L,8L,2L,4L,9L,3L,3L,6L,8L,7L,0L,0L,2L,6L,5L,2L,5L,1L,9L,8L,9L,3L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021381Inst : IEnumerable<long>
{
public static readonly long[] Value=A021381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021381.Bytes);
public long this[int i]=>Value[i];

public static A021381Inst Instance=new A021381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021380
{
public static readonly long[] Value={ 0L,0L,2L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L,7L,4L,4L,6L,8L,0L,8L,5L,1L,0L,6L,3L,8L,2L,9L,7L,8L,7L,2L,3L,4L,0L,4L,2L,5L,5L,3L,1L,9L,1L,4L,8L,9L,3L,6L,1L,7L,0L,2L,1L,2L,7L,6L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021380Inst : IEnumerable<long>
{
public static readonly long[] Value=A021380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021380.Bytes);
public long this[int i]=>Value[i];

public static A021380Inst Instance=new A021380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021379
{
public static readonly long[] Value={ 1L,17L,198L,2002L,19019L,175539L,1598416L,14463284L,130489557L,1175715541L,10586766554L,95302471446L,857809330015L,7720634709623L,69487122519012L,625389764724088L,5628530595298793L,50656866402527385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021379Inst : IEnumerable<long>
{
public static readonly long[] Value=A021379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021379.Bytes);
public long this[int i]=>Value[i];

public static A021379Inst Instance=new A021379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021378
{
public static readonly long[] Value={ 0L,0L,2L,6L,7L,3L,7L,9L,6L,7L,9L,1L,4L,4L,3L,8L,5L,0L,2L,6L,7L,3L,7L,9L,6L,7L,9L,1L,4L,4L,3L,8L,5L,0L,2L,6L,7L,3L,7L,9L,6L,7L,9L,1L,4L,4L,3L,8L,5L,0L,2L,6L,7L,3L,7L,9L,6L,7L,9L,1L,4L,4L,3L,8L,5L,0L,2L,6L,7L,3L,7L,9L,6L,7L,9L,1L,4L,4L,3L,8L,5L,0L,2L,6L,7L,3L,7L,9L,6L,7L,9L,1L,4L,4L,3L,8L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021378Inst : IEnumerable<long>
{
public static readonly long[] Value=A021378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021378.Bytes);
public long this[int i]=>Value[i];

public static A021378Inst Instance=new A021378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021377
{
public static readonly long[] Value={ 0L,0L,2L,6L,8L,0L,9L,6L,5L,1L,4L,7L,4L,5L,3L,0L,8L,3L,1L,0L,9L,9L,1L,9L,5L,7L,1L,0L,4L,5L,5L,7L,6L,4L,0L,7L,5L,0L,6L,7L,0L,2L,4L,1L,2L,8L,6L,8L,6L,3L,2L,7L,0L,7L,7L,7L,4L,7L,9L,8L,9L,2L,7L,6L,1L,3L,9L,4L,1L,0L,1L,8L,7L,6L,6L,7L,5L,6L,0L,3L,2L,1L,7L,1L,5L,8L,1L,7L,6L,9L,4L,3L,6L,9L,9L,7L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021377Inst : IEnumerable<long>
{
public static readonly long[] Value=A021377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021377.Bytes);
public long this[int i]=>Value[i];

public static A021377Inst Instance=new A021377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021376
{
public static readonly long[] Value={ 0L,0L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L,0L,4L,3L,0L,1L,0L,7L,5L,2L,6L,8L,8L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021376Inst : IEnumerable<long>
{
public static readonly long[] Value=A021376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021376.Bytes);
public long this[int i]=>Value[i];

public static A021376Inst Instance=new A021376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021375
{
public static readonly long[] Value={ 0L,0L,2L,6L,9L,5L,4L,1L,7L,7L,8L,9L,7L,5L,7L,4L,1L,2L,3L,9L,8L,9L,2L,1L,8L,3L,2L,8L,8L,4L,0L,9L,7L,0L,3L,5L,0L,4L,0L,4L,3L,1L,2L,6L,6L,8L,4L,6L,3L,6L,1L,1L,8L,5L,9L,8L,3L,8L,2L,7L,4L,9L,3L,2L,6L,1L,4L,5L,5L,5L,2L,5L,6L,0L,6L,4L,6L,9L,0L,0L,2L,6L,9L,5L,4L,1L,7L,7L,8L,9L,7L,5L,7L,4L,1L,2L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021375Inst : IEnumerable<long>
{
public static readonly long[] Value=A021375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021375.Bytes);
public long this[int i]=>Value[i];

public static A021375Inst Instance=new A021375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021374
{
public static readonly long[] Value={ 1L,16L,173L,1604L,13833L,115032L,938821L,7588108L,61024865L,489508448L,3921394269L,31392726612L,251228899897L,2010181938664L,16082865641717L,128668587186716L,1029371410275729L,8235062327044080L,65880863376836365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021374Inst : IEnumerable<long>
{
public static readonly long[] Value=A021374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021374.Bytes);
public long this[int i]=>Value[i];

public static A021374Inst Instance=new A021374Inst();

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

public static class A021356
{
public static readonly long[] Value={ 0L,0L,2L,8L,4L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021356Inst : IEnumerable<long>
{
public static readonly long[] Value=A021356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021356.Bytes);
public long this[int i]=>Value[i];

public static A021356Inst Instance=new A021356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021355
{
public static readonly long[] Value={ 0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L,8L,4L,9L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021355Inst : IEnumerable<long>
{
public static readonly long[] Value=A021355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021355.Bytes);
public long this[int i]=>Value[i];

public static A021355Inst Instance=new A021355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021354
{
public static readonly long[] Value={ 1L,14L,129L,994L,6965L,46158L,295513L,1850618L,11423709L,69851782L,424437377L,2568196722L,15496267333L,93328343486L,561380193321L,3373943212906L,20266372059437L,121689277194870L,730500423652945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021354Inst : IEnumerable<long>
{
public static readonly long[] Value=A021354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021354.Bytes);
public long this[int i]=>Value[i];

public static A021354Inst Instance=new A021354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021353
{
public static readonly long[] Value={ 0L,0L,2L,8L,6L,5L,3L,2L,9L,5L,1L,2L,8L,9L,3L,9L,8L,2L,8L,0L,8L,0L,2L,2L,9L,2L,2L,6L,3L,6L,1L,0L,3L,1L,5L,1L,8L,6L,2L,4L,6L,4L,1L,8L,3L,3L,8L,1L,0L,8L,8L,8L,2L,5L,2L,1L,4L,8L,9L,9L,7L,1L,3L,4L,6L,7L,0L,4L,8L,7L,1L,0L,6L,0L,1L,7L,1L,9L,1L,9L,7L,7L,0L,7L,7L,3L,6L,3L,8L,9L,6L,8L,4L,8L,1L,3L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021353Inst : IEnumerable<long>
{
public static readonly long[] Value=A021353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021353.Bytes);
public long this[int i]=>Value[i];

public static A021353Inst Instance=new A021353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021352
{
public static readonly long[] Value={ 0L,0L,2L,8L,7L,3L,5L,6L,3L,2L,1L,8L,3L,9L,0L,8L,0L,4L,5L,9L,7L,7L,0L,1L,1L,4L,9L,4L,2L,5L,2L,8L,7L,3L,5L,6L,3L,2L,1L,8L,3L,9L,0L,8L,0L,4L,5L,9L,7L,7L,0L,1L,1L,4L,9L,4L,2L,5L,2L,8L,7L,3L,5L,6L,3L,2L,1L,8L,3L,9L,0L,8L,0L,4L,5L,9L,7L,7L,0L,1L,1L,4L,9L,4L,2L,5L,2L,8L,7L,3L,5L,6L,3L,2L,1L,8L,3L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021352Inst : IEnumerable<long>
{
public static readonly long[] Value=A021352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021352.Bytes);
public long this[int i]=>Value[i];

public static A021352Inst Instance=new A021352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021351
{
public static readonly long[] Value={ 0L,0L,2L,8L,8L,1L,8L,4L,4L,3L,8L,0L,4L,0L,3L,4L,5L,8L,2L,1L,3L,2L,5L,6L,4L,8L,4L,1L,4L,9L,8L,5L,5L,9L,0L,7L,7L,8L,0L,9L,7L,9L,8L,2L,7L,0L,8L,9L,3L,3L,7L,1L,7L,5L,7L,9L,2L,5L,0L,7L,2L,0L,4L,6L,1L,0L,9L,5L,1L,0L,0L,8L,6L,4L,5L,5L,3L,3L,1L,4L,1L,2L,1L,0L,3L,7L,4L,6L,3L,9L,7L,6L,9L,4L,5L,2L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021351Inst : IEnumerable<long>
{
public static readonly long[] Value=A021351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021351.Bytes);
public long this[int i]=>Value[i];

public static A021351Inst Instance=new A021351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021350
{
public static readonly long[] Value={ 0L,0L,2L,8L,9L,0L,1L,7L,3L,4L,1L,0L,4L,0L,4L,6L,2L,4L,2L,7L,7L,4L,5L,6L,6L,4L,7L,3L,9L,8L,8L,4L,3L,9L,3L,0L,6L,3L,5L,8L,3L,8L,1L,5L,0L,2L,8L,9L,0L,1L,7L,3L,4L,1L,0L,4L,0L,4L,6L,2L,4L,2L,7L,7L,4L,5L,6L,6L,4L,7L,3L,9L,8L,8L,4L,3L,9L,3L,0L,6L,3L,5L,8L,3L,8L,1L,5L,0L,2L,8L,9L,0L,1L,7L,3L,4L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021350Inst : IEnumerable<long>
{
public static readonly long[] Value=A021350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021350.Bytes);
public long this[int i]=>Value[i];

public static A021350Inst Instance=new A021350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021349
{
public static readonly long[] Value={ 0L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L,4L,6L,3L,7L,6L,8L,1L,1L,5L,9L,4L,2L,0L,2L,8L,9L,8L,5L,5L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021349Inst : IEnumerable<long>
{
public static readonly long[] Value=A021349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021349.Bytes);
public long this[int i]=>Value[i];

public static A021349Inst Instance=new A021349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021348
{
public static readonly long[] Value={ 0L,0L,2L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L,0L,4L,6L,5L,1L,1L,6L,2L,7L,9L,0L,6L,9L,7L,6L,7L,4L,4L,1L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021348Inst : IEnumerable<long>
{
public static readonly long[] Value=A021348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021348.Bytes);
public long this[int i]=>Value[i];

public static A021348Inst Instance=new A021348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021347
{
public static readonly long[] Value={ 0L,0L,2L,9L,1L,5L,4L,5L,1L,8L,9L,5L,0L,4L,3L,7L,3L,1L,7L,7L,8L,4L,2L,5L,6L,5L,5L,9L,7L,6L,6L,7L,6L,3L,8L,4L,8L,3L,9L,6L,5L,0L,1L,4L,5L,7L,7L,2L,5L,9L,4L,7L,5L,2L,1L,8L,6L,5L,8L,8L,9L,2L,1L,2L,8L,2L,7L,9L,8L,8L,3L,3L,8L,1L,9L,2L,4L,1L,9L,8L,2L,5L,0L,7L,2L,8L,8L,6L,2L,9L,7L,3L,7L,6L,0L,9L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021347Inst : IEnumerable<long>
{
public static readonly long[] Value=A021347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021347.Bytes);
public long this[int i]=>Value[i];

public static A021347Inst Instance=new A021347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021346
{
public static readonly long[] Value={ 0L,0L,2L,9L,2L,3L,9L,7L,6L,6L,0L,8L,1L,8L,7L,1L,3L,4L,5L,0L,2L,9L,2L,3L,9L,7L,6L,6L,0L,8L,1L,8L,7L,1L,3L,4L,5L,0L,2L,9L,2L,3L,9L,7L,6L,6L,0L,8L,1L,8L,7L,1L,3L,4L,5L,0L,2L,9L,2L,3L,9L,7L,6L,6L,0L,8L,1L,8L,7L,1L,3L,4L,5L,0L,2L,9L,2L,3L,9L,7L,6L,6L,0L,8L,1L,8L,7L,1L,3L,4L,5L,0L,2L,9L,2L,3L,9L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021346Inst : IEnumerable<long>
{
public static readonly long[] Value=A021346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021346.Bytes);
public long this[int i]=>Value[i];

public static A021346Inst Instance=new A021346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021345
{
public static readonly long[] Value={ 0L,0L,2L,9L,3L,2L,5L,5L,1L,3L,1L,9L,6L,4L,8L,0L,9L,3L,8L,4L,1L,6L,4L,2L,2L,2L,8L,7L,3L,9L,0L,0L,2L,9L,3L,2L,5L,5L,1L,3L,1L,9L,6L,4L,8L,0L,9L,3L,8L,4L,1L,6L,4L,2L,2L,2L,8L,7L,3L,9L,0L,0L,2L,9L,3L,2L,5L,5L,1L,3L,1L,9L,6L,4L,8L,0L,9L,3L,8L,4L,1L,6L,4L,2L,2L,2L,8L,7L,3L,9L,0L,0L,2L,9L,3L,2L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021345Inst : IEnumerable<long>
{
public static readonly long[] Value=A021345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021345.Bytes);
public long this[int i]=>Value[i];

public static A021345Inst Instance=new A021345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021344
{
public static readonly long[] Value={ 1L,13L,110L,770L,4851L,28623L,161680L,885940L,4749701L,25058033L,130616850L,674656710L,3460370551L,17652592243L,89673093620L,454027521080L,2292850387401L,11555296775253L,58141244359990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021344Inst : IEnumerable<long>
{
public static readonly long[] Value=A021344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021344.Bytes);
public long this[int i]=>Value[i];

public static A021344Inst Instance=new A021344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021343
{
public static readonly long[] Value={ 0L,0L,2L,9L,4L,9L,8L,5L,2L,5L,0L,7L,3L,7L,4L,6L,3L,1L,2L,6L,8L,4L,3L,6L,5L,7L,8L,1L,7L,1L,0L,9L,1L,4L,4L,5L,4L,2L,7L,7L,2L,8L,6L,1L,3L,5L,6L,9L,3L,2L,1L,5L,3L,3L,9L,2L,3L,3L,0L,3L,8L,3L,4L,8L,0L,8L,2L,5L,9L,5L,8L,7L,0L,2L,0L,6L,4L,8L,9L,6L,7L,5L,5L,1L,6L,2L,2L,4L,1L,8L,8L,7L,9L,0L,5L,6L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021343Inst : IEnumerable<long>
{
public static readonly long[] Value=A021343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021343.Bytes);
public long this[int i]=>Value[i];

public static A021343Inst Instance=new A021343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021342
{
public static readonly long[] Value={ 0L,0L,2L,9L,5L,8L,5L,7L,9L,8L,8L,1L,6L,5L,6L,8L,0L,4L,7L,3L,3L,7L,2L,7L,8L,1L,0L,6L,5L,0L,8L,8L,7L,5L,7L,3L,9L,6L,4L,4L,9L,7L,0L,4L,1L,4L,2L,0L,1L,1L,8L,3L,4L,3L,1L,9L,5L,2L,6L,6L,2L,7L,2L,1L,8L,9L,3L,4L,9L,1L,1L,2L,4L,2L,6L,0L,3L,5L,5L,0L,2L,9L,5L,8L,5L,7L,9L,8L,8L,1L,6L,5L,6L,8L,0L,4L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021342Inst : IEnumerable<long>
{
public static readonly long[] Value=A021342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021342.Bytes);
public long this[int i]=>Value[i];

public static A021342Inst Instance=new A021342Inst();

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