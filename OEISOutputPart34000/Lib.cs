using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A010605
{
public static readonly long[] Value={ 3L,2L,3L,9L,6L,1L,1L,8L,0L,1L,2L,7L,7L,4L,8L,3L,3L,8L,4L,0L,7L,1L,4L,6L,9L,9L,2L,4L,2L,7L,2L,0L,2L,9L,7L,0L,0L,3L,7L,8L,3L,7L,8L,9L,6L,8L,5L,2L,6L,5L,2L,8L,8L,1L,6L,5L,1L,5L,1L,2L,5L,7L,6L,2L,1L,2L,4L,6L,8L,2L,6L,5L,3L,2L,2L,8L,5L,8L,2L,1L,9L,6L,3L,9L,7L,2L,1L,9L,5L,8L,0L,8L,3L,4L,2L,6L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010605Inst : IEnumerable<long>
{
public static readonly long[] Value=A010605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010605.Bytes);
public long this[int i]=>Value[i];

public static A010605Inst Instance=new A010605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010604
{
public static readonly long[] Value={ 3L,2L,0L,7L,5L,3L,4L,3L,2L,9L,9L,9L,5L,8L,2L,6L,4L,8L,7L,5L,5L,2L,5L,1L,5L,1L,7L,1L,7L,1L,9L,5L,2L,0L,1L,1L,1L,3L,6L,1L,8L,5L,1L,6L,6L,3L,3L,6L,0L,5L,7L,2L,1L,7L,1L,7L,2L,4L,0L,7L,1L,8L,4L,7L,2L,8L,3L,8L,1L,4L,9L,8L,0L,9L,7L,6L,3L,8L,9L,1L,9L,8L,9L,1L,0L,3L,0L,3L,5L,2L,0L,2L,5L,1L,2L,0L,1L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010604Inst : IEnumerable<long>
{
public static readonly long[] Value=A010604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010604.Bytes);
public long this[int i]=>Value[i];

public static A010604Inst Instance=new A010604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010603
{
public static readonly long[] Value={ 3L,1L,7L,4L,8L,0L,2L,1L,0L,3L,9L,3L,6L,3L,9L,8L,9L,4L,9L,5L,0L,3L,4L,1L,1L,2L,7L,8L,5L,4L,4L,6L,1L,6L,5L,2L,0L,7L,8L,2L,9L,8L,6L,6L,5L,5L,7L,9L,9L,7L,0L,6L,0L,1L,9L,6L,1L,6L,5L,7L,1L,5L,2L,3L,6L,5L,0L,4L,3L,3L,0L,1L,1L,2L,4L,8L,4L,3L,8L,3L,4L,6L,5L,4L,7L,0L,8L,8L,4L,2L,6L,5L,2L,4L,4L,4L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010603Inst : IEnumerable<long>
{
public static readonly long[] Value=A010603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010603.Bytes);
public long this[int i]=>Value[i];

public static A010603Inst Instance=new A010603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010602
{
public static readonly long[] Value={ 3L,1L,4L,1L,3L,8L,0L,6L,5L,2L,3L,9L,1L,3L,9L,3L,0L,0L,4L,4L,9L,3L,0L,7L,5L,8L,9L,6L,4L,6L,2L,7L,4L,9L,9L,2L,6L,3L,5L,0L,8L,5L,9L,7L,1L,8L,5L,0L,0L,7L,2L,6L,4L,2L,5L,6L,4L,2L,3L,5L,2L,6L,1L,7L,3L,3L,7L,5L,9L,0L,0L,0L,8L,5L,1L,2L,4L,3L,4L,2L,9L,1L,6L,2L,1L,3L,7L,0L,3L,1L,0L,1L,9L,8L,2L,5L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010602Inst : IEnumerable<long>
{
public static readonly long[] Value=A010602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010602.Bytes);
public long this[int i]=>Value[i];

public static A010602Inst Instance=new A010602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010601
{
public static readonly long[] Value={ 3L,1L,0L,7L,2L,3L,2L,5L,0L,5L,9L,5L,3L,8L,5L,8L,8L,6L,6L,8L,7L,7L,6L,6L,2L,4L,2L,7L,5L,2L,2L,3L,8L,6L,3L,6L,2L,8L,5L,4L,9L,0L,6L,8L,2L,9L,0L,6L,7L,4L,2L,2L,0L,0L,1L,4L,7L,1L,0L,3L,8L,4L,0L,4L,2L,5L,9L,1L,3L,0L,7L,2L,2L,6L,8L,2L,5L,0L,2L,1L,6L,2L,8L,6L,6L,6L,2L,1L,8L,3L,8L,4L,2L,2L,1L,4L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010601Inst : IEnumerable<long>
{
public static readonly long[] Value=A010601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010601.Bytes);
public long this[int i]=>Value[i];

public static A010601Inst Instance=new A010601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010600
{
public static readonly long[] Value={ 3L,0L,7L,2L,3L,1L,6L,8L,2L,5L,6L,8L,5L,8L,4L,7L,2L,9L,3L,3L,1L,2L,6L,3L,7L,9L,8L,2L,1L,0L,5L,5L,9L,7L,4L,8L,5L,5L,0L,2L,7L,8L,3L,2L,3L,8L,8L,7L,6L,0L,9L,5L,7L,9L,9L,4L,9L,2L,6L,7L,7L,0L,9L,7L,3L,6L,6L,0L,3L,8L,1L,7L,9L,2L,0L,6L,6L,2L,9L,5L,9L,9L,1L,6L,6L,3L,1L,9L,9L,0L,7L,1L,2L,1L,0L,0L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010600Inst : IEnumerable<long>
{
public static readonly long[] Value=A010600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010600.Bytes);
public long this[int i]=>Value[i];

public static A010600Inst Instance=new A010600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010599
{
public static readonly long[] Value={ 3L,0L,3L,6L,5L,8L,8L,9L,7L,1L,8L,7L,5L,6L,6L,2L,5L,1L,9L,4L,2L,0L,8L,0L,9L,5L,7L,8L,5L,0L,5L,6L,6L,9L,6L,3L,5L,5L,8L,1L,4L,5L,3L,9L,7L,7L,2L,4L,8L,1L,1L,1L,1L,2L,3L,2L,4L,2L,1L,4L,1L,6L,5L,4L,1L,6L,9L,1L,7L,7L,2L,6L,8L,4L,1L,1L,8L,8L,4L,9L,6L,1L,7L,7L,0L,2L,5L,0L,3L,9L,0L,8L,3L,8L,0L,9L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010599Inst : IEnumerable<long>
{
public static readonly long[] Value=A010599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010599.Bytes);
public long this[int i]=>Value[i];

public static A010599Inst Instance=new A010599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010598
{
public static readonly long[] Value={ 2L,9L,6L,2L,4L,9L,6L,0L,6L,8L,4L,0L,7L,3L,7L,0L,5L,0L,8L,6L,7L,3L,0L,6L,2L,1L,8L,9L,3L,4L,1L,8L,3L,8L,5L,3L,7L,5L,6L,6L,3L,5L,7L,4L,2L,2L,3L,1L,8L,8L,6L,6L,4L,3L,5L,7L,6L,6L,3L,2L,6L,3L,3L,7L,1L,6L,9L,4L,2L,2L,4L,3L,2L,5L,9L,8L,4L,8L,2L,4L,2L,2L,8L,9L,3L,7L,9L,9L,6L,2L,1L,2L,2L,8L,7L,5L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010598Inst : IEnumerable<long>
{
public static readonly long[] Value=A010598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010598.Bytes);
public long this[int i]=>Value[i];

public static A010598Inst Instance=new A010598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010597
{
public static readonly long[] Value={ 2L,9L,2L,4L,0L,1L,7L,7L,3L,8L,2L,1L,2L,8L,6L,6L,0L,6L,5L,5L,0L,6L,7L,8L,7L,3L,6L,0L,1L,3L,7L,9L,2L,2L,7L,7L,8L,5L,3L,0L,4L,9L,8L,6L,3L,5L,1L,0L,1L,0L,3L,0L,0L,4L,1L,4L,2L,2L,5L,7L,3L,5L,1L,0L,0L,7L,2L,5L,6L,0L,5L,5L,8L,5L,9L,3L,2L,1L,7L,3L,1L,7L,0L,6L,5L,7L,2L,0L,4L,5L,5L,3L,3L,7L,0L,8L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010597Inst : IEnumerable<long>
{
public static readonly long[] Value=A010597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010597.Bytes);
public long this[int i]=>Value[i];

public static A010597Inst Instance=new A010597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010596
{
public static readonly long[] Value={ 2L,8L,8L,4L,4L,9L,9L,1L,4L,0L,6L,1L,4L,8L,1L,6L,7L,6L,4L,6L,4L,3L,2L,7L,6L,6L,2L,1L,5L,6L,0L,2L,1L,9L,1L,7L,6L,7L,8L,3L,7L,3L,8L,5L,0L,6L,9L,9L,8L,7L,0L,1L,1L,5L,5L,0L,9L,2L,8L,3L,2L,3L,8L,9L,0L,8L,3L,3L,7L,5L,1L,9L,3L,6L,5L,9L,9L,9L,4L,6L,7L,9L,7L,0L,9L,5L,1L,0L,9L,5L,9L,4L,1L,1L,2L,9L,0L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010596Inst : IEnumerable<long>
{
public static readonly long[] Value=A010596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010596.Bytes);
public long this[int i]=>Value[i];

public static A010596Inst Instance=new A010596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010595
{
public static readonly long[] Value={ 2L,8L,4L,3L,8L,6L,6L,9L,7L,9L,8L,5L,1L,5L,6L,5L,4L,7L,7L,6L,9L,5L,4L,3L,9L,4L,0L,0L,9L,5L,8L,6L,5L,1L,8L,5L,2L,7L,6L,4L,1L,6L,5L,1L,7L,2L,7L,3L,7L,0L,4L,8L,1L,0L,4L,6L,5L,3L,4L,2L,5L,2L,3L,0L,2L,3L,5L,4L,4L,0L,8L,6L,0L,9L,6L,8L,5L,4L,9L,8L,7L,6L,0L,6L,4L,7L,3L,6L,6L,4L,0L,5L,4L,4L,4L,3L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010595Inst : IEnumerable<long>
{
public static readonly long[] Value=A010595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010595.Bytes);
public long this[int i]=>Value[i];

public static A010595Inst Instance=new A010595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010594
{
public static readonly long[] Value={ 2L,8L,0L,2L,0L,3L,9L,3L,3L,0L,6L,5L,5L,3L,8L,7L,1L,2L,0L,6L,6L,5L,6L,7L,7L,3L,8L,5L,6L,6L,5L,8L,9L,4L,0L,1L,7L,5L,8L,5L,7L,9L,8L,2L,1L,8L,7L,6L,9L,2L,6L,8L,3L,1L,6L,9L,7L,9L,7L,8L,3L,7L,3L,3L,7L,8L,3L,7L,5L,0L,1L,4L,6L,0L,1L,7L,8L,7L,4L,8L,6L,8L,1L,1L,5L,3L,4L,6L,2L,4L,9L,8L,9L,4L,1L,4L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010594Inst : IEnumerable<long>
{
public static readonly long[] Value=A010594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010594.Bytes);
public long this[int i]=>Value[i];

public static A010594Inst Instance=new A010594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010593
{
public static readonly long[] Value={ 2L,7L,5L,8L,9L,2L,4L,1L,7L,6L,3L,8L,1L,1L,2L,0L,6L,6L,9L,4L,6L,5L,7L,9L,1L,1L,0L,8L,3L,5L,8L,5L,2L,1L,5L,8L,2L,2L,5L,2L,7L,1L,2L,0L,8L,6L,0L,3L,8L,9L,3L,6L,0L,3L,2L,8L,0L,6L,5L,9L,2L,5L,0L,2L,1L,6L,2L,7L,9L,9L,1L,4L,1L,0L,8L,7L,0L,4L,3L,7L,3L,7L,9L,1L,2L,6L,3L,2L,1L,5L,8L,5L,2L,4L,4L,3L,7L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010593Inst : IEnumerable<long>
{
public static readonly long[] Value=A010593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010593.Bytes);
public long this[int i]=>Value[i];

public static A010593Inst Instance=new A010593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010592
{
public static readonly long[] Value={ 2L,7L,1L,4L,4L,1L,7L,6L,1L,6L,5L,9L,4L,9L,0L,6L,5L,7L,1L,5L,1L,8L,0L,8L,9L,4L,6L,9L,6L,7L,9L,4L,8L,9L,2L,0L,4L,8L,0L,5L,1L,0L,7L,7L,6L,9L,4L,8L,9L,0L,9L,6L,9L,5L,7L,2L,8L,4L,3L,6L,5L,4L,4L,2L,8L,0L,3L,3L,0L,8L,5L,5L,6L,3L,2L,8L,7L,6L,5L,8L,4L,9L,4L,8L,7L,1L,9L,7L,3L,7L,6L,8L,5L,1L,5L,0L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010592Inst : IEnumerable<long>
{
public static readonly long[] Value=A010592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010592.Bytes);
public long this[int i]=>Value[i];

public static A010592Inst Instance=new A010592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010591
{
public static readonly long[] Value={ 2L,6L,6L,8L,4L,0L,1L,6L,4L,8L,7L,2L,1L,9L,4L,4L,8L,6L,7L,3L,3L,9L,6L,2L,7L,3L,7L,1L,9L,7L,0L,8L,3L,0L,3L,3L,5L,0L,9L,5L,8L,7L,8L,5L,6L,9L,1L,8L,3L,1L,0L,1L,8L,6L,5L,6L,6L,4L,2L,1L,3L,5L,8L,6L,9L,4L,5L,7L,9L,3L,9L,7L,1L,6L,7L,2L,0L,5L,9L,7L,1L,6L,3L,1L,6L,6L,8L,1L,5L,9L,3L,1L,0L,0L,5L,1L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010591Inst : IEnumerable<long>
{
public static readonly long[] Value=A010591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010591.Bytes);
public long this[int i]=>Value[i];

public static A010591Inst Instance=new A010591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010590
{
public static readonly long[] Value={ 2L,6L,2L,0L,7L,4L,1L,3L,9L,4L,2L,0L,8L,8L,9L,6L,6L,0L,7L,1L,4L,1L,6L,6L,1L,2L,8L,0L,4L,4L,1L,9L,9L,6L,2L,7L,0L,2L,3L,9L,4L,2L,7L,6L,4L,5L,7L,2L,3L,6L,3L,1L,7L,2L,5L,1L,0L,2L,7L,7L,3L,8L,0L,5L,7L,2L,8L,6L,9L,9L,8L,1L,9L,1L,9L,6L,0L,4L,2L,1L,0L,8L,8L,2L,8L,4L,5L,5L,8L,2L,5L,9L,8L,9L,0L,7L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010590Inst : IEnumerable<long>
{
public static readonly long[] Value=A010590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010590.Bytes);
public long this[int i]=>Value[i];

public static A010590Inst Instance=new A010590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010573
{
public static readonly long[] Value={ 5L,40L,1040L,39120L,1746760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010573Inst : IEnumerable<long>
{
public static readonly long[] Value=A010573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010573.Bytes);
public long this[int i]=>Value[i];

public static A010573Inst Instance=new A010573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010572
{
public static readonly long[] Value={ 4L,24L,432L,10512L,290552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010572Inst : IEnumerable<long>
{
public static readonly long[] Value=A010572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010572.Bytes);
public long this[int i]=>Value[i];

public static A010572Inst Instance=new A010572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010571
{
public static readonly long[] Value={ 3L,12L,120L,1368L,18300L,268728L,4180860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010571Inst : IEnumerable<long>
{
public static readonly long[] Value=A010571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010571.Bytes);
public long this[int i]=>Value[i];

public static A010571Inst Instance=new A010571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010570
{
public static readonly long[] Value={ 12L,120L,4200L,216720L,13594320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010570Inst : IEnumerable<long>
{
public static readonly long[] Value=A010570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010570.Bytes);
public long this[int i]=>Value[i];

public static A010570Inst Instance=new A010570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010569
{
public static readonly long[] Value={ 10L,80L,2160L,82720L,3737120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010569Inst : IEnumerable<long>
{
public static readonly long[] Value=A010569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010569.Bytes);
public long this[int i]=>Value[i];

public static A010569Inst Instance=new A010569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010568
{
public static readonly long[] Value={ 8L,48L,912L,22944L,652320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010568Inst : IEnumerable<long>
{
public static readonly long[] Value=A010568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010568.Bytes);
public long this[int i]=>Value[i];

public static A010568Inst Instance=new A010568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010567
{
public static readonly long[] Value={ 6L,24L,264L,3312L,48240L,762096L,12673920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010567Inst : IEnumerable<long>
{
public static readonly long[] Value=A010567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010567.Bytes);
public long this[int i]=>Value[i];

public static A010567Inst Instance=new A010567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010566
{
public static readonly long[] Value={ 0L,8L,24L,112L,560L,2976L,16464L,94016L,549648L,3273040L,19781168L,121020960L,748039552L,4664263744L,29303071680L,185307690240L,1178635456752L,7535046744864L,48392012257184L,312061600211680L,2019822009608592L,13117263660884768L,85447982919036736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010566Inst : IEnumerable<long>
{
public static readonly long[] Value=A010566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010566.Bytes);
public long this[int i]=>Value[i];

public static A010566Inst Instance=new A010566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010565
{
public static readonly long[] Value={ 1L,8L,94L,1232L,17916L,278088L,4536836L,76800064L,1338190014L,23861081448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010565Inst : IEnumerable<long>
{
public static readonly long[] Value=A010565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010565.Bytes);
public long this[int i]=>Value[i];

public static A010565Inst Instance=new A010565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010564
{
public static readonly long[] Value={ 1L,50L,4264L,474208L,61159218L,8651484328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010564Inst : IEnumerable<long>
{
public static readonly long[] Value=A010564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010564.Bytes);
public long this[int i]=>Value[i];

public static A010564Inst Instance=new A010564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010563
{
public static readonly long[] Value={ 1L,6L,108L,2628L,72638L,2200108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010563Inst : IEnumerable<long>
{
public static readonly long[] Value=A010563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010563.Bytes);
public long this[int i]=>Value[i];

public static A010563Inst Instance=new A010563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010562
{
public static readonly long[] Value={ 24L,1152L,40344L,1237632L,35267640L,958763904L,25226225976L,647984522496L,16341539178744L,406175271393384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010562Inst : IEnumerable<long>
{
public static readonly long[] Value=A010562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010562.Bytes);
public long this[int i]=>Value[i];

public static A010562Inst Instance=new A010562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010561
{
public static readonly long[] Value={ 24L,552L,12504L,280920L,6280824L,139986456L,3113177400L,69123011832L,1532877910008L,33960365608008L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010561Inst : IEnumerable<long>
{
public static readonly long[] Value=A010561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010561.Bytes);
public long this[int i]=>Value[i];

public static A010561Inst Instance=new A010561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010560
{
public static readonly long[] Value={ 16L,512L,11792L,238592L,4480592L,80330752L,1393717968L,23613960192L,392797482960L,6440613392384L,104370678165520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010560Inst : IEnumerable<long>
{
public static readonly long[] Value=A010560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010560.Bytes);
public long this[int i]=>Value[i];

public static A010560Inst Instance=new A010560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010559
{
public static readonly long[] Value={ 16L,240L,3600L,53200L,786000L,11543952L,169538256L,2482215952L,36341716432L,531081176880L,7760918381072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010559Inst : IEnumerable<long>
{
public static readonly long[] Value=A010559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010559.Bytes);
public long this[int i]=>Value[i];

public static A010559Inst Instance=new A010559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010558
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,4L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010558Inst : IEnumerable<long>
{
public static readonly long[] Value=A010558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010558.Bytes);
public long this[int i]=>Value[i];

public static A010558Inst Instance=new A010558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010557
{
public static readonly long[] Value={ 1L,32L,584L,8288L,101240L,1121120L,11570360L,113293088L,1064631032L,9681082144L,85688330696L,741562925664L,6296196525768L,52589092312288L,433044168426616L,3521747918221984L,28326976016327032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010557Inst : IEnumerable<long>
{
public static readonly long[] Value=A010557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010557.Bytes);
public long this[int i]=>Value[i];

public static A010557Inst Instance=new A010557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010556
{
public static readonly long[] Value={ 1L,8L,56L,392L,2696L,18536L,126536L,863720L,5873768L,39942184L,271009112L,1838725896L,12457092504L,84392312392L,571140732808L,3865210690888L,26138072412040L,176752645540264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010556Inst : IEnumerable<long>
{
public static readonly long[] Value=A010556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010556.Bytes);
public long this[int i]=>Value[i];

public static A010556Inst Instance=new A010556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010555
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010555Inst : IEnumerable<long>
{
public static readonly long[] Value=A010555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010555.Bytes);
public long this[int i]=>Value[i];

public static A010555Inst Instance=new A010555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010554
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,4L,2L,4L,2L,4L,4L,8L,2L,6L,4L,4L,4L,10L,4L,8L,4L,6L,4L,12L,4L,8L,8L,8L,8L,8L,4L,12L,6L,8L,8L,16L,4L,12L,8L,8L,10L,22L,8L,12L,8L,16L,8L,24L,6L,16L,8L,12L,12L,28L,8L,16L,8L,12L,16L,16L,8L,20L,16L,20L,8L,24L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010554Inst : IEnumerable<long>
{
public static readonly long[] Value=A010554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010554.Bytes);
public long this[int i]=>Value[i];

public static A010554Inst Instance=new A010554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010553
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,2L,3L,2L,3L,2L,4L,2L,3L,3L,2L,2L,4L,2L,4L,3L,3L,2L,4L,2L,3L,3L,4L,2L,4L,2L,4L,3L,3L,3L,3L,2L,3L,3L,4L,2L,4L,2L,4L,4L,3L,2L,4L,2L,4L,3L,4L,2L,4L,3L,4L,3L,3L,2L,6L,2L,3L,4L,2L,3L,4L,2L,4L,3L,4L,2L,6L,2L,3L,4L,4L,3L,4L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010553Inst : IEnumerable<long>
{
public static readonly long[] Value=A010553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010553.Bytes);
public long this[int i]=>Value[i];

public static A010553Inst Instance=new A010553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010552
{
public static readonly long[] Value={ 1L,1L,2L,4L,12L,36L,108L,432L,1728L,6912L,27648L,138240L,691200L,3456000L,17280000L,86400000L,518400000L,3110400000L,18662400000L,111974400000L,671846400000L,4031078400000L,28217548800000L,197522841600000L,1382659891200000L,9678619238400000L,67750334668800000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010552Inst : IEnumerable<long>
{
public static readonly long[] Value=A010552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010552.Bytes);
public long this[int i]=>Value[i];

public static A010552Inst Instance=new A010552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010551
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,12L,36L,144L,576L,2880L,14400L,86400L,518400L,3628800L,25401600L,203212800L,1625702400L,14631321600L,131681894400L,1316818944000L,13168189440000L,144850083840000L,1593350922240000L,19120211066880000L,229442532802560000L,2982752926433280000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010551Inst : IEnumerable<long>
{
public static readonly long[] Value=A010551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010551.Bytes);
public long this[int i]=>Value[i];

public static A010551Inst Instance=new A010551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010550
{
public static readonly long[] Value={ 9L,9L,4L,9L,8L,7L,4L,3L,7L,1L,0L,6L,6L,1L,9L,9L,5L,4L,7L,3L,4L,4L,7L,9L,8L,2L,1L,0L,0L,1L,2L,0L,6L,0L,0L,5L,1L,7L,8L,1L,2L,6L,5L,6L,3L,6L,7L,6L,8L,0L,6L,0L,7L,9L,1L,1L,7L,6L,0L,4L,6L,4L,3L,8L,3L,4L,9L,4L,5L,3L,9L,2L,7L,8L,2L,7L,1L,3L,1L,5L,4L,0L,1L,2L,6L,5L,3L,0L,1L,9L,7L,3L,8L,4L,8L,7L,1L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010550Inst : IEnumerable<long>
{
public static readonly long[] Value=A010550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010550.Bytes);
public long this[int i]=>Value[i];

public static A010550Inst Instance=new A010550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010549
{
public static readonly long[] Value={ 9L,8L,9L,9L,4L,9L,4L,9L,3L,6L,6L,1L,1L,6L,6L,5L,3L,4L,1L,6L,1L,1L,8L,2L,1L,0L,6L,9L,4L,6L,7L,8L,8L,6L,5L,4L,9L,9L,8L,7L,7L,0L,3L,1L,2L,7L,6L,3L,8L,6L,3L,6L,5L,1L,2L,2L,3L,6L,7L,5L,8L,1L,6L,5L,9L,3L,5L,1L,2L,7L,3L,4L,9L,2L,3L,4L,7L,4L,9L,2L,7L,1L,9L,5L,2L,7L,1L,2L,7L,4L,0L,2L,9L,3L,4L,9L,1L,0L,0L,9L,1L,4L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010549Inst : IEnumerable<long>
{
public static readonly long[] Value=A010549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010549.Bytes);
public long this[int i]=>Value[i];

public static A010549Inst Instance=new A010549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010548
{
public static readonly long[] Value={ 9L,8L,4L,8L,8L,5L,7L,8L,0L,1L,7L,9L,6L,1L,0L,4L,7L,2L,1L,7L,4L,6L,2L,1L,1L,4L,1L,4L,9L,1L,7L,6L,2L,4L,4L,8L,1L,6L,9L,6L,1L,3L,6L,2L,8L,7L,4L,4L,2L,7L,6L,4L,1L,7L,1L,7L,2L,3L,1L,5L,4L,5L,2L,9L,8L,3L,6L,4L,4L,0L,5L,8L,3L,7L,0L,7L,6L,7L,8L,6L,3L,0L,0L,9L,3L,2L,0L,0L,7L,8L,4L,1L,1L,5L,4L,2L,5L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010548Inst : IEnumerable<long>
{
public static readonly long[] Value=A010548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010548.Bytes);
public long this[int i]=>Value[i];

public static A010548Inst Instance=new A010548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010547
{
public static readonly long[] Value={ 9L,7L,9L,7L,9L,5L,8L,9L,7L,1L,1L,3L,2L,7L,1L,2L,3L,9L,2L,7L,8L,9L,1L,3L,6L,2L,9L,8L,8L,2L,3L,5L,6L,5L,5L,6L,7L,8L,6L,3L,7L,8L,9L,9L,2L,2L,6L,2L,6L,6L,8L,0L,5L,1L,3L,7L,3L,0L,7L,7L,0L,2L,6L,9L,0L,0L,3L,8L,4L,1L,5L,0L,9L,8L,2L,9L,2L,6L,0L,1L,0L,6L,1L,5L,9L,4L,3L,7L,7L,3L,2L,4L,1L,8L,5L,6L,0L,9L,3L,9L,2L,7L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010547Inst : IEnumerable<long>
{
public static readonly long[] Value=A010547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010547.Bytes);
public long this[int i]=>Value[i];

public static A010547Inst Instance=new A010547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010546
{
public static readonly long[] Value={ 9L,7L,4L,6L,7L,9L,4L,3L,4L,4L,8L,0L,8L,9L,6L,3L,9L,0L,6L,8L,3L,8L,4L,1L,3L,1L,9L,9L,8L,9L,9L,6L,0L,0L,2L,9L,9L,2L,5L,2L,5L,8L,3L,9L,0L,0L,3L,3L,7L,4L,9L,1L,0L,3L,1L,9L,9L,1L,7L,5L,0L,0L,0L,5L,7L,2L,0L,0L,8L,1L,7L,7L,2L,4L,6L,0L,2L,4L,9L,3L,5L,6L,8L,4L,8L,7L,1L,2L,0L,9L,6L,0L,3L,8L,0L,6L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010546Inst : IEnumerable<long>
{
public static readonly long[] Value=A010546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010546.Bytes);
public long this[int i]=>Value[i];

public static A010546Inst Instance=new A010546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010545
{
public static readonly long[] Value={ 9L,6L,9L,5L,3L,5L,9L,7L,1L,4L,8L,3L,2L,6L,5L,8L,0L,2L,8L,1L,4L,8L,8L,8L,1L,1L,5L,0L,8L,4L,5L,3L,1L,3L,3L,9L,3L,6L,5L,2L,1L,5L,0L,9L,8L,7L,9L,5L,4L,6L,7L,9L,5L,9L,0L,5L,3L,9L,7L,1L,7L,4L,8L,6L,2L,3L,3L,0L,3L,9L,8L,6L,7L,5L,7L,3L,3L,0L,0L,7L,2L,8L,4L,8L,3L,2L,5L,8L,6L,7L,8L,4L,7L,6L,9L,1L,7L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010545Inst : IEnumerable<long>
{
public static readonly long[] Value=A010545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010545.Bytes);
public long this[int i]=>Value[i];

public static A010545Inst Instance=new A010545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010544
{
public static readonly long[] Value={ 9L,6L,4L,3L,6L,5L,0L,7L,6L,0L,9L,9L,2L,9L,5L,4L,9L,9L,5L,7L,6L,0L,0L,3L,1L,0L,4L,7L,4L,3L,2L,6L,6L,3L,1L,8L,3L,9L,0L,6L,9L,0L,3L,6L,9L,3L,0L,6L,3L,2L,5L,2L,4L,0L,7L,3L,0L,0L,1L,7L,6L,8L,8L,7L,7L,3L,1L,2L,8L,6L,4L,1L,8L,6L,6L,8L,6L,4L,9L,7L,2L,2L,9L,0L,0L,0L,5L,4L,7L,0L,9L,2L,9L,3L,6L,0L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010544Inst : IEnumerable<long>
{
public static readonly long[] Value=A010544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010544.Bytes);
public long this[int i]=>Value[i];

public static A010544Inst Instance=new A010544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010543
{
public static readonly long[] Value={ 9L,5L,9L,1L,6L,6L,3L,0L,4L,6L,6L,2L,5L,4L,3L,9L,0L,8L,3L,1L,9L,4L,8L,7L,6L,1L,2L,8L,3L,2L,5L,3L,8L,7L,8L,3L,9L,9L,9L,3L,4L,1L,4L,0L,8L,3L,8L,0L,8L,2L,5L,8L,6L,9L,2L,9L,7L,0L,6L,1L,8L,2L,2L,8L,8L,9L,6L,5L,1L,4L,4L,7L,1L,8L,1L,4L,9L,2L,8L,1L,6L,4L,9L,8L,4L,3L,8L,2L,8L,9L,2L,8L,7L,3L,8L,3L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010543Inst : IEnumerable<long>
{
public static readonly long[] Value=A010543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010543.Bytes);
public long this[int i]=>Value[i];

public static A010543Inst Instance=new A010543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010542
{
public static readonly long[] Value={ 9L,5L,3L,9L,3L,9L,2L,0L,1L,4L,1L,6L,9L,4L,5L,6L,4L,9L,1L,5L,2L,6L,2L,1L,5L,8L,6L,0L,2L,3L,2L,2L,6L,5L,4L,0L,2L,5L,4L,6L,2L,3L,4L,2L,5L,2L,5L,0L,5L,4L,5L,7L,5L,3L,9L,0L,8L,1L,5L,1L,8L,5L,2L,9L,1L,0L,3L,6L,2L,5L,5L,2L,3L,0L,5L,6L,5L,0L,7L,2L,1L,8L,2L,7L,7L,8L,2L,1L,7L,6L,4L,4L,9L,1L,2L,2L,0L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010542Inst : IEnumerable<long>
{
public static readonly long[] Value=A010542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010542.Bytes);
public long this[int i]=>Value[i];

public static A010542Inst Instance=new A010542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010541
{
public static readonly long[] Value={ 9L,4L,8L,6L,8L,3L,2L,9L,8L,0L,5L,0L,5L,1L,3L,7L,9L,9L,5L,9L,9L,6L,6L,8L,0L,6L,3L,3L,2L,9L,8L,1L,5L,5L,6L,0L,1L,1L,5L,8L,6L,6L,5L,4L,1L,7L,9L,7L,5L,6L,5L,0L,4L,8L,0L,5L,7L,2L,5L,1L,4L,5L,5L,8L,3L,7L,7L,7L,8L,3L,3L,1L,5L,9L,1L,7L,7L,1L,4L,6L,6L,4L,0L,3L,2L,7L,4L,4L,3L,2L,5L,1L,3L,7L,9L,0L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010541Inst : IEnumerable<long>
{
public static readonly long[] Value=A010541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010541.Bytes);
public long this[int i]=>Value[i];

public static A010541Inst Instance=new A010541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010540
{
public static readonly long[] Value={ 9L,4L,3L,3L,9L,8L,1L,1L,3L,2L,0L,5L,6L,6L,0L,3L,8L,1L,1L,3L,2L,0L,6L,6L,0L,3L,7L,7L,6L,2L,2L,6L,4L,0L,7L,1L,6L,9L,8L,3L,6L,2L,2L,6L,3L,3L,4L,1L,5L,1L,2L,1L,3L,2L,0L,6L,6L,2L,9L,8L,1L,4L,4L,8L,9L,8L,0L,0L,2L,2L,9L,0L,9L,5L,8L,5L,1L,1L,8L,0L,5L,8L,5L,4L,1L,0L,2L,6L,9L,8L,6L,8L,9L,0L,3L,8L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010540Inst : IEnumerable<long>
{
public static readonly long[] Value=A010540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010540.Bytes);
public long this[int i]=>Value[i];

public static A010540Inst Instance=new A010540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010539
{
public static readonly long[] Value={ 9L,3L,8L,0L,8L,3L,1L,5L,1L,9L,6L,4L,6L,8L,5L,9L,1L,0L,9L,1L,3L,1L,2L,6L,0L,2L,2L,7L,0L,8L,8L,9L,3L,2L,5L,6L,1L,1L,7L,6L,4L,5L,6L,7L,0L,6L,8L,2L,3L,4L,7L,4L,3L,0L,7L,2L,1L,1L,4L,0L,3L,7L,8L,2L,0L,3L,4L,0L,4L,9L,2L,6L,5L,5L,0L,6L,4L,7L,9L,4L,4L,2L,9L,6L,4L,2L,3L,1L,1L,9L,2L,1L,2L,3L,0L,8L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010539Inst : IEnumerable<long>
{
public static readonly long[] Value=A010539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010539.Bytes);
public long this[int i]=>Value[i];

public static A010539Inst Instance=new A010539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010538
{
public static readonly long[] Value={ 9L,3L,2L,7L,3L,7L,9L,0L,5L,3L,0L,8L,8L,8L,1L,5L,0L,4L,5L,5L,5L,4L,4L,7L,5L,5L,4L,2L,3L,2L,0L,5L,5L,6L,9L,8L,3L,2L,7L,6L,2L,4L,0L,6L,9L,4L,1L,9L,1L,6L,5L,4L,6L,7L,1L,0L,5L,6L,1L,9L,7L,2L,9L,8L,4L,4L,6L,7L,8L,4L,5L,4L,8L,8L,0L,7L,2L,4L,9L,6L,7L,8L,4L,1L,4L,2L,2L,0L,5L,6L,2L,9L,1L,1L,8L,8L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010538Inst : IEnumerable<long>
{
public static readonly long[] Value=A010538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010538.Bytes);
public long this[int i]=>Value[i];

public static A010538Inst Instance=new A010538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010537
{
public static readonly long[] Value={ 9L,2L,7L,3L,6L,1L,8L,4L,9L,5L,4L,9L,5L,7L,0L,3L,7L,5L,2L,5L,1L,6L,4L,1L,6L,0L,7L,3L,9L,9L,0L,1L,7L,4L,6L,2L,6L,2L,6L,3L,4L,6L,8L,9L,1L,2L,0L,7L,6L,2L,9L,8L,2L,1L,3L,3L,7L,3L,8L,2L,6L,5L,9L,8L,3L,2L,8L,2L,3L,6L,8L,3L,6L,4L,6L,3L,8L,4L,3L,0L,2L,3L,2L,3L,2L,0L,4L,5L,8L,5L,7L,3L,5L,8L,4L,7L,4L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010537Inst : IEnumerable<long>
{
public static readonly long[] Value=A010537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010537.Bytes);
public long this[int i]=>Value[i];

public static A010537Inst Instance=new A010537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010536
{
public static readonly long[] Value={ 9L,2L,1L,9L,5L,4L,4L,4L,5L,7L,2L,9L,2L,8L,8L,7L,3L,1L,0L,0L,0L,2L,2L,7L,4L,2L,8L,1L,7L,6L,2L,7L,9L,3L,1L,5L,7L,2L,4L,6L,8L,0L,5L,0L,4L,8L,7L,2L,2L,4L,6L,4L,0L,0L,8L,0L,0L,7L,7L,5L,2L,2L,0L,5L,4L,4L,2L,6L,7L,1L,0L,2L,6L,8L,0L,1L,8L,7L,5L,4L,6L,0L,7L,6L,7L,8L,9L,4L,0L,9L,0L,7L,9L,3L,2L,8L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010536Inst : IEnumerable<long>
{
public static readonly long[] Value=A010536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010536.Bytes);
public long this[int i]=>Value[i];

public static A010536Inst Instance=new A010536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010535
{
public static readonly long[] Value={ 9L,1L,6L,5L,1L,5L,1L,3L,8L,9L,9L,1L,1L,6L,8L,0L,0L,1L,3L,1L,7L,6L,0L,9L,4L,3L,8L,7L,4L,5L,6L,0L,1L,6L,9L,7L,7L,9L,6L,8L,9L,1L,3L,1L,5L,3L,5L,3L,5L,9L,4L,3L,8L,0L,5L,2L,1L,4L,4L,8L,4L,2L,4L,7L,8L,1L,3L,7L,3L,6L,8L,5L,1L,0L,9L,5L,5L,4L,1L,7L,7L,3L,2L,0L,8L,7L,2L,3L,1L,1L,8L,9L,8L,6L,8L,9L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010535Inst : IEnumerable<long>
{
public static readonly long[] Value=A010535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010535.Bytes);
public long this[int i]=>Value[i];

public static A010535Inst Instance=new A010535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010534
{
public static readonly long[] Value={ 9L,1L,1L,0L,4L,3L,3L,5L,7L,9L,1L,4L,4L,2L,9L,8L,8L,8L,1L,9L,4L,5L,6L,2L,6L,1L,0L,4L,6L,8L,8L,6L,6L,9L,1L,9L,0L,0L,9L,9L,1L,3L,9L,1L,6L,8L,2L,6L,4L,9L,5L,5L,8L,5L,2L,4L,9L,6L,9L,3L,8L,4L,6L,5L,0L,6L,6L,0L,2L,1L,1L,9L,4L,2L,8L,3L,4L,0L,5L,6L,6L,5L,5L,8L,5L,3L,4L,1L,4L,6L,0L,9L,2L,9L,1L,7L,7L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010534Inst : IEnumerable<long>
{
public static readonly long[] Value=A010534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010534.Bytes);
public long this[int i]=>Value[i];

public static A010534Inst Instance=new A010534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010533
{
public static readonly long[] Value={ 9L,0L,5L,5L,3L,8L,5L,1L,3L,8L,1L,3L,7L,4L,1L,6L,6L,2L,6L,5L,7L,3L,8L,0L,8L,1L,6L,6L,9L,8L,4L,0L,6L,6L,4L,1L,3L,0L,5L,2L,1L,2L,4L,4L,6L,4L,0L,9L,6L,9L,4L,0L,2L,7L,6L,5L,8L,1L,7L,4L,1L,2L,3L,0L,0L,1L,8L,6L,5L,7L,9L,8L,0L,7L,6L,6L,0L,5L,9L,2L,3L,3L,3L,8L,4L,9L,6L,0L,6L,7L,8L,5L,9L,0L,9L,9L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010533Inst : IEnumerable<long>
{
public static readonly long[] Value=A010533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010533.Bytes);
public long this[int i]=>Value[i];

public static A010533Inst Instance=new A010533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010532
{
public static readonly long[] Value={ 8L,9L,4L,4L,2L,7L,1L,9L,0L,9L,9L,9L,9L,1L,5L,8L,7L,8L,5L,6L,3L,6L,6L,9L,4L,6L,7L,4L,9L,2L,5L,1L,0L,4L,9L,4L,1L,7L,6L,2L,4L,7L,3L,4L,3L,8L,4L,4L,6L,1L,0L,2L,8L,9L,7L,0L,8L,3L,5L,8L,8L,9L,8L,1L,6L,4L,2L,0L,8L,3L,7L,0L,2L,5L,5L,1L,2L,1L,9L,5L,9L,7L,6L,5L,7L,6L,5L,7L,6L,3L,3L,5L,1L,5L,1L,2L,9L,0L,9L,9L,8L,7L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010532Inst : IEnumerable<long>
{
public static readonly long[] Value=A010532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010532.Bytes);
public long this[int i]=>Value[i];

public static A010532Inst Instance=new A010532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010531
{
public static readonly long[] Value={ 8L,8L,8L,8L,1L,9L,4L,4L,1L,7L,3L,1L,5L,5L,8L,8L,8L,5L,0L,0L,9L,1L,4L,4L,1L,6L,7L,5L,4L,0L,8L,7L,2L,7L,8L,1L,7L,0L,7L,6L,4L,5L,0L,6L,0L,3L,7L,2L,9L,5L,2L,6L,2L,9L,8L,3L,5L,4L,7L,2L,0L,1L,1L,6L,3L,7L,6L,1L,0L,0L,5L,9L,9L,6L,2L,8L,5L,9L,9L,5L,9L,6L,0L,2L,3L,5L,9L,2L,9L,5L,2L,7L,1L,3L,6L,3L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010531Inst : IEnumerable<long>
{
public static readonly long[] Value=A010531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010531.Bytes);
public long this[int i]=>Value[i];

public static A010531Inst Instance=new A010531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010530
{
public static readonly long[] Value={ 8L,8L,3L,1L,7L,6L,0L,8L,6L,6L,3L,2L,7L,8L,4L,6L,8L,5L,4L,7L,6L,4L,0L,4L,2L,7L,2L,6L,9L,5L,9L,2L,5L,3L,9L,6L,4L,1L,7L,4L,6L,3L,9L,4L,8L,0L,9L,3L,1L,4L,1L,7L,8L,2L,6L,2L,1L,0L,2L,0L,2L,9L,7L,2L,5L,5L,7L,1L,3L,9L,9L,3L,8L,2L,3L,5L,4L,4L,2L,8L,4L,0L,3L,7L,0L,4L,3L,5L,5L,3L,9L,4L,1L,4L,7L,7L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010530Inst : IEnumerable<long>
{
public static readonly long[] Value=A010530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010530.Bytes);
public long this[int i]=>Value[i];

public static A010530Inst Instance=new A010530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010529
{
public static readonly long[] Value={ 8L,7L,7L,4L,9L,6L,4L,3L,8L,7L,3L,9L,2L,1L,2L,2L,0L,6L,0L,4L,0L,6L,3L,8L,8L,3L,0L,7L,4L,1L,6L,3L,0L,9L,5L,6L,0L,8L,7L,5L,8L,7L,6L,8L,2L,7L,5L,5L,4L,5L,0L,3L,5L,9L,0L,9L,2L,7L,6L,9L,5L,6L,2L,9L,7L,8L,2L,7L,6L,4L,6L,4L,6L,2L,1L,9L,3L,0L,6L,2L,8L,1L,6L,7L,5L,6L,9L,3L,1L,5L,7L,0L,6L,8L,7L,0L,5L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010529Inst : IEnumerable<long>
{
public static readonly long[] Value=A010529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010529.Bytes);
public long this[int i]=>Value[i];

public static A010529Inst Instance=new A010529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010528
{
public static readonly long[] Value={ 8L,7L,1L,7L,7L,9L,7L,8L,8L,7L,0L,8L,1L,3L,4L,7L,1L,0L,4L,4L,7L,3L,9L,6L,3L,9L,6L,7L,7L,1L,9L,2L,3L,1L,3L,1L,8L,2L,7L,4L,0L,0L,7L,8L,5L,0L,4L,6L,4L,8L,8L,9L,8L,7L,3L,7L,8L,0L,6L,8L,8L,2L,7L,6L,3L,1L,9L,1L,1L,4L,6L,5L,6L,4L,0L,6L,3L,1L,6L,1L,7L,1L,3L,1L,2L,3L,1L,8L,3L,1L,1L,7L,0L,3L,8L,8L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010528Inst : IEnumerable<long>
{
public static readonly long[] Value=A010528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010528.Bytes);
public long this[int i]=>Value[i];

public static A010528Inst Instance=new A010528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010527
{
public static readonly long[] Value={ 8L,6L,6L,0L,2L,5L,4L,0L,3L,7L,8L,4L,4L,3L,8L,6L,4L,6L,7L,6L,3L,7L,2L,3L,1L,7L,0L,7L,5L,2L,9L,3L,6L,1L,8L,3L,4L,7L,1L,4L,0L,2L,6L,2L,6L,9L,0L,5L,1L,9L,0L,3L,1L,4L,0L,2L,7L,9L,0L,3L,4L,8L,9L,7L,2L,5L,9L,6L,6L,5L,0L,8L,4L,5L,4L,4L,0L,0L,0L,1L,8L,5L,4L,0L,5L,7L,3L,0L,9L,3L,3L,7L,8L,6L,2L,4L,2L,8L,7L,8L,3L,7L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010527Inst : IEnumerable<long>
{
public static readonly long[] Value=A010527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010527.Bytes);
public long this[int i]=>Value[i];

public static A010527Inst Instance=new A010527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010526
{
public static readonly long[] Value={ 8L,6L,0L,2L,3L,2L,5L,2L,6L,7L,0L,4L,2L,6L,2L,6L,7L,7L,1L,7L,2L,9L,4L,7L,3L,5L,3L,5L,0L,4L,9L,7L,1L,3L,6L,3L,2L,0L,2L,7L,5L,3L,5L,5L,5L,7L,2L,9L,0L,7L,3L,5L,6L,1L,9L,5L,0L,8L,0L,4L,5L,6L,4L,1L,2L,3L,7L,4L,2L,6L,9L,3L,4L,6L,6L,3L,0L,1L,7L,0L,1L,2L,7L,8L,3L,3L,3L,0L,8L,9L,0L,6L,9L,8L,9L,6L,2L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010526Inst : IEnumerable<long>
{
public static readonly long[] Value=A010526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010526.Bytes);
public long this[int i]=>Value[i];

public static A010526Inst Instance=new A010526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010525
{
public static readonly long[] Value={ 8L,5L,4L,4L,0L,0L,3L,7L,4L,5L,3L,1L,7L,5L,3L,1L,1L,6L,7L,8L,7L,1L,6L,4L,8L,3L,2L,6L,2L,3L,9L,7L,0L,6L,4L,3L,4L,5L,9L,4L,4L,5L,5L,3L,2L,9L,5L,3L,3L,2L,8L,2L,2L,4L,1L,9L,0L,8L,6L,5L,1L,2L,5L,3L,7L,7L,1L,6L,4L,8L,8L,1L,9L,3L,2L,7L,2L,9L,8L,3L,8L,1L,0L,8L,0L,9L,7L,2L,0L,3L,0L,1L,0L,7L,0L,0L,9L,4L,2L,9L,6L,0L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010525Inst : IEnumerable<long>
{
public static readonly long[] Value=A010525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010525.Bytes);
public long this[int i]=>Value[i];

public static A010525Inst Instance=new A010525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010524
{
public static readonly long[] Value={ 8L,4L,8L,5L,2L,8L,1L,3L,7L,4L,2L,3L,8L,5L,7L,0L,2L,9L,2L,8L,1L,0L,1L,3L,2L,3L,4L,5L,2L,5L,8L,1L,8L,8L,4L,7L,1L,4L,1L,8L,0L,3L,1L,2L,5L,2L,2L,6L,1L,6L,8L,8L,4L,3L,9L,0L,6L,0L,0L,7L,8L,4L,2L,7L,9L,4L,4L,3L,9L,4L,8L,7L,0L,7L,7L,2L,6L,4L,2L,2L,3L,3L,1L,0L,2L,3L,2L,5L,2L,0L,5L,9L,6L,5L,8L,4L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010524Inst : IEnumerable<long>
{
public static readonly long[] Value=A010524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010524.Bytes);
public long this[int i]=>Value[i];

public static A010524Inst Instance=new A010524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010523
{
public static readonly long[] Value={ 8L,4L,2L,6L,1L,4L,9L,7L,7L,3L,1L,7L,6L,3L,5L,8L,6L,3L,0L,6L,3L,4L,1L,3L,9L,9L,0L,6L,2L,0L,2L,7L,3L,6L,0L,3L,1L,6L,0L,8L,0L,0L,2L,4L,0L,1L,5L,6L,0L,7L,5L,0L,0L,1L,3L,6L,6L,7L,8L,1L,1L,1L,2L,9L,3L,2L,7L,2L,2L,5L,5L,0L,2L,7L,5L,5L,2L,0L,3L,0L,5L,5L,4L,8L,5L,6L,9L,3L,5L,3L,7L,2L,9L,8L,9L,6L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010523Inst : IEnumerable<long>
{
public static readonly long[] Value=A010523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010523.Bytes);
public long this[int i]=>Value[i];

public static A010523Inst Instance=new A010523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010522
{
public static readonly long[] Value={ 8L,3L,6L,6L,6L,0L,0L,2L,6L,5L,3L,4L,0L,7L,5L,5L,4L,7L,9L,7L,8L,1L,7L,2L,0L,2L,5L,7L,8L,5L,1L,8L,7L,4L,8L,9L,3L,9L,2L,8L,1L,5L,3L,6L,9L,2L,9L,8L,6L,7L,2L,1L,9L,9L,8L,1L,1L,1L,9L,1L,5L,4L,3L,0L,8L,0L,4L,1L,8L,7L,7L,2L,5L,9L,4L,3L,1L,7L,0L,0L,9L,8L,3L,0L,8L,1L,4L,7L,1L,1L,9L,6L,4L,9L,5L,1L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010522Inst : IEnumerable<long>
{
public static readonly long[] Value=A010522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010522.Bytes);
public long this[int i]=>Value[i];

public static A010522Inst Instance=new A010522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010521
{
public static readonly long[] Value={ 8L,3L,0L,6L,6L,2L,3L,8L,6L,2L,9L,1L,8L,0L,7L,4L,8L,5L,2L,5L,8L,4L,2L,6L,2L,7L,4L,4L,9L,0L,7L,4L,9L,2L,0L,1L,0L,2L,3L,2L,2L,1L,4L,2L,4L,8L,9L,5L,5L,6L,5L,5L,7L,7L,9L,4L,3L,2L,1L,8L,8L,3L,6L,9L,0L,3L,7L,5L,8L,5L,0L,3L,3L,4L,2L,3L,1L,5L,1L,5L,7L,3L,8L,6L,7L,3L,9L,8L,5L,0L,8L,2L,3L,2L,3L,5L,7L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010521Inst : IEnumerable<long>
{
public static readonly long[] Value=A010521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010521.Bytes);
public long this[int i]=>Value[i];

public static A010521Inst Instance=new A010521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010520
{
public static readonly long[] Value={ 8L,2L,4L,6L,2L,1L,1L,2L,5L,1L,2L,3L,5L,3L,2L,1L,0L,9L,9L,6L,4L,2L,8L,1L,9L,7L,1L,1L,9L,4L,8L,1L,5L,4L,0L,5L,0L,2L,9L,4L,3L,9L,8L,4L,5L,0L,7L,4L,7L,2L,4L,0L,8L,6L,8L,7L,9L,7L,2L,6L,7L,1L,4L,6L,1L,8L,9L,9L,0L,8L,6L,9L,2L,6L,7L,5L,2L,4L,3L,1L,8L,7L,1L,7L,5L,7L,2L,7L,3L,0L,1L,6L,2L,1L,3L,6L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010520Inst : IEnumerable<long>
{
public static readonly long[] Value=A010520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010520.Bytes);
public long this[int i]=>Value[i];

public static A010520Inst Instance=new A010520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010519
{
public static readonly long[] Value={ 8L,1L,8L,5L,3L,5L,2L,7L,7L,1L,8L,7L,2L,4L,4L,9L,9L,6L,9L,9L,5L,3L,7L,0L,3L,7L,2L,4L,7L,3L,3L,9L,2L,9L,4L,5L,8L,8L,8L,0L,4L,8L,6L,8L,1L,5L,4L,9L,8L,0L,3L,9L,9L,6L,3L,0L,6L,6L,7L,1L,5L,2L,0L,2L,7L,2L,3L,6L,6L,7L,6L,1L,4L,4L,6L,1L,0L,9L,7L,9L,4L,5L,3L,4L,3L,9L,2L,4L,6L,7L,1L,6L,3L,7L,8L,6L,8L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010519Inst : IEnumerable<long>
{
public static readonly long[] Value=A010519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010519.Bytes);
public long this[int i]=>Value[i];

public static A010519Inst Instance=new A010519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010518
{
public static readonly long[] Value={ 8L,1L,2L,4L,0L,3L,8L,4L,0L,4L,6L,3L,5L,9L,6L,0L,3L,6L,0L,4L,5L,9L,8L,8L,3L,5L,6L,8L,2L,6L,6L,0L,4L,0L,3L,4L,8L,5L,0L,4L,2L,0L,4L,0L,8L,6L,7L,2L,5L,3L,1L,2L,8L,2L,7L,6L,5L,1L,5L,7L,5L,5L,9L,4L,5L,3L,2L,9L,1L,6L,8L,0L,2L,8L,4L,0L,6L,7L,2L,6L,9L,4L,9L,9L,9L,1L,5L,7L,6L,0L,2L,9L,4L,7L,9L,3L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010518Inst : IEnumerable<long>
{
public static readonly long[] Value=A010518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010518.Bytes);
public long this[int i]=>Value[i];

public static A010518Inst Instance=new A010518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010517
{
public static readonly long[] Value={ 8L,0L,6L,2L,2L,5L,7L,7L,4L,8L,2L,9L,8L,5L,4L,9L,6L,5L,2L,3L,6L,6L,6L,1L,3L,2L,3L,0L,3L,0L,3L,7L,7L,1L,1L,3L,1L,1L,3L,4L,3L,9L,6L,3L,0L,5L,6L,0L,8L,5L,7L,3L,3L,8L,7L,9L,3L,6L,5L,9L,2L,3L,8L,9L,2L,6L,3L,8L,7L,4L,9L,5L,1L,0L,2L,5L,6L,8L,8L,2L,0L,2L,9L,6L,0L,1L,5L,4L,2L,6L,6L,7L,1L,7L,2L,3L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010517Inst : IEnumerable<long>
{
public static readonly long[] Value=A010517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010517.Bytes);
public long this[int i]=>Value[i];

public static A010517Inst Instance=new A010517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010516
{
public static readonly long[] Value={ 7L,9L,3L,7L,2L,5L,3L,9L,3L,3L,1L,9L,3L,7L,7L,1L,7L,7L,1L,5L,0L,4L,8L,4L,7L,2L,6L,0L,9L,1L,7L,7L,8L,1L,2L,7L,7L,1L,3L,0L,7L,7L,7L,5L,4L,9L,2L,4L,7L,3L,5L,0L,5L,4L,1L,1L,0L,5L,0L,0L,3L,3L,7L,7L,6L,0L,3L,2L,0L,6L,4L,6L,9L,6L,9L,0L,8L,5L,0L,8L,8L,3L,2L,8L,1L,1L,7L,8L,6L,5L,9L,4L,2L,3L,6L,3L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010516Inst : IEnumerable<long>
{
public static readonly long[] Value=A010516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010516.Bytes);
public long this[int i]=>Value[i];

public static A010516Inst Instance=new A010516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010515
{
public static readonly long[] Value={ 7L,8L,7L,4L,0L,0L,7L,8L,7L,4L,0L,1L,1L,8L,1L,1L,0L,1L,9L,6L,8L,5L,0L,3L,4L,4L,4L,8L,8L,1L,2L,0L,0L,7L,8L,6L,3L,6L,8L,1L,0L,8L,6L,1L,2L,2L,0L,2L,0L,8L,5L,3L,7L,9L,4L,5L,9L,8L,8L,4L,2L,5L,5L,0L,3L,1L,3L,7L,6L,0L,8L,4L,6L,8L,1L,7L,6L,9L,8L,0L,5L,6L,9L,2L,6L,1L,9L,1L,3L,5L,1L,2L,4L,8L,7L,4L,6L,8L,8L,9L,9L,2L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010515Inst : IEnumerable<long>
{
public static readonly long[] Value=A010515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010515.Bytes);
public long this[int i]=>Value[i];

public static A010515Inst Instance=new A010515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010514
{
public static readonly long[] Value={ 7L,8L,1L,0L,2L,4L,9L,6L,7L,5L,9L,0L,6L,6L,5L,4L,3L,9L,4L,1L,2L,9L,7L,2L,2L,7L,3L,5L,7L,5L,9L,1L,0L,1L,4L,1L,3L,5L,6L,8L,3L,0L,5L,1L,3L,6L,6L,4L,8L,5L,6L,3L,3L,0L,0L,1L,7L,7L,2L,4L,3L,7L,6L,0L,1L,9L,0L,7L,8L,5L,5L,8L,8L,9L,3L,6L,7L,2L,7L,0L,5L,4L,4L,2L,5L,4L,3L,3L,0L,5L,2L,2L,6L,7L,0L,0L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010514Inst : IEnumerable<long>
{
public static readonly long[] Value=A010514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010514.Bytes);
public long this[int i]=>Value[i];

public static A010514Inst Instance=new A010514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010513
{
public static readonly long[] Value={ 7L,7L,4L,5L,9L,6L,6L,6L,9L,2L,4L,1L,4L,8L,3L,3L,7L,7L,0L,3L,5L,8L,5L,3L,0L,7L,9L,9L,5L,6L,4L,7L,9L,9L,2L,2L,1L,6L,6L,5L,8L,4L,3L,4L,1L,0L,5L,8L,3L,1L,8L,1L,6L,5L,3L,1L,7L,5L,1L,4L,7L,5L,3L,2L,2L,2L,6L,9L,6L,6L,1L,8L,3L,8L,7L,3L,9L,5L,8L,0L,6L,7L,0L,3L,8L,5L,7L,4L,7L,5L,3L,7L,1L,7L,3L,4L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010513Inst : IEnumerable<long>
{
public static readonly long[] Value=A010513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010513.Bytes);
public long this[int i]=>Value[i];

public static A010513Inst Instance=new A010513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010512
{
public static readonly long[] Value={ 7L,6L,8L,1L,1L,4L,5L,7L,4L,7L,8L,6L,8L,6L,0L,8L,1L,7L,5L,7L,6L,9L,6L,8L,7L,0L,2L,1L,7L,3L,1L,3L,7L,2L,4L,7L,3L,0L,6L,2L,4L,5L,1L,0L,7L,7L,6L,1L,4L,8L,8L,3L,9L,2L,8L,0L,2L,4L,7L,3L,6L,4L,8L,3L,9L,3L,5L,5L,4L,1L,6L,5L,7L,9L,9L,2L,7L,0L,9L,8L,5L,1L,8L,5L,6L,0L,4L,7L,7L,2L,7L,9L,6L,1L,3L,7L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010512Inst : IEnumerable<long>
{
public static readonly long[] Value=A010512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010512.Bytes);
public long this[int i]=>Value[i];

public static A010512Inst Instance=new A010512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010511
{
public static readonly long[] Value={ 7L,6L,1L,5L,7L,7L,3L,1L,0L,5L,8L,6L,3L,9L,0L,8L,2L,8L,5L,6L,6L,1L,4L,1L,1L,0L,2L,7L,1L,5L,8L,3L,2L,3L,0L,0L,5L,3L,6L,0L,7L,0L,5L,5L,9L,2L,5L,4L,6L,5L,9L,8L,4L,6L,8L,9L,5L,0L,4L,8L,4L,2L,4L,0L,5L,2L,0L,3L,5L,2L,1L,5L,7L,3L,7L,3L,0L,0L,1L,2L,4L,4L,6L,4L,2L,2L,6L,9L,7L,1L,4L,3L,8L,7L,1L,5L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010511Inst : IEnumerable<long>
{
public static readonly long[] Value=A010511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010511.Bytes);
public long this[int i]=>Value[i];

public static A010511Inst Instance=new A010511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010510
{
public static readonly long[] Value={ 7L,5L,4L,9L,8L,3L,4L,4L,3L,5L,2L,7L,0L,7L,4L,9L,6L,9L,7L,2L,3L,6L,6L,8L,4L,8L,0L,6L,9L,4L,6L,1L,1L,7L,0L,5L,8L,2L,2L,2L,1L,9L,4L,7L,0L,4L,6L,2L,3L,3L,8L,0L,1L,3L,8L,2L,9L,8L,6L,2L,6L,9L,0L,5L,7L,1L,0L,7L,2L,1L,9L,5L,3L,9L,1L,7L,8L,1L,1L,1L,9L,5L,5L,8L,2L,4L,5L,2L,0L,7L,4L,1L,4L,7L,5L,2L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010510Inst : IEnumerable<long>
{
public static readonly long[] Value=A010510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010510.Bytes);
public long this[int i]=>Value[i];

public static A010510Inst Instance=new A010510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010509
{
public static readonly long[] Value={ 7L,4L,8L,3L,3L,1L,4L,7L,7L,3L,5L,4L,7L,8L,8L,2L,7L,7L,1L,1L,6L,7L,4L,9L,7L,4L,6L,4L,6L,3L,3L,0L,9L,8L,6L,0L,3L,5L,1L,2L,0L,3L,9L,6L,1L,5L,5L,5L,7L,4L,5L,3L,8L,9L,2L,6L,0L,7L,4L,9L,0L,9L,3L,4L,6L,4L,0L,0L,7L,0L,3L,1L,2L,6L,1L,3L,8L,7L,8L,0L,5L,5L,9L,5L,3L,6L,1L,9L,7L,9L,0L,3L,8L,8L,7L,5L,9L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010509Inst : IEnumerable<long>
{
public static readonly long[] Value=A010509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010509.Bytes);
public long this[int i]=>Value[i];

public static A010509Inst Instance=new A010509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010508
{
public static readonly long[] Value={ 7L,4L,1L,6L,1L,9L,8L,4L,8L,7L,0L,9L,5L,6L,6L,2L,9L,4L,8L,7L,1L,1L,3L,9L,7L,4L,4L,0L,8L,0L,0L,7L,1L,3L,0L,6L,0L,9L,7L,9L,9L,0L,4L,3L,1L,9L,0L,9L,7L,5L,0L,1L,5L,9L,8L,7L,3L,2L,6L,2L,3L,2L,6L,4L,3L,4L,3L,8L,3L,0L,1L,8L,4L,3L,1L,3L,8L,5L,0L,2L,4L,2L,7L,5L,3L,0L,0L,9L,2L,1L,3L,1L,9L,5L,8L,2L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010508Inst : IEnumerable<long>
{
public static readonly long[] Value=A010508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010508.Bytes);
public long this[int i]=>Value[i];

public static A010508Inst Instance=new A010508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010507
{
public static readonly long[] Value={ 7L,3L,4L,8L,4L,6L,9L,2L,2L,8L,3L,4L,9L,5L,3L,4L,2L,9L,4L,5L,9L,1L,8L,5L,2L,2L,2L,4L,1L,1L,7L,6L,7L,4L,1L,7L,5L,8L,9L,7L,8L,4L,2L,4L,4L,1L,9L,7L,0L,0L,1L,0L,3L,8L,5L,2L,9L,8L,0L,7L,7L,7L,0L,1L,7L,5L,2L,8L,8L,1L,1L,3L,2L,3L,7L,1L,9L,4L,5L,0L,7L,9L,6L,1L,9L,5L,7L,8L,2L,9L,9L,3L,1L,3L,9L,2L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010507Inst : IEnumerable<long>
{
public static readonly long[] Value=A010507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010507.Bytes);
public long this[int i]=>Value[i];

public static A010507Inst Instance=new A010507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010506
{
public static readonly long[] Value={ 7L,2L,8L,0L,1L,0L,9L,8L,8L,9L,2L,8L,0L,5L,1L,8L,2L,7L,1L,0L,9L,7L,3L,0L,2L,4L,9L,1L,5L,2L,7L,0L,3L,2L,7L,9L,3L,7L,7L,7L,6L,6L,9L,6L,8L,2L,5L,7L,6L,4L,7L,7L,4L,3L,8L,3L,7L,8L,1L,8L,1L,7L,9L,1L,2L,8L,4L,1L,1L,5L,7L,3L,8L,6L,2L,4L,9L,0L,5L,1L,8L,3L,3L,2L,9L,5L,7L,9L,4L,0L,9L,0L,8L,0L,9L,2L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010506Inst : IEnumerable<long>
{
public static readonly long[] Value=A010506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010506.Bytes);
public long this[int i]=>Value[i];

public static A010506Inst Instance=new A010506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010505
{
public static readonly long[] Value={ 7L,2L,1L,1L,1L,0L,2L,5L,5L,0L,9L,2L,7L,9L,7L,8L,5L,8L,6L,2L,3L,8L,4L,4L,2L,5L,3L,4L,9L,4L,0L,9L,9L,1L,8L,9L,2L,5L,0L,2L,5L,9L,3L,1L,4L,7L,6L,9L,0L,4L,9L,2L,4L,2L,5L,4L,2L,0L,9L,0L,6L,1L,1L,2L,4L,5L,4L,3L,3L,3L,8L,9L,6L,5L,8L,6L,0L,2L,0L,8L,9L,0L,4L,0L,9L,2L,3L,8L,1L,6L,4L,0L,3L,6L,9L,8L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010505Inst : IEnumerable<long>
{
public static readonly long[] Value=A010505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010505.Bytes);
public long this[int i]=>Value[i];

public static A010505Inst Instance=new A010505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010504
{
public static readonly long[] Value={ 7L,1L,4L,1L,4L,2L,8L,4L,2L,8L,5L,4L,2L,8L,4L,9L,9L,9L,7L,9L,9L,9L,3L,9L,9L,8L,1L,1L,3L,6L,7L,2L,6L,5L,2L,7L,8L,7L,6L,6L,1L,7L,1L,1L,5L,9L,9L,0L,2L,7L,3L,3L,8L,3L,3L,2L,0L,8L,4L,3L,0L,8L,8L,2L,7L,6L,5L,8L,2L,0L,4L,0L,6L,4L,4L,0L,0L,2L,1L,8L,8L,6L,2L,5L,8L,9L,8L,8L,2L,1L,3L,5L,3L,2L,8L,2L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010504Inst : IEnumerable<long>
{
public static readonly long[] Value=A010504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010504.Bytes);
public long this[int i]=>Value[i];

public static A010504Inst Instance=new A010504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010503
{
public static readonly long[] Value={ 7L,0L,7L,1L,0L,6L,7L,8L,1L,1L,8L,6L,5L,4L,7L,5L,2L,4L,4L,0L,0L,8L,4L,4L,3L,6L,2L,1L,0L,4L,8L,4L,9L,0L,3L,9L,2L,8L,4L,8L,3L,5L,9L,3L,7L,6L,8L,8L,4L,7L,4L,0L,3L,6L,5L,8L,8L,3L,3L,9L,8L,6L,8L,9L,9L,5L,3L,6L,6L,2L,3L,9L,2L,3L,1L,0L,5L,3L,5L,1L,9L,4L,2L,5L,1L,9L,3L,7L,6L,7L,1L,6L,3L,8L,2L,0L,7L,8L,6L,3L,6L,7L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010503Inst : IEnumerable<long>
{
public static readonly long[] Value=A010503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010503.Bytes);
public long this[int i]=>Value[i];

public static A010503Inst Instance=new A010503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010502
{
public static readonly long[] Value={ 6L,9L,2L,8L,2L,0L,3L,2L,3L,0L,2L,7L,5L,5L,0L,9L,1L,7L,4L,1L,0L,9L,7L,8L,5L,3L,6L,6L,0L,2L,3L,4L,8L,9L,4L,6L,7L,7L,7L,1L,2L,2L,1L,0L,1L,5L,2L,4L,1L,5L,2L,2L,5L,1L,2L,2L,2L,3L,2L,2L,7L,9L,1L,7L,8L,0L,7L,7L,3L,2L,0L,6L,7L,6L,3L,5L,2L,0L,0L,1L,4L,8L,3L,2L,4L,5L,8L,4L,7L,4L,7L,0L,2L,8L,9L,9L,4L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010502Inst : IEnumerable<long>
{
public static readonly long[] Value=A010502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010502.Bytes);
public long this[int i]=>Value[i];

public static A010502Inst Instance=new A010502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010501
{
public static readonly long[] Value={ 6L,8L,5L,5L,6L,5L,4L,6L,0L,0L,4L,0L,1L,0L,4L,4L,1L,2L,4L,9L,3L,5L,8L,7L,1L,4L,4L,9L,0L,8L,4L,8L,4L,8L,9L,6L,0L,4L,6L,0L,6L,4L,3L,4L,6L,1L,0L,0L,1L,3L,2L,6L,2L,7L,5L,4L,8L,5L,1L,0L,8L,1L,8L,5L,6L,7L,8L,5L,1L,7L,1L,1L,5L,1L,3L,6L,8L,1L,6L,9L,9L,9L,2L,2L,7L,3L,2L,5L,1L,4L,8L,5L,0L,0L,0L,6L,6L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010501Inst : IEnumerable<long>
{
public static readonly long[] Value=A010501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010501.Bytes);
public long this[int i]=>Value[i];

public static A010501Inst Instance=new A010501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010500
{
public static readonly long[] Value={ 6L,7L,8L,2L,3L,2L,9L,9L,8L,3L,1L,2L,5L,2L,6L,8L,1L,3L,9L,0L,6L,4L,5L,5L,6L,3L,2L,6L,6L,2L,5L,9L,6L,9L,1L,0L,5L,1L,9L,5L,7L,4L,8L,3L,2L,3L,9L,2L,3L,2L,8L,8L,2L,3L,2L,7L,5L,0L,2L,1L,9L,5L,8L,2L,0L,8L,0L,7L,2L,8L,2L,6L,3L,9L,8L,7L,1L,1L,2L,5L,8L,9L,8L,6L,2L,6L,4L,0L,9L,4L,0L,9L,3L,6L,3L,3L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010500Inst : IEnumerable<long>
{
public static readonly long[] Value=A010500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010500.Bytes);
public long this[int i]=>Value[i];

public static A010500Inst Instance=new A010500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010499
{
public static readonly long[] Value={ 6L,7L,0L,8L,2L,0L,3L,9L,3L,2L,4L,9L,9L,3L,6L,9L,0L,8L,9L,2L,2L,7L,5L,2L,1L,0L,0L,6L,1L,9L,3L,8L,2L,8L,7L,0L,6L,3L,2L,1L,8L,5L,5L,0L,7L,8L,8L,3L,4L,5L,7L,7L,1L,7L,2L,8L,1L,2L,6L,9L,1L,7L,3L,6L,2L,3L,1L,5L,6L,2L,7L,7L,6L,9L,1L,3L,4L,1L,4L,6L,9L,8L,2L,4L,3L,2L,4L,3L,2L,2L,5L,1L,3L,6L,3L,4L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010499Inst : IEnumerable<long>
{
public static readonly long[] Value=A010499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010499.Bytes);
public long this[int i]=>Value[i];

public static A010499Inst Instance=new A010499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010498
{
public static readonly long[] Value={ 6L,6L,3L,3L,2L,4L,9L,5L,8L,0L,7L,1L,0L,7L,9L,9L,6L,9L,8L,2L,2L,9L,8L,6L,5L,4L,7L,3L,3L,4L,1L,3L,7L,3L,3L,6L,7L,8L,5L,4L,1L,7L,7L,0L,9L,1L,1L,7L,8L,7L,0L,7L,1L,9L,4L,1L,1L,7L,3L,6L,4L,2L,9L,2L,2L,3L,2L,9L,6L,9L,2L,8L,5L,2L,1L,8L,0L,8L,7L,6L,9L,3L,4L,1L,7L,6L,8L,6L,7L,9L,8L,2L,5L,6L,5L,8L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010498Inst : IEnumerable<long>
{
public static readonly long[] Value=A010498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010498.Bytes);
public long this[int i]=>Value[i];

public static A010498Inst Instance=new A010498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010497
{
public static readonly long[] Value={ 6L,5L,5L,7L,4L,3L,8L,5L,2L,4L,3L,0L,2L,0L,0L,0L,6L,5L,2L,3L,4L,4L,1L,0L,9L,9L,9L,7L,6L,3L,6L,0L,0L,1L,6L,2L,7L,9L,2L,6L,9L,6L,6L,3L,1L,9L,8L,8L,3L,7L,8L,9L,7L,6L,9L,8L,6L,5L,4L,6L,0L,1L,0L,5L,5L,8L,5L,6L,5L,9L,8L,5L,3L,4L,8L,8L,5L,7L,5L,6L,3L,9L,3L,5L,5L,8L,0L,5L,2L,9L,0L,9L,6L,9L,6L,7L,8L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010497Inst : IEnumerable<long>
{
public static readonly long[] Value=A010497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010497.Bytes);
public long this[int i]=>Value[i];

public static A010497Inst Instance=new A010497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010496
{
public static readonly long[] Value={ 6L,4L,8L,0L,7L,4L,0L,6L,9L,8L,4L,0L,7L,8L,6L,0L,2L,3L,0L,9L,6L,5L,9L,6L,7L,4L,3L,6L,0L,8L,7L,9L,9L,6L,6L,5L,7L,7L,0L,5L,2L,0L,4L,3L,0L,7L,0L,5L,8L,3L,4L,6L,5L,4L,9L,7L,1L,1L,3L,5L,4L,3L,9L,7L,8L,0L,9L,6L,1L,7L,3L,7L,7L,8L,4L,4L,0L,4L,4L,3L,7L,1L,4L,0L,0L,3L,6L,0L,9L,0L,6L,6L,0L,5L,6L,1L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010496Inst : IEnumerable<long>
{
public static readonly long[] Value=A010496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010496.Bytes);
public long this[int i]=>Value[i];

public static A010496Inst Instance=new A010496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010495
{
public static readonly long[] Value={ 6L,4L,0L,3L,1L,2L,4L,2L,3L,7L,4L,3L,2L,8L,4L,8L,6L,8L,6L,4L,8L,8L,2L,1L,7L,6L,7L,4L,6L,2L,1L,8L,1L,3L,2L,6L,4L,5L,2L,0L,4L,2L,0L,1L,3L,2L,6L,2L,1L,0L,1L,8L,8L,8L,5L,5L,2L,9L,2L,7L,2L,6L,2L,6L,6L,6L,8L,1L,8L,2L,7L,5L,8L,1L,9L,6L,8L,7L,6L,0L,7L,4L,2L,8L,9L,3L,5L,4L,3L,0L,2L,2L,4L,9L,8L,6L,9L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010495Inst : IEnumerable<long>
{
public static readonly long[] Value=A010495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010495.Bytes);
public long this[int i]=>Value[i];

public static A010495Inst Instance=new A010495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010494
{
public static readonly long[] Value={ 6L,3L,2L,4L,5L,5L,5L,3L,2L,0L,3L,3L,6L,7L,5L,8L,6L,6L,3L,9L,9L,7L,7L,8L,7L,0L,8L,8L,8L,6L,5L,4L,3L,7L,0L,6L,7L,4L,3L,9L,1L,1L,0L,2L,7L,8L,6L,5L,0L,4L,3L,3L,6L,5L,3L,7L,1L,5L,0L,0L,9L,7L,0L,5L,5L,8L,5L,1L,8L,8L,8L,7L,7L,2L,7L,8L,4L,7L,6L,4L,4L,2L,6L,8L,8L,4L,9L,6L,2L,1L,6L,7L,5L,8L,6L,0L,0L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010494Inst : IEnumerable<long>
{
public static readonly long[] Value=A010494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010494.Bytes);
public long this[int i]=>Value[i];

public static A010494Inst Instance=new A010494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010477
{
public static readonly long[] Value={ 4L,5L,8L,2L,5L,7L,5L,6L,9L,4L,9L,5L,5L,8L,4L,0L,0L,0L,6L,5L,8L,8L,0L,4L,7L,1L,9L,3L,7L,2L,8L,0L,0L,8L,4L,8L,8L,9L,8L,4L,4L,5L,6L,5L,7L,6L,7L,6L,7L,9L,7L,1L,9L,0L,2L,6L,0L,7L,2L,4L,2L,1L,2L,3L,9L,0L,6L,8L,6L,8L,4L,2L,5L,5L,4L,7L,7L,7L,0L,8L,8L,6L,6L,0L,4L,3L,6L,1L,5L,5L,9L,4L,9L,3L,4L,4L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010477Inst : IEnumerable<long>
{
public static readonly long[] Value=A010477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010477.Bytes);
public long this[int i]=>Value[i];

public static A010477Inst Instance=new A010477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010476
{
public static readonly long[] Value={ 4L,4L,7L,2L,1L,3L,5L,9L,5L,4L,9L,9L,9L,5L,7L,9L,3L,9L,2L,8L,1L,8L,3L,4L,7L,3L,3L,7L,4L,6L,2L,5L,5L,2L,4L,7L,0L,8L,8L,1L,2L,3L,6L,7L,1L,9L,2L,2L,3L,0L,5L,1L,4L,4L,8L,5L,4L,1L,7L,9L,4L,4L,9L,0L,8L,2L,1L,0L,4L,1L,8L,5L,1L,2L,7L,5L,6L,0L,9L,7L,9L,8L,8L,2L,8L,8L,2L,8L,8L,1L,6L,7L,5L,7L,5L,6L,4L,5L,4L,9L,9L,3L,9L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010476Inst : IEnumerable<long>
{
public static readonly long[] Value=A010476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010476.Bytes);
public long this[int i]=>Value[i];

public static A010476Inst Instance=new A010476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010475
{
public static readonly long[] Value={ 4L,3L,5L,8L,8L,9L,8L,9L,4L,3L,5L,4L,0L,6L,7L,3L,5L,5L,2L,2L,3L,6L,9L,8L,1L,9L,8L,3L,8L,5L,9L,6L,1L,5L,6L,5L,9L,1L,3L,7L,0L,0L,3L,9L,2L,5L,2L,3L,2L,4L,4L,4L,9L,3L,6L,8L,9L,0L,3L,4L,4L,1L,3L,8L,1L,5L,9L,5L,5L,7L,3L,2L,8L,2L,0L,3L,1L,5L,8L,0L,8L,5L,6L,5L,6L,1L,5L,9L,1L,5L,5L,8L,5L,1L,9L,4L,4L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010475Inst : IEnumerable<long>
{
public static readonly long[] Value=A010475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010475.Bytes);
public long this[int i]=>Value[i];

public static A010475Inst Instance=new A010475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010474
{
public static readonly long[] Value={ 4L,2L,4L,2L,6L,4L,0L,6L,8L,7L,1L,1L,9L,2L,8L,5L,1L,4L,6L,4L,0L,5L,0L,6L,6L,1L,7L,2L,6L,2L,9L,0L,9L,4L,2L,3L,5L,7L,0L,9L,0L,1L,5L,6L,2L,6L,1L,3L,0L,8L,4L,4L,2L,1L,9L,5L,3L,0L,0L,3L,9L,2L,1L,3L,9L,7L,2L,1L,9L,7L,4L,3L,5L,3L,8L,6L,3L,2L,1L,1L,1L,6L,5L,5L,1L,1L,6L,2L,6L,0L,2L,9L,8L,2L,9L,2L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010474Inst : IEnumerable<long>
{
public static readonly long[] Value=A010474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010474.Bytes);
public long this[int i]=>Value[i];

public static A010474Inst Instance=new A010474Inst();

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